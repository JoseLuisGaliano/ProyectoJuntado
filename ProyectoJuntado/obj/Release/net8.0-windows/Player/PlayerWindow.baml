   M S B A M L   `   `   `  ����   ProyectoJuntado    Player.PlayerWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Music Player��$	��550��$	��815��.��� 
���   � � ColumnDefinitions �� �� $��4* � � RowDefinitions �� $
��Auto ��� .+��� $��2��$��Center=�$��Center=�$
��Auto��$��10q�.+��� -    ��Name$ 	SongImage��$	��150��$	��289��$��0,0,0,10q��� -    ��Name$ SongTitleTextBlock��
�������$��18(�$
��Bold"�$��Center=��� -   $ ArtistNameTextBlock��
�������$��14(�$��Center=���  �� Orientation$ 
Horizontal=�$��Center=�$��10q�.+��� -    ��Name$ PreviousButton��
������ $��0q��� -   $ 
PlayButton��$y�Visible=�
������ $��0q��� -   $ PauseButton��$y�	Collapsed=�
������ $��0q��� -   $ 
NextButton��
������ $��0q�$	��120���� -   $ QueueButton��$��Queue��
������ 
�������$��0q��� -	   $ DownloadButton��$��Download��
������ 
�������$��0q�$��64���� -
    ��Name$ QueueListBox��$��1��$��10q�