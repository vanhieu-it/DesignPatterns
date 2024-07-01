 ## Chain of Responsibility

### Behavioral Chain of Responsibility là một trong những mẫu thiết kế (design pattern) thuộc nhóm Behavioral (hành vi) trong lập trình hướng đối tượng. Mẫu thiết kế này giúp xử lý các yêu cầu theo một chuỗi các đối tượng, nơi mỗi đối tượng có thể xử lý yêu cầu hoặc chuyển nó đến đối tượng tiếp theo trong chuỗi.

#### Mục đích
+ Phân tách các yêu cầu: Thay vì gửi yêu cầu trực tiếp đến một đối tượng xử lý duy nhất, bạn có thể gửi nó qua một chuỗi các đối tượng có thể xử lý yêu cầu. Điều này tạo ra một cơ chế linh hoạt để thay đổi hoặc thêm các đối tượng xử lý mà không cần phải thay đổi mã nguồn nơi yêu cầu được khởi tạo.
+ Giảm sự phụ thuộc: Giúp giảm sự phụ thuộc lẫn nhau giữa các đối tượng bằng cách sử dụng liên kết động giữa các đối tượng xử lý.

#### Cách thức hoạt động
+ Khởi tạo các đối tượng trong chuỗi: Các đối tượng xử lý được liên kết với nhau thành một chuỗi.
+ Gửi yêu cầu: Khi một yêu cầu được gửi đi, nó sẽ đi qua từng đối tượng trong chuỗi.
+ Xử lý hoặc chuyển tiếp: Mỗi đối tượng trong chuỗi sẽ kiểm tra xem nó có thể xử lý yêu cầu hay không. Nếu có, nó sẽ xử lý yêu cầu; nếu không, nó sẽ chuyển yêu cầu đến đối tượng kế tiếp trong chuỗi.

#### Ưu điểm
+ Giảm sự phụ thuộc giữa người gửi và người nhận yêu cầu.
+ Dễ mở rộng: Dễ dàng thêm hoặc bớt các xử lý mà không ảnh hưởng đến các thành phần khác trong chuỗi.
+ Tăng tính linh hoạt trong việc xử lý yêu cầu.
#### Nhược điểm
+ Có thể không rõ ràng: Chuỗi xử lý có thể phức tạp và khó theo dõi khi số lượng các đối tượng trong chuỗi tăng lên.
+ Hiệu suất: Có thể bị ảnh hưởng nếu chuỗi quá dài hoặc nếu có nhiều đối tượng không xử lý yêu cầu.
