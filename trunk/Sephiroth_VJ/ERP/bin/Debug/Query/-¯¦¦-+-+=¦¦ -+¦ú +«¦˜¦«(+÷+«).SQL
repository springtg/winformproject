
SELECT NVL(MAX(( SELECT DEPT_NAME FROM NEOMICS.CM_DEPT D WHERE D.DEPT_CD = REQ_DEPT )), REQ_DEPT) AS REQ_DEPT_NAME,
       NVL(MAX(( SELECT DEPT_NAME FROM NEOMICS.CM_DEPT D WHERE D.DEPT_CD = OUT_DEPT )), OUT_DEPT) AS OUT_DEPT_NAME,
       SUM(DECODE(REQ_WEEK, '1', REQ_QTY, 0))   AS REQ_1,
       SUM(DECODE(REQ_WEEK, '1', OUT_QTY, 0))   AS OUT_1,
       SUM(DECODE(REQ_WEEK, '1', OUT_AMOUT, 0)) AS AMOUNT_1, 
       SUM(DECODE(REQ_WEEK, '2', REQ_QTY, 0))   AS REQ_2,
       SUM(DECODE(REQ_WEEK, '2', OUT_QTY, 0))   AS OUT_2,
       SUM(DECODE(REQ_WEEK, '2', OUT_AMOUT, 0)) AS AMOUNT_2, 
       SUM(DECODE(REQ_WEEK, '3', REQ_QTY, 0))   AS REQ_3,
       SUM(DECODE(REQ_WEEK, '3', OUT_QTY, 0))   AS OUT_3,
       SUM(DECODE(REQ_WEEK, '3', OUT_AMOUT, 0)) AS AMOUNT_3,
       SUM(DECODE(REQ_WEEK, '4', REQ_QTY, 0))   AS REQ_4,
       SUM(DECODE(REQ_WEEK, '4', OUT_QTY, 0))   AS OUT_4,
       SUM(DECODE(REQ_WEEK, '4', OUT_AMOUT, 0)) AS AMOUNT_4,
       SUM(DECODE(REQ_WEEK, '5', REQ_QTY, 0))   AS REQ_5,
       SUM(DECODE(REQ_WEEK, '5', OUT_QTY, 0))   AS OUT_5,
       SUM(DECODE(REQ_WEEK, '5', OUT_AMOUT, 0)) AS AMOUNT_5,
       SUM(REQ_QTY)                             AS REQ_TOTAL, 
       SUM(OUT_QTY)                             AS OUT_TOTAL,
       SUM(OUT_AMOUT)                           AS AMOUNT_TOTAL
  FROM (
        SELECT TO_CHAR(TO_DATE(A.REQ_YMD), 'W') AS REQ_WEEK, A.REQ_DEPT, SUM(B.REQ_QTY) AS REQ_QTY,
               MAX(( SELECT MAX(REQ_DEPT)
                       FROM SBO_OUT_TAIL C
                      WHERE C.FACTORY = B.FACTORY
                        AND C.REQ_NO  = B.REQ_NO
                        AND C.REQ_SEQ = B.REQ_SEQ )) AS OUT_DEPT, 
               SUM(( SELECT SUM(C.OUT_QTY)
                       FROM SBO_OUT_TAIL C
                      WHERE C.FACTORY = B.FACTORY
                        AND C.REQ_NO  = B.REQ_NO
                        AND C.REQ_SEQ = B.REQ_SEQ )) AS OUT_QTY,
               SUM(( SELECT SUM(C.OUT_QTY)
                       FROM SBO_OUT_TAIL C
                      WHERE C.FACTORY = B.FACTORY
                        AND C.REQ_NO  = B.REQ_NO
                        AND C.REQ_SEQ = B.REQ_SEQ ) * PKG_SBO_OUT_PRINT.FN_GET_STOCK_PRICE(A.FACTORY, A.REQ_YMD, B.ITEM_CD, B.SPEC_CD, B.COLOR_CD) ) AS OUT_AMOUT  
          FROM SBP_REQUEST_HEAD A, SBP_REQUEST_TAIL B
         WHERE A.FACTORY      = B.FACTORY
           AND A.REQ_NO       = B.REQ_NO
           AND A.FACTORY      = [1;공장;C;SBC21]
           AND A.REQ_YMD      BETWEEN [2;출고요청일 FROM;D] AND [3;출고요청일 TO;D]
           AND A.REQ_DIVISION  = '20'
           AND B.ITEM_CD IN ( SELECT ITEM_CD FROM SBC_ITEM WHERE SUBSTR(GROUP_CD, 1, 2) IN ( '04', '05' ) )
         GROUP BY TO_CHAR(TO_DATE(A.REQ_YMD), 'W'), A.REQ_DEPT
       )
 GROUP BY REQ_DEPT, OUT_DEPT
 ORDER BY REQ_DEPT, OUT_DEPT

