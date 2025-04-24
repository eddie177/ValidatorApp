namespace ValidatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtName, txtEmail, txtPhone, txtPassword, txtAddress, txtPostal, txtCV;
        private Button btnValidateForm, btnParseCV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            txtPostal = new TextBox();
            txtCV = new TextBox();
            btnValidateForm = new Button();
            btnParseCV = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            toolTip2 = new ToolTip(components);
            btnExtract = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(19, 68);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Letters and spaces only";
            txtName.Size = new Size(227, 27);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "e.g. john@uni.edu.eg";
            txtEmail.Size = new Size(227, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(19, 194);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "e.g., +201234567890";
            txtPhone.Size = new Size(227, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(281, 68);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "e.g. 32895Ak";
            txtPassword.Size = new Size(229, 27);
            txtPassword.TabIndex = 2;
            toolTip2.SetToolTip(txtPassword, "7-16 characters, at least one uppercase letter, one lowercase letter, and one number");
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(281, 131);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "e.g. 17 Galaa St. Mansoura";
            txtAddress.Size = new Size(229, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(281, 194);
            txtPostal.Name = "txtPostal";
            txtPostal.PlaceholderText = "5-6 digits";
            txtPostal.Size = new Size(229, 27);
            txtPostal.TabIndex = 6;
            // 
            // txtCV
            // 
            txtCV.Location = new Point(606, 80);
            txtCV.Multiline = true;
            txtCV.Name = "txtCV";
            txtCV.PlaceholderText = "Paste your CV here...";
            txtCV.ScrollBars = ScrollBars.Both;
            txtCV.Size = new Size(300, 175);
            txtCV.TabIndex = 8;
            // 
            // btnValidateForm
            // 
            btnValidateForm.Location = new Point(154, 255);
            btnValidateForm.Name = "btnValidateForm";
            btnValidateForm.Size = new Size(200, 30);
            btnValidateForm.TabIndex = 7;
            btnValidateForm.Text = "Validate Form";
            btnValidateForm.Click += btnValidateForm_Click;
            // 
            // btnParseCV
            // 
            btnParseCV.Location = new Point(606, 281);
            btnParseCV.Name = "btnParseCV";
            btnParseCV.Size = new Size(300, 30);
            btnParseCV.TabIndex = 9;
            btnParseCV.Text = "Parse";
            btnParseCV.Click += btnParseCV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(716, 44);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 10;
            label1.Text = "CV Validtor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, -19);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnValidateForm);
            groupBox1.Controls.Add(txtPostal);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Location = new Point(28, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 316);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manual Form Entry";
            // 
            // btnExtract
            // 
            btnExtract.Location = new Point(606, 331);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(300, 29);
            btnExtract.TabIndex = 10;
            btnExtract.Text = "Extract Parsing";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 45);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 45);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 108);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 14;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 108);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 15;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 171);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 16;
            label7.Text = "Phone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(281, 171);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 17;
            label8.Text = "Postal Code:";
            // 
            // Form1
            // 
            ClientSize = new Size(948, 384);
            Controls.Add(btnExtract);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtCV);
            Controls.Add(btnParseCV);
            Name = "Form1";
            Text = "Smart CV & Form Validator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Button btnExtract;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
