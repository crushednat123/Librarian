   M S B A M L   `   `   `  ����   LibraryE    ?Library.Pages.PageTeacher.PagesTeachers.Pages.EditMyCkassesPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44mask)http://schemas.xceed.com/wpf/xaml/toolkit  -     N� Title$  EditBookPage��.���� -    ��Name$ border��$��25 10 25 20q�
������� �� CornerRadius$ 10��|�.  � FocusVisualStyle Z� ._��  � RowDefinitions �� $��* ��� $��60 � � ColumnDefinitions �� $��* ��� $��* �.+�� $��0��.+��� -    ��Name$ textBlockIdUser��$y�	Collapsed=����� *
IdSchool+�� $��Center=�.+��� -   $��	tBSurName��$��1��   TextBox#��[   �� 	MaxLength$ 30��$��	10 10 0 0q�$
��auto������ *SchoolBoy.SurName+.�� � ToolTip �� $��65��$��15 0 0 0q�$��Фамилия��.��!  FontAwesome.Sharp.IconImage  -   	  Name$	 iconSurName��
 K� ZIndex$
 1���  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ UserEdit=�$
��Left=�   
Foreground
 �����$��
20 -30 0 0q��� -   $ PlaceholderSurName�� J� IsHitTestVisible .  $
��Wrap=�$��Фамилия��$��
43 -30 0 0q�$��Center=�
�������$
��Left=�����  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ 	tBSurName�� �� Value  .a���  � y�$ Visible=��� -   $��tBName��$��2��#��[  $ 30��$��	10 10 0 0q�$
��auto������ *SchoolBoy.Name+.�� �� $
��auto��$��	10 0 10 0q�$ ��Имя и отчество��.��  $
 1��$ AddressCard=�$
��Left=�
 �����$��
20 -30 0 0q��� -   $ PlaceholderName�� .  $
��Wrap=�$ ��Имя и отчество��$��
43 -30 0 0q�$��Center=�
�������$
��Left=����� " ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text+$ tBName��  .a���  � y�$ Visible=��� -	   $��tBAdres��$��3��#��[  $ 50��$��	10 10 0 0q�$
��auto������ *SchoolBoy.Address+.�� �� $��45��$��10 0 0 0q�$��
Адрес��.��  -
   $	 	iconAdres��$
 1��$ MapMarkerAlt=�$
��Left=�
 �����$��
20 -30 0 0q��� -   $ PlaceholderAdres�� .  $
��Wrap=�$��
Адрес��$��
43 -30 0 0q�$��Center=�
�������$
��Left=����� " ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text+$ tBAdres��  .a���  � y�$ Visible=��� -    ��Name$ 	cbClasses��$
��auto��$��30��$��	10 10 0 0q�$��4�� �� DisplayMemberPath$ NamberClasses�� �� SelectedItem �� *SchoolBoy.Classes+ Z�  �� $��	10 0 10 0q�$
��auto��$��
Класс��  -   $	 iconClasses��$
 1��$ Users=�$
��Left=�
 �����$��
20 -30 0 0q�� $��1��$��0 0 10 0q�.+��� $��Center=�.+��� -   $��tBLogin��$��5��#��[  $
��auto��$��	10 10 0 0q����� *Login+.�� �� $��50��$��15 0 0 0q�$��
Логин��.��  -   $	 	iconLogin��$
 User=�$
��Left=�
 �����$��
20 -30 0 0q��� -   $ Placeholder�� .  $
��Wrap=�$��
Логин��$��
43 -30 0 0q�$��Center=�
�������$
��Left=����� " ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text+$ tBLogin��  .a���  � y�$ Visible=��� -    ��Name$ 
tBPassword��$��6��#��[  $��	10 10 0 0q�$
��auto������ *
Password+.�� �� $��60��$��13 0 0 0q�$��Пароль��.��  -   $	 iconPassword��$
 Lock=�$
��Left=�
 �����$��
20 -30 0 0q��� -   $ textBlockPassword��$��Пароль��$��
43 -30 0 0q�$��Center=�
�������$
��Left=����� " ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text+$ 
tBPassword��  .a���  � y�$ Visible=�%  Xceed.Wpf.Toolkit.MaskedTextBox  -   $��tBPhone��$��7��#��[  $ 18��   Mask$ +7 (000)-000-00-00��$��	10 10 0 0q�$
��auto������ *SchoolBoy.Telephone+.�� �� $��65��$��10 0 0 0q�$��Телефон��.��  -   $	 	iconPhone��$ Whatsapp=�$
��Left=�
 �����$��
20 -30 0 0q��� -   $ tbImageCheck��$y�	Collapsed=����� *SchoolBoy.Img+�� -   $ tbImage��$y�	Collapsed=�  tbImageCheck#��[ �� -   $ textBoxImage��$��	10 10 0 0q� �� 
IsReadOnly . $��8��$
��auto��  TextBoxImage#��[ ���� $ tbImage�� �� Path$
 Text�.�� �� $��60��$��10 0 0 0q�$��Картинка��.��  -   $	 	iconImage��$
 1��$ Images=�$
��Left=�
 �����$��
20 -30 0 0q��� -    ��Name$ btnEditImage��|�.  $��	0 -28 5 0q�  btnEditFale#��[ .��  $ Ad=�$��16��  fa:IconImageTopButton#��[  _� $	��130��.���� $'��!Изменить картинку���� -   $ btnSave��$��9��$��10 0 10 -250q�$��2��$��Сохранить��$
��auto��� $��1��$��10 0 0 0q�.+���  �� Orientation$ 
Horizontal=�.+��� $��Картинка��  -   $	 iconChek��  iconImageChekImage#��[ $ CheckCircle=�$��
13 -40 0 0q�