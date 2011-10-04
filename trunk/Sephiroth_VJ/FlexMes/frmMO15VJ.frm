VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO15VJ 
   Caption         =   "MES-MO15VJ"
   ClientHeight    =   8145
   ClientLeft      =   75
   ClientTop       =   360
   ClientWidth     =   11895
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   8145
   ScaleWidth      =   11895
   Begin VB.CheckBox chkShp 
      Caption         =   "Without Shipped"
      Height          =   345
      Left            =   10110
      TabIndex        =   12
      Top             =   735
      Width           =   1965
   End
   Begin VB.ComboBox cboGrade 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   3720
      Style           =   2  '드롭다운 목록
      TabIndex        =   8
      Top             =   675
      Width           =   1995
   End
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   4725
      Top             =   435
   End
   Begin VSFlex7LCtl.VSFlexGrid fspStock 
      Height          =   5250
      Left            =   75
      TabIndex        =   4
      Top             =   1095
      Width           =   11850
      _cx             =   20902
      _cy             =   9260
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
      Rows            =   1
      Cols            =   1
      FixedRows       =   1
      FixedCols       =   0
      RowHeightMin    =   0
      RowHeightMax    =   0
      ColWidthMin     =   0
      ColWidthMax     =   0
      ExtendLastCol   =   0   'False
      FormatString    =   ""
      ScrollTrack     =   0   'False
      ScrollBars      =   3
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
         Size            =   9.01
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
      End
      Begin Threed.SSCommand cmdSearch 
         Height          =   435
         Left            =   7560
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
         Caption         =   "F/N Goods Stock"
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
         Caption         =   "F/N Goods Stock"
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
         Picture         =   "frmMO15VJ.frx":0000
         Top             =   30
         Width           =   4950
      End
   End
   Begin MSComctlLib.StatusBar sbrStatus 
      Align           =   2  '아래 맞춤
      Height          =   360
      Left            =   0
      TabIndex        =   5
      Top             =   7785
      Width           =   11895
      _ExtentX        =   20981
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
   Begin MSComDlg.CommonDialog cndSave 
      Left            =   1995
      Top             =   1125
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DefaultExt      =   "text (*.txt)"
   End
   Begin MSComCtl2.DTPicker dtpYMD 
      Height          =   360
      Left            =   795
      TabIndex        =   9
      Top             =   675
      Width           =   1605
      _ExtentX        =   2831
      _ExtentY        =   635
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Format          =   23789569
      CurrentDate     =   37956
      MinDate         =   37956
   End
   Begin VSFlex7LCtl.VSFlexGrid fspSIZE2 
      Height          =   1410
      Left            =   75
      TabIndex        =   13
      Top             =   6390
      Width           =   11850
      _cx             =   20902
      _cy             =   2487
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
      Rows            =   1
      Cols            =   1
      FixedRows       =   1
      FixedCols       =   0
      RowHeightMin    =   0
      RowHeightMax    =   0
      ColWidthMin     =   0
      ColWidthMax     =   0
      ExtendLastCol   =   0   'False
      FormatString    =   ""
      ScrollTrack     =   0   'False
      ScrollBars      =   3
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
   Begin Threed.SSCommand SSCommand2 
      Height          =   360
      Left            =   7950
      TabIndex        =   14
      Top             =   720
      Width           =   2040
      _Version        =   65536
      _ExtentX        =   3598
      _ExtentY        =   635
      _StockProps     =   78
      Caption         =   "Show All Column"
   End
   Begin VB.Label Label2 
      Caption         =   "Goods :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2850
      TabIndex        =   11
      Top             =   720
      Width           =   930
   End
   Begin VB.Label Label1 
      Caption         =   "Date :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   135
      TabIndex        =   10
      Top             =   720
      Width           =   705
   End
End
Attribute VB_Name = "frmMO15VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'Dim Lv_SIZE As Integer  '스프레드의 사이즈 시작 칼럼(0부터 시작)
'Dim vGEN_COUNT As Variant
Dim vSIZE_COUNT As Variant
'Dim vCol_Arr As Variant
Dim vWidth As Variant
Dim vMSG As String

Private Declare Function GetComputerName Lib "kernel32" Alias "GetComputerNameA" (ByVal lpBuffer As String, nSize As Long) As Long

'Private Sub cboComp_Click()
'   If Trim(fnCboValue(cboProc)) <> "" And Trim(fnCboValue(cboComp)) <> "" Then
'      Call cmdSearch_Click
'   End If
'End Sub

Private Sub cmdPrint_Click()
   Dim vOldWidth As Variant
   
   Dim i As Integer
   
   Dim strYMD As String
   Dim lngRTN As Long
   Dim strGrade As String
   Dim strShip As String
      
   'Dim buffer As String
   'Dim PCname As String
   
   
   'buffer = Space(32)
   'lngRTN = GetComputerName(buffer, 32)
   'PCname = fnRemoveNUL(buffer)
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   If Trim(fnCboValue(cboGrade)) = "" Then
      Exit Sub
   End If
   strGrade = fnCboDesc(cboGrade)
   
   If chkShp.Value = 1 Then
      strShip = "Without shipped"
   Else
      strShip = "               "
   End If
   
   fspStock.AddItem "" & vbTab & "", 0
   
   fspStock.Cell(flexcpText, 0, 0, 0, 4) = "F/N Goods Stock"
   fspStock.Cell(flexcpFontSize, 0, 0, 0, 4) = 12
   fspStock.Cell(flexcpFontBold, 0, 0, 0, 4) = True
   'fspStock.Cell(flexcpFontUnderline, 0, 0, 0, 4) = True
   fspStock.Cell(flexcpText, 0, 5, 0, fspStock.Cols - 1) = "Date: " & Format(dtpYMD.Value, "YYYY/MM/DD") & Space(6) & _
                                                       "Goods: " & strGrade & Space(4) & _
                                                        strShip & Space(4) & _
                                                       "Print Date: " & Format(Now, "YYYY/MM/DD HH:MM:SS")
   fspStock.Cell(flexcpAlignment, 0, 3, 0, fspStock.Cols - 1) = 8
   fspStock.Cell(flexcpBackColor, 0, 0, 0, fspStock.Cols - 1) = vbWhite
   
   fspStock.MergeRow(0) = True
   fspStock.RowHeightMax = 900
   fspStock.RowHeightMax = 350
   fspStock.RowHeight(0) = 900
   fspStock.RowHeight(1) = 220
   fspStock.RowHeight(2) = 480
   
   ReDim vOldWidth(fspStock.Cols - 1) As Integer
   For i = 0 To fspStock.Cols - 1 Step 1
      vOldWidth(i) = fspStock.ColWidth(i)
   Next
   
   fspStock.ColWidth(0) = fspStock.ColWidth(0) + 50
   fspStock.ColWidth(1) = 2600
   fspStock.ColWidth(2) = fspStock.ColWidth(2) + 50
   
   For i = 5 To fspStock.Cols - 1 Step 1
      fspStock.ColWidth(i) = fspStock.ColWidth(i) + 50
   Next i
   fspStock.FixedRows = 3
   
   fspStock.PrintGrid "", True, 2, 150, 250
   
   For i = 0 To fspStock.Cols - 1 Step 1
      fspStock.ColWidth(i) = vOldWidth(i)
   Next i
   fspStock.RemoveItem 0
   
   fspStock.FixedRows = 2
   fspStock.RowHeightMax = 420
   fspStock.RowHeightMin = 220
   fspStock.RowHeight(1) = 420
   fspStock.RowHeight(2) = 220
End Sub

Private Sub cmdSearch_Click()
   Call sbStockDsp
End Sub

Private Sub Form_Load()
   Dim SQL As String
   Dim strRtn As String
   
   lbTitle(0).Caption = "F/N Goods Stock"
   lbTitle(1).Caption = lbTitle(0).Caption
   
   Me.Left = 0
   Me.Top = 0
   vWidth = 600
   
   dtpYMD.Value = frmMO01VJ.dtpYMD.Value
   
   '--------Initializing ComboBox--------
   'GRADE
   SQL = " SELECT DCODE AS CD, CD_NAME AS NM FROM CM_CODE WHERE MCODE = 'MG01' AND DCODE <> '0000' "
   strRtn = fnSetCbo(cboGrade, SQL)
      
   'Lv_SIZE = 4
   'vGEN_COUNT = 3
   vSIZE_COUNT = 31
   
   Call sbHeadStockDsp
   
   Call sbHeadSizeDSP("ME")
   
   'Getting Process
   
End Sub

Private Sub sbStockDsp()
   Dim SQL As String
   Dim arrDATA As Variant
   Dim vFixedCols As Integer
   Dim i As Integer
   Dim EXESQL As String
   Dim strRtn As String
   
   Dim strYMD As String
   Dim strGrade As String
   Dim lngRTN As Long
   
   'Dim buffer As String
   'Dim PCname As String
   'buffer = Space(32)
   'lngRTN = GetComputerName(buffer, 32)
   'PCname = fnRemoveNUL(buffer)
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   strGrade = fnCboValue(cboGrade)
   If Trim(strGrade) = "" Then
      Exit Sub
   End If
      
   'EXESQL = "BEGIN SP_MM_IVTR('" & strYMD & "','" & varVAL(0) & "','" & strSEC & "','" & PCname & "'); END; "
   'Screen.MousePointer = 11
   'strRtn = fnExecOraSQL2(EXESQL)
   'Screen.MousePointer = 1
   'If strRtn <> "" Then
   '   Exit Sub
   'End If
   
   Call sbHeadStockDsp
      
   Call sbHeadSizeDSP("ME")
   
   If strYMD < "20041101" Then
      SQL = ""
      SQL = SQL & " SELECT A.PO_ID||A.PO_TYPE, "
      SQL = SQL & "     MAX(FN_MODEL2(A.STYLE_CD)), "
      SQL = SQL & "     SUBSTR(A.STYLE_CD,1,6)||'-'||SUBSTR(A.STYLE_CD,7,3), "
      SQL = SQL & "     MAX(A.DEST), "
      SQL = SQL & "     A.OBS_SEQ, "
      SQL = SQL & "     MAX(B.TOT_QTY), "
      SQL = SQL & "     MAX(A.RMK), "
      SQL = SQL & "     SUM(A.BSQTY)," 'BEFORE MONTH STOCK
      SQL = SQL & "     SUM(A.BPQTY)," 'BEFORE MONTH accumulative SHIP QTY
      SQL = SQL & "     SUM(A.IBQTY),"
      SQL = SQL & "     SUM(A.ITQTY),"
      SQL = SQL & "     SUM(A.IEQTY),"
      SQL = SQL & "     DECODE(MAX(B.TOT_QTY),0, 0, MAX(B.TOT_QTY) - SUM(A.BSQTY + A.BPQTY + A.IBQTY + A.ITQTY + A.IEQTY - A.OGQTY - A.OCQTY - A.OEQTY)),"
      SQL = SQL & "     SUM(A.OGQTY),"
      SQL = SQL & "     SUM(A.OCQTY),"
      SQL = SQL & "     SUM(A.OEQTY),"
      SQL = SQL & "     SUM(A.SBQTY),"
      SQL = SQL & "     SUM(A.STQTY),"
      SQL = SQL & "     DECODE(MAX(B.TOT_QTY),0, 0,MAX(B.TOT_QTY) - SUM(A.BPQTY + A.SBQTY + A.STQTY)),"
      SQL = SQL & "     SUM(A.BSQTY + (IBQTY + ITQTY + A.IEQTY) - (A.OGQTY + A.OCQTY + A.OEQTY) - (A.SBQTY + A.STQTY)) "
      SQL = SQL & "  FROM "
      SQL = SQL & "("
      SQL = SQL & " SELECT PO_ID, PO_TYPE, STYLE_CD, DEST, OBS_SEQ,"
      SQL = SQL & "     PRS_QTY AS BSQTY, SHP_QTY AS BPQTY,"
      SQL = SQL & "     0 AS IBQTY, 0 AS ITQTY, 0 AS IEQTY,"
      SQL = SQL & "     0 AS OGQTY, 0 AS OCQTY, 0 AS OEQTY,"
      SQL = SQL & "     0 AS SBQTY, 0 AS STQTY ,"
      SQL = SQL & "     '' AS RMK "
      SQL = SQL & "   FROM MG_MONSTK "
      SQL = SQL & "  WHERE YM    = TO_CHAR(ADD_MONTHS(TO_DATE('" & strYMD & "','YYYYMMDD'), -1),'YYYYMM') "
      SQL = SQL & "    AND GRADE = '" & strGrade & "' "
      SQL = SQL & " UNION ALL"
      SQL = SQL & " SELECT PO_ID, PO_TYPE, STYLE_CD, MAX(DEST) AS DEST, OBS_SEQ,"
      SQL = SQL & "     0 AS BSQTY, 0 AS BPQTY,"
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0)) "
      SQL = SQL & "   - SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0),0)) AS IBQTY, "
      SQL = SQL & "     SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0),0)) AS ITQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'IE',PRS_QTY,0)) AS IEQTY,"
      
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'G', PRS_QTY, 0)) AS OGQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'C', PRS_QTY, 0)) AS OCQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'OE',PRS_QTY,0)) AS OEQTY,"
      
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'S', PRS_QTY, 0)) - SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV,'S', PRS_QTY, 0),0)) AS SBQTY, "
      SQL = SQL & "     SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV,'S', PRS_QTY, 0),0)) AS STQTY, "
      SQL = SQL & "     MAX(REMARK) AS RMK "
      SQL = SQL & "   FROM MG_IO "
      SQL = SQL & "  WHERE YMD   >= '" & Mid(strYMD, 1, 6) & "01' AND YMD <= '" & strYMD & "' "
      SQL = SQL & "    AND GRADE = '" & strGrade & "' "
      SQL = SQL & "   GROUP BY PO_ID, PO_TYPE, STYLE_CD, OBS_SEQ "
      SQL = SQL & ") A, "
      SQL = SQL & " EM_OBS_HEAD B "
      SQL = SQL & " WHERE A.PO_ID      = B.PO_ID(+) "
      SQL = SQL & "   AND A.PO_TYPE    = B.PO_TYPE(+) "
      SQL = SQL & "   AND A.STYLE_CD   = B.STYLE_CD(+) "
      SQL = SQL & "   AND A.OBS_SEQ    = B.OBS_SEQ(+) "
      SQL = SQL & "   AND B.FACTORY(+) = '" & gFactory & "'"
      SQL = SQL & " GROUP BY A.PO_ID, A.PO_TYPE, A.STYLE_CD, A.OBS_SEQ "
      
      If chkShp.Value = 1 And strGrade = "A" Then
         SQL = SQL & " HAVING MAX(NVL(B.TOT_QTY,0)) > SUM(A.BPQTY + A.SBQTY + A.STQTY) "
      End If
      
      SQL = SQL & " ORDER BY 1, 3, 4, 5 "
   Else
      SQL = ""
      SQL = SQL & " SELECT A.PO_ID||A.PO_TYPE, "
      SQL = SQL & "     MAX(FN_MODEL2(A.STYLE_CD)), "
      SQL = SQL & "     SUBSTR(A.STYLE_CD,1,6)||'-'||SUBSTR(A.STYLE_CD,7,3), "
      SQL = SQL & "     MAX(A.DEST), "
      SQL = SQL & "     A.OBS_SEQ, "
      SQL = SQL & "     MAX(B.TOT_QTY), "
      SQL = SQL & "     MAX(A.RMK), "
      SQL = SQL & "     SUM(A.BSQTY)," 'BEFORE MONTH STOCK
      SQL = SQL & "     SUM(A.BPQTY)," 'BEFORE MONTH accumulative SHIP QTY
      SQL = SQL & "     SUM(A.IBQTY),"
      SQL = SQL & "     SUM(A.ITQTY),"
      SQL = SQL & "     SUM(A.IEQTY),"
      SQL = SQL & "     DECODE(MAX(B.TOT_QTY),0, 0, MAX(B.TOT_QTY) - SUM(A.BSQTY + A.BPQTY + A.IBQTY + A.ITQTY + A.IEQTY - A.OGQTY - A.OCQTY - A.OEQTY)),"
      SQL = SQL & "     SUM(A.OGQTY),"
      SQL = SQL & "     SUM(A.OCQTY),"
      SQL = SQL & "     SUM(A.OEQTY),"
      SQL = SQL & "     SUM(A.SBQTY),"
      SQL = SQL & "     SUM(A.STQTY),"
      SQL = SQL & "     DECODE(MAX(B.TOT_QTY),0, 0,MAX(B.TOT_QTY) - SUM(A.BPQTY + A.SBQTY + A.STQTY)),"
      SQL = SQL & "     SUM(A.BSQTY + (IBQTY + ITQTY + A.IEQTY) - (A.OGQTY + A.OCQTY + A.OEQTY) - (A.SBQTY + A.STQTY)) "
      SQL = SQL & "  FROM "
      SQL = SQL & "("
      SQL = SQL & " SELECT PO_ID, PO_TYPE, STYLE_CD, DEST, OBS_SEQ, "
      SQL = SQL & "     PRS_QTY AS BSQTY, out_prs_qty AS BPQTY, "
      SQL = SQL & "     0 AS IBQTY, 0 AS ITQTY, 0 AS IEQTY,"
      SQL = SQL & "     0 AS OGQTY, 0 AS OCQTY, 0 AS OEQTY,"
      SQL = SQL & "     0 AS SBQTY, 0 AS STQTY ,"
      SQL = SQL & "     '' AS RMK "
      SQL = SQL & "   FROM NM_GMONSTK_HEAD "
      SQL = SQL & "  WHERE YYMM       = TO_CHAR(ADD_MONTHS(TO_DATE('" & strYMD & "','YYYYMMDD'), -1),'YYYYMM') "
      SQL = SQL & "    AND PLANT_CD = '" & gFactory & "' "
      SQL = SQL & "    AND GRADE    = '" & strGrade & "' "
      SQL = SQL & " UNION ALL"
      SQL = SQL & " SELECT PO_ID, PO_TYPE, STYLE_CD, MAX(DEST) AS DEST, OBS_SEQ,"
      SQL = SQL & "     0 AS BSQTY, 0 AS BPQTY,"
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0)) "
      SQL = SQL & "   - SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0),0)) AS IBQTY, "
      SQL = SQL & "     SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0),0)) AS ITQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'IE',PRS_QTY,'IG',PRS_QTY,0)) AS IEQTY,"
      
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'Q', PRS_QTY, 0)) AS OGQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'F', PRS_QTY, 0)) AS OCQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'OE',PRS_QTY,'OG',PRS_QTY,0)) AS OEQTY,"
      
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'O', PRS_QTY, 0)) - SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV,'O', PRS_QTY, 0),0)) AS SBQTY, "
      SQL = SQL & "     SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV,'O', PRS_QTY, 0),0)) AS STQTY, "
      SQL = SQL & "     MAX(REMARK) AS RMK "
      SQL = SQL & "   FROM NM_GHEAD "
      SQL = SQL & "  WHERE YMD   >= '" & Mid(strYMD, 1, 6) & "01' AND YMD <= '" & strYMD & "' "
      SQL = SQL & "    AND PLANT_CD = '" & gFactory & "' "
      SQL = SQL & "    AND GRADE = '" & strGrade & "' "
      SQL = SQL & "   GROUP BY PO_ID, PO_TYPE, STYLE_CD, OBS_SEQ "
      SQL = SQL & ") A, "
      SQL = SQL & " EM_OBS_HEAD B "
      SQL = SQL & " WHERE A.PO_ID      = B.PO_ID(+) "
      SQL = SQL & "   AND A.PO_TYPE    = B.PO_TYPE(+) "
      SQL = SQL & "   AND A.STYLE_CD   = B.STYLE_CD(+) "
      SQL = SQL & "   AND A.OBS_SEQ    = B.OBS_SEQ(+) "
      SQL = SQL & "   AND B.FACTORY(+) = '" & gFactory & "'"
      SQL = SQL & " GROUP BY A.PO_ID, A.PO_TYPE, A.STYLE_CD, A.OBS_SEQ "
      
      If chkShp.Value = 1 And strGrade = "A" Then
         SQL = SQL & " HAVING MAX(NVL(B.TOT_QTY,0)) > SUM(A.BPQTY + A.SBQTY + A.STQTY) "
      End If
      
      SQL = SQL & " ORDER BY 1, 3, 4, 5 "
      
   End If
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If IsArray(arrDATA) Then
      
      vFixedCols = fspStock.FixedCols
      fspStock.FixedCols = 0
      fspStock.LoadArray arrDATA
      fspStock.FixedCols = vFixedCols
      fspStock.FrozenCols = 0
      
   Else
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   'For i = 3 To fspStock.Cols - 1 Step 1
   '   If UCase(Right(fspStock.TextMatrix(1, i), 3)) = "BAL" Then
   '      fspStock.Cell(flexcpBackColor, fspStock.FixedRows, i, fspStock.Rows - 1, i) = RGB(220, 220, 220)
   '   End If
   'Next i
      
   'fspStock.Cell(flexcpBackColor, fspLine.Rows - 1, 3, fspLine.Rows - 1, fspLine.Cols - 1) = vbYellow
   For i = 5 To fspStock.Cols - 1 Step 1
      If i = 6 Then
      Else
         fspStock.Subtotal flexSTSum, 0, i, "######", vbYellow
      End If
   Next i
   
   For i = 5 To fspStock.Cols - 1 Step 1
      If i = 6 Then
      Else
         fspStock.Subtotal flexSTSum, -1, i, "######", vbYellow
      End If
   Next i
   
   fspStock.Cell(flexcpAlignment, fspStock.FixedRows, 5, fspStock.Rows - 1, fspStock.Cols - 1) = 7
   
   'For i = fspStock.FixedRows To fspStock.Rows - 1 Step 1
   '   If Mid(fspStock.TextMatrix(i, 0), 1, 1) = "T" Or Mid(fspStock.TextMatrix(i, 0), 1, 1) = "G" Then
   '      fspStock.TextMatrix(i, 1) = fspStock.TextMatrix(i, 0)
   '      fspStock.TextMatrix(i, 0) = ""
   '   End If
   'Next
   
End Sub

Private Sub sbHeadStockDsp()
   Dim i As Integer
   
   fspStock.FontSize = 8
   fspStock.Clear
      
   fspStock.Rows = 3
   fspStock.Cols = 20
      
   fspStock.MergeCells = flexMergeFixedOnly
     
   fspStock.FixedCols = 5
   fspStock.FrozenCols = 0
   fspStock.FixedRows = 2
   
   fspStock.Cell(flexcpText, 0, 0, 1, 0) = "PO ID"
   fspStock.Cell(flexcpText, 0, 1, 1, 1) = "Model Name"
   fspStock.Cell(flexcpText, 0, 2, 1, 2) = "Style"
   fspStock.Cell(flexcpText, 0, 3, 1, 3) = "DEST"
   fspStock.Cell(flexcpText, 0, 4, 1, 4) = "SN"
   
   fspStock.Cell(flexcpText, 0, 5, 1, 5) = "Order"
   fspStock.Cell(flexcpText, 0, 6, 1, 6) = "Rmk"
   fspStock.Cell(flexcpText, 0, 7, 0, 8) = "Before Month"
   fspStock.Cell(flexcpText, 1, 7, 1, 7) = "Stock"
   fspStock.Cell(flexcpText, 1, 8, 1, 8) = "Ship"
   
   fspStock.Cell(flexcpText, 0, 9, 0, 12) = "Incoming"
   fspStock.Cell(flexcpText, 1, 9, 1, 9) = "Before"
   fspStock.Cell(flexcpText, 1, 10, 1, 10) = "Today"
   fspStock.Cell(flexcpText, 1, 11, 1, 11) = "Un-" & Chr(13) & "known"
   fspStock.Cell(flexcpText, 1, 12, 1, 12) = "Bal"
   
   fspStock.Cell(flexcpText, 0, 13, 0, 15) = "Outgoing"
   fspStock.Cell(flexcpText, 1, 13, 1, 13) = "Gift"
   fspStock.Cell(flexcpText, 1, 14, 1, 14) = "Scrap"
   fspStock.Cell(flexcpText, 1, 15, 1, 15) = "Un-" & Chr(13) & "known"
   
   fspStock.Cell(flexcpText, 0, 16, 0, 18) = "Shipped"
   fspStock.Cell(flexcpText, 1, 16, 1, 16) = "Before"
   fspStock.Cell(flexcpText, 1, 17, 1, 17) = "Today"
   fspStock.Cell(flexcpText, 1, 18, 1, 18) = "Bal"
   
   fspStock.Cell(flexcpText, 0, 19, 1, 19) = "Stock"
   
   fspStock.MergeCol(0) = True
   fspStock.MergeCol(1) = True
   fspStock.MergeCol(2) = True
   fspStock.MergeCol(3) = True
   fspStock.MergeCol(4) = True
   fspStock.MergeCol(5) = True
   fspStock.MergeCol(6) = True
   
   fspStock.MergeCol(19) = True
   
   fspStock.MergeRow(0) = True
   
   fspStock.ColWidth(0) = 800
   fspStock.ColWidth(1) = 1200
   fspStock.ColWidth(2) = 980
   fspStock.ColWidth(3) = 650
   fspStock.ColWidth(4) = 400
      
   fspStock.RowHeightMax = 420
   fspStock.RowHeightMin = 220
   fspStock.RowHeight(1) = 420
   
   fspStock.Cell(flexcpAlignment, 0, 0, 1, fspStock.Cols - 1) = 4
   
   For i = 5 To fspStock.Cols - 1 Step 1
      fspStock.ColWidth(i) = 550
   Next i
   
   fspStock.ColWidth(5) = 600
   fspStock.ColWidth(19) = 600
   
   
   fspStock.Rows = fspStock.FixedRows
   
End Sub

Private Sub Form_Unload(Cancel As Integer)
   Call frmMO01VJ.sbDspData(Format(frmMO01VJ.dtpYMD.Value, "YYYYMMDD"), "ALL")
   If frmMO01VJ.chkAutoScan.Value = 1 Then
      frmMO01VJ.tmrScan.Enabled = True
   End If
End Sub

Private Sub fspStock_Click()
'   Dim varArr As Variant
'   Dim Row As Long
'
'   Row = fspStock.Row
'   If Row = fspStock.Rows - 1 Then
'      Exit Sub
'   End If
'
'   ReDim varArr(1) As String
'
'   varArr(0) = fspStock.TextMatrix(Row, 0)                   'ASSY_LINE
'   varArr(1) = fspStock.TextMatrix(Row, 2)                   'STYLE_CD

   If fspStock.Row < fspStock.FixedRows Then
      Exit Sub
   End If
   If Mid(fspStock.TextMatrix(fspStock.Row, 1), 1, 1) = "T" Or Mid(fspStock.TextMatrix(fspStock.Row, 1), 1, 1) = "G" Or Mid(fspStock.TextMatrix(fspStock.Row, 1), 1, 1) = "" Then
      Exit Sub
   End If
   Call sbSizeDSP
End Sub

Private Sub sbSizeDSP()
   Dim SQL As String
   Dim arrDATA As Variant
   Dim i As Integer
   Dim j As Integer
   Dim q As Integer
   Dim vCol As Integer
   Dim vsum As Long
      
   Dim lngRTN As Long
   
   Dim varVAL As Variant
   
   Dim strYMD As String
   Dim strGrade As String
   Dim strPOID As String
   Dim strSTY As String
   Dim strSEQ As String
   
   'Dim buffer As String
   'Dim PCname As String
   'buffer = Space(32)
   'lngRTN = GetComputerName(buffer, 32)
   'PCname = fnRemoveNUL(buffer)
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   If Trim(fnCboValue(cboGrade)) = "" Then
      Exit Sub
   End If
   strGrade = fnCboValue(cboGrade)
   If strGrade = "" Then
      Exit Sub
   End If
   
   strPOID = fspStock.TextMatrix(fspStock.Row, 0)
   strSTY = Replace(fspStock.TextMatrix(fspStock.Row, 2), "-", "")
   strSEQ = fspStock.TextMatrix(fspStock.Row, 4)
   
   'Call sbHeadSizeDSP(Mid(fspStock.TextMatrix(fspStock.Row, 1), 1, 2))
   Call sbHeadSizeDSP2(Mid(fspStock.TextMatrix(fspStock.Row, 1), 1, 2))
   
   If strYMD < "20041101" Then
   
      SQL = ""
      
      If strGrade = "A" Then
         SQL = SQL & " SELECT B.CS_SIZE,"
      Else
         SQL = SQL & " SELECT A.CS_SIZE,"
      End If
      
      SQL = SQL & "     MAX(B.ORD_QTY), "
      SQL = SQL & "     SUM(A.BSQTY)," 'BEFORE MONTH STOCK
      SQL = SQL & "     SUM(A.BPQTY)," 'BEFORE MONTH accumulative SHIP QTY
      SQL = SQL & "     SUM(A.IBQTY),"
      SQL = SQL & "     SUM(A.ITQTY),"
      SQL = SQL & "     SUM(A.IEQTY),"
      SQL = SQL & "     DECODE(MAX(B.ORD_QTY),0, 0, MAX(B.ORD_QTY) - SUM(A.BSQTY + A.BPQTY + A.IBQTY + A.ITQTY + A.IEQTY - A.OGQTY - A.OCQTY - A.OEQTY)),"
      SQL = SQL & "     SUM(A.OGQTY),"
      SQL = SQL & "     SUM(A.OCQTY),"
      SQL = SQL & "     SUM(A.OEQTY),"
      SQL = SQL & "     SUM(A.SBQTY),"
      SQL = SQL & "     SUM(A.STQTY),"
      SQL = SQL & "     DECODE(MAX(B.ORD_QTY),0, 0, MAX(B.ORD_QTY) - SUM(A.BPQTY + A.SBQTY + A.STQTY)),"
      SQL = SQL & "     SUM(A.BSQTY + (IBQTY + ITQTY + A.IEQTY) - (A.OGQTY + A.OCQTY + A.OEQTY) - (A.SBQTY + A.STQTY)) "
      SQL = SQL & "  FROM "
      SQL = SQL & "("
      SQL = SQL & " SELECT CS_SIZE,"
      SQL = SQL & "     SUM(PRS_QTY) AS BSQTY, SUM(SHP_QTY) AS BPQTY,"
      SQL = SQL & "     0 AS IBQTY, 0 AS ITQTY, 0 AS IEQTY,"
      SQL = SQL & "     0 AS OGQTY, 0 AS OCQTY, 0 AS OEQTY,"
      SQL = SQL & "     0 AS SBQTY, 0 AS STQTY "
      SQL = SQL & "   FROM MG_MONSTK "
      SQL = SQL & "  WHERE YM       = TO_CHAR(ADD_MONTHS(TO_DATE('" & strYMD & "','YYYYMMDD'), -1),'YYYYMM') "
      SQL = SQL & "    AND GRADE    = '" & strGrade & "' "
      SQL = SQL & "    AND PO_ID    = '" & Mid(strPOID, 1, 6) & "' "
      SQL = SQL & "    AND PO_TYPE  = '" & Mid(strPOID, 7, 2) & "' "
      SQL = SQL & "    AND STYLE_CD = '" & strSTY & "' "
      SQL = SQL & "    AND OBS_SEQ  = " & strSEQ & " "
      SQL = SQL & "   GROUP BY CS_SIZE "
      SQL = SQL & " UNION ALL"
      SQL = SQL & " SELECT CS_SIZE,"
      SQL = SQL & "     0 AS BSQTY, 0 AS BPQTY,"
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0)) "
      SQL = SQL & "   - SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0),0)) AS IBQTY, "
      SQL = SQL & "     SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0),0)) AS ITQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'IE',PRS_QTY,0)) AS IEQTY,"
      
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'G', PRS_QTY, 0)) AS OGQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'C', PRS_QTY, 0)) AS OCQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'OE',PRS_QTY,0)) AS OEQTY,"
   
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'S', PRS_QTY, 0)) - SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV,'S', PRS_QTY, 0),0)) AS SBQTY, "
      SQL = SQL & "     SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV,'S', PRS_QTY, 0),0)) AS STQTY "
      SQL = SQL & "   FROM MG_IO "
      SQL = SQL & "  WHERE YMD   >= '" & Mid(strYMD, 1, 6) & "01' AND YMD <= '" & strYMD & "' "
      SQL = SQL & "    AND GRADE = '" & strGrade & "' "
      SQL = SQL & "    AND PO_ID    = '" & Mid(strPOID, 1, 6) & "' "
      SQL = SQL & "    AND PO_TYPE  = '" & Mid(strPOID, 7, 2) & "' "
      SQL = SQL & "    AND STYLE_CD = '" & strSTY & "' "
      SQL = SQL & "    AND OBS_SEQ  = " & strSEQ & " "
      SQL = SQL & "  GROUP BY CS_SIZE "
      SQL = SQL & ") A, "
      SQL = SQL & " EM_OBS_TAIL B "
   
      If strGrade = "A" Then
         SQL = SQL & " WHERE A.CS_SIZE(+) = B.CS_SIZE "
         SQL = SQL & "   and B.PO_ID      = '" & Mid(strPOID, 1, 6) & "' "
         SQL = SQL & "   AND B.PO_TYPE    = '" & Mid(strPOID, 7, 2) & "' "
         SQL = SQL & "   AND B.FACTORY    = '" & gFactory & "'"
         SQL = SQL & "   AND B.STYLE_CD   = '" & strSTY & "' "
         SQL = SQL & "   AND B.OBS_SEQ    = " & strSEQ & " "
         SQL = SQL & " GROUP BY B.CS_SIZE "
      Else
         SQL = SQL & " WHERE A.CS_SIZE       = B.CS_SIZE(+) "
         SQL = SQL & "   and B.PO_ID(+)      = '" & Mid(strPOID, 1, 6) & "' "
         SQL = SQL & "   AND B.PO_TYPE(+)    = '" & Mid(strPOID, 7, 2) & "' "
         SQL = SQL & "   AND B.FACTORY(+)    = '" & gFactory & "'"
         SQL = SQL & "   AND B.STYLE_CD(+)   = '" & strSTY & "' "
         SQL = SQL & "   AND B.OBS_SEQ(+)    = " & strSEQ & " "
         SQL = SQL & " GROUP BY A.CS_SIZE "
      End If
      SQL = SQL & " ORDER BY 1 "
   Else
      SQL = ""
      
      If strGrade = "A" Then
         SQL = SQL & " SELECT B.CS_SIZE,"
      Else
         SQL = SQL & " SELECT A.CS_SIZE,"
      End If
      
      SQL = SQL & "     MAX(B.ORD_QTY), "
      SQL = SQL & "     SUM(A.BSQTY)," 'BEFORE MONTH STOCK
      SQL = SQL & "     SUM(A.BPQTY)," 'BEFORE MONTH accumulative SHIP QTY
      SQL = SQL & "     SUM(A.IBQTY),"
      SQL = SQL & "     SUM(A.ITQTY),"
      SQL = SQL & "     SUM(A.IEQTY),"
      SQL = SQL & "     DECODE(MAX(B.ORD_QTY),0, 0, MAX(B.ORD_QTY) - SUM(A.BSQTY + A.BPQTY + A.IBQTY + A.ITQTY + A.IEQTY - A.OGQTY - A.OCQTY - A.OEQTY)),"
      SQL = SQL & "     SUM(A.OGQTY),"
      SQL = SQL & "     SUM(A.OCQTY),"
      SQL = SQL & "     SUM(A.OEQTY),"
      SQL = SQL & "     SUM(A.SBQTY),"
      SQL = SQL & "     SUM(A.STQTY),"
      SQL = SQL & "     DECODE(MAX(B.ORD_QTY),0, 0, MAX(B.ORD_QTY) - SUM(A.BPQTY + A.SBQTY + A.STQTY)),"
      SQL = SQL & "     SUM(A.BSQTY + (IBQTY + ITQTY + A.IEQTY) - (A.OGQTY + A.OCQTY + A.OEQTY) - (A.SBQTY + A.STQTY)) "
      SQL = SQL & "  FROM "
      SQL = SQL & "("
      SQL = SQL & " SELECT CS_SIZE,"
      SQL = SQL & "     SUM(PRS_QTY) AS BSQTY, SUM(out_prs_qty) AS BPQTY,"
      SQL = SQL & "     0 AS IBQTY, 0 AS ITQTY, 0 AS IEQTY,"
      SQL = SQL & "     0 AS OGQTY, 0 AS OCQTY, 0 AS OEQTY,"
      SQL = SQL & "     0 AS SBQTY, 0 AS STQTY "
      SQL = SQL & "   FROM NM_GMONSTK_TAIL "
      SQL = SQL & "  WHERE YYMM       = TO_CHAR(ADD_MONTHS(TO_DATE('" & strYMD & "','YYYYMMDD'), -1),'YYYYMM') "
      SQL = SQL & "    AND PLANT_CD = '" & gFactory & "' "
      SQL = SQL & "    AND GRADE    = '" & strGrade & "' "
      SQL = SQL & "    AND PO_ID    = '" & Mid(strPOID, 1, 6) & "' "
      SQL = SQL & "    AND PO_TYPE  = '" & Mid(strPOID, 7, 2) & "' "
      SQL = SQL & "    AND STYLE_CD = '" & strSTY & "' "
      SQL = SQL & "    AND OBS_SEQ  = " & strSEQ & " "
      SQL = SQL & "   GROUP BY CS_SIZE "
      SQL = SQL & " UNION ALL"
      SQL = SQL & " SELECT CS_SIZE,"
      SQL = SQL & "     0 AS BSQTY, 0 AS BPQTY,"
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0)) "
      SQL = SQL & "   - SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0),0)) AS IBQTY, "
      SQL = SQL & "     SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV||WORK_DIV,'IA', PRS_QTY,'IM', PRS_QTY, 0),0)) AS ITQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'IE',PRS_QTY,'IG',PRS_QTY,0)) AS IEQTY,"
      
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'Q', PRS_QTY, 0)) AS OGQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'F', PRS_QTY, 0)) AS OCQTY, "
      SQL = SQL & "     SUM(DECODE(INOUT_DIV||WORK_DIV,'OE',PRS_QTY,'OG',PRS_QTY,0)) AS OEQTY,"
   
      SQL = SQL & "     SUM(DECODE(INOUT_DIV,'O', PRS_QTY, 0)) - SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV,'O', PRS_QTY, 0),0)) AS SBQTY, "
      SQL = SQL & "     SUM(DECODE(YMD, '" & strYMD & "', DECODE(INOUT_DIV,'O', PRS_QTY, 0),0)) AS STQTY "
      SQL = SQL & "   FROM NM_GTAIL "
      SQL = SQL & "  WHERE YMD   >= '" & Mid(strYMD, 1, 6) & "01' AND YMD <= '" & strYMD & "' "
      SQL = SQL & "    AND PLANT_CD = '" & gFactory & "' "
      SQL = SQL & "    AND GRADE = '" & strGrade & "' "
      SQL = SQL & "    AND PO_ID    = '" & Mid(strPOID, 1, 6) & "' "
      SQL = SQL & "    AND PO_TYPE  = '" & Mid(strPOID, 7, 2) & "' "
      SQL = SQL & "    AND STYLE_CD = '" & strSTY & "' "
      SQL = SQL & "    AND OBS_SEQ  = " & strSEQ & " "
      SQL = SQL & "  GROUP BY CS_SIZE "
      SQL = SQL & ") A, "
      SQL = SQL & " EM_OBS_TAIL B "
   
      If strGrade = "A" Then
         SQL = SQL & " WHERE A.CS_SIZE(+) = B.CS_SIZE "
         SQL = SQL & "   and B.PO_ID      = '" & Mid(strPOID, 1, 6) & "' "
         SQL = SQL & "   AND B.PO_TYPE    = '" & Mid(strPOID, 7, 2) & "' "
         SQL = SQL & "   AND B.FACTORY    = '" & gFactory & "'"
         SQL = SQL & "   AND B.STYLE_CD   = '" & strSTY & "' "
         SQL = SQL & "   AND B.OBS_SEQ    = " & strSEQ & " "
         SQL = SQL & " GROUP BY B.CS_SIZE "
      Else
         SQL = SQL & " WHERE A.CS_SIZE       = B.CS_SIZE(+) "
         SQL = SQL & "   and B.PO_ID(+)      = '" & Mid(strPOID, 1, 6) & "' "
         SQL = SQL & "   AND B.PO_TYPE(+)    = '" & Mid(strPOID, 7, 2) & "' "
         SQL = SQL & "   AND B.FACTORY(+)    = '" & gFactory & "'"
         SQL = SQL & "   AND B.STYLE_CD(+)   = '" & strSTY & "' "
         SQL = SQL & "   AND B.OBS_SEQ(+)    = " & strSEQ & " "
         SQL = SQL & " GROUP BY A.CS_SIZE "
      End If
      SQL = SQL & " ORDER BY 1 "
   End If
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   
   If Not IsArray(arrDATA) Then
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find data by size! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   'fspSIZE2.Rows = 2
   'For i = 1 To fspSIZE2.Rows - 1 Step 1
   '   For j = 1 To fspSIZE2.Cols - 1 Step 1
   '      fspSIZE2.TextMatrix(i, j) = ""
   '   Next j
   'Next i
   
   For i = 0 To UBound(arrDATA, 2) Step 1
      vCol = 99
      For j = 1 To fspSIZE2.Cols - 1 Step 1
         If CStr(arrDATA(0, i)) = fspSIZE2.TextMatrix(0, j) Then
            vCol = j
            Exit For
         End If
      Next j
      If vCol = 99 Then
         For j = 1 To fspSIZE2.Cols - 1 Step 1
            If UCase(fspSIZE2.TextMatrix(0, j)) = "X" Then
               vCol = j
               Exit For
            End If
         Next j
         If vCol = 99 Then
            fspSIZE2.Cols = fspSIZE2.Cols + 1
            fspSIZE2.ColWidth(fspSIZE2.Cols - 1) = vWidth
            fspSIZE2.TextMatrix(0, fspSIZE2.Cols - 1) = arrDATA(0, i)
            vCol = fspSIZE2.Cols - 1
         End If
      End If
      For q = 1 To UBound(arrDATA, 1) Step 1
         fspSIZE2.TextMatrix(fspSIZE2.FixedRows + q - 1, vCol) = fnNVZ(arrDATA(q, i))
         
      Next q
   Next i
   
   'Total
   fspSIZE2.Cols = fspSIZE2.Cols + 1
   fspSIZE2.ColWidth(fspSIZE2.Cols - 1) = vWidth + 100
   fspSIZE2.TextMatrix(0, fspSIZE2.Cols - 1) = "Total"
   For i = 1 To fspSIZE2.Rows - 1 Step 1
      vsum = 0
      For j = 1 To fspSIZE2.Cols - 2 Step 1
         vsum = vsum + CLng(fnNVZ(fspSIZE2.TextMatrix(i, j)))
      Next j
      fspSIZE2.TextMatrix(i, fspSIZE2.Cols - 1) = vsum
      If UCase(fspSIZE2.TextMatrix(i, 0)) = "In.Bal" Or UCase(fspSIZE2.TextMatrix(i, 0)) = "Shp.Bal" _
         Or UCase(fspSIZE2.TextMatrix(i, 0)) = "Stock" Then
      
         fspSIZE2.Cell(flexcpBackColor, i, 0, i, fspSIZE2.Cols - 1) = RGB(220, 220, 220)
      End If
   Next i
   
   fspSIZE2.Cell(flexcpBackColor, 1, fspSIZE2.Cols - 1, fspSIZE2.Rows - 1, fspSIZE2.Cols - 1) = vbYellow
   fspSIZE2.Cell(flexcpAlignment, 0, 1, fspSIZE2.Rows - 1, fspSIZE2.Cols - 1) = 4
   
End Sub


Private Sub sbHeadSizeDSP(arg_Gen As String)
   Dim vsize_arr As Variant
   Dim vSIZE_COL As Integer
   Dim i As Single
   Dim j As Integer
   Dim k As Integer

On Error GoTo ErrGo
   
   vSIZE_COL = 1
   
   fspSIZE2.Clear
   fspSIZE2.FontSize = 8
   fspSIZE2.Rows = 15
   fspSIZE2.Cols = vSIZE_COL + vSIZE_COUNT
   fspSIZE2.TextMatrix(0, 0) = "Div"
   fspSIZE2.ColWidth(0) = 1000
   fspSIZE2.Cell(flexcpAlignment, fspSIZE2.FixedRows, vSIZE_COL, fspSIZE2.Rows - 1, fspSIZE2.Cols - 1) = 7
   
   fspSIZE2.TextMatrix(1, 0) = "Order"
   fspSIZE2.TextMatrix(2, 0) = "BM.Stock"
   fspSIZE2.TextMatrix(3, 0) = "BM.Ship"
   fspSIZE2.TextMatrix(4, 0) = "In.Before"
   fspSIZE2.TextMatrix(5, 0) = "In.Today"
   fspSIZE2.TextMatrix(6, 0) = "In.Unknown"
   fspSIZE2.TextMatrix(7, 0) = "In.Bal"
   
   fspSIZE2.TextMatrix(8, 0) = "Out.Gift"
   fspSIZE2.TextMatrix(9, 0) = "Out.Scrap"
   fspSIZE2.TextMatrix(10, 0) = "Out.unknown"
   
   fspSIZE2.TextMatrix(11, 0) = "Shp.Before"
   fspSIZE2.TextMatrix(12, 0) = "Shp.Today"
   fspSIZE2.TextMatrix(13, 0) = "Shp.Bal"
   fspSIZE2.TextMatrix(14, 0) = "Stock"
   
   fspSIZE2.FrozenCols = 1
   ReDim vsize_arr(vSIZE_COUNT - 1)
      
   For k = 0 To vSIZE_COUNT - 1 Step 1
       vsize_arr(k) = "x"
   Next k
   
   Select Case arg_Gen
   Case "ME"
      'M Size Map
      k = 0
      For i = 3.5 To 14.5 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
      
      For i = 15 To 18 Step 1
         vsize_arr(k) = CStr(i)
         k = k + 1
      Next
   Case "WO"
      'W Size Map
      k = 0
      For i = 2 To 15 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
   Case Else
      'G Size Map
      k = 0
      For i = 8 To 13.5 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
   
      For i = 1 To 7 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
   End Select
      
      
   
   For j = 0 To vSIZE_COUNT - 1 Step 1
      fspSIZE2.TextMatrix(0, j + vSIZE_COL) = vsize_arr(j)
   Next
   
   For i = vSIZE_COL To fspSIZE2.Cols - 1 Step 1
      fspSIZE2.ColWidth(i) = vWidth
   Next i
   fspSIZE2.Cell(flexcpAlignment, 0, vSIZE_COL, fspSIZE2.Rows - 1, fspSIZE2.Cols - 1) = 4
   
   Exit Sub
ErrGo:
   Call sbMsgDsp("Size Run Head Error!", gMsgDspSec)
   
End Sub


Private Sub sbHeadSizeDSP2(arg_Gen As String)
   Dim vsize_arr As Variant
   Dim vSIZE_COL As Integer
   Dim i As Single
   Dim j As Integer
   Dim k As Integer

'On Error GoTo ErrGo
   
   vSIZE_COL = 1
   
   fspSIZE2.Clear
   fspSIZE2.FontSize = 8
   fspSIZE2.Rows = 15
   fspSIZE2.Cols = vSIZE_COL + vSIZE_COUNT
   fspSIZE2.TextMatrix(0, 0) = "Div"
   fspSIZE2.ColWidth(0) = 1000
   fspSIZE2.Cell(flexcpAlignment, fspSIZE2.FixedRows, vSIZE_COL, fspSIZE2.Rows - 1, fspSIZE2.Cols - 1) = 7
   
   fspSIZE2.TextMatrix(1, 0) = "Order"
   fspSIZE2.TextMatrix(2, 0) = "BM.Stock"
   fspSIZE2.TextMatrix(3, 0) = "BM.Ship"
   fspSIZE2.TextMatrix(4, 0) = "In.Before"
   fspSIZE2.TextMatrix(5, 0) = "In.Today"
   fspSIZE2.TextMatrix(6, 0) = "In.Unknown"
   fspSIZE2.TextMatrix(7, 0) = "In.Bal"
   
   fspSIZE2.TextMatrix(8, 0) = "Out.Gift"
   fspSIZE2.TextMatrix(9, 0) = "Out.Scrap"
   fspSIZE2.TextMatrix(10, 0) = "Out.unknown"
   
   fspSIZE2.TextMatrix(11, 0) = "Shp.Before"
   fspSIZE2.TextMatrix(12, 0) = "Shp.Today"
   fspSIZE2.TextMatrix(13, 0) = "Shp.Bal"
   fspSIZE2.TextMatrix(14, 0) = "Stock"
   
   fspSIZE2.FrozenCols = 1
   ReDim vsize_arr(vSIZE_COUNT - 1)
      
   For k = 0 To vSIZE_COUNT - 1 Step 1
       vsize_arr(k) = "x"
   Next k
   
   Select Case arg_Gen
   Case "ME"
      'M Size Map
      k = 0
      For i = 3.5 To 14.5 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
      
      For i = 15 To 18 Step 1
         vsize_arr(k) = CStr(i)
         k = k + 1
      Next
   Case "WO"
      'W Size Map
      k = 0
      For i = 2 To 15 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
   Case Else
      'G Size Map
      k = 0
      For i = 8 To 13.5 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
   
      For i = 1 To 7 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
   End Select
      
   Dim SQL As String
   Dim vardata As Variant
   Dim arrSZ As Variant
   Dim strPOID As String
   
   strPOID = fspStock.TextMatrix(fspStock.Row, 0)
   
   SQL = ""
   SQL = SQL & "SELECT CS_SIZE FROM EM_OBS_TAIL "
   SQL = SQL & " WHERE PO_ID     = '" & Mid(strPOID, 1, 6) & "' "
   SQL = SQL & "   AND PO_TYPE   = '" & Mid(strPOID, 7, 2) & "' "
   SQL = SQL & "   AND FACTORY   = '" & gFactory & "' "
   SQL = SQL & "   AND STYLE_CD  = '" & Replace(fspStock.TextMatrix(fspStock.Row, 2), "-", "") & "' "
   SQL = SQL & "   AND OBS_SEQ   = " & fspStock.TextMatrix(fspStock.Row, 4) & " "
   
   Screen.MousePointer = 11
   vardata = fnGetOraData(SQL)
   Screen.MousePointer = 1
   
   
   If IsArray(vardata) Then
      ReDim arrSZ(UBound(vardata, 2)) As String
      j = 0
      
      For i = 0 To UBound(vsize_arr)
         For k = 0 To UBound(vardata, 2)
            If CStr(vsize_arr(i)) = CStr(vardata(0, k)) Then
               arrSZ(j) = CStr(vsize_arr(i))
               j = j + 1
               Exit For
            End If
         Next k
      Next i
      
      fspSIZE2.Cols = vSIZE_COL + UBound(vardata, 2) + 1
      For j = 0 To UBound(arrSZ) Step 1
         fspSIZE2.TextMatrix(0, j + vSIZE_COL) = CStr(arrSZ(j))
      Next
      
   Else
      If vardata = "" Then
         Call sbMsgDsp("Can not find data by size! ", gMsgDspSec)
      Else
         Call sbMsgDsp(vardata, gMsgDspSec)
      End If
      
      For j = 0 To vSIZE_COUNT - 1 Step 1
         fspSIZE2.TextMatrix(0, j + vSIZE_COL) = vsize_arr(j)
      Next
      
   End If
     
   For i = vSIZE_COL To fspSIZE2.Cols - 1 Step 1
      fspSIZE2.ColWidth(i) = vWidth
   Next i
   fspSIZE2.Cell(flexcpAlignment, 0, vSIZE_COL, fspSIZE2.Rows - 1, fspSIZE2.Cols - 1) = 4
   
   Exit Sub
'ErrGo:
'   Call sbMsgDsp("Size Run Head Error!", gMsgDspSec)
   
End Sub


Private Sub fspStock_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
   Dim i As Integer
   Dim L As Integer
   
   If Button = 2 Then
      'L = 0
      'For i = 0 To fspStock.Cols - 1
      '  L = L + fspStock.ColWidth(i)
      '  IF X
      L = fspStock.MouseCol
      If MsgBox("Would you hide this column ?", vbYesNo) = vbYes Then
         fspStock.ColHidden(L) = True
      End If
      
   End If
End Sub

Private Sub Label1_DblClick()
   If cmdPrint.Enabled Then
      'cndSave.DefaultExt = "*.txt"
      
      cndSave.ShowSave
      If cndSave.FileName = "" Then
      Else
         On Error GoTo err_rtn
         fspStock.SaveGrid cndSave.FileName, flexFileTabText, True
      End If
   End If
   Exit Sub
err_rtn:
   Call sbMsgDsp("Can not file open!", gMsgDspSec)
End Sub

Private Sub SSCommand1_Click()
   Unload frmMO15VJ
End Sub


Private Sub sbMsgDsp(arg_TXT As Variant, arg_ITVL As Integer)
   tmr1.Enabled = False
   sbrStatus.Panels.Item(1).Text = ""
   sbrStatus.Panels.Item(1).Text = arg_TXT
   tmr1.Interval = arg_ITVL * 1000
   tmr1.Enabled = True
End Sub

Private Sub SSCommand2_Click()
   Dim i As Integer
   
   For i = 0 To fspStock.Cols - 1
      
      fspStock.ColHidden(fspStock.MouseCol) = False
      
   Next
End Sub

Private Sub tmr1_Timer()
   sbrStatus.Panels.Item(1).Text = ""
   tmr1.Enabled = False
End Sub
