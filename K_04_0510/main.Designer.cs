namespace K_04_0510
{
    partial class main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.main_gen = new System.Windows.Forms.Button();
            this.main_exp = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_gen
            // 
            this.main_gen.BackColor = System.Drawing.Color.Transparent;
            this.main_gen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.main_gen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.main_gen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.main_gen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_gen.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_gen.ForeColor = System.Drawing.Color.Black;
            this.main_gen.Location = new System.Drawing.Point(53, 132);
            this.main_gen.Name = "main_gen";
            this.main_gen.Size = new System.Drawing.Size(83, 27);
            this.main_gen.TabIndex = 2;
            this.main_gen.Text = "Генерация";
            this.main_gen.UseVisualStyleBackColor = false;
            this.main_gen.Click += new System.EventHandler(this.main_gen_Click);
            // 
            // main_exp
            // 
            this.main_exp.BackColor = System.Drawing.Color.Transparent;
            this.main_exp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.main_exp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_exp.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_exp.ForeColor = System.Drawing.Color.Black;
            this.main_exp.Location = new System.Drawing.Point(154, 132);
            this.main_exp.Name = "main_exp";
            this.main_exp.Size = new System.Drawing.Size(95, 27);
            this.main_exp.TabIndex = 3;
            this.main_exp.Text = "Эксперимент";
            this.main_exp.UseVisualStyleBackColor = false;
            this.main_exp.Click += new System.EventHandler(this.main_exp_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(271, 132);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 27);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 248);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.main_exp);
            this.Controls.Add(this.main_gen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(408, 273);
            this.MinimumSize = new System.Drawing.Size(408, 273);
            this.Name = "main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button main_gen;
        private System.Windows.Forms.Button main_exp;
        private System.Windows.Forms.Button exit;
    }
}

