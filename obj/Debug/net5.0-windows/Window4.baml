   M S B A M L   `   `   `  ����@  <MyVP1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyVP1MyVP1  5   	       MyVP1.Window4   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:MyVP1     5   	     � Title$  Вариант 4��5   
   $	��480��6   $	��300��6)   .��5	      �� .+�5
   
   �� $��ФИО��6   $��5 5 0 0q�6   �� 5   
   -   5         ��Name$ NameBox��5      $��5 5 5 0q�6#   �� 5   
   $��Пол��6   $��5 20 0 0q�6   	� 5   
   -   5         	�Name$
 SexF��5      $��5 5 0 0q�6$    	� 	GroupName$ Region��65   ��5      �� 5      $��Женщина��6   5      	� 5   
   -   5        $
 SexM��5      $��5 5 0 0q�6$   $ Region��65   ��5      �� 5      $��Мужчина��6   5      �� 5   
   $��Дата рождения��6   $��5 20 0 0q�6)   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DateBox��5      $��5 5 5 0q�6&   �� 5   
   -   5         ��Name$ CheckMarried��5      $��Женат/замужем��6)   $��5 20 0 0q�6A   �� 5   
   -   5         ��Name$ 
HeightText��5      $��Рост: 1 см��6(   $��5 20 0 0q�6:   �� 5   
   -   5         ��Name$ HeightSlider��5       �� IsSnapToTickEnabled$
 True��6'   	 �� TickFrequency$	 1Q�6B   
 � Minimum$
 1Q�6T    � Maximum$	 250Q�6`   $��5 10 0 0q�6n   6�   �� 5   
   -   5        $ 
WeightText��5      $��Вес: 1 кг��6(   $��5 20 0 0q�69   �� 5   
   -	   5        $ WeightSlider��5      $
 True��6'   $	 1Q�6B   $
 1Q�6T   $	 250Q�6`   $��5 10 0 0q�6n   6�   �� 5   
   -
   5         ��Name$ Сonfirm��5      $��Подтвердить��6#   $��0 50 0 0q�69   $��24��6K   $	��100��6W   6c   5      5       