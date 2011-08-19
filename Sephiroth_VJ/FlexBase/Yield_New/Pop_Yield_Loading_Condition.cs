using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexBase.Yield_New
{
    public partial class Pop_Yield_Loading_Condition : COM.PCHWinForm.Pop_Small_Light
    {


        #region 생성자


        public int _Ix_Component = 0;          //F1
        public int _Ix_ExcelSizeStart = 1;     //F2
        public int _Ix_Material = 5;			//F6
        public int _Ix_Material_1 = 6;			//F7
        public int _Ix_SpecUnit = 15;			//F16
        public int _Ix_Color = 17;				//F18
        public int _Ix_CommonYieldValue = 23;	//F24



        public Pop_Yield_Loading_Condition(int[] arg_parameter)
        {
            InitializeComponent();

            _Ix_Component = arg_parameter[0];
            _Ix_ExcelSizeStart = arg_parameter[1];
            _Ix_Material = arg_parameter[2];
            _Ix_Material_1 = arg_parameter[3];
            _Ix_SpecUnit = arg_parameter[4];
            _Ix_Color = arg_parameter[5];
            _Ix_CommonYieldValue = arg_parameter[6];


            Init_Form(); 

        }


        #endregion

        #region 변수 정의

        private COM.OraDB MyOraDB = new COM.OraDB();


        //return 또는 cancel 이벤트 체크
        public bool _CancelFlag = true;


        #endregion

        #region 멤버 메서드

        private void Init_Form()
        {
            try
            {

                //Title 
                this.Text = "Excel Loading Condition";
                lbl_MainTitle.Text = "Excel Loading Condition";


                ClassLib.ComFunction.SetLangDic(this);


                numeric_Component.Value = _Ix_Component;
                numeric_SizeStart.Value = _Ix_ExcelSizeStart;
                numeric_Material1.Value = _Ix_Material;
                numeric_Material2.Value = _Ix_Material_1;
                numeric_SpecUnit.Value = _Ix_SpecUnit;
                numeric_Color.Value = _Ix_Color;
                numeric_CommonYield.Value = _Ix_CommonYieldValue;




            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        /// <summary>
        /// Apply : [Apply] 버튼 이벤트
        /// </summary>
        private void Apply()
        {


            _Ix_Component = Convert.ToInt32(numeric_Component.Value);
            _Ix_ExcelSizeStart = Convert.ToInt32(numeric_SizeStart.Value);
            _Ix_Material = Convert.ToInt32(numeric_Material1.Value);
            _Ix_Material_1 = Convert.ToInt32(numeric_Material2.Value);
            _Ix_SpecUnit = Convert.ToInt32(numeric_SpecUnit.Value);
            _Ix_Color = Convert.ToInt32(numeric_Color.Value);
            _Ix_CommonYieldValue = Convert.ToInt32(numeric_CommonYield.Value);


            _CancelFlag = false;

            this.Close();



        }



        /// <summary>
        /// Reset : [Reset] 버튼 이벤트
        /// </summary>
        private void Reset()
        {

            _Ix_Component = 0;          //F1
            _Ix_ExcelSizeStart = 1;     //F2
            _Ix_Material = 5;			//F6
            _Ix_Material_1 = 6;			//F7
            _Ix_SpecUnit = 15;			//F16
            _Ix_Color = 17;				//F18
            _Ix_CommonYieldValue = 23;	//F24


            numeric_Component.Value = _Ix_Component;
            numeric_SizeStart.Value = _Ix_ExcelSizeStart;
            numeric_Material1.Value = _Ix_Material;
            numeric_Material2.Value = _Ix_Material_1;
            numeric_SpecUnit.Value = _Ix_SpecUnit;
            numeric_Color.Value = _Ix_Color;
            numeric_CommonYield.Value = _Ix_CommonYieldValue;

        }



        #endregion

        #region 이벤트 처리


        private void btn_Apply_Click(object sender, System.EventArgs e)
        {
            try
            {
                Apply();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            _CancelFlag = true;

            this.Close();
        }


        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "btn_Reset_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion



    }
}