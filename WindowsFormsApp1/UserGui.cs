using MaterialSkin;
using MaterialSkin.Controls;
using Racoon.Business.Abstract;
using Racoon.Business.DependencyResolvers.Ninject;
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
using Microsoft.VisualBasic;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class userGui : MaterialForm
    {
        public userGui()
        {
            InitializeComponent();
            _personService = InstanceFactory.GetInstance<IPersonService>();
            _occupationService = InstanceFactory.GetInstance<IOccupationService>();
        }
        IPersonService _personService;
        IOccupationService _occupationService;
        public void GetMyPerson()
        {

        }
        private void GetAll()
        {
            dgwPersonList.DataSource = _personService.GetAll();
        }
        private Image ByteArrayToImage(byte[] array)
        {
            MemoryStream memoryStream = new MemoryStream(array);
            Image image = Image.FromStream(memoryStream);
            return image;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAll();
            timer1.Enabled = true;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow300, Primary.Grey900, Primary.Grey900, Accent.Yellow700, TextShade.BLACK);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWelcome.Text = lblWelcome.Text.Substring(1) + lblWelcome.Text.Substring(0, 1);
        }


        private void dgwPersonList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblName.Text = dgwPersonList.CurrentRow.Cells[1].Value.ToString().Trim();
            rtbxPersonİnfo.Text = dgwPersonList.CurrentRow.Cells[2].Value.ToString();
            lblOccupation.Text = dgwPersonList.CurrentRow.Cells[3].Value.ToString();
            lblBirthDate.Text = dgwPersonList.CurrentRow.Cells[4].Value.ToString();
            lblDeathDate.Text = dgwPersonList.CurrentRow.Cells[5].Value.ToString();
            lblSex.Text = dgwPersonList.CurrentRow.Cells[6].Value.ToString();
            lblStatus.Text = dgwPersonList.CurrentRow.Cells[7].Value.ToString();
            pbxPerson.Image = ByteArrayToImage((byte[])dgwPersonList.CurrentRow.Cells[8].Value);
            pbxOccupation1.Image = ByteArrayToImage((byte[])dgwPersonList.CurrentRow.Cells[9].Value);
            pbxOccupation2.Image = ByteArrayToImage((byte[])dgwPersonList.CurrentRow.Cells[10].Value);
            tPPersonDetail.Show();
        }

    }
}
