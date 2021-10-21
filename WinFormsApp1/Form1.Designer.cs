
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WeaponDamage = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.WeaponCrit = new System.Windows.Forms.TextBox();
            this.ModsDamage = new System.Windows.Forms.TextBox();
            this.ModsCrit = new System.Windows.Forms.TextBox();
            this.NumberAccs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BulletDamge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeaponDamage
            // 
            this.WeaponDamage.Location = new System.Drawing.Point(12, 86);
            this.WeaponDamage.Name = "WeaponDamage";
            this.WeaponDamage.Size = new System.Drawing.Size(175, 23);
            this.WeaponDamage.TabIndex = 0;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 291);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 23);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weapon Damage:";
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(12, 340);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(175, 23);
            this.Answer.TabIndex = 3;
            // 
            // WeaponCrit
            // 
            this.WeaponCrit.Location = new System.Drawing.Point(12, 130);
            this.WeaponCrit.Name = "WeaponCrit";
            this.WeaponCrit.Size = new System.Drawing.Size(175, 23);
            this.WeaponCrit.TabIndex = 4;
            // 
            // ModsDamage
            // 
            this.ModsDamage.Location = new System.Drawing.Point(12, 174);
            this.ModsDamage.Name = "ModsDamage";
            this.ModsDamage.Size = new System.Drawing.Size(175, 23);
            this.ModsDamage.TabIndex = 5;
            // 
            // ModsCrit
            // 
            this.ModsCrit.Location = new System.Drawing.Point(12, 218);
            this.ModsCrit.Name = "ModsCrit";
            this.ModsCrit.Size = new System.Drawing.Size(175, 23);
            this.ModsCrit.TabIndex = 6;
            // 
            // NumberAccs
            // 
            this.NumberAccs.Location = new System.Drawing.Point(12, 262);
            this.NumberAccs.Name = "NumberAccs";
            this.NumberAccs.Size = new System.Drawing.Size(175, 23);
            this.NumberAccs.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weapon Crit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mods Damage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mods Crit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numder of Accs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Answer:";
            // 
            // BulletDamge
            // 
            this.BulletDamge.Location = new System.Drawing.Point(13, 42);
            this.BulletDamge.Name = "BulletDamge";
            this.BulletDamge.Size = new System.Drawing.Size(174, 23);
            this.BulletDamge.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = " Bullet Damage:\r\n(Leave 0 if not Ranged Weapon)\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 373);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BulletDamge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberAccs);
            this.Controls.Add(this.ModsCrit);
            this.Controls.Add(this.ModsDamage);
            this.Controls.Add(this.WeaponCrit);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.WeaponDamage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeaponDamage;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.TextBox WeaponCrit;
        private System.Windows.Forms.TextBox ModsDamage;
        private System.Windows.Forms.TextBox ModsCrit;
        private System.Windows.Forms.TextBox NumberAccs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BulletDamge;
        private System.Windows.Forms.Label label7;
    }
}

