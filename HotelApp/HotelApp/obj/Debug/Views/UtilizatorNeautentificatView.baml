   M S B A M L   `   `   `  ����C  ?HotelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HotelApp.ViewModelsHotelApp.ViewModels  5   	   1    +HotelApp.Views.UtilizatorNeautentificatView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:HotelApp.ViewModels     5   	     � Title$"  UtilizatorNeautentificatView��5   	   $	��450��6.   $	��800��6;    � DataContext 5	      4  .HotelApp.ViewModels.UtilizatorNeautentificatVM  5
   
   .��5      � .+�5   
   �� $��Guest��6   $
��Left=�6    $��
325,24,0,0q�6;   $	��Top=�6O   $	��236��6g   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��
244,65,0,0q�60   $	��Top=�5   Z      SelectedDate 6   �� *DateIn+ �� UpdateSourceTrigger$ PropertyChanged=�6Z     5   
   $
��Left=�6   $��
244,96,0,0q�60   $	��Top=�5   [    6   �� *	DateOut+$ PropertyChanged=�6[   �� 5   
   $��Choose a date :��6   $
��Left=�6*   $��	69,77,0,0q�6E   $	��Top=�6X   �� 5   
   $��Check in��6   $
��Left=�6#   $��
166,63,0,0q�6>   $	��Top=�6R   �� 5   
   $��	Check out��6   $
��Left=�6$   $��
166,94,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $��roomlist��5      $��23,143,25,25q�6#   ��69   �� *Rooms+ �� View 5      �� 5      .P�5      �� $��Nume camera��6%    �� Width$	 190��6:    �� DisplayMemberBinding 6F   �� *nume+�� 5      $
��Pret��6%   $	 100��63    6?   �� *pret+�� 5      $��
Capacitate��6%   $ 70��69    6D   �� *
capacitate+�� 5      $��Dotari��6%   $	 190��65    6A   �� *detalii_dotare+�� 5      $��Servicii��6%   $	 190��67    6C   �� *detalii_serviciu+�� 5      $��Imagine��6%   $	 250��66    �� CellTemplate 5      �� 5      .R�5    "   �� ��6(   �� *	imagine+5!      5#      5$      5&      �� 5'   
   $��Cautare��6   $
��Left=�6#   $��
456,83,0,0q�6>   $	��Top=�5(   8   ��6   �� *OpenSearchCommand+68   5*      5+      