using Eticaret.Model.Enums;

namespace Eticaret.Model
{
    public class Register
    {
        public string Firstname { get; set; } = string.Empty;

        public string Lastname { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }
    }
}
