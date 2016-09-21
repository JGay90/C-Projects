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
            this.label1 = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.roomGroupbox = new System.Windows.Forms.GroupBox();
            this.useRoomItemButton = new System.Windows.Forms.Button();
            this.pickUpRoomItemButton = new System.Windows.Forms.Button();
            this.attackMobButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomItemListBox = new System.Windows.Forms.ListBox();
            this.mobListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.InventoryGroupbox = new System.Windows.Forms.GroupBox();
            this.usePlayerItemButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.playerItemListBox = new System.Windows.Forms.ListBox();
            this.combatGroupbox = new System.Windows.Forms.GroupBox();
            this.enemyGroupbox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.enemyLevelLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.enemyDefenseLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.enemyAttackLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.enemyHPLabel = new System.Windows.Forms.Label();
            this.playerGroupbox = new System.Windows.Forms.GroupBox();
            this.playerExpLabel = new System.Windows.Forms.Label();
            this.playerLevelLabel = new System.Windows.Forms.Label();
            this.playerDefenseLabel = new System.Windows.Forms.Label();
            this.playerAttackLabel = new System.Windows.Forms.Label();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.RichTextBox();
            this.combatLogGroupbox = new System.Windows.Forms.GroupBox();
            this.roomGroupbox.SuspendLayout();
            this.InventoryGroupbox.SuspendLayout();
            this.combatGroupbox.SuspendLayout();
            this.enemyGroupbox.SuspendLayout();
            this.playerGroupbox.SuspendLayout();
            this.combatLogGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room:";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNameLabel.Location = new System.Drawing.Point(56, 5);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(74, 21);
            this.roomNameLabel.TabIndex = 1;
            this.roomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roomGroupbox
            // 
            this.roomGroupbox.Controls.Add(this.useRoomItemButton);
            this.roomGroupbox.Controls.Add(this.pickUpRoomItemButton);
            this.roomGroupbox.Controls.Add(this.attackMobButton);
            this.roomGroupbox.Controls.Add(this.label3);
            this.roomGroupbox.Controls.Add(this.label2);
            this.roomGroupbox.Controls.Add(this.roomItemListBox);
            this.roomGroupbox.Controls.Add(this.mobListBox);
            this.roomGroupbox.Location = new System.Drawing.Point(15, 177);
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
            // 
            // pickUpRoomItemButton
            // 
            this.pickUpRoomItemButton.Location = new System.Drawing.Point(205, 118);
            this.pickUpRoomItemButton.Name = "pickUpRoomItemButton";
            this.pickUpRoomItemButton.Size = new System.Drawing.Size(75, 23);
            this.pickUpRoomItemButton.TabIndex = 2;
            this.pickUpRoomItemButton.Text = "Pick Up";
            this.pickUpRoomItemButton.UseVisualStyleBackColor = true;
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
            this.roomItemListBox.TabIndex = 0;
            // 
            // mobListBox
            // 
            this.mobListBox.FormattingEnabled = true;
            this.mobListBox.Location = new System.Drawing.Point(6, 30);
            this.mobListBox.Name = "mobListBox";
            this.mobListBox.Size = new System.Drawing.Size(180, 82);
            this.mobListBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Movement:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(207, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(269, 4);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(56, 23);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // InventoryGroupbox
            // 
            this.InventoryGroupbox.Controls.Add(this.usePlayerItemButton);
            this.InventoryGroupbox.Controls.Add(this.label5);
            this.InventoryGroupbox.Controls.Add(this.playerItemListBox);
            this.InventoryGroupbox.Location = new System.Drawing.Point(404, 177);
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
            this.playerItemListBox.TabIndex = 0;
            // 
            // combatGroupbox
            // 
            this.combatGroupbox.Controls.Add(this.enemyGroupbox);
            this.combatGroupbox.Controls.Add(this.playerGroupbox);
            this.combatGroupbox.Location = new System.Drawing.Point(15, 331);
            this.combatGroupbox.Name = "combatGroupbox";
            this.combatGroupbox.Size = new System.Drawing.Size(581, 170);
            this.combatGroupbox.TabIndex = 5;
            this.combatGroupbox.TabStop = false;
            this.combatGroupbox.Text = "Combat";
            // 
            // enemyGroupbox
            // 
            this.enemyGroupbox.Controls.Add(this.label11);
            this.enemyGroupbox.Controls.Add(this.enemyLevelLabel);
            this.enemyGroupbox.Controls.Add(this.label14);
            this.enemyGroupbox.Controls.Add(this.enemyDefenseLabel);
            this.enemyGroupbox.Controls.Add(this.label12);
            this.enemyGroupbox.Controls.Add(this.enemyAttackLabel);
            this.enemyGroupbox.Controls.Add(this.label13);
            this.enemyGroupbox.Controls.Add(this.enemyHPLabel);
            this.enemyGroupbox.Location = new System.Drawing.Point(377, 19);
            this.enemyGroupbox.Name = "enemyGroupbox";
            this.enemyGroupbox.Size = new System.Drawing.Size(198, 144);
            this.enemyGroupbox.TabIndex = 0;
            this.enemyGroupbox.TabStop = false;
            this.enemyGroupbox.Text = "Enemy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "HP:";
            // 
            // enemyLevelLabel
            // 
            this.enemyLevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyLevelLabel.Location = new System.Drawing.Point(63, 89);
            this.enemyLevelLabel.Name = "enemyLevelLabel";
            this.enemyLevelLabel.Size = new System.Drawing.Size(119, 23);
            this.enemyLevelLabel.TabIndex = 1;
            this.enemyLevelLabel.Text = "0";
            this.enemyLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Level:";
            // 
            // enemyDefenseLabel
            // 
            this.enemyDefenseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyDefenseLabel.Location = new System.Drawing.Point(63, 63);
            this.enemyDefenseLabel.Name = "enemyDefenseLabel";
            this.enemyDefenseLabel.Size = new System.Drawing.Size(119, 23);
            this.enemyDefenseLabel.TabIndex = 1;
            this.enemyDefenseLabel.Text = "0";
            this.enemyDefenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Attack:";
            // 
            // enemyAttackLabel
            // 
            this.enemyAttackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyAttackLabel.Location = new System.Drawing.Point(63, 37);
            this.enemyAttackLabel.Name = "enemyAttackLabel";
            this.enemyAttackLabel.Size = new System.Drawing.Size(119, 23);
            this.enemyAttackLabel.TabIndex = 1;
            this.enemyAttackLabel.Text = "0";
            this.enemyAttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Defense:";
            // 
            // enemyHPLabel
            // 
            this.enemyHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyHPLabel.Location = new System.Drawing.Point(63, 11);
            this.enemyHPLabel.Name = "enemyHPLabel";
            this.enemyHPLabel.Size = new System.Drawing.Size(119, 23);
            this.enemyHPLabel.TabIndex = 1;
            this.enemyHPLabel.Text = "0";
            this.enemyHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerGroupbox
            // 
            this.playerGroupbox.Controls.Add(this.playerExpLabel);
            this.playerGroupbox.Controls.Add(this.playerLevelLabel);
            this.playerGroupbox.Controls.Add(this.playerDefenseLabel);
            this.playerGroupbox.Controls.Add(this.playerAttackLabel);
            this.playerGroupbox.Controls.Add(this.playerHPLabel);
            this.playerGroupbox.Controls.Add(this.label10);
            this.playerGroupbox.Controls.Add(this.label9);
            this.playerGroupbox.Controls.Add(this.label8);
            this.playerGroupbox.Controls.Add(this.label7);
            this.playerGroupbox.Controls.Add(this.label6);
            this.playerGroupbox.Location = new System.Drawing.Point(6, 19);
            this.playerGroupbox.Name = "playerGroupbox";
            this.playerGroupbox.Size = new System.Drawing.Size(198, 144);
            this.playerGroupbox.TabIndex = 0;
            this.playerGroupbox.TabStop = false;
            this.playerGroupbox.Text = "Player";
            // 
            // playerExpLabel
            // 
            this.playerExpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerExpLabel.Location = new System.Drawing.Point(61, 115);
            this.playerExpLabel.Name = "playerExpLabel";
            this.playerExpLabel.Size = new System.Drawing.Size(119, 23);
            this.playerExpLabel.TabIndex = 1;
            this.playerExpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerLevelLabel
            // 
            this.playerLevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerLevelLabel.Location = new System.Drawing.Point(61, 89);
            this.playerLevelLabel.Name = "playerLevelLabel";
            this.playerLevelLabel.Size = new System.Drawing.Size(119, 23);
            this.playerLevelLabel.TabIndex = 1;
            this.playerLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerDefenseLabel
            // 
            this.playerDefenseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerDefenseLabel.Location = new System.Drawing.Point(61, 63);
            this.playerDefenseLabel.Name = "playerDefenseLabel";
            this.playerDefenseLabel.Size = new System.Drawing.Size(119, 23);
            this.playerDefenseLabel.TabIndex = 1;
            this.playerDefenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerAttackLabel
            // 
            this.playerAttackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerAttackLabel.Location = new System.Drawing.Point(61, 37);
            this.playerAttackLabel.Name = "playerAttackLabel";
            this.playerAttackLabel.Size = new System.Drawing.Size(119, 23);
            this.playerAttackLabel.TabIndex = 1;
            this.playerAttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHPLabel.Location = new System.Drawing.Point(61, 11);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(119, 23);
            this.playerHPLabel.TabIndex = 1;
            this.playerHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Exp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Level:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Defense:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Attack:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "HP:";
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.displayTextBox.Location = new System.Drawing.Point(6, 19);
            this.displayTextBox.MaxLength = 300;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(560, 115);
            this.displayTextBox.TabIndex = 6;
            this.displayTextBox.Text = "";
            // 
            // combatLogGroupbox
            // 
            this.combatLogGroupbox.Controls.Add(this.displayTextBox);
            this.combatLogGroupbox.Location = new System.Drawing.Point(19, 33);
            this.combatLogGroupbox.Name = "combatLogGroupbox";
            this.combatLogGroupbox.Size = new System.Drawing.Size(577, 138);
            this.combatLogGroupbox.TabIndex = 7;
            this.combatLogGroupbox.TabStop = false;
            this.combatLogGroupbox.Text = "Combat Log";
            // 
            // dungeonCrawlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 506);
            this.Controls.Add(this.combatLogGroupbox);
            this.Controls.Add(this.combatGroupbox);
            this.Controls.Add(this.InventoryGroupbox);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.roomGroupbox);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "dungeonCrawlForm";
            this.Text = "Dungeon Crawl";
            this.roomGroupbox.ResumeLayout(false);
            this.roomGroupbox.PerformLayout();
            this.InventoryGroupbox.ResumeLayout(false);
            this.InventoryGroupbox.PerformLayout();
            this.combatGroupbox.ResumeLayout(false);
            this.enemyGroupbox.ResumeLayout(false);
            this.enemyGroupbox.PerformLayout();
            this.playerGroupbox.ResumeLayout(false);
            this.playerGroupbox.PerformLayout();
            this.combatLogGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.GroupBox roomGroupbox;
        private System.Windows.Forms.Button useRoomItemButton;
        private System.Windows.Forms.Button pickUpRoomItemButton;
        private System.Windows.Forms.Button attackMobButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox roomItemListBox;
        private System.Windows.Forms.ListBox mobListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.GroupBox InventoryGroupbox;
        private System.Windows.Forms.Button usePlayerItemButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox playerItemListBox;
        private System.Windows.Forms.GroupBox combatGroupbox;
        private System.Windows.Forms.GroupBox enemyGroupbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox playerGroupbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label enemyLevelLabel;
        private System.Windows.Forms.Label enemyDefenseLabel;
        private System.Windows.Forms.Label enemyAttackLabel;
        private System.Windows.Forms.Label enemyHPLabel;
        private System.Windows.Forms.Label playerExpLabel;
        private System.Windows.Forms.Label playerLevelLabel;
        private System.Windows.Forms.Label playerDefenseLabel;
        private System.Windows.Forms.Label playerAttackLabel;
        private System.Windows.Forms.Label playerHPLabel;
        private System.Windows.Forms.RichTextBox displayTextBox;
        private System.Windows.Forms.GroupBox combatLogGroupbox;
    }
}

