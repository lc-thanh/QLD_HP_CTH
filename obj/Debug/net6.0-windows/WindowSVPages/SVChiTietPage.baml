   M S B A M L   `   `   `  ����E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QLD_HP_CTH.WindowSVPagesQLD_HP_CTH.WindowSVPages  5      ,    &QLD_HP_CTH.WindowSVPages.SVChiTietPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:QLD_HP_CTH.WindowSVPages     5        N� Title$  SVChiTietPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6   $��2��6-   $,��&Chi tiết chương trình đào tạo��6A   $��Center=�6i   $��20(�6�   
���"�"�6�   �� 5   
   $��1��6   $��0��6"    �� Orientation$ Vertical=�62   $	��Top=�6I   .+�5      �� $��Chi tiết ngành��6   $��Center=�6-   $��15(�6J   
���"�"�$	��400��6q   $��Center=�6}   
�������6�   �� 5      $ 
Horizontal=�6   $
��Left=�62   .+�5      �� $��	Tên khoa��6   $
��Left=�6+   �� 5      -   5         ��Name$ 
txtTenKhoa��5       �� 
IsReadOnly$
 True��6.   $��0q�6@   $��Center=�6T   5      �� 5      $ 
Horizontal=�6   $
��Left=�62   .+�5      �� $��Hệ đào tạo��6   $
��Left=�6-   �� 5      -   5        $ txtHeDaoTao��5      $
 True��6/   $��0q�6A   $��Center=�6U   5       �� 5!      $ 
Horizontal=�6   $
��Left=�62   .+�5"      �� $��Tên ngành��6   $
��Left=�6,   �� 5#      -   5        $ txtTenNganh��5#      $
 True��6/   $��0q�6A   $��Center=�6U   5$      �� 5%      $ 
Horizontal=�6   $
��Left=�62   .+�5&      �� $��
Mã ngành��6   $
��Left=�6+   �� 5'      -   5        $ 
txtMaNganh��5'      $
 True��6.   $��0q�6@   $��Center=�6T   5(      �� 5)      $ 
Horizontal=�6   $
��Left=�62   .+�5*      �� $��Thời gian đào tạo��6   $
��Left=�64   �� 5+      -   5        $ txtThoiGian��5+      $
 True��6/   $��0q�6A   $��Center=�6U   5,      �� 5-      $ 
Horizontal=�6   $
��Left=�62   .+�5.      �� $!��Khối lượng toàn khóa��6   $
��Left=�67   �� 5/      -   5        $ txtKhoiLuong��5/      $
 True��60   $��0q�6B   $��Center=�6V   50      �� 51      $ 
Horizontal=�6   $
��Left=�62   .+�52      �� $��Loại hình đào tạo��6   $
��Left=�64   �� 53      -   5        $ txtLoaiHinh��53      $
 True��6/   $��0q�6A   $��Center=�6U   54      55      �� 57   
   $��1��6   $��1��6"   $ Vertical=�62   $	��Top=�6I   .+�58      �� $��Mục tiêu đào tạo��6   $��Center=�6/   
���"�"�$	��400��6e   $��Center=�6q   
�������6�   �� 59      $�� PEO1:��6   $
��Left=�6%   
����� �6@   �� 5:      -   5         ��Name$ tbPEO1��5:      $
��Left=�6(   $
��Wrap=�6C   $	��350��6W   �� 5<      $�� PEO2:��6   $
��Left=�6%   
����� �6@   �� 5=      -	   5        $ tbPEO2��5=      $
��Left=�6(   $
��Wrap=�6C   $	��350��6W   �� 5?      $�� PEO3:��6   $
��Left=�6%   
����� �6@   �� 5@      -
   5        $ tbPEO3��5@      $
��Left=�6(   $
��Wrap=�6C   $	��350��6W   �� 5B      $�� PEO4:��6   $
��Left=�6%   
����� �6@   �� 5C      -   5        $ tbPEO4��5C      $
��Left=�6(   $
��Wrap=�6C   $	��350��6W   �� 5E      $�� PEO5:��6   $
��Left=�6%   
����� �6@   �� 5F      -   5        $ tbPEO5��5F      $
��Left=�6(   $
��Wrap=�6C   $	��350��6W   5G      5I      5J      