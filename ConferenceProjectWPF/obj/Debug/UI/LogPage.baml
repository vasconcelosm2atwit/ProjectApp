   M S B A M L   `   `   `  ����O  KConferenceProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ConferenceProjectWPF.UIConferenceProjectWPF.UI  5      %    ConferenceProjectWPF.UI.LogPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ConferenceProjectWPF.UI     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  LogPage��5      .��5      ]� ��. .+�5   
   �� 
���  ��$��Bottom=�6&   �� 5   
   
����  �$
��Left=�6'   �� 5   
   $	��Top=�6   .+�5      �� $��10q�5      $��Center=�5       $   MaterialDesignHeadline4TextBlock#��[  5      $	��Log��5      5      � 5   
   .+�5      �� $��0,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ LogGrid��5      $	��800��5      $	��400��5      $��0,10,0,0q�5         AlternatingRowBackground
 �����   AutoGenerateColumns .  
�������
���   �$��1q�5$         CanUserAddRows .     CanUserResizeColumns .     GridLinesVisibility$
 None=�5'         HeadersVisibility$ Column=�5(         SelectionMode$ Extended=�5*      	 �� SelectedItem	 5)      �� *SelectedItem+
 � 	Resources
 5+      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value �� Color��%�  '        (�� �    57   *   * SystemColors.HighlightBrushKey+)�� 5,      "  6    .�5-      ��  � �� �	#FF14234F6;   �� 5.       � ��
 ���� 6<   �� 5/       � ��$ SemiBold"�6;   �� 50       � ��$ 0q�6@   �� 51       � ��
 �����6;   �� 52       � ��$ Center=�6K   �� 53       � ��$ 35��67   �� 54       � ��$ 12(�69   �� 55       � ��$ Verdana)�6;   56      �� 57      $ #FF0000��6\   58         Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 5;         Header$ Log Id��5=         
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5<      �� *Session_title+5>        5?      $	 150 5@      $ Log Description��5B       .  5A      �� *Session_title+5C      5E      5F      5G      5H      5I      