   M S B A M L   `   `   `  ����   Library0    *Library.Pages.PageLibrarian.LibrarianStart   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  -     �Name$  startLibrarian��$	��660��$
��1300��$	��805��$	��585�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������  � 
ResizeMode$ CanResizeWithGrip=� � ShowActivated .  |�.  .��� $��6.9 0 6.4 0q�.+�� $��-0.5 0 -6 0q� � ColumnDefinitions �� $	��250 ��� .+���  �� CornerRadius$ 	10 0 0 10������  �� 
StartPoint$ 0.5,0&�	 �� EndPoint$	 0.5,1&�.���    DarkBlueTopColor
 � Color#
 [   � Offset$ 0Q��   DarkBlueBottomColor#
 [ $ 1Q�._��� .+���  �� Orientation$ 
Horizontal=�.+��� $��/Resources/Logo.png��$��48��$
��Left=�$��15 5 0 0q��� $��Библиотека��  titlePogram#��[ $��
10 15 0 10q��� -    ��Name$ 
btnSapport��|�.  $��49 0 0 0q�  btnCrossAndRollUp#��[ .��!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ LifeRing=�$��16��  fa:IconImageTopButton#��[  � ToolTip �� $
��auto��$��	10 0 10 0q�$��Помощь����   separatorLeft#��[ $��
20 10 20 0q��� $ 
Horizontal=�$��Center=�$��0 35 0 0q�.+��� $ 10��$��40��$��40������ $	 0,0&�$		 1,2&�.���   TopFrame#
 [ $ 0Q��   BottomFrame#
 [ $ 1Q�._��� -    ��Name$ Char1NameAndSurName��$�� ��  tbNameAndSurname#��[ �� $��10 0 0 0q�$��Center=�.+��� -   $ NameAndSyrName��$�� �� 	 tbNameSurname#��[	 �� -   $ tbRole��$�� �� 
 tbNumberVersion#��[
 �� -   $ btnEditUser��|�.  $��	0 -65 5 0q�#��[ .��  $	 Pen=�$��16��#��[  _� $	��180��.���� $)��#Изменить уч. данные���� #��[ �� -    ��Name$ stackPanelMenu��.+��� -   $ btnMain��  btnMenuActive#��[ |�.  .���� $ 
Horizontal=�.+�  $
 Home=�  fa:IconImage#��[ �� $��Главная��  menuButtonText#��[ �� -	   $ btnBooks��|�.    btnMenu#��[ .���� $ 
Horizontal=�.+�  $ BookOpen=�#��[ �� $��
Книги��#��[ �� -
   $ 
btnMyBooks��|�.  #��[ .���� $ 
Horizontal=�.+�  $
 Book=�#��[ �� $��Мои книги��#��[ �� -   $ 	btnUserAd��|�.  #��[ .���� $ 
Horizontal=�.+�  $ Users=�#��[ �� $��Пользователи��#��[ �� -   $ btnSupplier��|�.  #��[ .���� $ 
Horizontal=�.+�  $ Boxes=�#��[ �� $��Поставщики��#��[ �� -   $ 	btnVidaca��|�.  #��[ .���� $ 
Horizontal=�.+�  $ Inbox=�#��[ �� $��Выдача��#��[ �� -   $ btnBack��|�.  $y�	Collapsed=�#��[ .���� $ 
Horizontal=�.+�  $ 	ArrowLeft=�#��[ �� $��
Назад��#��[ �� -   $ btnExitZapic��|�.  #��[ .���� $ 
Horizontal=�.+�  $ DoorOpen=�#��[ �� $��
Выход��#��[  _� $(��"Выйти из уч. записи��$	��150���� -   $��1��$ 	0 10 10 0������ $	 1,0&�$		 0,1&�.���   DarkBlueTopRightColor#
 [ $ 0Q��   DarkBlueBottomLeftColor#
 [ $ 1Q�._��  � RowDefinitions �� $��* �.+� � -     �Name$ 
startFrame��$��0 35 0 0q�  � NavigationUIVisibility$ Hidden=� � FocusVisualStyle Z� �� $ 
Horizontal=�$	��Top=�$��Right=�$��0 0 10 0q�.+��� -   $ 	btnRollUp��|�.  #��[ .��  $ Minus=�$��5��#��[  _� $	��100��.���� $��Свернуть���� -   $ 	btnExpand��|�.  #��[ .��  -     Name$ 
iconExpand��$ ExpandArrowsAlt=�#��[  _� -    _�Name$ toolTipTest��  btnTopToolTip#��[ .���� -   $ tolText��$��Развернуть���� -   $ btnExit��|�.  #��[ .��  $ PowerOff=�#��[  _� $	��100��.���� $��Закрыть��