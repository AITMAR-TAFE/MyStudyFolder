﻿#pragma checksum "..\..\..\SecondPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AA06139AF126D75F58473018622437684FCAAB2D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyProject;
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


namespace MyProject {
    
    
    /// <summary>
    /// SecondPage
    /// </summary>
    public partial class SecondPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\SecondPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox_Jobs;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\SecondPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_LoadJobs;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\SecondPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_CompleteJob;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\SecondPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_NotCompleted;
        
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
            System.Uri resourceLocater = new System.Uri("/MyProject;component/secondpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SecondPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.ListBox_Jobs = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.Button_LoadJobs = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\SecondPage.xaml"
            this.Button_LoadJobs.Click += new System.Windows.RoutedEventHandler(this.Button_LoadJobs_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_CompleteJob = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\SecondPage.xaml"
            this.Button_CompleteJob.Click += new System.Windows.RoutedEventHandler(this.Button_CompleteJob_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_NotCompleted = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\SecondPage.xaml"
            this.Button_NotCompleted.Click += new System.Windows.RoutedEventHandler(this.Button_NotCompleted_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

