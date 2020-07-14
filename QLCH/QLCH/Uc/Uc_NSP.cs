using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc
{
    public partial class Uc_NSP : UserControl
    {
        public Uc_NSP()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        int choose = 0;
        string id = "";

        private void rdbGroupID_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Uc_NSP_Load(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            dgvGroupP.DataSource = db.NSP_Sel();
            if (rdbGroupID.Checked == false && rdbGroupName.Checked == false)
                btnFind.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            if(rdbGroupID.Checked == true && rdbGroupName.Checked == true)
            {
                if (txtID.Text == "" || txtName.Text=="")
                    MessageBox.Show("Not fill full information");
                else
                    dgvGroupP.DataSource = db.NSP_Find(txtID.Text, txtName.Text);
            }
            else if (rdbGroupID.Checked == true)
            {
                if (txtID.Text == "")
                    MessageBox.Show("Not fill the id yet");
                else
                    dgvGroupP.DataSource = db.NSP_Find(txtID.Text, null);
            }
            else if (rdbGroupName.Checked == true)
            {
                if (txtName.Text == "")
                    MessageBox.Show("Not fill the name yet");
                else
                    dgvGroupP.DataSource = db.NSP_Find(null, txtName.Text);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            rdbGroupID.Checked = false;
            rdbGroupName.Checked = false;
            Uc_NSP_Load(sender, e);
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnUp.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            btnUp.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            choose = 1;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            btnUp.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            choose = 2;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            btnDel.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            choose = 3;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sp = from u in db.nhomSPs select u;

            switch (choose)
            {

                case 1:
                    {
                        if (txtName.Text == "")
                            MessageBox.Show("Please enter enough information");
                        else if (txtName.Text != "")
                        {
                            if (sp.Count() == 0)
                            {
                                db.NSP_Add("Nhom0001", txtName.Text);
                            }
                            else
                            {
                                var sssp = db.nhomSPs.Where(s => s.tenLoai.Equals(txtName.Text)).FirstOrDefault();
                                if (sssp != null)
                                    MessageBox.Show("Already have this name");
                                else if (sssp == null)
                                {
                                    var ssp = sp.OrderByDescending(s => s.maLoai).FirstOrDefault();
                                    int stt = Convert.ToInt32(ssp.maLoai.Substring(4)) + 1;
                                    if (stt / 10 >= 100)
                                        id = "Nhom" + stt;
                                    else if (stt / 10 >= 10 && stt / 10 < 100)
                                        id = "Nhom0" + stt;
                                    else if (stt / 10 >= 1 && stt / 10 < 10)
                                        id = "Nhom00" + stt;
                                    else if (stt / 10 == 0)
                                        id = "Nhom000" + stt;
                                    //MessageBox.Show(id);
                                    db.NSP_Add(id, txtName.Text);
                                }
                            }
                            Uc_NSP_Load(sender, e);
                        }
                        break;

                    }
                case 2:
                    {
                        if (txtID.Text == "")
                        {
                            MessageBox.Show("Not enter id yet");
                        }
                        else
                            db.NSP_Del(txtID.Text);
                        Uc_NSP_Load(sender, e);
                        break;
                    }
                case 3:
                    {
                        if (txtName.Text == "" || txtID.Text == "")
                            MessageBox.Show("Please enter enough information");
                        else
                        {
                            var sssp = db.nhomSPs.Where(s => s.tenLoai.Equals(txtName.Text)).FirstOrDefault();
                            if (sssp != null)
                                MessageBox.Show("Already have this name");
                            else
                            {
                                db.NSP_Up(txtID.Text, txtName.Text);
                                Uc_NSP_Load(sender, e);
                            }
                            
                        }
                        break;
                    }

            }
            
        }
        int i = 0;
        private void dgvGroupP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                txtID.Text = dgvGroupP.Rows[i].Cells[0].Value.ToString();
                txtName.Text = dgvGroupP.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void rdbGroupID_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbGroupID.Checked == true)
            {
                txtID.Enabled = true;
                btnFind.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
                btnFind.Enabled = true;
            }
        }
    }
}
