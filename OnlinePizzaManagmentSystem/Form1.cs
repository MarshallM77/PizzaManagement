using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlinePizzaManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            viewChangeOrderStatusPanel.Hide();

            searchMemberProfilePanel.Hide();
            memberOrderHistoryPanel.Hide();

            businessVolumePanel.Hide();

            editItemsSaucesPanel.Hide();
            addItemSaucePanel.Hide();

            viewChangeStockPanel.Hide();

            /*
            string message = "The stock of Bacon is Low!";
            string title = "Urgent: Low Stock";
            MessageBox.Show(message, title);
            */
        }

        private void viewChangeOrderStatusButton_Click(object sender, EventArgs e)
        {
            viewChangeOrderStatusPanel.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrderStatus = "Recieved";
            orderStatusLabel.Text = "Current Status: " + selectedOrderStatus;

            string selectedOrderContents = "1 Cheese Pizza, 1 Sausage Pizza";
            orderContentsLabel.Text = "Order Contents: " + selectedOrderContents;
        }

        private void searchMemberProfileButton_Click(object sender, EventArgs e)
        {
            searchMemberProfilePanel.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchMemberProfileSearchButton_Click(object sender, EventArgs e)
        {
            /*
            string message = "A member with that username does not exist. Please enter another username.";
            string title = "Member does not exist.";
            MessageBox.Show(message, title);
            */
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void showBusinessVolumeButton_Click(object sender, EventArgs e)
        {
            businessVolumePanel.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void editItemsSaucesAddButton_Click(object sender, EventArgs e)
        {
            addItemSaucePanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void editItemSaucesButton_Click(object sender, EventArgs e)
        {
            editItemsSaucesPanel.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewChangeStockVolume_Click(object sender, EventArgs e)
        {
            viewChangeStockPanel.Show();
        }

        private void viewMemberOrderHistoryButton_Click(object sender, EventArgs e)
        {
            searchMemberProfilePanel.Hide();
            memberOrderHistoryPanel.Show();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {
            
        }
    }
}
