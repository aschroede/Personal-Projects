   M S B A M L   `   `   `  ����  BasketballRoster)    #BasketballRoster.View.RosterControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5	         PlayerItemTemplate �� Mode��%�   &	        �� 5
   
   .R�5      �� �� 5      �6   �� *Name+$ OneWay=� �� 5      $� #��6    �� 5      �6   �� *Number+$ OneWay=�5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   .+�5   
   �� $��2q�6   
����  � �� CornerRadius$ 6��68   $��5q�6I   
���   �._�5      � $��10q�6    5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5       $
��Auto �6$   �� 5!      $
��Auto �6$   �� 5"      $
��Auto �6$   .+�5$      �� $
��20px(�66   $��Segoe)�6G   $��0,5,0,0q�6Z   
�������
���   ���6   �� *
TeamName+6~   �� 5%      $��1��6   $��Starting Players��6)   $
��16px(�6A   $��Segoe)�6Q   $��0,5,0,0q�6d   
�������
���   �6�   �� 5&      $��2��6    �� SelectionMode$ Single=�6(   $��0,5,0,0q�6`   #��[  5'      
�������
���   ���5&   ?   �� *
Starters+5'   a   �� 5(      $��3��6   $��Bench Players��6)   $
��16px(�6>   $��Segoe)�6N   $��0,5,0,0q�6a   
�������
���   �6�   �� 5)      $��4��6   $ Single=�6(   $��0,5,0,0q�6]   #��[  5*      
�������
���   ���5)   ?   �� *Bench+5*   a   5+      5,      5-      5.      