namespace K_04_0510
{
    partial class generate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generate));
            this.genDown = new System.Windows.Forms.RadioButton();
            this.choose = new System.Windows.Forms.Label();
            this.seqtype = new System.Windows.Forms.GroupBox();
            this.genRandom = new System.Windows.Forms.RadioButton();
            this.genRotate = new System.Windows.Forms.RadioButton();
            this.genUp = new System.Windows.Forms.RadioButton();
            this.genNumberEl = new System.Windows.Forms.GroupBox();
            this.genTo = new System.Windows.Forms.Label();
            this.genFrom = new System.Windows.Forms.Label();
            this.genFromUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.genFromUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.genNumbSeq = new System.Windows.Forms.GroupBox();
            this.genNumSeqUpDown = new System.Windows.Forms.NumericUpDown();
            this.genGenerateB = new System.Windows.Forms.Button();
            this.genCancel = new System.Windows.Forms.Button();
            this.seqtype.SuspendLayout();
            this.genNumberEl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genFromUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genFromUpDown1)).BeginInit();
            this.genNumbSeq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genNumSeqUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // genDown
            // 
            this.genDown.AutoSize = true;
            this.genDown.Location = new System.Drawing.Point(7, 44);
            this.genDown.Name = "genDown";
            this.genDown.Size = new System.Drawing.Size(88, 17);
            this.genDown.TabIndex = 1;
            this.genDown.TabStop = true;
            this.genDown.Text = "Убывающая";
            this.genDown.UseVisualStyleBackColor = true;
            this.genDown.CheckedChanged += new System.EventHandler(this.genDown_CheckedChanged);
            // 
            // choose
            // 
            this.choose.AutoSize = true;
            this.choose.BackColor = System.Drawing.Color.Transparent;
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose.Location = new System.Drawing.Point(26, 34);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(78, 15);
            this.choose.TabIndex = 3;
            this.choose.Text = "Выберите:";
            // 
            // seqtype
            // 
            this.seqtype.BackColor = System.Drawing.Color.Transparent;
            this.seqtype.Controls.Add(this.genRandom);
            this.seqtype.Controls.Add(this.genRotate);
            this.seqtype.Controls.Add(this.genDown);
            this.seqtype.Controls.Add(this.genUp);
            this.seqtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seqtype.Location = new System.Drawing.Point(22, 74);
            this.seqtype.Name = "seqtype";
            this.seqtype.Size = new System.Drawing.Size(200, 126);
            this.seqtype.TabIndex = 4;
            this.seqtype.TabStop = false;
            this.seqtype.Text = "Тип последовательности";
            this.seqtype.Enter += new System.EventHandler(this.seqtype_Enter);
            // 
            // genRandom
            // 
            this.genRandom.AutoSize = true;
            this.genRandom.Location = new System.Drawing.Point(7, 92);
            this.genRandom.Name = "genRandom";
            this.genRandom.Size = new System.Drawing.Size(99, 17);
            this.genRandom.TabIndex = 3;
            this.genRandom.TabStop = true;
            this.genRandom.Text = "Произвольная";
            this.genRandom.UseVisualStyleBackColor = true;
            this.genRandom.CheckedChanged += new System.EventHandler(this.genRandom_CheckedChanged);
            // 
            // genRotate
            // 
            this.genRotate.AutoSize = true;
            this.genRotate.Location = new System.Drawing.Point(7, 68);
            this.genRotate.Name = "genRotate";
            this.genRotate.Size = new System.Drawing.Size(154, 17);
            this.genRotate.TabIndex = 2;
            this.genRotate.TabStop = true;
            this.genRotate.Text = "С чередующимся ключом";
            this.genRotate.UseVisualStyleBackColor = true;
            this.genRotate.CheckedChanged += new System.EventHandler(this.genRotate_CheckedChanged);
            // 
            // genUp
            // 
            this.genUp.AutoSize = true;
            this.genUp.Location = new System.Drawing.Point(7, 20);
            this.genUp.Name = "genUp";
            this.genUp.Size = new System.Drawing.Size(102, 17);
            this.genUp.TabIndex = 0;
            this.genUp.TabStop = true;
            this.genUp.Text = "Возрастающая";
            this.genUp.UseVisualStyleBackColor = true;
            this.genUp.CheckedChanged += new System.EventHandler(this.genUp_CheckedChanged);
            // 
            // genNumberEl
            // 
            this.genNumberEl.BackColor = System.Drawing.Color.Transparent;
            this.genNumberEl.Controls.Add(this.genTo);
            this.genNumberEl.Controls.Add(this.genFrom);
            this.genNumberEl.Controls.Add(this.genFromUpDown2);
            this.genNumberEl.Controls.Add(this.genFromUpDown1);
            this.genNumberEl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genNumberEl.Location = new System.Drawing.Point(241, 46);
            this.genNumberEl.Name = "genNumberEl";
            this.genNumberEl.Size = new System.Drawing.Size(200, 100);
            this.genNumberEl.TabIndex = 5;
            this.genNumberEl.TabStop = false;
            this.genNumberEl.Text = "Число элементов";
            // 
            // genTo
            // 
            this.genTo.AutoSize = true;
            this.genTo.Location = new System.Drawing.Point(20, 62);
            this.genTo.Name = "genTo";
            this.genTo.Size = new System.Drawing.Size(19, 13);
            this.genTo.TabIndex = 3;
            this.genTo.Text = "до";
            // 
            // genFrom
            // 
            this.genFrom.AutoSize = true;
            this.genFrom.Location = new System.Drawing.Point(20, 28);
            this.genFrom.Name = "genFrom";
            this.genFrom.Size = new System.Drawing.Size(18, 13);
            this.genFrom.TabIndex = 2;
            this.genFrom.Text = "от";
            // 
            // genFromUpDown2
            // 
            this.genFromUpDown2.Location = new System.Drawing.Point(62, 62);
            this.genFromUpDown2.Name = "genFromUpDown2";
            this.genFromUpDown2.Size = new System.Drawing.Size(120, 20);
            this.genFromUpDown2.TabIndex = 1;
            this.genFromUpDown2.ValueChanged += new System.EventHandler(this.genFromUpDown2_ValueChanged);
            // 
            // genFromUpDown1
            // 
            this.genFromUpDown1.Location = new System.Drawing.Point(62, 26);
            this.genFromUpDown1.Name = "genFromUpDown1";
            this.genFromUpDown1.Size = new System.Drawing.Size(120, 20);
            this.genFromUpDown1.TabIndex = 0;
            this.genFromUpDown1.ValueChanged += new System.EventHandler(this.genFromUpDown1_ValueChanged);
            // 
            // genNumbSeq
            // 
            this.genNumbSeq.BackColor = System.Drawing.Color.Transparent;
            this.genNumbSeq.Controls.Add(this.genNumSeqUpDown);
            this.genNumbSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genNumbSeq.Location = new System.Drawing.Point(241, 164);
            this.genNumbSeq.Name = "genNumbSeq";
            this.genNumbSeq.Size = new System.Drawing.Size(200, 70);
            this.genNumbSeq.TabIndex = 6;
            this.genNumbSeq.TabStop = false;
            this.genNumbSeq.Text = "Число последовательностей";
            // 
            // genNumSeqUpDown
            // 
            this.genNumSeqUpDown.Location = new System.Drawing.Point(62, 36);
            this.genNumSeqUpDown.Name = "genNumSeqUpDown";
            this.genNumSeqUpDown.Size = new System.Drawing.Size(120, 20);
            this.genNumSeqUpDown.TabIndex = 0;
            this.genNumSeqUpDown.ValueChanged += new System.EventHandler(this.genNumSeqUpDown_ValueChanged);
            // 
            // genGenerateB
            // 
            this.genGenerateB.BackColor = System.Drawing.Color.Transparent;
            this.genGenerateB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genGenerateB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genGenerateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genGenerateB.Location = new System.Drawing.Point(468, 108);
            this.genGenerateB.Name = "genGenerateB";
            this.genGenerateB.Size = new System.Drawing.Size(85, 31);
            this.genGenerateB.TabIndex = 7;
            this.genGenerateB.Text = "Генерация";
            this.genGenerateB.UseVisualStyleBackColor = false;
            this.genGenerateB.Click += new System.EventHandler(this.genGenerateB_Click);
            // 
            // genCancel
            // 
            this.genCancel.BackColor = System.Drawing.Color.Transparent;
            this.genCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genCancel.Location = new System.Drawing.Point(468, 164);
            this.genCancel.Name = "genCancel";
            this.genCancel.Size = new System.Drawing.Size(85, 31);
            this.genCancel.TabIndex = 8;
            this.genCancel.Text = "Отмена";
            this.genCancel.UseVisualStyleBackColor = false;
            this.genCancel.Click += new System.EventHandler(this.genCancel_Click);
            // 
            // generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 268);
            this.Controls.Add(this.genCancel);
            this.Controls.Add(this.genGenerateB);
            this.Controls.Add(this.genNumbSeq);
            this.Controls.Add(this.genNumberEl);
            this.Controls.Add(this.seqtype);
            this.Controls.Add(this.choose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(590, 307);
            this.MinimumSize = new System.Drawing.Size(590, 307);
            this.Name = "generate";
            this.Text = "Генерация";
            this.Load += new System.EventHandler(this.generate_Load);
            this.seqtype.ResumeLayout(false);
            this.seqtype.PerformLayout();
            this.genNumberEl.ResumeLayout(false);
            this.genNumberEl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genFromUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genFromUpDown1)).EndInit();
            this.genNumbSeq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genNumSeqUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.GroupBox seqtype;
        private System.Windows.Forms.RadioButton genRandom;
        private System.Windows.Forms.RadioButton genRotate;
        private System.Windows.Forms.RadioButton genUp;
        private System.Windows.Forms.GroupBox genNumberEl;
        private System.Windows.Forms.Label genTo;
        private System.Windows.Forms.Label genFrom;
        private System.Windows.Forms.NumericUpDown genFromUpDown2;
        private System.Windows.Forms.NumericUpDown genFromUpDown1;
        private System.Windows.Forms.GroupBox genNumbSeq;
        private System.Windows.Forms.Button genGenerateB;
        private System.Windows.Forms.Button genCancel;
        private System.Windows.Forms.NumericUpDown genNumSeqUpDown;
        private System.Windows.Forms.RadioButton genDown;
    }
}