﻿using System.Windows;

namespace ProyectoJuntado.Events
{
    public partial class CompletePurchase : Window
    {
        private string eventLocation;
        private DateTime eventDate;
        private string ticketType;
        private int quantity;
        public CompletePurchase(string eventLocation, DateTime eventDate, string ticketType, int quantity)
        {
            InitializeComponent();
            this.eventLocation = eventLocation;
            this.eventDate = eventDate;
            this.ticketType = ticketType;
            this.quantity = quantity;
        }

        private void BackToEventsButton_Click(object sender, RoutedEventArgs eventArgs)
        {
            // Open/connect the Event window
            Event eventWindow = new Event();
            eventWindow.Show();

            // Close the CompletePurchase window
            Close();
        }
    }
}

