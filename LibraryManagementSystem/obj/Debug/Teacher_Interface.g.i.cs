﻿#pragma checksum "..\..\Teacher_Interface.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F131936D5B4D717712B25944582284DAAC03D9B9550A5C1E55B17D40D94FB9C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryManagementSystem;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace LibraryManagementSystem {
    
    
    /// <summary>
    /// Teacher_Interface
    /// </summary>
    public partial class Teacher_Interface : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Teacher_Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_TeacherName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Teacher_Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_TeacherId;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Teacher_Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_TeacherPwd;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Teacher_Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_BNum;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Teacher_Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Return;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Teacher_Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Borrow;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Teacher_Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Update;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Teacher_Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Out;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryManagementSystem;component/teacher_interface.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Teacher_Interface.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txt_TeacherName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_TeacherId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_TeacherPwd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_BNum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_Return = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Teacher_Interface.xaml"
            this.btn_Return.Click += new System.Windows.RoutedEventHandler(this.btn_Return_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Borrow = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Teacher_Interface.xaml"
            this.btn_Borrow.Click += new System.Windows.RoutedEventHandler(this.btn_Borrow_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Update = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Teacher_Interface.xaml"
            this.btn_Update.Click += new System.Windows.RoutedEventHandler(this.btn_Update_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Out = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Teacher_Interface.xaml"
            this.btn_Out.Click += new System.Windows.RoutedEventHandler(this.btn_Out_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

