### Flyweight là một mẫu thiết kế (design pattern) thuộc nhóm Structural Patterns trong lập trình hướng đối tượng. Flyweight Pattern được sử dụng để giảm thiểu việc tạo ra các đối tượng tương tự nhau bằng cách chia sẻ chúng, giúp tiết kiệm bộ nhớ và tăng hiệu suất của ứng dụng.

### Cách hoạt động của Flyweight Pattern
- Chia sẻ trạng thái nội tại (intrinsic state): Flyweight chia sẻ các phần dữ liệu chung giữa các đối tượng khác nhau. Trạng thái nội tại là những thuộc tính không thay đổi của đối tượng, có thể được dùng chung.
- Trạng thái ngoại tại (extrinsic state): Đây là những thông tin cụ thể mà đối tượng cần để hoạt động, nhưng không được lưu trữ trong đối tượng Flyweight. Trạng thái ngoại tại thường được truyền vào các phương thức khi cần.

### Ưu điểm của Flyweight Pattern
- Tiết kiệm bộ nhớ: Flyweight giúp giảm đáng kể số lượng đối tượng được tạo ra, do đó tiết kiệm bộ nhớ.
- Hiệu suất tốt hơn: Bởi vì sử dụng ít bộ nhớ hơn, các ứng dụng có thể hoạt động nhanh hơn, đặc biệt là khi làm việc với nhiều đối tượng có cấu trúc tương tự.
- Quản lý đối tượng tốt hơn: Bằng cách chia sẻ các đối tượng chung, bạn có thể giảm số lượng đối tượng cần phải quản lý.

### Nhược điểm của Flyweight Pattern
- Tăng độ phức tạp: Việc triển khai Flyweight có thể làm tăng độ phức tạp của hệ thống, đặc biệt là trong việc phân tách trạng thái nội tại và ngoại tại.
- Khó duy trì: Khi số lượng đối tượng được chia sẻ tăng lên, việc duy trì và cập nhật các đối tượng này có thể trở nên khó khăn.
- Không phù hợp cho mọi tình huống: Flyweight không hiệu quả nếu các đối tượng có trạng thái nội tại không nhiều hoặc nếu không có nhiều đối tượng tương tự cần được quản lý.

### Khi nào nên sử dụng Flyweight Pattern
- Khi hệ thống cần tạo ra một số lượng lớn các đối tượng tương tự nhau, có thể chia sẻ một phần trạng thái của chúng.
- Khi việc tiết kiệm bộ nhớ là quan trọng đối với hiệu suất của ứng dụng.

Flyweight pattern là một cách tối ưu hóa tài nguyên mạnh mẽ, nhưng cần được sử dụng đúng cách để đạt được hiệu quả mong muốn mà không làm tăng độ phức tạp quá mức.
