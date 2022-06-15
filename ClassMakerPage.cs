
using app_csharpBTS;
using app_csharpBTS.Manager;
using app_csharpBTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTS_Csharp
{
    public partial class ClassMakerPage : Form
    {
        public ClassMakerPage()
        {
            InitializeComponent();
        }
        classManager classManager = new classManager();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void add_class_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameClassText.Text))
            {
                MessageBox.Show("Oups !! il semblerai que vous avez oublié de renseigner certains champs");
                
            }
            else
            {
                Decoclass newDecoclass = new Decoclass(NameClassText.Text, PlaceClassText.Text);
                classManager.AddClass(newDecoclass);
                ClassPage2 form = new ClassPage2();
                form.Show();

            }
        }

    }
}
