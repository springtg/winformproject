using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace COM.SQMWinForm
{
	/// <summary>
	/// PopUp_Small�� ���� ��� �����Դϴ�.
	/// </summary>
	public class Pop_Small : System.Windows.Forms.Form
	{
		public System.Windows.Forms.ImageList img_Label;
		public System.Windows.Forms.ImageList img_Button;
		public System.Windows.Forms.Label lbl_MainTitle;
		public System.Windows.Forms.ImageList image_List;
		public System.Windows.Forms.ImageList img_Action;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.ComponentModel.IContainer components;

		public Pop_Small()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Small));
			this.img_Label = new System.Windows.Forms.ImageList(this.components);
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.lbl_MainTitle = new System.Windows.Forms.Label();
			this.image_List = new System.Windows.Forms.ImageList(this.components);
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Label.ImageSize = new System.Drawing.Size(100, 21);
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			this.img_Label.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(70, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_MainTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(240)), ((System.Byte)(247)), ((System.Byte)(255)));
			this.lbl_MainTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MainTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_MainTitle.Location = new System.Drawing.Point(40, 8);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(360, 23);
			this.lbl_MainTitle.TabIndex = 26;
			this.lbl_MainTitle.Text = "title";
			this.lbl_MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// image_List
			// 
			this.image_List.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.image_List.ImageSize = new System.Drawing.Size(80, 23);
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			this.image_List.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Pop_Small
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(394, 268);
			this.Controls.Add(this.lbl_MainTitle);
			this.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Pop_Small";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pop_Small"; 
			this.Closed += new System.EventHandler(this.Pop_Small_Closed);
			this.ResumeLayout(false);

		}
		#endregion

		 

		private void Pop_Small_Closed(object sender, System.EventArgs e)
		{
			
			//this.Dispose(true);
		}

		

	}
}
