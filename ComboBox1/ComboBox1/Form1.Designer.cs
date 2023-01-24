namespace ComboBox1
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
            this.cmBoxOstan = new System.Windows.Forms.ComboBox();
            this.cmBoxCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmBoxOstan
            // 
            this.cmBoxOstan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxOstan.FormattingEnabled = true;
            this.cmBoxOstan.Location = new System.Drawing.Point(224, 146);
            this.cmBoxOstan.Name = "cmBoxOstan";
            this.cmBoxOstan.Size = new System.Drawing.Size(121, 21);
            this.cmBoxOstan.TabIndex = 0;
            this.cmBoxOstan.SelectedIndexChanged += new System.EventHandler(this.cmBoxOstan_SelectedIndexChanged);
            // 
            // cmBoxCity
            // 
            this.cmBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxCity.FormattingEnabled = true;
            this.cmBoxCity.Location = new System.Drawing.Point(367, 146);
            this.cmBoxCity.Name = "cmBoxCity";
            this.cmBoxCity.Size = new System.Drawing.Size(121, 21);
            this.cmBoxCity.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmBoxCity);
            this.Controls.Add(this.cmBoxOstan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxOstan;
        private System.Windows.Forms.ComboBox cmBoxCity;
    }
}

