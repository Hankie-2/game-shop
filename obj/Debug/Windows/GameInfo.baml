   M S B A M L   `   `   `  ����I  EUIKitTutorials, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UIKitTutorials.WindowsUIKitTutorials.Windows  5   	   %    UIKitTutorials.Windows.GameInfo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:UIKitTutorials.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�6.   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5
   	    � WindowState$ Normal=�6    � Title$ GameInfo��5   	   $	��450��6   $	��450��6'   .��5      � .+�5   
   ��  �� CornerRadius$ 8 0 0 8��6   ���#F2F0F0._�5      � $��1��6    � RowDefinitions 5      �� 5      $��40 �6$   �� 5      .+�5      �� $��0��6   $��4��6*   $��Right=�6:   $	��Top=�6V   $��0,5,10,0q�6n   $��30��6�    �� Orientation$ 
Horizontal=�6�   $��RightToLeft=�6�   .+�5      �� -   5        	 ��Name$	 btnClose��5      $��25��6/   $��25��6;      IconButtonsStyle#��[  6G    	 close#���  6q   

 � Tag$
 IsCloseButton��6�   �� 5      -   5        $	 
btnRestore��5      $��25��61   $��25��6=   $	��5,0q�6H   ��5      �� 5       �� 
TargetType" ��6$    �� BasedOn# [  6A   .�5   "   ��  �� Property � ��  maximize �� Value# �  6<    �� Triggers 5   "   �� 5   &    �� Binding 62   ��  �� ElementName$
 home�� �� Path$ WindowState� �� Value 	Maximized6i   .a�5   *   ��  � ��  restore# �  6D   5    '   5"      5$      �� 5%      -   5        $	 btnMinimize��5%      $��25��62   #���   6>     minimize#���  6i   6�   5&      �� 5*      $��1��6   $��0 10 0 0q�6*   .+�5,      �� $��1��6!   $ 
Horizontal=�6.   $��Bottom=�6G   $��Center=�6b   $��0 0 0 20q�6   .+�5-      F�   logo#���  6   $��16 0 0 0q�6=    �� Stretch$
 Fill=�6O     PrimaryBlueColor#���  6^   $��25��6�   $��25��6�   $
��Left=�6�   �� 5.      $��
Playground��6    #���  65   $
��Bold"�6e   $��20(�6w   $��Center=�6�   $
��Left=�6�   $
��Left=�6�   $��14 0 0 0q�6�   5/      �� 52      $��	10 0 10 0q�6!   .+�53      �� -   5         ��Name$ gameInfoName��53       $��0��66   $��Название игры��6F     TextPrimaryColor#���  6^   $��30(�6�   $��SemiBold"�6�   $��Center=�6�   $
��Left=�6�   �� 54      -   5        $ gameInfoPublisher��54       $��1��6;   $��Издатель��6K     PrimaryGrayColor#���  6^   $��15(�6�   $��Regular"�6�   $��Center=�6�   $
��Left=�6�    � ToolTip 55      _� 56   "   .��57   &   �� .+�58   *   �� -   5        $ publisherCountry��58   0   $��Страна��6J   #���  6[   $��15(�6�   $��SemiBold"�6�   $��Center=�6�   $
��Left=�6�   �� 59   *   -   5        $ publisherWebsite��59   0   $��Вебсайт��6J   #���  6\   $��15(�6�   $��SemiBold"�6�   $��Center=�6�   $
��Left=�6�   5:   '   5;   #   5=      �� 5>      -   5        $ gameInfoDate��5>       $��Дата��66   #���  6E   $��15(�6u   $��Regular"�6�   $��Center=�6�   $
��Left=�6�   �� 5?      -	   5        $ gameInfoPrice��5?       $
��500$��67   ���#81F085$��15(�6[   $��Regular"�6i   $��Center=�6~   $
��Left=�6�   �� 5@      -
   5         ��Name$ gameInfoDescription��5@   $   $��Описание игры��6A    �� Padding$ 3q�6V   ���#808080$��20(�6x   $��Regular"�6�   $
��Wrap=�6�   $
��Left=�6�   �� 5A      -   5        $	 	buyButton��5A   !   
�������$��20(�6G   $��40��6U   $��Center=�6a   #���  6~   $��0q�6�   $��0 20 0 0q�6�   $	��427��6�   .��6�   Купить5C      5D      5E      5F      5I      5J      5K      