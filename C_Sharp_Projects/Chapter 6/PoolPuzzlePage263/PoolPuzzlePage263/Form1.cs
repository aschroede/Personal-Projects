﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolPuzzlePage263
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string xyz = "";
            Boat b1 = new Boat();
            Sailboat b2 = new Sailboat();
            Rowboat b3 = new Rowboat();
            b2.setLength(32);
            xyz = b1.move();
            xyz += b3.move();
            xyz += b2.move();
            System.Windows.Forms.MessageBox.Show(xyz);
        }
    }

    class Rowboat : Boat
    {
        public string rowTheBoat()
        {
            return "stroke natasha";
        }
    }

    class Sailboat : Boat
    {
        public override string move(){
            return "hoist sail";
        }
    }
    class Boat {
        private int length;
        public void setLength(int len){
        length = len;
        }
        public int getLength()
        {
           return length;   
        }
        public virtual string move()
        {
            return "drift";
        }
    }

}
