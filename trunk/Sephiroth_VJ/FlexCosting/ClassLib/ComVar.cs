using System;
using System.Collections.Generic;
using System.Text;

namespace FlexCosting.ClassLib
{
    class ComVar : COM.ComVar
    {
        #region FlexCDC

        /// <summary>
        /// BOMLinkType : BOM ��ũ Ÿ��
        /// </summary>
        public const string BOMLinkType = "BOM_F";

        /// <summary>
        /// MenuClick_Flag : ���θ޴����� ȣ���ߴ��� ����
        /// </summary>
        public static bool MenuClick_Flag = false;


        /// <summary>
        /// Rout_Type : default ����� Ÿ�� 
        /// </summary> 
        public const string Rout_Type = "MAIN";

        /// <summary>
        /// FormClick_Flag : �ٸ����� ����, �Ķ���ͷ� �Ѱܼ� ���� �����ϰ��� �Ҷ�
        /// </summary>
        public static bool FormClick_Flag = false;

        /// <summary>
        /// RoutLinkType : ����� ��ũ Ÿ��
        /// </summary>
        public const string RoutLinkType = "ROUT";

        public static float addf_size_X = 1;
        public static float addf_size_Y = 1;

        #endregion


        #region Base

        public static System.Drawing.Color[] ClrCBDGubun = new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(251, 210, 251), System.Drawing.Color.WhiteSmoke, System.Drawing.Color.FromArgb(193, 209, 234)
        };

        #endregion


        #region Costing 

        public const string M_NEW = "New", M_EDIT = "Edit", M_CLEAR = "Clear", M_VIEW = "View", M_MODIFY = "Modify", M_CHANGE = "Change"; 

        #endregion


        #region Security


        #endregion


        #region Basic


        #endregion


        #region Management


        #endregion


        #region Report


        #endregion
    }
}
