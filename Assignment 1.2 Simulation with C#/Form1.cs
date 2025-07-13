using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1._2_Simulation_with_C_
{
    public partial class Form1 : Form
    {

        // Create class member variable that can be used anywhere in the class.
        double m_resources = 0; // This variable will hold the amount of drink units the user wants.

        // Create a class member variable that will hold the total amount of resources the user has accumulated.
        int m_totalSold = 0; // This variable will hold the total amount of resources the user has made during one day. 

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEspresso_Click(object sender, EventArgs e)
        {
            // When the user click the Espresso button,
            // increasing the amount of drink units the user wants. 
            m_resources = m_resources + 3.00; // 3 dollars for an espresso drink. 
            // set the display to the number of resources. 
            labelDrinkCount.Text = m_resources.ToString();

            m_totalSold = m_totalSold + 1; // I added a total amount of drinks sold. 
            labelDrinkSold.Text = m_totalSold.ToString(); // This right here is set to use a string and display the total amount. 


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCapuccino_Click(object sender, EventArgs e)
        {
            m_resources = m_resources + 5.75;// On the Cappucino I added a 5.75 dollar price to it. 
            labelDrinkCount.Text = m_resources.ToString();

            m_totalSold = m_totalSold + 1; // I added a total one of a drink sold. 
            labelDrinkSold.Text = m_totalSold.ToString(); 
        }

        private void buttonLatte_Click(object sender, EventArgs e)
        {
            m_resources = m_resources + 4.50;// Same thing here I added a different price for a Latte drink which is 4.50.
            labelDrinkCount.Text = m_resources.ToString();

            m_totalSold = m_totalSold + 1; //Same thing here I added a total of one drink sold.
            labelDrinkSold.Text = m_totalSold.ToString(); 


        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelTotalSold_Click(object sender, EventArgs e)
        {
            // When the user clicks the Total Sold 
            m_totalSold = m_totalSold + (int)m_resources; //Right here it adds the toal of coffe cups sold at the moment. 
        }
    }
}
