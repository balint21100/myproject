namespace csillahul
{
    partial class Form3
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.playerstart = new System.Windows.Forms.RadioButton();
            this.kezdes = new System.Windows.Forms.Label();
            this.botstart = new System.Windows.Forms.RadioButton();
            this.startrand = new System.Windows.Forms.RadioButton();
            this.boteasy = new System.Windows.Forms.RadioButton();
            this.bothard = new System.Windows.Forms.RadioButton();
            this.bot_difficulities = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botmedium = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(107, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kérem adja meg a nevét";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(95, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Játék kezdése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerstart
            // 
            this.playerstart.AutoSize = true;
            this.playerstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.playerstart.Location = new System.Drawing.Point(10, 19);
            this.playerstart.Name = "playerstart";
            this.playerstart.Size = new System.Drawing.Size(75, 21);
            this.playerstart.TabIndex = 3;
            this.playerstart.TabStop = true;
            this.playerstart.Text = "Játékos";
            this.playerstart.UseVisualStyleBackColor = true;
            // 
            // kezdes
            // 
            this.kezdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kezdes.Location = new System.Drawing.Point(113, 72);
            this.kezdes.Name = "kezdes";
            this.kezdes.Size = new System.Drawing.Size(94, 19);
            this.kezdes.TabIndex = 1;
            this.kezdes.Text = "Ki kezdjen?";
            // 
            // botstart
            // 
            this.botstart.AutoSize = true;
            this.botstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.botstart.Location = new System.Drawing.Point(135, 19);
            this.botstart.Name = "botstart";
            this.botstart.Size = new System.Drawing.Size(47, 21);
            this.botstart.TabIndex = 3;
            this.botstart.TabStop = true;
            this.botstart.Text = "Bot";
            this.botstart.UseVisualStyleBackColor = true;
            // 
            // startrand
            // 
            this.startrand.AutoSize = true;
            this.startrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startrand.Location = new System.Drawing.Point(224, 19);
            this.startrand.Name = "startrand";
            this.startrand.Size = new System.Drawing.Size(79, 21);
            this.startrand.TabIndex = 3;
            this.startrand.TabStop = true;
            this.startrand.Text = "Random";
            this.startrand.UseVisualStyleBackColor = true;
            // 
            // boteasy
            // 
            this.boteasy.AutoSize = true;
            this.boteasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boteasy.Location = new System.Drawing.Point(8, 19);
            this.boteasy.Name = "boteasy";
            this.boteasy.Size = new System.Drawing.Size(57, 20);
            this.boteasy.TabIndex = 4;
            this.boteasy.TabStop = true;
            this.boteasy.Text = "Easy";
            this.boteasy.UseVisualStyleBackColor = true;
            // 
            // bothard
            // 
            this.bothard.AutoSize = true;
            this.bothard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bothard.Location = new System.Drawing.Point(151, 19);
            this.bothard.Name = "bothard";
            this.bothard.Size = new System.Drawing.Size(56, 20);
            this.bothard.TabIndex = 5;
            this.bothard.TabStop = true;
            this.bothard.Text = "Hard";
            this.bothard.UseVisualStyleBackColor = true;
            // 
            // bot_difficulities
            // 
            this.bot_difficulities.AutoSize = true;
            this.bot_difficulities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bot_difficulities.Location = new System.Drawing.Point(80, 153);
            this.bot_difficulities.Name = "bot_difficulities";
            this.bot_difficulities.Size = new System.Drawing.Size(160, 20);
            this.bot_difficulities.TabIndex = 6;
            this.bot_difficulities.Text = "Milyen nehéz legyen?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerstart);
            this.groupBox1.Controls.Add(this.botstart);
            this.groupBox1.Controls.Add(this.startrand);
            this.groupBox1.Location = new System.Drawing.Point(4, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botmedium);
            this.groupBox2.Controls.Add(this.boteasy);
            this.groupBox2.Controls.Add(this.bothard);
            this.groupBox2.Location = new System.Drawing.Point(52, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 56);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // botmedium
            // 
            this.botmedium.AutoSize = true;
            this.botmedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.botmedium.Location = new System.Drawing.Point(71, 19);
            this.botmedium.Name = "botmedium";
            this.botmedium.Size = new System.Drawing.Size(74, 20);
            this.botmedium.TabIndex = 6;
            this.botmedium.TabStop = true;
            this.botmedium.Text = "Medium";
            this.botmedium.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bot_difficulities);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kezdes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton playerstart;
        private System.Windows.Forms.Label kezdes;
        private System.Windows.Forms.RadioButton botstart;
        private System.Windows.Forms.RadioButton startrand;
        private System.Windows.Forms.RadioButton boteasy;
        private System.Windows.Forms.RadioButton bothard;
        private System.Windows.Forms.Label bot_difficulities;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton botmedium;
    }
}