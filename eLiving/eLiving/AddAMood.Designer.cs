namespace eLiving
{
    partial class AddAMood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAMood));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrackBarRed = new System.Windows.Forms.TrackBar();
            this.TrackBarGreen = new System.Windows.Forms.TrackBar();
            this.TrackBarBlue = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DropDownMenuScents = new System.Windows.Forms.ComboBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.dropDownMenuPlaylists = new System.Windows.Forms.ComboBox();
            this.pictureBoxMusic = new System.Windows.Forms.PictureBox();
            this.RGBPreview = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGoBack);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtBoxName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DropDownMenuScents);
            this.groupBox1.Controls.Add(this.trackBarVolume);
            this.groupBox1.Controls.Add(this.dropDownMenuPlaylists);
            this.groupBox1.Controls.Add(this.pictureBoxMusic);
            this.groupBox1.Controls.Add(this.RGBPreview);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblBlueValue);
            this.groupBox1.Controls.Add(this.lblGreenValue);
            this.groupBox1.Controls.Add(this.lblRedValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TrackBarBlue);
            this.groupBox1.Controls.Add(this.TrackBarGreen);
            this.groupBox1.Controls.Add(this.TrackBarRed);
            this.groupBox1.Location = new System.Drawing.Point(100, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a mood";
            // 
            // TrackBarRed
            // 
            this.TrackBarRed.Location = new System.Drawing.Point(6, 55);
            this.TrackBarRed.Maximum = 255;
            this.TrackBarRed.Name = "TrackBarRed";
            this.TrackBarRed.Size = new System.Drawing.Size(164, 45);
            this.TrackBarRed.TabIndex = 0;
            this.TrackBarRed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBarRed.ValueChanged += new System.EventHandler(this.TrackBarRed_ValueChanged);
            // 
            // TrackBarGreen
            // 
            this.TrackBarGreen.Location = new System.Drawing.Point(6, 120);
            this.TrackBarGreen.Maximum = 255;
            this.TrackBarGreen.Name = "TrackBarGreen";
            this.TrackBarGreen.Size = new System.Drawing.Size(164, 45);
            this.TrackBarGreen.TabIndex = 1;
            this.TrackBarGreen.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBarGreen.ValueChanged += new System.EventHandler(this.TrackBarGreen_ValueChanged);
            // 
            // TrackBarBlue
            // 
            this.TrackBarBlue.Location = new System.Drawing.Point(6, 179);
            this.TrackBarBlue.Maximum = 255;
            this.TrackBarBlue.Name = "TrackBarBlue";
            this.TrackBarBlue.Size = new System.Drawing.Size(164, 45);
            this.TrackBarBlue.TabIndex = 2;
            this.TrackBarBlue.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBarBlue.ValueChanged += new System.EventHandler(this.TrackBarBlue_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Scent:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Volume:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Playlist:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Music:";
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueValue.Location = new System.Drawing.Point(141, 160);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(29, 16);
            this.lblBlueValue.TabIndex = 22;
            this.lblBlueValue.Text = "000";
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenValue.Location = new System.Drawing.Point(141, 103);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(29, 16);
            this.lblGreenValue.TabIndex = 21;
            this.lblGreenValue.Text = "000";
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedValue.Location = new System.Drawing.Point(141, 36);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(29, 16);
            this.lblRedValue.TabIndex = 20;
            this.lblRedValue.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Blue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Green:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Red:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Lighting:";
            // 
            // DropDownMenuScents
            // 
            this.DropDownMenuScents.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownMenuScents.FormattingEnabled = true;
            this.DropDownMenuScents.Location = new System.Drawing.Point(328, 173);
            this.DropDownMenuScents.Name = "DropDownMenuScents";
            this.DropDownMenuScents.Size = new System.Drawing.Size(95, 24);
            this.DropDownMenuScents.TabIndex = 32;
            this.DropDownMenuScents.SelectedIndexChanged += new System.EventHandler(this.DropDownMenuScents_SelectedIndexChanged);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.White;
            this.trackBarVolume.Location = new System.Drawing.Point(328, 120);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(94, 45);
            this.trackBarVolume.TabIndex = 31;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // dropDownMenuPlaylists
            // 
            this.dropDownMenuPlaylists.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownMenuPlaylists.FormattingEnabled = true;
            this.dropDownMenuPlaylists.Location = new System.Drawing.Point(330, 74);
            this.dropDownMenuPlaylists.Name = "dropDownMenuPlaylists";
            this.dropDownMenuPlaylists.Size = new System.Drawing.Size(95, 24);
            this.dropDownMenuPlaylists.TabIndex = 30;
            this.dropDownMenuPlaylists.SelectedIndexChanged += new System.EventHandler(this.dropDownMenuPlaylists_SelectedIndexChanged);
            // 
            // pictureBoxMusic
            // 
            this.pictureBoxMusic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMusic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMusic.Image")));
            this.pictureBoxMusic.Location = new System.Drawing.Point(428, 55);
            this.pictureBoxMusic.Name = "pictureBoxMusic";
            this.pictureBoxMusic.Size = new System.Drawing.Size(146, 146);
            this.pictureBoxMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMusic.TabIndex = 29;
            this.pictureBoxMusic.TabStop = false;
            // 
            // RGBPreview
            // 
            this.RGBPreview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RGBPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RGBPreview.Location = new System.Drawing.Point(176, 55);
            this.RGBPreview.Name = "RGBPreview";
            this.RGBPreview.Size = new System.Drawing.Size(146, 146);
            this.RGBPreview.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Scent:";
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(583, 74);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(124, 20);
            this.TxtBoxName.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(580, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(580, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "Finish:";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(580, 174);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(124, 23);
            this.btnGoBack.TabIndex = 38;
            this.btnGoBack.Text = "Go back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(580, 142);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(124, 23);
            this.btnConfirm.TabIndex = 37;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(260, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(437, 62);
            this.lblTitel.TabIndex = 39;
            this.lblTitel.Text = "Add a new mood:";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitel.UseMnemonic = false;
            // 
            // AddAMood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AddAMood";
            this.Text = "AddAMood";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar TrackBarBlue;
        private System.Windows.Forms.TrackBar TrackBarGreen;
        private System.Windows.Forms.TrackBar TrackBarRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DropDownMenuScents;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.ComboBox dropDownMenuPlaylists;
        private System.Windows.Forms.PictureBox pictureBoxMusic;
        private System.Windows.Forms.Panel RGBPreview;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTitel;
    }
}