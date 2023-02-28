using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gigachelick
{
    public partial class Form1 : Form
    {
        private BasaChelov _chel;
        public Form1()
        {
            InitializeComponent();
            _chel = new BasaChelov();
            _chel.Initialize();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            ChelDataGrid.DataSource = _chel.chels.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
