using app_csharpBTS.Manager;
using app_csharpBTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTS_Csharp
{
    public partial class ClassPage : Form
    {
        public ClassPage()
        {
            InitializeComponent();
        }
        



        #region affichage produits dans listview
        private void ClassPage_Load(object sender, EventArgs e)
        {
            member_tab.Items.Clear();
            //foreach (Decoclass decoclass in /*classManager.AllClasses()*/)
            //{
            //    ListViewItem lvi = new ListViewItem(new string[]
            //    {
            //        //decoclass.IdClass.ToString(),
            //        //decoclass.Name_Cli.ToString(),
            //        //decoclass.StockProduct.ToString(),
            //        //decoclass.PriceProduct.ToString(),
            //    });
            //    lvi.Tag = decoclass;
            //    member_tab.Items.Add(lvi);
            //}
            member_tab.Columns.Clear();
            member_tab.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 250 });
            member_tab.Columns.Add(new ColumnHeader() { Name = "Type", Text = "Type", Width = 250 });
            member_tab.Columns.Add(new ColumnHeader() { Name = "Stock", Text = "Stock", Width = 250 });
            member_tab.Columns.Add(new ColumnHeader() { Name = "Prix", Text = "Prix", Width = 250 });
        }

        private void member_tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    #endregion
}
