﻿#pragma checksum "..\..\..\Admin\AdminAddProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3B28D9247378A7A057CC6EC8F9286B69F37A9BA01C067511CC59BABAB6D9A4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Room_Interior.Admin;
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


namespace Room_Interior.Admin {
    
    
    /// <summary>
    /// AdminAddProduct
    /// </summary>
    public partial class AdminAddProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Admin\AdminAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNameProduct;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Admin\AdminAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbChangeCategoryProduct;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Admin\AdminAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbInputPrice;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Admin\AdminAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgImageProduct;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Admin\AdminAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnImageAdd;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Admin\AdminAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbInputDescription;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Admin\AdminAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbInputMaterialProduct;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Admin\AdminAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExitWindow;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Admin\AdminAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/Room Interior;component/admin/adminaddproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Admin\AdminAddProduct.xaml"
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
            this.tbNameProduct = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\Admin\AdminAddProduct.xaml"
            this.tbNameProduct.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbNameProduct_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbChangeCategoryProduct = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\Admin\AdminAddProduct.xaml"
            this.cmbChangeCategoryProduct.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbChangeCategoryProduct_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbInputPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Admin\AdminAddProduct.xaml"
            this.tbInputPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbInputPrice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.imgImageProduct = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.btnImageAdd = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Admin\AdminAddProduct.xaml"
            this.btnImageAdd.Click += new System.Windows.RoutedEventHandler(this.btnImageAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbInputDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\Admin\AdminAddProduct.xaml"
            this.tbInputDescription.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbInputDescription_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbInputMaterialProduct = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\..\Admin\AdminAddProduct.xaml"
            this.tbInputMaterialProduct.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbInputMaterialProduct_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnExitWindow = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\Admin\AdminAddProduct.xaml"
            this.btnExitWindow.Click += new System.Windows.RoutedEventHandler(this.btnExitWindow_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnSaveProduct = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Admin\AdminAddProduct.xaml"
            this.btnSaveProduct.Click += new System.Windows.RoutedEventHandler(this.btnSaveProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
