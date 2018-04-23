using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.Skins;

namespace WindowsApplication1
{
    public partial class Form1 : XtraForm
    {


        static string GetLibraryName(DynamicSkinType type)
        {
            return String.Format("DevExpress.{0}Skins{1}.dll", type, AssemblyInfo.VSuffix);
        }

        string ShowDialog(DynamicSkinType type)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = GetLibraryName(type);
            dialog.ShowDialog();
            return dialog.FileName;
        }

        void LoadDynamicSkin(DynamicSkinType type)
        {
            string fileName = ShowDialog(type);
            if (File.Exists(fileName))
            {
                Assembly SampleAssembly = Assembly.LoadFile(fileName);
                DevExpress.Skins.SkinManager.Default.RegisterAssembly(SampleAssembly);
                PopulateListBox();
            }
            else MessageBox.Show(String.Format("File not found ({0})", fileName));
        }

        void PopulateListBox()
        {
            listBoxControl1.Items.Clear();
            foreach (SkinContainer skin in SkinManager.Default.Skins)
            {
                listBoxControl1.Items.Add(skin.SkinName);
            }
        }

        public Form1()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadDynamicSkin(DynamicSkinType.Office);
        }

        private void listBoxControl1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedValue != null)
                defaultLookAndFeel1.LookAndFeel.SkinName = listBoxControl1.SelectedValue.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadDynamicSkin(DynamicSkinType.Bonus);
        }
    }

    enum DynamicSkinType
    {
        Office, 
        Bonus,
    }
}