using System;

namespace UnitTest
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }
        public string IdCard { get; set; }
        public bool IsEnable { get; set; }
    }
}