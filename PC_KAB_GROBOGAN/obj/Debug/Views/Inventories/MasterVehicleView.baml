   M S B A M L   `   `   `  ����J  FPC_KAB_GROBOGAN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:PC_KAB_GROBOGAN.Views.Inventories!PC_KAB_GROBOGAN.Views.Inventories  5   	   9    3PC_KAB_GROBOGAN.Views.Inventories.MasterVehicleView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:PC_KAB_GROBOGAN.Views.Inventories     5   	     � Title$  MasterMemberView��5   	   $	��646��6"   $
��1112��6/   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  $
��Left=�6r   $	��206��6�   $��	42,95,0,0q�6�   $	��Top=�6�   $
��1014��6�   ��6   �� *
Collection+ �� SelectedItem 66   �� *Model+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ VEHICLE TYPE��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *vehicle_type_id+  5      $ MEMBER��6%    65   �� *	member_id+  5      $ LICENSE PLATE��6%    6<   �� *license_plate+  5      $ NOTES��6%    64   �� *notes+5      �� 5   
   -   5         ��Name$ txtPlate��5      $
��Left=�6$   $��51��6?   $��432,335,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6�   $	��219��6�   ��6t   �� *Model.vehicle_plate+ �� Mode$ TwoWay=�6�   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��23��6>   $��432,391,0,0q�6J   $
 Wrap=�6_   $	��Top=�6�   $	��219��6�   ��6s   �� *Model.member_id+$ TwoWay=�6�   �� 5   
   -   5        	 ��Name$	 txtNotes��5      $
��Left=�6(   $��57��6C   $��432,447,0,0q�6O   $	��Top=�6d   $	��219��6|   . �5      /� .T�5      J� .*�6   .*�5      �� �6   �� *Model.notes+$ TwoWay=�5      5      5      �� 5   
   $��Vehicle Plate��6   $
��Left=�6(   $��280,332,0,0q�6C   $	��Top=�6X   �� 5   
   -   5        
 ��Name$
 	btnInsert��5      $��INSERT��6$   $
��Left=�65   $��690,335,0,0q�6P   $	��Top=�6e   $	��117��6}   $��39��6�   6�   �� 5   
   -   5        $
 	btnUpdate��5      $��UPDATE��6$   $
��Left=�65   $��690,380,0,0q�6P   $	��Top=�6e   $	��117��6}   $��39��6�   6�   �� 5   
   -   5        $
 	btnDelete��5      $��DELETE��6$   $
��Left=�65   $��690,424,0,0q�6P   $	��Top=�6e   $	��117��6}   $��39��6�   6�   �� 5    
   -   5        $
 	btnSubmit��5       $��SUBMIT��6$   $
��Left=�65   $��690,484,0,0q�6P   $	��Top=�6e   $	��117��6}   $��39��6�   6�   �� 5!   
   -   5        $
 	btnCancle��5!      $��CANCEL��6$   $
��Left=�65   $��690,528,0,0q�6P   $	��Top=�6e   $	��117��6}   $��39��6�   6�   �� 5"   
   $��Owner��6   $
��Left=�6    $��280,391,0,0q�6;   $	��Top=�6P   �� 5#   
   $��Vehicle Type��6   $
��Left=�6'   $��280,419,0,0q�6B   $	��Top=�6W    J� RenderTransformOrigin$ 0.526,1.731&�6o   �� 5$   
   $
��Note��6   $
��Left=�6   $��280,450,0,0q�6:   $	��Top=�6O   $ 0.526,1.731&�6g   �� 5%   
   -	   5         ��Name$ cmbVehicleType��5%      $
��Left=�6+   $��432,419,0,0q�6F   $	��Top=�6[   $	��219��6s   5'      5(      