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
        string[] tutorGroups = new string[] { "ABh","AJf", "AHb", "AWa", "BSa", "Bla", "BRi", "BGw", "HKa", "HMl", "HMd", "HKi", "RWt", "RTh", "RHr", "RBn", "SMn", "SRo", "SDg", "SDa" };   
        int[] arrayIntervalPrice = new int[] { 4, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4 };
        string[] arrayIntervalUpButtons = new string[] { "btnPlusCheeseRoll", "btnPlusSavouryPinwheel", "btnPlusMuffinSavoury", "btnPlusMuffinSweet", "btnPlusCinnamonSwirl", "btnPlusBrownie", "btnPlusCheesePuff", "btnPlusSandwichBeef", "btnPlusSandwichHam", "btnPlusSandwichBacon", "btnPlusSandwichEgg", "btnPlusSandwichChicken", "btnPlusBagelSalmon", "btnPlusBagelTomato" };
        string[] arrayIntervalDownButtons = new string[] { "btnMinusCheeseRoll", "btnMinusSavouryPinwheel", "btnMinusMuffinSavoury", "btnMinusMuffinSweet", "btnMinusCinnamonSwirl", "btnMinusBrownie", "btnMinusCheesePuff", "btnMinusSandwichBeef", "btnMinusSandwichHam", "btnMinusSandwichBacon", "btnMinusSandwichEgg", "btnMinusSandwichChicken", "btnMinusBagelSalmon", "btnMinusBagelTomato" };
        string[] arrayIntervalFood = new string[] { "Cheese Rolls", "Savoury Pinwheel", "Savoury Muffin", "Sweet Muffin", "Cinnamon Swirl", "Brownie", "Cheese Puffs", "Beef Sandwich", "Ham Sandwich", "Bacon Sandwich", "Vegetarian Sandwich", "Chicken Sandbwich", "Salmon Bagel", "Tomato Bagel" };
        string[] arrayLunchWeek2UpButtons = new string[] { "btnPlusWeek2ChickenNuggets", "btnPlusWeek2BaconPie", "btnPlusWeek2Lasagne", "btnPlusWeek2Meatballs", "btnPlusWeek2ChickenBurger", "btnPlusWeek2BeefBurger" };
        string[] arrayLunchWeek2DownButtons = new string[] { "btnMinusWeek2ChickenNuggets", "btnMinusWeek2BaconPie", "btnMinusWeek2Lasagne", "btnMinusWeek2Meatballs", "btnMinusWeek2ChickenBurger", "btnMinusWeek2BeefBurger" };
        string[] arrayLunchWeek2Food = new string[] { "Chicken Nuggets", "Bacon Pie", "Lasagne", "Meatballs", "Chicken Burger", "Beef Burger" };
        int[] arrayLunchWeek2Price = new int[] { 5, 5, 5, 5, 5, 5 };
        string[] arrayLunchWeek1UpButtons = new string[] { "btnPlusWeek1ChickenNuggets", "btnPlusWeek1Pumpkin", "btnPlusWeek1Macaroni", "btnPlusWeek1ButterChicken", "btnPlusWeek1FriedRice" };
        string[] arrayLunchWeek1DownButtons = new string[] { "btnMinusWeek1ChickenNuggets", "btnMinusWeek1Pumpkin", "btnMinusWeek1Macaroni", "btnMinusWeek1ButterChicken", "btnMinusWeek1FriedRice" };
        string[] arrayLunchWeek1Food = new string[] { "Chicken Nuggets", "Pumpkin Bake", "Macaroni & Cheese", "Butter Chicken", "Fried Rice" };
        int[] arrayLunchWeek1Price = new int[] { 5, 5, 5, 5, 5 };
        int itemsAdded = 0;
        int Lunch1ItemsAdded = 0;
        int Lunch2ItemsAdded = 0;
        List<int> itemsAddedList = new List<int>();
        List<int> Lunch1ItemsAddedList = new List<int>();
        List<int> Lunch2ItemsAddedList = new List<int>();
        int lunch;
        int week = 1;
        int totalPrice = 0;


       

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnlInterval);
            listPanel.Add(pnlLunchWeek1);
            listPanel.Add(pnlLunchWeek2);
            listPanel[0].BringToFront();
            //Code to make sure all the week 2 arrays are the same length
            Console.WriteLine(arrayLunchWeek2DownButtons.Length);
            Console.WriteLine(arrayLunchWeek2UpButtons.Length);
            Console.WriteLine(arrayLunchWeek2Price.Length);
            Console.WriteLine(arrayLunchWeek2Food.Length);
            for (int i = 0; i < tutorGroups.Length; i++)
            {
                cmbTutorClass.Items.Add(tutorGroups[i]);
            }
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
            Lunch1ItemsAddedList.Clear();
            Lunch2ItemsAddedList.Clear();
            itemsAdded = 0;
            Lunch1ItemsAdded = 0;
            Lunch2ItemsAdded = 0;
            lblOrder.Text = "Your order is: ";
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            lunch = 1;
            if (week == 1)
            {
                listPanel[1].BringToFront();
                itemsAddedList.Clear();
                Lunch2ItemsAddedList.Clear();
                Lunch1ItemsAddedList.Clear();
                itemsAdded = 0;
                Lunch1ItemsAdded = 0;
                Lunch2ItemsAdded = 0;
                lblOrder.Text = "Your order is: ";
            }
            else if (week == 2)
            {
                listPanel[2].BringToFront();
                itemsAddedList.Clear();
                Lunch1ItemsAddedList.Clear();
                Lunch2ItemsAddedList.Clear();
                itemsAdded = 0;
                Lunch1ItemsAdded = 0;
                Lunch2ItemsAdded = 0;
                lblOrder.Text = "Your order is: ";
            }

        }

        private void listLunchWeekList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLunchWeekList.GetItemText(listLunchWeekList.SelectedItem) == "Week 1" && lunch == 1)
            {
                week = 1;
                listPanel[1].BringToFront();
                itemsAddedList.Clear();
                Lunch2ItemsAddedList.Clear();
                Lunch1ItemsAddedList.Clear();
                itemsAdded = 0;
                Lunch1ItemsAdded = 0;
                Lunch2ItemsAdded = 0;
                lblOrder.Text = "Your order is: ";
            }
            else if (listLunchWeekList.GetItemText(listLunchWeekList.SelectedItem) == "Week 2" && lunch == 1)
            {
                week = 2;
                listPanel[2].BringToFront();
                itemsAddedList.Clear();
                Lunch1ItemsAddedList.Clear();
                Lunch2ItemsAddedList.Clear();
                itemsAdded = 0;
                Lunch1ItemsAdded = 0;
                Lunch2ItemsAdded = 0;
                lblOrder.Text = "Your order is: ";
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
            int intervalTotalPrice = 0;
            if (itemsAdded <= 2)
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
                for (int o = 0; o < itemsAddedList.Count; o++)
                {
                    int item = itemsAddedList[o];
                    intervalTotalPrice = intervalTotalPrice + arrayIntervalPrice[item];
                }
                lblOrder.Text += "The total price is $" + intervalTotalPrice;
            }
        }

        private void downArrowClicked(object sender, EventArgs e)
        {
            int intervalTotalPrice = 0;
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
                    for (int o = 0; o < itemsAddedList.Count; o++)
                    {
                        int item = itemsAddedList[o];
                        intervalTotalPrice = intervalTotalPrice + arrayIntervalPrice[o];
                    }
                    lblOrder.Text += "The total price is $" + intervalTotalPrice;

                }
            }
        }
        public int CalcAddedLunch1Item(string argsSender)
        {
            int index = -1;
            for (int i = 0; i < arrayLunchWeek1UpButtons.Length; i++)
            {
                if (arrayLunchWeek1UpButtons[i] == argsSender)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        private void Lunch1UpArrowClicked(object sender, EventArgs e)
        {
            if (Lunch1ItemsAdded < 1)
            {
                Lunch1ItemsAdded++;
                string stringLunch1UpButton = (sender as Button).Name;
                int intLunch1UpButton = CalcAddedLunch1Item(stringLunch1UpButton);
                Lunch1ItemsAddedList.Add(intLunch1UpButton);
                lblOrder.Text = "Your order is: ";
                int item = Lunch1ItemsAddedList[0];
                lblOrder.Text += arrayLunchWeek1Food[item] + " $" + arrayLunchWeek1Price[item] + " ";
            }
        }
        private void Lunch1DownArrowClicked(object sender, EventArgs e)
        {
            if (Lunch1ItemsAdded > 0)
            {
                string stringLunch1DownButton = (sender as Button).Name;
                int intLunch1DownButton = CalcRemovedLunch1Item(stringLunch1DownButton);
                Lunch1ItemsAddedList.Remove(intLunch1DownButton);
                Lunch1ItemsAdded = Lunch1ItemsAddedList.Count;
                lblOrder.Text = "Your order is: ";
                if (Lunch1ItemsAdded > 0)
                {
                    int item = Lunch1ItemsAddedList[0];
                    lblOrder.Text += arrayLunchWeek1Food[item] + " $" + arrayLunchWeek1Price[item] + " ";
                }

            }
        }
        public int CalcRemovedLunch1Item(string argsSender)
        {
            int index = -1;
            for (int i = 0; i < arrayLunchWeek1DownButtons.Length; i++)
            {
                if (arrayLunchWeek1DownButtons[i] == argsSender)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public int CalcAddedLunch2Item(string argsSender)
        {
            int index = -1;
            for (int i = 0; i < arrayLunchWeek2UpButtons.Length; i++)
            {
                if (arrayLunchWeek2UpButtons[i] == argsSender)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        private void Lunch2UpArrowClicked(object sender, EventArgs e)
        {
            if (Lunch2ItemsAdded < 1)
            {
                Lunch2ItemsAdded++;
                string stringLunch2UpButton = (sender as Button).Name;
                int intLunch2UpButton = CalcAddedLunch2Item(stringLunch2UpButton);
                Lunch2ItemsAddedList.Add(intLunch2UpButton);
                lblOrder.Text = "Your order is: ";
                int item = Lunch2ItemsAddedList[0];
                lblOrder.Text += arrayLunchWeek2Food[item] + " $" + arrayLunchWeek2Price[item] + " ";
            }
        }
        private void Lunch2DownArrowClicked(object sender, EventArgs e)
        {
            if (Lunch2ItemsAdded > 0)
            {
                string stringLunch2DownButton = (sender as Button).Name;
                int intLunch2DownButton = CalcRemovedLunch2Item(stringLunch2DownButton);
                Lunch2ItemsAddedList.Remove(intLunch2DownButton);
                Lunch2ItemsAdded = Lunch2ItemsAddedList.Count;
                lblOrder.Text = "Your order is: ";
                if (Lunch2ItemsAdded > 0)
                {
                    int item = Lunch2ItemsAddedList[0];
                    lblOrder.Text += arrayLunchWeek2Food[item] + " $" + arrayLunchWeek2Price[item] + " ";
                }

            }
        }
        public int CalcRemovedLunch2Item(string argsSender)
        {
            int index = -1;
            for (int i = 0; i < arrayLunchWeek2DownButtons.Length; i++)
            {
                if (arrayLunchWeek2DownButtons[i] == argsSender)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}