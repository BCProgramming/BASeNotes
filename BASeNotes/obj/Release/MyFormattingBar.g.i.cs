﻿#pragma checksum "..\..\MyFormattingBar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C9AF9FD50D2C972EFCFDB4C8B06371EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace BASeNotes {
    
    
    /// <summary>
    /// MyFormattingBar
    /// </summary>
    public partial class MyFormattingBar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdCut;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdCopy;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdPaste;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton FormatBold;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton FormatItalic;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton FormatUnderline;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FormatAlignLeft;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FormatAlignCenter;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FormatAlignRight;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MyFormattingBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboFont;
        
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
            System.Uri resourceLocater = new System.Uri("/BASeNotes;component/myformattingbar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MyFormattingBar.xaml"
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
            
            #line 4 "..\..\MyFormattingBar.xaml"
            ((BASeNotes.MyFormattingBar)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmdCut = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.cmdCopy = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.cmdPaste = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.FormatBold = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 24 "..\..\MyFormattingBar.xaml"
            this.FormatBold.Click += new System.Windows.RoutedEventHandler(this.FormatBold_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FormatItalic = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 28 "..\..\MyFormattingBar.xaml"
            this.FormatItalic.Click += new System.Windows.RoutedEventHandler(this.FormatItalic_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FormatUnderline = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 31 "..\..\MyFormattingBar.xaml"
            this.FormatUnderline.Click += new System.Windows.RoutedEventHandler(this.FormatUnderline_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FormatAlignLeft = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.FormatAlignCenter = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.FormatAlignRight = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.ComboFont = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\MyFormattingBar.xaml"
            this.ComboFont.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

