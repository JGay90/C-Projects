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
            mobPopulation();
            itemPopulation();
        }

        private void Mobload()
        {
            Queue<string> stats = new Queue<string>();
            StreamReader input = File.OpenText("Bestiary.txt");

            //Super simple method of putting a bunch of stats in. This would suck for more complex things.
            while (!input.EndOfStream)
            {
                stats.Enqueue(input.ReadLine());
            }

            //Super simple method of giving a creature stats. This would suck for more complex things.
            Creature goblin = new Creature();
            goblin.Name = stats.Dequeue();
            goblin.Desc = stats.Dequeue();
            goblin.HP = int.Parse(stats.Dequeue());
            goblin.AC = int.Parse(stats.Dequeue());
            goblin.ATK = int.Parse(stats.Dequeue());
            goblin.DMG = int.Parse(stats.Dequeue());
            //goblin.i = Image.FromFile("goblin.png");

            Creature wolf = new Creature();
            wolf.Name = stats.Dequeue();
            wolf.Desc = stats.Dequeue();
            wolf.HP = int.Parse(stats.Dequeue());
            wolf.AC = int.Parse(stats.Dequeue());
            wolf.ATK = int.Parse(stats.Dequeue());
            wolf.DMG = int.Parse(stats.Dequeue());
            //wolf.i = Image.FromFile("wolf.png");


        }
        private void attackMobButton_Click(object sender, EventArgs e)
        {
            Creature placeHolder = null;
            int damage = 0;
            bool isdead = false;
         
           foreach (Creature val in world.worldList[i].mobList)
           {
               if (val.Name == mobListBox.SelectedItem.ToString())
               {
                   placeHolder = val;
               }
               else
               {
                   displayTextBox.AppendText("Please select a monster to attack");
                   displayTextBox.ScrollToCaret();
               }

            }
           if(placeHolder != null)
            {
                damage = player.weaponAttack();
                placeHolder.HP = placeHolder.HP - damage;
                world.worldList[i].checkDeaths();
                displayTextBox.AppendText("You deal " + damage + "damage to the " + placeHolder.Name);
            }
            else
            {
                MessageBox.Show("Please select a real monster to attack");
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
    }
}