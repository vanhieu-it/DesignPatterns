#### Behavioral Strategy Pattern là một mẫu thiết kế thuộc nhóm các mẫu hành vi trong lập trình hướng đối tượng. Nó cho phép bạn định nghĩa một họ các thuật toán, đóng gói từng thuật toán lại, và làm cho chúng có thể hoán đổi cho nhau. Strategy Pattern cho phép thuật toán thay đổi độc lập với các khách hàng sử dụng nó.

#### Strategy Pattern định nghĩa một tập hợp các thuật toán, đóng gói từng thuật toán trong các lớp riêng biệt, và làm cho các thuật toán này có thể hoán đổi cho nhau. Khách hàng có thể sử dụng các thuật toán khác nhau mà không cần phải biết chi tiết thực hiện của chúng.

#### Strategy Pattern bao gồm các thành phần chính sau:
- Context: Lớp này chứa tham chiếu đến một đối tượng Strategy và sử dụng nó để thực hiện các thuật toán.
- Strategy: Là một giao diện hoặc lớp trừu tượng khai báo các phương thức mà các thuật toán cụ thể sẽ thực hiện.
- Concrete Strategies: Là các lớp cụ thể thực thi giao diện Strategy và định nghĩa các thuật toán cụ thể.

#### Ưu điểm
- Dễ dàng mở rộng: Thêm các chiến lược mới mà không làm thay đổi mã nguồn hiện có.
- Tách biệt trách nhiệm: Mỗi chiến lược được quản lý bởi một lớp riêng biệt.
- Tính linh hoạt cao: Cho phép các thuật toán thay đổi một cách linh hoạt trong runtime bằng cách thay đổi đối tượng Strategy.
#### Nhược điểm
- Số lượng lớp tăng lên: Cần tạo nhiều lớp cho mỗi chiến lược khác nhau, có thể làm tăng độ phức tạp của mã nguồn.
- Phải biết chi tiết cụ thể của từng chiến lược: Người dùng phải biết và chọn đúng chiến lược phù hợp.

Strategy Pattern rất hữu ích trong việc quản lý và hoán đổi các thuật toán khác nhau một cách linh hoạt, giúp mã nguồn trở nên dễ hiểu và dễ bảo trì hơn.
