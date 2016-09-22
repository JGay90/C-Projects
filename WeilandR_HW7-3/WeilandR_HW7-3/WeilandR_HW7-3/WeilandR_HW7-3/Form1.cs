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
            playerHPLabel.Text = player.HP.ToString();
            playerAttackLabel.Text = player.ATK.ToString();
            playerDefenseLabel.Text = player.AC.ToString();
            playerLevelLabel.Text = player.Lvl.ToString();
            playerExpLabel.Text = player.EXP.ToString();
            roomNameLabel.Text = world.worldList[0].rName;
            enemyAttackLabel.Text = world.worldList[0].mobList[0].ATK.ToString();
            enemyDefenseLabel.Text = world.worldList[0].mobList[0].AC.ToString();
            enemyHPLabel.Text = world.worldList[0].mobList[0].HP.ToString();
            enemyLevelLabel.Text = world.worldList[0].mobList[0].Lvl.ToString();
            playerWeaponLabel.Text = player.Weapon.Name;
            playerArmorLabel.Text = player.Armor.Name;
            mobPopulation();
            itemPopulation();
        }

        private void attackMobButton_Click(object sender, EventArgs e)
        {
            Creature placeHolder = null;
            int damage = 0;

            foreach (Creature val in world.worldList[i].mobList)//for each creature in the list, check to see if the selected name matches the creature's.
            {
                if (val.Name == mobListBox.SelectedItem.ToString())
                {
                    placeHolder = val;
                }
                else
                {
                    displayTextBox.AppendText("\nPlease select a monster to attack");
                    displayTextBox.ScrollToCaret();
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
                    world.worldList[i].checkDeaths();
                    //enemyLevelLabel.Text = world.worldList[i].mobList[mobListBox.SelectedIndex].Lvl.ToString();
                    //enemyAttackLabel.Text = world.worldList[i].mobList[mobListBox.SelectedIndex].ATK.ToString();
                    //enemyDefenseLabel.Text = world.worldList[i].mobList[mobListBox.SelectedIndex].AC.ToString();
                    displayTextBox.AppendText("\nYou have slain the " + placeHolder.Name);
                }
            }
            else
            {
                displayTextBox.AppendText("\nPlease select a real monster to attack");

            }
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
                i++;
                roomNameLabel.Text = world.worldList[i].rName;
                mobPopulation();
                player.Location++;
            }

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

            foreach (Item val in world.worldList[i].itemList)
            {
                if (val.Name == roomItemListBox.SelectedItem.ToString())
                {
                    placeHolder = val;
                }
                else
                {
                    displayTextBox.AppendText("\nThis item is not complete yet.");
                }
            }
            displayTextBox.AppendText(placeHolder.UseEffect(player));
            
        }

        private void usePlayerItemButton_Click(object sender, EventArgs e)
        {
            //this button need to be worked on.
            displayTextBox.AppendText("\nThis item is not complete yet.");
        }
    }
}