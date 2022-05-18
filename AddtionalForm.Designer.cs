namespace WinFormsApp1
{
    partial class AddtionalForm
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
            this.txt_nameMed = new System.Windows.Forms.TextBox();
            this.txt_expDate = new System.Windows.Forms.TextBox();
            this.txt_prodDate = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nameMed
            // 
            this.txt_nameMed.Location = new System.Drawing.Point(148, 60);
            this.txt_nameMed.Name = "txt_nameMed";
            this.txt_nameMed.Size = new System.Drawing.Size(149, 23);
            this.txt_nameMed.TabIndex = 0;
            this.txt_nameMed.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nameMed_Validating);
            this.txt_nameMed.Validated += new System.EventHandler(this.txt_nameMed_Validated);
            // 
            // txt_expDate
            // 
            this.txt_expDate.Location = new System.Drawing.Point(148, 89);
            this.txt_expDate.Name = "txt_expDate";
            this.txt_expDate.Size = new System.Drawing.Size(149, 23);
            this.txt_expDate.TabIndex = 1;
            this.txt_expDate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_expDate_Validating);
            this.txt_expDate.Validated += new System.EventHandler(this.txt_expDate_Validated);
            // 
            // txt_prodDate
            // 
            this.txt_prodDate.Location = new System.Drawing.Point(148, 118);
            this.txt_prodDate.Name = "txt_prodDate";
            this.txt_prodDate.Size = new System.Drawing.Size(149, 23);
            this.txt_prodDate.TabIndex = 2;
            this.txt_prodDate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_prodDate_Validating);
            this.txt_prodDate.Validated += new System.EventHandler(this.txt_prodDate_Validated);
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(148, 147);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(149, 23);
            this.txt_count.TabIndex = 3;
            this.txt_count.Validating += new System.ComponentModel.CancelEventHandler(this.txt_count_Validating);
            this.txt_count.Validated += new System.EventHandler(this.txt_count_Validated);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(148, 176);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(149, 23);
            this.txt_price.TabIndex = 4;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            this.txt_price.Validating += new System.ComponentModel.CancelEventHandler(this.txt_price_Validating);
            this.txt_price.Validated += new System.EventHandler(this.txt_price_Validated);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(51, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name of the medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Expiration date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Production date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(45, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Form for adding a new entry";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(148, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddtionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_prodDate);
            this.Controls.Add(this.txt_expDate);
            this.Controls.Add(this.txt_nameMed);
            this.Location = new System.Drawing.Point(200, 300);
            this.Name = "AddtionalForm";
            this.Text = "AddtionalForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_nameMed;
        private TextBox txt_expDate;
        private TextBox txt_prodDate;
        private TextBox txt_count;
        private TextBox txt_price;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private ErrorProvider errorProvider1;
    }
}