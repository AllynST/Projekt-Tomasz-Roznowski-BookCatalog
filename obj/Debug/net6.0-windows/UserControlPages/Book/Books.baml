   M S B A M L   `   `   `  ����_  [Projekt-Tomasz-Roznowski-BookCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Projekt_Tomasz_Roznowski_BookCatalog$Projekt_Tomasz_Roznowski_BookCatalog  5      0    *Projekt_Tomasz_Roznowski_BookCatalog.Books   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:Projekt_Tomasz_Roznowski_BookCatalog     5      ���#272537.��5
      �� .+�5   
   �� 
�������$��0 0 0 1q�6%   $��0 0 0 30q�6?   ._�5      �� 
�������$��20q�60   $��40(�6<   $��Center=�6J   Books6n   5      �� 5   
   $
��auto��6   �� 5      -   5        $��	FilterBTN��5   4   $	��100��6   $��	0 0 10 10q�6!   .��6]   Filter6e    �� 5      -   5        $��	FilterBox��5   Q   $	��100��6   $��0 0 0 10q�6#   $��Right=�65     �� SelectedValue$  Default��6b   .@�5      �� 
 � Tag$ Default��6   .��6-   	No Filter68   �� 5      .��6   PDF6$   �� 5      .��6   MOBI6%   �� 5      .��6   EPUB6%   5       �� 5      -   5        $��
AddBookBTN��5   !   $	��100��6   $��Right=�6L   $��
500 0 0 10q�6h   .��6|   
Add Book6�   5      �� 5   
   -   5        $��
BooksTable��5       $
��auto��6   $��Courier New)�62    �� View 5      �� 5       �� AllowsColumnReorder$ false��6    �� ColumnHeaderToolTip$ Books Table��68   .P�5!      �� $��ID��6S    �� Width$
 auto��6_    �� DisplayMemberBinding 6%   ��  �� Path$ Book_ID�6_   �� 5"      $��Title��6Q   $
 auto��6`    6%   �� $ Title�6`   �� 5#      $��Genre��6\   $
 Auto��6k    6%   �� $ Genre.Genre_Name�6k   �� 5$      $��Language��6T   $
 Auto��6f    6%   �� $ Language�6f   �� 5%      $��Author��6%   $
 Auto��65    �� CellTemplate 5&      �� 5'      .R�5(   "   �� �� 5)   &   �6*   �� *Author.Name+6I    �� 5*   &   �6*   �� *Author.Surname+6L   5+   #   5,      5.      �� 5/      $��Format��6R   $
 auto��6b    6%   �� $ Format�6b   �� 51      $�� ��6%    52      �� 53      .R�54   "   �� $��BookPage��6\   -   5        $��Go to Book page��54   )    6C   �� *	Book_ID+6�   55      58      �� 59      $��Delete book��6%   $ 50��6:    5:      �� 5;      .R�5<   "   �� $��DeleteBookBTN��6N   -   5        $��x��5<   )    65   �� *	Book_ID+6�   5=      5@      �� 5A      $��Add to read list��6%   $
 auto��6?    5B      �� 5C      .R�5D   "   �� $��AddReadList��6N   -   5        $��x��5D   )    65   �� *	Book_ID+6}   5E      5H      5K      5P      5Q      5R      