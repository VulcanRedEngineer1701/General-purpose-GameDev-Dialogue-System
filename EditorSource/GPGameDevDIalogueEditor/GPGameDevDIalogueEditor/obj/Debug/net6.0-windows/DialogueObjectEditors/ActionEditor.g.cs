﻿#pragma checksum "..\..\..\..\DialogueObjectEditors\ActionEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "061DDFD67B8E1705D35540AA6BEB7DA02515261D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using GPGameDevDialogueEditor.DialogueObjectEditors;
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


namespace GPGameDevDialogueEditor.DialogueObjectEditors {
    
    
    /// <summary>
    /// ActionEditor
    /// </summary>
    public partial class ActionEditor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\DialogueObjectEditors\ActionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ActionName;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\DialogueObjectEditors\ActionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ActionValue;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GPGameDevDialogueEditor;component/dialogueobjecteditors/actioneditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\DialogueObjectEditors\ActionEditor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ActionName = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\..\DialogueObjectEditors\ActionEditor.xaml"
            this.ActionName.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\DialogueObjectEditors\ActionEditor.xaml"
            this.ActionName.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ActionValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\..\DialogueObjectEditors\ActionEditor.xaml"
            this.ActionValue.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\DialogueObjectEditors\ActionEditor.xaml"
            this.ActionValue.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\..\..\DialogueObjectEditors\ActionEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveCustomAction);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

