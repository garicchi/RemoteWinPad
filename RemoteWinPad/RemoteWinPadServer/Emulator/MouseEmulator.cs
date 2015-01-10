using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RemoteWinPadServer.Emulator
{
    public struct POINT
    {
        public int X;
        public int Y;

    }
    public class MouseEmulator:ObservableObject
    {
        
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        public MouseEmulator()
        {

        }

        public void Move(int deltaX, int deltaY)
        {
            POINT point = new POINT();
            GetCursorPos(out point);

            point.X += deltaX;
            point.Y += deltaY;

            SetCursorPos(point.X,point.Y);
        }
    }
}
