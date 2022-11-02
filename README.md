# 2211COMP106402
Công nghệ NET lớp thứ 4


# Buổi 09 (02/11/2022): EF Core - Database first
## Step 0: Chuẩn bị
* Dựng lại database
* Tạo project và cài đặt 3 thư viện (packages):
```cs
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

## Step 1: Generate entity model
PM > ```Scaffold-DbContext "Server=.; Database=MyeStoreK4602;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data```
* trong đó ```Data``` là thư mục chứa các Entity model
* có thể thêm ```-f``` cho lần generate entity model tiếp theo nếu database thay đổi

## Step 2: Đăng ký DbContext
* Thiết lập chuỗi kết nối
	```json
	"ConnectionStrings": {
		"MyStore": "Server=.; Database=MyeStoreK4602;Integrated Security=True"
	},
	```
* Đăng ký
```cs
builder.Services.AddDbContext<MyeStoreK46Context>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyStore")));

```