using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeilandR_HW7_3
{
    public partial class dungeonCrawlForm : Form
    {
        Command com = new Command();

        public dungeonCrawlForm()
        {
            InitializeComponent();
            roomNameLabel.Text = com.world.worldList[0].rName;
            mobPopulation();
            itemPopulation();
            Instructions();
        }

        //private void attackMobButton_Click(object sender, EventArgs e)
        //{
        //    Creature placeHolder = null;
        //    int damage = 0;
        //    if (mobListBox.SelectedIndex != -1)
        //    {
        //        foreach (Creature val in com.world.worldList[i].mobList)//for each creature in the list, check to see if the selected name matches the creature's.
        //        {
        //            if (val.Name == mobListBox.SelectedItem.ToString())
        //            {
        //                placeHolder = val;
        //            }
        //            else
        //            {
        //                displayTextBox.AppendText("\nPlease select a monster to attack");
        //            }
        //        }

        //        if (placeHolder != null)//If the placeholder has a creature, do this.
        //        {
        //            damage = com.player.weaponAttack();
        //            placeHolder.HP = placeHolder.HP - damage;
        //            displayTextBox.AppendText("\nYou deal " + damage + " damage to the " + placeHolder.Name);
        //            enemyHPLabel.Text = com.world.worldList[i].mobList[mobListBox.SelectedIndex].HP.ToString();
        //            if (placeHolder.HP <= 0)
        //            {

        //                mobListBox.Items.Remove(mobListBox.SelectedItem);
        //                placeHolder.giveXP(com.player);
        //                com.player.levelUp();
        //                com.world.worldList[i].checkDeaths();
        //                displayTextBox.AppendText("\nYou have slain the " + placeHolder.Name);
        //            }
        //            else
        //            {
        //                damage = placeHolder.rollDamage();
        //                com.player.HP = com.player.HP - damage;
        //                displayTextBox.AppendText("\nThe " + placeHolder.Name + " deals " + damage + " damage to you.");
        //            }
        //        }
        //        else
        //        {
        //            displayTextBox.AppendText("Please select a monster to attack");
        //        }
                
        //            if(com.player.checkIfDead() == true)
        //            {
        //                MessageBox.Show("You died. Game over.");
        //                Application.Exit();
        //            }
                   

                    
        //    }
        //    else
        //    {
        //        displayTextBox.AppendText("\nAttack what?");
        //    }
        //    displayTextBox.ScrollToCaret();
        //}

        private void Instructions()
        {
            displayTextBox.AppendText("Instructions:");
            displayTextBox.AppendText("\n'Go Ahead' or 'Go Back' to move ahead or back.");
            com.Look();

        }
        
        private void mobPopulation()
        {
            mobListBox.Items.Clear();
            foreach (Creature val in com.world.worldList[com.player.Location].mobList)
            {
                mobListBox.Items.Add(val.Name);
            }
        }
        private void itemPopulation()
        {
            roomItemListBox.Items.Clear();
            playerItemListBox.Items.Clear();
            foreach (Item val in com.world.worldList[com.player.Location].itemList)
            {
                roomItemListBox.Items.Add(val.Name);
            }
            foreach(Item val in com.player.Inventory)
            {
                playerItemListBox.Items.Add(val.Name);
            }
        }

        //private void useRoomItemButton_Click(object sender, EventArgs e)
        //{

        //    Item placeHolder = null;
        //    string name = roomItemListBox.SelectedItem.ToString();

        //    if (roomItemListBox.SelectedIndex != -1)
        //    {
        //        foreach (Item val in com.world.worldList[i].itemList)
        //        {
        //            if (val.Name == name)
        //            {
        //                placeHolder = val;
        //                placeHolder.durability--;
        //                roomItemListBox.Items.Remove(roomItemListBox.SelectedItem);
        //            }
        //        }
        //        displayTextBox.AppendText(placeHolder.UseEffect(com.player));
        //        com.world.worldList[i].itemList.Remove(placeHolder);
        //    }
        //    else
        //    {
        //        displayTextBox.AppendText("\nWhat item are you using?");
        //    }
        //}

        private void usePlayerItemButton_Click(object sender, EventArgs e)
        {
            Item placeHolder = null;
            string name = playerItemListBox.SelectedItem.ToString();
            if (playerItemListBox.SelectedIndex != -1)
            {
                foreach (Item val in com.player.Inventory)
                {
                    if (val.Name == name)
                    {
                        placeHolder = val;
                        placeHolder.durability--;
                        playerItemListBox.Items.Remove(playerItemListBox.SelectedItem);
                    }
                }
                displayTextBox.AppendText(placeHolder.UseEffect(com.player));
                com.player.Inventory.Remove(placeHolder);
            }
            else
            {
                displayTextBox.AppendText("\nWhat item are you using in your inventory?");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playerHPLabel.Text = com.player.HP.ToString();
            playerAttackLabel.Text = com.player.ATK.ToString();
            playerDefenseLabel.Text = com.player.AC.ToString();
            playerLevelLabel.Text = com.player.Lvl.ToString();
            playerExpLabel.Text = com.player.EXP.ToString();
            playerWeaponLabel.Text = com.player.Weapon.Name;
            playerArmorLabel.Text = com.player.Armor.Name;
            roomNameLabel.Text = com.world.worldList[com.player.Location].rName;
            mobPopulation();
            itemPopulation();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string input = commandTextBox.Text;
            displayTextBox.AppendText(com.Handler(input));
            displayTextBox.ScrollToCaret();
        }
        
        private void attackCombatButton_Click(object sender, EventArgs e)
        {
 
        }
    }
}
