using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Timer;

namespace Qiuzz
{
    public partial class Game : Form
    {
        DateTime startTime;
        Timer timer;
        int timerCounter = 0;
        public Game()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Game_KeyDown1);
            this.KeyDown += new KeyEventHandler(Game_KeyDown2);
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;

            // Отображение времени в текстовом поле
            textBox1.Text = elapsed.TotalMilliseconds.ToString();
            timer.Stop();
            MessageBox.Show( "Таймер остановлен");
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool proverka = false;
        private void Game_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                    if(proverka==true)
                {

                }
                    else
                {
                    lb_hod.Text = ("Первый ход за игроком 1!");
                        proverka=true;
                }
            }
        }
        private void Game_KeyDown2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                if (proverka == true)
                {

                }
                else
                {
                    lb_hod.Text=("Второй ход за игроком 2!");
                    proverka = true;
                }
            }
        }
    }
}
