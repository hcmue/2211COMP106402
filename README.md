# 2211COMP106402
Công nghệ NET lớp thứ 4

# Buổi 07 (19/10/2022)
## Areas: Phân vùng (dễ quản lý)
	* Right click project chọn ```New Scaffolded Item```, chọn MVC  Area, đặt tên area ==> có sẵn Controllers, Models, Views
	* Tạo mới 1 controller, nhớ thêm property:
	```cs
	[Area("<area_name>")]
	```
	* Thêm phần route ở Program.cs (trước route default)
	```cs
	app.MapControllerRoute(
		name: "areas",
		pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
	```
	* Nhớ tạo ```_ViewStart.cshtml``` và ```_ViewImports.cshtml``` trong thư mục Views của Area

## ViewComponent
	* Tạo thư mục tên gì cũng được, nên ```ViewComponents```
	* Tạo class ```XYZViewComponent``` kế thừa từ ViewComponent
	* Implement cho method Invoke()
	* Tạo View hiển thị kết quả (thường là ```Default.cshtm```). Cấu trúc thư mục của View: ```~/Views/Shared/Components/<viewcomponent_name>/Default.cshtml```
	* Chèn: @await Component.InvokeAsync("Category")

# Buổi 06 (12/10/2022)
## jQuery validation:
* Thuộc tính remote: tự động gửi lên server để check

## Layout:
* Cách xây dựng layout
	* Tạo template Razor Layout
	* Phải có duy nhất RenderBody()
	* Có thể có nhiều RenderSection()
* PartialView
	* Phần nhỏ của View
