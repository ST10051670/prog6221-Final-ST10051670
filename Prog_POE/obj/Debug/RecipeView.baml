   M S B A M L   `   `   `  ����C  ?Prog_POE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Final_POE	Final_POE  5   	       Final_POE.RecipeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Final_POE     5   	     � Title$  frmViewRecipe��5   	   $	��716��6   $	��800��6,   .��5	      � -   5         �Name$ 
ViewRecipe��5	      $��0,0,0,-3q�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF22EDED��6    � Offset$ 0.043Q�61   5      .+�5   
   �� -   5         ��Name$ 	txtSearch��5      $O��IUse the search bar below and the appropriate button to filter accordingly��6#   $��Center=�6w   $��0,47,0,0q�6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ 	txtFilter��5      $
��Left=�6%   $��	36,50,0,0q�6@    �� TextWrapping$
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��144��6�   $��26��6�   $��14(�6�   �� 5   
   -   5        	 ��Name$	 btnFilterIng��5      $��Filter By Ingredient��6'   $
��Left=�6F   $��	39,85,0,0q�6a   $	��Top=�6t   $��27��6�   $	��112��6�   6�   �� 5   
   -   5        $	 btnFilterFoodGroup��5      $��Filter By Food Group��6-   $
��Left=�6L   $��
37,124,0,0q�6g   $	��Top=�6{   $��27��6�   $	��124��6�   6�   �� 5   
   -   5        $	 btnFilterCalories��5      $��Filter By Calories��6,   $
��Left=�6I   $��
38,161,0,0q�6d   $	��Top=�6x   $��27��6�   $	��112��6�   6�   �� 5   
   -   5        
 ��Name$
 	lbRecipes��5      $��270,89,314,506q�6P   6h   �� 5   
   -   5        $
 lbOutput��5      $��54,247,71,329q�6O   6f   �� 5   
   -	   5        $ lbSelectedRecipe��5      $��Selected Recipe Details:��6*   $
��Left=�6M   $��
52,219,0,0q�6h   $	��Top=�6|   $	��350��6�   �� 5   
   -
   5        $
 stepListBox��5      $��108,452,128,126q�6'   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��5,0,0,0q�6#   �� 5      ��6$   �� 5      5      5!      �� 5"   
   -   5        $ lblSteps��5"      $��Steps��6"   $
��Left=�62   $��114,429,0,0q�6M   $	��Top=�6b   $��39��6z   �� 5#   
   -   5        $ lbScale��5#      $��scale recipe by:��6!   $
��Left=�6<   $��
497,69,0,0q�6W   $	��Top=�6k   $	��183��6�   �� 5$   
   -   5        $	 btnscale��5$      $	��0.5��6#   $
��Left=�61   $��510,100,0,0q�6L   $	��Top=�6a   $��27��6y   $��53��6�   6�   �� 5%   
   -   5        $	 	btnscale2��5%      $��2��6$   $
��Left=�60   $��510,132,0,0q�6K   $	��Top=�6`   $��27��6x   $��53��6�   6�   �� 5&   
   -   5        $	 	btnscale3��5&      $��3��6$   $
��Left=�60   $��510,164,0,0q�6K   $	��Top=�6`   $��27��6x   $��53��6�   6�   �� 5'   
   -   5        $	 btnResetScale��5'      $��Reset Scale��6(   $
��Left=�6>   $��510,196,0,0q�6Y   $	��Top=�6n   $��27��6�   $��90��6�   6�   �� 5)   
   -   5        $ 
lbCalories��5)      $��Total Calories��6$   $
��Left=�6=   $��243,383,0,0q�6X   $	��Top=�6m   $	��350��6�   5*      5+      