﻿#pragma checksum "..\..\..\..\UserControls\AddOrRestockBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D0D6EC6BBC8D92C160A55C90176A40681AAD56E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BoxesProject.UserControls;
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


namespace BoxesProject.UserControls {
    
    
    /// <summary>
    /// AddOrRestockBox
    /// </summary>
    public partial class AddOrRestockBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\UserControls\AddOrRestockBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainMenu;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\UserControls\AddOrRestockBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BoxesProject.UserControls.ClearableTextBox basex;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\UserControls\AddOrRestockBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BoxesProject.UserControls.ClearableTextBox heightX;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\UserControls\AddOrRestockBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BoxesProject.UserControls.ClearableTextBox quantityX;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UserControls\AddOrRestockBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BoxesProject.UserControls.MenuButton btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\UserControls\AddOrRestockBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BoxesProject.UserControls.MenuButton btnReturn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BoxesProject;component/usercontrols/addorrestockbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\AddOrRestockBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mainMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.basex = ((BoxesProject.UserControls.ClearableTextBox)(target));
            return;
            case 3:
            this.heightX = ((BoxesProject.UserControls.ClearableTextBox)(target));
            return;
            case 4:
            this.quantityX = ((BoxesProject.UserControls.ClearableTextBox)(target));
            return;
            case 5:
            this.btnSubmit = ((BoxesProject.UserControls.MenuButton)(target));
            return;
            case 6:
            this.btnReturn = ((BoxesProject.UserControls.MenuButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

