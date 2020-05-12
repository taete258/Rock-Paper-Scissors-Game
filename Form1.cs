using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public partial class Form1 : Form
    {
        string[] game_object = { "rock", "scrissor", "paper" };
        char player_choice;
        char com_choice;
        public Form1()
        {
            InitializeComponent();
       

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void rock_Click(object sender, EventArgs e)
        {
            playerbox.Image = rock.Image;
            player_choice = 'R';
            this.com_Random();
        }

        private void scrissor_Click(object sender, EventArgs e)
        {
            playerbox.Image = scrissor.Image;
            player_choice = 'S';
            this.com_Random();
        }

        private void paper_Click(object sender, EventArgs e)
        {
            playerbox.Image = paper.Image;
            player_choice = 'P';
            this.com_Random();
        }

        private void com_Random()
        {
            Random random = new Random();
            int text = random.Next(0, game_object.Length);

            if (game_object[text] == "rock")
            {
                combox.Image = rock.Image;
                com_choice = 'R';
                this.game_result();
            }
            else if (game_object[text] == "scrissor")
            {
                combox.Image = scrissor.Image;
                com_choice = 'S';
                this.game_result();
            }
            else if(game_object[text] == "paper")
            {
                combox.Image = paper.Image;
                com_choice = 'P';
                this.game_result();
            }
            
        }

        private void game_result()
        {
            if (player_choice != com_choice)
            {
                if (player_choice == 'R')
                {
                    if (com_choice == 'P')
                    {
                        result.Text = "You Lose !!";
                        this.lose_sound();
                        Console.WriteLine("I chose Paper and you chose Rock: Paper covers rock, so I win");
                    }
                    else if (com_choice == 'S')
                    {
                        result.Text = "You Win !!";
                        Console.WriteLine("I chose Scissors and you choise Rock: Rock breaks Scissors, so you win");
                        this.win_sound();
                    }
                }
                else if (player_choice == 'S')
                {
                    if (com_choice == 'P')
                    {
                        result.Text = "You Win !!";
                        Console.WriteLine("I chose Paper and you chose Scrissor: Scrissor cut Paper, so you win");
                        this.win_sound();
                    }
                    else if (com_choice == 'R')
                    {
                        result.Text = "You Lose !!";
                        this.lose_sound();
                        Console.WriteLine("I chose Rock and you choise Scrissor: Rock breaks Scissors, so I win");
                    }
                }
                else if (player_choice == 'P')
                {
                    if (com_choice == 'R')
                    {
                        result.Text = "You Win !!";
                        this.win_sound();
                        Console.WriteLine("I chose Rock and you chose Paper: Paper covers rock, so you win");

                    }
                    else if(com_choice == 'S')
                    {
                        result.Text = "You Lose !!";
                        this.lose_sound();
                        Console.WriteLine("I chose Paper and you choise Scissors: Scissors cut Paper, so I win");
                    }


                }
            }
            else {
                result.Text = "Equal";
                this.equal_sound();


            }
        }

        private void win_sound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Exclamation.wav");
            simpleSound.Play();
        }
        private void lose_sound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Critical Stop.wav");
            simpleSound.Play();
        }
        private void equal_sound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Foreground.wav");
            simpleSound.Play();
        }
    }
}
