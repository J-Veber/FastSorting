namespace K_04_0510
{
    partial class experiment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(experiment));
            this.expAdd = new System.Windows.Forms.Button();
            this.expCancel = new System.Windows.Forms.Button();
            this.analisChoise = new System.Windows.Forms.GroupBox();
            this.rand = new System.Windows.Forms.CheckBox();
            this.last = new System.Windows.Forms.CheckBox();
            this.first = new System.Windows.Forms.CheckBox();
            this.med = new System.Windows.Forms.CheckBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.analisChoise.SuspendLayout();
            this.SuspendLayout();
            // 
            // expAdd
            // 
            this.expAdd.BackColor = System.Drawing.Color.Transparent;
            this.expAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expAdd.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expAdd.Location = new System.Drawing.Point(295, 69);
            this.expAdd.Name = "expAdd";
            this.expAdd.Size = new System.Drawing.Size(145, 27);
            this.expAdd.TabIndex = 6;
            this.expAdd.Text = "Добавить файлы";
            this.expAdd.UseVisualStyleBackColor = false;
            this.expAdd.Click += new System.EventHandler(this.expAdd_Click);
            // 
            // expCancel
            // 
            this.expCancel.BackColor = System.Drawing.Color.Transparent;
            this.expCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expCancel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expCancel.Location = new System.Drawing.Point(295, 124);
            this.expCancel.Name = "expCancel";
            this.expCancel.Size = new System.Drawing.Size(145, 27);
            this.expCancel.TabIndex = 9;
            this.expCancel.Text = "Отмена";
            this.expCancel.UseVisualStyleBackColor = false;
            this.expCancel.Click += new System.EventHandler(this.expCancel_Click);
            // 
            // analisChoise
            // 
            this.analisChoise.BackColor = System.Drawing.Color.Transparent;
            this.analisChoise.Controls.Add(this.rand);
            this.analisChoise.Controls.Add(this.last);
            this.analisChoise.Controls.Add(this.first);
            this.analisChoise.Controls.Add(this.med);
            this.analisChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analisChoise.Location = new System.Drawing.Point(15, 44);
            this.analisChoise.Name = "analisChoise";
            this.analisChoise.Size = new System.Drawing.Size(260, 129);
            this.analisChoise.TabIndex = 10;
            this.analisChoise.TabStop = false;
            this.analisChoise.Text = "Выберите тип разделяющего элемента";
            // 
            // rand
            // 
            this.rand.AutoSize = true;
            this.rand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rand.Location = new System.Drawing.Point(15, 97);
            this.rand.Name = "rand";
            this.rand.Size = new System.Drawing.Size(113, 19);
            this.rand.TabIndex = 3;
            this.rand.Text = "Произвольный";
            this.rand.UseVisualStyleBackColor = true;
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last.Location = new System.Drawing.Point(15, 73);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(90, 19);
            this.last.TabIndex = 2;
            this.last.Text = "Последний";
            this.last.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.Location = new System.Drawing.Point(15, 49);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(72, 19);
            this.first.TabIndex = 1;
            this.first.Text = "Первый";
            this.first.UseVisualStyleBackColor = true;
            // 
            // med
            // 
            this.med.AutoSize = true;
            this.med.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.med.Location = new System.Drawing.Point(15, 25);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(79, 19);
            this.med.TabIndex = 0;
            this.med.Text = "Медиана";
            this.med.UseVisualStyleBackColor = true;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            this.OFD.Multiselect = true;
            this.OFD.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_FileOk);
            // 
            // experiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 218);
            this.Controls.Add(this.analisChoise);
            this.Controls.Add(this.expCancel);
            this.Controls.Add(this.expAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(473, 243);
            this.MinimumSize = new System.Drawing.Size(473, 243);
            this.Name = "experiment";
            this.Text = "Эксперимент";
            this.Load += new System.EventHandler(this.experiment_Load);
            this.analisChoise.ResumeLayout(false);
            this.analisChoise.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button expAdd;
        private System.Windows.Forms.Button expCancel;
        private System.Windows.Forms.GroupBox analisChoise;
        private System.Windows.Forms.CheckBox rand;
        private System.Windows.Forms.CheckBox last;
        private System.Windows.Forms.CheckBox first;
        private System.Windows.Forms.CheckBox med;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}