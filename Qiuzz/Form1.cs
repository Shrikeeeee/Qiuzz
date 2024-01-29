using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Qiuzz
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        public void btn_Exit1_Click(object sender, EventArgs e)
        {
            //подтверждение выхода
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //очищение Файла со выбором сложности при выходе из программы
                string filePath = "SelectedSettings.txt";
                File.WriteAllText(filePath, string.Empty);
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
        //открытие формы с настройками
        public void btn_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }
        public void btn_Play_Click(object sender, EventArgs e)
        {
            
            if (DataBank.DifCheck == null) // Проверяем, выбрано ли какое-либо значение в ComboBox на форме Form2
            {
                MessageBox.Show("Выберите значение сложности в настройках"); // Выводим сообщение, если значение не выбрано
                return;
            }
            else 
            {
                Game game = new Game();
                game.ShowDialog();
            }
           
        }

    }
}
