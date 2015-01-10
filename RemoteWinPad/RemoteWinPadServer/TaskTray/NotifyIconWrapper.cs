using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RemoteWinPadServer.TaskTray
{
    public partial class NotifyIconWrapper : Component
    {
        private MainWindow _mainWindow;

        public NotifyIconWrapper()
        {
            InitializeComponent();

            Initialize();
        }

        public NotifyIconWrapper(IContainer container)
        {

            container.Add(this);

            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _mainWindow = new MainWindow();
            toolStrip_setting.Click += (s, e) =>
            {
                if (_mainWindow.WindowState == WindowState.Minimized)
                {
                    _mainWindow.IsShow = true;
                   
                    _mainWindow.WindowState = WindowState.Normal;
                    _mainWindow.ShowInTaskbar = true;
                }
                _mainWindow.Show();
                _mainWindow.Activate();
                
            };

            toolStrip_exit.Click += (s, e) =>
            {
                _mainWindow.Close();

                App.Current.Shutdown();
            };
        }
    }
}
