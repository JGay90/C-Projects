namespace WeilandR_HW7_3
{
    partial class dungeonCrawlForm
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
            this.components = new System.ComponentModel.Container();
            this.roomGroupbox = new System.Windows.Forms.GroupBox();
            this.useRoomItemButton = new System.Windows.Forms.Button();
            this.pickUpItemButton = new System.Windows.Forms.Button();
            this.attackMobButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomItemListBox = new System.Windows.Forms.ListBox();
            this.mobListBox = new System.Windows.Forms.ListBox();
            this.InventoryGroupbox = new System.Windows.Forms.GroupBox();
            this.usePlayerItemButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.playerItemListBox = new System.Windows.Forms.ListBox();
            this.displayTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.roomGroupbox.SuspendLayout();
            this.InventoryGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomGroupbox
            // 
            this.roomGroupbox.Controls.Add(this.useRoomItemButton);
            this.roomGroupbox.Controls.Add(this.pickUpItemButton);
            this.roomGroupbox.Controls.Add(this.attackMobButton);
            this.roomGroupbox.Controls.Add(this.label3);
            this.roomGroupbox.Controls.Add(this.label2);
            this.roomGroupbox.Controls.Add(this.roomItemListBox);
            this.roomGroupbox.Controls.Add(this.mobListBox);
            this.roomGroupbox.Location = new System.Drawing.Point(662, 6);
            this.roomGroupbox.Name = "roomGroupbox";
            this.roomGroupbox.Size = new System.Drawing.Size(383, 148);
            this.roomGroupbox.TabIndex = 2;
            this.roomGroupbox.TabStop = false;
            this.roomGroupbox.Text = "Room";
            // 
            // useRoomItemButton
            // 
            this.useRoomItemButton.Location = new System.Drawing.Point(286, 118);
            this.useRoomItemButton.Name = "useRoomItemButton";
            this.useRoomItemButton.Size = new System.Drawing.Size(75, 23);
            this.useRoomItemButton.TabIndex = 2;
            this.useRoomItemButton.Text = "Use";
            this.useRoomItemButton.UseVisualStyleBackColor = true;
            this.useRoomItemButton.Click += new System.EventHandler(this.useRoomItemButton_Click);
            // 
            // pickUpItemButton
            // 
            this.pickUpItemButton.Location = new System.Drawing.Point(205, 118);
            this.pickUpItemButton.Name = "pickUpItemButton";
            this.pickUpItemButton.Size = new System.Drawing.Size(75, 23);
            this.pickUpItemButton.TabIndex = 2;
            this.pickUpItemButton.Text = "Pick Up";
            this.pickUpItemButton.UseVisualStyleBackColor = true;
            this.pickUpItemButton.Click += new System.EventHandler(this.pickUpItemButton_Click);
            // 
            // attackMobButton
            // 
            this.attackMobButton.Location = new System.Drawing.Point(67, 118);
            this.attackMobButton.Name = "attackMobButton";
            this.attackMobButton.Size = new System.Drawing.Size(75, 23);
            this.attackMobButton.TabIndex = 2;
            this.attackMobButton.Text = "Attack";
            this.attackMobButton.UseVisualStyleBackColor = true;
            this.attackMobButton.Click += new System.EventHandler(this.attackMobButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inhabitants";
            // 
            // roomItemListBox
            // 
            this.roomItemListBox.FormattingEnabled = true;
            this.roomItemListBox.Location = new System.Drawing.Point(192, 30);
            this.roomItemListBox.Name = "roomItemListBox";
            this.roomItemListBox.Size = new System.Drawing.Size(180, 82);
            this.roomItemListBox.Sorted = true;
            this.roomItemListBox.TabIndex = 0;
            // 
            // mobListBox
            // 
            this.mobListBox.FormattingEnabled = true;
            this.mobListBox.Location = new System.Drawing.Point(6, 30);
            this.mobListBox.Name = "mobListBox";
            this.mobListBox.Size = new System.Drawing.Size(180, 82);
            this.mobListBox.Sorted = true;
            this.mobListBox.TabIndex = 0;
            // 
            // InventoryGroupbox
            // 
            this.InventoryGroupbox.Controls.Add(this.usePlayerItemButton);
            this.InventoryGroupbox.Controls.Add(this.label5);
            this.InventoryGroupbox.Controls.Add(this.playerItemListBox);
            this.InventoryGroupbox.Location = new System.Drawing.Point(725, 175);
            this.InventoryGroupbox.Name = "InventoryGroupbox";
            this.InventoryGroupbox.Size = new System.Drawing.Size(192, 148);
            this.InventoryGroupbox.TabIndex = 4;
            this.InventoryGroupbox.TabStop = false;
            this.InventoryGroupbox.Text = "Inventory";
            // 
            // usePlayerItemButton
            // 
            this.usePlayerItemButton.Location = new System.Drawing.Point(60, 118);
            this.usePlayerItemButton.Name = "usePlayerItemButton";
            this.usePlayerItemButton.Size = new System.Drawing.Size(75, 23);
            this.usePlayerItemButton.TabIndex = 2;
            this.usePlayerItemButton.Text = "Use";
            this.usePlayerItemButton.UseVisualStyleBackColor = true;
            this.usePlayerItemButton.Click += new System.EventHandler(this.usePlayerItemButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Items";
            // 
            // playerItemListBox
            // 
            this.playerItemListBox.FormattingEnabled = true;
            this.playerItemListBox.Location = new System.Drawing.Point(6, 30);
            this.playerItemListBox.Name = "playerItemListBox";
            this.playerItemListBox.Size = new System.Drawing.Size(180, 82);
            this.playerItemListBox.Sorted = true;
            this.playerItemListBox.TabIndex = 0;
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.displayTextBox.Location = new System.Drawing.Point(12, 12);
            this.displayTextBox.MaxLength = 300;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(595, 372);
            this.displayTextBox.TabIndex = 6;
            this.displayTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(511, 20);
            this.textBox1.TabIndex = 7;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(532, 405);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // dungeonCrawlForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 439);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.InventoryGroupbox);
            this.Controls.Add(this.roomGroupbox);
            this.Name = "dungeonCrawlForm";
            this.Text = "Dungeon Crawl";
            this.roomGroupbox.ResumeLayout(false);
            this.roomGroupbox.PerformLayout();
            this.InventoryGroupbox.ResumeLayout(false);
            this.InventoryGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox roomGroupbox;
        private System.Windows.Forms.Button useRoomItemButton;
        private System.Windows.Forms.Button pickUpItemButton;
        private System.Windows.Forms.Button attackMobButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox roomItemListBox;
        private System.Windows.Forms.ListBox mobListBox;
        private System.Windows.Forms.GroupBox InventoryGroupbox;
        private System.Windows.Forms.Button usePlayerItemButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox playerItemListBox;
        private System.Windows.Forms.RichTextBox displayTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitButton;
    }
}

