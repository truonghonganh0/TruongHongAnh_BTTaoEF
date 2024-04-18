using CodeFirst.Models;
using DefaultNamespace;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        
    }
    
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<SinhVien> SinhViens { get; set; }
    public DbSet<Lop> Lops { get; set; }
    public DbSet<Khoa> Khoas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Khoa>().HasData(
            new Khoa { MaKhoa = 1, TenKhoa = "CNS" },
            new Khoa { MaKhoa = 2, TenKhoa = "SPKT" },
            new Khoa { MaKhoa = 3, TenKhoa = "CK" }
        );

        modelBuilder.Entity<Lop>().HasData(
            new Lop { MaLop = 1, TenLop = "21T3" },
            new Lop { MaLop = 2, TenLop = "21T2" },
            new Lop { MaLop = 3, TenLop = "22T3" },
            new Lop { MaLop = 4, TenLop = "22T2" }
        );

        modelBuilder.Entity<SinhVien>().HasData(
            new SinhVien { MaSinhVien = 1, HoTen = "Tran Van A", Age = 19, KhoaMaKhoa = 1, LopMaLop = 1},
            new SinhVien { MaSinhVien = 2, HoTen = "Nguyen Van B", Age = 20, KhoaMaKhoa = 1, LopMaLop = 2 },
            new SinhVien { MaSinhVien = 3, HoTen = "Le Van C", Age = 21, KhoaMaKhoa = 1, LopMaLop = 1 },
            new SinhVien { MaSinhVien = 4, HoTen = "Ho Thi D", Age = 22, KhoaMaKhoa = 2, LopMaLop = 2 },
            new SinhVien { MaSinhVien = 5, HoTen = "Duong Van E", Age = 23, KhoaMaKhoa = 2, LopMaLop = 2 }
        );
    }
}