   M S B A M L   `   `   `  ���� I  ESpace Invaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Space_Invaders.ViewSpace_Invaders.View  C&clr-namespace:Space_Invaders.ViewModelSpace_Invaders.ViewModel  "    Space_Invaders.View.MainPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:Space_Invaders.View     <	viewmodel&clr-namespace:Space_Invaders.ViewModel     -     � Title$  Space Invaders!�� � 
ResizeMode$ CanResizeWithGrip=� � SizeToContent$ Manual=� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � WindowStyle$ SingleBorderWindow=�$��Center=�$��Center=� � 	Resources 0  *Space_Invaders.ViewModel.InvadersViewModel   	viewModel9  3Space_Invaders.ViewModel.BooleanVisibilityConverter  booleanVisibilityConverter  MyImageSource �� 	UriSource��%H   &	        &	      &	 
         �� $ ../Images/player.png?�.��� 
���   � � DataContext# [  	 � ColumnDefinitions	 �� $
��Auto ��� $
��Auto �.+��� $��1��$��5q�.+��� -   $��5q�
��� � �
���   �$��20(�$��OCR A Extended)�$��2q�
����  �$
��Left=�.���� 
���   �.+��� About� -   $��
aboutPopup��.���� 
 �� Orientation$
 Vertical=�
���   �.+��� 
��� � �
������ $��10q�$��15(�Brought to you by:�� 
��� � �
������ $��10, 0, 5, 10q�$��15(�Andrew Schroeder and�� $	��200������ $ /Images/hfcsharp.gif?��� 
��� � �$��OCR A Extended)�$��20(�$��5q��� .�Score: �� ��� *Score+ �� Mode$ OneWay=��� 
��� � �$��OCR A Extended)�$��20(�$��5q��� .�Wave: �� ��� *Wave+$ OneWay=��� 
���   �
���   �$��5q�����  �� Path$ Lives����� .R��� #��[ $��25��$��20���� -    ��Name$ playArea��
����  �$��2q�$��0�� �� CornerRadius$ 10��
���   �._��� ���� $ Sprites����� .R���  ��Name$ canvas��
���   ��� $
 Vertical=�$��Center=�$��Center=�.+��� $��Paused��$��Center=�
��� � �$��1��$��40(�$��OCR A Extended)�$��Center=�y��� *Paused+ �� 	Converter# [ �� $��	Game Over��$��Center=�
��� � �$��1��$��40(�$��OCR A Extended)�$��Center=�y��� *
GameOver+# [ �� -   $��Restart Game��
��� � �
������ $��40(�$��OCR A Extended)�
������ y��� *
GameOver+# [ 