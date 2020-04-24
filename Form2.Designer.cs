namespace suspliers
{
    partial class Form2
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label company_NameLabel;
            System.Windows.Forms.Label postal_CodeLabel;
            System.Windows.Forms.Label cityLabel;
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.suppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.company_NameTextBox = new System.Windows.Forms.TextBox();
            this.postal_CodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            company_NameLabel = new System.Windows.Forms.Label();
            postal_CodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.Location = new System.Drawing.Point(28, 22);
            iDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(33, 21);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // company_NameLabel
            // 
            company_NameLabel.AutoSize = true;
            company_NameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            company_NameLabel.Location = new System.Drawing.Point(28, 49);
            company_NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            company_NameLabel.Name = "company_NameLabel";
            company_NameLabel.Size = new System.Drawing.Size(135, 21);
            company_NameLabel.TabIndex = 3;
            company_NameLabel.Text = "Company Name:";
            // 
            // postal_CodeLabel
            // 
            postal_CodeLabel.AutoSize = true;
            postal_CodeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            postal_CodeLabel.Location = new System.Drawing.Point(28, 73);
            postal_CodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            postal_CodeLabel.Name = "postal_CodeLabel";
            postal_CodeLabel.Size = new System.Drawing.Size(106, 21);
            postal_CodeLabel.TabIndex = 5;
            postal_CodeLabel.Text = "Postal Code:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cityLabel.Location = new System.Drawing.Point(28, 104);
            cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(45, 21);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(172, 23);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(76, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // suppBindingSource
            // 
            this.suppBindingSource.DataSource = typeof(suspliers.supp);
            // 
            // company_NameTextBox
            // 
            this.company_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppBindingSource, "Company_Name", true));
            this.company_NameTextBox.Location = new System.Drawing.Point(172, 47);
            this.company_NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.company_NameTextBox.Name = "company_NameTextBox";
            this.company_NameTextBox.Size = new System.Drawing.Size(76, 20);
            this.company_NameTextBox.TabIndex = 4;
            // 
            // postal_CodeTextBox
            // 
            this.postal_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppBindingSource, "Postal_Code", true));
            this.postal_CodeTextBox.Location = new System.Drawing.Point(172, 71);
            this.postal_CodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postal_CodeTextBox.Name = "postal_CodeTextBox";
            this.postal_CodeTextBox.Size = new System.Drawing.Size(76, 20);
            this.postal_CodeTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(172, 95);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(76, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(32, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(172, 171);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(postal_CodeLabel);
            this.Controls.Add(this.postal_CodeTextBox);
            this.Controls.Add(company_NameLabel);
            this.Controls.Add(this.company_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource suppBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox company_NameTextBox;
        private System.Windows.Forms.TextBox postal_CodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}