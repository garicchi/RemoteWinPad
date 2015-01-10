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
    public class PadData
    {
        [DataMember]
        public PadDataType PadDataType { get; set; }
        [DataMember]
        public TouchData TouchData { get; set; }
    }
}
