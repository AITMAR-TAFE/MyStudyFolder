   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ Button_AddPerson��5
      $��
Add Person��6+   $
��Left=�6@   $��149,233,0,0q�6[   $	��Top=�6p   $	��120��6�   6�   �� 5   
   $��First Name:��6   $
��Left=�6&   $��	74,71,0,0q�6A   $	��Top=�6T   �� 5   
   $��
Last Name:��6   $
��Left=�6%   $��
74,102,0,0q�6@   $	��Top=�6T   �� 5   
   $��Date Of Birth:��6   $
��Left=�6)   $��
61,133,0,0q�6D   $	��Top=�6X   �� 5   
   $��Height:��6   $
��Left=�6"   $��
95,186,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5         ��Name$ Textbox_FirstName��5      $
��Left=�6-   $��23��6H   $��
149,74,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $��TextBox��6|   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ Textbox_LastName��5      $
��Left=�6,   $��23��6G   $��149,106,0,0q�6S   $
 Wrap=�6h   $��TextBox��6|   $	��Top=�6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Datepicker_DateOfBirth��5      $
��Left=�65   $��149,142,0,0q�6P   $	��Top=�6e   $��35��6}   $	��120��6�   �� 5   
   -   5         ��Name$ Combo_Height��5      $
��Left=�6)   $��149,190,0,0q�6D   $	��Top=�6Y   $	��120��6q   �� 5   
   -   5         ��Name$ Listbox_People��5      $
��Left=�6*   $	��367��6E   $��
579,10,0,0q�6R   $	��Top=�6f   $	��203��6~   �� 5   
   -   5        $ Button_LoadPeople��5      $��Load People��6,   $
��Left=�6B   $��579,382,0,0q�6]   $	��Top=�6r   $	��203��6�   $��27��6�   6�   5      5      