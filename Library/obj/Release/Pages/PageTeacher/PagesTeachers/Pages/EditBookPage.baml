   M S B A M L   `   `   `  ����   Library@    :Library.Pages.PageTeacher.PagesTeachers.Pages.EditBookPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  -     N� Title$  EditBookPage��.���� -    ��Name$ border��$��25 10 25 20q�
������� �� CornerRadius$ 10��|�.  � FocusVisualStyle Z� ._��  � RowDefinitions �� $��* ��� $��60 �.+��� $��Center=�$	��Top=�$��0 4 0 0q�$��20(����� *
NameBook+�� -    ��Name$ tbRole��$y�	Collapsed=�   
tbListView#��[  ���� *IdRoleChekss+�� -   $ tbElectroni��  
tbDocyment#��[ $y�	Collapsed=��� -   $ tbImageCheck��$y�	Collapsed=����� *Image+�� -   $ tbImage��$y�	Collapsed=�  tbImageCheck#��[ �� -   $ tbIdBook��$y�	Collapsed=� K� ZIndex$ -1������ *Id+�� -   $ tbElectronic��$y�	Collapsed=����� *ElectronicVersion+� $��0��$��Stretch=�$��Center=�.+�� .+�� $��1��$��	10 0 10 0q�.+��� .+��� .+��� -	    ��Name$ 
tbNameBook��$��0 0 0 20q�$
��auto��  textBoxChekRole#��[ ���� *
NameBook+.�� � ToolTip �� $	��110��$��15 0 0 0q�$!��Название книги��.��!  FontAwesome.Sharp.IconImage  -
   	  Name$	 iconNameBook��$ 1���  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]
   Icon$

 Book=�$
��Left=�   
Foreground
 �����$��
10 -70 0 0q��� -   $ textBoxImage��$��0 0 0 20q� �� 
IsReadOnly . $
��auto��  TextBoxImage#��[ ����  �� ElementName$ tbImage�� �� Path$
 Text�.�� �� $��60��$��10 0 0 0q�$��Картинка��.��  -   $	 	iconImage��$ 1��$
 Images=�$
��Left=�
 �����$��
10 -70 0 0q��� -    ��Name$ btnEditImage��|�.  $��	0 -68 5 0q�  btnEditFale#��[ .��  $
 Ad=�$��16��  fa:IconImageTopButton#��[  _� $	��130��.���� $'��!Изменить картинку���� -   $ textBoxDocument��$��0 0 0 20q� . $
��auto��  TextBox#��[ ���� $ tbElectroni��$
 Text�.�� �� $��65��$��10 0 0 0q�$��Документ��.��  -   $	 iconDocument��$ 1��$
 FileAlt=�$
��Left=�
 �����$��
10 -70 0 0q��� -   $ btnEditDocument��|�.  $��	0 -68 5 0q�#��[ .��  $
 Ad=�$��16��#��[  _� $	��130��.���� $'��!Изменить документ���� $��0 0 0 0q�.+��   checkRolePageLib#��[  � ColumnDefinitions �� $��* ��� $��* �.+�� $��0��$��0 0 10 0q�#��[ .+��� .+��� -   $ tbNumberBook��$��0 0 0 20q�$
��auto��#��[ ���� *
NamberBook+.�� �� $��90��$��15 0 0 0q�$��Номер книги��.��  -   $	 iconNameBool��$ 1��$
 Pager=�$
��Left=�
 �����$��
10 -70 0 0q�(  "System.Windows.Controls.DatePicker  -     Name$ dpYearPublisher��$��0 0 0 20q�$
��auto��   SelectedDate �� *YearOfPublication+ �� StringFormat$ 
dd.MM.yyyy�� �� $��90��$��15 0 0 0q�$��Год издания��  -   $	 iconCalendar��$ 1��$
 CalendarAlt=�$
��Left=�
 �����$��	7 -69 0 0q�  -   $ dpDatePostavka��$��0 0 0 20q�$
��auto�� �� *DeliveryDate+$ 
dd.MM.yyyy�� �� $��90��$��6 0 0 0q�$��Дата поставки��  -   $	 iconCalendarPostavha��$ 1��$
 CalendarAlt=�$
��Left=�
 �����$��	7 -70 0 0q��� -   $ textBoxCost��$��	0 0 0 20 q�$��0��$
��auto��#��[ ���� *Cost+$ {0:n2}�� Z� .�� �� $��40��$��10 0 0 0q�$��Цена��.��  -   $	 iconCost��$ 1��$
 MoneyBillWave=�$
��Left=�
 �����$��
10 -70 0 0q�� $��1��$��10 0 0 0q�#��[ .+��� .+��� -   $ tbAvtorBook��$��0 0 0 20q�$
��auto��#��[ ���� *AuthorOfThebook+.�� �� $��90��$��15 0 0 0q�$��Автор книги��.��  -   $	 iconUser��$ 1��$
 UserAlt=�$
��Left=�
 �����$��
10 -70 0 0q��� -    ��Name$ cBPostovhik��$��	0 -1 0 20q�$��30��$
��auto�� �� DisplayMemberPath$ SupplierName�� �� SelectedItem �� *DeliveryServices+ �� $
��auto��$��9 0 10 0q����� *DeliveryServices.Id+$* $Номер постовщика: {0}��  -   $	 iconPostohkik��$ 1��$
 TruckMoving=�$
��Left=�
 �����$��
10 -70 0 0q��� -   $ cbItems��$��	0 -2 0 20q�$��30��$
��auto��$
 Name�� Z�  �� *Items+ �� $	��100��$��9 0 0 0q�$��Предмет книги��  -   $
	 icon��$ 1��$
 Bookmark=�$
��Left=�
 �����$��
10 -70 0 0q��� -   $ 
cbBoxClass��$��	0 -2 0 20q�$��30��$
��auto��$ NamberClasses�� Z�  �� *	Classes+ �� $��45��$��10 0 0 0q�$��
Класс��  -    $	 	iconClass��$ 1��$
 Users=�$
��Left=�
 �����$��
10 -69 0 0q�� -!    �Name$ 	gridLocal��$��2��.+��� -"   $ cbBoxLocalBok��$��
0 195 0 20q�$��30��$
��auto��$ NameZal�� �� *	Locacia+ �� Mode$ OneWay=� Z�  �� $	��150��$��10 0 0 0q�$-��'Местоположение книги��  -#   $	 iconLocalBook��$ 1��$
 MapMarkerAlt=�$
��Left=�
 �����$��
10 175 0 0q��  	 checkRoleTeacher#��[	 .+��� -$   $ btnSave��$��7��$��Сохранить��$
��auto��� $��1��$��10 0 0 0q�.+���  �� Orientation$ 
Horizontal=�.+��� $��Картинка��  -%   $	 iconChek�� 
 iconImageChekImage#��[
 $
 CheckCircle=�$��
13 -40 0 0q��� $��0 20 0 0q�$ 
Horizontal=�.+��� $��Документ��  -&   $	 iconDoc��$ 1��$
 CheckCircle=�  iconDocumentCheck#��[ $��10  -22 0 0q�