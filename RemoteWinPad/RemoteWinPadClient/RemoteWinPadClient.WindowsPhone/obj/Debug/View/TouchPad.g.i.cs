﻿

#pragma checksum "C:\Users\Ryota\Projects\RemoteWinPad\RemoteWinPad\RemoteWinPadClient\RemoteWinPadClient.Shared\View\TouchPad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FDD78BD3491EA53306572D7D8142E67D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemoteWinPadClient.View
{
    partial class TouchPad : global::Windows.UI.Xaml.Controls.UserControl
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid gridLeftButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid gridRightButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Canvas canvasPad; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///View/TouchPad.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            gridLeftButton = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("gridLeftButton");
            gridRightButton = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("gridRightButton");
            canvasPad = (global::Windows.UI.Xaml.Controls.Canvas)this.FindName("canvasPad");
        }
    }
}


