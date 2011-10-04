VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO05VJ 
   Caption         =   "MES-MO05VJ"
   ClientHeight    =   8145
   ClientLeft      =   75
   ClientTop       =   360
   ClientWidth     =   11850
   LinkTopic       =   "Form1"
   ScaleHeight     =   8145
   ScaleWidth      =   11850
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   4725
      Top             =   435
   End
   Begin VSFlex7LCtl.VSFlexGrid fspBal 
      Height          =   5250
      Left            =   45
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
      Rows            =   50
      Cols            =   18
      FixedRows       =   2
      FixedCols       =   0
      RowHeightMin    =   0
      RowHeightMax    =   0
      ColWidthMin     =   0
      ColWidthMax     =   0
      ExtendLastCol   =   0   'False
      FormatString    =   $"frmMO05VJ.frx":0000
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
         TabIndex        =   9
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
         TabIndex        =   10
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
         Caption         =   "Set Balance"
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
         Caption         =   "Set Balance"
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
         Picture         =   "frmMO05VJ.frx":018A
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
      Width           =   11850
      _ExtentX        =   20902
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
   Begin VSFlex7LCtl.VSFlexGrid fspSIZE2 
      Height          =   1500
      Left            =   30
      TabIndex        =   6
      Top             =   6390
      Width           =   11865
      _cx             =   20929
      _cy             =   2646
      _ConvInfo       =   1
      Appearance      =   1
      BorderStyle     =   1
      Enabled         =   -1  'True
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "굴림"
         Size            =   9
         Charset         =   129
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
      FocusRect       =   0
      HighLight       =   0
      AllowSelection  =   0   'False
      AllowBigSelection=   0   'False
      AllowUserResizing=   0
      SelectionMode   =   0
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
      FormatString    =   $"frmMO05VJ.frx":0E5F
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
      SubtotalPosition=   1
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
   Begin MSComCtl2.DTPicker dtpYMD 
      Height          =   360
      Left            =   675
      TabIndex        =   7
      Top             =   690
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
      Format          =   69599233
      CurrentDate     =   37956
      MinDate         =   37956
   End
   Begin MSComDlg.CommonDialog cndSave 
      Left            =   2445
      Top             =   615
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DefaultExt      =   "text (*.txt)"
   End
   Begin Threed.SSCommand cmdApply 
      Height          =   435
      Left            =   10200
      TabIndex        =   11
      Top             =   645
      Width           =   1680
      _Version        =   65536
      _ExtentX        =   2963
      _ExtentY        =   767
      _StockProps     =   78
      Caption         =   "Closing Stock"
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
      Left            =   105
      TabIndex        =   8
      Top             =   735
      Width           =   660
   End
End
Attribute VB_Name = "frmMO05VJ"
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


Private Sub cmdApply_Click()
   frmMO08VJ.Show 1
End Sub

Private Sub cmdPrint_Click()
   Dim vOldWidth1 As Integer
   Dim vOldWidth2 As Integer
   Dim vOldWidth3 As Integer
   Dim i As Integer
   
   fspBal.AddItem "" & vbTab & "", 0
   
   fspBal.Cell(flexcpText, 0, 0, 0, 2) = "Set Balance"
   fspBal.Cell(flexcpFontSize, 0, 0, 0, 2) = 12
   fspBal.Cell(flexcpFontBold, 0, 0, 0, 2) = True
   'fspBal.Cell(flexcpFontUnderline, 0, 0, 0, 2) = True
   fspBal.Cell(flexcpText, 0, 3, 0, fspBal.Cols - 1) = "Date: " & Format(dtpYMD.Value, "YYYY/MM/DD") & "        Print Date: " & Format(Now, "YYYY/MM/DD HH:MM:SS")
   fspBal.Cell(flexcpAlignment, 0, 3, 0, fspBal.Cols - 1) = 8
   fspBal.Cell(flexcpBackColor, 0, 0, 0, fspBal.Cols - 1) = vbWhite
   
   fspBal.MergeRow(0) = True
   fspBal.RowHeightMax = 900
   fspBal.RowHeightMax = 300
   fspBal.RowHeight(0) = 900
   
   vOldWidth1 = fspBal.ColWidth(1)
   vOldWidth2 = fspBal.ColWidth(2)
   vOldWidth3 = fspBal.ColWidth(3)
   
   fspBal.ColWidth(1) = vOldWidth1 + 1000
   fspBal.ColWidth(2) = vOldWidth2 + 300
   For i = 3 To fspBal.Cols - 1 Step 1
      fspBal.ColWidth(i) = vOldWidth3 + 200
   Next i
   fspBal.FixedRows = 3
   
   
   
   fspBal.PrintGrid "", True, 2, 150, 100
   
   fspBal.ColWidth(1) = vOldWidth1
   fspBal.ColWidth(2) = vOldWidth2
   For i = 3 To fspBal.Cols - 1 Step 1
      fspBal.ColWidth(i) = vOldWidth3
   Next i
   fspBal.RemoveItem 0
   
   fspBal.FixedRows = 2
End Sub

Private Sub cmdSearch_Click()
   Call sbBalDsp
End Sub

Private Sub Form_Load()
      
   lbTitle(0).Caption = "Set Balance"
   lbTitle(1).Caption = lbTitle(0).Caption
   
   Me.Left = 0
   Me.Top = 0
   vWidth = 600
   
   dtpYMD.Value = frmMO01VJ.dtpYMD.Value
   
   'Lv_SIZE = 4
   'vGEN_COUNT = 3
   vSIZE_COUNT = 31
      
   Call sbHeadBalDsp
   
   Call sbHeadSizeDSP("ME")
End Sub


Private Sub sbBalDsp()
   Dim SQL As String
   Dim strYMD As String
   Dim arrDATA As Variant
   Dim vFixedCols As Integer
   Dim i As Integer
   
   Call sbHeadBalDsp
   
   Call sbHeadSizeDSP("ME")
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   SQL = ""
   SQL = SQL & " SELECT ASSY_LINE, MAX(FN_MODEL2(STYLE_CD)), SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), "
   SQL = SQL & "     SUM(FGA_UP),"
   SQL = SQL & "     SUM(FGA_FS),"
   SQL = SQL & "     SUM(FGA_BAL),"
   SQL = SQL & "     SUM(UPS_UP),"
   SQL = SQL & "     SUM(FSS_FS),"
   SQL = SQL & "     SUM(FSS_OS),"
   SQL = SQL & "     SUM(FSS_PH),"
   SQL = SQL & "     SUM(FSS_PU),"
   SQL = SQL & "     SUM(FSS_SP),"
   SQL = SQL & "     SUM(FSS_BAL),"
   SQL = SQL & "     SUM(SOL_OS),"
   SQL = SQL & "     SUM(SOL_PH),"
   SQL = SQL & "     SUM(SOL_PU),"
   SQL = SQL & "     SUM(SOL_SP),"
   SQL = SQL & "     SUM(SOL_BAL) "
   SQL = SQL & " FROM ("
   
'   SQL = SQL & " SELECT ASSY_LINE, STYLE_CD, CS_SIZE,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(FGA_UP_B + FGA_UP_E + FGA_UP)) AS FGA_UP,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(FGA_FS_B + FGA_FS_E + FGA_FS)) AS FGA_FS,"
'   SQL = SQL & "     LEAST(FN_MM_MVZ(SUM(FGA_UP_B + FGA_UP_E + FGA_UP)),"
'   SQL = SQL & "           FN_MM_MVZ(SUM(FGA_FS_B + FGA_FS_E + FGA_FS))) AS FGA_BAL,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(UPS_UP_B + UPS_UP_E + UPS_UP)) AS UPS_UP,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_FS_B + FSS_FS_E + FSS_FS)) AS FSS_FS,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_OS_B + FSS_OS_E + FSS_OS - FN_MM_COMPVAL('FSS',STYLE_CD,'OS', FSS_DEF))) AS FSS_OS,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_PH_B + FSS_PH_E + FSS_PH - FN_MM_COMPVAL('FSS',STYLE_CD,'PH', FSS_DEF))) AS FSS_PH,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_PU_B + FSS_PU_E + FSS_PU - FN_MM_COMPVAL('FSS',STYLE_CD,'PU', FSS_DEF))) AS FSS_PU,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_SP_B + FSS_SP_E + FSS_SP - FN_MM_COMPVAL('FSS',STYLE_CD,'SP', FSS_DEF))) AS FSS_SP,"
'   SQL = SQL & "     FN_MM_PROCBAL('FSS',STYLE_CD, 'OS','PH','PU','SP','*',"
'   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_OS_B + FSS_OS_E + FSS_OS - FN_MM_COMPVAL('FSS',STYLE_CD,'OS', FSS_DEF))),"
'   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_PH_B + FSS_PH_E + FSS_PH - FN_MM_COMPVAL('FSS',STYLE_CD,'PH', FSS_DEF))),"
'   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_PU_B + FSS_PU_E + FSS_PU - FN_MM_COMPVAL('FSS',STYLE_CD,'PU', FSS_DEF))),"
'   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_SP_B + FSS_SP_E + FSS_SP - FN_MM_COMPVAL('FSS',STYLE_CD,'SP', FSS_DEF))),"
'   SQL = SQL & "                   0) AS FSS_BAL,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(SOL_OS_B + SOL_OS_E + SOL_OS)) AS SOL_OS,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(SOL_PH_B + SOL_PH_E + SOL_PH)) AS SOL_PH,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(SOL_PU_B + SOL_PU_E + SOL_PU)) AS SOL_PU,"
'   SQL = SQL & "     FN_MM_MVZ(SUM(SOL_SP_B + SOL_SP_E + SOL_SP)) AS SOL_SP,"
'   SQL = SQL & "     FN_MM_PROCBAL('FSS',STYLE_CD, 'OS','PH','PU','SP','*',"
'   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_OS_B + SOL_OS_E + SOL_OS)),"
'   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_PH_B + SOL_PH_E + SOL_PH)),"
'   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_PU_B + SOL_PU_E + SOL_PU)),"
'   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_SP_B + SOL_SP_E + SOL_SP)),"
'   SQL = SQL & "                   0) AS SOL_BAL"
   
   SQL = SQL & " SELECT ASSY_LINE, STYLE_CD, CS_SIZE,"
   SQL = SQL & "     SUM(FGA_UP_B + FGA_UP_E + FGA_UP) AS FGA_UP,"
   SQL = SQL & "     SUM(FGA_FS_B + FGA_FS_E + FGA_FS) AS FGA_FS,"
   SQL = SQL & "     LEAST(FN_MM_MVZ(SUM(FGA_UP_B + FGA_UP_E + FGA_UP)),"
   SQL = SQL & "           FN_MM_MVZ(SUM(FGA_FS_B + FGA_FS_E + FGA_FS))) AS FGA_BAL,"
   SQL = SQL & "     SUM(UPS_UP_B + UPS_UP_E + UPS_UP) AS UPS_UP,"
   SQL = SQL & "     SUM(FSS_FS_B + FSS_FS_E + FSS_FS) AS FSS_FS,"
   SQL = SQL & "     SUM(FSS_OS_B + FSS_OS_E + FSS_OS - FN_MM_COMPVAL('FSS',STYLE_CD,'OS', FSS_DEF)) AS FSS_OS,"
   SQL = SQL & "     SUM(FSS_PH_B + FSS_PH_E + FSS_PH - FN_MM_COMPVAL('FSS',STYLE_CD,'PH', FSS_DEF)) AS FSS_PH,"
   SQL = SQL & "     SUM(FSS_PU_B + FSS_PU_E + FSS_PU - FN_MM_COMPVAL('FSS',STYLE_CD,'PU', FSS_DEF)) AS FSS_PU,"
   SQL = SQL & "     SUM(FSS_SP_B + FSS_SP_E + FSS_SP - FN_MM_COMPVAL('FSS',STYLE_CD,'SP', FSS_DEF)) AS FSS_SP,"
   SQL = SQL & "     FN_MM_PROCBAL('FSS',STYLE_CD, 'OS','PH','PU','SP','*',"
   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_OS_B + FSS_OS_E + FSS_OS - FN_MM_COMPVAL('FSS',STYLE_CD,'OS', FSS_DEF))),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_PH_B + FSS_PH_E + FSS_PH - FN_MM_COMPVAL('FSS',STYLE_CD,'PH', FSS_DEF))),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_PU_B + FSS_PU_E + FSS_PU - FN_MM_COMPVAL('FSS',STYLE_CD,'PU', FSS_DEF))),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_SP_B + FSS_SP_E + FSS_SP - FN_MM_COMPVAL('FSS',STYLE_CD,'SP', FSS_DEF))),"
   SQL = SQL & "                   0) AS FSS_BAL,"
   SQL = SQL & "     SUM(SOL_OS_B + SOL_OS_E + SOL_OS) AS SOL_OS,"
   SQL = SQL & "     SUM(SOL_PH_B + SOL_PH_E + SOL_PH) AS SOL_PH,"
   SQL = SQL & "     SUM(SOL_PU_B + SOL_PU_E + SOL_PU) AS SOL_PU,"
   SQL = SQL & "     SUM(SOL_SP_B + SOL_SP_E + SOL_SP) AS SOL_SP,"
   SQL = SQL & "     FN_MM_PROCBAL('FSS',STYLE_CD, 'OS','PH','PU','SP','*',"
   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_OS_B + SOL_OS_E + SOL_OS)),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_PH_B + SOL_PH_E + SOL_PH)),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_PU_B + SOL_PU_E + SOL_PU)),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_SP_B + SOL_SP_E + SOL_SP)),"
   SQL = SQL & "                   0) AS SOL_BAL"
   
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT ASSY_LINE, STYLE_CD, CS_SIZE,"
   SQL = SQL & "     0 AS FGA_UP_B,"
   SQL = SQL & "     0 AS FGA_FS_B,"
   SQL = SQL & "     0 AS UPS_UP_B,"
   SQL = SQL & "     0 AS FSS_FS_B,"
   SQL = SQL & "     0 AS FSS_OS_B,"
   SQL = SQL & "     0 AS FSS_PH_B,"
   SQL = SQL & "     0 AS FSS_PU_B,"
   SQL = SQL & "     0 AS FSS_SP_B,"
   SQL = SQL & "     0 AS SOL_OS_B,"
   SQL = SQL & "     0 AS SOL_PH_B,"
   SQL = SQL & "     0 AS SOL_PU_B,"
   SQL = SQL & "     0 AS SOL_SP_B,"
   SQL = SQL & "     0 AS FGA_UP_E,"
   SQL = SQL & "     0 AS FGA_FS_E,"
   SQL = SQL & "     0 AS UPS_UP_E,"
   SQL = SQL & "     0 AS FSS_FS_E,"
   SQL = SQL & "     0 AS FSS_OS_E,"
   SQL = SQL & "     0 AS FSS_PH_E,"
   SQL = SQL & "     0 AS FSS_PU_E,"
   SQL = SQL & "     0 AS FSS_SP_E,"
   SQL = SQL & "     0 AS SOL_OS_E,"
   SQL = SQL & "     0 AS SOL_PH_E,"
   SQL = SQL & "     0 AS SOL_PU_E,"
   SQL = SQL & "     0 AS SOL_SP_E,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGAIUP',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGATUP',PRS_QTY,0)) AS FGA_UP,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGAIFS',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGATFS',PRS_QTY,0)) AS FGA_FS,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'UPSPUP',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGAIUP',PRS_QTY,0)) AS UPS_UP,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGAIFS',PRS_QTY,0)) AS FSS_FS,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIOS',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',FN_MM_COMPVAL('FSS',STYLE_CD,'OS', PRS_QTY),0)) AS FSS_OS,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIPH',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',FN_MM_COMPVAL('FSS',STYLE_CD,'PH', PRS_QTY),0)) AS FSS_PH,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIPU',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',FN_MM_COMPVAL('FSS',STYLE_CD,'PU', PRS_QTY),0)) AS FSS_PU,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSISP',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',FN_MM_COMPVAL('FSS',STYLE_CD,'SP', PRS_QTY),0)) AS FSS_SP,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'OSPPOS',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIOS',PRS_QTY,0)) AS SOL_OS,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,2)||RST_DIV||SEMI_GOOD_CD,'PHIPH',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIPH',PRS_QTY,0)) AS SOL_PH,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'PUSPPU',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIPU',PRS_QTY,0)) AS SOL_PU,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'SPPPSP',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSISP',PRS_QTY,0)) AS SOL_SP,"
   SQL = SQL & "     0 AS FSS_DEF "
   SQL = SQL & " FROM MP_PROD "
   SQL = SQL & " WHERE RST_YMD >= '" & IIf(Mid(strYMD, 1, 6) <= "200401", "20040112", Mid(strYMD, 1, 6) & "00") & "' AND RST_YMD <= '" & strYMD & "' "
   SQL = SQL & " AND PROC||RST_DIV IN ('FGAI','FGAT','UPSP','FSSI','FSSP','OSPP','PHPI','PHII','PUSP','SPPP')"
   SQL = SQL & " AND ASSY_LINE >= '1' AND ASSY_LINE <= '6'"
   SQL = SQL & " GROUP BY ASSY_LINE, STYLE_CD, CS_SIZE "
   SQL = SQL & " UNION All "
   
   SQL = SQL & " SELECT A.ASSY_LINE, A.STYLE_CD, B.CS_SIZE,"
   SQL = SQL & "     0 AS FGA_UP_B,"
   SQL = SQL & "     0 AS FGA_FS_B,"
   SQL = SQL & "     0 AS UPS_UP_B,"
   SQL = SQL & "     0 AS FSS_FS_B,"
   SQL = SQL & "     0 AS FSS_OS_B,"
   SQL = SQL & "     0 AS FSS_PH_B,"
   SQL = SQL & "     0 AS FSS_PU_B,"
   SQL = SQL & "     0 AS FSS_SP_B,"
   SQL = SQL & "     0 AS SOL_OS_B,"
   SQL = SQL & "     0 AS SOL_PH_B,"
   SQL = SQL & "     0 AS SOL_PU_B,"
   SQL = SQL & "     0 AS SOL_SP_B,"
   SQL = SQL & "     0 AS FGA_UP_E,"
   SQL = SQL & "     0 AS FGA_FS_E,"
   SQL = SQL & "     0 AS UPS_UP_E,"
   SQL = SQL & "     0 AS FSS_FS_E,"
   SQL = SQL & "     0 AS FSS_OS_E,"
   SQL = SQL & "     0 AS FSS_PH_E,"
   SQL = SQL & "     0 AS FSS_PU_E,"
   SQL = SQL & "     0 AS FSS_SP_E,"
   SQL = SQL & "     0 AS SOL_OS_E,"
   SQL = SQL & "     0 AS SOL_PH_E,"
   SQL = SQL & "     0 AS SOL_PU_E,"
   SQL = SQL & "     0 AS SOL_SP_E,"
   SQL = SQL & "     0 AS FGA_UP,"
   SQL = SQL & "     0 AS FGA_FS,"
   SQL = SQL & "     0 AS UPS_UP,"
   SQL = SQL & "     0 AS FSS_FS,"
   SQL = SQL & "     0 AS FSS_OS,"
   SQL = SQL & "     0 AS FSS_PH,"
   SQL = SQL & "     0 AS FSS_PU,"
   SQL = SQL & "     0 AS FSS_SP,"
   SQL = SQL & "     0 AS SOL_OS,"
   SQL = SQL & "     0 AS SOL_PH,"
   SQL = SQL & "     0 AS SOL_PU,"
   SQL = SQL & "     0 AS SOL_SP,"
   SQL = SQL & "     SUM(DECODE(A.WRT_DIV,'DF',DECODE(A.DEF_GRADE,'R',0,ROUND((NVL(B.LEFT_PCS, 0) + NVL(B.RIGHT_PCS, 0))/2)),0)) AS FSS_DEF "
   SQL = SQL & " FROM QA_DEFHEAD A, QA_DEFSIZE B"
   SQL = SQL & " WHERE A.FACTORY = B.FACTORY "
   SQL = SQL & " AND A.DEF_YMD     = B.DEF_YMD"
   SQL = SQL & " AND A.WRT_AREA_CD = B.WRT_AREA_CD"
   SQL = SQL & " AND A.WRT_DIV     = B.WRT_DIV"
   SQL = SQL & " AND A.SEQ         = B.SEQ"
   SQL = SQL & " AND A.DEF_YMD    >= '" & IIf(Mid(strYMD, 1, 6) <= "200401", "20040112", Mid(strYMD, 1, 6) & "00") & "' AND A.DEF_YMD <= '" & strYMD & "' "
   SQL = SQL & " AND A.CAU_OP_CD   = 'FSS'"
   SQL = SQL & " AND A.CAU_AREA_CD = 'FSS'"
   SQL = SQL & " AND A.INPUT_YN    = 'N'"
   SQL = SQL & " AND A.DEF_CD      NOT IN ('FSS98', 'FSS99')"
   SQL = SQL & " AND A.CAU_SEMI_GOOD_CD = 'FS'"
   SQL = SQL & " GROUP BY A.ASSY_LINE, A.STYLE_CD, B.CS_SIZE "
   
   SQL = SQL & " UNION All "
   SQL = SQL & " SELECT ASSY_LINE, STYLE_CD, CS_SIZE,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FGAITUP', PRS_QTY,0)) AS FGA_UP_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FGAITFS', PRS_QTY,0)) AS FGA_FS_B,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,3)||IVTR_DIV||SEMI_GOOD_CD,'UPSPOUP', PRS_QTY,0)) AS UPS_UP_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSPOFS', PRS_QTY,0)) AS FSS_FS_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPOS', PRS_QTY,0)) AS FSS_OS_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPPH', PRS_QTY,0)) AS FSS_PH_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPPU', PRS_QTY,0)) AS FSS_PU_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPSP', PRS_QTY,0)) AS FSS_SP_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'OSPPOOS', PRS_QTY,0)) AS FSS_OS_B,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,2)||IVTR_DIV||SEMI_GOOD_CD,'PHIOPH', PRS_QTY,0)) AS FSS_PH_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'PUSPOPU', PRS_QTY,0)) AS FSS_PU_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'SPPPOSP', PRS_QTY,0)) AS FSS_SP_B,"
   SQL = SQL & "     0 AS FGA_UP_E,"
   SQL = SQL & "     0 AS FGA_FS_E,"
   SQL = SQL & "     0 AS UPS_UP_E,"
   SQL = SQL & "     0 AS FSS_FS_E,"
   SQL = SQL & "     0 AS FSS_OS_E,"
   SQL = SQL & "     0 AS FSS_PH_E,"
   SQL = SQL & "     0 AS FSS_PU_E,"
   SQL = SQL & "     0 AS FSS_SP_E,"
   SQL = SQL & "     0 AS SOL_OS_E,"
   SQL = SQL & "     0 AS SOL_PH_E,"
   SQL = SQL & "     0 AS SOL_PU_E,"
   SQL = SQL & "     0 AS SOL_SP_E,"
   SQL = SQL & "     0 AS FGA_UP,"
   SQL = SQL & "     0 AS FGA_FS,"
   SQL = SQL & "     0 AS UPS_UP,"
   SQL = SQL & "     0 AS FSS_FS,"
   SQL = SQL & "     0 AS FSS_OS,"
   SQL = SQL & "     0 AS FSS_PH,"
   SQL = SQL & "     0 AS FSS_PU,"
   SQL = SQL & "     0 AS FSS_SP,"
   SQL = SQL & "     0 AS SOL_OS,"
   SQL = SQL & "     0 AS SOL_PH,"
   SQL = SQL & "     0 AS SOL_PU,"
   SQL = SQL & "     0 AS SOL_SP, "
   SQL = SQL & "     0 AS FSS_DEF "
   SQL = SQL & "  FROM MP_MONSTK "
   SQL = SQL & " WHERE YYMM     = TO_CHAR(ADD_MONTHS(TO_DATE('" & strYMD & "','YYYYMMDD'),-1),'YYYYMM') "
   SQL = SQL & " AND PROC     IN ('FGA','UPS1','UPS2','FSS','OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & " AND ASSY_LINE >= '1' AND ASSY_LINE <= '6'"
   SQL = SQL & " GROUP BY ASSY_LINE, STYLE_CD, CS_SIZE "
   SQL = SQL & " UNION All"
   SQL = SQL & " SELECT ASSY_LINE, STYLE_CD, CS_SIZE,"
   SQL = SQL & "     0 AS FGA_UP_B,"
   SQL = SQL & "     0 AS FGA_FS_B,"
   SQL = SQL & "     0 AS UPS_UP_B,"
   SQL = SQL & "     0 AS FSS_FS_B,"
   SQL = SQL & "     0 AS FSS_OS_B,"
   SQL = SQL & "     0 AS FSS_PH_B,"
   SQL = SQL & "     0 AS FSS_PU_B,"
   SQL = SQL & "     0 AS FSS_SP_B,"
   SQL = SQL & "     0 AS SOL_OS_B,"
   SQL = SQL & "     0 AS SOL_PH_B,"
   SQL = SQL & "     0 AS SOL_PU_B,"
   SQL = SQL & "     0 AS SOL_SP_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FGAITUP', ADJ_QTY,0)) AS FGA_UP_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FGAITFS', ADJ_QTY,0)) AS FGA_FS_E,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,3)||IVTR_DIV||SEMI_GOOD_CD,'UPSPOUP', ADJ_QTY,0)) AS UPS_UP_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSPOFS', ADJ_QTY,0)) AS FSS_FS_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPOS', ADJ_QTY,0)) AS FSS_OS_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPPH', ADJ_QTY,0)) AS FSS_PH_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPPU', ADJ_QTY,0)) AS FSS_PU_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPSP', ADJ_QTY,0)) AS FSS_SP_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'OSPPOOS', ADJ_QTY,0)) AS FSS_OS_E,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,2)||IVTR_DIV||SEMI_GOOD_CD,'PHIOPH', PRS_QTY,0)) AS FSS_PH_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'PUSPOPU', ADJ_QTY,0)) AS FSS_PU_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'SPPPOSP', ADJ_QTY,0)) AS FSS_SP_E,"
   SQL = SQL & "     0 AS FGA_UP,"
   SQL = SQL & "     0 AS FGA_FS,"
   SQL = SQL & "     0 AS UPS_UP,"
   SQL = SQL & "     0 AS FSS_FS,"
   SQL = SQL & "     0 AS FSS_OS,"
   SQL = SQL & "     0 AS FSS_PH,"
   SQL = SQL & "     0 AS FSS_PU,"
   SQL = SQL & "     0 AS FSS_SP,"
   SQL = SQL & "     0 AS SOL_OS,"
   SQL = SQL & "     0 AS SOL_PH,"
   SQL = SQL & "     0 AS SOL_PU,"
   SQL = SQL & "     0 AS SOL_SP, "
   SQL = SQL & "     0 AS FSS_DEF "
   SQL = SQL & " FROM MP_EXAMSTK"
   SQL = SQL & " WHERE YMD >= '" & IIf(Mid(strYMD, 1, 6) <= "200401", "20040112", Mid(strYMD, 1, 6) & "00") & "' AND YMD <= '" & strYMD & "' "
   SQL = SQL & " AND PROC     IN ('FGA','UPS1','UPS2','FSS','OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & " AND ASSY_LINE >= '1' AND ASSY_LINE <= '6'"
   SQL = SQL & " GROUP BY ASSY_LINE, STYLE_CD, CS_SIZE"
   SQL = SQL & " )"
   SQL = SQL & " GROUP BY ASSY_LINE, STYLE_CD, CS_SIZE"
   SQL = SQL & " )"
   SQL = SQL & " GROUP BY ASSY_LINE, STYLE_CD"
   
   SQL = SQL & "  ORDER BY 1, 3 "
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If IsArray(arrDATA) Then
      
      vFixedCols = fspBal.FrozenCols
      fspBal.FrozenCols = 0
      fspBal.LoadArray arrDATA
      fspBal.FrozenCols = vFixedCols
      'vFixedCols = fspBal.FixedCols
      'fspBal.FixedCols = 0
      'fspBal.LoadArray arrDATA
      'fspBal.FixedCols = vFixedCols
   Else
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   For i = 3 To fspBal.Cols - 1 Step 1
      If UCase(Right(fspBal.TextMatrix(1, i), 3)) = "BAL" Then
         fspBal.Cell(flexcpBackColor, fspBal.FixedRows, i, fspBal.Rows - 1, i) = RGB(220, 220, 220)
      End If
   Next i
   
   
   'fspBal.Cell(flexcpBackColor, fspLine.Rows - 1, 3, fspLine.Rows - 1, fspLine.Cols - 1) = vbYellow
   For i = 3 To fspBal.Cols - 1 Step 1
      fspBal.Subtotal flexSTSum, 0, i, "######", vbYellow, , , ""
   Next i
   
   For i = 3 To fspBal.Cols - 1 Step 1
      fspBal.Subtotal flexSTSum, -1, i, "######", vbYellow, , , ""
   Next i
   
   fspBal.Cell(flexcpAlignment, fspBal.FixedRows, 3, fspBal.Rows - 1, fspBal.Cols - 1) = 7
   
   For i = fspBal.FixedRows To fspBal.Rows - 1 Step 1
      If Mid(fspBal.TextMatrix(i, 0), 1, 1) = "T" Or Mid(fspBal.TextMatrix(i, 0), 1, 1) = "G" Then
         fspBal.TextMatrix(i, 1) = fspBal.TextMatrix(i, 0)
         fspBal.TextMatrix(i, 0) = ""
      End If
   Next
   
End Sub

Private Sub sbHeadBalDsp()
   Dim i As Integer
            
            
   fspBal.Clear
   
   fspBal.FontSize = 8
   fspBal.MergeCells = flexMergeFree
   
   fspBal.FrozenCols = 3
   fspBal.Cols = 18
   
   fspBal.Cell(flexcpText, 0, 0, 1, 0) = "Ln"
   fspBal.Cell(flexcpText, 0, 1, 1, 1) = "Model Name"
   fspBal.Cell(flexcpText, 0, 2, 1, 2) = "Style"
   fspBal.Cell(flexcpText, 0, 3, 0, 5) = "Assembly Balance"
   fspBal.Cell(flexcpText, 1, 3, 1, 3) = "UP"
   fspBal.Cell(flexcpText, 1, 4, 1, 4) = "FS"
   fspBal.Cell(flexcpText, 1, 5, 1, 5) = "Bal"
   
   fspBal.Cell(flexcpText, 0, 6, 0, 7) = "W/S Stock"
   fspBal.Cell(flexcpText, 1, 6, 1, 6) = "UPS"
   fspBal.Cell(flexcpText, 1, 7, 1, 7) = "FSS"
   fspBal.Cell(flexcpText, 0, 8, 0, 12) = "Stockfit Balance"
   fspBal.Cell(flexcpText, 1, 8, 1, 8) = "OS"
   fspBal.Cell(flexcpText, 1, 9, 1, 9) = "PH"
   fspBal.Cell(flexcpText, 1, 10, 1, 10) = "PU"
   fspBal.Cell(flexcpText, 1, 11, 1, 11) = "SP"
   fspBal.Cell(flexcpText, 1, 12, 1, 12) = "Bal"
   fspBal.Cell(flexcpText, 0, 13, 0, 17) = "W/S Bottom Stock"
   fspBal.Cell(flexcpText, 1, 13, 1, 13) = "OS"
   fspBal.Cell(flexcpText, 1, 14, 1, 14) = "PH"
   fspBal.Cell(flexcpText, 1, 15, 1, 15) = "PU"
   fspBal.Cell(flexcpText, 1, 16, 1, 16) = "SP"
   fspBal.Cell(flexcpText, 1, 17, 1, 17) = "Bal"
   
   fspBal.MergeRow(0) = True
   fspBal.MergeCol(0) = True
   fspBal.MergeCol(1) = True
   fspBal.MergeCol(2) = True
   'fspBal.MergeCol(6) = True
   'fspBal.MergeCol(7) = True
   
   fspBal.ColWidth(0) = 270
   fspBal.ColWidth(1) = 1305
   fspBal.ColWidth(2) = 970
   
   fspBal.RowHeightMax = "220"
   fspBal.RowHeightMin = "220"
   
   fspBal.Cell(flexcpAlignment, 0, 0, 1, fspBal.Cols - 1) = 4
   
   For i = 3 To fspBal.Cols - 1 Step 1
      fspBal.ColWidth(i) = vWidth
   Next i
   
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
   If Mid(fspBal.TextMatrix(fspBal.Row, 1), 1, 1) = "T" Or Mid(fspBal.TextMatrix(fspBal.Row, 1), 1, 1) = "G" Then
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
   Dim strYMD As String
   Dim strLine As String
   Dim strSTY As String
   
   Call sbHeadSizeDSP(Mid(fspBal.TextMatrix(fspBal.Row, 1), 1, 2))
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   strLine = fspBal.TextMatrix(fspBal.Row, 0)
   strSTY = Replace(fspBal.TextMatrix(fspBal.Row, 2), "-", "")
   
   SQL = ""
   SQL = SQL & " SELECT CS_SIZE,"
   SQL = SQL & "     FN_MM_MVZ(SUM(FGA_UP_B + FGA_UP_E + FGA_UP)) AS FGA_UP,"
   SQL = SQL & "     FN_MM_MVZ(SUM(FGA_FS_B + FGA_FS_E + FGA_FS)) AS FGA_FS,"
   SQL = SQL & "     LEAST(FN_MM_MVZ(SUM(FGA_UP_B + FGA_UP_E + FGA_UP)),"
   SQL = SQL & "           FN_MM_MVZ(SUM(FGA_FS_B + FGA_FS_E + FGA_FS))) AS FGA_BAL,"
   SQL = SQL & "     FN_MM_MVZ(SUM(UPS_UP_B + UPS_UP_E + UPS_UP)) AS UPS_UP,"
   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_FS_B + FSS_FS_E + FSS_FS)) AS FSS_FS,"
   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_OS_B + FSS_OS_E + FSS_OS - FN_MM_COMPVAL('FSS','" & strSTY & "','OS', FSS_DEF))) AS FSS_OS,"
   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_PH_B + FSS_PH_E + FSS_PH - FN_MM_COMPVAL('FSS','" & strSTY & "','PH', FSS_DEF))) AS FSS_PH,"
   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_PU_B + FSS_PU_E + FSS_PU - FN_MM_COMPVAL('FSS','" & strSTY & "','PU', FSS_DEF))) AS FSS_PU,"
   SQL = SQL & "     FN_MM_MVZ(SUM(FSS_SP_B + FSS_SP_E + FSS_SP - FN_MM_COMPVAL('FSS','" & strSTY & "','SP', FSS_DEF))) AS FSS_SP,"
   SQL = SQL & "     FN_MM_PROCBAL('FSS','" & strSTY & "', 'OS','PH','PU','SP','*',"
   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_OS_B + FSS_OS_E + FSS_OS - FN_MM_COMPVAL('FSS','" & strSTY & "','OS', FSS_DEF))),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_PH_B + FSS_PH_E + FSS_PH - FN_MM_COMPVAL('FSS','" & strSTY & "','PH', FSS_DEF))),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_PU_B + FSS_PU_E + FSS_PU - FN_MM_COMPVAL('FSS','" & strSTY & "','PU', FSS_DEF))),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(FSS_SP_B + FSS_SP_E + FSS_SP - FN_MM_COMPVAL('FSS','" & strSTY & "','SP', FSS_DEF))),"
   SQL = SQL & "                   0) AS FSS_BAL,"
   SQL = SQL & "     FN_MM_MVZ(SUM(SOL_OS_B + SOL_OS_E + SOL_OS)) AS SOL_OS,"
   SQL = SQL & "     FN_MM_MVZ(SUM(SOL_PH_B + SOL_PH_E + SOL_PH)) AS SOL_PH,"
   SQL = SQL & "     FN_MM_MVZ(SUM(SOL_PU_B + SOL_PU_E + SOL_PU)) AS SOL_PU,"
   SQL = SQL & "     FN_MM_MVZ(SUM(SOL_SP_B + SOL_SP_E + SOL_SP)) AS SOL_SP,"
   SQL = SQL & "     FN_MM_PROCBAL('FSS','" & strSTY & "', 'OS','PH','PU','SP','*',"
   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_OS_B + SOL_OS_E + SOL_OS)),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_PH_B + SOL_PH_E + SOL_PH)),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_PU_B + SOL_PU_E + SOL_PU)),"
   SQL = SQL & "                   FN_MM_MVZ(SUM(SOL_SP_B + SOL_SP_E + SOL_SP)),"
   SQL = SQL & "                   0) AS SOL_BAL"
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT CS_SIZE,"
   SQL = SQL & "     0 AS FGA_UP_B,"
   SQL = SQL & "     0 AS FGA_FS_B,"
   SQL = SQL & "     0 AS UPS_UP_B,"
   SQL = SQL & "     0 AS FSS_FS_B,"
   SQL = SQL & "     0 AS FSS_OS_B,"
   SQL = SQL & "     0 AS FSS_PH_B,"
   SQL = SQL & "     0 AS FSS_PU_B,"
   SQL = SQL & "     0 AS FSS_SP_B,"
   SQL = SQL & "     0 AS SOL_OS_B,"
   SQL = SQL & "     0 AS SOL_PH_B,"
   SQL = SQL & "     0 AS SOL_PU_B,"
   SQL = SQL & "     0 AS SOL_SP_B,"
   SQL = SQL & "     0 AS FGA_UP_E,"
   SQL = SQL & "     0 AS FGA_FS_E,"
   SQL = SQL & "     0 AS UPS_UP_E,"
   SQL = SQL & "     0 AS FSS_FS_E,"
   SQL = SQL & "     0 AS FSS_OS_E,"
   SQL = SQL & "     0 AS FSS_PH_E,"
   SQL = SQL & "     0 AS FSS_PU_E,"
   SQL = SQL & "     0 AS FSS_SP_E,"
   SQL = SQL & "     0 AS SOL_OS_E,"
   SQL = SQL & "     0 AS SOL_PH_E,"
   SQL = SQL & "     0 AS SOL_PU_E,"
   SQL = SQL & "     0 AS SOL_SP_E,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGAIUP',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGATUP',PRS_QTY,0)) AS FGA_UP,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGAIFS',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGATFS',PRS_QTY,0)) AS FGA_FS,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'UPSPUP',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGAIUP',PRS_QTY,0)) AS UPS_UP,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FGAIFS',PRS_QTY,0)) AS FSS_FS,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIOS',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',FN_MM_COMPVAL('FSS',STYLE_CD,'OS', PRS_QTY),0)) AS FSS_OS,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIPH',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',FN_MM_COMPVAL('FSS',STYLE_CD,'PH', PRS_QTY),0)) AS FSS_PH,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIPU',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',FN_MM_COMPVAL('FSS',STYLE_CD,'PU', PRS_QTY),0)) AS FSS_PU,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSISP',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSPFS',FN_MM_COMPVAL('FSS',STYLE_CD,'SP', PRS_QTY),0)) AS FSS_SP,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'OSPPOS',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIOS',PRS_QTY,0)) AS SOL_OS,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,2)||RST_DIV||SEMI_GOOD_CD,'PHIPH',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIPH',PRS_QTY,0)) AS SOL_PH,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'PUSPPU',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSIPU',PRS_QTY,0)) AS SOL_PU,"
   SQL = SQL & "     SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'SPPPSP',PRS_QTY,0)) - SUM(DECODE(PROC||RST_DIV||SEMI_GOOD_CD,'FSSISP',PRS_QTY,0)) AS SOL_SP,"
   SQL = SQL & "     0 AS FSS_DEF "
   SQL = SQL & " FROM MP_PROD "
   SQL = SQL & " WHERE RST_YMD >= '" & IIf(Mid(strYMD, 1, 6) <= "200401", "20040112", Mid(strYMD, 1, 6) & "00") & "' AND RST_YMD <= '" & strYMD & "' "
   SQL = SQL & " AND PROC||RST_DIV IN ('FGAI','FGAT','UPSP','FSSI','FSSP','OSPP','PHPI','PHII','PUSP','SPPP')"
   SQL = SQL & " AND STYLE_CD  = '" & strSTY & "' "
   SQL = SQL & " AND ASSY_LINE = '" & strLine & "' "
   SQL = SQL & " GROUP BY CS_SIZE "
   SQL = SQL & " UNION All "
   
   SQL = SQL & " SELECT B.CS_SIZE,"
   SQL = SQL & "     0 AS FGA_UP_B,"
   SQL = SQL & "     0 AS FGA_FS_B,"
   SQL = SQL & "     0 AS UPS_UP_B,"
   SQL = SQL & "     0 AS FSS_FS_B,"
   SQL = SQL & "     0 AS FSS_OS_B,"
   SQL = SQL & "     0 AS FSS_PH_B,"
   SQL = SQL & "     0 AS FSS_PU_B,"
   SQL = SQL & "     0 AS FSS_SP_B,"
   SQL = SQL & "     0 AS SOL_OS_B,"
   SQL = SQL & "     0 AS SOL_PH_B,"
   SQL = SQL & "     0 AS SOL_PU_B,"
   SQL = SQL & "     0 AS SOL_SP_B,"
   SQL = SQL & "     0 AS FGA_UP_E,"
   SQL = SQL & "     0 AS FGA_FS_E,"
   SQL = SQL & "     0 AS UPS_UP_E,"
   SQL = SQL & "     0 AS FSS_FS_E,"
   SQL = SQL & "     0 AS FSS_OS_E,"
   SQL = SQL & "     0 AS FSS_PH_E,"
   SQL = SQL & "     0 AS FSS_PU_E,"
   SQL = SQL & "     0 AS FSS_SP_E,"
   SQL = SQL & "     0 AS SOL_OS_E,"
   SQL = SQL & "     0 AS SOL_PH_E,"
   SQL = SQL & "     0 AS SOL_PU_E,"
   SQL = SQL & "     0 AS SOL_SP_E,"
   SQL = SQL & "     0 AS FGA_UP,"
   SQL = SQL & "     0 AS FGA_FS,"
   SQL = SQL & "     0 AS UPS_UP,"
   SQL = SQL & "     0 AS FSS_FS,"
   SQL = SQL & "     0 AS FSS_OS,"
   SQL = SQL & "     0 AS FSS_PH,"
   SQL = SQL & "     0 AS FSS_PU,"
   SQL = SQL & "     0 AS FSS_SP,"
   SQL = SQL & "     0 AS SOL_OS,"
   SQL = SQL & "     0 AS SOL_PH,"
   SQL = SQL & "     0 AS SOL_PU,"
   SQL = SQL & "     0 AS SOL_SP,"
   SQL = SQL & "     SUM(DECODE(A.WRT_DIV,'DF',DECODE(A.DEF_GRADE,'R',0,ROUND((NVL(B.LEFT_PCS, 0) + NVL(B.RIGHT_PCS, 0))/2)),0)) AS FSS_DEF "
   SQL = SQL & " FROM QA_DEFHEAD A, QA_DEFSIZE B"
   SQL = SQL & " WHERE A.FACTORY = B.FACTORY "
   SQL = SQL & " AND A.DEF_YMD     = B.DEF_YMD"
   SQL = SQL & " AND A.WRT_AREA_CD = B.WRT_AREA_CD"
   SQL = SQL & " AND A.WRT_DIV     = B.WRT_DIV"
   SQL = SQL & " AND A.SEQ         = B.SEQ"
   SQL = SQL & " AND A.DEF_YMD    >= '" & IIf(Mid(strYMD, 1, 6) <= "200401", "20040112", Mid(strYMD, 1, 6) & "00") & "' AND A.DEF_YMD <= '" & strYMD & "' "
   SQL = SQL & " AND A.CAU_OP_CD   = 'FSS'"
   SQL = SQL & " AND A.CAU_AREA_CD = 'FSS'"
   SQL = SQL & " AND A.INPUT_YN    = 'N'"
   SQL = SQL & " AND A.DEF_CD      NOT IN ('FSS98', 'FSS99')"
   SQL = SQL & " AND A.CAU_SEMI_GOOD_CD = 'FS'"
   SQL = SQL & " AND A.STYLE_CD  = '" & strSTY & "' "
   SQL = SQL & " AND A.ASSY_LINE = '" & strLine & "' "
   SQL = SQL & " GROUP BY B.CS_SIZE "
   
   SQL = SQL & " UNION All "
   SQL = SQL & " SELECT CS_SIZE,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FGAITUP', PRS_QTY,0)) AS FGA_UP_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FGAITFS', PRS_QTY,0)) AS FGA_FS_B,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,3)||IVTR_DIV||SEMI_GOOD_CD,'UPSPOUP', PRS_QTY,0)) AS UPS_UP_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSPOFS', PRS_QTY,0)) AS FSS_FS_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPOS', PRS_QTY,0)) AS FSS_OS_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPPH', PRS_QTY,0)) AS FSS_PH_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPPU', PRS_QTY,0)) AS FSS_PU_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPSP', PRS_QTY,0)) AS FSS_SP_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'OSPPOOS', PRS_QTY,0)) AS FSS_OS_B,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,2)||IVTR_DIV||SEMI_GOOD_CD,'PHIOPH', PRS_QTY,0)) AS FSS_PH_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'PUSPOPU', PRS_QTY,0)) AS FSS_PU_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'SPPPOSP', PRS_QTY,0)) AS FSS_SP_B,"
   SQL = SQL & "     0 AS FGA_UP_E,"
   SQL = SQL & "     0 AS FGA_FS_E,"
   SQL = SQL & "     0 AS UPS_UP_E,"
   SQL = SQL & "     0 AS FSS_FS_E,"
   SQL = SQL & "     0 AS FSS_OS_E,"
   SQL = SQL & "     0 AS FSS_PH_E,"
   SQL = SQL & "     0 AS FSS_PU_E,"
   SQL = SQL & "     0 AS FSS_SP_E,"
   SQL = SQL & "     0 AS SOL_OS_E,"
   SQL = SQL & "     0 AS SOL_PH_E,"
   SQL = SQL & "     0 AS SOL_PU_E,"
   SQL = SQL & "     0 AS SOL_SP_E,"
   SQL = SQL & "     0 AS FGA_UP,"
   SQL = SQL & "     0 AS FGA_FS,"
   SQL = SQL & "     0 AS UPS_UP,"
   SQL = SQL & "     0 AS FSS_FS,"
   SQL = SQL & "     0 AS FSS_OS,"
   SQL = SQL & "     0 AS FSS_PH,"
   SQL = SQL & "     0 AS FSS_PU,"
   SQL = SQL & "     0 AS FSS_SP,"
   SQL = SQL & "     0 AS SOL_OS,"
   SQL = SQL & "     0 AS SOL_PH,"
   SQL = SQL & "     0 AS SOL_PU,"
   SQL = SQL & "     0 AS SOL_SP, "
   SQL = SQL & "     0 AS FSS_DEF "
   SQL = SQL & "  FROM MP_MONSTK "
   SQL = SQL & " WHERE YYMM    = TO_CHAR(ADD_MONTHS(TO_DATE('" & strYMD & "','YYYYMMDD'),-1),'YYYYMM') "
   SQL = SQL & " AND PROC     IN ('FGA','UPS1','UPS2','FSS','OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & " AND STYLE_CD  = '" & strSTY & "' "
   SQL = SQL & " AND ASSY_LINE = '" & strLine & "' "
   SQL = SQL & " GROUP BY CS_SIZE "
   SQL = SQL & " UNION All"
   SQL = SQL & " SELECT CS_SIZE,"
   SQL = SQL & "     0 AS FGA_UP_B,"
   SQL = SQL & "     0 AS FGA_FS_B,"
   SQL = SQL & "     0 AS UPS_UP_B,"
   SQL = SQL & "     0 AS FSS_FS_B,"
   SQL = SQL & "     0 AS FSS_OS_B,"
   SQL = SQL & "     0 AS FSS_PH_B,"
   SQL = SQL & "     0 AS FSS_PU_B,"
   SQL = SQL & "     0 AS FSS_SP_B,"
   SQL = SQL & "     0 AS SOL_OS_B,"
   SQL = SQL & "     0 AS SOL_PH_B,"
   SQL = SQL & "     0 AS SOL_PU_B,"
   SQL = SQL & "     0 AS SOL_SP_B,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FGAITUP', ADJ_QTY,0)) AS FGA_UP_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FGAITFS', ADJ_QTY,0)) AS FGA_FS_E,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,3)||IVTR_DIV||SEMI_GOOD_CD,'UPSPOUP', ADJ_QTY,0)) AS UPS_UP_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSPOFS', ADJ_QTY,0)) AS FSS_FS_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPOS', ADJ_QTY,0)) AS FSS_OS_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPPH', ADJ_QTY,0)) AS FSS_PH_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPPU', ADJ_QTY,0)) AS FSS_PU_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'FSSIPSP', ADJ_QTY,0)) AS FSS_SP_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'OSPPOOS', ADJ_QTY,0)) AS FSS_OS_E,"
   SQL = SQL & "     SUM(DECODE(SUBSTR(PROC,1,2)||IVTR_DIV||SEMI_GOOD_CD,'PHIOPH', PRS_QTY,0)) AS FSS_PH_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'PUSPOPU', ADJ_QTY,0)) AS FSS_PU_E,"
   SQL = SQL & "     SUM(DECODE(PROC||IVTR_DIV||SEMI_GOOD_CD,'SPPPOSP', ADJ_QTY,0)) AS FSS_SP_E,"
   SQL = SQL & "     0 AS FGA_UP,"
   SQL = SQL & "     0 AS FGA_FS,"
   SQL = SQL & "     0 AS UPS_UP,"
   SQL = SQL & "     0 AS FSS_FS,"
   SQL = SQL & "     0 AS FSS_OS,"
   SQL = SQL & "     0 AS FSS_PH,"
   SQL = SQL & "     0 AS FSS_PU,"
   SQL = SQL & "     0 AS FSS_SP,"
   SQL = SQL & "     0 AS SOL_OS,"
   SQL = SQL & "     0 AS SOL_PH,"
   SQL = SQL & "     0 AS SOL_PU,"
   SQL = SQL & "     0 AS SOL_SP, "
   SQL = SQL & "     0 AS FSS_DEF "
   SQL = SQL & " FROM MP_EXAMSTK"
   SQL = SQL & " WHERE YMD >= '" & IIf(Mid(strYMD, 1, 6) <= "200401", "20040112", Mid(strYMD, 1, 6) & "00") & "' AND YMD <= '" & strYMD & "' "
   SQL = SQL & " AND PROC     IN ('FGA','UPS1','UPS2','FSS','OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & " AND STYLE_CD  = '" & strSTY & "' "
   SQL = SQL & " AND ASSY_LINE = '" & strLine & "' "
   SQL = SQL & " GROUP BY CS_SIZE"
   SQL = SQL & " )"
   SQL = SQL & " GROUP BY CS_SIZE"
   SQL = SQL & "  ORDER BY 1 "
   
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
         fspSIZE2.TextMatrix(fspSIZE2.FixedRows + q - 1, vCol) = arrDATA(q, i)
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
      If UCase(Right(fspSIZE2.TextMatrix(i, 0), 3)) = "BAL" Then
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
   fspSIZE2.Rows = 16
   fspSIZE2.Cols = vSIZE_COL + vSIZE_COUNT
   fspSIZE2.TextMatrix(0, 0) = "Div"
   fspSIZE2.ColWidth(0) = 800
   fspSIZE2.Cell(flexcpAlignment, fspSIZE2.FixedRows, vSIZE_COL, fspSIZE2.Rows - 1, fspSIZE2.Cols - 1) = 7
   
   fspSIZE2.TextMatrix(1, 0) = "FGA.UP"
   fspSIZE2.TextMatrix(2, 0) = "FGA.FS"
   fspSIZE2.TextMatrix(3, 0) = "FGA.BAL"
   fspSIZE2.TextMatrix(4, 0) = "UPS.UP"
   fspSIZE2.TextMatrix(5, 0) = "FSS.FS"
   fspSIZE2.TextMatrix(6, 0) = "FSS.OS"
   fspSIZE2.TextMatrix(7, 0) = "FSS.PH"
   fspSIZE2.TextMatrix(8, 0) = "FSS.PU"
   fspSIZE2.TextMatrix(9, 0) = "FSS.SP"
   fspSIZE2.TextMatrix(10, 0) = "FSS.BAL"
   fspSIZE2.TextMatrix(11, 0) = "Sole.OS"
   fspSIZE2.TextMatrix(12, 0) = "Sole.PH"
   fspSIZE2.TextMatrix(13, 0) = "Sole.PU"
   fspSIZE2.TextMatrix(14, 0) = "Sole.SP"
   fspSIZE2.TextMatrix(15, 0) = "Sole.BAL"
   fspSIZE2.FrozenCols = 1
   ReDim vsize_arr(vSIZE_COUNT - 1)
      
   For k = 0 To vSIZE_COUNT - 1 Step 1
       vsize_arr(k) = "x"
   Next k
   
   Select Case arg_Gen
   Case "ME"
      'M Size Map
      k = 0
      For i = 3.5 To 12.5 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
      
      For i = 13 To 18 Step 1
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

Private Sub SSCommand1_Click()
   Unload frmMO05VJ
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
