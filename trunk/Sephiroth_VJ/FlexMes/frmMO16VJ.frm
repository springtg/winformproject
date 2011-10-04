VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO16VJ 
   Caption         =   "MES-MO16VJ"
   ClientHeight    =   8295
   ClientLeft      =   1410
   ClientTop       =   2010
   ClientWidth     =   11940
   BeginProperty Font 
      Name            =   "Arial Narrow"
      Size            =   9
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   8295
   ScaleWidth      =   11940
   Begin VB.CheckBox chkin 
      Caption         =   "INSIDE"
      Height          =   240
      Left            =   2790
      TabIndex        =   14
      Top             =   795
      Width           =   885
   End
   Begin VB.ComboBox cboComp 
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   10500
      Style           =   2  '드롭다운 목록
      TabIndex        =   10
      Top             =   735
      Width           =   1350
   End
   Begin VB.ComboBox cboProc 
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   5280
      Style           =   2  '드롭다운 목록
      TabIndex        =   8
      Top             =   720
      Width           =   2730
   End
   Begin MSComCtl2.DTPicker dtpYMD 
      Height          =   345
      Left            =   780
      TabIndex        =   5
      Top             =   735
      Width           =   1800
      _ExtentX        =   3175
      _ExtentY        =   609
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
      CurrentDate     =   37996
   End
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   11505
      Top             =   7695
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
         TabIndex        =   11
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
         Left            =   7545
         TabIndex        =   12
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
         Caption         =   "Checking Passcard"
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
         Caption         =   "Checking Passcard"
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
         Picture         =   "frmMO16VJ.frx":0000
         Top             =   30
         Width           =   4950
      End
   End
   Begin MSComctlLib.StatusBar sbrStatus 
      Align           =   2  '아래 맞춤
      Height          =   360
      Left            =   0
      TabIndex        =   4
      Top             =   7935
      Width           =   11940
      _ExtentX        =   21061
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
      Left            =   1185
      Top             =   300
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DefaultExt      =   "text (*.txt)"
   End
   Begin VSFlex7LCtl.VSFlexGrid fspView 
      Height          =   6615
      Left            =   90
      TabIndex        =   13
      Top             =   1170
      Width           =   11790
      _cx             =   20796
      _cy             =   11668
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
      AllowUserResizing=   0
      SelectionMode   =   1
      GridLines       =   1
      GridLinesFixed  =   2
      GridLineWidth   =   1
      Rows            =   50
      Cols            =   10
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
      ExplorerBar     =   5
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
   Begin VB.Label Label1 
      BackStyle       =   0  '투명
      Caption         =   "Comp:"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   2
      Left            =   9825
      TabIndex        =   9
      Top             =   765
      Width           =   765
   End
   Begin VB.Label Label1 
      BackStyle       =   0  '투명
      Caption         =   "Incoming Of"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   1
      Left            =   3945
      TabIndex        =   7
      Top             =   765
      Width           =   1320
   End
   Begin VB.Label Label1 
      BackStyle       =   0  '투명
      Caption         =   "Date:"
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Index           =   0
      Left            =   150
      TabIndex        =   6
      Top             =   765
      Width           =   810
   End
End
Attribute VB_Name = "frmMO16VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim vWidth As Variant
Dim MAX_HH As Integer

Private Sub sbHeadDSP2()
   Dim i As Integer
   Dim j As Integer
   Dim Row As Integer
   Dim Col As Integer
   Dim startCol As Integer
   Dim strVal As String
   
   fspView.Clear
   fspView.Rows = 3
   fspView.FixedRows = 3
   fspView.Cols = 7
   
   fspView.Cell(flexcpText, 0, 0, 1, 0) = "Last Scan Passcard"
   fspView.Cell(flexcpText, 0, 1, 1, 1) = " PO / STYLE / SIZE "
   
   fspView.Cell(flexcpText, 0, 2, 0, 5) = "Scan time of Inside process"
   fspView.Cell(flexcpText, 1, 2, 1, 2) = "Outgoing"
   fspView.Cell(flexcpText, 1, 3, 1, 3) = "Producing"
   fspView.Cell(flexcpText, 1, 4, 1, 4) = "Input"
   fspView.Cell(flexcpText, 1, 5, 1, 5) = "Incoming"
   fspView.Cell(flexcpText, 0, 6, 1, 6) = "PCARD_ID"
   
   
   fspView.MergeCells = flexMergeFixedOnly
   
   fspView.Cell(flexcpAlignment, 0, 0, fspView.Rows - 1, fspView.Cols - 1) = 4
   
   fspView.ColWidth(0) = 1500
   fspView.ColWidth(1) = 2500
   For i = 2 To fspView.Cols - 2 Step 1
      fspView.ColWidth(i) = 1900
   Next
   fspView.ColWidth(i) = 0
   
   fspView.MergeRow(0) = True
   'fspView.MergeRow(3) = True
   fspView.MergeRow(1) = True
   
   fspView.MergeCol(0) = True
   fspView.MergeCol(1) = True
   
   fspView.RowHeight(0) = 300
   fspView.RowHeight(1) = 300
   
End Sub

Private Sub sbViewDsp2()
   Dim SQL As String
   Dim strYMD As String
   Dim strProc As String
   Dim strPart As String
   Dim arrDATA As Variant
   Dim RST_DIV As Variant
   Dim i As Long
   Dim TOT_CNT As Long
   Dim O_CNT As Long
   Dim P_CNT As Long
   Dim T_CNT As Long
   Dim I_CNT As Long
   
   
   Call sbHeadDSP2
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   strProc = fnCboValue(cboProc)
   If strProc = "" Then
      Exit Sub
   End If
   
   strPart = fnCboValue(cboComp)
   If strPart = "FS" Then
      strPart = "OS"
   ElseIf strPart = "FG" Then
      strPart = "UP"
   End If
   
   SQL = "      SELECT DECODE(o_scn_result_yn, 'Y', 'O', DECODE(p_scn_result_yn, 'Y', 'P', DECODE(t_scn_result_yn, 'Y', 'T', DECODE(i_scn_result_yn,'Y', 'I','*'))))   "
   SQL = SQL & "  FROM PB_OPCD WHERE OP_CD = '" & Mid(strProc, 1, 3) & "' "
   
   Screen.MousePointer = 11
   RST_DIV = fnGetOraData(SQL)
   Screen.MousePointer = 1
   
   If strProc = "FGA" Then
      RST_DIV(0, 0) = "T"
   End If
   
   
   SQL = ""
   SQL = SQL & " SELECT MAX(PCARD), MAX(PO||' / '||STY||' / '||SZ), MAX(O_SCN), MAX(P_SCN), MAX(T_SCN), MAX(I_SCN), P_ID "
   SQL = SQL & "   FROM ( "
   SQL = SQL & " SELECT A.RES_CD||DECODE(C.LEAD_TYPE,3,'-'||A.MINI_LINE,'')"
   SQL = SQL & "        ||'-'||TO_CHAR(TO_DATE(A.ASY_YMD,'YYYYMMDD'),'MON-DD')"
   SQL = SQL & "        ||'-'||A.ABC_ID"
   SQL = SQL & "        ||'H-'||LTRIM(TO_CHAR(A.PCARD_SEQ,'00')) AS PCARD, "
   SQL = SQL & "        A.PO_NO AS PO, A.STYLE_CD AS STY, A.CS_SIZE AS SZ, "
   SQL = SQL & "        SUBSTR(B.O_SCN_YMD,1,4)||'-'||SUBSTR(B.O_SCN_YMD,5,2)||'-'||SUBSTR(B.O_SCN_YMD,7,2)||' '||SUBSTR(B.O_SCN_HMS,1,2)||'-'||SUBSTR(B.O_SCN_HMS,3,2) AS O_SCN, "
   SQL = SQL & "        SUBSTR(B.P_SCN_YMD,1,4)||'-'||SUBSTR(B.P_SCN_YMD,5,2)||'-'||SUBSTR(B.P_SCN_YMD,7,2)||' '||SUBSTR(B.P_SCN_HMS,1,2)||'-'||SUBSTR(B.P_SCN_HMS,3,2) AS P_SCN, "
   SQL = SQL & "        SUBSTR(B.T_SCN_YMD,1,4)||'-'||SUBSTR(B.T_SCN_YMD,5,2)||'-'||SUBSTR(B.T_SCN_YMD,7,2)||' '||SUBSTR(B.T_SCN_HMS,1,2)||'-'||SUBSTR(B.T_SCN_HMS,3,2) AS T_SCN, "
   SQL = SQL & "        SUBSTR(B.I_SCN_YMD,1,4)||'-'||SUBSTR(B.I_SCN_YMD,5,2)||'-'||SUBSTR(B.I_SCN_YMD,7,2)||' '||SUBSTR(B.I_SCN_HMS,1,2)||'-'||SUBSTR(B.I_SCN_HMS,3,2) AS I_SCN, "
   SQL = SQL & "        B.PCARD_ID AS P_ID"
   SQL = SQL & "   FROM PS_PCARD_SEQ B, PS_PCARD A, NA_GEN_PARA C "
   SQL = SQL & "  WHERE B." & RST_DIV(0, 0) & "_SCN_YMD    = '" & strYMD & "' "
   SQL = SQL & "    AND B.OP_CD        = '" & strProc & "' "
   SQL = SQL & "    AND B.PCARD_ID     = A.PCARD_ID "
   SQL = SQL & "    AND A.SEMI_GOOD_CD = '" & strPart & "' "
   SQL = SQL & "    AND A.RES_CD       = C.PLANT_CD"
   
   If strProc = "PUS" Or strProc = "SPP" Then
   SQL = SQL & " UNION ALL "
   SQL = SQL & " SELECT A.RES_CD||DECODE(C.LEAD_TYPE,3,'-'||A.MINI_LINE,'')"
   SQL = SQL & "        ||'-'||TO_CHAR(TO_DATE(A.ASY_YMD,'YYYYMMDD'),'MON-DD')"
   SQL = SQL & "        ||'-'||A.ABC_ID"
   SQL = SQL & "        ||'H-'||LTRIM(TO_CHAR(A.PCARD_SEQ,'00')) AS PCARD, "
   SQL = SQL & "        A.PO_NO AS PO, A.STYLE_CD AS STY, A.CS_SIZE AS SZ, "
   SQL = SQL & "        '' AS O_SCN, "
   SQL = SQL & "        '' AS P_SCN, "
   SQL = SQL & "        SUBSTR(B.P_SCN_YMD,1,4)||'-'||SUBSTR(B.P_SCN_YMD,5,2)||'-'||SUBSTR(B.P_SCN_YMD,7,2)||' '||SUBSTR(B.P_SCN_HMS,1,2)||'-'||SUBSTR(B.P_SCN_HMS,3,2) AS T_SCN, "
   SQL = SQL & "        '' AS I_SCN, "
   SQL = SQL & "        B.PCARD_ID AS P_ID"
   SQL = SQL & "   FROM PS_PCARD_SEQ B, PS_PCARD A, NA_GEN_PARA C "
   SQL = SQL & "  WHERE B.PCARD_ID    IN ("
   SQL = SQL & "        SELECT PCARD_ID "
   SQL = SQL & "          FROM PS_PCARD_SEQ "
   SQL = SQL & "         WHERE P_SCN_YMD    = '" & strYMD & "' "
   SQL = SQL & "           AND OP_CD        = '" & strProc & "' "
   SQL = SQL & "                         )"
   SQL = SQL & "    AND B.OP_CD        = '" & Mid(strProc, 1, 2) & "A" & "' "
   SQL = SQL & "    AND B.PCARD_ID     = A.PCARD_ID "
   SQL = SQL & "    AND A.SEMI_GOOD_CD = '" & strPart & "' "
   SQL = SQL & "    AND A.RES_CD       = C.PLANT_CD"
   
   End If
   SQL = SQL & "        ) "
   SQL = SQL & "  GROUP BY P_ID "
   SQL = SQL & "  ORDER BY 1 "
   
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   
   If IsArray(arrDATA) Then
      fspView.LoadArray arrDATA
      TOT_CNT = UBound(arrDATA, 2) + 1
      O_CNT = 0
      P_CNT = 0
      T_CNT = 0
      I_CNT = 0
      For i = 2 To fspView.Rows - 1 Step 1
         If Len(fspView.TextMatrix(i, 2)) < 16 Then
         Else
            O_CNT = O_CNT + 1
         End If
         
         If Len(fspView.TextMatrix(i, 3)) < 16 Then
         Else
            P_CNT = P_CNT + 1
         End If
         
         If Len(fspView.TextMatrix(i, 4)) < 16 Then
         Else
            T_CNT = T_CNT + 1
         End If
         
         If Len(fspView.TextMatrix(i, 5)) < 16 Then
         Else
            I_CNT = I_CNT + 1
         End If
      Next
      
      fspView.TextMatrix(2, 0) = "SCAN RATE(%)"
      'fspView.Cell(flexcpText, 2, 0, 2, 1) = "SCAN RATE(%)"
      fspView.TextMatrix(2, 2) = CStr(Round(O_CNT / TOT_CNT * 100, 3))
      fspView.TextMatrix(2, 3) = CStr(Round(P_CNT / TOT_CNT * 100, 3))
      fspView.TextMatrix(2, 4) = CStr(Round(T_CNT / TOT_CNT * 100, 3))
      fspView.TextMatrix(2, 5) = CStr(Round(I_CNT / TOT_CNT * 100, 3))
      
      fspView.Cell(flexcpForeColor, 2, 2, 2, fspView.Cols - 1) = vbRed
      fspView.Cell(flexcpFontBold, 2, 2, 2, fspView.Cols - 1) = True
      fspView.Cell(flexcpAlignment, 2, 0, fspView.Rows - 1, fspView.Cols - 1) = 4
      
   Else
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find data!", 4)
      Else
         Call sbMsgDsp(arrDATA, 4)
      End If
      Exit Sub
   End If
   
   
End Sub


Private Sub sbHeadDSP()
   Dim i As Integer
   Dim j As Integer
   Dim Row As Integer
   Dim Col As Integer
   Dim startCol As Integer
   Dim strVal As String
   
   fspView.Clear
   fspView.Rows = 3
   fspView.FixedRows = 3
   fspView.Cols = 7
   
   fspView.Cell(flexcpText, 0, 0, 1, 0) = "Incom Passcard"
   fspView.Cell(flexcpText, 0, 1, 1, 1) = " PO / STYLE / SIZE "
   
   fspView.Cell(flexcpText, 0, 2, 0, 5) = "Scan time of previous process"
   fspView.Cell(flexcpText, 1, 2, 1, 2) = "Outgoing"
   fspView.Cell(flexcpText, 1, 3, 1, 3) = "Producing"
   fspView.Cell(flexcpText, 1, 4, 1, 4) = "Input"
   fspView.Cell(flexcpText, 1, 5, 1, 5) = "Incoming"
   fspView.Cell(flexcpText, 0, 6, 1, 6) = "PCARD_ID"
   
   
   fspView.MergeCells = flexMergeFixedOnly
   
   fspView.Cell(flexcpAlignment, 0, 0, fspView.Rows - 1, fspView.Cols - 1) = 4
   
   fspView.ColWidth(0) = 1500
   fspView.ColWidth(1) = 2500
   For i = 2 To fspView.Cols - 2 Step 1
      fspView.ColWidth(i) = 1900
   Next
   fspView.ColWidth(i) = 0
   
   fspView.MergeRow(0) = True
   'fspView.MergeRow(3) = True
   fspView.MergeRow(1) = True
   
   fspView.MergeCol(0) = True
   fspView.MergeCol(1) = True
   
   fspView.RowHeight(0) = 300
   fspView.RowHeight(1) = 300
   
End Sub

Private Sub sbViewDsp()
   Dim SQL As String
   Dim strYMD As String
   Dim strProc As String
   Dim strProc2 As String
   Dim strPart As String
   Dim arrDATA As Variant
   Dim i As Long
   Dim TOT_CNT As Long
   Dim O_CNT As Long
   Dim P_CNT As Long
   Dim T_CNT As Long
   Dim I_CNT As Long
   
   
   Call sbHeadDSP
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   strProc = fnCboValue(cboProc)
   If strProc = "" Then
      Exit Sub
   End If
   
   strPart = fnCboValue(cboComp)
   If strPart = "FS" Then
      strPart = "OS"
   ElseIf strPart = "FG" Then
      strPart = "UP"
   End If
   
   strProc2 = "('XXX')"
   If strProc = "FGA" Then
      If strPart = "OS" Then
         strProc2 = "('FSS')"
      Else
         strProc2 = "('UPS')"
      End If
   ElseIf strProc = "FSS" Then
      
      If strPart = "OS" Then
         strProc2 = "('OSP')"
      ElseIf strPart = "PH" Then
         strProc2 = "('PHP','PHI')"
      ElseIf strPart = "PU" Then
         strProc2 = "('PUS')"
      ElseIf strPart = "SP" Then
         strProc2 = "('SPP')"
      End If
      
   End If
   
   SQL = ""
   SQL = SQL & " SELECT MAX(PCARD), MAX(PO||' / '||STY||' / '||SZ), MAX(O_SCN), MAX(P_SCN), MAX(T_SCN), MAX(I_SCN), P_ID "
   SQL = SQL & "   FROM ( "
   SQL = SQL & " SELECT A.RES_CD||DECODE(C.LEAD_TYPE,3,'-'||A.MINI_LINE,'')"
   SQL = SQL & "        ||'-'||TO_CHAR(TO_DATE(A.ASY_YMD,'YYYYMMDD'),'MON-DD')"
   SQL = SQL & "        ||'-'||A.ABC_ID"
   SQL = SQL & "        ||'H-'||LTRIM(TO_CHAR(A.PCARD_SEQ,'00')) AS PCARD, "
   SQL = SQL & "        A.PO_NO AS PO, A.STYLE_CD AS STY, A.CS_SIZE AS SZ, "
   SQL = SQL & "        TO_CHAR(NULL) AS O_SCN, "
   SQL = SQL & "        TO_CHAR(NULL) AS P_SCN, "
   SQL = SQL & "        TO_CHAR(NULL) AS T_SCN, "
   SQL = SQL & "        TO_CHAR(NULL) AS I_SCN, "
   SQL = SQL & "        B.PCARD_ID AS P_ID"
   SQL = SQL & "   FROM PS_PCARD_SEQ B, PS_PCARD A, NA_GEN_PARA C "
   SQL = SQL & "  WHERE B.I_SCN_YMD    = '" & strYMD & "' "
   SQL = SQL & "    AND B.OP_CD        = '" & strProc & "' "
   SQL = SQL & "    AND B.PCARD_ID     = A.PCARD_ID "
   SQL = SQL & "    AND A.SEMI_GOOD_CD = '" & strPart & "' "
   SQL = SQL & "    AND A.RES_CD       = C.PLANT_CD"
   
   SQL = SQL & "  UNION ALL"
   SQL = SQL & " SELECT A.RES_CD||DECODE(C.LEAD_TYPE,3,'-'||A.MINI_LINE,'')"
   SQL = SQL & "        ||'-'||TO_CHAR(TO_DATE(A.ASY_YMD,'YYYYMMDD'),'MON-DD')"
   SQL = SQL & "        ||'-'||A.ABC_ID"
   SQL = SQL & "        ||'H-'||LTRIM(TO_CHAR(A.PCARD_SEQ,'00')) AS PCARD, "
   SQL = SQL & "        A.PO_NO AS PO, A.STYLE_CD AS STY, A.CS_SIZE AS SZ, "
   SQL = SQL & "        SUBSTR(B.O_SCN_YMD,1,4)||'-'||SUBSTR(B.O_SCN_YMD,5,2)||'-'||SUBSTR(B.O_SCN_YMD,7,2)||' '||SUBSTR(B.O_SCN_HMS,1,2)||'-'||SUBSTR(B.O_SCN_HMS,3,2) AS O_SCN, "
   SQL = SQL & "        SUBSTR(B.P_SCN_YMD,1,4)||'-'||SUBSTR(B.P_SCN_YMD,5,2)||'-'||SUBSTR(B.P_SCN_YMD,7,2)||' '||SUBSTR(B.P_SCN_HMS,1,2)||'-'||SUBSTR(B.P_SCN_HMS,3,2) AS P_SCN, "
   SQL = SQL & "        SUBSTR(B.T_SCN_YMD,1,4)||'-'||SUBSTR(B.T_SCN_YMD,5,2)||'-'||SUBSTR(B.T_SCN_YMD,7,2)||' '||SUBSTR(B.T_SCN_HMS,1,2)||'-'||SUBSTR(B.T_SCN_HMS,3,2) AS T_SCN, "
   SQL = SQL & "        SUBSTR(B.I_SCN_YMD,1,4)||'-'||SUBSTR(B.I_SCN_YMD,5,2)||'-'||SUBSTR(B.I_SCN_YMD,7,2)||' '||SUBSTR(B.I_SCN_HMS,1,2)||'-'||SUBSTR(B.I_SCN_HMS,3,2) AS I_SCN, "
   SQL = SQL & "        B.PCARD_ID AS P_ID"
   SQL = SQL & "   FROM PS_PCARD_SEQ B, PS_PCARD A, NA_GEN_PARA C "
   SQL = SQL & "  WHERE B.PCARD_ID     = A.PCARD_ID "
   SQL = SQL & "    AND B.PCARD_ID    IN ("
   SQL = SQL & "        SELECT PCARD_ID "
   SQL = SQL & "          FROM PS_PCARD_SEQ "
   SQL = SQL & "         WHERE I_SCN_YMD    = '" & strYMD & "' "
   SQL = SQL & "           AND OP_CD        = '" & strProc & "' "
   SQL = SQL & "                         )"
   SQL = SQL & "    AND B.OP_CD        IN " & strProc2
   SQL = SQL & "    AND A.SEMI_GOOD_CD = '" & strPart & "' "
   SQL = SQL & "    AND A.RES_CD       = C.PLANT_CD"
   SQL = SQL & "        ) "
   SQL = SQL & "  GROUP BY P_ID "
   SQL = SQL & "  ORDER BY 1 "
   
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   
   If IsArray(arrDATA) Then
      fspView.LoadArray arrDATA
      TOT_CNT = UBound(arrDATA, 2) + 1
      O_CNT = 0
      P_CNT = 0
      T_CNT = 0
      I_CNT = 0
      For i = 2 To fspView.Rows - 1 Step 1
         If Len(fspView.TextMatrix(i, 2)) < 16 Then
         Else
            O_CNT = O_CNT + 1
         End If
         
         If Len(fspView.TextMatrix(i, 3)) < 16 Then
         Else
            P_CNT = P_CNT + 1
         End If
         
         If Len(fspView.TextMatrix(i, 4)) < 16 Then
         Else
            T_CNT = T_CNT + 1
         End If
         
         If Len(fspView.TextMatrix(i, 5)) < 16 Then
         Else
            I_CNT = I_CNT + 1
         End If
      Next
      
      fspView.TextMatrix(2, 0) = "SCAN RATE(%)"
      'fspView.Cell(flexcpText, 2, 0, 2, 1) = "SCAN RATE(%)"
      fspView.TextMatrix(2, 2) = CStr(Round(O_CNT / TOT_CNT * 100, 3))
      fspView.TextMatrix(2, 3) = CStr(Round(P_CNT / TOT_CNT * 100, 3))
      fspView.TextMatrix(2, 4) = CStr(Round(T_CNT / TOT_CNT * 100, 3))
      fspView.TextMatrix(2, 5) = CStr(Round(I_CNT / TOT_CNT * 100, 3))
      
      fspView.Cell(flexcpForeColor, 2, 2, 2, fspView.Cols - 1) = vbRed
      fspView.Cell(flexcpFontBold, 2, 2, 2, fspView.Cols - 1) = True
      fspView.Cell(flexcpAlignment, 2, 0, fspView.Rows - 1, fspView.Cols - 1) = 4
      
   Else
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find data!", 4)
      Else
         Call sbMsgDsp(arrDATA, 4)
      End If
      Exit Sub
   End If
   
   
End Sub

Private Sub sbMsgDsp(arg_TXT As Variant, arg_ITVL As Integer)
   tmr1.Enabled = False
   sbrStatus.Panels.Item(1).Text = ""
   sbrStatus.Panels.Item(1).Text = arg_TXT
   tmr1.Interval = arg_ITVL * 1000
   tmr1.Enabled = True
End Sub

Private Sub sbSetCboComp(arg_OPCD As String)
   Dim SQL As String
   Dim strRtn As String
   
   SQL = ""
   SQL = SQL & "SELECT SEMI_GOOD_CD, MAX(FN_MM_CDNAME('PA01',SEMI_GOOD_CD)) "
   SQL = SQL & "  FROM MP_APPLY "
   SQL = SQL & " WHERE OP_CD LIKE '" & Mid(arg_OPCD, 1, 3) & "%' "
   SQL = SQL & "   AND RST_DIV = 'I' "
   SQL = SQL & " GROUP BY SEMI_GOOD_CD "
   SQL = SQL & " ORDER BY 1 "
   
   strRtn = fnSetCbo(cboComp, SQL)

End Sub

Private Sub sbSetCboComp2(arg_OPCD As String)
   Dim SQL As String
   Dim strRtn As String
   
   SQL = ""
   SQL = SQL & "SELECT SEMI_GOOD_CD, MAX(FN_MM_CDNAME('PA01',SEMI_GOOD_CD)) "
   SQL = SQL & "  FROM MP_APPLY "
   SQL = SQL & " WHERE OP_CD LIKE '" & Mid(arg_OPCD, 1, 3) & "%' "
   SQL = SQL & " GROUP BY SEMI_GOOD_CD "
   SQL = SQL & " ORDER BY 1 "
   
   strRtn = fnSetCbo(cboComp, SQL)

End Sub


Private Sub chkin_Click()
   Dim strRtn As String
   Dim SQL As String
   
   If chkin.Value = 1 Then
      
      'Getting Process
      SQL = " SELECT DCODE, CD_NAME FROM CM_CODE WHERE MCODE = 'MP07' AND DCODE <> '0000' ORDER BY DCODE "
      
   Else
      'Getting Process
      SQL = ""
      SQL = SQL & " SELECT 'FGA', 'Incoming of Assembly' FROM DUAL "
      SQL = SQL & " UNION ALL "
      SQL = SQL & " SELECT 'FSS', 'Incoming of Stockfit' FROM DUAL "

   End If
   strRtn = fnSetCbo(cboProc, SQL)
End Sub

Private Sub cmdPrint_Click()
   Dim vOldWidth As Variant
   Dim i As Long
   Dim j As Long
   Dim strProc As String
   Dim strPart As String
   Dim old_fixed_rows As Long
   Dim arrCHK As Variant
   Dim blnOK As Boolean
   
   ReDim arrCHK(3) As Integer
   
   old_fixed_rows = fspView.FixedRows
   
   If CDbl(fspView.TextMatrix(2, 2)) > 0 And CDbl(fspView.TextMatrix(2, 2)) < 100 Then
      arrCHK(0) = 2
   Else
      arrCHK(0) = 0
   End If
   
   If CDbl(fspView.TextMatrix(2, 3)) > 0 And CDbl(fspView.TextMatrix(2, 3)) < 100 Then
      arrCHK(1) = 3
   Else
      arrCHK(1) = 0
   End If
   
   If CDbl(fspView.TextMatrix(2, 4)) > 0 And CDbl(fspView.TextMatrix(2, 4)) < 100 Then
      arrCHK(2) = 4
   Else
      arrCHK(2) = 0
   End If
   
   If CDbl(fspView.TextMatrix(2, 5)) > 0 And CDbl(fspView.TextMatrix(2, 5)) < 100 Then
      arrCHK(3) = 5
   Else
      arrCHK(3) = 0
   End If
   
   If arrCHK(0) = 2 Or arrCHK(1) = 3 Or arrCHK(2) = 4 Or arrCHK(3) = 5 Then
      For i = fspView.Rows - 1 To old_fixed_rows Step -1
         blnOK = False
         For j = 0 To 3 Step 1
            If arrCHK(j) = 0 Then
            Else
               If Mid(fspView.TextMatrix(i, arrCHK(j)), 1, 1) = "-" Then
                  blnOK = False
                  Exit For
               Else
                  blnOK = True
               End If
            End If
         Next j
         
         If blnOK Then
            fspView.RemoveItem i
         End If
      Next i
   Else
     MsgBox "Not fund miss scan list!"
     Exit Sub
   End If
   
   strProc = fnCboValue(cboProc)
   If strProc = "" Then
      Exit Sub
   End If
   
   strPart = fnCboValue(cboComp)
         
   ReDim vOldWidth(fspView.Cols - 1) As Integer
   For i = 0 To UBound(vOldWidth) Step 1
      vOldWidth(i) = fspView.ColWidth(i)
   Next i
      
   fspView.AddItem "" & vbTab & "", 0
   
   fspView.Cell(flexcpText, 0, 0, 0, 1) = lbTitle(0).Caption
   fspView.Cell(flexcpFontSize, 0, 0, 0, 1) = 12
   fspView.Cell(flexcpFontBold, 0, 0, 0, 1) = True
   'fspView.Cell(flexcpFontUnderline, 0, 0, 0, 2) = True
   fspView.Cell(flexcpText, 0, 2, 0, fspView.Cols - 1) = "Incom. DATE:" & Format(dtpYMD.Value, "YYYY/MM/DD") & _
                                                       " Incom. Proc:" & strProc & _
                                                       " Component:" & strPart & _
                                                       "  Print Date:" & Format(Now, "YYYY/MM/DD HH:MM:SS")
   fspView.Cell(flexcpAlignment, 0, 2, 0, fspView.Cols - 1) = 8
   fspView.Cell(flexcpBackColor, 0, 0, 0, fspView.Cols - 1) = vbWhite
   
   fspView.MergeRow(0) = True
   fspView.RowHeightMax = 900
   fspView.RowHeightMax = 300
   fspView.RowHeight(0) = 1200
   
   fspView.ColWidth(1) = vOldWidth(1)
   For i = 2 To UBound(vOldWidth) - 1 Step 1
         fspView.ColWidth(i) = vOldWidth(i) - 200
   Next i
   
   fspView.FixedRows = fspView.FixedRows + 1
   
   fspView.PrintGrid "", True, 1, 150, 500
   
   For i = 0 To UBound(vOldWidth) Step 1
      fspView.ColWidth(i) = vOldWidth(i)
   Next i
   
   fspView.RemoveItem 0
   
   fspView.FixedRows = old_fixed_rows
   
'   fspView.PrintGrid "", True, 2, 80, 100
End Sub

Private Sub cmdSearch_Click()
   If chkin.Value = 1 Then
      Call sbViewDsp2
   Else
      Call sbViewDsp
   End If
End Sub

Private Sub Form_Load()
   Dim strRtn As String
   Dim SQL As String
   
   MAX_HH = 8 '1H - 9H
   vWidth = 490
   
   Me.Left = 0
   Me.Top = 0
   dtpYMD.Value = frmMO01VJ.dtpYMD.Value
   
   'Getting Process
   SQL = ""
   SQL = SQL & " SELECT 'FGA', 'Incoming of Assembly' FROM DUAL "
   SQL = SQL & " UNION ALL "
   SQL = SQL & " SELECT 'FSS', 'Incoming of Stockfit' FROM DUAL "
   
   strRtn = fnSetCbo(cboProc, SQL)
      
   Call sbHeadDSP
   
End Sub

Private Sub Form_Resize()
  fspView.Width = Me.Width - 200
  fspView.Height = Me.Height - 2000
End Sub

Private Sub Form_Unload(Cancel As Integer)
   Call frmMO01VJ.sbDspData(Format(frmMO01VJ.dtpYMD.Value, "YYYYMMDD"), "ALL")
   If frmMO01VJ.chkAutoScan.Value = 1 Then
      frmMO01VJ.tmrScan.Enabled = True
   End If
End Sub

Private Sub Image1_Click()
   'cndSave.DefaultExt = "*.txt"
      
   cndSave.ShowSave
   If cndSave.FileName = "" Then
   Else
      On Error GoTo err_rtn
      fspView.SaveGrid cndSave.FileName, flexFileTabText, True
   End If
   Exit Sub
err_rtn:
   Call sbMsgDsp("Can not file open!", gMsgDspSec)
End Sub

Private Sub SSCommand1_Click()
   Unload frmMO16VJ
End Sub

Private Sub cboProc_Click()
   If chkin.Value = 1 Then
      Call sbSetCboComp2(fnCboValue(cboProc))
   Else
      Call sbSetCboComp(fnCboValue(cboProc))
   End If
End Sub

Private Sub tmr1_Timer()
   sbrStatus.Panels.Item(1).Text = ""
   tmr1.Enabled = False
End Sub

