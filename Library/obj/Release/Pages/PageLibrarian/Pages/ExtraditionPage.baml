   M S B A M L   `   `   `  ���� B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Library.Pages.PageLibrarian.Pages!Library.Pages.PageLibrarian.Pages  7    1Library.Pages.PageLibrarian.Pages.ExtraditionPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Alocal/clr-namespace:Library.Pages.PageLibrarian.Pages     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp    N� Title$  ExtraditionPage��.���  � RowDefinitions �� $��70 ��� $��* �.+�� $��0��.+��� -    ��Name$ btnAdExtadition��$
��Left=� K� ZIndex$ 1��|�.  $��	10 30 0 0q�   btnChekTecher#��[  .����  �� Orientation$ 
Horizontal=�.+�!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Ad=�$��0q�$��20��  fa:IconImage#��[ �� $��Добавить��  menuButtonText#��[ �� -   $ btnPrint��$��Center=�$ 1��|�.  $��	10 30 0 0q�#��[  .���� $ 
Horizontal=�.+�  $ Print=�$��0q�$��20��#��[ �� $��Печать��#��[ �� -   $ btnDeleteExtradition��$��Right=�|�.  $��	0 30 20 0q�#��[  .���� $ 
Horizontal=�.+�  $ TrashAlt=�$��0q�$��20��#��[ �� $��Удалить��#��[ �� $��Выдача��$��
10 -22 0 0q�  	TextTitle#��[ �  � Orientation$ 
Horizontal=�$��Stretch=�$	��Top=�$
��auto��$��	180 0 0 0q�$
��auto��.+��� -    ��Name$ tbDafaultDate��  tbPoiskStyle#��[ $	��Top=�$��0 0 0 0q�$	��300��$
��Left=�.�� � ToolTip _� $��60��$
��auto��  vidahaLibrarian#��[ .���� -   	 ��Name$	 Placeholder��
 J� IsHitTestVisible
 .  $
��Wrap=�$��Поиск:��$
��Bold"�$��Stretch=�
���iii�$��
-294 6 0 0q�$
��Left=�����  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ tbDafaultDate�� �� Value  .a���  � y�$ Visible=��� -   $ btnPoisk��  btnCrossAndRollUp#��[ $ 1��$��	-62 5 0 0q�$	��Top=�$
��Left=� �� 	IsDefault . .��    	poiskIcon#��[  _� $	��270��$��60��  ToolTipPoisk#��[ �� $ 
Horizontal=�.+��� -    ��Name$ 
cbChekDate��$	��200��$��30��.@��� $��
Все    ��$
��auto��$��10 0 0 0q�$ 1���� $��  Ученики���� $��  Учителя���� $ ��  Библиотекарь��  -     Name$ 	iconItems��$ 1��$ Users=�$
��Left=�$	��Top=�$��20��$��22��   
Foreground
 �����$��
-190 8 0 0q��� -	   $ 	btnApdate�� 	 	btnApdate#��[	 $��10 0 0 0q�$��30��$	��Top=�$
��Left=�|�.  .��  
 �����$ RedoAlt=� _� $	��105��$��40�� 
 ToolTipApdate#��[
 � $��1��.+��� -
    ��Name$ tbInfo��$y�	Collapsed=�$ 1��$��Center=�$��Center=�$ 
Horizontal=�.+�  $ Frown=� �#5b60c4$��70��$��70���� $&�� Ничего не найдено��$��20 0 0 0q�$��26(�#��[ ��  �� CornerRadius$ 10��$��
10 0 20 20q�����  �� 
StartPoint$	 1,0&� �� EndPoint$	 0,1&�.���  � Color$ #4169E1�� � Offset$ 0Q�� $ #ADD8E6��$ 1Q�._��� -   $
��Auto=�$
��Auto=�.���� $��
10 10 10 0q�.+��� -    ��Name$ listExtradition��$��0q�
������  � FocusVisualStyle Z� ���� .R�� $
��auto�� � ColumnDefinitions �� $	��100 ��� $��* ��� $��* ��� $��* �.+�� $��0��.+��� 
 �� Top$ 30��$	��100��$��0 5 0 5q�$
��Left=�
����  �$��1q�$ 10��  J� Effect  3  -System.Windows.Media.Effects.DropShadowEffect  !   
BlurRadius$! 20Q�"   Opacity$" .5Q�#   ShadowDepth$# 1Q�._��� $��ReceiverColor�����	#FF96B2E4$��2q�$ 10��._�� .+��� $
��Mask��
����������	#FF3B5998$��0q�$ 10���� .+��� -   $
��Fill=�$��5q����� $ �� Path$$ Books.Image�% �� TargetNullValue% ��/Resources/imageNull.png�� �� $��	10 0 10 0q�$%��Открыть картинку��& J� OpacityMask& !� ' !� Visual' �� $
 Mask��� $��1��$
��Left=�$��20 0 0 0q�.+��� .+��� $
��Bold"�$��0 0 0 10q�  
tbListView#��[ $��20(����� *Books.NameBook+�� $��0 10 0 0q�#��[ ���� *Books.YearOfPublication+( �� StringFormat$+( %Год издания: {0:dd.MM.yyyy}���� $��0 10 0 0q�#��[ ���� *Books.AuthorOfThebook+$ ( Автор книги: {0}��� $��2��$��90 0 0 0q�.+��� .+��� #��[ $��10q�$
��Bold"����� *
FullName+ �� $��	10 0 10 0q�$��Книга выдана���� $��0 10 0 0q�#��[ ���� *DateOfISsue+$+( %Дата выдачи: {0:dd.MM.yyyy}���� $��	0 10 0 30q�#��[ ���� *	EndDate+$5( /Окончание выдачи: {0:dd.MM.yyyy}���� #��[ $��Center=�$��Bottom=�$��0 0 10 0q����� *Books.NamberBook+$ ( Номер книги: {0}��� $��3��.+�� ) �Name$) 
gridButton��  	checkRole#��[ $��Right=�$��	0 10 10 0q�.+��� $ btnEditExtradition��-   |�.  $��Right=�$	��Top=�  btnEditImage#��[ .��  $
 Edit=�$��16��  fa:IconImageTopButton#��[  _� $	��140��.���� $+��%Редактировать книгу���� $ 
Horizontal=�$��Right=�.+��� $	 
tbNamberZl��$y�	Collapsed=����� *IdTypeOfHalls+�� $	 tbTypeUsers��#��[ $��Right=�$��Bottom=�$y�	Collapsed=�$��10q����� *	TypeUsers+�� $��Bottom=�.+���   btnTopMenuCheck#��[ $��Bottom=�$��	0 0 20 10q�$��Right=��� $ tbStatys��  btnExtraditionCheck#��[ $��	0 0 20 10q�$��Bottom=�$��Right=��� -   * ��Name$* borderImageBook��$y�	Collapsed=�$��
10 0 20 20q�$ 10��
������ ._��  �� $	��140 ��� $��* ��� $	��140 �.+��� 
�������$ 	10 0 0 10��+ J� Opacity$	+ 0.5Q�$��0���� -   $ 	btnBorder��$��1��$��	0 17 10 0q�  btnCross#��[ $	��Top=�$��Right=�$ 1��.��    iconCrossStyle#��[ $��	16 -6 0 0q�$
 Plus=�z��� , �� Angle$, 44Q� �� $%��Закрыть картинку��$
��auto��$��	10 0 10 0q��� -   $* borderImage��
�������$	+ 0.5Q�$��1���� 
�������$��	0 10 0 10q�$ 10��$��1��._�� .+��� $��5q����� $$ Image�% ��/Resources/imageNull.png���� 
�������$ 	0 10 10 0��$	+ 0.5Q�$��2��