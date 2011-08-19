using System;

namespace ERP.ClassLib
{

    #region �ʱ�ȭ��


    /// <summary>
    /// TBSPS_NOTICE : [Event] ���� ����
    /// </summary>
    public enum TBSPS_NOTICE_HOME : int
    {

        IxFACTORY = 0,
        IxSEQ = 1,
        IxTITLE = 2,
        IxSYMD = 3,


    }




    /// <summary>
    /// TBSPS_NOTICE_USER_HOME : [On Air]
    /// </summary>
    public enum TBSPS_NOTICE_USER_HOME : int
    {

        IxFACTORY = 0,
        IxDIVISION = 1,
        IxSEQ = 2,
        IxSUSER_NAME = 3,
        IxTITLE = 4,
        IxUPD_YMD = 5,

    }




    /// <summary>
    /// TBSPS_WORKINFO_USER_HOME : [Please, Do it] ����� ���� ����
    /// </summary>
    public enum TBSPS_WORKINFO_USER_HOME : int
    {

        IxFACTORY = 0,
        IxSEQ = 1,
        IxJOB_CD = 2,
        IxREAD_YN = 3,
        IxTITLE = 4,
        IxUPD_YMD = 5,
        IxRUSER_ID = 6,

    }



    /// <summary>
    /// TBSPS_NOTICE_INGWORK_HOME : [Notices] ������ ����
    /// </summary>
    public enum TBSPS_NOTICE_INGWORK_HOME : int
    {

        IxFACTORY = 0,
        IxSEQ = 1,
        IxEDATE = 2,
        IxJOB_CD = 3,
        IxSUSER_NAME = 4,
        IxTITLE = 5,
        IxUPD_YMD = 6,

    }



    #endregion

    #region �ʱ�ȭ�� ����


    /// <summary> 
    /// TBSPS_NOTICE ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSPS_NOTICE : int
    {
        IxMaxCt = 10,
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxSEQ = 2,
        IxUSER_ID = 3,
        IxUSER_NAME = 4,
        IxTITLE = 5,
        IxSDATE = 6,
        IxEDATE = 7,
        IxUPD_USER = 8,
        IxUPD_YMD = 9

    }


    /// <summary> 
    /// TBSPS_NOTICE_USER ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSPS_NOTICE_USER : int
    {
        IxMaxCt = 12,
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxDIV = 2,
        IxSEQ = 3,
        IxSUSER_ID = 4,
        IxSUSER_NAME = 5,
        IxRUSER_ID = 6,
        IxRUSER_NAME = 7,
        IxTITLE = 8,
        IxREAD_YN = 9,
        IxUPD_USER = 10,
        IxUPD_YMD = 11
    }


    /// <summary> 
    /// TBSPS_NOTICE_USERLIST ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSPS_NOTICE_USERLIST : int
    {
        IxMaxCt = 8,
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxUSER_ID = 2,
        IxUSER_GRP = 3,
        IxUSER_LIST = 4,
        IxREMARKS = 5,
        IxUPD_USER = 6,
        IxUPD_YMD = 7

    }


    /// <summary> 
    /// TBSPS_NOTICE_WORK1  ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSPS_NOTICE_WORK1 : int
    {
        IxMaxCt = 7,
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxUSER_ID = 2,
        IxPG_ID = 3,
        IxSEQ = 4,
        IxWORK_EVENT = 5,
        IxWORK_DESC = 6
    }


    /// <summary> 
    /// SPS_WORKINFO  ���̺� �ε��� Class 
    /// </summary> 
    public enum SPS_WORKINFO : int
    {
        IxDBFACTORY = 0,
        IxDBJOB_CD = 1,
        IxDBREGIST_ID = 2,
        IxDBEVENT_ID = 3,
        IxDBEVENT_DESC = 4,
        IxDBUSE_YN = 5,
        IxDBOPEN_YN = 6,
        IxDBREMARKS = 7,



        IxGRDIVISION = 0,
        IxGRFACTORY = 1,
        IxGRJOB_CD = 2,
        IxGRREGIST_ID = 3,
        IxGREVENT_ID = 4,
        IxGREVENT_DESC = 5,
        IxGRUSE_YN = 6,
        IxGROPEN_YN = 7,
        IxGRREMARKS = 8,
    }




    /// <summary> 
    /// TBSPS_NOTICE_INGWORK  ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSPS_NOTICE_INGWORK : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxDiV = 2,
        IxSEQ = 3,
        IxEDATE = 4,
        IxJOB_CD = 5,
        IxSUSER_ID = 6,
        IxSUSER_NAME = 7,
        IxRUSER_ID = 8,
        IxRUSER_NAME = 9,
        IxTITLE = 10,
        IxMESSAGE = 11,
        IxUPD_USER = 12,
        IxUPD_YMD = 13
    }



    /// <summary> 
    /// SPS_WORKINFO_USER  ���̺� �ε��� Class 
    /// </summary> 
    public enum SPS_WORKINFO_USER : int
    {
        IxDBFACTORY = 0,
        IxDBSEQ = 1,
        IxDBJOB_CD = 2,
        IxDBREAD_YN = 3,
        IxDBTITLE = 4,
        IxDBUPD_YMD = 5,
        IxDBRUSER_ID = 6,

        IxGRDIVISION = 0,
        IxGRFACTORY = 1,
        IxGRSEQ = 2,
        IxGRJOB_CD = 3,
        IxGRREAD_YN = 4,
        IxGRTITLE = 5,
        IxGRUPD_YMD = 6,
        IxGRRUSER_ID = 7,
    }



    /// <summary>
    /// TBSPS_WORKINFO_RUSER : [Please, Do it] Receive ����� ����Ʈ ��ȸ
    /// </summary>
    public enum TBSPS_WORKINFO_RUSER : int
    {

        IxFACTORY = 1,
        IxUSER_ID = 2,
        IxUSER_NAME1 = 3,
        IxDEPT_CD = 4,

    }



    /// <summary>
    /// TBSPS_NOTICE_USER_HOME : [On Air]
    /// </summary>
    public enum TBSPS_AUTO_INFO_HOME : int
    {

        IxFACTORY = 0,
        IxSEQ = 1,
        IxCONTENTS = 2,
        IxREMARKS = 3,
        IxUPD_USER = 4,
        IxUPD_YMD = 5,

    }



    /// <summary> 
    /// SPC_FILE_UPLOAD  ���̺� �ε��� Class 
    /// </summary> 
    public enum SPC_FILE_UPLOAD : int
    {
        IxMaxCt = 7,
        IxDIVISION = 0,
        IxSEQ = 1,
        IxPROGRAM_NAME = 2,
        IxVERSION = 3,
        IxFILE_SIZE = 4,
        IxDIR = 5,
        IxREGIST = 6,
    }




    
    #endregion

    #region ��������

    /// <summary> 
    /// SPC_CODE ���̺� �ε��� Enum 
    /// </summary> 
    public enum TBSCM_CODE : int
    {
        IxMaxCt = 16,		// �ε��� Count 
        IxFACTORY = 1,			// ����	:VARCHAR2(5) 
        IxCOM_CD = 2,			// ���� �ڵ�	:VARCHAR2(10) 
        IxCOM_SEQ = 3,			// �ڵ� �Ϸù�ȣ	:NUMBER(22) 
        IxCOM_NAME = 4,			// �ڵ��	:VARCHAR2(60) 
        IxSYSTEM_YN = 5,			// �ý��� �ڵ� ����	:VARCHAR2(1) 
        IxCOM_VALUE1 = 6,			// �ڵ尪 1	:VARCHAR2(20) 
        IxCOM_DESC1 = 7,			// �ڵ� ���� 1	:VARCHAR2(50) 
        IxCOM_VALUE2 = 8,			// �ڵ尪 2	:VARCHAR2(20) 
        IxCOM_DESC2 = 9,			// �ڵ� ���� 2	:VARCHAR2(50) 
        IxCOM_VALUE3 = 10,			// �ڵ尪 3	:VARCHAR2(20) 
        IxCOM_DESC3 = 11,			// �ڵ� ���� 3	:VARCHAR2(50) 
        IxCOM_VALUE4 = 12,			// �ڵ尪 4	:VARCHAR2(20) 
        IxCOM_DESC4 = 13,			// �ڵ� ���� 4	:VARCHAR2(50) 
        IxREMARKS = 14,			// ���	:VARCHAR2(100) 
        IxUPD_USER = 15,			// �ۼ���	:VARCHAR2(10) 
        IxUPD_YMD = 16,			// �ۼ�����	:DATE(7) 
    }


    /// <summary> 
    /// TBSPC_DATA_DIC ���̺� �ε��� Enum 
    /// </summary> 
    public enum TBSPC_DATA_DIC : int
    {
        IxMaxCt = 15,		// �ε��� Count
        IxDIVISION = 0,
        IxFACTORY = 1,			// �����ڵ�							:VARCHAR2(5) 
        IxLAN_CD = 2,			// ����ڵ�							:VARCHAR2(5)
        IxPG_PROJ = 3,			// �Ҽ� ������Ʈ					:VARCHAR2(20) 
        IxPG_ID = 4,			// ���α׷� ���̵� (���̸�)			:VARCHAR2(20) 
        IxCTL_NAME = 5,			// ��Ʈ�Ѹ�							:VARCHAR2(20) 
        IxSTD_TEXT = 6,			// ǥ��ĸ�� (�����ؽ�Ʈ)			:VARCHAR2(20) 
        IxSTD_TOOLTIP = 7,			// ǥ�� ���� (���� ����)			:VARCHAR2(60) 
        IxLAN_TEXT = 8,			// ����ڵ�ĸ�� (�ٲ� �ؽ�Ʈ)		:VARCHAR2(20) 
        IxLAN_TOOLTIP = 9,			// ����ڵ����� (�ٲ� ����)			:VARCHAR2(60) 
        IxFORECOLOR = 10,		// ���ڻ�							:VARCHAR2(10) 
        IxLABEL_TYPE = 11,		// ���̺� Ÿ�� (��Ʈ�Ѹ� ����κ�)	:VARCHAR2(20) 
        IxLABEL_LEN = 12,		// ���̺� ���� (�ڰ�)				:VARCHAR2(10) 
        IxREMARKS = 13,		// ���								:VARCHAR2(100) 
        IxUPD_USER = 14,		// �ۼ���							:VARCHAR2(10) 
        IxUPD_YMD = 15,		// �ۼ�����							:DATE
    }



    /// <summary> 
    /// SPS_MENU ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSPC_MENU_ROLE : int
    {

        IxMENU_GROUP = 0,
        IxMENU_KEY = 1,
        IxPARENT_MENU_KEY = 2,
        IxMENU_TYPE = 3,
        IxMENU_PG = 4,
        IxMENU_TEXT = 5,
        IxUSE_YN = 6,
        IxTB_NONE_YN = 7,
        IxTB_ALL_YN = 8,
        IxTB_SEARCH_YN = 9,
        IxTB_SAVE_YN = 10,
        IxTB_PRINT_YN = 11,
        IxROLE_ID = 12,


    }


    /// <summary> 
    /// SCM_TABLE ���̺� �ε��� Enum 
    /// </summary> 
    public enum TBSCM_TABLE : int
    {
        IxMaxCt = 31,		// �ε��� Count 
        IxPG_ID = 1,			// ���α׷� ���̵�	:VARCHAR2(20) 
        IxPG_SEQ = 2,			// ���α׷� SEQ	:NUMBER(22) 
        IxCOL_NAME = 3,			// �÷��� (����ʵ��)	:VARCHAR2(20) 
        IxCOL_ORDER = 4,			// �÷� ���� (ǥ�ü���)	:NUMBER(22) 
        IxTABLE_NAME = 5,			// ���̺��	:VARCHAR2(20) 
        IxHEAD_DESC1 = 6,			// �����(1)	:VARCHAR2(100) 
        IxHEAD_DESC2 = 7,			// �����(2)	:VARCHAR2(100) 
        IxHEAD_DESC3 = 8,			// �����(3)	:VARCHAR2(100) 
        IxHEAD_DESC4 = 9,			// �����(4)	:VARCHAR2(100) 
        IxLAN_HEAD_DESC1 = 10,			// ��� �����(1)	:VARCHAR2(100) 
        IxLAN_HEAD_DESC2 = 11,			// ��� �����(2)	:VARCHAR2(100) 
        IxLAN_HEAD_DESC3 = 12,			// ��� �����(3)	:VARCHAR2(100) 
        IxLAN_HEAD_DESC4 = 13,			// ��� �����(4)	:VARCHAR2(100) 
        IxWIDTH = 14,			// �÷� �ʺ�	:NUMBER(22) 
        IxLOCK_YN = 15,			// ����Ʈ ���� ����	:VARCHAR2(1) 
        IxVISIBLE_YN = 16,			// VISIBLE ����	:VARCHAR2(1) 
        IxAUTOSORT_YN = 17,			// �ڵ���Ʈ ����	:VARCHAR2(1) 
        IxHALIGN = 18,			// ���� ����	:VARCHAR2(10) 
        IxVALIGN = 19,			// ���� ����	:VARCHAR2(10) 
        IxMAXROW = 20,			// �ִ� �� �� : ó�� ǥ�õ� �� �������� ��� ����	:NUMBER(22) 
        IxFROZENCOL = 21,			// FROZEN COLUMN	:NUMBER(22) 
        IxFROZENROW = 22,			// FROZEN ROW	:NUMBER(22) 
        IxBACKCOLOR = 23,			// ����	:VARCHAR2(10) 
        IxFORECOLOR = 24,			// ���ڻ�	:VARCHAR2(10) 
        IxCELLTYPE = 25,			// ��Ÿ��	:VARCHAR2(10) 
        IxDATA_LIST_TYPE = 26,			// ��Ÿ���� �޺��ڽ��϶� �����ڵ� �Ǵ� ���� �̿� ���� ���� (�����ڵ� : 0, ���� : 1)	:VARCHAR2(1) 
        IxDATA_LIST_CD = 27,			// DATA_LIST_TYPE = 0 �϶� �����ڵ� ����	:VARCHAR2(10) 
        IxDATA_LIST_QUERY = 28,			// DATA_LIST_TYPE = 1 �϶� ���� ����	:VARCHAR2(500) 
        IxREMARKS = 29,			// ���	:VARCHAR2(100) 
        IxUPD_USER = 30,			// �ۼ���	:VARCHAR2(10) 
        IxUPD_YMD = 31,			// �ۼ�����	:DATE(7) 
    }



    /// <summary> 
    /// SPB_FACTORY ���̺� �ε��� Enum 
    /// </summary> 
    public enum TBSCM_FACTORY : int
    {
        IxMaxCt = 7,		// �ε��� Count 
        IxFACTORY = 1,			// �����ڵ�	:VARCHAR2(5) 
        IxFACTORY_NAME = 2,			// �����	:VARCHAR2(20) 
        IxADDRESS = 3,			// �ּ���	:VARCHAR2(60) 
        IxCAL_TYPE = 4,			// ��ǥ ī���� Ÿ��	:VARCHAR2(10) 
        IxUSE_YN = 5,
        IxREMARKS = 6,			// ���	:VARCHAR2(100) 
        IxUPD_USER = 7,			// �ۼ���	:VARCHAR2(10) 
        IxUPD_YMD = 8,			// �ۼ�����	:DATE(7) 
    }




    #endregion

    #region �޴�



    public enum TBSPS_USER : int
    {
        IxFACTORY = 0,
        IxUSER_ID = 1,
        IxPASSWD = 2,
        IxUSE_YN = 3,
        IxADMIN_YN = 4,
        IxLANG_CD = 6,
        IxJOB_CD = 7,
        IxUSER_NAME1 = 8,
        IxUSER_NAME2 = 9,
        IxLINE_CD = 10,
        IxDEPT_CD = 11,
        IxPOWERUSER_YN = 12,
        IxCDC_POWERLEVEL = 13,
        IxCDC_CDCGROUP_CD = 14,
        IxINSA_CD = 15,

    }  



    /// <summary>
    /// TBSCM_MENU_MAIN : 
    /// </summary>
    public enum TBSCM_MENU_MAIN : int
    {

        IxDIVISION              =  0,
        IxMENU_LEVEL            =  1,
        IxFACTORY               =  2,
        IxLANG_CD               =  3,
        IxMENU_KEY              =  4,
        IxPARENT_MENU_KEY       =  5,
        IxMENU_TYPE             =  6,
        IxMENU_TEXT             =  7,
        IxMENU_PG               =  8,
        IxMENU_ORD              =  9,
        IxUSE_YN                = 10,
        IxTB_NONE_YN            = 11,
        IxTB_ALL_YN             = 12,
        IxTB_SEARCH_YN          = 13,
        IxTB_SAVE_YN            = 14,
        IxTB_PRINT_YN           = 15,
        IxPERSION_IN_CHARGE     = 16,
        IxREMARKS               = 17,
        IxMENU_ORD_BEFORE       = 18,
        IxUPD_USER              = 19,
        IxUPD_YMD               = 20,



    }


         /// <summary>
    /// TBSCM_DATA_DIC_MENU : 
    /// </summary>
    public enum TBSCM_DATA_DIC_MENU : int
    {

        IxFACTORY               = 1,
        IxLANG_CD               = 2,
        IxPG_PROJ               = 3,
        IxPG_ID                 = 4,
        IxPG_TITLE              = 5,


    }



    /// <summary> 
    /// SCM_MENU_ROLE ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSCM_MENU_ROLE : int
    {

        IxDIVISION              =  0,
        IxMENU_LEVEL            =  1,
        IxFACTORY               =  2,
        IxLANG_CD               =  3,
        IxMENU_KEY              =  4,
        IxPARENT_MENU_KEY       =  5,
        IxMENU_TYPE             =  6,
        IxMENU_TEXT             =  7,
        IxMENU_PG               =  8,
        IxMENU_ORD              =  9,
        IxUSE_YN                = 10,
        IxTB_NONE_YN            = 11,
        IxTB_ALL_YN             = 12,
        IxTB_SEARCH_YN          = 13,
        IxTB_SAVE_YN            = 14,
        IxTB_PRINT_YN           = 15,
        IxPERSION_IN_CHARGE     = 16,
        IxREMARKS               = 17,
        IxMENU_ORD_BEFORE       = 18,
        IxROLE_ID               = 19,
        IxROLE_NAME             = 20,
        IxUPD_USER              = 21,
        IxUPD_YMD               = 22,


    }




    /// <summary> 
    /// TBSCM_MENU_USER_MASTER ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSCM_MENU_USER_MASTER : int
    {

        IxDIVISION              =  0,
        IxUSER_ID               =  1,
        IxFACTORY               =  2,
        IxLANG_CD               =  3,
        IxROLE_ID               =  4,
        IxUSE_YN                =  5,
        IxADMIN_YN              =  6,
        IxPOWERUSER_YN          =  7,
        IxCDCPOWER_LEVEL        =  8,
        IxCDCGROUP_CD           =  9,
        IxREMARKS               = 10,
        IxUPD_USER              = 11,
        IxUPD_YMD               = 12,


    }


    

    /// <summary> 
    /// TBSCM_MENU_USER ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSCM_MENU_USER : int
    {

        IxDIVISION              =  0,
        IxMENU_LEVEL            =  1,
        IxFACTORY               =  2,
        IxUSER_ID               =  3,
        IxROLE_ID               =  4,
        IxLANG_CD               =  5,
        IxMENU_KEY              =  6,
        IxPARENT_MENU_KEY       =  7,
        IxMENU_TYPE             =  8,
        IxMENU_TEXT             =  9,
        IxMENU_PG               = 10,
        IxMENU_ORD              = 11,
        IxUSE_YN                = 12,
        IxTB_NONE_YN            = 13,
        IxTB_ALL_YN             = 14,
        IxTB_SEARCH_YN          = 15,
        IxTB_SAVE_YN            = 16,
        IxTB_PRINT_YN           = 17,
        IxPERSION_IN_CHARGE     = 18,
        IxREMARKS               = 19,
        IxUPD_USER              = 20,
        IxUPD_YMD               = 21,


    }



    #endregion


}
