   M S B A M L   `   `   `  ���� L  HStockManagmentApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:StockManagmentApp.ViewsStockManagmentApp.Views  K*clr-namespace:StockManagmentApp.ViewModelsStockManagmentApp.ViewModels  ,    &StockManagmentApp.Views.AddProductView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7views%clr-namespace:StockManagmentApp.Views     A
viewmodels*clr-namespace:StockManagmentApp.ViewModels     .��� 
�������$��10q�  � RowDefinitions  �� $
��Auto ��� $��* ��� $
��Auto �.+�� $��0��
������� � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��17 �.+��� $
��Type��$
��Bold"�$��0���� $
��Name��$
��Bold"�$��1���� $��Price��$
��Bold"�$��2���� -    ��Name$ AddProductScrollView��$��1��.���� -    ��Name$ AddProductListView��$��Stretch=����� .R��  �� $��* ��� $��* ��� $��* �.+��� $��0������ *Type+�� $��1������ *Name+�� $��2������ *Price+�� $��2��$��0 20 0 0q�.+�� -    �Name$ ProductFormGrid�� �� $��* ��� $��* ��� $��* ��� $��17 �.+��� -    ��Name$ TypeTextBox��$
��Type��$��0���� -   $ NameTextBox��$
��Name��$��1���� -   $ PriceTextBox��$��Price��$��2���� -    ��Name$ AddProductButton��$	��Add��$��50��$
��0 10q�