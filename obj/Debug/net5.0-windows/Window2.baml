   M S B A M L   `   `   `  ����@  <MyVP1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyVP1MyVP1  5   	       MyVP1.Window2   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:MyVP1     5   	     � Title$  Вариант 2��5   	   $	��480��6   $	��300��6(   .��5	      �� .+�5
   
   �� $'��!Название предмета��6   $��5 5 0 0q�6-   �� 5   
   -   5         ��Name$ NameBox��5      $��5 5 5 0q�6#   64   �� 5   
   $��Аббревиатура��6   $��5 5 0 0q�6(   �� 5   
   -   5        $ AbbrBox��5      $��5 5 5 0q�6#   �� 5   
   $ ��Специальность��6   $��5 20 0 0q�6)   �� 5   
   -   5         ��Name$ SpecBox��5      $��5 5 5 0q�6$   �� 5   
   $!��Форма обучения��6   $��5 20 0 0q�6*   	� 5   
   -   5         	�Name$ DayRadio��5      $��5 5 0 0q�6(    	� 	GroupName$
 Form��69   ��5      �� 5      $��Дневная��6   5      	� 5   
   -   5        $ 	EvenRadio��5      $��5 5 0 0q�6)   $
 Form��6:   ��5      �� 5      $��Вечерняя��6   5      	� 5   
   -   5        $ ZaoRadio��5      $��5 5 0 0q�6(   $
 Form��69   ��5      �� 5      $��Заочная��6   5      �� 5    
   -   5         ��Name$ 
SliderText��5       $.��(Количество кредитов: 1��6(   $��5 20 0 0q�6F   �� 5!   
   -   5         ��Name$ CreditSlider��5!       �� IsSnapToTickEnabled$
 True��6'    �� TickFrequency$	 0.5Q�6B   	 � Minimum$	 1Q�6V   
 � Maximum$
 15Q�6b   $��5 10 0 0q�6o   6�   �� 5"   
   -	   5         ��Name$ 	CheckExam��5"      $��Экзамен��6&   $��5 20 0 0q�68   �� 5#   
   -
   5        $ CheckCP��5#      $#��Курсовая работа��6$   $��5 10 0 0q�6>   �� 5$   
   -   5         ��Name$ Сonfirm��5$      $��Подтвердить��6"   $��0 50 0 0q�68   $��24��6J   $	��100��6V   6b   5%      5&      