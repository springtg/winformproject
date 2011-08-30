using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.CDC_Bom
{
    public partial class Pop_Bom_Combine : COM.PCHWinForm.Pop_Large_B
    {
        public Pop_Bom_Combine()
        {
            InitializeComponent();
        }

        public Pop_Bom_Combine(Form_Bom_Editer arg_bom_editor)
        {
            _bom_editor = arg_bom_editor;
            InitializeComponent();
        }

        #region 사용자 정의 변수 
        private COM.OraDB MyOraDB = new COM.OraDB();
        Form_Bom_Editer _bom_editor = null;
        #endregion

        private void Pop_Bom_Combine_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Init_Form();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
 
            }

        }

        #region 공통 메서드
        private void Init_Form()
        {
            this.Text = "PCC_BOM Material Combine";
            this.lbl_MainTitle.Text = "PCC_BOM Material Combine";
            ClassLib.ComFunction.SetLangDic(this);

            Button_Control();

            #region Grid Setting
            fgrid_bom.Set_Grid_CDC("SXD_SRF_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_bom.Set_Action_Image(img_Action);
            fgrid_bom.Font = new Font("Verdana", 8);      
            #endregion


            Display_Data();

        }

        private void Button_Control()
        {
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = false;
            tbtn_Save.Enabled    = true;
            tbtn_Print.Enabled   = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_file_path.Enabled = false;
            btn_open_file.Enabled = false;
 
        }

        private void Display_Data()
        {
            int[] sct_rows = _bom_editor.fgrid_detail.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                if (_bom_editor.fgrid_detail.Rows[sct_rows[i]].Node.Level == 1)
                {
                    fgrid_bom.Add_Row(fgrid_bom.Rows.Count - 1);

                    for (int j = 0;j < fgrid_bom.Cols.Count; j++)
                    {
                        fgrid_bom[fgrid_bom.Rows.Count - 1, j] = _bom_editor.fgrid_detail[sct_rows[i], j].ToString();
                    }
 
                }
 
            }
        }
        #endregion

        #region 이벤트 처리

        #endregion

        #region DB Connect

        #endregion
    }
}

