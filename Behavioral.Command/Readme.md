#### Behavioral Command là một mẫu thiết kế thuộc nhóm Behavioral trong lĩnh vực lập trình và thiết kế phần mềm. Mẫu thiết kế này cho phép bạn đóng gói một yêu cầu (request) dưới dạng một đối tượng, nhờ đó bạn có thể tham số hóa các đối tượng khác nhau với các yêu cầu, hàng đợi các yêu cầu hoặc ghi log các yêu cầu, và hỗ trợ các thao tác như undo.
#### Các thành phần chính của mẫu thiết kế Command:
+ Command Interface: Định nghĩa một phương thức để thực thi lệnh.
+ Concrete Command: Hiện thực hóa Command Interface và định nghĩa mối quan hệ giữa người nhận (Receiver) và hành động. Thực hiện các phương thức của Command Interface để gọi các phương thức tương ứng của người nhận.
+ Client: Tạo Concrete Command và thiết lập người nhận của nó.
+ Invoker: Chịu trách nhiệm thực thi các lệnh cụ thể.
+ Receiver: Đối tượng thực tế thực hiện hành động khi lệnh được gọi.
