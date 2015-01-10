using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using RemoteWinPadLib.Data;
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

        private bool _isListening;

        public bool IsListening
        {
            get { return _isListening; }
            set { Set(ref _isListening, value); }
        }
        #endregion
        

        public RemoteServer()
        {
            
            _clientList = new ObservableCollection<RemoteClient>();
            _isListening = false;
        }

        public async Task ListenAsync(IPAddress address, int port)
        {
            this.Port = port;
            this._address = address;
            _listener = new TcpListener(address, port);

            _listener.Start();
            IsListening = true;
            while (true)
            {
                var client = await _listener.AcceptTcpClientAsync();
                if (!IsListening)
                {
                    break;
                }
                else
                {
                    ClientList.Add(new RemoteClient(client));
                }
                
            }
        }

        public void StopListener()
        {
            IsListening = false;
           
            _listener.Stop();
        }

        public async Task StartReceiveClients(Action<PadData> onReceive)
        {
            foreach (RemoteClient client in _clientList)
            {
                await client.OpenAsync((string message) =>
                {
                    PadData data = (PadData)JsonConvert.DeserializeObject(message);
                    onReceive(data);
                });
            }
        }

        public void StopReceiveClients()
        {
            foreach (RemoteClient client in _clientList)
            {
                client.Close();
            }
        }

        
    }
}
