using System;
using System.ServiceProcess;

namespace DebuggableService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public void StartDebug(string[] args) => OnStart(args);
        public void StopDebug() => OnStop();

        protected override void OnStart(string[] args)
        {
            Console.WriteLine("Service Started.");
        }

        protected override void OnStop()
        {
            Console.WriteLine("Service Stopped.");
        }
    }
}