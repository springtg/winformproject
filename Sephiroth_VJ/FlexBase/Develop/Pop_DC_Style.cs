using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexBase.Develop
{
	public class Pop_DC_Style : COM.PCHWinForm.Pop_Normal
	{
		#region 컨트롤정의 및 리소스 정의 
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_btn;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Label lbl_StyleCode;
		private System.Windows.Forms.Label lbl_StyleName;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.TextBox txt_StyleNo;
		private System.Windows.Forms.TextBox txt_StyleName;
		private C1.Win.C1List.C1Combo cmb_DevFactory;
		private C1.Win.C1List.C1Combo cmb_TestChk;
		private C1.Win.C1List.C1Combo cmb_ConfShoes;
		private C1.Win.C1List.C1Combo cmb_Season;
		private System.Windows.Forms.TextBox txt_LastCd;
		private C1.Win.C1List.C1Combo cmb_Model;
		private System.Windows.Forms.Label lbl_TestChk;
		private System.Windows.Forms.Label lbl_ConfShoes;
		private System.Windows.Forms.Label lbl_DevFactory;
		private System.Windows.Forms.Label lbl_Season;
		private System.Windows.Forms.Label lbl_Gender;
		private System.Windows.Forms.Label lbl_LastCd;
		private System.Windows.Forms.TextBox txt_Remark;
		private System.Windows.Forms.Label lbl_Remark;
		private C1.Win.C1List.C1Combo cmb_Gender;
		private System.ComponentModel.IContainer components = null;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private C1.Win.C1List.C1Combo cmb_Year;
		private System.Windows.Forms.Label lbl_Year;
		private string[] _data = new string[(int)ClassLib.TBSDC_STYLE.IxMaxCt + 1];
		private System.Windows.Forms.GroupBox groupBox1;
		private C1.Win.C1List.C1Combo cmb_Presto;
		private System.Windows.Forms.Label lbl_Presto;
		private System.Windows.Forms.Label lbl_Upper;
		private System.Windows.Forms.Label lbl_Bottom;
		private System.Windows.Forms.Label lbl_Currency;
		private System.Windows.Forms.Label lbl_Siluette;
		private System.Windows.Forms.Label lbl_Cost;
		private System.Windows.Forms.Label lbl_BCost;
		private System.Windows.Forms.Label lbl_Width;
		private C1.Win.C1List.C1Combo cmb_Upper;
		private C1.Win.C1List.C1Combo cmb_Bottom;
		private System.Windows.Forms.TextBox txt_Cost;
		private C1.Win.C1List.C1Combo cmb_Width;
		private C1.Win.C1List.C1Combo cmb_Currency;
		private System.Windows.Forms.TextBox txt_BCost;
		private C1.Win.C1List.C1Combo cmb_Siluette;
		private System.Windows.Forms.TextBox txt_DevCode;
		private System.Windows.Forms.Label lbl_DevCode;
		private System.Windows.Forms.TextBox txt_Bom_Id;
		private System.Windows.Forms.Label lbl_Bom_Id;
		private System.Windows.Forms.TextBox txt_Bom_Level;
		private System.Windows.Forms.Label lbl_BomLevel;
		private C1.Win.C1List.C1Combo cmb_Dev_Code;
		private C1.Win.C1List.C1Combo cmb_Bom_Level;
		private C1.Win.C1List.C1Combo cmb_Bom_Id;
		private System.Windows.Forms.CheckBox chk_Manual;



		private System.EventHandler _cmbModelEvent = null;


		public Pop_DC_Style()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_DC_Style));
            C1.Win.C1List.Style style129 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style130 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style131 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style132 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style133 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style134 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style135 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style136 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style137 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style138 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style139 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style140 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style141 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style142 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style143 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style144 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style145 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style146 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style147 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style148 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style149 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style150 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style151 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style152 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style153 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style154 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style155 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style156 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style157 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style158 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style159 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style160 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style161 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style162 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style163 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style164 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style165 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style166 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style167 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style168 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style169 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style170 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style171 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style172 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style173 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style174 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style175 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style176 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style177 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style178 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style179 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style180 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style181 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style182 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style183 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style184 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style185 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style186 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style187 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style188 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style189 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style190 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style191 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style192 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style193 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style194 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style195 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style196 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style197 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style198 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style199 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style200 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style201 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style202 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style203 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style204 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style205 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style206 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style207 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style208 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style209 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style210 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style211 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style212 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style213 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style214 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style215 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style216 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style217 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style218 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style219 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style220 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style221 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style222 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style223 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style224 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style225 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style226 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style227 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style228 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style229 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style230 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style231 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style232 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style233 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style234 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style235 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style236 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style237 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style238 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style239 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style240 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style241 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style242 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style243 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style244 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style245 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style246 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style247 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style248 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style249 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style250 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style251 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style252 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style253 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style254 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style255 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style256 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_Manual = new System.Windows.Forms.CheckBox();
            this.cmb_Bom_Id = new C1.Win.C1List.C1Combo();
            this.cmb_Bom_Level = new C1.Win.C1List.C1Combo();
            this.txt_DevCode = new System.Windows.Forms.TextBox();
            this.lbl_DevCode = new System.Windows.Forms.Label();
            this.txt_Bom_Id = new System.Windows.Forms.TextBox();
            this.lbl_Bom_Id = new System.Windows.Forms.Label();
            this.txt_Bom_Level = new System.Windows.Forms.TextBox();
            this.lbl_BomLevel = new System.Windows.Forms.Label();
            this.cmb_Siluette = new C1.Win.C1List.C1Combo();
            this.cmb_Width = new C1.Win.C1List.C1Combo();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.cmb_Presto = new C1.Win.C1List.C1Combo();
            this.lbl_Presto = new System.Windows.Forms.Label();
            this.txt_BCost = new System.Windows.Forms.TextBox();
            this.lbl_BCost = new System.Windows.Forms.Label();
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_Siluette = new System.Windows.Forms.Label();
            this.cmb_Currency = new C1.Win.C1List.C1Combo();
            this.lbl_Currency = new System.Windows.Forms.Label();
            this.cmb_Bottom = new C1.Win.C1List.C1Combo();
            this.lbl_Bottom = new System.Windows.Forms.Label();
            this.cmb_Upper = new C1.Win.C1List.C1Combo();
            this.lbl_Upper = new System.Windows.Forms.Label();
            this.cmb_Year = new C1.Win.C1List.C1Combo();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_StyleName = new System.Windows.Forms.Label();
            this.txt_StyleName = new System.Windows.Forms.TextBox();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.cmb_Model = new C1.Win.C1List.C1Combo();
            this.txt_StyleNo = new System.Windows.Forms.TextBox();
            this.lbl_StyleCode = new System.Windows.Forms.Label();
            this.lbl_LastCd = new System.Windows.Forms.Label();
            this.cmb_DevFactory = new C1.Win.C1List.C1Combo();
            this.cmb_Gender = new C1.Win.C1List.C1Combo();
            this.lbl_ConfShoes = new System.Windows.Forms.Label();
            this.lbl_DevFactory = new System.Windows.Forms.Label();
            this.cmb_Season = new C1.Win.C1List.C1Combo();
            this.lbl_Season = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cmb_ConfShoes = new C1.Win.C1List.C1Combo();
            this.txt_LastCd = new System.Windows.Forms.TextBox();
            this.cmb_TestChk = new C1.Win.C1List.C1Combo();
            this.lbl_TestChk = new System.Windows.Forms.Label();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.lbl_Remark = new System.Windows.Forms.Label();
            this.cmb_Dev_Code = new C1.Win.C1List.C1Combo();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Bom_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Bom_Level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Siluette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Presto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Currency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Upper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DevFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ConfShoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TestChk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Dev_Code)).BeginInit();
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(452, 23);
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.pnl_btn);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.GridDefinition = "88.3620689655172:False:False;10.7758620689655:False:False;\t0.816326530612245:Fals" +
                "e:True;96.9387755102041:False:False;0.612244897959184:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 34);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(490, 464);
            this.c1Sizer1.TabIndex = 217;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_btn
            // 
            this.pnl_btn.BackColor = System.Drawing.Color.Transparent;
            this.pnl_btn.Controls.Add(this.btn_apply);
            this.pnl_btn.Controls.Add(this.btn_cancel);
            this.pnl_btn.Location = new System.Drawing.Point(8, 414);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(475, 50);
            this.pnl_btn.TabIndex = 1;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(328, 12);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 12;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(399, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_main.Controls.Add(this.groupBox1);
            this.pnl_main.Location = new System.Drawing.Point(8, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(475, 410);
            this.pnl_main.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.chk_Manual);
            this.groupBox1.Controls.Add(this.cmb_Bom_Id);
            this.groupBox1.Controls.Add(this.cmb_Bom_Level);
            this.groupBox1.Controls.Add(this.txt_DevCode);
            this.groupBox1.Controls.Add(this.lbl_DevCode);
            this.groupBox1.Controls.Add(this.txt_Bom_Id);
            this.groupBox1.Controls.Add(this.lbl_Bom_Id);
            this.groupBox1.Controls.Add(this.txt_Bom_Level);
            this.groupBox1.Controls.Add(this.lbl_BomLevel);
            this.groupBox1.Controls.Add(this.cmb_Siluette);
            this.groupBox1.Controls.Add(this.cmb_Width);
            this.groupBox1.Controls.Add(this.lbl_Width);
            this.groupBox1.Controls.Add(this.cmb_Presto);
            this.groupBox1.Controls.Add(this.lbl_Presto);
            this.groupBox1.Controls.Add(this.txt_BCost);
            this.groupBox1.Controls.Add(this.lbl_BCost);
            this.groupBox1.Controls.Add(this.txt_Cost);
            this.groupBox1.Controls.Add(this.lbl_Cost);
            this.groupBox1.Controls.Add(this.lbl_Siluette);
            this.groupBox1.Controls.Add(this.cmb_Currency);
            this.groupBox1.Controls.Add(this.lbl_Currency);
            this.groupBox1.Controls.Add(this.cmb_Bottom);
            this.groupBox1.Controls.Add(this.lbl_Bottom);
            this.groupBox1.Controls.Add(this.cmb_Upper);
            this.groupBox1.Controls.Add(this.lbl_Upper);
            this.groupBox1.Controls.Add(this.cmb_Year);
            this.groupBox1.Controls.Add(this.lbl_Year);
            this.groupBox1.Controls.Add(this.lbl_StyleName);
            this.groupBox1.Controls.Add(this.txt_StyleName);
            this.groupBox1.Controls.Add(this.lbl_Model);
            this.groupBox1.Controls.Add(this.cmb_Model);
            this.groupBox1.Controls.Add(this.txt_StyleNo);
            this.groupBox1.Controls.Add(this.lbl_StyleCode);
            this.groupBox1.Controls.Add(this.lbl_LastCd);
            this.groupBox1.Controls.Add(this.cmb_DevFactory);
            this.groupBox1.Controls.Add(this.cmb_Gender);
            this.groupBox1.Controls.Add(this.lbl_ConfShoes);
            this.groupBox1.Controls.Add(this.lbl_DevFactory);
            this.groupBox1.Controls.Add(this.cmb_Season);
            this.groupBox1.Controls.Add(this.lbl_Season);
            this.groupBox1.Controls.Add(this.lbl_Gender);
            this.groupBox1.Controls.Add(this.cmb_ConfShoes);
            this.groupBox1.Controls.Add(this.txt_LastCd);
            this.groupBox1.Controls.Add(this.cmb_TestChk);
            this.groupBox1.Controls.Add(this.lbl_TestChk);
            this.groupBox1.Controls.Add(this.txt_Remark);
            this.groupBox1.Controls.Add(this.lbl_Remark);
            this.groupBox1.Controls.Add(this.cmb_Dev_Code);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 394);
            this.groupBox1.TabIndex = 495;
            this.groupBox1.TabStop = false;
            // 
            // chk_Manual
            // 
            this.chk_Manual.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chk_Manual.Location = new System.Drawing.Point(9, 297);
            this.chk_Manual.Name = "chk_Manual";
            this.chk_Manual.Size = new System.Drawing.Size(104, 24);
            this.chk_Manual.TabIndex = 520;
            this.chk_Manual.Text = "By Manual";
            this.chk_Manual.CheckedChanged += new System.EventHandler(this.chk_Manual_CheckedChanged);
            // 
            // cmb_Bom_Id
            // 
            this.cmb_Bom_Id.AddItemCols = 0;
            this.cmb_Bom_Id.AddItemSeparator = ';';
            //this.cmb_Bom_Id.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Bom_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Bom_Id.Caption = "";
            this.cmb_Bom_Id.CaptionHeight = 17;
            this.cmb_Bom_Id.CaptionStyle = style129;
            this.cmb_Bom_Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Bom_Id.ColumnCaptionHeight = 18;
            this.cmb_Bom_Id.ColumnFooterHeight = 18;
            this.cmb_Bom_Id.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Bom_Id.ContentHeight = 17;
            this.cmb_Bom_Id.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Bom_Id.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Bom_Id.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Bom_Id.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Bom_Id.EditorHeight = 17;
            this.cmb_Bom_Id.EvenRowStyle = style130;
            this.cmb_Bom_Id.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Bom_Id.FooterStyle = style131;
            this.cmb_Bom_Id.GapHeight = 2;
            this.cmb_Bom_Id.HeadingStyle = style132;
            this.cmb_Bom_Id.HighLightRowStyle = style133;
            this.cmb_Bom_Id.ItemHeight = 15;
            this.cmb_Bom_Id.Location = new System.Drawing.Point(230, 344);
            this.cmb_Bom_Id.MatchEntryTimeout = ((long)(2000));
            this.cmb_Bom_Id.MaxDropDownItems = ((short)(5));
            this.cmb_Bom_Id.MaxLength = 1;
            this.cmb_Bom_Id.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Bom_Id.Name = "cmb_Bom_Id";
            this.cmb_Bom_Id.OddRowStyle = style134;
            //this.cmb_Bom_Id.PartialRightColumn = false;
            this.cmb_Bom_Id.PropBag = resources.GetString("cmb_Bom_Id.PropBag");
            this.cmb_Bom_Id.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Bom_Id.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Bom_Id.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Bom_Id.SelectedStyle = style135;
            this.cmb_Bom_Id.Size = new System.Drawing.Size(240, 21);
            this.cmb_Bom_Id.Style = style136;
            this.cmb_Bom_Id.TabIndex = 519;
            this.cmb_Bom_Id.SelectedValueChanged += new System.EventHandler(this.cmb_Bom_Id_SelectedValueChanged);
            // 
            // cmb_Bom_Level
            // 
            this.cmb_Bom_Level.AddItemCols = 0;
            this.cmb_Bom_Level.AddItemSeparator = ';';
            //this.cmb_Bom_Level.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Bom_Level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Bom_Level.Caption = "";
            this.cmb_Bom_Level.CaptionHeight = 17;
            this.cmb_Bom_Level.CaptionStyle = style137;
            this.cmb_Bom_Level.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Bom_Level.ColumnCaptionHeight = 18;
            this.cmb_Bom_Level.ColumnFooterHeight = 18;
            this.cmb_Bom_Level.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Bom_Level.ContentHeight = 17;
            this.cmb_Bom_Level.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Bom_Level.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Bom_Level.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Bom_Level.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Bom_Level.EditorHeight = 17;
            this.cmb_Bom_Level.EvenRowStyle = style138;
            this.cmb_Bom_Level.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Bom_Level.FooterStyle = style139;
            this.cmb_Bom_Level.GapHeight = 2;
            this.cmb_Bom_Level.HeadingStyle = style140;
            this.cmb_Bom_Level.HighLightRowStyle = style141;
            this.cmb_Bom_Level.ItemHeight = 15;
            this.cmb_Bom_Level.Location = new System.Drawing.Point(230, 367);
            this.cmb_Bom_Level.MatchEntryTimeout = ((long)(2000));
            this.cmb_Bom_Level.MaxDropDownItems = ((short)(5));
            this.cmb_Bom_Level.MaxLength = 1;
            this.cmb_Bom_Level.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Bom_Level.Name = "cmb_Bom_Level";
            this.cmb_Bom_Level.OddRowStyle = style142;
            //this.cmb_Bom_Level.PartialRightColumn = false;
            this.cmb_Bom_Level.PropBag = resources.GetString("cmb_Bom_Level.PropBag");
            this.cmb_Bom_Level.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Bom_Level.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Bom_Level.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Bom_Level.SelectedStyle = style143;
            this.cmb_Bom_Level.Size = new System.Drawing.Size(240, 21);
            this.cmb_Bom_Level.Style = style144;
            this.cmb_Bom_Level.TabIndex = 518;
            this.cmb_Bom_Level.SelectedValueChanged += new System.EventHandler(this.cmb_Bom_Level_SelectedValueChanged);
            // 
            // txt_DevCode
            // 
            this.txt_DevCode.BackColor = System.Drawing.Color.White;
            this.txt_DevCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DevCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_DevCode.Location = new System.Drawing.Point(109, 321);
            this.txt_DevCode.MaxLength = 6;
            this.txt_DevCode.Name = "txt_DevCode";
            this.txt_DevCode.Size = new System.Drawing.Size(120, 21);
            this.txt_DevCode.TabIndex = 513;
            // 
            // lbl_DevCode
            // 
            this.lbl_DevCode.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_DevCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_DevCode.ImageIndex = 1;
            this.lbl_DevCode.ImageList = this.img_Label;
            this.lbl_DevCode.Location = new System.Drawing.Point(8, 321);
            this.lbl_DevCode.Name = "lbl_DevCode";
            this.lbl_DevCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_DevCode.TabIndex = 512;
            this.lbl_DevCode.Text = "Dev Code";
            this.lbl_DevCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Bom_Id
            // 
            this.txt_Bom_Id.BackColor = System.Drawing.Color.White;
            this.txt_Bom_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Bom_Id.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Bom_Id.Location = new System.Drawing.Point(109, 344);
            this.txt_Bom_Id.MaxLength = 6;
            this.txt_Bom_Id.Name = "txt_Bom_Id";
            this.txt_Bom_Id.Size = new System.Drawing.Size(120, 21);
            this.txt_Bom_Id.TabIndex = 515;
            // 
            // lbl_Bom_Id
            // 
            this.lbl_Bom_Id.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Bom_Id.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Bom_Id.ImageIndex = 1;
            this.lbl_Bom_Id.ImageList = this.img_Label;
            this.lbl_Bom_Id.Location = new System.Drawing.Point(8, 344);
            this.lbl_Bom_Id.Name = "lbl_Bom_Id";
            this.lbl_Bom_Id.Size = new System.Drawing.Size(100, 21);
            this.lbl_Bom_Id.TabIndex = 514;
            this.lbl_Bom_Id.Text = "Bom Id";
            this.lbl_Bom_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Bom_Level
            // 
            this.txt_Bom_Level.BackColor = System.Drawing.Color.White;
            this.txt_Bom_Level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Bom_Level.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Bom_Level.Location = new System.Drawing.Point(109, 367);
            this.txt_Bom_Level.MaxLength = 6;
            this.txt_Bom_Level.Name = "txt_Bom_Level";
            this.txt_Bom_Level.Size = new System.Drawing.Size(120, 21);
            this.txt_Bom_Level.TabIndex = 517;
            // 
            // lbl_BomLevel
            // 
            this.lbl_BomLevel.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_BomLevel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_BomLevel.ImageIndex = 1;
            this.lbl_BomLevel.ImageList = this.img_Label;
            this.lbl_BomLevel.Location = new System.Drawing.Point(8, 367);
            this.lbl_BomLevel.Name = "lbl_BomLevel";
            this.lbl_BomLevel.Size = new System.Drawing.Size(100, 21);
            this.lbl_BomLevel.TabIndex = 516;
            this.lbl_BomLevel.Text = "Bom Level";
            this.lbl_BomLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Siluette
            // 
            this.cmb_Siluette.AddItemCols = 0;
            this.cmb_Siluette.AddItemSeparator = ';';
            //this.cmb_Siluette.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Siluette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Siluette.Caption = "";
            this.cmb_Siluette.CaptionHeight = 17;
            this.cmb_Siluette.CaptionStyle = style145;
            this.cmb_Siluette.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Siluette.ColumnCaptionHeight = 18;
            this.cmb_Siluette.ColumnFooterHeight = 18;
            this.cmb_Siluette.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Siluette.ContentHeight = 17;
            this.cmb_Siluette.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Siluette.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Siluette.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Siluette.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Siluette.EditorHeight = 17;
            this.cmb_Siluette.EvenRowStyle = style146;
            this.cmb_Siluette.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Siluette.FooterStyle = style147;
            this.cmb_Siluette.GapHeight = 2;
            this.cmb_Siluette.HeadingStyle = style148;
            this.cmb_Siluette.HighLightRowStyle = style149;
            this.cmb_Siluette.ItemHeight = 15;
            this.cmb_Siluette.Location = new System.Drawing.Point(349, 182);
            this.cmb_Siluette.MatchEntryTimeout = ((long)(2000));
            this.cmb_Siluette.MaxDropDownItems = ((short)(5));
            this.cmb_Siluette.MaxLength = 1;
            this.cmb_Siluette.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Siluette.Name = "cmb_Siluette";
            this.cmb_Siluette.OddRowStyle = style150;
            //this.cmb_Siluette.PartialRightColumn = false;
            this.cmb_Siluette.PropBag = resources.GetString("cmb_Siluette.PropBag");
            this.cmb_Siluette.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Siluette.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Siluette.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Siluette.SelectedStyle = style151;
            this.cmb_Siluette.Size = new System.Drawing.Size(120, 21);
            this.cmb_Siluette.Style = style152;
            this.cmb_Siluette.TabIndex = 511;
            // 
            // cmb_Width
            // 
            this.cmb_Width.AddItemCols = 0;
            this.cmb_Width.AddItemSeparator = ';';
            //this.cmb_Width.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Width.Caption = "";
            this.cmb_Width.CaptionHeight = 17;
            this.cmb_Width.CaptionStyle = style153;
            this.cmb_Width.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Width.ColumnCaptionHeight = 18;
            this.cmb_Width.ColumnFooterHeight = 18;
            this.cmb_Width.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Width.ContentHeight = 17;
            this.cmb_Width.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Width.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Width.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Width.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Width.EditorHeight = 17;
            this.cmb_Width.EvenRowStyle = style154;
            this.cmb_Width.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Width.FooterStyle = style155;
            this.cmb_Width.GapHeight = 2;
            this.cmb_Width.HeadingStyle = style156;
            this.cmb_Width.HighLightRowStyle = style157;
            this.cmb_Width.ItemHeight = 15;
            this.cmb_Width.Location = new System.Drawing.Point(349, 248);
            this.cmb_Width.MatchEntryTimeout = ((long)(2000));
            this.cmb_Width.MaxDropDownItems = ((short)(5));
            this.cmb_Width.MaxLength = 1;
            this.cmb_Width.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Width.Name = "cmb_Width";
            this.cmb_Width.OddRowStyle = style158;
            //this.cmb_Width.PartialRightColumn = false;
            this.cmb_Width.PropBag = resources.GetString("cmb_Width.PropBag");
            this.cmb_Width.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Width.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Width.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Width.SelectedStyle = style159;
            this.cmb_Width.Size = new System.Drawing.Size(120, 21);
            this.cmb_Width.Style = style160;
            this.cmb_Width.TabIndex = 510;
            // 
            // lbl_Width
            // 
            this.lbl_Width.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Width.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Width.ImageIndex = 1;
            this.lbl_Width.ImageList = this.img_Label;
            this.lbl_Width.Location = new System.Drawing.Point(248, 248);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(100, 21);
            this.lbl_Width.TabIndex = 509;
            this.lbl_Width.Text = "Width Division";
            this.lbl_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Presto
            // 
            this.cmb_Presto.AddItemCols = 0;
            this.cmb_Presto.AddItemSeparator = ';';
            //this.cmb_Presto.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Presto.Caption = "";
            this.cmb_Presto.CaptionHeight = 17;
            this.cmb_Presto.CaptionStyle = style161;
            this.cmb_Presto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Presto.ColumnCaptionHeight = 18;
            this.cmb_Presto.ColumnFooterHeight = 18;
            this.cmb_Presto.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Presto.ContentHeight = 17;
            this.cmb_Presto.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Presto.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Presto.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Presto.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Presto.EditorHeight = 17;
            this.cmb_Presto.EvenRowStyle = style162;
            this.cmb_Presto.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Presto.FooterStyle = style163;
            this.cmb_Presto.GapHeight = 2;
            this.cmb_Presto.HeadingStyle = style164;
            this.cmb_Presto.HighLightRowStyle = style165;
            this.cmb_Presto.ItemHeight = 15;
            this.cmb_Presto.Location = new System.Drawing.Point(349, 88);
            this.cmb_Presto.MatchEntryTimeout = ((long)(2000));
            this.cmb_Presto.MaxDropDownItems = ((short)(5));
            this.cmb_Presto.MaxLength = 1;
            this.cmb_Presto.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Presto.Name = "cmb_Presto";
            this.cmb_Presto.OddRowStyle = style166;
            //this.cmb_Presto.PartialRightColumn = false;
            this.cmb_Presto.PropBag = resources.GetString("cmb_Presto.PropBag");
            this.cmb_Presto.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Presto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Presto.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Presto.SelectedStyle = style167;
            this.cmb_Presto.Size = new System.Drawing.Size(120, 21);
            this.cmb_Presto.Style = style168;
            this.cmb_Presto.TabIndex = 508;
            // 
            // lbl_Presto
            // 
            this.lbl_Presto.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Presto.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Presto.ImageIndex = 0;
            this.lbl_Presto.ImageList = this.img_Label;
            this.lbl_Presto.Location = new System.Drawing.Point(248, 88);
            this.lbl_Presto.Name = "lbl_Presto";
            this.lbl_Presto.Size = new System.Drawing.Size(100, 21);
            this.lbl_Presto.TabIndex = 507;
            this.lbl_Presto.Text = "Presto";
            this.lbl_Presto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_BCost
            // 
            this.txt_BCost.BackColor = System.Drawing.Color.White;
            this.txt_BCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCost.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_BCost.Location = new System.Drawing.Point(349, 226);
            this.txt_BCost.MaxLength = 6;
            this.txt_BCost.Name = "txt_BCost";
            this.txt_BCost.Size = new System.Drawing.Size(120, 21);
            this.txt_BCost.TabIndex = 506;
            // 
            // lbl_BCost
            // 
            this.lbl_BCost.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_BCost.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_BCost.ImageIndex = 0;
            this.lbl_BCost.ImageList = this.img_Label;
            this.lbl_BCost.Location = new System.Drawing.Point(248, 225);
            this.lbl_BCost.Name = "lbl_BCost";
            this.lbl_BCost.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCost.TabIndex = 505;
            this.lbl_BCost.Text = "B Cost";
            this.lbl_BCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Cost
            // 
            this.txt_Cost.BackColor = System.Drawing.Color.White;
            this.txt_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cost.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Cost.Location = new System.Drawing.Point(109, 248);
            this.txt_Cost.MaxLength = 6;
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(120, 21);
            this.txt_Cost.TabIndex = 504;
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Cost.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Cost.ImageIndex = 0;
            this.lbl_Cost.ImageList = this.img_Label;
            this.lbl_Cost.Location = new System.Drawing.Point(8, 248);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cost.TabIndex = 503;
            this.lbl_Cost.Text = "Cost";
            this.lbl_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Siluette
            // 
            this.lbl_Siluette.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Siluette.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Siluette.ImageIndex = 0;
            this.lbl_Siluette.ImageList = this.img_Label;
            this.lbl_Siluette.Location = new System.Drawing.Point(248, 183);
            this.lbl_Siluette.Name = "lbl_Siluette";
            this.lbl_Siluette.Size = new System.Drawing.Size(100, 21);
            this.lbl_Siluette.TabIndex = 501;
            this.lbl_Siluette.Text = "Siluette";
            this.lbl_Siluette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Currency
            // 
            this.cmb_Currency.AddItemCols = 0;
            this.cmb_Currency.AddItemSeparator = ';';
            //this.cmb_Currency.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Currency.Caption = "";
            this.cmb_Currency.CaptionHeight = 17;
            this.cmb_Currency.CaptionStyle = style169;
            this.cmb_Currency.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Currency.ColumnCaptionHeight = 18;
            this.cmb_Currency.ColumnFooterHeight = 18;
            this.cmb_Currency.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Currency.ContentHeight = 17;
            this.cmb_Currency.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Currency.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Currency.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Currency.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Currency.EditorHeight = 17;
            this.cmb_Currency.EvenRowStyle = style170;
            this.cmb_Currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Currency.FooterStyle = style171;
            this.cmb_Currency.GapHeight = 2;
            this.cmb_Currency.HeadingStyle = style172;
            this.cmb_Currency.HighLightRowStyle = style173;
            this.cmb_Currency.ItemHeight = 15;
            this.cmb_Currency.Location = new System.Drawing.Point(349, 204);
            this.cmb_Currency.MatchEntryTimeout = ((long)(2000));
            this.cmb_Currency.MaxDropDownItems = ((short)(5));
            this.cmb_Currency.MaxLength = 1;
            this.cmb_Currency.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Currency.Name = "cmb_Currency";
            this.cmb_Currency.OddRowStyle = style174;
            //this.cmb_Currency.PartialRightColumn = false;
            this.cmb_Currency.PropBag = resources.GetString("cmb_Currency.PropBag");
            this.cmb_Currency.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Currency.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Currency.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Currency.SelectedStyle = style175;
            this.cmb_Currency.Size = new System.Drawing.Size(120, 21);
            this.cmb_Currency.Style = style176;
            this.cmb_Currency.TabIndex = 500;
            // 
            // lbl_Currency
            // 
            this.lbl_Currency.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Currency.ImageIndex = 0;
            this.lbl_Currency.ImageList = this.img_Label;
            this.lbl_Currency.Location = new System.Drawing.Point(248, 206);
            this.lbl_Currency.Name = "lbl_Currency";
            this.lbl_Currency.Size = new System.Drawing.Size(100, 21);
            this.lbl_Currency.TabIndex = 499;
            this.lbl_Currency.Text = "Currency";
            this.lbl_Currency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Bottom
            // 
            this.cmb_Bottom.AddItemCols = 0;
            this.cmb_Bottom.AddItemSeparator = ';';
            //this.cmb_Bottom.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Bottom.Caption = "";
            this.cmb_Bottom.CaptionHeight = 17;
            this.cmb_Bottom.CaptionStyle = style177;
            this.cmb_Bottom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Bottom.ColumnCaptionHeight = 18;
            this.cmb_Bottom.ColumnFooterHeight = 18;
            this.cmb_Bottom.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Bottom.ContentHeight = 17;
            this.cmb_Bottom.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Bottom.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Bottom.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Bottom.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Bottom.EditorHeight = 17;
            this.cmb_Bottom.EvenRowStyle = style178;
            this.cmb_Bottom.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Bottom.FooterStyle = style179;
            this.cmb_Bottom.GapHeight = 2;
            this.cmb_Bottom.HeadingStyle = style180;
            this.cmb_Bottom.HighLightRowStyle = style181;
            this.cmb_Bottom.ItemHeight = 15;
            this.cmb_Bottom.Location = new System.Drawing.Point(109, 226);
            this.cmb_Bottom.MatchEntryTimeout = ((long)(2000));
            this.cmb_Bottom.MaxDropDownItems = ((short)(5));
            this.cmb_Bottom.MaxLength = 1;
            this.cmb_Bottom.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Bottom.Name = "cmb_Bottom";
            this.cmb_Bottom.OddRowStyle = style182;
            //this.cmb_Bottom.PartialRightColumn = false;
            this.cmb_Bottom.PropBag = resources.GetString("cmb_Bottom.PropBag");
            this.cmb_Bottom.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Bottom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Bottom.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Bottom.SelectedStyle = style183;
            this.cmb_Bottom.Size = new System.Drawing.Size(120, 21);
            this.cmb_Bottom.Style = style184;
            this.cmb_Bottom.TabIndex = 498;
            // 
            // lbl_Bottom
            // 
            this.lbl_Bottom.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Bottom.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Bottom.ImageIndex = 0;
            this.lbl_Bottom.ImageList = this.img_Label;
            this.lbl_Bottom.Location = new System.Drawing.Point(8, 226);
            this.lbl_Bottom.Name = "lbl_Bottom";
            this.lbl_Bottom.Size = new System.Drawing.Size(100, 21);
            this.lbl_Bottom.TabIndex = 497;
            this.lbl_Bottom.Text = "Bottom Chk";
            this.lbl_Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Upper
            // 
            this.cmb_Upper.AddItemCols = 0;
            this.cmb_Upper.AddItemSeparator = ';';
            //this.cmb_Upper.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Upper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Upper.Caption = "";
            this.cmb_Upper.CaptionHeight = 17;
            this.cmb_Upper.CaptionStyle = style185;
            this.cmb_Upper.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Upper.ColumnCaptionHeight = 18;
            this.cmb_Upper.ColumnFooterHeight = 18;
            this.cmb_Upper.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Upper.ContentHeight = 17;
            this.cmb_Upper.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Upper.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Upper.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Upper.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Upper.EditorHeight = 17;
            this.cmb_Upper.EvenRowStyle = style186;
            this.cmb_Upper.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Upper.FooterStyle = style187;
            this.cmb_Upper.GapHeight = 2;
            this.cmb_Upper.HeadingStyle = style188;
            this.cmb_Upper.HighLightRowStyle = style189;
            this.cmb_Upper.ItemHeight = 15;
            this.cmb_Upper.Location = new System.Drawing.Point(109, 204);
            this.cmb_Upper.MatchEntryTimeout = ((long)(2000));
            this.cmb_Upper.MaxDropDownItems = ((short)(5));
            this.cmb_Upper.MaxLength = 1;
            this.cmb_Upper.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Upper.Name = "cmb_Upper";
            this.cmb_Upper.OddRowStyle = style190;
            //this.cmb_Upper.PartialRightColumn = false;
            this.cmb_Upper.PropBag = resources.GetString("cmb_Upper.PropBag");
            this.cmb_Upper.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Upper.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Upper.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Upper.SelectedStyle = style191;
            this.cmb_Upper.Size = new System.Drawing.Size(120, 21);
            this.cmb_Upper.Style = style192;
            this.cmb_Upper.TabIndex = 496;
            // 
            // lbl_Upper
            // 
            this.lbl_Upper.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Upper.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Upper.ImageIndex = 0;
            this.lbl_Upper.ImageList = this.img_Label;
            this.lbl_Upper.Location = new System.Drawing.Point(8, 204);
            this.lbl_Upper.Name = "lbl_Upper";
            this.lbl_Upper.Size = new System.Drawing.Size(100, 21);
            this.lbl_Upper.TabIndex = 495;
            this.lbl_Upper.Text = "Upper Chk";
            this.lbl_Upper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Year
            // 
            this.cmb_Year.AddItemCols = 0;
            this.cmb_Year.AddItemSeparator = ';';
            //this.cmb_Year.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Year.Caption = "";
            this.cmb_Year.CaptionHeight = 17;
            this.cmb_Year.CaptionStyle = style193;
            this.cmb_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Year.ColumnCaptionHeight = 18;
            this.cmb_Year.ColumnFooterHeight = 18;
            this.cmb_Year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Year.ContentHeight = 17;
            this.cmb_Year.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Year.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Year.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Year.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Year.EditorHeight = 17;
            this.cmb_Year.EvenRowStyle = style194;
            this.cmb_Year.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Year.FooterStyle = style195;
            this.cmb_Year.GapHeight = 2;
            this.cmb_Year.HeadingStyle = style196;
            this.cmb_Year.HighLightRowStyle = style197;
            this.cmb_Year.ItemHeight = 15;
            this.cmb_Year.Location = new System.Drawing.Point(109, 66);
            this.cmb_Year.MatchEntryTimeout = ((long)(2000));
            this.cmb_Year.MaxDropDownItems = ((short)(5));
            this.cmb_Year.MaxLength = 1;
            this.cmb_Year.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.OddRowStyle = style198;
            //this.cmb_Year.PartialRightColumn = false;
            this.cmb_Year.PropBag = resources.GetString("cmb_Year.PropBag");
            this.cmb_Year.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Year.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Year.SelectedStyle = style199;
            this.cmb_Year.Size = new System.Drawing.Size(120, 21);
            this.cmb_Year.Style = style200;
            this.cmb_Year.TabIndex = 493;
            this.cmb_Year.TextChanged += new System.EventHandler(this.cmb_Year_TextChanged);
            // 
            // lbl_Year
            // 
            this.lbl_Year.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Year.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Year.ImageIndex = 0;
            this.lbl_Year.ImageList = this.img_Label;
            this.lbl_Year.Location = new System.Drawing.Point(8, 66);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(100, 21);
            this.lbl_Year.TabIndex = 494;
            this.lbl_Year.Text = "Year";
            this.lbl_Year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_StyleName
            // 
            this.lbl_StyleName.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_StyleName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_StyleName.ImageIndex = 0;
            this.lbl_StyleName.ImageList = this.img_Label;
            this.lbl_StyleName.Location = new System.Drawing.Point(8, 44);
            this.lbl_StyleName.Name = "lbl_StyleName";
            this.lbl_StyleName.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleName.TabIndex = 480;
            this.lbl_StyleName.Text = "Style Name";
            this.lbl_StyleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StyleName
            // 
            this.txt_StyleName.BackColor = System.Drawing.Color.White;
            this.txt_StyleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleName.Location = new System.Drawing.Point(109, 44);
            this.txt_StyleName.MaxLength = 30;
            this.txt_StyleName.Name = "txt_StyleName";
            this.txt_StyleName.Size = new System.Drawing.Size(360, 21);
            this.txt_StyleName.TabIndex = 479;
            // 
            // lbl_Model
            // 
            this.lbl_Model.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Model.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Model.ImageIndex = 0;
            this.lbl_Model.ImageList = this.img_Label;
            this.lbl_Model.Location = new System.Drawing.Point(8, 110);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(100, 21);
            this.lbl_Model.TabIndex = 458;
            this.lbl_Model.Text = "Model";
            this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Model
            // 
            this.cmb_Model.AddItemCols = 0;
            this.cmb_Model.AddItemSeparator = ';';
            //this.cmb_Model.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Model.Caption = "";
            this.cmb_Model.CaptionHeight = 17;
            this.cmb_Model.CaptionStyle = style201;
            this.cmb_Model.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Model.ColumnCaptionHeight = 18;
            this.cmb_Model.ColumnFooterHeight = 18;
            this.cmb_Model.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Model.ContentHeight = 17;
            this.cmb_Model.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Model.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Model.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Model.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Model.EditorHeight = 17;
            this.cmb_Model.EvenRowStyle = style202;
            this.cmb_Model.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Model.FooterStyle = style203;
            this.cmb_Model.GapHeight = 2;
            this.cmb_Model.HeadingStyle = style204;
            this.cmb_Model.HighLightRowStyle = style205;
            this.cmb_Model.ItemHeight = 15;
            this.cmb_Model.Location = new System.Drawing.Point(109, 110);
            this.cmb_Model.MatchEntryTimeout = ((long)(2000));
            this.cmb_Model.MaxDropDownItems = ((short)(5));
            this.cmb_Model.MaxLength = 1;
            this.cmb_Model.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Model.Name = "cmb_Model";
            this.cmb_Model.OddRowStyle = style206;
            this.cmb_Model.PartialRightColumn = false;
            this.cmb_Model.PropBag = resources.GetString("cmb_Model.PropBag");
            this.cmb_Model.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Model.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Model.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Model.SelectedStyle = style207;
            this.cmb_Model.Size = new System.Drawing.Size(120, 21);
            this.cmb_Model.Style = style208;
            this.cmb_Model.TabIndex = 490;
            // 
            // txt_StyleNo
            // 
            this.txt_StyleNo.BackColor = System.Drawing.Color.White;
            this.txt_StyleNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleNo.Location = new System.Drawing.Point(109, 16);
            this.txt_StyleNo.MaxLength = 9;
            this.txt_StyleNo.Name = "txt_StyleNo";
            this.txt_StyleNo.Size = new System.Drawing.Size(120, 21);
            this.txt_StyleNo.TabIndex = 476;
            this.txt_StyleNo.TextChanged += new System.EventHandler(this.txt_StyleNo_TextChanged);
            this.txt_StyleNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StyleNo_KeyPress);
            // 
            // lbl_StyleCode
            // 
            this.lbl_StyleCode.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_StyleCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_StyleCode.ImageIndex = 1;
            this.lbl_StyleCode.ImageList = this.img_Label;
            this.lbl_StyleCode.Location = new System.Drawing.Point(8, 16);
            this.lbl_StyleCode.Name = "lbl_StyleCode";
            this.lbl_StyleCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleCode.TabIndex = 461;
            this.lbl_StyleCode.Text = "Style No";
            this.lbl_StyleCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_LastCd
            // 
            this.lbl_LastCd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_LastCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_LastCd.ImageIndex = 0;
            this.lbl_LastCd.ImageList = this.img_Label;
            this.lbl_LastCd.Location = new System.Drawing.Point(8, 159);
            this.lbl_LastCd.Name = "lbl_LastCd";
            this.lbl_LastCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_LastCd.TabIndex = 459;
            this.lbl_LastCd.Text = "Last Code";
            this.lbl_LastCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_DevFactory
            // 
            this.cmb_DevFactory.AddItemCols = 0;
            this.cmb_DevFactory.AddItemSeparator = ';';
            this.cmb_DevFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_DevFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_DevFactory.Caption = "";
            this.cmb_DevFactory.CaptionHeight = 17;
            this.cmb_DevFactory.CaptionStyle = style209;
            this.cmb_DevFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_DevFactory.ColumnCaptionHeight = 18;
            this.cmb_DevFactory.ColumnFooterHeight = 18;
            this.cmb_DevFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_DevFactory.ContentHeight = 17;
            this.cmb_DevFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_DevFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_DevFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DevFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_DevFactory.EditorHeight = 17;
            this.cmb_DevFactory.EvenRowStyle = style210;
            this.cmb_DevFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_DevFactory.FooterStyle = style211;
            this.cmb_DevFactory.GapHeight = 2;
            this.cmb_DevFactory.HeadingStyle = style212;
            this.cmb_DevFactory.HighLightRowStyle = style213;
            this.cmb_DevFactory.ItemHeight = 15;
            this.cmb_DevFactory.Location = new System.Drawing.Point(109, 135);
            this.cmb_DevFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_DevFactory.MaxDropDownItems = ((short)(5));
            this.cmb_DevFactory.MaxLength = 1;
            this.cmb_DevFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_DevFactory.Name = "cmb_DevFactory";
            this.cmb_DevFactory.OddRowStyle = style214;
            this.cmb_DevFactory.PartialRightColumn = false;
            this.cmb_DevFactory.PropBag = resources.GetString("cmb_DevFactory.PropBag");
            this.cmb_DevFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_DevFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_DevFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_DevFactory.SelectedStyle = style215;
            this.cmb_DevFactory.Size = new System.Drawing.Size(120, 21);
            this.cmb_DevFactory.Style = style216;
            this.cmb_DevFactory.TabIndex = 483;
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.AddItemCols = 0;
            this.cmb_Gender.AddItemSeparator = ';';
            this.cmb_Gender.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Gender.Caption = "";
            this.cmb_Gender.CaptionHeight = 17;
            this.cmb_Gender.CaptionStyle = style217;
            this.cmb_Gender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Gender.ColumnCaptionHeight = 18;
            this.cmb_Gender.ColumnFooterHeight = 18;
            this.cmb_Gender.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Gender.ContentHeight = 17;
            this.cmb_Gender.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Gender.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Gender.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Gender.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Gender.EditorHeight = 17;
            this.cmb_Gender.EvenRowStyle = style218;
            this.cmb_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Gender.FooterStyle = style219;
            this.cmb_Gender.GapHeight = 2;
            this.cmb_Gender.HeadingStyle = style220;
            this.cmb_Gender.HighLightRowStyle = style221;
            this.cmb_Gender.ItemHeight = 15;
            this.cmb_Gender.Location = new System.Drawing.Point(349, 66);
            this.cmb_Gender.MatchEntryTimeout = ((long)(2000));
            this.cmb_Gender.MaxDropDownItems = ((short)(5));
            this.cmb_Gender.MaxLength = 1;
            this.cmb_Gender.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.OddRowStyle = style222;
            this.cmb_Gender.PartialRightColumn = false;
            this.cmb_Gender.PropBag = resources.GetString("cmb_Gender.PropBag");
            this.cmb_Gender.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Gender.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Gender.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Gender.SelectedStyle = style223;
            this.cmb_Gender.Size = new System.Drawing.Size(120, 21);
            this.cmb_Gender.Style = style224;
            this.cmb_Gender.TabIndex = 4;
            // 
            // lbl_ConfShoes
            // 
            this.lbl_ConfShoes.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ConfShoes.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ConfShoes.ImageIndex = 0;
            this.lbl_ConfShoes.ImageList = this.img_Label;
            this.lbl_ConfShoes.Location = new System.Drawing.Point(248, 159);
            this.lbl_ConfShoes.Name = "lbl_ConfShoes";
            this.lbl_ConfShoes.Size = new System.Drawing.Size(100, 21);
            this.lbl_ConfShoes.TabIndex = 471;
            this.lbl_ConfShoes.Text = "Conf Shoes";
            this.lbl_ConfShoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_DevFactory
            // 
            this.lbl_DevFactory.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_DevFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_DevFactory.ImageIndex = 0;
            this.lbl_DevFactory.ImageList = this.img_Label;
            this.lbl_DevFactory.Location = new System.Drawing.Point(8, 135);
            this.lbl_DevFactory.Name = "lbl_DevFactory";
            this.lbl_DevFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_DevFactory.TabIndex = 470;
            this.lbl_DevFactory.Text = "Dev Factory";
            this.lbl_DevFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Season
            // 
            this.cmb_Season.AddItemCols = 0;
            this.cmb_Season.AddItemSeparator = ';';
            this.cmb_Season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Season.Caption = "";
            this.cmb_Season.CaptionHeight = 17;
            this.cmb_Season.CaptionStyle = style225;
            this.cmb_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Season.ColumnCaptionHeight = 18;
            this.cmb_Season.ColumnFooterHeight = 18;
            this.cmb_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Season.ContentHeight = 17;
            this.cmb_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Season.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Season.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Season.EditorHeight = 17;
            this.cmb_Season.EvenRowStyle = style226;
            this.cmb_Season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Season.FooterStyle = style227;
            this.cmb_Season.GapHeight = 2;
            this.cmb_Season.HeadingStyle = style228;
            this.cmb_Season.HighLightRowStyle = style229;
            this.cmb_Season.ItemHeight = 15;
            this.cmb_Season.Location = new System.Drawing.Point(109, 88);
            this.cmb_Season.MatchEntryTimeout = ((long)(2000));
            this.cmb_Season.MaxDropDownItems = ((short)(5));
            this.cmb_Season.MaxLength = 1;
            this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Season.Name = "cmb_Season";
            this.cmb_Season.OddRowStyle = style230;
            this.cmb_Season.PartialRightColumn = false;
            this.cmb_Season.PropBag = resources.GetString("cmb_Season.PropBag");
            this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Season.SelectedStyle = style231;
            this.cmb_Season.Size = new System.Drawing.Size(120, 21);
            this.cmb_Season.Style = style232;
            this.cmb_Season.TabIndex = 486;
            // 
            // lbl_Season
            // 
            this.lbl_Season.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Season.ImageIndex = 0;
            this.lbl_Season.ImageList = this.img_Label;
            this.lbl_Season.Location = new System.Drawing.Point(8, 88);
            this.lbl_Season.Name = "lbl_Season";
            this.lbl_Season.Size = new System.Drawing.Size(100, 21);
            this.lbl_Season.TabIndex = 468;
            this.lbl_Season.Text = "Season";
            this.lbl_Season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Gender.ImageIndex = 0;
            this.lbl_Gender.ImageList = this.img_Label;
            this.lbl_Gender.Location = new System.Drawing.Point(248, 66);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_Gender.TabIndex = 463;
            this.lbl_Gender.Text = "Gender";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ConfShoes
            // 
            this.cmb_ConfShoes.AddItemCols = 0;
            this.cmb_ConfShoes.AddItemSeparator = ';';
            this.cmb_ConfShoes.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ConfShoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ConfShoes.Caption = "";
            this.cmb_ConfShoes.CaptionHeight = 17;
            this.cmb_ConfShoes.CaptionStyle = style233;
            this.cmb_ConfShoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ConfShoes.ColumnCaptionHeight = 18;
            this.cmb_ConfShoes.ColumnFooterHeight = 18;
            this.cmb_ConfShoes.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ConfShoes.ContentHeight = 17;
            this.cmb_ConfShoes.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ConfShoes.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ConfShoes.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ConfShoes.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ConfShoes.EditorHeight = 17;
            this.cmb_ConfShoes.EvenRowStyle = style234;
            this.cmb_ConfShoes.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_ConfShoes.FooterStyle = style235;
            this.cmb_ConfShoes.GapHeight = 2;
            this.cmb_ConfShoes.HeadingStyle = style236;
            this.cmb_ConfShoes.HighLightRowStyle = style237;
            this.cmb_ConfShoes.ItemHeight = 15;
            this.cmb_ConfShoes.Location = new System.Drawing.Point(349, 159);
            this.cmb_ConfShoes.MatchEntryTimeout = ((long)(2000));
            this.cmb_ConfShoes.MaxDropDownItems = ((short)(5));
            this.cmb_ConfShoes.MaxLength = 1;
            this.cmb_ConfShoes.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ConfShoes.Name = "cmb_ConfShoes";
            this.cmb_ConfShoes.OddRowStyle = style238;
            this.cmb_ConfShoes.PartialRightColumn = false;
            this.cmb_ConfShoes.PropBag = resources.GetString("cmb_ConfShoes.PropBag");
            this.cmb_ConfShoes.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ConfShoes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ConfShoes.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ConfShoes.SelectedStyle = style239;
            this.cmb_ConfShoes.Size = new System.Drawing.Size(120, 21);
            this.cmb_ConfShoes.Style = style240;
            this.cmb_ConfShoes.TabIndex = 485;
            // 
            // txt_LastCd
            // 
            this.txt_LastCd.BackColor = System.Drawing.Color.White;
            this.txt_LastCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LastCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_LastCd.Location = new System.Drawing.Point(109, 159);
            this.txt_LastCd.MaxLength = 5;
            this.txt_LastCd.Name = "txt_LastCd";
            this.txt_LastCd.Size = new System.Drawing.Size(120, 21);
            this.txt_LastCd.TabIndex = 487;
            // 
            // cmb_TestChk
            // 
            this.cmb_TestChk.AddItemCols = 0;
            this.cmb_TestChk.AddItemSeparator = ';';
            this.cmb_TestChk.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_TestChk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_TestChk.Caption = "";
            this.cmb_TestChk.CaptionHeight = 17;
            this.cmb_TestChk.CaptionStyle = style241;
            this.cmb_TestChk.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_TestChk.ColumnCaptionHeight = 18;
            this.cmb_TestChk.ColumnFooterHeight = 18;
            this.cmb_TestChk.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_TestChk.ContentHeight = 17;
            this.cmb_TestChk.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_TestChk.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_TestChk.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TestChk.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_TestChk.EditorHeight = 17;
            this.cmb_TestChk.EvenRowStyle = style242;
            this.cmb_TestChk.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_TestChk.FooterStyle = style243;
            this.cmb_TestChk.GapHeight = 2;
            this.cmb_TestChk.HeadingStyle = style244;
            this.cmb_TestChk.HighLightRowStyle = style245;
            this.cmb_TestChk.ItemHeight = 15;
            this.cmb_TestChk.Location = new System.Drawing.Point(109, 182);
            this.cmb_TestChk.MatchEntryTimeout = ((long)(2000));
            this.cmb_TestChk.MaxDropDownItems = ((short)(5));
            this.cmb_TestChk.MaxLength = 1;
            this.cmb_TestChk.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_TestChk.Name = "cmb_TestChk";
            this.cmb_TestChk.OddRowStyle = style246;
            this.cmb_TestChk.PartialRightColumn = false;
            this.cmb_TestChk.PropBag = resources.GetString("cmb_TestChk.PropBag");
            this.cmb_TestChk.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_TestChk.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_TestChk.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_TestChk.SelectedStyle = style247;
            this.cmb_TestChk.Size = new System.Drawing.Size(120, 21);
            this.cmb_TestChk.Style = style248;
            this.cmb_TestChk.TabIndex = 484;
            // 
            // lbl_TestChk
            // 
            this.lbl_TestChk.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_TestChk.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_TestChk.ImageIndex = 0;
            this.lbl_TestChk.ImageList = this.img_Label;
            this.lbl_TestChk.Location = new System.Drawing.Point(8, 182);
            this.lbl_TestChk.Name = "lbl_TestChk";
            this.lbl_TestChk.Size = new System.Drawing.Size(100, 21);
            this.lbl_TestChk.TabIndex = 472;
            this.lbl_TestChk.Text = "Trial";
            this.lbl_TestChk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Remark
            // 
            this.txt_Remark.BackColor = System.Drawing.Color.White;
            this.txt_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remark.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Remark.Location = new System.Drawing.Point(109, 271);
            this.txt_Remark.MaxLength = 30;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(360, 21);
            this.txt_Remark.TabIndex = 492;
            // 
            // lbl_Remark
            // 
            this.lbl_Remark.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Remark.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Remark.ImageIndex = 0;
            this.lbl_Remark.ImageList = this.img_Label;
            this.lbl_Remark.Location = new System.Drawing.Point(8, 271);
            this.lbl_Remark.Name = "lbl_Remark";
            this.lbl_Remark.Size = new System.Drawing.Size(100, 21);
            this.lbl_Remark.TabIndex = 491;
            this.lbl_Remark.Text = "Remark";
            this.lbl_Remark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Dev_Code
            // 
            this.cmb_Dev_Code.AddItemCols = 0;
            this.cmb_Dev_Code.AddItemSeparator = ';';
            this.cmb_Dev_Code.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Dev_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Dev_Code.Caption = "";
            this.cmb_Dev_Code.CaptionHeight = 17;
            this.cmb_Dev_Code.CaptionStyle = style249;
            this.cmb_Dev_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Dev_Code.ColumnCaptionHeight = 18;
            this.cmb_Dev_Code.ColumnFooterHeight = 18;
            this.cmb_Dev_Code.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Dev_Code.ContentHeight = 17;
            this.cmb_Dev_Code.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Dev_Code.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Dev_Code.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Dev_Code.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Dev_Code.EditorHeight = 17;
            this.cmb_Dev_Code.EvenRowStyle = style250;
            this.cmb_Dev_Code.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Dev_Code.FooterStyle = style251;
            this.cmb_Dev_Code.GapHeight = 2;
            this.cmb_Dev_Code.HeadingStyle = style252;
            this.cmb_Dev_Code.HighLightRowStyle = style253;
            this.cmb_Dev_Code.ItemHeight = 15;
            this.cmb_Dev_Code.Location = new System.Drawing.Point(230, 321);
            this.cmb_Dev_Code.MatchEntryTimeout = ((long)(2000));
            this.cmb_Dev_Code.MaxDropDownItems = ((short)(5));
            this.cmb_Dev_Code.MaxLength = 1;
            this.cmb_Dev_Code.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Dev_Code.Name = "cmb_Dev_Code";
            this.cmb_Dev_Code.OddRowStyle = style254;
            this.cmb_Dev_Code.PartialRightColumn = false;
            this.cmb_Dev_Code.PropBag = resources.GetString("cmb_Dev_Code.PropBag");
            this.cmb_Dev_Code.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Dev_Code.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Dev_Code.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Dev_Code.SelectedStyle = style255;
            this.cmb_Dev_Code.Size = new System.Drawing.Size(240, 21);
            this.cmb_Dev_Code.Style = style256;
            this.cmb_Dev_Code.TabIndex = 511;
            this.cmb_Dev_Code.SelectedValueChanged += new System.EventHandler(this.cmb_Dev_Code_SelectedValueChanged);
            // 
            // Pop_DC_Style
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(490, 512);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_DC_Style";
            this.Load += new System.EventHandler(this.Pop_DC_Style_Load);
            this.Closed += new System.EventHandler(this.Pop_DC_Style_Closed);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_btn.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Bom_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Bom_Level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Siluette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Presto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Currency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Upper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DevFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ConfShoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TestChk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Dev_Code)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		
		private void txt_StyleNo_TextChanged(object sender, System.EventArgs e)
		{
			if ( txt_StyleNo.Text.Length  != 9)  return;

			Set_Dev_Info();

		}



		private void Pop_DC_Style_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);		
		}

		private void cmb_Year_TextChanged(object sender, System.EventArgs e)
		{
			this.Cmb_YearSelectedValueChangedProcess();
		}

		private void txt_StyleNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.numeric_Type(e);


		}

		private void chk_Manual_CheckedChanged(object sender, System.EventArgs e)
		{
			Set_Dev_Info();
		}

		private void cmb_Dev_Code_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cmb_Dev_Code.SelectedIndex   == -1) return;
			txt_DevCode.Text  = cmb_Dev_Code.SelectedValue.ToString();
		}

		private void cmb_Bom_Id_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cmb_Bom_Id.SelectedIndex   == -1) return;
			txt_Bom_Id.Text  = cmb_Bom_Id.SelectedValue.ToString();
		}

		private void cmb_Bom_Level_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cmb_Bom_Level.SelectedIndex   == -1) return;
			txt_Bom_Level.Text  = cmb_Bom_Level.SelectedValue.ToString();
		}


		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Btn_ApplyClickProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region 공통 메서드



		private void Set_Dev_Info()
		{
			


			try
			{
				txt_Bom_Id.Clear();
				txt_Bom_Level.Clear();
				txt_DevCode.Clear();
				cmb_Dev_Code.ClearItems();
				cmb_Bom_Id.ClearItems();
				cmb_Bom_Level.ClearItems();


				if (chk_Manual.Checked  == true)  //manual
				{

					DataTable vDt = null;
					string vStyle_Cd  = "";
					string vStyle_Name ="";

					txt_DevCode.Enabled  = true;
					txt_Bom_Id.Enabled  = true;
					txt_Bom_Level.Enabled  = true;


					// Dev Code
					vDt = SELECT_SDC_BOM_EACH_INFO(vStyle_Cd,vStyle_Name,"1");
					COM.ComCtl.Set_ComboList(vDt, this.cmb_Dev_Code, 0, 0, false, 0, 100);
					vDt.Dispose();

					// Bom Id
					vDt = SELECT_SDC_BOM_EACH_INFO(vStyle_Cd,vStyle_Name,"2");
					COM.ComCtl.Set_ComboList(vDt, this.cmb_Bom_Id, 0, 0, false,0, 100);
					vDt.Dispose();

					// Bom Level
					vDt = SELECT_SDC_BOM_EACH_INFO(vStyle_Cd,vStyle_Name,"3");
					COM.ComCtl.Set_ComboList(vDt, this.cmb_Bom_Level, 0, 0, false, 0, 100);
					vDt.Dispose();




				}
				else
				{
             
					DataTable vDt = null;
					string vStyle_Cd  = txt_StyleNo.Text;
					string vStyle_Name ="";   // txt_StyleName.Text;

					txt_DevCode.Enabled  = false;
					txt_Bom_Id.Enabled  = false;
					txt_Bom_Level.Enabled  = false;


					// Dev Code
					vDt = SELECT_SDC_BOM_INFO(vStyle_Cd,vStyle_Name);

					

					COM.ComCtl.Set_ComboList(vDt, this.cmb_Dev_Code, 0, 0, false, 0, 100);	
					if (vDt.Rows.Count != 0) 
					{
						cmb_Dev_Code.SelectedIndex   = 0;
						txt_DevCode.Text  = cmb_Dev_Code.Columns[1].Text;
					}
	
					 
					// Bom Id
					COM.ComCtl.Set_ComboList(vDt, this.cmb_Bom_Id, 1, 1, false,0, 100);
					if (vDt.Rows.Count != 0)
					{
						cmb_Bom_Id.SelectedIndex   = 0;
						txt_Bom_Id.Text  =  cmb_Bom_Id.Columns[1].Text;
					}
					vDt.Dispose();

					// Bom Level
					COM.ComCtl.Set_ComboList(vDt, this.cmb_Bom_Level, 2, 2, false, 0, 100);
					if (vDt.Rows.Count != 0)
					{
						cmb_Bom_Level.SelectedIndex   = 0;
						txt_Bom_Level.Text   =  cmb_Bom_Level.Columns[1].Text;
					}
					vDt.Dispose();





				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_Dev_Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		// Get data from control
		private string[] GetData(string arg_div)
		{ 


			_data[0]										= arg_div;
			_data[(int)ClassLib.TBSDC_STYLE.IxSTYLE_CD]		= this.txt_StyleNo.Text;
			_data[(int)ClassLib.TBSDC_STYLE.IxMODEL_CD]		= COM.ComFunction.Empty_Combo(this.cmb_Model, "");
			_data[(int)ClassLib.TBSDC_STYLE.IxSTYLE_NAME]   = this.txt_StyleName.Text;
			_data[(int)ClassLib.TBSDC_STYLE.IxSTYLE_YEAR]   = COM.ComFunction.Empty_Combo(this.cmb_Year, "");
			_data[(int)ClassLib.TBSDC_STYLE.IxSEASON]		= COM.ComFunction.Empty_Combo(this.cmb_Season, "");
			_data[(int)ClassLib.TBSDC_STYLE.IxDEV_FACT]		= COM.ComFunction.Empty_Combo(this.cmb_DevFactory, "");
			_data[(int)ClassLib.TBSDC_STYLE.IxDEV_CD]		= this.txt_DevCode.Text;
			_data[(int)ClassLib.TBSDC_STYLE.IxCFM_CHK]		= COM.ComFunction.Empty_Combo(this.cmb_ConfShoes, "");
			_data[(int)ClassLib.TBSDC_STYLE.IxTEST_CHK]		= COM.ComFunction.Empty_Combo(this.cmb_TestChk, ""); 
			_data[(int)ClassLib.TBSDC_STYLE.IxUPPER_CHK]	= COM.ComFunction.Empty_Combo(this.cmb_Upper, "");
			_data[(int)ClassLib.TBSDC_STYLE.IxBOTTOM_CHK]	= COM.ComFunction.Empty_Combo(this.cmb_Bottom, ""); 
			_data[(int)ClassLib.TBSDC_STYLE.IxGENDER]		= COM.ComFunction.Empty_Combo(this.cmb_Gender, "");
			_data[(int)ClassLib.TBSDC_STYLE.IxLAST_CD]		= this.txt_LastCd.Text; 
			_data[(int)ClassLib.TBSDC_STYLE.IxSILUET]		= COM.ComFunction.Empty_Combo(this.cmb_Siluette, "");
			_data[(int)ClassLib.TBSDC_STYLE.IxCURRENCY]		= COM.ComFunction.Empty_Combo(this.cmb_Currency, ""); 
			_data[(int)ClassLib.TBSDC_STYLE.IxCOST]		    = this.txt_Cost.Text;
			_data[(int)ClassLib.TBSDC_STYLE.IxB_COST]		= this.txt_BCost.Text; 
			_data[(int)ClassLib.TBSDC_STYLE.IxPRESTO_YN]	= COM.ComFunction.Empty_Combo(this.cmb_Presto, "");
			_data[(int)ClassLib.TBSDC_STYLE.IxWIDTH_DIV]	= COM.ComFunction.Empty_Combo(this.cmb_Width, ""); 
			_data[(int)ClassLib.TBSDC_STYLE.IxREMARKS]		= this.txt_Remark.Text;
			_data[(int)ClassLib.TBSDC_STYLE.IxBOM_ID]		= this.txt_Bom_Id.Text;
			_data[(int)ClassLib.TBSDC_STYLE.IxBOM_REV]		= this.txt_Bom_Level.Text;
			_data[(int)ClassLib.TBSDC_STYLE.IxUPD_YMD]		= "";
			_data[(int)ClassLib.TBSDC_STYLE.IxUPD_USER]     = COM.ComVar.This_User;

			return _data;
		}

		// Set data to control from datatable
		private void SetDataFromDataTable(DataTable arg_dt)
		{
			try
			{
				if (arg_dt.Rows.Count > 0)
				{ 

					this.txt_StyleNo.Text				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxSTYLE_CD - 1].ToString();
					this.txt_StyleName.Text				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxSTYLE_NAME - 1].ToString(); 
					this.cmb_Year.SelectedValue			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxSTYLE_YEAR - 1].ToString();
					this.cmb_Season.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxSEASON - 1].ToString();
					this.cmb_Model.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxMODEL_CD - 1].ToString();
					this.cmb_DevFactory.SelectedValue	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxDEV_FACT - 1].ToString();
					this.txt_DevCode.Text				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxDEV_CD - 1].ToString(); 
					this.cmb_ConfShoes.SelectedValue	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxCFM_CHK - 1].ToString(); 
					this.cmb_TestChk.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxTEST_CHK - 1].ToString();
					this.cmb_Upper.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxUPPER_CHK - 1].ToString();
					this.cmb_Bottom.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxBOTTOM_CHK - 1].ToString();
					this.cmb_Gender.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxGENDER - 1].ToString();
					this.txt_LastCd.Text				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxLAST_CD - 1].ToString();
					this.cmb_Siluette.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxSILUET - 1].ToString();
					this.cmb_Currency.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxCURRENCY - 1].ToString();
					this.txt_Cost.Text					= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxCOST - 1].ToString();
					this.txt_BCost.Text					= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxB_COST - 1].ToString();
					this.cmb_Presto.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxPRESTO_YN - 1].ToString();
					this.cmb_Width.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxWIDTH_DIV - 1].ToString(); 
					this.txt_Remark.Text				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxREMARKS - 1].ToString();
					this.txt_Bom_Id.Text 				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxBOM_ID - 1].ToString();
					this.txt_Bom_Level.Text 			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_STYLE.IxBOM_REV  - 1].ToString();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Set data to control from parameter_popup
		private void SetDataFromParameter()
		{
			try
			{
//				this.txt_ModelCd.Text			 = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxMODEL_CD];
//				this.txt_Name.Text				 = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxMODEL_NAME];
//				this.cmb_Category.SelectedValue  = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxCATEGORY];
//				this.txt_Pattern.Text			 = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxPATTERN];
//				this.cmb_ToolCd.SelectedValue    = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxTOOL_CD];
//				this.cmb_SetPh.SelectedValue     = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_PH];
//				this.cmb_SetPhSpu.SelectedValue  = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_PH_SPU];
//				this.cmb_PhType.SelectedValue    = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxPH_TYPE];
//				this.cmb_SetHpu.SelectedValue    = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_HPU];
//				this.cmb_SetHpuSpu.SelectedValue = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_HPU_SPU];
//				this.cmb_SetSpu.SelectedValue    = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_SPU];
//				this.txt_Remark.Text			 = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxREMARKS];
//
//				this.cmb_Year.SelectedValue      = txt_ModelCd.Text.ToString().Substring(0,2);
//				this.cmb_Season.SelectedValue    = txt_ModelCd.Text.ToString().Substring(2,2);
				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//		// string(yyyy-mm-dd) to DateTime
		//		private DateTime StringToDateTime(string strDate)
		//		{
		//			if (strDate != null || !strDate.Equals(""))
		//				return new DateTime(Convert.ToInt32(strDate.Substring(0, 4)), Convert.ToInt32(strDate.Substring(5, 2)), Convert.ToInt32(strDate.Substring(8, 2)));
		//			else
		//				return System.DateTime.Now;
		//		}

//		// create combo
//		public void CreateComboBox(C1.Win.C1List.C1Combo arg_cmb, string[] code, string[] name)
//		{
//			int i;
//			
//			try
//			{
//				arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem; 
//				arg_cmb.ClearItems(); 
//
//				arg_cmb.AddItemTitles("Unit;Code"); 
//			
//				arg_cmb.ValueMember = "Unit";
//				arg_cmb.DisplayMember = "Code";
//			
//				for(i = 0 ; i < code.Length ; i++) 
//					arg_cmb.AddItem(code[i] + ";" + name[i]);
//		
//				arg_cmb.SelectedIndex = -1;  
//
//				arg_cmb.MaxDropDownItems = 10;
//				arg_cmb.Splits[0].DisplayColumns[0].Width = 50;
//				arg_cmb.Splits[0].DisplayColumns[1].Width = 150;
//				arg_cmb.Splits[0].DisplayColumns[0].Visible = false;
//
//				arg_cmb.ExtendRightColumn = true;
//				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show(ex.Message.ToString(),"Set_ComboList_AddItem",MessageBoxButtons.OK,MessageBoxIcon.Error );
//			}
//		}

		#endregion
		
		#region 이벤트 처리 메서드

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			 
			//Title
			this.Text = "Style Master";
            lbl_MainTitle.Text = "Style Master"; 
            ClassLib.ComFunction.SetLangDic(this);
			ClassLib.ComFunction.Init_Form_Control(this);
 
			
			DataTable vDt = null;

			// Gender Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxGen);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Gender, 1, 2, false, 40, 100);
			vDt.Dispose();

			// Develop Factory Setting
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt,  cmb_DevFactory,  0,  1,  false, 50, 130);
			cmb_DevFactory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose();

			// Confirm Shoes Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_ConfShoes, 1, 2, false, 40, 100);
			vDt.Dispose();

			// Test Chk Y/N Setting 
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_TestChk, 1, 2, false, 40, 100);
			vDt.Dispose();

			// Year Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxYear);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Year, 1, 2, false,40 ,104);
			vDt.Dispose();

			// Season Setting   seasonCode
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxSeason);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Season, 1, 2, false, 40, 100);
			vDt.Dispose();



			// Presto
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Presto, 1, 2, false, 40, 100);
			vDt.Dispose();

			// Siluette
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxSillhuoette);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Siluette, 1, 2, false, 40, 100);
			vDt.Dispose();

			// Upper chk
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Upper, 1, 2, false, 40, 100);
			vDt.Dispose();

			// Bottom chk
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Bottom, 1, 2, false, 40, 100);
			vDt.Dispose();

			// Currency
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxMonetaryUnit);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Currency, 1, 2, false, 40, 100);
			vDt.Dispose();

			// Width division
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxWidthDivision);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Width, 1, 2, false, 40, 100);
			vDt.Dispose();


			//DevInforation enable
			chk_Manual.Checked = false;
			txt_DevCode.Enabled  = false;
			txt_DevCode.Enabled  = false;
			txt_DevCode.Enabled  = false;


 

			if (COM.ComVar.Parameter_PopUp != null && COM.ComVar.Parameter_PopUp[0].Equals(ClassLib.ComVar.Update))
			{
				SetDataFromDataTable( SELECT_SDC_STYLE(COM.ComVar.Parameter_PopUp[1]));
				this.txt_StyleNo.Enabled   = false;
				this.txt_StyleName.Enabled = false;
			}
			else if (COM.ComVar.Parameter_PopUp != null && COM.ComVar.Parameter_PopUp[0].Equals(ClassLib.ComVar.Insert))
				SetDataFromParameter();
			else
			{
				this.txt_StyleNo.Enabled = true; 
			}
		}


		
			
		private bool check_dev_info()
		{
			if (chk_Manual.Checked  == true)
			{

				if ((txt_DevCode.Text =="") || (txt_DevCode.Text == null))
				{

					ClassLib.ComFunction.User_Message("Dev Code Check");
					return false;
				}

				if ((txt_Bom_Id.Text =="") || (txt_Bom_Id.Text == null))
				{

					ClassLib.ComFunction.User_Message("Bom Id Check");
					return false;
				}


				if ((txt_Bom_Level.Text  =="") || (txt_Bom_Level.Text == null))
				{

					ClassLib.ComFunction.User_Message("Bom Level Check");
					return false;
				}



			}

			return true;
		}


		private void Cmb_YearSelectedValueChangedProcess()
		{
			this.cmb_Model.SelectedValueChanged -= _cmbModelEvent;

			DataTable vDt = this.SELECT_SDC_MODEL(this.cmb_Year.SelectedValue.ToString());
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Model, 0, 1,  false, 60, 200);
			//cmb_Model.Splits[0].DisplayColumns[1].Visible = false;
			vDt.Dispose();

			this.cmb_Model.SelectedValueChanged += _cmbModelEvent;
		}

		private void Btn_VirtualContainerClickProcess()
		{
			//			this.cmb_contNo.SelectedValueChanged -= _cmbContNoEvent;
			//			this.txt_contNo.TextChanged -= _txtContNoEvent;
			//			txt_contNo.Text = "";
			//			CreateComboBox(cmb_contNo, new string[]{"40FT", "40FT", "40FT", "40FT", "40FT"}, new string[]{"Virtual001", "Virtual002", "Virtual003", "Virtual004", "Virtual005"});
			//			this.txt_contNo.TextChanged += _txtContNoEvent;
			//			this.cmb_contNo.SelectedValueChanged += _cmbContNoEvent;
		}

		private void Btn_ApplyClickProcess()
		{
			if(this.txt_StyleNo.Text != "" && this.txt_StyleName.Text != "" 
				&& ClassLib.ComFunction.Empty_TextBox(txt_DevCode, "") != "" && ClassLib.ComFunction.Empty_Combo(cmb_Width, "") != "")
			{
				bool check_exist = false;
				string vStyleCd   = "";

//				if(COM.ComVar.Parameter_PopUp[0].Equals(ClassLib.ComVar.Insert) )
//				{
//					// true : 중복 발생, false : 신규 처리 가능
//					vStyleCd = this.txt_StyleNo.Text;
//				
//					check_exist = CHECK_MODEL_EXIST(vStyleCd);
//
//
//					if(!check_exist)
//					{
//						COM.ComVar.Parameter_PopUp = GetData(ClassLib.ComVar.Insert);
//						this.DialogResult = DialogResult.OK;
//						Close(); 
//					}
//					else
//					{
//						ClassLib.ComFunction.User_Message("Duplicate Style");
//					}
//
//
//				}
//				else
//				{
//					COM.ComVar.Parameter_PopUp = GetData(ClassLib.ComVar.Update);
//					Close(); 
//
//				}



				// true : 중복 발생, false : 신규 처리 가능
				vStyleCd = this.txt_StyleNo.Text;

				check_exist = CHECK_MODEL_EXIST(vStyleCd);


				if(!check_exist)
				{
					
					if (!check_dev_info()) return;
					
					COM.ComVar.Parameter_PopUp = GetData(ClassLib.ComVar.Insert);
					this.DialogResult = DialogResult.OK;
					Close(); 
				}
				else
				{
					ClassLib.ComFunction.User_Message("Duplicate Style");
				}
 
				
			}
			else
			{
				if(txt_StyleNo.Text == "")   
				{
				    ClassLib.ComFunction.User_Message("Select Style No");
					return;
				}

				if(txt_StyleName.Text == "")
				{
					ClassLib.ComFunction.User_Message("Select Style Name");
					return;
				}

				if(ClassLib.ComFunction.Empty_TextBox(txt_DevCode, "") == "")  
				{
					ClassLib.ComFunction.User_Message("Select Develop Code");
					return;
				}

				if(ClassLib.ComFunction.Empty_Combo(cmb_Width, "") == "")  
				{
					ClassLib.ComFunction.User_Message("Select Width Division");
					return;
				}

			}

		}

		#endregion

		#region DB Connect


		
		/// <summary>
		/// CHECK_MODEL_EXIST : 모델명 중복 체크
		/// </summary>
		/// <param name="arg_style_cd">  style cd</param>
		/// <returns>true : 중복 발생, false : 신규 처리 가능</returns>
		private bool CHECK_MODEL_EXIST(string arg_style_cd)
		{ 

			try
			{
				COM.OraDB MyOraDB = new COM.OraDB(); 
				DataSet ds_ret;
				string exist_yn = "";
 
				MyOraDB.ReDim_Parameter(2);  

				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);

				MyOraDB.Process_Name = "PKG_SDC_STYLE.CHECK_STYLE_EXIST";
  
				MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
			 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 
			    
				MyOraDB.Parameter_Values[0] = arg_style_cd; 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);


				if(ds_ret == null) return false; 
				exist_yn = ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 

				if(exist_yn == "Y")
					return true;
				else
					return false;

			}
			catch
			{
				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
				return false;

			}

		}

		/// <summary>
		/// PKG_SDC_STYLE : 
		/// </summary>
		/// <param name="arg_modelCd"></param>
		/// <returns>DataTable : 결과테이블</returns>
		public DataTable SELECT_SDC_STYLE(string arg_style_cd)
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(3);
		
				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);


				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SDC_STYLE.SELECT_SDC_STYLE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_NAME";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_style_cd;
				MyOraDB.Parameter_Values[1] = "";
				MyOraDB.Parameter_Values[2] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();

				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);


				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];

			}
			catch
			{
				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
				return null;

			}
		}


		
			
		/// <summary>
		/// CHECK_STYLE_EXIST : CHECK_STYLE_EXIST
		/// </summary>
		/// <param name="arg_style_cd">  style cd</param>
		/// <returns>DataTable : 결과테이블</returns>
		private bool CHECK_STYLE_EXIST(string arg_style_cd)
		{ 

			try
			{
				COM.OraDB MyOraDB = new COM.OraDB(); 
				DataSet ds_ret;
				string exist_yn = "";
 
				MyOraDB.ReDim_Parameter(2);  

				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);

				MyOraDB.Process_Name = "PKG_SDC_STYLE.CHECK_STYLE_EXIST";
  
				MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
			 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 
			    
				MyOraDB.Parameter_Values[0] = arg_style_cd; 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);


				if(ds_ret == null) return false; 
				exist_yn = ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 

				if(exist_yn == "Y")
					return true;
				else
					return false;

			}
			catch
			{
				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
				return false;

			}

		}


		
		/// <summary>
		/// SELECT_SDC_BOM_EACH_INFO :  SR NO
		/// </summary>
		/// <param name="arg_modelCd"></param>
		/// <returns>DataTable : 결과테이블</returns>
		public DataTable SELECT_SDC_BOM_EACH_INFO(string arg_style_cd, string arg_style_name, string arg_flag)
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(4);
		
				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);


				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SDC_STYLE.SELECT_SDC_BOM_EACH_INFO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_NAME";
				MyOraDB.Parameter_Name[2] = "ARG_FLAG";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_style_cd;
				MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_style_name," ");
				MyOraDB.Parameter_Values[2] = arg_flag;
				MyOraDB.Parameter_Values[3] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();

				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);


	
				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];

			}
			catch
			{
				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
				return null;

			}
		}

		/// <summary>
		/// SELECT_SDC_BOM_INFO :  SR NO
		/// </summary>
		/// <param name="arg_modelCd"></param>
		/// <returns>DataTable : 결과테이블</returns>
		public DataTable SELECT_SDC_BOM_INFO(string arg_style_cd, string arg_style_name)
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(3);
		
				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);


				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SDC_STYLE.SELECT_SDC_BOM_INFO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_NAME";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_style_cd;
				MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_style_name," ");
				MyOraDB.Parameter_Values[2] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();

				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);


	
				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];

			}
			catch
			{
				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
				return null;

			}
		}





		
		/// <summary>
		/// PKG_SDC_MODEL : 
		/// </summary>
		/// <param name="arg_modelCd"></param>
		/// <returns>DataTable : 결과테이블</returns>
		public DataTable SELECT_SDC_MODEL(string arg_modelCd)
		{


			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(5);

			//Webservice Change - DS 
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);


			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SDC_MODEL.SELECT_SDC_MODEL";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_MODEL_CD";
			MyOraDB.Parameter_Name[1] = "ARG_MODEL_NAME";
			MyOraDB.Parameter_Name[2] = "ARG_YEAR";
			MyOraDB.Parameter_Name[3] = "ARG_SEASON_CODE";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_modelCd;
			MyOraDB.Parameter_Values[1] = "";
			MyOraDB.Parameter_Values[2] = "";
			MyOraDB.Parameter_Values[3] = "";
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();


			//Webservice Change - This Factory  
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);


			if(ds_ret == null) return null ;

			return ds_ret.Tables[MyOraDB.Process_Name];

		}


		#endregion  
	
		#region 정합성 체크


		#endregion

		private void Pop_DC_Style_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

	


	}
}

