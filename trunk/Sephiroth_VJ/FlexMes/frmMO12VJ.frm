VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO12VJ 
   Caption         =   "MES-MO12VJ"
   ClientHeight    =   8295
   ClientLeft      =   1080
   ClientTop       =   1245
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
   Begin VB.ComboBox cboDiv 
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
      Left            =   60
      Style           =   2  '드롭다운 목록
      TabIndex        =   17
      Top             =   735
      Width           =   840
   End
   Begin VB.ComboBox cboRstDiv 
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
      Left            =   7080
      Style           =   2  '드롭다운 목록
      TabIndex        =   15
      Top             =   735
      Width           =   1530
   End
   Begin VB.ComboBox cboLine 
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
      Left            =   11310
      Style           =   2  '드롭다운 목록
      TabIndex        =   13
      Top             =   735
      Width           =   585
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
      Left            =   9285
      Style           =   2  '드롭다운 목록
      TabIndex        =   11
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
      Left            =   4500
      Style           =   2  '드롭다운 목록
      TabIndex        =   9
      Top             =   735
      Width           =   1995
   End
   Begin MSComCtl2.DTPicker dtpYMD 
      Height          =   345
      Left            =   2070
      TabIndex        =   6
      Top             =   735
      Width           =   1470
      _ExtentX        =   2593
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
      Format          =   23789569
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
         TabIndex        =   16
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
         TabIndex        =   18
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
         Caption         =   "Daily Passcard"
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
         Caption         =   "Daily Passcard"
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
         Picture         =   "frmMO12VJ.frx":0000
         Top             =   30
         Width           =   4950
      End
   End
   Begin VSFlex7LCtl.VSFlexGrid fsp1 
      Height          =   6735
      Left            =   60
      TabIndex        =   4
      Top             =   1170
      Width           =   11850
      _cx             =   20902
      _cy             =   11880
      _ConvInfo       =   1
      Appearance      =   1
      BorderStyle     =   1
      Enabled         =   -1  'True
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Courier New"
         Size            =   6.75
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
      BackColorBkg    =   12632256
      BackColorAlternate=   -2147483643
      GridColor       =   8421504
      GridColorFixed  =   -2147483632
      TreeColor       =   -2147483632
      FloodColor      =   192
      SheetBorder     =   -2147483642
      FocusRect       =   1
      HighLight       =   1
      AllowSelection  =   -1  'True
      AllowBigSelection=   -1  'True
      AllowUserResizing=   4
      SelectionMode   =   0
      GridLines       =   0
      GridLinesFixed  =   0
      GridLineWidth   =   1
      Rows            =   50
      Cols            =   10
      FixedRows       =   0
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
   Begin MSComctlLib.StatusBar sbrStatus 
      Align           =   2  '아래 맞춤
      Height          =   360
      Left            =   0
      TabIndex        =   5
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
      Left            =   2475
      Top             =   420
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DefaultExt      =   "text (*.txt)"
   End
   Begin VB.Label Label1 
      BackStyle       =   0  '투명
      Caption         =   "Flow:"
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
      Index           =   4
      Left            =   6510
      TabIndex        =   14
      Top             =   765
      Width           =   585
   End
   Begin VB.Label Label1 
      BackStyle       =   0  '투명
      Caption         =   "Line:"
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
      Index           =   3
      Left            =   10785
      TabIndex        =   12
      Top             =   765
      Width           =   495
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
      Left            =   8610
      TabIndex        =   10
      Top             =   765
      Width           =   765
   End
   Begin VB.Label Label1 
      BackStyle       =   0  '투명
      Caption         =   "Process:"
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
      Left            =   3555
      TabIndex        =   8
      Top             =   765
      Width           =   930
   End
   Begin VB.Label lblassdate 
      BackStyle       =   0  '투명
      Caption         =   "Assy Date:"
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
      Left            =   930
      TabIndex        =   7
      Top             =   765
      Width           =   1155
   End
End
Attribute VB_Name = "frmMO12VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim vWidth As Variant
Dim MAX_HH As Integer

Private Sub sbMsgDsp(arg_TXT As Variant, arg_ITVL As Integer)
   tmr1.Enabled = False
   sbrStatus.Panels.Item(1).Text = ""
   sbrStatus.Panels.Item(1).Text = arg_TXT
   tmr1.Interval = arg_ITVL * 1000
   tmr1.Enabled = True
End Sub

Private Sub sbSetCboComp(arg_OPCD As String, arg_RstDiv As String)
   Dim SQL As String
   Dim strRtn As String
   
   SQL = ""
   SQL = SQL & "SELECT SEMI_GOOD_CD, MAX(FN_MM_CDNAME('PA01',SEMI_GOOD_CD)) "
   SQL = SQL & "  FROM MP_APPLY "
   SQL = SQL & " WHERE OP_CD LIKE '" & Mid(arg_OPCD, 1, 3) & "%' "
   SQL = SQL & "   AND RST_DIV LIKE '" & arg_RstDiv & "%' "
   SQL = SQL & " GROUP BY SEMI_GOOD_CD "
   SQL = SQL & " ORDER BY 1 "
   
   strRtn = fnSetCbo(cboComp, SQL)

End Sub

Private Sub sbSetCboRstDiv(arg_OPCD As String)
   Dim SQL As String
   Dim strRtn As String
   
   SQL = ""
   SQL = SQL & "SELECT RST_DIV, MAX(DECODE(RST_DIV,'I','Incoming','T','Input','P','Production','O','Outgoing','Nothing')) "
   SQL = SQL & "  FROM MP_APPLY "
   SQL = SQL & " WHERE OP_CD LIKE '" & Mid(arg_OPCD, 1, 3) & "%' "
   SQL = SQL & " GROUP BY RST_DIV "
   SQL = SQL & " ORDER BY 1 "
   
   strRtn = fnSetCbo(cboRstDiv, SQL)
   
End Sub

Private Sub sbSetCboLine(arg_OPCD As String, arg_RstDiv As String)
   Dim SQL As String
   Dim strRtn As String
   
   SQL = ""
   SQL = SQL & "SELECT ASSY_LINE, ASSY_LINE "
   SQL = SQL & "  FROM MP_APPLY "
   SQL = SQL & " WHERE OP_CD LIKE '" & Mid(arg_OPCD, 1, 3) & "%' "
   SQL = SQL & "   AND RST_DIV LIKE '" & arg_RstDiv & "%' "
   SQL = SQL & " GROUP BY ASSY_LINE "
   SQL = SQL & " ORDER BY 1 "
   
   strRtn = fnSetCbo(cboLine, SQL)

End Sub

Private Sub sbHeadPassDSP(arg_NOS_TF As Boolean)
   Dim i As Integer
   Dim j As Integer
   Dim Row As Integer
   Dim Col As Integer
   Dim startCol As Integer
   Dim strVal As String
   
   fsp1.Clear
   fsp1.GridLines = 0
   fsp1.GridLineWidth = 0
   fsp1.FontSize = 7
   fsp1.Rows = 65 + 6
   fsp1.Cols = 40
   fsp1.MergeCells = flexMergeFree
   fsp1.Cell(flexcpAlignment, 0, 0, fsp1.Rows - 1, fsp1.Cols - 1) = 4
   
   For i = 1 To fsp1.Cols - 2 Step 1
      fsp1.ColWidth(i) = vWidth
   Next
   
   Row = 0
   Col = 1
   fsp1.RowHeight(Row) = 400
   fsp1.Cell(flexcpText, Row, Col, Row, fsp1.Cols - 2) = "Daily Passcard By Plan(" & IIf(fnCboValue(cboDiv) = "1", "NOR", "DEF") & ")"
   fsp1.Cell(flexcpFontSize, Row, Col, Row, 19) = 14
   fsp1.Cell(flexcpFontBold, Row, Col, Row, 19) = True
   fsp1.Cell(flexcpFontUnderline, Row, Col, Row, 19) = True
   fsp1.MergeRow(Row) = True
   
   
   fsp1.RowHeight(1) = 10
   
   Row = 2
   fsp1.RowHeight(Row) = 250
   fsp1.Cell(flexcpFontSize, Row, 0, Row, fsp1.Cols - 1) = 10
   fsp1.Cell(flexcpText, Row, 0, Row, 6) = "Assembly Line : " & fnCboValue(cboLine)
   fsp1.Cell(flexcpText, Row, 17, Row, 26) = "Assembly Plan : " & Format(dtpYMD.Value, "MM.DD.YYYY")
   fsp1.Cell(flexcpText, Row, 32, Row, 37) = "Process Code : " & fnCboValue(cboProc)
   fsp1.Cell(flexcpAlignment, Row, 0, Row, fsp1.Cols - 1) = 1
   fsp1.MergeRow(Row) = True
   
   'Draw Box
   Row = 3
   Col = 0
   fsp1.ColWidth(Col) = 20
   fsp1.Cell(6, Row, Col, fsp1.Rows - 1, Col) = RGB(1, 1, 1)
   
   fsp1.RowHeight(Row) = 20
   fsp1.Cell(6, Row, Col, Row, fsp1.Cols - 1) = RGB(1, 1, 1)
   
   fsp1.ColWidth(fsp1.Cols - 1) = 20
   fsp1.Cell(6, Row, fsp1.Cols - 1, fsp1.Rows - 1, fsp1.Cols - 1) = RGB(1, 1, 1)
   
   fsp1.RowHeight(fsp1.Rows - 1) = 20
   fsp1.Cell(6, fsp1.Rows - 1, 0, fsp1.Rows - 1, fsp1.Cols - 1) = RGB(1, 1, 1)
   
   Row = 4
   Col = 1 'style
   fsp1.RowHeight(Row) = 180
   fsp1.Cell(flexcpText, Row, Col, Row, Col + 3) = "Style"
   Col = 4 'po
   fsp1.Cell(flexcpText, Row, Col, Row, Col + 2) = "PO"
   Col = 6 'model name
   fsp1.Cell(flexcpText, Row, Col, Row, Col + 5) = "Model Name"
   Col = 11 'qty
   fsp1.Cell(flexcpText, Row, Col, Row, Col + 2) = "QTY"
   If arg_NOS_TF Then
      Col = 14 '1
      fsp1.Cell(flexcpText, Row, Col, Row, Col + 1) = "ML.1"
      Col = 17 '2
      fsp1.Cell(flexcpText, Row, Col, Row, Col + 1) = "ML.2"
      Col = 20 '3
      fsp1.Cell(flexcpText, Row, Col, Row, Col + 1) = "ML.3"
      Col = 23 '4
      fsp1.Cell(flexcpText, Row, Col, Row, Col + 1) = "ML.4"
      Col = 26 '5
      fsp1.Cell(flexcpText, Row, Col, Row, Col + 1) = "ML.5"
      Col = 29 '6
      fsp1.Cell(flexcpText, Row, Col, Row, Col + 1) = "ML.6"
      Col = 32 '7
      fsp1.Cell(flexcpText, Row, Col, Row, Col + 1) = "ML.7"
      Col = 35 '8
      fsp1.Cell(flexcpText, Row, Col, Row, Col + 1) = "ML.8"
      
   Else
      Col = 14
      strVal = ""
      For i = 0 To MAX_HH Step 1
         strVal = strVal & Space(6) & CStr(i + 1) & "H" & Space(7) '15
      Next
      fsp1.Cell(flexcpText, Row, Col, Row, fsp1.Cols - 2) = strVal
      fsp1.Cell(flexcpAlignment, Row, Col, Row, fsp1.Cols - 2) = 1
   End If
   Col = 1
   fsp1.Cell(flexcpFontSize, Row, Col, Row, fsp1.Cols - 2) = 7
   fsp1.MergeRow(Row) = True
   
   Row = 5
   Col = 0
   fsp1.RowHeight(Row) = 10
   fsp1.Cell(6, Row, Col, Row, fsp1.Cols - 1) = RGB(1, 1, 1)
      
   Row = 14
   Col = 0
   fsp1.RowHeight(Row) = 10
   fsp1.Cell(6, Row, Col, Row, fsp1.Cols - 1) = RGB(1, 1, 1)
   
   For i = 0 To 5 Step 1
      If arg_NOS_TF Then
         Row = 14
         Col = (i * 6) + 3
         fsp1.ColWidth(Col) = 10
         fsp1.Cell(6, Row, Col, fsp1.Rows - 1, Col) = RGB(1, 1, 1)
   
         Row = 15
         Col = Col + 1
         fsp1.Cell(flexcpText, Row, Col, Row, Col + 4) = "Mini Line " & CStr(i + 1)
      Else
         Row = 14
         Col = (i * 6) + 3
         fsp1.ColWidth(Col) = 0
      End If
   Next i
   If arg_NOS_TF Then
      Row = 15
      fsp1.RowHeight(Row) = 220
      fsp1.MergeRow(Row) = True
      
   Else
      Row = 14
      fsp1.RowHeight(Row) = 0
      Row = 15
      fsp1.RowHeight(Row) = 0
   End If
   Row = 14
   Col = 3
   fsp1.ColWidth(Col) = 10
   fsp1.Cell(6, Row, Col, fsp1.Rows - 1, Col) = RGB(1, 1, 1)
   
   Row = 16
   Col = 0
   fsp1.RowHeight(Row) = 20
   fsp1.Cell(6, Row, Col, Row, fsp1.Cols - 1) = RGB(1, 1, 1)
      
   For i = 0 To MAX_HH Step 1
      Row = (i * 6) + 17
      Col = 1
      fsp1.Cell(flexcpText, Row + 1, Col, Row + 1, Col) = CStr(i + 1)
      Col = 2
      fsp1.Cell(flexcpText, Row + 1, Col, Row + 1, Col) = "H"
      
      'Size
      Col = 3
      fsp1.RowHeight(Row) = 180
      fsp1.Cell(flexcpFontSize, Row, Col, Row, fsp1.Cols - 2) = 7
            
      'Seq
      Row = Row + 1
      fsp1.RowHeight(Row) = 250
      fsp1.Cell(flexcpFontSize, Row, Col, Row, fsp1.Cols - 2) = 10
      
      'line
      Row = Row + 1
      Col = 3
      fsp1.RowHeight(Row) = 10
      fsp1.Cell(6, Row, Col, Row, fsp1.Cols - 1) = RGB(1, 1, 1)
      
      'size
      Row = Row + 1
      Col = 4
      fsp1.RowHeight(Row) = 180
      fsp1.Cell(flexcpFontSize, Row, Col, Row, fsp1.Cols - 2) = 7
      
      'Seq
      Row = Row + 1
      fsp1.RowHeight(Row) = 250
      fsp1.Cell(flexcpFontSize, Row, Col, Row, fsp1.Cols - 2) = 10
      
      Row = Row + 1
      Col = 0
      fsp1.RowHeight(Row) = 20
      fsp1.Cell(6, Row, Col, Row, fsp1.Cols - 1) = RGB(1, 1, 1)
   Next i
   Row = 17
   Col = 1
   'fsp1.MergeCol(col) = True
   fsp1.Cell(flexcpAlignment, Row, Col, fsp1.Rows - 2, Col) = 7
   fsp1.Cell(flexcpFontSize, Row, Col, fsp1.Rows - 2, Col) = 10
   fsp1.Cell(flexcpFontBold, Row, Col, fsp1.Rows - 2, Col) = True
   
   Col = 2
   'fsp1.MergeCol(col) = True
   fsp1.Cell(flexcpAlignment, Row, Col, fsp1.Rows - 2, Col) = 1
   fsp1.Cell(flexcpFontSize, Row, Col, fsp1.Rows - 2, Col) = 10
   fsp1.Cell(flexcpFontBold, Row, Col, fsp1.Rows - 2, Col) = True
   
End Sub

Private Sub sbStyDsp(arg_arr As Variant, arg_NOS_TF As Boolean)
   Dim Row As Integer
   Dim Col As Integer
   Dim startCol As Integer
   Dim i As Integer
   Dim j As Integer
   Dim strVal As String
   
   
   If Not IsArray(arg_arr) Then
      Exit Sub
   End If
   
   If (UBound(arg_arr, 2) + 1) > 8 Then
      For i = 1 To (UBound(arg_arr, 2) + 1) - 8 Step 1
         fsp1.AddItem " " & vbTab & " ", 10
      Next
   End If
   
   Row = 6
   For i = 0 To UBound(arg_arr, 2) Step 1
       Col = 1 'style
       fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 3) = CStr(arg_arr(0, i))
       Col = 4 'po
       fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 2) = CStr(arg_arr(1, i))
       Col = 6 'model name
       fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 5) = CStr(arg_arr(2, i))
       Col = 11 'qty
       fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 2) = CStr(arg_arr(3, i)) & "prs"
       If arg_NOS_TF Then
          Col = 14 '1
          fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 1) = CStr(arg_arr(4, i))
          Col = 17 '2
          fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 1) = CStr(arg_arr(5, i))
          Col = 20 '3
          fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 1) = CStr(arg_arr(6, i))
          Col = 23 '4
          fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 1) = CStr(arg_arr(7, i))
          Col = 26 '5
          fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 1) = CStr(arg_arr(8, i))
          Col = 29 '6
          fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 1) = CStr(arg_arr(9, i))
          Col = 32 '7
          fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 1) = CStr(arg_arr(10, i))
          Col = 35 '8
          fsp1.Cell(flexcpText, Row + i, Col, Row + i, Col + 1) = CStr(arg_arr(11, i))
       Else
          Col = 14 '1H
          strVal = ""
          For j = 0 To MAX_HH Step 1
             If Mid(CStr(arg_arr(j + 4, i)), 1, 3) = "999" Then
                strVal = strVal & Space(15)
             Else
                strVal = strVal & Space(5) & arg_arr(j + 4, i) & Space(5 + 5 - Len(arg_arr(j + 4, i))) '15
             End If
          Next
          fsp1.Cell(flexcpText, Row + i, Col, Row + i, fsp1.Cols - 2) = strVal
          fsp1.Cell(flexcpAlignment, Row + i, Col, Row + i, fsp1.Cols - 2) = 1
       End If
       'col = 30 'S
       'fsp1.Cell(flexcpText, row + i, col, row + i, col + 2) = CStr(arg_arr(12, i))
       Col = 1
       fsp1.MergeRow(Row + i) = True
       fsp1.Cell(flexcpFontSize, Row + i, Col, Row + i, fsp1.Cols - 2) = 7
       
   Next
   fsp1.Cell(flexcpAlignment, 6, 6, Row + i, 11) = 1
         
End Sub

Private Sub sbPassDSP(arg_NOS_TF As Boolean)
   Dim SQL As String
   Dim strDIV As String
   Dim strYMD As String
   Dim strProc As String
   Dim strRstDiv As String
   Dim strPart As String
   Dim strLine As String
   Dim arrHEAD As Variant
   Dim arrSeq As Variant
   Dim strTODAY As String
   
   strDIV = fnCboValue(cboDiv)
   If strDIV = "" Then
      Exit Sub
   End If
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   strProc = fnCboValue(cboProc)
   If strProc = "" Then
      Exit Sub
   End If
   
   strRstDiv = fnCboValue(cboRstDiv)
   If strRstDiv = "" Then
      Exit Sub
   End If
   
   strPart = fnCboValue(cboComp)
   If strPart = "" Then
     Exit Sub
   End If
   
   strLine = fnCboValue(cboLine)
   If strLine = "" Then
     Exit Sub
   End If
   
   Call sbHeadPassDSP(arg_NOS_TF)
   
   SQL = ""
   SQL = SQL & "SELECT SUBSTR(A.STYLE_CD,1,6)||'-'||SUBSTR(A.STYLE_CD,7,3), "
   SQL = SQL & "       SUBSTR(A.PO_NO,5,4)||A.PO_TYPE, "
   SQL = SQL & "       FN_MM_STYNAME(A.STYLE_CD), "
   SQL = SQL & "       SUM(A.PS_QTY), "
   If arg_NOS_TF Then
      SQL = SQL & "    SUM(DECODE(A.MINI_LINE,1,A.PS_QTY,0)), "
      SQL = SQL & "    SUM(DECODE(A.MINI_LINE,2,A.PS_QTY,0)), "
      SQL = SQL & "    SUM(DECODE(A.MINI_LINE,3,A.PS_QTY,0)), "
      SQL = SQL & "    SUM(DECODE(A.MINI_LINE,4,A.PS_QTY,0)), "
      SQL = SQL & "    SUM(DECODE(A.MINI_LINE,5,A.PS_QTY,0)), "
      SQL = SQL & "    SUM(DECODE(A.MINI_LINE,6,A.PS_QTY,0)), "
      SQL = SQL & "    SUM(DECODE(A.MINI_LINE,7,A.PS_QTY,0)), "
      SQL = SQL & "    SUM(DECODE(A.MINI_LINE,8,A.PS_QTY,0)) "
   Else
      SQL = SQL & "    LTRIM(TO_CHAR(MIN(DECODE(A.ABC_ID,'1',A.PCARD_SEQ,999)))) ||'-'|| LTRIM(TO_CHAR(MAX(DECODE(A.ABC_ID,'1',A.PCARD_SEQ,0)))), "
      SQL = SQL & "    LTRIM(TO_CHAR(MIN(DECODE(A.ABC_ID,'2',A.PCARD_SEQ,999)))) ||'-'|| LTRIM(TO_CHAR(MAX(DECODE(A.ABC_ID,'2',A.PCARD_SEQ,0)))), "
      SQL = SQL & "    LTRIM(TO_CHAR(MIN(DECODE(A.ABC_ID,'3',A.PCARD_SEQ,999)))) ||'-'|| LTRIM(TO_CHAR(MAX(DECODE(A.ABC_ID,'3',A.PCARD_SEQ,0)))), "
      SQL = SQL & "    LTRIM(TO_CHAR(MIN(DECODE(A.ABC_ID,'4',A.PCARD_SEQ,999)))) ||'-'|| LTRIM(TO_CHAR(MAX(DECODE(A.ABC_ID,'4',A.PCARD_SEQ,0)))), "
      SQL = SQL & "    LTRIM(TO_CHAR(MIN(DECODE(A.ABC_ID,'5',A.PCARD_SEQ,999)))) ||'-'|| LTRIM(TO_CHAR(MAX(DECODE(A.ABC_ID,'5',A.PCARD_SEQ,0)))), "
      SQL = SQL & "    LTRIM(TO_CHAR(MIN(DECODE(A.ABC_ID,'6',A.PCARD_SEQ,999)))) ||'-'|| LTRIM(TO_CHAR(MAX(DECODE(A.ABC_ID,'6',A.PCARD_SEQ,0)))), "
      SQL = SQL & "    LTRIM(TO_CHAR(MIN(DECODE(A.ABC_ID,'7',A.PCARD_SEQ,999)))) ||'-'|| LTRIM(TO_CHAR(MAX(DECODE(A.ABC_ID,'7',A.PCARD_SEQ,0)))), "
      SQL = SQL & "    LTRIM(TO_CHAR(MIN(DECODE(A.ABC_ID,'8',A.PCARD_SEQ,999)))) ||'-'|| LTRIM(TO_CHAR(MAX(DECODE(A.ABC_ID,'8',A.PCARD_SEQ,0)))), "
      SQL = SQL & "    LTRIM(TO_CHAR(MIN(DECODE(A.ABC_ID,'9',A.PCARD_SEQ,999)))) ||'-'|| LTRIM(TO_CHAR(MAX(DECODE(A.ABC_ID,'9',A.PCARD_SEQ,0)))) "
   End If
   SQL = SQL & "  FROM PS_PCARD A "
   SQL = SQL & " WHERE A.DIV         = '" & strDIV & "' "
   SQL = SQL & "   AND A.OP_CD     LIKE '" & IIf(strPart = "FS", "OS", IIf(strPart = "FG", "UP", strPart)) & "%' "
   SQL = SQL & "   AND A.ASY_YMD      = '" & strYMD & "' "
   SQL = SQL & "   AND A.RES_CD = '" & strLine & "' "
   SQL = SQL & "   AND A.SEMI_GOOD_CD = '" & IIf(strPart = "FS", "OS", IIf(strPart = "FG", "UP", strPart)) & "' "
   If Mid(strProc, 1, 2) = "UP" Then
      SQL = SQL & "AND A.MM_AREA        = 'UPC" & Mid(strProc, 4, 1) & "' "
   End If
   SQL = SQL & " GROUP BY A.STYLE_CD, A.PO_NO, A.PO_TYPE "
   
   arrHEAD = fnGetOraData(SQL)
   If IsArray(arrHEAD) Then
      Call sbStyDsp(arrHEAD, arg_NOS_TF)
   Else
      If arrHEAD = "" Then
         Call sbMsgDsp("Can not find plan sequence! STEP1", 4)
      Else
         Call sbMsgDsp(arrHEAD, 4)
      End If
      Exit Sub
   End If
   
   strTODAY = Format(frmMO01VJ.dtpYMD.Value, "YYYYMMDD")
   
   SQL = ""
   SQL = SQL & " SELECT A.MINI_LINE, A.ABC_ID, A.PCARD_SEQ, A.CS_SIZE, "
   SQL = SQL & "        DECODE(B." & strRstDiv & "_SCN_YMD,TO_CHAR(NULL),'N','Y'), "
   SQL = SQL & "        DECODE(B." & strRstDiv & "_SCN_YMD,'" & strTODAY & "','" & strTODAY & "','X') "
   SQL = SQL & "   FROM PS_PCARD A, PS_PCARD_SEQ B "
   SQL = SQL & "  WHERE A.DIV          = '" & strDIV & "' "
   SQL = SQL & "    AND A.OP_CD     LIKE '" & IIf(strPart = "FS", "OS", IIf(strPart = "FG", "UP", strPart)) & "%' "
   SQL = SQL & "    AND A.ASY_YMD      = '" & strYMD & "' "
   SQL = SQL & "    AND A.RES_CD = '" & strLine & "' "
   SQL = SQL & "    AND A.SEMI_GOOD_CD = '" & IIf(strPart = "FS", "OS", IIf(strPart = "FG", "UP", strPart)) & "' "
   If Mid(strProc, 1, 2) = "UP" Then
      SQL = SQL & " AND A.MM_AREA        = 'UPC" & Mid(strProc, 4, 1) & "' "
   End If
   SQL = SQL & "    AND A.PCARD_ID = B.PCARD_ID "
   SQL = SQL & "    AND B.OP_CD = '" & Mid(strProc, 1, 3) & "' "
   
   arrSeq = fnGetOraData(SQL)
   If IsArray(arrSeq) Then
      Call sbSeqDsp(arrSeq, arg_NOS_TF)
   Else
      If arrSeq = "" Then
         Call sbMsgDsp("Can not find plan sequence! STEP2", 4)
      Else
         Call sbMsgDsp(arrSeq, 4)
      End If
      Exit Sub
   End If
   
End Sub

Private Sub sbSeqDsp(arrSeq As Variant, arg_NOS_TF As Boolean)
   Dim i As Integer
   Dim j As Integer
   Dim SEQ As Integer
   Dim rowFrom As Integer
   Dim Row As Integer
   Dim colFrom As Integer
   Dim Col As Integer
   
   '0:MINI_LINE, 1:ABC_ID, 2:PCARD_SEQ, 3:CS_SIZE 4:YN
   cmdPrint.Enabled = True
   For i = 0 To UBound(arrSeq, 2) Step 1
      
      rowFrom = ((CInt(arrSeq(1, i)) - 1) * 6) + 17
      SEQ = CInt(arrSeq(2, i))
      If arg_NOS_TF Then
         colFrom = ((CInt(arrSeq(0, i)) - 1) * 6) + 4
         If SEQ > 5 Then
            Row = rowFrom + 3
            Col = colFrom + SEQ - 1 - 5
         Else
            Row = rowFrom
            Col = colFrom + SEQ - 1
         End If
      Else
         colFrom = 4
         If SEQ > 30 Then
            Row = rowFrom + 3
            Col = colFrom + SEQ - 1 - 30 + Int((SEQ - 1 - 30) / 5)
         Else
            Row = rowFrom
            Col = colFrom + SEQ - 1 + Int((SEQ - 1) / 5)
         End If
      End If
      If Col > (fsp1.Cols - 1) Then
        fsp1.Cols = Col + 1
        cmdPrint.Enabled = False
      End If
      
      fsp1.TextMatrix(Row, Col) = CStr(arrSeq(3, i))
      fsp1.TextMatrix(Row + 1, Col) = CStr(arrSeq(2, i))
      If CStr(arrSeq(4, i)) = "Y" Then
         If CStr(arrSeq(5, i)) = "X" Then
            fsp1.Cell(flexcpBackColor, Row, Col, Row + 1, Col) = RGB(180, 180, 180)
         Else
            fsp1.Cell(flexcpBackColor, Row, Col, Row + 1, Col) = vbGreen
         End If
      Else
         fsp1.Cell(flexcpBackColor, Row, Col, Row + 1, Col) = RGB(255, 255, 255)
      End If
      
   Next i
      
End Sub

Private Sub cmdPrint_Click()
   fsp1.PrintGrid "", True, 2, 80, 100
End Sub

Private Sub cmdSearch_Click()
   If fnCboValue(cboLine) = "" Then
      Exit Sub
   End If
   If CInt(fnCboValue(cboLine)) > 6 Then
      Call sbPassDSP(True)
   Else
      Call sbPassDSP(False)
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
      
   SQL = " SELECT '1','NOR' FROM DUAL UNION ALL SELECT '2','DEF' FROM DUAL "
   strRtn = fnSetCbo(cboDiv, SQL)
   Call sbLetCbo(cboDiv, "1")
   
   'Getting Process
   SQL = " SELECT OP, NM FROM ("
   SQL = SQL & "SELECT DECODE(SUBSTR(OP_CD,1,2), 'UP', OP_CD||'1', OP_CD) AS OP, "
   SQL = SQL & "       DECODE(SUBSTR(OP_CD,1,2), 'UP', OP_NAME||' 1', OP_NAME) AS NM "
   SQL = SQL & "  FROM PB_OPCD "
   SQL = SQL & " WHERE I_SCN_RESULT_YN = 'Y' "
   SQL = SQL & "    OR T_SCN_RESULT_YN = 'Y' "
   SQL = SQL & "    OR P_SCN_RESULT_YN = 'Y' "
   SQL = SQL & "    OR O_SCN_RESULT_YN = 'Y' "
   SQL = SQL & " UNION ALL "
   SQL = SQL & "SELECT 'UPC2', 'Cutting 2' FROM DUAL "
   SQL = SQL & " UNION ALL "
   SQL = SQL & "SELECT 'UPS2', 'Stitching 2' FROM DUAL "
   SQL = SQL & ") "
   SQL = SQL & " ORDER BY OP "
   strRtn = fnSetCbo(cboProc, SQL)
      
   Call sbHeadPassDSP(False)
   
End Sub

Private Sub Form_Resize()
  fsp1.Width = Me.Width - 200
  fsp1.Height = Me.Height - 2000
End Sub

Private Sub Form_Unload(Cancel As Integer)
   Call frmMO01VJ.sbDspData(Format(frmMO01VJ.dtpYMD.Value, "YYYYMMDD"), "ALL")
   If frmMO01VJ.chkAutoScan.Value = 1 Then
      frmMO01VJ.tmrScan.Enabled = True
   End If
End Sub

Private Sub fsp1_DblClick()
   Dim SQL As String
   Dim strDIV As String
   Dim strYMD As String
   Dim strProc As String
   Dim strRstDiv As String
   Dim strPart As String
   Dim strLine As String
   Dim tline As String
   Dim strTmp As String
   Dim arrID As Variant
   Dim varSQL As Variant
   Dim strRtn As String
   Dim intRTN As Integer
   Dim strMINI As String
   Dim strAbcID As String
   Dim strSEQ As String
   
   strDIV = fnCboValue(cboDiv)
   If strDIV = "" Then
      Exit Sub
   End If
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   strProc = fnCboValue(cboProc)
   If strProc = "" Then
      Exit Sub
   End If
   
   strRstDiv = fnCboValue(cboRstDiv)
   If strRstDiv = "" Then
      Exit Sub
   End If
   
   strPart = fnCboValue(cboComp)
   If strPart = "" Then
     Exit Sub
   End If
   
   strLine = fnCboValue(cboLine)
   If strLine = "" Then
     Exit Sub
   End If
   
   If CInt(strLine) > 6 Then
      strMINI = fsp1.TextMatrix(15, fsp1.Col)
      tline = strLine & "/" & strMINI
   Else
      strMINI = ""
      tline = strLine
   End If
   
   
   strSEQ = fsp1.Text
   If CInt(strSEQ) <= 30 Then
      strAbcID = fsp1.TextMatrix(fsp1.Row, 1)
   Else
      strAbcID = fsp1.TextMatrix(fsp1.Row - 3, 1)
   End If
   
   
   strTmp = strYMD & ":" & strProc & ":" & strRstDiv & ":" & strPart & ":" & tline
   
   MsgBox "COL:" & fsp1.Col & ", ROW:" & fsp1.Row & "=> " & strTmp & " HH:" & strAbcID & ", SEQ:" & strSEQ
         
   intRTN = MsgBox("DO you want to save data?", vbYesNo, "Applying")
   If intRTN = 6 Then
   Else
      Exit Sub
   End If
   
   SQL = ""
   SQL = SQL & " SELECT NVL(MAX(PCARD_ID),0) "
   SQL = SQL & "  FROM PS_PCARD A "
   SQL = SQL & " WHERE A.DIV          = '" & strDIV & "' "
   SQL = SQL & "   AND A.OP_CD     LIKE '" & IIf(strPart = "FS", "OS", IIf(strPart = "FG", "UP", strPart)) & "%' "
   SQL = SQL & "   AND A.ASY_YMD      = '" & strYMD & "' "
   SQL = SQL & "   AND A.RES_CD       = '" & strLine & "' "
   SQL = SQL & "   AND A.SEMI_GOOD_CD = '" & IIf(strPart = "FS", "OS", IIf(strPart = "FG", "UP", strPart)) & "' "
   If Mid(strProc, 1, 2) = "UP" Then
      SQL = SQL & "AND A.MM_AREA        = 'UPC" & Mid(strProc, 4, 1) & "' "
   End If
   If CInt(strLine) > 6 Then
      SQL = SQL & "AND A.MINI_LINE      = '" & Right(strMINI, 1) & "' "
   End If
   SQL = SQL & "AND A.ABC_ID      = '" & strAbcID & "' "
   SQL = SQL & "AND A.PCARD_SEQ   = " & strSEQ & " "
   
   Screen.MousePointer = 11
   arrID = fnGetOraData(SQL)
   Screen.MousePointer = 1
   
   If IsArray(arrID) Then
      ReDim varSQL(0)
      varSQL(0) = " UPDATE PS_PCARD_SEQ "
      
      If fsp1.Cell(flexcpBackColor, fsp1.Row, fsp1.Col, fsp1.Row + 1, fsp1.Col) = RGB(180, 180, 180) Then
         varSQL(0) = varSQL(0) & "  SET " & Trim(strRstDiv) & "_SCN_YMD = TO_CHAR(NULL), "
         varSQL(0) = varSQL(0) & "      " & Trim(strRstDiv) & "_SCN_HMS = TO_CHAR(NULL) "
      Else
         varSQL(0) = varSQL(0) & "  SET " & Trim(strRstDiv) & "_SCN_YMD = TO_CHAR(SYSDATE,'YYYYMMDD'), "
         varSQL(0) = varSQL(0) & "      " & Trim(strRstDiv) & "_SCN_HMS = TO_CHAR(SYSDATE,'HHMMSS') "
      End If
      
      varSQL(0) = varSQL(0) & " WHERE PCARD_ID = " & CStr(arrID(0, 0)) & " "
      varSQL(0) = varSQL(0) & "   AND OP_CD    = '" & Mid(strProc, 1, 3) & "' "
      
      Screen.MousePointer = 11
      strRtn = fnExecOraSQL(varSQL)
      Screen.MousePointer = 1
      If strRtn = "" Then
         If fsp1.Cell(flexcpBackColor, fsp1.Row, fsp1.Col, fsp1.Row + 1, fsp1.Col) = RGB(180, 180, 180) Then
            fsp1.Cell(flexcpBackColor, fsp1.Row, fsp1.Col, fsp1.Row + 1, fsp1.Col) = RGB(255, 255, 255)
         Else
            fsp1.Cell(flexcpBackColor, fsp1.Row, fsp1.Col, fsp1.Row + 1, fsp1.Col) = RGB(180, 180, 180)
         End If
         MsgBox "SAVED!"
         
      Else
         MsgBox strRtn
      End If
   Else
      If arrID = "" Then
         Call sbMsgDsp("Can not find PCARD_ID", 4)
      Else
         Call sbMsgDsp(arrID, 4)
      End If
      Exit Sub
   End If
End Sub

Private Sub Image1_DblClick()
'cndSave.DefaultExt = "*.txt"
      
   cndSave.ShowSave
   If cndSave.FileName = "" Then
   Else
      On Error GoTo err_rtn
      fsp1.SaveGrid cndSave.FileName, flexFileTabText, True
   End If
   Exit Sub
err_rtn:
   Call sbMsgDsp("Can not file open!", gMsgDspSec)
End Sub

Private Sub SSCommand1_Click()
   Unload frmMO12VJ
End Sub

Private Sub cboProc_Click()
   Call sbSetCboRstDiv(fnCboValue(cboProc))
   cboComp.Clear
   cboLine.Clear
End Sub

Private Sub cboRstDiv_Click()
   Call sbSetCboComp(fnCboValue(cboProc), fnCboValue(cboRstDiv))
   cboLine.Clear
End Sub

Private Sub cboComp_Click()
   Call sbSetCboLine(fnCboValue(cboProc), fnCboValue(cboRstDiv))
End Sub

Private Sub tmr1_Timer()
   sbrStatus.Panels.Item(1).Text = ""
   tmr1.Enabled = False
End Sub

