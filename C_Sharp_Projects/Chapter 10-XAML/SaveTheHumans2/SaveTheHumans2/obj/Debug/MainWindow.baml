   M S B A M L   `   `   `  ����I  ESaveTheHumans2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SaveTheHumans2SaveTheHumans2  5   	       SaveTheHumans2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SaveTheHumans2     5   	     � Title$  Save the Humans��5   	   $	��700��6!   $
��1000��6.    � 	Resources 5	         EnemyTemplate �� 
TargetType��%�   &	        �� 5
   
   " ��60   .R�5      � .+�5      A� ���	#FF186800$	��100��6+   
���   �$	��100��6G   5      5      5      .��5      � -   5         �Name$
 grid��5      
���   � � ColumnDefinitions 5   
   �� 5      $	��140 �6   �� 5      �� 5      $	��160 �6    � RowDefinitions 5   
   �� 5      �� 5      $	��150 �6   .+�5   
   �� -   5         ��Name$ startButton��5      $��Start!��6&   $��1��67   $��Center=�6D   $��Center=�6a   $��18(�6|   6�   �� 5   
   $��2��6    �� Orientation$ Vertical=�6%   $��1��6<   $��Center=�6I   $��Center=�6f   .+�5      �� $
��Wrap=�6   $��Avoid These��6,   $��18(�6?   $��Center=�6M   $��Center=�6j   
�������6�   �� 5      $��ContentControl��6   $��Center=�66   $��Center=�6S   #���   6n   5      � 5   
   -   5         �Name$ progressBar��5      $��1��6+   $��1��6;   $��20��6H   �� 5!   
   -   5        	 ��Name$	 playArea��5!      $��3��6#   ��5"      �� 5#      
 �� EndPoint$
 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5$      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5%      $ 	#FFC30000��6#   $ 1Q�65   5&      .+�5(      �� -   5         ��Name$ human��5(      $ Vertical=�6*   .+�5)      A� 
�������$��10��6'   $��10��63   �� 5*      
�������$��25��6)   $��10��65   5+      �� 5,      -   5         ��Name$ gameOverText��5,       �� Left$	 226��6.   $
��Wrap=�6@   $��	Game Over��6T   
 �� Top$	 285��6e   $��Arial)�6v   $	��100(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5-      -   5         ��Name$ target��5-      $��50��6(   $	 265��64   $	 170��6F   $��50��6W    J� RenderTransformOrigin$ 0.5,0.5&�6b   z�5.      V� 5/      .~�50      �� �� 51      �� 52       �� Angle$ 45Q�6*   T� 53      54      ��56      �� 57      $
 0.5,1&�6*   $ 0.5,0&�6;   .��58      � $ Black��6'   $ 0Q�65   � 59      $ White��6'   $ 1Q�65   5:      5<      5=      5?      5@      