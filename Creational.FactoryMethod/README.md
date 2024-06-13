### Factory Method định nghĩa một phương thức trong một lớp cơ sở (abstract class hoặc interface), cho phép các lớp con quyết định loại đối tượng nào sẽ được tạo. Nói cách khác, thay vì trực tiếp tạo các đối tượng bằng cách sử dụng từ khóa new, Factory Method di chuyển logic tạo đối tượng vào trong một phương thức riêng biệt, do các lớp con thực thi.

### Cấu trúc 
- Creator (Abstract Class or Interface): Khai báo phương thức factory, có thể có một phương thức mặc định hoặc abstract để tạo đối tượng. Các lớp con sẽ kế thừa lớp này và triển khai cụ thể phương thức factory.
- Concrete Creator (Concrete Subclasses): Thực thi phương thức factory để tạo ra các đối tượng cụ thể.
- Product (Abstract Class or Interface): Định nghĩa giao diện của đối tượng được tạo ra bởi phương thức factory.
- Concrete Product (Concrete Implementations): Triển khai cụ thể của Product.
