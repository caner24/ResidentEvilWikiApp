using MaterialSkin;
using MaterialSkin.Controls;
using Racoon.Business.Abstract;
using Racoon.Business.DependencyResolvers.Ninject;
using Racoon.Entities.Concrate;
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
using WindowsFormsApp1;

namespace REvilWikiAppAdmin
{
    public partial class adminPage : MaterialForm
    {
        public adminPage()
        {
            InitializeComponent();
            _personService = InstanceFactory.GetInstance<IPersonService>();
            _occupationService = InstanceFactory.GetInstance<IOccupationService>();
        }
        string _sex;
        IPersonService _personService;
        IOccupationService _occupationService;
        private void GetAll()
        {
            dgwPersonList.DataSource = _personService.GetAll();
        }
        private void GetAllOccupation()
        {
            cbxOccupation.DataSource = _occupationService.GetAll();
            cbxOccupation.ValueMember = "OccupationId";
            cbxOccupation.DisplayMember = "OccupationName";

        }

        public byte[] ImageToByteArray(System.Drawing.Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }
        public Image ByteArrayToImage(byte[] byteArray)
        {
            MemoryStream memoryStream = new MemoryStream(byteArray);
            Image returnImage = Image.FromStream(memoryStream);
            return returnImage;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetAll();
            GetAllOccupation();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow300, Primary.Grey900, Primary.Grey900, Accent.Yellow700, TextShade.BLACK);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                _personService.Add(new Person
                {
                    PersonName = tbxPersonName.Text,
                    OccupationId = (int)cbxOccupation.SelectedValue,
                    DateOfBirth = dtpDateOfBirth.Value,
                    DateOfDeath = dtpDateOfDeath.Value,
                    Sex = _sex.ToString(),
                    Status = tbxStatus.Text,
                    Personİnfo= rtbxPersonİnfo.Text,
                    Personİmage = ImageToByteArray(pbxPerson.Image),
                    Ocuppationİmage1 = ImageToByteArray(pbxOccupation1.Image),
                    Ocuppationİmage2 = ImageToByteArray(pbxOccupation2.Image),
                });
                GetAll();
            }
            catch (Exception expection)
            {

                MessageBox.Show(expection.Message);
            }
        }

        private void cbxOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPersonİmage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                pbxPerson.ImageLocation = openfiledialog.FileName;

            }
        }

        private void rbtMan_CheckedChanged(object sender, EventArgs e)
        {
            _sex = "Man";
        }

        private void rbtWoman_CheckedChanged(object sender, EventArgs e)
        {
            _sex = "Woman";
        }

        private void btnOccupation2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                pbxOccupation2.ImageLocation = openfiledialog.FileName;

            }
        }

        private void btnOccupation1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                pbxOccupation1.ImageLocation = openfiledialog.FileName;

            }
        }

        private void dgwPersonList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxPersonName.Text = dgwPersonList.CurrentRow.Cells[1].Value.ToString().Trim();
            rtbxPersonİnfo.Text = dgwPersonList.CurrentRow.Cells[2].Value.ToString();
            cbxOccupation.Text = dgwPersonList.CurrentRow.Cells[3].Value.ToString();
            dtpDateOfBirth.Text = dgwPersonList.CurrentRow.Cells[4].Value.ToString();
            dtpDateOfDeath.Text = dgwPersonList.CurrentRow.Cells[5].Value.ToString();
            _sex = dgwPersonList.CurrentRow.Cells[6].Value.ToString();
           if (_sex=="Man")
            {
                rbtMan.Checked = true;
            }
            else
            {
                rbtWoman.Checked = true;
            }
            tbxStatus.Text = dgwPersonList.CurrentRow.Cells[7].Value.ToString();
            pbxPerson.Image = ByteArrayToImage((byte[])dgwPersonList.CurrentRow.Cells[8].Value);
            pbxOccupation1.Image = ByteArrayToImage((byte[])dgwPersonList.CurrentRow.Cells[9].Value);
            pbxOccupation2.Image = ByteArrayToImage((byte[])dgwPersonList.CurrentRow.Cells[10].Value);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxSearch.Text))
            {
                GetAll();
            }
            else
            {

                dgwPersonList.DataSource = _personService.GetPersonById(int.Parse(tbxSearch.Text));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _personService.Delete(new Person()
            {
                PersonId = int.Parse(tbxDelete.Text),
            });
            GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _personService.Update(new Person()
            {
                PersonId = (int)dgwPersonList.CurrentRow.Cells[0].Value,
                PersonName = tbxPersonName.Text,
                OccupationId = int.Parse(cbxOccupation.Text),
                DateOfBirth = dtpDateOfBirth.Value,
                DateOfDeath = dtpDateOfDeath.Value,
                Sex = _sex.ToString(),
                Status = tbxStatus.Text,
                Personİnfo=rtbxPersonİnfo.Text,
                Personİmage = ImageToByteArray(pbxPerson.Image),
                Ocuppationİmage1 = ImageToByteArray(pbxOccupation1.Image),
                Ocuppationİmage2 = ImageToByteArray(pbxOccupation2.Image),
            });
        }

        private void btnOccupationAdd_Click(object sender, EventArgs e)
        {
            _occupationService.Add(new Occupation()
            {
                OccupationName = tbxOccupationName.Text,
                Occupationİmage1 = ImageToByteArray(pbxOccupationImage1.Image),
                Occupationİmage2 = ImageToByteArray(pbxOccupationImage2.Image)
            });
            GetAllOccupation();
        }

        private void btnOccupationImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                pbxOccupationImage1.ImageLocation = openfiledialog.FileName;

            }
        }

        private void btnOccupationImage2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                pbxOccupationImage2.ImageLocation = openfiledialog.FileName;

            }
        }

        private void enterUserGuiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userGui userGui = new userGui();
            userGui.Show();
            this.Hide();
        }
    }
}
