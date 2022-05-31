
using app_csharpBTS.Manager;
using app_csharpBTS.Models;
using BTS_Csharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_csharpBTS
{
    public partial class ClassPage2 : Form
    {
        private Decoclass classSelected;
        private Client clientSelected;
        classManager classManager = new classManager();
        PartakesManager partakesManager = new PartakesManager();
        ClientManager clientManager = new ClientManager();
        public ClassPage2()
        {
            InitializeComponent();
        }




        #region affichage produits dans listview
        private void ClassPage_Load(object sender, EventArgs e)
        {


            class_tab.Columns.Clear();
            class_tab.Columns.Add(new ColumnHeader() { Name = "Id", Text = "Id", Width = 100 });
            class_tab.Columns.Add(new ColumnHeader() { Name = "Places", Text = "Places", Width = 100 });
            class_tab.Columns.Add(new ColumnHeader() { Name = "Nom Formation", Text = "Nom Formation", Width = 100 });
            class_tab.Columns.Add(new ColumnHeader() { Name = "Id staff", Text = "Id staff", Width = 100 });
            //Listview pour les classes
            class_tab.Items.Clear();
            foreach (Decoclass decoclass in classManager.AllClasses())
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    decoclass.IdClass.ToString(),
                    decoclass.PlaceClass.ToString(),
                    decoclass.NameClass.ToString(),
                    decoclass.IdStaff.ToString(),

                });
                lvi.Tag = decoclass;
                class_tab.Items.Add(lvi);
            }



        }

        private void member_tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_class_btn_Click(object sender, EventArgs e)
        {
            ClassMakerPage form = new ClassMakerPage();
            form.Show();
        }

        private void class_tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void class_tab_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = class_tab.SelectedItems;
            if (selected.Count == 1)
            {
                classSelected = selected[0].Tag as Decoclass;
            }


            member_tab.Items.Clear();

            member_tab.Columns.Clear();
            member_tab.Columns.Add(new ColumnHeader() { Name = "Id Cours", Text = "Id Cours", Width = 100 });
            member_tab.Columns.Add(new ColumnHeader() { Name = "Nom Client", Text = "Nom Client", Width = 100 });
            member_tab.Columns.Add(new ColumnHeader() { Name = "Prenom Client", Text = "Prenom Client", Width = 100 });
            member_tab.Columns.Add(new ColumnHeader() { Name = "Email", Text = "email", Width = 100 });
            // code listview clien par classes
            foreach (Partake partake in partakesManager.FindClassClient(classSelected.IdClass))
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    partake.IdClass.ToString(),
                    partake.IdCliNavigation.NameCli.ToString(),
                    partake.IdCliNavigation.FirstnameCli.ToString(),
                    partake.IdCliNavigation.EmailCli.ToString(),
                });
                lvi.Tag = partake;
                member_tab.Items.Add(lvi);
            }


        }
        //ajout client
        private void Stocks_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            form.Show();
        }

        private void Add_cli_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(clientName.Text) || string.IsNullOrEmpty(Firstname.Text) || classSelected is null)
            {
                MessageBox.Show("Il semblerai que vous avez pas sélectionné de champs");
            }
            else
            {
                Client client = new Client(clientName.Text, Firstname.Text, email.Text);
                Client insert = clientManager.AddClient(client);
                Partake partakeInsert = new Partake(classSelected.IdClass, insert.IdCli);
                partakesManager.AddPartake(partakeInsert);

                member_tab.Items.Clear();
                foreach (Partake partake in partakesManager.FindClassClient(classSelected.IdClass))
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        partake.IdClass.ToString(),
                        partake.IdCliNavigation.NameCli.ToString(),
                        partake.IdCliNavigation.FirstnameCli.ToString(),
                        partake.IdCliNavigation.EmailCli.ToString(),
                    });
                    lvi.Tag = partake;
                    member_tab.Items.Add(lvi);
                }

            }


        }

        private void clientName_TextChanged(object sender, EventArgs e)
        {

        }
        private void Remove_cli_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrEmpty(clientName.Text) || string.IsNullOrEmpty(Firstname.Text) || clientSelected == null)
            {
                MessageBox.Show("Il semblerai que vous avez pas sélectionné de champs");
            }
            else
            {
                clientManager.RemoveClient(clientSelected);

            }
        }
        private void member_tab_DoubleClick(object sender, EventArgs e) { }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void remove_class_Click(object sender, EventArgs e)
        {
             if (classSelected == null)
            {
                MessageBox.Show("Il semblerai que vous avez pas sélectionné de champs");
            }
            else
            {
                classManager.RemoveClass(classSelected);

            }
        }
    }
    #endregion
}

