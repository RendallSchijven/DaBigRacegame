﻿namespace RaceGameExample {
    partial class formRaceGame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRaceGame));
            this.timerGameTicks = new System.Windows.Forms.Timer(this.components);
            this.eendgif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eendgif)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGameTicks
            // 
            this.timerGameTicks.Enabled = true;
            this.timerGameTicks.Interval = 1;
            this.timerGameTicks.Tick += new System.EventHandler(this.timerGameTicks_Tick);
            // 
            // eendgif
            // 
            this.eendgif.BackgroundImage = global::RaceGameExample.Properties.Resources.Eend;
            this.eendgif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eendgif.Image = global::RaceGameExample.Properties.Resources.Eend;
            this.eendgif.Location = new System.Drawing.Point(458, 191);
            this.eendgif.Name = "eendgif";
            this.eendgif.Size = new System.Drawing.Size(200, 81);
            this.eendgif.TabIndex = 0;
            this.eendgif.TabStop = false;
            // 
            // formRaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RaceGameExample.Properties.Resources.Racebaan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.eendgif);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "formRaceGame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classic Kart";
            this.Load += new System.EventHandler(this.formRaceGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eendgif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGameTicks;
        private System.Windows.Forms.PictureBox eendgif;
    }
}

