using System;
using System.IO;
using System.Windows.Forms;

namespace ERP
{
	/// <summary>
	/// Class_Main에 대한 요약 설명입니다.
	/// </summary>
	public class ClassMain
	{
		public ClassMain()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		} 

		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			#region 외부에서 웹서비스 정보 알아 오기

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
					// dblink 사용하는 경우, 속도 문제로 인해서,
					// 웹서비스 주소를 바꿔서 바로 해당 공장 디비에 접속하도록 처리
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
