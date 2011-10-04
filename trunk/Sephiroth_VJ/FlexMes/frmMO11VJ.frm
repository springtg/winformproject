VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO11VJ 
   Caption         =   "MES-MO11VJ"
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
   Begin VB.ComboBox cboComp 
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
      Left            =   10410
      Style           =   2  '드롭다운 목록
      TabIndex        =   16
      Top             =   675
      Width           =   1380
   End
   Begin VB.ComboBox cboProc 
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
      Left            =   3465
      Style           =   2  '드롭다운 목록
      TabIndex        =   10
      Top             =   675
      Width           =   1995
   End
   Begin VB.ComboBox cboSec 
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
      Left            =   6465
      Style           =   2  '드롭다운 목록
      TabIndex        =   9
      Top             =   675
      Width           =   3075
   End
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   4725
      Top             =   435
   End
   Begin VSFlex7LCtl.VSFlexGrid fspWIP 
      Height          =   5250
      Left            =   60
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
         TabIndex        =   7
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
         TabIndex        =   8
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
         Caption         =   "Inventory Status"
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
         Caption         =   "Inventory Status"
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
         Picture         =   "frmMO11VJ.frx":0000
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
      Left            =   720
      TabIndex        =   11
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
      Format          =   76808193
      CurrentDate     =   37956
      MinDate         =   37956
   End
   Begin VB.Label Label4 
      Caption         =   "Comp."
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
      Left            =   9705
      TabIndex        =   15
      Top             =   720
      Width           =   675
   End
   Begin VB.Label Label3 
      Caption         =   "Section"
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
      Left            =   5610
      TabIndex        =   14
      Top             =   720
      Width           =   930
   End
   Begin VB.Label Label2 
      Caption         =   "Process"
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
      Left            =   2505
      TabIndex        =   13
      Top             =   720
      Width           =   930
   End
   Begin VB.Label Label1 
      Caption         =   "Date"
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
      TabIndex        =   12
      Top             =   720
      Width           =   885
   End
End
Attribute VB_Name = "frmMO11VJ"
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
   Dim vOldWidth1 As Integer
   Dim vOldWidth2 As Integer
   Dim vOldWidth3 As Integer
   Dim i As Integer
   
   Dim strYMD As String
   Dim lngRTN As Long
   Dim buffer As String
   Dim PCname As String
   Dim varVAL As Variant
   Dim strSEC As String
   Dim sCOMP As String
   
   buffer = Space(32)
   lngRTN = GetComputerName(buffer, 32)
   PCname = fnRemoveNUL(buffer)
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   If Trim(fnCboValue(cboProc)) = "" Then
      Exit Sub
   End If
   varVAL = Split(fnCboValue(cboProc), ".")
   
   strSEC = fnCboValue(cboSec)
   If Trim(strSEC) = "" Then
      Exit Sub
   End If
   
   sCOMP = fnCboValue(cboComp)
   If Trim(sCOMP) = "" Then
      Exit Sub
   End If
   
   fspWIP.AddItem "" & vbTab & "", 0
   
   fspWIP.Cell(flexcpText, 0, 0, 0, 2) = "Inventory Status"
   fspWIP.Cell(flexcpFontSize, 0, 0, 0, 2) = 12
   fspWIP.Cell(flexcpFontBold, 0, 0, 0, 2) = True
   'fspWIP.Cell(flexcpFontUnderline, 0, 0, 0, 2) = True
   fspWIP.Cell(flexcpText, 0, 3, 0, fspWIP.Cols - 1) = "Date: " & Format(dtpYMD.Value, "YYYY/MM/DD") & Space(4) & _
                                                       "Process: " & varVAL(0) & Space(4) & _
                                                       "Section: " & strSEC & Space(4) & _
                                                       "Component: " & sCOMP & Space(4) & _
                                                       "Print Date: " & Format(Now, "YYYY/MM/DD HH:MM:SS")
   fspWIP.Cell(flexcpAlignment, 0, 3, 0, fspWIP.Cols - 1) = 8
   fspWIP.Cell(flexcpBackColor, 0, 0, 0, fspWIP.Cols - 1) = vbWhite
   
   fspWIP.MergeRow(0) = True
   fspWIP.RowHeightMax = 900
   fspWIP.RowHeightMax = 300
   fspWIP.RowHeight(0) = 900
   
   vOldWidth1 = fspWIP.ColWidth(1)
   vOldWidth2 = fspWIP.ColWidth(2)
   vOldWidth3 = fspWIP.ColWidth(3)
   
   fspWIP.ColWidth(1) = vOldWidth1 + 1000
   fspWIP.ColWidth(2) = vOldWidth2 + 300
   For i = 3 To fspWIP.Cols - 1 Step 1
      fspWIP.ColWidth(i) = vOldWidth3 + 60
   Next i
   fspWIP.FixedRows = 4
      
   
   fspWIP.PrintGrid "", True, 2, 150, 100
   
   fspWIP.ColWidth(1) = vOldWidth1
   fspWIP.ColWidth(2) = vOldWidth2
   For i = 3 To fspWIP.Cols - 1 Step 1
      fspWIP.ColWidth(i) = vOldWidth3
   Next i
   fspWIP.RemoveItem 0
   
   fspWIP.FixedRows = 3
End Sub

Private Sub cmdSearch_Click()
   Call sbWipDsp
End Sub

Private Sub Form_Load()
   Dim SQL As String
   Dim strRtn As String
   
   lbTitle(0).Caption = "Inventory Status"
   lbTitle(1).Caption = lbTitle(0).Caption
   
   Me.Left = 0
   Me.Top = 0
   vWidth = 600
   
   dtpYMD.Value = frmMO01VJ.dtpYMD.Value
   
   SQL = " SELECT DCODE||'.'||REMARK1, CD_NAME FROM CM_CODE WHERE MCODE = 'MP07' AND DCODE <> '0000' ORDER BY DCODE "
   strRtn = fnSetCbo(cboProc, SQL)
   
   'Lv_SIZE = 4
   'vGEN_COUNT = 3
   vSIZE_COUNT = 31
      
   Call sbHeadWipDsp
   
   Call sbHeadSizeDSP("ME")
   
   'Getting Process
   
   
End Sub

Private Sub cboProc_Click()
   Dim varVAL As Variant
   Dim varSec As Variant
   Dim SQL As String
   Dim i As Integer
   Dim strIN As String
   Dim strRtn As String
   
   varVAL = Split(fnCboValue(cboProc), ".")
   varSec = Split(varVAL(1), "/")
   strIN = "('"
   For i = 0 To UBound(varSec) Step 1
      strIN = strIN & varSec(i) & IIf(i = UBound(varSec), "')", "','")
   Next i
   
   SQL = " SELECT DCODE, CD_NAME FROM CM_CODE WHERE MCODE = 'MP06' AND DCODE IN " & strIN & " ORDER BY CD_NAME "
   Screen.MousePointer = 11
   strRtn = fnSetCbo(cboSec, SQL)
   Screen.MousePointer = 1
   If strRtn <> "" Then
      MsgBox strRtn
   End If
End Sub

Private Sub sbSetCboComp(arg_OPCD As String, arg_RstDiv As String)
   Dim SQL As String
   Dim strRtn As String
   If Mid(arg_OPCD, 1, 3) = "FGW" Then
      cboComp.Clear
      cboComp.AddItem "F/N Goods" + Space(51) & Chr$(27) & "FG"
      cboComp.AddItem Space(60) & Chr$(27) & ""
   ElseIf Mid(arg_OPCD, 1, 3) = "FGA" And arg_RstDiv = "P" Then
      cboComp.Clear
      cboComp.AddItem "F/N Goods" + Space(51) & Chr$(27) & "FG"
      cboComp.AddItem Space(60) & Chr$(27) & ""
   Else
      SQL = ""
      SQL = SQL & "SELECT SEMI_GOOD_CD, MAX(FN_MM_CDNAME('PA01',SEMI_GOOD_CD)) "
      SQL = SQL & "  FROM MP_APPLY "
      SQL = SQL & " WHERE OP_CD LIKE '" & Mid(arg_OPCD, 1, 3) & "%' "
      If arg_OPCD = "PUS" Or arg_OPCD = "SPP" Then
         SQL = SQL & "   AND RST_DIV LIKE 'P%' "
      Else
         SQL = SQL & "   AND RST_DIV LIKE '" & arg_RstDiv & "%' "
      End If
      SQL = SQL & " GROUP BY SEMI_GOOD_CD "
      SQL = SQL & " ORDER BY 1 "
      
      strRtn = fnSetCbo(cboComp, SQL)
   End If

End Sub

Private Sub cboSec_Click()
   Dim varVAL As Variant
     
   varVAL = Split(fnCboValue(cboProc), ".")
   Call sbSetCboComp(CStr(varVAL(0)), IIf(CStr(varVAL(0)) = "UPS", "P", Mid(fnCboValue(cboSec), 1, 1)))
  
   'If Trim(fnCboValue(cboProc)) <> "" And Trim(fnCboValue(cboComp)) <> "" Then
   '   Call cmdSearch_Click
   'End If
End Sub

Private Sub sbWipDsp()
   Dim SQL As String
   Dim arrDATA As Variant
   Dim vFixedCols As Integer
   Dim i As Integer
   Dim EXESQL As String
   Dim strRtn As String
   
   Dim strYMD As String
   Dim lngRTN As Long
   Dim buffer As String
   Dim PCname As String
   Dim varVAL As Variant
   Dim strSEC As String
   Dim sCOMP As String
   
   buffer = Space(32)
   lngRTN = GetComputerName(buffer, 32)
   PCname = fnRemoveNUL(buffer)
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   If Trim(fnCboValue(cboProc)) = "" Then
      Exit Sub
   End If
   varVAL = Split(fnCboValue(cboProc), ".")
   
   strSEC = fnCboValue(cboSec)
   If Trim(strSEC) = "" Then
      Exit Sub
   End If
   
   sCOMP = fnCboValue(cboComp)
   
   If Trim(sCOMP) = "" Then
      Exit Sub
   End If
   
   EXESQL = "BEGIN SP_MM_IVTR('" & strYMD & "','" & varVAL(0) & "','" & strSEC & "','" & PCname & "'); END; "
   
   Screen.MousePointer = 11
   strRtn = fnExecOraSQL2(EXESQL)
   Screen.MousePointer = 1
   
   If strRtn <> "" Then
      Exit Sub
   End If
   
   Call sbHeadWipDsp
      
   Call sbHeadSizeDSP("ME")
         
   SQL = ""
   SQL = SQL & " SELECT ASSY_LINE, MAX(FN_MODEL2(STYLE_CD)), SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), "
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'B',PRS_QTY,0)),"
   
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'I',PRS_QTY,0) - DECODE(TOT_DIV,'I',NVL(TODAY_QTY,0),0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'I',NVL(TODAY_QTY,0),0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'RI',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'WI',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'A',DECODE(SIGN(PRS_QTY),1,PRS_QTY,0),0)),"
   
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'O',PRS_QTY,0) - DECODE(TOT_DIV,'O',NVL(TODAY_QTY,0),0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'O',NVL(TODAY_QTY,0),0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'D',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'RO',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'WO',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'EL',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'EG',PRS_QTY,0)),"
   
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'A',DECODE(SIGN(PRS_QTY),-1,-PRS_QTY,0),0)),"
   
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'B',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'I',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'RI',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'WI',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'A',PRS_QTY,0))"
   
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'O',PRS_QTY,0))"
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'D',PRS_QTY,0))"
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'RO',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'WO',PRS_QTY,0))"
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'EL',PRS_QTY,0))"
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'EG',PRS_QTY,0))"
     
   
   SQL = SQL & " FROM MP_STK_TMP3 "
   SQL = SQL & " WHERE USR = '" & PCname & "' "
   SQL = SQL & " AND PROC = '" & varVAL(0) & "' "
   SQL = SQL & " AND IVTR_DIV = '" & strSEC & "' "
   SQL = SQL & " AND SEMI_GOOD_CD = '" & sCOMP & "'"
   SQL = SQL & " GROUP BY ASSY_LINE, STYLE_CD"
   SQL = SQL & "  ORDER BY 1, 3 "
   
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If IsArray(arrDATA) Then
      
      vFixedCols = fspWIP.FixedCols
      fspWIP.FixedCols = 0
      fspWIP.LoadArray arrDATA
      fspWIP.FixedCols = vFixedCols
      fspWIP.FrozenCols = 0
      
   Else
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   'For i = 3 To fspWIP.Cols - 1 Step 1
   '   If UCase(Right(fspWIP.TextMatrix(1, i), 3)) = "BAL" Then
   '      fspWIP.Cell(flexcpBackColor, fspWIP.FixedRows, i, fspWIP.Rows - 1, i) = RGB(220, 220, 220)
   '   End If
   'Next i
      
   'fspWIP.Cell(flexcpBackColor, fspLine.Rows - 1, 3, fspLine.Rows - 1, fspLine.Cols - 1) = vbYellow
   For i = 3 To fspWIP.Cols - 1 Step 1
      fspWIP.Subtotal flexSTSum, 0, i, "######", vbYellow, , , ""
   Next i
   
   For i = 3 To fspWIP.Cols - 1 Step 1
      fspWIP.Subtotal flexSTSum, -1, i, "######", vbYellow, , , ""
   Next i
   
   fspWIP.Cell(flexcpAlignment, fspWIP.FixedRows, 3, fspWIP.Rows - 1, fspWIP.Cols - 1) = 7
   
   For i = fspWIP.FixedRows To fspWIP.Rows - 1 Step 1
      If Mid(fspWIP.TextMatrix(i, 0), 1, 1) = "T" Or Mid(fspWIP.TextMatrix(i, 0), 1, 1) = "G" Then
         fspWIP.TextMatrix(i, 1) = fspWIP.TextMatrix(i, 0)
         fspWIP.TextMatrix(i, 0) = ""
      End If
   Next
   
End Sub

Private Sub sbHeadWipDsp()
   Dim i As Integer
   
   fspWIP.FontSize = 8
   fspWIP.Clear
      
   fspWIP.Rows = 3
   fspWIP.Cols = 16 + 2
      
   fspWIP.MergeCells = flexMergeFixedOnly
     
   fspWIP.FixedCols = 3
   fspWIP.FrozenCols = 0
   fspWIP.FixedRows = 3
   
   fspWIP.Cell(flexcpText, 0, 0, 2, 0) = "Ln"
   fspWIP.Cell(flexcpText, 0, 1, 2, 1) = "Model Name"
   fspWIP.Cell(flexcpText, 0, 2, 2, 2) = "Style"
   fspWIP.Cell(flexcpText, 0, 3, 2, 3) = "Base"
   
   fspWIP.Cell(flexcpText, 0, 4, 0, 8) = "Incoming"
   fspWIP.Cell(flexcpText, 1, 4, 1, 5) = "Normal"
   fspWIP.Cell(flexcpText, 2, 4, 2, 4) = "Before"
   fspWIP.Cell(flexcpText, 2, 5, 2, 5) = "Today"
   fspWIP.Cell(flexcpText, 1, 6, 2, 6) = "Return"
   fspWIP.Cell(flexcpText, 1, 7, 2, 7) = "Exch-" & Chr$(13) & "ange"
   fspWIP.Cell(flexcpText, 1, 8, 2, 8) = "Un-" & Chr$(13) & "known"
   
   fspWIP.Cell(flexcpText, 0, 9, 0, 16) = "Outgoing"
   fspWIP.Cell(flexcpText, 1, 9, 1, 10) = "Normal"
   fspWIP.Cell(flexcpText, 2, 9, 2, 9) = "Before"
   fspWIP.Cell(flexcpText, 2, 10, 2, 10) = "Today"
   fspWIP.Cell(flexcpText, 1, 11, 2, 11) = "Defect"
   fspWIP.Cell(flexcpText, 1, 12, 2, 12) = "Return"
   fspWIP.Cell(flexcpText, 1, 13, 2, 13) = "Exch-" & Chr$(13) & "ange"
   fspWIP.Cell(flexcpText, 1, 14, 2, 14) = "Lab"
   fspWIP.Cell(flexcpText, 1, 15, 2, 15) = "Gift"
   fspWIP.Cell(flexcpText, 1, 16, 2, 16) = "Un-" & Chr$(13) & "known"
   
   fspWIP.Cell(flexcpText, 0, 17, 2, 17) = "Inven-" & Chr$(13) & "tory"
   
   fspWIP.MergeCol(0) = True
   fspWIP.MergeCol(1) = True
   fspWIP.MergeCol(2) = True
   fspWIP.MergeCol(3) = True
   
   fspWIP.MergeCol(6) = True
   fspWIP.MergeCol(7) = True
   fspWIP.MergeCol(8) = True
   
   fspWIP.MergeCol(11) = True
   fspWIP.MergeCol(12) = True
   fspWIP.MergeCol(13) = True
   fspWIP.MergeCol(14) = True
   fspWIP.MergeCol(15) = True
   fspWIP.MergeCol(16) = True
   
   fspWIP.MergeCol(17) = True
   
   fspWIP.MergeRow(0) = True
   fspWIP.MergeRow(1) = True
   
   fspWIP.ColWidth(0) = 200
   fspWIP.ColWidth(1) = 1300
   fspWIP.ColWidth(2) = 980
      
   fspWIP.RowHeightMax = "220"
   fspWIP.RowHeightMin = "220"
   
   fspWIP.Cell(flexcpAlignment, 0, 0, 2, fspWIP.Cols - 1) = 4
   
   For i = 3 To fspWIP.Cols - 1 Step 1
      fspWIP.ColWidth(i) = vWidth
   Next i
   
   fspWIP.ColWidth(3) = 700
   fspWIP.ColWidth(4) = 650
   fspWIP.ColWidth(8) = 650
   fspWIP.ColWidth(17) = 650
   
   fspWIP.Rows = fspWIP.FixedRows
   
End Sub

Private Sub Form_Unload(Cancel As Integer)
   Call frmMO01VJ.sbDspData(Format(frmMO01VJ.dtpYMD.Value, "YYYYMMDD"), "ALL")
   If frmMO01VJ.chkAutoScan.Value = 1 Then
      frmMO01VJ.tmrScan.Enabled = True
   End If
End Sub

Private Sub fspWIP_Click()
'   Dim varArr As Variant
'   Dim Row As Long
'
'   Row = fspWIP.Row
'   If Row = fspWIP.Rows - 1 Then
'      Exit Sub
'   End If
'
'   ReDim varArr(1) As String
'
'   varArr(0) = fspWIP.TextMatrix(Row, 0)                   'ASSY_LINE
'   varArr(1) = fspWIP.TextMatrix(Row, 2)                   'STYLE_CD

   If fspWIP.Row < fspWIP.FixedRows Then
      Exit Sub
   End If
   If Mid(fspWIP.TextMatrix(fspWIP.Row, 1), 1, 1) = "T" Or Mid(fspWIP.TextMatrix(fspWIP.Row, 1), 1, 1) = "G" Then
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
   Dim lngRTN As Long
   Dim buffer As String
   Dim PCname As String
   Dim varVAL As Variant
   Dim strSEC As String
   Dim strLine As String
   Dim strSTY As String
   Dim sCOMP As String
   
   buffer = Space(32)
   lngRTN = GetComputerName(buffer, 32)
   PCname = fnRemoveNUL(buffer)
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   If Trim(fnCboValue(cboProc)) = "" Then
      Exit Sub
   End If
   varVAL = Split(fnCboValue(cboProc), ".")
   
   strSEC = fnCboValue(cboSec)
   If Trim(strSEC) = "" Then
      Exit Sub
   End If
      
   sCOMP = fnCboValue(cboComp)
   
   If Trim(sCOMP) = "" Then
      Exit Sub
   End If
      
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   strLine = fspWIP.TextMatrix(fspWIP.Row, 0)
   strSTY = Replace(fspWIP.TextMatrix(fspWIP.Row, 2), "-", "")
   
   Call sbHeadSizeDSP(Mid(fspWIP.TextMatrix(fspWIP.Row, 1), 1, 2))
      
   SQL = ""
   SQL = SQL & " SELECT CS_SIZE,"
   
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'B',PRS_QTY,0)),"
   
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'I',PRS_QTY,0) - DECODE(TOT_DIV,'I',NVL(TODAY_QTY,0),0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'I',NVL(TODAY_QTY,0),0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'RI',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'WI',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'A',DECODE(SIGN(PRS_QTY),1,PRS_QTY,0),0)),"
   
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'O',PRS_QTY,0) - DECODE(TOT_DIV,'O',NVL(TODAY_QTY,0),0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'O',NVL(TODAY_QTY,0),0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'D',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'RO',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'WO',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'EL',PRS_QTY,0)),"
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'EG',PRS_QTY,0)),"
   
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'A',DECODE(SIGN(PRS_QTY),-1,PRS_QTY,0),0)),"
   
   SQL = SQL & "     SUM(DECODE(TOT_DIV,'B',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'I',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'RI',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'WI',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'A',PRS_QTY,0))"
   
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'O',PRS_QTY,0))"
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'D',PRS_QTY,0))"
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'RO',PRS_QTY,0))"
   SQL = SQL & "   + SUM(DECODE(TOT_DIV,'WO',PRS_QTY,0))"
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'EL',PRS_QTY,0))"
   SQL = SQL & "   - SUM(DECODE(TOT_DIV,'EG',PRS_QTY,0))"
      
   SQL = SQL & " FROM MP_STK_TMP3 "
   SQL = SQL & " WHERE USR = '" & PCname & "' "
   SQL = SQL & " AND PROC = '" & varVAL(0) & "' "
   SQL = SQL & " AND IVTR_DIV = '" & strSEC & "' "
   SQL = SQL & " AND SEMI_GOOD_CD = '" & sCOMP & "'"
   SQL = SQL & " AND ASSY_LINE = '" & fspWIP.TextMatrix(fspWIP.Row, 0) & "' "
   SQL = SQL & " AND STYLE_CD  = '" & Replace(fspWIP.TextMatrix(fspWIP.Row, 2), "-", "") & "' "
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
      If UCase(fspSIZE2.TextMatrix(i, 0)) = "IN.BEFORE" Or UCase(fspSIZE2.TextMatrix(i, 0)) = "IN.TODAY" Or _
         UCase(fspSIZE2.TextMatrix(i, 0)) = "OUT.BEFORE" Or UCase(fspSIZE2.TextMatrix(i, 0)) = "OUT.TODAY" Or _
         UCase(fspSIZE2.TextMatrix(i, 0)) = "INVENTORY" Then
      
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
   fspSIZE2.ColWidth(0) = 1000
   fspSIZE2.Cell(flexcpAlignment, fspSIZE2.FixedRows, vSIZE_COL, fspSIZE2.Rows - 1, fspSIZE2.Cols - 1) = 7
   
   fspSIZE2.TextMatrix(1, 0) = "Base"
   fspSIZE2.TextMatrix(2, 0) = "IN.Before"
   fspSIZE2.TextMatrix(3, 0) = "IN.Today"
   fspSIZE2.TextMatrix(4, 0) = "IN.Return"
   fspSIZE2.TextMatrix(5, 0) = "IN.Rework"
   fspSIZE2.TextMatrix(6, 0) = "IN.Unknown"
   
   fspSIZE2.TextMatrix(7, 0) = "Out.Before"
   fspSIZE2.TextMatrix(8, 0) = "Out.Today"
   fspSIZE2.TextMatrix(9, 0) = "Out.Defect"
   fspSIZE2.TextMatrix(10, 0) = "Out.Return"
   fspSIZE2.TextMatrix(11, 0) = "Out.Rework"
   fspSIZE2.TextMatrix(12, 0) = "Out.Lab"
   fspSIZE2.TextMatrix(13, 0) = "Out.Gift"
   fspSIZE2.TextMatrix(14, 0) = "Out.UnKnown"
   fspSIZE2.TextMatrix(15, 0) = "Inventory"
   
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
         fspWIP.SaveGrid cndSave.FileName, flexFileTabText, True
      End If
   End If
   Exit Sub
err_rtn:
   Call sbMsgDsp("Can not file open!", gMsgDspSec)
End Sub

Private Sub SSCommand1_Click()
   Unload frmMO11VJ
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
