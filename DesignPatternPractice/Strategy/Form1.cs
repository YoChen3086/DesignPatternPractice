using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form1 : Form
    {
        public double Total = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxMethod.Items.AddRange(new object[] { "正常收費", "打八折", "打七折", "打五折" });
            ComboBoxMethod.SelectedIndex = 0;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            double totalPrices = 0.0d;
            switch (ComboBoxMethod.SelectedIndex)
            {
                case 0:
                    totalPrices = Convert.ToDouble(TxtPrice.Text) * Convert.ToDouble(TxtCount.Text);
                    break;
                case 1:
                    totalPrices = Convert.ToDouble(TxtPrice.Text) * Convert.ToDouble(TxtCount.Text) * 0.8;
                    break;
                case 2:
                    totalPrices = Convert.ToDouble(TxtPrice.Text) * Convert.ToDouble(TxtCount.Text) * 0.7;
                    break;
                case 3:
                    totalPrices = Convert.ToDouble(TxtPrice.Text) * Convert.ToDouble(TxtCount.Text) * 0.5;
                    break;
            }
            Total = Total + totalPrices;
            ListBox.Items.Add($"單價: {TxtPrice.Text} ,數量: {TxtCount.Text}, {ComboBoxMethod.SelectedItem} 合計: {totalPrices.ToString()}");
            LabelTotalPrice.Text = Total.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Total = 0.0d;
            TxtPrice.Text = "0";
            TxtCount.Text = "1";
            ComboBoxMethod.SelectedIndex = 0;
            ListBox.Items.Clear();
            LabelTotalPrice.Text = Total.ToString();
        }
    }
}