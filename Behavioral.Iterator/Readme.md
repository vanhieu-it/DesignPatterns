### Behavioral Iterator là một mẫu thiết kế (design pattern) trong lập trình hướng đối tượng, thuộc nhóm mẫu hành vi (behavioral patterns). Mẫu thiết kế này cung cấp một cách thức để truy cập tuần tự các phần tử của một tập hợp đối tượng (collection) mà không cần phải tiết lộ biểu diễn bên trong của nó.

#### Mục Đích
+ Tách rời cách duyệt: Cung cấp một cách thức để duyệt các phần tử của một tập hợp mà không làm lộ ra cấu trúc bên trong của tập hợp đó.
+ Tái sử dụng: Cho phép tạo nhiều kiểu duyệt khác nhau cho cùng một tập hợp dữ liệu.

#### Cấu Trúc
Mẫu thiết kế Iterator thường có ba thành phần chính:

+ Iterator Interface: Định nghĩa các phương thức để duyệt qua các phần tử, chẳng hạn như next(), hasNext(), currentItem(), v.v.
+ Concrete Iterator: Hiện thực cụ thể của giao diện Iterator, chứa logic để duyệt qua một tập hợp cụ thể.
+ Aggregate Interface: Định nghĩa phương thức để tạo ra các iterator, thường là createIterator().
+ Concrete Aggregate: Hiện thực cụ thể của giao diện Aggregate, trả về một iterator cho tập hợp của nó.

#### Lợi Ích
+ Đơn giản hóa mã: Tách biệt logic duyệt ra khỏi cấu trúc dữ liệu.
+ Tính linh hoạt: Dễ dàng thay đổi cách duyệt mà không ảnh hưởng đến cấu trúc dữ liệu.
+ Tái sử dụng mã: Có thể tái sử dụng các iterator cho nhiều loại tập hợp khác nhau.
#### Nhược Điểm
+ Phức tạp hơn: Có thể làm cho mã phức tạp hơn với nhiều lớp bổ sung.
+ Không hiệu quả: Đối với một số tập hợp, việc sử dụng iterator có thể không hiệu quả bằng việc sử dụng trực tiếp.
+ Iterator là một trong những mẫu thiết kế cơ bản và hữu ích nhất trong việc quản lý các cấu trúc dữ liệu phức tạp và cách thức duyệt qua chúng mà không cần biết chi tiết bên trong.
