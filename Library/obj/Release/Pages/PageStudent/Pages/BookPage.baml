   M S B A M L   `   `   `  ����   Library.    (Library.Pages.PageStudent.Pages.BookPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  -     N�Name$
  Page�� N� Title$ BookPage��.���  � RowDefinitions �� $��70 ��� $��* �.+�� $��0��.+��� -    ��Name$ 
btnAddBook��$
��Left=� K� ZIndex$ 1��|�.  $��	10 30 0 0q�   btnChekTecher#��[  .����  �� Orientation$ 
Horizontal=�.+�!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Ad=�$��0q�$��20��  fa:IconImage#��[ �� $!��Добавить книгу��  menuButtonText#��[ �� -    ��Name$ cbCheck��$��Bottom=�$
��Left=�$
��auto��$��
170 0 0 10q�.���� $-��'поиск по номеру книги��
��������� -   $ btnDeleteBook��$��Right=�|�.  $��	0 30 20 0q�#��[  .���� $ 
Horizontal=�.+�  $ TrashAlt=�$��0q�$��20��#��[ �� $��Удалить книгу��#��[ �� $��
Книги��$��
10 -22 0 0q�  	TextTitle#��[ �  � Orientation$ 
Horizontal=�$��Stretch=�$	��Top=�$
��auto��$��	145 0 0 0q�$
��auto��.+�� $��0 0 0 0q�.+��� -   	 ��Name$	 tbDafaultDate��  tbPoiskStyle#��[ $	��Top=�$��0 0 0 5q�$	��350��$
��Left=�.��
 � ToolTip
 �� $
��auto��$��	10 0 10 0q�$r��lПоиск по названию книги, по автору, год издания, номер книги��.���� -    ��Name$ Placeholder�� J� IsHitTestVisible .  $
��Wrap=�$��Поиск:��$
��Bold"�$��Stretch=�
���iii�$��
-344 6 0 0q�$
��Left=�����  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ tbDafaultDate�� �� Value  .a���  � y�$ Visible=��� -   $ btnPoisk��  btnCrossAndRollUp#��[ $ 1��$��	-62 5 0 0q�$	��Top=�$
��Left=� �� 	IsDefault . .��    	poiskIcon#��[ 
 _� $	��270��$��60��  ToolTipPoisk#��[ �� -    ��Name$ cmBook��$
��Left=�$	��150��$	��Top=�$��30�� �� DisplayMemberPath$ NameZal��  -	     Name$ 	iconItems��$ 1��$ 
LayerGroup=�$
��Left=�$	��Top=�   
Foreground
 �����$��
-140 7 0 0q��� -
   $ 	btnApdate��  	btnApdate#��[ $��15 5 0 0q�$	��Top=�$
��Left=�|�.  .��  
 �����$ RedoAlt=�
 _� $	��105��$��40�� 	 ToolTipApdate#��[	 � $��1��.+��� -    ��Name$ tbInfo��$ 1��$y�	Collapsed=�$��Center=�$��Center=�$ 
Horizontal=�.+�  $ Frown=� �#5b60c4$��70��$��70���� $&�� Ничего не найдено��$��20 0 0 0q�$��26(�#��[ ��  �� CornerRadius$ 10��$��
10 0 20 30q�����  �� 
StartPoint$	 1,0&� �� EndPoint$	 0,1&�.���  � Color$ #4169E1�� � Offset$ 0Q�� $ #ADD8E6��$ 1Q�._��� -   $
��Auto=�$
��Auto=�.���� $��
10 10 10 0q�.+��� -    ��Name$ listBook��$��0q�
������   � FocusVisualStyle  Z� ���� .R�� .+�� .+��� $ 
Horizontal=�.+��� 
! �� Top$! 30��$	��100��$��0 5 0 5q�$
��Left=�
����  �$��1q�$ 10��" J� Effect" 3  -System.Windows.Media.Effects.DropShadowEffect  #   
BlurRadius$# 20Q�$   Opacity$$ .5Q�%   ShadowDepth$% 1Q�._��� $��ReceiverColor�����	#FF96B2E4$��2q�$ 10��._�� .+��� $
��Mask��
����������	#FF3B5998$��0q�$ 10���� .+��� & ��Name$& 	imageBook��-   $
��Fill=�$��5q����� ' �� Path$' Image�( �� TargetNullValue( ��/Resources/imageNull.png��
 �� $��	10 0 10 0q�$%��Открыть картинку��) J� OpacityMask) !� * !� Visual* �� $
 Mask���� $ Vertical=�$��20 0 0 0q�$
��Left=�.+��� $
��Bold"�$��0 0 0 10q� 
 
tbListView#��[
 $��20(����� *
NameBook+�� $��0q�#��[
 ���� *AuthorOfThebook++ �� StringFormat$ + Автор книги: {0}���� $ tbElectronik��$��0 50 0 0q�$y�	Collapsed=����� *ElectronicVersion+�� $��0 10 0 0q�#��[
 ���� *YearOfPublication+$++ %Год издания: {0:dd.MM.yyyy}���� $ btnBookDocument��-     btnDocumentText#��[ $)��#Электронная версия��$
��Left=�$��0 0 0 10q��� $ Vertical=�$
��auto��$��40 0 0 0q�$��Stretch=�$��Center=�.+���   tbListViewId#��[ $��0 0 0 10q����� *Cost+$)+ #Цена книги: {0:n2} руб.���� #��[ $��0 0 0 10q����� *DeliveryServices.Id+$*+ $Номер постовщика: {0}���� #��[
 $��0 0 0 10q����� *
NamberBook+$ + Номер книги: {0}���� $��Right=�.+�� , �Name$, 
gridButton��  	checkRole#��[ $��Right=�$��	0 10 10 0q�.+��� $ btnEditBook��-   |�.  $��Right=�$	��Top=�  btnEditImage#��[ .��  $
 Edit=�$��16��  fa:IconImageTopButton#��[ 
 _� $	��140��.���� $+��%Редактировать книгу���� $ tbImageCheck��$y�	Collapsed=����� *Image+�� $ tbRole��$y�	Collapsed=�#��[
 ���� *IdRoleChekss+�� $ tbNull��$y�	Collapsed=����� *IdBookLocation+�� $��Right=�$��Bottom=�.+��� $ tbStatys��  
btnTopMenu#��[ $��	0 0 20 10q�$��Bottom=�$��Right=����� *#!BookLocations.TypeOfHalls.NameZal+�� #��[ $y�	Collapsed=����� *
Items.Name+�� -   $ tbCountBook��$�� ��$��10 0 0 5q�
�������#��[ $��Bottom=��� -   - ��Name$- borderImageBook��$y�	Collapsed=�$��
10 0 20 20q�$ 10��
������ ._�� . � ColumnDefinitions. �� $	��140 ��� $��* ��� $	��140 �.+��� 
�������$ 	10 0 0 10��/ J� Opacity$	/ 0.5Q�$��0���� -   $ 	btnBorder��$��1��$��	0 17 10 0q�  btnCross#��[ $	��Top=�$��Right=�$ 1��.��    iconCrossStyle#��[ $��	16 -6 0 0q�$
 Plus=�z��� 0 �� Angle$0 44Q�
 �� $%��Закрыть картинку��$
��auto��$��	10 0 10 0q��� -   $- borderImage��
�������$	/ 0.5Q�$��1���� 
�������$��	0 10 0 10q�$ 10��$��1��._�� .+��� $��5q����� $' Image�( ��/Resources/imageNull.png���� 
�������$ 	0 10 10 0��$	/ 0.5Q�$��2��