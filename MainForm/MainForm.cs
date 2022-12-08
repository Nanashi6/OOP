using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorException;
using VectorLibrary;

namespace MainForm
{
    public partial class MainForm : Form
    {
        List<double> a = new List<double>();
        List<double> b = new List<double>();
        List<double> c = new List<double>();
        List<double> w = new List<double>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetAButton_Click(object sender, EventArgs e)
        {
            GetVector getVector = new GetVector();
            getVector.ShowDialog();
            a = getVector.vector;

            ALabel.Text = "";
            foreach (double x in a)
            {
                ALabel.Text += x + " ";
            }
        }

        private void GetBButton_Click(object sender, EventArgs e)
        {
            GetVector getVector = new GetVector();
            getVector.ShowDialog();
            b = getVector.vector;

            BLabel.Text = "";
            foreach (double x in b)
            {
                BLabel.Text += x + " ";
            }
        }

        private void GetCButton_Click(object sender, EventArgs e)
        {
            GetVector getVector = new GetVector();
            getVector.ShowDialog();
            c = getVector.vector;

            CLabel.Text = "";
            foreach (double x in c)
            {
                CLabel.Text += x + " ";
            }
        }

        private void RefreshW()
        {
            WLabel.Text = "";
            foreach (double x in w)
            {
                WLabel.Text += x + " ";
            }
        }

        private void GetValueButton_Click(object sender, EventArgs e)
        {
            w.Clear();
            w = Vector.GetValue(a, Convert.ToDouble(ConstTextBox.Text));
            RefreshW();
        }

        private void ScalarProductButton_Click(object sender, EventArgs e)
        {
            w.Clear();
            try
            {
                w.Add(Vector.GetScalarProduct(a, b));
            }
            catch(ScalarProductException ex)
            {
                ExceptionLabel.Text = ex.Message;
            }
            RefreshW();
        }

        private void VectorProductButton_Click(object sender, EventArgs e)
        {
            w.Clear();
            try
            {
                w = Vector.GetVectorProduct(a, b);
            }
            catch (VectorProductException ex)
            {
                ExceptionLabel.Text = ex.Message;
            }
            RefreshW();
        }

        private void MixedProductButton_Click(object sender, EventArgs e)
        {
            w.Clear();
            try
            {
                w.Add(Vector.GetMixedProduct(a, b, c));
            }
            catch (VectorProductException ex)
            {
                ExceptionLabel.Text = ex.Message;
            }
            catch (ScalarProductException ex)
            {
                ExceptionLabel.Text = ex.Message;
            }
            RefreshW();
        }
    }
}
