   M S B A M L   `   `   `  ����I  ECodeAssignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CodeAssignment.ViewCodeAssignment.View  5      &     CodeAssignment.View.PostInfoView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:CodeAssignment.View     5        � 	Resources  5       �� 
TargetType   TextBlockStyle �� Property �� Value  TextBlockDataStyle��%�   &	        &	 n     �� 5
   
   " ��6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ 12(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 12(�6)   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $	��300 �6   6+   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��Center=�6;   .+�5      �� $��Center=�6   $
��Post��66   $��14(�6B   6R   �� 5      $��14(�65   $��5,0,0,0q�6C   ��6   �� *PostItem.id+6V   5      � 5   
   $��1��6   
������� 5   
   �� 5       $
��Auto �6   6,   �� 5!      $
��Auto �6   6,   �� 5"      $
��Auto �6    60    � ColumnDefinitions 5$      �� 5%      $	��100 �6#   61   �� 5&      6%   .+�5(      �� $��0��6   #���   6%   $��0��6N   $��User Id:��6^   $��0,50,0,0q�6n   $��Center=�6�   $��Right=�6�   5)      �� 5*      $��0��6   #���  6%   $��1��6s   $
��Left=�6�   $��5,50,0,0q�6�   $��Center=�6�   ��6R   �� *PostItem.userId+6�   �� 5+      $��1��6   #���   6&   $��0��6O   $��Title:��6_   $��Right=�6m   $	��Top=�6�   $��5,10,0,0q�6�   6�   �� 5,      $��1��6   #���  6'   $
��Wrap=�6t   $��1��6�   $��5,10,0,0q�6�   $
��Left=�6�   $��Center=�6�   ��6T   �� *PostItem.title+6�   �� 5-      $��2��6   #���   6&   $��0��6O   $��Body:��6_   $��Right=�6m   $	��Top=�6�   $��5,10,0,0q�6�   6�   �� 5.      $��2��6   #���  6&   $
��Wrap=�6r   $��1��6�   $
��Left=�6�   $��5,10,0,0q�6�   ��6S   �� *PostItem.body+6�   5/      �� 50   
   $ 
Horizontal=�6   $	��Top=�6.   $��2��6F   .+�51      �� 
�������$��5q�6(   $��
Expot Json��63   ��6H   �� *
ExportJson+6i   �� 52      
�������$��5q�6(   $��Export Html��63   ��6I   �� *
ExportHtml+6j   �� 53      
�������$��5q�6(   $��Export Text��63   ��6I   �� *
ExportText+6j   54      55      56      