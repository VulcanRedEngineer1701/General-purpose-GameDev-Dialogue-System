﻿#pragma checksum "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F70D846D935184146930B054E5D718CDAD41973"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GPGameDevDialogueEditor.DialogueObjectEditors;
using GPGameDevDialogueEditor.UICustomObjects;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
    /// AnswerEditor
    /// </summary>
    public partial class AnswerEditor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IsConditionalCB;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GPGameDevDialogueEditor.UICustomObjects.LineStarter starter;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AnswerConditionContainer;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AnswerText;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AnswerActionContainer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GPGameDevDialogueEditor;component/dialogueobjecteditors/answereditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.IsConditionalCB = ((System.Windows.Controls.CheckBox)(target));
            
            #line 15 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
            this.IsConditionalCB.Checked += new System.Windows.RoutedEventHandler(this.AddCondition);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
            this.IsConditionalCB.Unchecked += new System.Windows.RoutedEventHandler(this.RemoveCondition);
            
            #line default
            #line hidden
            return;
            case 2:
            this.starter = ((GPGameDevDialogueEditor.UICustomObjects.LineStarter)(target));
            return;
            case 3:
            this.AnswerConditionContainer = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.AnswerText = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
            this.AnswerText.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
            this.AnswerText.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 22 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveThis);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 27 "..\..\..\..\DialogueObjectEditors\AnswerEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddAction);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AnswerActionContainer = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

