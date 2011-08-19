using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexBase.MaterialBase
{
	public class Pop_Customer : COM.PCHWinForm.Pop_Medium
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_Zipno2;
		private System.Windows.Forms.TextBox txt_Zipno1;
		private System.Windows.Forms.TextBox txt_Faxno;
		private System.Windows.Forms.TextBox txt_Telno;
		private System.Windows.Forms.TextBox txt_Addr;
		private System.Windows.Forms.Label lbl_Zipno2;
		private System.Windows.Forms.Label lbl_Zipno1;
		private System.Windows.Forms.Label lbl_Faxno;
		private System.Windows.Forms.Label lbl_Telno;
		private System.Windows.Forms.Label lbl_Addr;
		private System.Windows.Forms.TextBox txt_UpCustcd;
		private System.Windows.Forms.TextBox txt_Customitnm;
		private System.Windows.Forms.TextBox txt_Itemnm;
		private System.Windows.Forms.TextBox txt_Uptnm;
		private System.Windows.Forms.TextBox txt_Custcd;
		private System.Windows.Forms.TextBox txt_Lawregno;
		private System.Windows.Forms.TextBox txt_Custname;
		private System.Windows.Forms.TextBox txt_Repjumin;
		private System.Windows.Forms.TextBox txt_Repnm;
		private System.Windows.Forms.TextBox txt_Entpregno;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label lbl_UpCustcd;
		private System.Windows.Forms.Label lbl_Itemnm;
		private System.Windows.Forms.Label lbl_Uptnm;
		private System.Windows.Forms.Label lbl_Lawregno;
		private System.Windows.Forms.Label lbl_Customitnm;
		private System.Windows.Forms.Label lbl_Custname;
		private System.Windows.Forms.Label lbl_Repjumin;
		private System.Windows.Forms.Label lbl_Entpregno;
		private System.Windows.Forms.Label lbl_Custcd;
		private System.Windows.Forms.Label lbl_Repnm;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.GroupBox groupBox3;
		private C1.Win.C1List.C1Combo cmb_UseYN;
		private C1.Win.C1List.C1Combo cmb_Returnyn;
		private C1.Win.C1List.C1Combo cmb_Baryn;
		private C1.Win.C1List.C1Combo cmb_Custpurtype;
		private System.Windows.Forms.TextBox txt_Mancust;
		private System.Windows.Forms.TextBox txt_Webcountcd;
		private System.Windows.Forms.TextBox txt_Webpass;
		private System.Windows.Forms.TextBox txt_Tradecust;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.TextBox txt_Email;
		private System.Windows.Forms.Label lbl_Webpass;
		private System.Windows.Forms.Label lbl_Email;
		private System.Windows.Forms.Label lbl_Webcountcd;
		private System.Windows.Forms.Label lbl_Mancust;
		private System.Windows.Forms.Label lbl_Tradecust;
		private System.Windows.Forms.Label lbl_Remarks;
		private System.Windows.Forms.Label lbl_Custpurtype;
		private System.Windows.Forms.Label lbl_Baryn;
		private System.Windows.Forms.Label lbl_Mancharge;
		private System.Windows.Forms.Label lbl_Returnyn;
		private System.Windows.Forms.Label lbl_UseYN;
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txt_Cashaccounttnm;
		private System.Windows.Forms.TextBox txt_Cashaccountno;
		private System.Windows.Forms.TextBox txt_Cashmovebankno;
		private System.Windows.Forms.TextBox txt_Paytime;
		private System.Windows.Forms.TextBox txt_Agttype;
		private System.Windows.Forms.TextBox txt_Paytype;
		private System.Windows.Forms.TextBox txt_Billaccounttnm;
		private System.Windows.Forms.TextBox txt_Billaccountno;
		private System.Windows.Forms.TextBox txt_Billmovebankno;
		private System.Windows.Forms.Label lbl_Cashaccounttnm;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_Cashaccountno;
		private System.Windows.Forms.Label label69;
		private System.Windows.Forms.Label label76;
		private System.Windows.Forms.Label lbl_Paytime;
		private System.Windows.Forms.Label lbl_Paytype;
		private System.Windows.Forms.Label lbl_Billaccounttnm;
		private System.Windows.Forms.Label lbl_Billaccountno;
		private System.Windows.Forms.TextBox txt_Mancharge;
		private System.Windows.Forms.Label btn_Mancharge;
		private C1.Win.C1List.C1Combo cmb_Mancharge;
		private System.ComponentModel.IContainer components = null;

		public Pop_Customer()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Customer));
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style65 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style66 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style67 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style68 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style69 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style70 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style71 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style72 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style73 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style74 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style75 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style76 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style77 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style78 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style79 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style80 = new C1.Win.C1List.Style();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Zipno2 = new System.Windows.Forms.TextBox();
            this.txt_Zipno1 = new System.Windows.Forms.TextBox();
            this.txt_Faxno = new System.Windows.Forms.TextBox();
            this.txt_Telno = new System.Windows.Forms.TextBox();
            this.txt_Addr = new System.Windows.Forms.TextBox();
            this.lbl_Zipno2 = new System.Windows.Forms.Label();
            this.lbl_Zipno1 = new System.Windows.Forms.Label();
            this.lbl_Faxno = new System.Windows.Forms.Label();
            this.lbl_Telno = new System.Windows.Forms.Label();
            this.lbl_Addr = new System.Windows.Forms.Label();
            this.txt_UpCustcd = new System.Windows.Forms.TextBox();
            this.txt_Customitnm = new System.Windows.Forms.TextBox();
            this.txt_Itemnm = new System.Windows.Forms.TextBox();
            this.txt_Uptnm = new System.Windows.Forms.TextBox();
            this.txt_Custcd = new System.Windows.Forms.TextBox();
            this.txt_Lawregno = new System.Windows.Forms.TextBox();
            this.txt_Custname = new System.Windows.Forms.TextBox();
            this.txt_Repjumin = new System.Windows.Forms.TextBox();
            this.txt_Repnm = new System.Windows.Forms.TextBox();
            this.txt_Entpregno = new System.Windows.Forms.TextBox();
            this.txt_Factory = new System.Windows.Forms.TextBox();
            this.lbl_UpCustcd = new System.Windows.Forms.Label();
            this.lbl_Itemnm = new System.Windows.Forms.Label();
            this.lbl_Uptnm = new System.Windows.Forms.Label();
            this.lbl_Lawregno = new System.Windows.Forms.Label();
            this.lbl_Customitnm = new System.Windows.Forms.Label();
            this.lbl_Custname = new System.Windows.Forms.Label();
            this.lbl_Repjumin = new System.Windows.Forms.Label();
            this.lbl_Entpregno = new System.Windows.Forms.Label();
            this.lbl_Custcd = new System.Windows.Forms.Label();
            this.lbl_Repnm = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_Mancharge = new C1.Win.C1List.C1Combo();
            this.cmb_UseYN = new C1.Win.C1List.C1Combo();
            this.cmb_Returnyn = new C1.Win.C1List.C1Combo();
            this.cmb_Baryn = new C1.Win.C1List.C1Combo();
            this.cmb_Custpurtype = new C1.Win.C1List.C1Combo();
            this.txt_Mancust = new System.Windows.Forms.TextBox();
            this.txt_Webcountcd = new System.Windows.Forms.TextBox();
            this.txt_Webpass = new System.Windows.Forms.TextBox();
            this.txt_Tradecust = new System.Windows.Forms.TextBox();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Webpass = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Webcountcd = new System.Windows.Forms.Label();
            this.lbl_Mancust = new System.Windows.Forms.Label();
            this.lbl_Tradecust = new System.Windows.Forms.Label();
            this.lbl_Remarks = new System.Windows.Forms.Label();
            this.lbl_Custpurtype = new System.Windows.Forms.Label();
            this.lbl_Baryn = new System.Windows.Forms.Label();
            this.lbl_Mancharge = new System.Windows.Forms.Label();
            this.lbl_Returnyn = new System.Windows.Forms.Label();
            this.lbl_UseYN = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Cashaccounttnm = new System.Windows.Forms.TextBox();
            this.txt_Cashaccountno = new System.Windows.Forms.TextBox();
            this.txt_Cashmovebankno = new System.Windows.Forms.TextBox();
            this.txt_Paytime = new System.Windows.Forms.TextBox();
            this.txt_Agttype = new System.Windows.Forms.TextBox();
            this.txt_Paytype = new System.Windows.Forms.TextBox();
            this.txt_Billaccounttnm = new System.Windows.Forms.TextBox();
            this.txt_Billaccountno = new System.Windows.Forms.TextBox();
            this.txt_Billmovebankno = new System.Windows.Forms.TextBox();
            this.lbl_Cashaccounttnm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Cashaccountno = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.lbl_Paytime = new System.Windows.Forms.Label();
            this.lbl_Paytype = new System.Windows.Forms.Label();
            this.lbl_Billaccounttnm = new System.Windows.Forms.Label();
            this.lbl_Billaccountno = new System.Windows.Forms.Label();
            this.txt_Mancharge = new System.Windows.Forms.TextBox();
            this.btn_Mancharge = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mancharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UseYN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Returnyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Baryn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Custpurtype)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Zipno2);
            this.groupBox1.Controls.Add(this.txt_Zipno1);
            this.groupBox1.Controls.Add(this.txt_Faxno);
            this.groupBox1.Controls.Add(this.txt_Telno);
            this.groupBox1.Controls.Add(this.txt_Addr);
            this.groupBox1.Controls.Add(this.lbl_Zipno2);
            this.groupBox1.Controls.Add(this.lbl_Zipno1);
            this.groupBox1.Controls.Add(this.lbl_Faxno);
            this.groupBox1.Controls.Add(this.lbl_Telno);
            this.groupBox1.Controls.Add(this.lbl_Addr);
            this.groupBox1.Controls.Add(this.txt_UpCustcd);
            this.groupBox1.Controls.Add(this.txt_Customitnm);
            this.groupBox1.Controls.Add(this.txt_Itemnm);
            this.groupBox1.Controls.Add(this.txt_Uptnm);
            this.groupBox1.Controls.Add(this.txt_Custcd);
            this.groupBox1.Controls.Add(this.txt_Lawregno);
            this.groupBox1.Controls.Add(this.txt_Custname);
            this.groupBox1.Controls.Add(this.txt_Repjumin);
            this.groupBox1.Controls.Add(this.txt_Repnm);
            this.groupBox1.Controls.Add(this.txt_Entpregno);
            this.groupBox1.Controls.Add(this.txt_Factory);
            this.groupBox1.Controls.Add(this.lbl_UpCustcd);
            this.groupBox1.Controls.Add(this.lbl_Itemnm);
            this.groupBox1.Controls.Add(this.lbl_Uptnm);
            this.groupBox1.Controls.Add(this.lbl_Lawregno);
            this.groupBox1.Controls.Add(this.lbl_Customitnm);
            this.groupBox1.Controls.Add(this.lbl_Custname);
            this.groupBox1.Controls.Add(this.lbl_Repjumin);
            this.groupBox1.Controls.Add(this.lbl_Entpregno);
            this.groupBox1.Controls.Add(this.lbl_Custcd);
            this.groupBox1.Controls.Add(this.lbl_Repnm);
            this.groupBox1.Controls.Add(this.lbl_Factory);
            this.groupBox1.Location = new System.Drawing.Point(5, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 151);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // txt_Zipno2
            // 
            this.txt_Zipno2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Zipno2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Zipno2.Location = new System.Drawing.Point(336, 122);
            this.txt_Zipno2.MaxLength = 13;
            this.txt_Zipno2.Name = "txt_Zipno2";
            this.txt_Zipno2.ReadOnly = true;
            this.txt_Zipno2.Size = new System.Drawing.Size(110, 21);
            this.txt_Zipno2.TabIndex = 439;
            this.txt_Zipno2.TabStop = false;
            // 
            // txt_Zipno1
            // 
            this.txt_Zipno1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Zipno1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Zipno1.Location = new System.Drawing.Point(108, 122);
            this.txt_Zipno1.MaxLength = 13;
            this.txt_Zipno1.Name = "txt_Zipno1";
            this.txt_Zipno1.ReadOnly = true;
            this.txt_Zipno1.Size = new System.Drawing.Size(110, 21);
            this.txt_Zipno1.TabIndex = 437;
            this.txt_Zipno1.TabStop = false;
            // 
            // txt_Faxno
            // 
            this.txt_Faxno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Faxno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Faxno.Location = new System.Drawing.Point(565, 100);
            this.txt_Faxno.MaxLength = 20;
            this.txt_Faxno.Name = "txt_Faxno";
            this.txt_Faxno.ReadOnly = true;
            this.txt_Faxno.Size = new System.Drawing.Size(110, 21);
            this.txt_Faxno.TabIndex = 435;
            this.txt_Faxno.TabStop = false;
            // 
            // txt_Telno
            // 
            this.txt_Telno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Telno.Location = new System.Drawing.Point(565, 122);
            this.txt_Telno.MaxLength = 20;
            this.txt_Telno.Name = "txt_Telno";
            this.txt_Telno.ReadOnly = true;
            this.txt_Telno.Size = new System.Drawing.Size(110, 21);
            this.txt_Telno.TabIndex = 433;
            this.txt_Telno.TabStop = false;
            // 
            // txt_Addr
            // 
            this.txt_Addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Addr.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Addr.Location = new System.Drawing.Point(108, 100);
            this.txt_Addr.MaxLength = 200;
            this.txt_Addr.Name = "txt_Addr";
            this.txt_Addr.ReadOnly = true;
            this.txt_Addr.Size = new System.Drawing.Size(338, 21);
            this.txt_Addr.TabIndex = 431;
            this.txt_Addr.TabStop = false;
            // 
            // lbl_Zipno2
            // 
            this.lbl_Zipno2.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Zipno2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Zipno2.ImageIndex = 0;
            this.lbl_Zipno2.ImageList = this.img_Label;
            this.lbl_Zipno2.Location = new System.Drawing.Point(235, 122);
            this.lbl_Zipno2.Name = "lbl_Zipno2";
            this.lbl_Zipno2.Size = new System.Drawing.Size(100, 21);
            this.lbl_Zipno2.TabIndex = 438;
            this.lbl_Zipno2.Text = "우편번호2";
            this.lbl_Zipno2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Zipno1
            // 
            this.lbl_Zipno1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Zipno1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Zipno1.ImageIndex = 0;
            this.lbl_Zipno1.ImageList = this.img_Label;
            this.lbl_Zipno1.Location = new System.Drawing.Point(7, 122);
            this.lbl_Zipno1.Name = "lbl_Zipno1";
            this.lbl_Zipno1.Size = new System.Drawing.Size(100, 21);
            this.lbl_Zipno1.TabIndex = 436;
            this.lbl_Zipno1.Text = "우편번호1";
            this.lbl_Zipno1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Faxno
            // 
            this.lbl_Faxno.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Faxno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Faxno.ImageIndex = 0;
            this.lbl_Faxno.ImageList = this.img_Label;
            this.lbl_Faxno.Location = new System.Drawing.Point(464, 100);
            this.lbl_Faxno.Name = "lbl_Faxno";
            this.lbl_Faxno.Size = new System.Drawing.Size(100, 21);
            this.lbl_Faxno.TabIndex = 434;
            this.lbl_Faxno.Text = "팩스번호";
            this.lbl_Faxno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Telno
            // 
            this.lbl_Telno.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Telno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Telno.ImageIndex = 0;
            this.lbl_Telno.ImageList = this.img_Label;
            this.lbl_Telno.Location = new System.Drawing.Point(464, 122);
            this.lbl_Telno.Name = "lbl_Telno";
            this.lbl_Telno.Size = new System.Drawing.Size(100, 21);
            this.lbl_Telno.TabIndex = 432;
            this.lbl_Telno.Text = "전화번호";
            this.lbl_Telno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Addr
            // 
            this.lbl_Addr.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Addr.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Addr.ImageIndex = 0;
            this.lbl_Addr.ImageList = this.img_Label;
            this.lbl_Addr.Location = new System.Drawing.Point(7, 100);
            this.lbl_Addr.Name = "lbl_Addr";
            this.lbl_Addr.Size = new System.Drawing.Size(100, 21);
            this.lbl_Addr.TabIndex = 430;
            this.lbl_Addr.Text = "주소";
            this.lbl_Addr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_UpCustcd
            // 
            this.txt_UpCustcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UpCustcd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_UpCustcd.Location = new System.Drawing.Point(565, 12);
            this.txt_UpCustcd.MaxLength = 10;
            this.txt_UpCustcd.Name = "txt_UpCustcd";
            this.txt_UpCustcd.ReadOnly = true;
            this.txt_UpCustcd.Size = new System.Drawing.Size(110, 21);
            this.txt_UpCustcd.TabIndex = 429;
            this.txt_UpCustcd.TabStop = false;
            // 
            // txt_Customitnm
            // 
            this.txt_Customitnm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Customitnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Customitnm.Location = new System.Drawing.Point(336, 34);
            this.txt_Customitnm.MaxLength = 100;
            this.txt_Customitnm.Name = "txt_Customitnm";
            this.txt_Customitnm.ReadOnly = true;
            this.txt_Customitnm.Size = new System.Drawing.Size(110, 21);
            this.txt_Customitnm.TabIndex = 420;
            this.txt_Customitnm.TabStop = false;
            // 
            // txt_Itemnm
            // 
            this.txt_Itemnm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Itemnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Itemnm.Location = new System.Drawing.Point(336, 78);
            this.txt_Itemnm.MaxLength = 30;
            this.txt_Itemnm.Name = "txt_Itemnm";
            this.txt_Itemnm.ReadOnly = true;
            this.txt_Itemnm.Size = new System.Drawing.Size(110, 21);
            this.txt_Itemnm.TabIndex = 426;
            this.txt_Itemnm.TabStop = false;
            // 
            // txt_Uptnm
            // 
            this.txt_Uptnm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Uptnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Uptnm.Location = new System.Drawing.Point(108, 78);
            this.txt_Uptnm.MaxLength = 30;
            this.txt_Uptnm.Name = "txt_Uptnm";
            this.txt_Uptnm.ReadOnly = true;
            this.txt_Uptnm.Size = new System.Drawing.Size(110, 21);
            this.txt_Uptnm.TabIndex = 424;
            this.txt_Uptnm.TabStop = false;
            // 
            // txt_Custcd
            // 
            this.txt_Custcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Custcd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Custcd.Location = new System.Drawing.Point(336, 12);
            this.txt_Custcd.MaxLength = 10;
            this.txt_Custcd.Name = "txt_Custcd";
            this.txt_Custcd.ReadOnly = true;
            this.txt_Custcd.Size = new System.Drawing.Size(110, 21);
            this.txt_Custcd.TabIndex = 415;
            this.txt_Custcd.TabStop = false;
            // 
            // txt_Lawregno
            // 
            this.txt_Lawregno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lawregno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Lawregno.Location = new System.Drawing.Point(108, 56);
            this.txt_Lawregno.MaxLength = 13;
            this.txt_Lawregno.Name = "txt_Lawregno";
            this.txt_Lawregno.ReadOnly = true;
            this.txt_Lawregno.Size = new System.Drawing.Size(110, 21);
            this.txt_Lawregno.TabIndex = 422;
            this.txt_Lawregno.TabStop = false;
            // 
            // txt_Custname
            // 
            this.txt_Custname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Custname.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Custname.Location = new System.Drawing.Point(108, 34);
            this.txt_Custname.MaxLength = 100;
            this.txt_Custname.Name = "txt_Custname";
            this.txt_Custname.ReadOnly = true;
            this.txt_Custname.Size = new System.Drawing.Size(110, 21);
            this.txt_Custname.TabIndex = 418;
            this.txt_Custname.TabStop = false;
            // 
            // txt_Repjumin
            // 
            this.txt_Repjumin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Repjumin.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Repjumin.Location = new System.Drawing.Point(565, 56);
            this.txt_Repjumin.MaxLength = 13;
            this.txt_Repjumin.Name = "txt_Repjumin";
            this.txt_Repjumin.ReadOnly = true;
            this.txt_Repjumin.Size = new System.Drawing.Size(110, 21);
            this.txt_Repjumin.TabIndex = 416;
            this.txt_Repjumin.TabStop = false;
            // 
            // txt_Repnm
            // 
            this.txt_Repnm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Repnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Repnm.Location = new System.Drawing.Point(336, 56);
            this.txt_Repnm.MaxLength = 100;
            this.txt_Repnm.Name = "txt_Repnm";
            this.txt_Repnm.ReadOnly = true;
            this.txt_Repnm.Size = new System.Drawing.Size(110, 21);
            this.txt_Repnm.TabIndex = 414;
            this.txt_Repnm.TabStop = false;
            // 
            // txt_Entpregno
            // 
            this.txt_Entpregno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Entpregno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Entpregno.Location = new System.Drawing.Point(565, 34);
            this.txt_Entpregno.MaxLength = 13;
            this.txt_Entpregno.Name = "txt_Entpregno";
            this.txt_Entpregno.ReadOnly = true;
            this.txt_Entpregno.Size = new System.Drawing.Size(110, 21);
            this.txt_Entpregno.TabIndex = 413;
            this.txt_Entpregno.TabStop = false;
            // 
            // txt_Factory
            // 
            this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Factory.Location = new System.Drawing.Point(108, 12);
            this.txt_Factory.MaxLength = 5;
            this.txt_Factory.Name = "txt_Factory";
            this.txt_Factory.ReadOnly = true;
            this.txt_Factory.Size = new System.Drawing.Size(110, 21);
            this.txt_Factory.TabIndex = 427;
            this.txt_Factory.TabStop = false;
            // 
            // lbl_UpCustcd
            // 
            this.lbl_UpCustcd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_UpCustcd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_UpCustcd.ImageIndex = 0;
            this.lbl_UpCustcd.ImageList = this.img_Label;
            this.lbl_UpCustcd.Location = new System.Drawing.Point(464, 12);
            this.lbl_UpCustcd.Name = "lbl_UpCustcd";
            this.lbl_UpCustcd.Size = new System.Drawing.Size(100, 21);
            this.lbl_UpCustcd.TabIndex = 428;
            this.lbl_UpCustcd.Text = "상위거래처코드";
            this.lbl_UpCustcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Itemnm
            // 
            this.lbl_Itemnm.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Itemnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Itemnm.ImageIndex = 0;
            this.lbl_Itemnm.ImageList = this.img_Label;
            this.lbl_Itemnm.Location = new System.Drawing.Point(235, 78);
            this.lbl_Itemnm.Name = "lbl_Itemnm";
            this.lbl_Itemnm.Size = new System.Drawing.Size(100, 21);
            this.lbl_Itemnm.TabIndex = 425;
            this.lbl_Itemnm.Text = "종목명";
            this.lbl_Itemnm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Uptnm
            // 
            this.lbl_Uptnm.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Uptnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Uptnm.ImageIndex = 0;
            this.lbl_Uptnm.ImageList = this.img_Label;
            this.lbl_Uptnm.Location = new System.Drawing.Point(7, 78);
            this.lbl_Uptnm.Name = "lbl_Uptnm";
            this.lbl_Uptnm.Size = new System.Drawing.Size(100, 21);
            this.lbl_Uptnm.TabIndex = 423;
            this.lbl_Uptnm.Text = "업태명";
            this.lbl_Uptnm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Lawregno
            // 
            this.lbl_Lawregno.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Lawregno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Lawregno.ImageIndex = 0;
            this.lbl_Lawregno.ImageList = this.img_Label;
            this.lbl_Lawregno.Location = new System.Drawing.Point(7, 56);
            this.lbl_Lawregno.Name = "lbl_Lawregno";
            this.lbl_Lawregno.Size = new System.Drawing.Size(100, 21);
            this.lbl_Lawregno.TabIndex = 421;
            this.lbl_Lawregno.Text = "법인등록번호";
            this.lbl_Lawregno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Customitnm
            // 
            this.lbl_Customitnm.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Customitnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Customitnm.ImageIndex = 0;
            this.lbl_Customitnm.ImageList = this.img_Label;
            this.lbl_Customitnm.Location = new System.Drawing.Point(235, 34);
            this.lbl_Customitnm.Name = "lbl_Customitnm";
            this.lbl_Customitnm.Size = new System.Drawing.Size(100, 21);
            this.lbl_Customitnm.TabIndex = 419;
            this.lbl_Customitnm.Text = "생략명";
            this.lbl_Customitnm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Custname
            // 
            this.lbl_Custname.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Custname.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Custname.ImageIndex = 0;
            this.lbl_Custname.ImageList = this.img_Label;
            this.lbl_Custname.Location = new System.Drawing.Point(7, 34);
            this.lbl_Custname.Name = "lbl_Custname";
            this.lbl_Custname.Size = new System.Drawing.Size(100, 21);
            this.lbl_Custname.TabIndex = 417;
            this.lbl_Custname.Text = "거래처명";
            this.lbl_Custname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Repjumin
            // 
            this.lbl_Repjumin.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Repjumin.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Repjumin.ImageIndex = 0;
            this.lbl_Repjumin.ImageList = this.img_Label;
            this.lbl_Repjumin.Location = new System.Drawing.Point(464, 56);
            this.lbl_Repjumin.Name = "lbl_Repjumin";
            this.lbl_Repjumin.Size = new System.Drawing.Size(100, 21);
            this.lbl_Repjumin.TabIndex = 412;
            this.lbl_Repjumin.Text = "대표자주민번호";
            this.lbl_Repjumin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Entpregno
            // 
            this.lbl_Entpregno.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Entpregno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Entpregno.ImageIndex = 0;
            this.lbl_Entpregno.ImageList = this.img_Label;
            this.lbl_Entpregno.Location = new System.Drawing.Point(464, 34);
            this.lbl_Entpregno.Name = "lbl_Entpregno";
            this.lbl_Entpregno.Size = new System.Drawing.Size(100, 21);
            this.lbl_Entpregno.TabIndex = 411;
            this.lbl_Entpregno.Text = "사업자등록번호";
            this.lbl_Entpregno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Custcd
            // 
            this.lbl_Custcd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Custcd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Custcd.ImageIndex = 0;
            this.lbl_Custcd.ImageList = this.img_Label;
            this.lbl_Custcd.Location = new System.Drawing.Point(235, 12);
            this.lbl_Custcd.Name = "lbl_Custcd";
            this.lbl_Custcd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Custcd.TabIndex = 410;
            this.lbl_Custcd.Text = "거래처코드";
            this.lbl_Custcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Repnm
            // 
            this.lbl_Repnm.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Repnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Repnm.ImageIndex = 0;
            this.lbl_Repnm.ImageList = this.img_Label;
            this.lbl_Repnm.Location = new System.Drawing.Point(235, 56);
            this.lbl_Repnm.Name = "lbl_Repnm";
            this.lbl_Repnm.Size = new System.Drawing.Size(100, 21);
            this.lbl_Repnm.TabIndex = 409;
            this.lbl_Repnm.Text = "대표자성명";
            this.lbl_Repnm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(7, 12);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 408;
            this.lbl_Factory.Text = "공장코드";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmb_Mancharge);
            this.groupBox3.Controls.Add(this.cmb_UseYN);
            this.groupBox3.Controls.Add(this.cmb_Returnyn);
            this.groupBox3.Controls.Add(this.cmb_Baryn);
            this.groupBox3.Controls.Add(this.cmb_Custpurtype);
            this.groupBox3.Controls.Add(this.txt_Mancust);
            this.groupBox3.Controls.Add(this.txt_Webcountcd);
            this.groupBox3.Controls.Add(this.txt_Webpass);
            this.groupBox3.Controls.Add(this.txt_Tradecust);
            this.groupBox3.Controls.Add(this.txt_Remarks);
            this.groupBox3.Controls.Add(this.txt_Email);
            this.groupBox3.Controls.Add(this.lbl_Webpass);
            this.groupBox3.Controls.Add(this.lbl_Email);
            this.groupBox3.Controls.Add(this.lbl_Webcountcd);
            this.groupBox3.Controls.Add(this.lbl_Mancust);
            this.groupBox3.Controls.Add(this.lbl_Tradecust);
            this.groupBox3.Controls.Add(this.lbl_Remarks);
            this.groupBox3.Controls.Add(this.lbl_Custpurtype);
            this.groupBox3.Controls.Add(this.lbl_Baryn);
            this.groupBox3.Controls.Add(this.lbl_Mancharge);
            this.groupBox3.Controls.Add(this.lbl_Returnyn);
            this.groupBox3.Controls.Add(this.lbl_UseYN);
            this.groupBox3.Location = new System.Drawing.Point(5, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 107);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // cmb_Mancharge
            // 
            this.cmb_Mancharge.AddItemCols = 0;
            this.cmb_Mancharge.AddItemSeparator = ';';
            this.cmb_Mancharge.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Mancharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Mancharge.Caption = "";
            this.cmb_Mancharge.CaptionHeight = 17;
            this.cmb_Mancharge.CaptionStyle = style41;
            this.cmb_Mancharge.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Mancharge.ColumnCaptionHeight = 18;
            this.cmb_Mancharge.ColumnFooterHeight = 18;
            this.cmb_Mancharge.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Mancharge.ContentHeight = 17;
            this.cmb_Mancharge.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Mancharge.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Mancharge.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mancharge.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Mancharge.EditorHeight = 17;
            this.cmb_Mancharge.EvenRowStyle = style42;
            this.cmb_Mancharge.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Mancharge.FooterStyle = style43;
            this.cmb_Mancharge.GapHeight = 2;
            this.cmb_Mancharge.HeadingStyle = style44;
            this.cmb_Mancharge.HighLightRowStyle = style45;
            this.cmb_Mancharge.ItemHeight = 15;
            this.cmb_Mancharge.Location = new System.Drawing.Point(565, 34);
            this.cmb_Mancharge.MatchEntryTimeout = ((long)(2000));
            this.cmb_Mancharge.MaxDropDownItems = ((short)(5));
            this.cmb_Mancharge.MaxLength = 1;
            this.cmb_Mancharge.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Mancharge.Name = "cmb_Mancharge";
            this.cmb_Mancharge.OddRowStyle = style46;
            this.cmb_Mancharge.PartialRightColumn = false;
            this.cmb_Mancharge.PropBag = resources.GetString("cmb_Mancharge.PropBag");
            this.cmb_Mancharge.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Mancharge.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Mancharge.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Mancharge.SelectedStyle = style47;
            this.cmb_Mancharge.Size = new System.Drawing.Size(110, 21);
            this.cmb_Mancharge.Style = style48;
            this.cmb_Mancharge.TabIndex = 434;
            // 
            // cmb_UseYN
            // 
            this.cmb_UseYN.AddItemCols = 0;
            this.cmb_UseYN.AddItemSeparator = ';';
            this.cmb_UseYN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_UseYN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_UseYN.Caption = "";
            this.cmb_UseYN.CaptionHeight = 17;
            this.cmb_UseYN.CaptionStyle = style49;
            this.cmb_UseYN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_UseYN.ColumnCaptionHeight = 18;
            this.cmb_UseYN.ColumnFooterHeight = 18;
            this.cmb_UseYN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_UseYN.ContentHeight = 17;
            this.cmb_UseYN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_UseYN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_UseYN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UseYN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_UseYN.EditorHeight = 17;
            this.cmb_UseYN.EvenRowStyle = style50;
            this.cmb_UseYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_UseYN.FooterStyle = style51;
            this.cmb_UseYN.GapHeight = 2;
            this.cmb_UseYN.HeadingStyle = style52;
            this.cmb_UseYN.HighLightRowStyle = style53;
            this.cmb_UseYN.ItemHeight = 15;
            this.cmb_UseYN.Location = new System.Drawing.Point(108, 78);
            this.cmb_UseYN.MatchEntryTimeout = ((long)(2000));
            this.cmb_UseYN.MaxDropDownItems = ((short)(5));
            this.cmb_UseYN.MaxLength = 1;
            this.cmb_UseYN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_UseYN.Name = "cmb_UseYN";
            this.cmb_UseYN.OddRowStyle = style54;
            this.cmb_UseYN.PartialRightColumn = false;
            this.cmb_UseYN.PropBag = resources.GetString("cmb_UseYN.PropBag");
            this.cmb_UseYN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_UseYN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_UseYN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_UseYN.SelectedStyle = style55;
            this.cmb_UseYN.Size = new System.Drawing.Size(110, 21);
            this.cmb_UseYN.Style = style56;
            this.cmb_UseYN.TabIndex = 9;
            this.cmb_UseYN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_UseYN_KeyPress);
            // 
            // cmb_Returnyn
            // 
            this.cmb_Returnyn.AddItemCols = 0;
            this.cmb_Returnyn.AddItemSeparator = ';';
            this.cmb_Returnyn.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Returnyn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Returnyn.Caption = "";
            this.cmb_Returnyn.CaptionHeight = 17;
            this.cmb_Returnyn.CaptionStyle = style57;
            this.cmb_Returnyn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Returnyn.ColumnCaptionHeight = 18;
            this.cmb_Returnyn.ColumnFooterHeight = 18;
            this.cmb_Returnyn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Returnyn.ContentHeight = 17;
            this.cmb_Returnyn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Returnyn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Returnyn.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Returnyn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Returnyn.EditorHeight = 17;
            this.cmb_Returnyn.EvenRowStyle = style58;
            this.cmb_Returnyn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Returnyn.FooterStyle = style59;
            this.cmb_Returnyn.GapHeight = 2;
            this.cmb_Returnyn.HeadingStyle = style60;
            this.cmb_Returnyn.HighLightRowStyle = style61;
            this.cmb_Returnyn.ItemHeight = 15;
            this.cmb_Returnyn.Location = new System.Drawing.Point(336, 34);
            this.cmb_Returnyn.MatchEntryTimeout = ((long)(2000));
            this.cmb_Returnyn.MaxDropDownItems = ((short)(5));
            this.cmb_Returnyn.MaxLength = 1;
            this.cmb_Returnyn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Returnyn.Name = "cmb_Returnyn";
            this.cmb_Returnyn.OddRowStyle = style62;
            this.cmb_Returnyn.PartialRightColumn = false;
            this.cmb_Returnyn.PropBag = resources.GetString("cmb_Returnyn.PropBag");
            this.cmb_Returnyn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Returnyn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Returnyn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Returnyn.SelectedStyle = style63;
            this.cmb_Returnyn.Size = new System.Drawing.Size(110, 21);
            this.cmb_Returnyn.Style = style64;
            this.cmb_Returnyn.TabIndex = 4;
            this.cmb_Returnyn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Returnyn_KeyPress);
            // 
            // cmb_Baryn
            // 
            this.cmb_Baryn.AddItemCols = 0;
            this.cmb_Baryn.AddItemSeparator = ';';
            this.cmb_Baryn.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Baryn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Baryn.Caption = "";
            this.cmb_Baryn.CaptionHeight = 17;
            this.cmb_Baryn.CaptionStyle = style65;
            this.cmb_Baryn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Baryn.ColumnCaptionHeight = 18;
            this.cmb_Baryn.ColumnFooterHeight = 18;
            this.cmb_Baryn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Baryn.ContentHeight = 17;
            this.cmb_Baryn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Baryn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Baryn.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Baryn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Baryn.EditorHeight = 17;
            this.cmb_Baryn.EvenRowStyle = style66;
            this.cmb_Baryn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Baryn.FooterStyle = style67;
            this.cmb_Baryn.GapHeight = 2;
            this.cmb_Baryn.HeadingStyle = style68;
            this.cmb_Baryn.HighLightRowStyle = style69;
            this.cmb_Baryn.ItemHeight = 15;
            this.cmb_Baryn.Location = new System.Drawing.Point(108, 34);
            this.cmb_Baryn.MatchEntryTimeout = ((long)(2000));
            this.cmb_Baryn.MaxDropDownItems = ((short)(5));
            this.cmb_Baryn.MaxLength = 1;
            this.cmb_Baryn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Baryn.Name = "cmb_Baryn";
            this.cmb_Baryn.OddRowStyle = style70;
            this.cmb_Baryn.PartialRightColumn = false;
            this.cmb_Baryn.PropBag = resources.GetString("cmb_Baryn.PropBag");
            this.cmb_Baryn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Baryn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Baryn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Baryn.SelectedStyle = style71;
            this.cmb_Baryn.Size = new System.Drawing.Size(110, 21);
            this.cmb_Baryn.Style = style72;
            this.cmb_Baryn.TabIndex = 3;
            this.cmb_Baryn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Baryn_KeyPress);
            // 
            // cmb_Custpurtype
            // 
            this.cmb_Custpurtype.AddItemCols = 0;
            this.cmb_Custpurtype.AddItemSeparator = ';';
            this.cmb_Custpurtype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Custpurtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Custpurtype.Caption = "";
            this.cmb_Custpurtype.CaptionHeight = 17;
            this.cmb_Custpurtype.CaptionStyle = style73;
            this.cmb_Custpurtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Custpurtype.ColumnCaptionHeight = 18;
            this.cmb_Custpurtype.ColumnFooterHeight = 18;
            this.cmb_Custpurtype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Custpurtype.ContentHeight = 17;
            this.cmb_Custpurtype.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Custpurtype.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Custpurtype.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Custpurtype.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Custpurtype.EditorHeight = 17;
            this.cmb_Custpurtype.EvenRowStyle = style74;
            this.cmb_Custpurtype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Custpurtype.FooterStyle = style75;
            this.cmb_Custpurtype.GapHeight = 2;
            this.cmb_Custpurtype.HeadingStyle = style76;
            this.cmb_Custpurtype.HighLightRowStyle = style77;
            this.cmb_Custpurtype.ItemHeight = 15;
            this.cmb_Custpurtype.Location = new System.Drawing.Point(336, 56);
            this.cmb_Custpurtype.MatchEntryTimeout = ((long)(2000));
            this.cmb_Custpurtype.MaxDropDownItems = ((short)(5));
            this.cmb_Custpurtype.MaxLength = 5;
            this.cmb_Custpurtype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Custpurtype.Name = "cmb_Custpurtype";
            this.cmb_Custpurtype.OddRowStyle = style78;
            this.cmb_Custpurtype.PartialRightColumn = false;
            this.cmb_Custpurtype.PropBag = resources.GetString("cmb_Custpurtype.PropBag");
            this.cmb_Custpurtype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Custpurtype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Custpurtype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Custpurtype.SelectedStyle = style79;
            this.cmb_Custpurtype.Size = new System.Drawing.Size(110, 21);
            this.cmb_Custpurtype.Style = style80;
            this.cmb_Custpurtype.TabIndex = 7;
            this.cmb_Custpurtype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Custpurtype_KeyPress);
            // 
            // txt_Mancust
            // 
            this.txt_Mancust.BackColor = System.Drawing.Color.White;
            this.txt_Mancust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mancust.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Mancust.Location = new System.Drawing.Point(565, 56);
            this.txt_Mancust.MaxLength = 30;
            this.txt_Mancust.Name = "txt_Mancust";
            this.txt_Mancust.Size = new System.Drawing.Size(110, 21);
            this.txt_Mancust.TabIndex = 8;
            this.txt_Mancust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mancust_KeyPress);
            // 
            // txt_Webcountcd
            // 
            this.txt_Webcountcd.BackColor = System.Drawing.Color.White;
            this.txt_Webcountcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Webcountcd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Webcountcd.Location = new System.Drawing.Point(108, 12);
            this.txt_Webcountcd.MaxLength = 6;
            this.txt_Webcountcd.Name = "txt_Webcountcd";
            this.txt_Webcountcd.Size = new System.Drawing.Size(110, 21);
            this.txt_Webcountcd.TabIndex = 0;
            this.txt_Webcountcd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Webcountcd_KeyPress);
            // 
            // txt_Webpass
            // 
            this.txt_Webpass.BackColor = System.Drawing.Color.White;
            this.txt_Webpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Webpass.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Webpass.Location = new System.Drawing.Point(336, 12);
            this.txt_Webpass.MaxLength = 20;
            this.txt_Webpass.Name = "txt_Webpass";
            this.txt_Webpass.Size = new System.Drawing.Size(110, 21);
            this.txt_Webpass.TabIndex = 1;
            this.txt_Webpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Webpass_KeyPress);
            // 
            // txt_Tradecust
            // 
            this.txt_Tradecust.BackColor = System.Drawing.Color.White;
            this.txt_Tradecust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Tradecust.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Tradecust.Location = new System.Drawing.Point(108, 56);
            this.txt_Tradecust.MaxLength = 30;
            this.txt_Tradecust.Name = "txt_Tradecust";
            this.txt_Tradecust.Size = new System.Drawing.Size(110, 21);
            this.txt_Tradecust.TabIndex = 6;
            this.txt_Tradecust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tradecust_KeyPress);
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.Color.White;
            this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Remarks.Location = new System.Drawing.Point(336, 78);
            this.txt_Remarks.MaxLength = 100;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(338, 21);
            this.txt_Remarks.TabIndex = 10;
            this.txt_Remarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Remarks_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.White;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Email.Location = new System.Drawing.Point(565, 12);
            this.txt_Email.MaxLength = 30;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(110, 21);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Email_KeyPress);
            // 
            // lbl_Webpass
            // 
            this.lbl_Webpass.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Webpass.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Webpass.ImageIndex = 1;
            this.lbl_Webpass.ImageList = this.img_Label;
            this.lbl_Webpass.Location = new System.Drawing.Point(235, 12);
            this.lbl_Webpass.Name = "lbl_Webpass";
            this.lbl_Webpass.Size = new System.Drawing.Size(100, 21);
            this.lbl_Webpass.TabIndex = 415;
            this.lbl_Webpass.Text = "Web비밀번호";
            this.lbl_Webpass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Email
            // 
            this.lbl_Email.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Email.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Email.ImageIndex = 1;
            this.lbl_Email.ImageList = this.img_Label;
            this.lbl_Email.Location = new System.Drawing.Point(464, 12);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(100, 21);
            this.lbl_Email.TabIndex = 417;
            this.lbl_Email.Text = "이메일";
            this.lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Webcountcd
            // 
            this.lbl_Webcountcd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Webcountcd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Webcountcd.ImageIndex = 1;
            this.lbl_Webcountcd.ImageList = this.img_Label;
            this.lbl_Webcountcd.Location = new System.Drawing.Point(7, 12);
            this.lbl_Webcountcd.Name = "lbl_Webcountcd";
            this.lbl_Webcountcd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Webcountcd.TabIndex = 433;
            this.lbl_Webcountcd.Text = "web거래처코드";
            this.lbl_Webcountcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Mancust
            // 
            this.lbl_Mancust.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Mancust.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Mancust.ImageIndex = 1;
            this.lbl_Mancust.ImageList = this.img_Label;
            this.lbl_Mancust.Location = new System.Drawing.Point(464, 56);
            this.lbl_Mancust.Name = "lbl_Mancust";
            this.lbl_Mancust.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mancust.TabIndex = 426;
            this.lbl_Mancust.Text = "업체담당자";
            this.lbl_Mancust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Tradecust
            // 
            this.lbl_Tradecust.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Tradecust.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Tradecust.ImageIndex = 1;
            this.lbl_Tradecust.ImageList = this.img_Label;
            this.lbl_Tradecust.Location = new System.Drawing.Point(7, 56);
            this.lbl_Tradecust.Name = "lbl_Tradecust";
            this.lbl_Tradecust.Size = new System.Drawing.Size(100, 21);
            this.lbl_Tradecust.TabIndex = 424;
            this.lbl_Tradecust.Text = "무역거래처";
            this.lbl_Tradecust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Remarks
            // 
            this.lbl_Remarks.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Remarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Remarks.ImageIndex = 1;
            this.lbl_Remarks.ImageList = this.img_Label;
            this.lbl_Remarks.Location = new System.Drawing.Point(235, 78);
            this.lbl_Remarks.Name = "lbl_Remarks";
            this.lbl_Remarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_Remarks.TabIndex = 422;
            this.lbl_Remarks.Text = "비고";
            this.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Custpurtype
            // 
            this.lbl_Custpurtype.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Custpurtype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Custpurtype.ImageIndex = 1;
            this.lbl_Custpurtype.ImageList = this.img_Label;
            this.lbl_Custpurtype.Location = new System.Drawing.Point(235, 56);
            this.lbl_Custpurtype.Name = "lbl_Custpurtype";
            this.lbl_Custpurtype.Size = new System.Drawing.Size(100, 21);
            this.lbl_Custpurtype.TabIndex = 421;
            this.lbl_Custpurtype.Text = "구매분류";
            this.lbl_Custpurtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Baryn
            // 
            this.lbl_Baryn.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Baryn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Baryn.ImageIndex = 1;
            this.lbl_Baryn.ImageList = this.img_Label;
            this.lbl_Baryn.Location = new System.Drawing.Point(7, 34);
            this.lbl_Baryn.Name = "lbl_Baryn";
            this.lbl_Baryn.Size = new System.Drawing.Size(100, 21);
            this.lbl_Baryn.TabIndex = 419;
            this.lbl_Baryn.Text = "바코드사용유무";
            this.lbl_Baryn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Mancharge
            // 
            this.lbl_Mancharge.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Mancharge.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Mancharge.ImageIndex = 1;
            this.lbl_Mancharge.ImageList = this.img_Label;
            this.lbl_Mancharge.Location = new System.Drawing.Point(464, 34);
            this.lbl_Mancharge.Name = "lbl_Mancharge";
            this.lbl_Mancharge.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mancharge.TabIndex = 428;
            this.lbl_Mancharge.Text = "담당사원";
            this.lbl_Mancharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Returnyn
            // 
            this.lbl_Returnyn.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Returnyn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Returnyn.ImageIndex = 1;
            this.lbl_Returnyn.ImageList = this.img_Label;
            this.lbl_Returnyn.Location = new System.Drawing.Point(235, 34);
            this.lbl_Returnyn.Name = "lbl_Returnyn";
            this.lbl_Returnyn.Size = new System.Drawing.Size(100, 21);
            this.lbl_Returnyn.TabIndex = 420;
            this.lbl_Returnyn.Text = "환급유무";
            this.lbl_Returnyn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UseYN
            // 
            this.lbl_UseYN.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_UseYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_UseYN.ImageIndex = 1;
            this.lbl_UseYN.ImageList = this.img_Label;
            this.lbl_UseYN.Location = new System.Drawing.Point(7, 78);
            this.lbl_UseYN.Name = "lbl_UseYN";
            this.lbl_UseYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_UseYN.TabIndex = 429;
            this.lbl_UseYN.Text = "사용여부";
            this.lbl_UseYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Save.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Save.ImageIndex = 11;
            this.btn_Save.ImageList = this.image_List;
            this.btn_Save.Location = new System.Drawing.Point(608, 392);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 23);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseDown);
            this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_Cashaccounttnm);
            this.groupBox2.Controls.Add(this.txt_Cashaccountno);
            this.groupBox2.Controls.Add(this.txt_Cashmovebankno);
            this.groupBox2.Controls.Add(this.txt_Paytime);
            this.groupBox2.Controls.Add(this.txt_Agttype);
            this.groupBox2.Controls.Add(this.txt_Paytype);
            this.groupBox2.Controls.Add(this.txt_Billaccounttnm);
            this.groupBox2.Controls.Add(this.txt_Billaccountno);
            this.groupBox2.Controls.Add(this.txt_Billmovebankno);
            this.groupBox2.Controls.Add(this.lbl_Cashaccounttnm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbl_Cashaccountno);
            this.groupBox2.Controls.Add(this.label69);
            this.groupBox2.Controls.Add(this.label76);
            this.groupBox2.Controls.Add(this.lbl_Paytime);
            this.groupBox2.Controls.Add(this.lbl_Paytype);
            this.groupBox2.Controls.Add(this.lbl_Billaccounttnm);
            this.groupBox2.Controls.Add(this.lbl_Billaccountno);
            this.groupBox2.Location = new System.Drawing.Point(5, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 88);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // txt_Cashaccounttnm
            // 
            this.txt_Cashaccounttnm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cashaccounttnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Cashaccounttnm.Location = new System.Drawing.Point(565, 34);
            this.txt_Cashaccounttnm.MaxLength = 10;
            this.txt_Cashaccounttnm.Name = "txt_Cashaccounttnm";
            this.txt_Cashaccounttnm.ReadOnly = true;
            this.txt_Cashaccounttnm.Size = new System.Drawing.Size(110, 21);
            this.txt_Cashaccounttnm.TabIndex = 429;
            this.txt_Cashaccounttnm.TabStop = false;
            // 
            // txt_Cashaccountno
            // 
            this.txt_Cashaccountno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cashaccountno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Cashaccountno.Location = new System.Drawing.Point(336, 34);
            this.txt_Cashaccountno.MaxLength = 20;
            this.txt_Cashaccountno.Name = "txt_Cashaccountno";
            this.txt_Cashaccountno.ReadOnly = true;
            this.txt_Cashaccountno.Size = new System.Drawing.Size(110, 21);
            this.txt_Cashaccountno.TabIndex = 416;
            this.txt_Cashaccountno.TabStop = false;
            // 
            // txt_Cashmovebankno
            // 
            this.txt_Cashmovebankno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cashmovebankno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Cashmovebankno.Location = new System.Drawing.Point(108, 34);
            this.txt_Cashmovebankno.MaxLength = 10;
            this.txt_Cashmovebankno.Name = "txt_Cashmovebankno";
            this.txt_Cashmovebankno.ReadOnly = true;
            this.txt_Cashmovebankno.Size = new System.Drawing.Size(110, 21);
            this.txt_Cashmovebankno.TabIndex = 414;
            this.txt_Cashmovebankno.TabStop = false;
            // 
            // txt_Paytime
            // 
            this.txt_Paytime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Paytime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Paytime.Location = new System.Drawing.Point(336, 12);
            this.txt_Paytime.MaxLength = 10;
            this.txt_Paytime.Name = "txt_Paytime";
            this.txt_Paytime.ReadOnly = true;
            this.txt_Paytime.Size = new System.Drawing.Size(110, 21);
            this.txt_Paytime.TabIndex = 425;
            this.txt_Paytime.TabStop = false;
            // 
            // txt_Agttype
            // 
            this.txt_Agttype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Agttype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Agttype.Location = new System.Drawing.Point(108, 12);
            this.txt_Agttype.MaxLength = 20;
            this.txt_Agttype.Name = "txt_Agttype";
            this.txt_Agttype.ReadOnly = true;
            this.txt_Agttype.Size = new System.Drawing.Size(110, 21);
            this.txt_Agttype.TabIndex = 426;
            this.txt_Agttype.TabStop = false;
            // 
            // txt_Paytype
            // 
            this.txt_Paytype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Paytype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Paytype.Location = new System.Drawing.Point(565, 12);
            this.txt_Paytype.MaxLength = 10;
            this.txt_Paytype.Name = "txt_Paytype";
            this.txt_Paytype.ReadOnly = true;
            this.txt_Paytype.Size = new System.Drawing.Size(110, 21);
            this.txt_Paytype.TabIndex = 423;
            this.txt_Paytype.TabStop = false;
            // 
            // txt_Billaccounttnm
            // 
            this.txt_Billaccounttnm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Billaccounttnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Billaccounttnm.Location = new System.Drawing.Point(565, 56);
            this.txt_Billaccounttnm.MaxLength = 30;
            this.txt_Billaccounttnm.Name = "txt_Billaccounttnm";
            this.txt_Billaccounttnm.ReadOnly = true;
            this.txt_Billaccounttnm.Size = new System.Drawing.Size(110, 21);
            this.txt_Billaccounttnm.TabIndex = 421;
            this.txt_Billaccounttnm.TabStop = false;
            // 
            // txt_Billaccountno
            // 
            this.txt_Billaccountno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Billaccountno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Billaccountno.Location = new System.Drawing.Point(336, 56);
            this.txt_Billaccountno.MaxLength = 20;
            this.txt_Billaccountno.Name = "txt_Billaccountno";
            this.txt_Billaccountno.ReadOnly = true;
            this.txt_Billaccountno.Size = new System.Drawing.Size(110, 21);
            this.txt_Billaccountno.TabIndex = 419;
            this.txt_Billaccountno.TabStop = false;
            // 
            // txt_Billmovebankno
            // 
            this.txt_Billmovebankno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Billmovebankno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Billmovebankno.Location = new System.Drawing.Point(108, 56);
            this.txt_Billmovebankno.MaxLength = 10;
            this.txt_Billmovebankno.Name = "txt_Billmovebankno";
            this.txt_Billmovebankno.ReadOnly = true;
            this.txt_Billmovebankno.Size = new System.Drawing.Size(110, 21);
            this.txt_Billmovebankno.TabIndex = 417;
            this.txt_Billmovebankno.TabStop = false;
            // 
            // lbl_Cashaccounttnm
            // 
            this.lbl_Cashaccounttnm.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Cashaccounttnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Cashaccounttnm.ImageIndex = 0;
            this.lbl_Cashaccounttnm.ImageList = this.img_Label;
            this.lbl_Cashaccounttnm.Location = new System.Drawing.Point(464, 34);
            this.lbl_Cashaccounttnm.Name = "lbl_Cashaccounttnm";
            this.lbl_Cashaccounttnm.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cashaccounttnm.TabIndex = 428;
            this.lbl_Cashaccounttnm.Text = "현금계좌명";
            this.lbl_Cashaccounttnm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(7, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 427;
            this.label3.Text = "어음계좌은행";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Cashaccountno
            // 
            this.lbl_Cashaccountno.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Cashaccountno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Cashaccountno.ImageIndex = 0;
            this.lbl_Cashaccountno.ImageList = this.img_Label;
            this.lbl_Cashaccountno.Location = new System.Drawing.Point(235, 34);
            this.lbl_Cashaccountno.Name = "lbl_Cashaccountno";
            this.lbl_Cashaccountno.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cashaccountno.TabIndex = 415;
            this.lbl_Cashaccountno.Text = "현금계좌번호";
            this.lbl_Cashaccountno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label69
            // 
            this.label69.BackColor = System.Drawing.SystemColors.Window;
            this.label69.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label69.ImageIndex = 0;
            this.label69.ImageList = this.img_Label;
            this.label69.Location = new System.Drawing.Point(7, 34);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(100, 21);
            this.label69.TabIndex = 413;
            this.label69.Text = "현금계좌은행";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label76
            // 
            this.label76.BackColor = System.Drawing.SystemColors.Window;
            this.label76.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label76.ImageIndex = 0;
            this.label76.ImageList = this.img_Label;
            this.label76.Location = new System.Drawing.Point(7, 12);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(100, 21);
            this.label76.TabIndex = 412;
            this.label76.Text = "거래처유형";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Paytime
            // 
            this.lbl_Paytime.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Paytime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Paytime.ImageIndex = 0;
            this.lbl_Paytime.ImageList = this.img_Label;
            this.lbl_Paytime.Location = new System.Drawing.Point(235, 12);
            this.lbl_Paytime.Name = "lbl_Paytime";
            this.lbl_Paytime.Size = new System.Drawing.Size(100, 21);
            this.lbl_Paytime.TabIndex = 424;
            this.lbl_Paytime.Text = "지불시기";
            this.lbl_Paytime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Paytype
            // 
            this.lbl_Paytype.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Paytype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Paytype.ImageIndex = 0;
            this.lbl_Paytype.ImageList = this.img_Label;
            this.lbl_Paytype.Location = new System.Drawing.Point(464, 56);
            this.lbl_Paytype.Name = "lbl_Paytype";
            this.lbl_Paytype.Size = new System.Drawing.Size(100, 21);
            this.lbl_Paytype.TabIndex = 422;
            this.lbl_Paytype.Text = "지불방법";
            this.lbl_Paytype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Billaccounttnm
            // 
            this.lbl_Billaccounttnm.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Billaccounttnm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Billaccounttnm.ImageIndex = 0;
            this.lbl_Billaccounttnm.ImageList = this.img_Label;
            this.lbl_Billaccounttnm.Location = new System.Drawing.Point(464, 12);
            this.lbl_Billaccounttnm.Name = "lbl_Billaccounttnm";
            this.lbl_Billaccounttnm.Size = new System.Drawing.Size(100, 21);
            this.lbl_Billaccounttnm.TabIndex = 420;
            this.lbl_Billaccounttnm.Text = "어음계좌명";
            this.lbl_Billaccounttnm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Billaccountno
            // 
            this.lbl_Billaccountno.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Billaccountno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Billaccountno.ImageIndex = 0;
            this.lbl_Billaccountno.ImageList = this.img_Label;
            this.lbl_Billaccountno.Location = new System.Drawing.Point(235, 56);
            this.lbl_Billaccountno.Name = "lbl_Billaccountno";
            this.lbl_Billaccountno.Size = new System.Drawing.Size(100, 21);
            this.lbl_Billaccountno.TabIndex = 418;
            this.lbl_Billaccountno.Text = "어음계좌번호";
            this.lbl_Billaccountno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Mancharge
            // 
            this.txt_Mancharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mancharge.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Mancharge.Location = new System.Drawing.Point(418, 392);
            this.txt_Mancharge.MaxLength = 30;
            this.txt_Mancharge.Name = "txt_Mancharge";
            this.txt_Mancharge.ReadOnly = true;
            this.txt_Mancharge.Size = new System.Drawing.Size(75, 21);
            this.txt_Mancharge.TabIndex = 434;
            this.txt_Mancharge.TabStop = false;
            this.txt_Mancharge.Visible = false;
            // 
            // btn_Mancharge
            // 
            this.btn_Mancharge.ImageIndex = 7;
            this.btn_Mancharge.ImageList = this.img_SmallButton;
            this.btn_Mancharge.Location = new System.Drawing.Point(494, 392);
            this.btn_Mancharge.Name = "btn_Mancharge";
            this.btn_Mancharge.Size = new System.Drawing.Size(18, 20);
            this.btn_Mancharge.TabIndex = 435;
            this.btn_Mancharge.Tag = "Return";
            this.btn_Mancharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Mancharge.Visible = false;
            this.btn_Mancharge.MouseLeave += new System.EventHandler(this.btn_Mancharge_MouseLeave);
            this.btn_Mancharge.Click += new System.EventHandler(this.btn_Mancharge_Click);
            this.btn_Mancharge.MouseHover += new System.EventHandler(this.btn_Mancharge_MouseHover);
            // 
            // Pop_Customer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Mancharge);
            this.Controls.Add(this.btn_Mancharge);
            this.Name = "Pop_Customer";
            this.Controls.SetChildIndex(this.btn_Mancharge, 0);
            this.Controls.SetChildIndex(this.txt_Mancharge, 0);
            this.Controls.SetChildIndex(this.btn_Save, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mancharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UseYN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Returnyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Baryn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Custpurtype)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private string _Factory,_Custcd;
		private string _Baryn,_Returnyn,_Custpurtype,_Mancharge,_UseYN;

		//save 했을 경우에만 메인 창 조회
		public bool _Close_Save = false;

		#endregion  

		#region 멤버 메서드
 

		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{
			try
			{
				//Title
				this.Text = "Vendor Master";
				lbl_MainTitle.Text = "Vendor Master";

				//영문변환 사용
				ClassLib.ComFunction.SetLangDic(this);

				_Factory				= ClassLib.ComVar.Parameter_PopUp[0];
				_Custcd					= ClassLib.ComVar.Parameter_PopUp[1];

				txt_Factory.Text		= ClassLib.ComVar.Parameter_PopUp[0];
				txt_Custcd.Text			= ClassLib.ComVar.Parameter_PopUp[1];
				txt_Entpregno.Text		= ClassLib.ComVar.Parameter_PopUp[2];
				txt_UpCustcd.Text		= ClassLib.ComVar.Parameter_PopUp[3];
				txt_Custname.Text		= ClassLib.ComVar.Parameter_PopUp[4];
				txt_Customitnm.Text		= ClassLib.ComVar.Parameter_PopUp[5];
				txt_Lawregno.Text		= ClassLib.ComVar.Parameter_PopUp[6];
				txt_Repnm.Text			= ClassLib.ComVar.Parameter_PopUp[7];
				txt_Repjumin.Text		= ClassLib.ComVar.Parameter_PopUp[8];
				txt_Uptnm.Text			= ClassLib.ComVar.Parameter_PopUp[9];
				txt_Itemnm.Text			= ClassLib.ComVar.Parameter_PopUp[10];
				txt_Agttype.Text		= ClassLib.ComVar.Parameter_PopUp[11];
				txt_Cashmovebankno.Text = ClassLib.ComVar.Parameter_PopUp[12];
				txt_Cashaccountno.Text	= ClassLib.ComVar.Parameter_PopUp[13];
				txt_Cashaccounttnm.Text = ClassLib.ComVar.Parameter_PopUp[14];
				txt_Billmovebankno.Text = ClassLib.ComVar.Parameter_PopUp[15];
				txt_Billaccountno.Text	= ClassLib.ComVar.Parameter_PopUp[16];
				txt_Billaccounttnm.Text = ClassLib.ComVar.Parameter_PopUp[17];
				txt_Addr.Text			= ClassLib.ComVar.Parameter_PopUp[18];
				txt_Telno.Text			= ClassLib.ComVar.Parameter_PopUp[19];
				txt_Faxno.Text			= ClassLib.ComVar.Parameter_PopUp[20];
				txt_Zipno1.Text			= ClassLib.ComVar.Parameter_PopUp[21];
				txt_Zipno2.Text			= ClassLib.ComVar.Parameter_PopUp[22];
				txt_Paytype.Text		= ClassLib.ComVar.Parameter_PopUp[23];
				txt_Paytime.Text		= ClassLib.ComVar.Parameter_PopUp[24];
				txt_Webcountcd.Text		= ClassLib.ComVar.Parameter_PopUp[25];
				txt_Webpass.Text		= ClassLib.ComVar.Parameter_PopUp[26];
				txt_Email.Text			= ClassLib.ComVar.Parameter_PopUp[27];
				_Baryn					= ClassLib.ComVar.Parameter_PopUp[28];
				_Returnyn				= ClassLib.ComVar.Parameter_PopUp[29];
				_Custpurtype			= ClassLib.ComVar.Parameter_PopUp[30];
				txt_Remarks.Text		= ClassLib.ComVar.Parameter_PopUp[31];
				txt_Tradecust.Text		= ClassLib.ComVar.Parameter_PopUp[32];
				txt_Mancust.Text		= ClassLib.ComVar.Parameter_PopUp[33];
				_Mancharge				= ClassLib.ComVar.Parameter_PopUp[34];
				_UseYN					= ClassLib.ComVar.Parameter_PopUp[35];

				// 컨트롤
				InitControls();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		/// <summary>
		/// 컨트롤
		/// </summary>
		private void InitControls()
		{
			DataTable dt_ret;

			//구매분류 콤보
			dt_ret = ClassLib.ComVar.Select_ComCode(_Factory, ClassLib.ComVar.CxPurDiv);
			//ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_Custpurtype,1, 2, false, ClassLib.ComVar.ComboList_Visible.Name); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Custpurtype, 1, 2, false, 0, 100);
			cmb_Custpurtype.Text = ClassLib.ComVar.Parameter_PopUp[30];
 
			//담당자 콤보
			dt_ret = ClassLib.ComFunction.Select_Man_Charge(_Factory); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Mancharge, 1, 2, false, 100, 0); 
			cmb_Mancharge.Text = ClassLib.ComVar.Parameter_PopUp[34];

			//Yes/No 콤보
			dt_ret = ClassLib.ComVar.Select_ComCode(_Factory, ClassLib.ComVar.CxUseYN); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Baryn, 1, 2, false, 0, 100); 
			 

			dt_ret = ClassLib.ComVar.Select_ComCode(_Factory, ClassLib.ComVar.CxUseYN); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Returnyn, 1, 2, false, 0, 100); 
			 

			dt_ret = ClassLib.ComVar.Select_ComCode(_Factory, ClassLib.ComVar.CxUseYN); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_UseYN, 1, 2, false, 0, 100); 
			 

//			//넘어온 데이타가 체크박스의 True/False 일때 Yes/No로 Convert
//			cmb_Baryn.SelectedValue       = Check_True_False(_Baryn);
//			cmb_Returnyn.SelectedValue    = Check_True_False(_Returnyn);
//			cmb_Custpurtype.SelectedValue = Check_True_False(_Custpurtype);
// 			cmb_Mancharge.SelectedValue   = Check_True_False(_Mancharge);
//			cmb_UseYN.SelectedValue       = Check_True_False(_UseYN);


			cmb_Baryn.SelectedValue = _Baryn;
			cmb_Returnyn.SelectedValue = _Returnyn;
			cmb_UseYN.SelectedValue = _UseYN;


			dt_ret.Dispose();
		}


		/// <summary>
		/// Check_True_False : 넘어온 데이타가 체크박스의 True/False 일때 Yes/No로 Convert
		/// </summary>
		/// <param name="arg_TrueFalse"></param>
		/// <returns></returns>
		public string Check_True_False(string arg_TrueFalse)
		{
			string ResultYN = null;
		
			if(arg_TrueFalse == "True")
			{
				ResultYN = "Y";
			}
			else
			{
				ResultYN = "N";
			}
			return ResultYN;
		}


		/// <summary>
		/// Close_Form : Form Close 시 작업
		/// </summary>
		private void Close_Form()
		{

  
			COM.ComVar.Parameter_PopUp = new string[] { ClassLib.ComFunction.Empty_TextBox(txt_Webcountcd, ""),
														ClassLib.ComFunction.Empty_TextBox(txt_Webpass, ""), 
														ClassLib.ComFunction.Empty_TextBox(txt_Email, ""),
														ClassLib.ComFunction.Empty_Combo(cmb_Baryn, ""),
														ClassLib.ComFunction.Empty_Combo(cmb_Returnyn, ""),
														ClassLib.ComFunction.Empty_Combo(cmb_Custpurtype, ""),
														ClassLib.ComFunction.Empty_TextBox(txt_Remarks, ""),
														ClassLib.ComFunction.Empty_TextBox(txt_Tradecust, ""),
														ClassLib.ComFunction.Empty_TextBox(txt_Mancust, ""),
														ClassLib.ComFunction.Empty_Combo(cmb_Mancharge, ""),
														ClassLib.ComFunction.Empty_Combo(cmb_UseYN, "") };


			this.Close();
		}
 

		#endregion 

		#region 이벤트 처리

		#region 이벤트_Enter키

		private void txt_Webcountcd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Webpass_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Email_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_Baryn_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_Returnyn_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_Mancharge_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Tradecust_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_Custpurtype_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Mancust_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_UseYN_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Remarks_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{
				Save_Data();
				Close_Form();
			}
		}

		#endregion 

		#region 이벤트_버튼 이미지 변경


		private void btn_Mancharge_MouseLeave(object sender, System.EventArgs e)
		{
			btn_Mancharge.ImageIndex = 7;
		} 
		
		private void btn_Mancharge_MouseHover(object sender, System.EventArgs e)
		{
			btn_Mancharge.ImageIndex = 6;
		}


		private void btn_Save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 11;
		}

		private void btn_Save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 10;
		}

		#endregion 

		private void btn_Mancharge_Click(object sender, System.EventArgs e)
		{
			Set_ManCharge();
		}


		/// <summary>
		/// Set_ManCharge : 인사 테이블에서 부서별 사원 검색해서 담당자 선택
		/// </summary>
		private void Set_ManCharge()
		{
			try
			{
//				Pop_DeptUser pop_form = new Pop_DeptUser();
//				pop_form.ShowDialog();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_ManCharge", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}




		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			Save_Data();
		}


		/// <summary>
		/// Save_Data : 저장
		/// </summary>
		private void Save_Data()
		{
			try
			{ 
				bool save_flag = false;

				save_flag = Save_Customer_Pop();

				if(save_flag)
				{ 
					_Close_Save = true;
					Close_Form();

					//메세지처리
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				else
				{
					//메세지처리
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
				}
				 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Data", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			} 
		}



		#endregion 

		#region DB Connect

		/// <summary>
		/// Save_Code : 저장
		/// </summary>
		private bool Save_Customer_Pop()
		{
			try
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(15); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SCM_CUST.SAVE_SCM_CUST_POP";
 
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2]  = "ARG_CUST_CD"; 
				MyOraDB.Parameter_Name[3]  = "ARG_WEB_CUST_CD";
				MyOraDB.Parameter_Name[4]  = "ARG_WEB_PASS";
				MyOraDB.Parameter_Name[5]  = "ARG_EMAIL";
				MyOraDB.Parameter_Name[6]  = "ARG_BAR_YN";
				MyOraDB.Parameter_Name[7]  = "ARG_RETURN_YN";
				MyOraDB.Parameter_Name[8]  = "ARG_CUST_PUR_TYPE";
				MyOraDB.Parameter_Name[9]  = "ARG_REMARKS";
				MyOraDB.Parameter_Name[10]  = "ARG_TRADE_CUST";
				MyOraDB.Parameter_Name[11]  = "ARG_MAN_CUST";
				MyOraDB.Parameter_Name[12]  = "ARG_MAN_CHARGE";
				MyOraDB.Parameter_Name[13]  = "ARG_USE_YN";
				MyOraDB.Parameter_Name[14]  = "ARG_UPD_USER";

				//03.DATA TYPE
				for (int i = 0; i <= 14; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			

				//04.DATA 정의  
				MyOraDB.Parameter_Values[0]   = "U";
				MyOraDB.Parameter_Values[1]   = txt_Factory.Text;//_Factory;
				MyOraDB.Parameter_Values[2]   = txt_Custcd.Text;//_Custcd;
				MyOraDB.Parameter_Values[3]   = ClassLib.ComFunction.Empty_TextBox(txt_Webcountcd, " ");
				MyOraDB.Parameter_Values[4]   = ClassLib.ComFunction.Empty_TextBox(txt_Webpass, " ");
				MyOraDB.Parameter_Values[5]   = ClassLib.ComFunction.Empty_TextBox(txt_Email, " ");
				MyOraDB.Parameter_Values[6]   = ClassLib.ComFunction.Empty_Combo(cmb_Baryn, " ");
				MyOraDB.Parameter_Values[7]   = ClassLib.ComFunction.Empty_Combo(cmb_Returnyn, " ");
				MyOraDB.Parameter_Values[8]   = ClassLib.ComFunction.Empty_Combo(cmb_Custpurtype, " ");
				MyOraDB.Parameter_Values[9]   = ClassLib.ComFunction.Empty_TextBox(txt_Remarks, " ");
				MyOraDB.Parameter_Values[10]  = ClassLib.ComFunction.Empty_TextBox(txt_Tradecust, " ");
				MyOraDB.Parameter_Values[11]  = ClassLib.ComFunction.Empty_TextBox(txt_Mancust, " ");
				MyOraDB.Parameter_Values[12]  = ClassLib.ComFunction.Empty_Combo(cmb_Mancharge, " ");
				MyOraDB.Parameter_Values[13]  = ClassLib.ComFunction.Empty_Combo(cmb_UseYN, " ");
				MyOraDB.Parameter_Values[14]  = ClassLib.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		
			
				//Error 처리
				if(ds_ret == null) 
					return false;
				else
					return true; 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Customer_Pop", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			} 

		}

		#endregion 



		
 
 

	}
}

