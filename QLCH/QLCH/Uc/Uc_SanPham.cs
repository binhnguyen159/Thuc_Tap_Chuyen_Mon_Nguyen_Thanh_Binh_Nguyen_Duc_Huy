using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using QLCH.Uc.WareHouse;
using System.Runtime.InteropServices.WindowsRuntime;

namespace QLCH.Uc
{
    public partial class Uc_SanPham : UserControl
    {
        public Uc_SanPham()
        {
            InitializeComponent();
            
            lbNext.Enabled = false;
            cbbPage.SelectedItem = "15";
            page = Convert.ToInt32(txtPage.Text);
            load_PhanTrang();
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = db.SP_Page(1,15);
            dgvProduct.Columns[2].DefaultCellStyle.Format = "N0";

        }

        public class GetData
        {
            public static string idBill = "";
            public static string masp = "";
            public static int choose = 0;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        
        int page = 0;
        string nhomsp = "", hangsp = "";
        float d = 0;
        int pagestart = 1, pageLast = 1;
        Button btnNSP, btnHSP;

        void load_PhanTrang()
        {
            
            if (cbbPage.SelectedItem.ToString() == "ALL")
            {
                lbPageMax.Text = "/1";
            }
            else
            {
                if (txtData.Text == "")
                {
                    var sp = from u in db.sanPhams select u;
                    if (sp == null)
                        return;
                    else
                    {
                        if (nhomsp == "" && hangsp == "")
                        {
                            int test = Convert.ToInt32(sp.Count()) % Convert.ToInt32(cbbPage.SelectedItem);
                            if (test == 0)
                                d = Convert.ToInt32(sp.Count()) / Convert.ToInt32(cbbPage.SelectedItem);
                            else
                                d = (Convert.ToInt32(sp.Count()) / Convert.ToInt32(cbbPage.SelectedItem)) + 1;
                            lbPageMax.Text = "/" + d;
                        }
                        else if (nhomsp != "" && hangsp == "")
                        {
                            int test = Convert.ToInt32(db.select_SP().Where(s => s.tenLoai.Equals(nhomsp)).Count()) % Convert.ToInt32(cbbPage.SelectedItem);
                            if (test == 0)
                                d = Convert.ToInt32(db.select_SP().Where(s => s.tenLoai.Equals(nhomsp)).Count()) / Convert.ToInt32(cbbPage.SelectedItem);
                            else
                                d = (Convert.ToInt32(db.select_SP().Where(s => s.tenLoai.Equals(nhomsp)).Count()) / Convert.ToInt32(cbbPage.SelectedItem)) + 1;
                            lbPageMax.Text = "/" + d;
                        }
                        else if (nhomsp != "" && hangsp != "")
                        {
                            int test = Convert.ToInt32(db.select_SP().Where(s => s.tenLoai.Equals(nhomsp) && s.tenHang.Equals(hangsp)).Count()) % Convert.ToInt32(cbbPage.SelectedItem);
                            if (test == 0)
                                d = Convert.ToInt32(db.select_SP().Where(s => s.tenLoai.Equals(nhomsp) && s.tenHang.Equals(hangsp)).Count()) / Convert.ToInt32(cbbPage.SelectedItem);
                            else
                                d = (Convert.ToInt32(db.select_SP().Where(s => s.tenLoai.Equals(nhomsp) && s.tenHang.Equals(hangsp)).Count()) / Convert.ToInt32(cbbPage.SelectedItem)) + 1;
                            lbPageMax.Text = "/" + d;
                        }
                    }
                }
                else if (txtData.Text != "")
                {
                    var sp = from u in db.SP_Find_Data(txtData.Text) select u;
                    if (sp == null)
                        return;
                    else
                    {
                        int dong = db.SP_Find_Data(txtData.Text).Count();
                        if (nhomsp == "" && hangsp == "")
                        {
                            int test = dong % Convert.ToInt32(cbbPage.SelectedItem);
                            if (test == 0)
                                d = dong / Convert.ToInt32(cbbPage.SelectedItem);
                            else
                                d = (dong / Convert.ToInt32(cbbPage.SelectedItem)) + 1;
                            lbPageMax.Text = "/" + d;
                        }
                        else if (nhomsp != "" && hangsp == "")
                        {
                            int test = Convert.ToInt32(db.SP_Find_Data(txtData.Text).Where(s => s.tenLoai.Equals(nhomsp)).Count()) % Convert.ToInt32(cbbPage.SelectedItem);
                            if (test == 0)
                                d = Convert.ToInt32(db.SP_Find_Data(txtData.Text).Where(s => s.tenLoai.Equals(nhomsp)).Count()) / Convert.ToInt32(cbbPage.SelectedItem);
                            else
                                d = (Convert.ToInt32(db.SP_Find_Data(txtData.Text).Where(s => s.tenLoai.Equals(nhomsp)).Count()) / Convert.ToInt32(cbbPage.SelectedItem)) + 1;
                            lbPageMax.Text = "/" + d;
                        }
                        else if (nhomsp != "" && hangsp != "")
                        {
                            int test = Convert.ToInt32(db.SP_Find_Data(txtData.Text).Where(s => s.tenLoai.Equals(nhomsp) && s.tenHang.Equals(hangsp)).Count()) % Convert.ToInt32(cbbPage.SelectedItem);
                            if (test == 0)
                                d = Convert.ToInt32(db.SP_Find_Data(txtData.Text).Where(s => s.tenLoai.Equals(nhomsp) && s.tenHang.Equals(hangsp)).Count()) / Convert.ToInt32(cbbPage.SelectedItem);
                            else
                                d = (Convert.ToInt32(db.SP_Find_Data(txtData.Text).Where(s => s.tenLoai.Equals(nhomsp) && s.tenHang.Equals(hangsp)).Count()) / Convert.ToInt32(cbbPage.SelectedItem)) + 1;
                            lbPageMax.Text = "/" + d;
                        }
                    }
                    
                    //if (db.SP_Find_Data(txtData.Text).Count() > 0)
                    //{
                    //    int test = Convert.ToInt32(dong) % Convert.ToInt32(cbbPage.SelectedItem);
                    //    if (test == 0)
                    //    {
                    //        d = Convert.ToInt32(dong) / Convert.ToInt32(cbbPage.SelectedItem);
                    //    }

                    //    else
                    //    {
                    //        d = (Convert.ToInt32(dong) / Convert.ToInt32(cbbPage.SelectedItem)) + 1;
                    //    }

                    //    lbPageMax.Text = "/" + d;
                    //}
                }
            }
            this.dgvProduct.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvProduct_RowPrePaint);
            //foreach (DataGridViewRow row in dgvProduct.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells[3].Value.ToString()) == 0)
            //        dgvProduct.Rows[row.Index].DefaultCellStyle.BackColor = Color.Red;
            //    else if (Convert.ToInt32(row.Cells[3].Value.ToString()) <= 10)
            //        dgvProduct.Rows[row.Index].DefaultCellStyle.BackColor = Color.Yellow;
            //}
        }

        private void dgvProduct_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[3].Value) == 0)
            {
                dgvProduct.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[3].Value) < 10)
            {
                dgvProduct.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Orange;
            }
        }
        void Uc_SP_Filter(string nhom, string hang, int c)
        {
            if (nhom != "" && hang == "")
            {
                if (cbbPage.SelectedItem.ToString() == "ALL")
                {
                    dgvProduct.AutoGenerateColumns = false;
                    lbPageMax.Text = "/1";
                    if (txtData.Text == "")
                    {
                        dgvProduct.DataSource = db.SP_Page_Find_NSP(1, db.select_SP().Where(s => s.tenLoai.Equals(nhom)).Count()
                            //Convert.ToInt32(cbbPage.SelectedItem.ToString())
                            , nhom);
                            //.Where(s => s.tenLoai.Equals(nhom));
                    }
                    else
                    {
                        dgvProduct.DataSource = db.SP_Page_Find_NSP_Name(1, db.select_SP().Where(s => s.tenLoai.Equals(nhom)).Count()
                            //Convert.ToInt32(cbbPage.SelectedItem.ToString())
                            , nhom, txtData.Text)
                            //.Where(s => s.tenSP.Equals(txtData.Text));
                            ;
                    }
                }
                else
                {
                    if (txtData.Text == "")
                    {
                        pagestart = (c - 1) * Convert.ToInt32(cbbPage.Text);
                        pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                        load_PhanTrang();
                        lbPageMax.Text = "/" + d;
                        dgvProduct.AutoGenerateColumns = false;
                        dgvProduct.DataSource = db.SP_Page_Find_NSP(pagestart, pageLast, nhom)
                            //.Where(s => s.tenLoai.Equals(nhom));
                            ;
                    }
                    else
                    {
                        pagestart = (c - 1) * Convert.ToInt32(cbbPage.Text);
                        pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                        load_PhanTrang();
                        lbPageMax.Text = "/" + d;
                        dgvProduct.AutoGenerateColumns = false;
                        dgvProduct.DataSource = db.SP_Page_Find_NSP_Name(pagestart, pageLast, nhom, txtData.Text)
                            //.Where(s=>s.tenSP.Equals(txtData.Text))
                            ;
                    }
                }
            }
            else if (nhom != "" & hang != "")
            {
                if (cbbPage.SelectedItem.ToString() == "ALL")
                {
                    dgvProduct.AutoGenerateColumns = false;
                    lbPageMax.Text = "/1";
                    if (txtData.Text == "")
                    {
                        dgvProduct.DataSource = db.SP_Page_Find_NSP_HSP(1, db.select_SP().Where(s => s.tenLoai.Equals(nhom) && s.tenHang.Equals(hang)).Count()
                            //Convert.ToInt32(cbbPage.SelectedItem.ToString())
                            , nhom, hang);
                        //.Where(s => s.tenLoai.Equals(nhom));
                    }
                    else
                    {
                        dgvProduct.DataSource = db.SP_Page_Find_NSP_HSP(1, db.select_SP().Where(s => s.tenLoai.Equals(nhom) && s.tenHang.Equals(hang)).Count()
                            , nhom, hang)
                            .Where(s => s.tenSP.Equals(txtData.Text));
                    }
                }
                else
                {
                    if (txtData.Text == "")
                    {
                        pagestart = (c - 1) * Convert.ToInt32(cbbPage.Text);
                        pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                        load_PhanTrang();
                        lbPageMax.Text = "/" + d;
                        dgvProduct.AutoGenerateColumns = false;
                        dgvProduct.DataSource = db.SP_Page_Find_NSP_HSP(pagestart, pageLast, nhom, hang)
                            //.Where(s => s.tenLoai.Equals(nhom));
                            ;
                    }
                    else
                    {
                        pagestart = (c - 1) * Convert.ToInt32(cbbPage.Text);
                        pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                        load_PhanTrang();
                        lbPageMax.Text = "/" + d;
                        dgvProduct.AutoGenerateColumns = false;
                        dgvProduct.DataSource = db.SP_Page_Find_NSP_HSP_Name(pagestart, pageLast, nhom, hang, txtData.Text)
                            //.Where(s=>s.tenSP.Equals(txtData.Text))
                            ;
                    }
                }
                //if (cbbPage.SelectedItem.ToString() == "ALL")
                //{
                //    dgvProduct.AutoGenerateColumns = false;
                //    lbPageMax.Text = "/1";
                //    if (txtData.Text == "")
                //    {
                //        dgvProduct.DataSource = db.SP_Page_Find_NSP_HSP(1, db.select_SP().Where(s => s.tenLoai.Equals(nhom) && s.tenHang.Equals(hang)).Count(),
                //            nhom, hang
                            
                //            //.Where(s => s.tenLoai.Equals(nhom) && s.tenHang.Equals(hang)
                            
                //            );
                //    }
                //    else
                //    {
                //        dgvProduct.DataSource = db.SP_Page_Find_NSP_HSP(1, db.select_SP().Where(s => s.tenLoai.Equals(nhom) && s.tenHang.Equals(hang)).Count(),
                //            nhom, hang
                //            //txtData.Text)
                //            //.Where(s => s.tenLoai.Equals(nhom) && s.tenHang.Equals(hang)
                //            );
                //    }
                //}
                //else
                //{
                //    if (txtData.Text == "")
                //    {
                //        pagestart = (c - 1) * Convert.ToInt32(cbbPage.Text);
                //        pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                //        load_PhanTrang();
                //        lbPageMax.Text = "/" + d;
                //        dgvProduct.AutoGenerateColumns = false;
                //        dgvProduct.DataSource = db.SP_Page_Find_NSP_HSP(pagestart, pageLast, nhom, hang);//.Where(s => s.tenLoai.Equals(nhom) && s.tenHang.Equals(hang));
                //    }
                //    else
                //    {
                //        pagestart = (c - 1) * Convert.ToInt32(cbbPage.Text);
                //        pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                //        load_PhanTrang();
                //        lbPageMax.Text = "/" + d;
                //        dgvProduct.AutoGenerateColumns = false;
                //        dgvProduct.DataSource = db.SP_Page_Find_NSP_HSP(pagestart, pageLast, nhom, hang).Where(s => s.tenSP.Equals(txtData.Text));
                //    }
                //}
            }
        }
        void Uc_SP_Load(int c)
        {
            fpnlGroupSP.Controls.Clear();
            foreach (var item in db.nhomSPs)
            {
                btnNSP = new Button();
                btnNSP.Height = 33;
                btnNSP.Width = 120;
                btnNSP.Text = item.tenLoai;
                btnNSP.BackColor = Color.FromArgb(35, 165, 178);
                fpnlGroupSP.Controls.Add(btnNSP);
                btnNSP.Click += btn_Click;
            }
            var nsp = from u in db.nhomSPs select u;
            var hsp = from u in db.HangSPs select u;

            if (cbbPage.SelectedItem.ToString() == "ALL")
            {
                dgvProduct.AutoGenerateColumns = false;
                lbPageMax.Text = "/1";
                if (txtData.Text == "")
                {
                    dgvProduct.DataSource = db.SP_Page(1, db.sanPhams.Count());
                }
                else
                {
                    dgvProduct.DataSource = db.SP_Page(1, db.sanPhams.Count()).Where(s=>s.tenSP.Equals(txtData.Text));
                }
            }
            else
            {
                if (txtData.Text == "")
                {
                    pagestart = (c - 1) * Convert.ToInt32(cbbPage.Text);
                    pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                    load_PhanTrang();
                    lbPageMax.Text = "/" + d;
                    dgvProduct.AutoGenerateColumns = false;
                    dgvProduct.DataSource = db.SP_Page(pagestart, pageLast);
                }
                else
                {
                    pagestart = (c - 1) * Convert.ToInt32(cbbPage.Text);
                    pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                    load_PhanTrang();
                    lbPageMax.Text = "/" + d;
                    dgvProduct.AutoGenerateColumns = false;
                    dgvProduct.DataSource = db.SP_Find(pagestart, pageLast,txtData.Text);
                }
                
            }
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtData.Text = "";
            hangsp = "";
            Button button = sender as Button;
            
            nhomsp = button.Text;
            Uc_SP_Filter(nhomsp, "", Convert.ToInt32(txtPage.Text));

            var hsp =db.Hang_in_Group(nhomsp);
            fpnlBranfOfGroup.Controls.Clear();
            foreach (var item in hsp)
            {
                btnHSP = new Button();
                btnHSP.Height = 33;
                btnHSP.Width = 120;
                btnHSP.Text = item.tenHang;
                fpnlBranfOfGroup.Controls.Add(btnHSP);
                btnHSP.Click += btnHSP_Click;
            }
            fpnlBranfOfGroup.Location = new Point(button.Location.X, 40);
        }

        private void btnHSP_Click(object sender, EventArgs e)
        {
            txtData.Text = "";
            Button button = sender as Button;
            hangsp = button.Text;
            Uc_SP_Filter(nhomsp, hangsp, Convert.ToInt32(txtPage.Text));
        }

        private void Uc_SanPham_Load(object sender, EventArgs e)
        {
            GetData.idBill = "";
            //var nsp = from u in db.nhomSPs select u;

            //var hsp = from u in db.HangSPs select u;

            //cbbType.Text = "";
            //txtTenSP.Text = "";
            //txtGia.Text = "";


            //cbbType.DisplayMember = "tenLoai";
            //cbbType.ValueMember = "maLoai";
            //cbbType.DataSource = nsp;

            //cbbBrand.DisplayMember = "tenHang";
            //cbbBrand.ValueMember = "maHang";
            //cbbBrand.DataSource = hsp;

            //dgvProduct.AutoGenerateColumns = false;
            //dgvProduct.DataSource = db.SP_Page(1, 50);

            //txtMaSP.Enabled = false;
        }

        

       
        int i = 0;
        
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                GetData.masp = dgvProduct.Rows[i].Cells[0].Value.ToString();
            }

        }

        
        private void lbFirst_Click(object sender, EventArgs e)
        {
            txtPage.Text = "1";
            if (nhomsp==""&& hangsp == "")
                Uc_SP_Load(1);
            else if (nhomsp != "" && hangsp == "")
                Uc_SP_Filter(nhomsp, "", 1);
            else if (nhomsp != "" && hangsp != "")
                Uc_SP_Filter(nhomsp, hangsp, 1);
        }

        private void cbbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPage.SelectedItem.ToString() == "ALL")
            {
                lbFirst.Enabled = false;
                lbNext.Enabled = false;
                lbPrevious.Enabled = false;
                lbLast.Enabled = false;
                txtPage.Enabled = false;
                
            }
            else
            {
                lbFirst.Enabled = true;
                lbNext.Enabled = true;
                lbPrevious.Enabled = true;
                lbLast.Enabled = true;
                txtPage.Enabled = true;
                
            }
            if (nhomsp == "" && hangsp == "")
                Uc_SP_Load(Convert.ToInt32(txtPage.Text));
            else if (nhomsp != "" && hangsp == "")
                Uc_SP_Filter(nhomsp, "", Convert.ToInt32(txtPage.Text));
            else if (nhomsp != "" && hangsp != "")
                Uc_SP_Filter(nhomsp, hangsp, Convert.ToInt32(txtPage.Text));
            //Uc_SP_Load(Convert.ToInt32(txtPage.Text));
        }

        private void lbPrevious_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPage.Text) <= 1)
                return;
            else
            {
                lbNext.Enabled = true;
                txtPage.Text = (Convert.ToInt32(txtPage.Text) - 1).ToString();
                if (nhomsp == "" && hangsp == "")
                    Uc_SP_Load(Convert.ToInt32(txtPage.Text));
                else if (nhomsp != "" && hangsp == "")
                    Uc_SP_Filter(nhomsp, "", Convert.ToInt32(txtPage.Text));
                else if (nhomsp != "" && hangsp != "")
                    Uc_SP_Filter(nhomsp, hangsp, Convert.ToInt32(txtPage.Text));
                //Uc_SP_Load(Convert.ToInt32(txtPage.Text));
            }
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string nhom = nhomsp, hang = hangsp;
            if(cbbTTSP.SelectedItem.ToString() == "Sắp hết")
            {
                if (nhom == "" && hang == "")
                {
                    if (cbbPage.SelectedItem.ToString() == "ALL")
                    {
                        dgvProduct.AutoGenerateColumns = false;
                        lbPageMax.Text = "/1";

                        dgvProduct.DataSource = db.SP_Page_Filter_Amount(1, db.select_SP().Where(s=>s.soLuong<10).Count()
                            //Convert.ToInt32(cbbPage.SelectedItem.ToString())
                            );

                        //.Where(s => s.tenLoai.Equals(nhom));

                    }
                    else
                    {
                        pagestart = ((Convert.ToInt32(txtPage.Text)) - 1) * Convert.ToInt32(cbbPage.Text);
                        pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                        load_PhanTrang();
                        lbPageMax.Text = "/" + d;
                        dgvProduct.AutoGenerateColumns = false;
                        dgvProduct.DataSource = db.SP_Page_Filter_Amount(pagestart, pageLast);

                    }
                }
                else if (nhom != "" && hang == "")
                {
                    if (cbbPage.SelectedItem.ToString() == "ALL")
                    {
                        dgvProduct.AutoGenerateColumns = false;
                        lbPageMax.Text = "/1";
                        
                            dgvProduct.DataSource = db.SP_Page_Filter_NSP_Amount(1, db.select_SP().Where(s => s.tenLoai.Equals(nhom)).Count()
                                //Convert.ToInt32(cbbPage.SelectedItem.ToString())
                                , nhom);
                                                    
                            //.Where(s => s.tenLoai.Equals(nhom));
                        
                    }
                    else
                    {
                        
                            pagestart = ((Convert.ToInt32(txtPage.Text)) - 1) * Convert.ToInt32(cbbPage.Text);
                            pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                            load_PhanTrang();
                            lbPageMax.Text = "/" + d;
                            dgvProduct.AutoGenerateColumns = false;
                            dgvProduct.DataSource =db.SP_Page_Filter_NSP_Amount(pagestart, pageLast, nhom);
                        
                    }
                }
                else if (nhom != "" & hang != "")
                {
                    if (cbbPage.SelectedItem.ToString() == "ALL")
                    {
                        dgvProduct.AutoGenerateColumns = false;
                        lbPageMax.Text = "/1";

                        dgvProduct.DataSource = db.SP_Page_Filter_NSP_HSP_Amount(1, db.select_SP().Where(s => s.tenLoai.Equals(nhom) && s.tenHang.Equals(hang)).Count()

                            , nhom, hang);


                    }
                    else
                    {

                        pagestart = ((Convert.ToInt32(txtPage.Text)) - 1) * Convert.ToInt32(cbbPage.Text);
                        pageLast = pagestart + Convert.ToInt32(cbbPage.Text);
                        load_PhanTrang();
                        lbPageMax.Text = "/" + d;
                        dgvProduct.AutoGenerateColumns = false;
                        dgvProduct.DataSource = db.SP_Page_Filter_NSP_HSP_Amount(pagestart, pageLast, nhom, hang);
                    }
                    
                }
            
            
            }
        }

        private void btnBill_Import_Click(object sender, EventArgs e)
        {
            btnBill_Import.Enabled = false;
            Uc_Bill_Buy.GetData.trThai = "Unpaid";
            btnSeeBill.Visible = true;
            //btnAddProduct.Visible = false;
            ////btnImport.Visible = false;
            //btnBillImport.Enabled = false;

            //btnCancel.Visible = true;
            DateTime d = DateTime.Now;
            var hdn = db.hoadDonNhaps;
            if (hdn.Count() == 0)
            {
                GetData.idBill = "HDN000001";
                frmChooseProvider chooseProvider = new frmChooseProvider();
                chooseProvider.ShowDialog();
                if (frmChooseProvider.GetData.idNCC != "")
                {
                    db.HDN_Ins("HDN000001", frmLogin.GetID.id, frmChooseProvider.GetData.idNCC, d, 0, "Unpaid","");
                }
            }
            else
            {
                var pn = db.hoadDonNhaps.OrderByDescending(s => s.maHDN).FirstOrDefault();
                int stt = Convert.ToInt32(pn.maHDN.Substring(3)) + 1;
                GetData.idBill = "";
                if (stt / 10 >= 100000)
                    GetData.idBill = "HDN" + stt;
                else if (stt / 10 >= 1000 && stt / 10 < 10000)
                    GetData.idBill = "HDN0" + stt;
                else if (stt / 10 >= 100 && stt / 10 < 1000)
                    GetData.idBill = "HDN00" + stt;
                else if (stt / 10 >= 10 && stt / 10 < 100)
                    GetData.idBill = "HDN000" + stt;
                else if (stt / 10 >= 1 && stt / 10 < 10)
                    GetData.idBill = "HDN0000" + stt;
                else if (stt / 10 < 1)
                    GetData.idBill = "HDN00000" + stt;
                frmChooseProvider chooseProvider = new frmChooseProvider();
                chooseProvider.ShowDialog();
                if (frmChooseProvider.GetData.idNCC != "")
                {
                    db.HDN_Ins(GetData.idBill, frmLogin.GetID.id, frmChooseProvider.GetData.idNCC, d, 0, "Unpaid","");
                }
            }
        }

        private void btnCanCle_Click(object sender, EventArgs e)
        {
            
            btnBill_Import.Enabled = true;
            btnSeeBill.Visible = false;
            btnCanCle.Visible = false;
            db.HDN_Del(GetData.idBill);
            GetData.idBill = "";
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvProduct.Columns[e.ColumnIndex].Name.Equals("ct"))
                {
                    if (GetData.idBill == "")
                        MessageBox.Show("Must create a Import bill yet");
                    else
                    {
                        chiTietHDN cthdn = db.chiTietHDNs.
                        Where(s => s.maHDN.Equals(GetData.idBill)
                                && s.maSP.Equals(GetData.masp))
                        .FirstOrDefault();
                        if (cthdn != null)
                        {
                            MessageBox.Show("Already have this product in this bill");
                        }
                        else
                        {
                            frmAmount amount = new frmAmount();
                            amount.ShowDialog();
                            db.CTHDN_Ins(GetData.idBill, GetData.masp, frmAmount.GetData.gia, frmAmount.GetData.sL, 0);
                            Uc_SP_Load(1);
                        }
                    }
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name.Equals("Column6"))
                {
                    frmProduct product = new frmProduct();
                    GetData.choose = 2;
                    product.ShowDialog();
                    Uc_SP_Load(Convert.ToInt32(txtPage.Text));
                }
                
            }
        }

        private void btnSeeBill_Click(object sender, EventArgs e)
        {
            frmDetail_Import_Bill frmDetail_Import_Bill = new frmDetail_Import_Bill();
            frmDetail_Import_Bill.ShowDialog();
            Uc_SP_Load(Convert.ToInt32(txtPage.Text));
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            GetData.choose = 1;
            product.ShowDialog();
            Uc_SP_Load(Convert.ToInt32(txtPage.Text));
        }

        private void lbLast_Click(object sender, EventArgs e)
        {
            txtPage.Text = lbPageMax.Text.Substring(1);
            if (nhomsp == "" && hangsp == "")
                Uc_SP_Load(Convert.ToInt32(txtPage.Text));
            else if (nhomsp != "" && hangsp == "")
                Uc_SP_Filter(nhomsp, "", Convert.ToInt32(txtPage.Text));
            else if (nhomsp != "" && hangsp != "")
                Uc_SP_Filter(nhomsp, hangsp, Convert.ToInt32(txtPage.Text));
            //Uc_SP_Load(Convert.ToInt32(txtPage.Text));
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            if (txtPage.Text != "")
            {
                if (Convert.ToInt32(txtPage.Text) <= 1)
                {
                    lbPrevious.Enabled = false;
                    lbNext.Enabled = true;
                }
                    
                else if (Convert.ToInt32(txtPage.Text) >= (Convert.ToInt32(lbPageMax.Text.Substring(1))))
                {
                    lbPrevious.Enabled = true;
                    lbNext.Enabled = false;
                }
                    
                else
                {
                    lbNext.Enabled = true;
                    lbPrevious.Enabled = true;
                }
                Uc_SP_Load(Convert.ToInt32(txtPage.Text));
            }
                
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (nhomsp == "" && hangsp == "")
                Uc_SP_Load(Convert.ToInt32(txtPage.Text));
            else if (nhomsp != "" && hangsp == "")
                Uc_SP_Filter(nhomsp, "", Convert.ToInt32(txtPage.Text));
            else if (nhomsp != "" && hangsp != "")
                Uc_SP_Filter(nhomsp, hangsp, Convert.ToInt32(txtPage.Text));
            //Uc_SP_Load(Convert.ToInt32(txtPage.Text));
        }

        private void lbNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPage.Text) >= (Convert.ToInt32(lbPageMax.Text.Substring(1))))
                return;
            else
            {
                lbPrevious.Enabled = true;
                txtPage.Text = (Convert.ToInt32(txtPage.Text) + 1).ToString();
                if (nhomsp == "" && hangsp == "")
                    Uc_SP_Load(Convert.ToInt32(txtPage.Text));
                else if (nhomsp != "" && hangsp == "")
                    Uc_SP_Filter(nhomsp, "", Convert.ToInt32(txtPage.Text));
                else if (nhomsp != "" && hangsp != "")
                    Uc_SP_Filter(nhomsp, hangsp, Convert.ToInt32(txtPage.Text));
                //Uc_SP_Load(Convert.ToInt32(txtPage.Text));
            }
        }
    }
}
