### Prototype Pattern là một mẫu thiết kế (design pattern) thuộc nhóm Creational trong lập trình hướng đối tượng. Prototype Pattern cho phép tạo ra các đối tượng mới bằng cách sao chép một đối tượng hiện có, được gọi là prototype. Mẫu thiết kế này đặc biệt hữu ích khi việc tạo đối tượng mới trực tiếp bằng hàm tạo (constructor) là phức tạp hoặc tốn kém.

### Đặc điểm chính của Prototype Pattern:
- Sao chép đối tượng: Thay vì tạo đối tượng mới từ đầu, Prototype Pattern tạo đối tượng bằng cách sao chép một đối tượng hiện có.
- Độc lập với loại đối tượng: Bạn có thể tạo các đối tượng mới mà không cần phải biết chính xác lớp cụ thể của chúng.
- Dễ dàng thay đổi và mở rộng: Bạn có thể dễ dàng thay đổi trạng thái hoặc thuộc tính của đối tượng sao chép mà không ảnh hưởng đến đối tượng gốc.

### Khi nào sử dụng Prototype Pattern:
- Khi đối tượng cần được tạo ra có cấu hình phức tạp hoặc tốn kém.
- Khi cần thực hiện việc tạo đối tượng mà không cần biết lớp cụ thể của chúng.
- Khi bạn muốn tránh các chi phí liên quan đến việc tạo mới đối tượng hoặc cấu hình lại chúng từ đầu.
