namespace InventoryManeger
{
    partial class MainForm
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
            ProductListBtn = new Button();
            UserProductBtn = new Button();
            LogOutBtn = new Button();
            SuspendLayout();
            // 
            // ProductListBtn
            // 
            ProductListBtn.Location = new Point(145, 110);
            ProductListBtn.Name = "ProductListBtn";
            ProductListBtn.Size = new Size(445, 23);
            ProductListBtn.TabIndex = 0;
            ProductListBtn.Text = "ProductLists";
            ProductListBtn.UseVisualStyleBackColor = true;
            // 
            // UserProductBtn
            // 
            UserProductBtn.Location = new Point(145, 148);
            UserProductBtn.Name = "UserProductBtn";
            UserProductBtn.Size = new Size(445, 23);
            UserProductBtn.TabIndex = 1;
            UserProductBtn.Text = "MyProductList";
            UserProductBtn.UseVisualStyleBackColor = true;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.IndianRed;
            LogOutBtn.Location = new Point(145, 186);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(445, 37);
            LogOutBtn.TabIndex = 2;
            LogOutBtn.Text = "Log out";
            LogOutBtn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 329);
            Controls.Add(LogOutBtn);
            Controls.Add(UserProductBtn);
            Controls.Add(ProductListBtn);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ProductListBtn;
        private Button UserProductBtn;
        private Button LogOutBtn;
    }
}