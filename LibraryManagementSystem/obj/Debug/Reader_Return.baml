   M S B A M L   `   `   `  ����R  NLibraryManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:LibraryManagementSystemLibraryManagementSystem  5   	   +    %LibraryManagementSystem.Reader_Return   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:LibraryManagementSystem     5   	   -   5          � Title$  读者归还界面��5   	   $	��450��6   $	��850��6<   .��5	      � .+�5
   
   �� -   5         ��Name$ listView��5
      $
��Left=�6R   $	��263��6m   $��	27,31,0,0q�6z   $	��Top=�6�   $	��666��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�    �� View 5      �� 5      .P�5      �� $��书号��6%    �� Width$	 100��61    �� DisplayMemberBinding 6=   ��  �� Path$ Book_Id��� 5      $��书名��6%   $	 200��61    6=   �� $ 	Book_Name��� 5      $��借书时间��6%   $	 180��63    6?   �� $ Borrow_Time��� 5      $��还书时间��6%   $	 180��63    6?   �� $ Return_Time�5      5      �� 5   
   $��用户已经借阅书籍��6   $
��Left=�6%   $	��296��6@   $��	10,10,0,0q�6M   $	��Top=�6`   $	��702��6x   �� 5   
   $��用户操作��6   $
��Left=�6!   $	��296��6<   $��
717,10,0,0q�6I   $	��Top=�6]   $	��115��6u   �� 5   
   -   5         ��Name$ 	btn_Renew��5      $��续借��6$   $
��Left=�61   $��
737,69,0,0q�6L   $	��Top=�6`   $��75��6x   {�.  6�   �� 5   
   -   5        $ btn_Back��5      $��返回��6#   $
��Left=�60   $��737,259,0,0q�6K   $	��Top=�6`   $��75��6x   6�   �� 5   
   -   5        $ 
btn_Return��5      $��归还��6%   $
��Left=�62   $��737,166,0,0q�6M   $	��Top=�6b   $��75��6z   {�.  6�   5      5      