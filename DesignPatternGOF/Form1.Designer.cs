namespace DesignPatternGOF
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFacade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFacade
            // 
            this.buttonFacade.Location = new System.Drawing.Point(24, 24);
            this.buttonFacade.Name = "buttonFacade";
            this.buttonFacade.Size = new System.Drawing.Size(75, 23);
            this.buttonFacade.TabIndex = 0;
            this.buttonFacade.Text = "Фасад";
            this.buttonFacade.UseVisualStyleBackColor = true;
            this.buttonFacade.Click += new System.EventHandler(this.buttonFacade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 406);
            this.Controls.Add(this.buttonFacade);
            this.Name = "Form1";
            this.Text = "DesignPatternGOF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFacade;
    }
}

