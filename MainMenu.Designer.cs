using System;
using System.Drawing;
using System.Windows.Forms;

namespace MegaDesk_JosueBenjaminCenturion
{
    partial class MainMenu : Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        


        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuote = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuote
            // 
            this.addQuote.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuote.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addQuote.Location = new System.Drawing.Point(23, 59);
            this.addQuote.Name = "addQuote";
            this.addQuote.Size = new System.Drawing.Size(127, 47);
            this.addQuote.TabIndex = 0;
            this.addQuote.Text = "Add New Quote";
            this.addQuote.UseVisualStyleBackColor = false;
            this.addQuote.Click += new System.EventHandler(this.addQuote_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.viewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.viewQuotes.Location = new System.Drawing.Point(23, 113);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(127, 47);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = false;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.searchQuotes.Location = new System.Drawing.Point(23, 167);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(127, 47);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = false;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exit.Location = new System.Drawing.Point(23, 221);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 47);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MegaDesk_JosueBenjaminCenturion.Properties.Resources.desk;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 344);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.addQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button addQuote;
        private Button viewQuotes;
        private Button searchQuotes;
        private Button exit;
        private PictureBox pictureBox1;
    }
}

//class Desk pseudocode
//{
//    // Properties with getters and setters
//    public int Price { get; set; }
//    public string Material { get; set; }
//    // Other properties: Width, Depth, Drawers, ProductionTime, etc.

//    // Constructor
//    public Desk(int price, string material, ...)
//    {
//        Price = price;
//        Material = material;
//        // Initialize other properties
//    }
//}

//class DeskQuote
//{
//    // Properties
//    public int DeskProperty1 { get; set; }
//    public string DeskProperty2 { get; set; }
//    // Other properties: DeskQuantity, RushDays, CustomerName, QuoteDate, etc.

//    // Constructor
//    public DeskQuote(int deskProperty1, string deskProperty2, ...)
//    {
//        DeskProperty1 = deskProperty1;
//        DeskProperty2 = deskProperty2;
//        // Initialize other properties
//    }

//    // Method to calculate the total price of the desk
//    public int CalculateTotalPrice()
//    {
//        int totalPrice = 0;

//        // Perform calculations
//        // Consider using the Date function to calculate the day
//        // Calculating conditionally the price per in and other properties

//        if (RushDays conditional pricing structure) 
//        {
//            // Modify the price per square inch based on rush days
//        }

//        // Calculate the total price based on various factors
//        totalPrice = (PricePerIn2 * Size) + Material + Drawers;

//        return totalPrice;
//    }

//    // Method to create a quote
//    public DeskQuote CreateQuote()
//    {
//        int total = CalculateTotalPrice();

//        // Create a new object with the updated total
//        DeskQuote quote = new DeskQuote(...DeskProperties, total);

//        return quote;
//    }
//}