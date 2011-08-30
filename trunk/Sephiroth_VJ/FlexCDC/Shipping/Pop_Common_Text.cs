using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCDC.Shipping
{
    public partial class Pop_Common_Text : COM.PCHWinForm.Pop_Small
    {
        public Shipping.Form_Shipping arg_request = null;
        public Pop_Common_Text()
        {
            InitializeComponent();
        }
        public Pop_Common_Text(Shipping.Form_Shipping arg_request1)
        {
            InitializeComponent();
            arg_request = arg_request1;
        }

        private void Pop_Common_Text_Load(object sender, EventArgs e)
        {
            this.Text = "Request for Shipping";
            this.lbl_MainTitle.Text = "Request for Shipping";

            txt_code.CharacterCasing = CharacterCasing.Upper;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            int[] selectRow = arg_request.fgrid_Main.Selections;
            int sct_row = arg_request.fgrid_Main.Selection.r1;
            int sct_col = arg_request.fgrid_Main.Selection.c1;

            for (int i = 0; i < arg_request.fgrid_Main.Selections.Length; i++)
            {
                if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPACKING)
                {
                    if (arg_request.fgrid_Main[selectRow[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() != "")
                    {
                        arg_request.fgrid_Main[selectRow[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxPACKING] = ClassLib.ComFunction.Empty_TextBox(txt_code, "");
                        arg_request.fgrid_Main.Update_Row(selectRow[i]);
                        for (int j = selectRow[i] + 1; j < arg_request.fgrid_Main.Rows.Count; j++)
                        {
                            if (arg_request.fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString() == "1" || arg_request.fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "")
                                break;

                            arg_request.fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxPACKING] = ClassLib.ComFunction.Empty_TextBox(txt_code, "");
                            arg_request.fgrid_Main.Update_Row(j);
                        }
                    }
                }
                if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPK_NO)
                {
                    if (arg_request.fgrid_Main[selectRow[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() != "")
                    {
                        arg_request.fgrid_Main[selectRow[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxPK_NO] = ClassLib.ComFunction.Empty_TextBox(txt_code, "");
                        arg_request.fgrid_Main.Update_Row(selectRow[i]);
                        for (int j = selectRow[i] + 1; j < arg_request.fgrid_Main.Rows.Count; j++)
                        {
                            if (arg_request.fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString() == "1" || arg_request.fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "")
                                break;

                            arg_request.fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxPK_NO] = ClassLib.ComFunction.Empty_TextBox(txt_code, "");
                            arg_request.fgrid_Main.Update_Row(j);
                        }
                    }
                }

            }
          
           
            this.Close();		
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();	
        }
    }
}

