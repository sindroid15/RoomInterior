   M S B A M L   `   `   `  ����H  DRoom Interior, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Room_Interior.HelperRoom_Interior.Helper  5      0    *Room_Interior.Manager.ManagerPageUserOrder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Room_Interior.Helper     5        N� Title$  ManagerPageUserOrder��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $	��330 �6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��200 �6   .+�5   
   � $��0��6    � Orientation$ 
Horizontal=�6!   $
��Left=�5      $��Center=�5      .+�5      �� -   5         ��Name$ 
btnBackFrm��5      $��<��6)      
ButtoneTwo#��[  5      5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�5      $��Center=�5      �� 5!   
   -   5         ��Name$ LvUser��5!       $��1��6    �� View 5"      �� 5#      .P�5$      �� $��Фамилия��6%    �� Width$	 100��66   	 �� DisplayMemberBinding	 6B   �� *
LastName+�� 5%      $��Имя��6%   $	 100��62   	 6>   �� *	FirstName+�� 5&      $��Отчество��6%   $	 100��67   	 6C   �� *
Patronymic+5'      5)      �� 5*   
   -   5        $ LvOrder��5*   0   $��1��6   $��1��6     5+      �� 5,      .P�5-      �� $��Номер заказа��6%   $	 100��6;   	 6G   �� *	IDOrder+�� 5.      $��Номер корзины��6%   $	 100��6<   	 6H   �� *
IDBasket+5/      51      52      53      