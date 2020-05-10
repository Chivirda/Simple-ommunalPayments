namespace CommunalPaymenstUI
{
    partial class MainForm
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(15, 69);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainLabel.Size = new System.Drawing.Size(142, 22);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Текущий тариф";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CatalogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CatalogToolStripMenuItem
            // 
            this.CatalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HousesToolStripMenuItem,
            this.RoomsToolStripMenuItem,
            this.RatesToolStripMenuItem});
            this.CatalogToolStripMenuItem.Name = "CatalogToolStripMenuItem";
            this.CatalogToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.CatalogToolStripMenuItem.Text = "Справочники";
            // 
            // HousesToolStripMenuItem
            // 
            this.HousesToolStripMenuItem.Name = "HousesToolStripMenuItem";
            this.HousesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.HousesToolStripMenuItem.Text = "Дома";
            // 
            // RoomsToolStripMenuItem
            // 
            this.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem";
            this.RoomsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.RoomsToolStripMenuItem.Text = "Помещения";
            // 
            // RatesToolStripMenuItem
            // 
            this.RatesToolStripMenuItem.Name = "RatesToolStripMenuItem";
            this.RatesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.RatesToolStripMenuItem.Text = "Тарифы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Simple Communal Payments";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RatesToolStripMenuItem;
    }
}

