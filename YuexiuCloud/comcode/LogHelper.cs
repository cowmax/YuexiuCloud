using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logging
{
    public class LogHelper
    {
        public static void initLog4Net()
        {
            // Initialize log4net.
            // Only be needed by MVC website
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void writeline(Type t, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error("Error", ex);
        }

        public static void writeline(Type t, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error(msg);
        }

        public static void info(string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("YueXiu.Cloud");
            log.Info(msg);
        }
        public static void error(string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("YueXiu.Cloud");
            log.Error(msg);
        }
    }
}