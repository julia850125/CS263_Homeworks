namespace BuyTicket
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.numberLlabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.DisplayTextBox = new System.Windows.Forms.RichTextBox();
            this.Buyingbutton = new System.Windows.Forms.Button();
            this.TicketCatagory = new System.Windows.Forms.ComboBox();
            this.ticketCatagerorylabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberLlabel
            // 
            this.numberLlabel.AutoSize = true;
            this.numberLlabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberLlabel.Location = new System.Drawing.Point(3, 9);
            this.numberLlabel.Name = "numberLlabel";
            this.numberLlabel.Size = new System.Drawing.Size(59, 26);
            this.numberLlabel.TabIndex = 0;
            this.numberLlabel.Text = "數量:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.numberTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberTextBox.Location = new System.Drawing.Point(68, 6);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(121, 35);
            this.numberTextBox.TabIndex = 1;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(12, 169);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(450, 113);
            this.DisplayTextBox.TabIndex = 2;
            this.DisplayTextBox.Text = "";
            // 
            // Buyingbutton
            // 
            this.Buyingbutton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Buyingbutton.Location = new System.Drawing.Point(322, 95);
            this.Buyingbutton.Name = "Buyingbutton";
            this.Buyingbutton.Size = new System.Drawing.Size(125, 68);
            this.Buyingbutton.TabIndex = 3;
            this.Buyingbutton.Text = "購票";
            this.Buyingbutton.UseVisualStyleBackColor = true;
            this.Buyingbutton.Click += new System.EventHandler(this.Buyingbutton_Click);
            // 
            // TicketCatagory
            // 
            this.TicketCatagory.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TicketCatagory.FormattingEnabled = true;
            this.TicketCatagory.Items.AddRange(new object[] {
            "普通票",
            "學生票",
            "兒童票"});
            this.TicketCatagory.Location = new System.Drawing.Point(326, 7);
            this.TicketCatagory.Name = "TicketCatagory";
            this.TicketCatagory.Size = new System.Drawing.Size(121, 34);
            this.TicketCatagory.TabIndex = 4;
            this.TicketCatagory.SelectedIndexChanged += new System.EventHandler(this.TicketCatagory_SelectedIndexChanged);
            // 
            // ticketCatagerorylabel
            // 
            this.ticketCatagerorylabel.AutoSize = true;
            this.ticketCatagerorylabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ticketCatagerorylabel.Location = new System.Drawing.Point(250, 9);
            this.ticketCatagerorylabel.Name = "ticketCatagerorylabel";
            this.ticketCatagerorylabel.Size = new System.Drawing.Size(59, 26);
            this.ticketCatagerorylabel.TabIndex = 5;
            this.ticketCatagerorylabel.Text = "票種:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ageTextBox.Location = new System.Drawing.Point(68, 98);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(121, 35);
            this.ageTextBox.TabIndex = 7;
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.agelabel.Location = new System.Drawing.Point(3, 101);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(59, 26);
            this.agelabel.TabIndex = 6;
            this.agelabel.Text = "年齡:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceTextBox.Location = new System.Drawing.Point(68, 52);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 35);
            this.priceTextBox.TabIndex = 9;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceLabel.Location = new System.Drawing.Point(3, 55);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(59, 26);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "票價:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 294);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.ticketCatagerorylabel);
            this.Controls.Add(this.TicketCatagory);
            this.Controls.Add(this.Buyingbutton);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLlabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.RichTextBox DisplayTextBox;
        private System.Windows.Forms.Button Buyingbutton;
        private System.Windows.Forms.ComboBox TicketCatagory;
        private System.Windows.Forms.Label ticketCatagerorylabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
    }
}

