   M S B A M L   `   `   `  ����C  ?HotelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HotelApp.ViewModelsHotelApp.ViewModels  5   	   &     HotelApp.Views.AdministratorView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:HotelApp.ViewModels     5   	     � Title$  AdministratorView��5   	   $	��450��6#   $	��800��60    � DataContext 5	      )   #HotelApp.ViewModels.AdministratorVM  5
   
   .��5      � .+�5   
   �� $��
Nr Camera:��6   $
��Left=�6%   $��	36,56,0,0q�6@   $	��Top=�6S   �� 5   
   $��Administrator��6   $
��Left=�6(   $��
335,10,0,0q�6C   $	��Top=�6W   $	��164��6o   �� 5   
   $
��Left=�6   $��
101,60,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�6U   $��38��5   O   $��22��6Z   ��6   �� *RoomNr+ �� UpdateSourceTrigger$ PropertyChanged=�6Z   �� 5   
   $��Add Room��6   $
��Left=�6$   $��
23,104,0,0q�6?   $	��Top=�5   4   ��6   �� *AddRoomCommand+64   �� 5   
   $��Delete Room��6   $
��Left=�6'   $��101,104,0,0q�6B   $	��Top=�5   7   ��6   �� *DeleteRoomCommand+67   �� 5   
   $��Dotari:��6   $
��Left=�6"   $��
182,56,0,0q�6=   $	��Top=�6Q   $��56��6i   �� 5   
   $
��Left=�6   $��
243,60,0,0q�6-   $
 Wrap=�6A   $	��Top=�5   T   $	��120��6l   $��22��6x   ��6   �� *RoomFeature+$ PropertyChanged=�6x   �� 5   
   $��Pret:��6   $
��Left=�6    $��
396,56,0,0q�6;   $	��Top=�6O   �� 5   
   $
��Left=�6   $��
439,60,0,0q�6-   $
 Wrap=�6A   $	��Top=�5   R   $	��120��6j   $��22��6v   ��6   �� *	RoomPrice+$ PropertyChanged=�6v   �� 5   
   $��	Servicii:��6   $
��Left=�6$   $��
589,56,0,0q�6?   $	��Top=�6S   �� 5   
   $
��Left=�6   $��
644,58,0,0q�6-   $
 Wrap=�6A   $	��Top=�5   T   $	��120��6l   $��24��6x   ��6   �� *RoomService+$ PropertyChanged=�6x   �� 5   
   $��UpdateRoomFeature��6   $
��Left=�6-   $��231,104,0,0q�6H   $	��Top=�5   :   ��6   �� *UpdateFeatureCommand+6:   �� 5    
   $��UpdateRoomPrice��6   $
��Left=�6+   $��427,104,0,0q�6F   $	��Top=�5!   8   ��6   �� *UpdatePriceCommand+68   �� 5"   
   $��UpdateRoomService��6   $
��Left=�6-   $��614,104,0,0q�6H   $	��Top=�5#   >   ��6   �� *UpdateRoomServiceCommand+6>   �� 5$   
   -   5        $��roomlist��5$      $��23,143,25,25q�6#   ��69   �� *Rooms+ �� View 5%      �� 5&      .P�5'      �� $��	Nr Camera��6%    �� Width$ 70��68    �� DisplayMemberBinding 6C   �� *	nr_camera+�� 5(      $��Valabilitate��6%   $ 70��6;    6F   �� *valabilitate+�� 5)      $��Nume camera��6%   $	 150��6:    6F   �� *nume+�� 5*      $��Status��6%   $	 100��65    6A   �� *nume_status+�� 5+      $��
Capacitate��6%   $ 60��69    6D   �� *
capacitate+�� 5,      $��Dotari��6%   $	 190��65    6A   �� *detalii_dotare+�� 5-      $��Servicii��6%   $	 190��67    6C   �� *detalii_serviciu+�� 5.      $
��Pret��6%   $ 50��63    6>   �� *pret+�� 5/      $��Imagine��6%   $	 250��66    �� CellTemplate 50      �� 51      .R�52   "   �� ��6(   �� *	imagine+53      55      56      58      5:      5;      