/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/17/2018
 * Time: 1:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BigInt
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNumber1 = new System.Windows.Forms.TextBox();
			this.txtNumber2 = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbSub = new System.Windows.Forms.RadioButton();
			this.rdbPlus = new System.Windows.Forms.RadioButton();
			this.btnCaculator = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(36, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number1";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Yellow;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(36, 140);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Number2";
			// 
			// txtNumber1
			// 
			this.txtNumber1.Location = new System.Drawing.Point(127, 44);
			this.txtNumber1.Name = "txtNumber1";
			this.txtNumber1.Size = new System.Drawing.Size(184, 22);
			this.txtNumber1.TabIndex = 2;
			this.txtNumber1.TextChanged += new System.EventHandler(this.TxtNumber1TextChanged);
			// 
			// txtNumber2
			// 
			this.txtNumber2.Location = new System.Drawing.Point(127, 146);
			this.txtNumber2.Name = "txtNumber2";
			this.txtNumber2.Size = new System.Drawing.Size(184, 22);
			this.txtNumber2.TabIndex = 3;
			this.txtNumber2.TextChanged += new System.EventHandler(this.TxtNumber2TextChanged);
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(127, 207);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(184, 22);
			this.txtResult.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(36, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(191, 10);
			this.label3.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Yellow;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(36, 201);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 28);
			this.label4.TabIndex = 6;
			this.label4.Text = "Result";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbSub);
			this.groupBox1.Controls.Add(this.rdbPlus);
			this.groupBox1.Location = new System.Drawing.Point(36, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(109, 52);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// rdbSub
			// 
			this.rdbSub.Location = new System.Drawing.Point(53, 21);
			this.rdbSub.Name = "rdbSub";
			this.rdbSub.Size = new System.Drawing.Size(41, 24);
			this.rdbSub.TabIndex = 1;
			this.rdbSub.Text = "-";
			this.rdbSub.UseVisualStyleBackColor = true;
			// 
			// rdbPlus
			// 
			this.rdbPlus.Checked = true;
			this.rdbPlus.Location = new System.Drawing.Point(6, 20);
			this.rdbPlus.Name = "rdbPlus";
			this.rdbPlus.Size = new System.Drawing.Size(41, 24);
			this.rdbPlus.TabIndex = 0;
			this.rdbPlus.TabStop = true;
			this.rdbPlus.Text = "+";
			this.rdbPlus.UseVisualStyleBackColor = true;
			// 
			// btnCaculator
			// 
			this.btnCaculator.Location = new System.Drawing.Point(36, 265);
			this.btnCaculator.Name = "btnCaculator";
			this.btnCaculator.Size = new System.Drawing.Size(94, 23);
			this.btnCaculator.TabIndex = 8;
			this.btnCaculator.Text = "Calculator";
			this.btnCaculator.UseVisualStyleBackColor = true;
			this.btnCaculator.Click += new System.EventHandler(this.BtnCaculatorClick);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(152, 265);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.ClientSize = new System.Drawing.Size(356, 321);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCaculator);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtNumber2);
			this.Controls.Add(this.txtNumber1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "BigInt";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnCaculator;
		private System.Windows.Forms.RadioButton rdbPlus;
		private System.Windows.Forms.RadioButton rdbSub;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.TextBox txtNumber2;
		private System.Windows.Forms.TextBox txtNumber1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
