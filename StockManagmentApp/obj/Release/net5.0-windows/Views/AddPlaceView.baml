   M S B A M L   `   `   `  ���� L  HStockManagmentApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:StockManagmentApp.ViewsStockManagmentApp.Views  K*clr-namespace:StockManagmentApp.ViewModelsStockManagmentApp.ViewModels  *    $StockManagmentApp.Views.AddPlaceView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7views%clr-namespace:StockManagmentApp.Views     A
viewmodels*clr-namespace:StockManagmentApp.ViewModels     .��� 
�������$��10q�  � RowDefinitions  �� $
��Auto ��� $��* ��� $
��Auto �.+�� $��0��
������� � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��17 �.+��� $
��Name��$
��Bold"�$��0���� $��Address��$
��Bold"�$��1���� $��Country��$
��Bold"�$��2���� $
��City��$
��Bold"�$��3���� $
��Area��$
��Bold"�$��4���� $��Price��$
��Bold"�$��5���� -    ��Name$ AddPlaceScrollView��$��1��.���� -    ��Name$ AddPlaceListView��$��Stretch=����� .R��  �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0������ *Name+�� $��1������ *	Address+�� $��2������ *	Country+�� $��3������ *City+�� $��4������ *Area+�� $��5������ *Price+�� $��2��$��0 20 0 0q�.+�� -    �Name$ PlaceFormGrid�� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��17 �.+��� -    ��Name$ NameTextBox��$
��Name��$��0���� -   $ AddressTextBox��$��Address��$��1���� -   $ CountryTextBox��$��Country��$��2���� -   $ CityTextBox��$
��City��$��3���� -   $ AreaTextBox��$
��Area��$��4���� -	   $ PriceTextBox��$��Price��$��5���� -
    ��Name$ AddPlaceButton��$	��Add��$��50��$
��0 10q�