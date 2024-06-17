### Builder là một mẫu thiết kế thuộc nhóm Creational Patterns (Mẫu Thiết kế Khởi tạo) trong lập trình hướng đối tượng. Mẫu này giúp xây dựng các đối tượng phức tạp từng bước và cho phép kiểm soát quá trình tạo đối tượng mà không cần phải tạo các lớp con hoặc sử dụng nhiều hàm tạo. Dưới đây là các điểm chính về mẫu thiết kế Builder:
#### 1. Vấn đề Cần Giải Quyết
Trong một số tình huống, việc tạo ra các đối tượng có thể rất phức tạp, đặc biệt khi đối tượng có nhiều thuộc tính hoặc yêu cầu các quy trình thiết lập đặc biệt. Ví dụ:

- Đối tượng có nhiều biến thể (phiên bản khác nhau).
- Đối tượng có nhiều thuộc tính bắt buộc và tuỳ chọn.
- Cần phải thực hiện các bước tạo đối tượng theo một trình tự nhất định.
2. Giải Pháp
  
  Mẫu Builder tách rời quá trình xây dựng một đối tượng phức tạp khỏi biểu diễn của nó. Nhờ đó, cùng một quá trình xây dựng có thể tạo ra các biểu diễn khác nhau của đối tượng.

  3. Các Thành Phần
- Builder Interface (Giao diện Builder): Định nghĩa các phương thức để tạo ra các phần của đối tượng.
- Concrete Builder (Builder Cụ Thể): Triển khai giao diện Builder và cung cấp các bước cụ thể để xây dựng các phần của đối tượng.
- Product (Sản phẩm): Đối tượng phức tạp được xây dựng.
- Director (Giám đốc): Điều khiển quá trình xây dựng bằng cách sử dụng một đối tượng Builder. Director không biết chi tiết của việc xây dựng các phần cụ thể.
4. Lợi Ích
- Kiểm soát quá trình xây dựng: Cho phép tạo ra các đối tượng phức tạp từng bước một.
- Tạo các đối tượng khác nhau: Tạo ra các biến thể khác nhau của đối tượng thông qua các Builder cụ thể khác nhau.
- Mã dễ đọc hơn: Tách quá trình khởi tạo phức tạp ra khỏi mã chính.

5. Sơ Đồ UML
``` yaml
+---------------------+
|     Director        |
+---------------------+
| -builder: Builder   |
+---------------------+
| +construct()        |
+---------------------+
          |
          v
+---------------------+
|      Builder        |
+---------------------+
| +buildPartA()       |
| +buildPartB()       |
| +getResult()        |
+---------------------+
          |
          v
+---------------------+
|  ConcreteBuilder    |
+---------------------+
| -product: Product   |
+---------------------+
| +buildPartA()       |
| +buildPartB()       |
| +getResult()        |
+---------------------+
          |
          v
+---------------------+
|      Product        |
+---------------------+
|                     |
+---------------------+
```
