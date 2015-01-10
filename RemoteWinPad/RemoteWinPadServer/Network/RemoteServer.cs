using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RemoteWinPadServer.Network
{
    public class RemoteServer:ObservableObject
    {

        #region PrivateMember

        private TcpListener _listener;

        private IPAddress _address;
        #endregion

        #region PublicProperty
        private int _port;

        public int Port
        {
            get { return _port; }
            set { Set(ref _port, value); }
        }

        private ObservableCollection<RemoteClient> _clientList;

        public ObservableCollection<RemoteClient> ClientList
        {
            get { return _clientList; }
            set { Set(ref _clientList,value); }
        }
        #endregion
        

        public RemoteServer(IPAddress address,int port)
        {
            this.Port=port;
            this._address=address;
            _listener = new TcpListener(address,port);
            _clientList = new ObservableCollection<RemoteClient>();
        }

        public async Task ListenAsync()
        {
            _listener.Start();
            while (true)
            {
                Socket socket = await _listener.AcceptSocketAsync();
                ClientList.Add(new RemoteClient(socket));
            }
        }

        public void Stop()
        {
            _listener.Stop();
        }
    }
}
