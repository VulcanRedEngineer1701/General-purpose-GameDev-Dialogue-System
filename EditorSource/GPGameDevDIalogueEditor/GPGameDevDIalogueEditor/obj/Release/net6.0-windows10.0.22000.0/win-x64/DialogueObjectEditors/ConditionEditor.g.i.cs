﻿#pragma checksum "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66FB589F234AEB53E215A7D7BF46845767348679"
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
    /// ConditionEditor
    /// </summary>
    public partial class ConditionEditor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Condition;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Argument;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GPGameDevDialogueEditor.UICustomObjects.LineStarter trueStarter;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ActionIfTrueStackPanel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GPGameDevDialogueEditor.UICustomObjects.LineStarter falseStarter;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ActionIfFalseStackPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/GPGameDevDialogueEditor;component/dialogueobjecteditors/conditioneditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
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
            this.Condition = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
            this.Condition.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
            this.Condition.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Argument = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
            this.Argument.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
            this.Argument.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddTrueConditionAction);
            
            #line default
            #line hidden
            return;
            case 4:
            this.trueStarter = ((GPGameDevDialogueEditor.UICustomObjects.LineStarter)(target));
            return;
            case 5:
            this.ActionIfTrueStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            
            #line 26 "..\..\..\..\..\DialogueObjectEditors\ConditionEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddFalseConditionAction);
            
            #line default
            #line hidden
            return;
            case 7:
            this.falseStarter = ((GPGameDevDialogueEditor.UICustomObjects.LineStarter)(target));
            return;
            case 8:
            this.ActionIfFalseStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

