﻿
namespace QuanLyQuanCoffe.View.Admin_Side
{
    partial class fAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ButtonReset = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonChangeImage = new Guna.UI2.WinForms.Guna2Button();
            this.itemImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ToggleAvailability = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thêm sản phẩm";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(208, 23);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 30);
            this.guna2VSeparator1.TabIndex = 16;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtPrice);
            this.guna2Panel1.Controls.Add(this.ButtonReset);
            this.guna2Panel1.Controls.Add(this.ButtonSave);
            this.guna2Panel1.Controls.Add(this.ButtonChangeImage);
            this.guna2Panel1.Controls.Add(this.itemImage);
            this.guna2Panel1.Controls.Add(this.ToggleAvailability);
            this.guna2Panel1.Controls.Add(this.cbType);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txtName);
            this.guna2Panel1.Location = new System.Drawing.Point(23, 78);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(712, 418);
            this.guna2Panel1.TabIndex = 15;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DecimalPlaces = 2;
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtPrice.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtPrice.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txtPrice.Location = new System.Drawing.Point(303, 240);
            this.txtPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(384, 36);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.UpDownButtonFillColor = System.Drawing.Color.LightGray;
            this.txtPrice.ValueChanged += new System.EventHandler(this.txtPrice_ValueChanged);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Animated = true;
            this.ButtonReset.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonReset.BorderThickness = 1;
            this.ButtonReset.FillColor = System.Drawing.Color.White;
            this.ButtonReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonReset.Location = new System.Drawing.Point(303, 355);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(180, 45);
            this.ButtonReset.TabIndex = 7;
            this.ButtonReset.Text = "Làm mới";
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click_1);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Animated = true;
            this.ButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(507, 355);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(180, 45);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Lưu";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonChangeImage
            // 
            this.ButtonChangeImage.Animated = true;
            this.ButtonChangeImage.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonChangeImage.BorderThickness = 1;
            this.ButtonChangeImage.FillColor = System.Drawing.Color.White;
            this.ButtonChangeImage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChangeImage.ForeColor = System.Drawing.Color.Black;
            this.ButtonChangeImage.Location = new System.Drawing.Point(18, 255);
            this.ButtonChangeImage.Name = "ButtonChangeImage";
            this.ButtonChangeImage.Size = new System.Drawing.Size(239, 33);
            this.ButtonChangeImage.TabIndex = 6;
            this.ButtonChangeImage.Text = "Đổi ảnh";
            this.ButtonChangeImage.Click += new System.EventHandler(this.ButtonChangeImage_Click_1);
            // 
            // itemImage
            // 
            this.itemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.itemImage.Image = ((System.Drawing.Image)(resources.GetObject("itemImage.Image")));
            this.itemImage.ImageLocation = "";
            this.itemImage.ImageRotate = 0F;
            this.itemImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("itemImage.InitialImage")));
            this.itemImage.Location = new System.Drawing.Point(18, 64);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(239, 185);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemImage.TabIndex = 5;
            this.itemImage.TabStop = false;
            // 
            // ToggleAvailability
            // 
            this.ToggleAvailability.Animated = true;
            this.ToggleAvailability.Checked = true;
            this.ToggleAvailability.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleAvailability.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleAvailability.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleAvailability.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleAvailability.Location = new System.Drawing.Point(400, 307);
            this.ToggleAvailability.Name = "ToggleAvailability";
            this.ToggleAvailability.Size = new System.Drawing.Size(35, 20);
            this.ToggleAvailability.TabIndex = 3;
            this.ToggleAvailability.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleAvailability.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleAvailability.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleAvailability.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.Animated = true;
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.Empty;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 30;
            this.cbType.Location = new System.Drawing.Point(303, 161);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(384, 36);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Is Available?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên món";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Animated = true;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(303, 64);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "(e.g. Hamburger)";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(384, 36);
            this.txtName.TabIndex = 0;
            // 
            // fAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddProduct";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtPrice;
        private Guna.UI2.WinForms.Guna2Button ButtonReset;
        public Guna.UI2.WinForms.Guna2Button ButtonSave;
        private Guna.UI2.WinForms.Guna2Button ButtonChangeImage;
        private Guna.UI2.WinForms.Guna2PictureBox itemImage;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleAvailability;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
    }
}