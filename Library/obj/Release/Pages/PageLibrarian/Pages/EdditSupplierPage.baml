   M S B A M L   `   `   `  ����   Library9    3Library.Pages.PageLibrarian.Pages.EdditSupplierPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44mask)http://schemas.xceed.com/wpf/xaml/toolkit    N� Title$  EditUserPage�� � FocusVisualStyle Z� .���� -    ��Name$ border��$��10 10 15 10q�
������� �� CornerRadius$ 10��|�.  Z� ._��� -    ��Name$ 
stackPanel��$��Stretch=�$��Center=�$��30q�.+��� -   $��tbNameAndSurName��$��0��   TextBox#��[  $��10 0 0 0q�$��0 10 0 0q�$
��auto������ *SupplierName+!  FontAwesome.Sharp.IconImage  -     Name$ 	iconLogin���  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ AddressCard=�$
��Left=�   
Foreground
 �����$��
13 -30 0 0q��� -    ��Name$ Placeholder��	 J� IsHitTestVisible	 .  $
��Wrap=�$��ФИО:��$��
35 -30 0 0q�$��Center=�
�������$
��Left=����� 
 �� 
TargetType"
 ��.���  �� Property � y� �� Value$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ tbNameAndSurName�� �� Value  .a���  � y�$ Visible=��� $��Right=�$��	0 0 10 20q����� "
 ��.���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text.Length+$ tbNameAndSurName�� 50.a���  � ��
 �  ���� ��� *Text.Length+$ tbNameAndSurName�� �� Mode$ OneWay=�/�� ��� *	MaxLength+$ tbNameAndSurName��%  Xceed.Wpf.Toolkit.MaskedTextBox  -   $��tBPhone��$��2��#��[   �� 	MaxLength$ 18��   Mask$ +7 (000)-000-00-00��$��10 0 0 0q�$��0 0 0 25q�$
��auto������ *	Telephone+.�� � ToolTip �� $��65��$��10 0 0 0q�$��Телефон��.��  -   $ 	iconPhone�� K� ZIndex$ 1��$ Whatsapp=�$
��Left=�
 �����$��
13 -80 0 0q��� -   $ PlaceholderPhone��	 .  $
��Wrap=�$��Телефон��$��35 -105 0 0q�$��Center=�
�������$
��Left=����� "
 ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text+$ tBPhone��  .a���  � y�$ Visible=��� -	   $��tbFirma��$��0��#��[  $��10 0 0 0q�$��0 10 0 0q�$
��auto������ *Firm+  $ Archway=�$
��Left=�
 �����$��
13 -30 0 0q��� -
   $ PlaceholderFirma��	 .  $
��Wrap=�$��Фирма:��$��
35 -30 0 0q�$��Center=�
�������$
��Left=����� "
 ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text+$ tbFirma��  .a���  � y�$ Visible=��� $��Right=�$��	0 0 10 20q����� "
 ��.���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text.Length+$ tbFirma�� 50.a���  � ��
 �  ���� ��� *Text.Length+$ tbFirma��$ OneWay=�/�� ��� *	MaxLength+$ tbFirma���� -    ��Name$ cBPostovhik��$��	0 -1 0 20q�$��30��$
��auto�� �� DisplayMemberPath$
 Type�� �� SelectedItem �� *TypeSuppliers+ �� $	��110��$��9 0 0 0q�$#��Поставщик книги��  -   $ iconPostohkik��$ 1��$ TruckMoving=�$
��Left=�
 �����$��
10 -70 0 0q��� -    ��Name$ btnSave��$��7��$��Сохранить��$��0 20 0 0q�$
��auto��