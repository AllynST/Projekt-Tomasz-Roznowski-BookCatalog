   M S B A M L   `   `   `  ����_  [Projekt-Tomasz-Roznowski-BookCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Projekt_Tomasz_Roznowski_BookCatalog$Projekt_Tomasz_Roznowski_BookCatalog  5   	   5    /Projekt_Tomasz_Roznowski_BookCatalog.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Projekt_Tomasz_Roznowski_BookCatalog     5   	     � Title$  BookCatalog��5   	   $	��700��5	   	   $
��1120��6    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 40��6   
����� �$��1q�62   ���#272537._�5   
   �� .+�5      �� -   5        
����� � J� Opacity$	 0.7Q�5   E   $ 	40 40 0 0��6S   ._�5      � $��90��6   .+�5      �� $��35(�6    $��80��6.   $��	40 25 0 0q�6:   $��Center=�6M   
���   ��� 5      .�6   Book Catalog6-   5      �� 5      $��	600 0 0 0q�6!    �� Orientation$ 
Horizontal=�64   $��Center=�6N    � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%�   '��       �� 5      "	 ��6$   .�5   "   �� 
 � ��
 �   �6O   �� 5   "   
 � ��$ 12(�6=   6J   �� 5   "   
 � ��$
 Bold"�6?   6N   5      5      .+�5       �� $��/Images/user.png��6    $��59��6:   $��67��6F   �� 5!      $��Center=�6%   .+�5#      �� �� 6*   -   5         �Name$ AccountUserName��5#   .   $�Allyn��6E   6U   �� 5$      $
��auto��6(   $
��Wrap=�67   $	 0.5Q�6K   $	��180��6Y   �� 6f   -   5        $ AccountMail��5$   j   $ �Tomaszroznowskii@gmail.com��6}   6�   5&      5'      5(      5*      � 5/   
    � ColumnDefinitions 50      �� 51      $	��200 �6#   61   �� 52      6%    � RowDefinitions 54      �� 55      $	��100 �6    6/   �� 56      $	��500 �6    6/   .+�59      �� $��1��6    5:      ��%�   '��       �� 5;      "	 ��6   .�5<      �� 
 � ��
 ���� 67   �� 5=      
 � ��$ 0q�6<   �� 5>      
 � ��
 �����67   �� 5?      
 � ��$ 24(�65   �� 5@      
 � ��$ 	15 15 0 0q�63   5C      5D      .+�5G      �� ���#6479C4$��40(�62   .��6@   Menu6F   �� 5H      -   5        $��Authors��5H      .��6C   	Authors6L   �� 5I      -   5        $��Books��5I      .��6@   Books6G   �� 5J      -   5        $��Genres��5J      .��6@   Genres6H   �� 5K      -   5        $��ReadList��5K      .��6D   	Read list6O   �� 5L      -   5        $��FBooks��5L      .��6@   Finished books6P   �� 5M      -	   5        $��Account��5M      .��6B   	Account6K   �� 5N      -
   5        $��ExitAPP��5N      
���  ��.��6S   
Exit APP6]   5S      �� 5U      
�������$��30q�6/   $��1 0 0 0q�6;   $��1��6U   $��3��6e   ._�5V      �� -   5        $
��Main��5V   -   $��20q�6!   5X      5Y      5c      5d      5e      5h      