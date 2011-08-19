using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexMRP.MRP
{
	public class Pop_BM_Shipping_LeadTime : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_process;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_remarks;
		private System.Windows.Forms.TextBox txt_shipDays;

		private COM.OraDB MyOraDB = new COM.OraDB();

		public Pop_BM_Shipping_LeadTime()
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BM_Shipping_LeadTime));
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.lbl_process = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_shipDays = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(188, 60);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(259, 60);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 218;
            this.label1.Text = "Remarks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_remarks
            // 
            this.txt_remarks.BackColor = System.Drawing.SystemColors.Window;
            this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remarks.Font = new System.Drawing.Font("����", 9F);
            this.txt_remarks.Location = new System.Drawing.Point(109, 38);
            this.txt_remarks.MaxLength = 10;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(220, 21);
            this.txt_remarks.TabIndex = 2;
            // 
            // lbl_process
            // 
            this.lbl_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_process.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_process.ImageIndex = 0;
            this.lbl_process.ImageList = this.img_Label;
            this.lbl_process.Location = new System.Drawing.Point(8, 16);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(100, 21);
            this.lbl_process.TabIndex = 218;
            this.lbl_process.Text = "LeadTime";
            this.lbl_process.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_shipDays);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_apply);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_remarks);
            this.groupBox1.Controls.Add(this.lbl_process);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 94);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // txt_shipDays
            // 
            this.txt_shipDays.BackColor = System.Drawing.SystemColors.Window;
            this.txt_shipDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shipDays.Font = new System.Drawing.Font("����", 9F);
            this.txt_shipDays.Location = new System.Drawing.Point(109, 16);
            this.txt_shipDays.MaxLength = 10;
            this.txt_shipDays.Name = "txt_shipDays";
            this.txt_shipDays.Size = new System.Drawing.Size(220, 21);
            this.txt_shipDays.TabIndex = 1;
            // 
            // Pop_BM_Shipping_LeadTime
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(354, 141);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_BM_Shipping_LeadTime";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region ��Ʈ�� �̺�Ʈ ó��

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Btn_ApplyProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelProcess();
		}
	
		#region �Է��̵�
		
		#endregion

		#region ��ưȿ��

		#endregion

		#endregion

		#region �̺�Ʈ ó�� �޼���
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
			// ClassLib.ComFunction.Init_Form_Control(this);
			this.Text = "Data";
			lbl_MainTitle.Text = "Data";

            ClassLib.ComFunction.SetLangDic(this);

			txt_shipDays.Text = COM.ComVar.Parameter_PopUp[0];
			txt_remarks.Text = COM.ComVar.Parameter_PopUp[1];
		}

		private void Btn_ApplyProcess()
		{
			string vShipDays = txt_shipDays.Text;
			string vRemarks  = txt_remarks.Text;

			COM.ComVar.Parameter_PopUp = new string[]{vShipDays, vRemarks};
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_CancelProcess()
		{
			this.Close();
		}

		#endregion

	}
}

