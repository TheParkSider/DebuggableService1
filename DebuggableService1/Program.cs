using System.ServiceProcess;
using System.Threading;

namespace DebuggableService1
{
    internal static class Program
    {
        static void Main()
        {
            var service = new Service1();
            if (System.Environment.UserInteractive)
            {
                var wh = new EventWaitHandle(false, EventResetMode.AutoReset, "StopService");
                service.StartDebug(null);
                wh.WaitOne();
                service.StopDebug();
            }
            else
            {
                ServiceBase.Run(service);
            }
        }
    }
}
