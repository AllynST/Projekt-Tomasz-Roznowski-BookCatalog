   M S B A M L   `   `   `  ����_  [Projekt-Tomasz-Roznowski-BookCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Hclr-namespace:Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book:Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book  5      I    CProjekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book.ReadList   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ZlocalHclr-namespace:Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book     5      .��5	      �� .+�5
   
   �� 
�������$��0 0 0 1q�6%   $��0 0 0 30q�6?   ._�5      �� 
�������$��20q�60   $��40(�6<   $��Center=�6J   	Read list6s   5      �� 5   
   -   5        $��ReadListTable��5       $
��auto��6   $��Courier New)�65     �� View  5      �� 5       �� AllowsColumnReorder$ false��6    �� ColumnHeaderToolTip$ Books Table��68   .P�5      �� $��Title��6Q    �� Width$
 auto��6`    �� DisplayMemberBinding 6%   ��  �� Path$ Title�6`   �� 5      $��Genre��6\   $
 Auto��6k    6%   �� $ Genre.Genre_Name�6k   �� 5      $��Language��6T   $
 Auto��6f    6%   �� $ Language�6f   �� 5      $��Author��6%   $
 Auto��65    �� CellTemplate 5      �� 5      .R�5   "   �� �� 5   &   �6*   �� *Author.Name+6I    �� 5   &   �6*   �� *Author.Surname+6L   5    #   5!      5#      �� 5$      $��Format��6R   $
 auto��6b    6%   �� $ Format�6b   �� 5&      $��Remove��6%   $
 auto��65    5'      �� 5(      .R�5)   "   �� $��DeleteBookFromReadListBTN��6N   -   5        $��x��5)   )   
 � Tag 65   �� *	Book_ID+6�   5*      5-      �� 5/      $��Finished��6%   $
 auto��67    50      �� 51      .R�52   "   �� $��AddToFinished��6N   -   5        $��x��52   )    65   �� *	Book_ID+6|   53      56      59      5>      5?      5@      