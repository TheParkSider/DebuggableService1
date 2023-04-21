using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace DebuggableService2
{
    public partial class Service1 : ServiceBase
    {
        Timer _timer;
        public Service1()
        {
            InitializeComponent();
            _timer = new Timer(300);
            _timer.Elapsed += (_, e) => { Debug.WriteLine("{0:HH:mm:ss}", e.SignalTime); };
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        protected override void OnStart(string[] args)
        {
            Debug.WriteLine("Service Started.");
        }

        protected override void OnStop()
        {
            Debug.WriteLine("Service Stopped.");
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
