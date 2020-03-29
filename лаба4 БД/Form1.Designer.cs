namespace лаба4_БД
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
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxLocalShop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(146, 72);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(267, 21);
            this.comboBoxState.TabIndex = 0;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxState_SelectedIndexChanged);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(146, 115);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(267, 21);
            this.comboBoxCity.TabIndex = 1;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // comboBoxLocalShop
            // 
            this.comboBoxLocalShop.FormattingEnabled = true;
            this.comboBoxLocalShop.Location = new System.Drawing.Point(146, 161);
            this.comboBoxLocalShop.Name = "comboBoxLocalShop";
            this.comboBoxLocalShop.Size = new System.Drawing.Size(267, 21);
            this.comboBoxLocalShop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 263);
            this.Controls.Add(this.comboBoxLocalShop);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxLocalShop;
    }
}

