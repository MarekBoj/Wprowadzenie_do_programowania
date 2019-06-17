using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Projekt gry Pong 
// Marek Bojarski
// Numer studenta: 11529

namespace Pong_Game
{

    public partial class PongWindow : Form
    {
        int z;
        int x = 8;
        int y = 8;
        int points_left;
        int points_right = 0;
        char direction_Right;
        char direction_Left;
        bool esc;

        public PongWindow()
        {
            InitializeComponent();
        }
        private void Pause()
        {

            if (esc == false)
            {
                Timer.Enabled = false;
                esc = true;
                label1_pause.Visible = true;

            }
            else
            {
                Timer.Enabled = true;
                esc = false;
                label1_pause.Visible = false;

            }
        }

        static int Losuj_polozenie_pilki()
        {
            var generator_polozenia = new Random();
            return generator_polozenia.Next(30, PongWindow.ActiveForm.Height - 30);
        }
        static int Losuj_Odbicie()
        {
            var generator_odbicia = new Random();
            return generator_odbicia.Next(6, 8);
        }

        private void Add_point()
        {
            if (x < 0)
            {
                points_right++;
                Right_player_point.Text = Convert.ToString(points_right);
                Play_sound("dzwieki/lost.wav");
            }
            else
            {
                points_left++;
                Left_player_point.Text = Convert.ToString(points_left);
                Play_sound("dzwieki/lost.wav");
            }
        }
        private void Play_sound(String path)
        {     
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = path;
                player.Load();
                player.Play();
            }
            catch
            {

            }
         }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Ball.Left += x;
            Ball.Top += y;

            // odbicie od platformy lewej
            if ((Ball.Left <= Platform_left.Left + Platform_left.Width + 5) &&
                (Ball.Left >= Platform_left.Left + Platform_left.Width) &&
                (Ball.Top + Ball.Height >= Platform_left.Top) &&
                (Ball.Top <= Platform_left.Top + Platform_left.Height))
            {
                if (x > 0)
                {
                    x = -Losuj_Odbicie();
                }
                else x = Losuj_Odbicie();
                Play_sound("dzwieki/hit.wav");

            }
            // odbicie od platformy prawej
            if ((Ball.Left + Ball.Width >= Platform_right.Left - 5) &&
                (Ball.Left + Ball.Width < Platform_right.Left) &&
                (Ball.Top + Ball.Height >= Platform_right.Top) &&
                (Ball.Top <= Platform_right.Top + Platform_right.Height))
            {
                if (x > 0)
                {
                    x = -Losuj_Odbicie();
                }
                else x = Losuj_Odbicie();

                Play_sound("dzwieki/hit.wav");

            }
            // Piłka trafiła
            if (Ball.Left < 0 || Ball.Left + Ball.Width > PongWindow.ActiveForm.Width)
            {
                Ball.Left = 378;
                Ball.Top = Losuj_polozenie_pilki();
                x = -x;
                Add_point();
            }
            // odbicie z góry
            if (Ball.Top < 0) {
                Ball.Top = 20;
                if (y > 0)
                {
                    y = -Losuj_Odbicie();
                }
                else y = Losuj_Odbicie();
                Play_sound("dzwieki/hit.wav");
            }
            // odbicie z dołu
            if (Ball.Bottom > PongWindow.ActiveForm.Height - 50) {
                Ball.Top = PongWindow.ActiveForm.Height - 70;
                if (y > 0)
                {
                    y = -Losuj_Odbicie();
                }
                else y = Losuj_Odbicie();
                Play_sound("dzwieki/hit.wav");
            }

            if (direction_Left == 'W')
            {
                if (Platform_left.Top >= 15)
                {
                    Platform_left.Top -= 14;
                }
            }
            if (direction_Left == 'S')
            {
                if (Platform_left.Top + Platform_left.Height <= PongWindow.ActiveForm.Height - 50)
                {
                    Platform_left.Top += 14;
                }
            }

            if (direction_Right == 'U')
            {
                if (Platform_right.Top >= 15)
                {
                    Platform_right.Top -= 14;
                }
            }
            if (direction_Right == 'D')
            {
                if (Platform_right.Top + Platform_right.Height <= PongWindow.ActiveForm.Height - 50)
                {
                    Platform_right.Top += 14;
                }
            }
        }   
        private void PongWindow_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W) direction_Left = 'W';
            if (e.KeyCode == Keys.Up) direction_Right = 'U';
            if (e.KeyCode == Keys.S) direction_Left = 'S';
            if (e.KeyCode == Keys.Down) direction_Right = 'D';
            if (e.KeyCode == Keys.Escape) Pause();
        }
        private void PongWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) direction_Left = '.';
            if (e.KeyCode == Keys.Up) direction_Right = '.';
            if (e.KeyCode == Keys.S) direction_Left = '.';
            if (e.KeyCode == Keys.Down) direction_Right = '.';
        }
    }
}
