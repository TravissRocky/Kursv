   M S B A M L   `   `   `  ����E  AUPPRAKTIKA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:UPPRAKTIKA
UPPRAKTIKA  5      9!clr-namespace:UPPRAKTIKA.CommandsUPPRAKTIKA.Commands  5      G(clr-namespace:UPPRAKTIKA.ValidationRulesUPPRAKTIKA.ValidationRules  5      3clr-namespace:UPPRAKTIKA.ModelUPPRAKTIKA.Model  5	          UPPRAKTIKA.PageIncome   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:UPPRAKTIKA     5      5command!clr-namespace:UPPRAKTIKA.Commands     5      9rule(clr-namespace:UPPRAKTIKA.ValidationRules     5      /coreclr-namespace:UPPRAKTIKA.Model     5	      -   5          N� Title$  
PageIncome��5       � 	Resources 5          UPPRAKTIKA.Model.ListTitle   	ListTitle  
errorStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� RelativeSource	 �� Path��%c  &	        &	        5   
   6   �� 5   
   " ��6#   .�5      ��  � ��$ -2q�6(    5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��63   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 5      ��  �� *Self+$)	 #(Validation.Errors)[0].ErrorContent�5       5"      5$      
 J� CommandBindings
 5&      )  #System.Windows.Input.CommandBinding  5'   
   -   5           Command$
 Undo��5'      5)        5-   
   -   5        &    UPPRAKTIKA.Commands.DataCommands   Edit# Z 5-      5/        50   
   -   5        $
 Find��50      51        53   
   -   5        $
 Save��53      56        57   
   -   5           Delete# Z 57      59        5:   
   -   5        $	 New��5:      5<        5>   
   -   5        $ Refresh��5>      5?      .��5E      �� $��3q�6     BackgroundWindowResource#��[ 6   .+�5G   
   o� .@�5I      m� $��Действие��6   .@�5K      m� $��Отменить��6    m� Command$
 Undo��6-   5M      �� 5N      6   m� 5O      $��Обновить��6   $ Refresh��6-   m� 5P      $��Создать��6   $	 New��6,   6<   m� 5Q      $ ��Редактировать��6   # Z 62   6c   m� 5R      $��Сохранить��6   $
 Save��6.   6?   m� 5S      $��
Найти��6   $
 Find��6*   �� 5T      6   m� 5U      $��Удалить��6   # Z 6,   6_   5V      m� 5W      $��
Отчет��6   6(   5X      c� 5Y   
   -	   5        $��ToolBar1��5Y      $��3q�6"   .@�5Z      �� -
   5        $
��Undo��5Z       � ToolTip$D >Отменить редактирование/создание��6!   $	��0,2q�5[      $��35��6   $��74��6   $
��Undo��6&   .��5\      �� $��images/undo.png��6   5]      �� 5^      -   5        $	��Add��5^      $ Добавить��6    $��5,2,5,2q�5_      $	��New��6   .��5`      �� $��images/add.png��6   $��35��60   $��74��6<   5a      �� 5b      -   5        $
��Edit��5b      $- 'Редактировать данные��6!   $��5,2,5,2q�5c      #��Z 6   .��5d      �� $��images/edit.png��6   $��35��61   $��74��6=   5e      �� 5f      -   5        $
��Find��5f      $ Найти данные��6!   $��5,2,5,2q�5g      $
��Find��6   .��5h      �� $��images/find.png��6   $��35��61   $��74��6=   5i      �� 5j      -   5        $
��Save��5j      $ Сохранить��6!   $��5,2,5,2q�5k      $
��Save��6   .��5l      �� $��images/save.png��6   $��35��61   $��74��6=   5m      �� 5n      -   5        $��Delete��5n      $ Удалить��6#   $��5,2,5,2q�5o      #��Z 6   .��5p      �� $��images/delete.png��6   $��35��63   $��74��6?   5q      5s      c� 5u   
   -   5        $��ToolBar2��5u      $��3q�6#   $	��112��6/   .@�5v      �� $��5q�6   
Доход6+   &   System.Windows.Controls.DataGrid  5w      -   5        $��DataGridEmployee��5w         AutoGenerateColumns .  $
��Left=�5z      $
��1000��5{      $	��295��6'      RowBackground �	#FFE6D3EF   AlternatingRowBackground �	#FC96CFD4���	#FF1F33EB$��3q�5         
IsReadOnly .    	RowHeight$ 25Q�5�       � Cursor$
 Hand��5�      ��5x      ��    Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$  КодСотрудника��6)   1  +System.Windows.Controls.DataGridBoundColumn   EditingElementStyle# [ 6A      Binding 5�      �� 5�      $ 	 КодСотрудника�6&    �� Mode$ TwoWay=�6;    �� UpdateSourceTrigger$ PropertyChanged=�6I    �� ValidatesOnExceptions .  �� ValidationRules 5�   "   3   -UPPRAKTIKA.ValidationRules.SymbolsSpecialRule  5�   &   5�      5�        5�      $ ВидДохода��6)   # [ 6=    5�      �� 5�      $	 ВидДохода�6&   $ TwoWay=�67   $ PropertyChanged=�6E    .  5�   "     5�   &   5�      5�        5�      $ СуммаДохода��6)   # [ 6?    5�      �� 5�      $	 СуммаДохода�6&   $ TwoWay=�69   $ PropertyChanged=�6G    .  5�   "     5�   &   5�      5�      !   RowValidationErrorTemplate 5�      �� 5�      .R�5�      � $��	0,-2,0,-2q�6    62   ��  �� *FindAncestor+ �� AncestorType)	  #System.Windows.Controls.DataGridRow" 	 $)	 #(Validation.Errors)[0].ErrorContent�.+�5�      A� $��0��6&   
���  ��#��z��6E   #��z��6h   �� 5�      $��!��6(   #��z��61   $
��Bold"�6W   
�������$��Center=�6|   5�      5�      5�      5�       � 5�   
   -   5           �Name$  
BorderFind��5�      $��445,82,18,248q�6$   $��62��6;   $y�Hidden=�6G   ��5�      �� 5�      ! �� EndPoint$! 0.5,1&�6&   " �� 
StartPoint$" 0.5,0&�67   .��5�      � # � Color$# Black��6#   $ � Offset$$ 0Q�61   � 5�      $
# Aqua��6#   $$ 1Q�60   5�      ��5�      � 5�      -   5        % �Name$% gridFind��5�      & � RowDefinitions& 5�      �� 5�      $��20 �6(   �� 5�      $��40 �6(   �� 5�      $��40 �6(   ' � ColumnDefinitions' 5�      �� 5�      $��70 �6+   �� 5�      $	��140 �6+   �� 5�      $��70 �6+   5�      5�      5�      5�      