> Structural Composite pattern là một trong những design pattern thuộc nhóm structural pattern trong lập trình hướng đối tượng. Mục đích của Composite pattern là để tạo ra một cấu trúc cây mà trong đó các đối tượng có thể được tổ chức thành các cấu trúc phân cấp. Điều này cho phép bạn xử lý các đối tượng riêng lẻ và các nhóm đối tượng theo cùng một cách.

### Đặc điểm của Composite Pattern:
- Cấu trúc cây: Composite pattern tổ chức các đối tượng theo cấu trúc cây, giúp dễ dàng biểu diễn mối quan hệ phân cấp giữa các đối tượng.
- Đồng nhất trong xử lý: Cho phép xử lý các đối tượng riêng lẻ và các nhóm đối tượng một cách đồng nhất, không cần phải phân biệt chúng.
- Tái sử dụng và mở rộng: Dễ dàng tái sử dụng và mở rộng các thành phần của cây mà không ảnh hưởng đến các phần khác.

### Thành phần chính của Composite Pattern:
- Component: Một interface hoặc abstract class định nghĩa các phương thức chung cho các đối tượng trong cấu trúc cây.
- Leaf: Đại diện cho các đối tượng đơn lẻ (các nút lá) trong cây. Leaf implements các phương thức được định nghĩa trong Component.
- Composite: Một class đại diện cho các node (nút) chứa các node khác. Composite chứa danh sách các Component và implements các phương thức từ Component để xử lý các nhóm đối tượng.
