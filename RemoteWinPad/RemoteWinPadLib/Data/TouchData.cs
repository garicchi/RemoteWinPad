using RemoteWinPadLib.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RemoteWinPadLib.Data
{
    [DataContract]
    public class TouchData
    {
        [DataMember]
        public TouchDataType TouchDataType { get;set;}
        [DataMember]
        public int X_Delta { get; set; }
        [DataMember]
        public int Y_Delta { get; set; }

        [DataMember]
        public TouchData()
        {

        }
    }
}
