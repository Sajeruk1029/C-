﻿#pragma checksum "C:\Users\Sajeruk\source\repos\Player\Player\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FF34E05B95031FD59EDC56FD47DD8392"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Player
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 18
                {
                    this.List = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 3: // MainPage.xaml line 40
                {
                    this.ScrollPlaylist = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 4: // MainPage.xaml line 47
                {
                    this.Player = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.Player).MediaEnded += this.Player_MediaEnded;
                }
                break;
            case 5: // MainPage.xaml line 41
                {
                    this.Playlist = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 35
                {
                    this.Play = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Play).Click += this.Play_Click;
                }
                break;
            case 7: // MainPage.xaml line 32
                {
                    this.VolumeProgress = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.VolumeProgress).ValueChanged += this.VolumeProgress_ValueChanged;
                }
                break;
            case 8: // MainPage.xaml line 29
                {
                    this.Help = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // MainPage.xaml line 26
                {
                    this.NameMusic = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 23
                {
                    this.Playlists = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Playlists).Click += this.Playlists_Click;
                }
                break;
            case 11: // MainPage.xaml line 20
                {
                    this.File = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.File).Click += this.File_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
