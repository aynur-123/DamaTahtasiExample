﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[10,10]; //çoklu dizi
            int top = 0, left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) 
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i+j) % 2 == 0)
                    { buttons[i,j].BackColor = Color.DarkBlue; }
                    else { buttons[i,j].BackColor = Color.Yellow;}
                    this.Controls.Add(buttons[i, j]); 
                }
                top += 50;
                left = 0;

            }
        



    }
}
}
