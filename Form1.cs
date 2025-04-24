using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ValidatorApp
{

    public partial class Form1 : Form
    {
        #region Constants
        // Regex patterns for validation
        private const string NamePattern = @"^[a-zA-Z\s]+$";
        private const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        private const string PhonePattern = @"^(\+20|0)1[0125]\d{8}$";
        private const string PasswordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{7,16}$";
        private const string AddressPattern = @".+";
        private const string PostalPattern = @"^\d{5,6}$";

        // CV Parsing patterns
        private const string CVNamePattern = @"(?<=Name[:\s]*)[A-Z][a-z]+\s[A-Z][a-z]+";
        private const string CVEmailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        private const string CVPhonePattern = @"(\+20|0)1[0125]\d{8}";
        private const string CVSkillsPattern = @"(?i)\b(C#|SQL|Python|AWS|JavaScript|PHP|HTML|CSS|Java|React|Node\.js)\b";
        private const string CVExperiencePattern = @"\b\d+\s+years?\b";
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        public string ValidateAndColor(TextBox field, string fieldName, string pattern)
        {
            if (Regex.IsMatch(field.Text, pattern))
            {
                field.BackColor = System.Drawing.Color.White;
                return $"{fieldName}: Valid\n";
            }
            else
            {
                field.BackColor = System.Drawing.Color.MistyRose;
                return $"{fieldName}: Invalid\n";
            }
        }


        private void btnValidateForm_Click(object sender, EventArgs e)
        {
            string result = "";
            result += ValidateAndColor(txtName, "Name", NamePattern);
            result += ValidateAndColor(txtEmail, "Email", EmailPattern);
            result += ValidateAndColor(txtPhone, "Phone", PhonePattern);
            result += ValidateAndColor(txtPassword, "Password", PasswordPattern);
            result += ValidateAndColor(txtAddress, "Address", AddressPattern);
            result += ValidateAndColor(txtPostal, "Postal Code", PostalPattern);

            MessageBox.Show(result, "Validation Results");
        }


        private string ValidateField(string fieldName, string input, string pattern)
        {
            return Regex.IsMatch(input, pattern)
                ? $"{fieldName}: Valid\n"
                : $"{fieldName}: Invalid\n";
        }


        private void btnParseCV_Click(object sender, EventArgs e)
        {
            string cvText = txtCV.Text;
            string result = "";

            var nameMatch = Regex.Match(cvText, CVNamePattern);
            var emailMatch = Regex.Match(cvText, CVEmailPattern);
            var phoneMatch = Regex.Match(cvText, CVPhonePattern);
            var skillsMatch = Regex.Matches(cvText, CVSkillsPattern);
            var expMatch = Regex.Match(cvText, CVExperiencePattern);

            result += $"Name: {nameMatch.Value}\n";
            result += $"Email: {emailMatch.Value}\n";
            result += $"Phone: {phoneMatch.Value}\n";
            result += "Skills: ";

            foreach (Match skill in skillsMatch)
            {
                result += $"{skill.Value}, ";
            }

            result = result.TrimEnd(',', ' ') + "\n";
            result += $"Experience: {expMatch.Value}\n";

            MessageBox.Show(result, "CV Parsing Result");
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            string cvText = txtCV.Text;
            string result = "";

            var nameMatch = Regex.Match(cvText, CVNamePattern);
            var emailMatch = Regex.Match(cvText, CVEmailPattern);
            var phoneMatch = Regex.Match(cvText, CVPhonePattern);
            var skillsMatch = Regex.Matches(cvText, CVSkillsPattern);
            var expMatch = Regex.Match(cvText, CVExperiencePattern);

            result += $"Name: {(nameMatch.Success ? nameMatch.Value : "Not found")}\n";
            result += $"Email: {(emailMatch.Success ? emailMatch.Value : "Not found")}\n";
            result += $"Phone: {(phoneMatch.Success ? phoneMatch.Value : "Not found")}\n";
            result += "Skills: ";

            foreach (Match skill in skillsMatch)
            {
                result += $"{skill.Value}, ";
            }
            result = result.TrimEnd(',', ' ') + "\n";
            result += $"Experience: {(expMatch.Success ? expMatch.Value : "Not found")}\n";

            // Choose location to save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                Title = "Save CV Info",
                FileName = "ParsedCV.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, result);
                MessageBox.Show("CV data extracted successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}