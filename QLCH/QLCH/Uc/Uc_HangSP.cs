using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace QLCH.Uc
{
    public partial class Uc_HangSP : UserControl
    {
        public Uc_HangSP()
        {
            InitializeComponent();
            //btnSave.Enabled = false;
            //btnCancel.Enabled = false;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int choose = 0;


        private void Uc_HangSP_Load(object sender, EventArgs e)
        {
            txtIDBrand.Enabled = false;
            dgvHangSP.DataSource = db.HSP_Sel();
            
            if (rdbBrandID.Checked == false && rdbBrandName.Checked == false)
                btnFind.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GunaButton btn = sender as GunaButton;
            if (btn.Name.Equals("btnAdd"))
            {
                choose = 1;
                btnDel.Enabled = false;
                btnUp.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
                
            else if (btn.Name.Equals("btnDel"))
            {
                txtIDBrand.Enabled = true;
                choose = 2;
                btnAdd.Enabled = false;
                btnUp.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
                
            else if (btn.Name.Equals("btnUp"))
            {
                txtIDBrand.Enabled = true;
                choose = 3;
                btnDel.Enabled = false;
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtIDBrand.Enabled = false;
            rdbBrandID.Checked = false;
            rdbBrandName.Checked = false;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnUp.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnFind.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if(rdbBrandID.Checked == true && rdbBrandName.Checked==true)
            {
                if(txtIDBrand.Text=="" || txtNameBrand.Text == "")
                {
                    MessageBox.Show("Please fill all the text");
                }
                else
                    dgvHangSP.DataSource = db.HSP_Find(txtIDBrand.Text, txtNameBrand.Text);
            }
            else if(rdbBrandID.Checked == true)
            {
                if (txtIDBrand.Text == "")
                    MessageBox.Show("Please enter the id of brand");
                else
                    dgvHangSP.DataSource = db.HSP_Find(txtIDBrand.Text, null);
                
            }
            else if (rdbBrandName.Checked == true)
            {
                if (txtNameBrand.Text == "")
                    MessageBox.Show("Please enter the name of brand");
                else
                    dgvHangSP.DataSource = db.HSP_Find(null, txtNameBrand.Text);
            }
        }

        private void rdbBrandID_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbBrandID.Checked == true)
            {
                txtIDBrand.Enabled = true;
                btnFind.Enabled = true;
                txtIDBrand.ResetText();
                txtNameBrand.ResetText();
            }
            else if (rdbBrandID.Checked == false)
            {
                txtIDBrand.Enabled = false;
                btnFind.Enabled = true;
                txtIDBrand.ResetText();
                txtNameBrand.ResetText();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (choose)
            {
                case 1:
                    {
                        if (txtNameBrand.Text == "")
                            MessageBox.Show("Please enter name of brand");
                        else if (txtNameBrand.Text != "")
                        {
                            var hsp = from u in db.HangSPs select u;
                            if (hsp.Count() == 0)
                            {
                                db.HSP_Ins("Hang0001", txtNameBrand.Text);

                            }
                            else
                            {
                                HangSP hspp = db.HangSPs.Where(s => s.tenHang.Equals(txtNameBrand.Text)).FirstOrDefault();
                                if (hspp != null)
                                    MessageBox.Show("Alredy have this name");
                                else if (hspp == null)
                                {
                                    var hsppp = hsp.OrderByDescending(s => s.maHang).FirstOrDefault();
                                    int stt = Convert.ToInt32(hsppp.maHang.Substring(4)) + 1;
                                    string id = "";
                                    if (stt / 10 >= 100)
                                        id = "Hang" + stt;
                                    else if (stt / 10 >= 10 && stt / 10 < 100)
                                        id = "Hang0" + stt;
                                    else if (stt / 10 >= 1 && stt / 10 < 10)
                                        id = "Hang00" + stt;
                                    else if (stt / 10 == 0)
                                        id = "Hang000" + stt;
                                    db.HSP_Ins(id, txtNameBrand.Text);
                                    //dgvHangSP.DataSource = db.HSP_Sel();
                                }
                            }
                            Uc_HangSP_Load(sender, e);
                        }
                        break;
                    }
                case 2:
                    {
                        if (txtIDBrand.Text == "")
                        {
                            MessageBox.Show("Please enter the id to delete");
                        }
                        else
                        {
                            db.HSP_Del(txtIDBrand.Text);
                            Uc_HangSP_Load(sender, e);
                        }
                        break;
                    }
                case 3:
                    {
                        if (txtIDBrand.Text == "" || txtNameBrand.Text == "")
                            MessageBox.Show("Please enter the id and name of brand");
                        else
                        {
                            HangSP hsp = db.HangSPs.Where(s => s.tenHang.Equals(txtNameBrand.Text)).FirstOrDefault();
                            if (hsp != null)
                                MessageBox.Show("Already have this name");
                            else
                            {
                                db.HSP_Up(txtIDBrand.Text, txtNameBrand.Text);
                                Uc_HangSP_Load(sender, e);
                            }
                            
                        }
                        break;
                    }
            
            }
        }
        int i = 0;
        private void dgvHangSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                txtIDBrand.Text = dgvHangSP.Rows[i].Cells[0].Value.ToString();
                txtNameBrand.Text = dgvHangSP.Rows[i].Cells[1].Value.ToString();
            }
        }
    }
}
