   M S B A M L   `   `   `  ����L  HStockManagmentApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:StockManagmentApp.ViewsStockManagmentApp.Views  5      K*clr-namespace:StockManagmentApp.ViewModelsStockManagmentApp.ViewModels  5      *    $StockManagmentApp.Views.AddPlaceView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7views%clr-namespace:StockManagmentApp.Views     5      A
viewmodels*clr-namespace:StockManagmentApp.ViewModels     5      .��5      � 
�������$��10q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6   
������� � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��17 �6#   .+�5       �� $
��Name��6   $
��Bold"�6#   $��0��65   �� 5!      $��Address��6   $
��Bold"�6&   $��1��68   �� 5"      $��Country��6   $
��Bold"�6&   $��2��68   �� 5#      $
��City��6   $
��Bold"�6#   $��3��65   �� 5$      $
��Area��6   $
��Bold"�6#   $��4��65   �� 5%      $��Price��6   $
��Bold"�6$   $��5��66   5'      �� 5)   
   -   5         ��Name$ AddPlaceScrollView��5)      $��1��63   .��5*      �� -   5         ��Name$ AddPlaceListView��5*      $��Stretch=�61   ��5+      �� 5,      .R�5-      �  5.      �� 5/   "   $��* �63   �� 50   "   $��* �63   �� 51   "   $��* �63   �� 52   "   $��* �63   �� 53   "   $��* �63   �� 54   "   $��* �63   .+�57      �� $��0��6=   ��6$   �� *Name+6=   �� 58      $��1��6@   ��6$   �� *	Address+6@   �� 59      $��2��6@   ��6$   �� *	Country+6@   �� 5:      $��3��6=   ��6$   �� *City+6=   �� 5;      $��4��6=   ��6$   �� *Area+6=   �� 5<      $��5��6>   ��6$   �� *Price+6>   5=      5>      5@      5A      �� 5C   
   $��2��6   $��0 20 0 0q�6"   .+�5E      � -   5         �Name$ PlaceFormGrid��5E       5G      �� 5H      $��* �6'   �� 5I      $��* �6'   �� 5J      $��* �6'   �� 5K      $��* �6'   �� 5L      $��* �6'   �� 5M      $��* �6'   �� 5O      $��17 �6'   .+�5R      �� -   5         ��Name$ NameTextBox��5R      $
��Name��6/   $��0��6u   �� 5S      -   5        $ AddressTextBox��5S      $��Address��62   $��1��6|   �� 5T      -   5        $ CountryTextBox��5T      $��Country��62   $��2��6|   �� 5U      -   5        $ CityTextBox��5U      $
��City��6/   $��3��6u   �� 5V      -   5        $ AreaTextBox��5V      $
��Area��6/   $��4��6u   �� 5W      -	   5        $ PriceTextBox��5W      $��Price��60   $��5��6w   5Y      �� 5[      -
   5         ��Name$ AddPlaceButton��5[      $	��Add��6J   $��50��6X   $
��0 10q�6c   5]      5_      5a      