using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RemoteWinPadServer.Network
{
    public class RemoteClient:ObservableObject
    {
        private Socket _socket;
        public RemoteClient(Socket socket)
        {
            this._socket = socket;
        }
    }
}
