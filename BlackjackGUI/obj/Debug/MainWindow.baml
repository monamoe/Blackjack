   M S B A M L   `   `   `  ����G  CBlackjackGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BlackjackGUIBlackjackGUI  5   	       BlackjackGUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BlackjackGUI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��
0,0,-16,-5q�6    J� OpacityMask �	#FF138B13 J� RenderTransformOrigin$ 0.5,0.5&�67   z�5
   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.172Q�6"   T� 5      5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF0D8B2A��6   $ 1Q�61   � 5      $ 	#FE000701��6   � 5      $ 	#FEB61010��6   5       � ColumnDefinitions 5   
   �� 5      $��9* �6   �� 5      $	��79* �6   .+�5   
   �� -   5        $	��Hit��5      $
��Left=�6   $��111,182,0,0q�6:   $	��Top=�6O   $	��100��6g   $ 
0.66,4.095&�6s   $��1��6�   $��53��6�   
�������$��20(�6�   �� 5   
   -   5        $��Stand��5      $
��Left=�6!   $��287,182,0,0q�6<   $	��Top=�6Q   $��93��6i   $ 0.227,3.424&�6�   $��1��6�   $��53��6�   
�������$��20(�6�   � 5    
   -   5        $��PlayerPanel��5       $��Center=�6'   $	��130��6D   $��18,240,30,0q�6Q   $	��Top=�6f   $	��663��6~   $ 0.5,0.5&�6�   $��1��6�   � 5!   
   -   5        $��DealerPanel��5!      $��Center=�6'   $	��130��6D   $��
18,37,30,0q�6Q   $	��Top=�6e   $	��663��6}   $��1��6�   �� 5"   
   -   5        $��winnerLabel��5"      $��Winner: ��6#   $
��Left=�66   $��432,182,0,0q�6Q   $	��Top=�6f   $��58��6~   $	��248��6�   $��1��6�   $��20(�6�   5$      5%      