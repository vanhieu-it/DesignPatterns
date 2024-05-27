## MEMENTO 

> Mẫu thiết kế Memento là một mẫu thiết kế hành vi cho phép lưu trữ và khôi phục trạng thái trước đó của một đối tượng mà không vi phạm nguyên tắc đóng gói. Mẫu này rất hữu ích trong các ứng dụng yêu cầu khả năng "hoàn tác" các thay đổi.

Mẫu thiết kế Memento giúp lưu trữ và khôi phục trạng thái của một đối tượng mà không vi phạm nguyên tắc đóng gói. Các bước triển khai mẫu thiết kế Memento bao gồm:
```
Tạo lớp Memento để lưu trữ trạng thái.
Tạo lớp Originator để tạo và khôi phục memento.
Tạo lớp Caretaker để quản lý các memento và cung cấp chức năng lưu trữ và khôi phục trạng thái của Originator.
Sử dụng các lớp này để lưu trữ và khôi phục trạng thái của đối tượng.
Mẫu thiết kế này đặc biệt hữu ích trong các ứng dụng yêu cầu tính năng hoàn tác hoặc khôi phục trạng thái trước đó.
```
