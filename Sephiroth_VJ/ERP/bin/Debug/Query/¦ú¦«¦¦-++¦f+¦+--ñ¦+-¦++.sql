SELECT PKG_SBC_COMMON.FN_GET_CUSTOMER('QD', B.CUST_CD) AS CUST_NAME,
       PKG_SBC_COMMON.FN_GET_ITEM_NAME(B.ITEM_CD)      AS ITEM_NAME,
	   PKG_SBC_COMMON.FN_GET_SPEC_NAME(B.SPEC_CD)      AS SPEC_NAME,
       PKG_SBC_COMMON.FN_GET_COLOR_NAME(B.COLOR_CD)    AS COLOR_NAME,
       SUM(B.IN_QTY)                                   AS IN_QTY,
       PKG_SBC_COMMON.FN_GET_STOCK_UNIT(B.ITEM_CD)     AS ITEM_UNIT,
       MAX(B.CBD_PRICE)                                AS CBD_PRICE,
       MAX(B.PUR_PRICE)                                AS PUR_PRICE,
       B.PUR_CURRENCY,
       SUM(B.IN_QTY) * MAX(B.PUR_PRICE)                AS PUR_AMOUNT 
  FROM SEPHIROTH.SBI_IN_HEAD@VJLINK A, SEPHIROTH.SBI_IN_TAIL@VJLINK B, SEPHIROTH.SBC_ITEM@VJLINK C
 WHERE A.FACTORY = B.FACTORY
   AND A.IN_NO   = B.IN_NO
   AND B.ITEM_CD = B.ITEM_CD
   AND A.FACTORY = [1;공장;C;SBC21]
   AND A.IN_YMD BETWEEN [2;입고일 FROM;D] AND [3;입고일 TO;D]
   AND NVL(C.IMPORT_QD, 'N') LIKE TRIM([4;자재구분;C;SBP13]) || '%'     
 GROUP BY B.CUST_CD, B.ITEM_CD, B.SPEC_CD, B.COLOR_CD, B.PUR_CURRENCY
 ORDER BY CUST_NAME, ITEM_NAME, SPEC_NAME, COLOR_NAME