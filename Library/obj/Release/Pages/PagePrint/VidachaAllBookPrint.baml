   M S B A M L   `   `   `  ����   Library1    +Library.Pages.PagePrint.VidachaAllBookPrint   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  -     N� Title$  VidachaAllBookPrint��.���  � RowDefinitions �� $��* ��� $��40 �.+�,� $��0��$ ,� HorizontalScrollBarVisibility$
 Auto=�" ,� VerticalScrollBarVisibility$
 Auto=�.��/� -    /�Name$ flowDocument�� /� 
Background
 ����� /� ColumnWidth$
 auto�� /� MinPageHeight$	 700�� /� 
FontFamily$ Comic Sans Ms)�.T��� .r�&   System.Windows.Controls.DataGrid  -   	  Name$	 dateGrid��$
��auto��$��Hidden=�
   CanUserResizeColumns
 .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Номер книги��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 98 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Books.NamberBook+  $! Название книги��$	 180  �� *Books.NameBook+  $ Выдана��$	 183  �� *
FullName+  $ Тип��$	 158  �� *	TypeUsers+  $ Дата выдачи��$	 176  �� *DateOfISsue+ �� StringFormat$ {0:dd.MM.yyyy}��  $
 До��$ *  �� *	EndDate+$ {0:dd.MM.yyyy}��� 
������� J� Opacity$	 0.7Q�$��1���� -    ��Name$ btnPrint��$��Center=� K� ZIndex$ 1��$��1��|�.  $��10 0 0 0q�   btnPrint#��[  .����  �� Orientation$ 
Horizontal=�.+�!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Print=�$��0q�$��20��  fa:IconImagepRrint#��[ �� $��Печать��  menuButtonText#��[ 