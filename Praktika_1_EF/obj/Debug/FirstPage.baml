   M S B A M L   `   `   `  ����H  DPraktika_1_EF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Praktika_1_EFPraktika_1_EF  5          Praktika_1_EF.FirstPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Praktika_1_EF     5        N� Title$  	FirstPage��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ NAME_COFFEEDataGrid��5         AutoGenerateColumns .  $��0,170,0,151q�6L      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID_NAME_COFFEE_HOUSE+  5      $ Название��6%    67   �� *TITLE+  5      $ 
Адрес��6%    64   �� *ADDRESS_COFFEE_HOUSE+5      �� 5   
   -   5         ��Name$ insert��5      $#��Добавить данные��6"   $��
0,430,10,0q�6<   6Q   �� 5   
   -   5        $ delete��5      $#��Удаление данных��6"   $��0,405,10,20q�6<   6Q   �� 5   
   -   5        $ update��5      $'��!Обновление данных��6"   $��0,380,10,45q�6>   6S   �� 5   
   -   5         ��Name$
 text��5      $��0,361,10,67q�6    .��65    � 	Resources 5      	 �� 
TargetType
 �� Property �� Value �� 
TargetType ��Name ��Name J� IsHitTestVisible ��Name �� Triggers P� Property P� Value �� 
TargetName��%5  '��       �� 5      "	 ��6   .�5      �� 
 � �� 5      �� 5      " ��6.   .R�5   "   � .+�5   &   �� $ border��6-   #��z��5       #��z��5!      #��z��5"      �� 5#   &   $ 	watermark��60   $8��2Введите название кофейни ...��5$       $��2q�5%       
�������$y�	Collapsed=�5'        .  5(       �� 5)   &   $ PART_ContentHost��63   5*   #    5+   "   P� 5,   &    � ��$  ��6>   . �5-   *   �� $ 	watermark��61   
 � y�$ Visible=�6^   5.   '   50      52      53      54      .��6!   55      �� 56   
   -   5        $ addressTextBox��56      $��0,341,10,89q�6*   .��6?    57      ��%  '��       �� 58      "	 ��6   .�59      �� 
 � �� 5:      �� 5;      " ��6.   .R�5<   "   � .+�5=   &   �� $ border��6-   #��z��5>      #��z��5?      #��z��5@      �� 5A   &   $ 	watermark��60   $"��Введите адрес...��5B       $��2q�5C       
�������$y�	Collapsed=�5E        .  5F       �� 5G   &   $ PART_ContentHost��63   5H   #    5I   "   P� 5J   &    � ��$  ��6>   . �5K   *   �� $ 	watermark��61   
 � y�$ Visible=�6^   5L   '   5N      5P      5Q      5R      .��6!   5S      5U      5V      