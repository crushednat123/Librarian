   M S B A M L   `   `   `  ����  Library@    :Library.Pages.PageTeacher.PagesTeachers.Pages.EditBookPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      -   5          N� Title$  EditBookPage��5	      .��5      �� -   5         ��Name$ border��5      $��25 10 25 20q�5   	   
������� �� CornerRadius$ 10��5   ,   |�.  � FocusVisualStyle 5   	   Z� ._�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��60 �6    .+�5      �� $��Center=�62   $	��Top=�6O   $��0 4 0 0q�5   #   $��20(�64   ��5      �� *
NameBook+5   4   �� 5      -   5         ��Name$ tbRole��5   q   $y�	Collapsed=�66      
tbListView#��[  6M   ��6   �� *IdRoleChekss+6q   �� 5      -   5        $ tbElectroni��5        
tbDocyment#��[ 6.   $y�	Collapsed=�6R   �� 5       -   5        $ tbImageCheck��5       $y�	Collapsed=�6F   ��6.   �� *Image+6F   �� 5!      -   5        $ tbImage��5!      $y�	Collapsed=�6)     tbImageCheck#��[ 6@   �� 5$      -   5        $ tbIdBook��5%   2   $y�	Collapsed=�5$   ,    K� ZIndex$ -1��5%       ��5$      �� *Id+5%   2   �� 5'      -   5        $ tbElectronic��5'      $y�	Collapsed=�6Q   ��6.   �� *ElectronicVersion+6Q   � 5)      $��0��6   $��Stretch=�6    $��Center=�6>   .+�5+      � .+�5,      � $��1��6   $��	10 0 10 0q�6(   .+�5-      �� .+�5.      �� .+�51   "   �� -	   5         ��Name$ 
tbNameBook��52   -   $��0 0 0 20q�51   *   $
��auto��6>     textBoxChekRole#��[ 6K   ��53   -   �� *
NameBook+.��6G    � ToolTip 54   &   �� 55   *   $	��110��64   $��15 0 0 0q�6@   $!��Название книги��6R   .��56   7   57   #   !  FontAwesome.Sharp.IconImage  59   "   -
   5        	  Name$	 iconNameBook��59   /   $ 1��6E   �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]
   Icon$

 Book=�6V   $
��Left=�5:   1      
Foreground
 �����$��
10 -70 0 0q�5;   C   �� 5?   "   -   5        $ textBoxImage��5?   O   $��0 0 0 20q�6*    �� 
IsReadOnly . $
��auto��6f     TextBoxImage#��[ 6s   ��5A   %   ��  �� ElementName$ tbImage�� �� Path$
 Text�.��6U    5B   &   �� 5C   *   $��60��64   $��10 0 0 0q�6?   $��Картинка��6Q   .��5D   7   5E   #     5F   "   -   5        $	 	iconImage��5F   /   $ 1��6B   $
 Images=�6S   $
��Left=�5G   )   
 �����$��
10 -70 0 0q�5H   ;   �� 5J   "   -   5         ��Name$ btnEditImage��5J   )   |�.  $��	0 -68 5 0q�5L   )     btnEditFale#��[ 6<   .��5M   &     $
 Ad=�63   $��16��6=     fa:IconImageTopButton#��[ 6I    5N   &   _� 5O   *   $	��130��62   .��5P   .   �� $'��!Изменить картинку��68   5Q   +   5S   #   �� 5Y   "   -   5        $ textBoxDocument��5Z   %   $��0 0 0 20q�5Y   *    . $
��auto��5[   %     TextBox#��[ 62   ��5Y   =   �� $ tbElectroni��$
 Text�.��5[   S    5\   &   �� 5]   *   $��65��64   $��10 0 0 0q�6?   $��Документ��6Q   .��5^   7   5_   #     5a   "   -   5        $	 iconDocument��5a   /   $ 1��6E   $
 FileAlt=�6V   $
��Left=�5b   )   
 �����$��
10 -70 0 0q�5c   ;   �� 5f   "   -   5        $ btnEditDocument��5f   )   |�.  $��	0 -68 5 0q�5h   )   #��[ 6<   .��5i   &     $
 Ad=�63   $��16��6=   #��[ 6I    5j   &   _� 5k   *   $	��130��62   .��5l   .   �� $'��!Изменить документ��68   5m   +   5o   #   5q      �� 5r      $��0 0 0 0q�6)   .+�5s   "   �   checkRolePageLib#��[ 6'    � ColumnDefinitions 5t   &   �� 5u   *   $��* �6;   �� 5v   *   $��* �6;   .+�5y   &   � $��0��6+   $��0 0 10 0q�6;   #��[ 6M   .+�5z   *   �� .+�5|   .   �� -   5        $ tbNumberBook��5}   6   $��0 0 0 20q�5|   6   $
��auto��6J   #��[ 6W   ��5~   6   �� *
NamberBook+.��6R    5   2   �� 5�   6   $��90��6@   $��15 0 0 0q�6K   $��Номер книги��6]   .��5�   C   5�   /     5�   .   -   5        $	 iconNameBool��5�   ;   $ 1��6Q   $
 Pager=�6b   $
��Left=�5�   ;   
 �����$��
10 -70 0 0q�5�   M   (  "System.Windows.Controls.DatePicker  5�   .   -   5          Name$ dpYearPublisher��5�   9   $��0 0 0 20q�5�   9   $
��auto��6M      SelectedDate 5�   9   �� *YearOfPublication+ �� StringFormat$ 
dd.MM.yyyy�� 5�   2   �� 5�   6   $��90��6@   $��15 0 0 0q�6K   $��Год издания��6]   5�   /     5�   .   -   5        $	 iconCalendar��5�   ;   $ 1��6Q   $
 CalendarAlt=�6b   $
��Left=�5�   ;   
 �����$��	7 -69 0 0q�5�   M     5�   .   -   5        $ dpDatePostavka��5�   9   $��0 0 0 20q�5�   9   $
��auto��6M    5�   9   �� *DeliveryDate+$ 
dd.MM.yyyy�� 5�   2   �� 5�   6   $��90��6@   $��6 0 0 0q�6K   $��Дата поставки��6\   5�   /     5�   .   -   5        $	 iconCalendarPostavha��5�   ;   $ 1��6Y   $
 CalendarAlt=�6j   $
��Left=�5�   ;   
 �����$��	7 -70 0 0q�5�   M   �� 5�   .   -   5        $ textBoxCost��5�   6   $��	0 0 0 20 q�5�   6   $��0��6I   $
��auto��5�   6   #��[ 6C   ��5�   Y   �� *Cost+$ {0:n2}�� 5�   6   Z� .��5�   d    5�   2   �� 5�   6   $��40��6@   $��10 0 0 0q�6K   $��Цена��6]   .��5�   C   5�   /     5�   .   -   5        $	 iconCost��5�   ;   $ 1��6M   $
 MoneyBillWave=�6^   $
��Left=�5�   ;   
 �����$��
10 -70 0 0q�5�   M   5�   +   5�   '   � 5�   &   $��1��6+   $��10 0 0 0q�6;   #��[ 6M   .+�5�   *   �� .+�5�   .   �� -   5        $ tbAvtorBook��5�   6   $��0 0 0 20q�5�   6   $
��auto��6J   #��[ 6W   ��5�   6   �� *AuthorOfThebook+.��6W    5�   2   �� 5�   6   $��90��6@   $��15 0 0 0q�6K   $��Автор книги��6]   .��5�   C   5�   /     5�   .   -   5        $	 iconUser��5�   ;   $ 1��6M   $
 UserAlt=�6^   $
��Left=�5�   ;   
 �����$��
10 -70 0 0q�5�   M   �� 5�   .   -   5         ��Name$ cBPostovhik��5�   7   $��	0 -1 0 20q�5�   7   $��30��5�   7   $
��auto��5�   N    �� DisplayMemberPath$ SupplierName��5�   7    �� SelectedItem 5�   7   �� *DeliveryServices+ 5�   2   �� 5�   6   $
��auto��6@   $��9 0 10 0q�6M   ��6_   �� *DeliveryServices.Id+$* $Номер постовщика: {0}��5�   /     5�   .   -   5        $	 iconPostohkik��5�   ;   $ 1��6R   $
 TruckMoving=�6c   $
��Left=�5�   =   
 �����$��
10 -70 0 0q�5�   O   �� 5�   .   -   5        $ cbItems��5�   7   $��	0 -2 0 20q�5�   7   $��30��5�   7   $
��auto��5�   7   $
 Name��5�   7    5�   D   Z�  5�   7   �� *Items+ 5�   2   �� 5�   6   $	��100��6@   $��9 0 0 0q�6L   $��Предмет книги��6]   5�   /     5�   .   -   5        $
	 icon��5�   ;   $ 1��6I   $
 Bookmark=�6Z   $
��Left=�5�   ;   
 �����$��
10 -70 0 0q�5�   M   �� 5�   .   -   5        $ 
cbBoxClass��5�   7   $��	0 -2 0 20q�5�   7   $��30��5�   7   $
��auto��5�   7   $ NamberClasses��5�   7    5�   D   Z�  5�   7   �� *	Classes+ 5�   2   �� 5�   6   $��45��6@   $��10 0 0 0q�6K   $��
Класс��6]   5�   /     5�   .   -    5        $	 	iconClass��5�   <   $ 1��6O   $
 Users=�6`   $
��Left=�5�   <   
 �����$��
10 -69 0 0q�5�   N   5   +   5  '   � 5  &   -!   5         �Name$ 	gridLocal��5  ?   $��2��6+   .+�5  *   �� -"   5        $ cbBoxLocalBok��5  5   $��
0 195 0 20q�5  3   $��30��5  5   $
��auto��5  5   $ NameZal��5
  5    5  5   �� *	Locacia+ �� Mode$ OneWay=� 5  B   Z�  5  .   �� 5  2   $	��150��6<   $��10 0 0 0q�6H   $-��'Местоположение книги��6Z   5  +     5  *   -#   5        $	 iconLocalBook��5  8   $ 1��6O   $
 MapMarkerAlt=�6`   $
��Left=�5  9   
 �����$��
10 175 0 0q�5  K   5  '   5  #   5     5     � 5      	 checkRoleTeacher#��[	 6    .+�5     �� -$   5        $ btnSave��5  F   $��7��6%   $��Сохранить��62   $
��auto��5  -   5     5      5!     5#     � 5%     $��1��6   $��10 0 0 0q�6    .+�5&     ��  �� Orientation$ 
Horizontal=�6   .+�5'     �� $��Картинка��6      5(     -%   5        $	 iconChek��5(  #    
 iconImageChekImage#��[
 65   $
 CheckCircle=�6b   $��
13 -40 0 0q�5)      5*     �� 5,     $��0 20 0 0q�6   $ 
Horizontal=�6/   .+�5.     �� $��Документ��6      5/     -&   5        $	 iconDoc��51     $ 1��50     $
 CheckCircle=�51  .     iconDocumentCheck#��[ 52     $��10  -22 0 0q�53     54     55     56     57     58     