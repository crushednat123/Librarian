   M S B A M L   `   `   `  ����   Library4    .Library.Pages.PageLibrarian.Pages.UserDatePage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  -     N�Name$  pageContent�� N� Title$ UserDatePage��.��� .+�� -    �Name$ gridShoolBoy��$y�	Collapsed=�.+��� -    ��Name$ btnAppdateSholBoy��$y�	Collapsed=��� $��Ученики��   	TextTitle#��[  � $
��Left=�$	��Top=�$��0 30 0 0q�.+���  �� Orientation$ 
Horizontal=�.+��� -   $ 
pageMinys1��  btnCrossAndRollUp#��[  K� ZIndex$ 1��.��!  FontAwesome.Sharp.IconImage  -     Name$ iconBackDate���  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ 	AngleLeft=�$��16��  fa:IconImageTopButton#��[  � ToolTip �� $
��auto��$��	10 0 10 0q�$+��%Предыдущая страница���� -   $ 	pagePlus1��#��[ $ 1��$��	-13 0 0 0q�.��  $ 
AngleRight=�$��16��#��[  �� $
��auto��$��	10 0 10 0q�$)��#Следующая страница���� -   $ btnAdShoolBoy��$
��Left=�$ 1��$	��Top=�|�.  $��	70 40 0 0q�  btnChekTecher#��[ .���� $ 
Horizontal=�.+�  $ Ad=�$��0q�$��20��  fa:IconImage#��[ �� $%��Добавить ученика��  menuButtonText#��[ �� -   $ btnDeleteShoolBoy��$��Right=�$ 1��$	��Top=�|�.  $��
70 40 25 0q�#��[ .���� $ 
Horizontal=�.+�  $ TrashAlt=�$��0q�$��20��#��[ �� $/��)Заблокировать ученика��#��[ � 	 � Orientation$	 
Horizontal=�$��Stretch=�$	��Top=�$
��auto��$��	105 0 0 0q�$
��auto��.+��� -	   
 ��Name$
 tbPoiskShoolBoy��  tbPoiskStyle#��[ $	��Top=�$��	110 3 0 0q�$	��350��$
��Left=�.�� �� $
��auto��$��	10 0 10 0q�$$��ФИО, логин, адрес��.���� -
    ��Name$ Placeholder�� J� IsHitTestVisible .  $��Поиск:��$
��Bold"�$��
-340 9 0 0q�$	��Top=�
���iii�$
��Left=�����  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ tbPoiskShoolBoy�� �� Value  .a���  � y�$ Visible=��� -   $ btnPoiskShoolBoy��#��[ $ 1��$��	-60 7 0 0q�$	��Top=�$
��Left=� �� 	IsDefault . .��    	poiskIcon#��[  _� $	��270��$��60��  ToolTipPoisk#��[ �� -    ��Name$ tbInfo��$ 1��$y�	Collapsed=�$��Center=�$��Center=�$ 
Horizontal=�.+�  $ Frown=�   
Foreground �#5b60c4$��70��$��70���� $&�� Ничего не найдено��$��20 0 0 0q�$��26(�#��[ ��  �� CornerRadius$ 10��$��10 75 20 20q�����  �� 
StartPoint$	 1,0&� �� EndPoint$	 0,1&�.���  � Color$ #4169E1�� � Offset$ 0Q�� $ #ADD8E6��$ 1Q�._�� .+�� .+��� -   $
��Auto=�$
��Auto=�.���� $��
10 10 10 0q�.+��� -    ��Name$ listShoolBoy��$��0q�
������  � FocusVisualStyle Z� ���� .R�� .+��� $ 
Horizontal=�.+��� $��60��$��0 5 0 5q�
����  �$��1q�$ 10�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 20Q�    Opacity$  .5Q�!   ShadowDepth$! 1Q�._��� $��ReceiverColor�����	#FF96B2E4$��2q�$ 10��._�� .+��� $
��Mask��
����������	#FF3B5998$��0q�$ 10���� .+��� " ��Name$" imageShoolBoy��-   $
��Fill=�# J� SnapsToDevicePixels# . $��3q����� $ �� Path$$ SchoolBoy.Img�% �� TargetNullValue% ��/Resources/user.png�� �� $��	10 0 10 0q�$%��Открыть картинку��& J� OpacityMask& !� ' !� Visual' �� $
 Mask���� $��7 4 0 0q�.+��� $ 
Horizontal=�.+�  $ iconName��$ 1��$ AddressCard=�$
��Left=�
 �����$��3 0 0 0q��� $��10 0 0 0q�$
��Bold"�$��13(� 	 
tbListView#��[	 ���� *SchoolBoy.FullName+�� $ 
Horizontal=�.+�  $ 1��$ Users=�$
��Left=�
 �����$��3 0 0 0q��� $��10 0 0 0q����� *SchoolBoy.NamberClasses+( �� StringFormat$( Класс: {0}���� $ 
Horizontal=�.+�  $ 1��$��16��$ MapMarkerAlt=�$
��Left=�
 �����$��3 0 0 0q��� $��10 0 0 0q����� *SchoolBoy.Address+$( Адрес: {0}���� $��Center=�$��Right=�$��	50 4 60 0q�.+��� $ 
Horizontal=�.+�  $��16��$
 User=�
 ������� $��10 0 0 0q����� *Login+$( Логин: {0}���� $ 
Horizontal=�.+�  $��16��$
 Lock=�
 ������� $��10 4 0 0q����� *
Password+$( Пароль: {0}���� $ 
Horizontal=�.+�  $��16��$ Whatsapp=�
 ������� $��10 4 0 0q����� *SchoolBoy.Telephone+$( Телефон: {0}���� $ btnEditShoolBoy��-    
 btnEditImage#��[
 |�.  $��Right=�$��0 4 3 0q�$	��Top=�.��  $
 Edit=�$��16��#��[  �� $
��auto��$��	10 0 10 0q�$/��)Редактировать ученика���� -   ) ��Name$) borderImageShol��$y�	Collapsed=�$ 10��
������ ._�� * � ColumnDefinitions* �� $	��140 ��� $��* ��� $	��140 �.+��� 
�������$ 	10 0 0 10��+ J� Opacity$	+ 0.5Q�$��0���� -   $ btnBorderShoolBoy��$��1��$��	0 17 10 0q�  btnCross#��[ $	��Top=�$��Right=�$ 1��.��    iconCrossStyle#��[ $��	16 -6 0 0q�$
 Plus=�z��� , �� Angle$, 44Q� �� $%��Закрыть картинку��$
��auto��$��	10 0 10 0q��� 
�������$	+ 0.5Q�$��1���� 
�������$��	0 10 0 10q�$ 10��$��1��._�� .+��� $��5q����� $	$ Img�% ��/Resources/user.png���� 
�������$ 	0 10 10 0��$	+ 0.5Q�$��2��� -   $ gridTeashers��$y�	Collapsed=�.+��� -   $ btnAppdateTeachers��$y�	Collapsed=��� $��Учителя��#��[  � $
��Left=�$	��Top=�$��0 30 0 0q�.+��� $ 
Horizontal=�.+��� -   $ pageMinysTesters1��#��[ $ 1��.��  -   $ iconBackDateTechers��$ 	AngleLeft=�$��16��#��[  �� $
��auto��$��	10 0 10 0q�$+��%Предыдущая страница���� -   $ pagePlusTesters1��#��[ $ 1��$��	-13 0 0 0q�.��  $ 
AngleRight=�$��16��#��[  �� $
��auto��$��	10 0 10 0q�$)��#Следующая страница���� -   $ btnAdTeachers��$
��Left=�$ 1��$	��Top=�|�.  $��	70 40 0 0q�#��[ .���� $ 
Horizontal=�.+�  $ Ad=�$��0q�$��20��#��[ �� $%��Добавить учителя��#��[ �� -   $ btnDeleteTeachers��$��Right=�$ 1��$	��Top=�|�.  $��
70 40 25 0q�#��[ .���� $ 
Horizontal=�.+�  $ TrashAlt=�$��0q�$��20��#��[ �� $/��)Заблокировать учителя��#��[ � $	 
Horizontal=�$��Stretch=�$	��Top=�$
��auto��$��	105 0 0 0q�$
��auto��.+��� -   $
 tbPoiskSTeachers��#��[ $	��Top=�$��	110 3 0 0q�$	��350��$
��Left=�.�� �� $
��auto��$��	10 0 10 0q�$$��ФИО, логин, адрес��.����  .  $��Поиск:��$
��Bold"�$��
-340 9 0 0q�$	��Top=�
���iii�$
��Left=����� " ��.���  � y�$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text+$ tbPoiskSTeachers��  .a���  � y�$ Visible=��� -   $ btnPoiskTeachers��#��[ $ 1��$��	-60 7 0 0q�$	��Top=�$
��Left=� . .��  #��[  _� $	��270��$��60��#��[ �� -   $ 
tbInfotext��$ 1��$y�	Collapsed=�$��Center=�$��Center=�$ 
Horizontal=�.+�  $ Frown=� �#5b60c4$��70��$��70���� $&�� Ничего не найдено��$��20 0 0 0q�$��26(�#��[ �� $ 10��$��10 75 20 20q����� $	 1,0&�$	 0,1&�.��� $ #4169E1��$ 0Q�� $ #ADD8E6��$ 1Q�._�� .+�� .+��� -   $
��Auto=�$
��Auto=�.���� $��
10 10 10 0q�.+��� -   $ listTechers��$��0q�
������  Z� ���� .R�� .+��� $ 
Horizontal=�.+��� $��60��$��0 5 0 5q�
����  �$��1q�$ 10��   $ 20Q�$  .5Q�$! 1Q�._��� $��ReceiverColor�����	#FF96B2E4$��2q�$ 10��._�� .+��� $
��Mask��
����������	#FF3B5998$��0q�$ 10���� .+��� $" imageShoolBoy��-   $
��Fill=�# . $��3q����� $$ Teachers.Img�% ��/Resources/user.png�� �� $��	10 0 10 0q�$%��Открыть картинку��& !� ' �� $
 Mask���� $��7 4 0 0q�.+��� $ 
Horizontal=�.+�  $ iconName��$ 1��$ AddressCard=�$
��Left=�
 �����$��3 0 0 0q��� $��10 0 0 0q�$
��Bold"�$��13(�#��[	 ���� *Teachers.FullName+�� $ 
Horizontal=�.+�  $ 1��$ Users=�$
��Left=�
 �����$��3 0 0 0q��� $��10 0 0 0q����� *Teachers.NamberClasses+$( Класс: {0}���� $ 
Horizontal=�.+�  $ 1��$��16��$ MapMarkerAlt=�$
��Left=�
 �����$��3 0 0 0q��� $��10 0 0 0q����� *Teachers.Address+$( Адрес: {0}���� $��Center=�$��Right=�$��	50 4 60 0q�.+��� $ 
Horizontal=�.+�  $��16��$
 User=�
 ������� $��10 0 0 0q����� *Login+$( Логин: {0}���� $ 
Horizontal=�.+�  $��16��$
 Lock=�
 ������� $��10 4 0 0q����� *
Password+$( Пароль: {0}���� $ 
Horizontal=�.+�  $��16��$ Whatsapp=�
 ������� $��10 4 0 0q����� *Teachers.Telephone+$( Телефон: {0}���� $ btnEditTeashers��-    #��[
 |�.  $��Right=�$��0 4 3 0q�$	��Top=�.��  $
 Edit=�$��16��#��[  �� $
��auto��$��	10 0 10 0q�$/��)Редактировать ученика���� -!   $) borderImageTeachers��$y�	Collapsed=�$ 10��
������ ._�� * �� $	��140 ��� $��* ��� $	��140 �.+��� 
�������$ 	10 0 0 10��$	+ 0.5Q�$��0���� -"   $ btnBorderTeashers��$��1��$��	0 17 10 0q�#��[ $	��Top=�$��Right=�$ 1��.��  #��[ $��	16 -6 0 0q�$
 Plus=�z��� $, 44Q� �� $%��Закрыть картинку��$
��auto��$��	10 0 10 0q��� 
�������$	+ 0.5Q�$��1���� 
�������$��	0 10 0 10q�$ 10��$��1��._�� .+��� $��5q����� $	$ Img�% ��/Resources/user.png���� 
�������$ 	0 10 10 0��$	+ 0.5Q�$��2��� -#   $ gridLibrarian��$y�	Collapsed=�