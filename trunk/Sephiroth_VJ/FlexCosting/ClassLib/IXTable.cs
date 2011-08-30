using System;
using System.Collections.Generic;
using System.Text;

namespace FlexCosting.ClassLib
{

    #region Security


    #endregion


    #region Basic

    public enum TBSXF_CBD_M_FXRATE : int
    {
        IxMaxCt = 11,	        // ¿Œµ¶Ω∫ Count
        IxSEASON_NAME = 1, 	    //   : ()
        IxCURR_NAME = 2, 	    //   : ()
        IxCOUNTRY_NAME = 3,     //   : ()
        IxFX_RATE = 4, 	        //   : ()
        IxSTATUS = 5, 	        //   : ()
        IxAPP_DATE = 6, 	    //   : ()
        IxFACTORY = 7, 	        //   : ()
        IxSEASON_CD = 8, 	    //   : ()
        IxCURR_CD = 9, 	        //   : ()
        IxUPD_USER = 10, 	    //   : ()
        IxUPD_YMD = 11 	        //   : ()
    }


    public enum TBSXD_SRF_M_MAT_04 : int
    {
        IxMaxCt = 19,	        // ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	        // Factory : VARCHAR2(5)
        IxDIV = 2, 	            // Div : ()
        IxCBD_CLASS = 3, 	    // Class : ()
        IxSUB_CLASS = 4, 	    // Sub Class : ()
        IxSIZE_EXC = 5, 	    // EXC : ()
        IxMAT_CD = 6, 	        // Code : VARCHAR2(50)
        IxMAT_NAME = 7, 	    // Material : VARCHAR2(1024)
        IxUOM = 8, 	            // UOM : ()
        IxFRT_TRM = 9, 	        // FRT TRM : ()
        IxPCC_LENGTH = 10, 	    // Length : NUMBER(22)
        IxPCC_LENGTHUOM = 11, 	// Lengthuom : VARCHAR2(50)
        IxPCC_WIDTH = 12, 	    // Width : NUMBER(22)
        IxPCC_WIDTHUOM = 13, 	// Widthuom : VARCHAR2(50)
        IxCBD_CURRENCY = 14, 	// Currency : VARCHAR2(10)
        IxCBD_PRICE = 15, 	    // Price : NUMBER(22)
        IxVENDOR_DESC = 16, 	// Vendor : ()
        IxVEN_SEQ = 17, 	    // Vendor : VARCHAR2(50)
        IxUPD_USER = 18, 	    // User : VARCHAR2(30)
        IxUPD_YMD = 19 	        // Date : DATE(7)
    }

    public enum TBSFB_NIKE_STD_DEFECTIVE_RATE_HEAD : int
    {
        IxMaxCt = 4,	        // ¿Œµ¶Ω∫ Count
        IxNO = 1, 	            // No : ()
        IxFACTORY = 2, 	        // Factory : ()
        IxAPPLIED_DATE = 3, 	// Applied date : ()
        IxCONTENTS = 4 	        // Contents : ()
    }

    public enum TBSFB_NIKE_STD_DEFECTIVE_RATE_TAIL : int
    {
        IxMaxCt = 12,	        // ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	        // Factory : ()
        IxAPP_DATE = 2, 	    // App Date : ()
        IxCONTENTS = 3, 	    // Contents : ()
        IxDIV = 4, 	            // Div : ()
        IxBOTTOM_KEY = 5, 	    // Bottom Key : ()
        IxBOTTOM_TYPE = 6, 	    // Bottom Type : ()
        IxMATERIAL_LOSS = 7, 	// Material Loss : ()
        IxMAT_LOSS_TYPE = 8, 	// Loss Type : ()
        IxDEFECTIVE_LOSS = 9, 	// Defective Loss : ()
        IxDEF_LOSS_TYPE = 10, 	// Loss Type : ()
        IxUPDATE_USER = 11, 	// Update user : ()
        IxUPDATE_YMD = 12 	    // Update Date : ()
    }

    public enum TBSFB_CBD_B_PTN_MATRIX_PART : int
    {
        IxMaxCt = 4,	        // ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	        // Factory : VARCHAR2(5)
        IxPART_SEQ = 2, 	    // Pare Seq : VARCHAR2(6)
        IxPART_TYPE = 3, 	    // Part Type : VARCHAR2(10)
        IxPART_DESC = 4 	    // Description : ()
    }

    public enum TBSFB_CBD_B_PTN_MATRIX_REL : int
    {
        IxMaxCt = 11,	        // ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	        //   : VARCHAR2(5)
        IxPART_SEQ = 2, 	    //   : VARCHAR2(6)
        IxPART_TYPE = 3, 	    //   : VARCHAR2(10)
        IxPART_CLASS = 4, 	    //   : VARCHAR2(10)
        IxPART_NAME = 5, 	    //   : VARCHAR2(200)
        IxPATT_SEQ = 6, 	    //   : ()
        IxPRO_PATT_SEQ = 7, 	//   : VARCHAR2(10)
        IxPRO_PATT_NAME = 8, 	//   : VARCHAR2(200)
        IxUSE_YN = 9, 	        //   : VARCHAR2(1)
        IxUPD_USER = 10, 	    //   : VARCHAR2(30)
        IxUPD_YMD = 11 	        //   : DATE(7)
    }

    public enum TBSFM_CBD_HEAD_5 : int
    {
        IxMaxCt = 18,	        // ¿Œµ¶Ω∫ Count
        IxSTATUS = 1, 	        // Status : ()
        IxDEV_FACTORY = 2, 	    // Dev Factory : ()
        IxPROD_FACTORY = 3, 	// Prod Factory : ()
        IxSEASON = 4, 	        // Season : VARCHAR2(6)
        IxCATEGORY = 5, 	    // Category : VARCHAR2(20)
        IxGEN = 6, 	            // GEN : ()
        IxMODEL_ID = 7, 	    // Model ID : VARCHAR2(15)
        IxMODEL_NAME = 8, 	    // Model : VARCHAR2(50)
        IxMOID = 9, 	        // MOID : VARCHAR2(20)
        IxBOM_ID = 10, 	        // BOM ID : VARCHAR2(8)
        IxCBD_ID = 11, 	        // CBD ID : VARCHAR2(8)
        IxCBD_VER = 12, 	    // CBD Ver : NUMBER(22)
        IxSTYLE_CD = 13, 	    // Style No : VARCHAR2(15)
        IxFOB_TYPE_CD = 14, 	// Fob Type : VARCHAR2(10)
        IxPCC_COSTER = 15, 	    // Charge : VARCHAR2(30)
        IxDATE_QUOTED = 16, 	// Date Quoted : DATE(7)
        IxSTATUS_CD = 17, 	    // Status Code : ()
        IxSEASON_CD = 18 	    // Season Code : VARCHAR2(6)
    }

    public enum TBSFM_CBD_HEAD_SHARE : int
    {
        IxMaxCt = 16,	        // ¿Œµ¶Ω∫ Count
        IxCHK = 1, 	            //   : ()
        IxSEASON = 2, 	        // Season : ()
        IxCATEGORY = 3, 	    // Category : ()
        IxMODEL_ID = 4, 	    // Model ID : ()
        IxMODEL_NAME = 5, 	    // Model : ()
        IxSHARE_MOID = 6, 	    // MOID : VARCHAR2(20)
        IxSHARE_BOM_ID = 7, 	// BOM ID : VARCHAR2(8)
        IxPCC_DEV = 8, 	        // PCC Dev : ()
        IxCBD_CHARGE_ID = 9, 	// CBD Charge : ()
        IxDEV_FACTORY = 10, 	// Dev Factory : ()
        IxMOID = 11, 	        // MOID : VARCHAR2(20)
        IxCBD_ID = 12, 	        // CBD ID : VARCHAR2(8)
        IxSEASON_CD = 13, 	    // Season : ()
        IxCATEGORY_CD = 14, 	// Category : ()
        IxUPD_USER = 15, 	    // Update user : VARCHAR2(30)
        IxUPD_YMD = 16 	        // Update date : DATE(7)
    }

    public enum TBSFM_CBD_HEAD_WITH_FOB : int
    {
        IxMaxCt = 13,	        // ¿Œµ¶Ω∫ Count
        IxCHK = 1, 	            // Chk : ()
        IxDATA_SOURCE = 2, 	    // Source : ()
        IxSEASON = 3, 	        // Season : ()
        IxCATEGORY = 4, 	    // Category : ()
        IxMODEL_ID = 5, 	    // Model ID : ()
        IxMODEL_NAME = 6, 	    // Model : ()
        IxSHARE_MOID = 7, 	    // MOID : ()
        IxSHARE_BOM_ID = 8, 	// BOM ID : ()
        IxPCC_DEV = 9, 	        // PCC Dev : ()
        IxCBD_CHARGE_ID = 10, 	// CBD Charge : ()
        IxDEV_FACTORY = 11, 	// Dev Factory : ()
        IxSEASON_CD = 12, 	    // Season : ()
        IxCATEGORY_CD = 13 	    // Category : ()
    }


    /// <summary>
    /// ∞¯≈Î popup - Item 
    /// </summary>
    public enum TBSBC_ITEM_COMMON : int
    {
        IxITEM_CD = 1,
        IxGROUP_CD = 2,
        IxITEM_NAME1 = 3,
        IxMNG_UNIT = 4,
        IxSIZE_YN = 5,
        IxUSE_YN = 6,
    }


    /// <summary>
    /// ∞¯≈Î popup - Sepcification
    /// </summary>
    public enum TBSBC_SPEC_COMMON : int
    {
        IxSPEC_CD = 1,
        IxSPEC_NAME = 2,
        IxUSE_YN = 3,
    }



    /// <summary>
    /// ∞¯≈Î popup - Color
    /// </summary>
    public enum TBSBC_COLOR_COMMON : int
    {
        IxCOLOR_CD = 1,
        IxCOLOR_NAME = 2,
        IxNIKE_CD_YN = 3,
        IxUSE_YN = 4,

    }





    ///// <summary>
    ///// ∞≈∑°√≥ ∏ÆΩ∫∆Æ ¡∂»∏
    ///// </summary>
    //public enum TBSFX_CBD_M_CUST_LIST : int
    //{
    //    IxMaxCt = 7,	// ¿Œµ¶Ω∫ Count
    //    IxLEV = 1, 	// Lev : ()
    //    IxFACTORY = 2, 	// Factory : ()
    //    IxMXS_DIV = 3, 	// Div : ()
    //    IxMXS_DIV_NAME = 4, 	// Div : ()
    //    IxNIKE_SUPPLIER_CD = 5, 	// Code : ()
    //    IxMXS_LOCATIONNAME = 6, 	// Supplier : ()
    //    IxMXS_MODIFY_YMD = 7 	// Modify : ()
    //}

    ///// <summary>
    ///// ∞≈∑°√≥ ¡§∫∏ ¡∂»∏
    ///// </summary>
    //public enum TBSFX_CBD_M_CUST_INFO : int
    //{
    //    IxMaxCt = 17,	// ¿Œµ¶Ω∫ Count
    //    IxLEV = 1, 	// Level : ()
    //    IxFACTORY = 2, 	// Factory : ()
    //    IxMXS_LOCATIONCODE = 3, 	// Code : ()
    //    IxMXS_LOCATIONNAME_K = 4, 	// Korean Name : ()
    //    IxMXS_LOCATIONNAME_E = 5, 	// English Name : ()
    //    IxMXS_LOCATION_SEQ = 6, 	// Seq. : ()
    //    IxMXS_DIV = 7, 	// Division : ()
    //    IxMXS_MAN_CUST = 8, 	// Charger : ()
    //    IxMXS_PHONE = 9, 	// Phone : ()
    //    IxMXS_FAX = 10, 	// Fax : ()
    //    IxMXS_HEADPHONE = 11, 	// Cell Phone : ()
    //    IxMXS_EMAIL = 12, 	// Email : ()
    //    IxMXS_COMMENTS = 13, 	// Comments : ()
    //    IxREMARKS = 14, 	// Remarks : ()
    //    IxSTATUS = 15, 	// Status : ()
    //    IxUPD_USER = 16, 	// User : ()
    //    IxUPD_YMD = 17 	// Date : ()
    //}

    //public enum TBSFX_CBD_M_MAT : int
    //{
    //    IxMaxCt = 22,	// ¿Œµ¶Ω∫ Count
    //    IxFACTORY = 1, 	// Factory : VARCHAR2(5)
    //    IxMAT_NUMBER = 2, 	// Mat.# : VARCHAR2(100)
    //    IxMXS_NUMBER = 3, 	// MxS# : VARCHAR2(100)
    //    IxMXS_UNIT = 4, 	// Unit : VARCHAR2(100)
    //    IxMXS_SEQ = 5, 	// Seq. : VARCHAR2(3)
    //    IxMXS_MATERIAL_NAME = 6, 	// Supplier : VARCHAR2(1024)
    //    IxNIKE_MAT_NAME = 7, 	// Nike : ()
    //    IxMXS_WIDTH = 8, 	// Width : VARCHAR2(100)
    //    IxMXS_UNIT_PRICE = 9, 	// Unit Price : NUMBER(22)
    //    IxMXS_CURRENCY = 10, 	// Currency : VARCHAR2(100)
    //    IxMXS_EXTRA_CHARGE = 11, 	// Extra Charge : NUMBER(22)
    //    IxMXS_SPECIAL_OPTION = 12, 	// Special Option : VARCHAR2(200)
    //    IxMXS_DELIVERY_TERM = 13, 	// Delivery Term : VARCHAR2(100)
    //    IxMXS_LOSS = 14, 	// Loss(%) : NUMBER(22)
    //    IxMXS_MOQ = 15, 	// MOQ : NUMBER(22)
    //    IxMXS_PROD_LOCATION = 16, 	// Prod. : VARCHAR2(100)
    //    IxMXS_LOCATIONCODE = 17, 	// Code : VARCHAR2(100)
    //    IxSTATUS = 18, 	// Status : VARCHAR2(1)
    //    IxREMARKS = 19, 	// Notification : VARCHAR2(500)
    //    IxMXS_CURRENT_YN = 20, 	// Current : VARCHAR2(1)
    //    IxUPD_USER = 21, 	// User : VARCHAR2(30)
    //    IxUPD_YMD = 22 	// Date : DATE(7)
    //}

    ///// <summary>
    ///// Item Master ¿« ∆Ø¡§ ¿⁄¿Á¿« »˜Ω∫≈‰∏Æ ¡∂»∏
    ///// </summary>
    //public enum TBSFX_CBD_M_MAT_HISTORY : int
    //{
    //    IxMaxCt = 21,	// ¿Œµ¶Ω∫ Count
    //    IxFACTORY = 1, 	// Factory : ()
    //    IxMAT_NUMBER = 2, 	// Mat. # : ()
    //    IxMXS_NUMBER = 3, 	// Number : ()
    //    IxMXS_UNIT = 4, 	// Unit : ()
    //    IxMXS_SPECIAL_OPTION = 5, 	// Color : ()
    //    IxMXS_SEQ = 6, 	// Seq : ()
    //    IxMXS_MATERIAL_NAME = 7, 	// Name : ()
    //    IxMXS_WIDTH = 8, 	// Width : ()
    //    IxMXS_UNIT_PRICE = 9, 	// Price : ()
    //    IxMXS_CURRENCY = 10, 	// Currency : ()
    //    IxMXS_EXTRA_CHARGE = 11, 	// Charge : ()
    //    IxMXS_DELIVERY_TERM = 12, 	// FRT Term : ()
    //    IxMXS_LOSS = 13, 	// Loss : ()
    //    IxMXS_MOQ = 14, 	// MOQ : ()
    //    IxMXS_PROD_LOCATION = 15, 	// Name : ()
    //    IxMXS_LOCATIONCODE = 16, 	// Code : ()
    //    IxSTATUS = 17, 	// Status : ()
    //    IxREMARKS = 18, 	// Remarks : ()
    //    IxMXS_CURRENT_YN = 19, 	// Current : ()
    //    IxUPD_USER = 20, 	// Update User : ()
    //    IxUPD_YMD = 21 	// Update Date : ()
    //}

    ///// <summary>
    ///// Item Master ¿« ∆Ø¡§ ¿⁄¿Á∞° º”«— Part ¡§∫∏ ¡∂»∏
    ///// </summary>
    //public enum TBSFX_CBD_M_REINFORCE : int
    //{
    //    IxMaxCt = 8,	// ¿Œµ¶Ω∫ Count
    //    IxFACTORY = 1, 	// Factory : VARCHAR2(5)
    //    IxMODEL_ID = 2, 	// Model : VARCHAR2(15)
    //    IxPART_DESC = 3, 	// Description : VARCHAR2(100)
    //    IxPART_SEQ = 4, 	// Seq : NUMBER(22)
    //    IxMAT_NUMBER = 5, 	// Mat. : ()
    //    IxMAT_DESC = 6, 	// Description : ()
    //    IxUPD_USER = 7, 	// Update User : VARCHAR2(30)
    //    IxUPD_YMD = 8 	// Update Date : DATE(7)
    //}

    //public enum TBSFX_CBD_M_MAT_CONV : int
    //{
    //    IxMaxCt = 37,	// ¿Œµ¶Ω∫ Count
    //    IxCHK = 1, 	//   : ()
    //    IxFACTORY = 2, 	// Factory : VARCHAR2(5)
    //    IxMXS_SEQ = 3, 	// Seq : VARCHAR2(10)
    //    IxMXS_LOCATIONCODE = 4, 	// Location : VARCHAR2(100)
    //    IxI01 = 5, 	// MxS# : VARCHAR2(200)
    //    IxI02 = 6, 	// Location : VARCHAR2(200)
    //    IxI03 = 7, 	// Material Name : VARCHAR2(200)
    //    IxI04 = 8, 	// Unit : VARCHAR2(200)
    //    IxI05 = 9, 	// Width : VARCHAR2(200)
    //    IxI06 = 10, 	// Unit Price : VARCHAR2(200)
    //    IxI07 = 11, 	// Currency : VARCHAR2(200)
    //    IxI08 = 12, 	// Special Option : VARCHAR2(200)
    //    IxI09 = 13, 	// Extra Charge : VARCHAR2(200)
    //    IxI10 = 14, 	// Delivery Term : VARCHAR2(200)
    //    IxI11 = 15, 	// Loss(%) : VARCHAR2(200)
    //    IxI12 = 16, 	// MOQ : VARCHAR2(200)
    //    IxI13 = 17, 	//   : VARCHAR2(200)
    //    IxI14 = 18, 	//   : VARCHAR2(200)
    //    IxI15 = 19, 	//   : VARCHAR2(200)
    //    IxI16 = 20, 	//   : VARCHAR2(200)
    //    IxI17 = 21, 	//   : VARCHAR2(200)
    //    IxI18 = 22, 	//   : VARCHAR2(200)
    //    IxI19 = 23, 	//   : VARCHAR2(200)
    //    IxI20 = 24, 	//   : VARCHAR2(200)
    //    IxI21 = 25, 	//   : VARCHAR2(200)
    //    IxI22 = 26, 	//   : VARCHAR2(200)
    //    IxI23 = 27, 	//   : VARCHAR2(200)
    //    IxI24 = 28, 	//   : VARCHAR2(200)
    //    IxI25 = 29, 	//   : VARCHAR2(200)
    //    IxI26 = 30, 	//   : VARCHAR2(200)
    //    IxI27 = 31, 	//   : VARCHAR2(200)
    //    IxI28 = 32, 	//   : VARCHAR2(200)
    //    IxI29 = 33, 	//   : VARCHAR2(200)
    //    IxI30 = 34, 	//   : VARCHAR2(200)
    //    IxSTATUS = 35, 	// Status : VARCHAR2(1)
    //    IxUPD_USER = 36, 	// Update User : VARCHAR2(30)
    //    IxUPD_YMD = 37 	// Update Date : DATE(7)
    //}

    #endregion

    #region Management

    #region Type ans search 

    public enum TBSFX_CBD_M_MAT_SEARCH : int
    {
        IxMaxCt = 25,	// ¿Œµ¶Ω∫ Count
        IxUPD_YMD = 1, 	// Date : ()
        IxFACTORY = 2, 	// Factory : ()
        IxMAT_NUMBER = 3, 	// Mat.# : ()
        IxMXS_NUMBER = 4, 	// MxS# : ()
        IxMXS_UNIT = 5, 	// Unit : ()
        IxMXS_SEQ = 6, 	// Seq. : ()
        IxMXS_MATERIAL_NAME = 7, 	// Supplier : ()
        IxNIKE_MAT_NAME = 8, 	// Nike : ()
        IxUOM = 9, 	// UOM : ()
        IxMXS_WIDTH = 10, 	// Width : ()
        IxMXS_UNIT_PRICE = 11, 	// Unit Price : ()
        IxMXS_CURRENCY = 12, 	// Currency : ()
        IxMXS_EXTRA_CHARGE = 13, 	// Extra Charge : ()
        IxMXS_SPECIAL_OPTION = 14, 	// Special Option : ()
        IxMXS_DELIVERY_TERM = 15, 	// Delivery Term : ()
        IxMXS_LOSS = 16, 	// Loss(%) : ()
        IxMXS_MOQ = 17, 	// MOQ : ()
        IxMXS_PROD_LOCATION = 18, 	// Prod. : ()
        IxMXS_LOCATIONCODE = 19, 	// Code : ()
        IxMXS_LOCATIONNAME_E = 20, 	// Name : ()
        IxSTATUS = 21, 	// Status : ()
        IxREMARKS = 22, 	// Notification : ()
        IxMXS_CURRENT_YN = 23, 	// Current : ()
        IxMXS_SINGLE_YN = 24, 
        IxUPD_USER = 25 	// User : ()
    }

    public enum TBSFM_CBD_TAIL1_UP_3 : int
    {
        IxMaxCt = 23,	// ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	// Factory : ()
        IxMXS_NUMBER = 2, 	// MxS# : ()
        IxMXS_SEQ = 3, 	// Seq. : ()
        IxMXS_MATERIAL_NAME = 4, 	// Supplier : ()
        IxMXS_UNIT = 5, 	// Unit : ()
        IxMXS_SPECIAL_OPTION = 6, 	// Special Option : ()
        IxMXS_WIDTH = 7, 	// Width : ()
        IxMXS_UNIT_PRICE = 8, 	// Unit Price : ()
        IxMXS_CURRENCY = 9, 	// Currency : ()
        IxMXS_EXTRA_CHARGE = 10, 	// Extra Charge : ()
        IxMXS_DELIVERY_TERM = 11, 	// Delivery Term : ()
        IxMXS_LOSS = 12, 	// Loss(%) : ()
        IxMXS_MOQ = 13, 	// MOQ : ()
        IxMXS_PROD_LOCATION = 14, 	// Prod. : ()
        IxMAT_NUMBER = 15, 	// Mat.# : ()
        IxMXS_LOCATIONCODE = 16, 	// Location : ()
        IxNIKE_SUPPLIER_CD = 17, 	// Code : ()
        IxMXS_LOCATIONNAME_E = 18, 	// Name : ()
        IxMXS_CURRENT_YN = 19, 	// Current : ()
        IxREMARKS = 20, 	// Notification : ()
        IxSTATUS = 21, 	// Status : ()
        IxUPD_USER = 22, 	// User : VARCHAR2(30)
        IxUPD_YMD = 23 	// Date : DATE(7)
    }

    public enum TBSFM_CBD_PART_4 : int
    {
        IxMaxCt = 3,	// ¿Œµ¶Ω∫ Count
        IxPART_NO = 1, 	//   : ()
        IxPART_SEQ = 2, 	//   : ()
        IxPART_DESC = 3 	//   : ()
    }

    #endregion

    #region Costing

    #region CBD Head

    public enum TBSFM_CBD_HEAD_1 : int
    {
        IxMaxCt = 54,	                // ¿Œµ¶Ω∫ Count
        IxCHK = 1,                  	//   : ()
        IxCLASS_NAME = 2, 	            // Class : ()
        IxDEV_FACTORY = 3, 	            // Dev : ()
        IxPROD_FACTORY = 4, 	        // Prod : ()
        IxSEASON_NAME = 5, 	            // Season : ()
        IxCATEGORY_NAME = 6, 	        // Category : ()
        IxROUND_TYPE = 7, 	            // (Type) : ()
        IxSIZE = 8, 	                // Size : ()
        IxGEN = 9, 	                    // Gen : ()
        IxMODEL_NAME = 10, 	            // Model : VARCHAR2(50)
        IxMOID = 11, 	                // MOID : VARCHAR2(20)
        IxBOM = 12, 	                // BOM : ()
        IxTD = 13, 	                    // TD : VARCHAR2(5)
        IxSTYLE_CD = 14, 	            // Style # : VARCHAR2(15)
        IxSEQ = 15, 	                // Seq : ()
        IxOBS_ID = 16, 	                // ID : ()
        IxOBS_TYPE = 17, 	            // Type : ()
        IxTOT_FOB = 18, 	            // Total : ()
        IxUPPER_SUMM_CBD = 19, 	        // Upper : NUMBER(22)
        IxPACKING_SUMM_CBD = 20, 	    // Packaging : NUMBER(22)
        IxMIDSOLE_SUMM_CBD = 21, 	    // Midsole : NUMBER(22)
        IxOUTSOLE_SUMM_CBD = 22, 	    // Outsole : NUMBER(22)
        IxSIZEUP_SUMM_CBD = 23, 	    // Size Up : NUMBER(22)
        IxMATERIAL_SUMM_CBD = 24, 	    // Cost : ()
        IxMATERIAL_SUMM_PCT = 25, 	    // Ratio : ()
        IxLABOR_SUMM_CBD = 26, 	        // Labor : NUMBER(22)
        IxOVERHEAD_SUMM_CBD = 27, 	    // Overhead : NUMBER(22)
        IxPROFIT_SUMM_CBD = 28, 	    // Profit : NUMBER(22)
        IxPRSS_SUMM_CBD = 29, 	        // Process : NUMBER(22)
        IxOTHERADJ_SUMM_CBD = 30, 	    // Other Adjust : NUMBER(22)
        IxNON_MATERIAL_SUMM_CBD = 31, 	// Cost : ()
        IxNON_MATERIAL_SUMM_PCT = 32, 	// Ratop : ()
        IxSMPL_TOOL_SUMM_CBD = 33, 	    // Sample : NUMBER(22)
        IxPROD_TOOL_SUMM_CBD = 34, 	    // Production : NUMBER(22)
        IxTOOL_SUMM_CBD = 35, 	        // Cost : ()
        IxTOOL_SUMM_PCT = 36, 	        // Ratio : ()
        IxTOTAL_CBD = 37, 	            // Cost : ()
        IxTOTAL_PCT = 38, 	            // Ratio : ()
        IxDATE_QUOTED = 39, 	        // Quoted : DATE(7)
        IxFOB_STATUS = 40, 	            // Status : VARCHAR2(20)
        IxCHARGE = 41, 	                // Charge : ()
        IxOPTION = 42, 	                // Option : ()
        IxFOB_STATUS_CD = 43, 	        // Status : ()
        IxCLASS_CD = 44, 	            // Class : VARCHAR2(5)
        IxSEASON_CD = 45, 	            // Season : VARCHAR2(6)
        IxCATEGORY_CD = 46, 	        // Category : ()
        IxMODEL_ID = 47, 	            // Model : VARCHAR2(15)
        IxSR_NO = 48, 	                // SR No : ()
        IxBOM_REV = 49, 	            // BOM Rev : VARCHAR2(3)
        IxSRF_SEQ = 50, 	            // SRF Seq : ()
        IxCBD_ID = 51, 	                // CBD ID : VARCHAR2(8)
        IxCBD_VER = 52, 	            // CBD Ver : NUMBER(22)
        IxPCC_CHARGE = 53, 	            // PCC Charge : ()
        IxFOB_TYPE_CD = 54 	// Fob Type Code : VARCHAR2(10)
    }

    public enum TBSFM_CBD_REMARK : int
    {
        IxMaxCt = 11,	                // ¿Œµ¶Ω∫ Count
        IxDEV_FAC = 1, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 2, 	            //   : VARCHAR2(5)
        IxMOID = 3, 	                //   : VARCHAR2(20)
        IxCBD_ID = 4, 	                //   : VARCHAR2(8)
        IxCBD_VER = 5, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 6, 	            //   : VARCHAR2(10)
        IxRMK_SEQ = 7, 	                //   : VARCHAR2(3)
        IxTITLE = 8, 	                //   : VARCHAR2(50)
        IxREMARK = 9, 	                //   : VARCHAR2(1000)
        IxUPD_USER = 10, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 11 	                //   : DATE(7)
    }

    #endregion

    #region CBD Detail - v5

    public enum TBSFM_CBD_TAIL1_UP : int
    {
        IxMaxCt = 39,	                // ¿Œµ¶Ω∫ Count
        IxDEV_FAC = 1, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 2, 	            //   : VARCHAR2(5)
        IxMOID = 3, 	                //   : VARCHAR2(20)
        IxCBD_ID = 4, 	                //   : VARCHAR2(8)
        IxCBD_VER = 5, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 6, 	            //   : VARCHAR2(10)
        IxSIZE_EXC = 7, 	            //   : VARCHAR2(1)
        IxCBD_CLASS = 8, 	            //   : VARCHAR2(10)
        IxSUB_CLASS = 9, 	            //   : VARCHAR2(20)
        IxBOM_NO = 10, 	                //   : NUMBER(22)
        IxCBD_UP_NO = 11, 	            //   : NUMBER(22)
        IxPART_NAME = 12, 	            //   : VARCHAR2(100)
        IxMAT_NAME = 13, 	            //   : VARCHAR2(100)
        IxVEN_NAME = 14, 	            //   : VARCHAR2(100)
        IxCOLOR_NAME = 15, 	            //   : VARCHAR2(100)
        IxMAT_CD = 16, 	                //   : VARCHAR2(15)
        IxUOM = 17, 	                //   : VARCHAR2(50)
        IxCURR = 18, 	                //   : VARCHAR2(10)
        IxFX_RATE = 19, 	            //   : NUMBER(22)
        IxMAT_UPRICE = 20, 	            //   : NUMBER(22)
        IxFRT_TRM = 21, 	            //   : VARCHAR2(20)
        IxFCT_LND_PCT = 22, 	        //   : NUMBER(22)
        IxFCT_LND_TOT = 23, 	        //   : NUMBER(22)
        IxFCT_LND_USD_TOT = 24, 	    //   : NUMBER(22)
        IxYIELD = 25, 	                //   : NUMBER(22)
        IxLOSS_PCT = 26, 	            //   : NUMBER(22)
        IxUSAGE = 27, 	                //   : NUMBER(22)
        IxUSS_COST = 28, 	            //   : NUMBER(22)
        IxSIZE_TOTAL_COST = 29, 	    //   : NUMBER(22)
        IxSIZEUP_CHARGE = 30, 	        //   : NUMBER(22)
        IxPRSS_CHARGE = 31, 	        //   : NUMBER(22)
        IxREF = 32, 	                //   : VARCHAR2(10)
        IxVEN_CD = 33, 	                //   : VARCHAR2(15)
        IxMCS_NO = 34, 	                //   : VARCHAR2(50)
        IxCOLOR_CD = 35, 	            //   : VARCHAR2(15)
        IxPART_NO = 36, 	            //   : VARCHAR2(50)
        IxPART_SEQ = 37, 	            //   : NUMBER(22)
        IxUPD_USER = 38, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 39 	                //   : DATE(7)
    }

    public enum TBSFM_CBD_TAIL2_PK : int
    {
        IxMaxCt = 39,	                // ¿Œµ¶Ω∫ Count
        IxDEV_FAC = 1, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 2, 	            //   : VARCHAR2(5)
        IxMOID = 3, 	                //   : VARCHAR2(20)
        IxCBD_ID = 4, 	                //   : VARCHAR2(8)
        IxCBD_VER = 5, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 6, 	            //   : VARCHAR2(10)
        IxSIZE_EXC = 7, 	            //   : VARCHAR2(1)
        IxCBD_CLASS = 8, 	            //   : VARCHAR2(10)
        IxSUB_CLASS = 9, 	            //   : VARCHAR2(20)
        IxBOM_NO = 10, 	                //   : NUMBER(22)
        IxCBD_PK_NO = 11, 	            //   : NUMBER(22)
        IxPART_NAME = 12, 	            //   : VARCHAR2(100)
        IxMAT_NAME = 13, 	            //   : VARCHAR2(100)
        IxVEN_NAME = 14, 	            //   : VARCHAR2(100)
        IxCOLOR_NAME = 15, 	            //   : VARCHAR2(100)
        IxMAT_CD = 16, 	                //   : VARCHAR2(15)
        IxUOM = 17, 	                //   : VARCHAR2(50)
        IxCURR = 18, 	                //   : VARCHAR2(10)
        IxFX_RATE = 19, 	            //   : NUMBER(22)
        IxMAT_UPRICE = 20, 	            //   : NUMBER(22)
        IxFRT_TRM = 21, 	            //   : VARCHAR2(20)
        IxFCT_LND_PCT = 22, 	        //   : NUMBER(22)
        IxFCT_LND_TOT = 23, 	        //   : NUMBER(22)
        IxFCT_LND_USD_TOT = 24, 	    //   : NUMBER(22)
        IxYIELD = 25, 	                //   : NUMBER(22)
        IxLOSS_PCT = 26, 	            //   : NUMBER(22)
        IxUSAGE = 27, 	                //   : NUMBER(22)
        IxUSS_COST = 28, 	            //   : NUMBER(22)
        IxSIZE_TOTAL_COST = 29, 	    //   : NUMBER(22)
        IxSIZEUP_CHARGE = 30, 	        //   : NUMBER(22)
        IxPRSS_CHARGE = 31, 	        //   : NUMBER(22)
        IxREF = 32, 	                //   : VARCHAR2(10)
        IxVEN_CD = 33, 	                //   : VARCHAR2(15)
        IxMCS_NO = 34, 	                //   : VARCHAR2(50)
        IxCOLOR_CD = 35, 	            //   : VARCHAR2(15)
        IxPART_NO = 36, 	            //   : VARCHAR2(50)
        IxPART_SEQ = 37, 	            //   : NUMBER(22)
        IxUPD_USER = 38, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 39 	                //   : DATE(7)
    }

    public enum TBSFM_CBD_TAIL3_MS : int
    {
        IxMaxCt = 39,	                // ¿Œµ¶Ω∫ Count
        IxDEV_FAC = 1, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 2, 	            //   : VARCHAR2(5)
        IxMOID = 3, 	                //   : VARCHAR2(20)
        IxCBD_ID = 4, 	                //   : VARCHAR2(8)
        IxCBD_VER = 5, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 6, 	            //   : VARCHAR2(10)
        IxSIZE_EXC = 7, 	            //   : VARCHAR2(1)
        IxCBD_CLASS = 8, 	            //   : VARCHAR2(10)
        IxSUB_CLASS = 9, 	            //   : VARCHAR2(20)
        IxBOM_NO = 10,  	            //   : NUMBER(22)
        IxCBD_NO = 11, 	                //   : ()
        IxPART_NAME = 12, 	            //   : VARCHAR2(100)
        IxMAT_NAME = 13, 	            //   : VARCHAR2(100)
        IxVEN_NAME = 14, 	            //   : VARCHAR2(100)
        IxCOLOR_NAME = 15, 	            //   : VARCHAR2(100)
        IxMAT_CD = 16, 	                //   : VARCHAR2(15)
        IxUOM = 17, 	                //   : VARCHAR2(50)
        IxCURR = 18, 	                //   : VARCHAR2(10)
        IxFX_RATE = 19, 	            //   : NUMBER(22)
        IxMAT_UPRICE = 20, 	            //   : NUMBER(22)
        IxFRT_TRM = 21, 	            //   : VARCHAR2(20)
        IxFCT_LND_PCT = 22, 	        //   : NUMBER(22)
        IxFCT_LND_TOT = 23, 	        //   : NUMBER(22)
        IxFCT_LND_USD_TOT = 24, 	    //   : NUMBER(22)
        IxYIELD = 25, 	                //   : NUMBER(22)
        IxLOSS_PCT = 26, 	            //   : NUMBER(22)
        IxUSAGE = 27, 	                //   : NUMBER(22)
        IxUSS_COST = 28, 	            //   : NUMBER(22)
        IxSIZE_TOTAL_COST = 29, 	    //   : NUMBER(22)
        IxSIZEUP_CHARGE = 30, 	        //   : NUMBER(22)
        IxPRSS_CHARGE = 31, 	        //   : NUMBER(22)
        IxREF = 32, 	                //   : VARCHAR2(10)
        IxVEN_CD = 33, 	                //   : VARCHAR2(15)
        IxMCS_NO = 34, 	                //   : VARCHAR2(50)
        IxCOLOR_CD = 35, 	            //   : VARCHAR2(15)
        IxPART_NO = 36, 	            //   : VARCHAR2(50)
        IxPART_SEQ = 37, 	            //   : NUMBER(22)
        IxUPD_USER = 38, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 39 	                //   : DATE(7)
    }

    public enum TBSFM_CBD_TAIL4_OS : int
    {
        IxMaxCt = 39,	                // ¿Œµ¶Ω∫ Count
        IxDEV_FAC = 1, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 2, 	            //   : VARCHAR2(5)
        IxMOID = 3, 	                //   : VARCHAR2(20)
        IxCBD_ID = 4, 	                //   : VARCHAR2(8)
        IxCBD_VER = 5, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 6, 	            //   : VARCHAR2(10)
        IxSIZE_EXC = 7, 	            //   : VARCHAR2(1)
        IxCBD_CLASS = 8, 	            //   : VARCHAR2(10)
        IxSUB_CLASS = 9, 	            //   : VARCHAR2(20)
        IxBOM_NO = 10, 	                //   : NUMBER(22)
        IxCBD_NO = 11, 	                //   : ()
        IxPART_NAME = 12, 	            //   : VARCHAR2(100)
        IxMAT_NAME = 13, 	            //   : VARCHAR2(100)
        IxVEN_NAME = 14, 	            //   : VARCHAR2(100)
        IxCOLOR_NAME = 15, 	            //   : VARCHAR2(100)
        IxMAT_CD = 16, 	                //   : VARCHAR2(15)
        IxUOM = 17, 	                //   : VARCHAR2(50)
        IxCURR = 18, 	                //   : VARCHAR2(10)
        IxFX_RATE = 19, 	            //   : NUMBER(22)
        IxMAT_UPRICE = 20, 	            //   : NUMBER(22)
        IxFRT_TRM = 21, 	            //   : VARCHAR2(20)
        IxFCT_LND_PCT = 22, 	        //   : NUMBER(22)
        IxFCT_LND_TOT = 23, 	        //   : NUMBER(22)
        IxFCT_LND_USD_TOT = 24, 	    //   : NUMBER(22)
        IxYIELD = 25, 	                //   : NUMBER(22)
        IxLOSS_PCT = 26, 	            //   : NUMBER(22)
        IxUSAGE = 27, 	                //   : NUMBER(22)
        IxUSS_COST = 28, 	            //   : NUMBER(22)
        IxSIZE_TOTAL_COST = 29, 	    //   : NUMBER(22)
        IxSIZEUP_CHARGE = 30, 	        //   : NUMBER(22)
        IxPRSS_CHARGE = 31, 	        //   : NUMBER(22)
        IxREF = 32, 	                //   : VARCHAR2(10)
        IxVEN_CD = 33, 	                //   : VARCHAR2(15)
        IxMCS_NO = 34, 	                //   : VARCHAR2(50)
        IxCOLOR_CD = 35, 	            //   : VARCHAR2(15)
        IxPART_NO = 36, 	            //   : VARCHAR2(50)
        IxPART_SEQ = 37, 	            //   : NUMBER(22)
        IxUPD_USER = 38, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 39 	                //   : DATE(7)
    }

    public enum TBSFM_CBD_TAIL5_LB : int
    {
        IxMaxCt = 26,	                // ¿Œµ¶Ω∫ Count
        IxDEV_FAC = 1, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 2, 	            //   : VARCHAR2(5)
        IxMOID = 3, 	                //   : VARCHAR2(20)
        IxCBD_ID = 4, 	                //   : VARCHAR2(8)
        IxCBD_VER = 5, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 6, 	            //   : VARCHAR2(10)
        IxTEMP0 = 7, 	                //   : ()
        IxCBD_CLASS = 8, 	            //   : VARCHAR2(10)
        IxSUB_CLASS = 9, 	            //   : VARCHAR2(20)
        IxCURR = 10, 	                //   : VARCHAR2(10)
        IxFX_RATE = 11, 	            //   : NUMBER(22)
        IxPROCESS = 12, 	            //   : VARCHAR2(50)
        IxWAGE_YR = 13, 	            //   : NUMBER(22)
        IxDIRT_WORKER = 14, 	        //   : NUMBER(22)
        IxDAY_PAID_YR = 15, 	        //   : NUMBER(22)
        IxMIN_DAY_WORKER = 16, 	        //   : NUMBER(22)
        IxEFFCTV_RATE = 17, 	        //   : NUMBER(22)
        IxCOST_STD = 18, 	            //   : NUMBER(22)
        IxSTD_MIN = 19, 	            //   : NUMBER(22)
        IxCOST_LOCAL = 20, 	            //   : NUMBER(22)
        IxCOST_USD = 21, 	            //   : NUMBER(22)
        IxOV_COST = 22, 	            //   : NUMBER(22)
        IxREF = 23, 	                //   : VARCHAR2(10)
        IxCBD_NO = 24, 	                //   : ()
        IxUPD_USER = 25, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 26 	                //   : DATE(7)
    }

    public enum TBSFM_CBD_TAIL6_OH : int
    {
        IxMaxCt = 27,	                // ¿Œµ¶Ω∫ Count
        IxCBD_OH_NO = 1, 	            //   : NUMBER(22)
        IxDEV_FAC = 2, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 3, 	            //   : VARCHAR2(5)
        IxMOID = 4, 	                //   : VARCHAR2(20)
        IxCBD_ID = 5, 	                //   : VARCHAR2(8)
        IxCBD_VER = 6, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 7, 	            //   : VARCHAR2(10)
        IxTEMP0 = 8, 	                //   : ()
        IxCBD_CLASS = 9, 	            //   : VARCHAR2(10)
        IxSUB_CLASS = 10, 	            //   : VARCHAR2(20)
        IxCURR = 11, 	                //   : VARCHAR2(10)
        IxFX_RATE = 12, 	            //   : NUMBER(22)
        IxITEM = 13, 	                //   : VARCHAR2(50)
        IxCOST_LOCAL = 14, 	            //   : NUMBER(22)
        IxCOST_USD = 15, 	            //   : NUMBER(22)
        IxTEMP1 = 16, 	                //   : ()
        IxTEMP2 = 17, 	                //   : ()
        IxTEMP3 = 18, 	                //   : ()
        IxTEMP4 = 19, 	                //   : ()
        IxTEMP5 = 20, 	                //   : ()
        IxTEMP6 = 21, 	                //   : ()
        IxTEMP7 = 22, 	                //   : ()
        IxTEMP8 = 23, 	                //   : ()
        IxREF = 24, 	                //   : VARCHAR2(10)
        IxCBD_NO = 25, 	                //   : NUMBER(22)
        IxUPD_USER = 26, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 27 	                //   : DATE(7)
    }

    public enum TBSFM_CBD_TAIL7_SM : int
    {
        IxMaxCt = 28,	                // ¿Œµ¶Ω∫ Count
        IxCBD_NO = 1, 	                //   : ()
        IxDEV_FAC = 2, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 3, 	            //   : VARCHAR2(5)
        IxMOID = 4, 	                //   : VARCHAR2(20)
        IxCBD_ID = 5, 	                //   : VARCHAR2(8)
        IxCBD_VER = 6, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 7, 	            //   : VARCHAR2(10)
        IxTEMP0 = 8, 	                //   : ()
        IxCBD_CLASS = 9, 	            //   : VARCHAR2(10)
        IxCOMPONENT = 10, 	            //   : VARCHAR2(100)
        IxMOLD_TYPE = 11, 	            //   : VARCHAR2(50)
        IxMOLD_CD = 12, 	            //   : VARCHAR2(10)
        IxMOLD_DESC = 13, 	            //   : VARCHAR2(50)
        IxMOLDA_CNT = 14, 	            //   : NUMBER(22)
        IxMOLDB_CNT = 15, 	            //   : NUMBER(22)
        IxCURR = 16, 	                //   : VARCHAR2(10)
        IxFX_RATE = 17, 	            //   : NUMBER(22)
        IxCOST_MOLDA = 18, 	            //   : NUMBER(22)
        IxCOST_MOLDB = 19, 	            //   : NUMBER(22)
        IxTOT_COST = 20, 	            //   : NUMBER(22)
        IxTOT_COST_USD = 21, 	        //   : NUMBER(22)
        IxAMORT_PAIRS = 22, 	        //   : NUMBER(22)
        IxCOST_USD_PAIR = 23, 	        //   : NUMBER(22)
        IxNOTE = 24, 	                //   : VARCHAR2(100)
        IxPROD_PER_DAY = 25, 	        //   : NUMBER(22)
        IxREF = 26, 	                //   : VARCHAR2(10)
        IxUPD_USER = 27, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 28 	                //   : DATE(7)
    }

    public enum TBSFM_CBD_TAIL8_PM : int
    {
        IxMaxCt = 28,	                // ¿Œµ¶Ω∫ Count
        IxCBD_NO = 1, 	                //   : ()
        IxDEV_FAC = 2, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 3, 	            //   : VARCHAR2(5)
        IxMOID = 4, 	                //   : VARCHAR2(20)
        IxCBD_ID = 5, 	                //   : VARCHAR2(8)
        IxCBD_VER = 6, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 7, 	            //   : VARCHAR2(10)
        IxTEMP0 = 8, 	                //   : ()
        IxCBD_CLASS = 9, 	            //   : VARCHAR2(10)
        IxCOMPONENT = 10, 	            //   : VARCHAR2(100)
        IxMOLD_TYPE = 11, 	            //   : VARCHAR2(50)
        IxMOLD_CD = 12, 	            //   : VARCHAR2(10)
        IxMOLD_DESC = 13, 	            //   : VARCHAR2(50)
        IxMOLDA_CNT = 14, 	            //   : NUMBER(22)
        IxMOLDB_CNT = 15, 	            //   : NUMBER(22)
        IxCURR = 16, 	                //   : VARCHAR2(10)
        IxFX_RATE = 17, 	            //   : NUMBER(22)
        IxCOST_MOLDA = 18, 	            //   : NUMBER(22)
        IxCOST_MOLDB = 19, 	            //   : NUMBER(22)
        IxTOT_COST = 20, 	            //   : NUMBER(22)
        IxTOT_COST_USD = 21, 	        //   : NUMBER(22)
        IxAMORT_PAIRS = 22, 	        //   : NUMBER(22)
        IxCOST_USD_PAIR = 23, 	        //   : NUMBER(22)
        IxNOTE = 24, 	                //   : VARCHAR2(100)
        IxPROD_PER_DAY = 25, 	        //   : NUMBER(22)
        IxREF = 26, 	                //   : VARCHAR2(10)
        IxUPD_USER = 27, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 28 	                //   : DATE(7)
    }

    public enum TBSFM_CBD_TAIL3_MS_TMP : int
    {
        IxMaxCt = 29,	                // ¿Œµ¶Ω∫ Count
        IxLEV = 1, 	                    // Lev : ()
        IxGROUP_BY = 2, 	            // Group : ()
        IxDEV_FAC = 3, 	                // Dev Fac : VARCHAR2(5)
        IxPROD_FAC = 4, 	            // Prod Fac : VARCHAR2(5)
        IxMOID = 5, 	                // MOID : VARCHAR2(20)
        IxCBD_ID = 6, 	                // CBD# : VARCHAR2(8)
        IxFOB_TYPE_CD = 7, 	            // Fob Type : VARCHAR2(10)
        IxSOLE_DIV = 8, 	            // Div : ()
        IxCBD_MO_NO = 9, 	            // No : ()
        IxPART_NO = 10, 	            // Part No : VARCHAR2(50)
        IxPART_SEQ = 11, 	            // Part Seq : NUMBER(22)
        IxPART_NAME = 12, 	            // Part Name : VARCHAR2(100)
        IxMCS_NO = 13, 	                // MCS# : VARCHAR2(50)
        IxCOLOR_CD = 14, 	            // Color Code : VARCHAR2(15)
        IxCOLOR_NAME = 15, 	            // Code Name : VARCHAR2(100)
        IxWEIGHT_PR = 16, 	            // Weight : ()
        IxMAT_COST_KG = 17, 	        // Mat Cost / KG : ()
        IxMAT_COST_PR = 18, 	        // Mat Cost / PR : ()
        IxMAT_LOSS_PCT = 19, 	        // Loss (%) : ()
        IxDEF_LOSS_PCT = 20, 	        // Loss (%) : ()
        IxMAT_TOT_COST = 21, 	        // Total Cost : ()
        IxOTHER_COST = 22, 	            // Other : ()
        IxOS_LB_COST = 23, 	            // Outsole Labor : ()
        IxLOSS_COST = 24, 	            // Defective Loss : ()
        IxTOTAL_COST = 25, 	            // Total Cost : ()
        IxMAT_UPD_YMD = 26, 	        // Last update : ()
        IxUPD_USER = 27, 	            // Update User : VARCHAR2(30)
        IxUPD_YMD = 28, 	            // Update Date : DATE(7)
        IxTEMP0 = 29 	                // for Model : ()
    }

    public enum TBSFM_CBD_TAIL4_OS_TMP : int
    {
        IxMaxCt = 29,	                // ¿Œµ¶Ω∫ Count
        IxLEV = 1, 	                    // Lev : ()
        IxGROUP_BY = 2, 	            // Group : ()
        IxDEV_FAC = 3, 	                // Dev Fac : VARCHAR2(5)
        IxPROD_FAC = 4, 	            // Prod Fac : VARCHAR2(5)
        IxMOID = 5, 	                // MOID : VARCHAR2(20)
        IxCBD_ID = 6, 	                // CBD# : VARCHAR2(8)
        IxFOB_TYPE_CD = 7, 	            // Fob Type : VARCHAR2(10)
        IxSOLE_DIV = 8, 	            // Div : ()
        IxCBD_MO_NO = 9, 	            // No : ()
        IxPART_NO = 10, 	            // Part No : VARCHAR2(50)
        IxPART_SEQ = 11, 	            // Part Seq : NUMBER(22)
        IxPART_NAME = 12, 	            // Part Name : VARCHAR2(100)
        IxMCS_NO = 13, 	                // MCS# : VARCHAR2(50)
        IxCOLOR_CD = 14, 	            // Color Code : VARCHAR2(15)
        IxCOLOR_NAME = 15, 	            // Code Name : VARCHAR2(100)
        IxWEIGHT_PR = 16, 	            // Weight : ()
        IxMAT_COST_KG = 17, 	        // Mat Cost / KG : ()
        IxMAT_COST_PR = 18, 	        // Mat Cost / PR : ()
        IxMAT_LOSS_PCT = 19, 	        // Loss (%) : ()
        IxDEF_LOSS_PCT = 20, 	        // Loss (%) : ()
        IxMAT_TOT_COST = 21, 	        // Total Cost : ()
        IxOTHER_COST = 22, 	            // Other : ()
        IxOS_LB_COST = 23, 	            // Outsole Labor : ()
        IxLOSS_COST = 24, 	            // Defective Loss : ()
        IxTOTAL_COST = 25, 	            // Total Cost : ()
        IxMAT_UPD_YMD = 26, 	        // Last update : ()
        IxUPD_USER = 27, 	            // Update User : VARCHAR2(30)
        IxUPD_YMD = 28, 	            // Update Date : DATE(7)
        IxTEMP0 = 29 	                // for Model : ()
    }


    #endregion

    #region CBD Detail - v6

    public enum TBSFX_CBD_TAIL : int
    {
        IxMaxCt = 44,	// ¿Œµ¶Ω∫ Count
        IxLEVEL = 1, 	// Lev : ()
        IxDEV_FAC = 2, 	// DEV FAC : ()
        IxMOID = 3, 	// MOID : ()
        IxCBD_ID = 4, 	// CBD ID : ()
        IxCBD_VER = 5, 	// CBD VER : ()
        IxFOB_TYPE_CD = 6, 	// FOB TYPE CD : ()
        IxDIV = 7, 	// DIV : ()
        IxSIZE_EXC = 8, 	// SIZE EXCLD? : ()
        IxCBD_CLASS = 9, 	// CLASS : ()
        IxSUB_CLASS = 10, 	// SUB CLASS : ()
        IxBOM_NO = 11, 	// BOM# : ()
        IxCBD_NO = 12, 	// CBD# : ()
        IxCBD_NO_VIEW = 13, 	// CBD# : ()
        IxPART_NAME = 14, 	// PART : ()
        IxMAT_NAME = 15, 	// MATERIAL NAME : ()
        IxMAT_COMMENT = 16, 	// Special Option : ()
        IxVEN_NAME = 17, 	// VENDOR : ()
        IxCOLOR_NAME = 18, 	// COLOR : ()
        IxMAT_CD = 19, 	// MTL# : ()
        IxUOM = 20, 	// UOM : ()
        IxCURR = 21, 	// CURR : ()
        IxFX_RATE = 22, 	// Extra Charge : ()
        IxMAT_UPRICE = 23, 	// MAT. PRICE / COST : ()
        IxFRT_TRM = 24, 	// FRT TRM : ()
        IxFCT_LND_PCT = 25, 	// FCT LND % : ()
        IxFCT_LND_TOT = 26, 	// FCT LND TOT : ()
        IxFCT_LND_USD_TOT = 27, 	// FCT LND USD TOT : ()
        IxYIELD = 28, 	// YIELD : ()
        IxLOSS_PCT = 29, 	// LOSS % : ()
        IxUSAGE = 30, 	// USAGE : ()
        IxUSS_COST = 31, 	// US$ COST : ()
        IxSIZE_TOTAL_COST = 32, 	// Size Total Cost : ()
        IxSIZEUP_CHARGE = 33, 	// Size Up Change : ()
        IxPRSS_CHARGE = 34, 	// Process Change : ()
        IxREF = 35, 	// Ref : ()
        IxVEN_CD = 36, 	// Ven Code : ()
        IxMCS_NO = 37, 	// MCS # : ()
        IxCOLOR_CD = 38, 	// Color Code : ()
        IxPART_NO = 39, 	// Part No : ()
        IxPART_SEQ = 40, 	// Part Seq : ()
        IxORDER_BY = 41, 	// Order by : ()
        IxSINGLE_YN = 42, 	// R/P : ()
        IxUPD_USER = 43, 	// Update User : ()
        IxUPD_YMD = 44 	// Update Date : ()
    }

    public enum TBSFX_CBD_TAIL_LB : int
    {
        IxMaxCt = 26,	// ¿Œµ¶Ω∫ Count
        IxDEV_FAC = 1, 	//   : VARCHAR2(5)
        IxMOID = 2, 	//   : VARCHAR2(20)
        IxCBD_ID = 3, 	//   : VARCHAR2(8)
        IxCBD_VER = 4, 	//   : VARCHAR2(3)
        IxFOB_TYPE_CD = 5, 	//   : VARCHAR2(10)
        IxTEMP0 = 6, 	//   : ()
        IxCBD_CLASS = 7, 	//   : VARCHAR2(10)
        IxSUB_CLASS = 8, 	//   : VARCHAR2(20)
        IxCURR = 9, 	//   : VARCHAR2(10)
        IxFX_RATE = 10, 	//   : NUMBER(22)
        IxPROCESS = 11, 	//   : VARCHAR2(50)
        IxWAGE_YR = 12, 	//   : NUMBER(22)
        IxDIRT_WORKER = 13, 	//   : NUMBER(22)
        IxDAY_PAID_YR = 14, 	//   : NUMBER(22)
        IxMIN_DAY_WORKER = 15, 	//   : NUMBER(22)
        IxEFFCTV_RATE = 16, 	//   : NUMBER(22)
        IxCOST_STD = 17, 	//   : NUMBER(22)
        IxSTD_MIN = 18, 	//   : NUMBER(22)
        IxCOST_LOCAL = 19, 	//   : NUMBER(22)
        IxCOST_USD = 20, 	//   : NUMBER(22)
        IxOV_COST = 21, 	//   : NUMBER(22)
        IxREF = 22, 	//   : VARCHAR2(10)
        IxCBD_NO = 23, 	//   : ()
        IxORDER_BY = 24, 	//   : ()
        IxUPD_USER = 25, 	//   : VARCHAR2(30)
        IxUPD_YMD = 26 	//   : DATE(7)
    }

    public enum TBSFX_CBD_TAIL_OH : int
    {
        IxMaxCt = 27,	// ¿Œµ¶Ω∫ Count
        IxCBD_NO = 1, 	//   : ()
        IxDEV_FAC = 2, 	//   : VARCHAR2(5)
        IxMOID = 3, 	//   : VARCHAR2(20)
        IxCBD_ID = 4, 	//   : VARCHAR2(8)
        IxCBD_VER = 5, 	//   : VARCHAR2(3)
        IxFOB_TYPE_CD = 6, 	//   : VARCHAR2(10)
        IxTEMP0 = 7, 	//   : ()
        IxCBD_CLASS = 8, 	//   : VARCHAR2(10)
        IxSUB_CLASS = 9, 	//   : VARCHAR2(20)
        IxCURR = 10, 	//   : VARCHAR2(10)
        IxFX_RATE = 11, 	//   : NUMBER(22)
        IxITEM = 12, 	//   : VARCHAR2(50)
        IxCOST_LOCAL = 13, 	//   : NUMBER(22)
        IxCOST_USD = 14, 	//   : NUMBER(22)
        IxTEMP1 = 15, 	//   : ()
        IxTEMP2 = 16, 	//   : ()
        IxTEMP3 = 17, 	//   : ()
        IxTEMP4 = 18, 	//   : ()
        IxTEMP5 = 19, 	//   : ()
        IxTEMP6 = 20, 	//   : ()
        IxTEMP7 = 21, 	//   : ()
        IxTEMP8 = 22, 	//   : ()
        IxREF = 23, 	//   : VARCHAR2(10)
        IxCBD_OH_NO = 24, 	//   : NUMBER(22)
        IxORDER_BY = 25, 	//   : ()
        IxUPD_USER = 26, 	//   : VARCHAR2(30)
        IxUPD_YMD = 27 	//   : DATE(7)
    }

    public enum TBSFX_CBD_TAIL_MOLD : int
    {
        IxMaxCt = 29,	// ¿Œµ¶Ω∫ Count
        IxCBD_NO = 1, 	//   : NUMBER(22)
        IxDEV_FAC = 2, 	//   : VARCHAR2(5)
        IxMOID = 3, 	//   : VARCHAR2(20)
        IxCBD_ID = 4, 	//   : VARCHAR2(8)
        IxCBD_VER = 5, 	//   : VARCHAR2(3)
        IxFOB_TYPE_CD = 6, 	//   : VARCHAR2(10)
        IxDIV = 7, 	//   : VARCHAR2(10)
        IxTEMP0 = 8, 	//   : ()
        IxCBD_CLASS = 9, 	//   : VARCHAR2(10)
        IxCOMPONENT = 10, 	//   : VARCHAR2(100)
        IxMOLD_TYPE = 11, 	//   : VARCHAR2(50)
        IxMOLD_CD = 12, 	//   : VARCHAR2(10)
        IxMOLD_DESC = 13, 	//   : VARCHAR2(50)
        IxMOLDA_CNT = 14, 	//   : NUMBER(22)
        IxMOLDB_CNT = 15, 	//   : NUMBER(22)
        IxCURR = 16, 	//   : VARCHAR2(10)
        IxFX_RATE = 17, 	//   : NUMBER(22)
        IxCOST_MOLDA = 18, 	//   : NUMBER(22)
        IxCOST_MOLDB = 19, 	//   : NUMBER(22)
        IxTOT_COST = 20, 	//   : NUMBER(22)
        IxTOT_COST_USD = 21, 	//   : NUMBER(22)
        IxAMORT_PAIRS = 22, 	//   : NUMBER(22)
        IxCOST_USD_PAIR = 23, 	//   : NUMBER(22)
        IxNOTE = 24, 	//   : VARCHAR2(100)
        IxPROD_PER_DAY = 25, 	//   : NUMBER(22)
        IxREF = 26, 	//   : VARCHAR2(10)
        IxORDER_BY = 27, 	//   : NUMBER(22)
        IxUPD_USER = 28, 	//   : VARCHAR2(30)
        IxUPD_YMD = 29 	//   : DATE(7)
    }

    public enum TBSFX_CBD_MASTER_SEARCH : int
    {
        IxMaxCt = 26,	// ¿Œµ¶Ω∫ Count
        IxCHK = 1, 	//   : ()
        IxCLASS_NAME = 2, 	// Class : ()
        IxDEV_FACTORY = 3, 	// Dev : ()
        IxPROD_FACTORY = 4, 	// Prod : ()
        IxSEASON_NAME = 5, 	// Season : ()
        IxCATEGORY_NAME = 6, 	// Category : ()
        IxROUND_TYPE = 7, 	// (Type) : ()
        IxMODEL_ID = 8, 	// ID : ()
        IxMODEL_NAME = 9, 	// Name : ()
        IxMOID = 10, 	// MOID : ()
        IxBOM = 11, 	// BOM : ()
        IxSTYLE_CD = 12, 	// Style # : ()
        IxFOB = 13, // FOB 
        IxISSUED_DATE = 14, 	// BOM Issued date : ()
        IxPCC_CHARGE = 15, 	// PCC Charge : ()
        IxCBD_CHARGE = 16, 	// CBD Charge : ()
        IxFOB_STATUS = 17, 	// FOB Status : ()
        IxQUOTED_DATE = 18, 	// Date Quoted : ()
        IxSR_NO = 19, 	// SR No : ()
        IxBOM_REV = 20, 	// BOM Rev : ()
        IxSRF_SEQ = 21, 	// SRF Seq : ()
        IxCBD_ID = 22, 	// CBD ID : ()
        IxCBD_VER = 23, 	// CBD Ver : ()
        IxFOB_TYPE_CD = 24, 	// FOB Type : ()
        IxSEASON_CD = 25, 	// Season : ()
        IxGEN_CD = 26 	// Gendor : ()
    }

    public enum TBSFX_CBD_MASTER_PRINT : int
    {
        IxMaxCt = 28,	// ¿Œµ¶Ω∫ Count
        IxCHK = 1, 	//   : ()
        IxCLASS_NAME = 2, 	// Class : ()
        IxCBD_ID_VIEW = 3, 	// CBD ID : ()
        IxXML_SEQ = 4, 	// XML Seq : ()
        IxDEV_FACTORY = 5, 	// Dev : ()
        IxPROD_FACTORY = 6, 	// Prod : ()
        IxSEASON_NAME = 7, 	// Season : ()
        IxCATEGORY_NAME = 8, 	// Category : ()
        IxROUND_TYPE = 9, 	// (Type) : ()
        IxMODEL_ID = 10, 	// ID : ()
        IxMODEL_NAME = 11, 	// Name : ()
        IxMOID = 12, 	// MOID : ()
        IxBOM = 13, 	// BOM : ()
        IxSTYLE_CD = 14, 	// Style # : ()
        IxFOB = 15, // FOB
        IxISSUED_DATE = 16, 	// BOM Issued date : ()
        IxPCC_CHARGE = 17, 	// PCC Charge : ()
        IxCBD_CHARGE = 18, 	// CBD Charge : ()
        IxFOB_STATUS = 19, 	// FOB Status : ()
        IxQUOTED_DATE = 20, 	// Date Quoted : ()
        IxSR_NO = 21, 	// SR No : ()
        IxBOM_REV = 22, 	// BOM Rev : ()
        IxSRF_SEQ = 23, 	// SRF Seq : ()
        IxCBD_ID = 24, 	// CBD ID : ()
        IxCBD_VER = 25, 	// CBD Ver : ()
        IxFOB_TYPE_CD = 26, 	// FOB Type : ()
        IxSEASON_CD = 27, 	// Season : ()
        IxGEN_CD = 28 	// Gendor : ()
    }

    #endregion

    #region CBD Option

    public enum TBSFM_CBD_OPT_BOM : int
    {
        IxMaxCt = 20,	                // ¿Œµ¶Ω∫ Count
        IxCBD_YN = 1, 	                //   : ()
        IxDEV_FAC = 2, 	                //   : ()
        IxPROD_FAC = 3, 	            //   : ()
        IxSEASON_CD = 4, 	            //   : ()
        IxSEASON_NAME = 5, 	            //   : ()
        IxCATEGORY_CD = 6, 	            //   : ()
        IxCATEGORY_NAME = 7, 	        //   : ()
        IxGEN = 8, 	                    //   : ()
        IxMODEL_ID = 9, 	            //   : ()
        IxMODEL_NAME = 10, 	            //   : ()
        IxMOID = 11, 	                //   : ()
        IxBOM_ID = 12, 	                //   : ()
        IxSTYLE_CD = 13, 	            //   : ()
        IxFOB_TYPE_CD = 14, 	        //   : ()
        IxFOB_TYPE_NAME = 15, 	        //   : ()
        IxPCC_DEV = 16, 	            //   : ()
        IxDATE_QUOTED = 17, 	        //   : ()
        IxCBD_ID = 18,          	    //   : ()
        IxCBD_VER = 19, 	            //   : ()
        IxPRODUCT_CD = 20 	            //   : ()
    }

    public enum TBSFM_CBD_OPT_HEAD : int
    {
        IxMaxCt = 12,	                // ¿Œµ¶Ω∫ Count
        IxDEV_FAC = 1, 	                //   : VARCHAR2(5)
        IxPROD_FAC = 2, 	            //   : VARCHAR2(5)
        IxMOID = 3, 	                //   : VARCHAR2(20)
        IxCBD_ID = 4, 	                //   : VARCHAR2(8)
        IxCBD_VER = 5, 	                //   : VARCHAR2(3)
        IxFOB_TYPE_CD = 6, 	            //   : VARCHAR2(10)
        IxOPT_SEQ = 7, 	                //   : VARCHAR2(3)
        IxOPT_CONTS = 8, 	            //   : VARCHAR2(200)
        IxOPT_DESC = 9, 	            //   : VARCHAR2(200)
        IxAPPLIED_YMD = 10, 	        //   : ()
        IxUPD_USER = 11, 	            //   : VARCHAR2(30)
        IxUPD_YMD = 12 	                //   : DATE(7)
    }

    public enum TBSFM_CBD_OPT_TAIL : int
    {
        IxMaxCt = 32,	                // ¿Œµ¶Ω∫ Count
        IxLEV = 1, 	                    // Lev : ()
        IxDEV_FAC = 2, 	                // Dev Fac : VARCHAR2(5)
        IxPROD_FAC = 3, 	            // Prod Fac : VARCHAR2(5)
        IxMOID = 4, 	                // MOID : VARCHAR2(20)
        IxCBD_ID = 5, 	                // CBD ID : VARCHAR2(8)
        IxCBD_VER = 6, 	                // CBD Ver : VARCHAR2(3)
        IxFOB_TYPE_CD = 7, 	            // FOB Type : VARCHAR2(10)
        IxOPT_SEQ = 8, 	                // Opt Seq : VARCHAR2(3)
        IxOPT_SEQ_NO = 9, 	            // Opt No : NUMBER(22)
        IxPART_NO = 10, 	            // Part No : VARCHAR2(50)
        IxPART_SEQ = 11, 	            // Part Seq : NUMBER(22)
        IxPART_NAME = 12, 	            // Part : VARCHAR2(100)
        IxSUBJECT = 13, 	            // Part : ()
        IxCBD_UP_NO = 14, 	            // CBD Up No : NUMBER(22)
        IxORG_MTL_CD = 15, 	            // Mat # : ()
        IxORG_MTL_NAME = 16, 	        // Material : ()
        IxORG_COLOR_CD = 17, 	        // Color Code : ()
        IxORG_COLOR_NAME = 18, 	        // Color : ()
        IxORG_UOM = 19, 	            // UOM : ()
        IxORG_FCT_LND = 20, 	        // FCT LND : ()
        IxORG_USAGE = 21, 	            // USAGE : ()
        IxORG_USS_COST = 22, 	        // US$ COST : ()
        IxOPT_MTL_CD = 23, 	            // Mat # : ()
        IxOPT_MTL_NAME = 24, 	        // Material : ()
        IxOPT_UOM = 25, 	            // UOM : ()
        IxOPT_FCT_LND = 26, 	        // FCT LND : ()
        IxOPT_USAGE = 27, 	            // USAGE : ()
        IxOPT_USS_COST = 28, 	        // US$ COST : ()
        IxOPT_DIFF = 29, 	            // Dif : ()
        IxUPD_YMD = 30, 	            // Update Date : DATE(7)
        IxUPD_USER = 31, 	            // Update User : VARCHAR2(30)
        IxTEMP = 32 	                // Temp : ()
    }

    public enum TBSXD_SRF_M_PART : int
    {
        IxMaxCt = 14,		            // ¿Œµ¶Ω∫ Count
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxPART_SEQ = 2,
        IxPART_NO = 3,
        IxPART_TYPE = 4,
        IxPART_DESC = 5,
        IxPART_COMMENT = 6,
        IxPART_DESC_KNAME = 7,
        IxUSE_YN = 8,
        IxSEND_CHK = 9,
        IxSEND_YMD = 10,
        IxSTATUS = 11,
        IxUPD_USER = 12,
        IxUPD_YMD = 13,
    }

    #endregion

    #region CBD Analysis

    public enum TBSFM_CBD_HEAD_3 : int
    {
        IxMaxCt = 29,	                // ¿Œµ¶Ω∫ Count
        IxCHK = 1, 	                    //   : ()
        IxCLASS_NAME = 2, 	            // Class : ()
        IxDEV_FAC = 3, 	                // Dev Fac : VARCHAR2(5)
        IxPROD_FAC = 4, 	            // Prod Fac : VARCHAR2(5)
        IxSEASON_NAME = 5, 	            // Season : ()
        IxCATEGORY_NAME = 6, 	        // Category : ()
        IxGEN = 7, 	                    // Gen : ()
        IxFOB_TYPE = 8, 	            // Type : VARCHAR2(20)
        IxMODEL_NAME = 9, 	            // Model : VARCHAR2(50)
        IxMOID = 10, 	                // MOID : VARCHAR2(20)
        IxBOM_ID = 11, 	                // BOM : VARCHAR2(8)
        IxSTYLE_CD = 12, 	            // Style # : VARCHAR2(15)
        IxSEQ = 13, 	                // Seq : ()
        IxOBS_ID = 14, 	                // ID : ()
        IxOBS_TYPE = 15, 	            // Type : ()
        IxTOT_FOB = 16, 	            // Total : ()
        IxDATE_QUOTED = 17, 	        // Quoted : DATE(7)
        IxPCC_COSTER = 18, 	            // Charge : VARCHAR2(30)
        IxUPD_YMD = 19, 	            // Date : DATE(7)
        IxCLASS_CD = 20, 	            // Class : VARCHAR2(5)
        IxMODEL_ID = 21, 	            // Model : VARCHAR2(15)
        IxSEASON_CD = 22, 	            // Season : VARCHAR2(6)
        IxCBD_ID = 23, 	                // CBD_ID : VARCHAR2(8)
        IxCBD_VER = 24, 	            // CBD_VER : NUMBER(22)
        IxSR_NO = 25, 	                // SR_NO : ()
        IxBOM_REV = 26, 	            // BOM_REV : VARCHAR2(3)
        IxNF_CD = 27, 	                // NF_CD : ()
        IxSRF_SEQ = 28,                 // SRF_SEQ : ()
        IxFILE_PATH = 29 	            // WORKSHEET FILE PATH : ()
    }

    #endregion

    #region CBD Comparison 

    public enum TBSFM_CBD_HEAD_4 : int
    {
        IxMaxCt = 25,	                // ¿Œµ¶Ω∫ Count
        IxCHK_BASE = 1, 	            // Base : ()
        IxCHK_COMP = 2, 	            // Compare : ()
        IxCLASS_NAME = 3, 	            // Class : ()
        IxDEV_FAC = 4, 	                // Dev Fac : VARCHAR2(5)
        IxPROD_FAC = 5, 	            // Prod Fac : VARCHAR2(5)
        IxSEASON_NAME = 6, 	            // Season : ()
        IxCATEGORY_NAME = 7, 	        // Category : ()
        IxGEN = 8, 	                    // Gen : ()
        IxFOB_TYPE = 9, 	            // Type : VARCHAR2(20)
        IxMODEL_NAME = 10, 	            // Model : VARCHAR2(50)
        IxMOID = 11, 	                // MOID : VARCHAR2(20)
        IxBOM_ID = 12, 	                // BOM : VARCHAR2(8)
        IxSTYLE_CD = 13, 	            // Style # : VARCHAR2(15)
        IxSEQ = 14, 	                // Seq : ()
        IxOBS_ID = 15, 	                // ID : ()
        IxOBS_TYPE = 16, 	            // Type : ()
        IxTOT_FOB = 17, 	            // Total : ()
        IxDATE_QUOTED = 18, 	        // Quoted : DATE(7)
        IxPCC_COSTER = 19, 	            // Charge : VARCHAR2(30)
        IxUPD_YMD = 20, 	            // Date : DATE(7)
        IxCBD_ID = 21, 	                // CBD ID : VARCHAR2(8)
        IxCBD_VER = 22, 	            // CBD Ver : NUMBER(22)
        IxCLASS_CD = 23, 	            // Class : VARCHAR2(5)
        IxMODEL_ID = 24, 	            // Model : VARCHAR2(15)
        IxSEASON_CD = 25 	            // Season : VARCHAR2(6)
    }

    public enum TBSFM_CBD_SUMMARY : int
    {
        IxMaxCt = 7,	                // ¿Œµ¶Ω∫ Count
        IxGROUP = 1, 	                //   : ()
        IxSUBJECT = 2, 	                //   : ()
        IxBASE_MODEL = 3, 	            //   : ()
        IxCOMPARE_1 = 4, 	            //   : ()
        IxDIFF_1 = 5, 	                //   : ()
        IxCOMPARE_2 = 6, 	            //   : ()
        IxDIFF_2 = 7 	                //   : ()
    }

    public enum TBSFM_CBD_SUMMARY_SUBJECT : int
    {
        IxMaxCt = 24,	                // ¿Œµ¶Ω∫ Count
        IxMODEL_NAME = 1, 	            // Model Name : ()
        IxMOID = 2, 	                // MOID : ()
        IxBOM_ID = 3, 	                // BOM ID : ()
        IxSTYLE_CD = 4, 	            // Style No : ()
        IxPCC_DEV = 5, 	                // PCC Dev : ()
        IxPCC_COSTER = 6, 	            // CBD Charge : ()
        IxFOB_TYPE = 7, 	            // FOB Type : ()
        IxFOB_STATUS = 8, 	            // FOB Status : ()
        IxDATE_QUOTED = 9, 	            // Date Quote : ()
        IxUPPER_SUMM_CBD = 10, 	        // Upper Material : ()
        IxPACKING_SUMM_CBD = 11, 	    // Packaging : ()
        IxMIDSOLE_SUMM_CBD = 12, 	    // Midsole : ()
        IxOUTSOLE_SUMM_CBD = 13, 	    // Outsole : ()
        IxSIZEUP_SUMM_CBD = 14, 	    // Size Up : ()
        IxMATERIAL_TOTAL = 15, 	        // Material Subtotal : ()
        IxLABOR_SUMM_CBD = 16, 	        // Labor : ()
        IxOVERHEAD_SUMM_CBD = 17, 	    // Overhead : ()
        IxPROFIT_SUMM_CBD = 18, 	    // Profit (Before Tooling) : ()
        IxOTHERADJ_SUMM_CBD = 19, 	    // Other Adjustments : ()
        IxNON_MATERIAL_TOTAL = 20, 	    // Non Material Subtotal : ()
        IxSMPL_TOOL_SUMM_CBD = 21, 	    // Sample Tooling : ()
        IxPROD_TOOL_SUMM_CBD = 22, 	    // Production Tooling : ()
        IxTOOLING_TOTAL = 23, 	        // Tooling Subtotal : ()
        IxCBD_TOTAL = 24 	            // Total FOB with Tooling : ()
    }

    #endregion

    #region New XML BOM Loading

    public enum TBSXD_SRF_TAIL_LOAD_NEW : int
    {
        IxMaxCt = 29,

        IxDIVISION = 0,

        IxFACTORY = 1,
        IxSR_NO = 2,
        IxSRF_NO = 3,
        IxBOM_ID = 4,
        IxBOM_REV = 5,
        IxNF_CD = 6,
        IxPART_NO = 7,
        IxPART_TYPE = 8,
        IxPART_NAME = 9,
        IxPART_COMMENT = 10,
        IxPART_QTY = 11,
        IxMAT_CD = 12,
        IxMAT_NAME = 13,
        IxMAT_COMMENT = 14,
        IxMAT_DESC = 15,
        IxMAT_SIZE = 16,
        IxMAT_MIN = 17,
        IXMAT_MAX = 18,
        IxMAT_STATE = 19,
        IxMAT_TYPE = 20,
        IxCOLOR_CD = 21,
        IxCOLOR_DESC = 22,
        IxCOLOR_COMMENT = 23,
        IxMCS_CD = 24,
        IxMXS_NUMBER = 25,
        IxSTATUS = 26,
        IxUPD_USER = 27,
        IxUPD_YMD = 28,
    }
    public enum TBSXD_SRF_ORDER_LOAD_NEW : int
    {
        IxMaxCt = 24,		// ¿Œµ¶Ω∫ Count

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxSR_NO = 2,
        IxSRF_NO = 3,
        IxBOM_ID = 4,
        IxBOM_REV = 5,
        IxNF_CD = 6,
        IxSIZE_CD = 7,
        IxORD_TYPE = 8,
        IxSR_LINE_ITEM = 9,
        IxSIDE_TYPE = 10,
        IxORD_QTY = 11,
        IxREQUESTER = 12,
        IxORD_YMD = 13,
        IxNEED_BY = 14,
        IxDESTINATION = 15,
        IxGEN_CD = 16,
        IxWIDTH = 17,
        IxFIT = 18,
        IxAGE = 19,
        IxATTN = 20,
        IxNIKE_FLG = 21,
        IxSTATUS = 22,
        IxUPD_USER = 23,

    }
    public enum TBSXD_SRF_RULE_LOAD_NEW : int
    {
        IxMaxCt = 24,		// ¿Œµ¶Ω∫ Count
        IxDIVISION = 0,

        IxFACTORY = 1,
        IxSR_NO = 2,
        IxSRF_NO = 3,
        IxBOM_ID = 4,
        IxBOM_REV = 5,
        IxNF_CD = 6,
        IxRULE_TYPE = 7,
        IxREGION = 8,
        IxEXCLUSIVE_TYPE = 9,
        IxEXCLUSIVE_TO = 10,
        IxSTATUS = 11,
        IxUPD_USER = 12,
        IxUPD_YMD = 13,

    }

    #endregion

    #region 5523 and meof 

    public enum TBEBM_FOB_5523_HEAD : int
    {
        IxMaxCt = 21,	// ¿Œµ¶Ω∫ Count
        IxCHK = 1, 	//   : ()
        IxFACTORY = 2, 	// Factory : ()
        IxSTYLE_CD = 3, 	// Style : ()
        IxREGION = 4, 	// Region : ()
        IxBOM_ID = 5, 	// BOM ID : ()
        IxPROD_CODE = 6, 	// Product Code : ()
        IxDEV_CODE = 7, 	// Dev Code : ()
        IxPROD_NAME = 8, 	// Product Name : ()
        IxPROD_TYPE = 9, 	// Product type : ()
        IxSEASON_CD = 10, 	// Season : ()
        IxAPP_YMD = 11, 	// Applied Date : ()
        IxLEATHER_PCT = 12, 	// Leather : ()
        IxSYNTHETIC_PCT = 13, 	// synthetic : ()
        IxTEXTILE_PCT = 14, 	// Textile : ()
        IxOTHER_PCT = 15, 	// Other : ()
        IxREMARKS = 16, 	// Remarks : ()
        IxSTATUS = 17, 	// Status : ()
        IxUPD_USER = 18, 	// User : ()
        IxUPD_YMD = 19, 	// Date : ()
        IxUPDATE_FACTORY = 20, 	// Upload factory : ()
        IxDETAIL_YN = 21, 	// Detail : ()
        IxFOB_TYPE = 22 	// Fob Type : ()
    }

    public enum TBEBM_FOB_5523_TAIL : int
    {
        IxMaxCt = 13,	// ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	// Factory : ()
        IxSTYLE_CD = 2, 	// Style : ()
        IxREGION = 3, 	// Region : ()
        IxSEQ = 4, 	// Seq : ()
        IxCOMP_DIV = 5, 	// Component division : ()
        IxCOMP_NAME = 6, 	// Component name : ()
        IxMEASUAL_DATA = 7, 	// Measurement data : ()
        IxBOM_COMP_READ = 8, 	// BOM Component reading : ()
        IxREMARKS = 9, 	// Remarks : ()
        IxSTATUS = 10, 	// Status : ()
        IxUPD_USER = 11, 	// User : ()
        IxUPD_YMD = 12, 	// Date : ()
        IxUPDATE_FACTORY = 13, 	// Upload factory : ()
        IxDEV_CODE = 14, 	// Dev Code : ()
        IxFOB_TYPE = 15, 	// Fob Type : ()
        IxBOM_ID = 16 	// BOM ID : ()
    }

    public enum TBEBM_FOB_5523_TAIL_2 : int
    {
        IxMaxCt = 5,	// ¿Œµ¶Ω∫ Count
        IxSEQ = 1, 	// Seq : ()
        IxREGION = 2, 	// Region : ()
        IxCOMP_DIV = 3, 	//   : ()
        IxCOMP_NAME = 4, 	// Component : ()
        IxMEASUAL_DATA = 5 	// Measurement data : ()
    }

    public enum TBEBM_FOB_MEOF_HEAD_1 : int
    {
        IxMaxCt = 11,	// ¿Œµ¶Ω∫ Count
        IxROW_NAME = 1, 	//   : ()
        IxSUBJECT = 2, 	//   : ()
        IxCELL_ROW = 3, 	//   : ()
        IxCELL_COL = 4, 	//   : ()
        IxMOLD_1 = 5, 	//   : ()
        IxMOLD_2 = 6, 	//   : ()
        IxMOLD_3 = 7, 	//   : ()
        IxMOLD_4 = 8, 	//   : ()
        IxMOLD_5 = 9, 	//   : ()
        IxMOLD_6 = 10, 	//   : ()
        IxMOLD_7 = 11 	//   : ()
    }

    public enum TBEBM_FOB_MEOF_HEAD_2 : int
    {
        IxMaxCt = 35,	// ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	// Factory : ()
        IxMOID = 2, 	// MOID : ()
        IxPIM_SEQ = 3, 	// Seq : ()
        IxSEASON_CD = 4, 	// Season Code : ()
        IxPART_TYPE = 5, 	// Type of Part : ()
        IxMOLD_CD = 6, 	// Mold Code : ()
        IxLAST_CD = 7, 	// Last Code : ()
        IxDEV_MOLD_SHOP = 8, 	// Dev. Mold Shop : ()
        IxPROD_MOLD_SHOP = 9, 	// Prod. Mold Shop : ()
        IxMOLD_MAT = 10, 	// Mold Material : ()
        IxMOLD_MFG_TECH = 11, 	// Mold MFG Technology : ()
        IxMOLDED_MAT = 12, 	// Molded Material : ()
        IxSAMP_MOLD_COST = 13, 	// Mold Cost - Sample : ()
        IxMOLD_A_COST = 14, 	// "A" Mold Cost : ()
        IxMOLD_B_COST = 15, 	// "B" Mold Cost : ()
        IxMOLD_ROUND = 16, 	// Mold Round : ()
        IxCOMP_SHARED = 17, 	// Comp. Shared With : ()
        IxSHIFT_PER_DAY = 18, 	// Shifts Per Day : ()
        IxHOURS_PER_SHIFT = 19, 	// Hours Per Shift : ()
        IxHOURS_PER_DAY = 20, 	// Hours Per Day : ()
        IxWORKING_DAYS = 21, 	// Working Days : ()
        IxEFFICIENCY_RATE = 22, 	// Efficiency % : ()
        IxPAIRS_PER_DAY = 23, 	// Pairs Per Day : ()
        IxPEAK_PAIRAGE = 24, 	// Peak Pairage : ()
        IxAMORT_PAIRAGE = 25, 	// Amortization Pairage : ()
        IxMOLD_A_QTY = 26, 	// "A" Molds Required : ()
        IxMOLD_B_QTY = 27, 	// Est.  Extra Molds : ()
        IxMDF = 28, 	// MDF : ()
        IxSIZE_RUN = 29, 	// Size Run : ()
        IxREMARKS = 30, 	// Remarks : ()
        IxSTATUS = 31, 	// Status : ()
        IxUPD_USER = 32, 	// User : ()
        IxUPD_YMD = 33, 	// Date : ()
        IxUPDATE_FACTORY = 34, 	// Update Factory : ()
        IxPIM_COUNT = 35 	// Count : ()
    }

    public enum TBEBM_FOB_MEOF_HEAD_4 : int
    {
        IxMaxCt = 31,	// ¿Œµ¶Ω∫ Count
        IxPART_TYPE = 1, 	// Type of Part : ()
        IxPIM_SEQ = 2, 	// Seq : ()
        IxPIM = 3, 	// PIM : ()
        IxMOLD_CD = 4, 	// Mold Code : ()
        IxLAST_CD = 5, 	// Last Code : ()
        IxDEV_MOLD_SHOP = 6, 	// Dev. Mold Shop : ()
        IxPROD_MOLD_SHOP = 7, 	// Prod. Mold Shop : ()
        IxMOLD_MAT = 8, 	// Mold Material : ()
        IxMOLD_MFG_TECH = 9, 	// Mold MFG Technology : ()
        IxMOLDED_MAT = 10, 	// Molded Material : ()
        IxSAMP_MOLD_COST = 11, 	// Mold Cost - Sample : ()
        IxMOLD_A_COST = 12, 	// "A" Mold Cost : ()
        IxMOLD_B_COST = 13, 	// "B" Mold Cost : ()
        IxMOLD_ROUND = 14, 	// Mold Round : ()
        IxCOMP_SHARED = 15, 	// Comp. Shared With : ()
        IxSHIFT_PER_DAY = 16, 	// Shifts Per Day : ()
        IxHOURS_PER_SHIFT = 17, 	// Hours Per Shift : ()
        IxHOURS_PER_DAY = 18, 	// Hours Per Day : ()
        IxWORKING_DAYS = 19, 	// Working Days : ()
        IxEFFICIENCY_RATE = 20, 	// Efficiency % : ()
        IxPAIRS_PER_DAY = 21, 	// Pairs Per Day : ()
        IxPEAK_PAIRAGE = 22, 	// Peak Pairage : ()
        IxAMORT_PAIRAGE = 23, 	// Amortization Pairage : ()
        IxMOLD_A_QTY = 24, 	// "A" Molds Required : ()
        IxMOLD_B_QTY = 25, 	// Est.  Extra Molds : ()
        IxMDF = 26, 	// MDF : ()
        IxSIZE_RUN = 27, 	// Size Run : ()
        IxREMARKS = 28, 	// Remarks : ()
        IxUPD_USER = 29, 	// User : ()
        IxUPD_YMD = 30, 	// Date : ()
        IxUPDATE_FACTORY = 31 	// Update Factory : ()
    }

    public enum TBEBM_FOB_MEOF_TAIL : int
    {
        IxMaxCt = 98,	// ¿Œµ¶Ω∫ Count
        Ix1_MOLD_CD = 1, 	//   : ()
        Ix1_PIM_SEQ = 2, 	//   : ()
        Ix1_SEQ = 3, 	//   : ()
        Ix1_CS_SIZE = 4, 	//   : ()
        Ix1_SIZE_PCT = 5, 	//   : ()
        Ix1_SIZE_PAIRS = 6, 	//   : ()
        Ix1_MOLD_REQ = 7, 	//   : ()
        Ix1_PIM = 8, 	//   : ()
        Ix1_MD = 9, 	//   : ()
        Ix1_REMARKS = 10, 	//   : ()
        Ix1_STATUS = 11, 	//   : ()
        Ix1_UPD_USER = 12, 	//   : ()
        Ix1_UPD_YMD = 13, 	//   : ()
        Ix1_UPDATE_FACTORY = 14 	//   : ()
    }

    #endregion

    #region Search material by other CBD

    public enum TBSFX_CBD_HEAD_COPY : int
    {
        IxMaxCt = 18,	// ¿Œµ¶Ω∫ Count
        IxSTATUS = 1, 	// Status : ()
        IxDEV_FAC = 2, 	// Dev Factory : ()
        IxPROD_FAC = 3, 	// Prod Factory : ()
        IxSEASON = 4, 	// Season : ()
        IxCATEGORY = 5, 	// Category : ()
        IxGEN = 6, 	// GEN : ()
        IxMODEL_ID = 7, 	// Model ID : ()
        IxMODEL_NAME = 8, 	// Model : ()
        IxMOID = 9, 	// MOID : ()
        IxBOM_ID = 10, 	// BOM ID : ()
        IxCBD_ID = 11, 	// CBD ID : ()
        IxCBD_VER = 12, 	// CBD Ver : ()
        IxSTYLE_CD = 13, 	// Style No : ()
        IxFOB_TYPE_CD = 14, 	// Fob Type : ()
        IxPCC_COSTER = 15, 	// Charge : ()
        IxDATE_QUOTED = 16, 	// Date Quoted : ()
        IxSTATUS_CD = 17, 	// Status Code : ()
        IxSEASON_CD = 18 	// Season Code : ()
    }

    #endregion

    #endregion

    #region General

    #region Bottom

    public enum TBSFB_CBD_B_MAT_BTTM : int
    {
        IxMaxCt = 19,	                // ¿Œµ¶Ω∫ Count
        IxCHK = 1, 	                    //   : ()
        IxFACTORY = 2, 	                // Factory : VARCHAR2(5)
        IxMAT_CD = 3, 	                // Code : VARCHAR2(15)
        IxITEM_GROUP = 4, 	            // Group : VARCHAR2(10)
        IxSEPH_NAME = 5, 	            // Name : VARCHAR2(500)
        IxCBD_NAME = 6, 	            // for English : VARCHAR2(100)
        IxMTRL_CLASS = 7, 	            // Class : ()
        IxCOMP_CLASS = 8, 	            // Comp's Class : ()
        IxVEN_CD = 9, 	                // Code : VARCHAR2(10)
        IxVEN_SEPH_NAME = 10, 	        // Name : VARCHAR2(100)
        IxVEN_CBD_NAME = 11, 	        // for CBD English : VARCHAR2(100)
        IxCURR = 12, 	                // Currency : VARCHAR2(10)
        IxCBD_UNIT_PRICE = 13, 	        // Unit Price : ()
        IxSEPH_UNIT_PRICE = 14,         // Changed : ()
        IxAPP_DATE = 15, 	            // App date : VARCHAR2(8)
        IxUSE_YN = 16, 	                // Used : VARCHAR2(1)
        IxUPD_USER = 17, 	            // User : VARCHAR2(30)
        IxUPD_YMD = 18, 	            // Date : DATE(7)
        IxCBD_YN = 19 	                // CBD Y/N : ()
    }


    public enum TBSFB_CBD_B_FORMU_COLOR_HEAD : int
    {
        IxMaxCt = 13,	                // ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	                // Factory : VARCHAR2(5)
        IxDIV = 2, 	                    // Diviaion : VARCHAR2(20)
        IxCOLOR_CD = 3, 	            // Code : VARCHAR2(10)
        IxCOLOR_NAME = 4, 	            // Name : VARCHAR2(100)
        IxTEMP1 = 5, 	                //   : ()
        IxAPP_YMD = 6, 	                // Applied Date : ()
        IxUSE_YN = 7, 	                // Used : VARCHAR2(1)
        IxSTD_COLOR_TYPE_CD = 8, 	    // Std color type : VARCHAR2(10)
        IxSTD_COLOR_TYPE = 9, 	        // Color type : VARCHAR2(10)
        IxMARGIN_PCT = 10, 	            // Margin : NUMBER(22)
        IxUPD_YMD = 11, 	            // Update date : DATE(7)
        IxUPD_USER = 12, 	            // Update user : VARCHAR2(30)
        IxTEMP_COL = 13 	            // Temp col : ()
    }

    public enum TBSFB_CBD_B_FORMU_COLOR_TAIL : int
    {
        IxMaxCt = 22,	                // ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	                // Factory : VARCHAR2(5)
        IxCLASS_NAME = 2, 	            // Class : ()
        IxCMP_CD = 3, 	                // Code : ()
        IxCBD_NAME = 4, 	            // Name : VARCHAR2(100)
        IxPDPB_ACT_PCT = 5, 	        // Active(%) : NUMBER(22)
        IxWEIGHT_GR = 6, 	            // (grams) : NUMBER(22)
        IxPDPB_FILLER = 7, 	            // PDPB : NUMBER(22)
        IxPHR = 8, 	                    // PHR : NUMBER(22)
        IxACT_PHR = 9, 	                // PHR : NUMBER(22)
        IxSP_GR = 10, 	                // GR. : NUMBER(22)
        IxVOLM = 11, 	                // (L) : NUMBER(22)
        IxUNIT_PRICE = 12, 	            // US/Kg : NUMBER(22)
        IxCBD_PRICE = 13, 	            // CBD : ()
        IxPRICE_BATCH = 14, 	        // US/Batch : NUMBER(22)
        IxVEN_CBD_NAME = 15, 	        // Vendor : VARCHAR2(100)
        IxAPP_DATE = 16, 	            // Update date : VARCHAR2(8)
        IxUPD_YMD = 17, 	            // Date : DATE(7)
        IxUPD_USER = 18, 	            // User : VARCHAR2(30)
        IxCOLOR_CD = 19, 	            // Color : VARCHAR2(10)
        IxF_COLOR = 20, 	            // Class : ()
        IxVEN_CD = 21, 	                // Vendor : VARCHAR2(10)
        IxTEMP_COL = 22 	            // Temp : ()
    }

    public enum TBSFB_CBD_B_FORMU_HEAD : int
    {
        IxMaxCt = 25,	                // ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	                // Factory : ()
        IxDIVISION = 2, 	            // Division : ()
        IxMCS_NO = 3, 	                // MCS # : VARCHAR2(50)
        IxCOLOR_CD = 4, 	            // Color : VARCHAR2(10)
        IxCOLOR_NAME = 5, 	            // Color : VARCHAR2(100)
        IxCOLOR_TYPE = 6, 	            // Type : ()
        IxBTTM_TYPE = 7, 	            // Type : VARCHAR2(20)
        IxMATERIAL = 8, 	            // Material : VARCHAR2(50)
        IxCOST_KG = 9, 	                // KG : NUMBER(22)
        IxPDPB_TOT = 10, 	            // Total : NUMBER(22)
        IxPOLYMER_TOT = 11, 	        // Total : NUMBER(22)
        IxSG_AVG = 12, 	                // AVG S.G : NUMBER(22)
        IxMIX_CAPA = 13, 	            // CAPA : NUMBER(22)
        IxSG_ACTUAL = 14, 	            // SG : NUMBER(22)
        IxAPP_DATE = 15, 	            // App Date : VARCHAR2(8)
        IxUTIL_CAPA_PCT = 16, 	        // CAPA Util : NUMBER(22)
        IxTARGET_WT = 17, 	            // Batch : NUMBER(22)
        IxUSE_YN = 18, 	                // Used : VARCHAR2(1)
        IxLOCK_YN = 19, 	            // Lock : CHAR(1)
        IxUPD_YMD = 20, 	            // Update date : DATE(7)
        IxUPD_USER = 21, 	            // Update user : VARCHAR2(30)
        IxFORMULA_TYPE = 22, 	        // Type : ()
        IxMCS_REMARK = 23, 	            // Remarks : VARCHAR2(10)
        IxCOLOR_MARGIN_PCT = 24, 	    // Margin : NUMBER(22)
        IxMUTI_FACTORY = 25 	        // Multi Factory : ()
    }

    public enum TBSFB_CBD_B_FORMU_TAIL : int
    {
        IxMaxCt = 23,	                // ¿Œµ¶Ω∫ Count
        IxFACTORY = 1, 	                // Factory : ()
        IxCLASS_NAME = 2, 	            // Class : ()
        IxCMP_CD = 3, 	                // Code : ()
        IxCBD_NAME = 4, 	            // Name : ()
        IxPDPB_ACT_PCT = 5, 	        // Active(%) : NUMBER(22)
        IxWEIGHT_GR = 6, 	            // (grams) : NUMBER(22)
        IxPDPB_FILLER = 7, 	            // PDPB : NUMBER(22)
        IxPHR = 8, 	                    // PHR : NUMBER(22)
        IxACT_PHR = 9, 	                // PHR : NUMBER(22)
        IxSP_GR = 10, 	                // GR. : NUMBER(22)
        IxVOLM = 11, 	                // (L) : NUMBER(22)
        IxUNIT_PRICE = 12, 	            // US/Kg : ()
        IxCBD_PRICE = 13, 	            // CBD : ()
        IxPRICE_BATCH = 14, 	        // US/Batch : ()
        IxVEN_CBD_NAME = 15, 	        // Vendor : VARCHAR2(100)
        IxAPP_DATE = 16, 	            // Update date : VARCHAR2(8)
        IxUPD_YMD = 17, 	            // Date : DATE(7)
        IxUPD_USER = 18, 	            // User : VARCHAR2(30)
        IxMCS_NO = 19, 	                // MCS # : VARCHAR2(20)
        IxCOLOR_CD = 20, 	            // Color Code : VARCHAR2(10)
        IxF_CLASS = 21, 	            // F Class : VARCHAR2(10)
        IxVEN_CD = 22, 	                // Vendor : VARCHAR2(10)
        IxTEMP_COL = 23 	            // Temp : ()
    }

    public enum TBSFB_CBD_B_MAT_BTTM_COST : int
    {
        IxMaxCt = 6,	                // ¿Œµ¶Ω∫ Count
        IxROW_NAME = 1, 	            // Row name : ()
        IxFACTORY = 2, 	                // Factory : ()
        IxDIV = 3, 	                    // Div : ()
        IxDIV_NAME = 4, 	            // Division : ()
        IxMCS_NO = 5, 	                // MCS # : ()
        IxREMARKS = 6 	                // Remarks : ()
    }

    public enum TBSFM_CBD_HEAD_WITH_BOM : int
    {
        IxMaxCt = 25,	// ¿Œµ¶Ω∫ Count
        IxCHK = 1, 	//   : ()
        IxCLASS_NAME = 2, 	// Class : ()
        IxDEV_FACTORY = 3, 	// Dev : ()
        IxPROD_FACTORY = 4, 	// Prod : ()
        IxSEASON_NAME = 5, 	// Season : ()
        IxCATEGORY_NAME = 6, 	// Category : ()
        IxROUND_TYPE = 7, 	// (Type) : ()
        IxMODEL_ID = 8, 	// ID : ()
        IxMODEL_NAME = 9, 	// Name : ()
        IxMOID = 10, 	// MOID : ()
        IxBOM = 11, 	// BOM : ()
        IxSTYLE_CD = 12, 	// Style # : ()
        IxISSUED_DATE = 13, 	// BOM Issued date : ()
        IxPCC_CHARGE = 14, 	// PCC Charge : ()
        IxCBD_CHARGE = 15, 	// CBD Charge : ()
        IxFOB_STATUS = 16, 	// FOB Status : ()
        IxQUOTED_DATE = 17, 	// Date Quoted : ()
        IxSR_NO = 18, 	// SR No : ()
        IxBOM_REV = 19, 	// BOM Rev : ()
        IxSRF_SEQ = 20, 	// SRF Seq : ()
        IxCBD_ID = 21, 	// CBD ID : ()
        IxCBD_VER = 22, 	// CBD Ver : ()
        IxFOB_TYPE_CD = 23, 	// FOB Type : ()
        IxSEASON_CD = 24, 	// Season : ()
        IxGEN_CD = 25 	// Gendor : ()
    }


    public enum TBPRO_COST_STYLE : int
    {
        IxMaxCt = 10,	                // ¿Œµ¶Ω∫ Count
        IxSTYLE_ID = 1, 	            //   : ()
        IxSEASON_NAME = 2, 	            //   : ()
        IxCATEGORY_NAME = 3, 	        //   : ()
        IxUSER = 4, 	                //   : ()
        IxSTYLE_NAME = 5, 	            //   : ()
        IxBASIC_SIZE = 6, 	            //   : ()
        IxDESCRIPTION = 7, 	            //   : ()
        IxSEMI_FILE = 8, 	            //   : ()
        IxCREATE_DATE = 9, 	            //   : ()
        IxUPD_YMD = 10 	                //   : ()
    }

    public enum TBSFM_CBD_PART : int
    {
        IxMaxCt = 34,	                // ¿Œµ¶Ω∫ Count
        IxLEV = 1, 	                    // Level : ()
        IxDEV_FAC = 2, 	                // Dev Fac : ()
        IxPROD_FAC = 3, 	            // Prod Fac : ()
        IxMOID = 4, 	                // MOID : ()
        IxCBD_ID = 5, 	                // CBD ID : ()
        IxCBD_VER = 6, 	                // CBD Ver : ()
        IxFOB_TYPE_CD = 7, 	            // FOB Type : ()
        IxCBD_NO = 8, 	                // CBD # : ()
        IxPTN_SEQ = 9, 	                // Pattern Seq : ()
        IxPART_NO = 10, 	            // Part # : ()
        IxPART_TYPE = 11, 	            // Part Type : ()
        IxPART_CLASS = 12, 	            // Part Class : ()
        IxPART_SEQ = 13, 	            // Part Seq : ()
        IxPART_NAME = 14, 	            // Part Name : ()
        IxPTTN_CNT = 15, 	            // Count : ()
        IxID_STYLE_PATTERN = 16, 	    //   : ()
        IxID_PATTERN_GEO = 17, 	        //   : ()
        IxID_PATTERN_MAT = 18, 	        //   : ()
        IxPATT_NAME = 19, 	            // Part Name : ()
        IxPART_GAP = 20, 	            // Part Gap (mm) : ()
        IxPARTS_PER_PAIR = 21, 	        // Parts Per Pair : ()
        IxEFFIC = 22, 	                // Efficiency : ()
        IxYIELD_FLD = 23, 	            // Yield FLD : ()
        IxYIELD_UNIT = 24, 	            // Yield Unit : ()
        IxYIELD_PAIR = 25, 	            // Yield Pair : ()
        IxW_L = 26, 	                // W*L : ()
        IxWEIGHT = 27, 	                // Weight : ()
        IxLENGTH = 28, 	                // Length : ()
        IxMARGIN_L = 29, 	            // Margin : ()
        IxMARGIN_L_UNIT = 30, 	        // Margin : ()
        IxMARGIN_R = 31, 	            // Margin : ()
        IxMARGIN_R_UNIT = 32, 	        // Margin : ()
        IxUPD_USER = 33, 	            // Update user : ()
        IxUPD_YMD = 34 	                // Update date : ()
    }

    public enum TBSFM_PROCOST_PART : int
    {
        IxMaxCt = 17,	// ¿Œµ¶Ω∫ Count
        IxID_STYLE_PATTERN = 1, 	//   : ()
        IxID_PATTERN_GEO = 2, 	//   : ()
        IxID_PATTERN_MAT = 3, 	//   : ()
        IxPATT_NAME = 4, 	// Part Name : ()
        IxPART_GAP = 5, 	// Part Gap (mm) : ()
        IxPARTS_PER_PAIR = 6, 	// Parts Per Pair : ()
        IxEFFIC = 7, 	// Efficiency : ()
        IxYIELD_FLD = 8, 	// Yield FLD : ()
        IxYIELD_UNIT = 9, 	// Yield Unit : ()
        IxYIELD_PAIR = 10, 	// Yield Pair : ()
        IxW_L = 11, 	// W*L : ()
        IxWEIGHT = 12, 	// Weight : ()
        IxLENGTH = 13, 	// Length : ()
        IxMARGIN_L = 14, 	// Margin : ()
        IxMARGIN_L_UNIT = 15, 	// Margin : ()
        IxMARGIN_R = 16, 	// Margin : ()
        IxMARGIN_R_UNIT = 17 	// Margin : ()
    }

    #endregion

    #region Tooling

    /// <summary> 
    /// SFB_CBD_B_TOOLING_CLASS ≈◊¿Ã∫Ì ¿Œµ¶Ω∫ Enum 
    /// </summary> 
    public enum TBSFB_CBD_B_TOOLING_CLASS : int
    {
        IxMaxCt = 9,		    // ¿Œµ¶Ω∫ Count 
        IxDEV_FAC = 1,			// Develop Factory	:VARCHAR2(5) 
        IxTOOL_DIV = 2,			// Department or team division for Tooling control." 	:VARCHAR2(10) 
        IxTOOL_TYPE_CD = 3,			// Tooling Big Group: SCM_CODE.SFB_33	:VARCHAR2(10) 
        IxTOOL_CLASS_CD = 4,			// Tooling Classification code: it makes like TOOLING_DIV(PE or TE) + Sequential(3 Charecter=001,002...) 	:VARCHAR2(10) 
        IxTOOL_CLASS = 5,			// Tooling Classification	:VARCHAR2(100) 
        IxCBD_CALCU_YN = 6,			// Applied or Not Tooling items to CBD master calculation	:VARCHAR2(1) 
        IxUSE_YN = 7,			// Use or not	:VARCHAR2(1) 
        IxUPD_USER = 8,			// 	:VARCHAR2(30) 
        IxUPD_YMD = 9,			// 	:DATE(7) 
    }

    /// <summary>
    /// TBSFM_CBD_TOOLING_HEAD : 
    /// </summary>
    public enum TBSFM_CBD_TOOLING_HEAD : int
    {
        IxPM_STATUS = 1,
        IxDEV_FAC = 2,
        IxPROD_FAC = 3,
        IxMODEL_NAME = 4,
        IxMOID = 5,
        IxTD_CD = 6,
        IxTD = 7,
        IxSEASON = 8,
        IxCAT_CD = 9,
        IxCATEGORY = 10,
        IxGENDER = 11,
        IxSIZE_REP = 12,
        IxCBD_CHARGE = 13,
        IxWHQ_DEV = 14,
        IxNLO_DEV = 15,
        IxPCC_DEV = 16,
        IxPCC_PE = 17,
        IxPCC_TE = 18,
        IxREMARKS = 19,
        IxUPD_USER = 20,
        IxUPD_YMD = 21,
    }

    /// <summary>
    /// TBSFM_CBD_TOOLING_TAIL 
    /// </summary>
    public enum TBSFM_CBD_TOOLING_TAIL : int
    {
        IxDEV_FAC = 1,
        IxPROD_FAC = 2,
        IxMOID = 3,
        IxTOOL_NO = 4,
        IxNIKE_CBD_YN = 5,
        IxPM_CHK_YN = 6,
        IxT_CLASS = 7,
        IxTOOL_DIV = 8,
        IxORDER_DATE = 9,
        IxFOB_TYPE_CD = 10,
        IxSIZE_REP = 11,
        IxCOMPONENT = 12,
        IxTOOLING_DESC = 13,
        IxITEM_CD = 14,
        IxITEM_NAME = 15,
        IxTOOLING_SPEC_CD = 16,
        IxTOOLING_SPEC = 17,
        IxTOOLING_COLOR_CD = 18,
        IxTOOLING_COLOR = 19,
        IxTOOL_TYPE_CD = 20,
        IxTOOL_TYPE = 21,
        IxNIKE_MOLD_CD = 22,
        IxTOOL_MAT_CD = 23,
        IxMOLD_SHOP_CD = 24,
        IxMOLD_SHOP = 25,
        IxUOM = 26,
        IxCURR = 27,
        IxUNIT_COST = 28,
        IxTOOLING_QTY = 29,
        IxCOST_AMT = 30,
        IxMOLD_IN_DATE = 31,
        IxSHIP_PLAN_DATE = 32,
        IxSHIPPING_STATUS = 33,
        IxSTEP_CD = 34,
        IxTEAM_CD = 35,
        IxREMARK = 36,
        IxUPD_USER = 37,
        IxUPD_YMD = 38,

    }


    public enum TBSFM_CBD_TOOLING_SHARE_HEAD_TREE : int
    {
        IxDISPLAY_LEVEL = 1,
        IxSHARE_YN = 2,
        IxREP_DEV_FAC = 3,
        IxREP_PROD_FAC = 4,
        IxREP_SEASON_CD = 5,
        IxREP_SEASON = 6,
        IxREP_CAT_CD = 7,
        IxREP_CATEGORY = 8,
        IxREP_MODEL_NAME = 9,
        IxREP_MODEL_ID = 10,
        IxREP_MOID = 11,
        IxREP_CBD_ID = 12,
        IxREP_TD_CD = 13,
        IxREP_TD = 14,
        IxREP_GENDER = 15,
        IxREP_SIZE_REP = 16,
        IxREP_PCC_DEV = 17,
        IxREP_NLO_DEV = 18,
        IxSHARE_DIV = 19,
        IxSHARE_DEV_FAC = 20,
        IxSHARE_PROD_FAC = 21,
        IxSHARE_SEASON_CD = 22,
        IxSHARE_SEASON = 23,
        IxSHARE_CAT_CD = 24,
        IxSHARE_CATEGORY = 25,
        IxSHARE_MODEL_NAME = 26,
        IxSHARE_MODEL_ID = 27,
        IxSHARE_MOID = 28,
        IxSHARE_BOM_ID = 29,
        IxSHARE_TD_CD = 30,
        IxSHARE_TD = 31,
        IxSHARE_GENDER = 32,
        IxSHARE_PCC_DEV = 33,
        IxSHARE_NLO_DEV = 34,
        IxUPD_USER = 35,
        IxUPD_YMD = 36,
    }


    public enum TBSFM_CBD_TOOLING_SHARE : int
    {
        IxSHARE_DIV = 1,
        IxSHARE_DEV_FAC = 2,
        IxSHARE_PROD_FAC = 3,
        IxSHARE_SEASON_CD = 4,
        IxSHARE_SEASON = 5,
        IxSHARE_CAT_CD = 6,
        IxSHARE_CATEGORY = 7,
        IxSHARE_MODEL_NAME = 8,
        IxSHARE_MODEL_ID = 9,
        IxSHARE_MOID = 10,
        IxSHARE_BOM_ID = 11,
        IxSHARE_TD_CD = 12,
        IxSHARE_TD = 13,
        IxSHARE_GENDER = 14,
        IxSHARE_PCC_DEV = 15,
        IxSHARE_NLO_DEV = 16,
    }

    public enum TBSFM_CBD_TOOLING_SHARE_CBD : int
    {
        IxDEV_FAC = 1,
        IxPROD_FAC = 2,
        IxSEASON_CD = 3,
        IxSEASON = 4,
        IxCAT_CD = 5,
        IxCATEGORY = 6,
        IxMODEL_NAME = 7,
        IxMODEL_ID = 8,
        IxMOID = 9,
        IxTD_CD = 10,
        IxTD = 11,
        IxGENDER = 12,
        IxSIZE_REP = 13,
        IxPCC_DEV = 14,
        IxNLO_DEV = 15,
    }

    public enum TBSFM_CBD_TOOLING_SHIP_HEAD : int
    {
        IxFACTORY = 1,
        IxREQ_SHIP_DATE = 2,
        IxSHIP_NO = 3,
        IxSHIP_STATUS = 4,
        IxEXC_RATE = 5,
        IxEXC_YM = 6,
        IxREMARKS = 7,
        IxUPD_USER = 8,
        IxUPD_YMD = 9,
    }


    public enum TBSFM_CBD_TOOLING_SHIP_TAIL : int
    {
        IxFACTORY = 1,
        IxSHIP_NO = 2,
        IxDEV_FAC = 3,
        IxPROD_FAC = 4,
        IxMOID = 5,
        IxTOOL_NO = 6,
        IxSHIP_SEQ = 7,
        IxT_CLASS = 8,
        IxTOOL_DIV = 9,
        IxSHIP_METHOD_CD = 10,
        IxSHIP_PLAN_DATE = 11,
        IxFOB_TYPE_CD = 12,
        IxTOOL_TYPE_CD = 13,
        IxTOOL_CLASS = 14,
        IxCOMPONENT = 15,
        IxTOOLING_DESC = 16,
        IxITEM_CD = 17,
        IxITEM_NAME = 18,
        IxTOOLING_SPEC = 19,
        IxTOOLING_SPEC_NAME = 20,
        IxTOOLING_COLOR = 21,
        IxTOOLING_COLOR_NAME = 22,
        IxTOOLING_QTY = 23,
        IxUOM = 24,
        IxUNIT_COST = 25,
        IxCOST_AMT = 26,
        IxCURR = 27,
        IxUSD_COST_AMT = 28,
        IxUSD_CURR = 29,
        IxSHIP_STATUS = 30,
        IxSTEP_CD = 31,
        IxTEAM_CD = 32,
        IxUPD_USER = 33,
        IxUPD_YMD = 34,
    }


    public enum TBSFM_CBD_TOOLING_SHIP_REQUEST : int
    {
        IxDEV_FAC = 1,
        IxPROD_FAC = 2,
        IxMOID = 3,
        IxTOOL_NO = 4,
        IxNIKE_CBD_YN = 5,
        IxPM_CHK_YN = 6,
        IxT_CLASS = 7,
        IxTOOL_DIV = 8,
        IxORDER_DATE = 9,
        IxFOB_TYPE_CD = 10,
        IxSIZE_REP = 11,
        IxCOMPONENT = 12,
        IxTOOLING_DESC = 13,
        IxITEM_CD = 14,
        IxITEM_NAME = 15,
        IxTOOLING_SPEC_CD = 16,
        IxTOOLING_SPEC = 17,
        IxTOOLING_COLOR_CD = 18,
        IxTOOLING_COLOR = 19,
        IxTOOL_TYPE_CD = 20,
        IxTOOL_TYPE = 21,
        IxNIKE_MOLD_CD = 22,
        IxTOOL_MAT_CD = 23,
        IxMOLD_SHOP_CD = 24,
        IxMOLD_SHOP = 25,
        IxUOM = 26,
        IxCURR = 27,
        IxUNIT_COST = 28,
        IxTOOLING_QTY = 29,
        IxCOST_AMT = 30,
        IxMOLD_IN_DATE = 31,
        IxSHIP_PLAN_DATE = 32,
        IxSHIPPING_STATUS = 33,
        IxSTEP_CD = 34,
        IxTEAM_CD = 35,
        IxREMARK = 36,
        IxCBD_TRANS = 37,
        IxCBD_TRANS_DATE = 38,
        IxUPD_USER = 39,
        IxUPD_YMD = 40,

    }



    public enum TBSFM_CBD_EFFI_HEAD : int
    {
        IxDIVISION = 1,
        IxDEV_FAC = 2,
        IxPROD_FAC = 3,
        IxMODEL_ID = 4,
        IxMODEL_NAME = 5,
        IxMOID = 6,
        IxTD_CD = 7,
        IxTD = 8,
        IxSEASON_CD = 9,
        IxSEASON = 10,
        IxCAT_CD = 11,
        IxCATEGORY = 12,
        IxGENDER = 13,
        IxSIZE_REP = 14,
        IxROUND_CD = 15,
        IxROUND = 16,
        IxCBD_ID = 17,
        IxCBD_VER = 18,
        IxBOM_ID = 19,
        IxPRODUCT_CD = 20,
        IxSTYLE_CD = 21,
        IxMAT_TYPE = 22,
        IxSHELL_NO = 23,
        IxPCC_DEV = 24,
        IxPCC_TE = 25,
        IxPCC_PE = 26,
        IxUPD_USER = 27,
        IxUPD_YMD = 28,

    }




    public enum TBSFM_CBD_EFFI_TAIL : int
    {
        IxDEV_FAC = 1,
        IxPROD_FAC = 2,
        IxFOB_TYPE_CD = 3,
        IxCBD_ID = 4,
        IxMOID = 5,
        IxEFFI_NO = 6,
        IxCBD_VER = 7,
        IxCBD_UP_NO = 8,
        IxID_PATTERN_MAT = 9,
        IxID_STYLE_PATTERN = 10,
        IxID_PATTERN_GEO = 11,
        IxPROCOST_PART_NAME = 12,
        IxPART_NO = 13,
        IxPART_SEQ = 14,
        IxPART_NAME = 15,
        IxMAT_CD = 16,
        IxMAT_NAME = 17,
        IxUOM = 18,
        IxYIELD = 19,
        IxEFFI_PCT = 20,
        IxWASTE_PCT = 21,
        IxUPD_USER = 22,
        IxUPD_YMD = 23,

    }




    public enum TBSFM_CBD_EFFI_PROCOST_HEAD : int
    {
        IxSTYLE_ID = 1,
        IxSEASON = 2,
        IxCATEGORY = 3,
        IxUSER_ = 4,
        IxSTYLE = 5,
        IxBASIC_SIZE = 6,
        IxDESCRIPTION = 7,
        IxSEMIFILE = 8,
        IxCREATE_DATE = 9,
        IxLASTMODIFIEDDATE = 10,

    }



    public enum TBSFM_CBD_EFFI_PROCOST_TAIL : int
    {
        IxID_STYLE_PATTERN = 1,
        IxID_PATTERN_GEO = 2,
        IxID = 3,
        IxPATT_NAME = 4,
        IxX_SIZE_2 = 5,
        IxMETHOD = 6,
        IxGAP = 7,
        IxNUMPAIRS = 8,
        IxEFFIC = 9,
        IxWASTE = 10,
        IxYIELDFLD = 11,
        IxYIELDUNIT = 12,
        IxWEIGHT = 13,
        IxLENGTH = 14,
        IxWEIGHT_LENGTH = 15,

    }

    public enum TBSFM_CBD_EFFI_TAIL_NEW : int
    {
        IxEFFI_NO = 1,
        IxPART_NO = 2,
        IxPART_SEQ = 3,
        IxPART_NAME = 4,
        IxMAT_CD = 5,
        IxMAT_NAME = 6,
        IxUOM = 7,
        IxID_STYLE_PATTERN = 8,
        IxID_PATTERN_GEO = 9,
        IxID = 10,
        IxPATT_NAME = 11,
        IxX_SIZE_2 = 12,
        IxMETHOD = 13,
        IxGAP = 14,
        IxNUMPAIRS = 15,
        IxEFFIC = 16,
        IxWASTE = 17,
        IxYIELDFLD = 18,
        IxYIELDUNIT = 19,
        IxWEIGHT = 20,
        IxLENGTH = 21,
        IxWEIGHT_LENGTH = 22,

    }


    public enum TBSFM_CBD_EFFI_CBD_HEAD : int
    {
        IxDEV_FAC = 1,
        IxPROD_FAC = 2,
        IxMODEL_ID = 3,
        IxMODEL_NAME = 4,
        IxMOID = 5,
        IxTD_CD = 6,
        IxTD = 7,
        IxSEASON_CD = 8,
        IxSEASON = 9,
        IxCAT_CD = 10,
        IxCATEGORY = 11,
        IxGENDER = 12,
        IxSIZE_REP = 13,
        IxROUND_CD = 14,
        IxROUND = 15,
        IxCBD_ID = 16,
        IxCBD_VER = 17,
        IxBOM_ID = 18,
        IxPRODUCT_CD = 19,
        IxSTYLE_CD = 20,
        IxMAT_TYPE = 21,
        IxSHELL_NO = 22,
        IxPCC_DEV = 23,
        IxPCC_TE = 24,
        IxPCC_PE = 25,
        IxUPD_USER = 26,
        IxUPD_YMD = 27,

    }


    public enum TBSFM_CBD_EFFI_CBD_TAIL : int
    {
        IxCBD_CLASS = 1,
        IxCBD_UP_NO = 2,
        IxPART_NO = 3,
        IxPART_SEQ = 4,
        IxPART_NAME = 5,
        IxMAT_CD = 6,
        IxMAT_NAME = 7,
        IxCOLOR_CD = 8,
        IxCOLOR_NAME = 9,
        IxUOM = 10,

    }

    #endregion

    #endregion

    #endregion

    #region Analysis

    public enum TBEIS_CBD_ANALISYS : int
    {
        IxMaxCt = 40,	// ¿Œµ¶Ω∫ Count
        IxDIV = 0,
        IxFACTORY = 1, 	// Factory : ()
        IxCATEGORY_CD = 2, 	// Category CD : ()
        IxCATEGORY_NAME = 3, 	// Category : ()
        IxMODEL_CD = 4, 	// Model CD : ()
        IxMODEL_NAME = 5, 	// Model : ()
        IxSTYLE_CD = 6, 	// Style : ()
        IxOBS_ID = 7, 	// DPO : ()
        IxOBS_TYPE = 8, 	// Type : ()
        IxORD_QTY = 9, 	// Order : ()
        IxSTATUS = 10, 	// Cfm : ()
        IxCOMPONENT = 11, 	// Comp : ()
        IxGAC_YMD = 12, 	// Gac : ()
        IxOVER_GAC = 13, 	// Gac.Diff : ()
        IxDEV_FAC = 14, 	// Dev Fac : ()
        IxMOID = 15, 	// MO ID : ()
        IxCBD_ID = 16, 	// CBD ID : ()
        IxFOB_TYPE_CD = 17, 	// FOB TYPE : ()
        IxCBD_SEQ = 18, 	// CBD Seq : ()
        IxDETAIL = 19, 	// Detail : ()
        IxUPPER_SUMM_CBD = 20, 	// Upper : ()
        IxPACKING_SUMM_CBD = 21, 	// Packing : ()
        IxMIDSOLE_SUMM_CBD = 22, 	// Midsole : ()
        IxOUTSOLE_SUMM_CBD = 23, 	// Outsole : ()
        IxSIZEUP_SUMM_CBD = 24, 	// Size Up : ()
        IxMAT_SUMM_CBD = 25, 	// Summ. : ()
        IxLABOR_SUMM_CBD = 26, 	// Labor : ()
        IxOVERHEAD_SUMM_CBD = 27, 	// OverHead : ()
        IxPROFIT_SUMM_CBD = 28, 	// Profit : ()
        IxPRSS_SUMM_CBD = 29, 	// Prss : ()
        IxOTHERADJ_SUMM_CBD = 30, 	// Oth. Adj : ()
        IxNON_MAT_SUMM_CBD = 31, 	// Summ. : ()
        IxSMPL_TOOL_SUMM_CBD = 32, 	// Sample : ()
        IxPROD_TOOL_SUMM_CBD = 33, 	// Prod. : ()
        IxTOOL_SUMM_CBD = 34, 	// Summ. : ()
        IxFOB = 35, 	// FOB : ()
        IxFOB_INV = 36,     // FOB INVOICE : ()
        IxDEDUCTION = 37, 	// Deduction : ()
        IxREMARKS = 38, 	// Remark : ()
        IxUPD_USER = 39, 	// User : ()
        IxNEW_YN = 40 	// New : ()
    }

    /// <summary> 
    /// TBEIS_MATPRICE_FOB_INSPECTION  ≈◊¿Ã∫Ì ¿Œµ¶Ω∫ Class 
    /// </summary> 
    public enum TBEIS_MATPRICE_FOB_INSPECTION : int
    {

        IxFACTORY = 1,
        IxPLAN_YMD = 2,
        IxCATEGORY = 3,
        IxCATEGORY_NAME = 4,
        IxMODEL_CD = 5,
        IxMODEL_NAME = 6,
        IxSTYLE_CD = 7,
        IxSTYLE_NAME = 8,
        IxOBS_ID = 9,
        IxOBS_TYPE = 10,
        IxPRS_QTY = 11,
        IxCOST_FOB = 12,
        IxTRADE_FOB = 13,
        IxBALANCE = 14,


    }

    public enum TBEIS_MATPRICE_MODEL_QTY : int
    {

        IxFACTORY = 1,
        IxMODEL_CD = 2,
        IxMODEL_NAME = 3,
        IxOBS_ID = 4,
        IxOBS_TYPE = 5,
        IxOBS_QTY = 6,


    }

    #endregion

    #region Report


    #endregion

    #region Item Master

    /// <summary>
    /// ∞≈∑°√≥ ∏ÆΩ∫∆Æ ¡∂»∏
    /// </summary>
    public enum TBSFX_CBD_M_CUST_LIST : int
    {
        IxMaxCt = 10,	// ¿Œµ¶Ω∫ Count

        IxLEV = 1, 	// Lev : ()
        IxFACTORY = 2, 	// Factory : ()
        IxMXS_DIV = 3, 	// Div : ()
        IxMXS_DIV_NAME = 4, 	// Div : ()
        IxNIKE_SUPPLIER_CD = 5, 	// Code : ()
        IxMXS_LOCATIONNAME = 6, 	// Supplier : ()
        IxMXS_LOCATIONNAME_E = 7, 	// Supplier Eng.: ()
        IxMXS_MODIFY_YMD = 8,	    // Modify : ()
        IxSTATUS = 9,
    }

    /// <summary>
    /// ∞≈∑°√≥ ¡§∫∏ ¡∂»∏
    /// </summary>
    public enum TBSFX_CBD_M_CUST_INFO : int
    {
        IxMaxCt = 18,	// ¿Œµ¶Ω∫ Count

        IxDIV = 0,
        IxLEV = 1, 	// Level : ()
        IxFACTORY = 2, 	// Factory : ()
        IxMXS_LOCATIONCODE = 3, 	// Code : ()
        IxMXS_LOCATIONNAME_K = 4, 	// Korean Name : ()
        IxMXS_LOCATIONNAME_E = 5, 	// English Name : ()
        IxMXS_LOCATION_SEQ = 6, 	// Seq. : ()
        IxMXS_DIV = 7, 	// Division : ()
        IxMXS_MAN_CUST = 8, 	// Charger : ()
        IxMXS_PHONE = 9, 	// Phone : ()
        IxMXS_FAX = 10, 	// Fax : ()
        IxMXS_HEADPHONE = 11, 	// Cell Phone : ()
        IxMXS_EMAIL = 12, 	// Email : ()
        IxMXS_COMMENTS = 13, 	// Comments : ()
        IxREMARKS = 14, 	// Remarks : ()
        IxSTATUS = 15, 	// Status : ()
        IxUPD_USER = 16, 	// User : ()
        IxUPD_YMD = 17 	// Date : ()
    }

    /// <summary>
    /// Item Master ¿« ¿⁄¿Á ∏ÆΩ∫∆Æ 
    /// </summary>
    public enum TBSFX_CBD_M_MAT : int
    {
        IxMaxCt = 25,	// ¿Œµ¶Ω∫ Count

        IxDIV = 0,
        IxFACTORY = 1, 	// Factory : VARCHAR2(5)
        IxMAT_NUMBER = 2, 	// Mat.# : VARCHAR2(100)
        IxMXS_NUMBER = 3, 	// MxS# : VARCHAR2(100)        
        IxMXS_SEQ = 4, 	// Seq. : VARCHAR2(3)
        IxMXS_MATERIAL_NAME = 5, 	// Supplier : VARCHAR2(1024)
        IxNIKE_MAT_NAME = 6, 	// Nike : ()
        IxMXS_UNIT = 7, 	// Unit : VARCHAR2(100)
        IxMXS_WIDTH = 8, 	// Width : VARCHAR2(100)
        IxMXS_UNIT_PRICE = 9, 	// Unit Price : NUMBER(22)
        IxMXS_CURRENCY = 10, 	// Currency : VARCHAR2(100)
        IxMXS_EXTRA_CHARGE = 11, 	// Extra Charge : NUMBER(22)
        IxMXS_SPECIAL_OPTION = 12, 	// Special Option : VARCHAR2(100)
        IxMXS_DELIVERY_TERM = 13, 	// Delivery Term : VARCHAR2(100)
        IxMXS_LOSS = 14, 	// Loss(%) : NUMBER(22)
        IxMXS_MOQ = 15, 	// MOQ : NUMBER(22)
        IxMXS_PROD_LOCATION = 16, 	// Prod. : VARCHAR2(100)
        IxMXS_LOCATIONCODE = 17, 	// Code : VARCHAR2(100)
        IxMXS_LOCATIONNAME = 18, 	// Name : VARCHAR2(100)
        IxMXS_SINGLE_YN = 19, 	// R/P : VARCHAR2(100)
        IxSTATUS = 20, 	// Status : VARCHAR2(1)
        IxREMARKS = 21, 	// Remarks : VARCHAR2(500)
        IxMXS_CURRENT_YN = 22, 	// Current : VARCHAR2(1)
        IxUPD_USER = 23, 	// User : VARCHAR2(30)
        IxUPD_YMD = 24, 	// Date : DATE(7)
    }


    /// <summary>
    /// Item Master ¿« ∆Ø¡§ ¿⁄¿Á¿« »˜Ω∫≈‰∏Æ ¡∂»∏
    /// </summary>
    public enum TBSFX_CBD_M_MAT_HISTORY : int
    {
        IxMaxCt = 21,	// ¿Œµ¶Ω∫ Count

        IxFACTORY = 1, 	// Factory : ()
        IxMAT_NUMBER = 2, 	// Mat. # : ()
        IxMXS_NUMBER = 3, 	// Number : ()
        IxMXS_UNIT = 4, 	// Unit : ()
        IxMXS_SPECIAL_OPTION = 5, 	// Color : ()
        IxMXS_SEQ = 6, 	// Seq : ()
        IxMXS_MATERIAL_NAME = 7, 	// Name : ()
        IxMXS_WIDTH = 8, 	// Width : ()
        IxMXS_UNIT_PRICE = 9, 	// Price : ()
        IxMXS_CURRENCY = 10, 	// Currency : ()
        IxMXS_EXTRA_CHARGE = 11, 	// Charge : ()
        IxMXS_DELIVERY_TERM = 12, 	// FRT Term : ()
        IxMXS_LOSS = 13, 	// Loss : ()
        IxMXS_MOQ = 14, 	// MOQ : ()
        IxMXS_PROD_LOCATION = 15, 	// Name : ()
        IxMXS_LOCATIONCODE = 16, 	// Code : ()
        IxSTATUS = 17, 	// Status : ()
        IxREMARKS = 18, 	// Remarks : ()
        IxMXS_CURRENT_YN = 19, 	// Current : ()
        IxUPD_USER = 20, 	// Update User : ()
        IxUPD_YMD = 21, 	// Update Date : ()
    }

    /// <summary>
    /// Item Master ¿« ∆Ø¡§ ¿⁄¿Á∞° º”«— Part ¡§∫∏ ¡∂»∏
    /// </summary>
    public enum TBSFX_CBD_M_REINFORCE : int
    {
        IxMaxCt = 8,	// ¿Œµ¶Ω∫ Count

        IxFACTORY = 1, 	// Factory : VARCHAR2(5)
        IxMODEL_ID = 2, 	// Model : VARCHAR2(15)
        IxPART_DESC = 3, 	// Description : VARCHAR2(100)
        IxPART_SEQ = 4, 	// Seq : NUMBER(22)
        IxMAT_NUMBER = 5, 	// Mat. : ()
        IxMAT_DESC = 6, 	// Description : ()
        IxUPD_USER = 7, 	// Update User : VARCHAR2(30)
        IxUPD_YMD = 8 	// Update Date : DATE(7)
    }

    public enum TBSFX_CBD_M_MAT_CONV : int
    {
        IxMaxCt = 37,	// ¿Œµ¶Ω∫ Count

        IxDIV = 0,
        IxCHK = 1, 	//   : ()
        IxFACTORY = 2, 	// Factory : VARCHAR2(5)
        IxMXS_SEQ = 3, 	// Seq : VARCHAR2(10)
        IxMXS_LOCATIONCODE = 4, 	// Location : VARCHAR2(100)
        IxI01 = 5, 	// MxS# : VARCHAR2(200)
        IxI02 = 6, 	// Location : VARCHAR2(200)
        IxI03 = 7, 	// Material Name : VARCHAR2(200)
        IxI04 = 8, 	// Unit : VARCHAR2(200)
        IxI05 = 9, 	// Width : VARCHAR2(200)
        IxI06 = 10, 	// Unit Price : VARCHAR2(200)
        IxI07 = 11, 	// Currency : VARCHAR2(200)
        IxI08 = 12, 	// Special Option : VARCHAR2(200)
        IxI09 = 13, 	// Extra Charge : VARCHAR2(200)
        IxI10 = 14, 	// Delivery Term : VARCHAR2(200)
        IxI11 = 15, 	// Loss(%) : VARCHAR2(200)
        IxI12 = 16, 	// MOQ : VARCHAR2(200)
        IxI13 = 17, 	//   : VARCHAR2(200)
        IxI14 = 18, 	//   : VARCHAR2(200)
        IxI15 = 19, 	//   : VARCHAR2(200)
        IxI16 = 20, 	//   : VARCHAR2(200)
        IxI17 = 21, 	//   : VARCHAR2(200)
        IxI18 = 22, 	//   : VARCHAR2(200)
        IxI19 = 23, 	//   : VARCHAR2(200)
        IxI20 = 24, 	//   : VARCHAR2(200)
        IxI21 = 25, 	//   : VARCHAR2(200)
        IxI22 = 26, 	//   : VARCHAR2(200)
        IxI23 = 27, 	//   : VARCHAR2(200)
        IxI24 = 28, 	//   : VARCHAR2(200)
        IxI25 = 29, 	//   : VARCHAR2(200)
        IxI26 = 30, 	//   : VARCHAR2(200)
        IxI27 = 31, 	//   : VARCHAR2(200)
        IxI28 = 32, 	//   : VARCHAR2(200)
        IxI29 = 33, 	//   : VARCHAR2(200)
        IxI30 = 34, 	//   : VARCHAR2(200)        
        IxERR_FLG = 35, 	// Status : VARCHAR2(1)
        IxSTATUS = 36, 	// Status : VARCHAR2(1)
        IxUPD_USER = 37, 	// Update User : VARCHAR2(30)
        IxUPD_YMD = 38 	// Update Date : DATE(7)
    }

    public enum TBSFX_CBD_M_MAT_RP : int
    {
        IxMaxCt = 11,	// ¿Œµ¶Ω∫ Count

        IxDIV = 0, 	// Factory : ()
        IxFACTORY = 1, 	// Mat. # : ()
        IxMXS_LOCATIONCODE = 2, 	// Number : ()
        IxCHARGE_DIV = 3, 	// Unit : ()
        IxCHARGE_CD = 4, 	// Color : ()
        IxCHARGE_DESC = 5, 	// Seq : ()
        IxUP_CHARGE = 6, 	// Name : ()
        IxREMARKS = 7, 	// Width : ()
        IxSTATUS = 8, 	// Price : ()
        IxUPD_USER = 9, 	// Currency : ()
        IxUPD_YMD = 10, 	// Charge : ()     

    }

    public enum TBSFX_CBD_M_FILE : int
    {
        IxMaxCt = 11,	// ¿Œµ¶Ω∫ Count

        IxDIV = 0,
        IxFACTORY = 1,
        IxFILE_DIV = 2,
        IxFILE_SEQ = 3,
        IxFILE_CD = 4,
        IxCHK = 5,
        IxFILE_NAME = 6,
        IxREMARKS = 7,
        IxSTATUS = 8,
        IxUPD_USER = 9,
        IxUPD_YMD = 10,
    }

    #endregion

    #region Base Information

    public enum TBSFX_CBD_BASE_FXRATE : int
    {
        IxMaxCt = 11,	// ¿Œµ¶Ω∫ Count     

        IxDIV = 0,
        IxFACTORY = 1,
        IxSEASON_CD = 2,
        IxSEASON_NAME = 3,
        IxCURR = 4,
        IxCOUNTRY = 5,
        IxFX_RATE = 6,
        IxSTATUS = 7,
        IxAPP_DATE = 8,
        IxUPD_USER = 9,
        IxUPD_YMD = 10,

    }

    public enum TBSFX_CBD_BASE_PACKING : int
    {
        IxMaxCt = 20,	// ¿Œµ¶Ω∫ Count     

        IxDIV = 0,
        IxFACTORY = 1,
        IxPACKING_SEQ = 2,
        IxPACKING_CD = 3,
        IxSDM_COST = 4,
        IxME_COST = 5,
        IxWO_COST = 6,
        IxGS_COST = 7,
        IxPS_COST = 8,
        IxTD_COST = 9,
        IxME_SIZE_CD = 10,
        IxWO_SIZE_CD = 11,
        IxGS_SIZE_CD = 12,
        IxPS_SIZE_CD = 13,
        IxTD_SIZE_CD = 14,
        IxSDM_YN = 15,
        IxREMARKS = 16,
        IxSTATUS = 17,
        IxUPD_USER = 18,
        IxUPD_YMD = 19,
    }

    public enum TBSFX_CBD_BASE_PACKAGING : int
    {
        IxMaxCt = 15,	// ¿Œµ¶Ω∫ Count     

        IxDIV = 0,
        IxFACTORY = 1,
        IxGEN_CD = 2,
        IxCATEGORY = 3,
        IxPACKING_SEQ = 4,
        IxGENDER = 5,
        IxCATEGORY_V = 6,
        IxPACKING_DESC = 7,
        IxSIZE_FROM = 8,
        IxSIZE_TO = 9,
        IxMAT_PRICE = 10,
        IxREMARKS = 11,
        IxSTATUS = 12,
        IxUPD_USER = 13,
        IxUPD_YMD = 14,
    }

    public enum TBSFX_CBD_BASE_LABOR : int
    {
        IxMaxCt = 16,	// ¿Œµ¶Ω∫ Count     

        IxDIV = 0,
        IxFACTORY = 1,
        IxSEASON_CD = 2,
        IxSEASON_NAME = 3,
        IxFACTORY_V = 4,
        IxCATEGORY = 5,
        IxGENDER = 6,
        IxRETAIL_FROM = 7,
        IxRETAIL_TO = 8,
        IxRETAIL_VIEW = 9,
        IxFIXED_COST = 10,
        IxLABOR_COST = 11,
        IxOVERHEAD_COST = 12,
        IxREMARKS = 13,
        IxSTATUS = 14,
        IxUPD_USER = 15,
        IxUPD_YMD = 16,
    }

    public enum TBSFX_CBD_BASE_UOM : int
    {
        IxMaxCt = 10,	// ¿Œµ¶Ω∫ Count     

        IxDIV = 0,
        IxFACTORY = 1,
        IxCOM_CD = 2,
        IxCOM_SEQ = 3,
        IxCOM_VALUE1 = 4,
        IxCOM_DESC1 = 5,
        IxUSE_YN = 6,
        IxREMARKS = 7,
        IxUPD_USER = 8,
        IxUPD_YMD = 9,

    }

    #endregion

    #region 5523

    public enum TBSFX_CBD_5523_HEAD : int
    {
        IxMaxCt = 19,	// ¿Œµ¶Ω∫ Count     

        IxDIV = 0,
        IxFACTORY = 1,
        IxPRODUCT_CODE = 2,
        IxDEV_CODE = 3,
        IxREGION = 4,
        IxCOMPONENT_DIV = 5,
        IxCOMPONENT_SEQ = 6,
        IxCOMPONENTS = 7,
        IxPRODUCT_NAME = 8,
        IxPRODUCT_TYPE = 9,
        IxPRODUCT_FACTORY = 10,
        IxSEASON_CD = 11,
        IxMEASUREMENT = 12,
        IxTTL = 13,
        IxFOXING_LIKE_BAND = 14,
        IxREMARKS = 15,
        IxSTATUS = 16,
        IxUPD_USER = 17,
        IxUPD_YMD = 18,
    }

    public enum TBSFX_CBD_5523_TAIL : int
    {
        IxMaxCt = 5,	// ¿Œµ¶Ω∫ Count     

        IxSEQ = 0,
        IxBOM_ID = 1,
        IxSTYLE_CD = 2,
        IxCOMPONENT_SEQ = 3,
        IxMATERIAL_STYLE = 4,
    }

    public enum TBSFX_CBD_5523_MTST : int
    {
        IxMaxCt = 19,	// ¿Œµ¶Ω∫ Count     

        IxDIV = 0,
        IxFACTORY = 1,
        IxPRODUCT_CODE = 2,
        IxDEV_CODE = 3,
        IxREGION = 4,
        IxNULL_01 = 5,
        IxNULL_02 = 6,
        IxTOTAL_NAME = 7,
        IxNULL_03 = 8,
        IxNULL_04 = 9,
        IxNULL_05 = 10,
        IxNULL_06 = 11,
        IxTOTAL_VALUE = 12,
        IxMAT_STYLE = 13,
        IxMAT_STYLE_CD = 14,
        IxNULL_08 = 15,
        IxNULL_09 = 16,
        IxNULL_10 = 17,
        IxNULL_11 = 18,
    }

    public enum TBSFX_CBD_5523_POP : int
    {
        IxMaxCt = 14,	// ¿Œµ¶Ω∫ Count     

        IxDIV = 0,
        IxFACTORY = 1,
        IxPRODUCT_CODE = 2,
        IxDEV_CODE = 3,
        IxREGION = 4,
        IxPRODUCT_NAME = 5,
        IxPRODUCT_TYPE = 6,
        IxPRODUCT_FACTORY = 7,
        IxSEASON_CD = 8,
        IxFOXING_LIKE_BAND = 9,
        IxREMARKS = 10,
        IxSTATUS = 11,
        IxUPD_USER = 12,
        IxUPD_YMD = 13,
    }

    #endregion
        
    #region Tooling

    public enum TBSFX_CBD_TOOLING_AMOTIZATION : int
    {
        IxMaxCt = 6,  // ¿Œµ¶Ω∫Count     

        IxDIV      = 0,
        IxFACTORY  = 1,
        IxCATEGORY = 2,
        IxSTYLE_CD = 3,
        IxDEV_NAME = 4,
        IxUPD_USER = 5, 
    }

    public enum TBSFX_CBD_TOOLING_TRACKING : int
    {
        IxMaxCt       = 24,

        IxDIV         = 0,
        IxFACTORY     = 1,
        IxCAT_CD      = 2,
        IxSEASON_CD   = 3,  
        IxSEASON      = 4, 
        IxCHARGE      = 5,
        IxCAT_NAME    = 6,
        IxMODEL       = 7, 
        IxFACTORY_V   = 8,   
        IxTTL_AMOUNT  = 9,    
        IxFORECAST    = 10, 
        IxPAIR        = 11,
        IxSTART_PO    = 12,  
        IxEND_PO      = 13,
        IxORD_QTY     = 14,
        IxREAL_ORD_QTY= 15,
        IxAMOUNT      = 16,
        IxBALANCE     = 17,
        IxSTATUS      = 18,
        IxCOMMENTS    = 19,
        IxMODEL_ID    = 20,
        IxSTYLE_CD    = 21,
        IxSEQ         = 22,
        IxLEVEL       = 23 
    }

    public enum TBSFX_CBD_TOOLING_CALC : int
    {
        IxMaxCt = 6,	    // ¿Œµ¶Ω∫ Count
        IxCALC_YN = 1, 	    //   : ()
        IxPROD_FAC = 2, 	//   : ()
        IxGENDER = 3, 	    //   : ()
        IxMOID = 4, 	    //   : ()
        IxPROD_CODE = 5, 	//   : ()
        IxCFM_FOB = 6, 	    //   : ()
        IxTTL_AMOUNT = 7, 	//   : ()
        IxFORECAST = 8, 	//   : ()
        IxMODEL_ID = 9 	    //   : ()
    }

    public enum TBSFX_CBD_TOOLING_CALC_DATATABLE : int
    {
        IxMaxCt = 15,	// ¿Œµ¶Ω∫ Count
        IxCALC_YN = 0, 	//   : ()
        IxPROD_FAC = 1, 	//   : ()
        IxGENDER = 2, 	//   : ()
        IxMOID_VIEW = 3, 	//   : ()
        IxPROD_CODE = 4, 	//   : ()
        IxCFM_FOB = 5, 	//   : ()
        IxOBS_ID = 6, 	//   : ()
        IxOBS_TYPE = 7, 	//   : ()
        IxSTYLE_CD = 8, 	//   : ()
        IxFOB = 9, 	//   : ()
        IxDEV_FAC = 10, 	//   : ()
        IxMOID = 11, 	//   : ()
        IxCBD_ID = 12, 	//   : ()
        IxFOB_TYPE_CD = 13, 	//   : ()
        IxCBD_SEQ = 14	//   : ()
    }
                      
    #endregion

    #region CBD Status
    public enum TBSFX_CBD_STATUS : int
    {
        IxMaxCt = 32,  // ¿Œµ¶Ω∫Count     
        
        IxDIV             = 0,
        IxFACTORY         = 1,
        IxSEASON_CD       = 2,
        IxSRF_NO          = 3,
        IxBOM_ID          = 4,
        IxBOM_REV         = 5, 
        IxNF_CD           = 6, 
        IxSEASON_NAME     = 7, 
        IxCATEGORY        = 8, 
        IxNUM             = 9, 
        IxSTYLE_NAME      = 10,
        IxSRF_NO_V        = 11,
        IxBOM_ID_V        = 12,
        IxT_D             = 13,
        IxGENDER          = 14,
        IxSIZE_CD         = 15,
        IxPROD_FAC        = 16,
        IxNLO_COSTER      = 17,
        IxCBD_COSTER      = 18,
        IxETS_YMD         = 19,
        IxQUOTED_YMD      = 20,
        IxQUOTED          = 21,
        IxGCIM_YN         = 22,
        IxDUTY            = 23,
        IxUPPER_MAT       = 24,        
        IxCBD_YN          = 25,
        IxDEV_FAC         = 26,
        IxMOID            = 27,
        IxBOM_ID_K        = 28,
        IxFOB_TYPE_CD     = 29,
        IxUPD_USER        = 30,
        IxUPD_YMD         = 31,
    }
    #endregion

    #region CBD XML Create
    public enum TBSFX_CBD_XML_CREATE : int
    {
        IxMaxCt = 19,  // ¿Œµ¶Ω∫Count     
                
        IxDIV            = 0,
        IxDEV_FAC        = 1,
        IxMOID           = 2,
        IxCBD_ID         = 3,
        IxFOB_TYPE_CD    = 4,
        IxCBD_SEQ        = 5, 
        IxCHK            = 6, 
        IxDEV_FAC_V      = 7, 
        IxPROC_FAC       = 8, 
        IxSEASON         = 9, 
        IxCATEGORY       = 10,
        IxMODEL_NAME     = 11,
        IxMOID_V         = 12,
        IxSTYLE_CD       = 13,
        IxBOM_ID         = 14,
        IxBOM_REV        = 15,
        IxPCC_DEV        = 16,
        IxPCC_COSTER     = 17,
        IxFOB_STATUS     = 18,
    }
    #endregion

    #region CBD master search 

    public enum TBSFX_CBD_HEAD_LIST : int
    {
        IxMaxCt = 55,	// ¿Œµ¶Ω∫ Count
        IxDEV_FAC = 1, 	// Dev Fac : VARCHAR2(5)
        IxMOID = 2, 	// MO Alias : VARCHAR2(20)
        IxCBD_ID = 3, 	// CBD ID : VARCHAR2(8)
        IxFOB_TYPE_CD = 4, 	// FOB Type Code : VARCHAR2(10)
        IxCBD_SEQ = 5, 	// CBD Seq : NUMBER(22)
        IxPROD_FAC = 6, 	// Factory : VARCHAR2(5)
        IxMO_ALIAS = 7, 	// Dev Proj Alias : ()
        IxSEASON_CD = 8, 	// Season : VARCHAR2(6)
        IxSEASON_NAME = 9, 	// Season : ()
        IxCATEGORY = 10, 	// Category : ()
        IxSTYLE_NAME = 11, 	// Model : ()
        IxSTYLE_CD = 12, 	// Style : VARCHAR2(15)
        IxOBS_ID = 13, 	// OBS ID : VARCHAR2(6)
        IxOBS_TYPE = 14, 	// OBS Type : VARCHAR2(30)
        IxBOM_ID = 15, 	// BOM ID : VARCHAR2(8)
        IxFOB_TYPE = 16, 	// FOB Type : ()
        IxNEW_FLAG = 17, 	// Detail : ()
        IxQUOTED_YMD = 18, 	// Quoted Date : ()
        IxGENDER = 19, 	// Gender : VARCHAR2(10)
        IxSIZE_CD = 20, 	// Code : ()
        IxSIZE_UP = 21, 	// Up   : ()
        IxUP = 22, 	// Up : ()
        IxBOTTOM = 23, 	// Bottom : ()
        IxEXTRA = 24, 	// Extra : ()
        IxM_UPPER = 25, 	// Upper : ()
        IxM_PACKING = 26, 	// Packing : ()
        IxM_MIDSOLE = 27, 	// Midsole : ()
        IxM_OUTSOLE = 28, 	// Outsole : ()
        IxM_SIZE_UP = 29, 	// Size Up : ()
        IxM_PRICE = 30, 	// M Total : ()
        IxM_RATIO = 31, 	// M Ratio : ()
        IxL_OH = 32, 	// L OH : ()
        IxPROFIT = 33, 	// Profit : NUMBER(22)
        IxOTHER_AD = 34, 	// Other AD : ()
        IxNM_PRICE = 35, 	// NM Total : ()
        IxT_SAMPLE = 36, 	// Sample : ()
        IxT_PRODUCTION = 37, 	// Production : ()
        IxTOOLING = 38, 	// T  Total : ()
        IxFOB = 39, 	// FOB : NUMBER(22)
        IxFOB_STATUS = 40, 	// Status : VARCHAR2(20)
        IxRATE_IDR = 41, 	// IDR : ()
        IxRATE_INR = 42, 	// INR : ()
        IxRATE_KRW = 43, 	// KRW : ()
        IxRATE_RMB = 44, 	// RMB : ()
        IxRATE_THB = 45, 	// THB : ()
        IxRATE_TWD = 46, 	// TWD : ()
        IxRATE_USD = 47, 	// USD : ()
        IxRATE_VND = 48, 	// VND : ()
        IxFORECAST = 49, 	// Forecast : NUMBER(22)
        IxRETAIL = 50, 	// Retail : ()
        IxTARGET = 51, 	// Target : ()
        IxREMARKS = 52, 	// Remarks : VARCHAR2(4000)
        IxSTATUS = 53, 	// Status : VARCHAR2(1)
        IxUPD_USER = 54, 	// User : VARCHAR2(30)
        IxUPD_YMD = 55 	// Date : DATE(7)
    }

    #endregion
}
