using RemoteWinPadServer.TaskTray;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RemoteWinPadServer
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private NotifyIconWrapper _wrapper;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            _wrapper = new NotifyIconWrapper();
        }

        

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            _wrapper.Dispose();
        }
    }
}
