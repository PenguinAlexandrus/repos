namespace Calculator
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
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.plusminus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.clear.Location = new System.Drawing.Point(52, 147);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(86, 73);
            this.clear.TabIndex = 0;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // backspace
            // 
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.backspace.Location = new System.Drawing.Point(144, 147);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(86, 73);
            this.backspace.TabIndex = 1;
            this.backspace.Text = "<-";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.plus.Location = new System.Drawing.Point(328, 147);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(86, 73);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // plusminus
            // 
            this.plusminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusminus.Location = new System.Drawing.Point(236, 147);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(86, 73);
            this.plusminus.TabIndex = 3;
            this.plusminus.Text = "+/-";
            this.plusminus.UseVisualStyleBackColor = true;
            this.plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.nine.Location = new System.Drawing.Point(236, 236);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(86, 73);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.minus.Location = new System.Drawing.Point(328, 236);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(86, 73);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.eight.Location = new System.Drawing.Point(144, 236);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(86, 73);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.seven.Location = new System.Drawing.Point(52, 236);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(86, 73);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.six.Location = new System.Drawing.Point(236, 325);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(86, 73);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.multiply.Location = new System.Drawing.Point(328, 325);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(86, 73);
            this.multiply.TabIndex = 10;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.five.Location = new System.Drawing.Point(144, 325);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(86, 73);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.four.Location = new System.Drawing.Point(52, 325);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(86, 73);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.three.Location = new System.Drawing.Point(236, 414);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(86, 73);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.divide.Location = new System.Drawing.Point(328, 414);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(86, 73);
            this.divide.TabIndex = 14;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.two.Location = new System.Drawing.Point(144, 414);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(86, 73);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.one.Location = new System.Drawing.Point(52, 414);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(86, 73);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.equal.Location = new System.Drawing.Point(236, 503);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(178, 73);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.dot.Location = new System.Drawing.Point(144, 503);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(86, 73);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.zero.Location = new System.Drawing.Point(52, 503);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(86, 73);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.input.Location = new System.Drawing.Point(52, 59);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(362, 62);
            this.input.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 606);
            this.Controls.Add(this.input);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.plusminus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button plusminus;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.TextBox input;
    }
}

