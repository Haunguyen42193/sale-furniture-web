# sale-furniture-web
1.	Giới thiệu đề tài

Ni’Vi Shop - Website về bán hàng nội thất được thiết kế để mang lại trải nghiệm mua sắm thú vị cho khách hàng với giao diện thân thiện và dễ sử dụng. Trang web được thiết kế với mục đích mang đến cho khách hàng một trải nghiệm mua sắm trực tuyến tuyệt vời, từ việc tìm kiếm sản phẩm dễ dàng đến quá trình thanh toán thuận tiện và an toàn.Web cho khách hàng xem chi tiết sản phẩm, tìm kiếm sản phẩm, thêm, xóa sản phẩm, sửa số lượng sản phẩm trong giỏ hàng và website cung cấp các phương thức để liên hệ với nhân viên Ni’Vi nếu cần giúp đỡ. Với sự đa dạng, chất lượng và tiện lợi, Ni’Vi Shop rất hy vọng sẽ giúp khách hàng tìm được những sản phẩm ưng ý và mang lại không gian sống hoàn hảo cho gia đình.
Website shop bán hàng nội thất online – Ni’Vi Shop của nhóm em được lập trình bằng ngôn ngữ lập trình C#, chạy trên nền .Net Framework và kết nối bằng cơ sở SQL Server. 

2.	Các bước thực hiện đề tài

-	Thiết kế giao diện trang web bán hàng nội thất Ni’Vi Shop
-	Thiết kế cơ sở dữ liệu để lưu trữ thông tin của sản phẩm (Products), nhà cung cấp (Supplier), bình luận (Comment), đơn hàng (Orders), chi tiết đơn hàng (OrderDetail), khách hàng (Users), vai trò (Role), loại sản phẩm (Categories).  
-	Tạo các chức năng cho website bán hàng.
-	Đảm bảo tính bảo mật cho website bằng cách sử dụng các công nghệ mã hóa dữ liệu, xác thực người dùng.
-	Thực hiện thử nghiệm trên website để kiểm tra các lỗi và đảm bảo tính ổn định.

3. Thiết kế hệ thống

3.1 Sơ đồ lớp

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/3f771696-36c4-41a5-b5e7-5d1208924c50)

3.2 Lược đồ cơ sở dữ liệu
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

4.	Chức năng

4.1 Mô tả chức năng

4.1.1	Chức năng của Admin
-	Theo dõi đơn hàng và cập nhật trạng thái đơn hàng.
-	Thống kê doanh thu trên từng lọai sản phẩm, thống kê số lượng bán ra trên từng loại sản phẩm.
-	Hiển thị, thêm, sửa, xóa sản phẩm.
-	Hiển thị, thêm, sửa, xóa nhà cung cấp.
-	Hiển thị, thêm, sửa, xóa người dùng.
-	Xóa những comment (Các comment được nhận định là tiêu cực).
4.1.2	Chức năng của Customer
-	Bình luận sản phẩm.
-	Đăng nhập và đăng ký tài khoản.
-	Hiển thị sản phẩm và danh mục sản phẩm.
-	Cho phép khách hàng tìm kiếm sản phẩm theo từ khóa
-	Cho phép khách hàng xem thông tin chi tiết của sản phẩm.
-	Cho phép khách hàng xem những đơn đặt hàng đã thanh toán online
-	Thêm sản phẩm vào giỏ hàng.
-	Thanh toán online với paypal.


5. Giao diện

- Trang chủ admin

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/0ca770ca-c873-4181-badd-6495dce4052b)

-	Theo dõi đơn hàng và cập nhật trạng thái đơn hàng.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/b6a57a86-9a0d-4373-8a81-98e79013c0ad)

-	Thống kê doanh thu trên từng lọai sản phẩm, thống kê số lượng bán ra trên từng loại sản phẩm.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/60211566-5348-44eb-81c2-a037be816347)

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/5b0247dd-7e07-413e-9869-985651e4764a)

-	Hiển thị, thêm, sửa, xóa sản phẩm.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/18ca5f2e-a3a6-45e4-87e9-f3bb9a9e0577)

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/957d8e65-3fbf-41fe-810c-893160c5150b)

-	Hiển thị, thêm, sửa, xóa nhà cung cấp.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/5869b7f1-4d8c-4cd6-aa08-4501e4b7df92)

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/7ad84643-4f9a-466d-978b-d7ceb14c70b2)

-	Hiển thị, thêm, sửa, xóa người dùng.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/2468f084-7f3b-4599-87cd-3c9fd35b1964)

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/204aa89d-8ee0-41a0-86a0-171d5483314d)

-	Xóa những comment (Các comment được nhận định là tiêu cực).

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/e95e5fb7-fffc-4ad7-891b-68a6dcf831a9)

3.2	Chức năng của Customer

-	Bình luận sản phẩm.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/2a0ba952-0918-456d-90f4-5ce6a6c49435)

-	Đăng nhập và đăng ký tài khoản.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/cfdf977b-39d9-45e1-8c0d-c9f2cef43510)

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/4b740c2a-83af-40e4-b23d-985c348017fe)

-	Hiển thị sản phẩm và danh mục sản phẩm.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/f896b8c7-f400-43bf-8042-43bb45694fd9)

-	Cho phép khách hàng xem thông tin chi tiết của sản phẩm.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/2e4d1e66-52d0-4b8a-9d44-229ff3f183ea)

-	Cho phép khách hàng xem những đơn đặt hàng đã thanh toán online

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/b282a32f-fab9-47ad-8ffd-7a37ef5e23ab)

-	Giao diện giỏ hàng.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/3b14cf73-39a3-4aed-ae1a-f5f2c8a68d1e)


-	Thanh toán online với paypal.

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/5aa18605-9393-4e6a-9fd1-11ec43c43f65)

![image](https://github.com/Haunguyen42193/sale-furniture-web/assets/92702518/3eddc737-8716-46e2-b20a-f8e5e0da8001)


