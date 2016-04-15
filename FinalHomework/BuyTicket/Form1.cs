using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketLibrary;

namespace BuyTicket
{    
    public partial class Form1 : Form
    {
        private List<Ticket> tickets;

        public Form1()
        {
            InitializeComponent();
            tickets = new List<Ticket> ();
            TicketCatagory.SelectedIndex = 0;
        }

       

        private void Buyingbutton_Click(object sender, EventArgs e)
        {
            Ticket ticket = null;
            if (TicketCatagory.SelectedIndex == 0)
            {
                ticket = new Ticket(numberTextBox.Text, priceTextBox.Text);
            }
            else if (TicketCatagory.SelectedIndex == 1)
            {
                ticket = new StudentTicket(numberTextBox.Text, priceTextBox.Text);
            }
            else if (TicketCatagory.SelectedIndex == 2)
            {
                ticket = new ChildTicket(numberTextBox.Text, priceTextBox.Text, ageTextBox.Text);
            }
            tickets.Add(ticket);
            UpdateTicketInfo();
        }
        private void UpdateTicketInfo()
        {
            DisplayTextBox.Text = string.Empty;
            numberTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
             
            foreach (Ticket  ticket in tickets)
            {
                DisplayTextBox.Text += string.Format("{0}\n"
                    , ticket);
            }
        }

        private void TicketCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
           agelabel.Visible = TicketCatagory.SelectedIndex ==2; 
           ageTextBox.Visible = TicketCatagory.SelectedIndex ==2;
        }
    }
    }
