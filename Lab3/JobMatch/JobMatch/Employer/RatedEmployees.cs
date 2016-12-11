using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobMatch
{
    public partial class RatedEmployees : Form
    {
        Image _yesImg = Image.FromFile(@"C:\Users\Acer\cslab3\Lab3\imgs\yes_img.png");
        Image _noImg = Image.FromFile(@"C:\Users\Acer\cslab3\Lab3\imgs\no_img.png");
        Image _maybeImg = Image.FromFile(@"C:\Users\Acer\cslab3\Lab3\imgs\maybe_img.png");

        public RatedEmployees()
        {
            _yesImg = resizeImage(_yesImg, new Size(15, 15));
            _noImg = resizeImage(_noImg, new Size(15, 15));
            _maybeImg = resizeImage(_maybeImg, new Size(15, 15));
            InitializeComponent();
        }

        private void RatedEmployees_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Cells[0].Value = "Software engineer";                                 //
                r.Cells[1].Value = "Paulius";                                            //DATA FROM DATABASE
                r.Cells[2].Value = _yesImg;                                             //
                r.Cells[3].Value = _maybeImg;                                           //
            }
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }
    }
}
