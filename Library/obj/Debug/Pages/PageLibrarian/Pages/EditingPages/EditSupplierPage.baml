   M S B A M L   `   `   `  ����  LibraryE    ?Library.Pages.PageLibrarian.Pages.EditingPages.EditSupplierPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44mask)http://schemas.xceed.com/wpf/xaml/toolkit  5        N� Title$  EditSupplierPage��5
       � FocusVisualStyle 5      Z� .��5      �� -   5         ��Name$ border��5      $��10 10 15 10q�5   	   
������� �� CornerRadius$ 10��5   ,   |�.  5      Z� ._�5   
   �� -   5         ��Name$ 
stackPanel��5   0   $��Stretch=�5      $��Center=�5      $��30q�5      .+�5      �� -   5        $��tbNameAndSurName��5   :   $��0��5         TextBox#��[  6A   $��0 10 0 0q�5      $
��auto��6,   ��5   #   �� *SupplierName+5   :   !  FontAwesome.Sharp.IconImage  5      -   5          Name$ 	iconLogin��5      �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ AddressCard=�6.   $
��Left=�5         
Foreground
 �����$��
13 -30 0 0q�5   1   �� 5      -   5         ��Name$ Placeholder��5      	 J� IsHitTestVisible	 .  $
��Wrap=�5        $��ФИО:��5!       $��
35 -30 0 0q�5"       $��Center=�5$       
�������$
��Left=�5&       ��5(      �� 5)      
 �� 
TargetType"
 ��6   .�5*      ��  �� Property � y� �� Value$ 	Collapsed=�67   �� 5+       � ��$ Comic Sans MS)�68   �� 5,       � ��$
 Bold"�67    �� Triggers 5-      �� 5.       �� Binding 6*   �� *Text+ �� ElementName$ tbNameAndSurName�� �� Value  6a   .a�5/   "   ��  � y�$ Visible=�6?   50      52      54      �� 58      $��Right=�6   $��	0 0 10 20q�64   ��59      �� 5;      "
 ��6   .�5<      ��  � ��$ Comic Sans MS)�68   �� 5=       � ��$
 Bold"�67    5>      �� 5?       6*   �� *Text.Length+$ tbNameAndSurName�� 506h   .a�5@   "   ��  � ��
 �  ��6?   5A      5C      �� 5E      �6   �� *Text.Length+$ tbNameAndSurName�� �� Mode$ OneWay=�/�� 6_   �6c   �� *	MaxLength+$ tbNameAndSurName��5G      %  Xceed.Wpf.Toolkit.MaskedTextBox  5K      -   5        $��tBPhone��5N   9   $��2��5K   !   #��[  6I    �� 	MaxLength$ 18��5L         Mask$ +7 (000)-000-00-00��6(   $��10 0 0 0q�5M      $��0 0 0 25q�5N      $
��auto��6+   ��5K   .   �� *	Telephone+.��5N   H    � ToolTip 5P      �� 5Q      $��65��6    $��10 0 0 0q�6+   $��Телефон��6=   .��5R   #   5S        5U      -   5        $ 	iconPhone��5U       K� ZIndex$ 1��6.   $ Whatsapp=�6?   $
��Left=�5V      
 �����$��
13 -80 0 0q�5W   /   �� 5Y      -   5        $ PlaceholderPhone��5Y      	 .  $
��Wrap=�5Z       $��Телефон��5[       $��35 -105 0 0q�5\       $��Center=�5^       
�������$
��Left=�5`       ��5b      �� 5c      "
 ��6   .�5d      ��  � y�$ 	Collapsed=�67   �� 5e       � ��$ Comic Sans MS)�68   �� 5f       � ��$
 Bold"�67    5g      �� 5h       6*   �� *Text+$ tBPhone��  6X   .a�5i   "   ��  � y�$ Visible=�6?   5j      5l      5n      �� 5r      -	   5        $��tbFirma��5t   :   $��0��5r      #��[  69   $��0 10 0 0q�5t      $
��auto��6,   ��5r   #   �� *Firm+5t   :     5v      $ Archway=�6   $
��Left=�5w      
 �����$��
13 -30 0 0q�5x   1   �� 5z      -
   5        $ PlaceholderFirma��5z      	 .  $
��Wrap=�5{       $��Фирма:��5|       $��
35 -30 0 0q�5}       $��Center=�5       
�������$
��Left=�5�       ��5�      �� 5�      "
 ��6   .�5�      ��  � y�$ 	Collapsed=�67   �� 5�       � ��$ Comic Sans MS)�68   �� 5�       � ��$
 Bold"�67    5�      �� 5�       6*   �� *Text+$ tbFirma��  6X   .a�5�   "   ��  � y�$ Visible=�6?   5�      5�      5�      �� 5�      $��Right=�6   $��	0 0 10 20q�64   ��5�      �� 5�      "
 ��6   .�5�      ��  � ��$ Comic Sans MS)�68   �� 5�       � ��$
 Bold"�67    5�      �� 5�       6*   �� *Text.Length+$ tbFirma�� 506_   .a�5�   "   ��  � ��
 �  ��6?   5�      5�      �� 5�      �6   �� *Text.Length+$ tbFirma��$ OneWay=�/�� 6V   �6Z   �� *	MaxLength+$ tbFirma��5�      �� 5�      -   5         ��Name$ cBPostovhik��5�      $��	0 -1 0 20q�5�      $��30��5�      $
��auto��5�   .    �� DisplayMemberPath$
 Type��5�       �� SelectedItem 5�      �� *TypeSuppliers+ 5�      �� 5�      $	��110��6    $��9 0 0 0q�6,   $#��Поставщик книги��6=   5�        5�      -   5        $ iconPostohkik��5�      $ 1��62   $ TruckMoving=�6C   $
��Left=�5�      
 �����$��
10 -70 0 0q�5�   -   �� 5�      -   5         ��Name$ btnSave��5�   6   $��7��6   $��Сохранить��6"   $��0 20 0 0q�5�   +   $
��auto��5�      5�      5�      5�      