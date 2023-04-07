namespace lab9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.CheckBox();
            this.Paws1 = new System.Windows.Forms.CheckBox();
            this.Paws2 = new System.Windows.Forms.CheckBox();
            this.tail = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рисование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.head.Location = new System.Drawing.Point(670, 169);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(83, 24);
            this.head.TabIndex = 2;
            this.head.Text = "Голова";
            this.head.UseVisualStyleBackColor = true;
            this.head.CheckedChanged += new System.EventHandler(this.head_CheckedChanged);
            // 
            // Paws1
            // 
            this.Paws1.AutoSize = true;
            this.Paws1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paws1.Location = new System.Drawing.Point(670, 192);
            this.Paws1.Name = "Paws1";
            this.Paws1.Size = new System.Drawing.Size(154, 24);
            this.Paws1.TabIndex = 4;
            this.Paws1.Text = "Передние лапки";
            this.Paws1.UseVisualStyleBackColor = true;
            this.Paws1.CheckedChanged += new System.EventHandler(this.Paws1_CheckedChanged);
            // 
            // Paws2
            // 
            this.Paws2.AutoSize = true;
            this.Paws2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paws2.Location = new System.Drawing.Point(670, 215);
            this.Paws2.Name = "Paws2";
            this.Paws2.Size = new System.Drawing.Size(135, 24);
            this.Paws2.TabIndex = 5;
            this.Paws2.Text = "Задние лапки";
            this.Paws2.UseVisualStyleBackColor = true;
            this.Paws2.CheckedChanged += new System.EventHandler(this.Paws2_CheckedChanged);
            // 
            // tail
            // 
            this.tail.AutoSize = true;
            this.tail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tail.Location = new System.Drawing.Point(670, 238);
            this.tail.Name = "tail";
            this.tail.Size = new System.Drawing.Size(74, 24);
            this.tail.TabIndex = 6;
            this.tail.Text = "Хвост";
            this.tail.UseVisualStyleBackColor = true;
            this.tail.CheckedChanged += new System.EventHandler(this.tail_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 550);
            this.Controls.Add(this.tail);
            this.Controls.Add(this.Paws2);
            this.Controls.Add(this.Paws1);
            this.Controls.Add(this.head);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ЛР9";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox head;
        private System.Windows.Forms.CheckBox Paws1;
        private System.Windows.Forms.CheckBox Paws2;
        private System.Windows.Forms.CheckBox tail;
    }
}

