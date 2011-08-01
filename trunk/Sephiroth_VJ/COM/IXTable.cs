using System;
using System.Drawing;

namespace COM
{


    /// <summary> 
    /// SCM_TABLE ���̺� �ε��� Enum 
    /// </summary> 
    public enum TBSCM_TABLE : int
    {
        IxMaxCt = 31,		// �ε��� Count 
        IxPG_ID = 0,			// ���α׷� ���̵�	:VARCHAR2(20) 
        IxPG_SEQ = 1,			// ���α׷� SEQ	:NUMBER(22) 
        IxCOL_NAME = 2,			// �÷��� (����ʵ��)	:VARCHAR2(20) 
        IxCOL_ORDER = 3,			// �÷� ���� (ǥ�ü���)	:NUMBER(22) 
        IxTABLE_NAME = 4,			// ���̺��	:VARCHAR2(20) 
        IxHEAD_DESC1 = 5,			// �����(1)	:VARCHAR2(100) 
        IxHEAD_DESC2 = 6,			// �����(2)	:VARCHAR2(100) 
        IxHEAD_DESC3 = 7,			// �����(3)	:VARCHAR2(100) 
        IxHEAD_DESC4 = 8,			// �����(4)	:VARCHAR2(100) 
        IxLAN_HEAD_DESC1 = 9,			// ��� �����(1)	:VARCHAR2(100) 
        IxLAN_HEAD_DESC2 = 10,			// ��� �����(2)	:VARCHAR2(100) 
        IxLAN_HEAD_DESC3 = 11,			// ��� �����(3)	:VARCHAR2(100) 
        IxLAN_HEAD_DESC4 = 12,			// ��� �����(4)	:VARCHAR2(100) 
        IxWIDTH = 13,			// �÷� �ʺ�	:NUMBER(22) 
        IxLOCK_YN = 14,			// ����Ʈ ���� ����	:VARCHAR2(1) 
        IxVISIBLE_YN = 15,			// VISIBLE ����	:VARCHAR2(1) 
        IxAUTOSORT_YN = 16,			// �ڵ���Ʈ ����	:VARCHAR2(1) 
        IxHALIGN = 17,			// ���� ����	:VARCHAR2(10) 
        IxVALIGN = 18,			// ���� ����	:VARCHAR2(10) 
        IxMAXROW = 19,			// �ִ� �� �� : ó�� ǥ�õ� �� �������� ��� ����	:NUMBER(22) 
        IxFROZENCOL = 20,			// FROZEN COLUMN	:NUMBER(22) 
        IxFROZENROW = 21,			// FROZEN ROW	:NUMBER(22) 
        IxBACKCOLOR = 22,			// ����	:VARCHAR2(10) 
        IxFORECOLOR = 23,			// ���ڻ�	:VARCHAR2(10) 
        IxCELLTYPE = 24,			// ��Ÿ��	:VARCHAR2(10) 
        IxDATA_LIST_TYPE = 25,			// ��Ÿ���� �޺��ڽ��϶� �����ڵ� �Ǵ� ���� �̿� ���� ���� (�����ڵ� : 0, ���� : 1)	:VARCHAR2(1) 
        IxDATA_LIST_CD = 26,			// DATA_LIST_TYPE = 0 �϶� �����ڵ� ����	:VARCHAR2(10) 
        IxDATA_LIST_QUERY = 27,			// DATA_LIST_TYPE = 1 �϶� ���� ����	:VARCHAR2(500) 
        //������ �߰�
        IxESSENTIAL_YN = 28,
        IxCHAR_CASE = 29,
        IxMAX_NUMBER = 30,
        IxMIN_NUMBER = 31,
        IxMAX_WIDTH = 32,
        IxREMARKS = 33,			// ���	:VARCHAR2(100) 
        IxUPD_USER = 34,			// �ۼ���	:VARCHAR2(10) 
        IxUPD_YMD = 35,			// �ۼ�����	:DATE(7) 
    }

    /// <summary> 
    /// SPC_CODE ���̺� �ε��� Enum 
    /// </summary> 
    public enum TBSCM_CODE : int
    {
        IxCOM_NAME = 0,			// �ڵ��	:VARCHAR2(60)  
        IxCOM_VALUE1 = 1,			// �ڵ尪 1	:VARCHAR2(20) 
        IxCOM_DESC1 = 2,			// �ڵ� ���� 1	:VARCHAR2(50) 
        IxCOM_VALUE2 = 3,			// �ڵ尪 2	:VARCHAR2(20) 
        IxCOM_DESC2 = 4,			// �ڵ� ���� 2	:VARCHAR2(50) 
        IxCOM_VALUE3 = 5,			// �ڵ尪 3	:VARCHAR2(20) 
        IxCOM_DESC3 = 6,			// �ڵ� ���� 3	:VARCHAR2(50) 
        IxCOM_VALUE4 = 7,			// �ڵ尪 4	:VARCHAR2(20) 
        IxCOM_DESC4 = 8,			// �ڵ� ���� 4	:VARCHAR2(50) 
        IxREMARKS = 9,			// ���	:VARCHAR2(100)  
    }


    /// <summary> 
    /// SPC_CODE ���̺� �ε��� Enum 
    /// </summary> 
    public enum TBSCM_CODE_TABLE : int
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
    /// TBSPC_PROC_PROG  ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSPC_PROC_PROG : int
    {
        IxMaxCt = 10,
        IxDIVISION = 0,
        IxRUN = 1,
        IxPROC_NAME = 2,
        IxPROC_VALUE = 3,
        IxTARGET_NAME = 4,
        IxTARGET_NAME1 = 5,
        IxTARGET_NAME2 = 6,
        IxTARGET_NAME3 = 7,
        IxTARGET_NAME4 = 8,
        IxSTATUS = 9,
    }



    /// <summary> 
    /// TBSPM_ERR  ���̺� �ε��� Class 
    /// </summary> 
    public enum TBSPM_ERR : int
    {
        IxMaxCt = 13,
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxERR_YMD = 2,
        IxSP_NAME = 3,
        IxJOB_CD = 4,
        IxFROM_NAME = 5,
        IxERR_DIV = 6,
        IxERR_NUM = 7,
        IxERR_MSG = 8,
        IxUSR_MSG = 9,
        IxUPD_USER = 10,
        IxUPD_YMD = 11,
        IxTemp = 12,
        IxTemp_User = 13,
    }



}
