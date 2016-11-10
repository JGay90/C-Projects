using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M4H1_WeilandR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            
        }

        private void displayStatsButton_Click(object sender, EventArgs e)
        {
            //New Player
            Player player = new Player(15, 5, 3, 5, false);
            playerHPLabel.Text = player.HP.ToString();
            playerACLabel.Text = player.AC.ToString();
            playerABLabel.Text = player.AB.ToString();
            playerDMGLabel.Text = player.DMG.ToString();
            //New Monster
            Monster Monster = new Monster(7, 4, 2, 5, true);
            monsterHPLabel.Text = Monster.HP.ToString();
            monsterACLabel.Text = Monster.AC.ToString();
            monsterABLabel.Text = Monster.AB.ToString();
            monsterDMGLabel.Text = Monster.DMG.ToString();
            //New NPC
            NonPlayerCharacter NPC = new NonPlayerCharacter(10, 2, 0, 2, false, NonPlayerCharacter.FactionType.Skylanders);
            npcHPLabel.Text = NPC.HP.ToString();
            npcACLabel.Text = NPC.AC.ToString();
            npcABLabel.Text = NPC.AB.ToString();
            npcDMGLabel.Text = NPC.DMG.ToString();
            npcFactionLabel.Text = NPC.Faction.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
