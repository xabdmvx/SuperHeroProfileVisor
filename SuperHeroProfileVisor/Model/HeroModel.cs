using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroProfile.Model
{
    public class HeroModel
    {
        //data
        public string Name { get; set; }
        public string RealName { get; set; }
        public DateTime BirthDate { get; set; }
        public string[] Powers { get; set; }
        public string ImagePath { get; set; }

        public void LoadValuesFromExistingInstance(HeroModel hero)
        {
            Name = hero.Name;
            RealName = hero.RealName;
            BirthDate = hero.BirthDate;
            Powers = hero.Powers;
            ImagePath = hero.ImagePath;
        }
    }
}
