﻿namespace WF_HW_2
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.Coordinates_bt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Coordinates_bt
            // 
            this.Coordinates_bt.BackColor = System.Drawing.Color.White;
            this.Coordinates_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Coordinates_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Coordinates_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Coordinates_bt.Location = new System.Drawing.Point(294, 76);
            this.Coordinates_bt.Name = "Coordinates_bt";
            this.Coordinates_bt.Size = new System.Drawing.Size(191, 53);
            this.Coordinates_bt.TabIndex = 0;
            this.Coordinates_bt.Text = "ЗАДАНИЕ 2";
            this.toolTip1.SetToolTip(this.Coordinates_bt, "Домашнее задание 1:\r\n\r\nКоординаты\r\n");
            this.Coordinates_bt.UseVisualStyleBackColor = false;
            this.Coordinates_bt.Click += new System.EventHandler(this.Coordinates_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "ВЫХОД";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Домашние задания по дисциплине WinForms";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(45, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "ЗАДАНИЕ 1";
            this.toolTip1.SetToolTip(this.button1, "Домашнее задание 1:\r\n\r\nКоординаты\r\n");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(537, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "ЗАДАНИЕ 3";
            this.toolTip1.SetToolTip(this.button3, "Домашнее задание 1:\r\n\r\nКоординаты\r\n");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(45, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "ЗАДАНИЕ 4";
            this.toolTip1.SetToolTip(this.button4, "Домашнее задание 1:\r\n\r\nКоординаты\r\n");
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Coordinates_bt);
            this.Name = "Menu";
            this.Text = "Меню Домашних работ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Coordinates_bt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

