   M S B A M L   `   `   `  ����D  @Stopwatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Stopwatch.ViewStopwatch.View  5      9!clr-namespace:Stopwatch.ViewModelStopwatch.ViewModel  5	      $    Stopwatch.View.AnalogStopwatch   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Stopwatch.View     5      7	viewmodel!clr-namespace:Stopwatch.ViewModel     5	        � 	Resources  5      ,  &Stopwatch.ViewModel.StopwatchViewModel   	viewModel-  'Stopwatch.ViewModel.BooleanNotConverter  notConverter(  "Stopwatch.ViewModel.AngleConverter  angleConverter��%W   &	        &	      &	 &       5   
   6'     5   
   6(     5   
   6#   5      .��5      � -   5         �Name$ baseGrid��5       � DataContext# [  6   
���   � � ColumnDefinitions 5   
   �� 5      $	��400 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   A� $	��300��6   $	��300��6   
���   �$��2��6:   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$
 Blue��6#   � 5      $
 Gray��6#    � Offset$ 1Q�60   5      5      �� 5    
   	 J� RenderTransformOrigin$	 0.5,0.5&�6   $��2��64   $	��150��6>   
���   �z�5!      V� 5"      .~�5#      T� 
 T� Y$	
 -60Q�6)   �� 5$       �� Angle 6&   �� *	Seconds+ �� 	Converter# [  �� ConverterParameter$ Seconds��5'      5)      �� 5*   
   $	 0.5,0.5&�6   $��4��64   $	��100��6>   
���   �z�5+      V� 5,      .~�5-      T� $	
 -50Q�6)   �� 5.       6&   �� *	Minutes+# [ $ Minutes��51      53      �� 54   
   $	 0.5,0.5&�6   $��1��64   $	��150��6>   
��� ���z�55      V� 56      .~�57      T� $	
 -60Q�6)   �� 58       6&   �� *
LapSeconds+# [ $ Seconds��5;      5=      �� 5>   
   $	 0.5,0.5&�6   $��2��64   $	��100��6>   
��� ���z�5?      V� 5@      .~�5A      T� $	
 -50Q�6)   �� 5B       6&   �� *
LapMinutes+# [ $ Minutes��5E      5G      A� 5H   
   $��10��6   $��10��6   
���   �6)   �� 5I   
    �� Orientation$ 
Horizontal=�6   $��	0,20,0,20q�6.   $��Bottom=�6A   $��1��6\   .+�5J      �� -   5         ��Name$ StartButton��5J   \   $��10,0,7,0q�6q   {�6   �� *	Running+# [ .��6�   Start6�   �� 5K      -   5        $ 
StopButton��5K   3   $��0,0,7,0q�6G   {�6   �� *	Running+.��6q   Stop6w   �� 5L      -   5        $ ResetButton��5L      $��0,0,7,0q�6*   .��6U   Reset6\   �� 5M      -   5        $ 	LapButton��5M   3   {�6   �� *	Running+.��6^   Lap6c   5N      5O      5P      