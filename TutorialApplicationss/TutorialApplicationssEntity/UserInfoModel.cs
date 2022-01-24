using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialApplicationssEntity;


namespace TutorialApplicationssEntity
{
   public class UserInfoModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string Pwd { get; set; }
    }
}
