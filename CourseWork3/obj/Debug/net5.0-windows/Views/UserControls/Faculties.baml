   M S B A M L   `   `   `  ����F  BCourseWork3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CourseWork3.Views.UserControlsCourseWork3.Views.UserControls  5      ?$clr-namespace:CourseWork3.ViewModelsCourseWork3.ViewModels  5      .    (CourseWork3.Views.UserControls.Faculties   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:CourseWork3.Views.UserControls     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      -vm$clr-namespace:CourseWork3.ViewModels  5      
���   �.��5      � .+�5   
   � y�6   �� *ViewDataVisibility+  � RowDefinitions  5      �� 5      �� 5      $��75 �6    .+�5      &   System.Windows.Controls.DataGrid  $��0��6   $��	10 0 10 0q�6$      AutoGenerateColumns$ false��67   $
��true��6y   "   VerticalScrollBarVisibility$ Visible=�6�   $   HorizontalScrollBarVisibility$ Visible=�6�   ��6S   �� *FacultiesList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6;      Header$ Id��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *Id+  5      $
 True��6)   $ 1* 6;   $
 Name��6F    6T   �� *FacultyName+  5      $
 True��6)   $ 1* 6;   $ Location Id��6F    6[   �� *
LocationId+  5      $
 True��6)   $ 1* 6;   $ 
Contact Id��6F    6Z   �� *	ContactId+4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5   "   �� $
��Edit��6)   ��68   �� 
 �� Path$
 DataContext.EditRecord� �� RelativeSource ��  �� AncestorType"  ��6�   �� 5      5        5       	 5!      �� 5"      .R�5#   "   �� $��Delete��6)   ��6:   �� $
 DataContext.DeleteRecord� �� "  ��6�   �� 5$      5&      5(      �� 5*      $��1��6   $��50��6"   $	��100��6.   $	��Add��6:   $��Right=�6H   $��0 0 20 0q�6d   ��6v   �� *EnterCreatingDataStateCommand+5+      � 5-   
   y�6   �� *CreatingDataVisibility+.+�5.      �� $
��Name��6   $��Center=�6$   $	��Top=�6A   $��0 50 0 0q�6Y   $
��Bold"�6k   $��18(�6}   �� 5/      $	��500��6,   $��Center=�68   $	��Top=�6U   $��0 80 0 0q�6m   ��6   �� *Name+6m   �� 50      $��Location��6   $��Center=�6(   $	��Top=�6E   $��	0 110 0 0q�6]   $
��Bold"�6p   $��18(�6�   �� 51      $��Center=�6B    �� DisplayMemberPath$ Address��52       �� SelectedValuePath$ Address��53      $	��500��55      $��Center=�6#   $	��Top=�6@   $��	0 140 0 0q�6X   $��18(�6k   ��51      �� $
 LocationsList� �� SelectedItem 54      �� $
 SelectedLocation�55   k   �� 56      $��Contact��6   $��Center=�6'   $	��Top=�6D   $��	0 180 0 0q�6\   $
��Bold"�6o   $��18(�6�   �� 57      $��Center=�6=   $ FullName��58      $ FullName��59      $	��500��5;      $��Center=�6#   $	��Top=�6@   $��	0 210 0 0q�6X   ��57      �� $
 Contacts� 5:      �� $
 SelectedContact�5;   X   �� 5=      $	��100��6   $��50��6!   $��Create��6-   $	��Top=�6>   $��	0 260 0 0q�6V   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5>      +  %Microsoft.Xaml.Behaviors.EventTrigger  5?         	EventName$ Click��6%   *	  $Microsoft.Xaml.Behaviors.TriggerBase 	  Actions. 5@      2
  ,Microsoft.Xaml.Behaviors.InvokeCommandAction
   
  Command 60   �� *CreateRecord+5A      5C      5D      � 5F   
   y�6   �� *EditDataVisibility+.+�5G      �� $
��Name��6   $��Center=�6$   $	��Top=�6A   $��0 50 0 0q�6Y   $
��Bold"�6k   $��18(�6}   �� 5H      $	��500��6,   $��Center=�68   $	��Top=�6U   $��0 80 0 0q�6m   ��6   �� *Name+6m   �� 5I      $��Location��6   $��Center=�6(   $	��Top=�6E   $��	0 110 0 0q�6]   $
��Bold"�6p   $��18(�6�   �� 5J      $��Center=�6B   $ Address��5K      $ Address��5L      $	��500��5N      $��Center=�6#   $	��Top=�6@   $��	0 140 0 0q�6X   $��18(�6k   ��5J      �� $
 LocationsList� 5M      �� $
 SelectedLocation�5N   k   �� 5O      $��Contact��6   $��Center=�6'   $	��Top=�6D   $��	0 180 0 0q�6\   $
��Bold"�6o   $��18(�6�   �� 5P      $��Center=�6=   $ FullName��5Q      $ FullName��5R      $	��500��5T      $��Center=�6#   $	��Top=�6@   $��	0 210 0 0q�6X   ��5P      �� $
 Contacts� 5S      �� $
 SelectedContact�5T   X   �� 5U      $	��100��6   $��50��6!   $
��Save��6-   $	��Top=�6<   $��	0 260 0 0q�6T    5V        5W      $ Click��6%   . 5X      
   60   �� *SaveEditedRecord+5Y      5[      5\      5^      5_      