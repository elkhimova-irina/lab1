using System;

namespace lab4
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
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonExact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoadFile.Location = new System.Drawing.Point(23, 74);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(192, 46);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "buttonLoadFile";
            this.buttonLoadFile.UseVisualStyleBackColor = false;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFileReadTime.Location = new System.Drawing.Point(234, 82);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(182, 31);
            this.textBoxFileReadTime.TabIndex = 2;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(234, 252);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(172, 31);
            this.textBoxFind.TabIndex = 4;
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxExactTime.Location = new System.Drawing.Point(234, 307);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(182, 31);
            this.textBoxExactTime.TabIndex = 6;
            // 
            // listBoxResult
            // 
            this.listBoxResult.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(462, 74);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(234, 129);
            this.listBoxResult.TabIndex = 8;
            // 
            // buttonExact
            // 
            this.buttonExact.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExact.Location = new System.Drawing.Point(23, 239);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(192, 57);
            this.buttonExact.TabIndex = 9;
            this.buttonExact.Text = "buttonExact";
            this.buttonExact.UseVisualStyleBackColor = false;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExact);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.buttonLoadFile);
            this.Name = "Form1";
            this.Text = "Elkhimova Irina IU5-33B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonExact;
        private EventHandler Form1_Load;

      //  public EventHandler buttonExact_Click { get; private set; }
    }
}

