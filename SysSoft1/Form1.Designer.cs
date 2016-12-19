using System.Drawing;

namespace SysSoft1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputDataBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.InputQueriesBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.OutputBtn = new System.Windows.Forms.Button();
            this.DoItBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputDataBtn
            // 
            this.InputDataBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputDataBtn.Location = new System.Drawing.Point(12, 52);
            this.InputDataBtn.Name = "InputDataBtn";
            this.InputDataBtn.Size = new System.Drawing.Size(758, 33);
            this.InputDataBtn.TabIndex = 0;
            this.InputDataBtn.Text = "Выбрать файл с данными";
            this.InputDataBtn.UseVisualStyleBackColor = true;
            this.InputDataBtn.Click += new System.EventHandler(this.InputDataBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(758, 34);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(758, 34);
            this.textBox2.TabIndex = 4;
            // 
            // InputQueriesBtn
            // 
            this.InputQueriesBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputQueriesBtn.Location = new System.Drawing.Point(12, 157);
            this.InputQueriesBtn.Name = "InputQueriesBtn";
            this.InputQueriesBtn.Size = new System.Drawing.Size(758, 33);
            this.InputQueriesBtn.TabIndex = 3;
            this.InputQueriesBtn.Text = "Выбрать файл с запросами";
            this.InputQueriesBtn.UseVisualStyleBackColor = true;
            this.InputQueriesBtn.Click += new System.EventHandler(this.InputQueriesBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(12, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(758, 34);
            this.textBox3.TabIndex = 6;
            // 
            // OutputBtn
            // 
            this.OutputBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputBtn.Location = new System.Drawing.Point(12, 264);
            this.OutputBtn.Name = "OutputBtn";
            this.OutputBtn.Size = new System.Drawing.Size(758, 33);
            this.OutputBtn.TabIndex = 5;
            this.OutputBtn.Text = "Выбрать файл для вывода";
            this.OutputBtn.UseVisualStyleBackColor = true;
            this.OutputBtn.Click += new System.EventHandler(this.OutputBtn_Click);
            // 
            // DoItBtn
            // 
            this.DoItBtn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoItBtn.Image = ((System.Drawing.Image)(resources.GetObject("DoItBtn.Image")));
            this.DoItBtn.Location = new System.Drawing.Point(12, 454);
            this.DoItBtn.Name = "DoItBtn";
            this.DoItBtn.Size = new System.Drawing.Size(758, 89);
            this.DoItBtn.TabIndex = 7;
            this.DoItBtn.UseVisualStyleBackColor = true;
            this.DoItBtn.Click += new System.EventHandler(this.DoItBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.DoItBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.OutputBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.InputQueriesBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InputDataBtn);
            this.Name = "Form1";
            this.Text = "Lab 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InputDataBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button InputQueriesBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button OutputBtn;
        private System.Windows.Forms.Button DoItBtn;
    }
}

