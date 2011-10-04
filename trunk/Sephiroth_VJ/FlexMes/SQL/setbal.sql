SELECT ASSY_LINE, FN_STYNAME(STYLE_CD), STYLE_CD, 
       SUM(FGA_UP), SUM(FGA_FS), SUM(FGA_BAL),
       SUM(FSS_OS), SUM(FSS_PH), SUM(FSS_PU), SUM(FSS_SP), SUM(FSS_BAL),
       SUM(OS_P), SUM(PH_P), SUM(PU_P), SUM(SP_P), SUM(BAL_P),
       SUM(UP_P)
  FROM ( SELECT ASSY_LINE, STYLE_CD, CS_SIZE, 
                SUM(DECODE(PROC||'-'||IN_LINE_YN||'-'||SEMI_GOOD_CD, 'FGA-IT-UP',PRS_QTY,0)),
                SUM(DECODE(PROC||'-'||IN_LINE_YN||'-'||SEMI_GOOD_CD, 'FGA-IT-FS',PRS_QTY,0)),
                SUM(DECODE(PROC||'-'||IN_LINE_YN||'-'||SEMI_GOOD_CD, 'FSS-IP-OS',PRS_QTY,0)),
                SUM(DECODE(PROC||'-'||IN_LINE_YN||'-'||SEMI_GOOD_CD, 'FSS-IP-PH',PRS_QTY,0)),
                SUM(DECODE(PROC||'-'||IN_LINE_YN||'-'||SEMI_GOOD_CD, 'FSS-IP-PU',PRS_QTY,0)),
                SUM(DECODE(PROC||'-'||IN_LINE_YN||'-'||SEMI_GOOD_CD, 'FSS-IP-SP',PRS_QTY,0)),
                SUM(DECODE(PROC||'-'||IN_LINE_YN||'-'||SEMI_GOOD_CD, 'OSP-PO-OS',PRS_QTY,0)),
                SUM(DECODE(PROC||'-'||IN_LINE_YN||'-'||SEMI_GOOD_CD, 'PHP-IO-PH',PRS_QTY,0)),
                SUM(DECODE(PROC||'-'||IN_LINE_YN||'-'||SEMI_GOOD_CD, 'PHP-IO-PH',PRS_QTY,0)),
                
       )
       
