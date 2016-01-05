namespace AsyncPersonExample
{
    partial class PersonListDialog
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
            this.ComboBoxPersonList = new System.Windows.Forms.ComboBox();
            this.ButtonGetPersonList = new System.Windows.Forms.Button();
            this.LabelResponsiveUI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxPersonList
            // 
            this.ComboBoxPersonList.FormattingEnabled = true;
            this.ComboBoxPersonList.Location = new System.Drawing.Point(37, 60);
            this.ComboBoxPersonList.Name = "ComboBoxPersonList";
            this.ComboBoxPersonList.Size = new System.Drawing.Size(202, 21);
            this.ComboBoxPersonList.TabIndex = 0;
            // 
            // ButtonGetPersonList
            // 
            this.ButtonGetPersonList.Location = new System.Drawing.Point(72, 131);
            this.ButtonGetPersonList.Name = "ButtonGetPersonList";
            this.ButtonGetPersonList.Size = new System.Drawing.Size(130, 31);
            this.ButtonGetPersonList.TabIndex = 1;
            this.ButtonGetPersonList.Text = "Get Person List";
            this.ButtonGetPersonList.UseVisualStyleBackColor = true;
            this.ButtonGetPersonList.Click += new System.EventHandler(this.Handle_GetPersonListButtonClick);
            // 
            // LabelResponsiveUI
            // 
            this.LabelResponsiveUI.AutoSize = true;
            this.LabelResponsiveUI.Location = new System.Drawing.Point(34, 24);
            this.LabelResponsiveUI.Name = "LabelResponsiveUI";
            this.LabelResponsiveUI.Size = new System.Drawing.Size(114, 13);
            this.LabelResponsiveUI.TabIndex = 2;
            this.LabelResponsiveUI.Text = "See...Responsive UI...";
            this.LabelResponsiveUI.Visible = false;
            // 
            // PersonListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LabelResponsiveUI);
            this.Controls.Add(this.ButtonGetPersonList);
            this.Controls.Add(this.ComboBoxPersonList);
            this.Name = "PersonListDialog";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxPersonList;
        private System.Windows.Forms.Button ButtonGetPersonList;
        private System.Windows.Forms.Label LabelResponsiveUI;
    }
}

