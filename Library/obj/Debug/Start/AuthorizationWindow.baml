   M S B A M L   `   `   `  ����  Library'    !Library.Start.AuthorizationWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  window��5   	    � WindowStartupLocation$ CenterScreen=�5	       � WindowStyle$
 None=�5
       � AllowsTransparency . 
������ $	��550��5   K   $	��500��6X   .��5      � .+�5   
   �� -   5         ��Name$ border��5   ?    �� CornerRadius$ 10��6-   |�.  � FocusVisualStyle 6   Z� ��5      �� 5       �� 
StartPoint$	 1,0&�6    �� EndPoint$	 0,1&�6+   .��5      �    DarkBlueTopRightColor	 � Color#	 [  6   
 � Offset$
 0Q�6C   � 5        DarkBlueBottomLeftColor#	 [ 6   $
 1Q�6E   5      5      !  FontAwesome.Sharp.IconImage  5   
   $��28��6   $	��Top=�6#   $
��Left=�6;   �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ DoorOpen=�6V   $��25��5         
Foreground �#7071f0$��7 10 0 0q�6)   �� 5      $��Авторизация��6     titlePogram#��[ 6!   $��
47 10 0 10q�6F   � 5      .+�5      �� -   5         ��Name$ btnExit��5   "   $��5��6   $	��Top=�63     btnCrossAndRollUp#��[ 6a   .��5        $ PowerOff=�6      fa:IconImageTopButton#��[ 60    � ToolTip 5       _� 5!      $	��100��6   .��5"      �� $��Закрыть��6$   5#      5%      �� 5'      -   5        $ 20��5'      
����  �$��2q�5)      $��Center=�5*      $��Center=�5+   
   $	��280��5-   H   $	��320��6T   ��5/      �� 51      .��53      � $	 #CEE3FF��6   $	
 0.2Q�6%   64   � 54      $	 #E0FFFF��6   $	
 0.7Q�6%   64   55      ._�58      �� $��Center=�6   $
��auto��68   $
��auto��6E   $��Center=�6S   $��0 0 0 20q�6p   .+�5:      �� $��Center=�6   $��0 0 0 30q�6.   $��18(�6A   Авторизация6\   �� 5<      -   5        $��tBLogin��5=   m   $��0��6     TextBox#��[ 6+   $��0 10 0 0q�6N   $	��230��6`   6m     5?      -   5          Name$ 	iconLogin��5?   #   $ UserAlt=�66   $
��Left=�6E   
 �����$��
10 -30 0 0q�6r   �� 5A      -   5         ��Name$ Placeholder��5A        J� IsHitTestVisible .  $
��Wrap=�5B      $��
Логин��5C      $��
35 -30 0 0q�5D      $��Center=�5F      
�������$
��Left=�5H      ��5J      �� 5K       �� 
TargetType" ��6$   .�5L   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?   �� 5M   "    � ��$ Comic Sans MS)�6@   �� 5N   "    � ��$
 Bold"�6?    �� Triggers 5O   "   �� 5P   &    �� Binding 62   �� *Text+ �� ElementName$ tBLogin�� �� Value  6`   .a�5Q   *   ��  � y�$ Visible=�6G   5R   '   5T      5V      �� 5Z      $��Right=�6    $��	0 0 10 20q�6<   ��5[      �� 5]   	   " ��6   .�5^   
   ��  � ��$ Comic Sans MS)�6(   �� 5_   
    � ��$
 Bold"�6'    5`   
   �� 5a       6   �� *Text.Length+$ tBLogin�� 506L   .a�5b      ��  � ��
 �  ��6)   5c      5e   
   �� 5g      �6   �� *Text.Length+$ tBLogin�� �� Mode$ OneWay=�/�� 6N   �6R   �� *	MaxLength+$ tBLogin��5h      G� 5j      -   5        $��
pBPassword��5j   }   $��1��6B   $	��230��6�   �� 5l      -	   5         ��Name$ 
tBPassword��5o      $��2��5n      #��[ 5p      $	��230��5q      $y�	Collapsed=�6*   ��5m      �� $ 
pBPassword�� �� Path$ Password�5q   *     5s      -
   5        $ iconPassword��5s   #   $
 Lock=�69   $
��Left=�6E   
 �����$��
10 -30 0 0q�6r   �� 5t      -   5        $ textBlockPassword��5t       $y�Visible=�6;   $��Пароль��5u      $��
35 -30 0 0q�5v      $��Center=�5w      
�������$
��Left=�5y      �� 5{      -   5        $
��text��5{   <   $��Right=�6    $��0 0 10 0q�6H   /505}      �� 5~      -   5        $ pasText��5~       $��Right=�61   $��0 -16.7 31 0q�6M   05�      �� 5�      -   5         ��Name$ checkPassword��5�   M   {�.  $#��Показать пароль��63   6�   �� 5�      -   5        $��btnVhod��5�   Q   $��3��5�      |�. $��0 20 0 0q�5�      $	��230��6/   $��
Войти��6a    �� 	IsDefault . 6q   5�      5�      5�      5�      5�      