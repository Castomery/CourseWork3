   M S B A M L   `   `   `  ����F  BCourseWork3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CourseWork3.Views.UserControlsCourseWork3.Views.UserControls  5      ?$clr-namespace:CourseWork3.ViewModelsCourseWork3.ViewModels  5      >    8CourseWork3.Views.UserControls.FacultyDepartmentContacts   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:CourseWork3.Views.UserControls     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      -vm$clr-namespace:CourseWork3.ViewModels  5      
���   �.��5      � .+�5   
   � y�6   �� *ViewDataVisibility+  � RowDefinitions  5      �� 5      �� 5      $��75 �6    .+�5      &   System.Windows.Controls.DataGrid  $��0��6   $��	10 0 10 0q�6$      AutoGenerateColumns$ false��67   $
��true��6�   "   VerticalScrollBarVisibility$ Visible=�6�   $   HorizontalScrollBarVisibility$ Visible=�6�   ��6S   �� *FacultyDepartmentContactsList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6;      Header$ Id��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *Id+  5      $
 True��6)   $ 1* 6;   $ Faculty Department Id��6F    6e   �� *FacultyDepartmentId+  5      $
 True��6)   $ 1* 6;   $ Position Id��6F    6[   �� *
PositionId+  5      $
 True��6)   $ 1* 6;   $ 
Contact Id��6F    6Z   �� *	ContactId+4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5   "   �� $
��Edit��6)   ��68   �� 
 �� Path$
 DataContext.EditRecord� �� RelativeSource ��  �� AncestorType"  ��6�   �� 5      5        5       	 5!      �� 5"      .R�5#   "   �� $��Delete��6)   ��6:   �� $
 DataContext.DeleteRecord� �� "  ��6�   �� 5$      5&      5(      �� 5*      $��1��6   $��50��6"   $	��100��6.   $	��Add��6:   $��Right=�6H   $��0 0 20 0q�6d   ��6v   �� *EnterCreatingDataStateCommand+5+      � 5-   
   y�6   �� *CreatingDataVisibility+.+�5.      �� $��Faculty Department��6   $��Center=�62   $	��Top=�6O   $��0 50 0 0q�6g   $
��Bold"�6y   $��18(�6�   �� 5/      $��Center=�6G    �� DisplayMemberPath$ FacultyDepartmentName��50       �� SelectedValuePath$ FacultyDepartmentName��51      $	��500��53      $��Center=�6#   $	��Top=�6@   $��0 80 0 0q�6X   $��18(�6j   ��5/      �� $
 FacultyDepartments� �� SelectedItem 52      �� $
 SelectedFacultyDepartment�53   j   �� 54      $��Position��6   $��Center=�6(   $	��Top=�6E   $��	0 120 0 0q�6]   $
��Bold"�6p   $��18(�6�   �� 55      $��Center=�6>   $ PositionName��56      $ PositionName��57      $	��500��59      $��Center=�6#   $	��Top=�6@   $��	0 150 0 0q�6X   $��18(�6k   ��55      �� $
 	Positions� 58      �� $
 SelectedPosition�59   k   �� 5:      $��Contact��6   $��Center=�6'   $	��Top=�6D   $��	0 190 0 0q�6\   $
��Bold"�6o   $��18(�6�   �� 5;      $��Center=�6=   $ FullName��5<      $ FullName��5=      $	��500��5?      $��Center=�6#   $	��Top=�6@   $��	0 220 0 0q�6X   $��18(�6k   ��5;      �� $
 Contacts� 5>      �� $
 SelectedContact�5?   k   �� 5A      $	��100��6   $��50��6!   $��Create��6-   $	��Top=�6>   $��	0 280 0 0q�6V   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5B      +  %Microsoft.Xaml.Behaviors.EventTrigger  5C         	EventName$ Click��6%   *	  $Microsoft.Xaml.Behaviors.TriggerBase 	  Actions. 5D      2
  ,Microsoft.Xaml.Behaviors.InvokeCommandAction
   
  Command 60   �� *CreateRecord+5E      5G      5H      � 5J   
   y�6   �� *EditDataVisibility+.+�5K      �� $��Faculty Department��6   $��Center=�62   $	��Top=�6O   $��0 50 0 0q�6g   $
��Bold"�6y   $��18(�6�   �� 5L      $��Center=�6G   $ FacultyDepartmentName��5M      $ FacultyDepartmentName��5N      $	��500��5P      $��Center=�6#   $	��Top=�6@   $��0 80 0 0q�6X   $��18(�6j   ��5L      �� $
 FacultyDepartments� 5O      �� $
 SelectedFacultyDepartment�5P   j   �� 5Q      $��Position��6   $��Center=�6(   $	��Top=�6E   $��	0 120 0 0q�6]   $
��Bold"�6p   $��18(�6�   �� 5R      $��Center=�6>   $ PositionName��5S      $ PositionName��5T      $	��500��5V      $��Center=�6#   $	��Top=�6@   $��	0 150 0 0q�6X   $��18(�6k   ��5R      �� $
 	Positions� 5U      �� $
 SelectedPosition�5V   k   �� 5W      $��Contact��6   $��Center=�6'   $	��Top=�6D   $��	0 190 0 0q�6\   $
��Bold"�6o   $��18(�6�   �� 5X      $��Center=�6=   $ FullName��5Y      $ FullName��5Z      $	��500��5\      $��Center=�6#   $	��Top=�6@   $��	0 220 0 0q�6X   $��18(�6k   ��5X      �� $
 Contacts� 5[      �� $
 SelectedContact�5\   k   �� 5^      $	��100��6   $��50��6!   $
��Save��6-   $	��Top=�6<   $��	0 280 0 0q�6T    5_        5`      $ Click��6%   . 5a      
   60   �� *SaveEditedRecord+5b      5d      5e      5f      5g      