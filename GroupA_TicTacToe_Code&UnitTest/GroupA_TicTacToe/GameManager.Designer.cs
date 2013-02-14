namespace ComputerGamesRUS.Game
{
    partial class GameManager
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
            this.components = new System.ComponentModel.Container();
            this.GameHeading = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Instructions = new System.Windows.Forms.Button();
            this.WelcomeGame = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GameRestart = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.InstructionsH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GoodBye = new System.Windows.Forms.Label();
            this.Instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameHeading
            // 
            this.GameHeading.AutoSize = true;
            this.GameHeading.BackColor = System.Drawing.Color.White;
            this.GameHeading.Font = new System.Drawing.Font("Footlight MT Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameHeading.Location = new System.Drawing.Point(130, 9);
            this.GameHeading.Name = "GameHeading";
            this.GameHeading.Size = new System.Drawing.Size(286, 34);
            this.GameHeading.TabIndex = 0;
            this.GameHeading.Text = "Tic-Tac-Toe-Forever";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Start.Location = new System.Drawing.Point(88, 259);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(87, 31);
            this.Start.TabIndex = 1;
            this.Start.Text = "START";
            this.toolTip1.SetToolTip(this.Start, "Press to start the game.");
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Instructions
            // 
            this.Instructions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Instructions.Location = new System.Drawing.Point(360, 259);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(98, 31);
            this.Instructions.TabIndex = 2;
            this.Instructions.Text = "INSTRUCTIONS";
            this.toolTip2.SetToolTip(this.Instructions, "Press the button to get instructions..");
            this.Instructions.UseVisualStyleBackColor = false;
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // WelcomeGame
            // 
            this.WelcomeGame.AutoSize = true;
            this.WelcomeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeGame.ForeColor = System.Drawing.Color.Transparent;
            this.WelcomeGame.Location = new System.Drawing.Point(82, 127);
            this.WelcomeGame.Name = "WelcomeGame";
            this.WelcomeGame.Size = new System.Drawing.Size(391, 31);
            this.WelcomeGame.TabIndex = 3;
            this.WelcomeGame.Text = "WELCOME TO THE GAME !!";
            // 
            // GameRestart
            // 
            this.GameRestart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GameRestart.Location = new System.Drawing.Point(136, 296);
            this.GameRestart.Name = "GameRestart";
            this.GameRestart.Size = new System.Drawing.Size(87, 31);
            this.GameRestart.TabIndex = 8;
            this.GameRestart.Text = "RESTART";
            this.toolTip1.SetToolTip(this.GameRestart, "Press to start the game.");
            this.toolTip2.SetToolTip(this.GameRestart, "Press the button to Restart the game..");
            this.GameRestart.UseVisualStyleBackColor = false;
            this.GameRestart.Click += new System.EventHandler(this.GameRestart_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Exit.Location = new System.Drawing.Point(371, 296);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(87, 31);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "EXIT";
            this.toolTip1.SetToolTip(this.Exit, "Press to start the game.");
            this.toolTip2.SetToolTip(this.Exit, "Press the button to Exit the game..");
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // InstructionsH
            // 
            this.InstructionsH.AutoSize = true;
            this.InstructionsH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsH.Location = new System.Drawing.Point(46, 89);
            this.InstructionsH.Name = "InstructionsH";
            this.InstructionsH.Size = new System.Drawing.Size(109, 20);
            this.InstructionsH.TabIndex = 4;
            this.InstructionsH.Text = "Instructions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 5;
            // 
            // GoodBye
            // 
            this.GoodBye.AutoSize = true;
            this.GoodBye.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodBye.ForeColor = System.Drawing.Color.Transparent;
            this.GoodBye.Location = new System.Drawing.Point(80, 148);
            this.GoodBye.Name = "GoodBye";
            this.GoodBye.Size = new System.Drawing.Size(442, 31);
            this.GoodBye.TabIndex = 10;
            this.GoodBye.Text = "Thanks for playing !! Good Bye !!";
            // 
            // Instruction
            // 
            this.Instruction.AutoSize = true;
            this.Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruction.Location = new System.Drawing.Point(47, 112);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(0, 18);
            this.Instruction.TabIndex = 11;
            // 
            // GameManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(534, 328);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.GoodBye);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.GameRestart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InstructionsH);
            this.Controls.Add(this.WelcomeGame);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.GameHeading);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameManager";
            this.Text = "Tic-Tac-Toe-forever";
            this.Load += new System.EventHandler(this.GameManager_Load);
            this.Resize += new System.EventHandler(this.GameManager_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameHeading;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Instructions;
        private System.Windows.Forms.Label WelcomeGame;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label InstructionsH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GameRestart;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label GoodBye;
        private System.Windows.Forms.Label Instruction;


    }
}

