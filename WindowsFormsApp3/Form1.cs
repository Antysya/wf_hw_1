using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void MoveToStart()
        {
            Point startPoin = panel1.Location;
            startPoin.Offset(40, 40);
            Cursor.Position = PointToScreen(startPoin);
        }
        private void Stop_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Пройден уровень 1");
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.Show();
            

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
