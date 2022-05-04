namespace WindowsFormsApp1.childForm
{
    partial class contract
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contract));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelFunc = new System.Windows.Forms.Panel();
            this.panelFuncDetail = new System.Windows.Forms.Panel();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.cbxCarID = new System.Windows.Forms.ComboBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyxedulichhDataSet1 = new WindowsFormsApp1.QuanlyxedulichhDataSet1();
            this.tbxDeposit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxContractID = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDateReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpDateReturnExpected = new System.Windows.Forms.DateTimePicker();
            this.dtpDateRent = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFuncBtn = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.panelDGVMain = new System.Windows.Forms.Panel();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.panelDGVSub1 = new System.Windows.Forms.Panel();
            this.dataGridViewSub1 = new System.Windows.Forms.DataGridView();
            this.panelDGVSub2 = new System.Windows.Forms.Panel();
            this.dataGridViewSub2 = new System.Windows.Forms.DataGridView();
            this.carTableAdapter = new WindowsFormsApp1.QuanlyxedulichhDataSet1TableAdapters.CarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelFunc.SuspendLayout();
            this.panelFuncDetail.SuspendLayout();
            this.groupBoxDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyxedulichhDataSet1)).BeginInit();
            this.panelFuncBtn.SuspendLayout();
            this.panelDGV.SuspendLayout();
            this.panelDGVMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panelDGVSub1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSub1)).BeginInit();
            this.panelDGVSub2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSub2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ HỢP ĐỒNG";
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1072, 51);
            this.panelTitle.TabIndex = 6;
            // 
            // panelFunc
            // 
            this.panelFunc.AutoScroll = true;
            this.panelFunc.Controls.Add(this.panelFuncDetail);
            this.panelFunc.Controls.Add(this.panelFuncBtn);
            this.panelFunc.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFunc.Location = new System.Drawing.Point(715, 51);
            this.panelFunc.Name = "panelFunc";
            this.panelFunc.Size = new System.Drawing.Size(357, 463);
            this.panelFunc.TabIndex = 7;
            // 
            // panelFuncDetail
            // 
            this.panelFuncDetail.AutoScroll = true;
            this.panelFuncDetail.Controls.Add(this.groupBoxDetail);
            this.panelFuncDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFuncDetail.Location = new System.Drawing.Point(0, 0);
            this.panelFuncDetail.Name = "panelFuncDetail";
            this.panelFuncDetail.Size = new System.Drawing.Size(357, 339);
            this.panelFuncDetail.TabIndex = 1;
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.Controls.Add(this.cbxCarID);
            this.groupBoxDetail.Controls.Add(this.tbxDeposit);
            this.groupBoxDetail.Controls.Add(this.label11);
            this.groupBoxDetail.Controls.Add(this.label10);
            this.groupBoxDetail.Controls.Add(this.tbxContractID);
            this.groupBoxDetail.Controls.Add(this.cbxStatus);
            this.groupBoxDetail.Controls.Add(this.label9);
            this.groupBoxDetail.Controls.Add(this.dtpDateReturn);
            this.groupBoxDetail.Controls.Add(this.dtpDateReturnExpected);
            this.groupBoxDetail.Controls.Add(this.dtpDateRent);
            this.groupBoxDetail.Controls.Add(this.label7);
            this.groupBoxDetail.Controls.Add(this.tbxPhoneNumber);
            this.groupBoxDetail.Controls.Add(this.tbxCustomerID);
            this.groupBoxDetail.Controls.Add(this.tbxCustomerName);
            this.groupBoxDetail.Controls.Add(this.label8);
            this.groupBoxDetail.Controls.Add(this.label6);
            this.groupBoxDetail.Controls.Add(this.label5);
            this.groupBoxDetail.Controls.Add(this.label4);
            this.groupBoxDetail.Controls.Add(this.label3);
            this.groupBoxDetail.Controls.Add(this.label2);
            this.groupBoxDetail.Location = new System.Drawing.Point(11, 6);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Size = new System.Drawing.Size(334, 444);
            this.groupBoxDetail.TabIndex = 2;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "Detail";
            // 
            // cbxCarID
            // 
            this.cbxCarID.DataSource = this.carBindingSource;
            this.cbxCarID.DisplayMember = "carID";
            this.cbxCarID.FormattingEnabled = true;
            this.cbxCarID.Location = new System.Drawing.Point(146, 174);
            this.cbxCarID.Name = "cbxCarID";
            this.cbxCarID.Size = new System.Drawing.Size(140, 24);
            this.cbxCarID.TabIndex = 30;
            this.cbxCarID.ValueMember = "carID";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.quanlyxedulichhDataSet1;
            // 
            // quanlyxedulichhDataSet1
            // 
            this.quanlyxedulichhDataSet1.DataSetName = "QuanlyxedulichhDataSet1";
            this.quanlyxedulichhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxDeposit
            // 
            this.tbxDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDeposit.Location = new System.Drawing.Point(146, 334);
            this.tbxDeposit.Name = "tbxDeposit";
            this.tbxDeposit.Size = new System.Drawing.Size(140, 22);
            this.tbxDeposit.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tiền cọc";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Mã hợp đồng";
            // 
            // tbxContractID
            // 
            this.tbxContractID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxContractID.Location = new System.Drawing.Point(146, 23);
            this.tbxContractID.Name = "tbxContractID";
            this.tbxContractID.Size = new System.Drawing.Size(140, 22);
            this.tbxContractID.TabIndex = 26;
            this.tbxContractID.Visible = false;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbxStatus.Location = new System.Drawing.Point(146, 373);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(140, 24);
            this.cbxStatus.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Trạng thái";
            // 
            // dtpDateReturn
            // 
            this.dtpDateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateReturn.Location = new System.Drawing.Point(146, 294);
            this.dtpDateReturn.Name = "dtpDateReturn";
            this.dtpDateReturn.Size = new System.Drawing.Size(140, 22);
            this.dtpDateReturn.TabIndex = 23;
            // 
            // dtpDateReturnExpected
            // 
            this.dtpDateReturnExpected.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateReturnExpected.Location = new System.Drawing.Point(146, 252);
            this.dtpDateReturnExpected.Name = "dtpDateReturnExpected";
            this.dtpDateReturnExpected.Size = new System.Drawing.Size(140, 22);
            this.dtpDateReturnExpected.TabIndex = 22;
            // 
            // dtpDateRent
            // 
            this.dtpDateRent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateRent.Location = new System.Drawing.Point(146, 211);
            this.dtpDateRent.Name = "dtpDateRent";
            this.dtpDateRent.Size = new System.Drawing.Size(140, 22);
            this.dtpDateRent.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ngày trả";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPhoneNumber.Location = new System.Drawing.Point(146, 137);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(140, 22);
            this.tbxPhoneNumber.TabIndex = 18;
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomerID.Location = new System.Drawing.Point(146, 100);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.Size = new System.Drawing.Size(140, 22);
            this.tbxCustomerID.TabIndex = 17;
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomerName.Location = new System.Drawing.Point(146, 60);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(140, 22);
            this.tbxCustomerName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày trả dự kiến";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "CMND";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày thuê";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã xe";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số dt";
            // 
            // panelFuncBtn
            // 
            this.panelFuncBtn.Controls.Add(this.btnAdd);
            this.panelFuncBtn.Controls.Add(this.btnModify);
            this.panelFuncBtn.Controls.Add(this.btnDelete);
            this.panelFuncBtn.Controls.Add(this.btnSearch);
            this.panelFuncBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFuncBtn.Location = new System.Drawing.Point(0, 339);
            this.panelFuncBtn.Name = "panelFuncBtn";
            this.panelFuncBtn.Size = new System.Drawing.Size(357, 124);
            this.panelFuncBtn.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(73, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 39);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(194, 23);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(115, 39);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Sửa";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(73, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 39);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(194, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 39);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.panelDGVMain);
            this.panelDGV.Controls.Add(this.panelDGVSub1);
            this.panelDGV.Controls.Add(this.panelDGVSub2);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGV.Location = new System.Drawing.Point(0, 51);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(715, 463);
            this.panelDGV.TabIndex = 8;
            // 
            // panelDGVMain
            // 
            this.panelDGVMain.Controls.Add(this.dataGridViewMain);
            this.panelDGVMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGVMain.Location = new System.Drawing.Point(0, 0);
            this.panelDGVMain.Name = "panelDGVMain";
            this.panelDGVMain.Size = new System.Drawing.Size(715, 209);
            this.panelDGVMain.TabIndex = 2;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(715, 209);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
            // 
            // panelDGVSub1
            // 
            this.panelDGVSub1.Controls.Add(this.dataGridViewSub1);
            this.panelDGVSub1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDGVSub1.Location = new System.Drawing.Point(0, 209);
            this.panelDGVSub1.Name = "panelDGVSub1";
            this.panelDGVSub1.Size = new System.Drawing.Size(715, 130);
            this.panelDGVSub1.TabIndex = 1;
            // 
            // dataGridViewSub1
            // 
            this.dataGridViewSub1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSub1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSub1.Name = "dataGridViewSub1";
            this.dataGridViewSub1.RowHeadersWidth = 51;
            this.dataGridViewSub1.RowTemplate.Height = 24;
            this.dataGridViewSub1.Size = new System.Drawing.Size(715, 130);
            this.dataGridViewSub1.TabIndex = 0;
            // 
            // panelDGVSub2
            // 
            this.panelDGVSub2.Controls.Add(this.dataGridViewSub2);
            this.panelDGVSub2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDGVSub2.Location = new System.Drawing.Point(0, 339);
            this.panelDGVSub2.Name = "panelDGVSub2";
            this.panelDGVSub2.Size = new System.Drawing.Size(715, 124);
            this.panelDGVSub2.TabIndex = 0;
            // 
            // dataGridViewSub2
            // 
            this.dataGridViewSub2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSub2.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSub2.Name = "dataGridViewSub2";
            this.dataGridViewSub2.RowHeadersWidth = 51;
            this.dataGridViewSub2.RowTemplate.Height = 24;
            this.dataGridViewSub2.Size = new System.Drawing.Size(715, 124);
            this.dataGridViewSub2.TabIndex = 0;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 514);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panelFunc);
            this.Controls.Add(this.panelTitle);
            this.Name = "contract";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.contract_FormClosed);
            this.Load += new System.EventHandler(this.contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelFunc.ResumeLayout(false);
            this.panelFuncDetail.ResumeLayout(false);
            this.groupBoxDetail.ResumeLayout(false);
            this.groupBoxDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyxedulichhDataSet1)).EndInit();
            this.panelFuncBtn.ResumeLayout(false);
            this.panelDGV.ResumeLayout(false);
            this.panelDGVMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panelDGVSub1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSub1)).EndInit();
            this.panelDGVSub2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSub2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelFunc;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.GroupBox groupBoxDetail;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDGVMain;
        private System.Windows.Forms.Panel panelDGVSub1;
        private System.Windows.Forms.Panel panelDGVSub2;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridView dataGridViewSub1;
        private System.Windows.Forms.DataGridView dataGridViewSub2;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpDateReturn;
        private System.Windows.Forms.DateTimePicker dtpDateReturnExpected;
        private System.Windows.Forms.DateTimePicker dtpDateRent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxContractID;
        private System.Windows.Forms.Panel panelFuncDetail;
        private System.Windows.Forms.Panel panelFuncBtn;
        private System.Windows.Forms.TextBox tbxDeposit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxCarID;
        private QuanlyxedulichhDataSet1 quanlyxedulichhDataSet1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private QuanlyxedulichhDataSet1TableAdapters.CarTableAdapter carTableAdapter;
    }
}