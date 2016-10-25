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

        World world = new World();
        Player player = new Player();
        int i;

        public dungeonCrawlForm()
        {
            InitializeComponent();
            roomNameLabel.Text = world.worldList[i].rName;
            mobPopulation();
            itemPopulation();
        }

        private void attackMobButton_Click(object sender, EventArgs e)
        {
            Creature placeHolder = null;
            int damage = 0;
            if (mobListBox.SelectedIndex != -1)
            {
                foreach (Creature val in world.worldList[i].mobList)//for each creature in the list, check to see if the selected name matches the creature's.
                {
                    if (val.Name == mobListBox.SelectedItem.ToString())
                    {
                        placeHolder = val;
                    }
                    else
                    {
                        displayTextBox.AppendText("\nPlease select a monster to attack");
                    }
                }

                if (placeHolder != null)//If the placeholder has a creature, do this.
                {
                    damage = player.weaponAttack();
                    placeHolder.HP = placeHolder.HP - damage;
                    displayTextBox.AppendText("\nYou deal " + damage + " damage to the " + placeHolder.Name);
                    enemyHPLabel.Text = world.worldList[i].mobList[mobListBox.SelectedIndex].HP.ToString();
                    if (placeHolder.HP <= 0)
                    {

                        mobListBox.Items.Remove(mobListBox.SelectedItem);
                        placeHolder.giveXP(player);
                        player.levelUp();
                        world.worldList[i].checkDeaths();
                        displayTextBox.AppendText("\nYou have slain the " + placeHolder.Name);
                    }
                    else
                    {
                        damage = placeHolder.rollDamage();
                        player.HP = player.HP - damage;
                        displayTextBox.AppendText("\nThe " + placeHolder.Name + " deals " + damage + " damage to you.");
                    }
                }
                else
                {
                    displayTextBox.AppendText("Please select a monster to attack");
                }
                
                    if(player.checkIfDead() == true)
                    {
                        MessageBox.Show("You died. Game over.");
                        Application.Exit();
                    }
                   

                    
            }
            else
            {
                displayTextBox.AppendText("\nAttack what?");
            }
            displayTextBox.ScrollToCaret();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (i == 9)
            {
                MessageBox.Show("You are at the end of the " +
                    "dungeon. You can go no further.");
            }
            else
            {
                if (world.worldList[i].mobList.Count == 0)
                {
                    i++;
                    roomNameLabel.Text = world.worldList[i].rName;
                    mobPopulation();
                    itemPopulation();
                    player.Location++;
                }
                else
                {
                    displayTextBox.AppendText("\nThe monster blocks your path.");
                }
            }
            displayTextBox.ScrollToCaret();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("You are at the beginning of the " +
                    "dungeon. You can go no further.");
            }
            else
            {
                i--;
                roomNameLabel.Text = world.worldList[i].rName;
                mobPopulation();
                itemPopulation();
                player.Location--;
            }
        }
        private void mobPopulation()
        {
            mobListBox.Items.Clear();
            foreach (Creature val in world.worldList[i].mobList)
            {
                mobListBox.Items.Add(val.Name);
            }
        }
        private void itemPopulation()
        {
            roomItemListBox.Items.Clear();
            foreach (Item val in world.worldList[i].itemList)
            {
                roomItemListBox.Items.Add(val.Name);
            }
        }

        private void pickUpItemButton_Click(object sender, EventArgs e)
        {
            Item placeHolder = null;

            foreach (Item val in world.worldList[i].itemList)//for each item in the list, check to see if the selected name matches the item's.
            {
                if (val.Name == roomItemListBox.SelectedItem.ToString())
                {
                    placeHolder = val;
                }
                else
                {
                    displayTextBox.AppendText("\nPlease select an item to pick up.");
                    displayTextBox.ScrollToCaret();
                }
            }
            if (placeHolder != null)//If the placeholder has an item, do this.
            {
                world.worldList[i].itemList.Remove(placeHolder);
                roomItemListBox.Items.Remove(roomItemListBox.SelectedItem);
                displayTextBox.AppendText("\nYou pick up the " + placeHolder.Name);
                player.Inventory.Add(placeHolder);
                playerItemListBox.Items.Add(placeHolder.Name);
            }
            else
            {
                displayTextBox.AppendText("\nPlease select a real item to pick up.");

            }
        }

        private void useRoomItemButton_Click(object sender, EventArgs e)
        {

            Item placeHolder = null;
            string name = roomItemListBox.SelectedItem.ToString();

            if (roomItemListBox.SelectedIndex != -1)
            {
                foreach (Item val in world.worldList[i].itemList)
                {
                    if (val.Name == name)
                    {
                        placeHolder = val;
                        placeHolder.durability--;
                        roomItemListBox.Items.Remove(roomItemListBox.SelectedItem);
                    }
                }
                displayTextBox.AppendText(placeHolder.UseEffect(player));
                world.worldList[i].itemList.Remove(placeHolder);
            }
            else
            {
                displayTextBox.AppendText("\nWhat item are you using?");
            }
        }

        private void usePlayerItemButton_Click(object sender, EventArgs e)
        {
            Item placeHolder = null;
            string name = playerItemListBox.SelectedItem.ToString();
            if (playerItemListBox.SelectedIndex != -1)
            {
                foreach (Item val in player.Inventory)
                {
                    if (val.Name == name)
                    {
                        placeHolder = val;
                        placeHolder.durability--;
                        playerItemListBox.Items.Remove(playerItemListBox.SelectedItem);
                    }
                }
                displayTextBox.AppendText(placeHolder.UseEffect(player));
                player.Inventory.Remove(placeHolder);
            }
            else
            {
                displayTextBox.AppendText("\nWhat item are you using in your inventory?");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playerHPLabel.Text = player.HP.ToString();
            playerAttackLabel.Text = player.ATK.ToString();
            playerDefenseLabel.Text = player.AC.ToString();
            playerLevelLabel.Text = player.Lvl.ToString();
            playerExpLabel.Text = player.EXP.ToString();
            playerWeaponLabel.Text = player.Weapon.Name;
            playerArmorLabel.Text = player.Armor.Name;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Command c = new Command();
            string input = commandTextBox.Text;
            displayTextBox.AppendText(c.Command(input));
        }
    }
}