   M S B A M L   `   `   `  ����H  DRoom Interior, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Room_Interior.UserRoom_Interior.User  5   	   $    Room_Interior.User.UserProfile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Room_Interior.User     5   	     � Title$  UserProfile��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ grbProfileUser��5
      $��Profile User��5      $��20q�5      .��5      � $��10q�6    � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $
��auto �6'    � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   .+�5      �� $��Login: ��6   $��Right=�5      $��Center=�5      �� 5      -   5         ��Name$ tbLogin��5      $
��Left=�5      $��Center=�5      $	��200��5       $��1��5!      ��5      ��  �� Path$
 user� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5!      �� 5"      $��
Password: ��6   $��Center=�5#      $��1��5$      �� 5%      -   5        $ 
tbPassword��5%      $
��Left=�5)      $��Center=�5*      $	��200��5+      $��1��5,      $��1��5-      ��5&      �� $ password�$ TwoWay=�$ PropertyChanged=�5-      � 5.      $��2��6   $��1��5/      $��0,10,0,0q�50      $
��Left=�51       52      �� 53      $
��auto �6+   �� 54      $
��auto �6+   .+�56      �� -   5         ��Name$ btnSave��56      $
��Save��58      $��90��59      $��	20,0,20,0q�5:         
ButtoneTwo#��[  5;      �� 5<      -   5        $ btnExit��5<      $
��Exit��5=      $��1��5>      $��60��5?      #��[  5A      5B      5C      5D      5E      5F      