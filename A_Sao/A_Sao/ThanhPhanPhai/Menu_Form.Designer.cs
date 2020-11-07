namespace A_Sao.ThanhPhanPhai
{
    partial class Menu_Form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flControl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbMTK = new System.Windows.Forms.Label();
            this.rtxtMTK = new System.Windows.Forms.RichTextBox();
            this.flMain.SuspendLayout();
            this.flControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // flMain
            // 
            this.flMain.Controls.Add(this.flControl);
            this.flMain.Controls.Add(this.lbMTK);
            this.flMain.Controls.Add(this.rtxtMTK);
            this.flMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flMain.Location = new System.Drawing.Point(0, 0);
            this.flMain.Name = "flMain";
            this.flMain.Size = new System.Drawing.Size(385, 680);
            this.flMain.TabIndex = 0;
            // 
            // flControl
            // 
            this.flControl.Controls.Add(this.btnStart);
            this.flControl.Controls.Add(this.btnReset);
            this.flControl.Controls.Add(this.btnHelp);
            this.flControl.Location = new System.Drawing.Point(3, 3);
            this.flControl.Name = "flControl";
            this.flControl.Size = new System.Drawing.Size(382, 167);
            this.flControl.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(326, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(3, 57);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 48);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(169, 57);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(160, 48);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // lbMTK
            // 
            this.lbMTK.AutoSize = true;
            this.lbMTK.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMTK.Location = new System.Drawing.Point(3, 173);
            this.lbMTK.Name = "lbMTK";
            this.lbMTK.Size = new System.Drawing.Size(213, 39);
            this.lbMTK.TabIndex = 1;
            this.lbMTK.Text = "Ma trận kề là:";
            // 
            // rtxtMTK
            // 
            this.rtxtMTK.BackColor = System.Drawing.Color.White;
            this.rtxtMTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMTK.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMTK.Location = new System.Drawing.Point(3, 215);
            this.rtxtMTK.Name = "rtxtMTK";
            this.rtxtMTK.ReadOnly = true;
            this.rtxtMTK.Size = new System.Drawing.Size(361, 260);
            this.rtxtMTK.TabIndex = 2;
            this.rtxtMTK.Text = "";
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.flMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Menu_Form";
            this.Size = new System.Drawing.Size(504, 704);
            this.flMain.ResumeLayout(false);
            this.flMain.PerformLayout();
            this.flControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flMain;
        private System.Windows.Forms.FlowLayoutPanel flControl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lbMTK;
        private System.Windows.Forms.RichTextBox rtxtMTK;
    }
}
