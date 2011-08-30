using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlexTraining.Evaluation
{
	public class Form_Follow_Up_Head : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.ComponentModel.IContainer components = null;

		public Form_Follow_Up_Head()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Follow_Up_Head));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Location = new System.Drawing.Point(726, 4);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 664);
			this.stbar.Name = "stbar";
			this.stbar.Size = new System.Drawing.Size(1012, 22);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(642, 23);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.Controls.Add(this.panel7);
			this.c1Sizer1.Controls.Add(this.panel6);
			this.c1Sizer1.Controls.Add(this.panel5);
			this.c1Sizer1.Controls.Add(this.panel2);
			this.c1Sizer1.GridDefinition = "20.3333333333333:True:True;28:False:False;41.6666666666667:False:False;6.66666666" +
				"666667:False:True;\t58.6274509803922:True:False;40.1960784313725:True:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 80);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 600);
			this.c1Sizer1.TabIndex = 29;
			this.c1Sizer1.TabStop = false;
			this.c1Sizer1.Click += new System.EventHandler(this.c1Sizer1_Click);
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1012, 122);
			this.panel2.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Location = new System.Drawing.Point(4, 130);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(598, 422);
			this.panel5.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Location = new System.Drawing.Point(606, 130);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(410, 168);
			this.panel6.TabIndex = 2;
			// 
			// panel7
			// 
			this.panel7.Location = new System.Drawing.Point(606, 302);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(410, 250);
			this.panel7.TabIndex = 3;
			// 
			// Form_Follow_Up_Head
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1012, 686);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_Follow_Up_Head";
			this.Load += new System.EventHandler(this.Form_Follow_Up_Head_Load);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_Follow_Up_Head_Load(object sender, System.EventArgs e)
		{
		
		}

		private void c1Sizer1_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}

