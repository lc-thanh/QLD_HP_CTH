   M S B A M L   `   `   `  ���� E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QLD_HP_CTH.WindowSVPagesQLD_HP_CTH.WindowSVPages  3    -QLD_HP_CTH.WindowSVPages.SVChuyenNganhControl   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     8local&clr-namespace:QLD_HP_CTH.WindowSVPages     .��� 
�������  � RowDefinitions  �� $
��auto ��� $
��auto ��� $
��auto ��� .+��� $��0��$��Center=�$��Chuyên ngành��
���"�"�$��20(��� $��1�� �� Orientation$ 
Horizontal=�$
��Left=�.+��� $��Tổng số học phần:��$��Center=��� -   $��	txtTongHP��$��0q�$��Center=� �� 
IsReadOnly$
 True���� $��2��$ 
Horizontal=�$
��Left=�.+��� $��Tổng số tín chỉ:��$��Center=��� -   $��	txtTinChi��$��0q�$��Center=�$
 True��&   System.Windows.Controls.DataGrid  -   $��dtgChuyenNganh��$��3��   AutoGenerateColumns$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã học phần��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
MaMonHoc+  $ Tên học phần��$ *  �� *	TenMonHoc+  $ 	Số tín��$ *  �� *
SoTinChi+