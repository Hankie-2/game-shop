   M S B A M L   `   `   `  ����I  EUIKitTutorials, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UIKitTutorials.WindowsUIKitTutorials.Windows  5   	   '    !UIKitTutorials.Windows.AdminPanel   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:UIKitTutorials.Windows     5   	   
������   � Title$  
AdminPanel��5   	   $	��450��6   $	��800��6)   .��5	      ��  �� CornerRadius$ 10��6   
���   �._�5
   
   �� .+�5      � $��10q�6   .+�5      �� .+�5      �� $��1��6!    �� Orientation$ 
Horizontal=�6.   $��Bottom=�6G   $��Center=�6b   $��0 0 0 20q�6   .+�5      F�    logo#���   6   $��16 0 0 0q�6=    �� Stretch$
 Fill=�6O   
�������$��25��6k   $��25��6v   $
��Left=�6�   �� 5      $��
Playground��6    
�������$
��Bold"�6H   $��20(�6Z   $��Center=�6h   $
��Left=�6�   $
��Left=�6�   $��14 0 0 0q�6�   5      �� 5      -   5         ��Name$ 	panelName��5      $��Админ панель��6/   
�������$��20(�6Y   $��SemiBold"�6g   $��Center=�6}   $
��Left=�6�   �� 5      $��Статистика��6   
�������$��20(�6E   $��SemiBold"�6S   $��Center=�6i   $
��Left=�6�   �� 5      -   5        $ soldGameCount��5      $��Продано игр: ��63     PrimaryGrayColor#���  6K   $��20(�6{   $��SemiBold"�6�   $��Center=�6�   $
��Left=�6�   �� 5      -   5        $ soldGameMoney��5      $-��'Продано игр на сумму: ��63   #���  6T   $��20(�6�   $��SemiBold"�6�   $��Center=�6�   $
��Left=�6�   �� 5      -   5        $ 
usersCount��5      $7��1Количество пользователей: ��60   #���  6U   $��20(�6�   $��SemiBold"�6�   $��Center=�6�   $
��Left=�6�   �� 5      -   5         ��Name$ createGameButton��5      
�������$��20(�6J   $��40��6X   $
��Left=�6d   ���#1ed5ec$��0q�6�   $��0 20 0 0q�6�   $	��160��6�   .��6�   Добавить игру5      5      5      5      5      5      