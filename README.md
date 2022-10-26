# 2211COMP106402
Công nghệ NET lớp thứ 4

# Buổi 08 - 26/10/2022 - EF Core

## Cài thư viện EFCore
* Tools > NuGet Package Manager > Package Manager Console
* Powershell
```
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
```

## Các bước xây dựng database + bộ map
* B1: Tạo các entity model
* B2: Tạo lớp ```MyDbContext``` (kế thừa DbContext) để quản database tại chương trình (Virtual object database)
	* Hàm tạo theo mẫu:
	```cs
        public MyDbContext(DbContextOptions options): base(options)
        {
        }
	```
	* Khai báo cái DbSet dùng để tạo các table tương ứng. Ví dụ:
	```cs
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
	```