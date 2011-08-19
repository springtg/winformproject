using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using System.Windows.Forms;

namespace FlexBase.ClassLib
{
    class Class_Check_InOut
    {


        public string _CheckDivision = "";
        public string _CheckFactory = "";
        public string _CheckUser = "";
        public string _CheckSeq = "-1";
        public string _CheckRemark = "";
        public string _CheckWhere = "";
        public bool _ShowMessage = false;
        public string _Factory = "";
        public string _StyleCd = "";
        public string _IncludeInfoTable = "";
        public string _IncludeValueTable = "";
        public string _IncludeHistoryTable = "";



        /// <summary>
        /// Run_Check_InOut : 
        /// </summary>
        public bool Run_Check_InOut()
        {


            bool check_ok = false;

            if (_CheckDivision == "I")
            {
                check_ok = Run_Check_In(_CheckFactory, 
                                        _CheckUser, 
                                        _CheckRemark, 
                                        _Factory, 
                                        _StyleCd);
            }
            else
            {
                check_ok = Run_Check_Out(_CheckFactory,
                                         _CheckUser,
                                         _CheckSeq,
                                         _CheckWhere,
                                         _Factory,
                                         _StyleCd,
                                         _IncludeInfoTable,
                                         _IncludeValueTable,
                                         _IncludeHistoryTable);
            }
            
            return check_ok;

        }



        
        /// <summary>
        /// Run_Check_In : 
        /// </summary>
        /// <param name="arg_check_factory"></param>
        /// <param name="arg_check_user"></param>
        /// <param name="arg_check_remark"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns>true : check in ok</returns>
        private bool Run_Check_In(string arg_check_factory,
            string arg_check_user,
            string arg_check_remark,
            string arg_factory,
            string arg_style_cd)
        {


            // check in/out cancel 
            bool checkin_cancel = false;

            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(_Factory, ClassLib.ComVar.CxYieldCheckinCancel);

            if (dt_ret != null && dt_ret.Rows.Count > 0)
            {
                checkin_cancel = (dt_ret.Rows[0].ItemArray[1].ToString().Trim().ToUpper().Equals("Y")) ? true : false;
            }
            else
            {
                checkin_cancel = false;
            }



            bool checkin_ok = false;

            if (checkin_cancel)   // local 만 체크
            {
                checkin_ok = Run_Check_In_Local(arg_check_factory, arg_check_user, arg_check_remark, arg_factory, arg_style_cd);
            }
            else  // remote, local 모두 체크
            {
                checkin_ok = Run_Check_In_RemoteLocal(arg_check_factory, arg_check_user, arg_check_remark, arg_factory, arg_style_cd);
            }


            return checkin_ok;


        }



        /// <summary>
        /// Run_Check_In_Local : Line 이상있는 경우, Checkin Local만 시도
        /// </summary>
        /// <param name="arg_check_factory"></param>
        /// <param name="arg_check_user"></param>
        /// <param name="arg_check_remark"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private bool Run_Check_In_Local(string arg_check_factory,
            string arg_check_user, 
            string arg_check_remark, 
            string arg_factory, 
            string arg_style_cd)
        {


            // 3) user factory Webservice 로 변경
            // 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
            // 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
            // 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
            // 9) user factory Webservice 로 변경
            // 10) 8) 성공 시 user factory Checkin table insert 처리 
            // 11) 10) 성공 시 최종 Checkin 성공

            // 3) user factory Webservice 로 변경
            string websvc_factory = arg_check_factory;


            string job_checkin_seq = "0";
            string job_checkin_user = arg_check_user;


            // 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
            DataTable dt_user = SELECT_SBC_YIELD_CHECKIN_MAIN(websvc_factory, arg_check_user, arg_factory, arg_style_cd);

            string user_checkin_seq = "";
            string user_checkin_user = "";

            if (dt_user == null)
            {

                if (_ShowMessage)
                {
                    string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error";
                    ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return false;

            }
            else
            {
                user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
                user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString();
            }



            // 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패 

            if (!job_checkin_user.Trim().Equals("") && !job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()))
            {

                if (_ShowMessage)
                {
                    string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + job_checkin_user;
                    ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return false;

            }

            if (!user_checkin_user.Trim().Equals("") && !user_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()))
            {

                if (_ShowMessage)
                {
                    string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + user_checkin_user;
                    ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return false;

            }



            // 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
            string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq)) ? job_checkin_seq : user_checkin_seq;
            _CheckSeq = checkinseq;


            // 9) user factory Webservice 로 변경
            websvc_factory = arg_check_factory;


            // 10) 8) 성공 시 user factory Checkin table insert 처리 
            DataSet ds_user = SAVE_SBC_YIELD_CHECKIN(websvc_factory, arg_check_user, checkinseq, arg_check_remark, arg_factory, arg_style_cd);

            if (ds_user == null)
            {

                if (_ShowMessage)
                {
                    string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim();
                    string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error";
                    ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return false;

            }


            // 11) 10) 성공 시 최종 Checkin 성공
            if (_ShowMessage)
            {
                ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            return true;



        }



        /// <summary>
        /// Run_Check_In_RemoteLocal : 정상적인 Checkin (remote, local 모두 체크)
        /// </summary>
        /// <param name="arg_check_factory"></param>
        /// <param name="arg_check_user"></param>
        /// <param name="arg_check_remark"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private bool Run_Check_In_RemoteLocal(string arg_check_factory,
            string arg_check_user,
            string arg_check_remark,
            string arg_factory,
            string arg_style_cd)
        {


            // 1) job factory Webservice 로 변경
            // 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
            // 3) user factory Webservice 로 변경
            // 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
            // 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
            // 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
            // 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
            // 8) job factory Checkin table insert 처리
            // 9) user factory Webservice 로 변경
            // 10) 8) 성공 시 user factory Checkin table insert 처리 
            // 11) 10) 성공 시 최종 Checkin 성공


            try
            {

                // 1) job factory Webservice 로 변경
                string websvc_factory = "";

                if (arg_check_factory == ClassLib.ComVar.DSFactory)
                {
                    websvc_factory = arg_factory;
                }
                else
                {
                    websvc_factory = ClassLib.ComVar.DSFactory;
                }


                // 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
                string job_checkin_seq = "";
                string job_checkin_user = "";

                DataTable dt_job = SELECT_SBC_YIELD_CHECKIN_MAIN(websvc_factory, arg_check_user, arg_factory, arg_style_cd);

                if (dt_job == null)
                {

                    if (_ShowMessage)
                    {
                        string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error (Remote)";
                        ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return false;

                }
                else
                {
                    job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
                    job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString();
                }


                // 3) user factory Webservice 로 변경
                websvc_factory = arg_check_factory;


                // 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
                DataTable dt_user = SELECT_SBC_YIELD_CHECKIN_MAIN(websvc_factory, arg_check_user, arg_factory, arg_style_cd);

                string user_checkin_seq = "";
                string user_checkin_user = "";

                if (dt_user == null)
                {

                    if (_ShowMessage)
                    {
                        string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error";
                        ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return false;

                }
                else
                {
                    user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
                    user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString();
                }



                // 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패 
                if (!job_checkin_user.Trim().Equals("") && !job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()))
                {

                    if (_ShowMessage)
                    {
                        string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + job_checkin_user;
                        ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return false;

                }

                if (!user_checkin_user.Trim().Equals("") && !user_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()))
                {

                    if (_ShowMessage)
                    {
                        string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + user_checkin_user;
                        ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return false;

                }



                // 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
                string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq)) ? job_checkin_seq : user_checkin_seq;
                _CheckSeq = checkinseq;


                // 7) 5) 가 아닌 경우,job factory Webservice 로 변경
                if (arg_check_factory == ClassLib.ComVar.DSFactory)
                {
                    websvc_factory = arg_factory;
                }
                else
                {
                    websvc_factory = ClassLib.ComVar.DSFactory;
                }


                // 8) job factory Checkin table insert 처리
                DataSet ds_job = SAVE_SBC_YIELD_CHECKIN(websvc_factory, arg_check_user, checkinseq, arg_check_remark, arg_factory, arg_style_cd);

                if (ds_job == null)
                {

                    if (_ShowMessage)
                    {
                        string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim();
                        string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error (Remote)";
                        ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return false;

                }


                // 9) user factory Webservice 로 변경
                websvc_factory = arg_check_factory;



                // 10) 8) 성공 시 user factory Checkin table insert 처리 
                DataSet ds_user = SAVE_SBC_YIELD_CHECKIN(websvc_factory, arg_check_user, checkinseq, arg_check_remark, arg_factory, arg_style_cd);

                if (ds_user == null)
                {

                    if (_ShowMessage)
                    {
                        string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim();
                        string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error";
                        ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return false;

                }


                // 11) 10) 성공 시 최종 Checkin 성공
                if (_ShowMessage)
                {
                    ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                return true;

            }
            catch
            {
                return false;
            }


        }



        
        /// <summary>
        /// Run_Check_Out :
        /// </summary>
        /// <param name="arg_check_factory"></param>
        /// <param name="arg_check_user"></param>
        /// <param name="arg_check_seq"></param>
        /// <param name="arg_check_where"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_include_info_table"></param>
        /// <param name="arg_include_value_table"></param>
        /// <param name="arg_include_history_table"></param>
        /// <returns></returns>
        private bool Run_Check_Out(string arg_check_factory,
            string arg_check_user,
            string arg_check_seq, 
            string arg_check_where, 
            string arg_factory,
            string arg_style_cd,
            string arg_include_info_table,
            string arg_include_value_table,
            string arg_include_history_table)
        {


            DataSet ds_ret = SAVE_SBC_YIELD_CHECKOUT(arg_check_factory,
                                                     arg_check_user,
                                                     arg_check_seq,
                                                     arg_check_where,
                                                     arg_factory,
                                                     arg_style_cd,
                                                     arg_include_info_table,
                                                     arg_include_value_table,
                                                     arg_include_history_table);


            if (ds_ret == null)
            {
                
                if (_ShowMessage)
                {
                    ClassLib.ComFunction.User_Message("Check Out Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return false;

            }
            else
            {

                if (_ShowMessage)
                {
                    ClassLib.ComFunction.User_Message("Check Out Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return true;

                
            }

        }



        /// <summary>
        /// SELECT_SBC_YIELD_CHECKIN_MAIN : 
        /// </summary>
        /// <param name="arg_job_factory"></param>
        /// <param name="arg_check_user"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataTable SELECT_SBC_YIELD_CHECKIN_MAIN(string arg_job_factory, 
            string arg_check_user, 
            string arg_factory, 
            string arg_style_cd)
        {


            try
            {
                 
                COM.OraDB MyOraDB = new COM.OraDB();


                ClassLib.ComFunction.Change_WebService_URL(arg_job_factory);


                MyOraDB.ReDim_Parameter(4);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SELECT_SBC_YIELD_CHECKIN_MAIN";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_CHECKIN_USER";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_check_user;
                MyOraDB.Parameter_Values[3] = "";


                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();


                ClassLib.ComFunction.Change_WebService_URL(_CheckFactory);



                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];

                // 컬럼 0 : Next Checkin Sequence
                // 컬럼 1 : Checkin User


            }
            catch
            {
                ClassLib.ComFunction.Change_WebService_URL(_CheckFactory);
                return null;
            }

        }



       

        /// <summary>
        /// CHECK IN
        /// </summary>
        /// <param name="arg_job_factory"></param>
        /// <param name="arg_check_user"></param>
        /// <param name="arg_check_seq"></param>
        /// <param name="arg_check_remarks"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        private DataSet SAVE_SBC_YIELD_CHECKIN(string arg_job_factory,
            string arg_check_user,
            string arg_check_seq,
            string arg_check_remarks,
            string arg_factory,
            string arg_style_cd)
        {


            try
            {

                COM.OraDB MyOraDB = new COM.OraDB();


                ClassLib.ComFunction.Change_WebService_URL(arg_job_factory);


                MyOraDB.ReDim_Parameter(6);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKIN";

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_CHECKIN_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_CHECKIN_USER";
                MyOraDB.Parameter_Name[5] = "ARG_REMARKS";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = "I";
                MyOraDB.Parameter_Values[1] = arg_factory;
                MyOraDB.Parameter_Values[2] = arg_style_cd;
                MyOraDB.Parameter_Values[3] = arg_check_seq;
                MyOraDB.Parameter_Values[4] = arg_check_user;
                MyOraDB.Parameter_Values[5] = arg_check_remarks;


                MyOraDB.Add_Modify_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();


                ClassLib.ComFunction.Change_WebService_URL(_CheckFactory);



                if (ds_ret == null) return null;
                return ds_ret;


            }
            catch
            {
                ClassLib.ComFunction.Change_WebService_URL(_CheckFactory);
                return null;
            }

        }



        /// <summary>
        /// SAVE_SBC_YIELD_CHECKOUT : 
        /// </summary>
        /// <param name="arg_job_factory"></param>
        /// <param name="arg_check_user"></param>
        /// <param name="arg_check_seq"></param>
        /// <param name="arg_check_where"></param>
        /// <param name="arg_factory"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_include_info_table">"Y"이면 통신 적용, "N"이면 통신 적용 하지 않음</param>
        /// <param name="arg_include_value_table">"Y"이면 통신 적용, "N"이면 통신 적용 하지 않음</param>
        /// <param name="arg_include_history_table">"Y"이면 통신 적용, "N"이면 통신 적용 하지 않음</param>
        /// <returns></returns>
        private DataSet SAVE_SBC_YIELD_CHECKOUT(string arg_job_factory,
            string arg_check_user,
            string arg_check_seq,
            string arg_check_where,
            string arg_factory,
            string arg_style_cd,
            string arg_include_info_table,
            string arg_include_value_table,
            string arg_include_history_table)
        {


            try
            {

                COM.OraDB MyOraDB = new COM.OraDB();


                ClassLib.ComFunction.Change_WebService_URL(arg_job_factory);


                MyOraDB.ReDim_Parameter(9);

                MyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKOUT";

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_WHERE";
                MyOraDB.Parameter_Name[4] = "ARG_CHECKIN_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_CHECKIN_USER";
                MyOraDB.Parameter_Name[6] = "ARG_INCLUDE_INFO_TABLE";
                MyOraDB.Parameter_Name[7] = "ARG_INCLUDE_VALUE_TABLE";
                MyOraDB.Parameter_Name[8] = "ARG_INCLUDE_HISTORY_TABLE";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = "O";
                MyOraDB.Parameter_Values[1] = arg_factory;
                MyOraDB.Parameter_Values[2] = arg_style_cd;
                MyOraDB.Parameter_Values[3] = arg_check_where;
                MyOraDB.Parameter_Values[4] = arg_check_seq;
                MyOraDB.Parameter_Values[5] = arg_check_user;
                MyOraDB.Parameter_Values[6] = (arg_include_info_table.Trim() == "") ? "Y" : arg_include_info_table;
                MyOraDB.Parameter_Values[7] = (arg_include_value_table.Trim() == "") ? "Y" : arg_include_value_table;
                MyOraDB.Parameter_Values[8] = (arg_include_history_table.Trim() == "") ? "Y" : arg_include_history_table;


                MyOraDB.Add_Modify_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();


                ClassLib.ComFunction.Change_WebService_URL(_CheckFactory);



                if (ds_ret == null) return null;
                return ds_ret;


            }
            catch
            {
                ClassLib.ComFunction.Change_WebService_URL(_CheckFactory);
                return null;
            }

        }




    } // end class
}
