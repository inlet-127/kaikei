   M S B A M L   `   `   `  ����A  =Kaikei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KaikeiKaikei  5   	       Kaikei.MessageDialog   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Kaikei     5   	     � Title$  MessageDialog��5   	   $	��200��6   $	��400��6,    � 
ResizeMode$ NoResize=�68   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��45 �6   �� 5      $��45 �6   �� 5      $��45 �6   �� 5      $��45 �6    � ColumnDefinitions 5   
   �� 5      -   5         �Name$ columm1��5   +   $	��200 �6   6+   �� 5      -   5        $ columm2��5   +   $	��200 �6   6+   .+�5   
   �� -   5        $��
MessageBox��5      $��0��6&   $��2��63   $��0��6D   $��2��6T    �� TextAlignment$ Center=�6h   $��Center=�6   $�� ��6�   �� 5   
   -   5        $��CenterPntBtn��5      $��OK��6%   $��2��62   $��0��6?   $��2��6O   $��2��6`   $��30��6t   $	��100��6�   $��Center=�6�   $y�Visible=�6�   6�   �� 5   
   -   5        $��
LeftPntBtn��5      $��OK��6#   $��2��60   $��0��6=   $��1��6M   $��2��6a   $��30��6r   $	��100��6~   $��Center=�6�   $y�Hidden=�6�   6�   �� 5   
   -   5        $��	CancelBtn��5      $��キャンセル��6"   $��2��62   $��1��6?   $��1��6O   $��2��6c   $��30��6t   $	��100��6�   $��Center=�6�   $y�Hidden=�6�   6�   5      5      