namespace Activation
{
    partial class Whitelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Whitelist));
            this.Button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textfield = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Depth = 0;
            this.Button.Location = new System.Drawing.Point(89, 157);
            this.Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button.Name = "Button";
            this.Button.Primary = true;
            this.Button.Size = new System.Drawing.Size(253, 29);
            this.Button.TabIndex = 0;
            this.Button.Text = "Login";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // textfield
            // 
            this.textfield.Depth = 0;
            this.textfield.Hint = "";
            this.textfield.Location = new System.Drawing.Point(12, 72);
            this.textfield.MouseState = MaterialSkin.MouseState.HOVER;
            this.textfield.Name = "textfield";
            this.textfield.PasswordChar = '\0';
            this.textfield.SelectedText = "";
            this.textfield.SelectionLength = 0;
            this.textfield.SelectionStart = 0;
            this.textfield.Size = new System.Drawing.Size(414, 23);
            this.textfield.TabIndex = 1;
            this.textfield.Text = "Put the whitelist key here lol";
            this.textfield.UseSystemPasswordChar = false;
            // 
            // Whitelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 240);
            this.Controls.Add(this.textfield);
            this.Controls.Add(this.Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Whitelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nemesis";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton Button;
        private MaterialSkin.Controls.MaterialSingleLineTextField textfield;
    }
}

