   M S B A M L   `   `   `  ����I  EUIKitTutorials, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ShopApplication.WindowsShopApplication.Windows  5   	   *    $ShopApplication.Windows.Registration   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:ShopApplication.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Registration��5	   	   $	��600��6   $
��1000��6+   .��5
      � 
������� � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      .+�5   
   � .+�5      �� $��/Assets/login_picture.jpg��6   $��UniformToFill=�67    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 10Q�6!    � LayoutTransform 5      �� 5       �� ScaleX$ -1Q�6%   5      5      �� 5   
   $��0��6   ._�5      � .+�5      �� $��Center=�6   $��Center=�6:   .+�5      �� -   5         ��Name$ goToLoginButton��5      
�������$��20(�6I   $��60��6W   $��Center=�6c   ���#fc6822$��0q�6�   $��0 20 0 0q�6�   $	��300��6�      roundedButton#��[  6�   .��6  Назад в меню5!      5"      �� 5$      $��1��6    �� Orientation$ 
Horizontal=�6*   $��Bottom=�6C   $��Center=�6^   $��0 0 0 20q�6{   .+�5%      F�   logo#���  6   $��16 0 0 0q�69   	 �� Stretch$
	 Fill=�6K   
�������$��25��6g   $��25��6r   $
��Left=�6~   �� 5&      $��
Playground��6   
�������$
��Bold"�6D   $��20(�6V   $��Center=�6d   $
��Left=�6   $
��Left=�6�   $��14 0 0 0q�6�   5'      5(      5)      �� 5,   
   $��1��6   
 �� Padding$
 50q�6!   ._�5-      � .+�5.      �� $
��auto��6   .+�5/      �� $��Регистрация��6     TextPrimaryColor#���  62   $��30(�6b   $��SemiBold"�6p   $��Center=�6�   $
��Left=�6�   �� 50      $?��9Пожалуйста, введие Ваши данные!��6     PrimaryGrayColor#���  6F   $��20(�6v   $��Regular"�6�   $��Center=�6�   $
��Left=�6�   $��0 0 0 0q�6�   �� 52      $��Имя��6   #���  6*   $��20(�6Z   $��Regular"�6h   $��Center=�6}   $
��Left=�6�   $��0 20 0 0q�6�   �� 53      -   5         ��Name$ registrationName��53      $��5q�68   $��50��6D   $��20(�6P     
normalText#��[ 6^   $
��Left=�6�   $��Center=�6�   �� 55      $��Никнейм��6   #���  6.   $��20(�6^   $��Regular"�6l   $��Center=�6�   $
��Left=�6�   $��0 20 0 0q�6�   �� 56      -   5        $ registrationUsername��56      $��5q�6<   $��50��6H   $��20(�6T   #��[ 6b   $
��Left=�6�   $��Center=�6�   �� 58      $��Пароль��6   #���  6-   $��20(�6]   $��Regular"�6k   $��Center=�6�   $
��Left=�6�   $��0 20 0 0q�6�   G� 59      -   5         G�Name$ registrationPassword��59   "   $��5q�6@   $��50��6L   $��20(�6X   $
��Left=�6f   $��Center=�6�   �� 5;      -   5        $ registrationButton��5;      
�������$��20(�6L   $��60��6Z   $��Right=�6f   ���#fc6822$��0q�6�   $��0 20 0 0q�6�   $	��250��6�   #��[  6�   .��6  " Зарегистрировать5=      5?      5@      5A      5C      5D      