### Behavioral.TemplateMethod là một mẫu thiết kế (design pattern) thuộc nhóm các mẫu hành vi (behavioral patterns). Mẫu này định nghĩa một bộ khung (framework) cơ bản cho một thuật toán và cho phép các lớp con (subclass) định nghĩa các bước cụ thể của thuật toán mà không thay đổi cấu trúc của nó.
#### Cụ thể, mẫu Behavioral.TemplateMethod định nghĩa một thuật toán gồm các bước cơ bản, nhưng cho phép các lớp con triển khai các bước cụ thể. Lớp cha (parent class) chứa phương thức mẫu (template method) định nghĩa cấu trúc chung của thuật toán, trong khi các lớp con cung cấp triển khai cụ thể cho các bước.

#### Ưu điểm chính của mẫu này là:
~~~
1. Tái sử dụng code: Lớp cha chứa phương thức mẫu có thể được sử dụng lại ở nhiều nơi khác nhau.
2. Giảm sự trùng lặp: Các lớp con chỉ cần triển khai các bước cụ thể thay vì phải viết lại toàn bộ thuật toán.
3. Tăng tính mở rộng: Dễ dàng thêm các bước mới vào thuật toán mà không ảnh hưởng đến các lớp con đã triển khai.
~~~

#### Mẫu Behavioral.TemplateMethod thường được sử dụng trong các trường hợp cần định nghĩa một thuật toán chung với các bước cụ thể có thể thay đổi giữa các lớp con.
