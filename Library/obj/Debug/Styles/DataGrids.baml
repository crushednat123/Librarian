   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 6H   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DataGridRow.Height  DataGrid.BorderThickness  u� Bottom u� Left u� Right
 u� Top   ColumnHeader.BorderThickness  DataGridRow.BorderThickness  DataGrid.BorderBrush �� Color  ColumnHeader.Background  ColumnHeader.BorderBrush  DataGridRow.BorderBrush ! DataGridRow.Normal.Background !	 DataGridRow.Normal.Foreground $
  DataGridRow.MouseOver.Background $  DataGridRow.MouseOver.Foreground # DataGridRow.Selected.Background # DataGridRow.Selected.Foreground&    System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value  Style_HeaderGripper �� 
TargetType	 �� Padding=  7System.Windows.Controls.Primitives.DataGridColumnHeader
 � ColumnDefinitions ��Name n�Name �� Triggers P� Property P� Value �� 
TargetName)  #System.Windows.Controls.DataGridRow J� SnapsToDevicePixels � UseLayoutRounding?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter#    RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7  1System.Windows.Controls.DataGridHeadersVisibility
   Row!    HeadersVisibilityConverter*	  $System.Windows.Controls.DataGridCell �� Triggers�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .sys&clr-namespace:System;assembly=mscorlib  5      VthemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  6H   %�  &	        &	      &	 \     &	 �     &	 �     &	     &	 "    &	 C    &	 d    &		 �    &	
 �    &	 �    &	 �    &	 	    '   *    7  7  7   &	     '  0    7  7  7  7  '  �
    7  7  7  7  7   7  7 
 7  7  '	  ^    X�5   
   33Q�64   u� 5
   
   $  1Q�65   $ 1Q�6@   $ 1Q�6I   $ 1Q�6S   u� 5   
   $  0Q�69   $ 0Q�6D   $ 1Q�6M   $ 0Q�6W   u� 5   
   $  0Q�68   $ 0Q�6C   $ 0Q�6L   $ 1Q�6V   �� 5   
   $ #E9ECF1��67   �� 5   
   $ #F6F7FB��6:   �� 5   
   $ #E9ECF1��6;   �� 5   
   $ #E9ECF1��6:   �� 5   
   $ #FFFFFF��6@   �� 5   
   $ #000000��6@   �� 5   
   $ #F6F7FB��6C   �� 5   
   $ #000000��6C   �� 5!   
   $ #F6F7FB��6B   �� 5#   
   $ #000000��6B   �� 5%   
   "   6   .�5)      ��  �@  RowHeaderWidth$ 0Q�6/   �� 5*       � ��8   60   �� 5+       �@  HeadersVisibility$ Column=�62   �� 5,       � ��8  6+   �� 5-       � ��
 �����6,   �� 5.        �@  HorizontalGridLinesBrush �	#00E9ECF169   �� 5/       �@  VerticalGridLinesBrush �	#00E9ECF167   �� 50       �@�UseLayoutRounding . 62   �� 51       �@J�SnapsToDevicePixels . 64   �� 52       �@  AutoGenerateColumns .  64   �� 53       �@  CanUserAddRows .  6/   �� 56       �@  CanUserReorderColumns . 66   �� 59       �@  CanUserResizeColumns . 65   �� 5;       �@  CanUserResizeRows . 62   �� 5<       �@  CanUserSortColumns . 63   �� 5=       �@  GridLinesVisibility$ 
Horizontal=�64   �� 5>       �@  
IsReadOnly . 6+   �� 5?       �@  	RowHeight8  6*   �� 5@       �@  SelectionMode$ Single=�6.   5A      �� 5I      " n�6(   .�5J   
   ��  � ��$ 1��6"   �� 5K   
    � ��
 �   �6'   �� 5L   
    �@�Cursor$ SizeWE��6#   �� 5N   
    � �� 5O      �� 5P      " n�6"   .R�5Q      �� #	 z��6   #��z��6A   5R      5T      5U      �� 5V      "  6   .�5W   
   ��  �@J�SnapsToDevicePixels . 60   �� 5X   
    � �� �#0000006'   �� 5Y   
    � ��$ 12(�6%   �� 5[   
    � ��$ Comic Sans MS)�6'   �� 5\   
    �@�Cursor$
 Hand��6#   �� 5]   
    � ��$ 28��6#   �� 5^   
    � �� 5_      �� 5`      "  6"   .R�5a      � 
 5b      �� 5c      $��* �6/   �� 5d      $
��Auto �6/   .+�5f      �� $ BackgroundBorder��6!   8��  8�� $��2��6�   �� 5g      $��6,3,6,3q�6+   $��Center=�6<   $
��Left=�6W   n� 5h      $ PART_LeftHeaderGripper��6    
������ $
��Left=�6Y   8�� 6t   n� 5i      $ PART_RightHeaderGripper��6    $��Right=�6A   8�� 6]   5j       5k      P� 5l       �@ DisplayIndex$ 0��6:   . �5m      �� $ PART_LeftHeaderGripper��6M    � y�$ 	Collapsed=�6;   6s   5n      5p      5r      5s      �� 5{   
   "  6   .�5|      ��  � ��8   6+   �� 5}       � ��8  6+   �� 5~       �@J�SnapsToDevicePixels . 64   �� 5       �@�UseLayoutRounding . 62   �� 5�   
    �@=�ErrorTemplate 65   Z� �� 5�       � ��8  60   �� 5�       � ��8  6,   �� 5�       �@ ValidationErrorTemplate 5�      �� 5�      .R�5�      �� $��0,0,0,0q�6$   $��Center=�65   
���  ��$��!��6a   5�      5�      �� 5�       � �� 5�      �� 5�      "  6&   .R�5�      �� $ 
DGR_Border��6   $��0,0,0,-1q�61   #��z��5�      #��z��5�      #��z��5�       .  . ._�5�        
 5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $��* �67    5�   "   �� 5�   &   $��* �64   8�� 6?   �� 5�   &   $
��Auto �64   .+�5�        $��1��65   #��z 5�   5   # z 5�   5     5�      $��1��67   $��1��6D   #y�z 5�   1    5�   1   �� *AreRowDetailsFrozen+# Z # Z  �� "   5�   1     5�      $��2��60   $ Vertical=�6A   y�5�   1   �� *HeadersVisibility+# Z # Z  �� "   5�   O   5�       5�      P� 5�       �@J�IsMouseOver . . �5�   "   �� 8   � ��6?   �� 5�   "   8   � ��6?   5�      P� 5�       �@ 
IsSelected . . �5�   "   �� 8   � ��6?   �� 5�   "   8   � ��6?   5�      5�      5�      5�      �� 5�   
   " 	 6   .�5�      ��  � �� 5�      �� 5�      " 	 6&   .R�5�      �� $ Bg��6!   
������  . ._�5�      �� $��Center=�6/   $��Center=�6L   5�      5�      5�       5�      P� 5�       �@	 
IsSelected . . �5�      ��  � ��
 ���� 63   �� 5�       � �� �#00000063   5�      5�      5�      