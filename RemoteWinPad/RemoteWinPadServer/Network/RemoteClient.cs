using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RemoteWinPadServer.Network
{
    public class RemoteClient:ObservableObject
    {
        private TcpClient _client;

        private NetworkStream _stream;

        private bool _isListening;

        public bool IsListening
        {
            get { return _isListening; }
            set { this.Set(ref _isListening, value); }
        }
        public RemoteClient(TcpClient client)
        {
            this._client = client;
            _stream = this._client.GetStream();
            IsListening = false;
            
        }

        public async Task OpenAsync(Action<string> receiveDataCallback)
        {
            IsListening = true;
            byte[] buffer=new byte[sizeof(char)];
            string resultStr = "";
            do
            {
                await _stream.ReadAsync(buffer,0,sizeof(char));
                // \0がくるまで文字列を追加し続ける
                if (Encoding.UTF8.GetString(buffer, 0, sizeof(char)).First() == '\0')
                {
                    receiveDataCallback(resultStr);
                    resultStr = "";
                }
                else
                {
                    resultStr += Encoding.UTF8.GetString(buffer, 0, sizeof(char));
                }
            } while (IsListening);
        }

        public void Close()
        {
            IsListening = false;
            _client.Close();
        }
    }
}
