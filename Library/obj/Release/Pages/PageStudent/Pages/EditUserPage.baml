   M S B A M L   `   `   `  ����   Library2    ,Library.Pages.PageStudent.Pages.EditUserPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  -     N� Title$  EditUserPage�� � FocusVisualStyle Z� .���� -    ��Name$ border��$��10 10 15 10q�
������� �� CornerRadius$ 10��|�.  Z� ._��� -    ��Name$ 
stackPanel��$��Stretch=�$��Center=�$��30q�.+��� -   $��tBLogin��$��0��   TextBox#��[  $��0 10 0 0q�$
��auto������ *Login+!  FontAwesome.Sharp.IconImage  -     Name$ 	iconLogin���  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ UserAlt=�$
��Left=�   
Foreground
 �����$��
13 -30 0 0q��� -    ��Name$ Placeholder��	 J� IsHitTestVisible	 .  $
��Wrap=�$��
Логин��$��
35 -30 0 0q�$��Center=�
�������$
��Left=����� 
 �� 
TargetType"
 ��.���  �� Property � y� �� Value$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ tBLogin�� �� Value  .a���  � y�$ Visible=��� $��Right=�$��	0 0 10 20q����� "
 ��.���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text.Length+$ tBLogin�� 50.a���  � ��
 �  ���� ��� *Text.Length+$ tBLogin�� �� Mode$ OneWay=�/�� ��� *	MaxLength+$ tBLogin��G� -   $��
pBPassword��$��1��$
��auto���� -    ��Name$ 
tBPassword��#��[  $
��auto��$y�	Collapsed=�  -	   $ iconPassword��$
 Lock=�$
��Left=�
 �����$��
13 -30 0 0q��� -
   $ textBlockPassword��$y�Visible=�$��Пароль��$��
35 -30 0 0q�$��Center=�
�������$
��Left=��� -   $
��text��$��Right=�$��0 0 10 0q�/50�� -   $ pasText��$��Right=�$��0 -16.8 31 0q�0�� -    ��Name$ checkPassword��$��3��{�.  $��5 0 0 10q�$#��Показать пароль���� -    ��Name$ btnSave��$��3��$��Сохранить��$
��auto���� -   $
 tBId��$y�	Collapsed=����� *Id+