﻿using System;
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
        public CashContext cashContext = null;

        public double Total = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxMethod.Items.AddRange(new object[] { "正常收費", "打8折", "滿300送100" });
            ComboBoxMethod.SelectedIndex = 0;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            cashContext = new CashContext(ComboBoxMethod.SelectedItem.ToString());
            double totalPrices = cashContext.GetResult(Convert.ToDouble(TxtPrice.Text) * Convert.ToDouble(TxtCount.Text));
            Total = Total + totalPrices;
            ListBox.Items.Add($"單價: {TxtPrice.Text} ,數量: {TxtCount.Text}, {ComboBoxMethod.SelectedItem} 合計: {totalPrices.ToString()}");
            LabelTotalPrice.Text = Total.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Total = 0.0d;
            TxtPrice.Text = "100";
            TxtCount.Text = "1";
            ComboBoxMethod.SelectedIndex = 0;
            ListBox.Items.Clear();
            LabelTotalPrice.Text = Total.ToString();
        }
    }
}