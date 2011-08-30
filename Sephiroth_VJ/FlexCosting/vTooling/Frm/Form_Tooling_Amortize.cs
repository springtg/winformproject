using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.vTooling.Frm
{

    public partial class Form_Tooling_Amortize : COM.PCHWinForm.Form_Top
    {


        #region 생성자
        public Form_Tooling_Amortize()
        {
            InitializeComponent();
        }

        #endregion 
        
        #region 변수 정의

         private COM.OraDB MyOraDB = new COM.OraDB();

         #endregion

        #region 공통 모듈
        private void Init_Form()
        {
            //Title
            this.Text = "Tooling Amortization";
            this.lbl_MainTitle.Text = "Tooling Amortization";
            ClassLib.ComFunction.SetLangDic(this);



            Init_Grid();

      
            #region cotrol setting
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List_Cost();
            COM.ComCtl.Set_ComboList(vDT, cmb_Factory, 0, 1, false);
            cmb_Factory.SelectedIndex = 1;
            vDT.Dispose();


            #endregion 



            #region button setting
            tbtn_New.Enabled = true;
            tbtn_Search.Enabled = true;
            tbtn_Save.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
            #endregion 



        }

        private void Init_Grid()
        {
            fgrid_tooling.Set_Grid("SFX_CBD_TOOLING", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_tooling.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_tooling.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_tooling.Set_Action_Image(img_Action);
            fgrid_tooling.ExtendLastCol = false;

            fgrid_tooling.Font = new Font(fgrid_tooling.Font.FontFamily, (float)8.5);
         


        }

    
        #endregion 

        #region 이벤트

        private void Form_Tooling_Amortize_Load(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        


        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;


                fgrid_tooling.Cols.Count = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt;
  
                Display_Title();
                Display_List();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }



        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Factory.SelectedValue.ToString() != "DS")
            {

                DataTable vDT = Select_DPO_ID(cmb_Factory.SelectedValue.ToString());
                COM.ComCtl.Set_ComboList(vDT, cmb_DPO_From, 0, 1, false, 0, 80);             
                COM.ComCtl.Set_ComboList(vDT, cmb_DPO_To, 0, 1, false, 0, 80);
                cmb_DPO_From.SelectedIndex = 1;
                cmb_DPO_To.SelectedIndex = 1;
                vDT.Dispose();
            }
        }



        #endregion

        #region 그리드
        private void Display_Title()
        {
            fgrid_tooling.Rows.Count = fgrid_tooling.Rows.Fixed;

            string[] arg_value = new string[4];
            arg_value[0] = cmb_Factory.SelectedValue.ToString();
            arg_value[1] = cmb_DPO_From.SelectedValue.ToString();
            arg_value[2] = cmb_DPO_To.SelectedValue.ToString();
            arg_value[3] = ClassLib.ComFunction.Empty_TextBox(txt_Style_Code, " ");

            DataTable dt = SELECT_SFX_CBD_TOOL_TITLE(arg_value);


            fgrid_tooling.Cols.Count = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxMaxCt;
            string vColor = "A";
            for (int i = 0; i < dt.Rows.Count; i++)
            {   
                fgrid_tooling.Cols.Count=fgrid_tooling.Cols.Count+3;


                //fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].Style.Format = "#,###.##";                

                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 3].Width = 80;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 2].Width = 70;
                fgrid_tooling.Cols[fgrid_tooling.Cols.Count - 1].Width = 70;
                
                fgrid_tooling[1, fgrid_tooling.Cols.Count - 3] = dt.Rows[i].ItemArray[0] == null ? "0" : dt.Rows[i].ItemArray[0].ToString();
                fgrid_tooling[1, fgrid_tooling.Cols.Count - 2] = dt.Rows[i].ItemArray[1] == null ? "0" : dt.Rows[i].ItemArray[1].ToString();
                fgrid_tooling[1, fgrid_tooling.Cols.Count - 1] = dt.Rows[i].ItemArray[2] == null ? "0" : dt.Rows[i].ItemArray[2].ToString();



                if (vColor == "A")
                { fgrid_tooling.GetCellRange(1, fgrid_tooling.Cols.Count - 3, 1, fgrid_tooling.Cols.Count - 1).StyleNew.BackColor = Color.Violet; vColor = "B"; }
                else
                { fgrid_tooling.GetCellRange(1, fgrid_tooling.Cols.Count - 3, 1, fgrid_tooling.Cols.Count - 1).StyleNew.BackColor = Color.Blue; vColor = "A"; }

            }



        }

        private void Display_List()
        {

            string[] arg_value = new string[4];
            arg_value[0] = arg_value[0] = cmb_Factory.SelectedValue.ToString();
            arg_value[1] = cmb_DPO_From.SelectedValue.ToString();
            arg_value[2] = cmb_DPO_To.SelectedValue.ToString();
            arg_value[3] = ClassLib.ComFunction.Empty_TextBox(txt_Style_Code, " ");


            DataTable dt = SELECT_SFX_CBD_TOOL_LIST (arg_value);

            string vStyle = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (vStyle != dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxSTYLE_CD-1].ToString())  //style 변경시 할당
                {
                    fgrid_tooling.Rows.Add();

                    for (int j = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFACTORY ; j<=(int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFORECAST; j++)
                        fgrid_tooling[fgrid_tooling.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j-1].ToString();
                                                            
                }


                //Style변경되지 않을 시
                for (int j = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFORECAST + 1;j<= fgrid_tooling.Cols.Count - 1; j++)
                {
                    //if (fgrid_tooling[1, j].ToString() == dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDPO_ID-1].ToString())
                    //{
                    //    fgrid_tooling[fgrid_tooling.Rows.Count - 1, j] = dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxQTY-1].ToString();
                    //    fgrid_tooling[fgrid_tooling.Rows.Count - 1, j + 1] = dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFOB-1].ToString();
                    //    fgrid_tooling[fgrid_tooling.Rows.Count - 1, j + 2] = dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxTOOLING-1].ToString();
                      


                    //    vStyle = dt.Rows[i].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxSTYLE_CD - 1].ToString();


                    //    break;

                    //}

                    
                }


                
            }


            //Merge
            fgrid_tooling.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;

            fgrid_tooling.Cols[0].AllowMerging = false;
            for (int i=(int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFACTORY; i<= (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxDEV_NAME;i++)
            {
                fgrid_tooling.Cols[i].AllowMerging = true;
            } 


            //Color
            for (int i = (int)ClassLib.TBSFX_CBD_TOOLING_AMOTIZATION.IxFORECAST + 1; i <= fgrid_tooling.Cols.Count - 1; i++)
            {
                if (fgrid_tooling.GetCellRange(1, i, 1, i).StyleNew.BackColor == Color.Violet)
                {
                    fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Fixed, i, fgrid_tooling.Rows.Count - 1, i).StyleNew.BackColor = Color.FromArgb(249, 243, 250);

                }
                else
                {
                    fgrid_tooling.GetCellRange(fgrid_tooling.Rows.Fixed, i, fgrid_tooling.Rows.Count - 1, i).StyleNew.BackColor = Color.FromArgb(227, 239, 242);


                }
            }




        }



        #endregion

        #region  DB



        public DataTable Select_DPO_ID(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_DPO_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;                
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataTable SELECT_SFX_CBD_TOOL_TITLE(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TOOL_TITLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SELECT_SFX_CBD_TOOL_LIST(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TOOL_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";



                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        #endregion 


    

      
       


    }
}

