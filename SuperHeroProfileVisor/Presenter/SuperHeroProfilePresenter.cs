using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SuperHeroProfile.Model;
using SuperHeroProfileVisor.AssemblyReflectionProxy;

namespace SuperHeroProfile.Presenter
{
    public class SuperHeroProfilePresenter
    {
        private HeroModel hero;
        private SuperHeroProfileView view;
        private Dictionary<string, HeroModel> dict = new Dictionary<string, HeroModel>();
                
        public SuperHeroProfilePresenter(HeroModel hero, SuperHeroProfileView view)
        {
            this.hero = hero;
            this.view = view;

            view.Presenter = this;
        }

        public bool ExistHero(string HeroName)
        {
            return dict.ContainsKey(HeroName);
        }

        public void OnHeroChanged(String HeroName)
        {
            //TODO:
            //If we have implemented some logic to add the heroes in a collection
            //here is where we will load the Hero Model with the stored data
            if (dict.ContainsKey(HeroName))
            {
                //update hero
                hero.LoadValuesFromExistingInstance(dict[HeroName]);
                
                //refresh view
                UpdateView();
            }
        }

        private void LoadHeroFromAssembly(string assemblyPath)
        { 
            var manager = new AssemblyReflectionManager();

            var success = manager.LoadAssembly(assemblyPath, "NewDomain");

            //Look for the SuperHero Type in the loaded Assembly, Otherwise it will return null 
            Type SuperHeroType = manager.Reflect(assemblyPath, (a) => {
                Type returnType = null;
                var names = new List<string>();
                Type[] types = a.GetTypes();
                foreach (Type t in types)
                {
                    if (t.Name == "SuperHero")
                    {
                        returnType = t;
                        break;
                    }
                }
                return returnType;
            });

            if (SuperHeroType == null)
            {
                throw new Exception("The Assembly is not supported by this application!");
            }

            //Get the instance of the class
            var instance = Activator.CreateInstance(SuperHeroType);

            string[] SuperHeroMethods = new string[]
                                                {
                                                    "GetSuperHeroName",
                                                    "GetSuperHeroRealName",
                                                    "GetSuperHeroBirthDate",
                                                    "GetSuperHeroImagePath",
                                                    "GetSuperHeroPowers"
                                                };
            //reset Hero Name since it is used as Key
            hero.Name = "";

            // Get the Super Hero methods to get the Info  
            // and Execute the GetAssemblyName method.               
            foreach (string method in SuperHeroMethods)
            {
                string methodResult = "";
                MethodInfo AssemblyMethod = SuperHeroType.GetMethod(method);

                if (method != "GetSuperHeroPowers")
                    methodResult = AssemblyMethod.Invoke(instance, null).ToString();

                switch (method)
                {
                    case "GetSuperHeroName":
                        hero.Name = methodResult;
                        break;
                    case "GetSuperHeroRealName":
                        hero.RealName = methodResult;
                        break;
                    case "GetSuperHeroImagePath":
                        hero.ImagePath = methodResult;
                        break;
                    case "GetSuperHeroBirthDate":
                        //define culture for date
                        CultureInfo culture = new CultureInfo("en-US");
                        //get date in US format
                        hero.BirthDate = Convert.ToDateTime(methodResult, culture);
                        break;
                    case "GetSuperHeroPowers":
                        string[] methodValues = (string[])AssemblyMethod.Invoke(instance, null);
                        hero.Powers = methodValues;
                        break;
                }
            }

            manager.UnloadAssembly(assemblyPath);
        }


        public void OnAssemblyFileSelected(string fileSelected)
        {

            LoadHeroFromAssembly(fileSelected);

            //Add a new hero
            if (hero.Name!="" && !dict.ContainsKey(hero.Name))
            {
                HeroModel svHero = new HeroModel();
                svHero.LoadValuesFromExistingInstance(hero);
                dict.Add(hero.Name, svHero);
            }
                        
            UpdateView();
        }

        public void OnExportXmlPathSelected(string savePath)
        {
            List<HeroModel> heroes = new List<HeroModel>();
            foreach (KeyValuePair<string, HeroModel> item in dict)
            {
                heroes.Add(item.Value);
            }
            view.ExportDataToXml(savePath, ObjectToXMLGeneric<List<HeroModel>>(heroes));
        }

        private void UpdateView()
        {
            CultureInfo culture = new CultureInfo("en-US");
            view.UpdateView(hero.Name, hero.RealName, hero.ImagePath, Convert.ToString(hero.BirthDate, culture), hero.Powers);
        }

        private String ObjectToXMLGeneric<T>(T filter)
        {
            //Convert a class into XML
            string xml = null;
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(sw, filter);
                try
                {
                    xml = sw.ToString();

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return xml;
        }
    }
}
