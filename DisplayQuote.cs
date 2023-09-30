using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MegaDesk_JosueBenjaminCenturion
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote _deskQuote;

        // Constructor to receive the deskQuote object
        public DisplayQuote(DeskQuote deskQuote)
        {
            _deskQuote = deskQuote;
            InitializeComponent();
            AssignQuoteInformationToLabels();
        }

     
        public void AssignQuoteInformationToLabels()
        {
            // Assign the quote information to the labels on the form
            widthLabel.Text = _deskQuote.Desk.Width.ToString();
            depthLabel.Text = _deskQuote.Desk.Depth.ToString();
            materialLabel.Text = _deskQuote.Desk.desktopMaterialProps.ToString();
            drawersLabel.Text = _deskQuote.Desk.Drawers.ToString();
            currentDateLabel.Text = _deskQuote.Date;
            nameLabel.Text = _deskQuote.CustomerName;
            // Display special message if the chosen rush days are 14
            int rushdays = _deskQuote.RushDays;

            if (rushdays == 14)
            {
                rushDaysLabel.Text = "14 days, no extra cost"; 
            } else
            {
               rushDaysLabel.Text = rushdays.ToString();
            }
           
            //quotePriceLabel.Text = _deskQuote.QuotePrice.ToString();
        }
    }
}
