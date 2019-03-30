using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordAndFather.Controllers.Modals
{
    public class Assassin
    {
        public Assassin(string codeName, string catchphrase, string prefferedWeapon)
        {
            CodeName = codeName;
            Catchphrase = catchphrase;
            PrefferedWeapon = prefferedWeapon;
        }

        public int Id { get; set; }
        public string CodeName { get; set; }
        public string Catchphrase { get; set; }
        public string PrefferedWeapon { get; set; }
        public int Rating { get; set; }
        public decimal StandardFee { get; set; }
    }
}
