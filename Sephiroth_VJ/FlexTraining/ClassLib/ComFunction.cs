using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
using System.Data.OleDb;
using Microsoft.Office.Core;


namespace FlexTraining.ClassLib
{
	/// <summary>
	/// Common_Function�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ComFunction : COM.ComFunction
	{
		public ComFunction()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
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
			return Application.StartupPath +"\\Report\\Training\\" + arg_FormName + ".mrd";
		}

		public static  DataTable CREATE_REPORT_REQUEST_KEY(string arg_Report_Job_Name)
		{
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE��
			MyOraDB.Process_Name = "PKG_STM_REPORT.CREATE_REPORT_REQUEST_KEY";

			//02.ARGURMENT ��
			MyOraDB.Parameter_Name[0]  = "ARG_JOB_NAME";
			MyOraDB.Parameter_Name[1]  = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE ����
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA ����
			MyOraDB.Parameter_Values[0]   = arg_Report_Job_Name;
			MyOraDB.Parameter_Values[1]   = COM.ComVar.This_User;
			MyOraDB.Parameter_Values[2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];

		}

		public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt)
		{
			if (arg_cmb != null)
			{
				for (int i =0; i < arg_cmb.Length; i++)
				{
					if (arg_cmb[i].SelectedIndex < 0)
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_cmb[i].Focus(); 
						return false;
					}
				}
			}
			if (arg_txt != null)
			{
				for (int i =0; i < arg_txt.Length; i++)
				{
					if (arg_txt[i].Text == "")
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_txt[i].Focus(); 
						return false;
					}
				}
			}
			return true; 
		}
	}
}