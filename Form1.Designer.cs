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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(19, 60);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name (letters and spaces only)";
            txtName.Size = new Size(227, 27);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(227, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(19, 163);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone (e.g., +201234567890)";
            txtPhone.Size = new Size(227, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(281, 60);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(229, 27);
            txtPassword.TabIndex = 2;
            toolTip2.SetToolTip(txtPassword, "7-16 characters, at least one uppercase letter, one lowercase letter, and one number");
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(281, 116);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(229, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(281, 163);
            txtPostal.Name = "txtPostal";
            txtPostal.PlaceholderText = "Postal Code (5-6 digits)";
            txtPostal.Size = new Size(229, 27);
            txtPostal.TabIndex = 6;
            // 
            // txtCV
            // 
            txtCV.Location = new Point(606, 80);
            txtCV.Multiline = true;
            txtCV.Name = "txtCV";
            txtCV.PlaceholderText = "Paste your CV here...";
            txtCV.Size = new Size(300, 175);
            txtCV.TabIndex = 8;
            // 
            // btnValidateForm
            // 
            btnValidateForm.Location = new Point(161, 213);
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
            groupBox1.Size = new Size(532, 267);
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
    }
}
