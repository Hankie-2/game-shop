   M S B A M L   `   `   `  ����I  EUIKitTutorials, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:UIKitTutorialsUIKitTutorials  5   	       UIKitTutorials.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:UIKitTutorials     5   	   -   5        $
��home��5        � Title$  
MainWindow��5   	   $	��650��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�6.   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�6   .��5      ��  �� CornerRadius$ 8��6      PrimaryBackgroundColor#���   6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      �� $ 8 0 0 8��6     SecundaryBackgroundColor#���  6,   ._�5      � -   5         �Name$ gridMenu��5      $��60��6)   	 � RowDefinitions	 5      �� 5      $��60 �6(   �� 5      $��80 �6(   �� 5      $
��Auto �6(   �� 5      .+�5      �� $��1��6!   
 �� Orientation$
 
Horizontal=�6.   $	��Top=�6G   .+�5      F�   logo#���  6   $��16 0 0 0q�6=    �� Stretch$
 Fill=�6O     PrimaryBlueColor#���  6^   $��25��6�   $��25��6�   $
��Left=�6�   �� 5       $��
Playground��6    #���  65   $
��Bold"�6e   $��20(�6w   $��Center=�6�   $
��Left=�6�   $
��Left=�6�   $��14 0 0 0q�6�   5!      d� 5$      -   5         d�Name$ btnMenu��5$   #   $��Right=�65   $��0q�6Q   
������ $��Center=�6~     MenuIconStyle#��[ 6�   $��0 0 15 0q�6�    � Triggers 5%      :� 5&       :� RoutedEvent$ ToggleButton.Unchecked��6+   .[�5'   "   �� .��5(   &   �� -   5         ��Name$ HideStackPanel��5(   1   .��5)   *   W�  �� 
TargetName$ gridMenu��6:    �� TargetProperty$ Width�6[    g� 	BeginTime$ 0:0:0X�6}    W� From$	 200X�6�   	 W� To$ 60X�6�    g� Duration$ 0:0:0.3D�6�   5*   +   5+   '   5,   #   5-      :� 5.      $ ToggleButton.Checked��6+   .[�5/   "   �� .��50   &   �� -   5        $ ShowStackPanel��50   1   .��51   *   W� $ gridMenu��6:   $ Width�6[   $ 0:0:0X�6}   $ 60X�6�   $	 200X�6�   $ 0:0:0.3D�6�   52   +   53   '   54   #   55      57      �� 59      $��3��6!   .+�5:      	� -   5         	�Name$ rdHome��5:   &    d� 	IsChecked$
 TrueY�66   $��Список игр��6G     MenuRadioButtonStyle#���  6\     home
 � Tag# �  6�   6�   	� 5;      -   5        $ 	rdPayment��5;   &   $��Покупки��69   #���  6K     payment# �  6z   $��0 5 0 5q�6�   6�   5<      �� 5>      $��3��6!   $��Bottom=�6.   $
 
Horizontal=�6I   $	��200��6b   $��0 0 0 20q�6n   .+�5?      A� $��40��6"   $��40��6-   $��10 0 0 0q�69   ��5@      �� 5A   "    �� ImageSource$! Assets/Avatars/avatar-1.jpg��6-   5C      �� 5D      $
 Vertical=�6%   $��10 0 0 0q�6<   .+�5E      �� -   5         ��Name$ menuName��5E   $   $��Scarlett Gwen��66     TextPrimaryColor#���  6N   $��14(�6~   $��SemiBold"�6�   $��Center=�6�   $
��Left=�6�   �� 5F      -	   5        $ 
menuWallet��5F   $   $��****$��68    	 PrimaryGrayColor#��� 	 6H   $��11(�6x   $��Regular"�6�   $��Center=�6�   $
��Left=�6�   $��	0 -10 0 0q�6�   �� 5H      -
   5         ��Name$ exitButtonMenu��5H   %   $��80��6=   $��25��6H   $
��Exit��6T   #���  6c   $��Regular"�6�   $��0q�6�   
�������6�   5I      5J      5L      5M      � 5Q      $��1��6   	 5R      �� 5S      $��60 �6$   �� 5T      .+�5X      �� $��0��6   $��4��6*   $��Right=�6:   $	��Top=�6V   $��0,5,10,0q�6n   $��30��6�   $
 
Horizontal=�6�   $��RightToLeft=�6�   .+�5Y      �� -   5        $ btnClose��5Y      $��25��6/   $��25��6;    
 IconButtonsStyle#��[
 6G    	 close#���  6q   $ IsCloseButton��6�   �� 5Z      -   5        $ 
btnRestore��5Z      $��25��61   $��25��6=   $	��5,0q�6H   ��5[      �� 5\       �� 
TargetType" ��6$    �� BasedOn# [
 6A   .�5]   "   ��  �� Property � ��  maximize �� Value# �  6<     �� Triggers  5^   "   �� 5_   &   ! �� Binding! 62   �� " �� ElementName$
" home��# �� Path$# WindowState�$ �� Value$ 	Maximized6i   .a�5`   *   ��  � ��  restore# �  6D   5a   '   5c      5e      �� 5f      -   5        $ btnMinimize��5f      $��25��62   #��� 
 6>     minimize#���  6i   6�   5g      �� 5j      $��1��6   $��10q�6&   ._�5k       � -   5        %  �Name$% PagesNavigation��5k      &  � NavigationUIVisibility$& Hidden=�65   5m      5n      5o      5q      5r      5s      