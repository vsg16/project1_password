
namespace project1_password
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
            this.button_generate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Power_Al_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Low_reg_check = new System.Windows.Forms.CheckBox();
            this.high_regs_check = new System.Windows.Forms.CheckBox();
            this.Special_symbols_check = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Numbers_symbols_check = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_generate.Location = new System.Drawing.Point(137, 13);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(207, 54);
            this.button_generate.TabIndex = 0;
            this.button_generate.Text = "Сгенерировать пароль";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 36);
            this.textBox1.TabIndex = 1;
            // 
            // Power_Al_label
            // 
            this.Power_Al_label.AutoSize = true;
            this.Power_Al_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Power_Al_label.Location = new System.Drawing.Point(8, 8);
            this.Power_Al_label.Name = "Power_Al_label";
            this.Power_Al_label.Size = new System.Drawing.Size(225, 40);
            this.Power_Al_label.TabIndex = 2;
            this.Power_Al_label.Text = "Выберите метод генерации \r\nсимволов пароля:";
            this.Power_Al_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Power_Al_label.Click += new System.EventHandler(this.Power_Al_label_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 192);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 36);
            this.textBox2.TabIndex = 3;
            // 
            // Low_reg_check
            // 
            this.Low_reg_check.AutoSize = true;
            this.Low_reg_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Low_reg_check.Location = new System.Drawing.Point(12, 51);
            this.Low_reg_check.Name = "Low_reg_check";
            this.Low_reg_check.Size = new System.Drawing.Size(151, 24);
            this.Low_reg_check.TabIndex = 4;
            this.Low_reg_check.Text = "Нижний регистр";
            this.Low_reg_check.UseVisualStyleBackColor = true;
            this.Low_reg_check.CheckedChanged += new System.EventHandler(this.Low_reg_check_CheckedChanged);
            // 
            // high_regs_check
            // 
            this.high_regs_check.AutoSize = true;
            this.high_regs_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.high_regs_check.Location = new System.Drawing.Point(12, 81);
            this.high_regs_check.Name = "high_regs_check";
            this.high_regs_check.Size = new System.Drawing.Size(155, 24);
            this.high_regs_check.TabIndex = 5;
            this.high_regs_check.Text = "Верхний регистр";
            this.high_regs_check.UseVisualStyleBackColor = true;
            this.high_regs_check.CheckedChanged += new System.EventHandler(this.high_regs_check_CheckedChanged);
            // 
            // Special_symbols_check
            // 
            this.Special_symbols_check.AutoSize = true;
            this.Special_symbols_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Special_symbols_check.Location = new System.Drawing.Point(12, 111);
            this.Special_symbols_check.Name = "Special_symbols_check";
            this.Special_symbols_check.Size = new System.Drawing.Size(141, 24);
            this.Special_symbols_check.TabIndex = 6;
            this.Special_symbols_check.Text = "Спец. символы";
            this.Special_symbols_check.UseVisualStyleBackColor = true;
            this.Special_symbols_check.CheckedChanged += new System.EventHandler(this.Special_symbols_check_CheckedChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Numbers_symbols_check);
            this.panel1.Controls.Add(this.Power_Al_label);
            this.panel1.Controls.Add(this.high_regs_check);
            this.panel1.Controls.Add(this.Special_symbols_check);
            this.panel1.Controls.Add(this.Low_reg_check);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 185);
            this.panel1.TabIndex = 7;
            // 
            // Numbers_symbols_check
            // 
            this.Numbers_symbols_check.AutoSize = true;
            this.Numbers_symbols_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Numbers_symbols_check.Location = new System.Drawing.Point(12, 141);
            this.Numbers_symbols_check.Name = "Numbers_symbols_check";
            this.Numbers_symbols_check.Size = new System.Drawing.Size(76, 24);
            this.Numbers_symbols_check.TabIndex = 9;
            this.Numbers_symbols_check.Text = "Числа";
            this.Numbers_symbols_check.UseVisualStyleBackColor = true;
            this.Numbers_symbols_check.CheckedChanged += new System.EventHandler(this.Numbers_symbols_check_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_generate);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(282, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 242);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(139, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сгенерированный пароль:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Длина сгенерированного\r\nпароля:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Power_Al_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox Low_reg_check;
        private System.Windows.Forms.CheckBox high_regs_check;
        private System.Windows.Forms.CheckBox Special_symbols_check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Numbers_symbols_check;
    }
}

