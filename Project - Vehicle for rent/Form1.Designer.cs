namespace Project___Vehicle_for_rent
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxMaster = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gboxSum = new System.Windows.Forms.GroupBox();
            this.tboxSum = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.gboxDate = new System.Windows.Forms.GroupBox();
            this.lblDateError = new System.Windows.Forms.Label();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.dateRent = new System.Windows.Forms.DateTimePicker();
            this.lblRentdate = new System.Windows.Forms.Label();
            this.lblReturndate = new System.Windows.Forms.Label();
            this.gboxPay = new System.Windows.Forms.GroupBox();
            this.lblPayError = new System.Windows.Forms.Label();
            this.rbuttonCash = new System.Windows.Forms.RadioButton();
            this.rbuttonBank = new System.Windows.Forms.RadioButton();
            this.lblPayway = new System.Windows.Forms.Label();
            this.rbuttonCard = new System.Windows.Forms.RadioButton();
            this.gboxVehicledata = new System.Windows.Forms.GroupBox();
            this.tboxCarprice = new System.Windows.Forms.TextBox();
            this.lblPrice3 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.cboxModel = new System.Windows.Forms.ComboBox();
            this.checkSkitrunk = new System.Windows.Forms.CheckBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.checkChains = new System.Windows.Forms.CheckBox();
            this.lblAdditional = new System.Windows.Forms.Label();
            this.checkChair = new System.Windows.Forms.CheckBox();
            this.gboxPersonalinfo = new System.Windows.Forms.GroupBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxLastname = new System.Windows.Forms.TextBox();
            this.tboxAdress = new System.Windows.Forms.TextBox();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxMaster.SuspendLayout();
            this.gboxSum.SuspendLayout();
            this.gboxDate.SuspendLayout();
            this.gboxPay.SuspendLayout();
            this.gboxVehicledata.SuspendLayout();
            this.gboxPersonalinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project___Vehicle_for_rent.Properties.Resources.text;
            this.pictureBox1.Location = new System.Drawing.Point(140, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // gboxMaster
            // 
            this.gboxMaster.BackColor = System.Drawing.SystemColors.Control;
            this.gboxMaster.BackgroundImage = global::Project___Vehicle_for_rent.Properties.Resources.background1;
            this.gboxMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gboxMaster.Controls.Add(this.btnClear);
            this.gboxMaster.Controls.Add(this.gboxSum);
            this.gboxMaster.Controls.Add(this.gboxDate);
            this.gboxMaster.Controls.Add(this.gboxPay);
            this.gboxMaster.Controls.Add(this.gboxVehicledata);
            this.gboxMaster.Controls.Add(this.gboxPersonalinfo);
            this.gboxMaster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gboxMaster.Location = new System.Drawing.Point(44, 80);
            this.gboxMaster.Name = "gboxMaster";
            this.gboxMaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gboxMaster.Size = new System.Drawing.Size(653, 525);
            this.gboxMaster.TabIndex = 27;
            this.gboxMaster.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(36, 476);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 38);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gboxSum
            // 
            this.gboxSum.BackColor = System.Drawing.Color.LemonChiffon;
            this.gboxSum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gboxSum.Controls.Add(this.tboxSum);
            this.gboxSum.Controls.Add(this.btnSum);
            this.gboxSum.Controls.Add(this.lblSum);
            this.gboxSum.Location = new System.Drawing.Point(435, 362);
            this.gboxSum.Name = "gboxSum";
            this.gboxSum.Size = new System.Drawing.Size(177, 152);
            this.gboxSum.TabIndex = 26;
            this.gboxSum.TabStop = false;
            this.gboxSum.Text = "Сума";
            // 
            // tboxSum
            // 
            this.tboxSum.Location = new System.Drawing.Point(42, 65);
            this.tboxSum.Name = "tboxSum";
            this.tboxSum.ReadOnly = true;
            this.tboxSum.Size = new System.Drawing.Size(100, 20);
            this.tboxSum.TabIndex = 27;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(42, 91);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(100, 38);
            this.btnSum.TabIndex = 27;
            this.btnSum.Text = "Изчисли сума";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(29, 33);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(130, 17);
            this.lblSum.TabIndex = 26;
            this.lblSum.Text = "Сума за плащане:";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboxDate
            // 
            this.gboxDate.BackColor = System.Drawing.Color.LemonChiffon;
            this.gboxDate.Controls.Add(this.lblDateError);
            this.gboxDate.Controls.Add(this.dateReturn);
            this.gboxDate.Controls.Add(this.dateRent);
            this.gboxDate.Controls.Add(this.lblRentdate);
            this.gboxDate.Controls.Add(this.lblReturndate);
            this.gboxDate.Location = new System.Drawing.Point(36, 362);
            this.gboxDate.Name = "gboxDate";
            this.gboxDate.Size = new System.Drawing.Size(393, 108);
            this.gboxDate.TabIndex = 22;
            this.gboxDate.TabStop = false;
            this.gboxDate.Text = "Дата";
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDateError.Location = new System.Drawing.Point(21, 88);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(298, 13);
            this.lblDateError.TabIndex = 29;
            this.lblDateError.Text = "Въвели сте невалидна дата за наемане или за връщане.";
            this.lblDateError.Visible = false;
            // 
            // dateReturn
            // 
            this.dateReturn.Location = new System.Drawing.Point(166, 65);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(200, 20);
            this.dateReturn.TabIndex = 25;
            this.dateReturn.ValueChanged += new System.EventHandler(this.dateReturn_ValueChanged);
            // 
            // dateRent
            // 
            this.dateRent.Location = new System.Drawing.Point(166, 30);
            this.dateRent.Name = "dateRent";
            this.dateRent.Size = new System.Drawing.Size(200, 20);
            this.dateRent.TabIndex = 24;
            this.dateRent.ValueChanged += new System.EventHandler(this.dateRent_ValueChanged);
            // 
            // lblRentdate
            // 
            this.lblRentdate.AutoSize = true;
            this.lblRentdate.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentdate.Location = new System.Drawing.Point(21, 30);
            this.lblRentdate.Name = "lblRentdate";
            this.lblRentdate.Size = new System.Drawing.Size(123, 17);
            this.lblRentdate.TabIndex = 22;
            this.lblRentdate.Text = "Дата на наемане";
            this.lblRentdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReturndate
            // 
            this.lblReturndate.AutoSize = true;
            this.lblReturndate.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturndate.Location = new System.Drawing.Point(21, 65);
            this.lblReturndate.Name = "lblReturndate";
            this.lblReturndate.Size = new System.Drawing.Size(124, 17);
            this.lblReturndate.TabIndex = 23;
            this.lblReturndate.Text = "Дата на връщане";
            this.lblReturndate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboxPay
            // 
            this.gboxPay.BackColor = System.Drawing.Color.LemonChiffon;
            this.gboxPay.Controls.Add(this.lblPayError);
            this.gboxPay.Controls.Add(this.rbuttonCash);
            this.gboxPay.Controls.Add(this.rbuttonBank);
            this.gboxPay.Controls.Add(this.lblPayway);
            this.gboxPay.Controls.Add(this.rbuttonCard);
            this.gboxPay.Location = new System.Drawing.Point(36, 289);
            this.gboxPay.Name = "gboxPay";
            this.gboxPay.Size = new System.Drawing.Size(576, 67);
            this.gboxPay.TabIndex = 18;
            this.gboxPay.TabStop = false;
            this.gboxPay.Text = "Плащане";
            // 
            // lblPayError
            // 
            this.lblPayError.AutoSize = true;
            this.lblPayError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPayError.Location = new System.Drawing.Point(21, 51);
            this.lblPayError.Name = "lblPayError";
            this.lblPayError.Size = new System.Drawing.Size(182, 13);
            this.lblPayError.TabIndex = 30;
            this.lblPayError.Text = "Моля изберете начин на плащане.";
            this.lblPayError.Visible = false;
            // 
            // rbuttonCash
            // 
            this.rbuttonCash.AutoSize = true;
            this.rbuttonCash.Location = new System.Drawing.Point(431, 25);
            this.rbuttonCash.Name = "rbuttonCash";
            this.rbuttonCash.Size = new System.Drawing.Size(59, 17);
            this.rbuttonCash.TabIndex = 21;
            this.rbuttonCash.TabStop = true;
            this.rbuttonCash.Text = "В брой";
            this.rbuttonCash.UseVisualStyleBackColor = true;
            // 
            // rbuttonBank
            // 
            this.rbuttonBank.AutoSize = true;
            this.rbuttonBank.Location = new System.Drawing.Point(342, 25);
            this.rbuttonBank.Name = "rbuttonBank";
            this.rbuttonBank.Size = new System.Drawing.Size(83, 17);
            this.rbuttonBank.TabIndex = 20;
            this.rbuttonBank.TabStop = true;
            this.rbuttonBank.Text = "Банков път";
            this.rbuttonBank.UseVisualStyleBackColor = true;
            // 
            // lblPayway
            // 
            this.lblPayway.AutoSize = true;
            this.lblPayway.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayway.Location = new System.Drawing.Point(12, 24);
            this.lblPayway.Name = "lblPayway";
            this.lblPayway.Size = new System.Drawing.Size(133, 17);
            this.lblPayway.TabIndex = 18;
            this.lblPayway.Text = "Начин на плащане";
            this.lblPayway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbuttonCard
            // 
            this.rbuttonCard.AutoSize = true;
            this.rbuttonCard.Location = new System.Drawing.Point(231, 25);
            this.rbuttonCard.Name = "rbuttonCard";
            this.rbuttonCard.Size = new System.Drawing.Size(105, 17);
            this.rbuttonCard.TabIndex = 19;
            this.rbuttonCard.TabStop = true;
            this.rbuttonCard.Text = "Кредитна карта";
            this.rbuttonCard.UseVisualStyleBackColor = true;
            // 
            // gboxVehicledata
            // 
            this.gboxVehicledata.BackColor = System.Drawing.Color.LemonChiffon;
            this.gboxVehicledata.Controls.Add(this.tboxCarprice);
            this.gboxVehicledata.Controls.Add(this.lblPrice3);
            this.gboxVehicledata.Controls.Add(this.lblPrice2);
            this.gboxVehicledata.Controls.Add(this.lblPrice1);
            this.gboxVehicledata.Controls.Add(this.cboxModel);
            this.gboxVehicledata.Controls.Add(this.checkSkitrunk);
            this.gboxVehicledata.Controls.Add(this.lblModel);
            this.gboxVehicledata.Controls.Add(this.checkChains);
            this.gboxVehicledata.Controls.Add(this.lblAdditional);
            this.gboxVehicledata.Controls.Add(this.checkChair);
            this.gboxVehicledata.Location = new System.Drawing.Point(36, 183);
            this.gboxVehicledata.Name = "gboxVehicledata";
            this.gboxVehicledata.Size = new System.Drawing.Size(576, 100);
            this.gboxVehicledata.TabIndex = 17;
            this.gboxVehicledata.TabStop = false;
            this.gboxVehicledata.Text = "Данни за автомобила";
            // 
            // tboxCarprice
            // 
            this.tboxCarprice.Location = new System.Drawing.Point(517, 28);
            this.tboxCarprice.Name = "tboxCarprice";
            this.tboxCarprice.ReadOnly = true;
            this.tboxCarprice.Size = new System.Drawing.Size(43, 20);
            this.tboxCarprice.TabIndex = 20;
            // 
            // lblPrice3
            // 
            this.lblPrice3.AutoSize = true;
            this.lblPrice3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice3.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPrice3.Location = new System.Drawing.Point(428, 79);
            this.lblPrice3.Name = "lblPrice3";
            this.lblPrice3.Size = new System.Drawing.Size(43, 15);
            this.lblPrice3.TabIndex = 19;
            this.lblPrice3.Text = "+30лв.";
            this.lblPrice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPrice2.Location = new System.Drawing.Point(319, 79);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(43, 15);
            this.lblPrice2.TabIndex = 18;
            this.lblPrice2.Text = "+45лв.";
            this.lblPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPrice1.Location = new System.Drawing.Point(212, 79);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(43, 15);
            this.lblPrice1.TabIndex = 17;
            this.lblPrice1.Text = "+40лв.";
            this.lblPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxModel
            // 
            this.cboxModel.FormattingEnabled = true;
            this.cboxModel.Items.AddRange(new object[] {
            "Audi A4",
            "Mazda 6",
            "Renault Clio",
            "Toyota Avensis",
            "Toyota Land Cruiser",
            "VW Multivan"});
            this.cboxModel.Location = new System.Drawing.Point(219, 28);
            this.cboxModel.Name = "cboxModel";
            this.cboxModel.Size = new System.Drawing.Size(285, 21);
            this.cboxModel.TabIndex = 16;
            this.cboxModel.SelectedIndexChanged += new System.EventHandler(this.cboxModel_SelectedIndexChanged);
            // 
            // checkSkitrunk
            // 
            this.checkSkitrunk.AutoSize = true;
            this.checkSkitrunk.Location = new System.Drawing.Point(431, 61);
            this.checkSkitrunk.Name = "checkSkitrunk";
            this.checkSkitrunk.Size = new System.Drawing.Size(112, 17);
            this.checkSkitrunk.TabIndex = 14;
            this.checkSkitrunk.Text = "Багажник за ски";
            this.checkSkitrunk.UseVisualStyleBackColor = true;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(12, 28);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(149, 17);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Модел на автомобил";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkChains
            // 
            this.checkChains.AutoSize = true;
            this.checkChains.Location = new System.Drawing.Point(322, 61);
            this.checkChains.Name = "checkChains";
            this.checkChains.Size = new System.Drawing.Size(103, 17);
            this.checkChains.TabIndex = 13;
            this.checkChains.Text = "Вериги за сняг";
            this.checkChains.UseVisualStyleBackColor = true;
            // 
            // lblAdditional
            // 
            this.lblAdditional.AutoSize = true;
            this.lblAdditional.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditional.Location = new System.Drawing.Point(12, 59);
            this.lblAdditional.Name = "lblAdditional";
            this.lblAdditional.Size = new System.Drawing.Size(190, 17);
            this.lblAdditional.TabIndex = 11;
            this.lblAdditional.Text = "Допълнително оборудване";
            this.lblAdditional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkChair
            // 
            this.checkChair.AutoSize = true;
            this.checkChair.Location = new System.Drawing.Point(215, 61);
            this.checkChair.Name = "checkChair";
            this.checkChair.Size = new System.Drawing.Size(101, 17);
            this.checkChair.TabIndex = 12;
            this.checkChair.Text = "Детско столче";
            this.checkChair.UseVisualStyleBackColor = true;
            // 
            // gboxPersonalinfo
            // 
            this.gboxPersonalinfo.BackColor = System.Drawing.Color.LemonChiffon;
            this.gboxPersonalinfo.Controls.Add(this.tboxName);
            this.gboxPersonalinfo.Controls.Add(this.tboxLastname);
            this.gboxPersonalinfo.Controls.Add(this.tboxAdress);
            this.gboxPersonalinfo.Controls.Add(this.tboxNumber);
            this.gboxPersonalinfo.Controls.Add(this.lblNumber);
            this.gboxPersonalinfo.Controls.Add(this.lblName);
            this.gboxPersonalinfo.Controls.Add(this.lblAdress);
            this.gboxPersonalinfo.Controls.Add(this.lblLastname);
            this.gboxPersonalinfo.Location = new System.Drawing.Point(87, 30);
            this.gboxPersonalinfo.Name = "gboxPersonalinfo";
            this.gboxPersonalinfo.Size = new System.Drawing.Size(480, 147);
            this.gboxPersonalinfo.TabIndex = 15;
            this.gboxPersonalinfo.TabStop = false;
            this.gboxPersonalinfo.Text = "Лични данни";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(176, 29);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(285, 20);
            this.tboxName.TabIndex = 1;
            // 
            // tboxLastname
            // 
            this.tboxLastname.Location = new System.Drawing.Point(176, 55);
            this.tboxLastname.Name = "tboxLastname";
            this.tboxLastname.Size = new System.Drawing.Size(285, 20);
            this.tboxLastname.TabIndex = 2;
            // 
            // tboxAdress
            // 
            this.tboxAdress.Location = new System.Drawing.Point(176, 81);
            this.tboxAdress.Name = "tboxAdress";
            this.tboxAdress.Size = new System.Drawing.Size(285, 20);
            this.tboxAdress.TabIndex = 3;
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(176, 107);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(285, 20);
            this.tboxNumber.TabIndex = 4;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(11, 107);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(68, 17);
            this.lblNumber.TabIndex = 9;
            this.lblNumber.Text = "Телефон";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Име";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(11, 81);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(48, 17);
            this.lblAdress.TabIndex = 8;
            this.lblAdress.Text = "Адрес";
            this.lblAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(11, 55);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(67, 17);
            this.lblLastname.TabIndex = 7;
            this.lblLastname.Text = "Фамилия";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 626);
            this.Controls.Add(this.gboxMaster);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Резервация на автомобил";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxMaster.ResumeLayout(false);
            this.gboxSum.ResumeLayout(false);
            this.gboxSum.PerformLayout();
            this.gboxDate.ResumeLayout(false);
            this.gboxDate.PerformLayout();
            this.gboxPay.ResumeLayout(false);
            this.gboxPay.PerformLayout();
            this.gboxVehicledata.ResumeLayout(false);
            this.gboxVehicledata.PerformLayout();
            this.gboxPersonalinfo.ResumeLayout(false);
            this.gboxPersonalinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxLastname;
        private System.Windows.Forms.TextBox tboxAdress;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblAdditional;
        private System.Windows.Forms.CheckBox checkChair;
        private System.Windows.Forms.CheckBox checkChains;
        private System.Windows.Forms.CheckBox checkSkitrunk;
        private System.Windows.Forms.GroupBox gboxPersonalinfo;
        private System.Windows.Forms.ComboBox cboxModel;
        private System.Windows.Forms.GroupBox gboxVehicledata;
        private System.Windows.Forms.Label lblPayway;
        private System.Windows.Forms.RadioButton rbuttonCard;
        private System.Windows.Forms.RadioButton rbuttonBank;
        private System.Windows.Forms.RadioButton rbuttonCash;
        private System.Windows.Forms.GroupBox gboxPay;
        private System.Windows.Forms.Label lblRentdate;
        private System.Windows.Forms.Label lblReturndate;
        private System.Windows.Forms.DateTimePicker dateRent;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.GroupBox gboxDate;
        private System.Windows.Forms.GroupBox gboxSum;
        private System.Windows.Forms.TextBox tboxSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.GroupBox gboxMaster;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPrice3;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.TextBox tboxCarprice;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPayError;
    }
}

