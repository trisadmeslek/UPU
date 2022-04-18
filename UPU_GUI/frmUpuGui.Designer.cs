namespace UPU_GUI
{
    partial class frmUpuGui
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.cmbChooseEngine = new System.Windows.Forms.ComboBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.Location = new System.Drawing.Point(419, 12);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(29, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "...";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnUnpack
            // 
            this.btnUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpack.Location = new System.Drawing.Point(338, 41);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(75, 23);
            this.btnUnpack.TabIndex = 1;
            this.btnUnpack.Text = "Unpack";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // txtPackage
            // 
            this.txtPackage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPackage.Location = new System.Drawing.Point(12, 14);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.ReadOnly = true;
            this.txtPackage.Size = new System.Drawing.Size(401, 20);
            this.txtPackage.TabIndex = 2;
            // 
            // cmbChooseEngine
            // 
            this.cmbChooseEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChooseEngine.FormattingEnabled = true;
            this.cmbChooseEngine.Items.AddRange(new object[] {
            "UPU Console",
            "Unity Packager"});
            this.cmbChooseEngine.Location = new System.Drawing.Point(198, 41);
            this.cmbChooseEngine.Name = "cmbChooseEngine";
            this.cmbChooseEngine.Size = new System.Drawing.Size(121, 21);
            this.cmbChooseEngine.TabIndex = 3;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(54, 46);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(138, 13);
            this.lblEngine.TabIndex = 4;
            this.lblEngine.Text = "Choose Unpacker Engine : ";
            // 
            // frmUpuGui
            // 
            this.AcceptButton = this.btnUnpack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 74);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.cmbChooseEngine);
            this.Controls.Add(this.txtPackage);
            this.Controls.Add(this.btnUnpack);
            this.Controls.Add(this.btnChoose);
            this.Name = "frmUpuGui";
            this.Text = "UPU GUI";
            this.Load += new System.EventHandler(this.frmUpuGui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.ComboBox cmbChooseEngine;
        private System.Windows.Forms.Label lblEngine;
    }
}

