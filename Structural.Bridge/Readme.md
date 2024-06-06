## Bridge pattern là một trong những design pattern thuộc nhóm structural pattern trong lập trình hướng đối tượng. Mục đích của Bridge pattern là tách biệt phần trừu tượng của một đối tượng với phần triển khai của nó, để cả hai có thể thay đổi một cách độc lập.

### Đặc điểm của Bridge Pattern:
- Tách biệt trừu tượng và triển khai: Cho phép tách biệt phần trừu tượng (abstraction) của đối tượng khỏi phần triển khai cụ thể (implementation), giúp dễ dàng thay đổi hoặc mở rộng cả hai mà không ảnh hưởng đến phần còn lại.
- Giảm sự phụ thuộc giữa abstraction và implementation: Tạo ra một cầu nối giữa abstraction và implementation, giảm sự phụ thuộc chặt chẽ giữa chúng.
- Tăng tính linh hoạt và mở rộng: Dễ dàng mở rộng cả phần trừu tượng và phần triển khai mà không cần thay đổi mã nguồn hiện có.

### Thành phần chính của Bridge Pattern:
- Abstraction: Một interface hoặc abstract class định nghĩa các hành vi trừu tượng.
- Refined Abstraction: Một class mở rộng từ Abstraction, thường thêm các hành vi hoặc thuộc tính cụ thể.
- Implementor: Một interface định nghĩa các hành vi cụ thể.
- Concrete Implementor: Các class thực hiện các hành vi cụ thể được định nghĩa trong Implementor.
