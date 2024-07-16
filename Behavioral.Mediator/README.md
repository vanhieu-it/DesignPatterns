#### Behavioral Mediator Pattern là một mẫu thiết kế hành vi thuộc nhóm các mẫu thiết kế hướng đối tượng, được dùng để định hình cách thức giao tiếp giữa các đối tượng trong một hệ thống mà không yêu cầu các đối tượng này biết đến sự tồn tại của nhau. Mediator pattern giúp giảm sự phụ thuộc lẫn nhau giữa các đối tượng và quản lý sự phức tạp của giao tiếp một cách tập trung.

#### Mục Đích
+ Tách biệt sự giao tiếp giữa các đối tượng để tránh sự phụ thuộc lẫn nhau (loose coupling).
+ Giảm thiểu sự phức tạp trong việc quản lý giao tiếp giữa các thành phần của hệ thống.
+ Tập trung hóa logic giao tiếp để dễ dàng điều chỉnh và bảo trì hệ thống.

#### Cấu Trúc
+ Mediator Interface: Định nghĩa giao diện để giao tiếp với các Colleague (đối tượng).
+ Concrete Mediator: Triển khai giao diện Mediator, thực hiện giao tiếp giữa các Colleague cụ thể.
+ Colleague Class: Các lớp này chỉ giao tiếp với Mediator, không giao tiếp trực tiếp với nhau.

#### Cách Hoạt Động
+ Colleagues: Các đối tượng giao tiếp thông qua Mediator thay vì liên hệ trực tiếp với nhau.
+ Mediator: Nhận các thông điệp từ các đối tượng, xử lý chúng, và điều phối giao tiếp đến các đối tượng liên quan khác.
+ Điều Phối: Mediator sẽ điều phối các hành động dựa trên logic được xác định trước, giúp giảm thiểu sự phức tạp và tạo ra sự tách biệt rõ ràng giữa các phần của hệ thống.

#### Ưu và Nhược Điểm
##### Ưu Điểm
+ Giảm sự phụ thuộc trực tiếp: Các đối tượng chỉ biết mediator, không biết các đối tượng khác.
+ Tập trung hóa logic giao tiếp: Dễ dàng thay đổi logic mà không ảnh hưởng đến các đối tượng khác.
+ Cải thiện khả năng mở rộng: Dễ dàng thêm hoặc bớt các đối tượng mà không cần thay đổi nhiều mã.

##### Nhược Điểm
+ Mediator có thể trở nên phức tạp: Nếu không được thiết kế cẩn thận, mediator có thể trở thành một đối tượng trung tâm phức tạp với nhiều logic khó bảo trì.
+ Tăng độ phức tạp: Khi sử dụng không cần thiết, có thể làm phức tạp hóa thiết kế thay vì đơn giản hóa nó.
