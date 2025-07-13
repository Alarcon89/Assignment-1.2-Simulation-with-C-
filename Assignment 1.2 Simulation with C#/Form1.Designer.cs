namespace Assignment_1._2_Simulation_with_C_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1CoffeeShop = new System.Windows.Forms.Label();
            this.buttonEspresso = new System.Windows.Forms.Button();
            this.labelDrinksUnits = new System.Windows.Forms.Label();
            this.labelDrinkCount = new System.Windows.Forms.Label();
            this.buttonLatte = new System.Windows.Forms.Button();
            this.buttonCappuccino = new System.Windows.Forms.Button();
            this.groupBoxCoffeeStats = new System.Windows.Forms.GroupBox();
            this.groupBoxDrinksMenu = new System.Windows.Forms.GroupBox();
            this.labelTotalSold = new System.Windows.Forms.Label();
            this.labelDrinkSold = new System.Windows.Forms.Label();
            this.groupBoxCoffeeStats.SuspendLayout();
            this.groupBoxDrinksMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1CoffeeShop
            // 
            this.label1CoffeeShop.AutoSize = true;
            this.label1CoffeeShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CoffeeShop.Location = new System.Drawing.Point(433, 9);
            this.label1CoffeeShop.Name = "label1CoffeeShop";
            this.label1CoffeeShop.Size = new System.Drawing.Size(390, 73);
            this.label1CoffeeShop.TabIndex = 0;
            this.label1CoffeeShop.Text = "Coffee Shop";
            // 
            // buttonEspresso
            // 
            this.buttonEspresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEspresso.Location = new System.Drawing.Point(6, 49);
            this.buttonEspresso.Name = "buttonEspresso";
            this.buttonEspresso.Size = new System.Drawing.Size(95, 23);
            this.buttonEspresso.TabIndex = 2;
            this.buttonEspresso.Text = "Espresso";
            this.buttonEspresso.UseVisualStyleBackColor = true;
            this.buttonEspresso.Click += new System.EventHandler(this.buttonEspresso_Click);
            // 
            // labelDrinksUnits
            // 
            this.labelDrinksUnits.AutoSize = true;
            this.labelDrinksUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrinksUnits.Location = new System.Drawing.Point(18, 49);
            this.labelDrinksUnits.Name = "labelDrinksUnits";
            this.labelDrinksUnits.Size = new System.Drawing.Size(154, 29);
            this.labelDrinksUnits.TabIndex = 3;
            this.labelDrinksUnits.Text = "Total Sales:$";
            // 
            // labelDrinkCount
            // 
            this.labelDrinkCount.AutoSize = true;
            this.labelDrinkCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrinkCount.Location = new System.Drawing.Point(171, 49);
            this.labelDrinkCount.Name = "labelDrinkCount";
            this.labelDrinkCount.Size = new System.Drawing.Size(26, 29);
            this.labelDrinkCount.TabIndex = 4;
            this.labelDrinkCount.Text = "0";
            this.labelDrinkCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLatte
            // 
            this.buttonLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLatte.Location = new System.Drawing.Point(6, 78);
            this.buttonLatte.Name = "buttonLatte";
            this.buttonLatte.Size = new System.Drawing.Size(75, 23);
            this.buttonLatte.TabIndex = 5;
            this.buttonLatte.Text = " Latte";
            this.buttonLatte.UseVisualStyleBackColor = true;
            this.buttonLatte.Click += new System.EventHandler(this.buttonLatte_Click);
            // 
            // buttonCappuccino
            // 
            this.buttonCappuccino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCappuccino.Location = new System.Drawing.Point(6, 107);
            this.buttonCappuccino.Name = "buttonCappuccino";
            this.buttonCappuccino.Size = new System.Drawing.Size(112, 25);
            this.buttonCappuccino.TabIndex = 6;
            this.buttonCappuccino.Text = "Cappuccino";
            this.buttonCappuccino.UseVisualStyleBackColor = true;
            this.buttonCappuccino.Click += new System.EventHandler(this.buttonCapuccino_Click);
            // 
            // groupBoxCoffeeStats
            // 
            this.groupBoxCoffeeStats.Controls.Add(this.labelDrinkSold);
            this.groupBoxCoffeeStats.Controls.Add(this.labelTotalSold);
            this.groupBoxCoffeeStats.Controls.Add(this.labelDrinksUnits);
            this.groupBoxCoffeeStats.Controls.Add(this.labelDrinkCount);
            this.groupBoxCoffeeStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCoffeeStats.Location = new System.Drawing.Point(785, 129);
            this.groupBoxCoffeeStats.Name = "groupBoxCoffeeStats";
            this.groupBoxCoffeeStats.Size = new System.Drawing.Size(372, 370);
            this.groupBoxCoffeeStats.TabIndex = 7;
            this.groupBoxCoffeeStats.TabStop = false;
            this.groupBoxCoffeeStats.Text = "Coffee Stats";
            // 
            // groupBoxDrinksMenu
            // 
            this.groupBoxDrinksMenu.Controls.Add(this.buttonEspresso);
            this.groupBoxDrinksMenu.Controls.Add(this.buttonLatte);
            this.groupBoxDrinksMenu.Controls.Add(this.buttonCappuccino);
            this.groupBoxDrinksMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDrinksMenu.Location = new System.Drawing.Point(154, 129);
            this.groupBoxDrinksMenu.Name = "groupBoxDrinksMenu";
            this.groupBoxDrinksMenu.Size = new System.Drawing.Size(353, 370);
            this.groupBoxDrinksMenu.TabIndex = 8;
            this.groupBoxDrinksMenu.TabStop = false;
            this.groupBoxDrinksMenu.Text = "Drinks Menu";
            // 
            // labelTotalSold
            // 
            this.labelTotalSold.AutoSize = true;
            this.labelTotalSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSold.Location = new System.Drawing.Point(18, 102);
            this.labelTotalSold.Name = "labelTotalSold";
            this.labelTotalSold.Size = new System.Drawing.Size(130, 29);
            this.labelTotalSold.TabIndex = 5;
            this.labelTotalSold.Text = "Total Sold:";
            this.labelTotalSold.Click += new System.EventHandler(this.labelTotalSold_Click);
            // 
            // labelDrinkSold
            // 
            this.labelDrinkSold.AutoSize = true;
            this.labelDrinkSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrinkSold.Location = new System.Drawing.Point(171, 102);
            this.labelDrinkSold.Name = "labelDrinkSold";
            this.labelDrinkSold.Size = new System.Drawing.Size(26, 29);
            this.labelDrinkSold.TabIndex = 6;
            this.labelDrinkSold.Text = "0";
            this.labelDrinkSold.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1305, 614);
            this.Controls.Add(this.groupBoxDrinksMenu);
            this.Controls.Add(this.groupBoxCoffeeStats);
            this.Controls.Add(this.label1CoffeeShop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCoffeeStats.ResumeLayout(false);
            this.groupBoxCoffeeStats.PerformLayout();
            this.groupBoxDrinksMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1CoffeeShop;
        private System.Windows.Forms.Button buttonEspresso;
        private System.Windows.Forms.Label labelDrinksUnits;
        private System.Windows.Forms.Label labelDrinkCount;
        private System.Windows.Forms.Button buttonLatte;
        private System.Windows.Forms.Button buttonCappuccino;
        private System.Windows.Forms.GroupBox groupBoxCoffeeStats;
        private System.Windows.Forms.GroupBox groupBoxDrinksMenu;
        private System.Windows.Forms.Label labelTotalSold;
        private System.Windows.Forms.Label labelDrinkSold;
    }
}

