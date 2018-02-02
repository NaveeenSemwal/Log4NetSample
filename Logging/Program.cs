using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logging
{
    /// <summary>
    /// Step 1 :  Declare log4net.Config.XmlConfigurator in AssemblyInfo.cs
    /// Step 2 :  Define Configuration in App.config
    /// Step 3 : Declare an instance for log4net
    /// 
    /// 
    /// 
    /// Issue :  Need to place whole App.Config file in App.Config . Otherwise log are not creating 
    /// </summary>
    class Program
    {
        //Declare an instance for log4net
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            ImplementLoggingFuntion();
        }




        private static void ImplementLoggingFuntion()
        {
            Trace.CorrelationManager.ActivityId = Guid.Parse(Guid.NewGuid().ToString());

            Log.Fatal("Start log FATAL...");
            Console.WriteLine("Start log FATAL...");
           

            Log.Error("Start log ERROR...");
            Console.WriteLine("Start log ERROR...");
           

            Log.Warn("Start log WARN...");
            Console.WriteLine("Start log WARN...");
          

            Log.Info("Start log INFO...");
            Console.WriteLine("Start log INFO...");
           

            Log.Debug("Start log DEBUG...");
            Console.WriteLine("Start log DEBUG...");



          

            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }
    }
}
