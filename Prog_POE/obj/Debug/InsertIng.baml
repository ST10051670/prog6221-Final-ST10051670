   M S B A M L   `   `   `  ����C  ?Prog_POE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Final_POE	Final_POE  5   	       Final_POE.InsertIng   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Final_POE     5   	     � Title$  frmInsertIngredients��5   	   $	��450��6&   $	��839��63   .��5	      � -   5         �Name$ frmInsertIng��5	      $	��429��6!   $	��Top=�6.   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF06D6B0��6    � Offset$ 0.082Q�61   5      .+�5   
   �� -   5         ��Name$ lblIngredientMessage��5      $��Insert Ingredients��6.   $��Center=�6K   $��0,34,0,0q�6h   $	��Top=�6z   $��15(�6�   $��Rockwell)�6�   $	��728��6�   $��52��6�   �� 5   
   -   5        $ lblIngredientName��5      $ ��Enter The Ingredient Name:��6+   $
��Left=�6P   $��	36,91,0,0q�6k   $	��Top=�6~   $��36��6�   $	��179��6�   $��14(�6�   �� 5   
   -   5         ��Name$ 
txtIngName��5      $
��Left=�6&   $��
220,96,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��145��6�   $��26��6�   $��14(�6�   �� 5   
   -   5        $ lblIngredientQuantity��5      $��Enter The Quantity:��6/   $
��Left=�6M   $��
80,147,0,0q�6h   $	��Top=�6|   $��36��6�   $	��135��6�   $��14(�6�   �� 5   
   -   5        $ txtIngQuantity��5      $
��Left=�6*   $��220,152,0,0q�6E   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��145��6�   $��26��6�   $��14(�6�   �� 5   
   -   5        $ lblIngredientMeasurement��5      $%��Select The Unit of Measurement:��62   $
��Left=�6\   $��481,147,0,0q�6w   $	��Top=�6�   $��36��6�   $	��216��6�   $��14(�6�   �� 5   
   -   5        	 ��Name$	 cmbUnitOfMeasurement��5      $
��Left=�61   $��702,152,0,0q�6L   $	��Top=�6a   $	��145��6y   $��26��6�   $��14(�6�   .@�5      �� $��grams��6   �� 5      $��milliliters��6   �� 5      $
��cups��6   �� 5      $��	teaspoons��6   �� 5      $��
tablespoon��6   5      �� 5   
   -	   5        $ lblIngredientCalories��5      $;��5Enter The Number of Calories (per single ingredient):��6/   $
��Left=�6o   $��
10,210,0,0q�6�   $	��Top=�6�   $��36��6�   $	��336��6�   $��14(�6�   �� 5    
   -
   5        $ txtCalories��5       $
��Left=�6'   $��400,210,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��145��6�   $��26��6�   $��14(�6�   6�   �� 5!   
   -   5        $ lblFoodGroup��5!      $;��5Select The Food Group That The Ingredient Belongs To:��6&   $
��Left=�6f   $��
10,264,0,0q�6�   $	��Top=�6�   $��36��6�   $	��355��6�   $��14(�6�   �� 5"   
   -   5        $	 cmbFoodGroup��5"      $
��Left=�6)   $��400,264,0,0q�6D   $	��Top=�6Y   $	��145��6q   $��32��6}   .@�5#      �� $��Grains��6   �� 5$      $��Fruits��6   �� 5%      $��
Vegatables��6   �� 5&      $��Protein��6   �� 5'      $��Dairy��6   5*      �� 5,   
   -   5        
 ��Name$
 btnAddNewIng��5,      $��Add Ingredient��6'   $
��Left=�6@   $��270,332,0,0q�6[   $	��Top=�6p   $��39��6�   $	��150��6�   6�   �� 5-   
   -   5        $
 
btnProceed��5-      $��Proceed��6%   $
��Left=�67   $��472,332,0,0q�6R   $	��Top=�6g   $��39��6   $	��112��6�   6�   �� 5.   
   -   5        $
 btnClear��5.      $��Clear��6#   $
��Left=�63   $��132,332,0,0q�6N   $	��Top=�6c   $��39��6{   $	��112��6�   6�   50      51      