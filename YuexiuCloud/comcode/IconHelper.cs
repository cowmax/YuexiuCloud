using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logging;

namespace YuexiuCloud
{
    class IconHelper
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }
        // 调用Windows API 获取指定文件的信息
        [DllImport("Shell32.dll", EntryPoint = "SHGetFileInfo", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

        [DllImport("Shell32", CharSet = CharSet.Auto)]
        public static extern int ExtractIconEx(string lpszFile, int nIconIndex, IntPtr[] phIconLarge, IntPtr[] phIconSmall, int nIcons);

        // 调用Windows API 销毁指定的 icon 资源
        [DllImport("User32.dll", EntryPoint = "DestroyIcon")]
        public static extern int DestroyIcon(IntPtr hIcon);

        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0;
        public const uint SHGFI_SMALLICON = 0x1;
        public const uint SHGFI_USEFILEATTRIBUTES = 0x10;

        static Icon GetFileIcon(string fileName, bool isLargeIcon)
        {
            //  System.Drawing.Icon.ExtractAssociatedIcon() --  具有相同的功能
            SHFILEINFO shfi = new SHFILEINFO();
            IntPtr hI;

            if (isLargeIcon)
                hI = SHGetFileInfo(fileName, 0, ref shfi, (uint)Marshal.SizeOf(shfi), SHGFI_ICON | SHGFI_USEFILEATTRIBUTES | SHGFI_LARGEICON);
            else
                hI = SHGetFileInfo(fileName, 0, ref shfi, (uint)Marshal.SizeOf(shfi), SHGFI_ICON | SHGFI_USEFILEATTRIBUTES | SHGFI_SMALLICON);
            Icon icon = Icon.FromHandle(shfi.hIcon).Clone() as Icon;
            DestroyIcon(shfi.hIcon);
            return icon;
        }
        /// <summary>
        /// 从指定的文件中提取指定数量的图标
        /// </summary>
        /// <param name="filePath">补提取图标的文件的路径</param>
        /// <param name="large">large = true, 提取大图标， 否则提取小图标</param>
        /// <param name="idx">将提取的图标的起始位置</param>
        /// <param name="iCount">将提取的图标数量</param>
        /// <returns>返回包含图标的 ImageList 对象</returns>
        public static ImageList ExtractIconFromExe(string filePath, bool large, int idx=0, int iCount=1)
        {
            ImageList imageList = new ImageList();
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            IntPtr[] largeIcons=null, smallIcons=null;  //存放大/小图标的指针数组  

            try
            {
                //第一步：获取程序中的图标数  
                int iconCount = ExtractIconEx(filePath, -1, null, null, 0);
                iconCount = (iCount > 0 && iCount <= iconCount) ? iCount : iconCount;
                //第二步：创建存放大/小图标的空间  
                largeIcons = new IntPtr[iconCount];
                smallIcons = new IntPtr[iconCount];
                //第三步：抽取所有的大小图标保存到largeIcons和smallIcons中  
                ExtractIconEx(filePath, idx, largeIcons, smallIcons, iconCount);
                //第四步：显示抽取的图标
                for (int i = 0; i < iconCount; i++)
                {
                    if (large)
                    {
                        imageList.Images.Add(Icon.FromHandle(largeIcons[i])); //图标添加进imageList中  
                    }
                    else
                    {
                        imageList.Images.Add(Icon.FromHandle(smallIcons[i]));
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.error("提取系统图标失败： " + ex.Message);
            }
            finally
            {
                // RELEASE RESOURCES
                foreach (IntPtr ptr in largeIcons)
                    if (ptr != IntPtr.Zero)
                        DestroyIcon(ptr);

                foreach (IntPtr ptr in smallIcons)
                    if (ptr != IntPtr.Zero)
                        DestroyIcon(ptr);
            }
            return imageList;
        }

    }
}