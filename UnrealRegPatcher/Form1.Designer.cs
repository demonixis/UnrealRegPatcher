namespace UnrealRegPatcher
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txTargetName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            UEPathText = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(352, 78);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Install";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnButtonInstallClicked;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(271, 78);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Uninstall";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnButtonUninstallClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 15);
            label1.TabIndex = 2;
            label1.Text = "Unreal Target Name";
            // 
            // txTargetName
            // 
            txTargetName.Location = new System.Drawing.Point(165, 9);
            txTargetName.Name = "txTargetName";
            txTargetName.Size = new System.Drawing.Size(181, 23);
            txTargetName.TabIndex = 3;
            txTargetName.Text = "UnrealMeta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 39);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 15);
            label3.TabIndex = 5;
            label3.Text = "Custom Install Path";
            // 
            // UEPathText
            // 
            UEPathText.Location = new System.Drawing.Point(165, 39);
            UEPathText.Name = "UEPathText";
            UEPathText.Size = new System.Drawing.Size(181, 23);
            UEPathText.TabIndex = 6;
            UEPathText.Text = "c:\\";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(352, 39);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Choose Path";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnChooseClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(447, 122);
            Controls.Add(button3);
            Controls.Add(UEPathText);
            Controls.Add(label3);
            Controls.Add(txTargetName);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Unreal Engine Registry Patcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txTargetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UEPathText;
        private System.Windows.Forms.Button button3;
    }
}
