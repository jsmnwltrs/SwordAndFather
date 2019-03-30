using System.Collections.Generic;
using SwordAndFather.Controllers.Modals;

namespace SwordAndFather.Controllers
{
    public class AssassinRepository
    {
        static readonly List<Assassin> _assassins = new List<Assassin>();

        public Assassin AddAssassin(string codeName, string catchphrase, string prefferedWeapon)
        {
            var newAssassin = new Assassin(codeName, catchphrase, prefferedWeapon);

            newAssassin.Id = _assassins.Count + 1;

            _assassins.Add(newAssassin);

            return newAssassin;
        }
    }
}