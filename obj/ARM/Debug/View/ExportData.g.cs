﻿

#pragma checksum "C:\Users\etienne\Documents\Visual Studio 2013\Projects\timesheet\timesheet\View\ExportData.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "69EB3F3913C89A1ABA470BCAB211A54E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace timesheet.View
{
    partial class ExportData : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 51 "..\..\..\View\ExportData.xaml"
                ((global::Microsoft.Advertising.Mobile.UI.AdControl)(target)).ErrorOccurred += this.error_ads;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 53 "..\..\..\View\ExportData.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SendByMail_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 54 "..\..\..\View\ExportData.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SaveOneDrive_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 67 "..\..\..\View\ExportData.xaml"
                ((global::Microsoft.Advertising.Mobile.UI.AdControl)(target)).ErrorOccurred += this.error_ads;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


