namespace eLiving
{
    partial class BeginForm
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.BtnSelectMood = new System.Windows.Forms.Button();
            this.BtnAddANewMood = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TimerBackground = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.White;
            this.lblTitel.Location = new System.Drawing.Point(250, 50);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(466, 58);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "eLiving: HomeFeels";
            this.lblTitel.UseMnemonic = false;
            // 
            // BtnSelectMood
            // 
            this.BtnSelectMood.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectMood.Location = new System.Drawing.Point(129, 245);
            this.BtnSelectMood.Name = "BtnSelectMood";
            this.BtnSelectMood.Size = new System.Drawing.Size(174, 71);
            this.BtnSelectMood.TabIndex = 1;
            this.BtnSelectMood.Text = "Select a mood";
            this.BtnSelectMood.UseVisualStyleBackColor = true;
            this.BtnSelectMood.Click += new System.EventHandler(this.btnSelectMood_Click);
            // 
            // BtnAddANewMood
            // 
            this.BtnAddANewMood.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddANewMood.Location = new System.Drawing.Point(402, 245);
            this.BtnAddANewMood.Name = "BtnAddANewMood";
            this.BtnAddANewMood.Size = new System.Drawing.Size(174, 71);
            this.BtnAddANewMood.TabIndex = 2;
            this.BtnAddANewMood.Text = "Add a new mood";
            this.BtnAddANewMood.UseVisualStyleBackColor = true;
            this.BtnAddANewMood.Click += new System.EventHandler(this.BtnAddANewMood_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistory.Location = new System.Drawing.Point(672, 245);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(174, 71);
            this.BtnHistory.TabIndex = 3;
            this.BtnHistory.Text = "History";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // TimerBackground
            // 
            this.TimerBackground.Enabled = true;
            this.TimerBackground.Interval = 10;
            this.TimerBackground.Tick += new System.EventHandler(this.timerBackground_Tick);
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.BtnAddANewMood);
            this.Controls.Add(this.BtnSelectMood);
            this.Controls.Add(this.lblTitel);
            this.Name = "BeginForm";
            this.Text = "eLivning: HomeFeels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button BtnSelectMood;
        private System.Windows.Forms.Button BtnAddANewMood;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Timer TimerBackground;
    }
}

