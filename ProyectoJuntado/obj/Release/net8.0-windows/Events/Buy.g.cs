﻿#pragma checksum "..\..\..\..\Events\Buy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E2A7E31726B3CDACB0BE317508F87886603F4F63"
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


namespace Events {
    
    
    /// <summary>
    /// Buy
    /// </summary>
    public partial class Buy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Events\Buy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock locationTextBlock;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Events\Buy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Events\Buy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ticketTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Events\Buy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantityTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Events\Buy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button purchaseButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProyectoJuntado;component/events/buy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Events\Buy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.locationTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.dateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ticketTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\..\Events\Buy.xaml"
            this.ticketTypeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TicketsComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.quantityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.purchaseButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Events\Buy.xaml"
            this.purchaseButton.Click += new System.Windows.RoutedEventHandler(this.PurchaseButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
