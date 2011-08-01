using System;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace COM.Com_Form
{
	public class Form_Manual_Language : COM.APSWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_ColumnDesc;
		private C1.Win.C1List.C1Combo cmb_Language;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자


		public Form_Manual_Language()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Manual_Language));
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_ColumnDesc = new System.Windows.Forms.Label();
			this.cmb_Language = new C1.Win.C1List.C1Combo();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Language)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "Select Manual Language";
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(249, 89);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 24);
			this.btn_Apply.TabIndex = 240;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(320, 90);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 241;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lbl_ColumnDesc);
			this.groupBox1.Controls.Add(this.cmb_Language);
			this.groupBox1.Location = new System.Drawing.Point(5, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(385, 40);
			this.groupBox1.TabIndex = 239;
			this.groupBox1.TabStop = false;
			// 
			// lbl_ColumnDesc
			// 
			this.lbl_ColumnDesc.ImageIndex = 0;
			this.lbl_ColumnDesc.ImageList = this.img_Label;
			this.lbl_ColumnDesc.Location = new System.Drawing.Point(7, 13);
			this.lbl_ColumnDesc.Name = "lbl_ColumnDesc";
			this.lbl_ColumnDesc.Size = new System.Drawing.Size(100, 21);
			this.lbl_ColumnDesc.TabIndex = 103;
			this.lbl_ColumnDesc.Text = "Language";
			this.lbl_ColumnDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Language
			// 
			this.cmb_Language.AccessibleDescription = "";
			this.cmb_Language.AccessibleName = "";
			this.cmb_Language.AddItemCols = 0;
			this.cmb_Language.AddItemSeparator = ';';
			//this.cmb_Language.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Language.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Language.Caption = "";
			this.cmb_Language.CaptionHeight = 17;
			this.cmb_Language.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Language.ColumnCaptionHeight = 18;
			this.cmb_Language.ColumnFooterHeight = 18;
			this.cmb_Language.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Language.ContentHeight = 16;
			this.cmb_Language.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Language.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Language.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Language.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Language.EditorHeight = 16;
			this.cmb_Language.Font = new System.Drawing.Font("Verdana", 9F);
			this.cmb_Language.GapHeight = 2;
			this.cmb_Language.ItemHeight = 15;
			this.cmb_Language.Location = new System.Drawing.Point(108, 14);
			this.cmb_Language.MatchEntryTimeout = ((long)(2000));
			this.cmb_Language.MaxDropDownItems = ((short)(5));
			this.cmb_Language.MaxLength = 32767;
			this.cmb_Language.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Language.Name = "cmb_Language";
			//this.cmb_Language.PartialRightColumn = false;
			this.cmb_Language.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Language.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Language.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Language.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Language.Size = new System.Drawing.Size(268, 20);
			this.cmb_Language.TabIndex = 52;
			// 
			// Form_Manual_Language
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 120);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form_Manual_Language";
			this.Text = "Select Manual Language";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Language)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			
			try
			{ 
			
				 
				//Title
				this.Text = "Select Manual Language";
				lbl_MainTitle.Text = "Select Manual Language"; 
 

				Init_Control();


			}
			catch(Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

  
		}


		
		/// <summary>
		/// Init_Control : 
		/// </summary>
		private void Init_Control()
		{
  

			DataTable dt_ret = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxManualLanguage);  // "SCML1";
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Language, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name); 
			cmb_Language.SelectedIndex = 0;


			dt_ret.Dispose();

			
		}  

 



		#endregion



		

		#endregion

		#region 이벤트 처리


		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
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


		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			

			try
			{

				if(cmb_Language.SelectedIndex != -1)
				{
					COM.ComVar.Parameter_PopUp = new string[] { cmb_Language.SelectedValue.ToString(),  cmb_Language.Columns[1].Text };

					COM.ComVar.This_ManualLanuage = cmb_Language.SelectedValue.ToString();
				}

				this.Close();

			}
			catch(Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{

			try
			{

				this.Close();

			}
			catch(Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		#endregion



	}
}

