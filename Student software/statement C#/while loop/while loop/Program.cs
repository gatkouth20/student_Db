using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
         {
   public partial class Form1 : Form
   {
       public Form1()
       {
           InitializeComponent();
       }
       private void button1_Click(object sender, EventArgs e)
       {
           findStatus("A+");
       }
       public void  findStatus(string val)
       {
           switch (val)
           {
               case "A+":
                   MessageBox.Show("Excellent !!");
                   break;
               case "A":
                   MessageBox.Show("Very Good  !!");
                   break;
               case "B":
                   MessageBox.Show("Good  !!");
                   break;
               case "C":
                   MessageBox.Show("Passed !!");
                   break;
               case "D":
                   MessageBox.Show("Failed !!");
                   break;
               default:
                   MessageBox.Show("Out of range !!");
                   break;
       }
       }
   }
}
