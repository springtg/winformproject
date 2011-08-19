using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Stock
{
	public class Pop_BK_CodeChange : COM.PCHWinForm.Pop_Normal
	{
		#region 디자이너에서 생성한 변수

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Spec;
		private System.Windows.Forms.TextBox txt_Date;
		private System.Windows.Forms.TextBox txt_ItemName;
		private System.Windows.Forms.TextBox txt_ItemCode;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label lbl_Item;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label btn_Search;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 생성한 변수

		private string _Division = "";
		private string _Factory = "";
		private string _Date = "";
		private string _ItemCode = "";
		private string _ItemName = "";
		private string _SpecCode = "";
		private string _SpecName = "";
		private string _ColorCode = "";
		private string _ColorName = "";
		private System.Windows.Forms.Label lbl_ItemS;
		private System.Windows.Forms.Label lbl_ItemT;
		private System.Windows.Forms.TextBox txt_ItemNameT;
		private System.Windows.Forms.TextBox txt_ItemCodeT; 

		# endregion

	    #region 생성자 / 소멸자

		public Pop_BK_CodeChange()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Pop_BK_CodeChange(string[] arg_parameter)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
			_Division  = arg_parameter[0];
			_Factory   = arg_parameter[1];
		    _Date      = arg_parameter[2];
			_ItemCode  = arg_parameter[3];
			_ItemName  = arg_parameter[4]; 
			_SpecCode  = arg_parameter[5];
			_SpecName  = arg_parameter[6]; 
			_ColorCode = arg_parameter[7];
			_ColorName = arg_parameter[8]; 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BK_CodeChange));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ItemS = new System.Windows.Forms.Label();
            this.lbl_Spec = new System.Windows.Forms.Label();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.txt_ItemCode = new System.Windows.Forms.TextBox();
            this.txt_Factory = new System.Windows.Forms.TextBox();
            this.lbl_Item = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Label();
            this.txt_ItemNameT = new System.Windows.Forms.TextBox();
            this.txt_ItemCodeT = new System.Windows.Forms.TextBox();
            this.lbl_ItemT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ItemS);
            this.groupBox1.Controls.Add(this.lbl_Spec);
            this.groupBox1.Controls.Add(this.txt_Date);
            this.groupBox1.Controls.Add(this.txt_ItemName);
            this.groupBox1.Controls.Add(this.txt_ItemCode);
            this.groupBox1.Controls.Add(this.txt_Factory);
            this.groupBox1.Controls.Add(this.lbl_Item);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 88);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // lbl_ItemS
            // 
            this.lbl_ItemS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ItemS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemS.ImageIndex = 0;
            this.lbl_ItemS.ImageList = this.img_Label;
            this.lbl_ItemS.Location = new System.Drawing.Point(8, 60);
            this.lbl_ItemS.Name = "lbl_ItemS";
            this.lbl_ItemS.Size = new System.Drawing.Size(100, 21);
            this.lbl_ItemS.TabIndex = 580;
            this.lbl_ItemS.Text = "Item";
            this.lbl_ItemS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Spec
            // 
            this.lbl_Spec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Spec.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Spec.ImageIndex = 0;
            this.lbl_Spec.ImageList = this.img_Label;
            this.lbl_Spec.Location = new System.Drawing.Point(8, 38);
            this.lbl_Spec.Name = "lbl_Spec";
            this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
            this.lbl_Spec.TabIndex = 579;
            this.lbl_Spec.Text = "Date";
            this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Date
            // 
            this.txt_Date.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Date.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Date.Location = new System.Drawing.Point(109, 38);
            this.txt_Date.MaxLength = 10;
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.Size = new System.Drawing.Size(70, 21);
            this.txt_Date.TabIndex = 576;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ItemName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ItemName.Location = new System.Drawing.Point(180, 60);
            this.txt_ItemName.MaxLength = 100;
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.ReadOnly = true;
            this.txt_ItemName.Size = new System.Drawing.Size(276, 21);
            this.txt_ItemName.TabIndex = 575;
            // 
            // txt_ItemCode
            // 
            this.txt_ItemCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ItemCode.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ItemCode.Location = new System.Drawing.Point(109, 60);
            this.txt_ItemCode.MaxLength = 10;
            this.txt_ItemCode.Name = "txt_ItemCode";
            this.txt_ItemCode.ReadOnly = true;
            this.txt_ItemCode.Size = new System.Drawing.Size(70, 21);
            this.txt_ItemCode.TabIndex = 574;
            // 
            // txt_Factory
            // 
            this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Factory.Location = new System.Drawing.Point(109, 16);
            this.txt_Factory.MaxLength = 10;
            this.txt_Factory.Name = "txt_Factory";
            this.txt_Factory.ReadOnly = true;
            this.txt_Factory.Size = new System.Drawing.Size(70, 21);
            this.txt_Factory.TabIndex = 572;
            // 
            // lbl_Item
            // 
            this.lbl_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item.ImageIndex = 0;
            this.lbl_Item.ImageList = this.img_Label;
            this.lbl_Item.Location = new System.Drawing.Point(8, 16);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item.TabIndex = 180;
            this.lbl_Item.Text = "Factory";
            this.lbl_Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(416, 192);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 23);
            this.btn_Cancel.TabIndex = 354;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(344, 192);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(71, 23);
            this.btn_Apply.TabIndex = 355;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_ItemNameT);
            this.groupBox2.Controls.Add(this.txt_ItemCodeT);
            this.groupBox2.Controls.Add(this.lbl_ItemT);
            this.groupBox2.Location = new System.Drawing.Point(7, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 48);
            this.groupBox2.TabIndex = 582;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target";
            // 
            // btn_Search
            // 
            this.btn_Search.ImageIndex = 27;
            this.btn_Search.ImageList = this.img_SmallButton;
            this.btn_Search.Location = new System.Drawing.Point(448, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(23, 23);
            this.btn_Search.TabIndex = 677;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_ItemNameT
            // 
            this.txt_ItemNameT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ItemNameT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ItemNameT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ItemNameT.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ItemNameT.Location = new System.Drawing.Point(180, 16);
            this.txt_ItemNameT.MaxLength = 100;
            this.txt_ItemNameT.Name = "txt_ItemNameT";
            this.txt_ItemNameT.ReadOnly = true;
            this.txt_ItemNameT.Size = new System.Drawing.Size(268, 21);
            this.txt_ItemNameT.TabIndex = 575;
            // 
            // txt_ItemCodeT
            // 
            this.txt_ItemCodeT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ItemCodeT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ItemCodeT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ItemCodeT.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ItemCodeT.Location = new System.Drawing.Point(109, 16);
            this.txt_ItemCodeT.MaxLength = 10;
            this.txt_ItemCodeT.Name = "txt_ItemCodeT";
            this.txt_ItemCodeT.ReadOnly = true;
            this.txt_ItemCodeT.Size = new System.Drawing.Size(70, 21);
            this.txt_ItemCodeT.TabIndex = 574;
            // 
            // lbl_ItemT
            // 
            this.lbl_ItemT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ItemT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemT.ImageIndex = 0;
            this.lbl_ItemT.ImageList = this.img_Label;
            this.lbl_ItemT.Location = new System.Drawing.Point(8, 16);
            this.lbl_ItemT.Name = "lbl_ItemT";
            this.lbl_ItemT.Size = new System.Drawing.Size(100, 21);
            this.lbl_ItemT.TabIndex = 180;
            this.lbl_ItemT.Text = "Factory";
            this.lbl_ItemT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_BK_CodeChange
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(494, 223);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "Pop_BK_CodeChange";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.btn_Apply, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
            // Form Setting 
            ClassLib.ComFunction.SetLangDic(this); 

			string title = "Incoming Code Change";

			lbl_MainTitle.Text = title;
			this.Text = title;

			txt_Factory.Text = _Factory;
			txt_Date.Text = _Date;
 
			if(_Division == "I")
			{
				title = "Incoming Item Code Change";
				lbl_ItemS.Text = "Item";
				lbl_ItemT.Text = "Item";  
				
				txt_ItemCode.Text = _ItemCode;
				txt_ItemName.Text = _ItemName; 
			}
			else if(_Division == "S")
			{
				title = "Incoming Spec Code Change";
				lbl_ItemS.Text = "Spec";
				lbl_ItemT.Text = "Spec";  
				
				txt_ItemCode.Text = _SpecCode;
				txt_ItemName.Text = _SpecName; 
			}
			else if(_Division == "C")
			{
				title = "Incoming Color Code Change";
				lbl_ItemS.Text = "Color";
				lbl_ItemT.Text = "Color";  
				txt_ItemCode.Text = _ColorCode;
				txt_ItemName.Text = _ColorName; 
			}

		}



		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		#endregion

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp = null; 
			this.Dispose();
			this.Close();
		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			Show_Item_Popup();
		}

		/// <summary>
		/// Show_Item_Popup : Item 기타 데이터 입력하는 팝업 실행 : Item/ Specification/ Color
		/// </summary>
		private void Show_Item_Popup()
		{
			try
			{
				 
//				string item_cd = _ItemCd; 
//				string item_name = _ItemName; 
//				string spec_cd = _SpecCd; 
//				string spec_name = _SpecName; 
//				string color_cd = _ColorCd; 
//				string color_name = _ColorName; 
//				string unit = _Unit;  
//				string size_yn = "N"; 
				bool default_view = false;
 

				ClassLib.ComVar.Parameter_PopUp = null; 

				//----------------------------------------------------------------------------------------------------------------------------
				// 선택 항목 바로 설정할 수 있도록 팝업 창 페이지 초기 설정
				//----------------------------------------------------------------------------------------------------------------------------
				string select = "";
				
				if(_Division == "I")
				{
					select = "Item";
				}
				else if(_Division == "S")
				{
					select = "Spec";
				}
				else if(_Division == "C")
				{
					select = "Color";
				} 

				COM.ComVar.Parameter_PopUp = new string[] { select };
				//----------------------------------------------------------------------------------------------------------------------------


				FlexBase.MaterialBase.Pop_Item_List pop_form = new FlexBase.MaterialBase.Pop_Item_List("", "", "", "", "", "", "", "", default_view);
				pop_form.ShowDialog();


				//----------------------------------------------------------------------------------------------------------------------------
				// New Data Setting
				//---------------------------------------------------------------------------------------------------------------------------- 
				bool same_flag = false;

				if(_Division == "I")
				{

					same_flag = (txt_ItemCode.Text == ClassLib.ComVar.Parameter_PopUp[0]) ? true : false;
  
					txt_ItemCodeT.Text = ClassLib.ComVar.Parameter_PopUp[0];
					txt_ItemNameT.Text = ClassLib.ComVar.Parameter_PopUp[1];
 
				}
				else if(_Division == "S")
				{
					
					same_flag = (txt_ItemCode.Text == ClassLib.ComVar.Parameter_PopUp[2]) ? true : false; 
					 
					txt_ItemCodeT.Text = ClassLib.ComVar.Parameter_PopUp[2];
					txt_ItemNameT.Text = ClassLib.ComVar.Parameter_PopUp[3];

				}
				else if(_Division == "C")
				{

					same_flag = (txt_ItemCode.Text == ClassLib.ComVar.Parameter_PopUp[4]) ? true : false;
 
					txt_ItemCodeT.Text = ClassLib.ComVar.Parameter_PopUp[4];
					txt_ItemNameT.Text = ClassLib.ComVar.Parameter_PopUp[5];

				} 

 

				pop_form.Dispose(); 
 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp2 = new string[2];
			COM.ComVar.Parameter_PopUp2[0] = txt_ItemCodeT.Text;
			COM.ComVar.Parameter_PopUp2[1] = txt_ItemNameT.Text;

			this.Dispose();
			this.Close();
		}

 
 

	}
}

