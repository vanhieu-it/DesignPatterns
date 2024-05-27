> Structural.Proxy là một mẫu thiết kế (design pattern) thuộc nhóm Structural Patterns. Mẫu thiết kế Proxy cung cấp một đại diện (proxy) hoặc một placeholder để kiểm soát truy cập tới một đối tượng khác, có thể là vì các lý do sau:
```
Kiểm soát truy cập: Proxy có thể giới hạn quyền truy cập vào đối tượng thật.
Giảm chi phí khởi tạo: Proxy có thể tạo ra đối tượng thật chỉ khi nó thực sự cần thiết.
Điều khiển từ xa: Proxy có thể đại diện cho một đối tượng ở một địa điểm khác, ví dụ như trên một server từ xa.
Logging và Monitoring: Proxy có thể ghi lại các hoạt động trước khi chuyển tiếp chúng đến đối tượng thật.
```
## Khi nào sử dụng Proxy Pattern?
- Khi bạn muốn kiểm soát quyền truy cập hoặc thao tác trên một đối tượng.
- Khi khởi tạo đối tượng là một quá trình nặng nề và bạn muốn trì hoãn nó cho đến khi thực sự cần thiết.
- Khi bạn muốn cung cấp một lớp điều khiển bổ sung cho một đối tượng.

Proxy Pattern là một công cụ mạnh mẽ trong việc quản lý và tối ưu hóa việc sử dụng các đối tượng trong lập trình, đặc biệt là khi làm việc với các tài nguyên nặng hoặc cần kiểm soát quyền truy cập.
