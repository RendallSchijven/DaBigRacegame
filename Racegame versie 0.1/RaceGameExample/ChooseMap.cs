﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RaceGameExample
{
    public partial class ChooseMap : Form
    {
        public ChooseMap()
        {
            InitializeComponent();
        }
        public static int Map;

        private void button1_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            Map = 1;
            this.Visible = false;
            var myForm = new PickerP1();
            myForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            Map = 2;
            this.Visible = false;
            var myForm = new PickerP1();
            myForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            Map = 3;
            this.Visible = false;
            var myForm = new PickerP1();
            myForm.Show();
        }

        private void ChooseMap_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            this.Visible = false;
            var myForm = new Splash_Screen();
            myForm.Show();
        }
    }
}
