   M S B A M L   `   `   `  ����  Library2    ,Library.Pages.PageStudent.Pages.EditUserPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      -   5          N� Title$  EditUserPage��5       � FocusVisualStyle 5      Z� .��5      �� -   5         ��Name$ border��5      $��10 10 15 10q�5   	   
������� �� CornerRadius$ 10��5   ,   |�.  5      Z� ._�5   
   �� -   5         ��Name$ 
stackPanel��5   0   $��Stretch=�5      $��Center=�5      $��30q�5      .+�5      �� -   5        $��tBLogin��5   6   $��0��5         TextBox#��[  6:   $��0 10 0 0q�5      $
��auto��6(   ��5   #   �� *Login+5   6   !  FontAwesome.Sharp.IconImage  5      -   5          Name$ 	iconLogin��5      �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ UserAlt=�6.   $
��Left=�5         
Foreground
 �����$��
13 -30 0 0q�5   -   �� 5!      -   5         ��Name$ Placeholder��5!      	 J� IsHitTestVisible	 .  $
��Wrap=�5"      $��
Логин��5#      $��
35 -30 0 0q�5$      $��Center=�5&      
�������$
��Left=�5(      ��5*      �� 5+      
 �� 
TargetType"
 ��6   .�5,      ��  �� Property � y� �� Value$ 	Collapsed=�67   �� 5-       � ��$ Comic Sans MS)�68   �� 5.       � ��$
 Bold"�67    �� Triggers 5/      �� 50       �� Binding 6*   �� *Text+ �� ElementName$ tBLogin�� �� Value  6X   .a�51   "   ��  � y�$ Visible=�6?   52      54      56      �� 5:      $��Right=�6   $��	0 0 10 20q�64   ��5;      �� 5=      "
 ��6   .�5>      ��  � ��$ Comic Sans MS)�68   �� 5?       � ��$
 Bold"�67    5@      �� 5A       6*   �� *Text.Length+$ tBLogin�� 506_   .a�5B   "   ��  � ��
 �  ��6?   5C      5E      �� 5G      �6   �� *Text.Length+$ tBLogin�� �� Mode$ OneWay=�/�� 6R   �6V   �� *	MaxLength+$ tBLogin��5H      G� 5J      -   5        $��
pBPassword��5M      $��1��5J      $
��auto��5M   ,   �� 5O      -   5         ��Name$ 
tBPassword��5O   \   #��[  6p   $
��auto��5P      $y�	Collapsed=�6#     5R      -	   5        $ iconPassword��5R      $
 Lock=�61   $
��Left=�5S      
 �����$��
13 -30 0 0q�5T   -   �� 5V      -
   5        $ textBlockPassword��5V      $y�Visible=�63   $��Пароль��5W      $��
35 -30 0 0q�5X      $��Center=�5Y      
�������$
��Left=�5[      �� 5]      -   5        $
��text��5]   4   $��Right=�6   $��0 0 10 0q�6@   /505_      �� 5`      -   5        $ pasText��5`      $��Right=�6)   $��0 -16.8 31 0q�6E   05c      �� 5e      -   5         ��Name$ checkPassword��5g   1   $��3��5e      {�.  $��5 0 0 10q�5f      $#��Показать пароль��5g      6H   �� 5h      -   5         ��Name$ btnSave��5h   6   $��3��6   $��Сохранить��6"   $
��auto��5k      �� 5m      -   5        $
 tBId��5m      $y�	Collapsed=�6:   ��6&   �� *Id+6:   5o      5p      5s      