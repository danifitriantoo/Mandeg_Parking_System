   M S B A M L   `   `   `  ����J  FPC_KAB_GROBOGAN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:PC_KAB_GROBOGAN.Views.Transaction!PC_KAB_GROBOGAN.Views.Transaction  5   	   :    4PC_KAB_GROBOGAN.Views.Transaction.ParkingPaymentView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:PC_KAB_GROBOGAN.Views.Transaction     5   	     � Title$  ParkingPaymentView��5   	   $	��450��6$   $	��800��61    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �� -   5         ��Name$ 
txtLicense��5      $
��Left=�6&   $��23��6A   $��
235,75,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   $��License Plate��6   $
��Left=�6(   $��
134,73,0,0q�6C   $	��Top=�6W   �� 5   
   -   5        $ 
txtVehicle��5      $
��Left=�6&   $��23��6A   $��235,106,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   $��Vehicle Type��6   $
��Left=�6'   $��134,104,0,0q�6B   $	��Top=�6W   �� 5   
   -   5        $ 	txtInDate��5      $
��Left=�6%   $��23��6@   $��235,183,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   $
��Date��6   $
��Left=�6   $��134,181,0,0q�6:   $	��Top=�6O   �� 5   
   -   5        $ 	txtInTime��5      $
��Left=�6%   $��23��6@   $��235,214,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   $
��Time��6   $
��Left=�6   $��134,212,0,0q�6:   $	��Top=�6O   �� 5   
   $��IN TIME��6   $
��Left=�6"   $��134,155,0,0q�6=   $	��Top=�6R    J� RenderTransformOrigin$ 0.675,-0.141&�6j   �� 5   
   -   5        $ 
txtOutDate��5      $
��Left=�6&   $��23��6A   $��235,284,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   $
��Date��6   $
��Left=�6   $��134,282,0,0q�6:   $	��Top=�6O   �� 5   
   -   5        $ 
txtOutTime��5      $
��Left=�6&   $��23��6A   $��235,315,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   $
��Time��6   $
��Left=�6   $��134,313,0,0q�6:   $	��Top=�6O   �� 5   
   $��OUT TIME��6   $
��Left=�6#   $��134,256,0,0q�6>   $	��Top=�6S   $ 0.675,-0.141&�6k   �� 5   
   -   5        $ txtLicense_Copy2��5      $
��Left=�6,   $��23��6G   $��
536,74,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   $��Owner��6   $
��Left=�6    $��
435,72,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $ txtVehicle_Copy2��5      $
��Left=�6,   $��23��6G   $��536,105,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   $��Member Type��6   $
��Left=�6&   $��435,103,0,0q�6A   $	��Top=�6V   �� 5   
   -	   5        $ txtParkDuration��5      $
��Left=�6+   $��23��6F   $��540,184,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   $��Parking Duration��6   $
��Left=�6+   $��439,182,0,0q�6F   $	��Top=�6[   �� 5   
   -
   5        $ txtHourlyRate��5      $
��Left=�6)   $��23��6D   $��540,215,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5    
   $��Hourly Rate��6   $
��Left=�6&   $��439,213,0,0q�6A   $	��Top=�6V   �� 5!   
   $��PARKING DURATION��6   $
��Left=�6+   $��439,156,0,0q�6F   $	��Top=�6[   $ 0.675,-0.141&�6s   �� 5"   
   -   5        $ 	txtAmount��5"      $
��Left=�6%   $��23��6@   $��540,255,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5#   
   $��Amount To Pay��6   $
��Left=�6(   $��439,253,0,0q�6C   $	��Top=�6X   �� 5$   
   -   5         ��Name$ 	btnSubmit��5$      $��SUBMIT��6$   $
��Left=�65   $��562,300,0,0q�6P   $	��Top=�6e   $��98��6}   $��39��6�   ��6�   �� *InsertCommand+5&      5'      