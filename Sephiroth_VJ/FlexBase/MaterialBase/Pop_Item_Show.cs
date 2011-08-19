using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Data.OleDb; 
using System.Data.SqlClient; 
using System.Text;


using System.Runtime.Serialization.Formatters.Binary; 



namespace FlexBase.MaterialBase
{
	public class Pop_Item_Show : COM.PCHWinForm.Pop_Medium
	{

		#region 컨트롤 정의 및 리소스 정리
 

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private FlatTabControl.FlatTabControl tab_Item;
		private System.Windows.Forms.TabPage tab_General;
		private System.Windows.Forms.DateTimePicker cmb_Reg_Ymd;
		private System.Windows.Forms.TextBox txt_ReMark;
		private System.Windows.Forms.TextBox txt_Item_Name5;
		private System.Windows.Forms.TextBox txt_Item_Name4;
		private System.Windows.Forms.Label lbl_Item_Name4;
		private System.Windows.Forms.Label lbl_Item_Name5;
		private System.Windows.Forms.TextBox txt_Item_Name3;
		private System.Windows.Forms.TextBox txt_Item_Name2;
		private System.Windows.Forms.Label lbl_Item_Name2;
		private System.Windows.Forms.Label lbl_Item_Name3;
		private System.Windows.Forms.Label lbl_Item_Name1;
		private System.Windows.Forms.TextBox txt_Item_Name1;
		private System.Windows.Forms.TextBox txt_Group_CD;
		private System.Windows.Forms.Label lbl_Item_CD;
		private System.Windows.Forms.TabPage tab_MRP;
		private C1.Win.C1List.C1Combo cmb_Out_Wh_Cd;
		private System.Windows.Forms.TabPage tab_Roul;
		private System.Windows.Forms.TabPage tab_Dim;
		private System.Windows.Forms.TextBox txt_Net_Weight;
		private System.Windows.Forms.TextBox txt_Mcs_No;
		private System.Windows.Forms.TextBox txt_Hs_No;
		private System.Windows.Forms.TextBox txt_Height;
		private System.Windows.Forms.TextBox txt_Width;
		private System.Windows.Forms.TextBox txt_Length;
		private System.Windows.Forms.TextBox txt_Volume;
		private System.Windows.Forms.TextBox txt_Gross_Weight;
		private System.Windows.Forms.TabPage tab_Unit;
		private C1.Win.C1List.C1Combo cmb_Cbd_Currency;
		private C1.Win.C1List.C1Combo cmb_Pur_Currency;
		private C1.Win.C1List.C1Combo cmb_Abc_Div;
		private C1.Win.C1List.C1Combo cmb_Stock_Unit;
		private C1.Win.C1List.C1Combo cmb_Buy_Div;
		private C1.Win.C1List.C1Combo cmb_Style_Item_Div;
		private System.Windows.Forms.TabPage tab_Catalog;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btn_Save;
		private C1.Win.C1List.C1Combo cmb_Processing_Currency;
		private System.Windows.Forms.Label lbl_Processing_;
		private C1.Win.C1List.C1Combo cmb_Man_Charge_QD;
		private C1.Win.C1List.C1Combo cmb_Man_Charge_VJ;
		private C1.Win.C1List.C1Combo cmb_Man_Charge_DS;
		private System.Windows.Forms.Label lbl_Ship_Loss_Rate;
		private System.Windows.Forms.Label lbl_Out_Loss_Rate;
		private System.Windows.Forms.Label lbl_Pur_Loss_Rate;
		private System.Windows.Forms.Label lbl_Out_Wh_Cd;
		private System.Windows.Forms.Label lbl_In_Wh_Cd;
		private C1.Win.C1List.C1Combo cmb_In_Wh_Cd;
		private System.Windows.Forms.TextBox txt_Item_CD;
		private System.Windows.Forms.TextBox txt_Copy_From_Name;
		private System.Windows.Forms.TextBox txt_Copy_From_CD;
		private C1.Win.C1List.C1Combo cmb_Cus_Cd_VJ;
		private C1.Win.C1List.C1Combo cmb_Cus_Cd_QD;
		private C1.Win.C1List.C1Combo cmb_Cus_Cd_DS;
		private C1.Win.C1List.C1Combo cmb_Insp_YN;
		private C1.Win.C1List.C1Combo cmb_Use_YN;
		private C1.Win.C1List.C1Combo cmb_Size_YN;
		private C1.Win.C1List.C1Combo cmb_Processing_YN;
		private C1.Win.C1List.C1Combo cmb_Cost_YN;
		private C1.Win.C1List.C1Combo cmb_Acc_Div_YN;
		private C1.Win.C1List.C1Combo cmb_Acc_Div_VJ;
		private C1.Win.C1List.C1Combo cmb_Acc_Div_QD;
		private C1.Win.C1List.C1Combo cmb_Acc_Div_DS;
		private C1.Win.C1List.C1Combo cmb_Import_DS;
		private C1.Win.C1List.C1Combo cmb_Import_QD;
		private C1.Win.C1List.C1Combo cmb_Import_VJ;
		private C1.Win.C1List.C1Combo cmb_Life_YN;
		private System.Windows.Forms.Label lbl_Reg_Ymd;
		private System.Windows.Forms.Label lbl_ReMark;
		private System.Windows.Forms.Label lbl_Copy_From;
		private System.Windows.Forms.Label lbl_Rep_Item_CD;
		private System.Windows.Forms.Label lbl_Use_YN;
		private System.Windows.Forms.Label lbl_Size_YN;
		private System.Windows.Forms.Label lbl_Group_CD;
		private System.Windows.Forms.Label lbl_Processing_Price;
		private System.Windows.Forms.Label lbl_Processing_YN;
		private System.Windows.Forms.Label lbl_Cbd_Currency;
		private System.Windows.Forms.Label lbl_Cbd_Price;
		private System.Windows.Forms.Label lbl_Pur_Currency;
		private System.Windows.Forms.Label lbl_Pur_Price;
		private System.Windows.Forms.Label lbl_Insp_YN;
		private System.Windows.Forms.Label lbl_Abc_Div;
		private System.Windows.Forms.Label lbl_Stock_Unit;
		private System.Windows.Forms.Label lbl_Buy_Div;
		private System.Windows.Forms.Label lbl_Style_Item_Div;
		private System.Windows.Forms.Label lbl_Pk_Qty;
		private System.Windows.Forms.Label lbl_Acc_Div_Ds;
		private System.Windows.Forms.Label lbl_Acc_Div_Vj;
		private System.Windows.Forms.Label lbl_Acc_Div_Qd;
		private System.Windows.Forms.Label lbl_Acc_Div_YN;
		private System.Windows.Forms.Label lbl_Cost_YN;
		private System.Windows.Forms.Label lbl_Import_VJ;
		private System.Windows.Forms.Label lbl_Import_QD;
		private System.Windows.Forms.Label lbl_Import_DS;
		private System.Windows.Forms.Label lbl_Man_Charge_VJ;
		private System.Windows.Forms.Label lbl_Man_Charge_QD;
		private System.Windows.Forms.Label lbl_Man_Charge_DS;
		private System.Windows.Forms.Label lbl_Cus_Cd_VJ;
		private System.Windows.Forms.Label lbl_Cus_Cd_QD;
		private System.Windows.Forms.Label lbl_Cus_Cd_DS;
		private System.Windows.Forms.Label lbl_Life_Day;
		private System.Windows.Forms.Label lbl_Life_YN;
		private System.Windows.Forms.Label lbl_Safe_Amt_Vj;
		private System.Windows.Forms.Label lbl_Safe_Amt_Qd;
		private System.Windows.Forms.Label lbl_Safe_Amt_Ds;
		private System.Windows.Forms.Label lbl_Lone_Yn;
		private System.Windows.Forms.Label lbl_Net_Weight;
		private System.Windows.Forms.Label lbl_Hs_No;
		private System.Windows.Forms.Label lbl_Prod_In_Lot;
		private System.Windows.Forms.Label lbl_Mcs_No;
		private System.Windows.Forms.Label lbl_Cbm;
		private System.Windows.Forms.Label lbl_Pur_Lot_Amt;
		private System.Windows.Forms.Label lbl_Height;
		private System.Windows.Forms.Label lbl_Width;
		private System.Windows.Forms.Label lbl_Length;
		private System.Windows.Forms.Label lbl_Volume;
		private System.Windows.Forms.Label lbl_Gross_Weight;
		private C1.Win.C1List.C1Combo cmb_Lone_YN;
		private C1.Win.C1Input.C1NumericEdit txt_Pk_Qty;
		private C1.Win.C1Input.C1NumericEdit txt_Pur_Price;
		private C1.Win.C1Input.C1NumericEdit txt_Cbd_Price;
		private C1.Win.C1Input.C1NumericEdit txt_Processing_Price;
		private C1.Win.C1Input.C1NumericEdit txt_Safe_Amt_QD;
		private C1.Win.C1Input.C1NumericEdit txt_Safe_Amt_DS;
		private C1.Win.C1Input.C1NumericEdit txt_Life_Day;
		private C1.Win.C1Input.C1NumericEdit txt_Safe_Amt_VJ;
		private C1.Win.C1Input.C1NumericEdit txt_Out_Loss_Rate;
		private C1.Win.C1Input.C1NumericEdit txt_Ship_Loss_Rate;
		private C1.Win.C1Input.C1NumericEdit txt_Pur_Loss_Rate;
		private C1.Win.C1Input.C1NumericEdit txt_Item_Conv;
		private System.Windows.Forms.Label lbl_Item_Conv;
		private System.Windows.Forms.TextBox txt_Rep_Item_Name;
		private System.Windows.Forms.TextBox txt_Rep_Item_CD;
		private System.Windows.Forms.Label btn_SearchItem;
		private System.Windows.Forms.Label btn_SearchGroup;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private System.Windows.Forms.Label lbl_image_name;
		private C1.Win.C1Input.C1PictureBox picb_item;
		private System.Windows.Forms.OpenFileDialog oFileDlg;
		private System.Windows.Forms.GroupBox groupBox11;
		private C1.Win.C1List.C1Combo cmb_Spec_Type;
		private System.Windows.Forms.Label lbl_Spec_Type;
		private C1.Win.C1List.C1Combo cmb_Mng_Unit;
		private System.Windows.Forms.TextBox txt_Cus_Cd_DS;
		private System.Windows.Forms.TextBox txt_Cus_Cd_QD;
		private System.Windows.Forms.TextBox txt_Cus_Cd_VJ;
		private System.Windows.Forms.TextBox txt_Man_Charge_DS;
		private System.Windows.Forms.TextBox txt_Man_Charge_QD;
		private System.Windows.Forms.TextBox txt_Man_Charge_VJ;
		private System.Windows.Forms.Label btn_AddGroup;
		private System.Windows.Forms.Label btn_FileOpen;
		private COM.SSP sgrid_Image;
		private FarPoint.Win.Spread.SheetView sgrid_Image_Sheet1;
		private System.Windows.Forms.TextBox txt_image_name;
		private System.Windows.Forms.Label lbl_Mng_Unit;
		private System.Windows.Forms.TextBox txt_Pur_Lot_Amt;
		private System.Windows.Forms.TextBox txt_Prod_In_Lot;
		private System.Windows.Forms.TextBox txt_cbm;
		private System.Windows.Forms.GroupBox gbox_General2;
		private System.Windows.Forms.GroupBox gbox_General1;
		private System.Windows.Forms.GroupBox gbox_Role2;
		private System.Windows.Forms.GroupBox gbox_Role1;
		private System.Windows.Forms.GroupBox gbox_MRP2;
		private System.Windows.Forms.GroupBox gbox_MRP1;
		private System.Windows.Forms.GroupBox gbox_Dim2;
		private System.Windows.Forms.GroupBox gbox_Dim1;
		private System.Windows.Forms.GroupBox gbox_Unit2;
		private System.Windows.Forms.GroupBox gbox_Unit1;
		private System.Windows.Forms.Label btn_Search_Image;
		private System.Windows.Forms.Label btn_Save_Image;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1List.C1Combo cmb_Group_Type;
		private C1.Win.C1List.C1Combo cmb_Group_M;
		private C1.Win.C1List.C1Combo cmb_Group_L;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1List.C1Combo cmb_trade_group;
		private System.Windows.Forms.TabPage tab_MachineInfor;
		private C1.Win.C1Input.C1NumericEdit txt_Dl_Days_VJ;
		private C1.Win.C1Input.C1NumericEdit txt_Dl_Days_QD;
		private C1.Win.C1Input.C1NumericEdit txt_Dl_Days_DS;
		private System.Windows.Forms.Label lbl_Dl_Days_Vj;
		private System.Windows.Forms.Label lbl_Dl_Days_Qd;
        private System.Windows.Forms.Label lbl_Dl_Days_Ds;
        private Label lbl_Dl_Days_JJ;
        private C1.Win.C1List.C1Combo cmb_Import_JJ;
        private Label lbl_Import_JJ;
        private Label lbl_Acc_Div_JJ;
        private C1.Win.C1List.C1Combo cmb_Acc_Div_JJ;
        private TextBox txt_Man_Charge_JJ;
        private Label lbl_Man_Charge_JJ;
        private C1.Win.C1List.C1Combo cmb_Man_Charge_JJ;
        private C1.Win.C1List.C1Combo cmb_Cus_Cd_JJ;
        private TextBox txt_Cus_Cd_JJ;
        private Label lbl_Cus_Cd_JJ;
        private C1.Win.C1Input.C1NumericEdit txt_Dl_Days_JJ;
        private Label lbl_Safe_Amt_JJ;
        private C1.Win.C1Input.C1NumericEdit txt_Safe_Amt_JJ;
		private System.ComponentModel.IContainer components = null;



		#endregion

		#region 생성자, 소멸자



		public Pop_Item_Show()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();
 
			Init_Form();


		}



		private bool _ReturnYN = false;

		public Pop_Item_Show(bool arg_returnyn)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();
 

			_ReturnYN = arg_returnyn;

			Init_Form();


		}




		public string _Division = "";
		public string _ItemCD = "";
		public string _Group_Type = "";
		public string _Group_L = "";


		public Pop_Item_Show(string arg_Division, string arg_item_cd, string arg_group_type, string arg_group_l)
		{

			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();


			_Division = arg_Division;
			_ItemCD = arg_item_cd;
			_Group_Type = arg_group_type;
			_Group_L = arg_group_l;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Item_Show));
            C1.Win.C1List.Style style313 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style314 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style315 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style316 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style317 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style318 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style319 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style320 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style321 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style322 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style323 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style324 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style325 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style326 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style327 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style328 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style329 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style330 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style331 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style332 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style333 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style334 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style335 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style336 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style337 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style338 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style339 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style340 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style341 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style342 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style343 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style344 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style345 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style346 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style347 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style348 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style349 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style350 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style351 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style352 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style353 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style354 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style355 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style356 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style357 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style358 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style359 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style360 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style361 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style362 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style363 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style364 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style365 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style366 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style367 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style368 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style369 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style370 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style371 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style372 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style373 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style374 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style375 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style376 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style377 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style378 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style379 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style380 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style381 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style382 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style383 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style384 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style385 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style386 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style387 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style388 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style389 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style390 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style391 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style392 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style393 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style394 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style395 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style396 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style397 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style398 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style399 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style400 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style401 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style402 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style403 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style404 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style405 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style406 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style407 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style408 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style409 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style410 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style411 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style412 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style413 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style414 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style415 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style416 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style417 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style418 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style419 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style420 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style421 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style422 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style423 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style424 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style425 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style426 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style427 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style428 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style429 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style430 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style431 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style432 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style433 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style434 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style435 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style436 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style437 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style438 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style439 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style440 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style441 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style442 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style443 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style444 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style445 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style446 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style447 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style448 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style449 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style450 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style451 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style452 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style453 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style454 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style455 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style456 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style457 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style458 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style459 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style460 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style461 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style462 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style463 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style464 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style465 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style466 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style467 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style468 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style469 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style470 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style471 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style472 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style473 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style474 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style475 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style476 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style477 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style478 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style479 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style480 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style481 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style482 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style483 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style484 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style485 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style486 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style487 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style488 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style489 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style490 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style491 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style492 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style493 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style494 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style495 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style496 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style497 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style498 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style499 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style500 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style501 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style502 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style503 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style504 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style505 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style506 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style507 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style508 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style509 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style510 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style511 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style512 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style513 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style514 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style515 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style516 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style517 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style518 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style519 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style520 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style521 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style522 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style523 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style524 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style525 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style526 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style527 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style528 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style529 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style530 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style531 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style532 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style533 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style534 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style535 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style536 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style537 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style538 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style539 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style540 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style541 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style542 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style543 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style544 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style545 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style546 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style547 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style548 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style549 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style550 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style551 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style552 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style553 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style554 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style555 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style556 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style557 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style558 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style559 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style560 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style561 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style562 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style563 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style564 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style565 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style566 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style567 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style568 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style569 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style570 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style571 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style572 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style573 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style574 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style575 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style576 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style577 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style578 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style579 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style580 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style581 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style582 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style583 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style584 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style585 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style586 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style587 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style588 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style589 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style590 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style591 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style592 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style593 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style594 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style595 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style596 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style597 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style598 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style599 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style600 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style601 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style602 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style603 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style604 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style605 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style606 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style607 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style608 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style609 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style610 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style611 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style612 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style613 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style614 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style615 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style616 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style617 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style618 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style619 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style620 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style621 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style622 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style623 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style624 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Label();
            this.tab_Item = new FlatTabControl.FlatTabControl();
            this.tab_General = new System.Windows.Forms.TabPage();
            this.gbox_General2 = new System.Windows.Forms.GroupBox();
            this.cmb_Spec_Type = new C1.Win.C1List.C1Combo();
            this.lbl_Spec_Type = new System.Windows.Forms.Label();
            this.cmb_Mng_Unit = new C1.Win.C1List.C1Combo();
            this.lbl_Mng_Unit = new System.Windows.Forms.Label();
            this.cmb_Use_YN = new C1.Win.C1List.C1Combo();
            this.lbl_Use_YN = new System.Windows.Forms.Label();
            this.cmb_Size_YN = new C1.Win.C1List.C1Combo();
            this.btn_SearchItem = new System.Windows.Forms.Label();
            this.txt_Rep_Item_Name = new System.Windows.Forms.TextBox();
            this.txt_Rep_Item_CD = new System.Windows.Forms.TextBox();
            this.txt_Copy_From_Name = new System.Windows.Forms.TextBox();
            this.txt_Copy_From_CD = new System.Windows.Forms.TextBox();
            this.cmb_Reg_Ymd = new System.Windows.Forms.DateTimePicker();
            this.lbl_Reg_Ymd = new System.Windows.Forms.Label();
            this.txt_ReMark = new System.Windows.Forms.TextBox();
            this.lbl_ReMark = new System.Windows.Forms.Label();
            this.lbl_Copy_From = new System.Windows.Forms.Label();
            this.lbl_Rep_Item_CD = new System.Windows.Forms.Label();
            this.lbl_Size_YN = new System.Windows.Forms.Label();
            this.gbox_General1 = new System.Windows.Forms.GroupBox();
            this.cmb_trade_group = new C1.Win.C1List.C1Combo();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Group_Type = new C1.Win.C1List.C1Combo();
            this.cmb_Group_M = new C1.Win.C1List.C1Combo();
            this.cmb_Group_L = new C1.Win.C1List.C1Combo();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddGroup = new System.Windows.Forms.Label();
            this.btn_SearchGroup = new System.Windows.Forms.Label();
            this.txt_Item_CD = new System.Windows.Forms.TextBox();
            this.txt_Item_Name5 = new System.Windows.Forms.TextBox();
            this.txt_Item_Name4 = new System.Windows.Forms.TextBox();
            this.lbl_Item_Name4 = new System.Windows.Forms.Label();
            this.lbl_Item_Name5 = new System.Windows.Forms.Label();
            this.txt_Item_Name3 = new System.Windows.Forms.TextBox();
            this.txt_Item_Name2 = new System.Windows.Forms.TextBox();
            this.lbl_Item_Name2 = new System.Windows.Forms.Label();
            this.lbl_Item_Name3 = new System.Windows.Forms.Label();
            this.lbl_Item_Name1 = new System.Windows.Forms.Label();
            this.txt_Item_Name1 = new System.Windows.Forms.TextBox();
            this.txt_Group_CD = new System.Windows.Forms.TextBox();
            this.lbl_Group_CD = new System.Windows.Forms.Label();
            this.lbl_Item_CD = new System.Windows.Forms.Label();
            this.tab_Unit = new System.Windows.Forms.TabPage();
            this.gbox_Unit2 = new System.Windows.Forms.GroupBox();
            this.txt_Processing_Price = new C1.Win.C1Input.C1NumericEdit();
            this.txt_Cbd_Price = new C1.Win.C1Input.C1NumericEdit();
            this.txt_Pur_Price = new C1.Win.C1Input.C1NumericEdit();
            this.cmb_Processing_Currency = new C1.Win.C1List.C1Combo();
            this.lbl_Processing_ = new System.Windows.Forms.Label();
            this.cmb_Processing_YN = new C1.Win.C1List.C1Combo();
            this.lbl_Processing_Price = new System.Windows.Forms.Label();
            this.lbl_Processing_YN = new System.Windows.Forms.Label();
            this.cmb_Cbd_Currency = new C1.Win.C1List.C1Combo();
            this.lbl_Cbd_Currency = new System.Windows.Forms.Label();
            this.lbl_Cbd_Price = new System.Windows.Forms.Label();
            this.cmb_Pur_Currency = new C1.Win.C1List.C1Combo();
            this.lbl_Pur_Currency = new System.Windows.Forms.Label();
            this.lbl_Pur_Price = new System.Windows.Forms.Label();
            this.gbox_Unit1 = new System.Windows.Forms.GroupBox();
            this.txt_Pk_Qty = new C1.Win.C1Input.C1NumericEdit();
            this.txt_Item_Conv = new C1.Win.C1Input.C1NumericEdit();
            this.lbl_Item_Conv = new System.Windows.Forms.Label();
            this.cmb_Stock_Unit = new C1.Win.C1List.C1Combo();
            this.lbl_Stock_Unit = new System.Windows.Forms.Label();
            this.cmb_Buy_Div = new C1.Win.C1List.C1Combo();
            this.lbl_Buy_Div = new System.Windows.Forms.Label();
            this.cmb_Style_Item_Div = new C1.Win.C1List.C1Combo();
            this.lbl_Style_Item_Div = new System.Windows.Forms.Label();
            this.lbl_Pk_Qty = new System.Windows.Forms.Label();
            this.lbl_Abc_Div = new System.Windows.Forms.Label();
            this.cmb_Abc_Div = new C1.Win.C1List.C1Combo();
            this.lbl_Insp_YN = new System.Windows.Forms.Label();
            this.cmb_Insp_YN = new C1.Win.C1List.C1Combo();
            this.tab_Roul = new System.Windows.Forms.TabPage();
            this.gbox_Role2 = new System.Windows.Forms.GroupBox();
            this.txt_Dl_Days_JJ = new C1.Win.C1Input.C1NumericEdit();
            this.lbl_Dl_Days_JJ = new System.Windows.Forms.Label();
            this.cmb_Import_JJ = new C1.Win.C1List.C1Combo();
            this.lbl_Import_JJ = new System.Windows.Forms.Label();
            this.lbl_Acc_Div_JJ = new System.Windows.Forms.Label();
            this.cmb_Acc_Div_JJ = new C1.Win.C1List.C1Combo();
            this.txt_Man_Charge_JJ = new System.Windows.Forms.TextBox();
            this.lbl_Man_Charge_JJ = new System.Windows.Forms.Label();
            this.cmb_Man_Charge_JJ = new C1.Win.C1List.C1Combo();
            this.cmb_Cus_Cd_JJ = new C1.Win.C1List.C1Combo();
            this.txt_Cus_Cd_JJ = new System.Windows.Forms.TextBox();
            this.lbl_Cus_Cd_JJ = new System.Windows.Forms.Label();
            this.txt_Dl_Days_VJ = new C1.Win.C1Input.C1NumericEdit();
            this.lbl_Dl_Days_Vj = new System.Windows.Forms.Label();
            this.cmb_Import_VJ = new C1.Win.C1List.C1Combo();
            this.lbl_Import_VJ = new System.Windows.Forms.Label();
            this.lbl_Acc_Div_Vj = new System.Windows.Forms.Label();
            this.cmb_Acc_Div_VJ = new C1.Win.C1List.C1Combo();
            this.txt_Man_Charge_VJ = new System.Windows.Forms.TextBox();
            this.lbl_Man_Charge_VJ = new System.Windows.Forms.Label();
            this.cmb_Man_Charge_VJ = new C1.Win.C1List.C1Combo();
            this.cmb_Cus_Cd_VJ = new C1.Win.C1List.C1Combo();
            this.txt_Cus_Cd_VJ = new System.Windows.Forms.TextBox();
            this.lbl_Cus_Cd_VJ = new System.Windows.Forms.Label();
            this.gbox_Role1 = new System.Windows.Forms.GroupBox();
            this.txt_Man_Charge_DS = new System.Windows.Forms.TextBox();
            this.txt_Dl_Days_QD = new C1.Win.C1Input.C1NumericEdit();
            this.txt_Cus_Cd_DS = new System.Windows.Forms.TextBox();
            this.cmb_Man_Charge_DS = new C1.Win.C1List.C1Combo();
            this.lbl_Dl_Days_Qd = new System.Windows.Forms.Label();
            this.lbl_Acc_Div_Qd = new System.Windows.Forms.Label();
            this.lbl_Man_Charge_DS = new System.Windows.Forms.Label();
            this.cmb_Acc_Div_QD = new C1.Win.C1List.C1Combo();
            this.cmb_Cus_Cd_DS = new C1.Win.C1List.C1Combo();
            this.cmb_Import_QD = new C1.Win.C1List.C1Combo();
            this.lbl_Cus_Cd_DS = new System.Windows.Forms.Label();
            this.lbl_Import_DS = new System.Windows.Forms.Label();
            this.lbl_Import_QD = new System.Windows.Forms.Label();
            this.cmb_Import_DS = new C1.Win.C1List.C1Combo();
            this.lbl_Dl_Days_Ds = new System.Windows.Forms.Label();
            this.txt_Dl_Days_DS = new C1.Win.C1Input.C1NumericEdit();
            this.lbl_Acc_Div_Ds = new System.Windows.Forms.Label();
            this.cmb_Acc_Div_DS = new C1.Win.C1List.C1Combo();
            this.lbl_Cost_YN = new System.Windows.Forms.Label();
            this.cmb_Acc_Div_YN = new C1.Win.C1List.C1Combo();
            this.lbl_Acc_Div_YN = new System.Windows.Forms.Label();
            this.cmb_Man_Charge_QD = new C1.Win.C1List.C1Combo();
            this.cmb_Cus_Cd_QD = new C1.Win.C1List.C1Combo();
            this.txt_Man_Charge_QD = new System.Windows.Forms.TextBox();
            this.cmb_Cost_YN = new C1.Win.C1List.C1Combo();
            this.lbl_Man_Charge_QD = new System.Windows.Forms.Label();
            this.lbl_Cus_Cd_QD = new System.Windows.Forms.Label();
            this.txt_Cus_Cd_QD = new System.Windows.Forms.TextBox();
            this.tab_MRP = new System.Windows.Forms.TabPage();
            this.gbox_MRP2 = new System.Windows.Forms.GroupBox();
            this.lbl_Safe_Amt_JJ = new System.Windows.Forms.Label();
            this.txt_Safe_Amt_JJ = new C1.Win.C1Input.C1NumericEdit();
            this.txt_Out_Loss_Rate = new C1.Win.C1Input.C1NumericEdit();
            this.txt_Ship_Loss_Rate = new C1.Win.C1Input.C1NumericEdit();
            this.txt_Pur_Loss_Rate = new C1.Win.C1Input.C1NumericEdit();
            this.lbl_Ship_Loss_Rate = new System.Windows.Forms.Label();
            this.lbl_Out_Loss_Rate = new System.Windows.Forms.Label();
            this.lbl_Pur_Loss_Rate = new System.Windows.Forms.Label();
            this.txt_Safe_Amt_QD = new C1.Win.C1Input.C1NumericEdit();
            this.lbl_Safe_Amt_Vj = new System.Windows.Forms.Label();
            this.lbl_Safe_Amt_Qd = new System.Windows.Forms.Label();
            this.lbl_Safe_Amt_Ds = new System.Windows.Forms.Label();
            this.txt_Safe_Amt_DS = new C1.Win.C1Input.C1NumericEdit();
            this.txt_Safe_Amt_VJ = new C1.Win.C1Input.C1NumericEdit();
            this.gbox_MRP1 = new System.Windows.Forms.GroupBox();
            this.txt_Life_Day = new C1.Win.C1Input.C1NumericEdit();
            this.cmb_Life_YN = new C1.Win.C1List.C1Combo();
            this.lbl_Life_Day = new System.Windows.Forms.Label();
            this.lbl_Life_YN = new System.Windows.Forms.Label();
            this.cmb_Lone_YN = new C1.Win.C1List.C1Combo();
            this.lbl_Lone_Yn = new System.Windows.Forms.Label();
            this.cmb_In_Wh_Cd = new C1.Win.C1List.C1Combo();
            this.cmb_Out_Wh_Cd = new C1.Win.C1List.C1Combo();
            this.lbl_Out_Wh_Cd = new System.Windows.Forms.Label();
            this.lbl_In_Wh_Cd = new System.Windows.Forms.Label();
            this.tab_Dim = new System.Windows.Forms.TabPage();
            this.gbox_Dim2 = new System.Windows.Forms.GroupBox();
            this.txt_Net_Weight = new System.Windows.Forms.TextBox();
            this.lbl_Net_Weight = new System.Windows.Forms.Label();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.lbl_Cbm = new System.Windows.Forms.Label();
            this.txt_Length = new System.Windows.Forms.TextBox();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.txt_Gross_Weight = new System.Windows.Forms.TextBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.lbl_Gross_Weight = new System.Windows.Forms.Label();
            this.txt_cbm = new System.Windows.Forms.TextBox();
            this.gbox_Dim1 = new System.Windows.Forms.GroupBox();
            this.txt_Prod_In_Lot = new System.Windows.Forms.TextBox();
            this.txt_Pur_Lot_Amt = new System.Windows.Forms.TextBox();
            this.txt_Mcs_No = new System.Windows.Forms.TextBox();
            this.lbl_Mcs_No = new System.Windows.Forms.Label();
            this.lbl_Pur_Lot_Amt = new System.Windows.Forms.Label();
            this.txt_Hs_No = new System.Windows.Forms.TextBox();
            this.lbl_Hs_No = new System.Windows.Forms.Label();
            this.lbl_Prod_In_Lot = new System.Windows.Forms.Label();
            this.tab_Catalog = new System.Windows.Forms.TabPage();
            this.sgrid_Image = new COM.SSP();
            this.sgrid_Image_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txt_image_name = new System.Windows.Forms.TextBox();
            this.btn_FileOpen = new System.Windows.Forms.Label();
            this.lbl_image_name = new System.Windows.Forms.Label();
            this.btn_Save_Image = new System.Windows.Forms.Label();
            this.btn_Search_Image = new System.Windows.Forms.Label();
            this.picb_item = new C1.Win.C1Input.C1PictureBox();
            this.tab_MachineInfor = new System.Windows.Forms.TabPage();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.oFileDlg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_Item.SuspendLayout();
            this.tab_General.SuspendLayout();
            this.gbox_General2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Spec_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mng_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Use_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Size_YN)).BeginInit();
            this.gbox_General1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_trade_group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_L)).BeginInit();
            this.tab_Unit.SuspendLayout();
            this.gbox_Unit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Processing_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cbd_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pur_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Processing_Currency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Processing_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cbd_Currency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Pur_Currency)).BeginInit();
            this.gbox_Unit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pk_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Item_Conv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Stock_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Buy_Div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style_Item_Div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Abc_Div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Insp_YN)).BeginInit();
            this.tab_Roul.SuspendLayout();
            this.gbox_Role2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dl_Days_JJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Import_JJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_JJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_JJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cus_Cd_JJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dl_Days_VJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Import_VJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_VJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_VJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cus_Cd_VJ)).BeginInit();
            this.gbox_Role1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dl_Days_QD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_QD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cus_Cd_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Import_QD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Import_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dl_Days_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_QD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cus_Cd_QD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cost_YN)).BeginInit();
            this.tab_MRP.SuspendLayout();
            this.gbox_MRP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Safe_Amt_JJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Out_Loss_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ship_Loss_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pur_Loss_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Safe_Amt_QD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Safe_Amt_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Safe_Amt_VJ)).BeginInit();
            this.gbox_MRP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Life_Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Life_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Lone_YN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_In_Wh_Cd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Out_Wh_Cd)).BeginInit();
            this.tab_Dim.SuspendLayout();
            this.gbox_Dim2.SuspendLayout();
            this.gbox_Dim1.SuspendLayout();
            this.tab_Catalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgrid_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgrid_Image_Sheet1)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.tab_Item);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c1Sizer1.GridDefinition = "89.9532710280374:False:False;8.17757009345794:False:False;\t98.8472622478386:False" +
                ":False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 39);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.SplitterWidth = 0;
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Location = new System.Drawing.Point(4, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 35);
            this.panel1.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Save.ImageIndex = 11;
            this.btn_Save.ImageList = this.image_List;
            this.btn_Save.Location = new System.Drawing.Point(600, 8);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 23);
            this.btn_Save.TabIndex = 72;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // tab_Item
            // 
            this.tab_Item.Controls.Add(this.tab_General);
            this.tab_Item.Controls.Add(this.tab_Unit);
            this.tab_Item.Controls.Add(this.tab_Roul);
            this.tab_Item.Controls.Add(this.tab_MRP);
            this.tab_Item.Controls.Add(this.tab_Dim);
            this.tab_Item.Controls.Add(this.tab_Catalog);
            this.tab_Item.Controls.Add(this.tab_MachineInfor);
            this.tab_Item.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Item.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tab_Item.ItemSize = new System.Drawing.Size(200, 30);
            this.tab_Item.Location = new System.Drawing.Point(4, 4);
            this.tab_Item.Name = "tab_Item";
            this.tab_Item.SelectedIndex = 0;
            this.tab_Item.Size = new System.Drawing.Size(686, 385);
            this.tab_Item.TabIndex = 1;
            this.tab_Item.SelectedIndexChanged += new System.EventHandler(this.tab_Item_SelectedIndexChanged);
            // 
            // tab_General
            // 
            this.tab_General.BackColor = System.Drawing.SystemColors.Window;
            this.tab_General.Controls.Add(this.gbox_General2);
            this.tab_General.Controls.Add(this.gbox_General1);
            this.tab_General.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_General.Location = new System.Drawing.Point(4, 34);
            this.tab_General.Name = "tab_General";
            this.tab_General.Size = new System.Drawing.Size(678, 347);
            this.tab_General.TabIndex = 0;
            this.tab_General.Text = "General";
            this.tab_General.ToolTipText = "General";
            // 
            // gbox_General2
            // 
            this.gbox_General2.Controls.Add(this.cmb_Spec_Type);
            this.gbox_General2.Controls.Add(this.lbl_Spec_Type);
            this.gbox_General2.Controls.Add(this.cmb_Mng_Unit);
            this.gbox_General2.Controls.Add(this.lbl_Mng_Unit);
            this.gbox_General2.Controls.Add(this.cmb_Use_YN);
            this.gbox_General2.Controls.Add(this.lbl_Use_YN);
            this.gbox_General2.Controls.Add(this.cmb_Size_YN);
            this.gbox_General2.Controls.Add(this.btn_SearchItem);
            this.gbox_General2.Controls.Add(this.txt_Rep_Item_Name);
            this.gbox_General2.Controls.Add(this.txt_Rep_Item_CD);
            this.gbox_General2.Controls.Add(this.txt_Copy_From_Name);
            this.gbox_General2.Controls.Add(this.txt_Copy_From_CD);
            this.gbox_General2.Controls.Add(this.cmb_Reg_Ymd);
            this.gbox_General2.Controls.Add(this.lbl_Reg_Ymd);
            this.gbox_General2.Controls.Add(this.txt_ReMark);
            this.gbox_General2.Controls.Add(this.lbl_ReMark);
            this.gbox_General2.Controls.Add(this.lbl_Copy_From);
            this.gbox_General2.Controls.Add(this.lbl_Rep_Item_CD);
            this.gbox_General2.Controls.Add(this.lbl_Size_YN);
            this.gbox_General2.Location = new System.Drawing.Point(340, 5);
            this.gbox_General2.Name = "gbox_General2";
            this.gbox_General2.Size = new System.Drawing.Size(327, 340);
            this.gbox_General2.TabIndex = 1;
            this.gbox_General2.TabStop = false;
            // 
            // cmb_Spec_Type
            // 
            this.cmb_Spec_Type.AddItemCols = 0;
            this.cmb_Spec_Type.AddItemSeparator = ';';
            this.cmb_Spec_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Spec_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Spec_Type.Caption = "";
            this.cmb_Spec_Type.CaptionHeight = 17;
            this.cmb_Spec_Type.CaptionStyle = style313;
            this.cmb_Spec_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Spec_Type.ColumnCaptionHeight = 18;
            this.cmb_Spec_Type.ColumnFooterHeight = 18;
            this.cmb_Spec_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Spec_Type.ContentHeight = 17;
            this.cmb_Spec_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Spec_Type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Spec_Type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Spec_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Spec_Type.EditorHeight = 17;
            this.cmb_Spec_Type.EvenRowStyle = style314;
            this.cmb_Spec_Type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Spec_Type.FooterStyle = style315;
            this.cmb_Spec_Type.GapHeight = 2;
            this.cmb_Spec_Type.HeadingStyle = style316;
            this.cmb_Spec_Type.HighLightRowStyle = style317;
            this.cmb_Spec_Type.ItemHeight = 15;
            this.cmb_Spec_Type.Location = new System.Drawing.Point(108, 35);
            this.cmb_Spec_Type.MatchEntryTimeout = ((long)(2000));
            this.cmb_Spec_Type.MaxDropDownItems = ((short)(5));
            this.cmb_Spec_Type.MaxLength = 32767;
            this.cmb_Spec_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Spec_Type.Name = "cmb_Spec_Type";
            this.cmb_Spec_Type.OddRowStyle = style318;
            this.cmb_Spec_Type.PartialRightColumn = false;
            this.cmb_Spec_Type.PropBag = resources.GetString("cmb_Spec_Type.PropBag");
            this.cmb_Spec_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Spec_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Spec_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Spec_Type.SelectedStyle = style319;
            this.cmb_Spec_Type.Size = new System.Drawing.Size(210, 21);
            this.cmb_Spec_Type.Style = style320;
            this.cmb_Spec_Type.TabIndex = 9;
            this.cmb_Spec_Type.Tag = "Y";
            // 
            // lbl_Spec_Type
            // 
            this.lbl_Spec_Type.ImageIndex = 1;
            this.lbl_Spec_Type.ImageList = this.img_Label;
            this.lbl_Spec_Type.Location = new System.Drawing.Point(7, 35);
            this.lbl_Spec_Type.Name = "lbl_Spec_Type";
            this.lbl_Spec_Type.Size = new System.Drawing.Size(100, 21);
            this.lbl_Spec_Type.TabIndex = 595;
            this.lbl_Spec_Type.Text = "Spec 단위";
            this.lbl_Spec_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Mng_Unit
            // 
            this.cmb_Mng_Unit.AddItemCols = 0;
            this.cmb_Mng_Unit.AddItemSeparator = ';';
            this.cmb_Mng_Unit.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Mng_Unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Mng_Unit.Caption = "";
            this.cmb_Mng_Unit.CaptionHeight = 17;
            this.cmb_Mng_Unit.CaptionStyle = style321;
            this.cmb_Mng_Unit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Mng_Unit.ColumnCaptionHeight = 18;
            this.cmb_Mng_Unit.ColumnFooterHeight = 18;
            this.cmb_Mng_Unit.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Mng_Unit.ContentHeight = 17;
            this.cmb_Mng_Unit.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Mng_Unit.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Mng_Unit.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mng_Unit.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Mng_Unit.EditorHeight = 17;
            this.cmb_Mng_Unit.EvenRowStyle = style322;
            this.cmb_Mng_Unit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Mng_Unit.FooterStyle = style323;
            this.cmb_Mng_Unit.GapHeight = 2;
            this.cmb_Mng_Unit.HeadingStyle = style324;
            this.cmb_Mng_Unit.HighLightRowStyle = style325;
            this.cmb_Mng_Unit.ItemHeight = 15;
            this.cmb_Mng_Unit.Location = new System.Drawing.Point(108, 13);
            this.cmb_Mng_Unit.MatchEntryTimeout = ((long)(2000));
            this.cmb_Mng_Unit.MaxDropDownItems = ((short)(5));
            this.cmb_Mng_Unit.MaxLength = 32767;
            this.cmb_Mng_Unit.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Mng_Unit.Name = "cmb_Mng_Unit";
            this.cmb_Mng_Unit.OddRowStyle = style326;
            this.cmb_Mng_Unit.PartialRightColumn = false;
            this.cmb_Mng_Unit.PropBag = resources.GetString("cmb_Mng_Unit.PropBag");
            this.cmb_Mng_Unit.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Mng_Unit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Mng_Unit.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Mng_Unit.SelectedStyle = style327;
            this.cmb_Mng_Unit.Size = new System.Drawing.Size(210, 21);
            this.cmb_Mng_Unit.Style = style328;
            this.cmb_Mng_Unit.TabIndex = 8;
            this.cmb_Mng_Unit.Tag = "Y";
            // 
            // lbl_Mng_Unit
            // 
            this.lbl_Mng_Unit.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Mng_Unit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mng_Unit.ImageIndex = 1;
            this.lbl_Mng_Unit.ImageList = this.img_Label;
            this.lbl_Mng_Unit.Location = new System.Drawing.Point(7, 13);
            this.lbl_Mng_Unit.Name = "lbl_Mng_Unit";
            this.lbl_Mng_Unit.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mng_Unit.TabIndex = 594;
            this.lbl_Mng_Unit.Text = "관리단위";
            this.lbl_Mng_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Use_YN
            // 
            this.cmb_Use_YN.AddItemCols = 0;
            this.cmb_Use_YN.AddItemSeparator = ';';
            this.cmb_Use_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Use_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Use_YN.Caption = "";
            this.cmb_Use_YN.CaptionHeight = 17;
            this.cmb_Use_YN.CaptionStyle = style329;
            this.cmb_Use_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Use_YN.ColumnCaptionHeight = 18;
            this.cmb_Use_YN.ColumnFooterHeight = 18;
            this.cmb_Use_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Use_YN.ContentHeight = 17;
            this.cmb_Use_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Use_YN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Use_YN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Use_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Use_YN.EditorHeight = 17;
            this.cmb_Use_YN.EvenRowStyle = style330;
            this.cmb_Use_YN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Use_YN.FooterStyle = style331;
            this.cmb_Use_YN.GapHeight = 2;
            this.cmb_Use_YN.HeadingStyle = style332;
            this.cmb_Use_YN.HighLightRowStyle = style333;
            this.cmb_Use_YN.ItemHeight = 15;
            this.cmb_Use_YN.Location = new System.Drawing.Point(108, 79);
            this.cmb_Use_YN.MatchEntryTimeout = ((long)(2000));
            this.cmb_Use_YN.MaxDropDownItems = ((short)(5));
            this.cmb_Use_YN.MaxLength = 32767;
            this.cmb_Use_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Use_YN.Name = "cmb_Use_YN";
            this.cmb_Use_YN.OddRowStyle = style334;
            this.cmb_Use_YN.PartialRightColumn = false;
            this.cmb_Use_YN.PropBag = resources.GetString("cmb_Use_YN.PropBag");
            this.cmb_Use_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Use_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Use_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Use_YN.SelectedStyle = style335;
            this.cmb_Use_YN.Size = new System.Drawing.Size(210, 21);
            this.cmb_Use_YN.Style = style336;
            this.cmb_Use_YN.TabIndex = 11;
            this.cmb_Use_YN.Tag = "Y";
            // 
            // lbl_Use_YN
            // 
            this.lbl_Use_YN.ImageIndex = 1;
            this.lbl_Use_YN.ImageList = this.img_Label;
            this.lbl_Use_YN.Location = new System.Drawing.Point(7, 79);
            this.lbl_Use_YN.Name = "lbl_Use_YN";
            this.lbl_Use_YN.Size = new System.Drawing.Size(100, 21);
            this.lbl_Use_YN.TabIndex = 554;
            this.lbl_Use_YN.Text = "Use";
            this.lbl_Use_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Size_YN
            // 
            this.cmb_Size_YN.AccessibleDescription = "";
            this.cmb_Size_YN.AccessibleName = "";
            this.cmb_Size_YN.AddItemCols = 0;
            this.cmb_Size_YN.AddItemSeparator = ';';
            this.cmb_Size_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Size_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Size_YN.Caption = "";
            this.cmb_Size_YN.CaptionHeight = 17;
            this.cmb_Size_YN.CaptionStyle = style337;
            this.cmb_Size_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Size_YN.ColumnCaptionHeight = 18;
            this.cmb_Size_YN.ColumnFooterHeight = 18;
            this.cmb_Size_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Size_YN.ContentHeight = 17;
            this.cmb_Size_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Size_YN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Size_YN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Size_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Size_YN.EditorHeight = 17;
            this.cmb_Size_YN.EvenRowStyle = style338;
            this.cmb_Size_YN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Size_YN.FooterStyle = style339;
            this.cmb_Size_YN.GapHeight = 2;
            this.cmb_Size_YN.HeadingStyle = style340;
            this.cmb_Size_YN.HighLightRowStyle = style341;
            this.cmb_Size_YN.ItemHeight = 15;
            this.cmb_Size_YN.Location = new System.Drawing.Point(108, 57);
            this.cmb_Size_YN.MatchEntryTimeout = ((long)(2000));
            this.cmb_Size_YN.MaxDropDownItems = ((short)(5));
            this.cmb_Size_YN.MaxLength = 32767;
            this.cmb_Size_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Size_YN.Name = "cmb_Size_YN";
            this.cmb_Size_YN.OddRowStyle = style342;
            this.cmb_Size_YN.PartialRightColumn = false;
            this.cmb_Size_YN.PropBag = resources.GetString("cmb_Size_YN.PropBag");
            this.cmb_Size_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Size_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Size_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Size_YN.SelectedStyle = style343;
            this.cmb_Size_YN.Size = new System.Drawing.Size(210, 21);
            this.cmb_Size_YN.Style = style344;
            this.cmb_Size_YN.TabIndex = 10;
            this.cmb_Size_YN.Tag = "Y";
            // 
            // btn_SearchItem
            // 
            this.btn_SearchItem.ImageIndex = 27;
            this.btn_SearchItem.ImageList = this.img_SmallButton;
            this.btn_SearchItem.Location = new System.Drawing.Point(297, 192);
            this.btn_SearchItem.Name = "btn_SearchItem";
            this.btn_SearchItem.Size = new System.Drawing.Size(21, 21);
            this.btn_SearchItem.TabIndex = 576;
            this.btn_SearchItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchItem.Visible = false;
            this.btn_SearchItem.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchItem.Click += new System.EventHandler(this.btn_SearchItem_Click);
            this.btn_SearchItem.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // txt_Rep_Item_Name
            // 
            this.txt_Rep_Item_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Rep_Item_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Rep_Item_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Rep_Item_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Rep_Item_Name.Location = new System.Drawing.Point(179, 192);
            this.txt_Rep_Item_Name.MaxLength = 10;
            this.txt_Rep_Item_Name.Name = "txt_Rep_Item_Name";
            this.txt_Rep_Item_Name.ReadOnly = true;
            this.txt_Rep_Item_Name.Size = new System.Drawing.Size(117, 21);
            this.txt_Rep_Item_Name.TabIndex = 14;
            this.txt_Rep_Item_Name.TabStop = false;
            this.txt_Rep_Item_Name.Visible = false;
            // 
            // txt_Rep_Item_CD
            // 
            this.txt_Rep_Item_CD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Rep_Item_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Rep_Item_CD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Rep_Item_CD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Rep_Item_CD.Location = new System.Drawing.Point(108, 192);
            this.txt_Rep_Item_CD.MaxLength = 10;
            this.txt_Rep_Item_CD.Name = "txt_Rep_Item_CD";
            this.txt_Rep_Item_CD.ReadOnly = true;
            this.txt_Rep_Item_CD.Size = new System.Drawing.Size(70, 21);
            this.txt_Rep_Item_CD.TabIndex = 13;
            this.txt_Rep_Item_CD.TabStop = false;
            this.txt_Rep_Item_CD.Visible = false;
            // 
            // txt_Copy_From_Name
            // 
            this.txt_Copy_From_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Copy_From_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Copy_From_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Copy_From_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Copy_From_Name.Location = new System.Drawing.Point(179, 214);
            this.txt_Copy_From_Name.MaxLength = 10;
            this.txt_Copy_From_Name.Name = "txt_Copy_From_Name";
            this.txt_Copy_From_Name.ReadOnly = true;
            this.txt_Copy_From_Name.Size = new System.Drawing.Size(139, 21);
            this.txt_Copy_From_Name.TabIndex = 16;
            this.txt_Copy_From_Name.TabStop = false;
            this.txt_Copy_From_Name.Visible = false;
            // 
            // txt_Copy_From_CD
            // 
            this.txt_Copy_From_CD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Copy_From_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Copy_From_CD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Copy_From_CD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Copy_From_CD.Location = new System.Drawing.Point(108, 214);
            this.txt_Copy_From_CD.MaxLength = 10;
            this.txt_Copy_From_CD.Name = "txt_Copy_From_CD";
            this.txt_Copy_From_CD.ReadOnly = true;
            this.txt_Copy_From_CD.Size = new System.Drawing.Size(70, 21);
            this.txt_Copy_From_CD.TabIndex = 15;
            this.txt_Copy_From_CD.TabStop = false;
            this.txt_Copy_From_CD.Visible = false;
            // 
            // cmb_Reg_Ymd
            // 
            this.cmb_Reg_Ymd.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_Reg_Ymd.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.cmb_Reg_Ymd.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.cmb_Reg_Ymd.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmb_Reg_Ymd.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.cmb_Reg_Ymd.CustomFormat = "";
            this.cmb_Reg_Ymd.Enabled = false;
            this.cmb_Reg_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmb_Reg_Ymd.Location = new System.Drawing.Point(108, 236);
            this.cmb_Reg_Ymd.Name = "cmb_Reg_Ymd";
            this.cmb_Reg_Ymd.Size = new System.Drawing.Size(212, 22);
            this.cmb_Reg_Ymd.TabIndex = 12;
            this.cmb_Reg_Ymd.TabStop = false;
            this.cmb_Reg_Ymd.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            this.cmb_Reg_Ymd.Visible = false;
            // 
            // lbl_Reg_Ymd
            // 
            this.lbl_Reg_Ymd.ImageIndex = 0;
            this.lbl_Reg_Ymd.ImageList = this.img_Label;
            this.lbl_Reg_Ymd.Location = new System.Drawing.Point(7, 236);
            this.lbl_Reg_Ymd.Name = "lbl_Reg_Ymd";
            this.lbl_Reg_Ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Reg_Ymd.TabIndex = 569;
            this.lbl_Reg_Ymd.Text = "신규등록일";
            this.lbl_Reg_Ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Reg_Ymd.Visible = false;
            // 
            // txt_ReMark
            // 
            this.txt_ReMark.BackColor = System.Drawing.Color.White;
            this.txt_ReMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReMark.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_ReMark.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_ReMark.Location = new System.Drawing.Point(108, 123);
            this.txt_ReMark.MaxLength = 500;
            this.txt_ReMark.Name = "txt_ReMark";
            this.txt_ReMark.Size = new System.Drawing.Size(210, 21);
            this.txt_ReMark.TabIndex = 17;
            // 
            // lbl_ReMark
            // 
            this.lbl_ReMark.ImageIndex = 0;
            this.lbl_ReMark.ImageList = this.img_Label;
            this.lbl_ReMark.Location = new System.Drawing.Point(7, 123);
            this.lbl_ReMark.Name = "lbl_ReMark";
            this.lbl_ReMark.Size = new System.Drawing.Size(100, 21);
            this.lbl_ReMark.TabIndex = 565;
            this.lbl_ReMark.Text = "비고";
            this.lbl_ReMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Copy_From
            // 
            this.lbl_Copy_From.ImageIndex = 0;
            this.lbl_Copy_From.ImageList = this.img_Label;
            this.lbl_Copy_From.Location = new System.Drawing.Point(7, 214);
            this.lbl_Copy_From.Name = "lbl_Copy_From";
            this.lbl_Copy_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_Copy_From.TabIndex = 558;
            this.lbl_Copy_From.Text = "복사출처";
            this.lbl_Copy_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Copy_From.Visible = false;
            // 
            // lbl_Rep_Item_CD
            // 
            this.lbl_Rep_Item_CD.ImageIndex = 0;
            this.lbl_Rep_Item_CD.ImageList = this.img_Label;
            this.lbl_Rep_Item_CD.Location = new System.Drawing.Point(7, 192);
            this.lbl_Rep_Item_CD.Name = "lbl_Rep_Item_CD";
            this.lbl_Rep_Item_CD.Size = new System.Drawing.Size(100, 21);
            this.lbl_Rep_Item_CD.TabIndex = 556;
            this.lbl_Rep_Item_CD.Text = "대표품목코드";
            this.lbl_Rep_Item_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Rep_Item_CD.Visible = false;
            // 
            // lbl_Size_YN
            // 
            this.lbl_Size_YN.ImageIndex = 1;
            this.lbl_Size_YN.ImageList = this.img_Label;
            this.lbl_Size_YN.Location = new System.Drawing.Point(7, 57);
            this.lbl_Size_YN.Name = "lbl_Size_YN";
            this.lbl_Size_YN.Size = new System.Drawing.Size(100, 21);
            this.lbl_Size_YN.TabIndex = 527;
            this.lbl_Size_YN.Text = "Size Item";
            this.lbl_Size_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbox_General1
            // 
            this.gbox_General1.Controls.Add(this.cmb_trade_group);
            this.gbox_General1.Controls.Add(this.label4);
            this.gbox_General1.Controls.Add(this.cmb_Group_Type);
            this.gbox_General1.Controls.Add(this.cmb_Group_M);
            this.gbox_General1.Controls.Add(this.cmb_Group_L);
            this.gbox_General1.Controls.Add(this.label3);
            this.gbox_General1.Controls.Add(this.label2);
            this.gbox_General1.Controls.Add(this.label1);
            this.gbox_General1.Controls.Add(this.btn_AddGroup);
            this.gbox_General1.Controls.Add(this.btn_SearchGroup);
            this.gbox_General1.Controls.Add(this.txt_Item_CD);
            this.gbox_General1.Controls.Add(this.txt_Item_Name5);
            this.gbox_General1.Controls.Add(this.txt_Item_Name4);
            this.gbox_General1.Controls.Add(this.lbl_Item_Name4);
            this.gbox_General1.Controls.Add(this.lbl_Item_Name5);
            this.gbox_General1.Controls.Add(this.txt_Item_Name3);
            this.gbox_General1.Controls.Add(this.txt_Item_Name2);
            this.gbox_General1.Controls.Add(this.lbl_Item_Name2);
            this.gbox_General1.Controls.Add(this.lbl_Item_Name3);
            this.gbox_General1.Controls.Add(this.lbl_Item_Name1);
            this.gbox_General1.Controls.Add(this.txt_Item_Name1);
            this.gbox_General1.Controls.Add(this.txt_Group_CD);
            this.gbox_General1.Controls.Add(this.lbl_Group_CD);
            this.gbox_General1.Controls.Add(this.lbl_Item_CD);
            this.gbox_General1.Location = new System.Drawing.Point(7, 5);
            this.gbox_General1.Name = "gbox_General1";
            this.gbox_General1.Size = new System.Drawing.Size(327, 340);
            this.gbox_General1.TabIndex = 0;
            this.gbox_General1.TabStop = false;
            // 
            // cmb_trade_group
            // 
            this.cmb_trade_group.AddItemCols = 0;
            this.cmb_trade_group.AddItemSeparator = ';';
            this.cmb_trade_group.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_trade_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_trade_group.Caption = "";
            this.cmb_trade_group.CaptionHeight = 17;
            this.cmb_trade_group.CaptionStyle = style345;
            this.cmb_trade_group.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_trade_group.ColumnCaptionHeight = 18;
            this.cmb_trade_group.ColumnFooterHeight = 18;
            this.cmb_trade_group.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_trade_group.ContentHeight = 17;
            this.cmb_trade_group.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_trade_group.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_trade_group.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_trade_group.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_trade_group.EditorHeight = 17;
            this.cmb_trade_group.EvenRowStyle = style346;
            this.cmb_trade_group.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_trade_group.FooterStyle = style347;
            this.cmb_trade_group.GapHeight = 2;
            this.cmb_trade_group.HeadingStyle = style348;
            this.cmb_trade_group.HighLightRowStyle = style349;
            this.cmb_trade_group.ItemHeight = 15;
            this.cmb_trade_group.Location = new System.Drawing.Point(108, 282);
            this.cmb_trade_group.MatchEntryTimeout = ((long)(2000));
            this.cmb_trade_group.MaxDropDownItems = ((short)(5));
            this.cmb_trade_group.MaxLength = 32767;
            this.cmb_trade_group.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_trade_group.Name = "cmb_trade_group";
            this.cmb_trade_group.OddRowStyle = style350;
            this.cmb_trade_group.PartialRightColumn = false;
            this.cmb_trade_group.PropBag = resources.GetString("cmb_trade_group.PropBag");
            this.cmb_trade_group.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_trade_group.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_trade_group.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_trade_group.SelectedStyle = style351;
            this.cmb_trade_group.Size = new System.Drawing.Size(210, 21);
            this.cmb_trade_group.Style = style352;
            this.cmb_trade_group.TabIndex = 595;
            this.cmb_trade_group.Tag = "Y";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageIndex = 1;
            this.label4.ImageList = this.img_Label;
            this.label4.Location = new System.Drawing.Point(7, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 596;
            this.label4.Text = "Trade Group";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Group_Type
            // 
            this.cmb_Group_Type.AddItemCols = 0;
            this.cmb_Group_Type.AddItemSeparator = ';';
            this.cmb_Group_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Group_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Group_Type.Caption = "";
            this.cmb_Group_Type.CaptionHeight = 17;
            this.cmb_Group_Type.CaptionStyle = style353;
            this.cmb_Group_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Group_Type.ColumnCaptionHeight = 18;
            this.cmb_Group_Type.ColumnFooterHeight = 18;
            this.cmb_Group_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Group_Type.ContentHeight = 17;
            this.cmb_Group_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Group_Type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Group_Type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Group_Type.EditorHeight = 17;
            this.cmb_Group_Type.Enabled = false;
            this.cmb_Group_Type.EvenRowStyle = style354;
            this.cmb_Group_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_Type.FooterStyle = style355;
            this.cmb_Group_Type.GapHeight = 2;
            this.cmb_Group_Type.HeadingStyle = style356;
            this.cmb_Group_Type.HighLightRowStyle = style357;
            this.cmb_Group_Type.ItemHeight = 15;
            this.cmb_Group_Type.Location = new System.Drawing.Point(108, 192);
            this.cmb_Group_Type.MatchEntryTimeout = ((long)(2000));
            this.cmb_Group_Type.MaxDropDownItems = ((short)(5));
            this.cmb_Group_Type.MaxLength = 32767;
            this.cmb_Group_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Group_Type.Name = "cmb_Group_Type";
            this.cmb_Group_Type.OddRowStyle = style358;
            this.cmb_Group_Type.PartialRightColumn = false;
            this.cmb_Group_Type.PropBag = resources.GetString("cmb_Group_Type.PropBag");
            this.cmb_Group_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Group_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Group_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Group_Type.SelectedStyle = style359;
            this.cmb_Group_Type.Size = new System.Drawing.Size(210, 21);
            this.cmb_Group_Type.Style = style360;
            this.cmb_Group_Type.TabIndex = 582;
            this.cmb_Group_Type.Tag = "";
            this.cmb_Group_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Group_Type_KeyPress);
            this.cmb_Group_Type.SelectedValueChanged += new System.EventHandler(this.cmb_Group_Type_SelectedValueChanged);
            // 
            // cmb_Group_M
            // 
            this.cmb_Group_M.AccessibleDescription = "";
            this.cmb_Group_M.AccessibleName = "";
            this.cmb_Group_M.AddItemCols = 0;
            this.cmb_Group_M.AddItemSeparator = ';';
            this.cmb_Group_M.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Group_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Group_M.Caption = "";
            this.cmb_Group_M.CaptionHeight = 17;
            this.cmb_Group_M.CaptionStyle = style361;
            this.cmb_Group_M.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Group_M.ColumnCaptionHeight = 18;
            this.cmb_Group_M.ColumnFooterHeight = 18;
            this.cmb_Group_M.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Group_M.ContentHeight = 16;
            this.cmb_Group_M.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Group_M.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Group_M.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_M.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Group_M.EditorHeight = 16;
            this.cmb_Group_M.Enabled = false;
            this.cmb_Group_M.EvenRowStyle = style362;
            this.cmb_Group_M.Font = new System.Drawing.Font("Verdana", 9F);
            this.cmb_Group_M.FooterStyle = style363;
            this.cmb_Group_M.GapHeight = 2;
            this.cmb_Group_M.HeadingStyle = style364;
            this.cmb_Group_M.HighLightRowStyle = style365;
            this.cmb_Group_M.ItemHeight = 15;
            this.cmb_Group_M.Location = new System.Drawing.Point(108, 235);
            this.cmb_Group_M.MatchEntryTimeout = ((long)(2000));
            this.cmb_Group_M.MaxDropDownItems = ((short)(5));
            this.cmb_Group_M.MaxLength = 32767;
            this.cmb_Group_M.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Group_M.Name = "cmb_Group_M";
            this.cmb_Group_M.OddRowStyle = style366;
            this.cmb_Group_M.PartialRightColumn = false;
            this.cmb_Group_M.PropBag = resources.GetString("cmb_Group_M.PropBag");
            this.cmb_Group_M.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Group_M.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Group_M.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Group_M.SelectedStyle = style367;
            this.cmb_Group_M.Size = new System.Drawing.Size(210, 20);
            this.cmb_Group_M.Style = style368;
            this.cmb_Group_M.TabIndex = 584;
            this.cmb_Group_M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Group_M_KeyPress);
            this.cmb_Group_M.SelectedValueChanged += new System.EventHandler(this.cmb_Group_M_SelectedValueChanged);
            // 
            // cmb_Group_L
            // 
            this.cmb_Group_L.AccessibleDescription = "";
            this.cmb_Group_L.AccessibleName = "";
            this.cmb_Group_L.AddItemCols = 0;
            this.cmb_Group_L.AddItemSeparator = ';';
            this.cmb_Group_L.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Group_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Group_L.Caption = "";
            this.cmb_Group_L.CaptionHeight = 17;
            this.cmb_Group_L.CaptionStyle = style369;
            this.cmb_Group_L.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Group_L.ColumnCaptionHeight = 18;
            this.cmb_Group_L.ColumnFooterHeight = 18;
            this.cmb_Group_L.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Group_L.ContentHeight = 16;
            this.cmb_Group_L.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Group_L.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Group_L.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_L.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Group_L.EditorHeight = 16;
            this.cmb_Group_L.Enabled = false;
            this.cmb_Group_L.EvenRowStyle = style370;
            this.cmb_Group_L.Font = new System.Drawing.Font("Verdana", 9F);
            this.cmb_Group_L.FooterStyle = style371;
            this.cmb_Group_L.GapHeight = 2;
            this.cmb_Group_L.HeadingStyle = style372;
            this.cmb_Group_L.HighLightRowStyle = style373;
            this.cmb_Group_L.ItemHeight = 15;
            this.cmb_Group_L.Location = new System.Drawing.Point(108, 214);
            this.cmb_Group_L.MatchEntryTimeout = ((long)(2000));
            this.cmb_Group_L.MaxDropDownItems = ((short)(5));
            this.cmb_Group_L.MaxLength = 32767;
            this.cmb_Group_L.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Group_L.Name = "cmb_Group_L";
            this.cmb_Group_L.OddRowStyle = style374;
            this.cmb_Group_L.PartialRightColumn = false;
            this.cmb_Group_L.PropBag = resources.GetString("cmb_Group_L.PropBag");
            this.cmb_Group_L.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Group_L.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Group_L.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Group_L.SelectedStyle = style375;
            this.cmb_Group_L.Size = new System.Drawing.Size(210, 20);
            this.cmb_Group_L.Style = style376;
            this.cmb_Group_L.TabIndex = 583;
            this.cmb_Group_L.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Group_L_KeyPress);
            this.cmb_Group_L.SelectedValueChanged += new System.EventHandler(this.cmb_Group_L_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.ImageIndex = 2;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(7, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 581;
            this.label3.Text = "Class (Second)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ImageIndex = 2;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(7, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 580;
            this.label2.Text = "Class (First)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.ImageIndex = 2;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(7, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 579;
            this.label1.Text = "Group Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_AddGroup
            // 
            this.btn_AddGroup.ImageIndex = 15;
            this.btn_AddGroup.ImageList = this.img_SmallButton;
            this.btn_AddGroup.Location = new System.Drawing.Point(201, 35);
            this.btn_AddGroup.Name = "btn_AddGroup";
            this.btn_AddGroup.Size = new System.Drawing.Size(21, 21);
            this.btn_AddGroup.TabIndex = 578;
            this.btn_AddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddGroup.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_AddGroup.Click += new System.EventHandler(this.btn_AddGroup_Click);
            this.btn_AddGroup.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn_SearchGroup
            // 
            this.btn_SearchGroup.ImageIndex = 27;
            this.btn_SearchGroup.ImageList = this.img_SmallButton;
            this.btn_SearchGroup.Location = new System.Drawing.Point(179, 35);
            this.btn_SearchGroup.Name = "btn_SearchGroup";
            this.btn_SearchGroup.Size = new System.Drawing.Size(21, 21);
            this.btn_SearchGroup.TabIndex = 577;
            this.btn_SearchGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchGroup.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchGroup.Click += new System.EventHandler(this.btn_SearchGroup_Click);
            this.btn_SearchGroup.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // txt_Item_CD
            // 
            this.txt_Item_CD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Item_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_CD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Item_CD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Item_CD.Location = new System.Drawing.Point(108, 13);
            this.txt_Item_CD.MaxLength = 10;
            this.txt_Item_CD.Name = "txt_Item_CD";
            this.txt_Item_CD.ReadOnly = true;
            this.txt_Item_CD.Size = new System.Drawing.Size(70, 21);
            this.txt_Item_CD.TabIndex = 0;
            this.txt_Item_CD.TabStop = false;
            this.txt_Item_CD.Tag = "Y";
            // 
            // txt_Item_Name5
            // 
            this.txt_Item_Name5.BackColor = System.Drawing.Color.White;
            this.txt_Item_Name5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_Name5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Item_Name5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Item_Name5.Location = new System.Drawing.Point(108, 145);
            this.txt_Item_Name5.MaxLength = 100;
            this.txt_Item_Name5.Name = "txt_Item_Name5";
            this.txt_Item_Name5.Size = new System.Drawing.Size(210, 21);
            this.txt_Item_Name5.TabIndex = 7;
            // 
            // txt_Item_Name4
            // 
            this.txt_Item_Name4.BackColor = System.Drawing.Color.White;
            this.txt_Item_Name4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_Name4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Item_Name4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Item_Name4.Location = new System.Drawing.Point(108, 123);
            this.txt_Item_Name4.MaxLength = 100;
            this.txt_Item_Name4.Name = "txt_Item_Name4";
            this.txt_Item_Name4.Size = new System.Drawing.Size(210, 21);
            this.txt_Item_Name4.TabIndex = 6;
            // 
            // lbl_Item_Name4
            // 
            this.lbl_Item_Name4.ImageIndex = 0;
            this.lbl_Item_Name4.ImageList = this.img_Label;
            this.lbl_Item_Name4.Location = new System.Drawing.Point(7, 123);
            this.lbl_Item_Name4.Name = "lbl_Item_Name4";
            this.lbl_Item_Name4.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item_Name4.TabIndex = 568;
            this.lbl_Item_Name4.Text = "무역통관명";
            this.lbl_Item_Name4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Item_Name5
            // 
            this.lbl_Item_Name5.ImageIndex = 0;
            this.lbl_Item_Name5.ImageList = this.img_Label;
            this.lbl_Item_Name5.Location = new System.Drawing.Point(7, 145);
            this.lbl_Item_Name5.Name = "lbl_Item_Name5";
            this.lbl_Item_Name5.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item_Name5.TabIndex = 567;
            this.lbl_Item_Name5.Text = "무역해외명";
            this.lbl_Item_Name5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Item_Name3
            // 
            this.txt_Item_Name3.BackColor = System.Drawing.Color.White;
            this.txt_Item_Name3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_Name3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Item_Name3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Item_Name3.Location = new System.Drawing.Point(108, 101);
            this.txt_Item_Name3.MaxLength = 100;
            this.txt_Item_Name3.Name = "txt_Item_Name3";
            this.txt_Item_Name3.Size = new System.Drawing.Size(210, 21);
            this.txt_Item_Name3.TabIndex = 5;
            // 
            // txt_Item_Name2
            // 
            this.txt_Item_Name2.BackColor = System.Drawing.Color.White;
            this.txt_Item_Name2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_Name2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Item_Name2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Item_Name2.Location = new System.Drawing.Point(108, 79);
            this.txt_Item_Name2.MaxLength = 100;
            this.txt_Item_Name2.Name = "txt_Item_Name2";
            this.txt_Item_Name2.Size = new System.Drawing.Size(210, 21);
            this.txt_Item_Name2.TabIndex = 4;
            // 
            // lbl_Item_Name2
            // 
            this.lbl_Item_Name2.ImageIndex = 0;
            this.lbl_Item_Name2.ImageList = this.img_Label;
            this.lbl_Item_Name2.Location = new System.Drawing.Point(7, 79);
            this.lbl_Item_Name2.Name = "lbl_Item_Name2";
            this.lbl_Item_Name2.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item_Name2.TabIndex = 564;
            this.lbl_Item_Name2.Text = "Process Name";
            this.lbl_Item_Name2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Item_Name3
            // 
            this.lbl_Item_Name3.ImageIndex = 0;
            this.lbl_Item_Name3.ImageList = this.img_Label;
            this.lbl_Item_Name3.Location = new System.Drawing.Point(7, 101);
            this.lbl_Item_Name3.Name = "lbl_Item_Name3";
            this.lbl_Item_Name3.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item_Name3.TabIndex = 563;
            this.lbl_Item_Name3.Text = "나이키명";
            this.lbl_Item_Name3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Item_Name1
            // 
            this.lbl_Item_Name1.ImageIndex = 1;
            this.lbl_Item_Name1.ImageList = this.img_Label;
            this.lbl_Item_Name1.Location = new System.Drawing.Point(7, 57);
            this.lbl_Item_Name1.Name = "lbl_Item_Name1";
            this.lbl_Item_Name1.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item_Name1.TabIndex = 562;
            this.lbl_Item_Name1.Text = "Item Name";
            this.lbl_Item_Name1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Item_Name1
            // 
            this.txt_Item_Name1.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Item_Name1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_Name1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Item_Name1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Item_Name1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Item_Name1.Location = new System.Drawing.Point(108, 57);
            this.txt_Item_Name1.MaxLength = 100;
            this.txt_Item_Name1.Name = "txt_Item_Name1";
            this.txt_Item_Name1.Size = new System.Drawing.Size(210, 21);
            this.txt_Item_Name1.TabIndex = 3;
            this.txt_Item_Name1.Tag = "Y";
            // 
            // txt_Group_CD
            // 
            this.txt_Group_CD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Group_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_CD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Group_CD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Group_CD.Location = new System.Drawing.Point(108, 35);
            this.txt_Group_CD.MaxLength = 10;
            this.txt_Group_CD.Name = "txt_Group_CD";
            this.txt_Group_CD.ReadOnly = true;
            this.txt_Group_CD.Size = new System.Drawing.Size(70, 21);
            this.txt_Group_CD.TabIndex = 1;
            this.txt_Group_CD.Tag = "Y";
            this.txt_Group_CD.TextChanged += new System.EventHandler(this.txt_Group_CD_TextChanged);
            // 
            // lbl_Group_CD
            // 
            this.lbl_Group_CD.ImageIndex = 1;
            this.lbl_Group_CD.ImageList = this.img_Label;
            this.lbl_Group_CD.Location = new System.Drawing.Point(7, 35);
            this.lbl_Group_CD.Name = "lbl_Group_CD";
            this.lbl_Group_CD.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_CD.TabIndex = 559;
            this.lbl_Group_CD.Text = "Group Code";
            this.lbl_Group_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Item_CD
            // 
            this.lbl_Item_CD.ImageIndex = 1;
            this.lbl_Item_CD.ImageList = this.img_Label;
            this.lbl_Item_CD.Location = new System.Drawing.Point(7, 13);
            this.lbl_Item_CD.Name = "lbl_Item_CD";
            this.lbl_Item_CD.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item_CD.TabIndex = 126;
            this.lbl_Item_CD.Text = "Item Code";
            this.lbl_Item_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_Unit
            // 
            this.tab_Unit.BackColor = System.Drawing.SystemColors.Window;
            this.tab_Unit.Controls.Add(this.gbox_Unit2);
            this.tab_Unit.Controls.Add(this.gbox_Unit1);
            this.tab_Unit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Unit.Location = new System.Drawing.Point(4, 25);
            this.tab_Unit.Name = "tab_Unit";
            this.tab_Unit.Size = new System.Drawing.Size(192, 71);
            this.tab_Unit.TabIndex = 4;
            this.tab_Unit.Text = "Unit";
            this.tab_Unit.ToolTipText = "Unit";
            this.tab_Unit.Visible = false;
            // 
            // gbox_Unit2
            // 
            this.gbox_Unit2.Controls.Add(this.txt_Processing_Price);
            this.gbox_Unit2.Controls.Add(this.txt_Cbd_Price);
            this.gbox_Unit2.Controls.Add(this.txt_Pur_Price);
            this.gbox_Unit2.Controls.Add(this.cmb_Processing_Currency);
            this.gbox_Unit2.Controls.Add(this.lbl_Processing_);
            this.gbox_Unit2.Controls.Add(this.cmb_Processing_YN);
            this.gbox_Unit2.Controls.Add(this.lbl_Processing_Price);
            this.gbox_Unit2.Controls.Add(this.lbl_Processing_YN);
            this.gbox_Unit2.Controls.Add(this.cmb_Cbd_Currency);
            this.gbox_Unit2.Controls.Add(this.lbl_Cbd_Currency);
            this.gbox_Unit2.Controls.Add(this.lbl_Cbd_Price);
            this.gbox_Unit2.Controls.Add(this.cmb_Pur_Currency);
            this.gbox_Unit2.Controls.Add(this.lbl_Pur_Currency);
            this.gbox_Unit2.Controls.Add(this.lbl_Pur_Price);
            this.gbox_Unit2.Location = new System.Drawing.Point(340, 5);
            this.gbox_Unit2.Name = "gbox_Unit2";
            this.gbox_Unit2.Size = new System.Drawing.Size(327, 340);
            this.gbox_Unit2.TabIndex = 1;
            this.gbox_Unit2.TabStop = false;
            // 
            // txt_Processing_Price
            // 
            this.txt_Processing_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Processing_Price.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Processing_Price.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Processing_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Processing_Price.Location = new System.Drawing.Point(108, 149);
            this.txt_Processing_Price.MaxLength = 15;
            this.txt_Processing_Price.Name = "txt_Processing_Price";
            this.txt_Processing_Price.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Processing_Price.Size = new System.Drawing.Size(210, 21);
            this.txt_Processing_Price.TabIndex = 30;
            this.txt_Processing_Price.Tag = null;
            this.txt_Processing_Price.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Processing_Price.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // txt_Cbd_Price
            // 
            this.txt_Cbd_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cbd_Price.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Cbd_Price.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Cbd_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Cbd_Price.Location = new System.Drawing.Point(108, 57);
            this.txt_Cbd_Price.MaxLength = 15;
            this.txt_Cbd_Price.Name = "txt_Cbd_Price";
            this.txt_Cbd_Price.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Cbd_Price.Size = new System.Drawing.Size(210, 21);
            this.txt_Cbd_Price.TabIndex = 27;
            this.txt_Cbd_Price.Tag = null;
            this.txt_Cbd_Price.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Cbd_Price.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // txt_Pur_Price
            // 
            this.txt_Pur_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pur_Price.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Pur_Price.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Pur_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Pur_Price.Location = new System.Drawing.Point(108, 13);
            this.txt_Pur_Price.MaxLength = 15;
            this.txt_Pur_Price.Name = "txt_Pur_Price";
            this.txt_Pur_Price.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Pur_Price.Size = new System.Drawing.Size(210, 21);
            this.txt_Pur_Price.TabIndex = 25;
            this.txt_Pur_Price.Tag = null;
            this.txt_Pur_Price.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Pur_Price.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // cmb_Processing_Currency
            // 
            this.cmb_Processing_Currency.AddItemCols = 0;
            this.cmb_Processing_Currency.AddItemSeparator = ';';
            this.cmb_Processing_Currency.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Processing_Currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Processing_Currency.Caption = "";
            this.cmb_Processing_Currency.CaptionHeight = 17;
            this.cmb_Processing_Currency.CaptionStyle = style377;
            this.cmb_Processing_Currency.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Processing_Currency.ColumnCaptionHeight = 18;
            this.cmb_Processing_Currency.ColumnFooterHeight = 18;
            this.cmb_Processing_Currency.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Processing_Currency.ContentHeight = 17;
            this.cmb_Processing_Currency.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Processing_Currency.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Processing_Currency.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Processing_Currency.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Processing_Currency.EditorHeight = 17;
            this.cmb_Processing_Currency.EvenRowStyle = style378;
            this.cmb_Processing_Currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Processing_Currency.FooterStyle = style379;
            this.cmb_Processing_Currency.GapHeight = 2;
            this.cmb_Processing_Currency.HeadingStyle = style380;
            this.cmb_Processing_Currency.HighLightRowStyle = style381;
            this.cmb_Processing_Currency.ItemHeight = 15;
            this.cmb_Processing_Currency.Location = new System.Drawing.Point(108, 171);
            this.cmb_Processing_Currency.MatchEntryTimeout = ((long)(2000));
            this.cmb_Processing_Currency.MaxDropDownItems = ((short)(5));
            this.cmb_Processing_Currency.MaxLength = 32767;
            this.cmb_Processing_Currency.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Processing_Currency.Name = "cmb_Processing_Currency";
            this.cmb_Processing_Currency.OddRowStyle = style382;
            this.cmb_Processing_Currency.PartialRightColumn = false;
            this.cmb_Processing_Currency.PropBag = resources.GetString("cmb_Processing_Currency.PropBag");
            this.cmb_Processing_Currency.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Processing_Currency.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Processing_Currency.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Processing_Currency.SelectedStyle = style383;
            this.cmb_Processing_Currency.Size = new System.Drawing.Size(210, 21);
            this.cmb_Processing_Currency.Style = style384;
            this.cmb_Processing_Currency.TabIndex = 31;
            // 
            // lbl_Processing_
            // 
            this.lbl_Processing_.ImageIndex = 0;
            this.lbl_Processing_.ImageList = this.img_Label;
            this.lbl_Processing_.Location = new System.Drawing.Point(7, 171);
            this.lbl_Processing_.Name = "lbl_Processing_";
            this.lbl_Processing_.Size = new System.Drawing.Size(100, 21);
            this.lbl_Processing_.TabIndex = 585;
            this.lbl_Processing_.Text = "임가공화폐단위";
            this.lbl_Processing_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Processing_YN
            // 
            this.cmb_Processing_YN.AddItemCols = 0;
            this.cmb_Processing_YN.AddItemSeparator = ';';
            this.cmb_Processing_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Processing_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Processing_YN.Caption = "";
            this.cmb_Processing_YN.CaptionHeight = 17;
            this.cmb_Processing_YN.CaptionStyle = style385;
            this.cmb_Processing_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Processing_YN.ColumnCaptionHeight = 18;
            this.cmb_Processing_YN.ColumnFooterHeight = 18;
            this.cmb_Processing_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Processing_YN.ContentHeight = 17;
            this.cmb_Processing_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Processing_YN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Processing_YN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Processing_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Processing_YN.EditorHeight = 17;
            this.cmb_Processing_YN.EvenRowStyle = style386;
            this.cmb_Processing_YN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Processing_YN.FooterStyle = style387;
            this.cmb_Processing_YN.GapHeight = 2;
            this.cmb_Processing_YN.HeadingStyle = style388;
            this.cmb_Processing_YN.HighLightRowStyle = style389;
            this.cmb_Processing_YN.ItemHeight = 15;
            this.cmb_Processing_YN.Location = new System.Drawing.Point(108, 127);
            this.cmb_Processing_YN.MatchEntryTimeout = ((long)(2000));
            this.cmb_Processing_YN.MaxDropDownItems = ((short)(5));
            this.cmb_Processing_YN.MaxLength = 32767;
            this.cmb_Processing_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Processing_YN.Name = "cmb_Processing_YN";
            this.cmb_Processing_YN.OddRowStyle = style390;
            this.cmb_Processing_YN.PartialRightColumn = false;
            this.cmb_Processing_YN.PropBag = resources.GetString("cmb_Processing_YN.PropBag");
            this.cmb_Processing_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Processing_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Processing_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Processing_YN.SelectedStyle = style391;
            this.cmb_Processing_YN.Size = new System.Drawing.Size(210, 21);
            this.cmb_Processing_YN.Style = style392;
            this.cmb_Processing_YN.TabIndex = 29;
            // 
            // lbl_Processing_Price
            // 
            this.lbl_Processing_Price.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Processing_Price.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Processing_Price.ImageIndex = 0;
            this.lbl_Processing_Price.ImageList = this.img_Label;
            this.lbl_Processing_Price.Location = new System.Drawing.Point(7, 149);
            this.lbl_Processing_Price.Name = "lbl_Processing_Price";
            this.lbl_Processing_Price.Size = new System.Drawing.Size(100, 21);
            this.lbl_Processing_Price.TabIndex = 583;
            this.lbl_Processing_Price.Text = "임가공비용";
            this.lbl_Processing_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Processing_YN
            // 
            this.lbl_Processing_YN.ImageIndex = 0;
            this.lbl_Processing_YN.ImageList = this.img_Label;
            this.lbl_Processing_YN.Location = new System.Drawing.Point(7, 127);
            this.lbl_Processing_YN.Name = "lbl_Processing_YN";
            this.lbl_Processing_YN.Size = new System.Drawing.Size(100, 21);
            this.lbl_Processing_YN.TabIndex = 581;
            this.lbl_Processing_YN.Text = "임가공여부";
            this.lbl_Processing_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Cbd_Currency
            // 
            this.cmb_Cbd_Currency.AddItemCols = 0;
            this.cmb_Cbd_Currency.AddItemSeparator = ';';
            this.cmb_Cbd_Currency.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Cbd_Currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Cbd_Currency.Caption = "";
            this.cmb_Cbd_Currency.CaptionHeight = 17;
            this.cmb_Cbd_Currency.CaptionStyle = style393;
            this.cmb_Cbd_Currency.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Cbd_Currency.ColumnCaptionHeight = 18;
            this.cmb_Cbd_Currency.ColumnFooterHeight = 18;
            this.cmb_Cbd_Currency.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Cbd_Currency.ContentHeight = 17;
            this.cmb_Cbd_Currency.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Cbd_Currency.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Cbd_Currency.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cbd_Currency.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Cbd_Currency.EditorHeight = 17;
            this.cmb_Cbd_Currency.EvenRowStyle = style394;
            this.cmb_Cbd_Currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Cbd_Currency.FooterStyle = style395;
            this.cmb_Cbd_Currency.GapHeight = 2;
            this.cmb_Cbd_Currency.HeadingStyle = style396;
            this.cmb_Cbd_Currency.HighLightRowStyle = style397;
            this.cmb_Cbd_Currency.ItemHeight = 15;
            this.cmb_Cbd_Currency.Location = new System.Drawing.Point(108, 79);
            this.cmb_Cbd_Currency.MatchEntryTimeout = ((long)(2000));
            this.cmb_Cbd_Currency.MaxDropDownItems = ((short)(5));
            this.cmb_Cbd_Currency.MaxLength = 32767;
            this.cmb_Cbd_Currency.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Cbd_Currency.Name = "cmb_Cbd_Currency";
            this.cmb_Cbd_Currency.OddRowStyle = style398;
            this.cmb_Cbd_Currency.PartialRightColumn = false;
            this.cmb_Cbd_Currency.PropBag = resources.GetString("cmb_Cbd_Currency.PropBag");
            this.cmb_Cbd_Currency.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Cbd_Currency.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Cbd_Currency.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Cbd_Currency.SelectedStyle = style399;
            this.cmb_Cbd_Currency.Size = new System.Drawing.Size(210, 21);
            this.cmb_Cbd_Currency.Style = style400;
            this.cmb_Cbd_Currency.TabIndex = 28;
            // 
            // lbl_Cbd_Currency
            // 
            this.lbl_Cbd_Currency.ImageIndex = 0;
            this.lbl_Cbd_Currency.ImageList = this.img_Label;
            this.lbl_Cbd_Currency.Location = new System.Drawing.Point(7, 79);
            this.lbl_Cbd_Currency.Name = "lbl_Cbd_Currency";
            this.lbl_Cbd_Currency.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cbd_Currency.TabIndex = 579;
            this.lbl_Cbd_Currency.Text = "CBD화폐단위";
            this.lbl_Cbd_Currency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Cbd_Price
            // 
            this.lbl_Cbd_Price.ImageIndex = 0;
            this.lbl_Cbd_Price.ImageList = this.img_Label;
            this.lbl_Cbd_Price.Location = new System.Drawing.Point(7, 57);
            this.lbl_Cbd_Price.Name = "lbl_Cbd_Price";
            this.lbl_Cbd_Price.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cbd_Price.TabIndex = 577;
            this.lbl_Cbd_Price.Text = "CBD단가";
            this.lbl_Cbd_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Pur_Currency
            // 
            this.cmb_Pur_Currency.AddItemCols = 0;
            this.cmb_Pur_Currency.AddItemSeparator = ';';
            this.cmb_Pur_Currency.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Pur_Currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Pur_Currency.Caption = "";
            this.cmb_Pur_Currency.CaptionHeight = 17;
            this.cmb_Pur_Currency.CaptionStyle = style401;
            this.cmb_Pur_Currency.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Pur_Currency.ColumnCaptionHeight = 18;
            this.cmb_Pur_Currency.ColumnFooterHeight = 18;
            this.cmb_Pur_Currency.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Pur_Currency.ContentHeight = 17;
            this.cmb_Pur_Currency.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Pur_Currency.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Pur_Currency.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pur_Currency.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Pur_Currency.EditorHeight = 17;
            this.cmb_Pur_Currency.EvenRowStyle = style402;
            this.cmb_Pur_Currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Pur_Currency.FooterStyle = style403;
            this.cmb_Pur_Currency.GapHeight = 2;
            this.cmb_Pur_Currency.HeadingStyle = style404;
            this.cmb_Pur_Currency.HighLightRowStyle = style405;
            this.cmb_Pur_Currency.ItemHeight = 15;
            this.cmb_Pur_Currency.Location = new System.Drawing.Point(108, 35);
            this.cmb_Pur_Currency.MatchEntryTimeout = ((long)(2000));
            this.cmb_Pur_Currency.MaxDropDownItems = ((short)(5));
            this.cmb_Pur_Currency.MaxLength = 32767;
            this.cmb_Pur_Currency.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Pur_Currency.Name = "cmb_Pur_Currency";
            this.cmb_Pur_Currency.OddRowStyle = style406;
            this.cmb_Pur_Currency.PartialRightColumn = false;
            this.cmb_Pur_Currency.PropBag = resources.GetString("cmb_Pur_Currency.PropBag");
            this.cmb_Pur_Currency.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Pur_Currency.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Pur_Currency.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Pur_Currency.SelectedStyle = style407;
            this.cmb_Pur_Currency.Size = new System.Drawing.Size(210, 21);
            this.cmb_Pur_Currency.Style = style408;
            this.cmb_Pur_Currency.TabIndex = 26;
            // 
            // lbl_Pur_Currency
            // 
            this.lbl_Pur_Currency.ImageIndex = 0;
            this.lbl_Pur_Currency.ImageList = this.img_Label;
            this.lbl_Pur_Currency.Location = new System.Drawing.Point(7, 35);
            this.lbl_Pur_Currency.Name = "lbl_Pur_Currency";
            this.lbl_Pur_Currency.Size = new System.Drawing.Size(100, 21);
            this.lbl_Pur_Currency.TabIndex = 575;
            this.lbl_Pur_Currency.Text = "구매화폐단위";
            this.lbl_Pur_Currency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Pur_Price
            // 
            this.lbl_Pur_Price.ImageIndex = 0;
            this.lbl_Pur_Price.ImageList = this.img_Label;
            this.lbl_Pur_Price.Location = new System.Drawing.Point(7, 13);
            this.lbl_Pur_Price.Name = "lbl_Pur_Price";
            this.lbl_Pur_Price.Size = new System.Drawing.Size(100, 21);
            this.lbl_Pur_Price.TabIndex = 573;
            this.lbl_Pur_Price.Text = "구매단가";
            this.lbl_Pur_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbox_Unit1
            // 
            this.gbox_Unit1.Controls.Add(this.txt_Pk_Qty);
            this.gbox_Unit1.Controls.Add(this.txt_Item_Conv);
            this.gbox_Unit1.Controls.Add(this.lbl_Item_Conv);
            this.gbox_Unit1.Controls.Add(this.cmb_Stock_Unit);
            this.gbox_Unit1.Controls.Add(this.lbl_Stock_Unit);
            this.gbox_Unit1.Controls.Add(this.cmb_Buy_Div);
            this.gbox_Unit1.Controls.Add(this.lbl_Buy_Div);
            this.gbox_Unit1.Controls.Add(this.cmb_Style_Item_Div);
            this.gbox_Unit1.Controls.Add(this.lbl_Style_Item_Div);
            this.gbox_Unit1.Controls.Add(this.lbl_Pk_Qty);
            this.gbox_Unit1.Controls.Add(this.lbl_Abc_Div);
            this.gbox_Unit1.Controls.Add(this.cmb_Abc_Div);
            this.gbox_Unit1.Controls.Add(this.lbl_Insp_YN);
            this.gbox_Unit1.Controls.Add(this.cmb_Insp_YN);
            this.gbox_Unit1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_Unit1.Location = new System.Drawing.Point(7, 5);
            this.gbox_Unit1.Name = "gbox_Unit1";
            this.gbox_Unit1.Size = new System.Drawing.Size(327, 340);
            this.gbox_Unit1.TabIndex = 0;
            this.gbox_Unit1.TabStop = false;
            // 
            // txt_Pk_Qty
            // 
            this.txt_Pk_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.txt_Pk_Qty.Calculator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Pk_Qty.Calculator.StoredFormat = "";
            this.txt_Pk_Qty.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Pk_Qty.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Pk_Qty.GapHeight = 0;
            this.txt_Pk_Qty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Pk_Qty.Location = new System.Drawing.Point(108, 149);
            this.txt_Pk_Qty.MaxLength = 10;
            this.txt_Pk_Qty.Name = "txt_Pk_Qty";
            this.txt_Pk_Qty.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Pk_Qty.Size = new System.Drawing.Size(210, 21);
            this.txt_Pk_Qty.TabIndex = 20;
            this.txt_Pk_Qty.Tag = null;
            this.txt_Pk_Qty.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Pk_Qty.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // txt_Item_Conv
            // 
            this.txt_Item_Conv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_Conv.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Item_Conv.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Item_Conv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Item_Conv.Location = new System.Drawing.Point(108, 127);
            this.txt_Item_Conv.MaxLength = 10;
            this.txt_Item_Conv.Name = "txt_Item_Conv";
            this.txt_Item_Conv.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Item_Conv.Size = new System.Drawing.Size(210, 21);
            this.txt_Item_Conv.TabIndex = 19;
            this.txt_Item_Conv.Tag = "Y";
            this.txt_Item_Conv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Item_Conv.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // lbl_Item_Conv
            // 
            this.lbl_Item_Conv.ImageIndex = 1;
            this.lbl_Item_Conv.ImageList = this.img_Label;
            this.lbl_Item_Conv.Location = new System.Drawing.Point(7, 127);
            this.lbl_Item_Conv.Name = "lbl_Item_Conv";
            this.lbl_Item_Conv.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item_Conv.TabIndex = 593;
            this.lbl_Item_Conv.Text = "환산계수";
            this.lbl_Item_Conv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Stock_Unit
            // 
            this.cmb_Stock_Unit.AddItemCols = 0;
            this.cmb_Stock_Unit.AddItemSeparator = ';';
            this.cmb_Stock_Unit.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Stock_Unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Stock_Unit.Caption = "";
            this.cmb_Stock_Unit.CaptionHeight = 17;
            this.cmb_Stock_Unit.CaptionStyle = style409;
            this.cmb_Stock_Unit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Stock_Unit.ColumnCaptionHeight = 18;
            this.cmb_Stock_Unit.ColumnFooterHeight = 18;
            this.cmb_Stock_Unit.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Stock_Unit.ContentHeight = 17;
            this.cmb_Stock_Unit.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Stock_Unit.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Stock_Unit.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock_Unit.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Stock_Unit.EditorHeight = 17;
            this.cmb_Stock_Unit.EvenRowStyle = style410;
            this.cmb_Stock_Unit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Stock_Unit.FooterStyle = style411;
            this.cmb_Stock_Unit.GapHeight = 2;
            this.cmb_Stock_Unit.HeadingStyle = style412;
            this.cmb_Stock_Unit.HighLightRowStyle = style413;
            this.cmb_Stock_Unit.ItemHeight = 15;
            this.cmb_Stock_Unit.Location = new System.Drawing.Point(108, 13);
            this.cmb_Stock_Unit.MatchEntryTimeout = ((long)(2000));
            this.cmb_Stock_Unit.MaxDropDownItems = ((short)(5));
            this.cmb_Stock_Unit.MaxLength = 32767;
            this.cmb_Stock_Unit.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Stock_Unit.Name = "cmb_Stock_Unit";
            this.cmb_Stock_Unit.OddRowStyle = style414;
            this.cmb_Stock_Unit.PartialRightColumn = false;
            this.cmb_Stock_Unit.PropBag = resources.GetString("cmb_Stock_Unit.PropBag");
            this.cmb_Stock_Unit.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Stock_Unit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Stock_Unit.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Stock_Unit.SelectedStyle = style415;
            this.cmb_Stock_Unit.Size = new System.Drawing.Size(210, 21);
            this.cmb_Stock_Unit.Style = style416;
            this.cmb_Stock_Unit.TabIndex = 18;
            // 
            // lbl_Stock_Unit
            // 
            this.lbl_Stock_Unit.ImageIndex = 0;
            this.lbl_Stock_Unit.ImageList = this.img_Label;
            this.lbl_Stock_Unit.Location = new System.Drawing.Point(7, 13);
            this.lbl_Stock_Unit.Name = "lbl_Stock_Unit";
            this.lbl_Stock_Unit.Size = new System.Drawing.Size(100, 21);
            this.lbl_Stock_Unit.TabIndex = 551;
            this.lbl_Stock_Unit.Text = "재고단위";
            this.lbl_Stock_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Buy_Div
            // 
            this.cmb_Buy_Div.AddItemCols = 0;
            this.cmb_Buy_Div.AddItemSeparator = ';';
            this.cmb_Buy_Div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Buy_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Buy_Div.Caption = "";
            this.cmb_Buy_Div.CaptionHeight = 17;
            this.cmb_Buy_Div.CaptionStyle = style417;
            this.cmb_Buy_Div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Buy_Div.ColumnCaptionHeight = 18;
            this.cmb_Buy_Div.ColumnFooterHeight = 18;
            this.cmb_Buy_Div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Buy_Div.ContentHeight = 17;
            this.cmb_Buy_Div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Buy_Div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Buy_Div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Buy_Div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Buy_Div.EditorHeight = 17;
            this.cmb_Buy_Div.EvenRowStyle = style418;
            this.cmb_Buy_Div.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Buy_Div.FooterStyle = style419;
            this.cmb_Buy_Div.GapHeight = 2;
            this.cmb_Buy_Div.HeadingStyle = style420;
            this.cmb_Buy_Div.HighLightRowStyle = style421;
            this.cmb_Buy_Div.ItemHeight = 15;
            this.cmb_Buy_Div.Location = new System.Drawing.Point(108, 83);
            this.cmb_Buy_Div.MatchEntryTimeout = ((long)(2000));
            this.cmb_Buy_Div.MaxDropDownItems = ((short)(5));
            this.cmb_Buy_Div.MaxLength = 32767;
            this.cmb_Buy_Div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Buy_Div.Name = "cmb_Buy_Div";
            this.cmb_Buy_Div.OddRowStyle = style422;
            this.cmb_Buy_Div.PartialRightColumn = false;
            this.cmb_Buy_Div.PropBag = resources.GetString("cmb_Buy_Div.PropBag");
            this.cmb_Buy_Div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Buy_Div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Buy_Div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Buy_Div.SelectedStyle = style423;
            this.cmb_Buy_Div.Size = new System.Drawing.Size(210, 21);
            this.cmb_Buy_Div.Style = style424;
            this.cmb_Buy_Div.TabIndex = 22;
            this.cmb_Buy_Div.SelectedValueChanged += new System.EventHandler(this.cmb_Buy_Div_SelectedValueChanged);
            // 
            // lbl_Buy_Div
            // 
            this.lbl_Buy_Div.ImageIndex = 1;
            this.lbl_Buy_Div.ImageList = this.img_Label;
            this.lbl_Buy_Div.Location = new System.Drawing.Point(7, 83);
            this.lbl_Buy_Div.Name = "lbl_Buy_Div";
            this.lbl_Buy_Div.Size = new System.Drawing.Size(100, 21);
            this.lbl_Buy_Div.TabIndex = 549;
            this.lbl_Buy_Div.Text = "구매분류";
            this.lbl_Buy_Div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Style_Item_Div
            // 
            this.cmb_Style_Item_Div.AddItemCols = 0;
            this.cmb_Style_Item_Div.AddItemSeparator = ';';
            this.cmb_Style_Item_Div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Style_Item_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Style_Item_Div.Caption = "";
            this.cmb_Style_Item_Div.CaptionHeight = 17;
            this.cmb_Style_Item_Div.CaptionStyle = style425;
            this.cmb_Style_Item_Div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Style_Item_Div.ColumnCaptionHeight = 18;
            this.cmb_Style_Item_Div.ColumnFooterHeight = 18;
            this.cmb_Style_Item_Div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Style_Item_Div.ContentHeight = 17;
            this.cmb_Style_Item_Div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Style_Item_Div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Style_Item_Div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style_Item_Div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Style_Item_Div.EditorHeight = 17;
            this.cmb_Style_Item_Div.EvenRowStyle = style426;
            this.cmb_Style_Item_Div.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Style_Item_Div.FooterStyle = style427;
            this.cmb_Style_Item_Div.GapHeight = 2;
            this.cmb_Style_Item_Div.HeadingStyle = style428;
            this.cmb_Style_Item_Div.HighLightRowStyle = style429;
            this.cmb_Style_Item_Div.ItemHeight = 15;
            this.cmb_Style_Item_Div.Location = new System.Drawing.Point(108, 61);
            this.cmb_Style_Item_Div.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style_Item_Div.MaxDropDownItems = ((short)(5));
            this.cmb_Style_Item_Div.MaxLength = 32767;
            this.cmb_Style_Item_Div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style_Item_Div.Name = "cmb_Style_Item_Div";
            this.cmb_Style_Item_Div.OddRowStyle = style430;
            this.cmb_Style_Item_Div.PartialRightColumn = false;
            this.cmb_Style_Item_Div.PropBag = resources.GetString("cmb_Style_Item_Div.PropBag");
            this.cmb_Style_Item_Div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style_Item_Div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style_Item_Div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style_Item_Div.SelectedStyle = style431;
            this.cmb_Style_Item_Div.Size = new System.Drawing.Size(210, 21);
            this.cmb_Style_Item_Div.Style = style432;
            this.cmb_Style_Item_Div.TabIndex = 21;
            // 
            // lbl_Style_Item_Div
            // 
            this.lbl_Style_Item_Div.ImageIndex = 1;
            this.lbl_Style_Item_Div.ImageList = this.img_Label;
            this.lbl_Style_Item_Div.Location = new System.Drawing.Point(7, 61);
            this.lbl_Style_Item_Div.Name = "lbl_Style_Item_Div";
            this.lbl_Style_Item_Div.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style_Item_Div.TabIndex = 547;
            this.lbl_Style_Item_Div.Text = "스타일자재분류";
            this.lbl_Style_Item_Div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Pk_Qty
            // 
            this.lbl_Pk_Qty.ImageIndex = 0;
            this.lbl_Pk_Qty.ImageList = this.img_Label;
            this.lbl_Pk_Qty.Location = new System.Drawing.Point(7, 149);
            this.lbl_Pk_Qty.Name = "lbl_Pk_Qty";
            this.lbl_Pk_Qty.Size = new System.Drawing.Size(100, 21);
            this.lbl_Pk_Qty.TabIndex = 495;
            this.lbl_Pk_Qty.Text = "PK수량";
            this.lbl_Pk_Qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Abc_Div
            // 
            this.lbl_Abc_Div.ImageIndex = 1;
            this.lbl_Abc_Div.ImageList = this.img_Label;
            this.lbl_Abc_Div.Location = new System.Drawing.Point(7, 105);
            this.lbl_Abc_Div.Name = "lbl_Abc_Div";
            this.lbl_Abc_Div.Size = new System.Drawing.Size(100, 21);
            this.lbl_Abc_Div.TabIndex = 569;
            this.lbl_Abc_Div.Text = "ABC분류";
            this.lbl_Abc_Div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Abc_Div
            // 
            this.cmb_Abc_Div.AddItemCols = 0;
            this.cmb_Abc_Div.AddItemSeparator = ';';
            this.cmb_Abc_Div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Abc_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Abc_Div.Caption = "";
            this.cmb_Abc_Div.CaptionHeight = 17;
            this.cmb_Abc_Div.CaptionStyle = style433;
            this.cmb_Abc_Div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Abc_Div.ColumnCaptionHeight = 18;
            this.cmb_Abc_Div.ColumnFooterHeight = 18;
            this.cmb_Abc_Div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Abc_Div.ContentHeight = 17;
            this.cmb_Abc_Div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Abc_Div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Abc_Div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Abc_Div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Abc_Div.EditorHeight = 17;
            this.cmb_Abc_Div.EvenRowStyle = style434;
            this.cmb_Abc_Div.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Abc_Div.FooterStyle = style435;
            this.cmb_Abc_Div.GapHeight = 2;
            this.cmb_Abc_Div.HeadingStyle = style436;
            this.cmb_Abc_Div.HighLightRowStyle = style437;
            this.cmb_Abc_Div.ItemHeight = 15;
            this.cmb_Abc_Div.Location = new System.Drawing.Point(108, 105);
            this.cmb_Abc_Div.MatchEntryTimeout = ((long)(2000));
            this.cmb_Abc_Div.MaxDropDownItems = ((short)(5));
            this.cmb_Abc_Div.MaxLength = 32767;
            this.cmb_Abc_Div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Abc_Div.Name = "cmb_Abc_Div";
            this.cmb_Abc_Div.OddRowStyle = style438;
            this.cmb_Abc_Div.PartialRightColumn = false;
            this.cmb_Abc_Div.PropBag = resources.GetString("cmb_Abc_Div.PropBag");
            this.cmb_Abc_Div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Abc_Div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Abc_Div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Abc_Div.SelectedStyle = style439;
            this.cmb_Abc_Div.Size = new System.Drawing.Size(210, 21);
            this.cmb_Abc_Div.Style = style440;
            this.cmb_Abc_Div.TabIndex = 23;
            this.cmb_Abc_Div.Tag = "Y";
            // 
            // lbl_Insp_YN
            // 
            this.lbl_Insp_YN.ImageIndex = 0;
            this.lbl_Insp_YN.ImageList = this.img_Label;
            this.lbl_Insp_YN.Location = new System.Drawing.Point(7, 171);
            this.lbl_Insp_YN.Name = "lbl_Insp_YN";
            this.lbl_Insp_YN.Size = new System.Drawing.Size(100, 21);
            this.lbl_Insp_YN.TabIndex = 571;
            this.lbl_Insp_YN.Text = "검사여부";
            this.lbl_Insp_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Insp_YN
            // 
            this.cmb_Insp_YN.AddItemCols = 0;
            this.cmb_Insp_YN.AddItemSeparator = ';';
            this.cmb_Insp_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Insp_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Insp_YN.Caption = "";
            this.cmb_Insp_YN.CaptionHeight = 17;
            this.cmb_Insp_YN.CaptionStyle = style441;
            this.cmb_Insp_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Insp_YN.ColumnCaptionHeight = 18;
            this.cmb_Insp_YN.ColumnFooterHeight = 18;
            this.cmb_Insp_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Insp_YN.ContentHeight = 17;
            this.cmb_Insp_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Insp_YN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Insp_YN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Insp_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Insp_YN.EditorHeight = 17;
            this.cmb_Insp_YN.EvenRowStyle = style442;
            this.cmb_Insp_YN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Insp_YN.FooterStyle = style443;
            this.cmb_Insp_YN.GapHeight = 2;
            this.cmb_Insp_YN.HeadingStyle = style444;
            this.cmb_Insp_YN.HighLightRowStyle = style445;
            this.cmb_Insp_YN.ItemHeight = 15;
            this.cmb_Insp_YN.Location = new System.Drawing.Point(108, 171);
            this.cmb_Insp_YN.MatchEntryTimeout = ((long)(2000));
            this.cmb_Insp_YN.MaxDropDownItems = ((short)(5));
            this.cmb_Insp_YN.MaxLength = 32767;
            this.cmb_Insp_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Insp_YN.Name = "cmb_Insp_YN";
            this.cmb_Insp_YN.OddRowStyle = style446;
            this.cmb_Insp_YN.PartialRightColumn = false;
            this.cmb_Insp_YN.PropBag = resources.GetString("cmb_Insp_YN.PropBag");
            this.cmb_Insp_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Insp_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Insp_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Insp_YN.SelectedStyle = style447;
            this.cmb_Insp_YN.Size = new System.Drawing.Size(210, 21);
            this.cmb_Insp_YN.Style = style448;
            this.cmb_Insp_YN.TabIndex = 24;
            // 
            // tab_Roul
            // 
            this.tab_Roul.BackColor = System.Drawing.SystemColors.Window;
            this.tab_Roul.Controls.Add(this.gbox_Role2);
            this.tab_Roul.Controls.Add(this.gbox_Role1);
            this.tab_Roul.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Roul.Location = new System.Drawing.Point(4, 25);
            this.tab_Roul.Name = "tab_Roul";
            this.tab_Roul.Size = new System.Drawing.Size(192, 71);
            this.tab_Roul.TabIndex = 2;
            this.tab_Roul.Text = "Role";
            this.tab_Roul.ToolTipText = "Roul";
            this.tab_Roul.Visible = false;
            // 
            // gbox_Role2
            // 
            this.gbox_Role2.Controls.Add(this.txt_Dl_Days_JJ);
            this.gbox_Role2.Controls.Add(this.lbl_Dl_Days_JJ);
            this.gbox_Role2.Controls.Add(this.cmb_Import_JJ);
            this.gbox_Role2.Controls.Add(this.lbl_Import_JJ);
            this.gbox_Role2.Controls.Add(this.lbl_Acc_Div_JJ);
            this.gbox_Role2.Controls.Add(this.cmb_Acc_Div_JJ);
            this.gbox_Role2.Controls.Add(this.txt_Man_Charge_JJ);
            this.gbox_Role2.Controls.Add(this.lbl_Man_Charge_JJ);
            this.gbox_Role2.Controls.Add(this.cmb_Man_Charge_JJ);
            this.gbox_Role2.Controls.Add(this.cmb_Cus_Cd_JJ);
            this.gbox_Role2.Controls.Add(this.txt_Cus_Cd_JJ);
            this.gbox_Role2.Controls.Add(this.lbl_Cus_Cd_JJ);
            this.gbox_Role2.Controls.Add(this.txt_Dl_Days_VJ);
            this.gbox_Role2.Controls.Add(this.lbl_Dl_Days_Vj);
            this.gbox_Role2.Controls.Add(this.cmb_Import_VJ);
            this.gbox_Role2.Controls.Add(this.lbl_Import_VJ);
            this.gbox_Role2.Controls.Add(this.lbl_Acc_Div_Vj);
            this.gbox_Role2.Controls.Add(this.cmb_Acc_Div_VJ);
            this.gbox_Role2.Controls.Add(this.txt_Man_Charge_VJ);
            this.gbox_Role2.Controls.Add(this.lbl_Man_Charge_VJ);
            this.gbox_Role2.Controls.Add(this.cmb_Man_Charge_VJ);
            this.gbox_Role2.Controls.Add(this.cmb_Cus_Cd_VJ);
            this.gbox_Role2.Controls.Add(this.txt_Cus_Cd_VJ);
            this.gbox_Role2.Controls.Add(this.lbl_Cus_Cd_VJ);
            this.gbox_Role2.Location = new System.Drawing.Point(340, 5);
            this.gbox_Role2.Name = "gbox_Role2";
            this.gbox_Role2.Size = new System.Drawing.Size(327, 340);
            this.gbox_Role2.TabIndex = 1;
            this.gbox_Role2.TabStop = false;
            // 
            // txt_Dl_Days_JJ
            // 
            this.txt_Dl_Days_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dl_Days_JJ.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Dl_Days_JJ.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Dl_Days_JJ.Location = new System.Drawing.Point(108, 289);
            this.txt_Dl_Days_JJ.MaxLength = 3;
            this.txt_Dl_Days_JJ.Name = "txt_Dl_Days_JJ";
            this.txt_Dl_Days_JJ.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Dl_Days_JJ.Size = new System.Drawing.Size(210, 21);
            this.txt_Dl_Days_JJ.TabIndex = 633;
            this.txt_Dl_Days_JJ.Tag = "Y";
            this.txt_Dl_Days_JJ.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Dl_Days_JJ.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // lbl_Dl_Days_JJ
            // 
            this.lbl_Dl_Days_JJ.ImageIndex = 1;
            this.lbl_Dl_Days_JJ.ImageList = this.img_Label;
            this.lbl_Dl_Days_JJ.Location = new System.Drawing.Point(7, 289);
            this.lbl_Dl_Days_JJ.Name = "lbl_Dl_Days_JJ";
            this.lbl_Dl_Days_JJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Dl_Days_JJ.TabIndex = 632;
            this.lbl_Dl_Days_JJ.Text = "납기소요일-JJ";
            this.lbl_Dl_Days_JJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Import_JJ
            // 
            this.cmb_Import_JJ.AddItemCols = 0;
            this.cmb_Import_JJ.AddItemSeparator = ';';
            this.cmb_Import_JJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Import_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Import_JJ.Caption = "";
            this.cmb_Import_JJ.CaptionHeight = 17;
            this.cmb_Import_JJ.CaptionStyle = style449;
            this.cmb_Import_JJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Import_JJ.ColumnCaptionHeight = 18;
            this.cmb_Import_JJ.ColumnFooterHeight = 18;
            this.cmb_Import_JJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Import_JJ.ContentHeight = 17;
            this.cmb_Import_JJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Import_JJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Import_JJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Import_JJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Import_JJ.EditorHeight = 17;
            this.cmb_Import_JJ.EvenRowStyle = style450;
            this.cmb_Import_JJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Import_JJ.FooterStyle = style451;
            this.cmb_Import_JJ.GapHeight = 2;
            this.cmb_Import_JJ.HeadingStyle = style452;
            this.cmb_Import_JJ.HighLightRowStyle = style453;
            this.cmb_Import_JJ.ItemHeight = 15;
            this.cmb_Import_JJ.Location = new System.Drawing.Point(108, 267);
            this.cmb_Import_JJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Import_JJ.MaxDropDownItems = ((short)(5));
            this.cmb_Import_JJ.MaxLength = 32767;
            this.cmb_Import_JJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Import_JJ.Name = "cmb_Import_JJ";
            this.cmb_Import_JJ.OddRowStyle = style454;
            this.cmb_Import_JJ.PartialRightColumn = false;
            this.cmb_Import_JJ.PropBag = resources.GetString("cmb_Import_JJ.PropBag");
            this.cmb_Import_JJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Import_JJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Import_JJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Import_JJ.SelectedStyle = style455;
            this.cmb_Import_JJ.Size = new System.Drawing.Size(210, 21);
            this.cmb_Import_JJ.Style = style456;
            this.cmb_Import_JJ.TabIndex = 625;
            this.cmb_Import_JJ.Tag = "Y";
            // 
            // lbl_Import_JJ
            // 
            this.lbl_Import_JJ.ImageIndex = 1;
            this.lbl_Import_JJ.ImageList = this.img_Label;
            this.lbl_Import_JJ.Location = new System.Drawing.Point(7, 267);
            this.lbl_Import_JJ.Name = "lbl_Import_JJ";
            this.lbl_Import_JJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Import_JJ.TabIndex = 630;
            this.lbl_Import_JJ.Text = "Local /LLT-JJ";
            this.lbl_Import_JJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Acc_Div_JJ
            // 
            this.lbl_Acc_Div_JJ.ImageIndex = 0;
            this.lbl_Acc_Div_JJ.ImageList = this.img_Label;
            this.lbl_Acc_Div_JJ.Location = new System.Drawing.Point(7, 311);
            this.lbl_Acc_Div_JJ.Name = "lbl_Acc_Div_JJ";
            this.lbl_Acc_Div_JJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Acc_Div_JJ.TabIndex = 629;
            this.lbl_Acc_Div_JJ.Text = "회계분류-JJ";
            this.lbl_Acc_Div_JJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Acc_Div_JJ
            // 
            this.cmb_Acc_Div_JJ.AddItemCols = 0;
            this.cmb_Acc_Div_JJ.AddItemSeparator = ';';
            this.cmb_Acc_Div_JJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Acc_Div_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Acc_Div_JJ.Caption = "";
            this.cmb_Acc_Div_JJ.CaptionHeight = 17;
            this.cmb_Acc_Div_JJ.CaptionStyle = style457;
            this.cmb_Acc_Div_JJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Acc_Div_JJ.ColumnCaptionHeight = 18;
            this.cmb_Acc_Div_JJ.ColumnFooterHeight = 18;
            this.cmb_Acc_Div_JJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Acc_Div_JJ.ContentHeight = 17;
            this.cmb_Acc_Div_JJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Acc_Div_JJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Acc_Div_JJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Acc_Div_JJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Acc_Div_JJ.EditorHeight = 17;
            this.cmb_Acc_Div_JJ.EvenRowStyle = style458;
            this.cmb_Acc_Div_JJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Acc_Div_JJ.FooterStyle = style459;
            this.cmb_Acc_Div_JJ.GapHeight = 2;
            this.cmb_Acc_Div_JJ.HeadingStyle = style460;
            this.cmb_Acc_Div_JJ.HighLightRowStyle = style461;
            this.cmb_Acc_Div_JJ.ItemHeight = 15;
            this.cmb_Acc_Div_JJ.Location = new System.Drawing.Point(108, 311);
            this.cmb_Acc_Div_JJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Acc_Div_JJ.MaxDropDownItems = ((short)(5));
            this.cmb_Acc_Div_JJ.MaxLength = 32767;
            this.cmb_Acc_Div_JJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Acc_Div_JJ.Name = "cmb_Acc_Div_JJ";
            this.cmb_Acc_Div_JJ.OddRowStyle = style462;
            this.cmb_Acc_Div_JJ.PartialRightColumn = false;
            this.cmb_Acc_Div_JJ.PropBag = resources.GetString("cmb_Acc_Div_JJ.PropBag");
            this.cmb_Acc_Div_JJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_JJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Acc_Div_JJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_JJ.SelectedStyle = style463;
            this.cmb_Acc_Div_JJ.Size = new System.Drawing.Size(210, 21);
            this.cmb_Acc_Div_JJ.Style = style464;
            this.cmb_Acc_Div_JJ.TabIndex = 626;
            // 
            // txt_Man_Charge_JJ
            // 
            this.txt_Man_Charge_JJ.BackColor = System.Drawing.Color.White;
            this.txt_Man_Charge_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Man_Charge_JJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Man_Charge_JJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Man_Charge_JJ.Location = new System.Drawing.Point(108, 245);
            this.txt_Man_Charge_JJ.MaxLength = 10;
            this.txt_Man_Charge_JJ.Name = "txt_Man_Charge_JJ";
            this.txt_Man_Charge_JJ.Size = new System.Drawing.Size(60, 21);
            this.txt_Man_Charge_JJ.TabIndex = 623;
            // 
            // lbl_Man_Charge_JJ
            // 
            this.lbl_Man_Charge_JJ.ImageIndex = 0;
            this.lbl_Man_Charge_JJ.ImageList = this.img_Label;
            this.lbl_Man_Charge_JJ.Location = new System.Drawing.Point(7, 245);
            this.lbl_Man_Charge_JJ.Name = "lbl_Man_Charge_JJ";
            this.lbl_Man_Charge_JJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Man_Charge_JJ.TabIndex = 628;
            this.lbl_Man_Charge_JJ.Text = "담당자-JJ";
            this.lbl_Man_Charge_JJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Man_Charge_JJ
            // 
            this.cmb_Man_Charge_JJ.AddItemCols = 0;
            this.cmb_Man_Charge_JJ.AddItemSeparator = ';';
            this.cmb_Man_Charge_JJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Man_Charge_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Man_Charge_JJ.Caption = "";
            this.cmb_Man_Charge_JJ.CaptionHeight = 17;
            this.cmb_Man_Charge_JJ.CaptionStyle = style465;
            this.cmb_Man_Charge_JJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Man_Charge_JJ.ColumnCaptionHeight = 18;
            this.cmb_Man_Charge_JJ.ColumnFooterHeight = 18;
            this.cmb_Man_Charge_JJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Man_Charge_JJ.ContentHeight = 17;
            this.cmb_Man_Charge_JJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Man_Charge_JJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Man_Charge_JJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Man_Charge_JJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Man_Charge_JJ.EditorHeight = 17;
            this.cmb_Man_Charge_JJ.EvenRowStyle = style466;
            this.cmb_Man_Charge_JJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Man_Charge_JJ.FooterStyle = style467;
            this.cmb_Man_Charge_JJ.GapHeight = 2;
            this.cmb_Man_Charge_JJ.HeadingStyle = style468;
            this.cmb_Man_Charge_JJ.HighLightRowStyle = style469;
            this.cmb_Man_Charge_JJ.ItemHeight = 15;
            this.cmb_Man_Charge_JJ.Location = new System.Drawing.Point(169, 245);
            this.cmb_Man_Charge_JJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Man_Charge_JJ.MaxDropDownItems = ((short)(5));
            this.cmb_Man_Charge_JJ.MaxLength = 32767;
            this.cmb_Man_Charge_JJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Man_Charge_JJ.Name = "cmb_Man_Charge_JJ";
            this.cmb_Man_Charge_JJ.OddRowStyle = style470;
            this.cmb_Man_Charge_JJ.PartialRightColumn = false;
            this.cmb_Man_Charge_JJ.PropBag = resources.GetString("cmb_Man_Charge_JJ.PropBag");
            this.cmb_Man_Charge_JJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_JJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Man_Charge_JJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_JJ.SelectedStyle = style471;
            this.cmb_Man_Charge_JJ.Size = new System.Drawing.Size(150, 21);
            this.cmb_Man_Charge_JJ.Style = style472;
            this.cmb_Man_Charge_JJ.TabIndex = 624;
            this.cmb_Man_Charge_JJ.Tag = "Y";
            // 
            // cmb_Cus_Cd_JJ
            // 
            this.cmb_Cus_Cd_JJ.AddItemCols = 0;
            this.cmb_Cus_Cd_JJ.AddItemSeparator = ';';
            this.cmb_Cus_Cd_JJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Cus_Cd_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Cus_Cd_JJ.Caption = "";
            this.cmb_Cus_Cd_JJ.CaptionHeight = 17;
            this.cmb_Cus_Cd_JJ.CaptionStyle = style473;
            this.cmb_Cus_Cd_JJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Cus_Cd_JJ.ColumnCaptionHeight = 18;
            this.cmb_Cus_Cd_JJ.ColumnFooterHeight = 18;
            this.cmb_Cus_Cd_JJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Cus_Cd_JJ.ContentHeight = 17;
            this.cmb_Cus_Cd_JJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Cus_Cd_JJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Cus_Cd_JJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cus_Cd_JJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Cus_Cd_JJ.EditorHeight = 17;
            this.cmb_Cus_Cd_JJ.EvenRowStyle = style474;
            this.cmb_Cus_Cd_JJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Cus_Cd_JJ.FooterStyle = style475;
            this.cmb_Cus_Cd_JJ.GapHeight = 2;
            this.cmb_Cus_Cd_JJ.HeadingStyle = style476;
            this.cmb_Cus_Cd_JJ.HighLightRowStyle = style477;
            this.cmb_Cus_Cd_JJ.ItemHeight = 15;
            this.cmb_Cus_Cd_JJ.Location = new System.Drawing.Point(169, 223);
            this.cmb_Cus_Cd_JJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Cus_Cd_JJ.MaxDropDownItems = ((short)(5));
            this.cmb_Cus_Cd_JJ.MaxLength = 32767;
            this.cmb_Cus_Cd_JJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Cus_Cd_JJ.Name = "cmb_Cus_Cd_JJ";
            this.cmb_Cus_Cd_JJ.OddRowStyle = style478;
            this.cmb_Cus_Cd_JJ.PartialRightColumn = false;
            this.cmb_Cus_Cd_JJ.PropBag = resources.GetString("cmb_Cus_Cd_JJ.PropBag");
            this.cmb_Cus_Cd_JJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Cus_Cd_JJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Cus_Cd_JJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Cus_Cd_JJ.SelectedStyle = style479;
            this.cmb_Cus_Cd_JJ.Size = new System.Drawing.Size(150, 21);
            this.cmb_Cus_Cd_JJ.Style = style480;
            this.cmb_Cus_Cd_JJ.TabIndex = 622;
            this.cmb_Cus_Cd_JJ.Tag = "Y";
            // 
            // txt_Cus_Cd_JJ
            // 
            this.txt_Cus_Cd_JJ.BackColor = System.Drawing.Color.White;
            this.txt_Cus_Cd_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cus_Cd_JJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Cus_Cd_JJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Cus_Cd_JJ.Location = new System.Drawing.Point(108, 223);
            this.txt_Cus_Cd_JJ.MaxLength = 10;
            this.txt_Cus_Cd_JJ.Name = "txt_Cus_Cd_JJ";
            this.txt_Cus_Cd_JJ.Size = new System.Drawing.Size(60, 21);
            this.txt_Cus_Cd_JJ.TabIndex = 621;
            // 
            // lbl_Cus_Cd_JJ
            // 
            this.lbl_Cus_Cd_JJ.ImageIndex = 0;
            this.lbl_Cus_Cd_JJ.ImageList = this.img_Label;
            this.lbl_Cus_Cd_JJ.Location = new System.Drawing.Point(7, 223);
            this.lbl_Cus_Cd_JJ.Name = "lbl_Cus_Cd_JJ";
            this.lbl_Cus_Cd_JJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cus_Cd_JJ.TabIndex = 627;
            this.lbl_Cus_Cd_JJ.Text = "주거래처-JJ";
            this.lbl_Cus_Cd_JJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Dl_Days_VJ
            // 
            this.txt_Dl_Days_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dl_Days_VJ.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Dl_Days_VJ.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Dl_Days_VJ.Location = new System.Drawing.Point(108, 80);
            this.txt_Dl_Days_VJ.MaxLength = 3;
            this.txt_Dl_Days_VJ.Name = "txt_Dl_Days_VJ";
            this.txt_Dl_Days_VJ.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Dl_Days_VJ.Size = new System.Drawing.Size(210, 21);
            this.txt_Dl_Days_VJ.TabIndex = 617;
            this.txt_Dl_Days_VJ.Tag = "Y";
            this.txt_Dl_Days_VJ.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Dl_Days_VJ.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // lbl_Dl_Days_Vj
            // 
            this.lbl_Dl_Days_Vj.ImageIndex = 1;
            this.lbl_Dl_Days_Vj.ImageList = this.img_Label;
            this.lbl_Dl_Days_Vj.Location = new System.Drawing.Point(7, 80);
            this.lbl_Dl_Days_Vj.Name = "lbl_Dl_Days_Vj";
            this.lbl_Dl_Days_Vj.Size = new System.Drawing.Size(100, 21);
            this.lbl_Dl_Days_Vj.TabIndex = 620;
            this.lbl_Dl_Days_Vj.Text = "납기소요일-VJ";
            this.lbl_Dl_Days_Vj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Import_VJ
            // 
            this.cmb_Import_VJ.AddItemCols = 0;
            this.cmb_Import_VJ.AddItemSeparator = ';';
            this.cmb_Import_VJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Import_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Import_VJ.Caption = "";
            this.cmb_Import_VJ.CaptionHeight = 17;
            this.cmb_Import_VJ.CaptionStyle = style481;
            this.cmb_Import_VJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Import_VJ.ColumnCaptionHeight = 18;
            this.cmb_Import_VJ.ColumnFooterHeight = 18;
            this.cmb_Import_VJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Import_VJ.ContentHeight = 17;
            this.cmb_Import_VJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Import_VJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Import_VJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Import_VJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Import_VJ.EditorHeight = 17;
            this.cmb_Import_VJ.EvenRowStyle = style482;
            this.cmb_Import_VJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Import_VJ.FooterStyle = style483;
            this.cmb_Import_VJ.GapHeight = 2;
            this.cmb_Import_VJ.HeadingStyle = style484;
            this.cmb_Import_VJ.HighLightRowStyle = style485;
            this.cmb_Import_VJ.ItemHeight = 15;
            this.cmb_Import_VJ.Location = new System.Drawing.Point(108, 58);
            this.cmb_Import_VJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Import_VJ.MaxDropDownItems = ((short)(5));
            this.cmb_Import_VJ.MaxLength = 32767;
            this.cmb_Import_VJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Import_VJ.Name = "cmb_Import_VJ";
            this.cmb_Import_VJ.OddRowStyle = style486;
            this.cmb_Import_VJ.PartialRightColumn = false;
            this.cmb_Import_VJ.PropBag = resources.GetString("cmb_Import_VJ.PropBag");
            this.cmb_Import_VJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Import_VJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Import_VJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Import_VJ.SelectedStyle = style487;
            this.cmb_Import_VJ.Size = new System.Drawing.Size(210, 21);
            this.cmb_Import_VJ.Style = style488;
            this.cmb_Import_VJ.TabIndex = 71;
            this.cmb_Import_VJ.Tag = "Y";
            // 
            // lbl_Import_VJ
            // 
            this.lbl_Import_VJ.ImageIndex = 1;
            this.lbl_Import_VJ.ImageList = this.img_Label;
            this.lbl_Import_VJ.Location = new System.Drawing.Point(7, 58);
            this.lbl_Import_VJ.Name = "lbl_Import_VJ";
            this.lbl_Import_VJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Import_VJ.TabIndex = 614;
            this.lbl_Import_VJ.Text = "Local /LLT-VJ";
            this.lbl_Import_VJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Acc_Div_Vj
            // 
            this.lbl_Acc_Div_Vj.ImageIndex = 0;
            this.lbl_Acc_Div_Vj.ImageList = this.img_Label;
            this.lbl_Acc_Div_Vj.Location = new System.Drawing.Point(7, 102);
            this.lbl_Acc_Div_Vj.Name = "lbl_Acc_Div_Vj";
            this.lbl_Acc_Div_Vj.Size = new System.Drawing.Size(100, 21);
            this.lbl_Acc_Div_Vj.TabIndex = 603;
            this.lbl_Acc_Div_Vj.Text = "회계분류-VJ";
            this.lbl_Acc_Div_Vj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Acc_Div_VJ
            // 
            this.cmb_Acc_Div_VJ.AddItemCols = 0;
            this.cmb_Acc_Div_VJ.AddItemSeparator = ';';
            this.cmb_Acc_Div_VJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Acc_Div_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Acc_Div_VJ.Caption = "";
            this.cmb_Acc_Div_VJ.CaptionHeight = 17;
            this.cmb_Acc_Div_VJ.CaptionStyle = style489;
            this.cmb_Acc_Div_VJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Acc_Div_VJ.ColumnCaptionHeight = 18;
            this.cmb_Acc_Div_VJ.ColumnFooterHeight = 18;
            this.cmb_Acc_Div_VJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Acc_Div_VJ.ContentHeight = 17;
            this.cmb_Acc_Div_VJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Acc_Div_VJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Acc_Div_VJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Acc_Div_VJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Acc_Div_VJ.EditorHeight = 17;
            this.cmb_Acc_Div_VJ.EvenRowStyle = style490;
            this.cmb_Acc_Div_VJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Acc_Div_VJ.FooterStyle = style491;
            this.cmb_Acc_Div_VJ.GapHeight = 2;
            this.cmb_Acc_Div_VJ.HeadingStyle = style492;
            this.cmb_Acc_Div_VJ.HighLightRowStyle = style493;
            this.cmb_Acc_Div_VJ.ItemHeight = 15;
            this.cmb_Acc_Div_VJ.Location = new System.Drawing.Point(108, 102);
            this.cmb_Acc_Div_VJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Acc_Div_VJ.MaxDropDownItems = ((short)(5));
            this.cmb_Acc_Div_VJ.MaxLength = 32767;
            this.cmb_Acc_Div_VJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Acc_Div_VJ.Name = "cmb_Acc_Div_VJ";
            this.cmb_Acc_Div_VJ.OddRowStyle = style494;
            this.cmb_Acc_Div_VJ.PartialRightColumn = false;
            this.cmb_Acc_Div_VJ.PropBag = resources.GetString("cmb_Acc_Div_VJ.PropBag");
            this.cmb_Acc_Div_VJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_VJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Acc_Div_VJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_VJ.SelectedStyle = style495;
            this.cmb_Acc_Div_VJ.Size = new System.Drawing.Size(210, 21);
            this.cmb_Acc_Div_VJ.Style = style496;
            this.cmb_Acc_Div_VJ.TabIndex = 76;
            // 
            // txt_Man_Charge_VJ
            // 
            this.txt_Man_Charge_VJ.BackColor = System.Drawing.Color.White;
            this.txt_Man_Charge_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Man_Charge_VJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Man_Charge_VJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Man_Charge_VJ.Location = new System.Drawing.Point(108, 36);
            this.txt_Man_Charge_VJ.MaxLength = 10;
            this.txt_Man_Charge_VJ.Name = "txt_Man_Charge_VJ";
            this.txt_Man_Charge_VJ.Size = new System.Drawing.Size(60, 21);
            this.txt_Man_Charge_VJ.TabIndex = 67;
            this.txt_Man_Charge_VJ.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // lbl_Man_Charge_VJ
            // 
            this.lbl_Man_Charge_VJ.ImageIndex = 0;
            this.lbl_Man_Charge_VJ.ImageList = this.img_Label;
            this.lbl_Man_Charge_VJ.Location = new System.Drawing.Point(7, 36);
            this.lbl_Man_Charge_VJ.Name = "lbl_Man_Charge_VJ";
            this.lbl_Man_Charge_VJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Man_Charge_VJ.TabIndex = 602;
            this.lbl_Man_Charge_VJ.Text = "담당자-VJ";
            this.lbl_Man_Charge_VJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Man_Charge_VJ
            // 
            this.cmb_Man_Charge_VJ.AddItemCols = 0;
            this.cmb_Man_Charge_VJ.AddItemSeparator = ';';
            this.cmb_Man_Charge_VJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Man_Charge_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Man_Charge_VJ.Caption = "";
            this.cmb_Man_Charge_VJ.CaptionHeight = 17;
            this.cmb_Man_Charge_VJ.CaptionStyle = style497;
            this.cmb_Man_Charge_VJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Man_Charge_VJ.ColumnCaptionHeight = 18;
            this.cmb_Man_Charge_VJ.ColumnFooterHeight = 18;
            this.cmb_Man_Charge_VJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Man_Charge_VJ.ContentHeight = 17;
            this.cmb_Man_Charge_VJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Man_Charge_VJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Man_Charge_VJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Man_Charge_VJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Man_Charge_VJ.EditorHeight = 17;
            this.cmb_Man_Charge_VJ.EvenRowStyle = style498;
            this.cmb_Man_Charge_VJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Man_Charge_VJ.FooterStyle = style499;
            this.cmb_Man_Charge_VJ.GapHeight = 2;
            this.cmb_Man_Charge_VJ.HeadingStyle = style500;
            this.cmb_Man_Charge_VJ.HighLightRowStyle = style501;
            this.cmb_Man_Charge_VJ.ItemHeight = 15;
            this.cmb_Man_Charge_VJ.Location = new System.Drawing.Point(169, 36);
            this.cmb_Man_Charge_VJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Man_Charge_VJ.MaxDropDownItems = ((short)(5));
            this.cmb_Man_Charge_VJ.MaxLength = 32767;
            this.cmb_Man_Charge_VJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Man_Charge_VJ.Name = "cmb_Man_Charge_VJ";
            this.cmb_Man_Charge_VJ.OddRowStyle = style502;
            this.cmb_Man_Charge_VJ.PartialRightColumn = false;
            this.cmb_Man_Charge_VJ.PropBag = resources.GetString("cmb_Man_Charge_VJ.PropBag");
            this.cmb_Man_Charge_VJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_VJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Man_Charge_VJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_VJ.SelectedStyle = style503;
            this.cmb_Man_Charge_VJ.Size = new System.Drawing.Size(150, 21);
            this.cmb_Man_Charge_VJ.Style = style504;
            this.cmb_Man_Charge_VJ.TabIndex = 68;
            this.cmb_Man_Charge_VJ.Tag = "Y";
            this.cmb_Man_Charge_VJ.SelectedValueChanged += new System.EventHandler(this.cmb_Man_Charge_SelectedValueChanged);
            // 
            // cmb_Cus_Cd_VJ
            // 
            this.cmb_Cus_Cd_VJ.AddItemCols = 0;
            this.cmb_Cus_Cd_VJ.AddItemSeparator = ';';
            this.cmb_Cus_Cd_VJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Cus_Cd_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Cus_Cd_VJ.Caption = "";
            this.cmb_Cus_Cd_VJ.CaptionHeight = 17;
            this.cmb_Cus_Cd_VJ.CaptionStyle = style505;
            this.cmb_Cus_Cd_VJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Cus_Cd_VJ.ColumnCaptionHeight = 18;
            this.cmb_Cus_Cd_VJ.ColumnFooterHeight = 18;
            this.cmb_Cus_Cd_VJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Cus_Cd_VJ.ContentHeight = 17;
            this.cmb_Cus_Cd_VJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Cus_Cd_VJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Cus_Cd_VJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cus_Cd_VJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Cus_Cd_VJ.EditorHeight = 17;
            this.cmb_Cus_Cd_VJ.EvenRowStyle = style506;
            this.cmb_Cus_Cd_VJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Cus_Cd_VJ.FooterStyle = style507;
            this.cmb_Cus_Cd_VJ.GapHeight = 2;
            this.cmb_Cus_Cd_VJ.HeadingStyle = style508;
            this.cmb_Cus_Cd_VJ.HighLightRowStyle = style509;
            this.cmb_Cus_Cd_VJ.ItemHeight = 15;
            this.cmb_Cus_Cd_VJ.Location = new System.Drawing.Point(169, 14);
            this.cmb_Cus_Cd_VJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Cus_Cd_VJ.MaxDropDownItems = ((short)(5));
            this.cmb_Cus_Cd_VJ.MaxLength = 32767;
            this.cmb_Cus_Cd_VJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Cus_Cd_VJ.Name = "cmb_Cus_Cd_VJ";
            this.cmb_Cus_Cd_VJ.OddRowStyle = style510;
            this.cmb_Cus_Cd_VJ.PartialRightColumn = false;
            this.cmb_Cus_Cd_VJ.PropBag = resources.GetString("cmb_Cus_Cd_VJ.PropBag");
            this.cmb_Cus_Cd_VJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Cus_Cd_VJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Cus_Cd_VJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Cus_Cd_VJ.SelectedStyle = style511;
            this.cmb_Cus_Cd_VJ.Size = new System.Drawing.Size(150, 21);
            this.cmb_Cus_Cd_VJ.Style = style512;
            this.cmb_Cus_Cd_VJ.TabIndex = 62;
            this.cmb_Cus_Cd_VJ.Tag = "Y";
            // 
            // txt_Cus_Cd_VJ
            // 
            this.txt_Cus_Cd_VJ.BackColor = System.Drawing.Color.White;
            this.txt_Cus_Cd_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cus_Cd_VJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Cus_Cd_VJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Cus_Cd_VJ.Location = new System.Drawing.Point(108, 14);
            this.txt_Cus_Cd_VJ.MaxLength = 10;
            this.txt_Cus_Cd_VJ.Name = "txt_Cus_Cd_VJ";
            this.txt_Cus_Cd_VJ.Size = new System.Drawing.Size(60, 21);
            this.txt_Cus_Cd_VJ.TabIndex = 61;
            this.txt_Cus_Cd_VJ.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // lbl_Cus_Cd_VJ
            // 
            this.lbl_Cus_Cd_VJ.ImageIndex = 0;
            this.lbl_Cus_Cd_VJ.ImageList = this.img_Label;
            this.lbl_Cus_Cd_VJ.Location = new System.Drawing.Point(7, 14);
            this.lbl_Cus_Cd_VJ.Name = "lbl_Cus_Cd_VJ";
            this.lbl_Cus_Cd_VJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cus_Cd_VJ.TabIndex = 596;
            this.lbl_Cus_Cd_VJ.Text = "주거래처-VJ";
            this.lbl_Cus_Cd_VJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbox_Role1
            // 
            this.gbox_Role1.Controls.Add(this.txt_Man_Charge_DS);
            this.gbox_Role1.Controls.Add(this.txt_Dl_Days_QD);
            this.gbox_Role1.Controls.Add(this.txt_Cus_Cd_DS);
            this.gbox_Role1.Controls.Add(this.cmb_Man_Charge_DS);
            this.gbox_Role1.Controls.Add(this.lbl_Dl_Days_Qd);
            this.gbox_Role1.Controls.Add(this.lbl_Acc_Div_Qd);
            this.gbox_Role1.Controls.Add(this.lbl_Man_Charge_DS);
            this.gbox_Role1.Controls.Add(this.cmb_Acc_Div_QD);
            this.gbox_Role1.Controls.Add(this.cmb_Cus_Cd_DS);
            this.gbox_Role1.Controls.Add(this.cmb_Import_QD);
            this.gbox_Role1.Controls.Add(this.lbl_Cus_Cd_DS);
            this.gbox_Role1.Controls.Add(this.lbl_Import_DS);
            this.gbox_Role1.Controls.Add(this.lbl_Import_QD);
            this.gbox_Role1.Controls.Add(this.cmb_Import_DS);
            this.gbox_Role1.Controls.Add(this.lbl_Dl_Days_Ds);
            this.gbox_Role1.Controls.Add(this.txt_Dl_Days_DS);
            this.gbox_Role1.Controls.Add(this.lbl_Acc_Div_Ds);
            this.gbox_Role1.Controls.Add(this.cmb_Acc_Div_DS);
            this.gbox_Role1.Controls.Add(this.lbl_Cost_YN);
            this.gbox_Role1.Controls.Add(this.cmb_Acc_Div_YN);
            this.gbox_Role1.Controls.Add(this.lbl_Acc_Div_YN);
            this.gbox_Role1.Controls.Add(this.cmb_Man_Charge_QD);
            this.gbox_Role1.Controls.Add(this.cmb_Cus_Cd_QD);
            this.gbox_Role1.Controls.Add(this.txt_Man_Charge_QD);
            this.gbox_Role1.Controls.Add(this.cmb_Cost_YN);
            this.gbox_Role1.Controls.Add(this.lbl_Man_Charge_QD);
            this.gbox_Role1.Controls.Add(this.lbl_Cus_Cd_QD);
            this.gbox_Role1.Controls.Add(this.txt_Cus_Cd_QD);
            this.gbox_Role1.Location = new System.Drawing.Point(7, 5);
            this.gbox_Role1.Name = "gbox_Role1";
            this.gbox_Role1.Size = new System.Drawing.Size(327, 340);
            this.gbox_Role1.TabIndex = 0;
            this.gbox_Role1.TabStop = false;
            // 
            // txt_Man_Charge_DS
            // 
            this.txt_Man_Charge_DS.BackColor = System.Drawing.Color.White;
            this.txt_Man_Charge_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Man_Charge_DS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Man_Charge_DS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Man_Charge_DS.Location = new System.Drawing.Point(108, 36);
            this.txt_Man_Charge_DS.MaxLength = 10;
            this.txt_Man_Charge_DS.Name = "txt_Man_Charge_DS";
            this.txt_Man_Charge_DS.Size = new System.Drawing.Size(60, 21);
            this.txt_Man_Charge_DS.TabIndex = 63;
            this.txt_Man_Charge_DS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // txt_Dl_Days_QD
            // 
            this.txt_Dl_Days_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dl_Days_QD.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Dl_Days_QD.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Dl_Days_QD.Location = new System.Drawing.Point(108, 289);
            this.txt_Dl_Days_QD.MaxLength = 3;
            this.txt_Dl_Days_QD.Name = "txt_Dl_Days_QD";
            this.txt_Dl_Days_QD.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Dl_Days_QD.Size = new System.Drawing.Size(210, 21);
            this.txt_Dl_Days_QD.TabIndex = 616;
            this.txt_Dl_Days_QD.Tag = "Y";
            this.txt_Dl_Days_QD.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Dl_Days_QD.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // txt_Cus_Cd_DS
            // 
            this.txt_Cus_Cd_DS.BackColor = System.Drawing.Color.White;
            this.txt_Cus_Cd_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cus_Cd_DS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Cus_Cd_DS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Cus_Cd_DS.Location = new System.Drawing.Point(108, 14);
            this.txt_Cus_Cd_DS.MaxLength = 10;
            this.txt_Cus_Cd_DS.Name = "txt_Cus_Cd_DS";
            this.txt_Cus_Cd_DS.Size = new System.Drawing.Size(60, 21);
            this.txt_Cus_Cd_DS.TabIndex = 57;
            this.txt_Cus_Cd_DS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // cmb_Man_Charge_DS
            // 
            this.cmb_Man_Charge_DS.AddItemCols = 0;
            this.cmb_Man_Charge_DS.AddItemSeparator = ';';
            this.cmb_Man_Charge_DS.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Man_Charge_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Man_Charge_DS.Caption = "";
            this.cmb_Man_Charge_DS.CaptionHeight = 17;
            this.cmb_Man_Charge_DS.CaptionStyle = style513;
            this.cmb_Man_Charge_DS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Man_Charge_DS.ColumnCaptionHeight = 18;
            this.cmb_Man_Charge_DS.ColumnFooterHeight = 18;
            this.cmb_Man_Charge_DS.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Man_Charge_DS.ContentHeight = 17;
            this.cmb_Man_Charge_DS.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Man_Charge_DS.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Man_Charge_DS.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Man_Charge_DS.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Man_Charge_DS.EditorHeight = 17;
            this.cmb_Man_Charge_DS.EvenRowStyle = style514;
            this.cmb_Man_Charge_DS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Man_Charge_DS.FooterStyle = style515;
            this.cmb_Man_Charge_DS.GapHeight = 2;
            this.cmb_Man_Charge_DS.HeadingStyle = style516;
            this.cmb_Man_Charge_DS.HighLightRowStyle = style517;
            this.cmb_Man_Charge_DS.ItemHeight = 15;
            this.cmb_Man_Charge_DS.Location = new System.Drawing.Point(169, 36);
            this.cmb_Man_Charge_DS.MatchEntryTimeout = ((long)(2000));
            this.cmb_Man_Charge_DS.MaxDropDownItems = ((short)(5));
            this.cmb_Man_Charge_DS.MaxLength = 32767;
            this.cmb_Man_Charge_DS.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Man_Charge_DS.Name = "cmb_Man_Charge_DS";
            this.cmb_Man_Charge_DS.OddRowStyle = style518;
            this.cmb_Man_Charge_DS.PartialRightColumn = false;
            this.cmb_Man_Charge_DS.PropBag = resources.GetString("cmb_Man_Charge_DS.PropBag");
            this.cmb_Man_Charge_DS.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_DS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Man_Charge_DS.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_DS.SelectedStyle = style519;
            this.cmb_Man_Charge_DS.Size = new System.Drawing.Size(150, 21);
            this.cmb_Man_Charge_DS.Style = style520;
            this.cmb_Man_Charge_DS.TabIndex = 64;
            this.cmb_Man_Charge_DS.Tag = "Y";
            this.cmb_Man_Charge_DS.SelectedValueChanged += new System.EventHandler(this.cmb_Man_Charge_SelectedValueChanged);
            // 
            // lbl_Dl_Days_Qd
            // 
            this.lbl_Dl_Days_Qd.ImageIndex = 1;
            this.lbl_Dl_Days_Qd.ImageList = this.img_Label;
            this.lbl_Dl_Days_Qd.Location = new System.Drawing.Point(7, 289);
            this.lbl_Dl_Days_Qd.Name = "lbl_Dl_Days_Qd";
            this.lbl_Dl_Days_Qd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Dl_Days_Qd.TabIndex = 619;
            this.lbl_Dl_Days_Qd.Text = "납기소요일-QD";
            this.lbl_Dl_Days_Qd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Acc_Div_Qd
            // 
            this.lbl_Acc_Div_Qd.ImageIndex = 0;
            this.lbl_Acc_Div_Qd.ImageList = this.img_Label;
            this.lbl_Acc_Div_Qd.Location = new System.Drawing.Point(7, 311);
            this.lbl_Acc_Div_Qd.Name = "lbl_Acc_Div_Qd";
            this.lbl_Acc_Div_Qd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Acc_Div_Qd.TabIndex = 602;
            this.lbl_Acc_Div_Qd.Text = "회계분류-QD";
            this.lbl_Acc_Div_Qd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Man_Charge_DS
            // 
            this.lbl_Man_Charge_DS.ImageIndex = 1;
            this.lbl_Man_Charge_DS.ImageList = this.img_Label;
            this.lbl_Man_Charge_DS.Location = new System.Drawing.Point(7, 36);
            this.lbl_Man_Charge_DS.Name = "lbl_Man_Charge_DS";
            this.lbl_Man_Charge_DS.Size = new System.Drawing.Size(100, 21);
            this.lbl_Man_Charge_DS.TabIndex = 600;
            this.lbl_Man_Charge_DS.Text = "담당자-DS";
            this.lbl_Man_Charge_DS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Acc_Div_QD
            // 
            this.cmb_Acc_Div_QD.AddItemCols = 0;
            this.cmb_Acc_Div_QD.AddItemSeparator = ';';
            this.cmb_Acc_Div_QD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Acc_Div_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Acc_Div_QD.Caption = "";
            this.cmb_Acc_Div_QD.CaptionHeight = 17;
            this.cmb_Acc_Div_QD.CaptionStyle = style521;
            this.cmb_Acc_Div_QD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Acc_Div_QD.ColumnCaptionHeight = 18;
            this.cmb_Acc_Div_QD.ColumnFooterHeight = 18;
            this.cmb_Acc_Div_QD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Acc_Div_QD.ContentHeight = 17;
            this.cmb_Acc_Div_QD.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Acc_Div_QD.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Acc_Div_QD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Acc_Div_QD.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Acc_Div_QD.EditorHeight = 17;
            this.cmb_Acc_Div_QD.EvenRowStyle = style522;
            this.cmb_Acc_Div_QD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Acc_Div_QD.FooterStyle = style523;
            this.cmb_Acc_Div_QD.GapHeight = 2;
            this.cmb_Acc_Div_QD.HeadingStyle = style524;
            this.cmb_Acc_Div_QD.HighLightRowStyle = style525;
            this.cmb_Acc_Div_QD.ItemHeight = 15;
            this.cmb_Acc_Div_QD.Location = new System.Drawing.Point(108, 311);
            this.cmb_Acc_Div_QD.MatchEntryTimeout = ((long)(2000));
            this.cmb_Acc_Div_QD.MaxDropDownItems = ((short)(5));
            this.cmb_Acc_Div_QD.MaxLength = 32767;
            this.cmb_Acc_Div_QD.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Acc_Div_QD.Name = "cmb_Acc_Div_QD";
            this.cmb_Acc_Div_QD.OddRowStyle = style526;
            this.cmb_Acc_Div_QD.PartialRightColumn = false;
            this.cmb_Acc_Div_QD.PropBag = resources.GetString("cmb_Acc_Div_QD.PropBag");
            this.cmb_Acc_Div_QD.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_QD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Acc_Div_QD.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_QD.SelectedStyle = style527;
            this.cmb_Acc_Div_QD.Size = new System.Drawing.Size(210, 21);
            this.cmb_Acc_Div_QD.Style = style528;
            this.cmb_Acc_Div_QD.TabIndex = 75;
            // 
            // cmb_Cus_Cd_DS
            // 
            this.cmb_Cus_Cd_DS.AddItemCols = 0;
            this.cmb_Cus_Cd_DS.AddItemSeparator = ';';
            this.cmb_Cus_Cd_DS.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Cus_Cd_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Cus_Cd_DS.Caption = "";
            this.cmb_Cus_Cd_DS.CaptionHeight = 17;
            this.cmb_Cus_Cd_DS.CaptionStyle = style529;
            this.cmb_Cus_Cd_DS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Cus_Cd_DS.ColumnCaptionHeight = 18;
            this.cmb_Cus_Cd_DS.ColumnFooterHeight = 18;
            this.cmb_Cus_Cd_DS.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Cus_Cd_DS.ContentHeight = 17;
            this.cmb_Cus_Cd_DS.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Cus_Cd_DS.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Cus_Cd_DS.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cus_Cd_DS.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Cus_Cd_DS.EditorHeight = 17;
            this.cmb_Cus_Cd_DS.EvenRowStyle = style530;
            this.cmb_Cus_Cd_DS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Cus_Cd_DS.FooterStyle = style531;
            this.cmb_Cus_Cd_DS.GapHeight = 2;
            this.cmb_Cus_Cd_DS.HeadingStyle = style532;
            this.cmb_Cus_Cd_DS.HighLightRowStyle = style533;
            this.cmb_Cus_Cd_DS.ItemHeight = 15;
            this.cmb_Cus_Cd_DS.Location = new System.Drawing.Point(169, 14);
            this.cmb_Cus_Cd_DS.MatchEntryTimeout = ((long)(2000));
            this.cmb_Cus_Cd_DS.MaxDropDownItems = ((short)(5));
            this.cmb_Cus_Cd_DS.MaxLength = 32767;
            this.cmb_Cus_Cd_DS.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Cus_Cd_DS.Name = "cmb_Cus_Cd_DS";
            this.cmb_Cus_Cd_DS.OddRowStyle = style534;
            this.cmb_Cus_Cd_DS.PartialRightColumn = false;
            this.cmb_Cus_Cd_DS.PropBag = resources.GetString("cmb_Cus_Cd_DS.PropBag");
            this.cmb_Cus_Cd_DS.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Cus_Cd_DS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Cus_Cd_DS.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Cus_Cd_DS.SelectedStyle = style535;
            this.cmb_Cus_Cd_DS.Size = new System.Drawing.Size(150, 21);
            this.cmb_Cus_Cd_DS.Style = style536;
            this.cmb_Cus_Cd_DS.TabIndex = 58;
            this.cmb_Cus_Cd_DS.Tag = "Y";
            // 
            // cmb_Import_QD
            // 
            this.cmb_Import_QD.AddItemCols = 0;
            this.cmb_Import_QD.AddItemSeparator = ';';
            this.cmb_Import_QD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Import_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Import_QD.Caption = "";
            this.cmb_Import_QD.CaptionHeight = 17;
            this.cmb_Import_QD.CaptionStyle = style537;
            this.cmb_Import_QD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Import_QD.ColumnCaptionHeight = 18;
            this.cmb_Import_QD.ColumnFooterHeight = 18;
            this.cmb_Import_QD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Import_QD.ContentHeight = 17;
            this.cmb_Import_QD.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Import_QD.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Import_QD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Import_QD.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Import_QD.EditorHeight = 17;
            this.cmb_Import_QD.EvenRowStyle = style538;
            this.cmb_Import_QD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Import_QD.FooterStyle = style539;
            this.cmb_Import_QD.GapHeight = 2;
            this.cmb_Import_QD.HeadingStyle = style540;
            this.cmb_Import_QD.HighLightRowStyle = style541;
            this.cmb_Import_QD.ItemHeight = 15;
            this.cmb_Import_QD.Location = new System.Drawing.Point(108, 267);
            this.cmb_Import_QD.MatchEntryTimeout = ((long)(2000));
            this.cmb_Import_QD.MaxDropDownItems = ((short)(5));
            this.cmb_Import_QD.MaxLength = 32767;
            this.cmb_Import_QD.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Import_QD.Name = "cmb_Import_QD";
            this.cmb_Import_QD.OddRowStyle = style542;
            this.cmb_Import_QD.PartialRightColumn = false;
            this.cmb_Import_QD.PropBag = resources.GetString("cmb_Import_QD.PropBag");
            this.cmb_Import_QD.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Import_QD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Import_QD.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Import_QD.SelectedStyle = style543;
            this.cmb_Import_QD.Size = new System.Drawing.Size(210, 21);
            this.cmb_Import_QD.Style = style544;
            this.cmb_Import_QD.TabIndex = 70;
            this.cmb_Import_QD.Tag = "Y";
            // 
            // lbl_Cus_Cd_DS
            // 
            this.lbl_Cus_Cd_DS.ImageIndex = 1;
            this.lbl_Cus_Cd_DS.ImageList = this.img_Label;
            this.lbl_Cus_Cd_DS.Location = new System.Drawing.Point(7, 14);
            this.lbl_Cus_Cd_DS.Name = "lbl_Cus_Cd_DS";
            this.lbl_Cus_Cd_DS.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cus_Cd_DS.TabIndex = 594;
            this.lbl_Cus_Cd_DS.Text = "주거래처-DS";
            this.lbl_Cus_Cd_DS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Import_DS
            // 
            this.lbl_Import_DS.ImageIndex = 1;
            this.lbl_Import_DS.ImageList = this.img_Label;
            this.lbl_Import_DS.Location = new System.Drawing.Point(7, 58);
            this.lbl_Import_DS.Name = "lbl_Import_DS";
            this.lbl_Import_DS.Size = new System.Drawing.Size(100, 21);
            this.lbl_Import_DS.TabIndex = 612;
            this.lbl_Import_DS.Text = "Local /LLT-DS";
            this.lbl_Import_DS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Import_QD
            // 
            this.lbl_Import_QD.ImageIndex = 1;
            this.lbl_Import_QD.ImageList = this.img_Label;
            this.lbl_Import_QD.Location = new System.Drawing.Point(7, 267);
            this.lbl_Import_QD.Name = "lbl_Import_QD";
            this.lbl_Import_QD.Size = new System.Drawing.Size(100, 21);
            this.lbl_Import_QD.TabIndex = 613;
            this.lbl_Import_QD.Text = "Local /LLT-QD";
            this.lbl_Import_QD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Import_DS
            // 
            this.cmb_Import_DS.AddItemCols = 0;
            this.cmb_Import_DS.AddItemSeparator = ';';
            this.cmb_Import_DS.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Import_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Import_DS.Caption = "";
            this.cmb_Import_DS.CaptionHeight = 17;
            this.cmb_Import_DS.CaptionStyle = style545;
            this.cmb_Import_DS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Import_DS.ColumnCaptionHeight = 18;
            this.cmb_Import_DS.ColumnFooterHeight = 18;
            this.cmb_Import_DS.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Import_DS.ContentHeight = 17;
            this.cmb_Import_DS.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Import_DS.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Import_DS.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Import_DS.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Import_DS.EditorHeight = 17;
            this.cmb_Import_DS.EvenRowStyle = style546;
            this.cmb_Import_DS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Import_DS.FooterStyle = style547;
            this.cmb_Import_DS.GapHeight = 2;
            this.cmb_Import_DS.HeadingStyle = style548;
            this.cmb_Import_DS.HighLightRowStyle = style549;
            this.cmb_Import_DS.ItemHeight = 15;
            this.cmb_Import_DS.Location = new System.Drawing.Point(108, 58);
            this.cmb_Import_DS.MatchEntryTimeout = ((long)(2000));
            this.cmb_Import_DS.MaxDropDownItems = ((short)(5));
            this.cmb_Import_DS.MaxLength = 32767;
            this.cmb_Import_DS.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Import_DS.Name = "cmb_Import_DS";
            this.cmb_Import_DS.OddRowStyle = style550;
            this.cmb_Import_DS.PartialRightColumn = false;
            this.cmb_Import_DS.PropBag = resources.GetString("cmb_Import_DS.PropBag");
            this.cmb_Import_DS.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Import_DS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Import_DS.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Import_DS.SelectedStyle = style551;
            this.cmb_Import_DS.Size = new System.Drawing.Size(210, 21);
            this.cmb_Import_DS.Style = style552;
            this.cmb_Import_DS.TabIndex = 69;
            this.cmb_Import_DS.Tag = "Y";
            // 
            // lbl_Dl_Days_Ds
            // 
            this.lbl_Dl_Days_Ds.ImageIndex = 1;
            this.lbl_Dl_Days_Ds.ImageList = this.img_Label;
            this.lbl_Dl_Days_Ds.Location = new System.Drawing.Point(7, 80);
            this.lbl_Dl_Days_Ds.Name = "lbl_Dl_Days_Ds";
            this.lbl_Dl_Days_Ds.Size = new System.Drawing.Size(100, 21);
            this.lbl_Dl_Days_Ds.TabIndex = 618;
            this.lbl_Dl_Days_Ds.Text = "납기소요일-DS";
            this.lbl_Dl_Days_Ds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Dl_Days_DS
            // 
            this.txt_Dl_Days_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dl_Days_DS.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Dl_Days_DS.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Dl_Days_DS.Location = new System.Drawing.Point(108, 80);
            this.txt_Dl_Days_DS.MaxLength = 3;
            this.txt_Dl_Days_DS.Name = "txt_Dl_Days_DS";
            this.txt_Dl_Days_DS.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Dl_Days_DS.Size = new System.Drawing.Size(210, 21);
            this.txt_Dl_Days_DS.TabIndex = 615;
            this.txt_Dl_Days_DS.Tag = "Y";
            this.txt_Dl_Days_DS.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Dl_Days_DS.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // lbl_Acc_Div_Ds
            // 
            this.lbl_Acc_Div_Ds.ImageIndex = 0;
            this.lbl_Acc_Div_Ds.ImageList = this.img_Label;
            this.lbl_Acc_Div_Ds.Location = new System.Drawing.Point(7, 102);
            this.lbl_Acc_Div_Ds.Name = "lbl_Acc_Div_Ds";
            this.lbl_Acc_Div_Ds.Size = new System.Drawing.Size(100, 21);
            this.lbl_Acc_Div_Ds.TabIndex = 607;
            this.lbl_Acc_Div_Ds.Text = "회계분류-DS";
            this.lbl_Acc_Div_Ds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Acc_Div_DS
            // 
            this.cmb_Acc_Div_DS.AddItemCols = 0;
            this.cmb_Acc_Div_DS.AddItemSeparator = ';';
            this.cmb_Acc_Div_DS.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Acc_Div_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Acc_Div_DS.Caption = "";
            this.cmb_Acc_Div_DS.CaptionHeight = 17;
            this.cmb_Acc_Div_DS.CaptionStyle = style553;
            this.cmb_Acc_Div_DS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Acc_Div_DS.ColumnCaptionHeight = 18;
            this.cmb_Acc_Div_DS.ColumnFooterHeight = 18;
            this.cmb_Acc_Div_DS.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Acc_Div_DS.ContentHeight = 17;
            this.cmb_Acc_Div_DS.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Acc_Div_DS.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Acc_Div_DS.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Acc_Div_DS.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Acc_Div_DS.EditorHeight = 17;
            this.cmb_Acc_Div_DS.EvenRowStyle = style554;
            this.cmb_Acc_Div_DS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Acc_Div_DS.FooterStyle = style555;
            this.cmb_Acc_Div_DS.GapHeight = 2;
            this.cmb_Acc_Div_DS.HeadingStyle = style556;
            this.cmb_Acc_Div_DS.HighLightRowStyle = style557;
            this.cmb_Acc_Div_DS.ItemHeight = 15;
            this.cmb_Acc_Div_DS.Location = new System.Drawing.Point(108, 102);
            this.cmb_Acc_Div_DS.MatchEntryTimeout = ((long)(2000));
            this.cmb_Acc_Div_DS.MaxDropDownItems = ((short)(5));
            this.cmb_Acc_Div_DS.MaxLength = 32767;
            this.cmb_Acc_Div_DS.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Acc_Div_DS.Name = "cmb_Acc_Div_DS";
            this.cmb_Acc_Div_DS.OddRowStyle = style558;
            this.cmb_Acc_Div_DS.PartialRightColumn = false;
            this.cmb_Acc_Div_DS.PropBag = resources.GetString("cmb_Acc_Div_DS.PropBag");
            this.cmb_Acc_Div_DS.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_DS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Acc_Div_DS.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_DS.SelectedStyle = style559;
            this.cmb_Acc_Div_DS.Size = new System.Drawing.Size(210, 21);
            this.cmb_Acc_Div_DS.Style = style560;
            this.cmb_Acc_Div_DS.TabIndex = 74;
            // 
            // lbl_Cost_YN
            // 
            this.lbl_Cost_YN.ImageIndex = 0;
            this.lbl_Cost_YN.ImageList = this.img_Label;
            this.lbl_Cost_YN.Location = new System.Drawing.Point(7, 150);
            this.lbl_Cost_YN.Name = "lbl_Cost_YN";
            this.lbl_Cost_YN.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cost_YN.TabIndex = 598;
            this.lbl_Cost_YN.Text = "원가관리여부";
            this.lbl_Cost_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Acc_Div_YN
            // 
            this.cmb_Acc_Div_YN.AddItemCols = 0;
            this.cmb_Acc_Div_YN.AddItemSeparator = ';';
            this.cmb_Acc_Div_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Acc_Div_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Acc_Div_YN.Caption = "";
            this.cmb_Acc_Div_YN.CaptionHeight = 17;
            this.cmb_Acc_Div_YN.CaptionStyle = style561;
            this.cmb_Acc_Div_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Acc_Div_YN.ColumnCaptionHeight = 18;
            this.cmb_Acc_Div_YN.ColumnFooterHeight = 18;
            this.cmb_Acc_Div_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Acc_Div_YN.ContentHeight = 17;
            this.cmb_Acc_Div_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Acc_Div_YN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Acc_Div_YN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Acc_Div_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Acc_Div_YN.EditorHeight = 17;
            this.cmb_Acc_Div_YN.EvenRowStyle = style562;
            this.cmb_Acc_Div_YN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Acc_Div_YN.FooterStyle = style563;
            this.cmb_Acc_Div_YN.GapHeight = 2;
            this.cmb_Acc_Div_YN.HeadingStyle = style564;
            this.cmb_Acc_Div_YN.HighLightRowStyle = style565;
            this.cmb_Acc_Div_YN.ItemHeight = 15;
            this.cmb_Acc_Div_YN.Location = new System.Drawing.Point(108, 172);
            this.cmb_Acc_Div_YN.MatchEntryTimeout = ((long)(2000));
            this.cmb_Acc_Div_YN.MaxDropDownItems = ((short)(5));
            this.cmb_Acc_Div_YN.MaxLength = 32767;
            this.cmb_Acc_Div_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Acc_Div_YN.Name = "cmb_Acc_Div_YN";
            this.cmb_Acc_Div_YN.OddRowStyle = style566;
            this.cmb_Acc_Div_YN.PartialRightColumn = false;
            this.cmb_Acc_Div_YN.PropBag = resources.GetString("cmb_Acc_Div_YN.PropBag");
            this.cmb_Acc_Div_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Acc_Div_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Acc_Div_YN.SelectedStyle = style567;
            this.cmb_Acc_Div_YN.Size = new System.Drawing.Size(210, 21);
            this.cmb_Acc_Div_YN.Style = style568;
            this.cmb_Acc_Div_YN.TabIndex = 73;
            // 
            // lbl_Acc_Div_YN
            // 
            this.lbl_Acc_Div_YN.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_Acc_Div_YN.ImageIndex = 0;
            this.lbl_Acc_Div_YN.ImageList = this.img_Label;
            this.lbl_Acc_Div_YN.Location = new System.Drawing.Point(7, 172);
            this.lbl_Acc_Div_YN.Name = "lbl_Acc_Div_YN";
            this.lbl_Acc_Div_YN.Size = new System.Drawing.Size(100, 21);
            this.lbl_Acc_Div_YN.TabIndex = 600;
            this.lbl_Acc_Div_YN.Text = "회계분류사용여부";
            this.lbl_Acc_Div_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Man_Charge_QD
            // 
            this.cmb_Man_Charge_QD.AddItemCols = 0;
            this.cmb_Man_Charge_QD.AddItemSeparator = ';';
            this.cmb_Man_Charge_QD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Man_Charge_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Man_Charge_QD.Caption = "";
            this.cmb_Man_Charge_QD.CaptionHeight = 17;
            this.cmb_Man_Charge_QD.CaptionStyle = style569;
            this.cmb_Man_Charge_QD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Man_Charge_QD.ColumnCaptionHeight = 18;
            this.cmb_Man_Charge_QD.ColumnFooterHeight = 18;
            this.cmb_Man_Charge_QD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Man_Charge_QD.ContentHeight = 17;
            this.cmb_Man_Charge_QD.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Man_Charge_QD.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Man_Charge_QD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Man_Charge_QD.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Man_Charge_QD.EditorHeight = 17;
            this.cmb_Man_Charge_QD.EvenRowStyle = style570;
            this.cmb_Man_Charge_QD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Man_Charge_QD.FooterStyle = style571;
            this.cmb_Man_Charge_QD.GapHeight = 2;
            this.cmb_Man_Charge_QD.HeadingStyle = style572;
            this.cmb_Man_Charge_QD.HighLightRowStyle = style573;
            this.cmb_Man_Charge_QD.ItemHeight = 15;
            this.cmb_Man_Charge_QD.Location = new System.Drawing.Point(169, 245);
            this.cmb_Man_Charge_QD.MatchEntryTimeout = ((long)(2000));
            this.cmb_Man_Charge_QD.MaxDropDownItems = ((short)(5));
            this.cmb_Man_Charge_QD.MaxLength = 32767;
            this.cmb_Man_Charge_QD.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Man_Charge_QD.Name = "cmb_Man_Charge_QD";
            this.cmb_Man_Charge_QD.OddRowStyle = style574;
            this.cmb_Man_Charge_QD.PartialRightColumn = false;
            this.cmb_Man_Charge_QD.PropBag = resources.GetString("cmb_Man_Charge_QD.PropBag");
            this.cmb_Man_Charge_QD.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_QD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Man_Charge_QD.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_QD.SelectedStyle = style575;
            this.cmb_Man_Charge_QD.Size = new System.Drawing.Size(150, 21);
            this.cmb_Man_Charge_QD.Style = style576;
            this.cmb_Man_Charge_QD.TabIndex = 66;
            this.cmb_Man_Charge_QD.Tag = "Y";
            this.cmb_Man_Charge_QD.SelectedValueChanged += new System.EventHandler(this.cmb_Man_Charge_SelectedValueChanged);
            // 
            // cmb_Cus_Cd_QD
            // 
            this.cmb_Cus_Cd_QD.AddItemCols = 0;
            this.cmb_Cus_Cd_QD.AddItemSeparator = ';';
            this.cmb_Cus_Cd_QD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Cus_Cd_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Cus_Cd_QD.Caption = "";
            this.cmb_Cus_Cd_QD.CaptionHeight = 17;
            this.cmb_Cus_Cd_QD.CaptionStyle = style577;
            this.cmb_Cus_Cd_QD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Cus_Cd_QD.ColumnCaptionHeight = 18;
            this.cmb_Cus_Cd_QD.ColumnFooterHeight = 18;
            this.cmb_Cus_Cd_QD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Cus_Cd_QD.ContentHeight = 17;
            this.cmb_Cus_Cd_QD.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Cus_Cd_QD.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Cus_Cd_QD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cus_Cd_QD.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Cus_Cd_QD.EditorHeight = 17;
            this.cmb_Cus_Cd_QD.EvenRowStyle = style578;
            this.cmb_Cus_Cd_QD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Cus_Cd_QD.FooterStyle = style579;
            this.cmb_Cus_Cd_QD.GapHeight = 2;
            this.cmb_Cus_Cd_QD.HeadingStyle = style580;
            this.cmb_Cus_Cd_QD.HighLightRowStyle = style581;
            this.cmb_Cus_Cd_QD.ItemHeight = 15;
            this.cmb_Cus_Cd_QD.Location = new System.Drawing.Point(169, 223);
            this.cmb_Cus_Cd_QD.MatchEntryTimeout = ((long)(2000));
            this.cmb_Cus_Cd_QD.MaxDropDownItems = ((short)(5));
            this.cmb_Cus_Cd_QD.MaxLength = 32767;
            this.cmb_Cus_Cd_QD.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Cus_Cd_QD.Name = "cmb_Cus_Cd_QD";
            this.cmb_Cus_Cd_QD.OddRowStyle = style582;
            this.cmb_Cus_Cd_QD.PartialRightColumn = false;
            this.cmb_Cus_Cd_QD.PropBag = resources.GetString("cmb_Cus_Cd_QD.PropBag");
            this.cmb_Cus_Cd_QD.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Cus_Cd_QD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Cus_Cd_QD.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Cus_Cd_QD.SelectedStyle = style583;
            this.cmb_Cus_Cd_QD.Size = new System.Drawing.Size(150, 21);
            this.cmb_Cus_Cd_QD.Style = style584;
            this.cmb_Cus_Cd_QD.TabIndex = 60;
            this.cmb_Cus_Cd_QD.Tag = "Y";
            // 
            // txt_Man_Charge_QD
            // 
            this.txt_Man_Charge_QD.BackColor = System.Drawing.Color.White;
            this.txt_Man_Charge_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Man_Charge_QD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Man_Charge_QD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Man_Charge_QD.Location = new System.Drawing.Point(108, 245);
            this.txt_Man_Charge_QD.MaxLength = 10;
            this.txt_Man_Charge_QD.Name = "txt_Man_Charge_QD";
            this.txt_Man_Charge_QD.Size = new System.Drawing.Size(60, 21);
            this.txt_Man_Charge_QD.TabIndex = 65;
            this.txt_Man_Charge_QD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // cmb_Cost_YN
            // 
            this.cmb_Cost_YN.AddItemCols = 0;
            this.cmb_Cost_YN.AddItemSeparator = ';';
            this.cmb_Cost_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Cost_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Cost_YN.Caption = "";
            this.cmb_Cost_YN.CaptionHeight = 17;
            this.cmb_Cost_YN.CaptionStyle = style585;
            this.cmb_Cost_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Cost_YN.ColumnCaptionHeight = 18;
            this.cmb_Cost_YN.ColumnFooterHeight = 18;
            this.cmb_Cost_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Cost_YN.ContentHeight = 17;
            this.cmb_Cost_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Cost_YN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Cost_YN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cost_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Cost_YN.EditorHeight = 17;
            this.cmb_Cost_YN.EvenRowStyle = style586;
            this.cmb_Cost_YN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Cost_YN.FooterStyle = style587;
            this.cmb_Cost_YN.GapHeight = 2;
            this.cmb_Cost_YN.HeadingStyle = style588;
            this.cmb_Cost_YN.HighLightRowStyle = style589;
            this.cmb_Cost_YN.ItemHeight = 15;
            this.cmb_Cost_YN.Location = new System.Drawing.Point(108, 150);
            this.cmb_Cost_YN.MatchEntryTimeout = ((long)(2000));
            this.cmb_Cost_YN.MaxDropDownItems = ((short)(5));
            this.cmb_Cost_YN.MaxLength = 32767;
            this.cmb_Cost_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Cost_YN.Name = "cmb_Cost_YN";
            this.cmb_Cost_YN.OddRowStyle = style590;
            this.cmb_Cost_YN.PartialRightColumn = false;
            this.cmb_Cost_YN.PropBag = resources.GetString("cmb_Cost_YN.PropBag");
            this.cmb_Cost_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Cost_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Cost_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Cost_YN.SelectedStyle = style591;
            this.cmb_Cost_YN.Size = new System.Drawing.Size(210, 21);
            this.cmb_Cost_YN.Style = style592;
            this.cmb_Cost_YN.TabIndex = 72;
            // 
            // lbl_Man_Charge_QD
            // 
            this.lbl_Man_Charge_QD.ImageIndex = 0;
            this.lbl_Man_Charge_QD.ImageList = this.img_Label;
            this.lbl_Man_Charge_QD.Location = new System.Drawing.Point(7, 245);
            this.lbl_Man_Charge_QD.Name = "lbl_Man_Charge_QD";
            this.lbl_Man_Charge_QD.Size = new System.Drawing.Size(100, 21);
            this.lbl_Man_Charge_QD.TabIndex = 601;
            this.lbl_Man_Charge_QD.Text = "담당자-QD";
            this.lbl_Man_Charge_QD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Cus_Cd_QD
            // 
            this.lbl_Cus_Cd_QD.ImageIndex = 0;
            this.lbl_Cus_Cd_QD.ImageList = this.img_Label;
            this.lbl_Cus_Cd_QD.Location = new System.Drawing.Point(7, 223);
            this.lbl_Cus_Cd_QD.Name = "lbl_Cus_Cd_QD";
            this.lbl_Cus_Cd_QD.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cus_Cd_QD.TabIndex = 595;
            this.lbl_Cus_Cd_QD.Text = "주거래처-QD";
            this.lbl_Cus_Cd_QD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Cus_Cd_QD
            // 
            this.txt_Cus_Cd_QD.BackColor = System.Drawing.Color.White;
            this.txt_Cus_Cd_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cus_Cd_QD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Cus_Cd_QD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Cus_Cd_QD.Location = new System.Drawing.Point(108, 223);
            this.txt_Cus_Cd_QD.MaxLength = 10;
            this.txt_Cus_Cd_QD.Name = "txt_Cus_Cd_QD";
            this.txt_Cus_Cd_QD.Size = new System.Drawing.Size(60, 21);
            this.txt_Cus_Cd_QD.TabIndex = 59;
            this.txt_Cus_Cd_QD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // tab_MRP
            // 
            this.tab_MRP.BackColor = System.Drawing.SystemColors.Window;
            this.tab_MRP.Controls.Add(this.gbox_MRP2);
            this.tab_MRP.Controls.Add(this.gbox_MRP1);
            this.tab_MRP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_MRP.Location = new System.Drawing.Point(4, 25);
            this.tab_MRP.Name = "tab_MRP";
            this.tab_MRP.Size = new System.Drawing.Size(192, 71);
            this.tab_MRP.TabIndex = 3;
            this.tab_MRP.Text = "MRP";
            this.tab_MRP.ToolTipText = "MRP";
            this.tab_MRP.Visible = false;
            // 
            // gbox_MRP2
            // 
            this.gbox_MRP2.Controls.Add(this.lbl_Safe_Amt_JJ);
            this.gbox_MRP2.Controls.Add(this.txt_Safe_Amt_JJ);
            this.gbox_MRP2.Controls.Add(this.txt_Out_Loss_Rate);
            this.gbox_MRP2.Controls.Add(this.txt_Ship_Loss_Rate);
            this.gbox_MRP2.Controls.Add(this.txt_Pur_Loss_Rate);
            this.gbox_MRP2.Controls.Add(this.lbl_Ship_Loss_Rate);
            this.gbox_MRP2.Controls.Add(this.lbl_Out_Loss_Rate);
            this.gbox_MRP2.Controls.Add(this.lbl_Pur_Loss_Rate);
            this.gbox_MRP2.Controls.Add(this.txt_Safe_Amt_QD);
            this.gbox_MRP2.Controls.Add(this.lbl_Safe_Amt_Vj);
            this.gbox_MRP2.Controls.Add(this.lbl_Safe_Amt_Qd);
            this.gbox_MRP2.Controls.Add(this.lbl_Safe_Amt_Ds);
            this.gbox_MRP2.Controls.Add(this.txt_Safe_Amt_DS);
            this.gbox_MRP2.Controls.Add(this.txt_Safe_Amt_VJ);
            this.gbox_MRP2.Location = new System.Drawing.Point(340, 5);
            this.gbox_MRP2.Name = "gbox_MRP2";
            this.gbox_MRP2.Size = new System.Drawing.Size(327, 340);
            this.gbox_MRP2.TabIndex = 1;
            this.gbox_MRP2.TabStop = false;
            // 
            // lbl_Safe_Amt_JJ
            // 
            this.lbl_Safe_Amt_JJ.ImageIndex = 0;
            this.lbl_Safe_Amt_JJ.ImageList = this.img_Label;
            this.lbl_Safe_Amt_JJ.Location = new System.Drawing.Point(7, 79);
            this.lbl_Safe_Amt_JJ.Name = "lbl_Safe_Amt_JJ";
            this.lbl_Safe_Amt_JJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Safe_Amt_JJ.TabIndex = 627;
            this.lbl_Safe_Amt_JJ.Text = "안전재고량-JJ";
            this.lbl_Safe_Amt_JJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Safe_Amt_JJ
            // 
            this.txt_Safe_Amt_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Safe_Amt_JJ.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Safe_Amt_JJ.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Safe_Amt_JJ.Location = new System.Drawing.Point(108, 79);
            this.txt_Safe_Amt_JJ.MaxLength = 7;
            this.txt_Safe_Amt_JJ.Name = "txt_Safe_Amt_JJ";
            this.txt_Safe_Amt_JJ.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Safe_Amt_JJ.Size = new System.Drawing.Size(210, 21);
            this.txt_Safe_Amt_JJ.TabIndex = 626;
            this.txt_Safe_Amt_JJ.Tag = null;
            this.txt_Safe_Amt_JJ.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Safe_Amt_JJ.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // txt_Out_Loss_Rate
            // 
            this.txt_Out_Loss_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Out_Loss_Rate.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Out_Loss_Rate.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Out_Loss_Rate.Location = new System.Drawing.Point(108, 167);
            this.txt_Out_Loss_Rate.Name = "txt_Out_Loss_Rate";
            this.txt_Out_Loss_Rate.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Out_Loss_Rate.Size = new System.Drawing.Size(210, 21);
            this.txt_Out_Loss_Rate.TabIndex = 45;
            this.txt_Out_Loss_Rate.Tag = null;
            this.txt_Out_Loss_Rate.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Out_Loss_Rate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // txt_Ship_Loss_Rate
            // 
            this.txt_Ship_Loss_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ship_Loss_Rate.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Ship_Loss_Rate.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Ship_Loss_Rate.Location = new System.Drawing.Point(108, 145);
            this.txt_Ship_Loss_Rate.Name = "txt_Ship_Loss_Rate";
            this.txt_Ship_Loss_Rate.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Ship_Loss_Rate.Size = new System.Drawing.Size(210, 21);
            this.txt_Ship_Loss_Rate.TabIndex = 44;
            this.txt_Ship_Loss_Rate.Tag = null;
            this.txt_Ship_Loss_Rate.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Ship_Loss_Rate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // txt_Pur_Loss_Rate
            // 
            this.txt_Pur_Loss_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pur_Loss_Rate.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Pur_Loss_Rate.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Pur_Loss_Rate.Location = new System.Drawing.Point(108, 123);
            this.txt_Pur_Loss_Rate.Name = "txt_Pur_Loss_Rate";
            this.txt_Pur_Loss_Rate.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Pur_Loss_Rate.Size = new System.Drawing.Size(210, 21);
            this.txt_Pur_Loss_Rate.TabIndex = 43;
            this.txt_Pur_Loss_Rate.Tag = null;
            this.txt_Pur_Loss_Rate.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Pur_Loss_Rate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // lbl_Ship_Loss_Rate
            // 
            this.lbl_Ship_Loss_Rate.ImageIndex = 0;
            this.lbl_Ship_Loss_Rate.ImageList = this.img_Label;
            this.lbl_Ship_Loss_Rate.Location = new System.Drawing.Point(7, 145);
            this.lbl_Ship_Loss_Rate.Name = "lbl_Ship_Loss_Rate";
            this.lbl_Ship_Loss_Rate.Size = new System.Drawing.Size(100, 21);
            this.lbl_Ship_Loss_Rate.TabIndex = 625;
            this.lbl_Ship_Loss_Rate.Text = "SHIP LOSSRATE";
            this.lbl_Ship_Loss_Rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Out_Loss_Rate
            // 
            this.lbl_Out_Loss_Rate.ImageIndex = 0;
            this.lbl_Out_Loss_Rate.ImageList = this.img_Label;
            this.lbl_Out_Loss_Rate.Location = new System.Drawing.Point(7, 167);
            this.lbl_Out_Loss_Rate.Name = "lbl_Out_Loss_Rate";
            this.lbl_Out_Loss_Rate.Size = new System.Drawing.Size(100, 21);
            this.lbl_Out_Loss_Rate.TabIndex = 623;
            this.lbl_Out_Loss_Rate.Text = "OUT LOSSRATE";
            this.lbl_Out_Loss_Rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Pur_Loss_Rate
            // 
            this.lbl_Pur_Loss_Rate.ImageIndex = 0;
            this.lbl_Pur_Loss_Rate.ImageList = this.img_Label;
            this.lbl_Pur_Loss_Rate.Location = new System.Drawing.Point(7, 123);
            this.lbl_Pur_Loss_Rate.Name = "lbl_Pur_Loss_Rate";
            this.lbl_Pur_Loss_Rate.Size = new System.Drawing.Size(100, 21);
            this.lbl_Pur_Loss_Rate.TabIndex = 617;
            this.lbl_Pur_Loss_Rate.Text = "PUR LOSSRATE";
            this.lbl_Pur_Loss_Rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Safe_Amt_QD
            // 
            this.txt_Safe_Amt_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Safe_Amt_QD.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Safe_Amt_QD.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Safe_Amt_QD.Location = new System.Drawing.Point(108, 35);
            this.txt_Safe_Amt_QD.MaxLength = 7;
            this.txt_Safe_Amt_QD.Name = "txt_Safe_Amt_QD";
            this.txt_Safe_Amt_QD.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Safe_Amt_QD.Size = new System.Drawing.Size(210, 21);
            this.txt_Safe_Amt_QD.TabIndex = 36;
            this.txt_Safe_Amt_QD.Tag = null;
            this.txt_Safe_Amt_QD.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Safe_Amt_QD.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // lbl_Safe_Amt_Vj
            // 
            this.lbl_Safe_Amt_Vj.ImageIndex = 0;
            this.lbl_Safe_Amt_Vj.ImageList = this.img_Label;
            this.lbl_Safe_Amt_Vj.Location = new System.Drawing.Point(7, 57);
            this.lbl_Safe_Amt_Vj.Name = "lbl_Safe_Amt_Vj";
            this.lbl_Safe_Amt_Vj.Size = new System.Drawing.Size(100, 21);
            this.lbl_Safe_Amt_Vj.TabIndex = 610;
            this.lbl_Safe_Amt_Vj.Text = "안전재고량-VJ";
            this.lbl_Safe_Amt_Vj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Safe_Amt_Qd
            // 
            this.lbl_Safe_Amt_Qd.ImageIndex = 0;
            this.lbl_Safe_Amt_Qd.ImageList = this.img_Label;
            this.lbl_Safe_Amt_Qd.Location = new System.Drawing.Point(7, 35);
            this.lbl_Safe_Amt_Qd.Name = "lbl_Safe_Amt_Qd";
            this.lbl_Safe_Amt_Qd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Safe_Amt_Qd.TabIndex = 609;
            this.lbl_Safe_Amt_Qd.Text = "안전재고량-QD";
            this.lbl_Safe_Amt_Qd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Safe_Amt_Ds
            // 
            this.lbl_Safe_Amt_Ds.ImageIndex = 0;
            this.lbl_Safe_Amt_Ds.ImageList = this.img_Label;
            this.lbl_Safe_Amt_Ds.Location = new System.Drawing.Point(7, 13);
            this.lbl_Safe_Amt_Ds.Name = "lbl_Safe_Amt_Ds";
            this.lbl_Safe_Amt_Ds.Size = new System.Drawing.Size(100, 21);
            this.lbl_Safe_Amt_Ds.TabIndex = 608;
            this.lbl_Safe_Amt_Ds.Text = "안전재고량-DS";
            this.lbl_Safe_Amt_Ds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Safe_Amt_DS
            // 
            this.txt_Safe_Amt_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Safe_Amt_DS.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Safe_Amt_DS.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Safe_Amt_DS.Location = new System.Drawing.Point(108, 13);
            this.txt_Safe_Amt_DS.MaxLength = 7;
            this.txt_Safe_Amt_DS.Name = "txt_Safe_Amt_DS";
            this.txt_Safe_Amt_DS.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Safe_Amt_DS.Size = new System.Drawing.Size(210, 21);
            this.txt_Safe_Amt_DS.TabIndex = 35;
            this.txt_Safe_Amt_DS.Tag = null;
            this.txt_Safe_Amt_DS.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Safe_Amt_DS.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // txt_Safe_Amt_VJ
            // 
            this.txt_Safe_Amt_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Safe_Amt_VJ.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Safe_Amt_VJ.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Safe_Amt_VJ.Location = new System.Drawing.Point(108, 57);
            this.txt_Safe_Amt_VJ.MaxLength = 7;
            this.txt_Safe_Amt_VJ.Name = "txt_Safe_Amt_VJ";
            this.txt_Safe_Amt_VJ.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Safe_Amt_VJ.Size = new System.Drawing.Size(210, 21);
            this.txt_Safe_Amt_VJ.TabIndex = 37;
            this.txt_Safe_Amt_VJ.Tag = null;
            this.txt_Safe_Amt_VJ.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Safe_Amt_VJ.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // gbox_MRP1
            // 
            this.gbox_MRP1.Controls.Add(this.txt_Life_Day);
            this.gbox_MRP1.Controls.Add(this.cmb_Life_YN);
            this.gbox_MRP1.Controls.Add(this.lbl_Life_Day);
            this.gbox_MRP1.Controls.Add(this.lbl_Life_YN);
            this.gbox_MRP1.Controls.Add(this.cmb_Lone_YN);
            this.gbox_MRP1.Controls.Add(this.lbl_Lone_Yn);
            this.gbox_MRP1.Controls.Add(this.cmb_In_Wh_Cd);
            this.gbox_MRP1.Controls.Add(this.cmb_Out_Wh_Cd);
            this.gbox_MRP1.Controls.Add(this.lbl_Out_Wh_Cd);
            this.gbox_MRP1.Controls.Add(this.lbl_In_Wh_Cd);
            this.gbox_MRP1.Font = new System.Drawing.Font("Verdana", 9F);
            this.gbox_MRP1.Location = new System.Drawing.Point(7, 5);
            this.gbox_MRP1.Name = "gbox_MRP1";
            this.gbox_MRP1.Size = new System.Drawing.Size(327, 340);
            this.gbox_MRP1.TabIndex = 0;
            this.gbox_MRP1.TabStop = false;
            // 
            // txt_Life_Day
            // 
            this.txt_Life_Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Life_Day.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Life_Day.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.txt_Life_Day.Location = new System.Drawing.Point(108, 35);
            this.txt_Life_Day.MaxLength = 3;
            this.txt_Life_Day.Name = "txt_Life_Day";
            this.txt_Life_Day.NumericInputKeys = C1.Win.C1Input.NumericInputKeyFlags.None;
            this.txt_Life_Day.Size = new System.Drawing.Size(210, 21);
            this.txt_Life_Day.TabIndex = 34;
            this.txt_Life_Day.Tag = null;
            this.txt_Life_Day.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Life_Day.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // cmb_Life_YN
            // 
            this.cmb_Life_YN.AddItemCols = 0;
            this.cmb_Life_YN.AddItemSeparator = ';';
            this.cmb_Life_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Life_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Life_YN.Caption = "";
            this.cmb_Life_YN.CaptionHeight = 17;
            this.cmb_Life_YN.CaptionStyle = style593;
            this.cmb_Life_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Life_YN.ColumnCaptionHeight = 18;
            this.cmb_Life_YN.ColumnFooterHeight = 18;
            this.cmb_Life_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Life_YN.ContentHeight = 17;
            this.cmb_Life_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Life_YN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Life_YN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Life_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Life_YN.EditorHeight = 17;
            this.cmb_Life_YN.EvenRowStyle = style594;
            this.cmb_Life_YN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Life_YN.FooterStyle = style595;
            this.cmb_Life_YN.GapHeight = 2;
            this.cmb_Life_YN.HeadingStyle = style596;
            this.cmb_Life_YN.HighLightRowStyle = style597;
            this.cmb_Life_YN.ItemHeight = 15;
            this.cmb_Life_YN.Location = new System.Drawing.Point(108, 13);
            this.cmb_Life_YN.MatchEntryTimeout = ((long)(2000));
            this.cmb_Life_YN.MaxDropDownItems = ((short)(5));
            this.cmb_Life_YN.MaxLength = 32767;
            this.cmb_Life_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Life_YN.Name = "cmb_Life_YN";
            this.cmb_Life_YN.OddRowStyle = style598;
            this.cmb_Life_YN.PartialRightColumn = false;
            this.cmb_Life_YN.PropBag = resources.GetString("cmb_Life_YN.PropBag");
            this.cmb_Life_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Life_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Life_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Life_YN.SelectedStyle = style599;
            this.cmb_Life_YN.Size = new System.Drawing.Size(210, 21);
            this.cmb_Life_YN.Style = style600;
            this.cmb_Life_YN.TabIndex = 33;
            // 
            // lbl_Life_Day
            // 
            this.lbl_Life_Day.ImageIndex = 0;
            this.lbl_Life_Day.ImageList = this.img_Label;
            this.lbl_Life_Day.Location = new System.Drawing.Point(7, 35);
            this.lbl_Life_Day.Name = "lbl_Life_Day";
            this.lbl_Life_Day.Size = new System.Drawing.Size(100, 21);
            this.lbl_Life_Day.TabIndex = 616;
            this.lbl_Life_Day.Text = "악성재고 일수";
            this.lbl_Life_Day.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Life_YN
            // 
            this.lbl_Life_YN.ImageIndex = 0;
            this.lbl_Life_YN.ImageList = this.img_Label;
            this.lbl_Life_YN.Location = new System.Drawing.Point(7, 13);
            this.lbl_Life_YN.Name = "lbl_Life_YN";
            this.lbl_Life_YN.Size = new System.Drawing.Size(100, 21);
            this.lbl_Life_YN.TabIndex = 615;
            this.lbl_Life_YN.Text = "악성재고 유무";
            this.lbl_Life_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Lone_YN
            // 
            this.cmb_Lone_YN.AddItemCols = 0;
            this.cmb_Lone_YN.AddItemSeparator = ';';
            this.cmb_Lone_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Lone_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Lone_YN.Caption = "";
            this.cmb_Lone_YN.CaptionHeight = 17;
            this.cmb_Lone_YN.CaptionStyle = style601;
            this.cmb_Lone_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Lone_YN.ColumnCaptionHeight = 18;
            this.cmb_Lone_YN.ColumnFooterHeight = 18;
            this.cmb_Lone_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Lone_YN.ContentHeight = 17;
            this.cmb_Lone_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Lone_YN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Lone_YN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Lone_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Lone_YN.EditorHeight = 17;
            this.cmb_Lone_YN.EvenRowStyle = style602;
            this.cmb_Lone_YN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Lone_YN.FooterStyle = style603;
            this.cmb_Lone_YN.GapHeight = 2;
            this.cmb_Lone_YN.HeadingStyle = style604;
            this.cmb_Lone_YN.HighLightRowStyle = style605;
            this.cmb_Lone_YN.ItemHeight = 15;
            this.cmb_Lone_YN.Location = new System.Drawing.Point(108, 167);
            this.cmb_Lone_YN.MatchEntryTimeout = ((long)(2000));
            this.cmb_Lone_YN.MaxDropDownItems = ((short)(5));
            this.cmb_Lone_YN.MaxLength = 32767;
            this.cmb_Lone_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Lone_YN.Name = "cmb_Lone_YN";
            this.cmb_Lone_YN.OddRowStyle = style606;
            this.cmb_Lone_YN.PartialRightColumn = false;
            this.cmb_Lone_YN.PropBag = resources.GetString("cmb_Lone_YN.PropBag");
            this.cmb_Lone_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Lone_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Lone_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Lone_YN.SelectedStyle = style607;
            this.cmb_Lone_YN.Size = new System.Drawing.Size(210, 21);
            this.cmb_Lone_YN.Style = style608;
            this.cmb_Lone_YN.TabIndex = 32;
            this.cmb_Lone_YN.Tag = "Y";
            this.cmb_Lone_YN.Visible = false;
            // 
            // lbl_Lone_Yn
            // 
            this.lbl_Lone_Yn.ImageIndex = 0;
            this.lbl_Lone_Yn.ImageList = this.img_Label;
            this.lbl_Lone_Yn.Location = new System.Drawing.Point(7, 167);
            this.lbl_Lone_Yn.Name = "lbl_Lone_Yn";
            this.lbl_Lone_Yn.Size = new System.Drawing.Size(100, 21);
            this.lbl_Lone_Yn.TabIndex = 600;
            this.lbl_Lone_Yn.Text = "장기/단기 자재";
            this.lbl_Lone_Yn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Lone_Yn.Visible = false;
            // 
            // cmb_In_Wh_Cd
            // 
            this.cmb_In_Wh_Cd.AddItemCols = 0;
            this.cmb_In_Wh_Cd.AddItemSeparator = ';';
            this.cmb_In_Wh_Cd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_In_Wh_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_In_Wh_Cd.Caption = "";
            this.cmb_In_Wh_Cd.CaptionHeight = 17;
            this.cmb_In_Wh_Cd.CaptionStyle = style609;
            this.cmb_In_Wh_Cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_In_Wh_Cd.ColumnCaptionHeight = 18;
            this.cmb_In_Wh_Cd.ColumnFooterHeight = 18;
            this.cmb_In_Wh_Cd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_In_Wh_Cd.ContentHeight = 17;
            this.cmb_In_Wh_Cd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_In_Wh_Cd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_In_Wh_Cd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_In_Wh_Cd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_In_Wh_Cd.EditorHeight = 17;
            this.cmb_In_Wh_Cd.EvenRowStyle = style610;
            this.cmb_In_Wh_Cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_In_Wh_Cd.FooterStyle = style611;
            this.cmb_In_Wh_Cd.GapHeight = 2;
            this.cmb_In_Wh_Cd.HeadingStyle = style612;
            this.cmb_In_Wh_Cd.HighLightRowStyle = style613;
            this.cmb_In_Wh_Cd.ItemHeight = 15;
            this.cmb_In_Wh_Cd.Location = new System.Drawing.Point(108, 123);
            this.cmb_In_Wh_Cd.MatchEntryTimeout = ((long)(2000));
            this.cmb_In_Wh_Cd.MaxDropDownItems = ((short)(5));
            this.cmb_In_Wh_Cd.MaxLength = 32767;
            this.cmb_In_Wh_Cd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_In_Wh_Cd.Name = "cmb_In_Wh_Cd";
            this.cmb_In_Wh_Cd.OddRowStyle = style614;
            this.cmb_In_Wh_Cd.PartialRightColumn = false;
            this.cmb_In_Wh_Cd.PropBag = resources.GetString("cmb_In_Wh_Cd.PropBag");
            this.cmb_In_Wh_Cd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_In_Wh_Cd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_In_Wh_Cd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_In_Wh_Cd.SelectedStyle = style615;
            this.cmb_In_Wh_Cd.Size = new System.Drawing.Size(210, 21);
            this.cmb_In_Wh_Cd.Style = style616;
            this.cmb_In_Wh_Cd.TabIndex = 41;
            // 
            // cmb_Out_Wh_Cd
            // 
            this.cmb_Out_Wh_Cd.AddItemCols = 0;
            this.cmb_Out_Wh_Cd.AddItemSeparator = ';';
            this.cmb_Out_Wh_Cd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Out_Wh_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Out_Wh_Cd.Caption = "";
            this.cmb_Out_Wh_Cd.CaptionHeight = 17;
            this.cmb_Out_Wh_Cd.CaptionStyle = style617;
            this.cmb_Out_Wh_Cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Out_Wh_Cd.ColumnCaptionHeight = 18;
            this.cmb_Out_Wh_Cd.ColumnFooterHeight = 18;
            this.cmb_Out_Wh_Cd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Out_Wh_Cd.ContentHeight = 17;
            this.cmb_Out_Wh_Cd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Out_Wh_Cd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Out_Wh_Cd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Out_Wh_Cd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Out_Wh_Cd.EditorHeight = 17;
            this.cmb_Out_Wh_Cd.EvenRowStyle = style618;
            this.cmb_Out_Wh_Cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Out_Wh_Cd.FooterStyle = style619;
            this.cmb_Out_Wh_Cd.GapHeight = 2;
            this.cmb_Out_Wh_Cd.HeadingStyle = style620;
            this.cmb_Out_Wh_Cd.HighLightRowStyle = style621;
            this.cmb_Out_Wh_Cd.ItemHeight = 15;
            this.cmb_Out_Wh_Cd.Location = new System.Drawing.Point(108, 145);
            this.cmb_Out_Wh_Cd.MatchEntryTimeout = ((long)(2000));
            this.cmb_Out_Wh_Cd.MaxDropDownItems = ((short)(5));
            this.cmb_Out_Wh_Cd.MaxLength = 32767;
            this.cmb_Out_Wh_Cd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Out_Wh_Cd.Name = "cmb_Out_Wh_Cd";
            this.cmb_Out_Wh_Cd.OddRowStyle = style622;
            this.cmb_Out_Wh_Cd.PartialRightColumn = false;
            this.cmb_Out_Wh_Cd.PropBag = resources.GetString("cmb_Out_Wh_Cd.PropBag");
            this.cmb_Out_Wh_Cd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Out_Wh_Cd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Out_Wh_Cd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Out_Wh_Cd.SelectedStyle = style623;
            this.cmb_Out_Wh_Cd.Size = new System.Drawing.Size(210, 21);
            this.cmb_Out_Wh_Cd.Style = style624;
            this.cmb_Out_Wh_Cd.TabIndex = 42;
            // 
            // lbl_Out_Wh_Cd
            // 
            this.lbl_Out_Wh_Cd.ImageIndex = 0;
            this.lbl_Out_Wh_Cd.ImageList = this.img_Label;
            this.lbl_Out_Wh_Cd.Location = new System.Drawing.Point(7, 145);
            this.lbl_Out_Wh_Cd.Name = "lbl_Out_Wh_Cd";
            this.lbl_Out_Wh_Cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Out_Wh_Cd.TabIndex = 573;
            this.lbl_Out_Wh_Cd.Text = "출고창고";
            this.lbl_Out_Wh_Cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_In_Wh_Cd
            // 
            this.lbl_In_Wh_Cd.ImageIndex = 0;
            this.lbl_In_Wh_Cd.ImageList = this.img_Label;
            this.lbl_In_Wh_Cd.Location = new System.Drawing.Point(7, 123);
            this.lbl_In_Wh_Cd.Name = "lbl_In_Wh_Cd";
            this.lbl_In_Wh_Cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_In_Wh_Cd.TabIndex = 572;
            this.lbl_In_Wh_Cd.Text = "입고창고";
            this.lbl_In_Wh_Cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_Dim
            // 
            this.tab_Dim.BackColor = System.Drawing.SystemColors.Window;
            this.tab_Dim.Controls.Add(this.gbox_Dim2);
            this.tab_Dim.Controls.Add(this.gbox_Dim1);
            this.tab_Dim.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Dim.Location = new System.Drawing.Point(4, 25);
            this.tab_Dim.Name = "tab_Dim";
            this.tab_Dim.Size = new System.Drawing.Size(192, 71);
            this.tab_Dim.TabIndex = 1;
            this.tab_Dim.Text = "Dimension";
            this.tab_Dim.ToolTipText = "Dimension";
            this.tab_Dim.Visible = false;
            // 
            // gbox_Dim2
            // 
            this.gbox_Dim2.Controls.Add(this.txt_Net_Weight);
            this.gbox_Dim2.Controls.Add(this.lbl_Net_Weight);
            this.gbox_Dim2.Controls.Add(this.txt_Height);
            this.gbox_Dim2.Controls.Add(this.txt_Width);
            this.gbox_Dim2.Controls.Add(this.lbl_Cbm);
            this.gbox_Dim2.Controls.Add(this.txt_Length);
            this.gbox_Dim2.Controls.Add(this.txt_Volume);
            this.gbox_Dim2.Controls.Add(this.txt_Gross_Weight);
            this.gbox_Dim2.Controls.Add(this.lbl_Height);
            this.gbox_Dim2.Controls.Add(this.lbl_Width);
            this.gbox_Dim2.Controls.Add(this.lbl_Length);
            this.gbox_Dim2.Controls.Add(this.lbl_Volume);
            this.gbox_Dim2.Controls.Add(this.lbl_Gross_Weight);
            this.gbox_Dim2.Controls.Add(this.txt_cbm);
            this.gbox_Dim2.Location = new System.Drawing.Point(340, 5);
            this.gbox_Dim2.Name = "gbox_Dim2";
            this.gbox_Dim2.Size = new System.Drawing.Size(327, 340);
            this.gbox_Dim2.TabIndex = 1;
            this.gbox_Dim2.TabStop = false;
            // 
            // txt_Net_Weight
            // 
            this.txt_Net_Weight.BackColor = System.Drawing.Color.White;
            this.txt_Net_Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Net_Weight.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Net_Weight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Net_Weight.Location = new System.Drawing.Point(108, 35);
            this.txt_Net_Weight.MaxLength = 100;
            this.txt_Net_Weight.Name = "txt_Net_Weight";
            this.txt_Net_Weight.Size = new System.Drawing.Size(210, 21);
            this.txt_Net_Weight.TabIndex = 51;
            // 
            // lbl_Net_Weight
            // 
            this.lbl_Net_Weight.ImageIndex = 0;
            this.lbl_Net_Weight.ImageList = this.img_Label;
            this.lbl_Net_Weight.Location = new System.Drawing.Point(7, 35);
            this.lbl_Net_Weight.Name = "lbl_Net_Weight";
            this.lbl_Net_Weight.Size = new System.Drawing.Size(100, 21);
            this.lbl_Net_Weight.TabIndex = 624;
            this.lbl_Net_Weight.Text = "중량(Net)";
            this.lbl_Net_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Height
            // 
            this.txt_Height.BackColor = System.Drawing.Color.White;
            this.txt_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Height.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Height.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Height.Location = new System.Drawing.Point(108, 145);
            this.txt_Height.MaxLength = 100;
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(210, 21);
            this.txt_Height.TabIndex = 56;
            // 
            // txt_Width
            // 
            this.txt_Width.BackColor = System.Drawing.Color.White;
            this.txt_Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Width.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Width.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Width.Location = new System.Drawing.Point(108, 123);
            this.txt_Width.MaxLength = 100;
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(210, 21);
            this.txt_Width.TabIndex = 55;
            // 
            // lbl_Cbm
            // 
            this.lbl_Cbm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Cbm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cbm.ImageIndex = 0;
            this.lbl_Cbm.ImageList = this.img_Label;
            this.lbl_Cbm.Location = new System.Drawing.Point(7, 13);
            this.lbl_Cbm.Name = "lbl_Cbm";
            this.lbl_Cbm.Size = new System.Drawing.Size(100, 21);
            this.lbl_Cbm.TabIndex = 620;
            this.lbl_Cbm.Text = "CBM";
            this.lbl_Cbm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Length
            // 
            this.txt_Length.BackColor = System.Drawing.Color.White;
            this.txt_Length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Length.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Length.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Length.Location = new System.Drawing.Point(108, 79);
            this.txt_Length.MaxLength = 100;
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.Size = new System.Drawing.Size(210, 21);
            this.txt_Length.TabIndex = 53;
            // 
            // txt_Volume
            // 
            this.txt_Volume.BackColor = System.Drawing.Color.White;
            this.txt_Volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Volume.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Volume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Volume.Location = new System.Drawing.Point(108, 101);
            this.txt_Volume.MaxLength = 100;
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(210, 21);
            this.txt_Volume.TabIndex = 54;
            // 
            // txt_Gross_Weight
            // 
            this.txt_Gross_Weight.BackColor = System.Drawing.Color.White;
            this.txt_Gross_Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Gross_Weight.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Gross_Weight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Gross_Weight.Location = new System.Drawing.Point(108, 57);
            this.txt_Gross_Weight.MaxLength = 100;
            this.txt_Gross_Weight.Name = "txt_Gross_Weight";
            this.txt_Gross_Weight.Size = new System.Drawing.Size(210, 21);
            this.txt_Gross_Weight.TabIndex = 52;
            // 
            // lbl_Height
            // 
            this.lbl_Height.ImageIndex = 0;
            this.lbl_Height.ImageList = this.img_Label;
            this.lbl_Height.Location = new System.Drawing.Point(7, 145);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(100, 21);
            this.lbl_Height.TabIndex = 605;
            this.lbl_Height.Text = "높이";
            this.lbl_Height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Width
            // 
            this.lbl_Width.ImageIndex = 0;
            this.lbl_Width.ImageList = this.img_Label;
            this.lbl_Width.Location = new System.Drawing.Point(7, 123);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(100, 21);
            this.lbl_Width.TabIndex = 604;
            this.lbl_Width.Text = "폭";
            this.lbl_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Length
            // 
            this.lbl_Length.ImageIndex = 0;
            this.lbl_Length.ImageList = this.img_Label;
            this.lbl_Length.Location = new System.Drawing.Point(7, 79);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(100, 21);
            this.lbl_Length.TabIndex = 603;
            this.lbl_Length.Text = "길이";
            this.lbl_Length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.ImageIndex = 0;
            this.lbl_Volume.ImageList = this.img_Label;
            this.lbl_Volume.Location = new System.Drawing.Point(7, 101);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(100, 21);
            this.lbl_Volume.TabIndex = 602;
            this.lbl_Volume.Text = "부피";
            this.lbl_Volume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Gross_Weight
            // 
            this.lbl_Gross_Weight.ImageIndex = 0;
            this.lbl_Gross_Weight.ImageList = this.img_Label;
            this.lbl_Gross_Weight.Location = new System.Drawing.Point(7, 57);
            this.lbl_Gross_Weight.Name = "lbl_Gross_Weight";
            this.lbl_Gross_Weight.Size = new System.Drawing.Size(100, 21);
            this.lbl_Gross_Weight.TabIndex = 601;
            this.lbl_Gross_Weight.Text = "중량(Gross)";
            this.lbl_Gross_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cbm
            // 
            this.txt_cbm.BackColor = System.Drawing.Color.White;
            this.txt_cbm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cbm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_cbm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_cbm.Location = new System.Drawing.Point(108, 13);
            this.txt_cbm.MaxLength = 100;
            this.txt_cbm.Name = "txt_cbm";
            this.txt_cbm.Size = new System.Drawing.Size(210, 21);
            this.txt_cbm.TabIndex = 626;
            // 
            // gbox_Dim1
            // 
            this.gbox_Dim1.Controls.Add(this.txt_Prod_In_Lot);
            this.gbox_Dim1.Controls.Add(this.txt_Pur_Lot_Amt);
            this.gbox_Dim1.Controls.Add(this.txt_Mcs_No);
            this.gbox_Dim1.Controls.Add(this.lbl_Mcs_No);
            this.gbox_Dim1.Controls.Add(this.lbl_Pur_Lot_Amt);
            this.gbox_Dim1.Controls.Add(this.txt_Hs_No);
            this.gbox_Dim1.Controls.Add(this.lbl_Hs_No);
            this.gbox_Dim1.Controls.Add(this.lbl_Prod_In_Lot);
            this.gbox_Dim1.Location = new System.Drawing.Point(7, 5);
            this.gbox_Dim1.Name = "gbox_Dim1";
            this.gbox_Dim1.Size = new System.Drawing.Size(327, 340);
            this.gbox_Dim1.TabIndex = 0;
            this.gbox_Dim1.TabStop = false;
            // 
            // txt_Prod_In_Lot
            // 
            this.txt_Prod_In_Lot.BackColor = System.Drawing.Color.White;
            this.txt_Prod_In_Lot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Prod_In_Lot.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Prod_In_Lot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Prod_In_Lot.Location = new System.Drawing.Point(108, 35);
            this.txt_Prod_In_Lot.MaxLength = 100;
            this.txt_Prod_In_Lot.Name = "txt_Prod_In_Lot";
            this.txt_Prod_In_Lot.Size = new System.Drawing.Size(210, 21);
            this.txt_Prod_In_Lot.TabIndex = 625;
            // 
            // txt_Pur_Lot_Amt
            // 
            this.txt_Pur_Lot_Amt.BackColor = System.Drawing.Color.White;
            this.txt_Pur_Lot_Amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pur_Lot_Amt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Pur_Lot_Amt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Pur_Lot_Amt.Location = new System.Drawing.Point(108, 13);
            this.txt_Pur_Lot_Amt.MaxLength = 100;
            this.txt_Pur_Lot_Amt.Name = "txt_Pur_Lot_Amt";
            this.txt_Pur_Lot_Amt.Size = new System.Drawing.Size(210, 21);
            this.txt_Pur_Lot_Amt.TabIndex = 624;
            // 
            // txt_Mcs_No
            // 
            this.txt_Mcs_No.BackColor = System.Drawing.Color.White;
            this.txt_Mcs_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mcs_No.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Mcs_No.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Mcs_No.Location = new System.Drawing.Point(108, 57);
            this.txt_Mcs_No.MaxLength = 20;
            this.txt_Mcs_No.Name = "txt_Mcs_No";
            this.txt_Mcs_No.Size = new System.Drawing.Size(210, 21);
            this.txt_Mcs_No.TabIndex = 48;
            this.txt_Mcs_No.Tag = "Y";
            // 
            // lbl_Mcs_No
            // 
            this.lbl_Mcs_No.ImageIndex = 0;
            this.lbl_Mcs_No.ImageList = this.img_Label;
            this.lbl_Mcs_No.Location = new System.Drawing.Point(7, 57);
            this.lbl_Mcs_No.Name = "lbl_Mcs_No";
            this.lbl_Mcs_No.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mcs_No.TabIndex = 623;
            this.lbl_Mcs_No.Text = "MCS 번호";
            this.lbl_Mcs_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Pur_Lot_Amt
            // 
            this.lbl_Pur_Lot_Amt.ImageIndex = 0;
            this.lbl_Pur_Lot_Amt.ImageList = this.img_Label;
            this.lbl_Pur_Lot_Amt.Location = new System.Drawing.Point(7, 13);
            this.lbl_Pur_Lot_Amt.Name = "lbl_Pur_Lot_Amt";
            this.lbl_Pur_Lot_Amt.Size = new System.Drawing.Size(100, 21);
            this.lbl_Pur_Lot_Amt.TabIndex = 617;
            this.lbl_Pur_Lot_Amt.Text = "발주LOT";
            this.lbl_Pur_Lot_Amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Hs_No
            // 
            this.txt_Hs_No.BackColor = System.Drawing.Color.White;
            this.txt_Hs_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Hs_No.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Hs_No.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Hs_No.Location = new System.Drawing.Point(108, 79);
            this.txt_Hs_No.MaxLength = 20;
            this.txt_Hs_No.Name = "txt_Hs_No";
            this.txt_Hs_No.Size = new System.Drawing.Size(210, 21);
            this.txt_Hs_No.TabIndex = 49;
            this.txt_Hs_No.Tag = "Y";
            // 
            // lbl_Hs_No
            // 
            this.lbl_Hs_No.ImageIndex = 0;
            this.lbl_Hs_No.ImageList = this.img_Label;
            this.lbl_Hs_No.Location = new System.Drawing.Point(7, 79);
            this.lbl_Hs_No.Name = "lbl_Hs_No";
            this.lbl_Hs_No.Size = new System.Drawing.Size(100, 21);
            this.lbl_Hs_No.TabIndex = 613;
            this.lbl_Hs_No.Text = "HS_NO";
            this.lbl_Hs_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Prod_In_Lot
            // 
            this.lbl_Prod_In_Lot.ImageIndex = 0;
            this.lbl_Prod_In_Lot.ImageList = this.img_Label;
            this.lbl_Prod_In_Lot.Location = new System.Drawing.Point(7, 35);
            this.lbl_Prod_In_Lot.Name = "lbl_Prod_In_Lot";
            this.lbl_Prod_In_Lot.Size = new System.Drawing.Size(100, 21);
            this.lbl_Prod_In_Lot.TabIndex = 611;
            this.lbl_Prod_In_Lot.Text = "생산불출LOT";
            this.lbl_Prod_In_Lot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_Catalog
            // 
            this.tab_Catalog.BackColor = System.Drawing.SystemColors.Window;
            this.tab_Catalog.Controls.Add(this.sgrid_Image);
            this.tab_Catalog.Controls.Add(this.groupBox11);
            this.tab_Catalog.Controls.Add(this.picb_item);
            this.tab_Catalog.Location = new System.Drawing.Point(4, 25);
            this.tab_Catalog.Name = "tab_Catalog";
            this.tab_Catalog.Size = new System.Drawing.Size(192, 71);
            this.tab_Catalog.TabIndex = 5;
            this.tab_Catalog.Text = "e-Catalog";
            this.tab_Catalog.ToolTipText = "e-Catalog";
            this.tab_Catalog.Visible = false;
            // 
            // sgrid_Image
            // 
            this.sgrid_Image.Location = new System.Drawing.Point(392, 48);
            this.sgrid_Image.Name = "sgrid_Image";
            this.sgrid_Image.Sheets.Add(this.sgrid_Image_Sheet1);
            this.sgrid_Image.Size = new System.Drawing.Size(280, 288);
            this.sgrid_Image.TabIndex = 585;
            this.sgrid_Image.EditModeOn += new System.EventHandler(this.sgrid_Image_EditModeOn);
            this.sgrid_Image.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.sgrid_Image_EditChange);
            this.sgrid_Image.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.sgrid_Image_ButtonClicked);
            this.sgrid_Image.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.sgrid_Image_CellDoubleClick);
            // 
            // sgrid_Image_Sheet1
            // 
            this.sgrid_Image_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txt_image_name);
            this.groupBox11.Controls.Add(this.btn_FileOpen);
            this.groupBox11.Controls.Add(this.lbl_image_name);
            this.groupBox11.Controls.Add(this.btn_Save_Image);
            this.groupBox11.Controls.Add(this.btn_Search_Image);
            this.groupBox11.Location = new System.Drawing.Point(7, 5);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(665, 40);
            this.groupBox11.TabIndex = 584;
            this.groupBox11.TabStop = false;
            // 
            // txt_image_name
            // 
            this.txt_image_name.BackColor = System.Drawing.Color.White;
            this.txt_image_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_image_name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_image_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_image_name.Location = new System.Drawing.Point(108, 14);
            this.txt_image_name.MaxLength = 100;
            this.txt_image_name.Name = "txt_image_name";
            this.txt_image_name.Size = new System.Drawing.Size(268, 21);
            this.txt_image_name.TabIndex = 586;
            // 
            // btn_FileOpen
            // 
            this.btn_FileOpen.ImageIndex = 19;
            this.btn_FileOpen.ImageList = this.img_SmallButton;
            this.btn_FileOpen.Location = new System.Drawing.Point(377, 13);
            this.btn_FileOpen.Name = "btn_FileOpen";
            this.btn_FileOpen.Size = new System.Drawing.Size(21, 21);
            this.btn_FileOpen.TabIndex = 583;
            this.btn_FileOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_FileOpen.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_FileOpen.Click += new System.EventHandler(this.btn_FileOpen_Click);
            this.btn_FileOpen.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // lbl_image_name
            // 
            this.lbl_image_name.ImageIndex = 0;
            this.lbl_image_name.ImageList = this.img_Label;
            this.lbl_image_name.Location = new System.Drawing.Point(7, 13);
            this.lbl_image_name.Name = "lbl_image_name";
            this.lbl_image_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_image_name.TabIndex = 580;
            this.lbl_image_name.Text = "Name";
            this.lbl_image_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Save_Image
            // 
            this.btn_Save_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Save_Image.ImageIndex = 11;
            this.btn_Save_Image.ImageList = this.image_List;
            this.btn_Save_Image.Location = new System.Drawing.Point(580, 11);
            this.btn_Save_Image.Name = "btn_Save_Image";
            this.btn_Save_Image.Size = new System.Drawing.Size(80, 23);
            this.btn_Save_Image.TabIndex = 587;
            this.btn_Save_Image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save_Image.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Save_Image.Click += new System.EventHandler(this.btn_Save_Image_Click);
            this.btn_Save_Image.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn_Search_Image
            // 
            this.btn_Search_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Search_Image.ImageIndex = 13;
            this.btn_Search_Image.ImageList = this.image_List;
            this.btn_Search_Image.Location = new System.Drawing.Point(499, 11);
            this.btn_Search_Image.Name = "btn_Search_Image";
            this.btn_Search_Image.Size = new System.Drawing.Size(80, 23);
            this.btn_Search_Image.TabIndex = 586;
            this.btn_Search_Image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search_Image.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Search_Image.Click += new System.EventHandler(this.btn_Search_Image_Click);
            this.btn_Search_Image.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // picb_item
            // 
            this.picb_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_item.Location = new System.Drawing.Point(7, 48);
            this.picb_item.Name = "picb_item";
            this.picb_item.Size = new System.Drawing.Size(377, 288);
            this.picb_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_item.TabIndex = 0;
            this.picb_item.TabStop = false;
            this.picb_item.Tag = "";
            // 
            // tab_MachineInfor
            // 
            this.tab_MachineInfor.Location = new System.Drawing.Point(4, 25);
            this.tab_MachineInfor.Name = "tab_MachineInfor";
            this.tab_MachineInfor.Size = new System.Drawing.Size(192, 71);
            this.tab_MachineInfor.TabIndex = 6;
            this.tab_MachineInfor.Text = "Machine Information";
            this.tab_MachineInfor.ToolTipText = "Machine Information";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Owner = this;
            // 
            // oFileDlg
            // 
            this.oFileDlg.AddExtension = false;
            this.oFileDlg.Title = "MDI Sample";
            // 
            // Pop_Item_Show
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 467);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_Item_Show";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tab_Item.ResumeLayout(false);
            this.tab_General.ResumeLayout(false);
            this.gbox_General2.ResumeLayout(false);
            this.gbox_General2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Spec_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mng_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Use_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Size_YN)).EndInit();
            this.gbox_General1.ResumeLayout(false);
            this.gbox_General1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_trade_group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_L)).EndInit();
            this.tab_Unit.ResumeLayout(false);
            this.gbox_Unit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Processing_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cbd_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pur_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Processing_Currency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Processing_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cbd_Currency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Pur_Currency)).EndInit();
            this.gbox_Unit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pk_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Item_Conv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Stock_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Buy_Div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style_Item_Div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Abc_Div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Insp_YN)).EndInit();
            this.tab_Roul.ResumeLayout(false);
            this.gbox_Role2.ResumeLayout(false);
            this.gbox_Role2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dl_Days_JJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Import_JJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_JJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_JJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cus_Cd_JJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dl_Days_VJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Import_VJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_VJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_VJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cus_Cd_VJ)).EndInit();
            this.gbox_Role1.ResumeLayout(false);
            this.gbox_Role1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dl_Days_QD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_QD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cus_Cd_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Import_QD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Import_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dl_Days_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Acc_Div_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_QD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cus_Cd_QD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cost_YN)).EndInit();
            this.tab_MRP.ResumeLayout(false);
            this.gbox_MRP2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Safe_Amt_JJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Out_Loss_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ship_Loss_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pur_Loss_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Safe_Amt_QD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Safe_Amt_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Safe_Amt_VJ)).EndInit();
            this.gbox_MRP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Life_Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Life_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Lone_YN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_In_Wh_Cd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Out_Wh_Cd)).EndInit();
            this.tab_Dim.ResumeLayout(false);
            this.gbox_Dim2.ResumeLayout(false);
            this.gbox_Dim2.PerformLayout();
            this.gbox_Dim1.ResumeLayout(false);
            this.gbox_Dim1.PerformLayout();
            this.tab_Catalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sgrid_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgrid_Image_Sheet1)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new ClassLib.ComFunction();
 
		private string _Group_CD = "", _Group_Name = "";  



		//SRF Group Type : 그룹 재구성 할 수 있게 하기 위함
		private string _GroupTypeSRF = "07";



		// 저장 후 종료시에만 메인 폼 데이터 조회되도록 하기 위함
		public bool _Close_Save = false;

		protected DataTable _dataSource;
		protected CurrencyManager _cm;
 
		#endregion  

		#region 멤버 메서드



		private DataTable _DT_ItemData = new DataTable();



		/// <summary>
		/// Init_Form : 
		/// </summary>
		public void Init_Form()
		{
			try
			{
				//Title
				this.Text = "Item Master";
				lbl_MainTitle.Text = "Item Master"; 
				ClassLib.ComFunction.SetLangDic(this);

				// 그리드 설정  
				sgrid_Image.Set_Spread_Comm("SBC_ITEM_IMAGE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);


                if (_ReturnYN)
                {
                    _Division = ClassLib.ComVar.Parameter_PopUp[0];
                    _ItemCD = ClassLib.ComVar.Parameter_PopUp[1];
                    _Group_Type = ClassLib.ComVar.Parameter_PopUp[2];
                    _Group_L = ClassLib.ComVar.Parameter_PopUp[3];
                }

				txt_Item_CD.Text = _ItemCD;


				//그룹타입 콤보쿼리
				DataTable dt_ret;
				dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
				ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_Group_Type, 0, 1, false, 40, 130);  
				dt_ret.Dispose();

				DataTable ds_ret = Select_SBC_ITEM_POP(_ItemCD);
				_DT_ItemData = ds_ret;
				ds_ret.Dispose();



				//-----------------------------------------------------------
				// 처음 선택되었을 경우에만 콤보 데이터 리스트 세팅하기 위함
				// 선택되어졌을 경우 tag 값 "Y" 로 변경
				//-----------------------------------------------------------
				tab_General.Tag = "N";
				tab_Unit.Tag = "N";
				tab_Roul.Tag = "N";
				tab_MRP.Tag = "N"; 
				tab_Dim.Tag = "N"; 
				//-----------------------------------------------------------



				tab_Item.SelectedTab = tab_General;
				InitControl_tab_General(_DT_ItemData);
				InitControl_tab_Unit(_DT_ItemData);
				InitControl_tab_Roul(_DT_ItemData);
				InitControl_tab_MRP(_DT_ItemData);
				InitControl_tab_Dim(_DT_ItemData);
				InitControl_tab_eCatalog();
 
 
				btn_SearchGroup.Enabled = true;
				btn_AddGroup.Enabled = true;


				// 해외의 경우 관련 컨트롤만 사용 가능
				if (!COM.ComVar.This_Factory.Equals(COM.ComVar.DSFactory))
				{
					LockControl();
					btn_Save.Enabled = true;
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#region Tab Page 별로 콤보 데이타 쿼리

		private void InitControl_tab_General(DataTable arg_dt)
		{

			if(tab_General.Tag.ToString() == "Y") return;


			DataTable dt;

			//관리단위
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxPurUnit); //"SBC02");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Mng_Unit, 1, 2, false, 50, 100);

			//Spec단위
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSpecDiv); //"SBCS1");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Spec_Type, 1, 2, false, 0, 100);

			//Trade Group (Sole Materials)
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxTradeGroup); //"SBC19");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_trade_group, 1, 2, false, 0, 100);
			cmb_trade_group.SelectedValue = "Z";  // NONE


			//사이즈자재여부
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxUseYN);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Size_YN, 1, 2, false, 0, 100); 

			//사용유무
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxUseYN);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Use_YN, 1, 2, false, 0, 100); 
			dt.Dispose();



			if(_Division == "U" && arg_dt.Rows.Count != 0) 
			{


                txt_Group_CD.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxGROUP_CD].ToString();
                txt_Item_Name1.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME1].ToString();
                txt_Item_Name2.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME2].ToString();
                txt_Item_Name3.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME3].ToString();
                txt_Item_Name4.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME4].ToString();
                txt_Item_Name5.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME5].ToString();
                cmb_Size_YN.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSIZE_YN].ToString();
                cmb_Use_YN.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxUSE_YN].ToString();
                txt_Rep_Item_CD.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxREP_ITEM_CD].ToString();
                txt_Copy_From_CD.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCOPY_FROM].ToString();
                txt_ReMark.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxREMARK].ToString();
                cmb_Reg_Ymd.Text = Convert.ToDateTime(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxREG_YMD].ToString()).ToString();
                cmb_Mng_Unit.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMNG_UNIT].ToString();
                cmb_Spec_Type.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSPEC_TYPE].ToString();

                cmb_trade_group.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCHILD_ITEM_CD].ToString();

			}



			tab_General.Tag = "Y";


		}

		private void InitControl_tab_Unit(DataTable arg_dt)
		{


			if(tab_Unit.Tag.ToString() == "Y") return;


			DataTable dt;

			
			//스타일자재분류
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxMRPItemDivision); //.CxUBDiv); //"SBC04");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Style_Item_Div, 1, 2, false, 0, 100);

			//구매분류
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxPurDiv); //"SBC01");
			//ClassLib.ComCtl.Set_ComboList(dt,cmb_Buy_Div, 1, 2, false, 0, 100);
			ClassLib.ComCtl.Set_ComboList_3(dt, cmb_Buy_Div, 1, 2, 3);

			//재고단위
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxPurUnit); //"SBC02");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Stock_Unit, 1, 2, false, 0, 100);
			
			//ABC분류
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxABCDiv); //"SBC05");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Abc_Div, 1, 2, false, 0, 100);

			//검사여부
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxUseYN); //"SBC00");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Insp_YN, 1, 2, false, 0, 100);

			//구매화폐단위
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxMonetaryUnit); //"SBC06");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Pur_Currency, 1, 2, false, 0, 100);

			//CBD화폐단위
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxMonetaryUnit); //"SBC06");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Cbd_Currency, 1, 2, false, 0, 100);

			//임가공여부
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxUseYN); //"SBC00");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Processing_YN, 1, 2, false, 0, 100);

			//임가공 화폐단위
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxMonetaryUnit); //"SBC06");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Processing_Currency, 1, 2, false, 0, 100);

			dt.Dispose();


			if(_Division == "U" && arg_dt.Rows.Count != 0) 
			{

				txt_Pk_Qty.Value						= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPK_QTY].ToString(); 
				cmb_Style_Item_Div.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSTYLE_ITEM_DIV].ToString();
				cmb_Buy_Div.SelectedValue				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxBUY_DIV].ToString();
				cmb_Stock_Unit.SelectedText				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSTOCK_UNIT].ToString();
				txt_Item_Conv.Value						= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_CONV].ToString();
				cmb_Abc_Div.SelectedValue				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxABC_DIV].ToString();
				cmb_Insp_YN.SelectedValue				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxINSP_YN].ToString();
				txt_Pur_Price.Value						= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPUR_PRICE].ToString();
				cmb_Pur_Currency.SelectedValue			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPUR_CURRENCY].ToString();
				txt_Cbd_Price.Value						= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCBD_PRICE].ToString();
				cmb_Cbd_Currency.SelectedValue			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCBD_CURRENCY].ToString();
				cmb_Processing_YN.SelectedValue			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPROCESSING_YN].ToString();
				txt_Processing_Price.Value				= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPROCESSING_PRICE].ToString();
                cmb_Processing_Currency.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPROCESSING_CURRENCY].ToString();
			


			}


			tab_Unit.Tag = "Y";

		}

		private void InitControl_tab_Roul(DataTable arg_dt)
		{

			if(tab_Roul.Tag.ToString() == "Y") return;


			DataTable dt;
 
			//수입자재여부
            dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxLocalLLTDivision); //"SBP13");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Import_DS, 1 ,2, false, 0, 200);
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Import_QD, 1 ,2, false, 0, 200);
            ClassLib.ComCtl.Set_ComboList(dt, cmb_Import_VJ, 1, 2, false, 0, 200);
            ClassLib.ComCtl.Set_ComboList(dt, cmb_Import_JJ, 1, 2, false, 0, 200);

			//원가관리여부
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxUseYN); //"SBC00");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Cost_YN, 1, 2, false, 0, 200);

			//회계분류여부
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxUseYN); //"SBC00");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Acc_Div_YN, 1, 2, false, 0, 200);

			//회계분류
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxAccountDiv); //"SBC07");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Acc_Div_DS, 1, 2, false, 0, 200);
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Acc_Div_QD, 1 ,2, false, 0, 200);
            ClassLib.ComCtl.Set_ComboList(dt, cmb_Acc_Div_VJ, 1, 2, false, 0, 200);
            ClassLib.ComCtl.Set_ComboList(dt, cmb_Acc_Div_JJ, 1, 2, false, 0, 200);

			dt.Dispose();



			if(_Division == "U" && arg_dt.Rows.Count != 0) 
			{

				// 거래처 --------------------------------------------------------------------------
				txt_Cus_Cd_DS.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_DS].ToString();
				txt_Cus_Cd_QD.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_QD].ToString();
				txt_Cus_Cd_VJ.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_VJ].ToString();
                txt_Cus_Cd_JJ.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_JJ].ToString();
			
				//거래처 콤보 세팅
				Set_Cust_User_Combo(txt_Cus_Cd_DS);
				Set_Cust_User_Combo(txt_Cus_Cd_QD);
				Set_Cust_User_Combo(txt_Cus_Cd_VJ);

                cmb_Cus_Cd_DS.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_DS].ToString();
                cmb_Cus_Cd_QD.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_QD].ToString();
                cmb_Cus_Cd_VJ.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_VJ].ToString();
                cmb_Cus_Cd_JJ.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_JJ].ToString();

				// 담당자 --------------------------------------------------------------------------
				txt_Man_Charge_DS.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_DS].ToString();
				txt_Man_Charge_QD.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_QD].ToString();
				txt_Man_Charge_VJ.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_VJ].ToString();
                txt_Man_Charge_JJ.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_JJ].ToString(); 

				//담당자 콤보 세팅
				Set_Cust_User_Combo(txt_Man_Charge_DS);
				Set_Cust_User_Combo(txt_Man_Charge_QD);
				Set_Cust_User_Combo(txt_Man_Charge_VJ);
                Set_Cust_User_Combo(txt_Man_Charge_JJ);

                cmb_Man_Charge_DS.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_DS].ToString();
                cmb_Man_Charge_QD.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_QD].ToString();
                cmb_Man_Charge_VJ.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_VJ].ToString();
                cmb_Man_Charge_JJ.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_JJ].ToString();

				cmb_Import_DS.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIMPORT_DS].ToString();
				cmb_Import_QD.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIMPORT_QD].ToString();
				cmb_Import_VJ.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIMPORT_VJ].ToString();
                cmb_Import_JJ.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIMPORT_JJ].ToString();

				cmb_Cost_YN.SelectedValue	 = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCOST_YN].ToString();
				cmb_Acc_Div_YN.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_YN].ToString();
				
                cmb_Acc_Div_DS.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_DS].ToString();
				cmb_Acc_Div_QD.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_QD].ToString();
				cmb_Acc_Div_VJ.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_VJ].ToString();  
                cmb_Acc_Div_JJ.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_JJ].ToString();  
				 
				txt_Dl_Days_DS.Value = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxDL_DAYS_DS].ToString();
				txt_Dl_Days_QD.Value = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxDL_DAYS_QD].ToString();
				txt_Dl_Days_VJ.Value = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxDL_DAYS_VJ].ToString();
                txt_Dl_Days_JJ.Value = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxDL_DAYS_JJ].ToString();
				
				 				


			}


			tab_Roul.Tag = "Y";


		}

		private void InitControl_tab_MRP(DataTable arg_dt)
		{

			if(tab_MRP.Tag.ToString() == "Y") return;



			DataTable dt;

			//장기,단기구분
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxUseYN); // .CxDeliveryDiv); //"SBC08");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Lone_YN, 1, 2, false, 0, 200);

			//악성재고 유무
			dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxUseYN); //"SBC00");
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Life_YN, 1, 2, false, 0, 200);

			//입고창고
			dt = Select_WareHouse();
			ClassLib.ComCtl.Set_ComboList(dt,cmb_In_Wh_Cd, 0, 1, false, 0, 200);

			//출고창고
			dt = Select_WareHouse();
			ClassLib.ComCtl.Set_ComboList(dt,cmb_Out_Wh_Cd, 0, 1, false, 0, 200);

			dt.Dispose();


			if(_Division == "U" && arg_dt.Rows.Count != 0) 
			{
                cmb_Lone_YN.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxLONE_YN].ToString();
				
				txt_Safe_Amt_DS.Value = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSAFE_AMT_DS].ToString();
				txt_Safe_Amt_QD.Value = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSAFE_AMT_QD].ToString();
				txt_Safe_Amt_VJ.Value = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSAFE_AMT_VJ].ToString();
				txt_Safe_Amt_JJ.Value = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSAFE_AMT_JJ].ToString();

				cmb_Life_YN.SelectedValue	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxLIFE_YN].ToString();
				txt_Life_Day.Value			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxLIFE_DAY].ToString();
				cmb_In_Wh_Cd.SelectedValue	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIN_WH_CD].ToString();
				cmb_Out_Wh_Cd.SelectedValue	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxOUT_WH_CD].ToString();
				txt_Pur_Loss_Rate.Value		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPUR_LOSS_RATE].ToString();
				txt_Out_Loss_Rate.Value		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxOUT_LOSS_RATE].ToString();
                txt_Ship_Loss_Rate.Value = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSHIP_LOSS_RATE].ToString();
				 
			}											  


			tab_MRP.Tag = "Y";


		}

		private void InitControl_tab_Dim(DataTable arg_dt)
		{

			if(tab_Dim.Tag.ToString() == "Y") return;



			if(_Division == "U" && arg_dt.Rows.Count != 0) 
			{
				
				txt_Pur_Lot_Amt.Text	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPUR_LOT_AMT].ToString();
				txt_Prod_In_Lot.Text	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPROD_IN_LOT].ToString();
				txt_Mcs_No.Text			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMCS_NO].ToString();
				txt_Hs_No.Text			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxHS_NO].ToString();
				txt_cbm.Text			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCBM].ToString();
				txt_Gross_Weight.Text	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxGROSS_WEIGHT].ToString();
				txt_Net_Weight.Text		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxNET_WEIGHT].ToString();
				txt_Volume.Text			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxVOLUME].ToString();
				txt_Length.Text			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxLENGTH].ToString();
				txt_Width.Text			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxWIDTH].ToString();
                txt_Height.Text         = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxHEIGHT].ToString();

			}


			tab_Dim.Tag = "Y";


		}

		private void InitControl_tab_eCatalog()
		{

			if(_Division == "U") 
			{

				Select_Image();


			}


		}

		#endregion
 
		#region 콘트롤에 데이타 Setting

		private void InitConrol()
		{
			DataTable ds_ret = Select_SBC_ITEM_POP(_ItemCD);

			txt_Group_CD.Text						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxGROUP_CD].ToString();
			txt_Item_Name1.Text						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME1].ToString();
			txt_Item_Name2.Text						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME2].ToString();
			txt_Item_Name3.Text						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME3].ToString(); 
			txt_Item_Name4.Text						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME4].ToString(); 
			txt_Item_Name5.Text						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_NAME5].ToString(); 
			cmb_Size_YN.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSIZE_YN].ToString();
			cmb_Use_YN.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxUSE_YN].ToString();
            txt_Rep_Item_CD.Text                    = ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxREP_ITEM_CD].ToString();
			txt_Copy_From_CD.Text					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCOPY_FROM].ToString();
			txt_ReMark.Text							= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxREMARK].ToString();
            cmb_Reg_Ymd.Text                        = Convert.ToDateTime(ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxREG_YMD].ToString()).ToString(); 
			cmb_Mng_Unit.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMNG_UNIT].ToString();
			cmb_Spec_Type.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSPEC_TYPE].ToString();

			txt_Pk_Qty.Value						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPK_QTY].ToString(); 
			cmb_Style_Item_Div.SelectedValue		= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSTYLE_ITEM_DIV].ToString();
			cmb_Buy_Div.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxBUY_DIV].ToString();
			cmb_Stock_Unit.SelectedText				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSTOCK_UNIT].ToString();
			txt_Item_Conv.Value						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxITEM_CONV].ToString();
			cmb_Abc_Div.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxABC_DIV].ToString();
			cmb_Insp_YN.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxINSP_YN].ToString();
			txt_Pur_Price.Value						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPUR_PRICE].ToString();
			cmb_Pur_Currency.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPUR_CURRENCY].ToString();
			txt_Cbd_Price.Value						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCBD_PRICE].ToString();
			cmb_Cbd_Currency.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCBD_CURRENCY].ToString();
			cmb_Processing_YN.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPROCESSING_YN].ToString();
			txt_Processing_Price.Value				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPROCESSING_PRICE].ToString();
			cmb_Processing_Currency.SelectedValue	= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPROCESSING_CURRENCY].ToString();
			

			// 거래처 --------------------------------------------------------------------------
			txt_Cus_Cd_DS.Text                      = ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_DS].ToString();
			txt_Cus_Cd_QD.Text                      = ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_QD].ToString();
			txt_Cus_Cd_VJ.Text                      = ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_VJ].ToString();
			txt_Cus_Cd_JJ.Text                      = ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_JJ].ToString();
			
			//거래처 콤보 세팅
			Set_Cust_User_Combo(txt_Cus_Cd_DS);
			Set_Cust_User_Combo(txt_Cus_Cd_QD);
			Set_Cust_User_Combo(txt_Cus_Cd_VJ);
			Set_Cust_User_Combo(txt_Cus_Cd_JJ);

			cmb_Cus_Cd_DS.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_DS].ToString();
			cmb_Cus_Cd_QD.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_QD].ToString();
			cmb_Cus_Cd_VJ.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_VJ].ToString();
			cmb_Cus_Cd_JJ.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCUS_CD_JJ].ToString();

			// 담당자 --------------------------------------------------------------------------
			txt_Man_Charge_DS.Text                  = ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_DS].ToString();
			txt_Man_Charge_QD.Text                  = ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_QD].ToString();
			txt_Man_Charge_VJ.Text                  = ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_VJ].ToString(); 
			txt_Man_Charge_JJ.Text                  = ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_JJ].ToString(); 

			//담당자 콤보 세팅
			Set_Cust_User_Combo(txt_Man_Charge_DS);
			Set_Cust_User_Combo(txt_Man_Charge_QD);
			Set_Cust_User_Combo(txt_Man_Charge_VJ);
			Set_Cust_User_Combo(txt_Man_Charge_JJ);

			cmb_Man_Charge_DS.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_DS].ToString();
			cmb_Man_Charge_QD.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_QD].ToString();
			cmb_Man_Charge_VJ.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_VJ].ToString();
			cmb_Man_Charge_JJ.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMAN_CHARGE_JJ].ToString();

			//----------------------------------------------------------------------------------

			cmb_Import_DS.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIMPORT_DS].ToString();
			cmb_Import_QD.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIMPORT_QD].ToString();
			cmb_Import_VJ.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIMPORT_VJ].ToString();
			cmb_Import_JJ.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIMPORT_JJ].ToString();

			cmb_Cost_YN.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCOST_YN].ToString();
			cmb_Acc_Div_YN.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_YN].ToString();

			cmb_Acc_Div_DS.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_DS].ToString();
			cmb_Acc_Div_QD.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_QD].ToString();
			cmb_Acc_Div_VJ.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_VJ].ToString();
			cmb_Acc_Div_JJ.SelectedValue			= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxACC_DIV_JJ].ToString();

			cmb_Lone_YN.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxLONE_YN].ToString();

			txt_Dl_Days_DS.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxDL_DAYS_DS].ToString();
			txt_Dl_Days_QD.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxDL_DAYS_QD].ToString();
			txt_Dl_Days_VJ.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxDL_DAYS_VJ].ToString();
            txt_Dl_Days_JJ.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxDL_DAYS_JJ].ToString();
			
            txt_Safe_Amt_DS.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSAFE_AMT_DS].ToString();
			txt_Safe_Amt_QD.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSAFE_AMT_QD].ToString();
			txt_Safe_Amt_VJ.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSAFE_AMT_VJ].ToString();
			txt_Safe_Amt_JJ.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSAFE_AMT_JJ].ToString();

			cmb_Life_YN.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxLIFE_YN].ToString();
			txt_Life_Day.Value						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxLIFE_DAY].ToString();
			cmb_In_Wh_Cd.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxIN_WH_CD].ToString();
			cmb_Out_Wh_Cd.SelectedValue				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxOUT_WH_CD].ToString();

			txt_Pur_Loss_Rate.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPUR_LOSS_RATE].ToString();
			txt_Out_Loss_Rate.Value					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxOUT_LOSS_RATE].ToString();
			txt_Ship_Loss_Rate.Value				= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxSHIP_LOSS_RATE].ToString();
			txt_Pur_Lot_Amt.Text					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPUR_LOT_AMT].ToString();
			txt_Prod_In_Lot.Text					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxPROD_IN_LOT].ToString();
			txt_Mcs_No.Text							= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxMCS_NO].ToString();
			txt_Hs_No.Text							= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxHS_NO].ToString();
			txt_cbm.Text							= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxCBM].ToString();
			txt_Gross_Weight.Text					= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxGROSS_WEIGHT].ToString();
			txt_Net_Weight.Text						= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxNET_WEIGHT].ToString();
			txt_Volume.Text							= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxVOLUME].ToString();
			txt_Length.Text							= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxLENGTH].ToString();
			txt_Width.Text							= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxWIDTH].ToString();
			txt_Height.Text							= ds_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_ITEM_POP_SHOW.IxHEIGHT].ToString();

			ds_ret.Dispose();

			/*
			//그룹코드에 해당하는 그룹이름 쿼리
			if(txt_Rep_Item_CD.Text != "") 
			{
				DataTable dt_gname = ClassLib.ComFunction.Select_Group_Name(txt_Group_CD.Text);
				txt_Group_Name.Text = dt_gname.Rows[0].ItemArray[0].ToString();
				dt_gname.Dispose();
			}
			*/

			/*
			//대표품목itemcd에 해당하는 itemname 쿼리
			if(txt_Rep_Item_CD.Text != "") 
			{
				DataTable dt_itemname1 = ClassLib.ComFunction.Select_Item_Name(txt_Rep_Item_CD.Text);
				txt_Rep_Item_Name.Text = dt_itemname1.Rows[0].ItemArray[0].ToString();
				dt_itemname1.Dispose();
			}
			*/

			/*
			//복사출처itemcd에 해당하는 itemname 쿼리
			if(txt_Copy_From_CD.Text != "") 
			{
				DataTable dt_itemname2 = ClassLib.ComFunction.Select_Item_Name(txt_Copy_From_CD.Text);
				txt_Copy_From_Name.Text = dt_itemname2.Rows[0].ItemArray[0].ToString();
				dt_itemname2.Dispose();
			}
			*/


			// e-Catalog --------------------------------------------------------------------
			Select_Image();


			
		}

		#endregion

		#region 컨트롤 Locked

		private void LockControl()
		{
			for (int i = 0 ; i < tab_Item.TabPages.Count ; i++)
			{
				LockControl(tab_Item.TabPages[i]);
			}
		}

		private void LockControl(Control arg_par_ctl)
		{
			foreach (Control ctl in arg_par_ctl.Controls)
			{
				if (ctl is C1.Win.C1List.C1Combo		|| 
					ctl is C1.Win.C1Input.C1NumericEdit || 
					ctl is System.Windows.Forms.TextBox || 
					ctl is System.Windows.Forms.Label)
				{
					if (ctl.Name.ToUpper().IndexOf("_" + COM.ComVar.This_Factory) > -1)
					{
						ctl.Enabled = true;
					}
					else
					{
						ctl.Enabled = false;
					}
				}
				else if (ctl is System.Windows.Forms.GroupBox)
				{
					LockControl(ctl);
				}
				else
				{
					ctl.Enabled = false;
				}
			}
		}

		#endregion


		/// <summary>
		/// Clear_All : 
		/// </summary>
		public void Clear_All()
		{

			txt_Item_CD.Text = "";
			txt_Group_CD.Text = "";
			txt_Item_Name1.Text = "";
			txt_Item_Name2.Text = ""; 
			txt_Item_Name3.Text = "";  
			txt_Item_Name4.Text = "";  
			txt_Item_Name5.Text = "";  
			cmb_Size_YN.SelectedIndex = -1;  
			cmb_Use_YN.SelectedIndex = -1;  
			txt_Rep_Item_CD.Text = "";  
			txt_Copy_From_CD.Text	 = "";  
			txt_ReMark.Text = "";  
			cmb_Reg_Ymd.Text = "";  
			cmb_Mng_Unit.SelectedIndex = -1;  
			cmb_Spec_Type.SelectedIndex = -1;  
			cmb_Group_Type.SelectedIndex = -1;
			cmb_Group_L.SelectedIndex = -1;
			cmb_Group_M.SelectedIndex = -1;
			cmb_trade_group.SelectedValue = "Z";


			txt_Pk_Qty.Value = 0; 
			cmb_Style_Item_Div.SelectedIndex = -1;  
			cmb_Buy_Div.SelectedIndex = -1;  
			cmb_Stock_Unit.SelectedIndex = -1;  
			txt_Item_Conv.Value = 1;
			cmb_Abc_Div.SelectedIndex = -1;  
			cmb_Insp_YN.SelectedIndex = -1;  
			txt_Pur_Price.Value = 0;
			cmb_Pur_Currency.SelectedIndex = -1;  
			txt_Cbd_Price.Value = 0;
			cmb_Cbd_Currency.SelectedIndex = -1;  
			cmb_Processing_YN.SelectedIndex = -1;  
			txt_Processing_Price.Value = 0;
			cmb_Processing_Currency.SelectedIndex = -1;  


			// 거래처 --------------------------------------------------------------------------
			txt_Cus_Cd_DS.Text = "";
			txt_Cus_Cd_QD.Text = "";
            txt_Cus_Cd_VJ.Text = "";
            txt_Cus_Cd_JJ.Text = "";
			
			//거래처 콤보 세팅
			Set_Cust_User_Combo(txt_Cus_Cd_DS);
			Set_Cust_User_Combo(txt_Cus_Cd_QD);
            Set_Cust_User_Combo(txt_Cus_Cd_VJ);
            Set_Cust_User_Combo(txt_Cus_Cd_JJ);

			cmb_Cus_Cd_DS.SelectedIndex = -1;  
			cmb_Cus_Cd_QD.SelectedIndex = -1;
            cmb_Cus_Cd_VJ.SelectedIndex = -1;
            cmb_Cus_Cd_JJ.SelectedIndex = -1;  

			// 담당자 --------------------------------------------------------------------------
			txt_Man_Charge_DS.Text = "";
			txt_Man_Charge_QD.Text = "";
            txt_Man_Charge_VJ.Text = "";
            txt_Man_Charge_JJ.Text = ""; 

			//담당자 콤보 세팅
			Set_Cust_User_Combo(txt_Man_Charge_DS);
			Set_Cust_User_Combo(txt_Man_Charge_QD);
            Set_Cust_User_Combo(txt_Man_Charge_VJ);
            Set_Cust_User_Combo(txt_Man_Charge_JJ);

			cmb_Man_Charge_DS.SelectedIndex = -1;  
			cmb_Man_Charge_QD.SelectedIndex = -1;
            cmb_Man_Charge_VJ.SelectedIndex = -1;
            cmb_Man_Charge_JJ.SelectedIndex = -1;  

			//----------------------------------------------------------------------------------

			cmb_Import_DS.SelectedIndex = -1;  
			cmb_Import_QD.SelectedIndex = -1;
            cmb_Import_VJ.SelectedIndex = -1;
            cmb_Import_JJ.SelectedIndex = -1;  

			cmb_Cost_YN.SelectedIndex = -1;  
			cmb_Acc_Div_YN.SelectedIndex = -1;  

			cmb_Acc_Div_DS.SelectedIndex = -1;  
			cmb_Acc_Div_QD.SelectedIndex = -1;
            cmb_Acc_Div_VJ.SelectedIndex = -1;
            cmb_Acc_Div_JJ.SelectedIndex = -1;  
			
			cmb_Lone_YN.SelectedIndex = -1;  

			txt_Dl_Days_DS.Value = 0;
			txt_Dl_Days_QD.Value = 0;
            txt_Dl_Days_VJ.Value = 0;
            txt_Dl_Days_JJ.Value = 0;

			txt_Safe_Amt_DS.Value = 0;
			txt_Safe_Amt_QD.Value = 0;
            txt_Safe_Amt_VJ.Value = 0;
            txt_Safe_Amt_JJ.Value = 0;

			cmb_Life_YN.SelectedIndex = -1;  
			txt_Life_Day.Value = 0;
			cmb_In_Wh_Cd.SelectedIndex = -1;  
			cmb_Out_Wh_Cd.SelectedIndex = -1;  

			txt_Pur_Loss_Rate.Value = 0;
			txt_Out_Loss_Rate.Value = 0;
			txt_Ship_Loss_Rate.Value = 0;
			txt_Pur_Lot_Amt.Text = "";
			txt_Prod_In_Lot.Text = "";
			txt_Mcs_No.Text = "";
			txt_Hs_No.Text = "";
			txt_cbm.Text = "";
			txt_Gross_Weight.Text = "";
			txt_Net_Weight.Text = "";
			txt_Volume.Text = "";
			txt_Length.Text	= "";
			txt_Width.Text = "";
			txt_Height.Text	= "";




			_Close_Save = false;


		}




		/// <summary>
		/// Save_Check : save 필수 항목 체크
		/// </summary>
		/// <returns></returns>
		private bool Save_Check()
		{


			if (COM.ComVar.This_Factory.Equals(COM.ComVar.DSFactory))
			{
				if (cmb_Style_Item_Div.SelectedIndex == -1)
				{
					MessageBox.Show(this, "Select Item Division", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cmb_Style_Item_Div.Focus();
					return false;
				}

//				if ( (cmb_Style_Item_Div.SelectedIndex == 1) && (cmb_trade_group.SelectedIndex == -1) )
//				{
//					MessageBox.Show(this, "Select Trade Group", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//					cmb_trade_group.Focus();
//					return false;
//				}


                //if (cmb_trade_group.SelectedIndex == -1 || cmb_trade_group.SelectedValue.ToString().Trim().Equals("") )
                //{
                //    MessageBox.Show(this, "Select Trade Group", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    cmb_trade_group.Focus();
                //    return false;
                //}
			}

             



			System.Windows.Forms.TextBox[] text_list = new System.Windows.Forms.TextBox[] { txt_Group_CD, txt_Item_Name1 };   // txt_Item_CD, 

  	
 			//if (!FlexBase.ClassLib.ComFunction.Essentiality_check(combo_list, text_list, true) ) return false;  
			if (!FlexBase.ClassLib.ComFunction.Essentiality_check(null, text_list, true) ) return false;  


			return true; 

		}






		#endregion 

		#region 이벤트 처리


		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}

		}


		#endregion 

		#region 키보드 조회 이벤트

		private void txt_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{ 
			try
			{
				//if(e.KeyValue != (char)13) return;
				if(e.KeyCode != Keys.Enter) return; 

				TextBox src = sender as TextBox;

				Set_Cust_User_Combo(src); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		
		/// <summary>
		/// Set_Cust_User_Combo : 
		/// </summary>
		/// <param name="arg_control"></param>
		private void Set_Cust_User_Combo(System.Windows.Forms.TextBox arg_control)
		{
			try
			{
				DataTable dt;

				//arg_control.Text = ClassLib.ComFunction.Empty_TextBox(arg_control, " ");

				switch(arg_control.Name)
				{
						//주거래처
					case "txt_Cus_Cd_DS": 
						
						dt = Select_Customer_CD("DS", arg_control.Text);
						ClassLib.ComCtl.Set_ComboList(dt,cmb_Cus_Cd_DS, 0, 1, false, 50, 200); 

						break;

					case "txt_Cus_Cd_QD": 
						
						dt = Select_Customer_CD("QD", arg_control.Text);
						ClassLib.ComCtl.Set_ComboList(dt,cmb_Cus_Cd_QD, 0, 1, false, 50, 200);

						break;

					case "txt_Cus_Cd_VJ": 
						
						dt = Select_Customer_CD("VJ", arg_control.Text);
						ClassLib.ComCtl.Set_ComboList(dt,cmb_Cus_Cd_VJ, 0, 1, false, 50, 200);

						break;

                    case "txt_Cus_Cd_JJ":

                        dt = Select_Customer_CD("JJ", arg_control.Text);
                        ClassLib.ComCtl.Set_ComboList(dt, cmb_Cus_Cd_VJ, 0, 1, false, 50, 200);

                        break;



						//담당자
					case "txt_Man_Charge_DS": 
						
						dt = ClassLib.ComFunction.Select_Man_Charge("DS", arg_control.Text);
						ClassLib.ComCtl.Set_ComboList(dt,cmb_Man_Charge_DS, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code);  
 

						break;

					case "txt_Man_Charge_QD": 
						
						dt = ClassLib.ComFunction.Select_Man_Charge("QD", arg_control.Text);
						ClassLib.ComCtl.Set_ComboList(dt,cmb_Man_Charge_QD, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code);   
 


						break;

					case "txt_Man_Charge_VJ": 
						
						dt = ClassLib.ComFunction.Select_Man_Charge("VJ", arg_control.Text);
						ClassLib.ComCtl.Set_ComboList(dt,cmb_Man_Charge_VJ, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code);  
 

						break;

                    case "txt_Man_Charge_JJ":

                        dt = ClassLib.ComFunction.Select_Man_Charge("JJ", arg_control.Text);
                        ClassLib.ComCtl.Set_ComboList(dt, cmb_Man_Charge_VJ, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code);


                        break;

				} 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_Cust_User_Combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		private void cmb_Man_Charge_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				C1.Win.C1List.C1Combo src = sender as C1.Win.C1List.C1Combo;

				if(src.Equals(cmb_Man_Charge_DS) )
				{
					txt_Man_Charge_DS.Text = ClassLib.ComFunction.Empty_Combo(src, "");
				}
				else if(src.Equals(cmb_Man_Charge_QD) )
				{
					txt_Man_Charge_QD.Text = ClassLib.ComFunction.Empty_Combo(src, "");
				}
				else if(src.Equals(cmb_Man_Charge_VJ) )
				{
					txt_Man_Charge_VJ.Text = ClassLib.ComFunction.Empty_Combo(src, "");
				}
                else if (src.Equals(cmb_Man_Charge_JJ))
                {
                    txt_Man_Charge_JJ.Text = ClassLib.ComFunction.Empty_Combo(src, "");
                }


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Man_Charge_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		private void cmb_Group_Type_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_Group_L_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_Group_M_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_Group_Type_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				DataTable dt_ret;

				if(cmb_Group_Type.SelectedIndex == -1) return; 

				dt_ret = ClassLib.ComFunction.Select_GroupLCode(cmb_Group_Type.SelectedValue.ToString());    
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Group_L, 0, 1, true, 20, 150); 
 
				cmb_Group_L.SelectedIndex = -1;
				cmb_Group_M.SelectedIndex = -1;

				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Group_Type_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}		
		}

		private void cmb_Group_L_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				DataTable dt_ret;

				if(cmb_Group_Type.SelectedIndex == -1 || cmb_Group_L.SelectedIndex == -1) return;

				dt_ret = ClassLib.ComFunction.Select_GroupMCode(cmb_Group_Type.SelectedValue.ToString(), cmb_Group_L.SelectedValue.ToString());    
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Group_M, 0, 1, true, 40, 130); 
 
				cmb_Group_M.SelectedIndex = -1;

				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Group_L_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}		
		}

		private void cmb_Group_M_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_Group_Type.SelectedIndex == -1 || cmb_Group_L.SelectedIndex == -1 || cmb_Group_M.SelectedIndex == -1) return;

				dt_ret = ClassLib.ComFunction.Select_GroupSCode(cmb_Group_Type.SelectedValue.ToString(), cmb_Group_L.SelectedValue.ToString(), cmb_Group_M.SelectedValue.ToString());    			
				
				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Group_M_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}		
		}

		private void txt_Group_CD_TextChanged(object sender, System.EventArgs e)
		{
			if(txt_Group_CD.Text.Trim().Equals("")) return;


			cmb_Group_Type.SelectedValue = txt_Group_CD.Text.Substring(0,2);
			cmb_Group_L.SelectedValue    = txt_Group_CD.Text.Substring(2,1);
			cmb_Group_M.SelectedValue    = txt_Group_CD.Text.Substring(3,2);
		}

	    #endregion

		
		private void tab_Item_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			try
			{

				if(tab_Item.SelectedTab.Equals(tab_General) )
				{
					InitControl_tab_General(_DT_ItemData);
				}
				else if(tab_Item.SelectedTab.Equals(tab_Unit) )
				{
					InitControl_tab_Unit(_DT_ItemData);
				}
				else if(tab_Item.SelectedTab.Equals(tab_Roul) )
				{
					InitControl_tab_Roul(_DT_ItemData);
				}
				else if(tab_Item.SelectedTab.Equals(tab_MRP) )
				{
					InitControl_tab_MRP(_DT_ItemData);
				}
				else if(tab_Item.SelectedTab.Equals(tab_Dim) )
				{
					InitControl_tab_Dim(_DT_ItemData);
				}
				else if(tab_Item.SelectedTab.Equals(tab_Catalog) )
				{
					InitControl_tab_eCatalog();
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tab_Item_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
 


		}



		/// <summary>
		/// 저장버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			try
			{
				//-----------------------------------------------------------------------------------------
				// save 필수 항목 체크
				bool save_ok = Save_Check();

				if(! save_ok) return;
				//-----------------------------------------------------------------------------------------

				//-----------------------------------------------------------------------------------------
				// Item 중복 체크

				if(txt_Item_CD.Text.Trim().Equals("") )
				{

					DataTable dt_ret;
 
					dt_ret = Check_Duplicate_DB(txt_Item_Name1.Text.Trim() );

					// 중복 아님, 저장 가능
					if(! Convert.IsDBNull(dt_ret.Rows[0].ItemArray[0]) )  
					{
					 
						ClassLib.ComFunction.User_Message("Duplicate Itemt Name : [" 
							+ dt_ret.Rows[0].ItemArray[0].ToString().Trim() + "]", 
							"Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

						dt_ret.Dispose(); 

						return;
					}

					if(dt_ret != null) dt_ret.Dispose(); 
				}

				//-----------------------------------------------------------------------------------------


				//-----------------------------------------------------------------------------------------
				bool save_flag = Save_Item();

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
					_Close_Save = true;

					if(_ReturnYN)
					{
 
						Return_Data_New_Return(); 
					}
					else
					{ 
						Return_Data();  

					}


					this.Close();



				}
				//-----------------------------------------------------------------------------------------

				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			} 

		}



		


		private void Return_Data_New_Return()
		{


			string item_cd = ClassLib.ComFunction.Empty_String(_ItemCD, " ");
			string group_cd = ClassLib.ComFunction.Empty_TextBox(txt_Group_CD, " "); 
			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name1, " ");
			string use_yn = ClassLib.ComFunction.Empty_Combo(cmb_Use_YN, "N"); 

			if(item_cd.Trim().Equals("") )
			{
				
				DataTable dt_ret = FlexBase.MaterialBase.Pop_Item_List.Select_SBC_ITEM_COMMON(item_cd, group_cd, item_name, use_yn); 

				item_cd = dt_ret.Rows[0].ItemArray[0].ToString();

				dt_ret.Dispose();
			} 
 
			 
			ClassLib.ComVar.Parameter_PopUp  = new string[4];
			ClassLib.ComVar.Parameter_PopUp[0] = item_cd; 
			ClassLib.ComVar.Parameter_PopUp[1] = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name1, "");   
			ClassLib.ComVar.Parameter_PopUp[2] = ClassLib.ComFunction.Empty_Combo(cmb_Size_YN, "");   // y or n
			ClassLib.ComVar.Parameter_PopUp[3] = ClassLib.ComFunction.Empty_Combo(cmb_Mng_Unit, ""); 
 

		}


		private void Return_Data()
		{



			string item_cd = ClassLib.ComFunction.Empty_String(_ItemCD, " ");
			string group_cd = ClassLib.ComFunction.Empty_TextBox(txt_Group_CD, " "); 
			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name1, " ");
			string use_yn = ClassLib.ComFunction.Empty_Combo(cmb_Use_YN, "N"); 

			if(item_cd.Trim().Equals("") )
			{
				
				DataTable dt_ret = FlexBase.MaterialBase.Pop_Item_List.Select_SBC_ITEM_COMMON(item_cd, group_cd, item_name, use_yn); 

				item_cd = dt_ret.Rows[0].ItemArray[0].ToString();

				dt_ret.Dispose();
			} 



			ClassLib.ComVar.Parameter_PopUp  = new string[80];


            ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxDIVISION] = "";
            ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_CD] = item_cd;
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxGROUP_CD]  = ClassLib.ComFunction.Empty_TextBox(txt_Group_CD, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_NAME1]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name1, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_NAME2]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name2, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_NAME3]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name3, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_NAME4]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name4, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_NAME5]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name5, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxSIZE_YN]  = ClassLib.ComFunction.Empty_Combo(cmb_Size_YN, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxUSE_YN]  = ClassLib.ComFunction.Empty_Combo(cmb_Use_YN, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxREP_ITEM_CD] = ClassLib.ComFunction.Empty_TextBox(txt_Rep_Item_CD, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCOPY_FROM] = ClassLib.ComFunction.Empty_TextBox(txt_Copy_From_CD, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxREMARK] = ClassLib.ComFunction.Empty_TextBox(txt_ReMark, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMNG_UNIT] = ClassLib.ComFunction.Empty_Combo(cmb_Mng_Unit, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxPK_QTY] = ClassLib.ComFunction.Empty_TextBox(txt_Pk_Qty, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxSPEC_TYPE] = ClassLib.ComFunction.Empty_Combo(cmb_Spec_Type, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxSTYLE_ITEM_DIV] = ClassLib.ComFunction.Empty_Combo(cmb_Style_Item_Div, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxBUY_DIV] = ClassLib.ComFunction.Empty_Combo(cmb_Buy_Div, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxSTOCK_UNIT] = ClassLib.ComFunction.Empty_Combo(cmb_Stock_Unit, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_CONV] = ClassLib.ComFunction.Empty_TextBox(txt_Item_Conv, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxABC_DIV] = ClassLib.ComFunction.Empty_Combo(cmb_Abc_Div, ""); 
            ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxINSP_YN] = ClassLib.ComFunction.Empty_Combo(cmb_Insp_YN, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxPUR_PRICE] = ClassLib.ComFunction.Empty_TextBox(txt_Pur_Price, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxPUR_CURRENCY] = ClassLib.ComFunction.Empty_Combo(cmb_Pur_Currency, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCBD_PRICE] = ClassLib.ComFunction.Empty_TextBox(txt_Cbd_Price, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCBD_CURRENCY] = ClassLib.ComFunction.Empty_Combo(cmb_Cbd_Currency, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxPROCESSING_YN] = ClassLib.ComFunction.Empty_Combo(cmb_Processing_YN, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxPROCESSING_PRICE] = ClassLib.ComFunction.Empty_TextBox(txt_Processing_Price, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxPROCESSING_CURRENCY] = ClassLib.ComFunction.Empty_Combo(cmb_Processing_Currency, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_CD_DS] = ClassLib.ComFunction.Empty_Combo(cmb_Cus_Cd_DS, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_CD_QD] = ClassLib.ComFunction.Empty_Combo(cmb_Cus_Cd_QD, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_CD_VJ] = ClassLib.ComFunction.Empty_Combo(cmb_Cus_Cd_VJ, "");  
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_CD_JJ] = ClassLib.ComFunction.Empty_Combo(cmb_Cus_Cd_JJ, "");  

			if(cmb_Cus_Cd_DS.SelectedIndex == -1)
			{
                ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_DS] = ""; 
			}
			else
			{
                ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_DS] = ClassLib.ComFunction.Empty_String(cmb_Cus_Cd_DS.Columns[1].Text, ""); 
			}

			if(cmb_Cus_Cd_QD.SelectedIndex == -1)
			{
                ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_QD] = ""; 
			}
			else
			{
                ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_QD] = ClassLib.ComFunction.Empty_String(cmb_Cus_Cd_QD.Columns[1].Text, ""); 
			}

			if(cmb_Cus_Cd_VJ.SelectedIndex == -1)
			{
                ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_VJ] = ""; 
			}
			else
			{
                ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_VJ] = ClassLib.ComFunction.Empty_String(cmb_Cus_Cd_VJ.Columns[1].Text, ""); 
			}

            if (cmb_Cus_Cd_JJ.SelectedIndex == -1)
            {
                ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_JJ] = "";
            }
            else
            {
                ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_JJ] = ClassLib.ComFunction.Empty_String(cmb_Cus_Cd_JJ.Columns[1].Text, "");
            }
			
			 

			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMAN_CHARGE_DS] = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_DS, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMAN_CHARGE_QD] = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_QD, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMAN_CHARGE_VJ] = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_VJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMAN_CHARGE_JJ] = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_JJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxIMPORT_DS] = ClassLib.ComFunction.Empty_Combo(cmb_Import_DS, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxIMPORT_QD] = ClassLib.ComFunction.Empty_Combo(cmb_Import_QD, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxIMPORT_VJ] = ClassLib.ComFunction.Empty_Combo(cmb_Import_VJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxIMPORT_JJ] = ClassLib.ComFunction.Empty_Combo(cmb_Import_JJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCOST_YN] = ClassLib.ComFunction.Empty_Combo(cmb_Cost_YN, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxACC_DIV_YN] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_YN, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxACC_DIV_DS] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_DS, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxACC_DIV_QD] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_QD, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxACC_DIV_VJ] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_VJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxACC_DIV_JJ] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_JJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxLONE_YN] = ClassLib.ComFunction.Empty_Combo(cmb_Lone_YN, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxDL_DAYS_DS] = ClassLib.ComFunction.Empty_TextBox(txt_Dl_Days_DS, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxDL_DAYS_QD] = ClassLib.ComFunction.Empty_TextBox(txt_Dl_Days_QD, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxDL_DAYS_VJ] = ClassLib.ComFunction.Empty_TextBox(txt_Dl_Days_VJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxDL_DAYS_JJ] = ClassLib.ComFunction.Empty_TextBox(txt_Dl_Days_JJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxSAFE_AMT_DS] = ClassLib.ComFunction.Empty_TextBox(txt_Safe_Amt_DS, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxSAFE_AMT_QD] = ClassLib.ComFunction.Empty_TextBox(txt_Safe_Amt_QD, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxSAFE_AMT_VJ] = ClassLib.ComFunction.Empty_TextBox(txt_Safe_Amt_VJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxSAFE_AMT_JJ] = ClassLib.ComFunction.Empty_TextBox(txt_Safe_Amt_JJ, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxLIFE_YN] = ClassLib.ComFunction.Empty_Combo(cmb_Life_YN, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxLIFE_DAY] = ClassLib.ComFunction.Empty_TextBox(txt_Life_Day, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxIN_WH_CD] = ClassLib.ComFunction.Empty_Combo(cmb_In_Wh_Cd, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxOUT_WH_CD] = ClassLib.ComFunction.Empty_Combo(cmb_Out_Wh_Cd, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxPUR_LOSS_RATE] = ClassLib.ComFunction.Empty_TextBox(txt_Pur_Loss_Rate, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxOUT_LOSS_RATE] = ClassLib.ComFunction.Empty_TextBox(txt_Out_Loss_Rate, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxSHIP_LOSS_RATE] = ClassLib.ComFunction.Empty_TextBox(txt_Ship_Loss_Rate, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxPUR_LOT_AMT] = ClassLib.ComFunction.Empty_TextBox(txt_Pur_Lot_Amt, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxPROD_IN_LOT] = ClassLib.ComFunction.Empty_TextBox(txt_Prod_In_Lot, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMCS_NO] = ClassLib.ComFunction.Empty_TextBox(txt_Mcs_No, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxHS_NO] = ClassLib.ComFunction.Empty_TextBox(txt_Hs_No, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCBM] = ClassLib.ComFunction.Empty_TextBox(txt_cbm, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxGROSS_WEIGHT] = ClassLib.ComFunction.Empty_TextBox(txt_Gross_Weight, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxNET_WEIGHT] = ClassLib.ComFunction.Empty_TextBox(txt_Net_Weight, "");  
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxVOLUME] = ClassLib.ComFunction.Empty_TextBox(txt_Volume, "");  
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxLENGTH] = ClassLib.ComFunction.Empty_TextBox(txt_Length, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxWIDTH] = ClassLib.ComFunction.Empty_TextBox(txt_Width, ""); 
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxHEIGHT] = ClassLib.ComFunction.Empty_TextBox(txt_Height, "");  
			ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxUPD_USER] = ClassLib.ComVar.This_User;
            ClassLib.ComVar.Parameter_PopUp[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxUPD_YMD] = "";

		}


		/// <summary>
		/// 그룹조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_SearchGroup_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;


				//Pop_GroupSearch pop_form = new Pop_GroupSearch(_Group_Type, _Group_L);
				Pop_GroupSearch pop_form = new Pop_GroupSearch("", "");
				pop_form.ShowDialog();	
	
				Set_NewItemGroup();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}




		private void Set_NewItemGroup()
		{

			if(ClassLib.ComVar.Parameter_PopUp == null) return;
			if(ClassLib.ComVar.Parameter_PopUp[3].Length != 8) return;

			_Group_CD = ClassLib.ComVar.Parameter_PopUp[3];


			if(_Group_CD.Trim().Equals("") ) return;

            //ClassLib.ComVar.Parameter_PopUp = new string[] {_GroupType, 
            //                                                   _GroupL, 
            //                                                   _GroupM, 
            //                                                   _GroupCd, 
            //                                                   _GroupName,
            //                                                   _ManCharge_DS,
            //                                                   _ManCharge_QD,
            //                                                   _ManCharge_VJ,
            //                                                   _ManCharge_JJ};


			_Group_Name	= ClassLib.ComVar.Parameter_PopUp[4];
				
			txt_Group_CD.Text = _Group_CD;

//			if(txt_Group_CD.Text.Trim().Substring(0, 2) != _GroupTypeSRF)
//			{
//				txt_Item_Name1.Text = _Group_Name;
//			}

 



			// man charge ds, qd, vj
			txt_Man_Charge_DS.Text = ClassLib.ComVar.Parameter_PopUp[5];
			txt_Man_Charge_QD.Text = ClassLib.ComVar.Parameter_PopUp[6];
            txt_Man_Charge_VJ.Text = ClassLib.ComVar.Parameter_PopUp[7];
            txt_Man_Charge_JJ.Text = ClassLib.ComVar.Parameter_PopUp[8];

			//담당자 콤보 세팅
			Set_Cust_User_Combo(txt_Man_Charge_DS);
			Set_Cust_User_Combo(txt_Man_Charge_QD);
            Set_Cust_User_Combo(txt_Man_Charge_VJ);
            Set_Cust_User_Combo(txt_Man_Charge_JJ);

			cmb_Man_Charge_DS.SelectedValue	= ClassLib.ComVar.Parameter_PopUp[5];
			cmb_Man_Charge_QD.SelectedValue	= ClassLib.ComVar.Parameter_PopUp[6];
            cmb_Man_Charge_VJ.SelectedValue = ClassLib.ComVar.Parameter_PopUp[7];
            cmb_Man_Charge_JJ.SelectedValue = ClassLib.ComVar.Parameter_PopUp[8];


		}


		

		/// <summary>
		/// 아이템 그룹 추가
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_AddGroup_Click(object sender, System.EventArgs e)
		{
			try
			{

				this.Cursor = Cursors.WaitCursor;

				Form_BC_Group pop_form = new Form_BC_Group(true);
				pop_form.ShowDialog();	 

				Set_NewItemGroup();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message, "btn_AddGroup_Click", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}




		/// <summary>
		/// 품목조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_SearchItem_Click(object sender, System.EventArgs e)
		{
			try
			{
//				Pop_Item_Show_Search Pop_Item_Showform = new Pop_Item_Show_Search();
//				Pop_Item_Showform.ShowDialog();	
//	
//				_Item_CD	= ClassLib.ComVar.Parameter_PopUp[0];
//				_Item_Name	= ClassLib.ComVar.Parameter_PopUp[1];
//				
//				txt_Rep_Item_CD.Text		= _Item_CD;
//				txt_Rep_Item_Name.Text		= _Item_Name;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		
		}



		private void sgrid_Image_EditModeOn(object sender, System.EventArgs e)
		{
			try
			{
				int ir = sgrid_Image.ActiveSheet.ActiveRowIndex ;
				int ic = sgrid_Image.ActiveSheet.ActiveColumnIndex ;

				sgrid_Image.Buffer_CellData = (sgrid_Image.ActiveSheet.Cells[ir,ic].Value == null) ? "" : sgrid_Image.ActiveSheet.Cells[ir,ic].Value.ToString() ;
				 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "sgrid_Image_EditModeOn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

  
		
		private void sgrid_Image_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			int ir = sgrid_Image.ActiveSheet.ActiveRowIndex ;
			int ic = sgrid_Image.ActiveSheet.ActiveColumnIndex ;

			if(ic == (int)ClassLib.TBSBC_ITEM_IMAGE.IxDELETE_YN)  
			{ 
				if((bool)sgrid_Image.ActiveSheet.Cells[ir, ic].Value)
				{  
					sgrid_Image.ActiveSheet.Cells[ir, ic].Value = true; 
					sgrid_Image.Delete_Row(ir, img_Action);  
				}
				else
				{ 
					sgrid_Image.ActiveSheet.Cells[ir, ic].Value = false; 
					sgrid_Image.Recovery(); 
				}
			}


		}



		private void sgrid_Image_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{ 
			sgrid_Image.Update_Row(img_Action); 
		} 

  




		private void cmb_Buy_Div_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				cmb_Import_DS.SelectedValue = cmb_Buy_Div.Columns[2].Text;
				cmb_Import_QD.SelectedValue = cmb_Buy_Div.Columns[2].Text;
                cmb_Import_VJ.SelectedValue = cmb_Buy_Div.Columns[2].Text;
                cmb_Import_JJ.SelectedValue = cmb_Buy_Div.Columns[2].Text;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Buy_Div_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#endregion
   
		#region DB Connect


		/// 해당 Item Data 조회 : 
		/// </summary>
		/// <returns></returns>
		public static DataTable Select_SBC_ITEM_POP(string _ItemCD)
		{
 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_ITEM.SELECT_SBC_ITEM_POP";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = _ItemCD; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}


		/// <summary>
		/// Select_Customer_CD : 거래처리스트
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_cust"></param>
		/// <returns>DataTable</returns>
		public static DataTable Select_Customer_CD(string arg_factory, string arg_cust)
		{
			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SBC_COMMON.SELECT_SCM_CUST_LIST";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_VALUE";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_cust, " ");
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ; 
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// 창고 조회
		/// </summary>
		/// <returns></returns>
		public static DataTable Select_WareHouse()
		{
	 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
	 
			MyOraDB.ReDim_Parameter(1); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_ITEM.SELECT_SBC_ITEM_WAREHOUSE";
	 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
				 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = ""; 

			MyOraDB.Add_Select_Parameter(true);
	 
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;
				
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}


		/// <summary>
		/// Save_Item : 저장
		/// </summary>
		private bool Save_Item()
		{
			try
			{
				COM.OraDB MyOraDB = new COM.OraDB();

				DataSet ds_ret;
 
				int col_ct = 80;

				MyOraDB.ReDim_Parameter(col_ct); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBC_ITEM.SAVE_SBC_ITEM";
 
				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[2]  = "ARG_GROUP_CD";
				MyOraDB.Parameter_Name[3]  = "ARG_ITEM_NAME1";
				MyOraDB.Parameter_Name[4]  = "ARG_ITEM_NAME2";
				MyOraDB.Parameter_Name[5]  = "ARG_ITEM_NAME3";
				MyOraDB.Parameter_Name[6]  = "ARG_ITEM_NAME4";
				MyOraDB.Parameter_Name[7]  = "ARG_ITEM_NAME5";
				MyOraDB.Parameter_Name[8]  = "ARG_SIZE_YN";
				MyOraDB.Parameter_Name[9]  = "ARG_USE_YN";
                MyOraDB.Parameter_Name[10] = "ARG_REP_ITEM_CD";
                MyOraDB.Parameter_Name[11] = "ARG_COPY_FROM";
                MyOraDB.Parameter_Name[12] = "ARG_REMARK";
                MyOraDB.Parameter_Name[13] = "ARG_MNG_UNIT";
                MyOraDB.Parameter_Name[14] = "ARG_PK_QTY";
                MyOraDB.Parameter_Name[15] = "ARG_SPEC_TYPE";
                MyOraDB.Parameter_Name[16] = "ARG_STYLE_ITEM_DIV";
                MyOraDB.Parameter_Name[17] = "ARG_BUY_DIV";
                MyOraDB.Parameter_Name[18] = "ARG_STOCK_UNIT";
                MyOraDB.Parameter_Name[19] = "ARG_ITEM_CONV";
                MyOraDB.Parameter_Name[20] = "ARG_ABC_DIV";
                MyOraDB.Parameter_Name[21] = "ARG_INSP_YN";
                MyOraDB.Parameter_Name[22] = "ARG_PUR_PRICE";
                MyOraDB.Parameter_Name[23] = "ARG_PUR_CURRENCY";
                MyOraDB.Parameter_Name[24] = "ARG_CBD_PRICE";
                MyOraDB.Parameter_Name[25] = "ARG_CBD_CURRENCY";
                MyOraDB.Parameter_Name[26] = "ARG_PROCESSING_YN";
                MyOraDB.Parameter_Name[27] = "ARG_PROCESSING_PRICE";
                MyOraDB.Parameter_Name[28] = "ARG_PROCESSING_CURRENCY";
                MyOraDB.Parameter_Name[29] = "ARG_CUS_CD_DS";
                MyOraDB.Parameter_Name[30] = "ARG_CUS_CD_QD";
                MyOraDB.Parameter_Name[31] = "ARG_CUS_CD_VJ";
                MyOraDB.Parameter_Name[32] = "ARG_CUS_CD_JJ";
                MyOraDB.Parameter_Name[33] = "ARG_CUS_NAME_DS";
                MyOraDB.Parameter_Name[34] = "ARG_CUS_NAME_QD";
                MyOraDB.Parameter_Name[35] = "ARG_CUS_NAME_VJ";
                MyOraDB.Parameter_Name[36] = "ARG_CUS_NAME_JJ";
                MyOraDB.Parameter_Name[37] = "ARG_MAN_CHARGE_DS";
                MyOraDB.Parameter_Name[38] = "ARG_MAN_CHARGE_QD";
                MyOraDB.Parameter_Name[39] = "ARG_MAN_CHARGE_VJ";
                MyOraDB.Parameter_Name[40] = "ARG_MAN_CHARGE_JJ";
                MyOraDB.Parameter_Name[41] = "ARG_IMPORT_DS";
                MyOraDB.Parameter_Name[42] = "ARG_IMPORT_QD";
                MyOraDB.Parameter_Name[43] = "ARG_IMPORT_VJ";
                MyOraDB.Parameter_Name[44] = "ARG_IMPORT_JJ";
                MyOraDB.Parameter_Name[45] = "ARG_COST_YN";
                MyOraDB.Parameter_Name[46] = "ARG_ACC_DIV_YN";
                MyOraDB.Parameter_Name[47] = "ARG_ACC_DIV_DS";
                MyOraDB.Parameter_Name[48] = "ARG_ACC_DIV_QD";
                MyOraDB.Parameter_Name[49] = "ARG_ACC_DIV_VJ";
                MyOraDB.Parameter_Name[50] = "ARG_ACC_DIV_JJ";
                MyOraDB.Parameter_Name[51] = "ARG_LONE_YN";
                MyOraDB.Parameter_Name[52] = "ARG_DL_DAYS_DS";
                MyOraDB.Parameter_Name[53] = "ARG_DL_DAYS_QD";
                MyOraDB.Parameter_Name[54] = "ARG_DL_DAYS_VJ";
                MyOraDB.Parameter_Name[55] = "ARG_DL_DAYS_JJ";
                MyOraDB.Parameter_Name[56] = "ARG_SAFE_AMT_DS";
                MyOraDB.Parameter_Name[57] = "ARG_SAFE_AMT_QD";
                MyOraDB.Parameter_Name[58] = "ARG_SAFE_AMT_VJ";
                MyOraDB.Parameter_Name[59] = "ARG_SAFE_AMT_JJ";
                MyOraDB.Parameter_Name[60] = "ARG_LIFE_YN";
                MyOraDB.Parameter_Name[61] = "ARG_LIFE_DAY";
                MyOraDB.Parameter_Name[62] = "ARG_IN_WH_CD";
                MyOraDB.Parameter_Name[63] = "ARG_OUT_WH_CD";
                MyOraDB.Parameter_Name[64] = "ARG_PUR_LOSS_RATE";
                MyOraDB.Parameter_Name[65] = "ARG_OUT_LOSS_RATE";
                MyOraDB.Parameter_Name[66] = "ARG_SHIP_LOSS_RATE";
                MyOraDB.Parameter_Name[67] = "ARG_PUR_LOT_AMT";
                MyOraDB.Parameter_Name[68] = "ARG_PROD_IN_LOT";
                MyOraDB.Parameter_Name[69] = "ARG_MCS_NO";
                MyOraDB.Parameter_Name[70] = "ARG_HS_NO";
                MyOraDB.Parameter_Name[71] = "ARG_CBM";
                MyOraDB.Parameter_Name[72] = "ARG_GROSS_WEIGHT";
                MyOraDB.Parameter_Name[73] = "ARG_NET_WEIGHT";
                MyOraDB.Parameter_Name[74] = "ARG_VOLUME";
                MyOraDB.Parameter_Name[75] = "ARG_LENGTH";
                MyOraDB.Parameter_Name[76] = "ARG_WIDTH";
                MyOraDB.Parameter_Name[77] = "ARG_HEIGHT";
                MyOraDB.Parameter_Name[78] = "ARG_CHILD_ITEM_CD";
                MyOraDB.Parameter_Name[79] = "ARG_UPD_USER";

				//03.DATA TYPE
				for (int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
			
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0]  = _Division; 
				MyOraDB.Parameter_Values[1]  = ClassLib.ComFunction.Empty_String(_ItemCD, " ");
				MyOraDB.Parameter_Values[2]  = ClassLib.ComFunction.Empty_TextBox(txt_Group_CD, " "); 
				MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name1, " "); 
				MyOraDB.Parameter_Values[4]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name2, " "); 
				MyOraDB.Parameter_Values[5]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name3, " "); 
				MyOraDB.Parameter_Values[6]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name4, " "); 
				MyOraDB.Parameter_Values[7]  = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name5, " "); 
				MyOraDB.Parameter_Values[8]  = ClassLib.ComFunction.Empty_Combo(cmb_Size_YN, " "); 
				MyOraDB.Parameter_Values[9]  = ClassLib.ComFunction.Empty_Combo(cmb_Use_YN, " ");
                MyOraDB.Parameter_Values[10] = ClassLib.ComFunction.Empty_TextBox(txt_Rep_Item_CD, " ");
                MyOraDB.Parameter_Values[11] = ClassLib.ComFunction.Empty_TextBox(txt_Copy_From_CD, " ");
                MyOraDB.Parameter_Values[12] = ClassLib.ComFunction.Empty_TextBox(txt_ReMark, " ");
                MyOraDB.Parameter_Values[13] = ClassLib.ComFunction.Empty_Combo(cmb_Mng_Unit, " ");
                MyOraDB.Parameter_Values[14] = ClassLib.ComFunction.Empty_TextBox(txt_Pk_Qty, " ");
                MyOraDB.Parameter_Values[15] = ClassLib.ComFunction.Empty_Combo(cmb_Spec_Type, " ");
                MyOraDB.Parameter_Values[16] = ClassLib.ComFunction.Empty_Combo(cmb_Style_Item_Div, " ");
                MyOraDB.Parameter_Values[17] = ClassLib.ComFunction.Empty_Combo(cmb_Buy_Div, " ");
                MyOraDB.Parameter_Values[18] = ClassLib.ComFunction.Empty_Combo(cmb_Stock_Unit, " ");
                MyOraDB.Parameter_Values[19] = ClassLib.ComFunction.Empty_TextBox(txt_Item_Conv, " ");
                MyOraDB.Parameter_Values[20] = ClassLib.ComFunction.Empty_Combo(cmb_Abc_Div, " ");
                MyOraDB.Parameter_Values[21] = ClassLib.ComFunction.Empty_Combo(cmb_Insp_YN, " ");
                MyOraDB.Parameter_Values[22] = ClassLib.ComFunction.Empty_TextBox(txt_Pur_Price, " ");
                MyOraDB.Parameter_Values[23] = ClassLib.ComFunction.Empty_Combo(cmb_Pur_Currency, " ");
                MyOraDB.Parameter_Values[24] = ClassLib.ComFunction.Empty_TextBox(txt_Cbd_Price, " ");
                MyOraDB.Parameter_Values[25] = ClassLib.ComFunction.Empty_Combo(cmb_Cbd_Currency, " ");
                MyOraDB.Parameter_Values[26] = ClassLib.ComFunction.Empty_Combo(cmb_Processing_YN, " ");
                MyOraDB.Parameter_Values[27] = ClassLib.ComFunction.Empty_TextBox(txt_Processing_Price, " ");
                MyOraDB.Parameter_Values[28] = ClassLib.ComFunction.Empty_Combo(cmb_Processing_Currency, " ");
                MyOraDB.Parameter_Values[29] = ClassLib.ComFunction.Empty_Combo(cmb_Cus_Cd_DS, " ");
                MyOraDB.Parameter_Values[30] = ClassLib.ComFunction.Empty_Combo(cmb_Cus_Cd_QD, " ");
                MyOraDB.Parameter_Values[31] = ClassLib.ComFunction.Empty_Combo(cmb_Cus_Cd_VJ, " ");
                MyOraDB.Parameter_Values[32] = ClassLib.ComFunction.Empty_Combo(cmb_Cus_Cd_JJ, " ");
                MyOraDB.Parameter_Values[33] = " ";
                MyOraDB.Parameter_Values[34] = " ";
                MyOraDB.Parameter_Values[35] = " ";
                MyOraDB.Parameter_Values[36] = " ";
                MyOraDB.Parameter_Values[37] = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_DS, " ");
                MyOraDB.Parameter_Values[38] = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_QD, " ");
                MyOraDB.Parameter_Values[39] = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_VJ, " ");
                MyOraDB.Parameter_Values[40] = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_JJ, " ");
                MyOraDB.Parameter_Values[41] = ClassLib.ComFunction.Empty_Combo(cmb_Import_DS, " ");
                MyOraDB.Parameter_Values[42] = ClassLib.ComFunction.Empty_Combo(cmb_Import_QD, " ");
                MyOraDB.Parameter_Values[43] = ClassLib.ComFunction.Empty_Combo(cmb_Import_VJ, " ");
                MyOraDB.Parameter_Values[44] = ClassLib.ComFunction.Empty_Combo(cmb_Import_JJ, " ");
                MyOraDB.Parameter_Values[45] = ClassLib.ComFunction.Empty_Combo(cmb_Cost_YN, " ");
                MyOraDB.Parameter_Values[46] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_YN, " ");
                MyOraDB.Parameter_Values[47] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_DS, " ");
                MyOraDB.Parameter_Values[48] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_QD, " ");
                MyOraDB.Parameter_Values[49] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_VJ, " ");
                MyOraDB.Parameter_Values[50] = ClassLib.ComFunction.Empty_Combo(cmb_Acc_Div_JJ, " ");
                MyOraDB.Parameter_Values[51] = ClassLib.ComFunction.Empty_Combo(cmb_Lone_YN, " ");
                MyOraDB.Parameter_Values[52] = ClassLib.ComFunction.Empty_TextBox(txt_Dl_Days_DS, " ");
                MyOraDB.Parameter_Values[53] = ClassLib.ComFunction.Empty_TextBox(txt_Dl_Days_QD, " ");
                MyOraDB.Parameter_Values[54] = ClassLib.ComFunction.Empty_TextBox(txt_Dl_Days_VJ, " ");
                MyOraDB.Parameter_Values[55] = ClassLib.ComFunction.Empty_TextBox(txt_Dl_Days_JJ, " ");
                MyOraDB.Parameter_Values[56] = ClassLib.ComFunction.Empty_TextBox(txt_Safe_Amt_DS, " ");
                MyOraDB.Parameter_Values[57] = ClassLib.ComFunction.Empty_TextBox(txt_Safe_Amt_QD, " ");
                MyOraDB.Parameter_Values[58] = ClassLib.ComFunction.Empty_TextBox(txt_Safe_Amt_VJ, " ");
                MyOraDB.Parameter_Values[59] = ClassLib.ComFunction.Empty_TextBox(txt_Safe_Amt_JJ, " ");
                MyOraDB.Parameter_Values[60] = ClassLib.ComFunction.Empty_Combo(cmb_Life_YN, " ");
                MyOraDB.Parameter_Values[61] = ClassLib.ComFunction.Empty_TextBox(txt_Life_Day, " ");
                MyOraDB.Parameter_Values[62] = ClassLib.ComFunction.Empty_Combo(cmb_In_Wh_Cd, " ");
                MyOraDB.Parameter_Values[63] = ClassLib.ComFunction.Empty_Combo(cmb_Out_Wh_Cd, " ");
                MyOraDB.Parameter_Values[64] = ClassLib.ComFunction.Empty_TextBox(txt_Pur_Loss_Rate, " ");
                MyOraDB.Parameter_Values[65] = ClassLib.ComFunction.Empty_TextBox(txt_Out_Loss_Rate, " ");
                MyOraDB.Parameter_Values[66] = ClassLib.ComFunction.Empty_TextBox(txt_Ship_Loss_Rate, " ");
                MyOraDB.Parameter_Values[67] = ClassLib.ComFunction.Empty_TextBox(txt_Pur_Lot_Amt, " ");
                MyOraDB.Parameter_Values[68] = ClassLib.ComFunction.Empty_TextBox(txt_Prod_In_Lot, " ");
                MyOraDB.Parameter_Values[69] = ClassLib.ComFunction.Empty_TextBox(txt_Mcs_No, " ");
                MyOraDB.Parameter_Values[70] = ClassLib.ComFunction.Empty_TextBox(txt_Hs_No, " ");
                MyOraDB.Parameter_Values[71] = ClassLib.ComFunction.Empty_TextBox(txt_cbm, " ");
                MyOraDB.Parameter_Values[72] = ClassLib.ComFunction.Empty_TextBox(txt_Gross_Weight, " ");
                MyOraDB.Parameter_Values[73] = ClassLib.ComFunction.Empty_TextBox(txt_Net_Weight, " ");
                MyOraDB.Parameter_Values[74] = ClassLib.ComFunction.Empty_TextBox(txt_Volume, " ");
                MyOraDB.Parameter_Values[75] = ClassLib.ComFunction.Empty_TextBox(txt_Length, " ");
                MyOraDB.Parameter_Values[76] = ClassLib.ComFunction.Empty_TextBox(txt_Width, " ");
                MyOraDB.Parameter_Values[77] = ClassLib.ComFunction.Empty_TextBox(txt_Height, " ");
                MyOraDB.Parameter_Values[78] = ClassLib.ComFunction.Empty_Combo(cmb_trade_group, " ");
                MyOraDB.Parameter_Values[79] = ClassLib.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Modify_Procedure();		
			 
				if(ds_ret == null) 
				{
					ds_ret.Dispose();
					return false;
				}
				else
				{
					return true;
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			} 


		}





		/// <summary>
		/// Check_Duplicate_DB : 
		/// </summary>
		///<param name="arg_item_name1"></param>
		/// <returns></returns>
		private DataTable Check_Duplicate_DB(string arg_item_name1)
		{  
			try
			{
				DataSet ds_ret;  

				MyOraDB.ReDim_Parameter(2);
				MyOraDB.Process_Name = "PKG_SBC_ITEM.CHECK_ITEM_NAME1_EXIST"; 
				
				MyOraDB.Parameter_Name[0] = "ARG_ITEM_NAME1"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = @"'" + arg_item_name1 + @"'";
				MyOraDB.Parameter_Values[1] = ""; 
				 
				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			} 
		}



		#endregion   

		#region e-Catalog


		private string _FileName = "";


		private void btn_FileOpen_Click(object sender, System.EventArgs e)
		{ 
			try
			{ 
				oFileDlg.Filter = "Picture (*.jpg;*.gif;*.bmp)|*.jpg;*.gif;*.bmp";

				if (oFileDlg.ShowDialog() == DialogResult.OK)
				{
					_FileName = oFileDlg.FileName; 
					picb_item.Image = Image.FromFile(_FileName);

					txt_image_name.Focus();
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_FileOpen_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		/// <summary>
		/// db upload 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Save_Image_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				bool save_flag = Save_Image(); 

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message("Save Image", ClassLib.ComVar.MgsDoNotSave, this);
				}
				else
				{
					ClassLib.ComFunction.Data_Message("Save Image", ClassLib.ComVar.MgsEndSave, this); 
					
					Select_Image();
				}
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
 



		/// <summary>
		/// Save_Image : 
		/// </summary>
		private bool Save_Image()
		{
			try
			{
				COM.OraDB MyOraDB = new COM.OraDB(); 
 
				bool ret;

				MyOraDB.ReDim_Parameter(6);
 
 
				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBC_ITEM_IMAGE.SAVE_SBC_ITEM_IMAGE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_Division";
				MyOraDB.Parameter_Name[1] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[2] = "ARG_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_IMAGE_NAME";
				MyOraDB.Parameter_Name[4] = "ARG_IMAGE";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Blob;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

				//04.DATA 정의
				string[] div = Check_Division();
				MyOraDB.Parameter_Values[0] = div[0]; 
				MyOraDB.Parameter_Values[1] = txt_Item_CD.Text;  
				MyOraDB.Parameter_Values[2] = div[1]; 
				MyOraDB.Parameter_Values[3] = div[2];
				MyOraDB.Parameter_Values[4] = " ";
				MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;
  
				byte[] photo = null;

				if(div[0] == "I") 
				{
					photo = GetPhoto(_FileName);
				}
				else
				{
					photo = (byte[])sgrid_Image.ActiveSheet.Cells[Convert.ToInt32(div[3]), (int)ClassLib.TBSBC_ITEM_IMAGE.IxIMAGE].Value;
				}



				ret = MyOraDB.Exe_Modify_Procedure_Blob(photo);
				
				return ret;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			} 
		}



		/// <summary>
		/// Check_Division : 
		/// </summary>
		/// <returns></returns>
		private string[] Check_Division()
		{
			string[] div = new string[4];

			/*
			div[0] = save division
			div[1] = image seq
			div[2] = image name
			div[3] = save row index
			*/


			for(int i = 0; i < sgrid_Image.ActiveSheet.RowCount; i++)
			{
				if(sgrid_Image.ActiveSheet.Cells[i, 0].Tag == null || sgrid_Image.ActiveSheet.Cells[i, 0].Tag.ToString() == "") continue;

				if(sgrid_Image.ActiveSheet.Cells[i, 0].Tag.ToString() == "U")
				{
					div[0] = "U";
					div[1] = sgrid_Image.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_ITEM_IMAGE.IxSEQ].Text.ToString();
					div[2] = sgrid_Image.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_ITEM_IMAGE.IxIMAGE_NAME].Text.ToString();
					div[3] = i.ToString();
					break;
				}
				else if(sgrid_Image.ActiveSheet.Cells[i, 0].Tag.ToString() == "D")
				{
					div[0] = "D";
					div[1] = sgrid_Image.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_ITEM_IMAGE.IxSEQ].Text.ToString();
					div[2] = " ";
					div[3] = i.ToString();
					break;
				} // end if

			}

			if(div[0] == null || div[0] == "") 
			{
				div[0] = "I";
				div[1] = " ";
				div[2] = txt_image_name.Text;
				div[3] = "";
			}

			return div;

		}


		/// <summary>
		/// GetPhoto : 
		/// </summary>
		/// <param name="arg_filename"></param>
		/// <returns></returns>
		private byte[] GetPhoto(string arg_filename)
		{
			FileStream fs = new FileStream(arg_filename, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			byte[] photo = br.ReadBytes((int)fs.Length);   
				
			br.Close();
			fs.Close();

			return photo;

		}

  

		private void sgrid_Image_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{
				int sel_row = sgrid_Image.ActiveSheet.ActiveRowIndex; 
				byte[] image = (byte[])sgrid_Image.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_ITEM_IMAGE.IxIMAGE].Value;

				txt_image_name.Text = sgrid_Image.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_ITEM_IMAGE.IxIMAGE_NAME].Value.ToString();
				Display_Image(image);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "sgrid_Image_CellClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}

		
		 



		/// <summary>
		/// Display_Image : 
		/// </summary>
		/// <param name="arg_image"></param>
		private void Display_Image(byte[] arg_image)
		{ 	 
			byte[] db_image = (byte[])arg_image; 

			MemoryStream ms = new MemoryStream(db_image); 

			System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms);

			picb_item.Image = true_image;  

			ms.Close(); 

		}



		private void btn_Search_Image_Click(object sender, System.EventArgs e)
		{
			Select_Image();
			
		}
 

		/// <summary>
		/// Select_Image : 
		/// </summary>
		private void Select_Image()
		{
			try
			{
				DataTable dt_ret;

				dt_ret = Select_SBC_ITEM_IMAGE();	
	 
				sgrid_Image.Display_Grid(dt_ret);


				dt_ret.Dispose();

				txt_image_name.Text = "";
				picb_item.Image = null;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_Image", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}  

		}

 



		/// <summary>
		/// Select_SBC_ITEM_IMAGE : 
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SBC_ITEM_IMAGE()
		{
			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SBC_ITEM_IMAGE.SELECT_SBC_ITEM_IMAGE";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_ITEM_CD"; 
			oraDB.Parameter_Name[1] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = txt_Item_CD.Text;
			oraDB.Parameter_Values[1] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ; 
			return  DS_Ret.Tables[Proc_Name];
		}



		#endregion

		

	

	 

	}
}

