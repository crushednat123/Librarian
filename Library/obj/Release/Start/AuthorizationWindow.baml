   M S B A M L   `   `   `  ����   Library'    !Library.Start.AuthorizationWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  window�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������ $	��550��$	��500��.��� .+��� -    ��Name$ border�� �� CornerRadius$ 10��|�.  � FocusVisualStyle Z� ����  �� 
StartPoint$	 1,0&� �� EndPoint$	 0,1&�.���    DarkBlueTopRightColor	 � Color#	 [  
 � Offset$
 0Q��   DarkBlueBottomLeftColor#	 [ $
 1Q�!  FontAwesome.Sharp.IconImage  $��28��$	��Top=�$
��Left=��  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ DoorOpen=�$��25��   
Foreground �#7071f0$��7 10 0 0q��� $��Авторизация��  titlePogram#��[ $��
47 10 0 10q�� .+��� -    ��Name$ btnExit��$��5��$	��Top=�  btnCrossAndRollUp#��[ .��  $ PowerOff=�  fa:IconImageTopButton#��[  � ToolTip _� $	��100��.���� $��Закрыть���� -   $ 20��
����  �$��2q�$��Center=�$��Center=�$	��280��$	��320������ .��� $	 #CEE3FF��$	
 0.2Q�� $	 #E0FFFF��$	
 0.7Q�._��� $��Center=�$
��auto��$
��auto��$��Center=�$��0 0 0 20q�.+��� $��Center=�$��0 0 0 30q�$��18(�Авторизация�� -   $��tBLogin��$��0��  TextBox#��[ $��0 10 0 0q�$	��230��  -     Name$ 	iconLogin��$ UserAlt=�$
��Left=�
 �����$��
10 -30 0 0q��� -    ��Name$ Placeholder�� J� IsHitTestVisible .  $
��Wrap=�$��
Логин��$��
35 -30 0 0q�$��Center=�
�������$
��Left=�����  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=���  � ��$ Comic Sans MS)���  � ��$
 Bold"� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ tBLogin�� �� Value  .a���  � y�$ Visible=��� $��Right=�$��	0 0 10 20q����� " ��.���  � ��$ Comic Sans MS)���  � ��$
 Bold"� ��  �� *Text.Length+$ tBLogin�� 50.a���  � ��
 �  ���� ��� *Text.Length+$ tBLogin�� �� Mode$ OneWay=�/�� ��� *	MaxLength+$ tBLogin��G� -   $��
pBPassword��$��1��$	��230���� -	    ��Name$ 
tBPassword��$��2��#��[ $	��230��$y�	Collapsed=����� $ 
pBPassword�� �� Path$ Password�  -
   $ iconPassword��$
 Lock=�$
��Left=�
 �����$��
10 -30 0 0q��� -   $ textBlockPassword��$y�Visible=�$��Пароль��$��
35 -30 0 0q�$��Center=�
�������$
��Left=��� -   $
��text��$��Right=�$��0 0 10 0q�/50�� -   $ pasText��$��Right=�$��0 -16.7 31 0q�0�� -    ��Name$ checkPassword��{�.  $#��Показать пароль���� -   $��btnVhod��$��3��|�. $��0 20 0 0q�$	��230��$��
Войти�� �� 	IsDefault . 