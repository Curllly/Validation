   M S B A M L   `   `   `  ����E  AValidation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Validation
Validation  5   	   G(clr-namespace:Validation.ValidationRulesValidation.ValidationRules  5   	   %    Validation.ValidationRuleWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Validation     5   	   :rules(clr-namespace:Validation.ValidationRules     5   	     � Title$  ValidationRuleWindow��5	   	   $	��450��6&   $	��350��63    � 	Resources 5
       �� 
TargetType   errorTextBox �� Triggers P� Property P� Value �� Property �� Value��%�   &	        �� 5   
   " ��6    5      P� 5       �@=�HasError$
 True��69   . �5      ��  � ��
 �  ��63   5      5      5      .��5      �� -   5         ��Name$ 
stackPanel��5      .+�5   
   �� $4��.Добавление пользователя:��6   �� 5   
   $��Имя:��6   $��0, 10, 0, 0q�6    �� 5   
   -   5        	 ��Name$	 NameTextBox��5      #��[  5      .��68   ��5      �� 5      
 �� Path$

 Name�6    �� UpdateSourceTrigger$ PropertyChanged=�6&    �� NotifyOnValidationError$
 True��6L    �� ValidationRules 5      1   +Validation.ValidationRules.NonEmptyTextRule  5      5      .��5      5      �� 5    
   $��Логин:��6   $��0, 15, 0, 0q�6"   �� 5!   
   -   5        $	 UsernameTextBox��5!      #��[  6+   .��6Q   ��5"      �� 5#      $
 Username�6   $ PropertyChanged=�6*   $
 True��6P    5$        5%      5'      .��5(      5)      �� 5*   
   $��Возраст:��6   $��0, 15, 0, 0q�6$   �� 5+      -   5        $	 
AgeTextBox��5+      #��[  6*   .��6P   ��5,      �� 5-      $	
 Age�6   $ PropertyChanged=�6%   $
 True��6K    5.      2   ,Validation.ValidationRules.AgeValidationRule  5/      51      .��52      53      �� 54   
   -   5         ��Name$ AddUserButton��54   9   $��Добавить��6   $��0, 15, 0, 0q�6$   55      56      57      