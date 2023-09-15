namespace WindowsFormsApp1
{
    partial class DSMessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.labelText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.separator);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panel1.Size = new System.Drawing.Size(199, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSize = true;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAccept.Location = new System.Drawing.Point(19, 15);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Padding = new System.Windows.Forms.Padding(5);
            this.btnAccept.Size = new System.Drawing.Size(75, 33);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.SystemColors.Control;
            this.separator.Dock = System.Windows.Forms.DockStyle.Right;
            this.separator.Location = new System.Drawing.Point(94, 15);
            this.separator.Name = "separator";
            this.separator.Padding = new System.Windows.Forms.Padding(5);
            this.separator.Size = new System.Drawing.Size(10, 33);
            this.separator.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(104, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureIcon
            // 
            this.pictureIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(74, 73);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureIcon.TabIndex = 1;
            this.pictureIcon.TabStop = false;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelText.Location = new System.Drawing.Point(74, 0);
            this.labelText.Name = "labelText";
            this.labelText.Padding = new System.Windows.Forms.Padding(0, 28, 25, 20);
            this.labelText.Size = new System.Drawing.Size(54, 61);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Text";
            // 
            // DSMessageBox
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(199, 136);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.pictureIcon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DSMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DSMessageBox_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label separator;
    }
}