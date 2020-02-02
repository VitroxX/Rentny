namespace Generator
{
	// Token: 0x02000002 RID: 2
	public partial class Generator : global::MaterialSkin.Controls.MaterialForm
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002810 File Offset: 0x00000A10
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002848 File Offset: 0x00000A48
		private void InitializeComponent()
		{
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.button5 = new global::MaterialSkin.Controls.MaterialRaisedButton();
			this.button6 = new global::MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton1 = new global::MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton3 = new global::MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton4 = new global::MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton5 = new global::MaterialSkin.Controls.MaterialRaisedButton();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(-1, 70);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new global::System.Drawing.Size(804, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.dataGridView1.BackgroundColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new global::System.Drawing.Point(-1, 96);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new global::System.Drawing.Size(804, 294);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.textBox2.Location = new global::System.Drawing.Point(226, 396);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(577, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "Place Key Here for Black/Whitelisting/Delete";
			this.button5.Depth = 0;
			this.button5.Location = new global::System.Drawing.Point(226, 422);
			this.button5.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.button5.Name = "button5";
			this.button5.Primary = true;
			this.button5.Size = new global::System.Drawing.Size(577, 23);
			this.button5.TabIndex = 11;
			this.button5.Text = "Blacklist";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new global::System.EventHandler(this.button5_Click_1);
			this.button6.Depth = 0;
			this.button6.Location = new global::System.Drawing.Point(226, 451);
			this.button6.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.button6.Name = "button6";
			this.button6.Primary = true;
			this.button6.Size = new global::System.Drawing.Size(577, 23);
			this.button6.TabIndex = 12;
			this.button6.Text = "Whitelist";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new global::System.EventHandler(this.button6_Click_1);
			this.materialRaisedButton1.Depth = 0;
			this.materialRaisedButton1.Location = new global::System.Drawing.Point(144, 396);
			this.materialRaisedButton1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton1.Name = "materialRaisedButton1";
			this.materialRaisedButton1.Primary = true;
			this.materialRaisedButton1.Size = new global::System.Drawing.Size(76, 20);
			this.materialRaisedButton1.TabIndex = 15;
			this.materialRaisedButton1.Text = "Generate";
			this.materialRaisedButton1.UseVisualStyleBackColor = true;
			this.materialRaisedButton1.Click += new global::System.EventHandler(this.materialRaisedButton1_Click);
			this.materialRaisedButton3.Depth = 0;
			this.materialRaisedButton3.Location = new global::System.Drawing.Point(144, 451);
			this.materialRaisedButton3.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton3.Name = "materialRaisedButton3";
			this.materialRaisedButton3.Primary = true;
			this.materialRaisedButton3.Size = new global::System.Drawing.Size(75, 23);
			this.materialRaisedButton3.TabIndex = 17;
			this.materialRaisedButton3.Text = "Refresh";
			this.materialRaisedButton3.UseVisualStyleBackColor = true;
			this.materialRaisedButton3.Click += new global::System.EventHandler(this.materialRaisedButton3_Click);
			this.materialRaisedButton4.Depth = 0;
			this.materialRaisedButton4.Location = new global::System.Drawing.Point(1, 396);
			this.materialRaisedButton4.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton4.Name = "materialRaisedButton4";
			this.materialRaisedButton4.Primary = true;
			this.materialRaisedButton4.Size = new global::System.Drawing.Size(137, 78);
			this.materialRaisedButton4.TabIndex = 18;
			this.materialRaisedButton4.Text = "Remove Key";
			this.materialRaisedButton4.UseVisualStyleBackColor = true;
			this.materialRaisedButton4.Click += new global::System.EventHandler(this.materialRaisedButton4_Click);
			this.materialRaisedButton5.Depth = 0;
			this.materialRaisedButton5.Location = new global::System.Drawing.Point(144, 422);
			this.materialRaisedButton5.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton5.Name = "materialRaisedButton5";
			this.materialRaisedButton5.Primary = true;
			this.materialRaisedButton5.Size = new global::System.Drawing.Size(75, 23);
			this.materialRaisedButton5.TabIndex = 19;
			this.materialRaisedButton5.Text = "Add Key";
			this.materialRaisedButton5.UseVisualStyleBackColor = true;
			this.materialRaisedButton5.Click += new global::System.EventHandler(this.materialRaisedButton5_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(802, 480);
			base.Controls.Add(this.materialRaisedButton5);
			base.Controls.Add(this.materialRaisedButton4);
			base.Controls.Add(this.materialRaisedButton3);
			base.Controls.Add(this.materialRaisedButton1);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.dataGridView1);
			base.Controls.Add(this.textBox1);
			base.Name = "Generator";
			this.Text = "Generator";
			base.Load += new global::System.EventHandler(this.Generator_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000006 RID: 6
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400000A RID: 10
		private global::MaterialSkin.Controls.MaterialRaisedButton button5;

		// Token: 0x0400000B RID: 11
		private global::MaterialSkin.Controls.MaterialRaisedButton button6;

		// Token: 0x0400000C RID: 12
		private global::MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;

		// Token: 0x0400000D RID: 13
		private global::MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;

		// Token: 0x0400000E RID: 14
		private global::MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;

		// Token: 0x0400000F RID: 15
		private global::MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
	}
}
