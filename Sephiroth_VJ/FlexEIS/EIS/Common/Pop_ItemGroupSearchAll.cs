using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexEIS.EIS.Common
{
    public partial class Pop_ItemGroupSearchAll : COM.APSWinForm.Pop_Small
    {

        #region ������


        public Pop_ItemGroupSearchAll()
        {
            InitializeComponent();
        }



        private string _GroupType = null;

        public Pop_ItemGroupSearchAll(string arg_group_type)
        {
            
            InitializeComponent();

            _GroupType = arg_group_type;

            Init_Form();

        }


        #endregion

        #region ���� ����

        private COM.OraDB MyOraDB = new COM.OraDB();


        private int _Rowfixed = 2;

        private string _GroupL = "", _GroupM = "";
        private string _GroupCd = "", _GroupName = ""; 


        #endregion

        #region ��� �޼���


        #region �ʱ�ȭ


        private void Init_Form()
        {
            try
            {
                
                
                this.Text = "Search Item Group";
                this.lbl_MainTitle.Text = "Search Item Group";
                ClassLib.ComFunction.SetLangDic(this);

                // �׸��� ���� Tree
                fgrid_Main.Set_Grid("SBC_ITEM_GROUP", "2", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
                Select_Menu_List();
                SetCols();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       

        #endregion

        #region ��ȸ


        /// <summary>
        /// Select_Menu_List : ��ȸ�ο� �´� ������ �׸��忡 ǥ��
        /// </summary>
        private void Select_Menu_List()
        {

            DataTable dt_ret;
            dt_ret = Select_Group(_GroupType);

            fgrid_Main.Rows.Count = _Rowfixed;
            fgrid_Main.Cols.Count = dt_ret.Columns.Count + 1;

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_Main.Rows.InsertNode(i + _Rowfixed, int.Parse(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL - 1].ToString()) - 1);
                insertcell(i, dt_ret.Rows[i].ItemArray);
                Draw_Color(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL - 1].ToString(), i + _Rowfixed);
            }

            SetCols();

            dt_ret.Dispose();

        }



        /// <summary>
        /// Draw_Color : ���� �� �� ���� ����
        /// </summary>
        /// <param name="arg_level"></param>
        private void Draw_Color(string arg_level, int arg_selrow)
        {
            System.Drawing.Color row_color = Color.Empty;

            switch (Convert.ToInt32(arg_level))
            {
                // group type
                case 1:
                    row_color = ClassLib.ComVar.ClrSubTotal0;
                    break;

                // first class
                case 2:
                    row_color = ClassLib.ComVar.ClrSubTotal1;
                    break;

                // second class
                case 3:
                    row_color = ClassLib.ComVar.ClrSubTotal2;
                    break;

                // third class
                case 4:
                    row_color = ClassLib.ComVar.ClrSubTotal3;
                    break;

            } // end switch

            fgrid_Main.GetCellRange(arg_selrow, 1, arg_selrow, fgrid_Main.Cols.Count - 1).StyleNew.BackColor = row_color;
        }


        /// <summary>
        /// insertcell : �׸��忡 �� �ֱ�
        /// </summary>
        /// <param name="arg_row"></param>
        /// <param name="arg_incell"></param>
        private void insertcell(int arg_row, object[] arg_incell)
        {
            fgrid_Main[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxDIVISION] = "";
            fgrid_Main[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME] = arg_incell[0].ToString();
            fgrid_Main[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_CD] = arg_incell[1].ToString();
            fgrid_Main[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL] = arg_incell[2].ToString();
            fgrid_Main[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_TYPE] = arg_incell[3].ToString();
            fgrid_Main[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_L] = arg_incell[4].ToString();
            fgrid_Main[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_M] = arg_incell[5].ToString();
            fgrid_Main[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_S] = arg_incell[6].ToString();
        }

        /// <summary>
        /// setCols : �׸��带 Ʈ�� �������� ǥ��
        /// </summary>
        private void SetCols()
        {
            fgrid_Main.Tree.Column = (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME;
            fgrid_Main.Tree.Show(1);
        }



        #endregion

        #region ���� �̺�Ʈ �޼���


        #endregion

        #region �׸��� �̺�Ʈ �޼���


        /// <summary>
        /// Return_GroupCode : 
        /// </summary>
        private void Return_GroupCode()
        {
            try
            {
                int sel_row = 0, sel_level = 0;

                sel_row = fgrid_Main.Selection.r1;
                if (sel_row < fgrid_Main.Rows.Fixed) return;

                sel_level = Convert.ToInt32(fgrid_Main[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString());

                string vGroupCd = fgrid_Main[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_CD].ToString();

                switch (sel_level)
                {
                    case 1:
                        _GroupCd = vGroupCd.Substring(0, 2);
                        break;
                    case 2:
                        _GroupCd = vGroupCd.Substring(0, 3);
                        break;
                    case 3:
                        _GroupCd = vGroupCd.Substring(0, 5);
                        break;
                    case 4:
                        _GroupCd = vGroupCd;
                        break;
                }

                _GroupName = fgrid_Main[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME].ToString(); 
                _GroupL = fgrid_Main[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_L].ToString();
                _GroupM = fgrid_Main[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_M].ToString();

                this.Close();


            }

            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Return_GroupCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region ��ư �� ��Ÿ �̺�Ʈ �޼���

        #endregion

        #region ���ؽ�Ʈ �޴� �̺�Ʈ �޼���


        #endregion



        #endregion

        #region �̺�Ʈ ó��

        #region ���� �̺�Ʈ
         
        
        #endregion

        #region �׸��� �̺�Ʈ


        private void fgrid_Main_DoubleClick(object sender, EventArgs e)
        {
            Return_GroupCode();
        }


        #endregion

        #region ��ư �� ��Ÿ �̺�Ʈ


        #region ��ưŬ���� �̹�������


        private void btn_MouseHover(object sender, System.EventArgs e)
        {
            Label src = sender as Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }

        }

        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            Label src = sender as Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }

        }

        private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Label src = sender as Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }
        }

        private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Label src = sender as Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }
        }




        #endregion

        private void Pop_ItemGroupSearchAll_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassLib.ComVar.Parameter_PopUp = new string[] { _GroupType, _GroupL, _GroupM, _GroupCd, _GroupName };
        }



        #endregion

       

        #region ���ؽ�Ʈ �޴� �̺�Ʈ



        #endregion

        #endregion

        #region ��� ����


        #region �޺�

        #endregion

        #region ��ȸ


        /// <summary>
        /// Group ��ȸ
        /// </summary>
        /// <returns></returns>
        public static DataTable Select_Group(string arg_group_type)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet ds_ret;
            string process_name = "SEPHIROTH.PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_TYPE";

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE��
            MyOraDB.Process_Name = process_name;

            //02.ARGURMENT��
            MyOraDB.Parameter_Name[0] = "ARG_GROUP_TYPE";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA ����  
            MyOraDB.Parameter_Values[0] = arg_group_type;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[process_name];
        }


        /// <summary>
        /// Check_Duplicate_DB : 
        /// </summary>
        ///<param name="arg_groupcd"></param>
        /// <returns></returns>
        private DataTable Check_Duplicate_DB(string arg_groupcd)
        {
            try
            {
                DataSet ds_ret;

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = "SEPHIROTH.PKG_SBC_ITEM.CHECK_GROUP_CD_EXIST";

                MyOraDB.Parameter_Name[0] = "ARG_GROUP_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = @"'" + arg_groupcd + @"'";
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        #endregion

        #region ����


        #endregion



        #endregion




    }
}

