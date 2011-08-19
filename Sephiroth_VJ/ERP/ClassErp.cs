using System;

namespace ERP
{
	/// <summary>
	/// ClassErp에 대한 요약 설명입니다.
	/// </summary>
	public class ClassErp
	{
		public ClassErp()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}
	}


	/// <summary>
	/// MyItem :메뉴 항목 정보 설정 Class
	/// </summary>
	public class MyItem : System.Windows.Forms.MenuItem
	{
		 

		public string PrjName;
		public string FormName;
		
		public MyItem(string arg_ItemName,string arg_PrjName,string arg_FormName)
		{
			
			this.Text= arg_ItemName;
			this.PrjName = arg_PrjName;
			this.FormName= arg_FormName;

		}








//		public string _MenuKey;
//		public string _Parent_MenuKey;
//		public string _MenuText;
//		public string _MenuPG;
//		public string _RoleID;
//
//
//
//		public MyItem(string arg_menukey, 
//			          string arg_parent_menukey, 
//			          string arg_menutext, 
//			          string arg_menupg, 
//			          string arg_roleid)
//		{
//			this.Text = arg_menutext;
//
//			this._MenuKey = arg_menukey;
//			this._Parent_MenuKey = arg_parent_menukey;
//			this._MenuText = arg_menutext;
//			this._MenuPG = arg_menupg;
//			this._RoleID = arg_roleid;
//
//		} 




	}
}
