   M S B A M L   `   `   `  ����  CocktailCollectionApp-    'CocktailCollectionApp.DrinksUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      -   5        .��5	      � 
������   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� $��Add a Drink!��6   $��0��6'   $��/Fonts/#Pacifico)�64   $��0��6R   $��2��6b   $��Center=�6v   $��Center=�6�   $��24(�6�   �� 5   
   -   5        $��	drinkName��5      $��
Drink Name��6!   $��1��66   $��0��6C   $��Center=�6S   $��Right=�6n   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $��tbdrinkName��5      $��25��6&   $��1��62   $��1��6?   $��Center=�6O   $��	15,0,45,0q�6j   ��6}   �� *	Drinkname+�� 5   
   -   5        $��ingredients��5      $��Ingredients��6#   $��2��69   $��0��6F   $��Center=�6V   $��Right=�6q   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $��tbIngredients��5      $��50��6(    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6I   $��2��6]   $��1��6j   $��Center=�6z   $��	15,0,45,0q�6�   ��6�   �� *Ingredients+�� 5   
   -   5        $��method��5      $��Method��6   $��3��6/   $��0��6<   $��Center=�6L   $��Right=�6g   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $��tbMethod��5      $��50��6#    . $
 Wrap=�6D   $��3��6X   $��1��6e   $��Center=�6u   $��	15,0,45,0q�6�   ��6�   �� *Method+�� 5   
   -   5        $��alcoholContent��5      $��Alcohol Content��6&   $��4��6@   $��0��6M   $��Center=�6]   $��Right=�6x   $��14(�6�   $
��Bold"�6�   �� 5   
   -	   5        $��
tbprovince��5      $��4��6%   $��1��62   $��Center=�6B   $��25��6]   $��	15,0,45,0q�6i    �� SelectedIndex$ 0��6�    �� SelectedValue 6|   �� *Alcoholcontent+.@�5       �� .��6   High6"   �� 5!      .��6   Medium6#   �� 5"      .��6   Low6    5#      �� 5$   
   -
   5        $��btnSubmitDrink��5$      $
��Save��6'   $��
Add Drink!��66   
������ $��5��6d   $��1��6q   $��Center=�6�   $
��Left=�6�   $��65,0,0,0q�6�   $��75��6�   $��35��6�    J� CommandBindings 5%      )  #System.Windows.Input.CommandBinding  5&      -   5           Command$
 Save��5&   !   5'   .   5)      5*      5+      