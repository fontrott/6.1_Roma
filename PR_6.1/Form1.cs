using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace PR_6._1
{
    public partial class Galaxy : Form
    {
        Planets planets = new Planets();
        public Galaxy()
        {
            InitializeComponent();
        }
        public void RandomEvent() 
        {
            RandomEventGenerator rndevent = new RandomEventGenerator();
            rndevent.RandomEvent();
        }
        public void HideAndShowButtons()
        {
            btn_Mars.Visible = false;
            btn_Neptune.Visible = false;
            btn_Jupiter.Visible = false;
            btn_Saturn.Visible = false;
            back.Visible = true;
            drownout.Visible = true;
            camouflage.Visible = true;
            label1.Visible = false;
        }
        private void startattack_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            btn_Jupiter.Visible = true;
            btn_Mars.Visible = true;
            btn_Neptune.Visible = true;
            btn_Saturn.Visible = true;
            startattack.Visible = false;
        }
        static Timer timer;
        //таймер для камуфляжа
        private void camouflage_Click(object sender, EventArgs e)
        {
            RandomEvent();
            timer = new Timer();
            timer.Interval = 2000; // Интервал в миллисекундах (15 секунд)
            // Скрываем pictureBox2 и отображаем camouFlage
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox5.Visible = false;
            // Подписываемся на событие таймера
            timer.Elapsed += OnTimedEvent;
            // Запускаем таймер
            timer.Start();
        }
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            // Останавливаем таймер
            timer.Stop();
            // Скрываем camouFlage
            if (pictureBox3.InvokeRequired)
            {
                pictureBox3.Invoke(new Action(() => pictureBox3.Visible = false));
                pictureBox2.Invoke(new Action(() => pictureBox2.Visible = true));
                camouflage.Invoke(new Action(() => camouflage.Visible = false));
            }
        }
        //таймер для съеба
        private void back_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible= false;
            pictureBox4.Visible = false;            
            camouflage.Visible = false;
            drownout.Visible = false;
            back.Visible = false;
            pictureBox5.Visible = true;
            timer = new Timer();
            timer.Interval = 6000;
            timer.Elapsed += OnTimedEvent3;
            timer.Start();
        }
        private void OnTimedEvent3(object sender, ElapsedEventArgs e)
        {
            // Останавливаем таймер
            timer.Stop();
            if (pictureBox5.InvokeRequired)
            {
                pictureBox5.Invoke(new Action(() => pictureBox5.Visible = false));
                pictureBox2.Invoke(new Action(() => pictureBox2.Visible = false));
                back.Invoke(new Action(() => back.Visible = false));
                Application.Exit();
            }
        }            
        //таймер для заглушки
        private void drownout_Click(object sender, EventArgs e)
        {
            RandomEvent();
            timer = new Timer();
            timer.Interval = 2000;
            pictureBox2.Visible = false;
            pictureBox3.Visible=false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
            timer.Elapsed += OnTimedEvent2;
            timer.Start();
        }
        private void OnTimedEvent2(object sender, ElapsedEventArgs e)
        {
            // Останавливаем таймер
            timer.Stop();
            if (pictureBox4.InvokeRequired)
            {
                pictureBox4.Invoke(new Action(() => pictureBox4.Visible = false));
                pictureBox2.Invoke(new Action(() => pictureBox2.Visible = true));
                drownout.Invoke(new Action(() => drownout.Visible = false));
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void btn_Mars_Click(object sender, EventArgs e)
        {
            planets.BusyPlanet();
            if (planets.CapturePlanetSingleton1.IsPlanetCaptured)
            {
                btn_Mars.Visible = false;
                planets.Reset();
            }
            else
            {
                HideAndShowButtons();
            }
        }

        private void btn_Jupiter_Click(object sender, EventArgs e)
        {
            planets.BusyPlanet();
            if (planets.CapturePlanetSingleton1.IsPlanetCaptured)
            {
                btn_Jupiter.Visible = false;
                planets.Reset();
            }
            else
            {
                HideAndShowButtons();
            }
        }

        private void btn_Saturn_Click(object sender, EventArgs e)
        {
            planets.BusyPlanet();
            if (planets.CapturePlanetSingleton1.IsPlanetCaptured)
            {
                btn_Saturn.Visible = false;
                planets.Reset();
            }
            else
            {
                HideAndShowButtons();
            }
        }

        private void btn_Neptune_Click(object sender, EventArgs e)
        {
            planets.BusyPlanet();
            if (planets.CapturePlanetSingleton1.IsPlanetCaptured)
            {
                btn_Neptune.Visible = false;
                planets.Reset();
            }
            else
            {
                HideAndShowButtons();
            }
        }
    }
}
