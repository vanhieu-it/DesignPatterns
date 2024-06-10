> Creational.Singleton Pattern là một mẫu thiết kế (design pattern) thuộc nhóm Creational trong lập trình hướng đối tượng, đảm bảo rằng một lớp chỉ có một thể hiện (instance) duy nhất và cung cấp một cách để truy cập thể hiện đó từ bất kỳ đâu trong ứng dụng. Đây là mẫu thiết kế rất phổ biến và hữu ích khi chỉ cần một thể hiện của một lớp để quản lý trạng thái toàn cục hoặc thực hiện các nhiệm vụ như quản lý kết nối cơ sở dữ liệu, cấu hình, log...

 ### Đặc điểm chính của Singleton Pattern:
 - Chỉ có một thể hiện: Đảm bảo rằng một lớp chỉ có một thể hiện duy nhất. Ví dụ, trong trường hợp một lớp DatabaseConnection, bạn muốn chỉ có một kết nối duy nhất được sử dụng xuyên suốt ứng dụng.
 - Truy cập toàn cục: Cung cấp một điểm truy cập toàn cục cho thể hiện đó. Điều này có nghĩa là thể hiện Singleton có thể được truy cập từ bất kỳ đâu trong mã nguồn của bạn.
