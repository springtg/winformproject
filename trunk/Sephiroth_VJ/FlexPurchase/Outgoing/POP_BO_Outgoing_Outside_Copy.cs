using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
namespace FlexPurchase.Outgoing
{
	public class POP_BO_Outgoing_Outside_Copy : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤정의 및 리소스
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.GroupBox grp_group;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_factory_From;
		private System.Windows.Forms.Label lbl_workLine_From;
		private System.Windows.Forms.Label lbl_OutProcess_From;
		private System.Windows.Forms.Label lbl_OutDate_From;
		private System.Windows.Forms.Label lbl_OutNo_From;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbl_OutDate_To;
		private System.Windows.Forms.Label lbl_OutDivision_From;
		private System.Windows.Forms.Label cmb_OutNo_To;
		private System.Windows.Forms.DateTimePicker dpick_Target;
		private System.Windows.Forms.TextBox txtFactory;
		private System.Windows.Forms.TextBox txtDivision;
		private System.Windows.Forms.TextBox txtProcess;
		private System.Windows.Forms.TextBox txtLine;
		private System.Windows.Forms.DateTimePicker dpick_OutDate;
		private System.Windows.Forms.TextBox txtStyle;
		private System.Windows.Forms.DateTimePicker dpick_Last;
		private System.ComponentModel.IContainer components = null;

		public POP_BO_Outgoing_Outside_Copy()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			Init_Form();
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
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

		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POP_BO_Outgoing_Outside_Copy));
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.grp_group = new System.Windows.Forms.GroupBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.dpick_OutDate = new System.Windows.Forms.DateTimePicker();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.lbl_OutNo_From = new System.Windows.Forms.Label();
            this.lbl_factory_From = new System.Windows.Forms.Label();
            this.lbl_workLine_From = new System.Windows.Forms.Label();
            this.lbl_OutProcess_From = new System.Windows.Forms.Label();
            this.lbl_OutDivision_From = new System.Windows.Forms.Label();
            this.lbl_OutDate_From = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpick_Last = new System.Windows.Forms.DateTimePicker();
            this.cmb_OutNo_To = new System.Windows.Forms.Label();
            this.dpick_Target = new System.Windows.Forms.DateTimePicker();
            this.lbl_OutDate_To = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_group.SuspendLayout();
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(328, 23);
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
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(280, 288);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(72, 23);
            this.btn_close.TabIndex = 549;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(208, 288);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(72, 23);
            this.btn_apply.TabIndex = 548;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // grp_group
            // 
            this.grp_group.BackColor = System.Drawing.Color.Transparent;
            this.grp_group.Controls.Add(this.txtStyle);
            this.grp_group.Controls.Add(this.dpick_OutDate);
            this.grp_group.Controls.Add(this.txtLine);
            this.grp_group.Controls.Add(this.txtProcess);
            this.grp_group.Controls.Add(this.txtDivision);
            this.grp_group.Controls.Add(this.txtFactory);
            this.grp_group.Controls.Add(this.lbl_OutNo_From);
            this.grp_group.Controls.Add(this.lbl_factory_From);
            this.grp_group.Controls.Add(this.lbl_workLine_From);
            this.grp_group.Controls.Add(this.lbl_OutProcess_From);
            this.grp_group.Controls.Add(this.lbl_OutDivision_From);
            this.grp_group.Controls.Add(this.lbl_OutDate_From);
            this.grp_group.Controls.Add(this.label1);
            this.grp_group.Location = new System.Drawing.Point(8, 40);
            this.grp_group.Name = "grp_group";
            this.grp_group.Size = new System.Drawing.Size(344, 160);
            this.grp_group.TabIndex = 550;
            this.grp_group.TabStop = false;
            this.grp_group.Text = "Original Outgoing";
            // 
            // txtStyle
            // 
            this.txtStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStyle.Enabled = false;
            this.txtStyle.Font = new System.Drawing.Font("굴림", 9F);
            this.txtStyle.Location = new System.Drawing.Point(110, 126);
            this.txtStyle.MaxLength = 10;
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(216, 21);
            this.txtStyle.TabIndex = 565;
            // 
            // dpick_OutDate
            // 
            this.dpick_OutDate.CustomFormat = "";
            this.dpick_OutDate.Enabled = false;
            this.dpick_OutDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_OutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_OutDate.Location = new System.Drawing.Point(110, 38);
            this.dpick_OutDate.Name = "dpick_OutDate";
            this.dpick_OutDate.Size = new System.Drawing.Size(216, 21);
            this.dpick_OutDate.TabIndex = 564;
            this.dpick_OutDate.Value = new System.DateTime(2010, 1, 23, 16, 21, 18, 523);
            // 
            // txtLine
            // 
            this.txtLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLine.Enabled = false;
            this.txtLine.Font = new System.Drawing.Font("굴림", 9F);
            this.txtLine.Location = new System.Drawing.Point(110, 104);
            this.txtLine.MaxLength = 10;
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(216, 21);
            this.txtLine.TabIndex = 563;
            // 
            // txtProcess
            // 
            this.txtProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcess.Enabled = false;
            this.txtProcess.Font = new System.Drawing.Font("굴림", 9F);
            this.txtProcess.Location = new System.Drawing.Point(110, 82);
            this.txtProcess.MaxLength = 10;
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(216, 21);
            this.txtProcess.TabIndex = 562;
            // 
            // txtDivision
            // 
            this.txtDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDivision.Enabled = false;
            this.txtDivision.Font = new System.Drawing.Font("굴림", 9F);
            this.txtDivision.Location = new System.Drawing.Point(110, 60);
            this.txtDivision.MaxLength = 10;
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(216, 21);
            this.txtDivision.TabIndex = 561;
            // 
            // txtFactory
            // 
            this.txtFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFactory.Enabled = false;
            this.txtFactory.Font = new System.Drawing.Font("굴림", 9F);
            this.txtFactory.Location = new System.Drawing.Point(110, 16);
            this.txtFactory.MaxLength = 10;
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(216, 21);
            this.txtFactory.TabIndex = 560;
            // 
            // lbl_OutNo_From
            // 
            this.lbl_OutNo_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutNo_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutNo_From.ImageIndex = 1;
            this.lbl_OutNo_From.ImageList = this.img_Label;
            this.lbl_OutNo_From.Location = new System.Drawing.Point(8, 126);
            this.lbl_OutNo_From.Name = "lbl_OutNo_From";
            this.lbl_OutNo_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutNo_From.TabIndex = 558;
            this.lbl_OutNo_From.Text = "Style No.";
            this.lbl_OutNo_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory_From
            // 
            this.lbl_factory_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory_From.ImageIndex = 1;
            this.lbl_factory_From.ImageList = this.img_Label;
            this.lbl_factory_From.Location = new System.Drawing.Point(8, 16);
            this.lbl_factory_From.Name = "lbl_factory_From";
            this.lbl_factory_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory_From.TabIndex = 550;
            this.lbl_factory_From.Text = "Factory";
            this.lbl_factory_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_workLine_From
            // 
            this.lbl_workLine_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine_From.ImageIndex = 1;
            this.lbl_workLine_From.ImageList = this.img_Label;
            this.lbl_workLine_From.Location = new System.Drawing.Point(8, 104);
            this.lbl_workLine_From.Name = "lbl_workLine_From";
            this.lbl_workLine_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_workLine_From.TabIndex = 556;
            this.lbl_workLine_From.Text = "Work Line";
            this.lbl_workLine_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_OutProcess_From
            // 
            this.lbl_OutProcess_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutProcess_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutProcess_From.ImageIndex = 1;
            this.lbl_OutProcess_From.ImageList = this.img_Label;
            this.lbl_OutProcess_From.Location = new System.Drawing.Point(8, 82);
            this.lbl_OutProcess_From.Name = "lbl_OutProcess_From";
            this.lbl_OutProcess_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutProcess_From.TabIndex = 553;
            this.lbl_OutProcess_From.Text = "Out Process";
            this.lbl_OutProcess_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_OutDivision_From
            // 
            this.lbl_OutDivision_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutDivision_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutDivision_From.ImageIndex = 1;
            this.lbl_OutDivision_From.ImageList = this.img_Label;
            this.lbl_OutDivision_From.Location = new System.Drawing.Point(8, 60);
            this.lbl_OutDivision_From.Name = "lbl_OutDivision_From";
            this.lbl_OutDivision_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutDivision_From.TabIndex = 551;
            this.lbl_OutDivision_From.Text = "Out Division";
            this.lbl_OutDivision_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_OutDate_From
            // 
            this.lbl_OutDate_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutDate_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutDate_From.ImageIndex = 1;
            this.lbl_OutDate_From.ImageList = this.img_Label;
            this.lbl_OutDate_From.Location = new System.Drawing.Point(8, 38);
            this.lbl_OutDate_From.Name = "lbl_OutDate_From";
            this.lbl_OutDate_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutDate_From.TabIndex = 549;
            this.lbl_OutDate_From.Text = "Outgoing Date";
            this.lbl_OutDate_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Button;
            this.label1.Location = new System.Drawing.Point(576, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 557;
            this.label1.Text = "Apply";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dpick_Last);
            this.groupBox1.Controls.Add(this.cmb_OutNo_To);
            this.groupBox1.Controls.Add(this.dpick_Target);
            this.groupBox1.Controls.Add(this.lbl_OutDate_To);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(8, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 72);
            this.groupBox1.TabIndex = 551;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Outgoing";
            // 
            // dpick_Last
            // 
            this.dpick_Last.CustomFormat = "";
            this.dpick_Last.Enabled = false;
            this.dpick_Last.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_Last.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_Last.Location = new System.Drawing.Point(110, 16);
            this.dpick_Last.Name = "dpick_Last";
            this.dpick_Last.Size = new System.Drawing.Size(221, 21);
            this.dpick_Last.TabIndex = 559;
            this.dpick_Last.Value = new System.DateTime(2010, 1, 23, 16, 21, 18, 523);
            // 
            // cmb_OutNo_To
            // 
            this.cmb_OutNo_To.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.cmb_OutNo_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OutNo_To.ImageIndex = 1;
            this.cmb_OutNo_To.ImageList = this.img_Label;
            this.cmb_OutNo_To.Location = new System.Drawing.Point(8, 38);
            this.cmb_OutNo_To.Name = "cmb_OutNo_To";
            this.cmb_OutNo_To.Size = new System.Drawing.Size(100, 21);
            this.cmb_OutNo_To.TabIndex = 558;
            this.cmb_OutNo_To.Text = "Target Out Date";
            this.cmb_OutNo_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_Target
            // 
            this.dpick_Target.CustomFormat = "";
            this.dpick_Target.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_Target.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_Target.Location = new System.Drawing.Point(110, 38);
            this.dpick_Target.Name = "dpick_Target";
            this.dpick_Target.Size = new System.Drawing.Size(221, 21);
            this.dpick_Target.TabIndex = 548;
            this.dpick_Target.Value = new System.DateTime(2010, 1, 23, 16, 21, 18, 523);
            // 
            // lbl_OutDate_To
            // 
            this.lbl_OutDate_To.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutDate_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutDate_To.ImageIndex = 1;
            this.lbl_OutDate_To.ImageList = this.img_Label;
            this.lbl_OutDate_To.Location = new System.Drawing.Point(8, 16);
            this.lbl_OutDate_To.Name = "lbl_OutDate_To";
            this.lbl_OutDate_To.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutDate_To.TabIndex = 549;
            this.lbl_OutDate_To.Text = "Last Out Date";
            this.lbl_OutDate_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label7.ImageIndex = 0;
            this.label7.ImageList = this.img_Button;
            this.label7.Location = new System.Drawing.Point(576, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 557;
            this.label7.Text = "Apply";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // POP_BO_Outgoing_Outside_Copy
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(362, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_group);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_apply);
            this.Name = "POP_BO_Outgoing_Outside_Copy";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_close, 0);
            this.Controls.SetChildIndex(this.grp_group, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.grp_group.ResumeLayout(false);
            this.grp_group.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB   = new COM.OraDB();
		private string _LotNo;
        private string _LotSeq;

		#endregion 
		
		#region 버튼이벤트
		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		
		private void btn_apply_Click(object sender, System.EventArgs e)
		{   
			
			try
			{ 
				DialogResult result = new DialogResult(); 

				result = ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
				if ( result.ToString() == "Yes")
				{
					bool run_flag = SAVE_SBO_OUT_COPY();
 
					if(run_flag)
					{
						ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsEndRun, this);
						this.Close();
					}
					else
					{
						ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsDoNotRun, this);
					}  
				}
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
				
			}	


		}


		private void btn_Outno_Click(object sender, System.EventArgs e)
		{
			
		}




		#endregion 

		#region 공통메쏘드

		private void Init_Form()
		{


            this.Text = "Outgoing Outside Copy";
            lbl_MainTitle.Text = "Outgoing Outside Copy";
            ClassLib.ComFunction.SetLangDic(this);


			txtFactory.Text    = ClassLib.ComVar.Parameter_PopUp_Object[0].ToString();
			txtDivision.Text   = ClassLib.ComVar.Parameter_PopUp_Object[1].ToString();
			dpick_OutDate.Text = ClassLib.ComVar.Parameter_PopUp_Object[2].ToString();
			txtProcess.Text    = ClassLib.ComVar.Parameter_PopUp_Object[4].ToString();
			txtLine.Text       = ClassLib.ComVar.Parameter_PopUp_Object[5].ToString();
			txtStyle.Text      = ClassLib.ComVar.Parameter_PopUp_Object[6].ToString(); 
			_LotNo             = ClassLib.ComVar.Parameter_PopUp_Object[7].ToString(); 
			_LotSeq            = ClassLib.ComVar.Parameter_PopUp_Object[8].ToString();  

			bindData();

		}


		private void bindData()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				DataTable vDt = this.SELECT_SBO_OUT_EXPEND_DATE();

				if ( vDt != null )
				{
					dpick_Last.Value = ClassLib.ComFunction.StringToDateTime(vDt.Rows[0].ItemArray[0].ToString());
					dpick_Target.Value = ClassLib.ComFunction.StringToDateTime(vDt.Rows[0].ItemArray[1].ToString());

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				ClassLib.ComFunction.User_Message(ex.Message, "bindData", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		
		#endregion 

		#region DB관리 

		/// <summary>
		/// SELECT_SBO_OUT_EXPEND_DATE
		/// </summary>
		private DataTable SELECT_SBO_OUT_EXPEND_DATE ()
		{

			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_EXPEND.SELECT_SBO_EXPEND_DATE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_PROCESS";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[5] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";  

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor; 

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = txtFactory.Text;
			MyOraDB.Parameter_Values[1] = txtProcess.Text;
			MyOraDB.Parameter_Values[2] = txtLine.Text;
			MyOraDB.Parameter_Values[3] = txtStyle.Text;
			MyOraDB.Parameter_Values[4] = _LotNo;
			MyOraDB.Parameter_Values[5] = _LotSeq;
			MyOraDB.Parameter_Values[6] = "";  

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null; 
			if(ds_ret.Tables.Count == 0) return null; 

			return ds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// SAVE_SBO_OUT_COPY :  불출 복사
		/// </summary>
		public bool SAVE_SBO_OUT_COPY()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_EXPEND.SAVE_SBO_OUT_COPY";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_DATE";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_PROCESS";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[6] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[7] = "ARG_COPY_DATE";
			MyOraDB.Parameter_Name[8] = "ARG_UPD_USER";


			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = txtFactory.Text;
			MyOraDB.Parameter_Values[1] = dpick_OutDate.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = txtProcess.Text;
			MyOraDB.Parameter_Values[3] = txtLine.Text;
			MyOraDB.Parameter_Values[4] = txtStyle.Text;
			MyOraDB.Parameter_Values[5] = _LotNo;
			MyOraDB.Parameter_Values[6] = _LotSeq;
			MyOraDB.Parameter_Values[7] = dpick_Target.Text.Replace("-","");
            MyOraDB.Parameter_Values[8] = ClassLib.ComVar.This_User;


			
			MyOraDB.Add_Modify_Parameter(true);
			vds_ret = MyOraDB.Exe_Modify_Procedure(); 

			if(vds_ret == null)
			{
				return false;
			}
			else
			{
				return true;
			}

		}


		#endregion  



 
	}
}

