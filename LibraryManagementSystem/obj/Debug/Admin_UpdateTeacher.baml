   M S B A M L   `   `   `  ����R  NLibraryManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:LibraryManagementSystemLibraryManagementSystem  5   	   1    +LibraryManagementSystem.Admin_UpdateTeacher   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:LibraryManagementSystem     5   	     � Title$  更新教师信息��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5
   
   �� $��教师信息��6   $
��Left=�6!   $	��279��6<   $��
127,32,0,0q�6I   $	��Top=�6]   $	��510��6u   �� 5   
   $��姓名��6   $
��Left=�6   $��145,106,0,0q�68   $	��Top=�6M   �� 5   
   $��	教师号��6   $
��Left=�6   $��145,159,0,0q�69   $	��Top=�6N   �� 5   
   $��可借阅数量��6   $
��Left=�6    $��127,217,0,0q�6;   $	��Top=�6P   �� 5   
   $��	原密码��6   $��Center=�6   $��	0,105,0,0q�6;   $	��Top=�6N   �� 5   
   $��	新密码��6   $��Center=�6   $��	0,159,0,0q�6;   $	��Top=�6N   �� 5   
   $��确认密码��6   $
��Left=�6   $��374,216,0,0q�6:   $	��Top=�6O   �� 5   
   -   5         ��Name$ txt_TeacherName��5      $
��Left=�6+   $��24��6F   $��209,108,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txt_TeacherId��5      $
��Left=�6)   $��26��6D   $��209,159,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txt_TeacherBNumy��5      $
��Left=�6,   $��26��6G   $��209,216,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txt_Pwd��5      $
��Left=�6#   $��26��6>   $��478,106,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   G� 5   
   -   5         G�Name$ 	pwd_First��5      $
��Left=�6)   $��478,161,0,0q�6D   $	��Top=�6Y   $	��120��6q   $��26��6}   G� 5   
   -   5        $ 
pwd_Second��5      $
��Left=�6*   $��478,217,0,0q�6E   $	��Top=�6Z   $	��120��6r   $��26��6~   �� 5   
   -   5         ��Name$ 
btn_Update��5      $��更新��6%   $
��Left=�62   $��275,340,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ btn_Back��5      $��返回��6#   $
��Left=�60   $��403,340,0,0q�6K   $	��Top=�6`   $��75��6x   6�   5      5      