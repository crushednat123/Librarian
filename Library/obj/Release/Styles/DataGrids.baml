   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DataGridRow.Height  DataGrid.BorderThickness  u� Bottom u� Left u� Right
 u� Top   ColumnHeader.BorderThickness  DataGridRow.BorderThickness  DataGrid.BorderBrush �� Color  ColumnHeader.Background  ColumnHeader.BorderBrush  DataGridRow.BorderBrush ! DataGridRow.Normal.Background !	 DataGridRow.Normal.Foreground $
  DataGridRow.MouseOver.Background $  DataGridRow.MouseOver.Foreground # DataGridRow.Selected.Background # DataGridRow.Selected.Foreground&    System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value  Style_HeaderGripper �� 
TargetType	 �� Padding=  7System.Windows.Controls.Primitives.DataGridColumnHeader
 � ColumnDefinitions ��Name n�Name �� Triggers P� Property P� Value �� 
TargetName)  #System.Windows.Controls.DataGridRow J� SnapsToDevicePixels � UseLayoutRounding?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter#    RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7  1System.Windows.Controls.DataGridHeadersVisibility
   Row!    HeadersVisibilityConverter*	  $System.Windows.Controls.DataGridCell �� Triggers�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     .sys&clr-namespace:System;assembly=mscorlib  VthemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  %�  &	        &	      &	 1     &	 V     &	 {     &	 �     &	 �     &	 �     &	 �     &		 �     &	
 �     &	      &	     &	 &    '   9    7  7  7   &	     '  �    7  7  7  7  '  �    7  7  7  7  7   7  7 
 7  7  '	  
    X�33Q�u� $  1Q�$ 1Q�$ 1Q�$ 1Q�u� $  0Q�$ 0Q�$ 1Q�$ 0Q�u� $  0Q�$ 0Q�$ 0Q�$ 1Q��� $ #E9ECF1���� $ #F6F7FB���� $ #E9ECF1���� $ #E9ECF1���� $ #FFFFFF���� $ #000000���� $ #F6F7FB���� $ #000000���� $ #F6F7FB���� $ #000000���� "   .���  �@  RowHeaderWidth$ 0Q���  � ��8   ��  �@  HeadersVisibility$ Column=���  � ��8  ��  � ��
 �������   �@  HorizontalGridLinesBrush �	#00E9ECF1��  �@  VerticalGridLinesBrush �	#00E9ECF1��  �@�UseLayoutRounding . ��  �@J�SnapsToDevicePixels . ��  �@  AutoGenerateColumns .  ��  �@  CanUserAddRows .  ��  �@  CanUserReorderColumns . ��  �@  CanUserResizeColumns . ��  �@  CanUserResizeRows . ��  �@  CanUserSortColumns . ��  �@  GridLinesVisibility$ 
Horizontal=���  �@  
IsReadOnly . ��  �@  	RowHeight8  ��  �@  SelectionMode$ Single=��� " n�.���  � ��$ 1����  � ��
 �   ���  �@�Cursor$ SizeWE����  � �� �� " n�.R��� #	 z��#��z���� "  .���  �@J�SnapsToDevicePixels . ��  � �� �#000000��  � ��$ 12(���  � ��$ Comic Sans MS)���  �@�Cursor$
 Hand����  � ��$ 28����  � �� �� "  .R�� 
 �� $��* ��� $
��Auto �.+��� $ BackgroundBorder��8��  8�� $��2���� $��6,3,6,3q�$��Center=�$
��Left=�n� $ PART_LeftHeaderGripper��
������ $
��Left=�8�� n� $ PART_RightHeaderGripper��$��Right=�8��  P�  �@ DisplayIndex$ 0��. ��� $ PART_LeftHeaderGripper�� � y�$ 	Collapsed=��� "  .���  � ��8   ��  � ��8  ��  �@J�SnapsToDevicePixels . ��  �@�UseLayoutRounding . ��  �@=�ErrorTemplate Z� ��  � ��8  ��  � ��8  ��  �@ ValidationErrorTemplate �� .R��� $��0,0,0,0q�$��Center=�
���  ��$��!����  � �� �� "  .R��� $ 
DGR_Border��$��0,0,0,-1q�#��z��#��z��#��z�� .  . ._�  
 �� $
��Auto ��� $��* � �� $��* �8�� �� $
��Auto �.+�  $��1��#��z # z   $��1��$��1��#y�z  �� *AreRowDetailsFrozen+# Z # Z  �� "     $��2��$ Vertical=�y��� *HeadersVisibility+# Z # Z  �� "    P�  �@J�IsMouseOver . . ��� 8   � ���� 8   � ��P�  �@ 
IsSelected . . ��� 8   � ���� 8   � ���� " 	 .���  � �� �� " 	 .R��� $ Bg��
������  . ._��� $��Center=�$��Center=� P�  �@	 
IsSelected . . ���  � ��
 ���� ��  � �� �#000000