using System;

namespace FlexTrade.ClassLib
{
	/// <summary>
	/// ClassForm:  �޴��� �� ������ ���� Form�� ���� ����
	/// </summary>
	public class ClassForm
	{
		public ClassForm()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}
		/// <summary>
		/// �ش� ���� Type ���� Return
		/// </summary>
		/// <param name="arg_FormName"> ���� ���ӽ����̽�.�̸�</param>
		public Type TypeForm(string arg_FormName)
		{

			Type tp = Type.GetType( arg_FormName );
			return tp;
		
		}

	}
}
