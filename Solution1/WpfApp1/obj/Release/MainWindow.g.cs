﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "26149AE6AF3A02E61E3FC332A3256B4C47084141ED98EC36C63170D9BB3E710D"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using System.Windows.Shell;
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView1;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView2;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 13 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MainMenuItemRun_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MainMenuItemClear_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listView1 = ((System.Windows.Controls.ListView)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.listView1.DragEnter += new System.Windows.DragEventHandler(this.ListView_DragEnter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.listView1.Drop += new System.Windows.DragEventHandler(this.ListView1_Drop);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.listView1.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListView1_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.listView1.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListView1_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.listView1.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.ListView1_PreviewMouseMove);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 25 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ListView1MenuItemRemove_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 26 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ListView1MenuItemClear_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 27 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem1_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.listView2 = ((System.Windows.Controls.ListView)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.listView2.DragEnter += new System.Windows.DragEventHandler(this.ListView_DragEnter);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            this.listView2.Drop += new System.Windows.DragEventHandler(this.ListView2_Drop);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            this.listView2.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListView2_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            this.listView2.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListView2_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            this.listView2.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.ListView2_PreviewMouseMove);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 39 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ListView2MenuItemRemove_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 40 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ListView2MenuItemClear_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

