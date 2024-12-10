namespace Learn
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditNameLabel = new System.Windows.Forms.Label();
            this.EditNameBox = new System.Windows.Forms.TextBox();
            this.EditCostBox = new System.Windows.Forms.TextBox();
            this.EditCostLabel = new System.Windows.Forms.Label();
            this.EditDurBox = new System.Windows.Forms.TextBox();
            this.EditDurLabel = new System.Windows.Forms.Label();
            this.EditDescBox = new System.Windows.Forms.TextBox();
            this.EditDescLabel = new System.Windows.Forms.Label();
            this.EditDiscBox = new System.Windows.Forms.TextBox();
            this.EditDiscLabel = new System.Windows.Forms.Label();
            this.EditPictureLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(1070, 515);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 28);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Learn.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 609);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EditNameLabel
            // 
            this.EditNameLabel.AutoSize = true;
            this.EditNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditNameLabel.Location = new System.Drawing.Point(677, 37);
            this.EditNameLabel.Name = "EditNameLabel";
            this.EditNameLabel.Size = new System.Drawing.Size(72, 19);
            this.EditNameLabel.TabIndex = 5;
            this.EditNameLabel.Text = "Название";
            // 
            // EditNameBox
            // 
            this.EditNameBox.Location = new System.Drawing.Point(861, 37);
            this.EditNameBox.Name = "EditNameBox";
            this.EditNameBox.Size = new System.Drawing.Size(200, 20);
            this.EditNameBox.TabIndex = 6;
            // 
            // EditCostBox
            // 
            this.EditCostBox.Location = new System.Drawing.Point(861, 88);
            this.EditCostBox.Name = "EditCostBox";
            this.EditCostBox.Size = new System.Drawing.Size(200, 20);
            this.EditCostBox.TabIndex = 8;
            // 
            // EditCostLabel
            // 
            this.EditCostLabel.AutoSize = true;
            this.EditCostLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCostLabel.Location = new System.Drawing.Point(677, 88);
            this.EditCostLabel.Name = "EditCostLabel";
            this.EditCostLabel.Size = new System.Drawing.Size(80, 19);
            this.EditCostLabel.TabIndex = 7;
            this.EditCostLabel.Text = "Стоимость";
            // 
            // EditDurBox
            // 
            this.EditDurBox.Location = new System.Drawing.Point(861, 139);
            this.EditDurBox.Name = "EditDurBox";
            this.EditDurBox.Size = new System.Drawing.Size(200, 20);
            this.EditDurBox.TabIndex = 10;
            // 
            // EditDurLabel
            // 
            this.EditDurLabel.AutoSize = true;
            this.EditDurLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDurLabel.Location = new System.Drawing.Point(677, 139);
            this.EditDurLabel.Name = "EditDurLabel";
            this.EditDurLabel.Size = new System.Drawing.Size(106, 19);
            this.EditDurLabel.TabIndex = 9;
            this.EditDurLabel.Text = "Длительность";
            // 
            // EditDescBox
            // 
            this.EditDescBox.Location = new System.Drawing.Point(861, 190);
            this.EditDescBox.Multiline = true;
            this.EditDescBox.Name = "EditDescBox";
            this.EditDescBox.Size = new System.Drawing.Size(200, 50);
            this.EditDescBox.TabIndex = 12;
            this.EditDescBox.TextChanged += new System.EventHandler(this.EditDescBox_TextChanged);
            // 
            // EditDescLabel
            // 
            this.EditDescLabel.AutoSize = true;
            this.EditDescLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDescLabel.Location = new System.Drawing.Point(677, 190);
            this.EditDescLabel.Name = "EditDescLabel";
            this.EditDescLabel.Size = new System.Drawing.Size(77, 19);
            this.EditDescLabel.TabIndex = 11;
            this.EditDescLabel.Text = "Описание";
            // 
            // EditDiscBox
            // 
            this.EditDiscBox.Location = new System.Drawing.Point(861, 268);
            this.EditDiscBox.Name = "EditDiscBox";
            this.EditDiscBox.Size = new System.Drawing.Size(200, 20);
            this.EditDiscBox.TabIndex = 15;
            // 
            // EditDiscLabel
            // 
            this.EditDiscLabel.AutoSize = true;
            this.EditDiscLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDiscLabel.Location = new System.Drawing.Point(677, 268);
            this.EditDiscLabel.Name = "EditDiscLabel";
            this.EditDiscLabel.Size = new System.Drawing.Size(55, 19);
            this.EditDiscLabel.TabIndex = 14;
            this.EditDiscLabel.Text = "Скидка";
            // 
            // EditPictureLabel
            // 
            this.EditPictureLabel.AutoSize = true;
            this.EditPictureLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPictureLabel.Location = new System.Drawing.Point(677, 321);
            this.EditPictureLabel.Name = "EditPictureLabel";
            this.EditPictureLabel.Size = new System.Drawing.Size(97, 19);
            this.EditPictureLabel.TabIndex = 16;
            this.EditPictureLabel.Text = "Изображение";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(861, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 120);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(755, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "(только буквы)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(786, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "(в минутах)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(772, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "(png, jpg, jpeg)";
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.EditRecordButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditRecordButton.Location = new System.Drawing.Point(670, 515);
            this.EditRecordButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(113, 28);
            this.EditRecordButton.TabIndex = 21;
            this.EditRecordButton.Text = "Сохранить";
            this.EditRecordButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(791, 515);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditRecordButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EditPictureLabel);
            this.Controls.Add(this.EditDiscBox);
            this.Controls.Add(this.EditDiscLabel);
            this.Controls.Add(this.EditDescBox);
            this.Controls.Add(this.EditDescLabel);
            this.Controls.Add(this.EditDurBox);
            this.Controls.Add(this.EditDurLabel);
            this.Controls.Add(this.EditCostBox);
            this.Controls.Add(this.EditCostLabel);
            this.Controls.Add(this.EditNameBox);
            this.Controls.Add(this.EditNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 290);
            this.Name = "Edit";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EditNameLabel;
        private System.Windows.Forms.TextBox EditNameBox;
        private System.Windows.Forms.TextBox EditCostBox;
        private System.Windows.Forms.Label EditCostLabel;
        private System.Windows.Forms.TextBox EditDurBox;
        private System.Windows.Forms.Label EditDurLabel;
        private System.Windows.Forms.TextBox EditDescBox;
        private System.Windows.Forms.Label EditDescLabel;
        private System.Windows.Forms.TextBox EditDiscBox;
        private System.Windows.Forms.Label EditDiscLabel;
        private System.Windows.Forms.Label EditPictureLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditRecordButton;
        private System.Windows.Forms.Button button1;
    }
}