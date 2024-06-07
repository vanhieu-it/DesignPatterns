### Adapter Pattern là một trong các structural design pattern, được sử dụng để cho phép hai giao diện không tương thích làm việc cùng nhau. Pattern này hoạt động như một cầu nối giữa hai giao diện khác nhau bằng cách "bọc" một lớp cũ trong một lớp mới với một giao diện mà ứng dụng cần.

### Đặc điểm của Adapter Pattern:
- Chuyển đổi giao diện: Chuyển đổi giao diện của một lớp hiện có thành một giao diện khác mà một client mong muốn.
- Tính tương thích: Làm cho các lớp với giao diện không tương thích có thể hoạt động cùng nhau.
- Độc lập với giao diện hiện có: Adapter cho phép sử dụng lại các lớp hiện có mà không cần thay đổi chúng, bằng cách cung cấp một lớp mới với giao diện mong muốn.

### Thành phần chính của Adapter Pattern:
1. Target: Giao diện mong muốn mà client muốn sử dụng.
2. Adapter: Lớp chuyển đổi, triển khai giao diện Target và chứa một đối tượng của lớp hiện có.
3. Adaptee: Lớp hiện có có giao diện không tương thích với Target.
4. Client: Sử dụng giao diện Target để tương tác với lớp hiện có thông qua Adapter.
