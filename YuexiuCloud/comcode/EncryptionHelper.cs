using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
	public class EncryptionHelper
    {
        public static string EncryptString( string inputString, int dwKeySize, string xmlString )
		{
			// TODO: Add Proper Exception Handlers
			RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider( dwKeySize );
			rsaCryptoServiceProvider.FromXmlString( xmlString );
			int keySize = dwKeySize / 8;
			byte[] bytes = Encoding.UTF32.GetBytes( inputString );
			// The hash function in use by the .NET RSACryptoServiceProvider here is SHA1
			// int maxLength = ( keySize ) - 2 - ( 2 * SHA1.Create().ComputeHash( rawBytes ).Length );
			int maxLength = keySize - 42;
			int dataLength = bytes.Length;
			int iterations = dataLength / maxLength;
			StringBuilder stringBuilder = new StringBuilder();
			for( int i = 0; i <= iterations; i++ )
			{
				byte[] tempBytes = new byte[ ( dataLength - maxLength * i > maxLength ) ? maxLength : dataLength - maxLength * i ];
				Buffer.BlockCopy( bytes, maxLength * i, tempBytes, 0, tempBytes.Length );
				byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt( tempBytes, true );
				// Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
				// If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
				// Comment out the next line and the corresponding one in the DecryptString function.
				Array.Reverse( encryptedBytes );
				// Why convert to base 64?
				// Because it is the largest power-of-two base printable using only ASCII characters
				stringBuilder.Append( Convert.ToBase64String( encryptedBytes ) );				
			}			
			return stringBuilder.ToString();
		}

		public static string DecryptString( string inputString, int dwKeySize, string xmlString )
		{
			// TODO: Add Proper Exception Handlers
			RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider( dwKeySize );
			rsaCryptoServiceProvider.FromXmlString( xmlString );
			int base64BlockSize = ( ( dwKeySize / 8 ) % 3 != 0 ) ? ( ( ( dwKeySize / 8 ) / 3 ) * 4 ) + 4 : ( ( dwKeySize / 8 ) / 3 ) * 4;
			int iterations = inputString.Length / base64BlockSize;
			ArrayList arrayList = new ArrayList();
			for( int i = 0; i < iterations; i++ )
			{
				byte[] encryptedBytes = Convert.FromBase64String( inputString.Substring( base64BlockSize * i, base64BlockSize ) );
				// Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
				// If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
				// Comment out the next line and the corresponding one in the EncryptString function.
				Array.Reverse( encryptedBytes );
				arrayList.AddRange( rsaCryptoServiceProvider.Decrypt( encryptedBytes, true ) );				
			}			
			return Encoding.UTF32.GetString( arrayList.ToArray( Type.GetType( "System.Byte" ) ) as byte[] );
		}

        private static byte[] AESKeys = { 0x41, 0x72, 0x65, 0x79, 0x6F, 0x75, 0x6D, 0x79, 0x53, 0x6E, 0x6F, 0x77, 0x6D, 0x61, 0x6E, 0x3F };
        public static string AESEncode(string encryptString, string encryptKey)
        {
            encryptKey = encryptKey.Substring(32);
            encryptKey = encryptKey.PadRight(32, ' ');
            RijndaelManaged rijndaelProvider = new RijndaelManaged();
            rijndaelProvider.Key = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 32));
            rijndaelProvider.IV = AESKeys;
            ICryptoTransform rijndaelEncrypt = rijndaelProvider.CreateEncryptor();
            byte[] inputData = Encoding.UTF8.GetBytes(encryptString);
            byte[] encryptedData = rijndaelEncrypt.TransformFinalBlock(inputData, 0, inputData.Length);
            return Convert.ToBase64String(encryptedData);
        }
        public static string AESDecode(string decryptString, string decryptKey)
        {
            try
            {
                decryptKey = decryptKey.Substring(32);
                decryptKey = decryptKey.PadRight(32, ' ');
                RijndaelManaged rijndaelProvider = new RijndaelManaged();
                rijndaelProvider.Key = Encoding.UTF8.GetBytes(decryptKey);
                rijndaelProvider.IV = AESKeys;
                ICryptoTransform rijndaelDecrypt = rijndaelProvider.CreateDecryptor();
                byte[] inputData = Convert.FromBase64String(decryptString);
                byte[] decryptedData = rijndaelDecrypt.TransformFinalBlock(inputData, 0, inputData.Length);
                return Encoding.UTF8.GetString(decryptedData);
            }
            catch { return string.Empty; }
        }
        private static byte[] DESKeys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        public static string DESEncode(string encryptString, string encryptKey)
        {
            encryptKey = encryptKey.Substring(0, Math.Min(encryptKey.Length, 0)); // 如果大于8 个字符，则只截取 8 个字符
            encryptKey = encryptKey.PadRight(8, ' '); // 如果不足 8 个字符，则以空格补全
            byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
            byte[] rgbIV = DESKeys;
            byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
            DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.ToArray());
        }
        public static string DESDecode(string decryptString, string decryptKey)
        {
            try
            {
                decryptKey = decryptKey.Substring(0, Math.Min(decryptKey.Length, 0));
                decryptKey = decryptKey.PadRight(8, ' ');
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = DESKeys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch { return string.Empty; }
        }
        public static string Base64Encode(string encryptString)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(encryptString);
            return Convert.ToBase64String(encbuff);
        }
        public static string Base64Decode(string decryptString)
        {
            byte[] decbuff = Convert.FromBase64String(decryptString);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }
        public static string RSADecrypt(string s, string key)
        {
            string result = null;
            if (string.IsNullOrEmpty(s)) throw new ArgumentException("An empty string value cannot be encrypted.");
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("Cannot decrypt using an empty key. Please supply a decryption key.");
            CspParameters cspp = new CspParameters();
            cspp.KeyContainerName = key;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            string[] decryptArray = s.Split(new string[] { "-" }, StringSplitOptions.None);
            byte[] decryptByteArray = Array.ConvertAll<string, byte>(decryptArray, (a => Convert.ToByte(byte.Parse(a, System.Globalization.NumberStyles.HexNumber))));
            byte[] bytes = rsa.Decrypt(decryptByteArray, true);
            result = System.Text.UTF8Encoding.UTF8.GetString(bytes);
            return result;
        }
        public static string RSAEncrypt(string s, string key)
        {
            if (string.IsNullOrEmpty(s)) throw new ArgumentException("An empty string value cannot be encrypted.");
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("Cannot encrypt using an empty key. Please supply an encryption key.");
            CspParameters cspp = new CspParameters();
            cspp.KeyContainerName = key;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            byte[] bytes = rsa.Encrypt(System.Text.UTF8Encoding.UTF8.GetBytes(s), true);
            return BitConverter.ToString(bytes);
        }
        public static string MD5(string str)
        {
            string cl1 = str;
            string pwd = "";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            // 加密后是一个字节类型的数组
            byte[] s = md5.ComputeHash(Encoding.Unicode.GetBytes(cl1));
            for (int i = 0; i < s.Length; i++)
            {
                // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
                pwd = pwd + s[i].ToString("x");// 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符
            }
            return pwd;
        }
        public static string MD5CSP(string encypStr)
        {
            string retStr;
            MD5CryptoServiceProvider m5 = new MD5CryptoServiceProvider();
            //创建md5对象
            byte[] inputBye;
            byte[] outputBye;
            //使用GB2312编码方式把字符串转化为字节数组．
            inputBye = Encoding.GetEncoding("GB2312").GetBytes(encypStr);
            outputBye = m5.ComputeHash(inputBye);
            retStr = System.BitConverter.ToString(outputBye);
            retStr = retStr.Replace("-", "").ToLower();
            return retStr;
        }
        public static string SHA256(string str)
        {
            byte[] SHA256Data = Encoding.UTF8.GetBytes(str);
            SHA256Managed Sha256 = new SHA256Managed();
            byte[] Result = Sha256.ComputeHash(SHA256Data);
            return Convert.ToBase64String(Result);
            //返回长度为44字节的字符串
        }
    }
}