   M S B A M L   `   `   `  ����K  GDsmSoftExercises, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DsmSoftExercisesDsmSoftExercises  5   	   !    DsmSoftExercises.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:DsmSoftExercises     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �  � ShowGridLines$
 True��6    � ColumnDefinitions 5      �� 5      $	��380 �6#   �� 5      $��* �6#   .+�5      �� $��10q�6   $��0��6%   .+�5      �� -   5         ��Name$ FilterCombo��5      $	��250��60   $��35��6<    �� SelectedValue$ DeptId��6�    �� DisplayMemberPath$ DeptName��6�   ��6H   ��  �� Path$ departments�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ EmployeeGrid��5      $	��350��61   $	��380��6=   
�������$��10q�6b      AutoGenerateColumns$ False��6n   ��6�   �� *	employees+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� $ EmpId�  5      $
 Name��6-   $ 60 6;    6F   �� $ EmpName�  5      $ Designation��6-   $ 60 6B    6M   �� $ Designation�  5      $ DeptId��6-   $ 60 6=    6H   �� $ DeptId�  5      $ Salary��6-   $ 60 6=    6H   �� $ Salary�5      5      �� 5!      $��1��6   $��10q�6)   .+�5"      � $��10q�6   .+�5#      �� $��Employee ID: ��6    $��5q�65   $��Center=�6@   $	��180��6]   $��30��6i   $��Center=�6u   $
��Bold"�6�   
����ح�6�   �� 5$      -   5         ��Name$ TxtEmpId��5$      $��5q�60   $	��180��6;   $��30��6G   
������6S   5%      � 5&      $��10q�6   .+�5'      �� $��Employee Name: ��6    $��5q�67   $��Center=�6B   $	��180��6_   $��30��6k   $��Center=�6w   $
��Bold"�6�   
����ح�6�   �� 5(      -   5        $ 
TxtEmpName��5(      $��5q�62   $	��180��6=   $��30��6I   
������6U   5)      � 5*      $��10q�6   .+�5+      �� $��Designation: ��6    $��5q�65   $��Center=�6@   $	��180��6]   $��30��6i   $��Center=�6u   $
��Bold"�6�   
����ح�6�   �� 5,      -   5        $ 	TxtDesign��5,      $��5q�61   $	��180��6<   $��30��6H   
������6T   5-      � 5.      $��10q�6   .+�5/      �� $��Department ID: ��6    $��5q�67   $��Center=�6B   $	��180��6_   $��30��6k   $��Center=�6w   $
��Bold"�6�   
����ح�6�   �� 50      -   5        $ 	TxtDeptID��50      $��5q�61   $	��180��6<   $��30��6H   
������6T   51      � 52      $��10q�6   .+�53      �� $��Salary: ��6    $��5q�60   $��Center=�6;   $	��180��6X   $��30��6d   $��Center=�6p   $
��Bold"�6�   
����ح�6�   �� 54      -   5        $ 	TxtSalary��54      $��5q�61   $	��180��6<   $��30��6H   
������6T   55      � 56      $��5q�6   .+�57      �� -   5         ��Name$ 	btnInsert��57      $��INSERT��60   $��5q�6A   $��80��6L   $��30��6W   
��� E��$
��Bold"�6z   
�������6�   �� 58      -	   5        $ 	btnUpdate��58      $��UPDATE��60   $��5q�6A   $��80��6L   $��30��6W   
��� E��$
��Bold"�6z   
�������6�   �� 59      -
   5        $ 	btnDelete��59      $��DELETE��60   $��5q�6A   $��80��6L   $��30��6W   
��� E��$
��Bold"�6z   
�������6�   �� 5:      -   5        $ btnClear��5:      $��CLEAR��6/   $��5q�6?   $��80��6J   $��30��6U   
��� E��$
��Bold"�6x   
�������6�   5;      5<      5=      5>      5?      