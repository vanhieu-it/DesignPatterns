#### State Pattern (Mẫu trạng thái) định nghĩa một lớp để biểu diễn các trạng thái khác nhau của một đối tượng, và cho phép đối tượng đó chuyển đổi giữa các trạng thái này một cách linh hoạt. Mẫu này giúp cho việc quản lý trạng thái và hành vi của đối tượng trở nên dễ dàng và rõ ràng hơn.

#### State Pattern bao gồm các thành phần chính sau:
- Context: Là lớp chứa một tham chiếu đến trạng thái hiện tại của đối tượng và cung cấp các phương thức để chuyển đổi giữa các trạng thái.
- State: Là một giao diện hoặc lớp cơ sở khai báo các hành vi mà các trạng thái cụ thể sẽ thực hiện.
- Concrete States: Là các lớp cụ thể thực thi giao diện State và định nghĩa hành vi cho từng trạng thái cụ thể.

#### Ưu điểm
- Giảm sự phức tạp trong mã nguồn: Dễ dàng thêm hoặc thay đổi các trạng thái khác nhau mà không ảnh hưởng đến các trạng thái khác.
- Tách biệt trách nhiệm: Mỗi trạng thái được quản lý bởi một lớp riêng biệt.
- Dễ dàng mở rộng: Thêm trạng thái mới mà không làm thay đổi mã nguồn hiện có.
#### Nhược điểm
- Số lượng lớp tăng lên: Cần tạo nhiều lớp cho mỗi trạng thái khác nhau.
- Có thể phức tạp đối với các hệ thống đơn giản: Với các hệ thống không phức tạp, việc sử dụng State Pattern có thể làm phức tạp không cần thiết.

State Pattern rất hữu ích trong việc quản lý các trạng thái khác nhau của một đối tượng, giúp cho mã nguồn trở nên dễ hiểu và dễ bảo trì hơn.
