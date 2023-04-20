using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{

    //Khoi tao bang co so du lieu gom 4 cot Id, UserName, PasswordHash, PasswordSalt
    public class AppUser
    {
        public int Id { get; set; }
        
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
