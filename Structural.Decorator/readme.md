>Mẫu thiết kế Decorator là một mẫu thiết kế cấu trúc cho phép bạn thêm hành vi mới vào các đối tượng hiện có một cách linh hoạt bằng cách bọc các đối tượng đó trong các lớp trang trí (decorator). Điều này giúp bạn mở rộng chức năng của các đối tượng mà không cần thay đổi mã nguồn của chúng hoặc tạo ra các lớp con mới.

Các thành phần chính của Decorator Pattern:
- Component: Giao diện hoặc lớp cơ bản định nghĩa các phương thức chung cho cả các đối tượng gốc và các decorator.
- Concrete Component: Một lớp cụ thể triển khai Component. Đây là đối tượng mà chúng ta muốn thêm hành vi mới.
- Decorator: Lớp cơ sở hoặc giao diện cho tất cả các decorator, chứa tham chiếu tới một Component.
- Concrete Decorators: Các lớp cụ thể triển khai Decorator để thêm hành vi mới vào Concrete Component.
