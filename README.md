# sale-furniture-web
1.	Giới thiệu đề tài

Ni’Vi Shop - Website về bán hàng nội thất được thiết kế để mang lại trải nghiệm mua sắm thú vị cho khách hàng với giao diện thân thiện và dễ sử dụng. Trang web được thiết kế với mục đích mang đến cho khách hàng một trải nghiệm mua sắm trực tuyến tuyệt vời, từ việc tìm kiếm sản phẩm dễ dàng đến quá trình thanh toán thuận tiện và an toàn.Web cho khách hàng xem chi tiết sản phẩm, tìm kiếm sản phẩm, thêm, xóa sản phẩm, sửa số lượng sản phẩm trong giỏ hàng và website cung cấp các phương thức để liên hệ với nhân viên Ni’Vi nếu cần giúp đỡ. Với sự đa dạng, chất lượng và tiện lợi, Ni’Vi Shop rất hy vọng sẽ giúp khách hàng tìm được những sản phẩm ưng ý và mang lại không gian sống hoàn hảo cho gia đình.
Website shop bán hàng nội thất online – Ni’Vi Shop của nhóm em được lập trình bằng ngôn ngữ lập trình C#, chạy trên nền .Net Framework và kết nối bằng cơ sở SQL Server. 

3.	Các bước thực hiện đề tài

-	Thiết kế giao diện trang web bán hàng nội thất Ni’Vi Shop
-	Thiết kế cơ sở dữ liệu để lưu trữ thông tin của sản phẩm (Products), nhà cung cấp (Supplier), bình luận (Comment), đơn hàng (Orders), chi tiết đơn hàng (OrderDetail), khách hàng (Users), vai trò (Role), loại sản phẩm (Categories).  
-	Tạo các chức năng cho website bán hàng.
-	Đảm bảo tính bảo mật cho website bằng cách sử dụng các công nghệ mã hóa dữ liệu, xác thực người dùng.
-	Thực hiện thử nghiệm trên website để kiểm tra các lỗi và đảm bảo tính ổn định.

3.	Mô tả chức năng của đề tài

3.1	Chức năng của Admin
-	Theo dõi đơn hàng và cập nhật trạng thái đơn hàng.
-	Thống kê doanh thu trên từng lọai sản phẩm, thống kê số lượng bán ra trên từng loại sản phẩm.
-	Hiển thị, thêm, sửa, xóa sản phẩm.
-	Hiển thị, thêm, sửa, xóa nhà cung cấp.
-	Hiển thị, thêm, sửa, xóa người dùng.
-	Xóa những comment (Các comment được nhận định là tiêu cực).
3.2	Chức năng của Customer
-	Bình luận sản phẩm.
-	Đăng nhập và đăng ký tài khoản.
-	Hiển thị sản phẩm và danh mục sản phẩm.
-	Cho phép khách hàng tìm kiếm sản phẩm theo từ khóa
-	Cho phép khách hàng xem thông tin chi tiết của sản phẩm.
-	Cho phép khách hàng xem những đơn đặt hàng đã thanh toán online
-	Thêm sản phẩm vào giỏ hàng.
-	Thanh toán online với paypal.

4.	Mô tả dữ liệu

4.1	Lược đồ cơ sở dữ liệu
-	Role (RoleID, RoleName)
-	Users (UserID, Username, Password, Name, PhoneNumber, Address, Email, #RoleID)
-	Orders (OrderID, #UserID, OrderDate, isPaid, isReceived)
-	Categories (CategoryID, CategoryName, Description)
-	Supplier (SupplierID, Name, PhoneNumber, Address, CompanyName)
-	Products (ProductID, Name, Image, Price, Quantity, Detail, #SupplierID, #CategoryID)
-	OrderDetail (OrderDetailId, #OrderID, #ProductID, Price, Quantity)
-	Comment (IDComment, [Content], #ProductID, DayComment, #UserID)
4.2	Mối quan hệ giữa các thực thể
-	Mối quan hệ giữa bảng Users và Role: Một Role có nhiều Users và một Users thuộc một Role. Khi Role bị hủy thì vẫn còn Users. Đây là quan hệ Agreegation.
-	Mối quan hệ giữa bảng Users và Orders: Một Users có nhiều Orders và một Orders thuộc một Users. Khi Users bị hủy thì Orders vẫn còn. Đây là quan hệ Agreegation.
-	Mối quan hệ giữa bảng Orders và OrderDetail: Một Orders có nhiều OrderDetail và một OrderDetail thuộc một Orders. Khi Orders bị hủy thì OrderDetail vẫn còn. Đây là quan hệ Agreegation.
-	Mối quan hệ giữa bảng Users và Comment: Một Users có nhiều Comment và một Comment thuộc một Users. Khi Users bị hủy thì Comment cũng bị hủy theo. Đây là quan hệ Composition.
-	Mối quan hệ giữa bảng Products và Comment: Một Products có nhiều Comment và một Comment thuộc một Products. Khi Products bị hủy thì Comment cũng bị hủy theo. Đây là quan hệ Composition.
-	Mối quan hệ giữa bảng Products và OrderDetail: Một Products có nhiều OrderDetail và một OrderDetail thuộc một Products. Khi Products bị hủy thì OrderDetail vẫn còn. Đây là quan hệ Agreegation.
-	Mối quan hệ giữa bảng Products và Supplier: Một Supplier có nhiều Products và một Products thuộc một Supplier. Khi Supplier bị hủy thì Products cũng bị hủy theo. Đây là quan hệ Composition.
-	Mối quan hệ giữa bảng Products và Categories: Một Categories có nhiều Products và một Products thuộc một Categories. Khi Categories bị hủy thì vẫn còn Products. Đây là quan hệ Agreegation.
