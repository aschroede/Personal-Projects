   M S B A M L   `   `   `  ���� E  AGoFish-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GoFish_WPF
GoFish_WPF      GoFish_WPF.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:GoFish_WPF       � Title$  Go Fish!��$	��500��$	��525��
������� � 	Resources    GoFish_WPF.Game   game��%   &	          .��� $��10q� � DataContext# [   � ColumnDefinitions �� $��5* ��� $��40 ��� $��2* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� �� $
��Auto ��� $
��Auto �$	��150���� $
��Auto �.+��� $��	Your Name����  �� Orientation$ 
Horizontal=�$��1��.+��� -    ��Name$ 
playerName��$��12(�$	��150��{��� *GameNotStarted+���� *
PlayerName+ �� Mode$ TwoWay=��� -    ��Name$ startButton��$
��5, 0q�$��Start the game!��$��20��$	��Top=�{��� *GameNotStarted+�� $��Game progress��$��2��$��0,10,0,0q��� $��3��$��12(�
�������
���   ����� *GameProgress+�� $��Books��$��0,10,0,0q�$��4���� $��12(�
�������
���   �$��5��$��2������ *Books+�� $��	Your hand��$��0��$��2���� -   	 ��Name$	 cards��
�������$��12(�$
��Auto��$��0,0,0,10q�$��1��$��5��$��2��{��� *GameInProgress+���� *Hand+�� -   $ askForACard��$��Ask for a card��$��Stretch=�$��Stretch=�$��6��$��2��{��� *GameInProgress+