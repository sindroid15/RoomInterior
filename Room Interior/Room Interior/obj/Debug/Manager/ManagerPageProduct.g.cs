#pragma checksum "..\..\..\Manager\ManagerPageProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B843D0F684FFA640F3A6E79E6003B554801D2431B359365A7937AC1B9672CD9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Room_Interior.Manager;
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


namespace Room_Interior.Manager {
    
    
    /// <summary>
    /// ManagerPageProduct
    /// </summary>
    public partial class ManagerPageProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Manager\ManagerPageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBackFrm;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Manager\ManagerPageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbSearch;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Manager\ManagerPageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFiltrationCategory;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Manager\ManagerPageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSortingPrice;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Manager\ManagerPageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLastPage;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Manager\ManagerPageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbckPage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Manager\ManagerPageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNextPage;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Manager\ManagerPageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditProduct;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Manager\ManagerPageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LvProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/Room Interior;component/manager/managerpageproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Manager\ManagerPageProduct.xaml"
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
            this.btnBackFrm = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Manager\ManagerPageProduct.xaml"
            this.btnBackFrm.Click += new System.Windows.RoutedEventHandler(this.btnBackFrm_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Manager\ManagerPageProduct.xaml"
            this.txbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbFiltrationCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\Manager\ManagerPageProduct.xaml"
            this.cmbFiltrationCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbFiltrationCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbSortingPrice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\Manager\ManagerPageProduct.xaml"
            this.cmbSortingPrice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbSortingPrice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnLastPage = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Manager\ManagerPageProduct.xaml"
            this.btnLastPage.Click += new System.Windows.RoutedEventHandler(this.btnLastPage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbckPage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btnNextPage = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Manager\ManagerPageProduct.xaml"
            this.btnNextPage.Click += new System.Windows.RoutedEventHandler(this.btnNextPage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnEditProduct = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Manager\ManagerPageProduct.xaml"
            this.btnEditProduct.Click += new System.Windows.RoutedEventHandler(this.btnEditProduct_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LvProduct = ((System.Windows.Controls.ListView)(target));
            
            #line 62 "..\..\..\Manager\ManagerPageProduct.xaml"
            this.LvProduct.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LvProduct_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

