   M S B A M L   `   `   `  ����I  EUIKitTutorials, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UIKitTutorials.WindowsUIKitTutorials.Windows  5   	   "    UIKitTutorials.Windows.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:UIKitTutorials.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Login��5	   	   $	��600��6   $
��1000��6$   .��5
      � 
������� � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      .+�5   
   � .+�5      �� $��/Assets/login_picture.jpg��6   $��UniformToFill=�67    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 10Q�6!   5      5      �� 5   
   $��0��6   ._�5      � .+�5      �� $��Center=�6   $��Center=�6:   .+�5      �� $&�� Создайте аккаунт!��6    
�������$��Center=�6L   $��30(�6i      	titleText#��[  6w   �� 5      $9��3Если до сих пор нет аккаунта��6    $��0 20 0 0q�6D   $��20(�6V   ���#D4D4D4  
normalText#��[ 6y   �� 5      -   5         ��Name$ registrationButton��5      
�������$��20(�6L   $��60��6Z   $��Center=�6f   ���#1ed5ec$��0q�6�   $��0 20 0 0q�6�   $	��300��6�     roundedButton#��[ 6�   .��6  Регистрация5       5!      �� 5#      $��1��6    �� Orientation$ 
Horizontal=�6*   $��Bottom=�6C   $��Center=�6^   $��0 0 0 20q�6{   .+�5$      F�   logo#���  6   $��16 0 0 0q�69    �� Stretch$
 Fill=�6K   
�������$��25��6g   $��25��6r   $
��Left=�6~   �� 5%      $��
Playground��6   
�������$
��Bold"�6D   $��20(�6V   $��Center=�6d   $
��Left=�6   $
��Left=�6�   $��14 0 0 0q�6�   5&      5'      5(      �� 5+   
   $��1��6    �� Padding$ 50q�6!   ._�5,      � .+�5-      �� .+�5.      �� $&�� Добро пожаловать!��6     TextPrimaryColor#���  68   $��30(�6h   $��SemiBold"�6v   $��Center=�6�   $
��Left=�6�   �� 5/      $=��7Пожалуйста, войдите в аккаунт!��6     PrimaryGrayColor#���  6E   $��20(�6u   $��Regular"�6�   $��Center=�6�   $
��Left=�6�   �� 50      $��Никнейм��6   #���  6.   $��20(�6^   $��Regular"�6l   $��Center=�6�   $
��Left=�6�   $��0 60 0 0q�6�   �� 51      -   5        	 ��Name$	 loginNickname��51      $��5q�65   $��50��6A   $��20(�6M   #��[ 6[   $
��Left=�6   $��Center=�6�   �� 52      $��Пароль��6   #���  6-   $��20(�6]   $��Regular"�6k   $��Center=�6�   $
��Left=�6�   $��0 60 0 0q�6�   G� 53      -   5        
 G�Name$
 loginPassword��53   "   $��5q�69   $��50��6E   $��20(�6Q   $
��Left=�6_   $��Center=�6�   �� 54      -   5        $ loginButton��54      
�������$��20(�6E   $��60��6S   $��Right=�6_   ���#1ed5ec$��0q�6�   $��0 20 0 0q�6�   $	��150��6�   #��[ 6�   .��6  
Вход56      57      58      59      5;      5<      