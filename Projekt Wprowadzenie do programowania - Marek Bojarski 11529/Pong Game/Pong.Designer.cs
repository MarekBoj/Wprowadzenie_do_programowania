namespace Pong_Game
{
    partial class PongWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongWindow));
            this.Left_player_point = new System.Windows.Forms.TextBox();
            this.Right_player_point = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Platform_left = new System.Windows.Forms.PictureBox();
            this.Platform_right = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.label1_pause = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Platform_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_player_point
            // 
            this.Left_player_point.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("Left_player_point.AutoCompleteCustomSource")});
            this.Left_player_point.BackColor = System.Drawing.Color.Snow;
            this.Left_player_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Left_player_point.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Left_player_point, "Left_player_point");
            this.Left_player_point.ForeColor = System.Drawing.Color.Black;
            this.Left_player_point.Name = "Left_player_point";
            this.Left_player_point.ReadOnly = true;
            // 
            // Right_player_point
            // 
            this.Right_player_point.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("Right_player_point.AutoCompleteCustomSource")});
            this.Right_player_point.BackColor = System.Drawing.Color.Snow;
            this.Right_player_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Right_player_point.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Right_player_point, "Right_player_point");
            this.Right_player_point.ForeColor = System.Drawing.Color.Black;
            this.Right_player_point.Name = "Right_player_point";
            this.Right_player_point.ReadOnly = true;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 2;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Platform_left
            // 
            this.Platform_left.BackColor = System.Drawing.Color.White;
            this.Platform_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Platform_left, "Platform_left");
            this.Platform_left.Name = "Platform_left";
            this.Platform_left.TabStop = false;
            // 
            // Platform_right
            // 
            this.Platform_right.BackColor = System.Drawing.Color.White;
            this.Platform_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Platform_right, "Platform_right");
            this.Platform_right.Name = "Platform_right";
            this.Platform_right.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = global::Pong_Game.Properties.Resources.pilka;
            resources.ApplyResources(this.Ball, "Ball");
            this.Ball.Name = "Ball";
            this.Ball.TabStop = false;
            // 
            // label1_pause
            // 
            resources.ApplyResources(this.label1_pause, "label1_pause");
            this.label1_pause.BackColor = System.Drawing.Color.Transparent;
            this.label1_pause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_pause.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1_pause.Name = "label1_pause";
            // 
            // PongWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.label1_pause);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Platform_right);
            this.Controls.Add(this.Platform_left);
            this.Controls.Add(this.Right_player_point);
            this.Controls.Add(this.Left_player_point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PongWindow";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PongWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PongWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Platform_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Left_player_point;
        private System.Windows.Forms.TextBox Right_player_point;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Platform_left;
        private System.Windows.Forms.PictureBox Platform_right;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label label1_pause;
    }
}

