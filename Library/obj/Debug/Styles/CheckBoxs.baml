   M S B A M L   `   `   `  ����W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType �� Property �� Value   CheckBoxFocusVisual �� 
TargetType �� 
Background �� Bullet ��Name �� CornerRadius �� 
StartPoint	 �� EndPoint
 � Color � Offset F�Name J� SnapsToDevicePixels �� Color'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty8   2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value R� KeyTime   System.Windows.Visibility   Visible R� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�
  '��       �� 5      "  ��6&   .�5   
   ��  �@J�SnapsToDevicePixels . 61   �� 5   
    �@�OverridesDefaultStyle . 62   �� 5   
    �@�FocusVisualStyle# �   6-   �� 5   
    � �� 5	      �� 5
      " ��6"   .R�5      �� 
 ����  5      �� 5      $ Border��6%   $��23��5   %   $��18��5   %   $ 5��5   %   $��1q�5   %   ��5   "   �� 5   &   $	 0,0&�6:   $		 0,1&�6L   ��5   .   � � 5   2   $
 White��6?   $	 0.0Q�6N   � 5   2   $

 Gray��6?   $	 1.0Q�6L   5   /   5   '   ��5   "   �� 5    &   $	 0,0&�6:   $		 0,1&�6M   ��5#   .   � � 5$   2   $
 White��6?   � 5%   2   $
 White��6?   $	 1.0Q�6N   5'   /   5)   '   ._�5-   "   � .+�5.   &   F� $ 	CheckMark��52   +   $y�	Collapsed=�5.   +   $��7��5/   +   $��15��50   +   $��2 0 0 0q�51   +    .  $��2��54   +   "����    @KL р� ��� р��     	��56   *   �� 57   .   $
 Blue��6>   59   '   5:   #   5;       5=        5>      CommonStates��. 5?   "     
Normal��6.     5@   "   	MouseOver��. 5A   &   �� .��5B   *   �� $ Border��6G   $ y(Panel.Background).                                                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�5C   1   .g�5E   .     $ 0��6B   $ #E6E6FA��6O   5G   +   5H   '   5I   #     5K   "   Pressed��. 5L   &   �� .��5M   *   �� $ Border��6G   $ y(Panel.Background).                                                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�5N   1   .g�5P   .     $ 0��6B   $ White��6N   5R   +   �� 5S   *   $ Border��6G   $� {(Border.BorderBrush).                                                 (GradientBrush.GradientStops)[0].(GradientStop.Color)�5T   1   .g�5V   .     $ 0��6B   $
 Blue��6O   5X   +   �� 5Y   *   $ Border��6G   $� {(Border.BorderBrush).                                                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�5Z   1   .g�5\   .     $ 0��6B   $
 Blue��6O   5^   +   5_   '   5`   #     5a   "   Disabled��6.   5b        5c      CheckStates��. 5d   "     Checked��. 5e   &   �� .��5f   *   T� $ (UIElement.Visibility)�6H   $ 	CheckMark��5g   2   ..�5h   .   i� $ 0��6E   # Z 6Q   5j   +   5k   '   5l   #     5m   "   	Unchecked��6.     5n   "   Indeterminate��. 5o   &   �� .��5p   *   T� $ (UIElement.Visibility)�6H   $ InderminateMark��5q   H   ..�5r   .   i� $ 0��6E   # Z 6R   5t   +   5u   '   5v   #   5w      ._�5y      �� $��4,0,0,0q�6+   $��Center=�5z   +   $
��Left=�5{   +   ��. 5|   +   5}      5~      5�      5�      5�      