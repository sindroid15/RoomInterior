#pragma checksum "..\..\..\User\UserMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3875E925B02BFE693972E0CD76099CEE014E6372EB02B5F4868A2354979BE5EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Room_Interior.User;
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


namespace Room_Interior.User {
    
    
    /// <summary>
    /// UserMain
    /// </summary>
    public partial class UserMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\User\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfileButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\User\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnListProduct;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\User\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnListBasket;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\User\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnListExitProfile;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\User\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnListCloseApp;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\User\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frmMainUser;
        
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
            System.Uri resourceLocater = new System.Uri("/Room Interior;component/user/usermain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User\UserMain.xaml"
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
            this.ProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\User\UserMain.xaml"
            this.ProfileButton.Click += new System.Windows.RoutedEventHandler(this.ProfileButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnListProduct = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\User\UserMain.xaml"
            this.btnListProduct.Click += new System.Windows.RoutedEventHandler(this.btnListProduct_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnListBasket = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\User\UserMain.xaml"
            this.btnListBasket.Click += new System.Windows.RoutedEventHandler(this.btnListBasket_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnListExitProfile = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\User\UserMain.xaml"
            this.btnListExitProfile.Click += new System.Windows.RoutedEventHandler(this.btnListExitProfile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnListCloseApp = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\User\UserMain.xaml"
            this.btnListCloseApp.Click += new System.Windows.RoutedEventHandler(this.btnListCloseApp_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.frmMainUser = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

