   M S B A M L   `   `   `  ���� E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QLD_HP_CTH.WindowGVPagesQLD_HP_CTH.WindowGVPages  -    'QLD_HP_CTH.WindowGVPages.GVBangDiemPage   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     8local&clr-namespace:QLD_HP_CTH.WindowGVPages       N� Title$  GVBangDiemPage�� N� FontSize$ 20(�.��� 
������� � ColumnDefinitions �� �� ��  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��30 ��� .+��� $��0��$��0��$��Danh sách lớp��$��20(�$��	100,0,0,0q�$��Center=��� -   $��cbDsLop��$��0��$��1��$	��200���� -   $��0��$��2��$��Lấy danh sách��$
��Left=�$	��150���� $��1��$��0��$��3�� �� Orientation$ 
Horizontal=�$��Center=�.+��� $��Select Mode���� -   $��Thông thường��
�������$��5q��� -   $��Nhập điểm��
�������$��5q��� $��2��$��0��$��Mã sinh viên��$��Center=�$��	100,0,0,0q��� -   $��txtMaSV��$��2��$��1��$
��Left=�$	��200��$��30��$��	0,10,0,10q��� -   $��2��$��2��$��Tìm kiếm��$��5q�$
��Left=�$	��100��$��30���� $��3��$��0��$ ��Điểm thường xuyên 1��$��Center=�$��	100,0,0,0q��� -   $��txtTX1��$��3��$��1��$
��Left=�$	��200��$��30��$��	0,10,0,10q��� $��4��$��0��$ ��Điểm thường xuyên 2��$��Center=�$��	100,0,0,0q��� -   $��txtTX2��$��4��$��1��$
��Left=�$	��200��$��30��$��	0,10,0,10q��� $��5��$��0��$��Điểm thi��$��Center=�$��	100,0,0,0q��� -	   $��
txtDiemThi��$��5��$��1��$
��Left=�$	��200��$��30��$��	0,10,0,10q��� -
    ��Name$ btnLuu��$��6��$��2��$
��Lưu��$��5q�$
��Left=�$	��100���� -   $��	txtTenMon��$��7��$��0��$��3�� �� 
IsReadOnly$
 True��
���� ��$��20(�$��Center=�$��0q�&   System.Windows.Controls.DataGrid  -   $��dtgDanhSach��$��8��$��0��$��3��   AutoGenerateColumns$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã sinh viên��
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *MaSv+  $	 	Họ tên��$	
 200  �� *HoTen+  $	 Điểm TX1��$	
 200  �� *	DiemTx1+  $	 Điểm TX2��$	
 200  �� *	DiemTx2+  $	 Điểm Thi��$	
 200  �� *	DiemThi+