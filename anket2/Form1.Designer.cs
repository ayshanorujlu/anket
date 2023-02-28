namespace anket2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Questionnaire = new System.Windows.Forms.GroupBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_dad = new System.Windows.Forms.Label();
            this.label_country = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.label_birth = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_dad = new System.Windows.Forms.TextBox();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.textBox_load = new System.Windows.Forms.TextBox();
            this.Questionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // Questionnaire
            // 
            this.Questionnaire.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Questionnaire.Controls.Add(this.radioButton_female);
            this.Questionnaire.Controls.Add(this.radioButton_male);
            this.Questionnaire.Controls.Add(this.dateTimePicker1);
            this.Questionnaire.Controls.Add(this.textBox_number);
            this.Questionnaire.Controls.Add(this.textBox_city);
            this.Questionnaire.Controls.Add(this.textBox_country);
            this.Questionnaire.Controls.Add(this.textBox_dad);
            this.Questionnaire.Controls.Add(this.textBox_surname);
            this.Questionnaire.Controls.Add(this.textBox_name);
            this.Questionnaire.Controls.Add(this.label_gender);
            this.Questionnaire.Controls.Add(this.label_birth);
            this.Questionnaire.Controls.Add(this.label_number);
            this.Questionnaire.Controls.Add(this.label_city);
            this.Questionnaire.Controls.Add(this.label_country);
            this.Questionnaire.Controls.Add(this.label_dad);
            this.Questionnaire.Controls.Add(this.label_surname);
            this.Questionnaire.Controls.Add(this.label_name);
            this.Questionnaire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Questionnaire.Location = new System.Drawing.Point(12, 38);
            this.Questionnaire.Name = "Questionnaire";
            this.Questionnaire.Size = new System.Drawing.Size(694, 381);
            this.Questionnaire.TabIndex = 0;
            this.Questionnaire.TabStop = false;
            this.Questionnaire.Text = "Questionnaire";
            this.Questionnaire.Enter += new System.EventHandler(this.Questionnaire_Enter);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(19, 34);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(19, 61);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(67, 20);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "Surname";
            // 
            // label_dad
            // 
            this.label_dad.AutoSize = true;
            this.label_dad.Location = new System.Drawing.Point(19, 94);
            this.label_dad.Name = "label_dad";
            this.label_dad.Size = new System.Drawing.Size(78, 20);
            this.label_dad.TabIndex = 2;
            this.label_dad.Text = "Dad name";
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(19, 124);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(60, 20);
            this.label_country.TabIndex = 3;
            this.label_country.Text = "Country";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(19, 154);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(34, 20);
            this.label_city.TabIndex = 4;
            this.label_city.Text = "City";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(19, 183);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(108, 20);
            this.label_number.TabIndex = 5;
            this.label_number.Text = "Phone Number";
            // 
            // label_birth
            // 
            this.label_birth.AutoSize = true;
            this.label_birth.Location = new System.Drawing.Point(19, 217);
            this.label_birth.Name = "label_birth";
            this.label_birth.Size = new System.Drawing.Size(76, 20);
            this.label_birth.TabIndex = 6;
            this.label_birth.Text = "Birth Date";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(19, 268);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(57, 20);
            this.label_gender.TabIndex = 7;
            this.label_gender.Text = "Gender";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(133, 26);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(125, 27);
            this.textBox_name.TabIndex = 8;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(133, 58);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(125, 27);
            this.textBox_surname.TabIndex = 9;
            // 
            // textBox_dad
            // 
            this.textBox_dad.Location = new System.Drawing.Point(133, 87);
            this.textBox_dad.Name = "textBox_dad";
            this.textBox_dad.Size = new System.Drawing.Size(125, 27);
            this.textBox_dad.TabIndex = 10;
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(133, 117);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(125, 27);
            this.textBox_country.TabIndex = 11;
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(133, 147);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(125, 27);
            this.textBox_city.TabIndex = 12;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(133, 176);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(125, 27);
            this.textBox_number.TabIndex = 13;
            this.textBox_number.TextChanged += new System.EventHandler(this.textBox_number_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(133, 264);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(63, 24);
            this.radioButton_male.TabIndex = 15;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(284, 264);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(78, 24);
            this.radioButton_female.TabIndex = 16;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(694, 409);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(94, 29);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(694, 3);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(94, 29);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // textBox_load
            // 
            this.textBox_load.Location = new System.Drawing.Point(14, 5);
            this.textBox_load.Name = "textBox_load";
            this.textBox_load.Size = new System.Drawing.Size(125, 27);
            this.textBox_load.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_load);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.Questionnaire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Questionnaire.ResumeLayout(false);
            this.Questionnaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Questionnaire;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox_number;
        private TextBox textBox_city;
        private TextBox textBox_country;
        private TextBox textBox_dad;
        private TextBox textBox_surname;
        private TextBox textBox_name;
        private Label label_gender;
        private Label label_birth;
        private Label label_number;
        private Label label_city;
        private Label label_country;
        private Label label_dad;
        private Label label_surname;
        private Label label_name;
        private Button button_save;
        private Button button_load;
        private TextBox textBox_load;
    }
}