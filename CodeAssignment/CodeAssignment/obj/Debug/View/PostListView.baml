   M S B A M L   `   `   `  ����I  ECodeAssignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CodeAssignment.ViewCodeAssignment.View  5   	   C&clr-namespace:CodeAssignment.ViewModelCodeAssignment.ViewModel  5   	   C&clr-namespace:CodeAssignment.ConverterCodeAssignment.Converter  5   	   &     CodeAssignment.View.PostListView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CodeAssignment.View     5   	   7post&clr-namespace:CodeAssignment.ViewModel     5   	   <	Converter&clr-namespace:CodeAssignment.Converter     5   	     � Title$  PostListView��5
   	    � 	Resources 5      /   )CodeAssignment.Converter.BoolToVisibility   	BoolTOVis)   #CodeAssignment.ViewModel.PostListVM  PostListVmKey �� 
TargetType  MyHeaderStyle �� Property �� Value  CustomListViewItemStyle �� Triggers P� Property P� Value��%�  &	        &	      &	 &     &	 �       5   
   69     5   
   62   �� 5   
   " ��6   .�5      ��  � ��
 �   �6+   �� 5       � ��
 �����6+   5      �� 5   
   " ��60    5      P� 5       �@��AlternationIndex$ 0��6C   . �5      ��  � ��
 �����6C   5      P� 5       �@��AlternationIndex$ 1��6C   . �5      ��  � ��
 �   �6C   5      5       5!      .��5#      � $��20,10,10,20q�6I    � DataContext 6   �� 	 �� Source#	 [ 
 � ColumnDefinitions
 5$   
   �� 5%      $
��Auto �6   6.   �� 5&      $��* �6   6+    � RowDefinitions 5(   
   �� 5)      $��40 �6   6*   �� 5*      $��* �6   6)   .+�5,   
   �� $��16(�6   $��Post Details��6"   $��Center=�66   $��0��6S   $��2��6`   6v   �� 5-   
   #���  6   $��0��5.   $   $��1��6W   ��6   �� *
PostList+ �� SelectedValue 64   �� *
PostItem+ �� SelectedValuePath 6d   �� *id+ �� View 5/      �� 50      ! �� ColumnHeaderContainerStyle# �  6   .P�51      ��  �� Width$ 50��6&    �� DisplayMemberBinding 61   �� *userId+.��52      �� $��User Id��6/   $��userId��54      ��53      �� *SortByUserId+54      56      �� 57      $ 50��6%    60   �� *id+.��58      �� $��Post Id��6/   $��userId��5:      ��59      �� *SortByPostId+5:      5;      �� 5<      $
 Auto��6%    63   �� *title+.��5=      �� $��Title��6/   $��userId��5?      ��5>      �� *SortByTitle+5?      5@      5A      5C      &    CodeAssignment.View.PostInfoView  5D   
   $��1��6   $��	40,0,40,0q�6-   $��1��6@   $	��500��6M   y�6Z   �� *IsPostInfoVisible+ �� 	Converter# [  6�   5E      5F      