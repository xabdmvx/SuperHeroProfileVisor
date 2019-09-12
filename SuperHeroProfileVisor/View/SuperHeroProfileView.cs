using SuperHeroProfile.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SuperHeroProfile
{
    public partial class SuperHeroProfileView : Form
    {
        public SuperHeroProfilePresenter Presenter { get; set; }

        public SuperHeroProfileView()
        {
            InitializeComponent();
        }

        private void comboBoxHeroesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string SelectedHero = comboBoxHeroesList.SelectedItem.ToString();               
                if (SelectedHero != "")
                {
                    Presenter.OnHeroChanged(SelectedHero);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error loading Hero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripLblToLoadAssembly_Click(object sender, EventArgs e)
        {
            OpenFileDialog AssemblyFileDialog = new OpenFileDialog
            {
                Title = "Browse Assembly Files",
                DefaultExt = "dll",
                Filter = "Assembly files (*.dll)|*.dll|All files (*.*)|*.*",
                FilterIndex = 1
            };

            if (AssemblyFileDialog.ShowDialog() == DialogResult.OK)
            {
                //after return from the Dialog                
                string FileSelected = AssemblyFileDialog.FileName;
                try
                { 
                    Presenter.OnAssemblyFileSelected(FileSelected);               
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message+Ex.InnerException, "Error Loading Assembly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void toolStripLblToExportXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog ExportXmlSaveFileDialog = new SaveFileDialog()
            {
                Title = "Exporting Heros to XML File",
                CheckPathExists = true,
                DefaultExt = "xml",
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (ExportXmlSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //after return from the Dialog
                string SavePathSelected = ExportXmlSaveFileDialog.FileName;
                try
                {
                    Presenter.OnExportXmlPathSelected(SavePathSelected);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error Exporting Heros into XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateView(string Name, string RealName, string ImagePath, string BirthDate, String[] Powers)
        {
            if(!comboBoxHeroesList.Items.Contains(Name))
            {
                comboBoxHeroesList.Items.Add(Name);
                comboBoxHeroesList.Text = Name;
            }
            
            textBoxRealName.Text = RealName;
            textBoxBirthDate.Text = BirthDate;

            listBoxPowers.Items.Clear();
            listBoxPowers.Items.AddRange(Powers);
            
            bool ImageFound = true;
            string ImgFullPath = ImagePath;
            if(!File.Exists(ImgFullPath))
            {
                ImgFullPath = Directory.GetCurrentDirectory() + ImagePath;
                if (!File.Exists(ImgFullPath))
                {
                    ImageFound = false;
                }
            }

            if(ImageFound)
            {
                Image file = Image.FromFile(ImgFullPath);
                pictureBoxOfHero.Image = file;
            }
            else
            {
                pictureBoxOfHero.Image = null;       
            }
        }

        public void ExportDataToXml(string savePath, string ExportXmlStr)
        {
            XmlDocument ExportXml = new XmlDocument();
            ExportXml.LoadXml(ExportXmlStr);
            ExportXml.Save(savePath);
        }        
    }
}