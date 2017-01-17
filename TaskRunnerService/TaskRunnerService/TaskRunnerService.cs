using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace TaskRunnerService
{
    public partial class TaskRunnerService : ServiceBase
    {
        Timer timer = null;
        public TaskRunnerService()
        {
            InitializeComponent();
        }        

        protected override void OnStart(string[] args)
        {
            timer = new Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
            timer.Start();
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            try
            {

            }   
            catch(Exception ex)
            {

            }    
        }

        protected override void OnStop()
        {
            timer.Stop();
            timer.Enabled = false;
            timer.Dispose();          
        }
    }
}
