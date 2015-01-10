using RemoteWinPadServer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RemoteWinPadServer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        struct POINT
        {
            public int X;
            public int Y;

        }
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        private ViewModelLocator _locator;

        private bool _isShow;

        public bool IsShow
        {
            get { return _isShow; }
            set { _isShow = value; }
        }
        
        public MainWindow()
        {
            InitializeComponent();

            this.Closing += (s, e) =>
            {
                e.Cancel = true;
                IsShow = false;
               
                this.WindowState = WindowState.Minimized;
                this.ShowInTaskbar = false;
            };

            _locator=new ViewModelLocator();
            this.DataContext = _locator.Main;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            POINT pos = new POINT();
            
            //GetCursorPos(out pos);
            //SetCursorPos(100,100);
        }


        
    }
}
