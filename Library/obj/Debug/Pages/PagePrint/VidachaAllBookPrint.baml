   M S B A M L   `   `   `  ����  Library1    +Library.Pages.PagePrint.VidachaAllBookPrint   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      -   5          N� Title$  VidachaAllBookPrint��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   ,� $��0��6#   $ ,� HorizontalScrollBarVisibility$
 Auto=�5      " ,� VerticalScrollBarVisibility$
 Auto=�5      .��5      /� -   5         /�Name$ flowDocument��5       /� 
Background
 ����� /� ColumnWidth$
 auto��6E    /� MinPageHeight$	 700��6X    /� 
FontFamily$ Comic Sans Ms)�6l   .T�5      �� .r�5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dateGrid��5      $
��auto��61   $��Hidden=�6>   
   CanUserResizeColumns
 .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5   #   ,  &System.Windows.Controls.DataGridColumn   Header$ Номер книги��66      Width5  /System.Windows.Controls.DataGridLengthConverter$ 98 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6W   �� *Books.NamberBook+  5   #   $! Название книги��66   $	 180 6N    6Z   �� *Books.NameBook+  5   #   $ Выдана��66   $	 183 6F    6R   �� *
FullName+  5   #   $ Тип��66   $	 158 6C    6O   �� *	TypeUsers+  5   #   $ Дата выдачи��66   $	 176 6K    6W   �� *DateOfISsue+ �� StringFormat$ {0:dd.MM.yyyy}��  5   #   $
 До��66   $ * 6B    6L   �� *	EndDate+$ {0:dd.MM.yyyy}��5"      5#      5$      5%      � 5'   
   
������� J� Opacity$	 0.7Q�6!   $��1��6/   5)      �� 5+   
   -   5         ��Name$ btnPrint��5+      $��Center=�6#    K� ZIndex$ 1��5,      $��1��6$   |�.  $��10 0 0 0q�5/         btnPrint#��[  6$   .��50      ��  �� Orientation$ 
Horizontal=�6   .+�51      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Print=�6   $��0q�6-   $��20��68     fa:IconImagepRrint#��[ 6D   �� 53      $��Печать��6     menuButtonText#��[ 6*   54      55      57      58      