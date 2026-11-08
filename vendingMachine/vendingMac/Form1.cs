using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace vendingMac
{
    public partial class Form1 : Form
    {
        private decimal total = 0m;
        private decimal insertedAmount = 0m;
        private Dictionary<string, int> itemCounts = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();

            // Initialise item labels
            crisps.Text = "Crisps - £1.20";
            coke1.Text = "Coke Can - £1.50";
            coke2.Text = "Coke Bottle - £2.00";
            sandwich.Text = "Sandwich - £3.50";
            water.Text = "Water - £1.00";

            // Initialise item counts
            itemCounts["Crisps"] = 0;
            itemCounts["Coke (Can)"] = 0;
            itemCounts["Coke (Bottle)"] = 0;  // makes sure they are all 0, like the amount. add a call for when transaction, currently doesnt reset
            itemCounts["Sandwich"] = 0;
            itemCounts["Water"] = 0;

            // Enable drag and drop for payment
            EnablePaymentDragDrop();

            // Show initial total
            UpdateTotalDisplay();
        }

        // =============================
        //  ITEM BUTTONS
        // =============================
        private void crisps_Click(object sender, EventArgs e) => AddItem("Crisps", 1.20m, 0); //last number, in this case 0, will be calleed later to add to array showing how much has been added.
        private void coke1_Click(object sender, EventArgs e) => AddItem("Coke (Can)", 1.50m, 1);
        private void coke2_Click(object sender, EventArgs e) => AddItem("Coke (Bottle)", 2.00m, 2);
        private void sandwich_Click(object sender, EventArgs e) => AddItem("Sandwich", 3.50m, 3);
        private void water_Click(object sender, EventArgs e) => AddItem("Water", 1.00m, 4);

        private void AddItem(string itemName, decimal price, int index)
        {
            total += price;
            itemCounts[itemName]++;
            UpdateListBox();
            UpdateTotalDisplay();
        }

        // ============================= 
        // the GrEaT RESET BUTTON , changed to clear, as to go by the guide lines
        // =============================
        private void reset_Click(object sender, EventArgs e)
        {
            // Reset totals and inserted money
            total = 0m;
            insertedAmount = 0m;

            // Reset item counts
            foreach (var key in itemCounts.Keys.ToList())
                itemCounts[key] = 0;

            // Clear the listbox
            listBox1.Items.Clear();

            // Update display
            UpdateTotalDisplay(); // below add connection to payment. problem in clearing by payment

            MessageBox.Show("All items have been removed.",
                            "clear Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
           
        }
        
        // =============================
        // LISTBOX + DISPLAY
        // =============================
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var kvp in itemCounts) //way too overcomplicated also kvp stands for KeyValuePair
            {
                if (kvp.Value > 0)
                    listBox1.Items.Add($"{kvp.Key} x{kvp.Value}");
            }
        }

        private void UpdateTotalDisplay()
        {
            if (totalAmounts2 != null)
                totalAmounts2.Text = $"£{total:F2}"; //to be called later
        }

        private string GetItemName(int index)
        {
            return index switch
            {
                0 => "Crisps",
                1 => "Coke (Can)",
                2 => "Coke (Bottle)",
                3 => "Sandwich",
                4 => "Water",
                _ => ""
            };
        }

        // =============================
        //  DRAG & DROP PAYMENT
        // =============================
        private void EnablePaymentDragDrop()
        {
            // Enable dragging from payment sources
            TheCard.MouseDown += Payment_MouseDown;
            pound.MouseDown += Payment_MouseDown;
            pound20.MouseDown += Payment_MouseDown;

            // Allow drop on slots
            CardSlot.AllowDrop = true;
            CoinSlot.AllowDrop = true;
            NoteSlot.AllowDrop = true;

            // Connect slot events
            CardSlot.DragEnter += Slot_DragEnter;
            CardSlot.DragDrop += CardSlot_DragDrop;

            CoinSlot.DragEnter += Slot_DragEnter;
            CoinSlot.DragDrop += CoinSlot_DragDrop;

            NoteSlot.DragEnter += Slot_DragEnter;
            NoteSlot.DragDrop += NoteSlot_DragDrop;
        }

        private void Payment_MouseDown(object sender, MouseEventArgs e) 
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                pb.DoDragDrop(pb.Name, DragDropEffects.Move);
            }
        }

        private void Slot_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void CardSlot_DragDrop(object sender, DragEventArgs e)
        {
            string item = e.Data.GetData(DataFormats.Text).ToString();
            if (item == "TheCard")
            {
                if (total > 0)
                {
                    MessageBox.Show("Card payment successful! Thank you.",
                                    "Payment",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    insertedAmount = total;
                    total = 0m;
                    listBox1.Items.Clear();
                    UpdateTotalDisplay();
                }
                else
                {
                    MessageBox.Show("No payment needed. Please select an item first.",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void CoinSlot_DragDrop(object sender, DragEventArgs e)
        {
            string item = e.Data.GetData(DataFormats.Text).ToString();
            if (item == "pound")
            {
                insertedAmount += 1.00m;
                MessageBox.Show("£1 coin inserted.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheckIfEnoughPaid();
            }
        }

        private void NoteSlot_DragDrop(object sender, DragEventArgs e)
        {
            string item = e.Data.GetData(DataFormats.Text).ToString();
            if (item == "pound20")
            {
                insertedAmount += 20.00m;
                MessageBox.Show("£20 note inserted.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheckIfEnoughPaid();
            }
        }

        private void CheckIfEnoughPaid()
        {
            if (total > 0 && insertedAmount >= total)
            {
                MessageBox.Show("Payment complete! Enjoy your items.",
                                "Vending Machine",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information); //add under text box for change.

                insertedAmount -= total;
                total = 0m;
                listBox1.Items.Clear(); 
                UpdateTotalDisplay(); //connect to reset button which is now called clear
            }
            else if (total > 0)
            {
                decimal remaining = total - insertedAmount;
                MessageBox.Show($"Remaining amount: £{remaining:F2}",
                                "Payment",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
