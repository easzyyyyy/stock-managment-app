   M S B A M L   `   `   `  ����L  HStockManagmentApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:StockManagmentApp.ViewsStockManagmentApp.Views  5      K*clr-namespace:StockManagmentApp.ViewModelsStockManagmentApp.ViewModels  5      ,    &StockManagmentApp.Views.AddProductView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7views%clr-namespace:StockManagmentApp.Views     5      A
viewmodels*clr-namespace:StockManagmentApp.ViewModels     5      .��5      � 
�������$��10q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6   
������� � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��17 �6#   .+�5      �� $
��Type��6   $
��Bold"�6#   $��0��65   �� 5      $
��Name��6   $
��Bold"�6#   $��1��65   �� 5      $��Price��6   $
��Bold"�6$   $��2��66   5!      �� 5#   
   -   5         ��Name$ AddProductScrollView��5#      $��1��65   .��5$      �� -   5         ��Name$ AddProductListView��5$      $��Stretch=�63   ��5%      �� 5&      .R�5'      �  5(      �� 5)   "   $��* �63   �� 5*   "   $��* �63   �� 5+   "   $��* �63   .+�5.      �� $��0��6=   ��6$   �� *Type+6=   �� 5/      $��1��6=   ��6$   �� *Name+6=   �� 50      $��2��6>   ��6$   �� *Price+6>   51      52      54      55      �� 57   
   $��2��6   $��0 20 0 0q�6"   .+�59      � -   5         �Name$ ProductFormGrid��59       5;      �� 5<      $��* �6'   �� 5=      $��* �6'   �� 5>      $��* �6'   �� 5@      $��17 �6'   .+�5C      �� -   5         ��Name$ TypeTextBox��5C      $
��Type��6/   $��0��6u   �� 5D      -   5        $ NameTextBox��5D      $
��Name��6/   $��1��6v   �� 5E      -   5        $ PriceTextBox��5E      $��Price��60   $��2��6x   5G      �� 5I      -   5         ��Name$ AddProductButton��5I      $	��Add��6N   $��50��6\   $
��0 10q�6g   5K      5M      5O      