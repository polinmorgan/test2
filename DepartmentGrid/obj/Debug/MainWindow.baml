   M S B A M L   `   `   `  ����I  EDepartmentGrid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DepartmentGridDepartmentGrid  5   	       DepartmentGrid.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DepartmentGrid     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��657��6)   .��5	      � $	��320��6   $	��Top=�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��1 �6   6+   �� 5      $��2 �6   6+   .+�5   
   �� $��8,10,-426,10q�6    �� DisplayMemberPath$ Department_name��5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5      $��1��6*   ��5   *   ��  �� Path$ Departaments� �� SelectedItem 5   :   �� $ CurrentDeportament� �� Mode$ OneWayToSource=�5      &   System.Windows.Controls.DataGrid  5   
   $��1��6   $��10,8,-433,2q�6       CanUserAddRows .  	   CanUserDeleteRows	 .  
   AutoGenerateColumns
 .  $��1��5   U   ��6   �� $ DataGridCollection� �� IsAsync .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $ Data.Department_id�6_     5      $
 NAME��6S    6%   �� $ Data.Department_name�6c     5       $ PHONE��6T    6%   �� $ Data.Department_phone�6e   4  .System.Windows.Controls.DataGridCheckBoxColumn  5!      $ SELECT��6Z    6)   �� $ 
IsSelected�$ TwoWay=�6l   5#      � 5%   
   $��1��6   $��1��6    5&      �� 5(      $
��Auto �6    �� 5)      $
��147* �6    �� 5*      $	��10* �6    �� 5+      $
��115* �6     5.      �� 5/      $��2 �6#   6/   �� 50      $��3 �6#   6/   54      �� 55   
   -   5         ��Name$ button��55      $��Delete��6!   $��1��6]   $
��Left=�6m   $��440,10,-512,0q�6�   $	��Top=�6�   $��75��6�   ��62   �� $ DeleteDepartments�6�   �� 56   
   -   5         ��Name$ 	text_name��56      $��1��6[   $
��Left=�6k   $��23��6�   $��500,12,-617,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��1��6�   ��6%   �� $# NewDepartment.Department_name�6�   �� 57   
   -   5        $ 
text_phone��57      $��1��6\   $
��Left=�6l   $��23��6�   $��500,57,-617,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��1��6�   ��6&   �� $$ NewDepartment.Department_phone�6�   �� 58   
   -   5        $ button1��58      $	��Add��6"   $��1��6X   $
��Left=�6h   $��500,108,-572,0q�6�   $��1��6�   $	��Top=�6�   $��75��6�   ��60   �� $ AddDepartments�6�   �� 59   
   -   5         ��Name$ label��59      $
��Name��6   $��1��6.   $
��Left=�6>   $��450,12,-491,0q�6Y   $��1��6p   $	��Top=�6}   $��44��6�   �� 5:   
   -   5        $ label1��5:      $��Phone��6    $��1��60   $
��Left=�6@   $��450,57,-492,0q�6[   $��1��6r   $	��Top=�6   $��45��6�   5;      5<      