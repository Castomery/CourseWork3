   M S B A M L   `   `   `  ����F  BCourseWork3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CourseWork3.ViewModelsCourseWork3.ViewModels  5   	   )clr-namespace:CourseWork3CourseWork3  5   	       CourseWork3.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3vm$clr-namespace:CourseWork3.ViewModels     5   	   'lclr-namespace:CourseWork3     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��800��5	      $
��1080��6'   
�������
�������  � DataContext  5      0  *CourseWork3.ViewModels.MainWindowViewModel  5   
   .��5      � -   5        
������� � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      .+�5   
   � $��0��6   ���	#FF2B74C5.+�5      �� $��Phone Dictionary��6   $��Center=�60   $��Center=�6M   $��32(�6h   '  !MaterialDesignThemes.Wpf.PopupBox  5      $��Right=�6&   $��10q�6B      PlacementMode$ BottomAndAlignRightEdges=�6N      	StaysOpen$ False��6w      PopupContent. 5      �� $	��150��6   .+�5      �� -   5         ��Name$ ButtonPopUpLogout��5      $��Close��68   6H   5      5      5      �� 5!   
   $��1��6   .@�5"      �� $
��Bold"�6   $��Center=�6(   $��Tables��6E   .��5#      � $��1��6    � ColumnDefinitions 5$      �� 5%      $	��300 �6+   �� 5&      .+�5)      � -   5         �Name$ GridMenu��5)   +   $��0��6   $
��Left=�6=   .+�5*      �� $��Disabled=�6'   $
��Auto=�6P   .��5+      ��  �� Orientation$ Vertical=�6)   $	��300��6@   .+�5,   "   �� $��60��6)   $
��Left=�65   ��6W   �� *LoadContacts+.��5-   &   �� $ 
Horizontal=�61   .+�5.   *   '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Contact=�6B   $��25��6Q   $��25��6\   $��10q�6h   $��Center=�6t   �� 5/   *   $��Contacts��64   $��Center=�6D   $��20(�6_   $
��0 10q�6m   50   '   51   #   �� 52   "   $��60��6)   $
��Left=�65   ��6W   �� *LoadPositions+.��53   &   �� $ 
Horizontal=�61   .+�54   *     $
	 Work=�6B   $��25��6N   $��25��6Y   $��10q�6e   $��Center=�6q   �� 55   *   $��	Positions��64   $��Center=�6E   $��20(�6`   $
��0 10q�6n   56   '   57   #   �� 58   "   $��60��6)   $
��Left=�65   ��6W   �� *LoadTypesOfDepartment+.��59   &   �� $ 
Horizontal=�61   .+�5:   *     $	 OfficeBuilding=�6B   $��25��6X   $��25��6c   $��10q�6o   $��Center=�6{   �� 5;   *   $��Types of departments��64   $��Center=�6P   $��20(�6k   $
��0 10q�6y   5<   '   5=   #   �� 5>   "   $��60��6)   $
��Left=�65   ��6W   �� *LoadLocations+.��5?   &   �� $ 
Horizontal=�61   .+�5@   *     $	 Location=�6B   $��25��6R   $��25��6]   $��10q�6i   $��Center=�6u   �� 5A   *   $��	Locations��64   $��Center=�6E   $��20(�6`   $
��0 10q�6n   5B   '   5C   #   �� 5D   "   $��60��6)   $
��Left=�65   ��6W   �� *LoadFaculties+.��5E   &   �� $ 
Horizontal=�61   .+�5F   *     $	 
University=�6B   $��25��6T   $��25��6_   $��10q�6k   $��Center=�6w   �� 5G   *   $��	Faculties��64   $��Center=�6E   $��20(�6`   $
��0 10q�6n   5H   '   5I   #   �� 5J   "   $��60��6)   $
��Left=�65   ��6W   �� *LoadFacultyDepartments+.��5K   &   �� $ 
Horizontal=�61   .+�5L   *     $	 UniversityOutline=�6B   $��25��6[   $��25��6f   $��10q�6r   $��Center=�6~   �� 5M   *   $��Faculty Departments��64   $��Center=�6O   $��20(�6j   $
��0 10q�6x   5N   '   5O   #   �� 5P   "   $��60��6)   $
��Left=�65   ��6W   �� *LoadDepartments+.��5Q   &   �� $ 
Horizontal=�61   .+�5R   *     $
	 Home=�6B   $��25��6N   $��25��6Y   $��10q�6e   $��Center=�6q   �� 5S   *   $��Departments��64   $��Center=�6G   $��20(�6b   $
��0 10q�6p   5T   '   5U   #   �� 5V   "   $��60��6)   $
��Left=�65   ��6W   �� *LoadFacultyContacts+.��5W   &   �� $ 
Horizontal=�61   .+�5X   *     $	 Phone=�6B   $��25��6O   $��25��6Z   $��10q�6f   $��Center=�6r   �� 5Y   *   $��Faculty CTC��64   $��Center=�6G   $��20(�6b   $
��0 10q�6p   5Z   '   5[   #   �� 5\   "   $��60��6)   $
��Left=�65   ��6W   �� *LoadFacultyDepartmentContacts+.��5]   &   �� $ 
Horizontal=�61   .+�5^   *     $	 Phone=�6B   $��25��6O   $��25��6Z   $��10q�6f   $��Center=�6r   �� 5_   *   $��Faculty Department CTC��64   $��Center=�6R   $��20(�6m   $
��0 10q�6{   5`   '   5a   #   �� 5b   "   $��60��6)   $
��Left=�65   ��6W   �� *LoadDepartmentContacts+.��5c   &   �� $ 
Horizontal=�61   .+�5d   *     $	 Phone=�6B   $��25��6O   $��25��6Z   $��10q�6f   $��Center=�6r   �� 5e   *   $��Department CTC��64   $��Center=�6J   $��20(�6e   $
��0 10q�6s   5f   '   5g   #   5i      5j      5k      � 5l      $��1��6   .+�5m      �� ��6)   �� *CurrentContentInTables+5n      5o      5p      �� 5r      $
��Bold"�6   $��Center=�6(   $��Query Panel��6E   .��5s      � $��1��6    5t      �� 5u      $
��0.2* �6(   �� 5v      .+�5x      � $��0��6    5y      �� 5z      $��2* �6/   �� 5{      $
��0.5* �6/   .+�5~      �� $��0��6F   
�������$��16(�6i   
���   �$	��Top=�6�   
 �� AcceptsReturn$

 True��6�   ��6"   �� *CurrentCustomQuery+6�   �� 5      $��1��6!   $��Execute��61   ���	#FF2B74C5$��48(�6Z   $��Center=�6h   $	��113��6�   ��6�   �� *LoadCustomData+5�      &   System.Windows.Controls.DataGrid  5�      $��1��6      AutoGenerateColumns$
 true��6T   ��6,   �� *CurrentDataView+5�      5�      5�      5�      5�      5�      