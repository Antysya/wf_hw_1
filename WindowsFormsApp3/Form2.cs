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
    public partial class Form2 : Form
    {
        public Form2()
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
            MessageBox.Show("Пройден уровень 2\nИгра пройдена!");
            Close();
        }

        private void Form2_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           new Form2();
        }
    }
}
