namespace DinamicMemory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtValue = new TextBox();
            btnAdd = new Button();
            lstValue = new ListBox();
            label1 = new Label();
            btnEliminate = new Button();
            btnModify = new Button();
            btnShow = new Button();
            SuspendLayout();
            // 
            // txtValue
            // 
            txtValue.Location = new Point(117, 60);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(100, 23);
            txtValue.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(223, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstValue
            // 
            lstValue.FormattingEnabled = true;
            lstValue.ItemHeight = 15;
            lstValue.Location = new Point(320, 60);
            lstValue.Name = "lstValue";
            lstValue.Size = new Size(120, 94);
            lstValue.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 63);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter the numbers";
            // 
            // btnEliminate
            // 
            btnEliminate.Location = new Point(223, 89);
            btnEliminate.Name = "btnEliminate";
            btnEliminate.Size = new Size(75, 23);
            btnEliminate.TabIndex = 4;
            btnEliminate.Text = "Eliminate";
            btnEliminate.UseVisualStyleBackColor = true;
            btnEliminate.Click += btnEliminate_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(223, 118);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 5;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(223, 147);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 450);
            Controls.Add(btnShow);
            Controls.Add(btnModify);
            Controls.Add(btnEliminate);
            Controls.Add(label1);
            Controls.Add(lstValue);
            Controls.Add(btnAdd);
            Controls.Add(txtValue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValue;
        private Button btnAdd;
        private ListBox lstValue;
        private Label label1;
        private Button btnEliminate;
        private Button btnModify;
        private Button btnShow;
    }
}
