
SELECT FACTORY, OUT_PROCESS, OUT_LINE, STYLE_CD, STYLE_NAME, LOT_NO, LOT_SEQ, 
       ITEM_NAME, SPEC_NAME, COLOR_NAME, ITEM_UNIT, ITEM_CD, SPEC_CD, COLOR_CD,
       OUT_YMD, LOT_TOTAL_QTY, LOT_DAY_QTY,  
       YIELD_QTY, DIR_QTY, OUT_QTY
  FROM (
        SELECT FACTORY, OUT_LINE, OUT_PROCESS,
               STYLE_CD,
               PKG_SBC_COMMON.FN_GET_STYLE_NAME(STYLE_CD)                                                      AS STYLE_NAME, 
               LOT_NO, LOT_SEQ, OUT_YMD,
               PKG_SBO_OUTGOING_NORMAL.FN_GET_PROCESS_TOTAL(FACTORY, LOT_NO, LOT_SEQ, OUT_PROCESS, STYLE_CD, OUT_LINE)            AS LOT_TOTAL_QTY,
               PKG_SBO_OUTGOING_NORMAL.FN_GET_PROCESS_DAY(FACTORY, LOT_NO, LOT_SEQ, OUT_PROCESS, STYLE_CD, OUT_LINE, OUT_YMD )  AS LOT_DAY_QTY, 
               PKG_SBC_COMMON.FN_GET_ITEM_NAME(ITEM_CD)                                                        AS ITEM_NAME,
               PKG_SBC_COMMON.FN_GET_SPEC_NAME(SPEC_CD)                                                        AS SPEC_NAME,
               PKG_SBC_COMMON.FN_GET_COLOR_NAME(COLOR_CD)                                                      AS COLOR_NAME,
               PKG_SBC_COMMON.FN_GET_STOCK_UNIT(ITEM_CD)                                                       AS ITEM_UNIT,
               ITEM_CD, SPEC_CD, COLOR_CD,
               SUM(YIELD_M) AS YIELD_QTY,
               SUM(DIR_QTY) AS DIR_QTY, 
			   SUM(OUT_QTY) AS OUT_QTY
          FROM SBO_OUT_EXPEND
         WHERE FACTORY     = 'QD'
           AND OUT_PROCESS = 'UPC'
           AND OUT_LINE    = '001'
           AND ( LOT_NO, LOT_SEQ, STYLE_CD ) IN 
               (
                SELECT LOT_NO, LOT_SEQ, STYLE_CD
                  FROM SBO_OUT_EXPEND 
                 WHERE FACTORY     = 'QD'
                   AND OUT_YMD     = '20080701'
                   AND OUT_PROCESS = 'UPC'
                   AND OUT_LINE    = '001'
                 GROUP BY LOT_NO, LOT_SEQ, STYLE_CD
               )
		 GROUP BY FACTORY, OUT_LINE, OUT_PROCESS, STYLE_CD, LOT_NO, LOT_SEQ, ITEM_CD, SPEC_CD, COLOR_CD, OUT_YMD
       )
   ORDER BY FACTORY, LOT_NO, LOT_SEQ, STYLE_CD, ITEM_NAME, SPEC_NAME, COLOR_NAME, OUT_YMD
 