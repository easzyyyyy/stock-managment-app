   M S B A M L   `   `   `  ���� L  HStockManagmentApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:StockManagmentApp.ViewsStockManagmentApp.Views  K*clr-namespace:StockManagmentApp.ViewModelsStockManagmentApp.ViewModels  +    %StockManagmentApp.Views.StockListView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7views%clr-namespace:StockManagmentApp.Views     A
viewmodels*clr-namespace:StockManagmentApp.ViewModels     .��� 
�������$��10q�  � RowDefinitions  �� $
��Auto ��� $��* ��� $
��Auto �.+�� $��0��
������� � ColumnDefinitions �� $��* ��� $��* ��� $
��0.5* ��� $��* ��� $��* ��� $��17 �.+��� $��Place��$
��Bold"�$��0���� $��Product��$
��Bold"�$��1���� $��Amount��$
��Bold"�$��2���� $��Last Arrival��$
��Bold"�$��3���� $��Next Arrival��$
��Bold"�$��4���� -    ��Name$ StockListScrollView��$��1��.���� -    ��Name$ StockListListView��$��Stretch=����� .R��  �� $��* ��� $��* ��� $
��0.5* ��� $��* ��� $��* �.+��� $��0������ *
Place.Name+�� $��1������ *Product.Name+�� $��2������ *Amount+�� $��3������ *LastArrival+�� $��4������ *NextArrival+�� $��2��$��0 20 0 0q�.+�� -    �Name$ StockFormGrid�� �� $��* ��� $��* ��� $
��0.5* ��� $��* ��� $��* ��� $��17 �.+��� -    ��Name$ PlaceComboBox��$��0������ .R��� ���� *Name+�� -   $ ProductComboBox��$��1������ .R��� ���� *Name+�� -    ��Name$ AmountTextBox��$��Amount��$��Center=�$��2��(  "System.Windows.Controls.DatePicker  -     Name$ LastArrivalDatePicker��   Text$ dzdaz��$��3��  -   $ NextArrivalDatePicker��$ dzdaz��$��4���� -	   	 ��Name$	 AddStockButton��$	��Add��$��50��$
��0 10q�