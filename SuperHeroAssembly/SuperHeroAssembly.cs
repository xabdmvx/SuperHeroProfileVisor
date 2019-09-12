using SuperHeroProfile.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperHeroAssembly
{
    public class SuperHero
    {
        private HeroModel hero;
        const int loadArrayItem = 3;
        string[] ArrayName = new string[] 
        {
            "Iron Man",
            "Daredevil",
            "Hiro Nakamura",
            "Starlight"
        };
        string[] ArrayRealName = new string[] 
        {
            "Tony Starks",
            "Matt Murdock",
            "Hiro Nakamura",
            "Annie January"
        };
        string[] ArrayImagePath = new string[] 
        {
            "Ironman.jpg",
            "Daredevil.jpg",
            "Hiro.jpg",
            "Starlight.jpg"
        };
        string[][] ArrayPowers =
        {
            new string[]
            {
                "Super Armor",
                "Missiles",
                "Laser beans",
                "Bash Account"
            },
            new string[]
            {
                "Henhanced Hearing",
                "Enhanced Touch",
                "Henhanced Taste",
                "Enhanced Smell",
                "Enhanced Senses"
            },
            new string[]
            {
                "Space-time manipulation",
                "teleport",
                "time travel"
            },
            new string[]
            {
                "Manipulate Light Energy",
                "Super force",
                "invulnerability"
            }

        };
        string[] ArrayBirthDate = new string[] 
        {
            "05/29/1970",
            "05/10/1986",
            "3/15/1983",
            "07/07/1991"
        };

        public SuperHero()
        {
            //define culture for date
            CultureInfo culture = new CultureInfo("en-US");

            //populate the model hero instance with Fixed Data 
            hero = new HeroModel
            {
                Name = ArrayName[loadArrayItem],
                RealName = ArrayRealName[loadArrayItem],
                BirthDate = Convert.ToDateTime(ArrayBirthDate[loadArrayItem], culture),
                ImagePath = ArrayImagePath[loadArrayItem],
                Powers = ArrayPowers[loadArrayItem] 
            };
        }

        public HeroModel GetSuperHero()
        {     
            return hero;
        }

        public string GetSuperHeroName()
        {
            return hero.Name;
        }

        public string GetSuperHeroRealName()
        {
            return hero.RealName;
        }

        public string GetSuperHeroImagePath()
        {
            return hero.ImagePath;
        }

        public string GetSuperHeroBirthDate()
        {
            //define culture for date
            CultureInfo culture = new CultureInfo("en-US");

            return Convert.ToString(hero.BirthDate,culture);
        }

        public string[] GetSuperHeroPowers()
        {
            return hero.Powers;
        }



    }
}
