using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lr4._2.Properties;

namespace Lr4._2
{
    public partial class Form1 : Form
    {
        Model model;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            model = new Model(Properties.Settings.Default.valueA, 0, Properties.Settings.Default.valueC);
            model.observers += new System.EventHandler(this.UpdateFromModel);
            model.load();
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb == textBoxA)
                i = 1;
            else if (tb == textBoxB)
                i = 2;
            else i = 3;
            if (e.KeyCode == Keys.Enter)
                model.SetValue(i, Int32.Parse(tb.Text));
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numUD = (NumericUpDown)sender;
            if (numUD == numericUpDownA)
                i = 1;
            else if (numUD == numericUpDownB)
                i = 2;
            else i = 3;
            model.SetValue(i, Decimal.ToInt32(numUD.Value));
        }

        private void tBarA_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tr = (TrackBar)sender;
            if (tr == tBarA)
                i = 1;
            else if (tr == tBarB)
                i = 2;
            else i = 3;
            model.SetValue(i, tr.Value);
        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBoxA.Text = model.GetValue(1).ToString();
            numericUpDownA.Value = model.GetValue(1);
            numericUpDownA.Maximum = model.GetValue(3);
            tBarA.Value = model.GetValue(1);

            textBoxB.Text = model.GetValue(2).ToString();
            numericUpDownB.Value = model.GetValue(2);
            numericUpDownB.Minimum = model.GetValue(1);
            numericUpDownB.Maximum = model.GetValue(3);
            tBarB.Value = model.GetValue(2);

            textBoxC.Text = model.GetValue(3).ToString();
            numericUpDownC.Value = model.GetValue(3);
            numericUpDownC.Minimum = model.GetValue(1);
            tBarC.Value = model.GetValue(3);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.valueA = model.GetValue(1);
            Properties.Settings.Default.valueC = model.GetValue(3);
            Properties.Settings.Default.Save();
        }
    }

    public class Model
    {
        int valA;
        int valB;
        int valC;
        public System.EventHandler observers;
        public Model(int v1, int v2, int v3)
        {
            valA = v1;
            valB = v2;
            valC = v3;
        }
        public void SetValue(int i, int value)
        {
            if (i == 1)
                SetValue1(value);
            else if (i == 2)
                SetValue2(value);
            else SetValue3(value);
        }
        public void load()
        {
            observers.Invoke(this, null);
        }
        private void SetValue1(int value) //установка значения для числа А
        {
            if (value > 100)
                value = 100;
            if (value < 0)
                value = 0;
            if (valC >= value)
            {
                valA = value;
                if (valA >= valB)
                    valB = valA;
            }
            else valA = GetValue(1);
            load();
        }

        private void SetValue2(int value)
        {
            if (valC >= value)
            {
                if (valA <= value)
                    valB = value;
                else valB = valA;
            }
            else valB = valC;
            load();
        }

        private void SetValue3(int value)
        {
            if (value > 100)
                value = 100;
            if (value < 0)
                value = 0;
            if (valA <= value)
            {
                valC = value;
                if (valC < valB)
                    valB = value;
            }
            else valC = GetValue(3);
            load();
        }
        public int GetValue(int i)
        {
            if (i == 1)
                return valA;
            else if (i == 2)
                return valB;
            else return valC;
        }
    }
}
