using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;
        private Random random = new Random();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        private void Form1_Load_1(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(100, 80, 620, 200));
            game.NewLevel(random);
            UpdateCharacters();
            pictureBoxes.Add(bowItem);
            pictureBoxes.Add(swordItem);
            pictureBoxes.Add(maceItem);
            pictureBoxes.Add(bluePotionItem);
            pictureBoxes.Add(redPotionItem);
        }

        public void UpdateCharacters()
        {
            playerImage.Location = new Point(game.PlayerLocation.X - 25, game.PlayerLocation.Y - 25);
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            playerImage.Visible = true;

            batHitPoints.Text = null;
            ghostHitPoints.Text = null;
            ghoulHitPoints.Text = null;
            bat.Visible = false;
            ghost.Visible = false;
            ghoul.Visible = false;

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    if (enemy.HitPoints > 0)
                    {
                        bat.Location = new Point(enemy.Location.X - 25, enemy.Location.Y - 25);
                        batHitPoints.Text = enemy.HitPoints.ToString();
                        showBat = true;
                        enemiesShown++;
                    }
                }

                

                if (enemy is Ghost)
                {
                    if (enemy.HitPoints > 0)
                    {
                        ghost.Location = new Point(enemy.Location.X - 25, enemy.Location.Y - 25);
                        ghostHitPoints.Text = enemy.HitPoints.ToString();
                        showGhost = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghoul)
                {
                    if (enemy.HitPoints > 0)
                    {
                        ghoul.Location = new Point(enemy.Location.X-25, enemy.Location.Y-25);
                        ghoulHitPoints.Text = enemy.HitPoints.ToString();
                        showGhoul = true;
                        enemiesShown++;
                    }
                }

                if (showBat)
                {
                    bat.Visible = true;
                }

                if (showGhost)
                {
                    ghost.Visible = true;
                }

                if (showGhoul)
                {
                    ghoul.Visible = true;
                }


            }

            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; break;
                case "Bow":
                    weaponControl = bow; break;
                case "Red Potion":
                    weaponControl = redPotion; break;
                case "Blue Potion":
                    weaponControl = bluePotion; break;
                case "Mace":
                    weaponControl = mace; break;
            }
            
            weaponControl.Location = new Point(weaponControl.Location.X - 25, weaponControl.Location.Y - 25);

            weaponControl.Visible = true;

            swordItem.Visible = false;
            bowItem.Visible = false;
            maceItem.Visible = false;
            bluePotionItem.Visible = false;
            redPotionItem.Visible = false;

            if (game.CheckPlayerInventory("Sword"))
                swordItem.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                bowItem.Visible = true;
            if (game.CheckPlayerInventory("Mace"))
                maceItem.Visible = true;
            if (game.CheckPlayerInventory("Blue Potion"))
                bluePotionItem.Visible = true;
            if (game.CheckPlayerInventory("Red Potion"))
                redPotionItem.Visible = true;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if(game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if(enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }
        private void bowItem_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                clearBorders();
                bowItem.BorderStyle = BorderStyle.FixedSingle;
                bringAttackButtonsBack();
            }
        }       

        private void redPotionItem_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                clearBorders();
                redPotionItem.BorderStyle = BorderStyle.FixedSingle;
                clearAttacksForPotions();
            }

        }

        private void clearAttacksForPotions()
        {
            attackRight.Visible = false;
            attackDown.Visible = false;
            attackLeft.Visible = false;
            attackUp.Text = "Drink";
        }

        private void bringAttackButtonsBack()
        {
            attackRight.Visible = true;
            attackDown.Visible = true;
            attackLeft.Visible = true;
            attackUp.Text = "↑";
        }

        private void swordItem_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                clearBorders();
                swordItem.BorderStyle = BorderStyle.FixedSingle;
                bringAttackButtonsBack();
            }
        }

        private void bluePotionItem_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                clearBorders();
                bluePotionItem.BorderStyle = BorderStyle.FixedSingle;
                clearAttacksForPotions();
            }
        }

        private void maceItem_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                clearBorders();
                maceItem.BorderStyle = BorderStyle.FixedSingle;
                bringAttackButtonsBack();
            }
        }

        private void clearBorders()
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.BorderStyle = BorderStyle.None;
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void down_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void left_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }
        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();

        }
        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);;
            UpdateCharacters();
        }
        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void right_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Right)
            {
                game.Move(Direction.Right, random);
                UpdateCharacters();
            }
        }

        private void right_Click_1(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }
    }
}
