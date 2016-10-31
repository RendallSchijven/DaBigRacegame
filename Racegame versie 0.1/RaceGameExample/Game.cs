﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace RaceGameExample {
    public partial class formRaceGame : Form {

        Bitmap Backbuffer;

        List<Car> cars = new List<Car>();
        //Maak de auto ints aan
        int Carplayer1;
        int Carplayer2;

        public formRaceGame() {
            InitializeComponent();

            Carplayer1 = PickerP1.CarP1;
            Carplayer2 = PickerP2.CarP2;

            //Tijdelijk bewijs dat de autos zijn doorgegeven.
            MessageBox.Show("Player 1 koos auto "+Carplayer1+ " en Player 2 koos auto "+Carplayer2);

            //Check welke auto player 1 koos en maak hem aan
            if (Carplayer2 == 1)
            {
                Car car1 = new Car(270, 635, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                cars.Add(car1);
            }
            if (Carplayer2 == 2)
            {
                Car car1 = new Car(270, 635, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                cars.Add(car1);
            }
            if (Carplayer2 == 3)
            {
                Car car1 = new Car(270, 635, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                cars.Add(car1);
            }
            if (Carplayer2 == 4)
            {
                Car car1 = new Car(270, 635, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                cars.Add(car1);
            }

            //Check welke auto player 2 koos en maak hem aan
            if (Carplayer1 == 1)
            {
                Car car2 = new Car(270, 665, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                cars.Add(car2);
            }
            if (Carplayer1 == 2)
            {
                Car car2 = new Car(270, 665, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                cars.Add(car2);
            }
            if (Carplayer1 == 3)
            {
                Car car2 = new Car(270, 665, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                cars.Add(car2);
            }
            if (Carplayer1 == 4)
            {
                Car car2 = new Car(270, 665, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                cars.Add(car2);
            }

            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        void Form1_KeyUp(object sender, KeyEventArgs e) {
            foreach (Car car in cars)
                car.handleKeyUpEvent(e);
        }

        void Form1_KeyDown(object sender, KeyEventArgs e) {
            foreach (Car car in cars)
                car.handleKeyDownEvent(e);
        }

        void Form1_Paint(object sender, PaintEventArgs e) {
            if (Backbuffer != null) {
                e.Graphics.DrawImageUnscaled(Backbuffer, Point.Empty);
            }

            Draw(e.Graphics);
        }

        void Form1_CreateBackBuffer(object sender, EventArgs e) {
            if (Backbuffer != null)
                Backbuffer.Dispose();

            Backbuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }



        void Draw(Graphics g) {
            foreach (Car car in cars)
                g.DrawImage(car.getImage(), car.getPosition());
        }

        private void timerGameTicks_Tick(object sender, EventArgs e) {
            foreach (Car car in cars)
                car.calculateNewPosition();

            Invalidate();
        }
    }
}