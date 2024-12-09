using System.Windows.Forms;

namespace HeThongQuanLyVanBanCongVan
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0xA1; // Sự kiện nhấn chuột trái trên non-client area
            const int HTCAPTION = 0x2;        // Khu vực tiêu đề của form

            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
            {
                return; // Ngăn không cho xử lý sự kiện di chuyển form
            }

            base.WndProc(ref m); // Xử lý các thông điệp khác bình thường
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPageVanBanNoiBo = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPagePhongBan = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.XuatExcel = new System.Windows.Forms.PictureBox();
            this.picLuu = new System.Windows.Forms.PictureBox();
            this.picXoa = new System.Windows.Forms.PictureBox();
            this.picThemPhongBan = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewPhongBan = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VBNoiBotabPage = new System.Windows.Forms.TabPage();
            this.btnXoaFile = new System.Windows.Forms.Button();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnDinhKem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNguoiDuyet = new System.Windows.Forms.TextBox();
            this.txtNguoiKy = new System.Windows.Forms.TextBox();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LuuVBNB = new System.Windows.Forms.PictureBox();
            this.ThemVBNB = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridViewTaiLieu = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTrichYeu = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateNgayBanHanh = new System.Windows.Forms.DateTimePicker();
            this.cmbPhongBanNhan = new System.Windows.Forms.ComboBox();
            this.cmbPhongBanHanh = new System.Windows.Forms.ComboBox();
            this.cmbLoaiBanHanh = new System.Windows.Forms.ComboBox();
            this.txtTenVanBan = new System.Windows.Forms.TextBox();
            this.txtSoKyHieu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageDSVBNoiBo = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnXoaVBNB = new System.Windows.Forms.PictureBox();
            this.btnSuaVBNB = new System.Windows.Forms.PictureBox();
            this.btnThemVBNB = new System.Windows.Forms.PictureBox();
            this.dataGridViewVBNB = new System.Windows.Forms.DataGridView();
            this.tabPageTimKiem = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label57 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label54 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button37 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label56 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label55 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.button33 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dataGridViewVBNB1 = new System.Windows.Forms.DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInbaocao = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.ThoiGianTimKiem = new System.Windows.Forms.ComboBox();
            this.nhapTrichYeu = new System.Windows.Forms.RichTextBox();
            this.nhapTenVanBan = new System.Windows.Forms.TextBox();
            this.nhapSoKyHieu = new System.Windows.Forms.TextBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ChonCmbPhongBanNhan = new System.Windows.Forms.ComboBox();
            this.chonCmbPhongBanHanh = new System.Windows.Forms.ComboBox();
            this.chonCmbLoaiBanHanh = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTimKiemThongKe = new System.Windows.Forms.Button();
            this.btnQuanLyVbNoiBo = new System.Windows.Forms.Button();
            this.btnQuanLyVanBan = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đăngNhậpLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaThôngTinNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPageVanBanNoiBo.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPagePhongBan.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XuatExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThemPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).BeginInit();
            this.VBNoiBotabPage.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuuVBNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemVBNB)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiLieu)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPageDSVBNoiBo.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaVBNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSuaVBNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemVBNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVBNB)).BeginInit();
            this.tabPageTimKiem.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel16.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel15.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVBNB1)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1051);
            this.panel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPageVanBanNoiBo);
            this.tabControl2.Controls.Add(this.tabPageTimKiem);
            this.tabControl2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(410, 47);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1920, 1056);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel14);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.ForeColor = System.Drawing.Color.LightCyan;
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1912, 1018);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Trang chủ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.LightCyan;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.pictureBox31);
            this.panel14.Controls.Add(this.pictureBox30);
            this.panel14.Controls.Add(this.pictureBox29);
            this.panel14.Controls.Add(this.pictureBox28);
            this.panel14.Controls.Add(this.pictureBox27);
            this.panel14.Controls.Add(this.pictureBox26);
            this.panel14.Controls.Add(this.pictureBox25);
            this.panel14.Controls.Add(this.pictureBox24);
            this.panel14.Controls.Add(this.pictureBox23);
            this.panel14.Controls.Add(this.button32);
            this.panel14.Controls.Add(this.button31);
            this.panel14.Controls.Add(this.button30);
            this.panel14.Controls.Add(this.button29);
            this.panel14.Controls.Add(this.button28);
            this.panel14.Controls.Add(this.button27);
            this.panel14.Controls.Add(this.label35);
            this.panel14.Location = new System.Drawing.Point(811, 6);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(811, 884);
            this.panel14.TabIndex = 2;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
            this.pictureBox31.Location = new System.Drawing.Point(117, 383);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(523, 25);
            this.pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox31.TabIndex = 25;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
            this.pictureBox30.Location = new System.Drawing.Point(388, 347);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(32, 37);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 29;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
            this.pictureBox29.Location = new System.Drawing.Point(92, 212);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(590, 25);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox29.TabIndex = 28;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(608, 162);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(32, 63);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 27;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(388, 162);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(32, 63);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 26;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(130, 162);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(32, 63);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 25;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(565, 404);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(32, 37);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 19;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(143, 399);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(32, 37);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 18;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(388, 231);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(32, 37);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 17;
            this.pictureBox23.TabStop = false;
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.ForeColor = System.Drawing.Color.Navy;
            this.button32.Location = new System.Drawing.Point(431, 438);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(263, 76);
            this.button32.TabIndex = 16;
            this.button32.Text = "Tìm kiếm thống kê";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.Color.Navy;
            this.button31.Location = new System.Drawing.Point(23, 438);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(263, 76);
            this.button31.TabIndex = 15;
            this.button31.Text = "Danh sách văn bản nội bộ";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ForeColor = System.Drawing.Color.Navy;
            this.button30.Location = new System.Drawing.Point(280, 274);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(221, 74);
            this.button30.TabIndex = 14;
            this.button30.Text = "Văn bản nội bộ";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.Color.Navy;
            this.button29.Location = new System.Drawing.Point(534, 82);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(181, 79);
            this.button29.TabIndex = 13;
            this.button29.Text = "Phòng ban nhận";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.Color.Navy;
            this.button28.Location = new System.Drawing.Point(280, 82);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(221, 76);
            this.button28.TabIndex = 12;
            this.button28.Text = "Phòng ban hành";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.Color.Navy;
            this.button27.Location = new System.Drawing.Point(35, 82);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(214, 76);
            this.button27.TabIndex = 11;
            this.button27.Text = "Loại văn bản";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Navy;
            this.label35.Location = new System.Drawing.Point(185, 26);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(439, 31);
            this.label35.TabIndex = 1;
            this.label35.Text = "QUY TRÌNH QUẢN LÝ VĂN BẢN NỘI BỘ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox22);
            this.panel4.Controls.Add(this.pictureBox21);
            this.panel4.Controls.Add(this.pictureBox20);
            this.panel4.Controls.Add(this.pictureBox19);
            this.panel4.Controls.Add(this.pictureBox18);
            this.panel4.Controls.Add(this.pictureBox17);
            this.panel4.Controls.Add(this.pictureBox16);
            this.panel4.Controls.Add(this.pictureBox15);
            this.panel4.Controls.Add(this.pictureBox14);
            this.panel4.Controls.Add(this.pictureBox13);
            this.panel4.Controls.Add(this.pictureBox12);
            this.panel4.Controls.Add(this.pictureBox11);
            this.panel4.Controls.Add(this.pictureBox10);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.button26);
            this.panel4.Controls.Add(this.button25);
            this.panel4.Controls.Add(this.button24);
            this.panel4.Controls.Add(this.button23);
            this.panel4.Controls.Add(this.button21);
            this.panel4.Controls.Add(this.button22);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 887);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(126, 679);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(485, 25);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(350, 636);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(32, 37);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 23;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(547, 399);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(32, 37);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 22;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(350, 399);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(32, 37);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 21;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(126, 399);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(32, 37);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 20;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(350, 221);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(32, 37);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 19;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(99, 379);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(512, 25);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 18;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(126, 200);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(469, 25);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 17;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(547, 697);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(32, 37);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 16;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(143, 697);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(32, 37);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 15;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(350, 517);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(32, 37);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 14;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(350, 347);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 37);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(532, 166);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 37);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(143, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.Color.Navy;
            this.button26.Location = new System.Drawing.Point(414, 740);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(273, 84);
            this.button26.TabIndex = 10;
            this.button26.Text = "Tìm kiếm thống kê";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.Navy;
            this.button25.Location = new System.Drawing.Point(20, 740);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(273, 78);
            this.button25.TabIndex = 9;
            this.button25.Text = "Danh sách văn bản đi";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.Color.Navy;
            this.button24.Location = new System.Drawing.Point(222, 557);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(273, 73);
            this.button24.TabIndex = 8;
            this.button24.Text = "Văn bản đi";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.Navy;
            this.button23.Location = new System.Drawing.Point(497, 438);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(181, 73);
            this.button23.TabIndex = 7;
            this.button23.Text = "Sổ văn bản";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.Navy;
            this.button21.Location = new System.Drawing.Point(283, 438);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(181, 73);
            this.button21.TabIndex = 6;
            this.button21.Text = "Nơi ban hành";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.Navy;
            this.button22.Location = new System.Drawing.Point(44, 438);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(181, 69);
            this.button22.TabIndex = 5;
            this.button22.Text = "Loại văn bản";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(222, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 77);
            this.button4.TabIndex = 3;
            this.button4.Text = "Văn bản đến";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(414, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 79);
            this.button3.TabIndex = 2;
            this.button3.Text = "Danh sách văn bản đi";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(44, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Danh sách văn bản đến";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Navy;
            this.label34.Location = new System.Drawing.Point(183, 26);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(436, 31);
            this.label34.TabIndex = 0;
            this.label34.Text = "QUY TRÌNH QUẢN LÝ VĂN BẢN ĐI ĐẾN";
            // 
            // tabPageVanBanNoiBo
            // 
            this.tabPageVanBanNoiBo.BackColor = System.Drawing.Color.Lavender;
            this.tabPageVanBanNoiBo.Controls.Add(this.tabControl3);
            this.tabPageVanBanNoiBo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageVanBanNoiBo.Location = new System.Drawing.Point(4, 34);
            this.tabPageVanBanNoiBo.Name = "tabPageVanBanNoiBo";
            this.tabPageVanBanNoiBo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVanBanNoiBo.Size = new System.Drawing.Size(1912, 1018);
            this.tabPageVanBanNoiBo.TabIndex = 1;
            this.tabPageVanBanNoiBo.Text = "Văn bản nội bộ";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPagePhongBan);
            this.tabControl3.Controls.Add(this.VBNoiBotabPage);
            this.tabControl3.Controls.Add(this.tabPageDSVBNoiBo);
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1920, 1056);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPagePhongBan
            // 
            this.tabPagePhongBan.Controls.Add(this.panel5);
            this.tabPagePhongBan.Controls.Add(this.label5);
            this.tabPagePhongBan.Controls.Add(this.dataGridViewPhongBan);
            this.tabPagePhongBan.Controls.Add(this.label4);
            this.tabPagePhongBan.Controls.Add(this.label3);
            this.tabPagePhongBan.Controls.Add(this.label2);
            this.tabPagePhongBan.Controls.Add(this.label1);
            this.tabPagePhongBan.Location = new System.Drawing.Point(4, 34);
            this.tabPagePhongBan.Name = "tabPagePhongBan";
            this.tabPagePhongBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhongBan.Size = new System.Drawing.Size(1912, 1018);
            this.tabPagePhongBan.TabIndex = 0;
            this.tabPagePhongBan.Text = "Phòng ban";
            this.tabPagePhongBan.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.Controls.Add(this.XuatExcel);
            this.panel5.Controls.Add(this.picLuu);
            this.panel5.Controls.Add(this.picXoa);
            this.panel5.Controls.Add(this.picThemPhongBan);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1578, 52);
            this.panel5.TabIndex = 6;
            // 
            // XuatExcel
            // 
            this.XuatExcel.BackColor = System.Drawing.Color.LightYellow;
            this.XuatExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("XuatExcel.Image")));
            this.XuatExcel.Location = new System.Drawing.Point(197, 3);
            this.XuatExcel.Name = "XuatExcel";
            this.XuatExcel.Size = new System.Drawing.Size(47, 46);
            this.XuatExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.XuatExcel.TabIndex = 8;
            this.XuatExcel.TabStop = false;
            this.XuatExcel.Click += new System.EventHandler(this.XuatExcel_Click);
            // 
            // picLuu
            // 
            this.picLuu.BackColor = System.Drawing.Color.LightYellow;
            this.picLuu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLuu.Image = ((System.Drawing.Image)(resources.GetObject("picLuu.Image")));
            this.picLuu.Location = new System.Drawing.Point(132, 3);
            this.picLuu.Name = "picLuu";
            this.picLuu.Size = new System.Drawing.Size(47, 46);
            this.picLuu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLuu.TabIndex = 7;
            this.picLuu.TabStop = false;
            this.picLuu.Click += new System.EventHandler(this.picLuu_Click);
            // 
            // picXoa
            // 
            this.picXoa.BackColor = System.Drawing.Color.LightYellow;
            this.picXoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picXoa.Image = ((System.Drawing.Image)(resources.GetObject("picXoa.Image")));
            this.picXoa.Location = new System.Drawing.Point(68, 3);
            this.picXoa.Name = "picXoa";
            this.picXoa.Size = new System.Drawing.Size(47, 46);
            this.picXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXoa.TabIndex = 2;
            this.picXoa.TabStop = false;
            this.picXoa.Click += new System.EventHandler(this.picXoa_Click);
            // 
            // picThemPhongBan
            // 
            this.picThemPhongBan.BackColor = System.Drawing.Color.LightYellow;
            this.picThemPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picThemPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("picThemPhongBan.Image")));
            this.picThemPhongBan.Location = new System.Drawing.Point(4, 3);
            this.picThemPhongBan.Name = "picThemPhongBan";
            this.picThemPhongBan.Size = new System.Drawing.Size(47, 46);
            this.picThemPhongBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThemPhongBan.TabIndex = 0;
            this.picThemPhongBan.TabStop = false;
            this.picThemPhongBan.Click += new System.EventHandler(this.picThemPhongBan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(66, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "BẢNG DỮ LIỆU PHÒNG BAN";
            // 
            // dataGridViewPhongBan
            // 
            this.dataGridViewPhongBan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhongBan.Location = new System.Drawing.Point(117, 294);
            this.dataGridViewPhongBan.Name = "dataGridViewPhongBan";
            this.dataGridViewPhongBan.RowHeadersWidth = 51;
            this.dataGridViewPhongBan.RowTemplate.Height = 24;
            this.dataGridViewPhongBan.Size = new System.Drawing.Size(1364, 476);
            this.dataGridViewPhongBan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orchid;
            this.label4.Location = new System.Drawing.Point(248, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(746, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phòng ban hành: Khởi tạo/gửi tài liệu, quyết định, thông tin nội bộ hoặc ra bên n" +
    "goài.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(249, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(735, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng ban nhận: Tiếp nhận tài liệu, thông tin hoặc công việc từ các phòng ban khá" +
    "c.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(125, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng ban có: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHÒNG BAN";
            // 
            // VBNoiBotabPage
            // 
            this.VBNoiBotabPage.Controls.Add(this.btnXoaFile);
            this.VBNoiBotabPage.Controls.Add(this.btnDocFile);
            this.VBNoiBotabPage.Controls.Add(this.btnDinhKem);
            this.VBNoiBotabPage.Controls.Add(this.button2);
            this.VBNoiBotabPage.Controls.Add(this.txtNguoiDuyet);
            this.VBNoiBotabPage.Controls.Add(this.txtNguoiKy);
            this.VBNoiBotabPage.Controls.Add(this.txtNguoiNhan);
            this.VBNoiBotabPage.Controls.Add(this.label17);
            this.VBNoiBotabPage.Controls.Add(this.label16);
            this.VBNoiBotabPage.Controls.Add(this.label15);
            this.VBNoiBotabPage.Controls.Add(this.panel9);
            this.VBNoiBotabPage.Controls.Add(this.panel8);
            this.VBNoiBotabPage.Controls.Add(this.panel7);
            this.VBNoiBotabPage.Controls.Add(this.panel6);
            this.VBNoiBotabPage.Controls.Add(this.dateNgayBanHanh);
            this.VBNoiBotabPage.Controls.Add(this.cmbPhongBanNhan);
            this.VBNoiBotabPage.Controls.Add(this.cmbPhongBanHanh);
            this.VBNoiBotabPage.Controls.Add(this.cmbLoaiBanHanh);
            this.VBNoiBotabPage.Controls.Add(this.txtTenVanBan);
            this.VBNoiBotabPage.Controls.Add(this.txtSoKyHieu);
            this.VBNoiBotabPage.Controls.Add(this.label11);
            this.VBNoiBotabPage.Controls.Add(this.label10);
            this.VBNoiBotabPage.Controls.Add(this.label9);
            this.VBNoiBotabPage.Controls.Add(this.label8);
            this.VBNoiBotabPage.Controls.Add(this.label7);
            this.VBNoiBotabPage.Controls.Add(this.label6);
            this.VBNoiBotabPage.Location = new System.Drawing.Point(4, 34);
            this.VBNoiBotabPage.Name = "VBNoiBotabPage";
            this.VBNoiBotabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VBNoiBotabPage.Size = new System.Drawing.Size(1912, 1018);
            this.VBNoiBotabPage.TabIndex = 1;
            this.VBNoiBotabPage.Text = "Văn bản nội bộ";
            this.VBNoiBotabPage.UseVisualStyleBackColor = true;
            // 
            // btnXoaFile
            // 
            this.btnXoaFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaFile.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnXoaFile.Location = new System.Drawing.Point(1308, 768);
            this.btnXoaFile.Name = "btnXoaFile";
            this.btnXoaFile.Size = new System.Drawing.Size(126, 35);
            this.btnXoaFile.TabIndex = 25;
            this.btnXoaFile.Text = "Xóa file";
            this.btnXoaFile.UseVisualStyleBackColor = true;
            this.btnXoaFile.Click += new System.EventHandler(this.btnXoaFile_Click);
            // 
            // btnDocFile
            // 
            this.btnDocFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnDocFile.Location = new System.Drawing.Point(1308, 706);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(126, 37);
            this.btnDocFile.TabIndex = 24;
            this.btnDocFile.Text = "Đọc file";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnDinhKem
            // 
            this.btnDinhKem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinhKem.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnDinhKem.Location = new System.Drawing.Point(1308, 649);
            this.btnDinhKem.Name = "btnDinhKem";
            this.btnDinhKem.Size = new System.Drawing.Size(126, 38);
            this.btnDinhKem.TabIndex = 23;
            this.btnDinhKem.Text = "Đính kèm";
            this.btnDinhKem.UseVisualStyleBackColor = true;
            this.btnDinhKem.Click += new System.EventHandler(this.btnDinhKem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1273, 781);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtNguoiDuyet
            // 
            this.txtNguoiDuyet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiDuyet.Location = new System.Drawing.Point(1265, 219);
            this.txtNguoiDuyet.Name = "txtNguoiDuyet";
            this.txtNguoiDuyet.Size = new System.Drawing.Size(228, 31);
            this.txtNguoiDuyet.TabIndex = 21;
            // 
            // txtNguoiKy
            // 
            this.txtNguoiKy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiKy.Location = new System.Drawing.Point(1265, 143);
            this.txtNguoiKy.Name = "txtNguoiKy";
            this.txtNguoiKy.Size = new System.Drawing.Size(228, 31);
            this.txtNguoiKy.TabIndex = 20;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiNhan.Location = new System.Drawing.Point(1265, 82);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(228, 31);
            this.txtNguoiNhan.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label17.Location = new System.Drawing.Point(1099, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 33);
            this.label17.TabIndex = 18;
            this.label17.Text = "Người duyệt";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label16.Location = new System.Drawing.Point(1099, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 35);
            this.label16.TabIndex = 17;
            this.label16.Text = "Người ký";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label15.Location = new System.Drawing.Point(1099, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 34);
            this.label15.TabIndex = 16;
            this.label15.Text = "Người nhận";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SeaShell;
            this.panel9.Controls.Add(this.LuuVBNB);
            this.panel9.Controls.Add(this.ThemVBNB);
            this.panel9.Location = new System.Drawing.Point(3, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1581, 50);
            this.panel9.TabIndex = 15;
            // 
            // LuuVBNB
            // 
            this.LuuVBNB.BackColor = System.Drawing.Color.LightYellow;
            this.LuuVBNB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LuuVBNB.Image = ((System.Drawing.Image)(resources.GetObject("LuuVBNB.Image")));
            this.LuuVBNB.Location = new System.Drawing.Point(63, 3);
            this.LuuVBNB.Name = "LuuVBNB";
            this.LuuVBNB.Size = new System.Drawing.Size(47, 44);
            this.LuuVBNB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LuuVBNB.TabIndex = 7;
            this.LuuVBNB.TabStop = false;
            this.LuuVBNB.Click += new System.EventHandler(this.LuuVBNB_Click);
            // 
            // ThemVBNB
            // 
            this.ThemVBNB.BackColor = System.Drawing.Color.LightYellow;
            this.ThemVBNB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemVBNB.Image = ((System.Drawing.Image)(resources.GetObject("ThemVBNB.Image")));
            this.ThemVBNB.Location = new System.Drawing.Point(4, 3);
            this.ThemVBNB.Name = "ThemVBNB";
            this.ThemVBNB.Size = new System.Drawing.Size(47, 47);
            this.ThemVBNB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThemVBNB.TabIndex = 0;
            this.ThemVBNB.TabStop = false;
            this.ThemVBNB.Click += new System.EventHandler(this.ThemVBNB_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.dataGridViewTaiLieu);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(66, 633);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1215, 201);
            this.panel8.TabIndex = 14;
            // 
            // dataGridViewTaiLieu
            // 
            this.dataGridViewTaiLieu.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewTaiLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaiLieu.Location = new System.Drawing.Point(16, 47);
            this.dataGridViewTaiLieu.Name = "dataGridViewTaiLieu";
            this.dataGridViewTaiLieu.RowHeadersWidth = 51;
            this.dataGridViewTaiLieu.RowTemplate.Height = 24;
            this.dataGridViewTaiLieu.Size = new System.Drawing.Size(1071, 134);
            this.dataGridViewTaiLieu.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(3, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 28);
            this.label14.TabIndex = 15;
            this.label14.Text = "Đính kèm file";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.txtNoiDung);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(66, 475);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1427, 137);
            this.panel7.TabIndex = 13;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(28, 35);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(1387, 85);
            this.txtNoiDung.TabIndex = 15;
            this.txtNoiDung.Text = "";
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(13, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 28);
            this.label13.TabIndex = 14;
            this.label13.Text = "Nội dung";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.txtTrichYeu);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(66, 307);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1427, 149);
            this.panel6.TabIndex = 12;
            this.panel6.Tag = "";
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.Location = new System.Drawing.Point(25, 37);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(1390, 92);
            this.txtTrichYeu.TabIndex = 14;
            this.txtTrichYeu.Text = "";
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(13, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 31);
            this.label12.TabIndex = 13;
            this.label12.Text = "Trích yếu";
            // 
            // dateNgayBanHanh
            // 
            this.dateNgayBanHanh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBanHanh.Location = new System.Drawing.Point(240, 219);
            this.dateNgayBanHanh.Name = "dateNgayBanHanh";
            this.dateNgayBanHanh.Size = new System.Drawing.Size(252, 31);
            this.dateNgayBanHanh.TabIndex = 11;
            // 
            // cmbPhongBanNhan
            // 
            this.cmbPhongBanNhan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhongBanNhan.FormattingEnabled = true;
            this.cmbPhongBanNhan.Location = new System.Drawing.Point(763, 214);
            this.cmbPhongBanNhan.Name = "cmbPhongBanNhan";
            this.cmbPhongBanNhan.Size = new System.Drawing.Size(260, 33);
            this.cmbPhongBanNhan.TabIndex = 10;
            // 
            // cmbPhongBanHanh
            // 
            this.cmbPhongBanHanh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhongBanHanh.FormattingEnabled = true;
            this.cmbPhongBanHanh.Location = new System.Drawing.Point(763, 145);
            this.cmbPhongBanHanh.Name = "cmbPhongBanHanh";
            this.cmbPhongBanHanh.Size = new System.Drawing.Size(260, 33);
            this.cmbPhongBanHanh.TabIndex = 9;
            // 
            // cmbLoaiBanHanh
            // 
            this.cmbLoaiBanHanh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiBanHanh.FormattingEnabled = true;
            this.cmbLoaiBanHanh.Location = new System.Drawing.Point(763, 86);
            this.cmbLoaiBanHanh.Name = "cmbLoaiBanHanh";
            this.cmbLoaiBanHanh.Size = new System.Drawing.Size(260, 33);
            this.cmbLoaiBanHanh.TabIndex = 8;
            // 
            // txtTenVanBan
            // 
            this.txtTenVanBan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVanBan.Location = new System.Drawing.Point(240, 143);
            this.txtTenVanBan.Name = "txtTenVanBan";
            this.txtTenVanBan.Size = new System.Drawing.Size(245, 31);
            this.txtTenVanBan.TabIndex = 7;
            // 
            // txtSoKyHieu
            // 
            this.txtSoKyHieu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoKyHieu.Location = new System.Drawing.Point(240, 82);
            this.txtSoKyHieu.Name = "txtSoKyHieu";
            this.txtSoKyHieu.Size = new System.Drawing.Size(245, 31);
            this.txtSoKyHieu.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label11.Location = new System.Drawing.Point(569, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Phòng ban nhận";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label10.Location = new System.Drawing.Point(569, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 31);
            this.label10.TabIndex = 4;
            this.label10.Text = "Phòng ban hành";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label9.Location = new System.Drawing.Point(569, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Loại ban hành";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(61, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày ban hành";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label7.Location = new System.Drawing.Point(61, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên văn bản";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(61, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ký hiệu";
            // 
            // tabPageDSVBNoiBo
            // 
            this.tabPageDSVBNoiBo.Controls.Add(this.label21);
            this.tabPageDSVBNoiBo.Controls.Add(this.panel11);
            this.tabPageDSVBNoiBo.Controls.Add(this.panel10);
            this.tabPageDSVBNoiBo.Controls.Add(this.dataGridViewVBNB);
            this.tabPageDSVBNoiBo.Location = new System.Drawing.Point(4, 34);
            this.tabPageDSVBNoiBo.Name = "tabPageDSVBNoiBo";
            this.tabPageDSVBNoiBo.Size = new System.Drawing.Size(1912, 1018);
            this.tabPageDSVBNoiBo.TabIndex = 2;
            this.tabPageDSVBNoiBo.Text = "Danh sách văn bản nội bộ";
            this.tabPageDSVBNoiBo.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(36, 233);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(279, 25);
            this.label21.TabIndex = 14;
            this.label21.Text = "Bảng danh sách văn bản nội bộ";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label20);
            this.panel11.Controls.Add(this.label19);
            this.panel11.Controls.Add(this.dateTimePicker2);
            this.panel11.Controls.Add(this.dateTimePicker1);
            this.panel11.Controls.Add(this.comboBox1);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Location = new System.Drawing.Point(60, 67);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1519, 141);
            this.panel11.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label20.Location = new System.Drawing.Point(968, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 25);
            this.label20.TabIndex = 13;
            this.label20.Text = "đến ngày";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label19.Location = new System.Drawing.Point(499, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 25);
            this.label19.TabIndex = 12;
            this.label19.Text = "Từ ngày";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(1151, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(306, 31);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(637, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 31);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Năm nay",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12",
            "Năm trước"});
            this.comboBox1.Location = new System.Drawing.Point(154, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 33);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label18.Location = new System.Drawing.Point(43, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 25);
            this.label18.TabIndex = 8;
            this.label18.Text = "Chọn lọc thời gian";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SeaShell;
            this.panel10.Controls.Add(this.pictureBox4);
            this.panel10.Controls.Add(this.btnXoaVBNB);
            this.panel10.Controls.Add(this.btnSuaVBNB);
            this.panel10.Controls.Add(this.btnThemVBNB);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1576, 49);
            this.panel10.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightYellow;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(212, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnXoaVBNB
            // 
            this.btnXoaVBNB.BackColor = System.Drawing.Color.LightYellow;
            this.btnXoaVBNB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnXoaVBNB.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaVBNB.Image")));
            this.btnXoaVBNB.Location = new System.Drawing.Point(145, 3);
            this.btnXoaVBNB.Name = "btnXoaVBNB";
            this.btnXoaVBNB.Size = new System.Drawing.Size(47, 46);
            this.btnXoaVBNB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXoaVBNB.TabIndex = 7;
            this.btnXoaVBNB.TabStop = false;
            this.btnXoaVBNB.Click += new System.EventHandler(this.btnXoaVBNB_Click);
            // 
            // btnSuaVBNB
            // 
            this.btnSuaVBNB.BackColor = System.Drawing.Color.LightYellow;
            this.btnSuaVBNB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSuaVBNB.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaVBNB.Image")));
            this.btnSuaVBNB.Location = new System.Drawing.Point(78, 3);
            this.btnSuaVBNB.Name = "btnSuaVBNB";
            this.btnSuaVBNB.Size = new System.Drawing.Size(47, 46);
            this.btnSuaVBNB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSuaVBNB.TabIndex = 2;
            this.btnSuaVBNB.TabStop = false;
            this.btnSuaVBNB.Click += new System.EventHandler(this.btnSuaVBNB_Click);
            // 
            // btnThemVBNB
            // 
            this.btnThemVBNB.BackColor = System.Drawing.Color.LightYellow;
            this.btnThemVBNB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnThemVBNB.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVBNB.Image")));
            this.btnThemVBNB.Location = new System.Drawing.Point(4, 3);
            this.btnThemVBNB.Name = "btnThemVBNB";
            this.btnThemVBNB.Size = new System.Drawing.Size(47, 46);
            this.btnThemVBNB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThemVBNB.TabIndex = 0;
            this.btnThemVBNB.TabStop = false;
            this.btnThemVBNB.Click += new System.EventHandler(this.btnThemVBNB_Click);
            // 
            // dataGridViewVBNB
            // 
            this.dataGridViewVBNB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewVBNB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVBNB.Location = new System.Drawing.Point(41, 279);
            this.dataGridViewVBNB.Name = "dataGridViewVBNB";
            this.dataGridViewVBNB.RowHeadersWidth = 51;
            this.dataGridViewVBNB.RowTemplate.Height = 24;
            this.dataGridViewVBNB.Size = new System.Drawing.Size(1538, 616);
            this.dataGridViewVBNB.TabIndex = 0;
            this.dataGridViewVBNB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewVBNB_MouseClick);
            // 
            // tabPageTimKiem
            // 
            this.tabPageTimKiem.Controls.Add(this.tabControl4);
            this.tabPageTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTimKiem.Location = new System.Drawing.Point(4, 34);
            this.tabPageTimKiem.Name = "tabPageTimKiem";
            this.tabPageTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimKiem.Size = new System.Drawing.Size(1912, 1018);
            this.tabPageTimKiem.TabIndex = 2;
            this.tabPageTimKiem.Text = "Tìm kiếm thống kê";
            this.tabPageTimKiem.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage7);
            this.tabControl4.Controls.Add(this.tabPage8);
            this.tabControl4.Controls.Add(this.tabPage9);
            this.tabControl4.Location = new System.Drawing.Point(6, 12);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1578, 968);
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label57);
            this.tabPage7.Controls.Add(this.panel17);
            this.tabPage7.Controls.Add(this.panel16);
            this.tabPage7.Controls.Add(this.label33);
            this.tabPage7.Location = new System.Drawing.Point(4, 34);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1570, 930);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Thống kê văn bản đi";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label57.Location = new System.Drawing.Point(576, 26);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(354, 31);
            this.label57.TabIndex = 5;
            this.label57.Text = "THỐNG KÊ VĂN BẢN NỘI BỘ ĐI";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dataGridView1);
            this.panel17.Controls.Add(this.label54);
            this.panel17.Location = new System.Drawing.Point(0, 364);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1540, 588);
            this.panel17.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1512, 461);
            this.dataGridView1.TabIndex = 19;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label54.Location = new System.Drawing.Point(23, 31);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(287, 25);
            this.label54.TabIndex = 18;
            this.label54.Text = "BẢNG DANH SÁCH VĂN BẢN ĐI";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.button37);
            this.panel16.Controls.Add(this.button39);
            this.panel16.Controls.Add(this.button40);
            this.panel16.Controls.Add(this.comboBox6);
            this.panel16.Controls.Add(this.richTextBox2);
            this.panel16.Controls.Add(this.textBox3);
            this.panel16.Controls.Add(this.textBox4);
            this.panel16.Controls.Add(this.dateTimePicker7);
            this.panel16.Controls.Add(this.dateTimePicker8);
            this.panel16.Controls.Add(this.label45);
            this.panel16.Controls.Add(this.label46);
            this.panel16.Controls.Add(this.label47);
            this.panel16.Controls.Add(this.label48);
            this.panel16.Controls.Add(this.label49);
            this.panel16.Controls.Add(this.comboBox8);
            this.panel16.Controls.Add(this.comboBox9);
            this.panel16.Controls.Add(this.label51);
            this.panel16.Controls.Add(this.label52);
            this.panel16.Controls.Add(this.label53);
            this.panel16.Location = new System.Drawing.Point(3, 81);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1557, 263);
            this.panel16.TabIndex = 3;
            // 
            // button37
            // 
            this.button37.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button37.Location = new System.Drawing.Point(1347, 22);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(146, 43);
            this.button37.TabIndex = 23;
            this.button37.Text = "Tìm kiếm";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button39.Location = new System.Drawing.Point(1347, 182);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(146, 46);
            this.button39.TabIndex = 21;
            this.button39.Text = "Xuất file excel";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button40.Location = new System.Drawing.Point(1347, 96);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(146, 44);
            this.button40.TabIndex = 20;
            this.button40.Text = "Xem chi tiết";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Năm nay",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12",
            "Năm trước"});
            this.comboBox6.Location = new System.Drawing.Point(212, 32);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(220, 33);
            this.comboBox6.TabIndex = 18;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(947, 141);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(263, 96);
            this.richTextBox2.TabIndex = 17;
            this.richTextBox2.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(606, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 31);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(606, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(255, 31);
            this.textBox4.TabIndex = 15;
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker7.Location = new System.Drawing.Point(1015, 31);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(249, 31);
            this.dateTimePicker7.TabIndex = 14;
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker8.Location = new System.Drawing.Point(606, 31);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.Size = new System.Drawing.Size(255, 31);
            this.dateTimePicker8.TabIndex = 13;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label45.Location = new System.Drawing.Point(902, 107);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(205, 25);
            this.label45.TabIndex = 12;
            this.label45.Text = "Tìm kiếm theo từ khóa";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label46.Location = new System.Drawing.Point(896, 32);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(91, 25);
            this.label46.TabIndex = 11;
            this.label46.Text = "đến ngày";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label47.Location = new System.Drawing.Point(469, 180);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(90, 25);
            this.label47.TabIndex = 10;
            this.label47.Text = "Nơi nhận";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label48.Location = new System.Drawing.Point(469, 109);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(100, 25);
            this.label48.TabIndex = 9;
            this.label48.Text = "Số ký hiệu";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label49.Location = new System.Drawing.Point(469, 31);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(82, 25);
            this.label49.TabIndex = 8;
            this.label49.Text = "Từ ngày";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(212, 172);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(220, 33);
            this.comboBox8.TabIndex = 6;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(212, 101);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(220, 33);
            this.comboBox9.TabIndex = 5;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label51.Location = new System.Drawing.Point(23, 182);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(120, 25);
            this.label51.TabIndex = 2;
            this.label51.Text = "Loại văn bản";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label52.Location = new System.Drawing.Point(23, 107);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(106, 25);
            this.label52.TabIndex = 1;
            this.label52.Text = "Sổ văn bản";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label53.Location = new System.Drawing.Point(23, 24);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(137, 25);
            this.label53.TabIndex = 0;
            this.label53.Text = "Chọn thời gian";
            // 
            // label33
            // 
            this.label33.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(332, 69);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 25);
            this.label33.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label56);
            this.tabPage8.Controls.Add(this.panel18);
            this.tabPage8.Controls.Add(this.panel15);
            this.tabPage8.Location = new System.Drawing.Point(4, 34);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1570, 930);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Thống kê văn bản đến";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label56.Location = new System.Drawing.Point(550, 22);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(291, 31);
            this.label56.TabIndex = 5;
            this.label56.Text = "THỐNG KÊ VĂN BẢN ĐẾN";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dataGridView2);
            this.panel18.Controls.Add(this.label55);
            this.panel18.Location = new System.Drawing.Point(0, 378);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1540, 588);
            this.panel18.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(28, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1512, 461);
            this.dataGridView2.TabIndex = 19;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label55.Location = new System.Drawing.Point(23, 31);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(305, 25);
            this.label55.TabIndex = 18;
            this.label55.Text = "BẢNG DANH SÁCH VĂN BẢN ĐẾN";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.button33);
            this.panel15.Controls.Add(this.button35);
            this.panel15.Controls.Add(this.button36);
            this.panel15.Controls.Add(this.comboBox2);
            this.panel15.Controls.Add(this.richTextBox1);
            this.panel15.Controls.Add(this.textBox1);
            this.panel15.Controls.Add(this.textBox2);
            this.panel15.Controls.Add(this.dateTimePicker5);
            this.panel15.Controls.Add(this.dateTimePicker6);
            this.panel15.Controls.Add(this.label36);
            this.panel15.Controls.Add(this.label37);
            this.panel15.Controls.Add(this.label38);
            this.panel15.Controls.Add(this.label39);
            this.panel15.Controls.Add(this.label40);
            this.panel15.Controls.Add(this.comboBox4);
            this.panel15.Controls.Add(this.comboBox5);
            this.panel15.Controls.Add(this.label42);
            this.panel15.Controls.Add(this.label43);
            this.panel15.Controls.Add(this.label44);
            this.panel15.Location = new System.Drawing.Point(3, 91);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1557, 263);
            this.panel15.TabIndex = 3;
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button33.Location = new System.Drawing.Point(1335, 22);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(146, 43);
            this.button33.TabIndex = 23;
            this.button33.Text = "Tìm kiếm";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button35.Location = new System.Drawing.Point(1335, 164);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(146, 46);
            this.button35.TabIndex = 21;
            this.button35.Text = "Xuất file excel";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button36.Location = new System.Drawing.Point(1335, 86);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(146, 44);
            this.button36.TabIndex = 20;
            this.button36.Text = "Xem chi tiết";
            this.button36.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Năm nay",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12",
            "Năm trước"});
            this.comboBox2.Location = new System.Drawing.Point(212, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 33);
            this.comboBox2.TabIndex = 18;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(939, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(336, 96);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(606, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 31);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(606, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 31);
            this.textBox2.TabIndex = 15;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Location = new System.Drawing.Point(1026, 31);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(249, 31);
            this.dateTimePicker5.TabIndex = 14;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker6.Location = new System.Drawing.Point(606, 31);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(255, 31);
            this.dateTimePicker6.TabIndex = 13;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label36.Location = new System.Drawing.Point(934, 105);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(205, 25);
            this.label36.TabIndex = 12;
            this.label36.Text = "Tìm kiếm theo từ khóa";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label37.Location = new System.Drawing.Point(918, 32);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(91, 25);
            this.label37.TabIndex = 11;
            this.label37.Text = "đến ngày";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label38.Location = new System.Drawing.Point(473, 188);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(127, 25);
            this.label38.TabIndex = 10;
            this.label38.Text = "Nơi ban hành";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label39.Location = new System.Drawing.Point(473, 104);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 25);
            this.label39.TabIndex = 9;
            this.label39.Text = "Số ký hiệu";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label40.Location = new System.Drawing.Point(469, 31);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(82, 25);
            this.label40.TabIndex = 8;
            this.label40.Text = "Từ ngày";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(212, 177);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(220, 33);
            this.comboBox4.TabIndex = 6;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(212, 97);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(220, 33);
            this.comboBox5.TabIndex = 5;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label42.Location = new System.Drawing.Point(23, 185);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(120, 25);
            this.label42.TabIndex = 2;
            this.label42.Text = "Loại văn bản";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label43.Location = new System.Drawing.Point(23, 106);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(106, 25);
            this.label43.TabIndex = 1;
            this.label43.Text = "Sổ văn bản";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label44.Location = new System.Drawing.Point(23, 24);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(137, 25);
            this.label44.TabIndex = 0;
            this.label44.Text = "Chọn thời gian";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.panel13);
            this.tabPage9.Controls.Add(this.panel12);
            this.tabPage9.Controls.Add(this.label22);
            this.tabPage9.Location = new System.Drawing.Point(4, 34);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1570, 930);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Thống kê văn bản nội bộ";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dataGridViewVBNB1);
            this.panel13.Controls.Add(this.label32);
            this.panel13.Location = new System.Drawing.Point(17, 346);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1540, 588);
            this.panel13.TabIndex = 3;
            // 
            // dataGridViewVBNB1
            // 
            this.dataGridViewVBNB1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewVBNB1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVBNB1.Location = new System.Drawing.Point(28, 77);
            this.dataGridViewVBNB1.Name = "dataGridViewVBNB1";
            this.dataGridViewVBNB1.RowHeadersWidth = 51;
            this.dataGridViewVBNB1.RowTemplate.Height = 24;
            this.dataGridViewVBNB1.Size = new System.Drawing.Size(1512, 461);
            this.dataGridViewVBNB1.TabIndex = 19;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label32.Location = new System.Drawing.Point(23, 31);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(333, 25);
            this.label32.TabIndex = 18;
            this.label32.Text = "BẢNG DANH SÁCH VĂN BẢN NỘI BỘ";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnTimKiem);
            this.panel12.Controls.Add(this.btnInbaocao);
            this.panel12.Controls.Add(this.btnXuatExcel);
            this.panel12.Controls.Add(this.btnXemChiTiet);
            this.panel12.Controls.Add(this.ThoiGianTimKiem);
            this.panel12.Controls.Add(this.nhapTrichYeu);
            this.panel12.Controls.Add(this.nhapTenVanBan);
            this.panel12.Controls.Add(this.nhapSoKyHieu);
            this.panel12.Controls.Add(this.dateTimePicker4);
            this.panel12.Controls.Add(this.dateTimePicker3);
            this.panel12.Controls.Add(this.label31);
            this.panel12.Controls.Add(this.label30);
            this.panel12.Controls.Add(this.label29);
            this.panel12.Controls.Add(this.label28);
            this.panel12.Controls.Add(this.label27);
            this.panel12.Controls.Add(this.ChonCmbPhongBanNhan);
            this.panel12.Controls.Add(this.chonCmbPhongBanHanh);
            this.panel12.Controls.Add(this.chonCmbLoaiBanHanh);
            this.panel12.Controls.Add(this.label26);
            this.panel12.Controls.Add(this.label25);
            this.panel12.Controls.Add(this.label24);
            this.panel12.Controls.Add(this.label23);
            this.panel12.Location = new System.Drawing.Point(17, 54);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1557, 263);
            this.panel12.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnTimKiem.Location = new System.Drawing.Point(1321, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(146, 43);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnInbaocao
            // 
            this.btnInbaocao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbaocao.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnInbaocao.Location = new System.Drawing.Point(1321, 213);
            this.btnInbaocao.Name = "btnInbaocao";
            this.btnInbaocao.Size = new System.Drawing.Size(146, 47);
            this.btnInbaocao.TabIndex = 22;
            this.btnInbaocao.Text = "In báo cáo";
            this.btnInbaocao.UseVisualStyleBackColor = true;
            this.btnInbaocao.Click += new System.EventHandler(this.btnInbaocao_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnXuatExcel.Location = new System.Drawing.Point(1321, 150);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(146, 46);
            this.btnXuatExcel.TabIndex = 21;
            this.btnXuatExcel.Text = "Xuất file excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnXemChiTiet.Location = new System.Drawing.Point(1321, 82);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(146, 44);
            this.btnXemChiTiet.TabIndex = 20;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // ThoiGianTimKiem
            // 
            this.ThoiGianTimKiem.FormattingEnabled = true;
            this.ThoiGianTimKiem.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Năm nay",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12",
            "Năm trước"});
            this.ThoiGianTimKiem.Location = new System.Drawing.Point(212, 24);
            this.ThoiGianTimKiem.Name = "ThoiGianTimKiem";
            this.ThoiGianTimKiem.Size = new System.Drawing.Size(220, 33);
            this.ThoiGianTimKiem.TabIndex = 18;
            this.ThoiGianTimKiem.SelectedIndexChanged += new System.EventHandler(this.ThoiGianTimKiem_SelectedIndexChanged);
            // 
            // nhapTrichYeu
            // 
            this.nhapTrichYeu.Location = new System.Drawing.Point(1015, 97);
            this.nhapTrichYeu.Name = "nhapTrichYeu";
            this.nhapTrichYeu.Size = new System.Drawing.Size(263, 96);
            this.nhapTrichYeu.TabIndex = 17;
            this.nhapTrichYeu.Text = "";
            // 
            // nhapTenVanBan
            // 
            this.nhapTenVanBan.Location = new System.Drawing.Point(606, 137);
            this.nhapTenVanBan.Name = "nhapTenVanBan";
            this.nhapTenVanBan.Size = new System.Drawing.Size(255, 31);
            this.nhapTenVanBan.TabIndex = 16;
            // 
            // nhapSoKyHieu
            // 
            this.nhapSoKyHieu.Location = new System.Drawing.Point(606, 82);
            this.nhapSoKyHieu.Name = "nhapSoKyHieu";
            this.nhapSoKyHieu.Size = new System.Drawing.Size(255, 31);
            this.nhapSoKyHieu.TabIndex = 15;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Location = new System.Drawing.Point(1015, 31);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(249, 31);
            this.dateTimePicker4.TabIndex = 14;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(606, 31);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(255, 31);
            this.dateTimePicker3.TabIndex = 13;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label31.Location = new System.Drawing.Point(897, 88);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 25);
            this.label31.TabIndex = 12;
            this.label31.Text = "Trích yếu";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label30.Location = new System.Drawing.Point(896, 32);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 25);
            this.label30.TabIndex = 11;
            this.label30.Text = "đến ngày";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label29.Location = new System.Drawing.Point(469, 143);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 25);
            this.label29.TabIndex = 10;
            this.label29.Text = "Tên văn bản";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label28.Location = new System.Drawing.Point(469, 82);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 25);
            this.label28.TabIndex = 9;
            this.label28.Text = "Số ký hiệu";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label27.Location = new System.Drawing.Point(469, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 25);
            this.label27.TabIndex = 8;
            this.label27.Text = "Từ ngày";
            // 
            // ChonCmbPhongBanNhan
            // 
            this.ChonCmbPhongBanNhan.FormattingEnabled = true;
            this.ChonCmbPhongBanNhan.Location = new System.Drawing.Point(212, 199);
            this.ChonCmbPhongBanNhan.Name = "ChonCmbPhongBanNhan";
            this.ChonCmbPhongBanNhan.Size = new System.Drawing.Size(220, 33);
            this.ChonCmbPhongBanNhan.TabIndex = 7;
            // 
            // chonCmbPhongBanHanh
            // 
            this.chonCmbPhongBanHanh.FormattingEnabled = true;
            this.chonCmbPhongBanHanh.Location = new System.Drawing.Point(212, 133);
            this.chonCmbPhongBanHanh.Name = "chonCmbPhongBanHanh";
            this.chonCmbPhongBanHanh.Size = new System.Drawing.Size(220, 33);
            this.chonCmbPhongBanHanh.TabIndex = 6;
            // 
            // chonCmbLoaiBanHanh
            // 
            this.chonCmbLoaiBanHanh.FormattingEnabled = true;
            this.chonCmbLoaiBanHanh.Location = new System.Drawing.Point(212, 79);
            this.chonCmbLoaiBanHanh.Name = "chonCmbLoaiBanHanh";
            this.chonCmbLoaiBanHanh.Size = new System.Drawing.Size(220, 33);
            this.chonCmbLoaiBanHanh.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label26.Location = new System.Drawing.Point(23, 202);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(152, 25);
            this.label26.TabIndex = 3;
            this.label26.Text = "Phòng ban nhận";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label25.Location = new System.Drawing.Point(23, 143);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(152, 25);
            this.label25.TabIndex = 2;
            this.label25.Text = "Phòng ban hành";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label24.Location = new System.Drawing.Point(23, 79);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(132, 25);
            this.label24.TabIndex = 1;
            this.label24.Text = "Loại ban hành";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label23.Location = new System.Drawing.Point(23, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 25);
            this.label23.TabIndex = 0;
            this.label23.Text = "Chọn thời gian";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(480, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(324, 31);
            this.label22.TabIndex = 1;
            this.label22.Text = "THỐNG KÊ VĂN BẢN NỘI BỘ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnTimKiemThongKe);
            this.panel3.Controls.Add(this.btnQuanLyVbNoiBo);
            this.panel3.Controls.Add(this.btnQuanLyVanBan);
            this.panel3.Controls.Add(this.btnHeThong);
            this.panel3.Controls.Add(this.pictureBox9);
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(3, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 1005);
            this.panel3.TabIndex = 1;
            // 
            // btnTimKiemThongKe
            // 
            this.btnTimKiemThongKe.BackColor = System.Drawing.Color.OldLace;
            this.btnTimKiemThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiemThongKe.Location = new System.Drawing.Point(59, 821);
            this.btnTimKiemThongKe.Name = "btnTimKiemThongKe";
            this.btnTimKiemThongKe.Size = new System.Drawing.Size(294, 59);
            this.btnTimKiemThongKe.TabIndex = 3;
            this.btnTimKiemThongKe.Text = "Tìm kiếm - Thống kê";
            this.btnTimKiemThongKe.UseVisualStyleBackColor = false;
            this.btnTimKiemThongKe.Click += new System.EventHandler(this.btnTimKiemThongKe_Click);
            // 
            // btnQuanLyVbNoiBo
            // 
            this.btnQuanLyVbNoiBo.BackColor = System.Drawing.Color.OldLace;
            this.btnQuanLyVbNoiBo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyVbNoiBo.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyVbNoiBo.Location = new System.Drawing.Point(59, 744);
            this.btnQuanLyVbNoiBo.Name = "btnQuanLyVbNoiBo";
            this.btnQuanLyVbNoiBo.Size = new System.Drawing.Size(294, 59);
            this.btnQuanLyVbNoiBo.TabIndex = 2;
            this.btnQuanLyVbNoiBo.Text = "Quản lý văn bản nội bộ";
            this.btnQuanLyVbNoiBo.UseVisualStyleBackColor = false;
            this.btnQuanLyVbNoiBo.Click += new System.EventHandler(this.btnQuanLyVbNoiBo_Click);
            // 
            // btnQuanLyVanBan
            // 
            this.btnQuanLyVanBan.BackColor = System.Drawing.Color.OldLace;
            this.btnQuanLyVanBan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyVanBan.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyVanBan.Location = new System.Drawing.Point(59, 672);
            this.btnQuanLyVanBan.Name = "btnQuanLyVanBan";
            this.btnQuanLyVanBan.Size = new System.Drawing.Size(294, 52);
            this.btnQuanLyVanBan.TabIndex = 1;
            this.btnQuanLyVanBan.Text = "Quản lý văn bản";
            this.btnQuanLyVanBan.UseVisualStyleBackColor = false;
            this.btnQuanLyVanBan.Click += new System.EventHandler(this.btnQuanLyVanBan_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.BackColor = System.Drawing.Color.OldLace;
            this.btnHeThong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.Black;
            this.btnHeThong.Location = new System.Drawing.Point(59, 605);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(294, 51);
            this.btnHeThong.TabIndex = 0;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.UseVisualStyleBackColor = false;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(-5, 539);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(418, 451);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-5, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 539);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hệ thống";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(60, 269);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(294, 71);
            this.button7.TabIndex = 2;
            this.button7.Text = "Thông tin người ký duyệt";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(60, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(294, 66);
            this.button5.TabIndex = 0;
            this.button5.Text = "Quản lý người dùng";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(60, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(294, 71);
            this.button6.TabIndex = 1;
            this.button6.Text = "Phân quyền nhân viên";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-4, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(413, 495);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.pictureBox6);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Văn bản";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(49, 421);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(321, 56);
            this.button14.TabIndex = 6;
            this.button14.Text = "Danh sách văn bản đi";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(49, 352);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(321, 59);
            this.button13.TabIndex = 5;
            this.button13.Text = "Danh sách văn bản đến";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(49, 293);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(321, 53);
            this.button12.TabIndex = 4;
            this.button12.Text = "Văn bản đi";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(49, 228);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(321, 58);
            this.button11.TabIndex = 3;
            this.button11.Text = "Văn bản đến";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(49, 169);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(321, 53);
            this.button10.TabIndex = 2;
            this.button10.Text = "Nơi ban hành";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(49, 112);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(321, 51);
            this.button9.TabIndex = 1;
            this.button9.Text = "Loại văn bản";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(49, 52);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(321, 54);
            this.button8.TabIndex = 0;
            this.button8.Text = "Số văn bản";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::HeThongQuanLyVanBanCongVan.Properties.Resources.ngua;
            this.pictureBox6.Location = new System.Drawing.Point(4, -7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(414, 502);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Controls.Add(this.button16);
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.pictureBox7);
            this.tabPage3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(413, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Văn bản nội bộ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button17.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Black;
            this.button17.Location = new System.Drawing.Point(68, 313);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(283, 50);
            this.button17.TabIndex = 2;
            this.button17.Text = "Danh sách văn bản nội bộ";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Black;
            this.button16.Location = new System.Drawing.Point(68, 216);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(283, 50);
            this.button16.TabIndex = 1;
            this.button16.Text = "Văn bản nội bộ";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(68, 124);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(283, 50);
            this.button15.TabIndex = 0;
            this.button15.Text = "Phòng ban";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(404, 495);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button20);
            this.tabPage4.Controls.Add(this.button19);
            this.tabPage4.Controls.Add(this.button18);
            this.tabPage4.Controls.Add(this.pictureBox8);
            this.tabPage4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(413, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tìm kiếm - Thống kê";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button20.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.Black;
            this.button20.Location = new System.Drawing.Point(60, 279);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(299, 49);
            this.button20.TabIndex = 2;
            this.button20.Text = "Thống kê văn bản nội bộ";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button19.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(60, 192);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(299, 49);
            this.button19.TabIndex = 1;
            this.button19.Text = "Thống kê văn bản đến";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Location = new System.Drawing.Point(60, 103);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(299, 49);
            this.button18.TabIndex = 0;
            this.button18.Text = "Thống kê văn bản đi";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(407, 502);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 46);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpLạiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 52);
            // 
            // đăngNhậpLạiToolStripMenuItem
            // 
            this.đăngNhậpLạiToolStripMenuItem.Name = "đăngNhậpLạiToolStripMenuItem";
            this.đăngNhậpLạiToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.đăngNhậpLạiToolStripMenuItem.Text = "Đăng nhập lại";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaThôngTinNgườiDùngToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(223, 28);
            // 
            // sửaThôngTinNgườiDùngToolStripMenuItem
            // 
            this.sửaThôngTinNgườiDùngToolStripMenuItem.Name = "sửaThôngTinNgườiDùngToolStripMenuItem";
            this.sửaThôngTinNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.sửaThôngTinNgườiDùngToolStripMenuItem.Text = "Sửa thông tin cá nhân";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HỆ THỐNG QUẢN LÝ VĂN BẢN - CÔNG VĂN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChu_FormClosing);
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPageVanBanNoiBo.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPagePhongBan.ResumeLayout(false);
            this.tabPagePhongBan.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XuatExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThemPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).EndInit();
            this.VBNoiBotabPage.ResumeLayout(false);
            this.VBNoiBotabPage.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LuuVBNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemVBNB)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiLieu)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabPageDSVBNoiBo.ResumeLayout(false);
            this.tabPageDSVBNoiBo.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaVBNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSuaVBNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemVBNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVBNB)).EndInit();
            this.tabPageTimKiem.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVBNB1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTimKiemThongKe;
        private System.Windows.Forms.Button btnQuanLyVbNoiBo;
        private System.Windows.Forms.Button btnQuanLyVanBan;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem đăngNhậpLạiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem sửaThôngTinNgườiDùngToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tabControl2;
        private TabPage tabPage5;
        private TabPage tabPageVanBanNoiBo;
        private TabControl tabControl3;
        private TabPage tabPagePhongBan;
        private Panel panel5;
        private PictureBox picLuu;
        private PictureBox picXoa;
        private PictureBox picThemPhongBan;
        private Label label5;
        private DataGridView dataGridViewPhongBan;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage VBNoiBotabPage;
        private TabPage tabPageDSVBNoiBo;
        private Panel panel6;
        private DateTimePicker dateNgayBanHanh;
        private ComboBox cmbPhongBanNhan;
        private ComboBox cmbPhongBanHanh;
        private ComboBox cmbLoaiBanHanh;
        private TextBox txtTenVanBan;
        private TextBox txtSoKyHieu;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel9;
        private PictureBox LuuVBNB;
        private PictureBox ThemVBNB;
        private Panel panel8;
        private DataGridView dataGridViewTaiLieu;
        private Label label14;
        private Panel panel7;
        private Label label13;
        private Label label12;
        private DataGridView dataGridViewVBNB;
        private RichTextBox txtNoiDung;
        private RichTextBox txtTrichYeu;
        private TextBox txtNguoiDuyet;
        private TextBox txtNguoiKy;
        private TextBox txtNguoiNhan;
        private Label label17;
        private Label label16;
        private Label label15;
        private Button btnXoaFile;
        private Button btnDocFile;
        private Button btnDinhKem;
        private Button button2;
        private Panel panel10;
        private PictureBox btnXoaVBNB;
        private PictureBox btnSuaVBNB;
        private PictureBox btnThemVBNB;
        private Panel panel11;
        private Label label20;
        private Label label19;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label18;
        private Label label21;
        private TabPage tabPageTimKiem;
        private TabControl tabControl4;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private Panel panel12;
        private RichTextBox nhapTrichYeu;
        private TextBox nhapTenVanBan;
        private TextBox nhapSoKyHieu;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private ComboBox ChonCmbPhongBanNhan;
        private ComboBox chonCmbPhongBanHanh;
        private ComboBox chonCmbLoaiBanHanh;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Panel panel13;
        private DataGridView dataGridViewVBNB1;
        private Label label32;
        private ComboBox ThoiGianTimKiem;
        private ComboBox comboBox1;
        private PictureBox XuatExcel;
        private PictureBox pictureBox4;
        private Button btnInbaocao;
        private Button btnXuatExcel;
        private Button btnXemChiTiet;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Button btnTimKiem;
        private Button button5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label33;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Panel panel14;
        private Panel panel4;
        private Label label34;
        private Label label35;
        private Button button22;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button26;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button21;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button29;
        private Button button28;
        private Button button27;
        private PictureBox pictureBox3;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox20;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox22;
        private PictureBox pictureBox21;
        private PictureBox pictureBox31;
        private PictureBox pictureBox30;
        private PictureBox pictureBox29;
        private PictureBox pictureBox28;
        private PictureBox pictureBox27;
        private PictureBox pictureBox26;
        private PictureBox pictureBox25;
        private PictureBox pictureBox24;
        private PictureBox pictureBox23;
        private Panel panel16;
        private Button button37;
        private Button button39;
        private Button button40;
        private ComboBox comboBox6;
        private RichTextBox richTextBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker7;
        private DateTimePicker dateTimePicker8;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private Label label51;
        private Label label52;
        private Label label53;
        private Panel panel15;
        private Button button33;
        private Button button35;
        private Button button36;
        private ComboBox comboBox2;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker6;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label42;
        private Label label43;
        private Label label44;
        private Panel panel17;
        private DataGridView dataGridView1;
        private Label label54;
        private Label label56;
        private Panel panel18;
        private DataGridView dataGridView2;
        private Label label55;
        private Label label57;
    }
}

