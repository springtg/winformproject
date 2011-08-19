using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;
using C1.Win.C1List;

namespace FlexPurchase.Search
{
	public class Pop_BW_QE_Parameter : COM.PCHWinForm.Pop_Small
	{
		#region 디자이너에서 사용한 변수 선언

		private System.Windows.Forms.GroupBox grp_param;
		private System.Windows.Forms.Label btn_apply;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 멤버 변수
		
		private const int SEQ = 0, PARAM_NAME = 1, PARAM_TYPE = 2, COM_CD = 3;
		private const string COMBO = "C", TEXTBOX = "T", DATETIMEPICKER = "D", PUR_USER = "U";
		private const int CONTROL_HEIGHT = 21;
		private Point _lblPoint = new System.Drawing.Point(16, 24);
		private Point _ctlPoint = new System.Drawing.Point(117, 24);
		private Form_BW_Query_Analysis _parent;

		#endregion

		#region 생성자 / 소멸자

		public Pop_BW_QE_Parameter()
		{
			InitializeComponent();
		}

		public Pop_BW_QE_Parameter(Form_BW_Query_Analysis arg_parent)
		{
			InitializeComponent();

			_parent = arg_parent;
			initForm();
		}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BW_QE_Parameter));
			this.grp_param = new System.Windows.Forms.GroupBox();
			this.btn_apply = new System.Windows.Forms.Label();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(336, 23);
			this.lbl_MainTitle.Text = "Print";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// grp_param
			// 
			this.grp_param.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.grp_param.BackColor = System.Drawing.Color.Transparent;
			this.grp_param.Location = new System.Drawing.Point(8, 40);
			this.grp_param.Name = "grp_param";
			this.grp_param.Size = new System.Drawing.Size(356, 64);
			this.grp_param.TabIndex = 27;
			this.grp_param.TabStop = false;
			this.grp_param.Text = " Parameters ";
			// 
			// btn_apply
			// 
			this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_apply.ImageIndex = 0;
			this.btn_apply.ImageList = this.img_Button;
			this.btn_apply.Location = new System.Drawing.Point(292, 104);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(72, 23);
			this.btn_apply.TabIndex = 356;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// Pop_BW_QE_Parameter
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(370, 135);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.grp_param);
			this.Name = "Pop_BW_QE_Parameter";
			this.Load += new System.EventHandler(this.Pop_BW_QA_Parameter_Load);
			this.Controls.SetChildIndex(this.grp_param, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_apply, 0);
			this.ResumeLayout(false);

		}
		#endregion

		#region 이벤트 처리 메서드

		private void Pop_BW_QA_Parameter_Load(object sender, System.EventArgs e)
		{
			if (_parent.ParamList.Count == 0)
			{
				setValue();
				this.DialogResult = DialogResult.OK;
			}
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			setValue();
			this.DialogResult = DialogResult.OK;
		}

		private void initForm()
		{
			try
			{
				this.Text = "Parameter Input";
                this.lbl_MainTitle.Text = "Parameter";
                ClassLib.ComFunction.SetLangDic(this);

				Hashtable tht = new Hashtable();

				lock(_parent.ParamList.SyncRoot)
				{
					foreach (object obj in _parent.ParamList.Values)
					{
						Proviso prov = (Proviso)obj;

						string[] param = (string[])prov.param;
						int idx = Convert.ToInt32(param[SEQ]);

						Point lblPoint = _lblPoint;
						Point ctlPoint = _ctlPoint;

						lblPoint.Y = lblPoint.Y + (CONTROL_HEIGHT * (idx - 1)) + idx;
						ctlPoint.Y = ctlPoint.Y + (CONTROL_HEIGHT * (idx - 1)) + idx;

						grp_param.Controls.Add(createLabel(param[SEQ], param[PARAM_NAME], lblPoint));

						if (param[PARAM_TYPE].Equals(COMBO))
						{
							C1Combo cmb = createCombo(param[SEQ], ctlPoint);
							grp_param.Controls.Add(cmb);
							DataTable vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, param[COM_CD]);
							COM.ComCtl.Set_ComboList(vDt, cmb, 1, 1, true, false);
							vDt.Dispose();
							cmb.SelectedValue = COM.ComVar.This_Factory;
							prov.control = cmb;
						}
						else if (param[PARAM_TYPE].Equals(DATETIMEPICKER))
						{
							DateTimePicker dpick = createDatePicker(param[SEQ], ctlPoint);
							grp_param.Controls.Add(dpick);
							prov.control = dpick;
						}
						else if (param[PARAM_TYPE].Equals(PUR_USER))
						{
							C1Combo cmb = createCombo(param[SEQ], ctlPoint);
							grp_param.Controls.Add(cmb);
							DataTable vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory, "");
							COM.ComCtl.Set_ComboList(vDt, cmb, 1, 1, true, false);
							vDt.Dispose();
							cmb.SelectedValue = COM.ComVar.This_User;
							prov.control = cmb;
						}
						else
						{
							TextBox textbox = createTextBox(param[SEQ], ctlPoint);
							grp_param.Controls.Add(textbox);
							prov.control = textbox;
						}

						tht.Add(prov.where, prov);

					}

					this.Height = this.Height + ((_parent.ParamList.Count - 1) * CONTROL_HEIGHT + _parent.ParamList.Count);
					_parent.ParamList = tht;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void setValue()
		{
			try
			{
				Hashtable tht = new Hashtable();

				lock(_parent.ParamList.SyncRoot)
				{
					foreach (object obj in _parent.ParamList.Values)
					{
						Proviso prov = (Proviso)obj;

						if (prov.control is C1Combo)
						{
							prov.val = ClassLib.ComFunction.NullToBlank(((C1Combo)prov.control).SelectedValue);
						}
						else if (prov.control is DateTimePicker)
						{
							prov.val = ((DateTimePicker)prov.control).Text.Replace("-", "");
						}
						else
						{
							prov.val = ((TextBox)prov.control).Text;
						}

						tht.Add(prov.where, prov);
					}

					_parent.ParamList = tht;
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

		#region Create Controls

		private Label createLabel(string arg_idx, string arg_title, Point arg_location)
		{
			Label label = new System.Windows.Forms.Label();
			label.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			label.ImageIndex = 1;
			label.ImageList = this.img_Label;
			label.Location = new System.Drawing.Point(8, 40);
			label.Name = "label_" + arg_idx;
			label.Size = new System.Drawing.Size(100, 21);
			label.Text = arg_title;
			label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

			label.Location = arg_location;

			return label;
		}

		private TextBox createTextBox(string arg_idx, Point arg_location)
		{
			TextBox textbox = new TextBox();

			textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			textbox.Font = new System.Drawing.Font("굴림", 9F);
			textbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
			textbox.MaxLength = 10;
			textbox.Name = "txt_" + arg_idx;
			textbox.Size = new System.Drawing.Size(210, 21);

			textbox.Location = arg_location;

			return textbox;
		}

		private C1Combo createCombo(string arg_idx, Point arg_location)
		{
			C1Combo combo = new C1Combo();

			combo.AddItemCols = 0;
			combo.AddItemSeparator = ';';
			combo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			combo.AutoSize = false;
			combo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			combo.Caption = "";
			combo.CaptionHeight = 17;
			combo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			combo.ColumnCaptionHeight = 18;
			combo.ColumnFooterHeight = 18;
			combo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			combo.ContentHeight = 17;
			combo.DeadAreaBackColor = System.Drawing.Color.Empty;
			combo.EditorBackColor = System.Drawing.SystemColors.Window;
			combo.EditorFont = new System.Drawing.Font("굴림", 9F);
			combo.EditorForeColor = System.Drawing.SystemColors.WindowText;
			combo.EditorHeight = 17;
			combo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			combo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			combo.GapHeight = 2;
			combo.ImeMode = System.Windows.Forms.ImeMode.Disable;
			combo.ItemHeight = 15;
			combo.MatchEntryTimeout = ((long)(2000));
			combo.MaxDropDownItems = ((short)(5));
			combo.MaxLength = 32767;
			combo.MouseCursor = System.Windows.Forms.Cursors.Default;
			combo.Name = "cmb_" + arg_idx;
			combo.PartialRightColumn = false;
			combo.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			combo.RowDivider.Color = System.Drawing.Color.DarkGray;
			combo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			combo.RowSubDividerColor = System.Drawing.Color.DarkGray;
			combo.Size = new System.Drawing.Size(210, 21);
			combo.TabIndex = 539;

			combo.Location = arg_location;

			return combo;
		}

		private DateTimePicker createDatePicker(string arg_idx, Point arg_location)
		{
			
			DateTimePicker dpick = new DateTimePicker();
			dpick.CustomFormat = "";
			dpick.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			dpick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			dpick.Name = "dpick_" + arg_idx;
			dpick.Size = new System.Drawing.Size(212, 21);

			dpick.Location = arg_location;

            return dpick;
		}

		public static void Set_ComboList(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow)
		{ 

			DataTable temp_datatable= new DataTable("Combo List"); 
			DataRow newrow; 
 
			try 
			{
				temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
				temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
 
				if(arg_emptyrow == true )
				{
					newrow = temp_datatable.NewRow();
					newrow["Code"] = " ";
					newrow["Name"] = "ALL";
					temp_datatable.Rows.Add(newrow);
				}

				for(int i = 0 ; i < dtcmb_list.Rows.Count; i++)
				{
					newrow = temp_datatable.NewRow();
					newrow["Code"] = dtcmb_list.Rows[i].ItemArray[arg_cd_ix];
					newrow["Name"] = dtcmb_list.Rows[i].ItemArray[arg_name_ix];
					temp_datatable.Rows.Add(newrow);  
				}  

				arg_cmb.DataSource = null; 
				arg_cmb.DataSource = temp_datatable;
			
				arg_cmb.ValueMember = "Code";
				arg_cmb.DisplayMember = "Name"; 

				arg_cmb.SelectedIndex = -1;
				arg_cmb.MaxDropDownItems = 10;
				arg_cmb.ExtendRightColumn = true; 
				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}
		
		#endregion

	}
}

