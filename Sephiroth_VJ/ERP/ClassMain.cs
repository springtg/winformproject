using System;
using System.IO;
using System.Windows.Forms;

namespace ERP
{
	/// <summary>
	/// Class_Main�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ClassMain
	{
		public ClassMain()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		} 

		/// <summary>
		/// �ش� ���� ���α׷��� �� �������Դϴ�.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			#region �ܺο��� ������ ���� �˾� ����

			try
			{
				string fullname = Application.StartupPath + @"\webservice.path";
				FileStream file = new FileStream(fullname, FileMode.Open, FileAccess.Read);
				StreamReader sr = new StreamReader(file);

				string NextLine;
				string div = ";";

				while((NextLine = sr.ReadLine()) != null)
				{

					string[] Service = NextLine.Split(div.ToCharArray());

					if(Service[0] == "_WebSvc")
					{
						COM.ComVar._WebSvc.Url = Service[1];
						COM.ComVar._WebSvc.Timeout = 60*60*1000;
					}
					// dblink ����ϴ� ���, �ӵ� ������ ���ؼ�,
					// ������ �ּҸ� �ٲ㼭 �ٷ� �ش� ���� ��� �����ϵ��� ó��
					else if(Service[0] == "DS_WebSvc")
					{
						COM.ComVar.DS_WebSvc_Url = Service[1];
					}
					else if(Service[0] == "QD_WebSvc")
					{
						COM.ComVar.QD_WebSvc_Url = Service[1];
					}
					else if(Service[0] == "VJ_WebSvc")
					{
						COM.ComVar.VJ_WebSvc_Url = Service[1];
                    }
                    else if (Service[0] == "JJ_WebSvc")
                    {
                        COM.ComVar.JJ_WebSvc_Url = Service[1];
                    }
                    else if (Service[0] == "EIS_WebSvc")
                    {
                        COM.ComVar.EIS_WebSvc_Url = Service[1];
                    }


				}

				sr.Close();
				file.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Read Webservice URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			#endregion            
             
            //Application.EnableVisualStyles();					 
			ClassMain start = new ClassMain();

			do
			{
                COM.ComVar._LoginOK = false;

                if (COM.ComVar._CloseFlg.Equals(true))
                    return;

				ERP.LoginWnd login = new ERP.LoginWnd(); 
				login.ShowDialog();                

				if(COM.ComVar._LoginOK)
				{ 
					ERP.MainWnd main = new ERP.MainWnd(); 
					main.ShowDialog();
				}
				else
				{
					return;
				}


			}
			while(true);
		}
	}
}
