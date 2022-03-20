
namespace Lr4._2
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.tBarA = new System.Windows.Forms.TrackBar();
            this.tBarB = new System.Windows.Forms.TrackBar();
            this.tBarC = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarC)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(98, 182);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(135, 22);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(309, 182);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(135, 22);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(521, 182);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(135, 22);
            this.textBoxC.TabIndex = 2;
            this.textBoxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(98, 229);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(135, 22);
            this.numericUpDownA.TabIndex = 3;
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(309, 228);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(135, 22);
            this.numericUpDownB.TabIndex = 4;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(521, 229);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(135, 22);
            this.numericUpDownC.TabIndex = 5;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // tBarA
            // 
            this.tBarA.Location = new System.Drawing.Point(98, 285);
            this.tBarA.Maximum = 100;
            this.tBarA.Name = "tBarA";
            this.tBarA.Size = new System.Drawing.Size(135, 56);
            this.tBarA.TabIndex = 6;
            this.tBarA.ValueChanged += new System.EventHandler(this.tBarA_ValueChanged);
            // 
            // tBarB
            // 
            this.tBarB.Location = new System.Drawing.Point(309, 285);
            this.tBarB.Maximum = 100;
            this.tBarB.Name = "tBarB";
            this.tBarB.Size = new System.Drawing.Size(135, 56);
            this.tBarB.TabIndex = 7;
            this.tBarB.ValueChanged += new System.EventHandler(this.tBarA_ValueChanged);
            // 
            // tBarC
            // 
            this.tBarC.Location = new System.Drawing.Point(521, 285);
            this.tBarC.Maximum = 100;
            this.tBarC.Name = "tBarC";
            this.tBarC.Size = new System.Drawing.Size(135, 56);
            this.tBarC.TabIndex = 8;
            this.tBarC.ValueChanged += new System.EventHandler(this.tBarA_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 52.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 101);
            this.label1.TabIndex = 9;
            this.label1.Text = "A <= B <= C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBarC);
            this.Controls.Add(this.tBarB);
            this.Controls.Add(this.tBarA);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.TrackBar tBarA;
        private System.Windows.Forms.TrackBar tBarB;
        private System.Windows.Forms.TrackBar tBarC;
        private System.Windows.Forms.Label label1;
    }
}

