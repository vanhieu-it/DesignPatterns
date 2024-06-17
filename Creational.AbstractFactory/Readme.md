### Abstract Factory là một mẫu thiết kế trong lập trình hướng đối tượng thuộc nhóm Creational (Tạo dựng). Nó cho phép tạo ra các họ sản phẩm liên quan hoặc phụ thuộc lẫn nhau mà không cần chỉ định các lớp cụ thể của chúng. Abstract Factory cung cấp một giao diện để tạo ra các họ đối tượng mà không chỉ ra các lớp cụ thể của từng đối tượng.

### Mục tiêu
Mẫu thiết kế này giúp tránh sự phụ thuộc vào các lớp cụ thể (concrete classes) và cung cấp một giao diện chung để tạo các đối tượng liên quan. Điều này rất hữu ích khi hệ thống cần làm việc với các họ sản phẩm khác nhau, có thể thay đổi mà không ảnh hưởng đến mã nguồn hiện tại.

### Cấu trúc
1. AbstractFactory: Giao diện (interface) hoặc lớp trừu tượng khai báo các phương thức tạo các sản phẩm trừu tượng.
2. ConcreteFactory: Các lớp cụ thể triển khai AbstractFactory để tạo ra các sản phẩm cụ thể.
3. AbstractProduct: Giao diện hoặc lớp trừu tượng khai báo các loại sản phẩm được tạo ra bởi Abstract Factory.
4. ConcreteProduct: Các lớp cụ thể triển khai AbstractProduct.

### Khi nào sử dụng
+ Khi hệ thống cần tạo ra các họ sản phẩm liên quan mà không cần xác định trước các lớp cụ thể.
+ Khi cần đảm bảo rằng các sản phẩm được tạo ra bởi một nhà máy cụ thể là tương thích với nhau.
+ Khi muốn xây dựng một thư viện các thành phần có thể dễ dàng mở rộng và hoán đổi.

### Ưu điểm
+ Giảm sự phụ thuộc vào các lớp cụ thể, dễ dàng mở rộng và bảo trì hệ thống.
+ Giúp đảm bảo tính nhất quán giữa các sản phẩm cùng loại.

### Nhược điểm
+ Có thể dẫn đến việc tạo ra quá nhiều lớp nếu có nhiều sản phẩm và biến thể của chúng.
+ Việc thêm một loại sản phẩm mới có thể yêu cầu sửa đổi toàn bộ hệ thống.

Abstract Factory là một mẫu thiết kế mạnh mẽ khi cần tạo ra các đối tượng trong một họ sản phẩm liên quan và giúp giữ cho mã nguồn linh hoạt và dễ bảo trì.
