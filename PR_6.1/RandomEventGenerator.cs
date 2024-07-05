using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6._1
{
    internal class RandomEventGenerator
    {
        public void RandomEvent()
        {
            Random random = new Random();
            int rand = random.Next(0, 9);
            switch (rand)
            {
                case 0:
                    MessageBox.Show("Всплеск враждебной активности", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                    break;
                case 1:
                    MessageBox.Show("Нанесение удара наших войск!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                    break;
                case 2:
                    MessageBox.Show("Появление космического тумана!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                    break;
            }

        }

    }
}
