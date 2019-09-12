
using System.Windows.Forms;

namespace SuperHeroProfile
{
    public partial class SuperHeroProfileView : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxOfHero = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHeroesList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPowers = new System.Windows.Forms.ListBox();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxRealName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLblToLoadAssembly = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblToExportXML = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfHero)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxOfHero
            // 
            this.pictureBoxOfHero.Location = new System.Drawing.Point(70, 123);
            this.pictureBoxOfHero.Name = "pictureBoxOfHero";
            this.pictureBoxOfHero.Size = new System.Drawing.Size(258, 248);
            this.pictureBoxOfHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOfHero.TabIndex = 0;
            this.pictureBoxOfHero.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loaded superheroes:";
            // 
            // comboBoxHeroesList
            // 
            this.comboBoxHeroesList.FormattingEnabled = true;
            this.comboBoxHeroesList.Location = new System.Drawing.Point(73, 88);
            this.comboBoxHeroesList.Name = "comboBoxHeroesList";
            this.comboBoxHeroesList.Size = new System.Drawing.Size(255, 24);
            this.comboBoxHeroesList.TabIndex = 2;
            this.comboBoxHeroesList.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeroesList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPowers);
            this.groupBox1.Controls.Add(this.textBoxBirthDate);
            this.groupBox1.Controls.Add(this.textBoxRealName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(415, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile:";
            // 
            // listBoxPowers
            // 
            this.listBoxPowers.FormattingEnabled = true;
            this.listBoxPowers.ItemHeight = 16;
            this.listBoxPowers.Location = new System.Drawing.Point(113, 129);
            this.listBoxPowers.Name = "listBoxPowers";
            this.listBoxPowers.Size = new System.Drawing.Size(173, 116);
            this.listBoxPowers.TabIndex = 5;
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(113, 85);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxBirthDate.TabIndex = 4;
            // 
            // textBoxRealName
            // 
            this.textBoxRealName.Location = new System.Drawing.Point(113, 47);
            this.textBoxRealName.Name = "textBoxRealName";
            this.textBoxRealName.Size = new System.Drawing.Size(100, 22);
            this.textBoxRealName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Powers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Real Name:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblToLoadAssembly,
            this.toolStripLblToExportXML});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLblToLoadAssembly
            // 
            this.toolStripLblToLoadAssembly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLblToLoadAssembly.Name = "toolStripLblToLoadAssembly";
            this.toolStripLblToLoadAssembly.Size = new System.Drawing.Size(115, 22);
            this.toolStripLblToLoadAssembly.Text = "Load Assembly";
            this.toolStripLblToLoadAssembly.Click += new System.EventHandler(this.toolStripLblToLoadAssembly_Click);
            // 
            // toolStripLblToExportXML
            // 
            this.toolStripLblToExportXML.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLblToExportXML.Name = "toolStripLblToExportXML";
            this.toolStripLblToExportXML.Size = new System.Drawing.Size(110, 22);
            this.toolStripLblToExportXML.Text = "Export to XML";
            this.toolStripLblToExportXML.Click += new System.EventHandler(this.toolStripLblToExportXML_Click);
            // 
            // SuperHeroProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxHeroesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOfHero);
            this.Name = "SuperHeroProfileView";
            this.Text = "Super Hero Profile Visor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfHero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxOfHero;
        private Label label1;
        private ComboBox comboBoxHeroesList;
        private GroupBox groupBox1;
        private ListBox listBoxPowers;
        private TextBox textBoxBirthDate;
        private TextBox textBoxRealName;
        private Label label4;
        private Label label3;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLblToLoadAssembly;
        private ToolStripLabel toolStripLblToExportXML;
    }
}

