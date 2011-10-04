VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO06VJ 
   Caption         =   "MES-MO06VJ"
   ClientHeight    =   8295
   ClientLeft      =   1665
   ClientTop       =   1560
   ClientWidth     =   11910
   LinkTopic       =   "Form1"
   ScaleHeight     =   8295
   ScaleWidth      =   11910
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   4725
      Top             =   435
   End
   Begin VSFlex7LCtl.VSFlexGrid fspBal 
      Height          =   6810
      Left            =   45
      TabIndex        =   4
      Top             =   1110
      Width           =   11850
      _cx             =   20902
      _cy             =   12012
      _ConvInfo       =   1
      Appearance      =   1
      BorderStyle     =   1
      Enabled         =   -1  'True
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      MousePointer    =   0
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      BackColorFixed  =   -2147483633
      ForeColorFixed  =   -2147483630
      BackColorSel    =   -2147483635
      ForeColorSel    =   -2147483634
      BackColorBkg    =   -2147483636
      BackColorAlternate=   -2147483643
      GridColor       =   -2147483633
      GridColorFixed  =   -2147483632
      TreeColor       =   -2147483632
      FloodColor      =   192
      SheetBorder     =   -2147483642
      FocusRect       =   1
      HighLight       =   1
      AllowSelection  =   -1  'True
      AllowBigSelection=   -1  'True
      AllowUserResizing=   1
      SelectionMode   =   1
      GridLines       =   1
      GridLinesFixed  =   2
      GridLineWidth   =   1
      Rows            =   50
      Cols            =   18
      FixedRows       =   2
      FixedCols       =   0
      RowHeightMin    =   0
      RowHeightMax    =   0
      ColWidthMin     =   0
      ColWidthMax     =   0
      ExtendLastCol   =   0   'False
      FormatString    =   ""
      ScrollTrack     =   0   'False
      ScrollBars      =   2
      ScrollTips      =   0   'False
      MergeCells      =   0
      MergeCompare    =   0
      AutoResize      =   -1  'True
      AutoSizeMode    =   0
      AutoSearch      =   0
      AutoSearchDelay =   2
      MultiTotals     =   -1  'True
      SubtotalPosition=   0
      OutlineBar      =   0
      OutlineCol      =   0
      Ellipsis        =   0
      ExplorerBar     =   0
      PicturesOver    =   0   'False
      FillStyle       =   0
      RightToLeft     =   0   'False
      PictureType     =   0
      TabBehavior     =   0
      OwnerDraw       =   0
      Editable        =   0
      ShowComboButton =   -1  'True
      WordWrap        =   0   'False
      TextStyle       =   0
      TextStyleFixed  =   0
      OleDragMode     =   0
      OleDropMode     =   0
      ComboSearch     =   3
      AutoSizeMouse   =   -1  'True
      FrozenRows      =   0
      FrozenCols      =   0
      AllowUserFreezing=   0
      BackColorFrozen =   0
      ForeColorFrozen =   0
      WallPaperAlignment=   9
   End
   Begin Threed.SSPanel SSPanel1 
      Height          =   645
      Left            =   -15
      TabIndex        =   0
      Top             =   -15
      Width           =   11910
      _Version        =   65536
      _ExtentX        =   21008
      _ExtentY        =   1138
      _StockProps     =   15
      BackColor       =   12632256
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "굴림"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSCommand SSCommand1 
         Height          =   435
         Left            =   10305
         TabIndex        =   3
         Top             =   105
         Width           =   1395
         _Version        =   65536
         _ExtentX        =   2461
         _ExtentY        =   767
         _StockProps     =   78
         Caption         =   "Close"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin Threed.SSCommand cmdPrint 
         Height          =   435
         Left            =   8925
         TabIndex        =   6
         Top             =   105
         Width           =   1395
         _Version        =   65536
         _ExtentX        =   2461
         _ExtentY        =   767
         _StockProps     =   78
         Caption         =   "Print"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand cmdSearch 
         Height          =   435
         Left            =   7545
         TabIndex        =   7
         Top             =   105
         Width           =   1395
         _Version        =   65536
         _ExtentX        =   2461
         _ExtentY        =   767
         _StockProps     =   78
         Caption         =   "Search"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin VB.Label lbTitle 
         BackStyle       =   0  '투명
         Caption         =   "Shortage"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   345
         Index           =   1
         Left            =   1380
         TabIndex        =   2
         Top             =   180
         Width           =   5790
      End
      Begin VB.Label lbTitle 
         BackStyle       =   0  '투명
         Caption         =   "Shortage"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   345
         Index           =   0
         Left            =   1365
         TabIndex        =   1
         Top             =   150
         Width           =   5790
      End
      Begin VB.Image Image1 
         Height          =   585
         Left            =   30
         Picture         =   "frmMO06VJ.frx":0000
         Top             =   30
         Width           =   4950
      End
   End
   Begin MSComctlLib.StatusBar sbrStatus 
      Align           =   2  '아래 맞춤
      Height          =   360
      Left            =   0
      TabIndex        =   5
      Top             =   7935
      Width           =   11910
      _ExtentX        =   21008
      _ExtentY        =   635
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   2
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Object.Width           =   18521
            MinWidth        =   18521
            Key             =   "msg"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Alignment       =   1
            Object.Width           =   2822
            MinWidth        =   2822
            Text            =   "V 1.0"
            TextSave        =   "V 1.0"
            Key             =   "plVer"
            Object.ToolTipText     =   "버젼"
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "굴림"
         Size            =   11.25
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSComCtl2.DTPicker dtpYMD 
      Height          =   360
      Left            =   675
      TabIndex        =   8
      Top             =   705
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   635
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Microsoft Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Format          =   23855105
      CurrentDate     =   37956
      MinDate         =   37956
   End
   Begin MSComDlg.CommonDialog cndSave 
      Left            =   2565
      Top             =   630
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DefaultExt      =   "text (*.txt)"
   End
   Begin VB.Label Label1 
      Caption         =   "Date:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   270
      Left            =   90
      TabIndex        =   9
      Top             =   750
      Width           =   660
   End
End
Attribute VB_Name = "frmMO06VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'Dim Lv_SIZE As Integer  '스프레드의 사이즈 시작 칼럼(0부터 시작)
'Dim vGEN_COUNT As Variant
'Dim vSIZE_COUNT As Variant
'Dim vCol_Arr As Variant
Dim vWidth As Variant
Dim vLastUpTM As Variant

Dim vMSG As String

Private Sub cmdPrint_Click()
   Dim vOldWidth As Variant
   Dim i As Integer
   
   ReDim vOldWidth(fspBal.Cols - 1) As Integer
   For i = 0 To UBound(vOldWidth) Step 1
      vOldWidth(i) = fspBal.ColWidth(i)
   Next i
   
   fspBal.AddItem "" & vbTab & "", 0
   
   fspBal.Cell(flexcpText, 0, 0, 0, 5) = lbTitle(0).Caption
   fspBal.Cell(flexcpFontSize, 0, 0, 0, 5) = 12
   fspBal.Cell(flexcpFontBold, 0, 0, 0, 5) = True
   'fspBal.Cell(flexcpFontUnderline, 0, 0, 0, 2) = True
   fspBal.Cell(flexcpText, 0, 6, 0, fspBal.Cols - 1) = "D-DAY: " & Format(dtpYMD.Value, "YYYY/MM/DD") & _
                                                       "                Update Time: " & vLastUpTM(0, 0) & _
                                                       "                Print Date: " & Format(Now, "YYYY/MM/DD HH:MM:SS")
   fspBal.Cell(flexcpAlignment, 0, 6, 0, fspBal.Cols - 1) = 8
   fspBal.Cell(flexcpBackColor, 0, 0, 0, fspBal.Cols - 1) = vbWhite
   
   fspBal.MergeRow(0) = True
   fspBal.RowHeightMax = 900
   fspBal.RowHeightMax = 300
   fspBal.RowHeight(0) = 900
   
   fspBal.ColWidth(1) = vOldWidth(1) + 500
   For i = 3 To UBound(vOldWidth) - 1 Step 1
      If i = 10 Or i = 14 Or i = 20 Then
      Else
         fspBal.ColWidth(i) = vOldWidth(i) + 160
      End If
   Next i
   fspBal.FixedRows = 3
   
   fspBal.PrintGrid "", True, 2, 150, 200
   
   For i = 0 To UBound(vOldWidth) Step 1
      fspBal.ColWidth(i) = vOldWidth(i)
   Next i
   
   fspBal.RemoveItem 0
   
   fspBal.FixedRows = 2
End Sub

Private Sub cmdSearch_Click()
   Call sbBalDsp
End Sub



Private Sub Form_Load()
      
   dtpYMD.Value = Now
      
   lbTitle(0).Caption = "Shortage"
   lbTitle(1).Caption = lbTitle(0).Caption
   
   Me.Left = 0
   Me.Top = 0
   vWidth = 600
   
   Call sbHeadBalDsp
   
End Sub


Private Sub sbBalDsp()
   Dim SQL As String
   Dim strYMD As String
   Dim vNextYMD As Variant
   Dim arrBTM As Variant
   Dim arrFSS As Variant
   Dim arrUPS As Variant
   Dim arrFGA As Variant
   Dim arrDATA As Variant
   Dim vFixedCols As Integer
   Dim i As Integer
   Dim j As Integer
   Dim k As Integer
   Dim Rows_1 As Integer
   Dim Cols_1 As Integer
        
   Call sbHeadBalDsp
      
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   SQL = ""
   SQL = SQL & " SELECT FN_MM_NEXT_DAY('" & strYMD & "') FROM DUAL "
   
   Screen.MousePointer = 11
   vNextYMD = fnGetOraData(SQL)
   
   If Not IsArray(vNextYMD) Then
      Screen.MousePointer = 1
      If vNextYMD = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(vNextYMD, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   SQL = ""
   SQL = SQL & " SELECT TO_CHAR(MAX(UPD_YMD),'YYYY/MM/DD HH24:MI:SS') FROM MP_APPLY "
   
   vLastUpTM = fnGetOraData(SQL)
   
   If Not IsArray(vLastUpTM) Then
      Screen.MousePointer = 1
      If vLastUpTM = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(vLastUpTM, gMsgDspSec)
      End If
      Exit Sub
   End If
   
      
   SQL = ""
   SQL = SQL & " SELECT ' ', ASSY_LINE, ' ', ABC_ID, OS_DM1DAY, OS_DDAY, PH_DM1DAY, PH_DDAY, PU_DM1DAY, PU_DDAY  "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT B.RES_CD AS ASSY_LINE, 'D+0/'||B.ABC_ID AS ABC_ID,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'OSP',DECODE(LEAST(A.DIR_YMD,'" & strYMD & "'), '" & strYMD & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS OS_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'OSP',DECODE(A.DIR_YMD,'" & strYMD & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS OS_DDAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP',DECODE(LEAST(A.DIR_YMD,'" & strYMD & "'), '" & strYMD & "', 0,"
   SQL = SQL & "                                    DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI',DECODE(LEAST(A.DIR_YMD,'" & strYMD & "'), '" & strYMD & "', 0,"
   SQL = SQL & "                                    DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS PH_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP',DECODE(A.DIR_YMD,'" & strYMD & "', DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI',DECODE(A.DIR_YMD,'" & strYMD & "', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS PH_DDAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PUS',DECODE(LEAST(A.DIR_YMD,'" & strYMD & "'), '" & strYMD & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'SPP',DECODE(LEAST(A.DIR_YMD,'" & strYMD & "'), '" & strYMD & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS PU_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PUS',DECODE(A.DIR_YMD,'" & strYMD & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'SPP',DECODE(A.DIR_YMD,'" & strYMD & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS PU_DDAY"
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD IN ('OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '3' AND B.ABC_ID <= '8')"
   SQL = SQL & " GROUP BY B.RES_CD, B.ABC_ID"
   SQL = SQL & " Union All"
   SQL = SQL & " SELECT B.RES_CD AS ASSY_LINE, 'D+1/'||B.ABC_ID AS ABC_ID,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'OSP',DECODE(LEAST(A.DIR_YMD,'" & vNextYMD(0, 0) & "'), '" & vNextYMD(0, 0) & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS OS_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'OSP',DECODE(A.DIR_YMD,'" & vNextYMD(0, 0) & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS OS_DDAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP',DECODE(LEAST(A.DIR_YMD,'" & vNextYMD(0, 0) & "'), '" & vNextYMD(0, 0) & "', 0,"
   SQL = SQL & "                                    DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI',DECODE(LEAST(A.DIR_YMD,'" & vNextYMD(0, 0) & "'), '" & vNextYMD(0, 0) & "', 0,"
   SQL = SQL & "                                    DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS PH_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP',DECODE(A.DIR_YMD,'" & vNextYMD(0, 0) & "', DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI',DECODE(A.DIR_YMD,'" & vNextYMD(0, 0) & "', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS PH_DDAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PUS',DECODE(LEAST(A.DIR_YMD,'" & vNextYMD(0, 0) & "'), '" & vNextYMD(0, 0) & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'SPP',DECODE(LEAST(A.DIR_YMD,'" & vNextYMD(0, 0) & "'), '" & vNextYMD(0, 0) & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS PU_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PUS',DECODE(A.DIR_YMD,'" & vNextYMD(0, 0) & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'SPP',DECODE(A.DIR_YMD,'" & vNextYMD(0, 0) & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS PU_DDAY"
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
   SQL = SQL & "   AND A.OP_CD IN ('OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '2')"
   SQL = SQL & " GROUP BY B.RES_CD, B.ABC_ID"
   SQL = SQL & "    )"
   SQL = SQL & " ORDER BY 2, 4 "
   
   arrBTM = fnGetOraData(SQL)
   
   If IsArray(arrBTM) Then
      
      'vFixedCols = fspBal.FrozenCols
      'fspBal.FrozenCols = 0
      'fspBal.LoadArray arrDATA
      'fspBal.FrozenCols = vFixedCols
      
   Else
      Screen.MousePointer = 1
      If arrBTM = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrBTM, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   '---------------- FSS ----------------
   SQL = ""
   SQL = SQL & " SELECT ASSY_LINE, ABC_ID, FS_DM1DAY, FS_DDAY "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT B.RES_CD AS ASSY_LINE, 'D+0/'||B.ABC_ID AS ABC_ID,"
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'OS',DECODE(LEAST(A.DIR_YMD,'" & strYMD & "'), '" & strYMD & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS FS_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'OS',DECODE(A.DIR_YMD,'" & strYMD & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS FS_DDAY"
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD    = 'FSS'"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '5' AND B.ABC_ID <= '8')"
   SQL = SQL & " GROUP BY B.RES_CD, B.ABC_ID"
   SQL = SQL & " Union All"
   SQL = SQL & " SELECT B.RES_CD AS ASSY_LINE, 'D+1/'||B.ABC_ID AS ABC_ID,"
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'OS',DECODE(LEAST(A.DIR_YMD,'" & vNextYMD(0, 0) & "'), '" & vNextYMD(0, 0) & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS FS_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'OS',DECODE(A.DIR_YMD,'" & vNextYMD(0, 0) & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS FS_DDAY"
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
   SQL = SQL & "   AND A.OP_CD    = 'FSS'"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '4')"
   SQL = SQL & " GROUP BY B.RES_CD, B.ABC_ID"
   SQL = SQL & "    )"
   SQL = SQL & " ORDER BY 1, 2 "
   
   arrFSS = fnGetOraData(SQL)
   
   If IsArray(arrFSS) Then
      
      'vFixedCols = fspBal.FrozenCols
      'fspBal.FrozenCols = 0
      'fspBal.LoadArray arrDATA, 2, 10
      'fspBal.FrozenCols = vFixedCols
      
   Else
      Screen.MousePointer = 1
      If arrFSS = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrFSS, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   '---------------- UPS ----------------
   SQL = ""
   SQL = SQL & " SELECT ASSY_LINE, ABC_ID, UPS1_DM1DAY, UPS1_DDAY, UPS2_DM1DAY, UPS2_DDAY "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT B.RES_CD AS ASSY_LINE, 'D+0/'||B.ABC_ID AS ABC_ID,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'UPSUPC1',DECODE(LEAST(A.DIR_YMD,'" & strYMD & "'), '" & strYMD & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS UPS1_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'UPSUPC1',DECODE(A.DIR_YMD,'" & strYMD & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS UPS1_DDAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'FGAUPC2',DECODE(LEAST(A.DIR_YMD,'" & strYMD & "'), '" & strYMD & "', 0,"
   SQL = SQL & "                                    DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS UPS2_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'FGAUPC2',DECODE(A.DIR_YMD,'" & strYMD & "', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS UPS2_DDAY"
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD   IN ('UPS','FGA')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '2' AND B.ABC_ID <= '8')"
   SQL = SQL & " GROUP BY B.RES_CD, B.ABC_ID"
   SQL = SQL & " Union All"
   SQL = SQL & " SELECT B.RES_CD AS ASSY_LINE, 'D+1/'||B.ABC_ID AS ABC_ID,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'UPSUPC1',DECODE(LEAST(A.DIR_YMD,'" & vNextYMD(0, 0) & "'), '" & vNextYMD(0, 0) & "', 0,"
   SQL = SQL & "                                    DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS UPS1_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'UPSUPC1',DECODE(A.DIR_YMD,'" & vNextYMD(0, 0) & "', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS UPS1_DDAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'FGAUPC2',DECODE(LEAST(A.DIR_YMD,'" & vNextYMD(0, 0) & "'), '" & vNextYMD(0, 0) & "', 0,"
   SQL = SQL & "                                    DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS UPS2_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'FGAUPC2',DECODE(A.DIR_YMD,'" & vNextYMD(0, 0) & "', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS UPS2_DDAY"
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
   SQL = SQL & "   AND A.OP_CD   IN ('UPS','FGA')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND B.ABC_ID   = '1' "
   SQL = SQL & " GROUP BY B.RES_CD, B.ABC_ID"
   SQL = SQL & "    )"
   SQL = SQL & " ORDER BY 1, 2 "

   arrUPS = fnGetOraData(SQL)

   If IsArray(arrUPS) Then

      'vFixedCols = fspBal.FrozenCols
      'fspBal.FrozenCols = 0
      'fspBal.LoadArray arrDATA
      'fspBal.FrozenCols = vFixedCols

   Else
      Screen.MousePointer = 1
      If arrUPS = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrUPS, gMsgDspSec)
      End If
      Exit Sub
   End If

   '---------------- FGA ----------------
   SQL = ""
   SQL = SQL & " SELECT ASSY_LINE, ABC_ID, FG_DM1DAY, FG_DDAY, ' '  "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT B.RES_CD AS ASSY_LINE, 'D+0/'||B.ABC_ID AS ABC_ID,"
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'UP',DECODE(LEAST(A.DIR_YMD,'" & strYMD & "'), '" & strYMD & "', 0,"
   SQL = SQL & "                                   DECODE(A.T_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)),0)) AS FG_DM1DAY,"
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'UP',DECODE(A.DIR_YMD,'" & strYMD & "', DECODE(A.T_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0), 0),0)) AS FG_DDAY"
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD    = 'FGA'"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '8')"
   SQL = SQL & " GROUP BY B.RES_CD, B.ABC_ID"
   SQL = SQL & "    )"
   SQL = SQL & " ORDER BY 1, 2 "

   arrFGA = fnGetOraData(SQL)

   If IsArray(arrFGA) Then

      'vFixedCols = fspBal.FrozenCols
      'fspBal.FrozenCols = 0
      'fspBal.LoadArray arrDATA
      'fspBal.FrozenCols = vFixedCols

   Else
      Screen.MousePointer = 1
      If arrFGA = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrFGA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   Screen.MousePointer = 1
   
   '----------------
   Cols_1 = UBound(arrBTM, 1) + UBound(arrFSS, 1) + 1 + UBound(arrUPS, 1) + 1 + UBound(arrFGA, 1) + 1
   Rows_1 = UBound(arrBTM, 2)
   ReDim arrDATA(Cols_1, Rows_1)
   
   For i = 0 To Rows_1 Step 1
      k = 0
      For j = 0 To UBound(arrBTM, 1) Step 1
          arrDATA(k, i) = arrBTM(j, i)
          k = k + 1
      Next
      For j = 0 To UBound(arrFSS, 1) Step 1
          arrDATA(k, i) = arrFSS(j, i)
          k = k + 1
      Next
      For j = 0 To UBound(arrUPS, 1) Step 1
          arrDATA(k, i) = arrUPS(j, i)
          k = k + 1
      Next
      For j = 0 To UBound(arrFGA, 1) Step 1
          arrDATA(k, i) = arrFGA(j, i)
          k = k + 1
      Next
   Next i
   
   fspBal.LoadArray arrDATA
   
   For i = 2 To fspBal.Rows - 1 Step 1
      fspBal.TextMatrix(i, 3) = Mid(fspBal.TextMatrix(i, 3), 5, 1) & "H"
      fspBal.TextMatrix(i, 11) = Mid(fspBal.TextMatrix(i, 11), 5, 1) & "H"
      fspBal.TextMatrix(i, 15) = Mid(fspBal.TextMatrix(i, 15), 5, 1) & "H"
      fspBal.TextMatrix(i, 21) = Mid(fspBal.TextMatrix(i, 21), 5, 1) & "H"
   Next i
   
   For i = 4 To fspBal.Cols - 1 Step 1
      If Mid(fspBal.TextMatrix(1, i), 1, 1) = "D" Then
         fspBal.Subtotal flexSTSum, 1, i, "######", vbYellow, , , ""
      End If
   Next i
   
   For i = 4 To fspBal.Cols - 1 Step 1
      If Mid(fspBal.TextMatrix(1, i), 1, 1) = "D" Then
         fspBal.Subtotal flexSTSum, -1, i, "######", vbYellow, , , " "
      End If
   Next i
   fspBal.TextMatrix(fspBal.Rows - 1, 1) = "G-Total"
   fspBal.Cell(flexcpAlignment, fspBal.FixedRows, 4, fspBal.Rows - 1, fspBal.Cols - 1) = 7
   fspBal.Cell(flexcpAlignment, fspBal.FixedRows, 1, fspBal.Rows - 1, 1) = 4
   fspBal.Cell(flexcpAlignment, fspBal.FixedRows, 3, fspBal.Rows - 1, 3) = 4
   fspBal.Cell(flexcpAlignment, fspBal.FixedRows, 11, fspBal.Rows - 1, 11) = 4
   fspBal.Cell(flexcpAlignment, fspBal.FixedRows, 15, fspBal.Rows - 1, 15) = 4
   fspBal.Cell(flexcpAlignment, fspBal.FixedRows, 21, fspBal.Rows - 1, 21) = 4
   
   'Call sbSpdVLine(fspBal, 2, 0)
   'Call sbSpdVLine(fspBal, 10, 0)
   'Call sbSpdVLine(fspBal, 14, 0)
   'Call sbSpdVLine(fspBal, 20, 0)
   'Call sbSpdVLine(fspBal, 24, 0)
   
   'For i = fspBal.FixedRows To fspBal.Rows - 1 Step 1
   '   If Mid(fspBal.TextMatrix(i, 0), 1, 1) = "T" Or Mid(fspBal.TextMatrix(i, 0), 1, 1) = "G" Then
   '      fspBal.TextMatrix(i, 1) = fspBal.TextMatrix(i, 0)
   '      fspBal.TextMatrix(i, 0) = ""
   '   End If
   'Next
   
   cmdPrint.Enabled = True
   
End Sub

Private Sub sbHeadBalDsp()
   Dim i As Integer
   Dim j As Integer
               
   fspBal.Clear
   
   fspBal.FontSize = 8
   fspBal.MergeCells = flexMergeFree
   
   fspBal.FrozenCols = 1
   fspBal.Cols = 19 + 6 ' 6 are line.
   'fspBal.Rows = 84
   
   Call sbSpdVLine(fspBal, 0, 0)
   fspBal.Cell(flexcpText, 0, 1, 1, 1) = "Ln"
   
   
   fspBal.Cell(flexcpText, 0, 3, 1, 3) = "Time"
   fspBal.Cell(flexcpText, 0, 4, 0, 5) = "OS"
   fspBal.Cell(flexcpText, 1, 4, 1, 4) = "D-1"
   fspBal.Cell(flexcpText, 1, 5, 1, 5) = "D-Day"
   fspBal.Cell(flexcpText, 0, 6, 0, 7) = "PH"
   fspBal.Cell(flexcpText, 1, 6, 1, 6) = "D-1"
   fspBal.Cell(flexcpText, 1, 7, 1, 7) = "D-Day"
   fspBal.Cell(flexcpText, 0, 8, 0, 9) = "PU+SP"
   fspBal.Cell(flexcpText, 1, 8, 1, 8) = "D-1"
   fspBal.Cell(flexcpText, 1, 9, 1, 9) = "D-Day"
      
   fspBal.Cell(flexcpText, 0, 11, 1, 11) = "Time"
   fspBal.Cell(flexcpText, 0, 12, 0, 13) = "FSS"
   fspBal.Cell(flexcpText, 1, 12, 1, 12) = "D-1"
   fspBal.Cell(flexcpText, 1, 13, 1, 13) = "D-Day"
   
   fspBal.Cell(flexcpText, 0, 15, 1, 15) = "Time"
   fspBal.Cell(flexcpText, 0, 16, 0, 17) = "UPS1"
   fspBal.Cell(flexcpText, 1, 16, 1, 16) = "D-1"
   fspBal.Cell(flexcpText, 1, 17, 1, 17) = "D-Day"
   fspBal.Cell(flexcpText, 0, 18, 0, 19) = "UPS2"
   fspBal.Cell(flexcpText, 1, 18, 1, 18) = "D-1"
   fspBal.Cell(flexcpText, 1, 19, 1, 19) = "D-Day"
   
   fspBal.Cell(flexcpText, 0, 21, 1, 21) = "Time"
   fspBal.Cell(flexcpText, 0, 22, 0, 23) = "FGA"
   fspBal.Cell(flexcpText, 1, 22, 1, 22) = "D-1"
   fspBal.Cell(flexcpText, 1, 23, 1, 23) = "D-Day"
   
   fspBal.MergeRow(0) = True
   fspBal.MergeCol(1) = True
   fspBal.MergeCol(3) = True
   fspBal.MergeCol(11) = True
   fspBal.MergeCol(15) = True
   fspBal.MergeCol(21) = True
   
   fspBal.ColWidth(1) = 270
   fspBal.ColWidth(3) = 420
   For i = 4 To fspBal.Cols - 1 Step 1
      fspBal.ColWidth(i) = 680
   Next
   
   fspBal.ColWidth(11) = 420
   fspBal.ColWidth(15) = 420
   fspBal.ColWidth(21) = 420
      
   'Vertical Line
   Call sbSpdVLine(fspBal, 2, 0)
   Call sbSpdVLine(fspBal, 10, 0)
   Call sbSpdVLine(fspBal, 14, 0)
   Call sbSpdVLine(fspBal, 20, 0)
   Call sbSpdVLine(fspBal, 24, 0)
   
   fspBal.RowHeightMax = "220"
   fspBal.RowHeightMin = "220"
   
   fspBal.Cell(flexcpAlignment, 0, 0, 1, fspBal.Cols - 1) = 4
      
   fspBal.Rows = fspBal.FixedRows
   
End Sub


Private Sub Form_Unload(Cancel As Integer)
   Call frmMO01VJ.sbDspData(Format(frmMO01VJ.dtpYMD.Value, "YYYYMMDD"), "ALL")
   If frmMO01VJ.chkAutoScan.Value = 1 Then
      frmMO01VJ.tmrScan.Enabled = True
   End If
End Sub

Private Sub fspBal_Click()
'   Dim varArr As Variant
'   Dim Row As Long
'
'   Row = fspBal.Row
'   If Row = fspBal.Rows - 1 Then
'      Exit Sub
'   End If
'
'   ReDim varArr(1) As String
'
'   varArr(0) = fspBal.TextMatrix(Row, 0)                   'ASSY_LINE
'   varArr(1) = fspBal.TextMatrix(Row, 2)                   'STYLE_CD
'
'   If Mid(fspBal.TextMatrix(fspBal.Row, 1), 1, 1) = "T" Or Mid(fspBal.TextMatrix(fspBal.Row, 1), 1, 1) = "G" Then
'      Exit Sub
'   End If
'   Call sbTmDSP
End Sub

Private Sub fspBal_DblClick()
   Dim strLine As String
   
   strLine = fspBal.TextMatrix(fspBal.Row, 1)
   If UCase(Mid(strLine, 1, 1)) = "T" Or UCase(Mid(strLine, 1, 1)) = "G" Then
      Exit Sub
   Else
      frmMO09VJ.Show 1
   End If
End Sub

Private Sub Label1_DblClick()
   If cmdPrint.Enabled Then
      'cndSave.DefaultExt = "*.txt"
      
      cndSave.ShowSave
      If cndSave.FileName = "" Then
      Else
         On Error GoTo err_rtn
         fspBal.SaveGrid cndSave.FileName, flexFileTabText, True
      End If
   End If
   Exit Sub
err_rtn:
   Call sbMsgDsp("Can not file open!", gMsgDspSec)
End Sub

'Private Sub sbHeadTmDSP()
'
'   Dim i As Integer
'
'   fspTM.Clear
'
'   fspTM.FontSize = 8
'   fspTM.MergeCells = flexMergeFree
'
'   'fspTM.FrozenCols = 1
'   fspTM.Cols = 15
'
'   fspTM.Cell(flexcpText, 0, 0, 0, 4) = "Bottom"
'   fspTM.Cell(flexcpText, 1, 0, 1, 0) = "Time"
'   fspTM.Cell(flexcpText, 1, 1, 1, 1) = "Plan"
'   fspTM.Cell(flexcpText, 1, 2, 1, 2) = "OS"
'   fspTM.Cell(flexcpText, 1, 3, 1, 3) = "PH"
'   fspTM.Cell(flexcpText, 1, 4, 1, 4) = "PU+SP"
'
'   fspTM.Cell(flexcpText, 0, 5, 0, 7) = "FSS"
'   fspTM.Cell(flexcpText, 1, 5, 1, 5) = "Time"
'   fspTM.Cell(flexcpText, 1, 6, 1, 6) = "Plan"
'   fspTM.Cell(flexcpText, 1, 7, 1, 7) = "FS"
'
'   fspTM.Cell(flexcpText, 0, 8, 0, 11) = "UPS"
'   fspTM.Cell(flexcpText, 1, 8, 1, 8) = "Time"
'   fspTM.Cell(flexcpText, 1, 9, 1, 9) = "Plan"
'   fspTM.Cell(flexcpText, 1, 10, 1, 10) = "UPS1"
'   fspTM.Cell(flexcpText, 1, 11, 1, 11) = "UPS2"
'
'   fspTM.Cell(flexcpText, 0, 12, 0, 14) = "FGA"
'   fspTM.Cell(flexcpText, 1, 12, 1, 12) = "Time"
'   fspTM.Cell(flexcpText, 1, 13, 1, 13) = "Plan"
'   fspTM.Cell(flexcpText, 1, 14, 1, 14) = "FG"
'
'   fspTM.MergeRow(0) = True
'
'   For i = 0 To fspTM.Cols - 1 Step 1
'      fspTM.ColWidth(i) = 780
'   Next
'   fspTM.RowHeightMax = "220"
'   fspTM.RowHeightMin = "220"
'
'   fspTM.Cell(flexcpAlignment, 0, 0, 1, fspTM.Cols - 1) = 4
'
'   fspTM.Rows = fspTM.FixedRows
'   'fspTM.Rows = 11
'End Sub


Private Sub SSCommand1_Click()
   Unload frmMO06VJ
End Sub


Private Sub sbMsgDsp(arg_TXT As Variant, arg_ITVL As Integer)
   tmr1.Enabled = False
   sbrStatus.Panels.Item(1).Text = ""
   sbrStatus.Panels.Item(1).Text = arg_TXT
   tmr1.Interval = arg_ITVL * 1000
   tmr1.Enabled = True
End Sub

Private Sub tmr1_Timer()
   sbrStatus.Panels.Item(1).Text = ""
   tmr1.Enabled = False
End Sub
