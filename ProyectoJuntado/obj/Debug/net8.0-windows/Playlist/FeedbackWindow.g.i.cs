﻿#pragma checksum "..\..\..\..\Playlist\FeedbackWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02B4DBB0D1F8645229B02DBF7DE8B317D99D9498"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProyectoJuntado.Playlist {
    
    
    /// <summary>
    /// FeedbackWindow
    /// </summary>
    public partial class FeedbackWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\Playlist\FeedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image AlbumCoverImage;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Playlist\FeedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SongNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Playlist\FeedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ArtistNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Playlist\FeedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StarsPanel;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Playlist\FeedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CommentTextBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Playlist\FeedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PreviousCommentsListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProyectoJuntado;V1.0.0.0;component/playlist/feedbackwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Playlist\FeedbackWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AlbumCoverImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.SongNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ArtistNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.StarsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            
            #line 53 "..\..\..\..\Playlist\FeedbackWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StarButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 54 "..\..\..\..\Playlist\FeedbackWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StarButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 55 "..\..\..\..\Playlist\FeedbackWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StarButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 56 "..\..\..\..\Playlist\FeedbackWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StarButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 57 "..\..\..\..\Playlist\FeedbackWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StarButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 61 "..\..\..\..\Playlist\FeedbackWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.CommentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 69 "..\..\..\..\Playlist\FeedbackWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SubmitButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.PreviousCommentsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

