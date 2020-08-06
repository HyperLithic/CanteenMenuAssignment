using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenMenuAssessment
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        string[] arrayIntervalFood = new string[] { "Cheese Rolls", "Savoury Pinwheel", "Savoury Muffin", "Sweet Muffin", "Cinnamon Swirl", "Brownie", "Cheese Puffs", "Beef Sandwich", "Ham Sandwich", "Bacon Sandwich", "Vegetarian Sandwich", "Chicken Sandbwich", "Salmon Bagel", "Tomato Bagel"};
        int index;
        int lunch;
        int week = 1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnlInterval);
            listPanel.Add(pnlLunchWeek1);
            listPanel.Add(pnlLunchWeek2);
            listPanel[0].BringToFront();

            lis
        }

        private void lblCheesePuffs_Click(object sender, EventArgs e)
        {

        }

        private void lblBagels_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxInterval_Enter(object sender, EventArgs e)
        {

        }

        private void grpBoxLunch_Enter(object sender, EventArgs e)
        {

        }

        private void btnInterval_Click(object sender, EventArgs e)
        {
            lunch = 0;
            listPanel[0].BringToFront();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            lunch = 1;
            if (week == 1)
            {
                listPanel[1].BringToFront();

            } 
            else if (week == 2)
            {
                listPanel[2].BringToFront();
            }

        }

        private void listLunchWeekList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLunchWeekList.GetItemText(listLunchWeekList.SelectedItem) == "Week 1" && lunch == 1)
            {
                week = 1;
                listPanel[1].BringToFront();
            }
            else if (listLunchWeekList.GetItemText(listLunchWeekList.SelectedItem) == "Week 2" && lunch == 1)
            {
                week = 2;
                listPanel[2].BringToFront();
            }
            else if (listLunchWeekList.GetItemText(listLunchWeekList.SelectedItem) == "Week 1" && lunch == 0)
            {
                week = 1;
            }
            else if (listLunchWeekList.GetItemText(listLunchWeekList.SelectedItem) == "Week 2" && lunch == 0)
            {
                week = 2;
            }
        }
    }
}
