# THỰC TẬP CHUYÊN MÔN NĂM HỌC 2019-2020
	Họ tên:Nguyễn Thanh Bình
		Mã sinh viên: 5851071003
	Họ tên:Nguyễn Đức huy
		Mã sinh viên: 5851071031
Lớp: Công nghệ thông tin - K58
## Đề tài: Quản lý cửa hàng bán laptop
## Phần 1: Công nghệ sử dụng
- Winform C#
- Sql server 2018
- Bunifu framework
- Guna framework
- Dev express
## Phần 2: Các chức năng đã hoàn thành
1. Trình bày được các sản phẩm hiện đang có trong cửa hàng. (chia theo danh mục)
2. Thêm sửa xóa sản phẩm.
3. Tạo hóa đơn cho khách hàng khi mua hàng.
4. Gửi mail cho khách hàng.
5 .Thống kê doanh thu của cửa hàng.
6. Lập biểu đồ để biểu diễn doanh số.
7. Phân quyền công việc cho từng nhân viên.
8. Phân quyền tài khoản (admin, quản lý, nhân viên)
9. Lưu trữ thông tin khách hàng qua số điện thoại (hoặc email). Tìm kiếm lịch sử mua hàng khách hàng thông qua thông tin khách hàng.
10. Hoàn trả lại sản phẩm (khi bị các vấn đề về sản phẩm …). Chức năng giảm giá theo thời điểm.
11. Quản lý kho hàng.(thêm sản phẩm vào kho, nhập hàng, xem hóa đơn và chi tiết hóa đơn)
12. Đóng gói phần mềm.
13. Mã hóa mật khẩu bằng md5
14. In hóa đơn, gửi hóa đơn về cho chủ cửa hàng
11. Quản lý kho hàng.
12. Đóng gói phần mềm
13. Mã hóa mật khẩu bằng md5
14. Bắt nhập đúng định dạng mail 
...
## Phần 3: Các chức năng chưa hoàn thành

...
## Hướng dẫn sử dụng
- Tài khoản sẽ được cấp mặc định cho chủ cửa hàng là: admin, pass: 123
- Trong phần Category: sẽ có 5 thông tin cần quản lý
	+) Mỗi thông tin sẽ có chức năng thêm xóa sửa
	+) Trước tiên cần bấm vào chức năng cần thực thi (Thêm xóa sửa)
	+) Sau đó bấm nút save để lưu thông tin trong lần thực thi đó
	+) Lần thực thi sẽ kết thúc khi bấm nút cancel
- Trong phần Product Management: sẽ có chức năng là quản lý kho (gồm nhóm sản phẩm, hãng sản phẩm và sản phẩm)
	+) Trước hết phải thêm nhóm sản phẩm và hãng sp để phân loại sản phẩm theo danh mục.
	+) Muốn kinh doanh sản phẩm gì phải bấm nút add để thêm thông tin của sản phẩm đó.
	+) Nếu muốn thay đổi thông tin vừa nhập của sản phẩm có thể bấm nút choose trong cột update của sp
	+) Bấm nút create bill import để tạo hóa đơn nhập hàng, sẽ hiện ra 1 form để chọn danh sách nhà cung cấp mà bạn đã add từ phần Category.
	+) Sau đó sẽ qua lại form sản phẩm. Để chọn sản phẩm cần nhập, bấm vào nút choose trong cột Import. Nó sẽ hiện lên số lượng và đơn giá mà bạn phải chọn.
	+) Sau khi chọn xong, để xem những sản phẩm gì bạn đã nhập có thể bấm vào see bill để xem chi tiết của hóa đơn đang tạo. Có thể xóa bớt sản phẩm bằng cách bấm vào nút choose trong cột delete.
	+)Khi đã kiểm tra xong hóa đơn và muốn thanh toán có thể bấm nút pay để thanh toán hoặc tắt bằng dấu X ở góc phải và chọn cancel trong phần sản phẩm để hủy hóa đơn.
	+) Có thể xem danh sách hóa đơn nhập ở Mục Bill->Buy. Ở mục này cũng có nút select trong cột detail để xem chi tiết hóa đơn, tương tự như nút see bill ở trong mục sản phẩm
	+) Nếu người đăng nhập là chủ cửa hàng, tức tài khoản chủ có thể hủy đơn hàng (trong trường hợp nhân viên nhập nhầm,...). Nếu không phải tài khoản chủ thì không thể thay đổi tình trạng hóa đơn.
Xin cám ơn!
	