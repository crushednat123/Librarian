   M S B A M L   `   `   `  ���� W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType �� Property �� Value   CheckBoxFocusVisual �� 
TargetType �� 
Background �� Bullet ��Name �� CornerRadius �� 
StartPoint	 �� EndPoint
 � Color � Offset F�Name J� SnapsToDevicePixels �� Color'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty8   2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value R� KeyTime   System.Windows.Visibility   Visible R� Value�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      %�  '��       �� "  ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@�FocusVisualStyle# �   ��  � �� �� " ��.R��� 
 ����  �� $ Border��$��23��$��18��$ 5��$��1q����� $	 0,0&�$		 0,1&���� � $
 White��$	 0.0Q�� $

 Gray��$	 1.0Q����� $	 0,0&�$		 0,1&���� � $
 White��� $
 White��$	 1.0Q�._�� .+�F� $ 	CheckMark��$y�	Collapsed=�$��7��$��15��$��2 0 0 0q� .  $��2��"����    @KL р� ��� р��     	���� $
 Blue��   CommonStates��.   
Normal��  	MouseOver��. �� .���� $ Border��$ y(Panel.Background).                                                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�.g�  $ 0��$ #E6E6FA��  Pressed��. �� .���� $ Border��$ y(Panel.Background).                                                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�.g�  $ 0��$ White���� $ Border��$� {(Border.BorderBrush).                                                 (GradientBrush.GradientStops)[0].(GradientStop.Color)�.g�  $ 0��$
 Blue���� $ Border��$� {(Border.BorderBrush).                                                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�.g�  $ 0��$
 Blue��  Disabled��  CheckStates��.   Checked��. �� .��T� $ (UIElement.Visibility)�$ 	CheckMark��..�i� $ 0��# Z   	Unchecked��  Indeterminate��. �� .��T� $ (UIElement.Visibility)�$ InderminateMark��..�i� $ 0��# Z ._��� $��4,0,0,0q�$��Center=�$
��Left=���. 