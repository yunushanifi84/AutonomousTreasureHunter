﻿namespace ProLab2_1.Forms
{
    partial class MapFormtest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameMap)).BeginInit();
            this.SuspendLayout();
            // 
            // GameMap
            // 
            this.GameMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameMap.Location = new System.Drawing.Point(9, 10);
            this.GameMap.Margin = new System.Windows.Forms.Padding(2);
            this.GameMap.Name = "GameMap";
            this.GameMap.Size = new System.Drawing.Size(515, 310);
            this.GameMap.TabIndex = 0;
            this.GameMap.TabStop = false;
            this.GameMap.Paint += new System.Windows.Forms.PaintEventHandler(this.GameMap_Paint);
            // 
            // MapFormtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 329);
            this.Controls.Add(this.GameMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MapFormtest";
            this.Text = "MapForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.GameMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameMap;
    }
}