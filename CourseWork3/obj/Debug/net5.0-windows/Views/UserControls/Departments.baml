   M S B A M L   `   `   `  ����F  BCourseWork3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CourseWork3.Views.UserControlsCourseWork3.Views.UserControls  5      ?$clr-namespace:CourseWork3.ViewModelsCourseWork3.ViewModels  5      0    *CourseWork3.Views.UserControls.Departments   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:CourseWork3.Views.UserControls     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      -vm$clr-namespace:CourseWork3.ViewModels  5      
���   �.��5      � .+�5   
   � y�6   �� *ViewDataVisibility+  � RowDefinitions  5      �� 5      �� 5      $��75 �6    .+�5      &   System.Windows.Controls.DataGrid  $��0��6   $��	10 0 10 0q�6$      AutoGenerateColumns$ false��67   $
��true��6{   "   VerticalScrollBarVisibility$ Visible=�6�   $   HorizontalScrollBarVisibility$ Visible=�6�   ��6S   �� *DepartmentsList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6;      Header$ Id��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *Id+  5      $
 True��6)   $ 1* 6;   $
 Name��6F    6T   �� *DepartmentName+  5      $
 True��6)   $ 1* 6;   $ 
Service Id��6F    6Z   �� *	ServiceId+  5      $
 True��6)   $ 1* 6;   $ Location Id��6F    6[   �� *
LocationId+4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5   "   �� $��Delete��6)   ��6:   �� 
 �� Path$
 DataContext.DeleteRecord� �� RelativeSource ��  �� AncestorType"  ��6�   �� 5      5      5!      �� 5#      $��1��6   $��50��6"   $	��100��6.   $	��Add��6:   $��Right=�6H   $��0 0 20 0q�6d   ��6v   �� *EnterCreatingDataStateCommand+5$      � 5&   
   y�6   �� *CreatingDataVisibility+.+�5'      �� $
��Name��6   $��Center=�6$   $	��Top=�6A   $��0 50 0 0q�6Y   $
��Bold"�6k   $��18(�6}   �� 5(      $	��500��6,   $��Center=�68   $	��Top=�6U   $��0 80 0 0q�6m   $��18(�6   ��6   �� *Name+6   �� 5)      $��Service��6   $��Center=�6'   $	��Top=�6D   $��	0 120 0 0q�6\   $
��Bold"�6o   $��18(�6�   �� 5*      $��Center=�6F    �� DisplayMemberPath$ TypeOfDepartmentName��5+       �� SelectedValuePath$ TypeOfDepartmentName��5,      $	��500��5.      $��Center=�6#   $	��Top=�6@   $��	0 150 0 0q�6X   $��18(�6k   ��5*      �� $
 TypeOfDepartments� �� SelectedItem 5-      �� $
 SelectedTypeOfDepartment�5.   k   �� 5/      $��Location��6   $��Center=�6(   $	��Top=�6E   $��	0 190 0 0q�6]   $
��Bold"�6p   $��18(�6�   �� 50      $��Center=�6B   $ Address��51      $ Address��52      $	��500��54      $��Center=�6#   $	��Top=�6@   $��	0 220 0 0q�6X   $��18(�6k   ��50      �� $
 LocationsList� 53      �� $
 SelectedLocation�54   k   �� 56      $	��100��6   $��50��6!   $��Create��6-   $	��Top=�6>   $��	0 280 0 0q�6V   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 57      +  %Microsoft.Xaml.Behaviors.EventTrigger  58         	EventName$ Click��6%   *	  $Microsoft.Xaml.Behaviors.TriggerBase 	  Actions. 59      2
  ,Microsoft.Xaml.Behaviors.InvokeCommandAction
   
  Command 60   �� *CreateRecord+5:      5<      5=      � 5?   
   y�6   �� *EditDataVisibility+5@      5B      5C      