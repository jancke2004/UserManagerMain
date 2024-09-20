using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Logic.DTOs.Users
{
    public class AddUser
    {
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Added_By { get; set; }

        public string Updated_By { get; set; }
    }
}
