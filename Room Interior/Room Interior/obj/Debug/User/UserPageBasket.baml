   M S B A M L   `   `   `  ����H  DRoom Interior, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Room_Interior.UserRoom_Interior.User  5      '    !Room_Interior.User.UserPageBasket   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Room_Interior.User     5        N� Title$  UserPageBasket��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $	��330 �6   .+�5   
   � $��0��6    � Orientation$ 
Horizontal=�5      $
��Left=�5      $��Center=�5      .+�5      �� -   5         ��Name$ 
btnBackFrm��5      $��<��5         
ButtoneTwo#��[  5      5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�5      $��Right=�5       $��Center=�5!      �� 5#   
   -   5         ��Name$ lvBasket��5$      $��1��5#       �� View 5&      �� 5'      .P�5(      �� $��Номер заказа��6%    �� Width$	 100��5)   %   	 �� DisplayMemberBinding	 5*   %   �� *	IdOrder+5+      5-      �� 5.   
   -   5        $ 	lvProduct��50      $��1��5.      $��2��5/       52      �� 53      .P�54      �� $!��Номер продукта��6%   $	 100��55   %   	 56   %   �� *	IdProduct+�� 57      $��Цена��6%   $	 100��58   %   	 59   %   �� *Price+5:      5<      5=      5>      