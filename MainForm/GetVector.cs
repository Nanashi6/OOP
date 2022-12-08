using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class GetVector : Form
    {
        public List<double> vector = new List<double>();
        public GetVector()
        {
            InitializeComponent();
        }

        private void GetVector_Load(object sender, EventArgs e)
        {

        }

        private void GetVectorButton_Click(object sender, EventArgs e)
        {
            vector.Clear();
            string[] textVector = VectorTextBox.Text.Split(' ');
            for(int i = 0; i < textVector.Length; i++)
            {
                vector.Add(Convert.ToDouble(textVector[i]));
            }
        }
    }
}
