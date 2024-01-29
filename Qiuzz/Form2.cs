using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //новая библиотека для того, чтобы делать запись (StreamWriter)

namespace Qiuzz
{
    public partial class SettingsForm : Form
    {
      
        public SettingsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }
        
        public void btn_Exit2_Click(object sender, EventArgs e)
        {
            Close();

        }

        public void btn_SaveSettings_Click(object sender, EventArgs e)
        {
            if (cmb_Dif.SelectedItem == null)
            {
                MessageBox.Show("Выберите сложность игры"); // Выводим сообщение, если значение не выбрано
                return;
            }
            else
            {
                //создал переменуую которая сохраняет значение сложности, которая выбирается в КомбоБоксе
                 string selectedValue;
                 selectedValue = cmb_Dif.SelectedItem.ToString();
                // Сохраняем выбранное значение в файл SelectedSettings.txt
                using (StreamWriter writer1 = new StreamWriter("SelectedSettings.txt", false))
                {

                    writer1.WriteLine(selectedValue);
                    DataBank.DifCheck = selectedValue;
                }
                MessageBox.Show("Настройки применены"); // Выводим сообщение, что настройки применены.
            }
        }
            
        public void Settings_Load(object sender, EventArgs e)
        {
            // чтение последнего значения из txt файла
            string filePath = "SelectedSettings.txt";

            //считываем последнее значение из файла
            string lastValue = File.ReadLines(filePath).LastOrDefault();

            //вписываем значение в ComboBox
            cmb_Dif.Text = lastValue;
            
        }

    }
}
    

