using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ResidentEvilWiki
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

        }
        IPersonService _productService;
        ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {


            timer1.Enabled = true;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow300, Primary.Grey900, Primary.Grey900, Accent.Yellow700, TextShade.BLACK);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        int _photoNumbers=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            materialLabel2.Text = DateTime.Today.ToString();
            pbxİmageStock.Image = imagelistWikiPhotos.Images[0];
            if (_photoNumbers == imagelistWikiPhotos.Images.Count)
            {
                _photoNumbers = 0;
            }
            else
            {
                _photoNumbers++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tPPersonDetail.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tPPersonDetail.Show();
        }
    }
}
