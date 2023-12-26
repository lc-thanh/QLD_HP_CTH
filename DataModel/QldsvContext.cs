using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLD_HP_CTH.DataModel;

public partial class QldsvContext : DbContext
{
    public QldsvContext()
    {
    }

    public QldsvContext(DbContextOptions<QldsvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminTaiKhoan> AdminTaiKhoans { get; set; }

    public virtual DbSet<BangDiem> BangDiems { get; set; }

    public virtual DbSet<GiangVien> GiangViens { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<MonHoc> MonHocs { get; set; }

    public virtual DbSet<Nganh> Nganhs { get; set; }

    public virtual DbSet<NganhMonHoc> NganhMonHocs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-F19LIAJ;Initial Catalog=QLDSV;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminTaiKhoan>(entity =>
        {
            entity.HasKey(e => e.TaiKhoan).HasName("PK__adminTai__B4C453191CE19330");

            entity.ToTable("adminTaiKhoan");

            entity.Property(e => e.TaiKhoan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("taiKhoan");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("matKhau");
        });

        modelBuilder.Entity<BangDiem>(entity =>
        {
            entity.HasKey(e => e.MaBangDiem).HasName("PK__BangDiem__4643C1D5BCE8236E");

            entity.ToTable("BangDiem");

            entity.Property(e => e.MaBangDiem).HasColumnName("maBangDiem");
            entity.Property(e => e.DiemTx1).HasColumnName("DiemTX1");
            entity.Property(e => e.DiemTx2).HasColumnName("DiemTX2");
            entity.Property(e => e.MaSv).HasColumnName("MaSV");

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.BangDiems)
                .HasForeignKey(d => d.MaLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BangDiem__MaLop__4AB81AF0");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.BangDiems)
                .HasForeignKey(d => d.MaSv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BangDiem__MaSV__49C3F6B7");
        });

        modelBuilder.Entity<GiangVien>(entity =>
        {
            entity.HasKey(e => e.MaGv).HasName("PK__GiangVie__2725AEF3F67D7455");

            entity.ToTable("GiangVien");

            entity.Property(e => e.MaGv)
                .ValueGeneratedNever()
                .HasColumnName("MaGV");
            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.GioiTinh).HasMaxLength(3);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.SoDt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SoDT");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaKhoa).HasName("PK__Khoa__653904056419C4F2");

            entity.ToTable("Khoa");

            entity.Property(e => e.MaKhoa).ValueGeneratedNever();
            entity.Property(e => e.TenKhoa).HasMaxLength(250);
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.MaLop).HasName("PK__Lop__3B98D273A001C3C2");

            entity.ToTable("Lop");

            entity.Property(e => e.MaLop).ValueGeneratedNever();
            entity.Property(e => e.MaGv).HasColumnName("MaGV");
            entity.Property(e => e.ViTriLop)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MaMonHocNavigation).WithMany(p => p.Lops)
                .HasForeignKey(d => d.MaMonHoc)
                .HasConstraintName("FK__Lop__MaMonHoc__46E78A0C");
        });

        modelBuilder.Entity<MonHoc>(entity =>
        {
            entity.HasKey(e => e.MaMonHoc).HasName("PK__MonHoc__4127737F58B8C750");

            entity.ToTable("MonHoc");

            entity.Property(e => e.MaMonHoc).ValueGeneratedNever();
            entity.Property(e => e.HeSoTx1).HasColumnName("HeSoTX1");
            entity.Property(e => e.HeSoTx2).HasColumnName("HeSoTX2");
            entity.Property(e => e.Loai)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SoTienMotTc).HasColumnName("SoTienMotTC");
            entity.Property(e => e.TenMonHoc).HasMaxLength(150);
        });

        modelBuilder.Entity<Nganh>(entity =>
        {
            entity.HasKey(e => e.MaNganh).HasName("PK__Nganh__A2CEF50DF478DA6E");

            entity.ToTable("Nganh");

            entity.Property(e => e.MaNganh).ValueGeneratedNever();
            entity.Property(e => e.HeDaoTao).HasMaxLength(250);
            entity.Property(e => e.LoaiHinhDaoTao).HasMaxLength(250);
            entity.Property(e => e.Peo1).HasColumnName("PEO1");
            entity.Property(e => e.Peo2).HasColumnName("PEO2");
            entity.Property(e => e.Peo3).HasColumnName("PEO3");
            entity.Property(e => e.Peo4).HasColumnName("PEO4");
            entity.Property(e => e.Peo5).HasColumnName("PEO5");
            entity.Property(e => e.TenNganh).HasMaxLength(250);

            entity.HasOne(d => d.MaKhoaNavigation).WithMany(p => p.Nganhs)
                .HasForeignKey(d => d.MaKhoa)
                .HasConstraintName("FK__Nganh__MaKhoa__398D8EEE");
        });

        modelBuilder.Entity<NganhMonHoc>(entity =>
        {
            entity.HasKey(e => e.MaNganhMonHoc).HasName("PK__NganhMon__A4BB236B96A9F752");

            entity.ToTable("NganhMonHoc");

            entity.Property(e => e.MaNganhMonHoc).HasColumnName("maNganhMonHoc");

            entity.HasOne(d => d.MaMonHocNavigation).WithMany(p => p.NganhMonHocs)
                .HasForeignKey(d => d.MaMonHoc)
                .HasConstraintName("FK__NganhMonH__MaMon__4222D4EF");

            entity.HasOne(d => d.MaNganhNavigation).WithMany(p => p.NganhMonHocs)
                .HasForeignKey(d => d.MaNganh)
                .HasConstraintName("FK__NganhMonH__MaNga__412EB0B6");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("PK__SinhVien__2725081A0D405353");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSv)
                .ValueGeneratedNever()
                .HasColumnName("MaSV");
            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.GioiTinh).HasMaxLength(3);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.SoDt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SoDT");

            entity.HasOne(d => d.MaNganhNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaNganh)
                .HasConstraintName("FK__SinhVien__MaNgan__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
