namespace DAL.BO
{
    public class CommonBO
    {

        public class ApiResponse
        {
            public string? Message { get; set; }
            public object? Result { get; set; }
            public string? Token { get; set; }
            public object? Activity { get; set; }
            public int? EmployeeID { get; set; }
            public int Count { get; set; }
            public string? RefreshToken { get; set; }

        }



        public class UserMasterBO
        {
            public short? Id { get; set; }
            public string? Name { get; set; }
            public string? Email { get; set; }
            public string? Password { get; set; }



        }


    }
}
