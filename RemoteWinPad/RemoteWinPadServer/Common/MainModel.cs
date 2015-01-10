using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteWinPadServer.Common
{
    public class MainModel:ObservableObject
    {
        private string _sample;

        public string Sample
        {
            get { return _sample; }
            set { Set(ref _sample,value); }
        }
        public MainModel()
        {
            Sample = "moge";
        }

        
    }
}
