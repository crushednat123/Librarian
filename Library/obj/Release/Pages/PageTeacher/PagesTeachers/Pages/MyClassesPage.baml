   M S B A M L   `   `   `  ���� B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:Library.Pages.PageTeacher.PagesTeachers.Pages-Library.Pages.PageTeacher.PagesTeachers.Pages  A    ;Library.Pages.PageTeacher.PagesTeachers.Pages.MyClassesPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Mlocal;clr-namespace:Library.Pages.PageTeacher.PagesTeachers.Pages     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  -     N� Title$  
MyBookPage��.��� .+��� -    ��Name$ 
btnAppdate��$y�	Collapsed=��� $��Мой класс��   	TextTitle#��[  �� -   $ 
btnVidasha��$
��Left=�$	��Top=� K� ZIndex$ 1��|�.  $��	17 40 0 0q�  btnChekTecher#��[ .����  �� Orientation$ 
Horizontal=�.+�!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Book=�$��0q�$��20��  fa:IconImage#��[ �� $��10 0 0 0q�$9��3Выданные книги моему классу��  menuButtonText#��[ �  � Orientation$ 
Horizontal=�$��Stretch=�$	��Top=�$
��auto��$��	145 0 0 0q�$
��auto��.+��� -    ��Name$ tbPoisk��  tbPoiskStyle#��[ $	��Top=�$��	110 3 0 0q�$	��350��$
��Left=�.�� � ToolTip �� $
��auto��$��	10 0 10 0q�$4��.ФИО, логин, телефон, адрес��.���� -    ��Name$ Placeholder��	 J� IsHitTestVisible	 .  $��Поиск:��$
��Bold"�$��
-340 9 0 0q�$	��Top=�
���iii�$
��Left=����� 
 �� 
TargetType"
 ��.���  �� Property � y� �� Value$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ tbPoisk�� �� Value  .a���  � y�$ Visible=��� -   $ btnPoisk��  btnCrossAndRollUp#��[ $ 1��$��	-60 7 0 0q�$	��Top=�$
��Left=� �� 	IsDefault . .��    	poiskIcon#��[  _� $	��270��$��60��  ToolTipPoisk#��[ �� -    ��Name$ tbInfo��$ 1��$y�	Collapsed=�$��Center=�$��Center=�$ 
Horizontal=�.+�  $ Frown=�   
Foreground �#5b60c4$��70��$��70���� $&�� Ничего не найдено��$��20 0 0 0q�$��26(�#��[ ��  �� CornerRadius$ 10��$��10 75 20 20q�����  �� 
StartPoint$	 1,0&� �� EndPoint$	 0,1&�.���  � Color$ #4169E1�� � Offset$ 0Q�� $ #ADD8E6��$ 1Q�._�� .+�� .+��� -   $
��Auto=�$
��Auto=�.���� $��
10 10 10 0q�.+��� -	    ��Name$ listMyClasses��$��0q�
������  � FocusVisualStyle Z� ���� .R�� .+��� $ 
Horizontal=�.+��� $��60��$��0 5 0 5q�
����  �$��1q�$ 10�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 20Q�   Opacity$ .5Q�   ShadowDepth$ 1Q�._��� $��ReceiverColor�����	#FF96B2E4$��2q�$ 10��._�� .+��� $
��Mask��
����������	#FF3B5998$��0q�$ 10���� .+���  ��Name$ 	imageBook��-
   $
��Fill=�  J� SnapsToDevicePixels  . $��3q����� ! �� Path$! SchoolBoy.Img�" �� TargetNullValue" ��/Resources/user.png�� �� $��	10 0 10 0q�$%��Открыть картинку��# J� OpacityMask# !� $ !� Visual$ �� $
 Mask���� $��7 4 0 0q�.+��� $ 
Horizontal=�.+�  %  Name$% iconName��$ 1��$ AddressCard=�$
��Left=�
 �����$��3 0 0 0q��� $��10 0 0 0q�$
��Bold"�$��13(�  
tbListView#��[ ���� *SchoolBoy.FullName+�� $ 
Horizontal=�.+�  $ 1��$ Users=�$
��Left=�
 �����$��3 0 0 0q��� $��10 0 0 0q����� *SchoolBoy.NamberClasses+& �� StringFormat$& Класс: {0}���� $ 
Horizontal=�.+�  $ 1��$��16��$ MapMarkerAlt=�$
��Left=�
 �����$��3 0 0 0q��� $��10 0 0 0q����� *SchoolBoy.Address+$& Адрес: {0}���� $��Center=�$��Right=�$��	50 4 60 0q�.+��� $ 
Horizontal=�.+�  $��16��$
 User=�
 ������� $��10 0 0 0q����� *Login+$& Логин: {0}���� $ 
Horizontal=�.+�  $��16��$
 Lock=�
 ������� $��10 4 0 0q����� *
Password+$& Пароль: {0}���� $ 
Horizontal=�.+�  $��16��$ Whatsapp=�
 ������� $��10 4 0 0q����� *SchoolBoy.Telephone+$& Телефон: {0}���� $ btnEditUser��-    	 btnEditImage#��[	 |�.  $��Right=�$��0 4 3 0q�$	��Top=�.��  $
 Edit=�$��16�� 
 fa:IconImageTopButton#��[
  �� $
��auto��$��	10 0 10 0q�$/��)Редактировать ученика���� -   ' ��Name$' borderImageBook��$y�	Collapsed=�$ 10��
������ ._�� ( � ColumnDefinitions( �� $	��140 ��� $��* ��� $	��140 �.+��� 
�������$ 	10 0 0 10��) J� Opacity$	) 0.5Q�$��0���� -   $ 	btnBorder��$��1��$��	0 17 10 0q�  btnCross#��[ $	��Top=�$��Right=�$ 1��.��    iconCrossStyle#��[ $��	16 -6 0 0q�$
 Plus=�z��� * �� Angle$* 44Q� �� $%��Закрыть картинку��$
��auto��$��	10 0 10 0q��� -   $' borderImage��
�������$	) 0.5Q�$��1���� 
�������$��	0 10 0 10q�$ 10��$��1��._�� .+��� $��5q����� $	! Img�" ��/Resources/user.png���� 
�������$ 	0 10 10 0��$	) 0.5Q�$��2��