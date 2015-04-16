using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ServiceLooper;

namespace BackgroundWorker
{
    public partial class Service1 : ServiceBase
    {
        readonly Looper looper = new Looper();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            looper.start();
        }

        protected override void OnStop()
        {
            looper.stop();
        }

        
    }
}
