   M S B A M L   `   `   `  ����   LibraryG    ALibrary.Pages.PageTeacher.PagesTeachers.Pages.VidahaMyClassesPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp    N� Title$  VidahaMyClassesPage��.���  � RowDefinitions �� $��70 ��� $��* �.+��� -    ��Name$ 
btnAppdate��$y�	Collapsed=�� $��0��.+��� $!��Выданные книги��$��
10 -22 0 0q�   	TextTitle#��[  �  � Orientation$ 
Horizontal=�$
��Left=�$	��Top=�$
��auto��$��	10 35 0 0q�$
��auto��.+�� $��0q�.+��� -    ��Name$ tbDafaultDate��  tbPoiskStyle#��[ $	��Top=�$	��350��$
��Left=�.�� � ToolTip _� $��60��$
��auto��  vidahaSkool#��[ .���� -    ��Name$ Placeholder�� J� IsHitTestVisible .  $
��Wrap=�$��Поиск:��$
��Bold"�$��Stretch=�
���iii�$��
-344 6 0 0q�$
��Left=�����  �� 
TargetType" ��.��� 	 �� Property	 � y�
 �� Value$
 	Collapsed=��� 	 � ��$
 Comic Sans MS)��� 	 � ��$

 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ tbDafaultDate�� �� Value  .a��� 	 � y�$
 Visible=��� -   $ btnPoisk��  btnCrossAndRollUp#��[  K� ZIndex$ 1��$��	-62 5 0 0q�$	��Top=�$
��Left=� �� 	IsDefault . .��!  FontAwesome.Sharp.IconImage    	poiskIcon#��[  _� $	��270��$��60��  ToolTipPoisk#��[ � $��1��.+��� -    ��Name$ tbInfo��$ 1��$y�	Collapsed=�$��Center=�$��Center=� �� Orientation$ 
Horizontal=�.+�  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Frown=�   
Foreground �#5b60c4$��70��$��70���� $&�� Ничего не найдено��$��20 0 0 0q�$��26(�  menuButtonText#��[ ��  �� CornerRadius$ 10��$��
10 0 20 20q�����  �� 
StartPoint$	 1,0&� �� EndPoint$	 0,1&�.���  � Color$ #4169E1�� � Offset$ 0Q�� $ #ADD8E6��$ 1Q�._��� -   $
��Auto=�$
��Auto=�.���� $��
10 10 10 0q�.+��� -    ��Name$ listBook��$��0q�
������  � FocusVisualStyle Z� ���� .R�� .+�� .+��� $ 
Horizontal=�.+��� 
 �� Top$ 30��$	��100��$��0 5 0 5q�$
��Left=�
����  �$��1q�$ 10�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 20Q�   Opacity$ .5Q�    ShadowDepth$  1Q�._��� $��ReceiverColor�����	#FF96B2E4$��2q�$ 10��._�� .+��� $
��Mask��
����������	#FF3B5998$��0q�$ 10���� .+��� ! ��Name$! 	imageBook��-   $
��Fill=�$��5q����� " �� Path$" Books.Image�# �� TargetNullValue# ��/Resources/imageNull.png�� �� $��	10 0 10 0q�$%��Открыть картинку��$ J� OpacityMask$ !� % !� Visual% �� $
 Mask���� $ Vertical=�$��20 0 0 0q�$
��Left=�.+��� $
��Bold"�$��0 0 0 10q�  
tbListView#��[ $��20(����� *Books.NameBook+�� $��0q�#��[ ���� *Books.AuthorOfThebook+& �� StringFormat$ & Автор книги: {0}���� $��0 10 0 0q�#��[ ���� *Books.YearOfPublication+$+& %Год издания: {0:dd.MM.yyyy}���� $��0 10 0 0q�#��[ ���� *DateOfISsue+$"& Выдана: {0:dd.MM.yyyy}���� $��0 10 0 0q�#��[ ���� *	EndDate+$& До: {0:dd.MM.yyyy}���� $ Vertical=�$
��auto��$��40 0 0 0q�$��Stretch=�$��Center=�.+��� #��[ $
��Bold"�$��0 0 0 10q����� *
FullName+$& Ученик: {0}���� #��[ $��0 0 0 10q����� *Books.NamberBook+$ & Номер книги: {0}���� -	   ' ��Name$' borderImageBook��$y�	Collapsed=�$��
10 0 20 20q�$ 10��
������ ._�� ( � ColumnDefinitions( �� $	��140 ��� $��* ��� $	��140 �.+��� 
�������$ 	10 0 0 10��) J� Opacity$	) 0.5Q�$��0���� -
   $ 	btnBorder��$��1��$��	0 17 10 0q�  btnCross#��[ $	��Top=�$��Right=�$ 1��.��   	 iconCrossStyle#��[	 $��	16 -6 0 0q�$
 Plus=�z��� * �� Angle$* 44Q� �� $%��Закрыть картинку��$
��auto��$��	10 0 10 0q��� -   $' borderImage��
�������$	) 0.5Q�$��1���� 
�������$��	0 10 0 10q�$ 10��$��1��._�� .+��� $��5q����� $" Image�# ��/Resources/imageNull.png���� 
�������$ 	0 10 10 0��$	) 0.5Q�$��2��