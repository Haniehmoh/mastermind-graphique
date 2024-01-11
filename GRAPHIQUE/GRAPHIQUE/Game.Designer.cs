namespace GRAPHIQUE
{
    partial class Game
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab8 = new System.Windows.Forms.Label();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.labelsec4 = new System.Windows.Forms.Label();
            this.labelsec3 = new System.Windows.Forms.Label();
            this.labelsec2 = new System.Windows.Forms.Label();
            this.labelsec1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuBtn = new System.Windows.Forms.Button();
            this.lab11 = new System.Windows.Forms.Label();
            this.lab9 = new System.Windows.Forms.Label();
            this.lab10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lab12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(618, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(618, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Effacer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(638, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "code secret";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 18);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.label3.Size = new System.Drawing.Size(566, 75);
            this.label3.TabIndex = 25;
            this.label3.Text = "Jeu MasterMind";
            // 
            // lab8
            // 
            this.lab8.AutoSize = true;
            this.lab8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lab8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab8.Location = new System.Drawing.Point(669, 129);
            this.lab8.Name = "lab8";
            this.lab8.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lab8.Size = new System.Drawing.Size(32, 35);
            this.lab8.TabIndex = 34;
            this.lab8.Click += new System.EventHandler(this.lab8_Click);
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.BackColor = System.Drawing.Color.Red;
            this.lab7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab7.Location = new System.Drawing.Point(631, 129);
            this.lab7.Name = "lab7";
            this.lab7.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lab7.Size = new System.Drawing.Size(32, 35);
            this.lab7.TabIndex = 33;
            this.lab7.Click += new System.EventHandler(this.lab7_Click);
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.BackColor = System.Drawing.Color.Green;
            this.lab6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab6.Location = new System.Drawing.Point(593, 129);
            this.lab6.Name = "lab6";
            this.lab6.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lab6.Size = new System.Drawing.Size(32, 35);
            this.lab6.TabIndex = 32;
            this.lab6.Click += new System.EventHandler(this.lab6_Click);
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.BackColor = System.Drawing.Color.Blue;
            this.lab5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab5.Location = new System.Drawing.Point(555, 129);
            this.lab5.Name = "lab5";
            this.lab5.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lab5.Size = new System.Drawing.Size(32, 35);
            this.lab5.TabIndex = 31;
            this.lab5.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelsec4
            // 
            this.labelsec4.AutoSize = true;
            this.labelsec4.BackColor = System.Drawing.Color.Silver;
            this.labelsec4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelsec4.Location = new System.Drawing.Point(710, 526);
            this.labelsec4.Name = "labelsec4";
            this.labelsec4.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.labelsec4.Size = new System.Drawing.Size(32, 35);
            this.labelsec4.TabIndex = 39;
            // 
            // labelsec3
            // 
            this.labelsec3.AutoSize = true;
            this.labelsec3.BackColor = System.Drawing.Color.Silver;
            this.labelsec3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelsec3.Location = new System.Drawing.Point(672, 526);
            this.labelsec3.Name = "labelsec3";
            this.labelsec3.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.labelsec3.Size = new System.Drawing.Size(32, 35);
            this.labelsec3.TabIndex = 38;
            // 
            // labelsec2
            // 
            this.labelsec2.AutoSize = true;
            this.labelsec2.BackColor = System.Drawing.Color.Silver;
            this.labelsec2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelsec2.Location = new System.Drawing.Point(634, 526);
            this.labelsec2.Name = "labelsec2";
            this.labelsec2.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.labelsec2.Size = new System.Drawing.Size(32, 35);
            this.labelsec2.TabIndex = 37;
            // 
            // labelsec1
            // 
            this.labelsec1.AutoSize = true;
            this.labelsec1.BackColor = System.Drawing.Color.Silver;
            this.labelsec1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelsec1.Location = new System.Drawing.Point(596, 526);
            this.labelsec1.Name = "labelsec1";
            this.labelsec1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.labelsec1.Size = new System.Drawing.Size(32, 35);
            this.labelsec1.TabIndex = 36;
            this.labelsec1.Click += new System.EventHandler(this.labelsec1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Fuchsia;
            this.label8.Location = new System.Drawing.Point(613, 536);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label8.Size = new System.Drawing.Size(30, 43);
            this.label8.TabIndex = 35;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuBtn
            // 
            this.menuBtn.Location = new System.Drawing.Point(625, 267);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(75, 23);
            this.menuBtn.TabIndex = 53;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // lab11
            // 
            this.lab11.AutoSize = true;
            this.lab11.BackColor = System.Drawing.Color.Cyan;
            this.lab11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab11.Location = new System.Drawing.Point(669, 168);
            this.lab11.Name = "lab11";
            this.lab11.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lab11.Size = new System.Drawing.Size(32, 35);
            this.lab11.TabIndex = 54;
            this.lab11.Click += new System.EventHandler(this.lab11_Click);
            // 
            // lab9
            // 
            this.lab9.AutoSize = true;
            this.lab9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lab9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab9.Location = new System.Drawing.Point(593, 168);
            this.lab9.Name = "lab9";
            this.lab9.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lab9.Size = new System.Drawing.Size(32, 35);
            this.lab9.TabIndex = 55;
            this.lab9.Click += new System.EventHandler(this.lab9_Click);
            // 
            // lab10
            // 
            this.lab10.AutoSize = true;
            this.lab10.BackColor = System.Drawing.Color.Fuchsia;
            this.lab10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab10.Location = new System.Drawing.Point(630, 168);
            this.lab10.Name = "lab10";
            this.lab10.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lab10.Size = new System.Drawing.Size(32, 35);
            this.lab10.TabIndex = 56;
            this.lab10.Click += new System.EventHandler(this.lab10_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(616, 463);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 20);
            this.button3.TabIndex = 57;
            this.button3.Text = "cacher le code secret";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lab12
            // 
            this.lab12.AutoSize = true;
            this.lab12.BackColor = System.Drawing.Color.DarkViolet;
            this.lab12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab12.Location = new System.Drawing.Point(555, 168);
            this.lab12.Name = "lab12";
            this.lab12.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lab12.Size = new System.Drawing.Size(32, 35);
            this.lab12.TabIndex = 58;
            this.lab12.Click += new System.EventHandler(this.lab12_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(905, 687);
            this.Controls.Add(this.lab12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lab10);
            this.Controls.Add(this.lab9);
            this.Controls.Add(this.lab11);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.labelsec4);
            this.Controls.Add(this.labelsec3);
            this.Controls.Add(this.labelsec2);
            this.Controls.Add(this.labelsec1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab8);
            this.Controls.Add(this.lab7);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.Name = "Game";
            this.Text = "MasterMind";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab8;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label labelsec4;
        private System.Windows.Forms.Label labelsec3;
        private System.Windows.Forms.Label labelsec2;
        private System.Windows.Forms.Label labelsec1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label lab11;
        private System.Windows.Forms.Label lab9;
        private System.Windows.Forms.Label lab10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lab12;
    }
}

