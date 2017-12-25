using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Text;
using System.Runtime;
using System.Windows;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> colors = new List<string>();

            //add items in a List collection
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");

            //insert an item in the list
            colors.Insert(1, "violet");

            //retrieve items using foreach loop
            foreach (string color in colors)
            {
                MessageBox.Show(color);
            }

            //remove an item from list
            colors.Remove("violet");

            //retrieve items using for loop
            for (int i = 0; i < colors.Count; i++)
            {
                MessageBox.Show(colors[i]);
            }

            if (colors.Contains("Blue"))
            {
                MessageBox.Show("Blue color exist in the list");
            }
            else
            {
                MessageBox.Show("Not exist");
            }

            //copy array to list
            string[] strArr = new string[3];
            strArr[0] = "Red";
            strArr[1] = "Blue";
            strArr[2] = "Green";
            List<string> arrlist = new List<string>(strArr);

            foreach (string str in strArr)
            {
                MessageBox.Show(str);
            }

            //call clear method
            arrlist.Clear();

            MessageBox.Show(arrlist.Count.ToString());
        }
    }
}