   M S B A M L   `   `   `  ����H  DRoom Interior, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Room_Interior.AdminRoom_Interior.Admin  5      '    !Room_Interior.Admin.AdminPageUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Room_Interior.Admin     5        N� Title$  AdminPageUser��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $	��330 �6   .+�5   
   � $��0��6    � Orientation$ 
Horizontal=�5      $
��Left=�5      $��Center=�5      .+�5      �� -   5         ��Name$ 
btnBackFrm��5      $��<��5         
ButtoneTwo#��[  5      5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�5      $��Right=�5      $��Center=�5      �� 5   
   -   5         ��Name$ LvUser��5      $��1��5       �� View 5       �� 5!      .P�5"      �� $��Фамилия��6%    �� Width$	 100��5#   %    �� DisplayMemberBinding 5$   %   �� *
LastName+�� 5&      $��Имя��6%   $	 100��5'   %    5(   %   �� *	FirstName+�� 5*      $��Отчество��6%   $	 100��5+   %    5,   %   �� *
Patronymic+�� 5.      $ ��НомерТелефона��6%   $	 100��5/   %    50   %   �� *Phone+�� 52      $'��!Электронная пчота��6%   $	 150��53   %    54   %   �� *Email+56      58      59      5:      