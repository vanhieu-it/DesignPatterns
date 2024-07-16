## MEMENTO 
### Mẫu thiết kế Memento thuộc nhóm Behavioral Design Patterns và được sử dụng để lưu trữ trạng thái bên trong của một đối tượng để có thể khôi phục lại trạng thái đó sau này mà không vi phạm nguyên tắc đóng gói (encapsulation). Điều này rất hữu ích trong các tình huống cần chức năng "undo" hoặc khi bạn muốn lưu trữ trạng thái của một đối tượng để sử dụng sau này.

#### Các thành phần chính của Memento Pattern:
- Originator: Đối tượng mà trạng thái của nó cần được lưu trữ và khôi phục.
- Memento: Đối tượng lưu trữ trạng thái trước đó của Originator.
- Caretaker: Đối tượng quản lý Memento, nhưng không can thiệp vào nội dung của nó.
#### Ưu điểm
- Không vi phạm nguyên tắc đóng gói: Memento lưu trữ trạng thái của Originator mà không tiết lộ thông tin nội bộ của nó ra ngoài.
- Dễ dàng khôi phục trạng thái: Bạn có thể dễ dàng lưu và khôi phục trạng thái của đối tượng, điều này rất hữu ích trong các ứng dụng yêu cầu chức năng undo.
- Tách biệt trách nhiệm: Caretaker chỉ quản lý Memento, không can thiệp vào trạng thái của Originator, giúp tách biệt rõ ràng trách nhiệm giữa các lớp.
#### Nhược điểm
- Tốn bộ nhớ: Lưu trữ nhiều trạng thái của đối tượng có thể tốn nhiều bộ nhớ, đặc biệt khi đối tượng có nhiều dữ liệu.
- Quản lý phức tạp: Nếu có nhiều trạng thái cần lưu trữ, việc quản lý các Memento có thể trở nên phức tạp.
- Không phù hợp với mọi đối tượng: Memento phù hợp nhất với các đối tượng có trạng thái đơn giản. Với các đối tượng có trạng thái phức tạp, việc tạo và lưu trữ Memento có thể trở nên khó khăn.
