   M S B A M L   `   `   `  ����   Library@    :Library.Pages.PageTeacher.PagesTeachers.Pages.EditUserPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44mask)http://schemas.xceed.com/wpf/xaml/toolkit  -     N� Title$  EditUserPage�� � FocusVisualStyle Z� .���� -    ��Name$ border��$��25 10 25 20q�
������� �� CornerRadius$ 10��|�.  Z� ._��� $��Stretch=�$��Center=�$��	30 0 30 0q�.+��� -   $��tBName��$��0��   TextBox#��[   �� 	MaxLength$ 30��$��0 10 0 0q�$
��auto������ *Teachers.Name+.�� � ToolTip �� $��40��$��15 0 0 0q�$��Имя��.���� $��Right=�$��	0 0 10 10q�����  �� 
TargetType" ��.���  �� Property � �� �� Value$ Comic Sans MS)���  � ��$
 Bold"�	 �� Triggers	 �� 
 �� Binding
 �� *Text.Length+ �� ElementName$ tBName�� �� Value 30.a���  � ��
 �  ���� ��� *Text.Length+$ tBName�� �� Mode$ OneWay=�/�� ��� *	MaxLength+$ tBName��!  FontAwesome.Sharp.IconImage  -     Name$ iconName�� K� ZIndex$ 1���  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ AddressCard=�$
��Left=�   
Foreground
 �����$��
13 -85 0 0q��� -    ��Name$ PlaceholderName�� J� IsHitTestVisible .  $
��Wrap=�$��Имя��$��
35 -86 0 0q�$��Center=�
�������$
��Left=����� " ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"�	 �� 
 �� *Text+$ tBName��  .a���  � y�$ Visible=��� -   $��	tBSurName��$��1��#��[  $ 30��$��0 10 0 0q�$
��auto������ *Teachers.SurName+.�� �� $��65��$��15 0 0 0q�$��Фамилия��.���� $��Right=�$��	0 0 10 10q����� " ��.���  � ��$ Comic Sans MS)���  � ��$
 Bold"�	 �� 
 �� *Text.Length+$ 	tBSurName�� 30.a���  � ��
 �  ���� ��� *Text.Length+$ 	tBSurName��$ OneWay=�/�� ��� *	MaxLength+$ 	tBSurName��  -   $ iconSurName��$ 1��$ UserEdit=�$
��Left=�
 �����$��
13 -85 0 0q��� -   $ PlaceholderSurName�� .  $
��Wrap=�$��Фамилия��$��35 -105 0 0q�$��Center=�
�������$
��Left=����� " ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"�	 �� 
 �� *Text+$ 	tBSurName��  .a���  � y�$ Visible=��� -	   $��tBAdres��$��2��#��[  $ 50��$��0 10 0 0q�$
��auto������ *Teachers.Address+.�� �� $��45��$��10 0 0 0q�$��
Адрес��.���� $��Right=�$��	0 0 10 20q����� " ��.���  � ��$ Comic Sans MS)���  � ��$
 Bold"�	 �� 
 �� *Text.Length+$ tBAdres�� 50.a���  � ��
 �  ���� ��� *Text.Length+$ tBAdres��$ OneWay=�/�� ��� *	MaxLength+$ tBAdres��  -
   $ 	iconAdres��$ 1��$ MapMarkerAlt=�$
��Left=�
 �����$��13 -102 0 0q��� -   $ PlaceholderAdres�� .  $
��Wrap=�$��
Адрес��$��35 -105 0 0q�$��Center=�
�������$
��Left=����� " ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"�	 �� 
 �� *Text+$ tBAdres��  .a���  � y�$ Visible=�%  Xceed.Wpf.Toolkit.MaskedTextBox  -   $��tBPhone��$��2��#��[  $ 18��   Mask$ +7 (000)-000-00-00��$��0 0 0 25q�$
��auto������ *Teachers.Telephone+.�� �� $��65��$��10 0 0 0q�$��Телефон��.��  -   $ 	iconPhone��$ 1��$ 	MobileAlt=�$
��Left=�
 �����$��
13 -80 0 0q��� -    ��Name$ cBItems��$��30��$��0 0 0 20q�$��3�� �� DisplayMemberPath$
 Name�� �� SelectedIndex �� *Teachers.IdItems+ Z�  �� $��	20 0  0 0q�$	��100��$��Мой предмет��  -   $ 	iconItems��$ 1��$ 
Swatchbook=�$
��Left=�
 �����$��
10 -70 0 0q��� -   $ 	cBClasses��$
��auto��$��30��$��0 0 0 20q�$��3��$ NamberClasses�� �� SelectedItem �� *Teachers.Classes+$ OneWay=� Z�  �� $��	20 0  0 0q�$��80��$��Мой класс��  -   $ iconClasses��$ 1��$ Users=�$
��Left=�
 �����$��
10 -70 0 0q��� -   $��tBLogin��$��4��#��[  $
��auto������ *Login+.�� �� $��50��$��15 0 0 0q�$��
Логин��.��  -   $ 	iconLogin��$ UserAlt=�$
��Left=�
 �����$��
13 -30 0 0q��� -   $ Placeholder�� .  $
��Wrap=�$��
Логин��$��
35 -30 0 0q�$��Center=�
�������$
��Left=����� " ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"�	 �� 
 �� *Text+$ tBLogin��  .a���  � y�$ Visible=��� $��Right=�$��	0 0 10 20q����� " ��.���  � ��$ Comic Sans MS)���  � ��$
 Bold"�	 �� 
 �� *Text.Length+$ tBLogin�� 50.a���  � ��
 �  ���� ��� *Text.Length+$ tBLogin��$ OneWay=�/�� ��� *	MaxLength+$ tBLogin��G� -   $��
pBPassword��$��5��$
��auto�� �� $��60��$��13 0 0 0q�$��Пароль���� -    ��Name$ 
tBPassword��#��[  $
��auto��$y�	Collapsed=�.�� �� $��60��$��13 0 0 0q�$��Пароль��.��  -   $ iconPassword��$
 Lock=�$
��Left=�
 �����$��
13 -30 0 0q��� -   $ textBlockPassword��$y�Visible=�$��Пароль��$��
35 -30 0 0q�$��Center=�
�������$
��Left=��� -   $
��text��$��Right=�$��0 0 10 0q�/50�� -   $ pasText��$��Right=�$��0 -16.8 31 0q�0�� -    ��Name$ checkPassword��$��6��{�.  $��5 0 0 10q�$#��Показать пароль���� -    ��Name$ btnSave��$��7��$��Сохранить��$
��auto���� -   $
 tBId��$y�	Collapsed=����� *Id+