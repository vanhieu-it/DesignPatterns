### Abstract Factory là một mẫu thiết kế trong lập trình hướng đối tượng thuộc nhóm Creational (Tạo dựng). Nó cho phép tạo ra các họ sản phẩm liên quan hoặc phụ thuộc lẫn nhau mà không cần chỉ định các lớp cụ thể của chúng. Abstract Factory cung cấp một giao diện để tạo ra các họ đối tượng mà không chỉ ra các lớp cụ thể của từng đối tượng.

### Mục tiêu
Mẫu thiết kế này giúp tránh sự phụ thuộc vào các lớp cụ thể (concrete classes) và cung cấp một giao diện chung để tạo các đối tượng liên quan. Điều này rất hữu ích khi hệ thống cần làm việc với các họ sản phẩm khác nhau, có thể thay đổi mà không ảnh hưởng đến mã nguồn hiện tại.

### Cấu trúc
1. AbstractFactory: Giao diện (interface) hoặc lớp trừu tượng khai báo các phương thức tạo các sản phẩm trừu tượng.
2. ConcreteFactory: Các lớp cụ thể triển khai AbstractFactory để tạo ra các sản phẩm cụ thể.
3. AbstractProduct: Giao diện hoặc lớp trừu tượng khai báo các loại sản phẩm được tạo ra bởi Abstract Factory.
4. ConcreteProduct: Các lớp cụ thể triển khai AbstractProduct.
