namespace HotelManager.components
{
    partial class ServiceForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnAdd = new System.Windows.Forms.Button();
			this.roomFormLabel = new System.Windows.Forms.Label();
			this.closeRoomFormBtn = new FontAwesome.Sharp.IconButton();
			this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.Nametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.Pricetxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.ServiceDatagridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.btnUpdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ServiceDatagridview)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(334, 419);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(220, 49);
			this.btnAdd.TabIndex = 57;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// roomFormLabel
			// 
			this.roomFormLabel.AutoSize = true;
			this.roomFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.roomFormLabel.ForeColor = System.Drawing.Color.White;
			this.roomFormLabel.Location = new System.Drawing.Point(474, 62);
			this.roomFormLabel.Name = "roomFormLabel";
			this.roomFormLabel.Size = new System.Drawing.Size(101, 29);
			this.roomFormLabel.TabIndex = 56;
			this.roomFormLabel.Text = "Service";
			this.roomFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.roomFormLabel.Click += new System.EventHandler(this.roomFormLabel_Click);
			// 
			// closeRoomFormBtn
			// 
			this.closeRoomFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeRoomFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.closeRoomFormBtn.FlatAppearance.BorderSize = 0;
			this.closeRoomFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeRoomFormBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
			this.closeRoomFormBtn.IconColor = System.Drawing.Color.White;
			this.closeRoomFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.closeRoomFormBtn.IconSize = 32;
			this.closeRoomFormBtn.Location = new System.Drawing.Point(1021, -1);
			this.closeRoomFormBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.closeRoomFormBtn.Name = "closeRoomFormBtn";
			this.closeRoomFormBtn.Size = new System.Drawing.Size(56, 46);
			this.closeRoomFormBtn.TabIndex = 53;
			this.closeRoomFormBtn.UseVisualStyleBackColor = false;
			this.closeRoomFormBtn.Click += new System.EventHandler(this.closeRoomFormBtn_Click);
			// 
			// bunifuCustomLabel10
			// 
			this.bunifuCustomLabel10.AutoSize = true;
			this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel10.Location = new System.Drawing.Point(63, 209);
			this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
			this.bunifuCustomLabel10.Size = new System.Drawing.Size(61, 21);
			this.bunifuCustomLabel10.TabIndex = 129;
			this.bunifuCustomLabel10.Text = "Name";
			// 
			// Nametxt
			// 
			this.Nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Nametxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nametxt.ForeColor = System.Drawing.Color.White;
			this.Nametxt.HintForeColor = System.Drawing.Color.White;
			this.Nametxt.HintText = "";
			this.Nametxt.isPassword = false;
			this.Nametxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.Nametxt.LineIdleColor = System.Drawing.Color.Gray;
			this.Nametxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.Nametxt.LineThickness = 4;
			this.Nametxt.Location = new System.Drawing.Point(204, 181);
			this.Nametxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Nametxt.Name = "Nametxt";
			this.Nametxt.Size = new System.Drawing.Size(288, 64);
			this.Nametxt.TabIndex = 128;
			this.Nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(59, 310);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(50, 21);
			this.bunifuCustomLabel1.TabIndex = 131;
			this.bunifuCustomLabel1.Text = "Price";
			this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
			// 
			// Pricetxt
			// 
			this.Pricetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Pricetxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pricetxt.ForeColor = System.Drawing.Color.White;
			this.Pricetxt.HintForeColor = System.Drawing.Color.White;
			this.Pricetxt.HintText = "";
			this.Pricetxt.isPassword = false;
			this.Pricetxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.Pricetxt.LineIdleColor = System.Drawing.Color.Gray;
			this.Pricetxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.Pricetxt.LineThickness = 4;
			this.Pricetxt.Location = new System.Drawing.Point(200, 282);
			this.Pricetxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Pricetxt.Name = "Pricetxt";
			this.Pricetxt.Size = new System.Drawing.Size(292, 64);
			this.Pricetxt.TabIndex = 130;
			this.Pricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.Pricetxt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
			// 
			// ServiceDatagridview
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ServiceDatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.ServiceDatagridview.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.ServiceDatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ServiceDatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ServiceDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.ServiceDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ServiceDatagridview.DoubleBuffered = true;
			this.ServiceDatagridview.EnableHeadersVisualStyles = false;
			this.ServiceDatagridview.HeaderBgColor = System.Drawing.Color.SeaGreen;
			this.ServiceDatagridview.HeaderForeColor = System.Drawing.Color.SeaGreen;
			this.ServiceDatagridview.Location = new System.Drawing.Point(560, 152);
			this.ServiceDatagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ServiceDatagridview.Name = "ServiceDatagridview";
			this.ServiceDatagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ServiceDatagridview.RowHeadersWidth = 62;
			this.ServiceDatagridview.RowTemplate.Height = 28;
			this.ServiceDatagridview.Size = new System.Drawing.Size(453, 194);
			this.ServiceDatagridview.TabIndex = 132;
			this.ServiceDatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceDatagridview_CellClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(141)))));
			this.btnUpdate.Enabled = false;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(580, 419);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(220, 49);
			this.btnUpdate.TabIndex = 133;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
			// 
			// ServiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
			this.ClientSize = new System.Drawing.Size(1079, 561);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.ServiceDatagridview);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.Pricetxt);
			this.Controls.Add(this.bunifuCustomLabel10);
			this.Controls.Add(this.Nametxt);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.roomFormLabel);
			this.Controls.Add(this.closeRoomFormBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ServiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ServiceForm";
			this.Load += new System.EventHandler(this.ServiceForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ServiceDatagridview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label roomFormLabel;
        private FontAwesome.Sharp.IconButton closeRoomFormBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Nametxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Pricetxt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ServiceDatagridview;
        private System.Windows.Forms.Button btnUpdate;
    }
}