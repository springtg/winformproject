using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
using FarPoint.Win.Spread; 

using System.Data.OleDb;
using Microsoft.Office.Core;


namespace FlexTrade.ClassLib
{
	/// <summary>
	/// Common_Function에 대한 요약 설명입니다.
	/// </summary>
	public class ComFunction : COM.ComFunction
	{
		public ComFunction()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		// object type data null check
		public static string NullToBlank(object val)
		{
			if (val != null)
				return val.ToString();
			else
				return "";
		}

		// Report Directory 
		public static string Set_RD_Directory(string arg_FormName)
		{
			return Application.StartupPath +"\\Report\\Trade\\" + arg_FormName + ".mrd";
		}

		public static  DataTable CREATE_REPORT_REQUEST_KEY(string arg_Report_Job_Name)
		{
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_STM_REPORT.CREATE_REPORT_REQUEST_KEY";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_JOB_NAME";
			MyOraDB.Parameter_Name[1]  = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = arg_Report_Job_Name;
			MyOraDB.Parameter_Values[1]   = COM.ComVar.This_User;
			MyOraDB.Parameter_Values[2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];

		}


		//  
		public static double Calcute_Factory_FOB(double arg_fob, double margin_rate)
		{
			double dTemp;

			dTemp = (arg_fob * (margin_rate/100) + 0.005) * 100; 

			dTemp = System.Math.Floor(dTemp);

			dTemp = dTemp/100;

			return dTemp;
		}

		public static string MERCURY_QUERY_STRING(string arg_div, string arg_factory, string arg_po_no, string arg_po_item, string arg_invoiceno)
		{
			string sQUERY;


			if (arg_div == "1")
				sQUERY =
							" SELECT '' AS MERCURY_CT_QTY,                                                        " +
							"        ISNULL(MAX(A.MENGE),               0) AS MERCURY_SHOE_QTY,                   " +
							"        ISNULL(MAX(A.NETPR),               0) AS MERCURY_FOB,                        " +
							"        ISNULL(MAX(A.FFS_STENCIL_SHIPTO), '') AS FFS_STENCIL_SHIPTO,                 " +
							"        ISNULL(MAX(A.FFS_STENCIL_DEST),   '') AS FFS_STENCIL_DEST,                   " +
							"        ISNULL(MAX(A.FFS_STENCIL_ORIGIN), '') AS FFS_STENCIL_ORIGIN,                 " +
							"        ISNULL(MAX(A.WERKS),              '') AS WERKS,                              " +
							"        ISNULL(MAX(A.FFS_SHP_TO_ACCT),    '') AS FFS_SHP_TO_ACCT,                    " +
							"        ISNULL(MAX(A.J_4KSCAT),           '') AS J_4KSCAT,                           " +
							"        ISNULL(MAX(A.LINE),               '') AS LINE,                               " +
							"        ISNULL(MAX(A.GENDER_CD),          '') AS GENDER_CD,                          " +
							"        ISNULL(MAX(A.GENDER_NM),          '') AS GENDER_NM,                          " +
							"        ISNULL(MAX(A.SEASON),             '') AS SEASON                              " +
							"   FROM (                                                                            " +
							"          SELECT P.FFS_STENCIL_SHIPTO, P.FFS_STENCIL_DEST, P.FFS_STENCIL_ORIGIN,     " +
							"                 P.NETPR, P.MENGE, P.WERKS, P.FFS_SHP_TO_ACCT, P.J_4KSCAT,           " +
							"                 R.SUBCATEGORYNAME AS LINE,                                          " +					       
							"                 R.GENDERAGE AS GENDER_CD, R.GENDERAGENAME AS GENDER_NM,             " +
							"                 K.ZZSESN_CD+K.ZZSESN_YR AS SEASON                                   " +
							"            FROM EKPO P, MARA R, EKKO K                                              " +
							"           WHERE P.MATNR = R.MATNR                                                   " +
							"             AND P.EBELN = K.EBELN                                                   " +
							"             AND P.EBELN = '" + arg_po_no		                                 + "' " +
							"             AND P.EBELP = '" + arg_po_item		                             + "' " +
							"       ) A                                                                           " ;
			else
				sQUERY =
							" SELECT ISNULL(MAX(A.CARTONS),             0) AS MERCURY_CT_QTY,                     " +
							"        ISNULL(MAX(A.SHOE_QTY),            0) AS MERCURY_SHOE_QTY,                   " +
							"        ISNULL(MAX(A.NETPR),               0) AS MERCURY_FOB,                        " +
							"        ISNULL(MAX(A.FFS_STENCIL_SHIPTO), '') AS FFS_STENCIL_SHIPTO,                 " +
							"        ISNULL(MAX(A.FFS_STENCIL_DEST),   '') AS FFS_STENCIL_DEST,                   " +
							"        ISNULL(MAX(A.FFS_STENCIL_ORIGIN), '') AS FFS_STENCIL_ORIGIN,                 " +
							"        ISNULL(MAX(A.WERKS),              '') AS WERKS,                              " +
							"        ISNULL(MAX(A.FFS_SHP_TO_ACCT),    '') AS FFS_SHP_TO_ACCT,                    " +
							"        ISNULL(MAX(A.J_4KSCAT),           '') AS J_4KSCAT,                           " +
							"        ISNULL(MAX(A.LINE),               '') AS LINE,                               " +
							"        ISNULL(MAX(A.GENDER_CD),          '') AS GENDER_CD,                          " +
							"        ISNULL(MAX(A.GENDER_NM),          '') AS GENDER_NM,                          " +
							"        ISNULL(MAX(A.SEASON),             '') AS SEASON                              " +
							"   FROM (                                                                            " +
							"         SELECT H.CARTONS AS CARTONS,                                                " +
							"                D.TOTALQTY AS SHOE_QTY,                                              " +
							"                '' AS LINE,                                                          " +
							"                '' AS GENDER_CD,                                                     " +
							"                '' AS GENDER_NM,                                                     " +
							"                '' AS FFS_STENCIL_SHIPTO,                                            " +
							"                '' AS FFS_STENCIL_DEST,                                              " +
							"                '' AS FFS_STENCIL_ORIGIN,                                            " +
							"                0  AS NETPR,                                                         " +
							"                0  AS MENGE,                                                         " +
							"                '' AS WERKS,                                                         " +
							"                '' AS FFS_SHP_TO_ACCT,                                               " +
							"                '' AS J_4KSCAT,                                                      " +
							"                '' AS SEASON                                                         " +
							"           FROM RPTCIHEADER H,                                                       " +
							"                RPTCILINE   D,                                                       " +
							"                ( SELECT FACTORYCODE, PONUMBER, INVOICENO,                           " +
							"                         MAX(REPORTREQUEST) AS REPORTREQUEST                         " +
							"                    FROM RPTCILINE                                                   " +
							"                   WHERE FACTORYCODE    = '" + arg_factory	                     + "' " +
							"                     AND PONUMBER       = '" + arg_po_no	                     + "' " +
							"                     AND ITEMSEQ        = '" + arg_po_item		                 + "' " +
							"                     AND INVOICENO      = '" + arg_invoiceno		             + "' " +
							"                   GROUP BY FACTORYCODE, PONUMBER, INVOICENO ) R                     " +
							"          WHERE H.FACTORYCODE   = D.FACTORYCODE                                      " +
							"            AND H.PONUMBER      = D.PONUMBER                                         " +
							"            AND H.INVOICENO     = D.INVOICENO                                        " +
							"            AND H.REPORTREQUEST = D.REPORTREQUEST                                    " +
							"            AND D.FACTORYCODE   = R.FACTORYCODE                                      " +
							"            AND D.PONUMBER      = R.PONUMBER                                         " +
							"            AND D.INVOICENO     = R.INVOICENO                                        " +
							"            AND D.REPORTREQUEST = R.REPORTREQUEST                                    " +
							"          UNION ALL                                                                  " +
							"         SELECT 0 AS CARTONS, 0 AS SHOE_QTY, '' AS LINE,                             " +
							"                '' AS GENDER_CD, '' AS GENDER_NM,                                    " +
							"                P.FFS_STENCIL_SHIPTO, P.FFS_STENCIL_DEST, P.FFS_STENCIL_ORIGIN,      " +
							"                P.NETPR, P.MENGE, P.WERKS, P.FFS_SHP_TO_ACCT, P.J_4KSCAT,            " +
							"                K.ZZSESN_CD+K.ZZSESN_YR AS SEASON                                    " +
							"           FROM EKPO P, EKKO K                                                       " +
							"          WHERE P.EBELN = K.EBELN                                                    " +
					        "            AND P.EBELN = '" + arg_po_no		                                 + "' " +
							"            AND P.EBELP = '" + arg_po_item		                                 + "' " +
							"       ) A                                                                           " ;

			return sQUERY;

		}


	}
}