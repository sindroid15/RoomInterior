   M S B A M L   `   `   `  ����H  DRoom Interior, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Room_InteriorRoom_Interior  5          Room_Interior.Auth   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Room_Interior     5        N� Title$
  Auth��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   .+�5   
   � $��0��6   $��Center=�5      $��Center=�5      .+�5      �� $��Авторизация��6   5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�5      $��Center=�5      $��Center=�5      .+�5      �� $)��#Введите логин:         ��6   �� 5      -   5         ��Name$ txbLogin��5      5      �� 5    
   $��2��6   $ 
Horizontal=�5!      $��Center=�5"      $��Center=�5#      .+�5$      �� $)��#Введите пароль:       ��6   G� 5%      -   5         G�Name$ psbPassword��5%      5&      �� 5'   
   $��3��6   $ 
Horizontal=�5(      $��Center=�5)      $��Center=�5*      .+�5+      �� $(��"Повторите пароль:  ��6   G� 5,      -   5        $ psbPasswordRepeat��5,      5-      �� 5.   
   $��4��6   $ 
Horizontal=�5/      $��Center=�50      $��Center=�51      .+�52      �� -   5         ��Name$ btnExit��52      $��
Выйти��53         
ButtoneOne#��[  55      �� 56      -   5        $ btnEnter��56      $��
Войти��57      #��[  59      5:      5;      5<      