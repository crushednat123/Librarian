   M S B A M L   `   `   `  ����   Library5    /Library.Pages.PageLibrarian.Pages.SuppliersPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  -     N�Name$  pageSlipper�� N� Title$ SuppliersPage��.���  � RowDefinitions �� $��70 ��� $��* �.+�� $��0��.+��� -    ��Name$ btnAdSupplier��$
��Left=� K� ZIndex$ 1��|�.  $��	10 30 0 0q�   btnChekTecher#��[  .����  �� Orientation$ 
Horizontal=�.+�!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Ad=�$��0q�$��20��  fa:IconImage#��[ �� $+��%Добавить поставщика��  menuButtonText#��[ �� -   $ btnDeleteSuplier��$��Right=�|�.  $��	0 30 20 0q�#��[  .���� $ 
Horizontal=�.+�  $ TrashAlt=�$��0q�$��20��#��[ �� $)��#Удалить поставщика��#��[ �� $��Поставщики��$��
10 -22 0 0q�  	TextTitle#��[ �  � Orientation$ 
Horizontal=�$��Stretch=�$	��Top=�$
��auto��$��	280 0 0 0q�$
��auto��.+��� -    ��Name$ tbDafaultDate��  tbPoiskStyle#��[ $	��Top=�$��0 0 0 5q�$	��300��$
��Left=�.��	 � ToolTip	 �� $
��auto��$��	10 0 10 0q�$f��`Поиск: по ФИО, по телефону, по фирме, номер поставщика��.���� -   
 ��Name$
 Placeholder�� J� IsHitTestVisible .  $
��Wrap=�$��Поиск:��$
��Bold"�$��Stretch=�
���iii�$��
-294 6 0 0q�$
��Left=�����  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ tbDafaultDate�� �� Value  .a���  � y�$ Visible=��� -   $ btnPoisk��  btnCrossAndRollUp#��[ $ 1��$��	-62 5 0 0q�$	��Top=�$
��Left=� �� 	IsDefault . .��    	poiskIcon#��[ 	 _� $	��270��$��60��  ToolTipPoisk#��[ � $	��230��$��50��$��0 -6 0 0q�.+��� -    ��Name$ 
cbChekDate��$
��Left=�$	��200��$��0 -7 0 0q�$��30��.@��� $%��Связанные записи��$��2 -2 0 0q��� $*��$Не связанные записи��$��2 -2 0 0q�  -     Name$ 	iconItems��$ 1��$
 Bars=�$
��Left=�$	��Top=�   
Foreground
 �����$��	10 14 0 0q��� -	   $ 	btnApdate��  	btnApdate#��[ $	��Top=�$��0 12 0 0q�$��Right=�|�.  .��  
 �����$ RedoAlt=�	 _� $	��105��$��40�� 	 ToolTipApdate#��[	 � $��1��.+��� -
    ��Name$ tbInfo��$y�	Collapsed=�$ 1��$��Center=�$��Center=�$ 
Horizontal=�.+�  $ Frown=� �#5b60c4$��70��$��70���� $&�� Ничего не найдено��$��20 0 0 0q�$��26(�#��[ ��  �� CornerRadius$ 10��$��
10 0 20 20q�����  �� 
StartPoint$	 1,0&� �� EndPoint$	 0,1&�.���  � Color$ #4169E1�� � Offset$ 0Q�� $ #ADD8E6��$ 1Q�._��� -   $
��Auto=�$
��Auto=�.���� $��
10 10 10 0q�.+��� -    ��Name$ listSuppliers��$��0q�
������ ���� .R�� .+��� .+��� $ 
Horizontal=�.+�  $ iconName��$ 1��$ AddressCard=�$
��Left=�
 �����$��3 0 0 0q��� $��
15 10 0 10q����� *SupplierName+ �� StringFormat$ ФИО:          {0}���� $ 
Horizontal=�.+�  $ 	iconPhone��$ 1��$ Whatsapp=�$
��Left=�
 �����$��	3 -10 0 0q��� $��	15 0 0 10q����� *	Telephone+$ Телефон:    {0}���� $ 
Horizontal=�.+�  $ 	iconFirma��$ 1��$ Archway=�$
��Left=�
 �����$��	3 -10 0 0q��� $��	15 0 0 10q����� *Firm+$ Фирма:        {0}���� $ 
Horizontal=�.+�  $ iconPostovhik��$ 1��$ TruckMoving=�$
��Left=�
 �����$��	3 -10 0 0q��� $��	15 0 0 10q����� *TypeSuppliers.Type+$ Поставщик:   {0}���� $
��auto��$��Center=�$��
9 -20 10 0q����� *Id+$* $Номер постовщика: {0}���  �Name$ 
gridButton�� 
 	checkRole#��[
 $��Right=�$��	0 10 10 0q�.+��� $ btnEditSlupper��-   |�.  $��Right=�$	��Top=�  btnEditImage#��[ .��  $
 Edit=�$��16��  fa:IconImageTopButton#��[ 	 _� $	��140��.���� $+��%Редактировать книгу��