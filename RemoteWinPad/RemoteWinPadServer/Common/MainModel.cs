using GalaSoft.MvvmLight;
using RemoteWinPadServer.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteWinPadServer.Common
{
    public class MainModel:ObservableObject
    {
        private RemoteServer _remoteServer;

        public RemoteServer RemoteServer
        {
            get { return _remoteServer; }
            set { Set(ref _remoteServer,value); }
        }
        public MainModel()
        {
            _remoteServer = new RemoteServer();
        }

        
    }
}
