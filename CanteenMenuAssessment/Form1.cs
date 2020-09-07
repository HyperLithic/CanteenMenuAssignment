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
        public Form1()
        {
            InitializeComponent();

        }
        List<Panel> listPanel = new List<Panel>();
        int[] arrayIntervalPrice = new int[] {4, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4};
        string[] arrayIntervalUpButtons = new string[] { "btnPlusCheeseRoll", "btnPlusSavouryPinwheel", "btnPlusMuffinSavoury", "btnPlusMuffinSweet", "btnPlusCinnamonSwirl", "btnPlusBrownie", "btnPlusCheesePuff", "btnPlusSandwichBeef", "btnPlusSandwichHam", "btnPlusSandwichBacon", "btnPlusSandwichEgg", "btnPlusSandwichChicken", "btnPlusBagelSalmon", "btnPlusBagelTomato" };
        string[] arrayIntervalDownButtons = new string[] { "btnMinusCheeseRoll", "btnMinusSavouryPinwheel", "btnMinusMuffinSavoury", "btnMinusMuffinSweet", "btnMinusCinnamonSwirl", "btnMinusBrownie", "btnMinusCheesePuff", "btnMinusSandwichBeef", "btnMinusSandwichHam", "btnMinusSandwichBacon", "btnMinusSandwichEgg", "btnMinusSandwichChicken", "btnMinusBagelSalmon", "btnMinusBagelTomato" };
        string[] arrayIntervalFood = new string[] { "Cheese Rolls", "Savoury Pinwheel", "Savoury Muffin", "Sweet Muffin", "Cinnamon Swirl", "Brownie", "Cheese Puffs", "Beef Sandwich", "Ham Sandwich", "Bacon Sandwich", "Vegetarian Sandwich", "Chicken Sandbwich", "Salmon Bagel", "Tomato Bagel" };
        int itemsAdded = 0;
        List<int> itemsAddedList = new List<int>();
        int lunch;
        int week = 1;
        //readonly string 
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnlInterval);
            listPanel.Add(pnlLunchWeek1);
            listPanel.Add(pnlLunchWeek2);
            listPanel[0].BringToFront();
            //Console.WriteLine(arrayIntervalDownButtons.Length);
            //Console.WriteLine(arrayIntervalUpButtons.Length);
            //Console.WriteLine(arrayIntervalPrice.Length);
            //Console.WriteLine(arrayIntervalFood.Length);


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

        public int CalcAddedIntervalItem(string argsSender)
        {
            int index = -1;
            for (int i = 0; i < arrayIntervalDownButtons.Length; i++)
            {
                if (arrayIntervalUpButtons[i] == argsSender)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public int CalcRemovedIntervalItem(string argsSender)
        {
            int index = -1;
            for (int i = 0; i < arrayIntervalUpButtons.Length; i++)
            {
                if (arrayIntervalDownButtons[i] == argsSender)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        private void upArrowClicked(object sender, EventArgs e)
        {
            if (itemsAdded <= 3)
            {
                itemsAdded++;
                string stringIntervalUpButton = (sender as Button).Name;
                int intIntervalUpButton = CalcAddedIntervalItem(stringIntervalUpButton);
                itemsAddedList.Add(intIntervalUpButton);
                lblOrder.Text = "Your order is: ";
                for (int i = 0; i < itemsAddedList.Count; i++)
                {
                    int item = itemsAddedList[i];
                    lblOrder.Text += arrayIntervalFood[item] + " $" + arrayIntervalPrice[item] + " ";
                }
            }
        }

        private void downArrowClicked(object sender, EventArgs e)
        {
            if (itemsAdded >= 1)
            {
                string stringIntervalDownButton = (sender as Button).Name;
                int intIntervalDownButton = CalcRemovedIntervalItem(stringIntervalDownButton);
                itemsAddedList.Remove(intIntervalDownButton);
                itemsAdded = itemsAddedList.Count;
                lblOrder.Text = "Your order is: ";
                if (itemsAddedList.Count >= 1)
                {
                    for (int i = 0; i < itemsAddedList.Count; i++)
                    {
                        int item = itemsAddedList[i];
                        lblOrder.Text += arrayIntervalFood[item] + " $" + arrayIntervalPrice[item] + " ";
                    }

                }

            }
        }
    }
}
