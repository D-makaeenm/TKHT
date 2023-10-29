//using System.Data.SqlClient;

//private bool VerifyOldPassword(string oldPassword, string username)
//{
//    // Kết nối đến cơ sở dữ liệu
//    string connectionString = "your_connection_string_here";
//    using (SqlConnection connection = new SqlConnection(connectionString))
//    {
//        connection.Open();

//        // Truy vấn cơ sở dữ liệu để lấy mật khẩu hiện tại của tài khoản người dùng
//        string query = "SELECT Password FROM Users WHERE Username = @Username";
//        using (SqlCommand cmd = new SqlCommand(query, connection))
//        {
//            cmd.Parameters.AddWithValue("@Username", username); Mk,a                                                                                                                                                                                                                                                                                          ```````````````                                                                                    
//            string hashedPasswordInDatabase = cmd.ExecuteScalar() as string;

//            // Kiểm tra xem mật khẩu cũ có khớp với mật khẩu trong cơ sở dữ liệu hay không
//            if (hashedPasswordInDatabase != null && VerifyPasswordHash(oldPassword, hashedPasswordInDatabase))
//            {
//                return true; // Mật khẩu cũ hợp lệ
//            }
//        }
//    }

//    return false; // Mật khẩu cũ không hợp lệ
//}

//private bool VerifyPasswordHash(string inputPassword, string hashedPassword)
//{
//    // Thực hiện so sánh mật khẩu nhập vào với mật khẩu đã băm trong cơ sở dữ liệu
//    // Nếu hợp lệ, trả về true; ngược lại, trả về false
//    // Thực hiện kiểm tra và so sánh mật khẩu tại đây.
//}
