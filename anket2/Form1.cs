using System.Diagnostics.Metrics;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace anket2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            Person person = new();
            try
            {
                var json = File.ReadAllText($"{button_load.Text}.json");
                person = JsonSerializer.Deserialize<Person>(json)!;
                textBox_name.Text = person.Name;
                textBox_surname.Text = person.Surname;
                textBox_country.Text = person.Country;
                textBox_dad.Text = person.DadName;
                textBox_city.Text = person.City;
                textBox_number.Text = person.PhoneNumber;
                dateTimePicker1.Value = person.Date;
                if (person.Gender == "Male")
                    radioButton_male.Select();
                else if (person.Gender == "Female")
                    radioButton_female.Select();
            }
            catch (Exception)
            {
                MessageBox.Show("It was not found", "i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string gender = radioButton_male.Checked ? radioButton_male.Text : radioButton_female.Text;
            var person = new Person(textBox_name.Text, textBox_surname.Text, textBox_dad.Text, textBox_country.Text, textBox_city.Text, textBox_number.Text, dateTimePicker1.Value, gender);

            if (textBox_name.Text == "" || textBox_surname.Text == "" || textBox_dad.Text == "" || textBox_city.Text == "" || textBox_country.Text == "" || textBox_number.Text == "")
            {
                MessageBox.Show("Missed", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var person1 = JsonSerializer.Serialize(person);
                File.WriteAllText($"{person.Name}.json", person1);
                MessageBox.Show("It was saved", "i", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void textBox_number_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
            if (regex.IsMatch(textBox_number.Text))
            {
                textBox_number.ForeColor = Color.Green;
            }
            else
            {
                textBox_number.ForeColor = Color.Red;
            }
        }

        private void Questionnaire_Enter(object sender, EventArgs e)
        {

        }
    }
}