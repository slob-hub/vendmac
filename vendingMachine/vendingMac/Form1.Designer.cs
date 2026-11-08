namespace vendingMac
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            crisps = new Button();
            coke1 = new Button();
            coke2 = new Button();
            sandwich = new Button();
            water = new Button();
            listBox1 = new ListBox();
            vendingPic = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1 = new GroupBox();
            ButtonBack = new GroupBox();
            CardSlot = new PictureBox();
            NoteSlot = new PictureBox();
            CoinSlot = new PictureBox();
            TheCard = new PictureBox();
            pound = new PictureBox();
            pound20 = new PictureBox();
            totalAmounts2 = new TextBox();
            reset = new Button();
            ((System.ComponentModel.ISupportInitialize)vendingPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CardSlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NoteSlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoinSlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TheCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pound20).BeginInit();
            SuspendLayout();
            // 
            // crisps
            // 
            crisps.Location = new Point(168, 127);
            crisps.Name = "crisps";
            crisps.Size = new Size(160, 23);
            crisps.TabIndex = 0;
            crisps.Text = "crisps";
            crisps.UseVisualStyleBackColor = true;
            crisps.Click += crisps_Click;
            // 
            // coke1
            // 
            coke1.Location = new Point(168, 156);
            coke1.Name = "coke1";
            coke1.Size = new Size(160, 23);
            coke1.TabIndex = 1;
            coke1.Text = "coke";
            coke1.UseVisualStyleBackColor = true;
            coke1.Click += coke1_Click;
            // 
            // coke2
            // 
            coke2.Location = new Point(168, 185);
            coke2.Name = "coke2";
            coke2.Size = new Size(160, 23);
            coke2.TabIndex = 2;
            coke2.Text = "Coke0";
            coke2.UseVisualStyleBackColor = true;
            coke2.Click += coke2_Click;
            // 
            // sandwich
            // 
            sandwich.Location = new Point(168, 214);
            sandwich.Name = "sandwich";
            sandwich.Size = new Size(160, 23);
            sandwich.TabIndex = 3;
            sandwich.Text = "sandwich";
            sandwich.UseVisualStyleBackColor = true;
            sandwich.Click += sandwich_Click;
            // 
            // water
            // 
            water.Location = new Point(168, 243);
            water.Name = "water";
            water.Size = new Size(160, 25);
            water.TabIndex = 4;
            water.Text = "water";
            water.UseVisualStyleBackColor = true;
            water.Click += water_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(168, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(160, 64);
            listBox1.TabIndex = 5;
            // 
            // vendingPic
            // 
            vendingPic.Image = (Image)resources.GetObject("vendingPic.Image");
            vendingPic.Location = new Point(27, 43);
            vendingPic.Name = "vendingPic";
            vendingPic.Size = new Size(100, 225);
            vendingPic.SizeMode = PictureBoxSizeMode.StretchImage;
            vendingPic.TabIndex = 6;
            vendingPic.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(131, 264);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "vendImage";
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = SystemColors.GradientInactiveCaption;
            ButtonBack.Location = new Point(158, 112);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(181, 174);
            ButtonBack.TabIndex = 8;
            ButtonBack.TabStop = false;
            // 
            // CardSlot
            // 
            CardSlot.Image = (Image)resources.GetObject("CardSlot.Image");
            CardSlot.Location = new Point(218, 339);
            CardSlot.Name = "CardSlot";
            CardSlot.Size = new Size(121, 50);
            CardSlot.SizeMode = PictureBoxSizeMode.StretchImage;
            CardSlot.TabIndex = 9;
            CardSlot.TabStop = false;
            // 
            // NoteSlot
            // 
            NoteSlot.Image = (Image)resources.GetObject("NoteSlot.Image");
            NoteSlot.Location = new Point(218, 283);
            NoteSlot.Name = "NoteSlot";
            NoteSlot.Size = new Size(121, 50);
            NoteSlot.SizeMode = PictureBoxSizeMode.StretchImage;
            NoteSlot.TabIndex = 10;
            NoteSlot.TabStop = false;
            // 
            // CoinSlot
            // 
            CoinSlot.Image = (Image)resources.GetObject("CoinSlot.Image");
            CoinSlot.Location = new Point(149, 274);
            CoinSlot.Name = "CoinSlot";
            CoinSlot.Size = new Size(63, 134);
            CoinSlot.SizeMode = PictureBoxSizeMode.StretchImage;
            CoinSlot.TabIndex = 11;
            CoinSlot.TabStop = false;
            // 
            // TheCard
            // 
            TheCard.Image = (Image)resources.GetObject("TheCard.Image");
            TheCard.Location = new Point(27, 388);
            TheCard.Name = "TheCard";
            TheCard.Size = new Size(100, 50);
            TheCard.SizeMode = PictureBoxSizeMode.StretchImage;
            TheCard.TabIndex = 12;
            TheCard.TabStop = false;
            // 
            // pound
            // 
            pound.Image = (Image)resources.GetObject("pound.Image");
            pound.Location = new Point(27, 339);
            pound.Name = "pound";
            pound.Size = new Size(100, 50);
            pound.SizeMode = PictureBoxSizeMode.StretchImage;
            pound.TabIndex = 13;
            pound.TabStop = false;
            // 
            // pound20
            // 
            pound20.Image = (Image)resources.GetObject("pound20.Image");
            pound20.Location = new Point(27, 292);
            pound20.Name = "pound20";
            pound20.Size = new Size(100, 50);
            pound20.SizeMode = PictureBoxSizeMode.StretchImage;
            pound20.TabIndex = 14;
            pound20.TabStop = false;
            // 
            // totalAmounts2
            // 
            totalAmounts2.Location = new Point(168, 83);
            totalAmounts2.Name = "totalAmounts2";
            totalAmounts2.Size = new Size(160, 23);
            totalAmounts2.TabIndex = 15;
            // 
            // reset
            // 
            reset.Location = new Point(264, 424);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 16;
            reset.Text = "clear";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(reset);
            Controls.Add(totalAmounts2);
            Controls.Add(pound20);
            Controls.Add(pound);
            Controls.Add(TheCard);
            Controls.Add(CoinSlot);
            Controls.Add(NoteSlot);
            Controls.Add(CardSlot);
            Controls.Add(vendingPic);
            Controls.Add(listBox1);
            Controls.Add(water);
            Controls.Add(sandwich);
            Controls.Add(coke2);
            Controls.Add(coke1);
            Controls.Add(crisps);
            Controls.Add(groupBox1);
            Controls.Add(ButtonBack);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)vendingPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)CardSlot).EndInit();
            ((System.ComponentModel.ISupportInitialize)NoteSlot).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoinSlot).EndInit();
            ((System.ComponentModel.ISupportInitialize)TheCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pound).EndInit();
            ((System.ComponentModel.ISupportInitialize)pound20).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button crisps;
        private Button coke1;
        private Button coke2;
        private Button sandwich;
        private Button water;
        private ListBox listBox1;
        private PictureBox vendingPic;
        private SaveFileDialog saveFileDialog1;
        private GroupBox groupBox1;
        private GroupBox ButtonBack;
        private TextBox totalAmounts2;
        private PictureBox CardSlot;
        private PictureBox NoteSlot;
        private PictureBox CoinSlot;
        private PictureBox TheCard;
        private PictureBox pound;
        private PictureBox pound20;
        private Button reset;
    }
}
