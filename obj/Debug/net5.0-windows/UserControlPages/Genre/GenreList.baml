   M S B A M L   `   `   `  ����_  [Projekt-Tomasz-Roznowski-BookCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Iclr-namespace:Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Genre;Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Genre  5      K    EProjekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Genre.GenreList   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      [localIclr-namespace:Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Genre     5      .��5	      �� .+�5
   
   �� 
�������$��0 0 0 1q�6%   $��0 0 0 30q�6?   ._�5      �� 
�������$��20q�60   $��40(�6<   $��Center=�6J   Genres6o   5      �� 5   
   -   5        $��AddGenreBTN��5      $	��100��6   $��Right=�6J   $��	0 0 20 10q�6f   .��6y   	Add Genre6�   �� 5   
   -   5        $��
GenreTable��5      $��Courier New)�6%     �� View  5      �� 5       �� AllowsColumnReorder$ false��6    �� ColumnHeaderToolTip$ Author table��68   .P�5      �� $��ID��6O    �� Width$ 25��6[    �� DisplayMemberBinding 6%   �� *
Genre_ID+6[   �� 5      $
��Name��6Q   $	 100��6_    6%   �� *
Genre_Name+6_   �� 5      $��
Book count��6R   $	 100��6f    6%   �� *Books.Count+6f   �� 5      $��Books in the genre��6%    �� CellTemplate 5      �� 5      .R�5   "   �� $��DisplayGenreBooksBTN��6R   -   5        $
��Show��5   )   
 � Tag 68   �� *
Genre_ID+6�   5      5       �� 5"      $��Delete genre��6%    5#      �� 5$      .R�5%   "   �� $��DeleteGenreBTN��6O   -   5        $��x��5%   )    65   �� *
Genre_ID+6�   5&      5)      5+      5.      5/      50      