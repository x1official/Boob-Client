namespace Cock_Client
{
    partial class Cock_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cock_Client));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.Suicide = new System.Windows.Forms.Button();
            this.SpeedValue = new System.Windows.Forms.TextBox();
            this.Fly = new System.Windows.Forms.CheckBox();
            this.AirJump = new System.Windows.Forms.CheckBox();
            this.Zoom = new System.Windows.Forms.CheckBox();
            this.Fullbright = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.autoctrl = new System.Windows.Forms.CheckBox();
            this.autoshift = new System.Windows.Forms.CheckBox();
            this.autospace = new System.Windows.Forms.CheckBox();
            this.TriggerBot = new System.Windows.Forms.CheckBox();
            this.UserFOV = new System.Windows.Forms.Label();
            this.NoFall = new System.Windows.Forms.CheckBox();
            this.keybinds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boob";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minecraft:";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.ProcOpenLabel.Location = new System.Drawing.Point(442, 9);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(81, 23);
            this.ProcOpenLabel.TabIndex = 2;
            this.ProcOpenLabel.Text = "Not Open";
            this.ProcOpenLabel.TextChanged += new System.EventHandler(this.ProcOpenLabel_TextChanged);
            // 
            // Suicide
            // 
            this.Suicide.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Suicide.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suicide.ForeColor = System.Drawing.Color.DarkViolet;
            this.Suicide.Location = new System.Drawing.Point(529, 9);
            this.Suicide.Name = "Suicide";
            this.Suicide.Size = new System.Drawing.Size(22, 429);
            this.Suicide.TabIndex = 4;
            this.Suicide.Text = "Suicide";
            this.Suicide.UseVisualStyleBackColor = false;
            this.Suicide.Click += new System.EventHandler(this.Suicide_Click);
            // 
            // SpeedValue
            // 
            this.SpeedValue.BackColor = System.Drawing.SystemColors.MenuText;
            this.SpeedValue.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedValue.ForeColor = System.Drawing.Color.DarkRed;
            this.SpeedValue.Location = new System.Drawing.Point(371, 418);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(72, 23);
            this.SpeedValue.TabIndex = 7;
            this.SpeedValue.Text = "0.1000000015";
            this.SpeedValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Fly
            // 
            this.Fly.AutoSize = true;
            this.Fly.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fly.ForeColor = System.Drawing.Color.DarkCyan;
            this.Fly.Location = new System.Drawing.Point(12, 62);
            this.Fly.Name = "Fly";
            this.Fly.Size = new System.Drawing.Size(53, 27);
            this.Fly.TabIndex = 9;
            this.Fly.Text = "Fly";
            this.Fly.UseVisualStyleBackColor = true;
            this.Fly.CheckedChanged += new System.EventHandler(this.Fly_CheckedChanged);
            this.Fly.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fly_KeyDown);
            // 
            // AirJump
            // 
            this.AirJump.AutoSize = true;
            this.AirJump.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirJump.ForeColor = System.Drawing.Color.DarkCyan;
            this.AirJump.Location = new System.Drawing.Point(12, 95);
            this.AirJump.Name = "AirJump";
            this.AirJump.Size = new System.Drawing.Size(93, 27);
            this.AirJump.TabIndex = 10;
            this.AirJump.Text = "AirJump";
            this.AirJump.UseVisualStyleBackColor = true;
            this.AirJump.CheckedChanged += new System.EventHandler(this.AirJump_CheckedChanged);
            // 
            // Zoom
            // 
            this.Zoom.AutoSize = true;
            this.Zoom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zoom.ForeColor = System.Drawing.Color.DarkCyan;
            this.Zoom.Location = new System.Drawing.Point(12, 128);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(68, 27);
            this.Zoom.TabIndex = 11;
            this.Zoom.Text = "Zoom";
            this.Zoom.UseVisualStyleBackColor = true;
            this.Zoom.CheckedChanged += new System.EventHandler(this.Zoom_CheckedChanged);
            // 
            // Fullbright
            // 
            this.Fullbright.AutoSize = true;
            this.Fullbright.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullbright.ForeColor = System.Drawing.Color.DarkCyan;
            this.Fullbright.Location = new System.Drawing.Point(12, 161);
            this.Fullbright.Name = "Fullbright";
            this.Fullbright.Size = new System.Drawing.Size(103, 27);
            this.Fullbright.TabIndex = 12;
            this.Fullbright.Text = "Fullbright";
            this.Fullbright.UseVisualStyleBackColor = true;
            this.Fullbright.CheckedChanged += new System.EventHandler(this.Fullbright_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(12, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Your FOV:";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed.ForeColor = System.Drawing.Color.DarkViolet;
            this.Speed.Location = new System.Drawing.Point(449, 416);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(74, 27);
            this.Speed.TabIndex = 15;
            this.Speed.Text = "Speed";
            this.Speed.UseVisualStyleBackColor = true;
            this.Speed.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // autoctrl
            // 
            this.autoctrl.AutoSize = true;
            this.autoctrl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoctrl.ForeColor = System.Drawing.Color.DarkCyan;
            this.autoctrl.Location = new System.Drawing.Point(12, 194);
            this.autoctrl.Name = "autoctrl";
            this.autoctrl.Size = new System.Drawing.Size(94, 27);
            this.autoctrl.TabIndex = 19;
            this.autoctrl.Text = "AutoCtrl";
            this.autoctrl.UseVisualStyleBackColor = true;
            this.autoctrl.CheckedChanged += new System.EventHandler(this.autoctrl_CheckedChanged);
            // 
            // autoshift
            // 
            this.autoshift.AutoSize = true;
            this.autoshift.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoshift.ForeColor = System.Drawing.Color.DarkCyan;
            this.autoshift.Location = new System.Drawing.Point(12, 227);
            this.autoshift.Name = "autoshift";
            this.autoshift.Size = new System.Drawing.Size(103, 27);
            this.autoshift.TabIndex = 20;
            this.autoshift.Text = "AutoShift";
            this.autoshift.UseVisualStyleBackColor = true;
            this.autoshift.CheckedChanged += new System.EventHandler(this.autoshift_CheckedChanged);
            // 
            // autospace
            // 
            this.autospace.AutoSize = true;
            this.autospace.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autospace.ForeColor = System.Drawing.Color.DarkCyan;
            this.autospace.Location = new System.Drawing.Point(12, 260);
            this.autospace.Name = "autospace";
            this.autospace.Size = new System.Drawing.Size(64, 27);
            this.autospace.TabIndex = 21;
            this.autospace.Text = "Bhop";
            this.autospace.UseVisualStyleBackColor = true;
            this.autospace.CheckedChanged += new System.EventHandler(this.autospace_CheckedChanged);
            // 
            // TriggerBot
            // 
            this.TriggerBot.AutoSize = true;
            this.TriggerBot.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriggerBot.ForeColor = System.Drawing.Color.DarkCyan;
            this.TriggerBot.Location = new System.Drawing.Point(12, 293);
            this.TriggerBot.Name = "TriggerBot";
            this.TriggerBot.Size = new System.Drawing.Size(110, 27);
            this.TriggerBot.TabIndex = 23;
            this.TriggerBot.Text = "TriggerBot";
            this.TriggerBot.UseVisualStyleBackColor = true;
            this.TriggerBot.CheckedChanged += new System.EventHandler(this.TriggerBot_CheckedChanged);
            // 
            // UserFOV
            // 
            this.UserFOV.AutoSize = true;
            this.UserFOV.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFOV.ForeColor = System.Drawing.Color.GreenYellow;
            this.UserFOV.Location = new System.Drawing.Point(106, 418);
            this.UserFOV.Name = "UserFOV";
            this.UserFOV.Size = new System.Drawing.Size(44, 23);
            this.UserFOV.TabIndex = 24;
            this.UserFOV.Text = "N/A";
            // 
            // NoFall
            // 
            this.NoFall.AutoSize = true;
            this.NoFall.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoFall.ForeColor = System.Drawing.Color.DarkCyan;
            this.NoFall.Location = new System.Drawing.Point(12, 326);
            this.NoFall.Name = "NoFall";
            this.NoFall.Size = new System.Drawing.Size(78, 27);
            this.NoFall.TabIndex = 25;
            this.NoFall.Text = "NoFall";
            this.NoFall.UseVisualStyleBackColor = true;
            this.NoFall.CheckedChanged += new System.EventHandler(this.NoFall_CheckedChanged);
            // 
            // keybinds
            // 
            this.keybinds.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keybinds.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keybinds.ForeColor = System.Drawing.Color.DarkViolet;
            this.keybinds.Location = new System.Drawing.Point(437, 35);
            this.keybinds.Name = "keybinds";
            this.keybinds.Size = new System.Drawing.Size(86, 32);
            this.keybinds.TabIndex = 26;
            this.keybinds.Text = "Keybinds";
            this.keybinds.UseVisualStyleBackColor = false;
            this.keybinds.Click += new System.EventHandler(this.keybinds_Click);
            // 
            // Cock_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.keybinds);
            this.Controls.Add(this.NoFall);
            this.Controls.Add(this.UserFOV);
            this.Controls.Add(this.TriggerBot);
            this.Controls.Add(this.autospace);
            this.Controls.Add(this.autoshift);
            this.Controls.Add(this.autoctrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fullbright);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.AirJump);
            this.Controls.Add(this.Fly);
            this.Controls.Add(this.SpeedValue);
            this.Controls.Add(this.Suicide);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cock_Client";
            this.Text = "x1 is sex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Cock_Client_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Button Suicide;
        private System.Windows.Forms.TextBox SpeedValue;
        private System.Windows.Forms.CheckBox Fly;
        private System.Windows.Forms.CheckBox AirJump;
        private System.Windows.Forms.CheckBox Zoom;
        private System.Windows.Forms.CheckBox Fullbright;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox autoctrl;
        private System.Windows.Forms.CheckBox autoshift;
        private System.Windows.Forms.CheckBox autospace;
        private System.Windows.Forms.CheckBox TriggerBot;
        private System.Windows.Forms.Label UserFOV;
        private System.Windows.Forms.CheckBox NoFall;
        private System.Windows.Forms.Button keybinds;
    }
}

