   M S B A M L   `   `   `  ���� K  GRenamer_Project1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Renamer_Project1Renamer_Project1  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem !    Renamer_Project1.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Renamer_Project1     9System&clr-namespace:System;assembly=mscorlib       � Title$  Renamer��$	��600��$	��800��.���� -    ��Name$ 
tabControl��.@��� -    ��Name$ tabItem1��$��CopyName��.��]� ���	#FFE5E5E5.+�o� $	��Top=�.@�m� $��_Rename��.@�m� -   $
��_Run��m� -   $��_Restore��m� -   $��_Clear���  � ColumnDefinitions �� �� .+��� -    ��Name$ 	listView1��$��10q� J� 	AllowDrop . ����  �� 
TargetType" ��.���  �� Property �@��
IsSelected �� Value �� *
Selected+	 � ContextMenu	 �� .@�m� -   $��_Remove��m� -   $��_Clear��
 �� View
 �� .P��� $��	Extension�� �� DisplayMemberBinding �� *	Extension+�� $��FileName�� �� *
FileName+�� -	   $ 	listView2��$��10q� . $��1������ " ��.���  �@��
IsSelected �� *
Selected+	 �� .@�m� -
   $��_Remove��m� -   $��_Clear��
 �� .P��� $��	Extension�� �� *	Extension+�� $��FileName�� �� *
FileName+�� -   $ tabItem2��$��TempName��.��]� ���	#FFE5E5E5.+�o� $	��Top=�.@�m� $��_Rename��.@�m� -   $
��_Run��m� -   $��_Restore��m� -   $��_Clear��� $	��Top=� � RowDefinitions �� �� .+��� -    ��Name$ textBox1��$��0��$��10q� �� 
IsReadOnly . �� $��1�� �� Orientation$ 
Horizontal=�.+��� -   $ textBox4��$
��10,0q�$��40��$��Center=��� -    ��Name$ 	comboBox1��$
��10,0q�$��60�� �� 
IsEditable .  �� SelectedIndex$ 0��$��Center=�.@��� .��EP�� .��SP�� .��OVA�� .��OAD�� .��OP�� .��ED�� .��Menu�� .��etc�� -    ��Name$ 	checkBox1��$��10,0,0,0q� d� 	IsChecked$
 TrueY�$��Center=��� -   $ textBox2��$
��10,0q�$��20��$��1��$��Center=�$��Right=��� $��10,0,0,0q�$��Pad 0��$��Center=��� -   $ textBox3��$
��10,0q�$��20��$��2��$��Center=�$��Right=��� -   $ 	checkBox2��$��0q�$
��Auto��$
 TrueY�$��Center=��� -   $ 	listView3��$��10q� . ���� " ��.���  �@��
IsSelected �� *
Selected+	 �� .@�m� -   $��	_TempName��m� -   $��_Remove��m� -   $��_Clear��
 �� .P��� $��TempName�� �� *
TempName+�� $��	Extension�� �� *	Extension+�� $��FileName�� �� *
FileName+