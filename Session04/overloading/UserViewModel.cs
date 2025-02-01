namespace Session04.overloading
{
    internal class UserViewModel
    {
        #region Properties
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        #endregion

        public static explicit operator UserViewModel(User user)
        {
            string[]? names = user?.FullName?.Split("");
            return new UserViewModel()
            {
                Id = user?.Id ?? 0,
                Email = user?.Email,
                FirstName = names?[0],
                LastName = names?.Length >= 1 ? names[1] : null
            };
        }




















        //public static explicit operator UserViewModel(User user)
        //{

        //    string[]? names = user?.FullName?.Split("");
        //    return new UserViewModel()
        //    {
        //        Id = user?.Id ?? 0,
        //        Email = user?.Email,
        //        FirstName = names?[0] ,
        //        LastName = names?.Length > 2 ? names[1] : null ,
        //    };
        //}

    }
}
