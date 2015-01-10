using GalaSoft.MvvmLight;
using RemoteWinPadLib.Data;
using RemoteWinPadLib.Type;
using RemoteWinPadServer.Emulator;
using RemoteWinPadServer.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        private MouseEmulator _mouseEmulator;

        public MouseEmulator MouseEmulator
        {
            get { return _mouseEmulator; }
            set { Set(ref _mouseEmulator,value); }
        }

        int _port;
        
        public MainModel()
        {
            _remoteServer = new RemoteServer();
            _mouseEmulator= new MouseEmulator();
            _port = 500;
        }

        public async Task ServerListenAsync()
        {
            IPAddress address = Dns.GetHostAddresses(Dns.GetHostName()).First();
            await _remoteServer.ListenAsync(address,_port);
        }

        public void ServerListenStop()
        {
            _remoteServer.StopListener();
        }

        public async Task StartClients()
        {
            await _remoteServer.StartReceiveClients((padData) =>
            {
                switch(padData.PadDataType){
                    case PadDataType.Touch:
                        DecodeTouchData(padData.TouchData);
                        break;
                }
            });
        }

        public void StopClients()
        {
            _remoteServer.StopReceiveClients();
        }

        private void DecodeTouchData(TouchData data)
        {
            switch (data.TouchDataType)
            {
                case TouchDataType.Move:
                    _mouseEmulator.Move(data.X_Delta,data.Y_Delta);
                    break;
            }
        }

        
    }
}
