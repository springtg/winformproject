using System;

namespace ERP
{
	/// <summary>
	/// ClassErp�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ClassErp
	{
		public ClassErp()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}
	}


	/// <summary>
	/// MyItem :�޴� �׸� ���� ���� Class
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
