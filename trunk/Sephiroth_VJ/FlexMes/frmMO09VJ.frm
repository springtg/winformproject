VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Begin VB.Form frmMO09VJ 
   Caption         =   "MES-MO09VJ"
   ClientHeight    =   8145
   ClientLeft      =   75
   ClientTop       =   360
   ClientWidth     =   11850
   LinkTopic       =   "Form1"
   ScaleHeight     =   8145
   ScaleWidth      =   11850
   Begin Threed.SSPanel SSPanel2 
      Height          =   375
      Left            =   7965
      TabIndex        =   8
      Top             =   750
      Width           =   3900
      _Version        =   65536
      _ExtentX        =   6879
      _ExtentY        =   661
      _StockProps     =   15
      Caption         =   "Shorted Sequence Plan By Day"
      BackColor       =   13160660
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
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   5160
      Top             =   330
   End
   Begin VSFlex7LCtl.VSFlexGrid fspDay 
      Height          =   2235
      Left            =   15
      TabIndex        =   4
      Top             =   1110
      Width           =   11850
      _cx             =   20902
      _cy             =   3942
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
         Visible         =   0   'False
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
         Visible         =   0   'False
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
         Caption         =   "Sequence Balance Detail"
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
         Caption         =   "Sequence Balance Detail"
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
         Picture         =   "frmMO09VJ.frx":0000
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
   Begin MSComDlg.CommonDialog cndSave 
      Left            =   5955
      Top             =   270
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DefaultExt      =   "text (*.txt)"
   End
   Begin Threed.SSPanel SSPanel3 
      Height          =   375
      Left            =   7965
      TabIndex        =   9
      Top             =   3420
      Width           =   3900
      _Version        =   65536
      _ExtentX        =   6879
      _ExtentY        =   661
      _StockProps     =   15
      Caption         =   "Shorted Sequence Plan By Item"
      BackColor       =   13160660
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
   Begin Threed.SSPanel SSPanel4 
      Height          =   375
      Left            =   7950
      TabIndex        =   10
      Top             =   5850
      Width           =   3900
      _Version        =   65536
      _ExtentX        =   6879
      _ExtentY        =   661
      _StockProps     =   15
      Caption         =   "Shorted Sequence Plan By Size"
      BackColor       =   13160660
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
   Begin VSFlex7LCtl.VSFlexGrid fspItem 
      Height          =   1995
      Left            =   15
      TabIndex        =   11
      Top             =   3780
      Width           =   11850
      _cx             =   20902
      _cy             =   3519
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
   Begin VSFlex7LCtl.VSFlexGrid fspSize 
      Height          =   1710
      Left            =   0
      TabIndex        =   12
      Top             =   6210
      Width           =   11850
      _cx             =   20902
      _cy             =   3016
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
   Begin Threed.SSPanel sspLine 
      Height          =   375
      Left            =   2340
      TabIndex        =   13
      Top             =   630
      Width           =   2325
      _Version        =   65536
      _ExtentX        =   4101
      _ExtentY        =   661
      _StockProps     =   15
      Caption         =   "Assembly Line:"
      BackColor       =   13160660
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
   Begin Threed.SSPanel sspDay 
      Height          =   375
      Left            =   15
      TabIndex        =   14
      Top             =   630
      Width           =   2325
      _Version        =   65536
      _ExtentX        =   4101
      _ExtentY        =   661
      _StockProps     =   15
      Caption         =   "D-Day:"
      BackColor       =   13160660
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
   Begin Threed.SSPanel sspItem 
      Height          =   375
      Left            =   3060
      TabIndex        =   15
      Top             =   5850
      Width           =   3495
      _Version        =   65536
      _ExtentX        =   6165
      _ExtentY        =   661
      _StockProps     =   15
      BackColor       =   13160660
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
   Begin Threed.SSPanel sspSTY 
      Height          =   375
      Left            =   1410
      TabIndex        =   16
      Top             =   5850
      Width           =   1650
      _Version        =   65536
      _ExtentX        =   2910
      _ExtentY        =   661
      _StockProps     =   15
      BackColor       =   13160660
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
   Begin Threed.SSPanel sspPROC 
      Height          =   375
      Left            =   15
      TabIndex        =   17
      Top             =   5850
      Width           =   1395
      _Version        =   65536
      _ExtentX        =   2461
      _ExtentY        =   661
      _StockProps     =   15
      BackColor       =   13160660
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
End
Attribute VB_Name = "frmMO09VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'Dim Lv_SIZE As Integer  '스프레드의 사이즈 시작 칼럼(0부터 시작)
'Dim vGEN_COUNT As Variant
'Dim vSIZE_COUNT As Variant
'Dim vCol_Arr As Variant

Dim vSIZE_COL As Integer
Dim vSIZE_COUNT As Integer
Dim vWidth As Variant
Dim vLastUpTM As Variant
Dim vYMD As String
Dim vLine As String

Dim vMSG As String

'Private Sub cmdPrint_Click()
'   Dim vOldWidth As Variant
'   Dim i As Integer
'
'
'
'   ReDim vOldWidth(fspBal.Cols - 1) As Integer
'   For i = 0 To UBound(vOldWidth) Step 1
'      vOldWidth(i) = fspBal.ColWidth(i)
'   Next i
'
'   fspBal.AddItem "" & vbTab & "", 0
'
'   fspBal.Cell(flexcpText, 0, 0, 0, 5) = "Sequence Balance"
'   fspBal.Cell(flexcpFontSize, 0, 0, 0, 5) = 12
'   fspBal.Cell(flexcpFontBold, 0, 0, 0, 5) = True
'   'fspBal.Cell(flexcpFontUnderline, 0, 0, 0, 2) = True
'   fspBal.Cell(flexcpText, 0, 6, 0, fspBal.Cols - 1) = "D-DAY: " & Format(dtpYMD.Value, "YYYY/MM/DD") & _
'                                                       "                Update Time: " & vLastUpTM(0, 0) & _
'                                                       "                Print Date: " & Format(Now, "YYYY/MM/DD HH:MM:SS")
'   fspBal.Cell(flexcpAlignment, 0, 6, 0, fspBal.Cols - 1) = 8
'   fspBal.Cell(flexcpBackColor, 0, 0, 0, fspBal.Cols - 1) = vbWhite
'
'   fspBal.MergeRow(0) = True
'   fspBal.RowHeightMax = 900
'   fspBal.RowHeightMax = 300
'   fspBal.RowHeight(0) = 900
'
'   fspBal.ColWidth(1) = vOldWidth(1) + 500
'   For i = 3 To UBound(vOldWidth) - 1 Step 1
'      If i = 10 Or i = 14 Or i = 20 Then
'      Else
'         fspBal.ColWidth(i) = vOldWidth(i) + 160
'      End If
'   Next i
'   fspBal.FixedRows = 3
'
'   fspBal.PrintGrid "", True, 2, 150, 200
'
'   For i = 0 To UBound(vOldWidth) Step 1
'      fspBal.ColWidth(i) = vOldWidth(i)
'   Next i
'
'   fspBal.RemoveItem 0
'
'   fspBal.FixedRows = 2
'End Sub

Private Sub cmdSearch_Click()
   Call sbDayDsp
   Call sbItemDsp
End Sub


Private Sub Form_Load()
      
   vYMD = Format(frmMO06VJ.dtpYMD.Value, "YYYYMMDD")
   vLine = frmMO06VJ.fspBal.TextMatrix(frmMO06VJ.fspBal.Row, 1)
   If UCase(Mid(vLine, 1, 1)) = "T" Or UCase(Mid(vLine, 1, 1)) = "G" Then
      Unload Me
   End If
   
   sspDay.Caption = "D-Day: " & Format(frmMO06VJ.dtpYMD.Value, "dd/mmm/yyyy")
   sspLine.Caption = "Assembly Line: " & vLine
   
   lbTitle(0).Caption = "Sequence Balance Detail"
   lbTitle(1).Caption = lbTitle(0).Caption
   
   Me.Left = 0
   Me.Top = 0
   vWidth = 600
   
   Call sbDayDsp
   Call sbItemDsp
   Call sbHeadSizeDSP("ME")
   
End Sub

Private Sub sbHeadDayDSP()

   Dim i As Integer
   
   fspDay.Clear
   
   fspDay.FontSize = 8
   fspDay.MergeCells = flexMergeFree
   
   'fspDay.FrozenCols = 1
   fspDay.Cols = 16
   
   fspDay.Cell(flexcpText, 0, 1, 0, 4) = "Bottom"
   fspDay.Cell(flexcpText, 1, 1, 1, 1) = "D-Day"
   fspDay.Cell(flexcpText, 1, 2, 1, 2) = "OS"
   fspDay.Cell(flexcpText, 1, 3, 1, 3) = "PH"
   fspDay.Cell(flexcpText, 1, 4, 1, 4) = "PU+SP"
   
   fspDay.Cell(flexcpText, 0, 6, 0, 7) = "FSS"
   fspDay.Cell(flexcpText, 1, 6, 1, 6) = "D-Day"
   fspDay.Cell(flexcpText, 1, 7, 1, 7) = "FS"
   
   fspDay.Cell(flexcpText, 0, 9, 0, 11) = "UPS"
   fspDay.Cell(flexcpText, 1, 9, 1, 9) = "D-Day"
   fspDay.Cell(flexcpText, 1, 10, 1, 10) = "UPS1"
   fspDay.Cell(flexcpText, 1, 11, 1, 11) = "UPS2"
   
   fspDay.Cell(flexcpText, 0, 13, 0, 14) = "FGA"
   fspDay.Cell(flexcpText, 1, 13, 1, 13) = "D-Day"
   fspDay.Cell(flexcpText, 1, 14, 1, 14) = "FG"
   
   fspDay.MergeRow(0) = True

   For i = 0 To fspDay.Cols - 1 Step 1
      fspDay.ColWidth(i) = 1030
   Next
   
   Call sbSpdVLine(fspDay, 0, 0)
   Call sbSpdVLine(fspDay, 5, 0)
   Call sbSpdVLine(fspDay, 8, 0)
   Call sbSpdVLine(fspDay, 12, 0)
   Call sbSpdVLine(fspDay, 15, 0)
   
   'fspDay.RowHeightMax = 220
   'fspDay.RowHeightMin = 220

   fspDay.Cell(flexcpAlignment, 0, 0, 1, fspDay.Cols - 1) = 4

   fspDay.Rows = fspDay.FixedRows
   
End Sub

Private Sub sbHeadItemDSP()

   Dim i As Integer
   
   fspItem.Clear
   
   fspItem.FontSize = 8
   fspItem.MergeCells = flexMergeFree
   
   'fspitem.FrozenCols = 1
   fspItem.Cols = 16
   
   fspItem.Cell(flexcpText, 0, 1, 0, 4) = "Bottom"
   fspItem.Cell(flexcpText, 1, 1, 1, 1) = "Item"
   fspItem.Cell(flexcpText, 1, 2, 1, 2) = "OS"
   fspItem.Cell(flexcpText, 1, 3, 1, 3) = "PH"
   fspItem.Cell(flexcpText, 1, 4, 1, 4) = "PU+SP"
   
   fspItem.Cell(flexcpText, 0, 6, 0, 7) = "FSS"
   fspItem.Cell(flexcpText, 1, 6, 1, 6) = "Item"
   fspItem.Cell(flexcpText, 1, 7, 1, 7) = "FS"

   fspItem.Cell(flexcpText, 0, 9, 0, 11) = "UPS"
   fspItem.Cell(flexcpText, 1, 9, 1, 9) = "Item"
   fspItem.Cell(flexcpText, 1, 10, 1, 10) = "UPS1"
   fspItem.Cell(flexcpText, 1, 11, 1, 11) = "UPS2"
   
   fspItem.Cell(flexcpText, 0, 13, 0, 14) = "FGA"
   fspItem.Cell(flexcpText, 1, 13, 1, 13) = "Item"
   fspItem.Cell(flexcpText, 1, 14, 1, 14) = "FG"
   
   fspItem.MergeRow(0) = True

   For i = 0 To fspItem.Cols - 1 Step 1
      fspItem.ColWidth(i) = 1000
   Next
   fspItem.ColWidth(1) = 1100
   fspItem.ColWidth(6) = 1100
   fspItem.ColWidth(9) = 1100
   fspItem.ColWidth(13) = 1100
   
   Call sbSpdVLine(fspItem, 0, 0)
   Call sbSpdVLine(fspItem, 5, 0)
   Call sbSpdVLine(fspItem, 8, 0)
   Call sbSpdVLine(fspItem, 12, 0)
   Call sbSpdVLine(fspItem, 15, 0)
   
   'fspitem.RowHeightMax = 220
   'fspitem.RowHeightMin = 220

   fspItem.Cell(flexcpAlignment, 0, 0, 1, fspItem.Cols - 1) = 4

   fspItem.Rows = fspItem.FixedRows
   
End Sub

Private Sub sbHeadSizeDSP(arg_Gen As String)
   Dim vsize_arr As Variant
   Dim i As Single
   Dim j As Integer
   Dim k As Integer

On Error GoTo ErrGo

   vSIZE_COUNT = 31
   vSIZE_COL = 2
   vWidth = 600
   
   fspSize.Clear
   fspSize.FontSize = 8
   fspSize.Rows = 1
   fspSize.Cols = vSIZE_COL + vSIZE_COUNT
   fspSize.FrozenCols = vSIZE_COL
   
   fspSize.MergeCells = flexMergeFree
   fspSize.MergeCol(0) = True
   
   fspSize.Cell(flexcpText, 0, 0, 0, 0) = "RP#"
   fspSize.Cell(flexcpText, 0, 1, 0, 1) = "D-Day"
   
   fspSize.Cell(flexcpAlignment, 0, 0, 0, 1) = 4
   
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
      fspSize.TextMatrix(0, j + vSIZE_COL) = vsize_arr(j)
   Next
   
   fspSize.Cols = vSIZE_COUNT + 1
   fspSize.TextMatrix(0, vSIZE_COUNT) = "Total"
   For i = vSIZE_COL To fspSize.Cols - 2 Step 1
      fspSize.ColWidth(i) = vWidth
   Next
   fspSize.ColWidth(i) = vWidth + 100
   fspSize.Cell(flexcpAlignment, 0, vSIZE_COL, fspSize.Rows - 1, fspSize.Cols - 1) = 4
   
   For i = 0 To fspSize.Cols - 1 Step 1
      fspSize.ColDataType(i) = flexDTLong
   Next
   
   'fspsize.Cell(flexcpAlignment, 0, 1, fspsize.Rows - 1, fspsize.Cols - 1) = 4
   
   Exit Sub
ErrGo:
   Call sbMsgDsp("Size Run Head Error!", gMsgDspSec)
   
End Sub

Private Sub sbDayDsp()
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
        
   Call sbHeadDayDSP
      
   strYMD = vYMD
   
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
   
   'SQL = ""
   'SQL = SQL & " SELECT TO_CHAR(MAX(UPD_YMD),'YYYY/MM/DD HH24:MI:SS') FROM MP_APPLY "
   '
   'vLastUpTM = fnGetOraData(SQL)
   '
   'If Not IsArray(vLastUpTM) Then
   '   Screen.MousePointer = 1
   '   If vLastUpTM = "" Then
   '      Call sbMsgDsp("Can not find data! ", gMsgDspSec)
   '   Else
   '      Call sbMsgDsp(vLastUpTM, gMsgDspSec)
   '   End If
   '   Exit Sub
   'End If
   
      
   SQL = ""
   SQL = SQL & " SELECT ' ', SUBSTR(DIR_YMD,5,2)||'/'||SUBSTR(DIR_YMD,7,2), SUM(OS_D), SUM(PH_D), SUM(PU_D), ' ' "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT A.DIR_YMD AS DIR_YMD, "
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'OSP', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS OS_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP', DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS PH_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PUS', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'SPP', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS PU_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD IN ('OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '3' AND B.ABC_ID <= '8')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY A.DIR_YMD "
   SQL = SQL & " Union All"
   SQL = SQL & " SELECT FN_MM_PREV_DAY(A.DIR_YMD,1) AS DIR_YMD, "
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'OSP', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS OS_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP', DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS PH_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PUS', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'SPP', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS PU_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
   SQL = SQL & "   AND A.OP_CD IN ('OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '2')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY A.DIR_YMD"
   SQL = SQL & "    )"
   SQL = SQL & " GROUP BY DIR_YMD"
   SQL = SQL & " ORDER BY 2 "
   
   arrBTM = fnGetOraData(SQL)
   
   If IsArray(arrBTM) Then
      
      'vFixedCols = fspDAY.FrozenCols
      'fspDAY.FrozenCols = 0
      'fspDAY.LoadArray arrDATA
      'fspDAY.FrozenCols = vFixedCols
      
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
   SQL = SQL & " SELECT SUBSTR(DIR_YMD,5,2)||'/'||SUBSTR(DIR_YMD,7,2), SUM(FS_D), ' ' "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT A.DIR_YMD AS DIR_YMD, "
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'OS', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS FS_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD    = 'FSS'"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '5' AND B.ABC_ID <= '8')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY A.DIR_YMD"
   SQL = SQL & " Union All"
   SQL = SQL & " SELECT FN_MM_PREV_DAY(A.DIR_YMD,1) AS DIR_YMD, "
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'OS', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS FS_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
   SQL = SQL & "   AND A.OP_CD    = 'FSS'"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '4')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY A.DIR_YMD"
   SQL = SQL & "    )"
   SQL = SQL & " GROUP BY DIR_YMD"
   SQL = SQL & " ORDER BY 1 "
   
   arrFSS = fnGetOraData(SQL)
   
   If IsArray(arrFSS) Then
      
      'vFixedCols = fspDAY.FrozenCols
      'fspDAY.FrozenCols = 0
      'fspDAY.LoadArray arrDATA, 2, 10
      'fspDAY.FrozenCols = vFixedCols
      
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
   SQL = SQL & " SELECT SUBSTR(DIR_YMD,5,2)||'/'||SUBSTR(DIR_YMD,7,2), SUM(UPS1_D), SUM(UPS2_D), ' ' "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT A.DIR_YMD AS DIR_YMD, "
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'UPSUPC1', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS UPS1_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'FGAUPC2', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS UPS2_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD   IN ('UPS','FGA')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '2' AND B.ABC_ID <= '8')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY A.DIR_YMD"
   SQL = SQL & " Union All"
   SQL = SQL & " SELECT FN_MM_PREV_DAY(A.DIR_YMD,1) AS DIR_YMD, "
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'UPSUPC1', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS UPS1_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'FGAUPC2', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS UPS2_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
   SQL = SQL & "   AND A.OP_CD   IN ('UPS','FGA')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND B.ABC_ID   = '1' "
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY A.DIR_YMD"
   SQL = SQL & "    )"
   SQL = SQL & " GROUP BY DIR_YMD"
   SQL = SQL & " ORDER BY 1 "

   arrUPS = fnGetOraData(SQL)

   If IsArray(arrUPS) Then

      'vFixedCols = fspDAY.FrozenCols
      'fspDAY.FrozenCols = 0
      'fspDAY.LoadArray arrDATA
      'fspDAY.FrozenCols = vFixedCols

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
   SQL = SQL & " SELECT SUBSTR(DIR_YMD,5,2)||'/'||SUBSTR(DIR_YMD,7,2), FG_D, ' '  "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT A.DIR_YMD AS DIR_YMD, "
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'UP', DECODE(A.T_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS FG_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD    = 'FGA'"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '8')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY A.DIR_YMD"
   SQL = SQL & "    )"
   SQL = SQL & " ORDER BY 1 "

   arrFGA = fnGetOraData(SQL)

   If IsArray(arrFGA) Then

      'vFixedCols = fspDAY.FrozenCols
      'fspDAY.FrozenCols = 0
      'fspDAY.LoadArray arrDATA
      'fspDAY.FrozenCols = vFixedCols

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
   
   fspDay.LoadArray arrDATA
   
   'For i = 2 To fspDAY.Cols - 1 Step 1
   '   If Mid(fspDAY.TextMatrix(1, i), 1, 1) <> "D" Then
   '      fspDAY.Subtotal flexSTSum, 1, i, "######", vbYellow, , , ""
   '   End If
   'Next i
   
   For i = 2 To fspDay.Cols - 1 Step 1
      If Mid(fspDay.TextMatrix(1, i), 1, 1) <> "D" Then
         fspDay.Subtotal flexSTSum, -1, i, "######", vbYellow, , , " "
      End If
   Next i
   
   fspDay.TextMatrix(fspDay.Rows - 1, 1) = "G-Total"
   fspDay.Cell(flexcpAlignment, fspDay.FixedRows, 2, fspDay.Rows - 1, fspDay.Cols - 1) = 7
   fspDay.Cell(flexcpAlignment, fspDay.FixedRows, 1, fspDay.Rows - 1, 1) = 4
   fspDay.Cell(flexcpAlignment, fspDay.FixedRows, 6, fspDay.Rows - 1, 6) = 4
   fspDay.Cell(flexcpAlignment, fspDay.FixedRows, 9, fspDay.Rows - 1, 9) = 4
   fspDay.Cell(flexcpAlignment, fspDay.FixedRows, 13, fspDay.Rows - 1, 13) = 4
   
   
   'Call sbSpdVLine(fspDAY, 2, 0)
   'Call sbSpdVLine(fspDAY, 10, 0)
   'Call sbSpdVLine(fspDAY, 14, 0)
   'Call sbSpdVLine(fspDAY, 20, 0)
   'Call sbSpdVLine(fspDAY, 24, 0)
   
   'For i = fspDAY.FixedRows To fspDAY.Rows - 1 Step 1
   '   If Mid(fspDAY.TextMatrix(i, 0), 1, 1) = "T" Or Mid(fspDAY.TextMatrix(i, 0), 1, 1) = "G" Then
   '      fspDAY.TextMatrix(i, 1) = fspDAY.TextMatrix(i, 0)
   '      fspDAY.TextMatrix(i, 0) = ""
   '   End If
   'Next
   
   'cmdPrint.Enabled = True
   
End Sub

Private Sub sbItemDsp()
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
   
   Call sbHeadItemDSP
      
   strYMD = vYMD
   
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
   
   'SQL = ""
   'SQL = SQL & " SELECT TO_CHAR(MAX(UPD_YMD),'YYYY/MM/DD HH24:MI:SS') FROM MP_APPLY "
   '
   'vLastUpTM = fnGetOraData(SQL)
   '
   'If Not IsArray(vLastUpTM) Then
   '   Screen.MousePointer = 1
   '   If vLastUpTM = "" Then
   '      Call sbMsgDsp("Can not find data! ", gMsgDspSec)
   '   Else
   '      Call sbMsgDsp(vLastUpTM, gMsgDspSec)
   '   End If
   '   Exit Sub
   'End If
   
      
   SQL = ""
   SQL = SQL & " SELECT ' ', SUBSTR(STY,1,6)||'-'||SUBSTR(STY,7,3), SUM(OS_D), SUM(PH_D), SUM(PU_D), MAX(FN_MODEL2(STY)) "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT B.STYLE_CD AS STY, "
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'OSP', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS OS_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP', DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS PH_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PUS', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'SPP', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS PU_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD IN ('OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '3' AND B.ABC_ID <= '8')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY B.STYLE_CD "
   SQL = SQL & " Union All"
   SQL = SQL & " SELECT B.STYLE_CD AS STY, "
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'OSP', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS OS_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP', DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS PH_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD,'PUS', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
   SQL = SQL & "  + SUM(DECODE(A.OP_CD,'SPP', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS PU_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
   SQL = SQL & "   AND A.OP_CD IN ('OSP','PHP','PHI','PUS','SPP')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '2')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY B.STYLE_CD"
   SQL = SQL & "    )"
   SQL = SQL & " GROUP BY STY"
   SQL = SQL & " ORDER BY 2 "
   
   arrBTM = fnGetOraData(SQL)
   
   If IsArray(arrBTM) Then
      
      'vFixedCols = FSPITEM.FrozenCols
      'FSPITEM.FrozenCols = 0
      'FSPITEM.LoadArray arrDATA
      'FSPITEM.FrozenCols = vFixedCols
      
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
   SQL = SQL & " SELECT SUBSTR(STY,1,6)||'-'||SUBSTR(STY,7,3), SUM(FS_D), MAX(FN_MODEL2(STY)) "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT B.STYLE_CD AS STY, "
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'OS', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS FS_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD    = 'FSS'"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '5' AND B.ABC_ID <= '8')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY B.STYLE_CD"
   SQL = SQL & " Union All"
   SQL = SQL & " SELECT B.STYLE_CD AS STY, "
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'OS', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS FS_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
   SQL = SQL & "   AND A.OP_CD    = 'FSS'"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '4')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY B.STYLE_CD"
   SQL = SQL & "    )"
   SQL = SQL & " GROUP BY STY"
   SQL = SQL & " ORDER BY 1 "
   
   arrFSS = fnGetOraData(SQL)
   
   If IsArray(arrFSS) Then
      
      'vFixedCols = FSPITEM.FrozenCols
      'FSPITEM.FrozenCols = 0
      'FSPITEM.LoadArray arrDATA, 2, 10
      'FSPITEM.FrozenCols = vFixedCols
      
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
   SQL = SQL & " SELECT SUBSTR(STY,1,6)||'-'||SUBSTR(STY,7,3), SUM(UPS1_D), SUM(UPS2_D), MAX(FN_MODEL2(STY)) "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT B.STYLE_CD AS STY, "
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'UPSUPC1', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS UPS1_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'FGAUPC2', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS UPS2_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD   IN ('UPS','FGA')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '2' AND B.ABC_ID <= '8')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY B.STYLE_CD"
   SQL = SQL & " Union All"
   SQL = SQL & " SELECT B.STYLE_CD AS STY, "
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'UPSUPC1', DECODE(A.P_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS UPS1_D,"
   SQL = SQL & "    SUM(DECODE(A.OP_CD||B.MM_AREA,'FGAUPC2', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS UPS2_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
   SQL = SQL & "   AND A.OP_CD   IN ('UPS','FGA')"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND B.ABC_ID   = '1' "
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY B.STYLE_CD"
   SQL = SQL & "    )"
   SQL = SQL & " GROUP BY STY"
   SQL = SQL & " ORDER BY 1 "

   arrUPS = fnGetOraData(SQL)

   If IsArray(arrUPS) Then

      'vFixedCols = FSPITEM.FrozenCols
      'FSPITEM.FrozenCols = 0
      'FSPITEM.LoadArray arrDATA
      'FSPITEM.FrozenCols = vFixedCols

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
   SQL = SQL & " SELECT SUBSTR(STY,1,6)||'-'||SUBSTR(STY,7,3), FG_D, FN_MODEL2(STY)  "
   SQL = SQL & " FROM ("
   SQL = SQL & " SELECT B.STYLE_CD AS STY, "
   SQL = SQL & "    SUM(DECODE(B.SEMI_GOOD_CD,'UP', DECODE(A.T_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS FG_D "
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD    = 'FGA'"
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '8')"
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   SQL = SQL & " GROUP BY B.STYLE_CD"
   SQL = SQL & "    )"
   SQL = SQL & " ORDER BY 1 "

   arrFGA = fnGetOraData(SQL)

   If IsArray(arrFGA) Then

      'vFixedCols = FSPITEM.FrozenCols
      'FSPITEM.FrozenCols = 0
      'FSPITEM.LoadArray arrDATA
      'FSPITEM.FrozenCols = vFixedCols

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
   If Rows_1 < UBound(arrFSS, 2) Then
      Rows_1 = UBound(arrFSS, 2)
   End If
   If Rows_1 < UBound(arrUPS, 2) Then
      Rows_1 = UBound(arrUPS, 2)
   End If
   If Rows_1 < UBound(arrFGA, 2) Then
      Rows_1 = UBound(arrFGA, 2)
   End If
   
   ReDim arrDATA(Cols_1, Rows_1)
   
   For i = 0 To Rows_1 Step 1
      k = 0
      If i <= UBound(arrBTM, 2) Then
         For j = 0 To UBound(arrBTM, 1) Step 1
            arrDATA(k, i) = arrBTM(j, i)
            k = k + 1
         Next
      End If
      If i <= UBound(arrFSS, 2) Then
         For j = 0 To UBound(arrFSS, 1) Step 1
            arrDATA(k, i) = arrFSS(j, i)
            k = k + 1
         Next
      End If
      If i <= UBound(arrUPS, 2) Then
         For j = 0 To UBound(arrUPS, 1) Step 1
            arrDATA(k, i) = arrUPS(j, i)
            k = k + 1
         Next
      End If
      If i <= UBound(arrFGA, 2) Then
         For j = 0 To UBound(arrFGA, 1) Step 1
            arrDATA(k, i) = arrFGA(j, i)
            k = k + 1
         Next
      End If
   Next i
   
   fspItem.LoadArray arrDATA
   
   'For i = 2 To FSPITEM.Cols - 1 Step 1
   '   If Mid(FSPITEM.TextMatrix(1, i), 1, 1) <> "D" Then
   '      FSPITEM.Subtotal flexSTSum, 1, i, "######", vbYellow, , , ""
   '   End If
   'Next i
   
   For i = 2 To fspItem.Cols - 1 Step 1
      If Mid(fspItem.TextMatrix(1, i), 1, 1) <> "I" Then
         fspItem.Subtotal flexSTSum, -1, i, "######", vbYellow, , , " "
      End If
   Next i
   
   fspItem.TextMatrix(fspItem.Rows - 1, 1) = "Total"
   fspItem.Cell(flexcpAlignment, fspItem.FixedRows, 2, fspItem.Rows - 1, fspItem.Cols - 1) = 7
   fspItem.Cell(flexcpAlignment, fspItem.FixedRows, 1, fspItem.Rows - 1, 1) = 4
   fspItem.Cell(flexcpAlignment, fspItem.FixedRows, 6, fspItem.Rows - 1, 6) = 4
   fspItem.Cell(flexcpAlignment, fspItem.FixedRows, 9, fspItem.Rows - 1, 9) = 4
   fspItem.Cell(flexcpAlignment, fspItem.FixedRows, 13, fspItem.Rows - 1, 13) = 4
   
   
   'Call sbSpdVLine(FSPITEM, 2, 0)
   'Call sbSpdVLine(FSPITEM, 10, 0)
   'Call sbSpdVLine(FSPITEM, 14, 0)
   'Call sbSpdVLine(FSPITEM, 20, 0)
   'Call sbSpdVLine(FSPITEM, 24, 0)
   
   'For i = FSPITEM.FixedRows To FSPITEM.Rows - 1 Step 1
   '   If Mid(FSPITEM.TextMatrix(i, 0), 1, 1) = "T" Or Mid(FSPITEM.TextMatrix(i, 0), 1, 1) = "G" Then
   '      FSPITEM.TextMatrix(i, 1) = FSPITEM.TextMatrix(i, 0)
   '      FSPITEM.TextMatrix(i, 0) = ""
   '   End If
   'Next
   
   'cmdPrint.Enabled = True
   
End Sub

Private Sub sbSizeDSP()
   Dim SQL As String
   Dim strYMD As String
   Dim strSTY As String
   Dim strProc As String
   Dim strPart As String
   Dim strArea As String
   Dim strRstDiv As String
   Dim strRstComp As String
   
   Dim vNextYMD As Variant
   
   Dim arrDATA As Variant
   
   Dim VCOMP As String
   Dim vrow_sz As Integer
   Dim vsum As Long
   Dim lngSUM As Long
   
   Dim i As Integer
   Dim j As Integer
   Dim k As Integer
   Dim vROW As Integer
   Dim vCol As Integer
   
   strPart = Mid(fspItem.TextMatrix(0, fspItem.Col), 1, 2)
   strProc = fspItem.TextMatrix(1, fspItem.Col)
   
   If fspItem.Col >= 2 And fspItem.Col <= 4 Then
      strSTY = fspItem.TextMatrix(fspItem.Row, 1)
   ElseIf fspItem.Col = 7 Then
      strSTY = fspItem.TextMatrix(fspItem.Row, 6)
   ElseIf fspItem.Col >= 10 And fspItem.Col <= 11 Then
      strSTY = fspItem.TextMatrix(fspItem.Row, 9)
   ElseIf fspItem.Col = 14 Then
      strSTY = fspItem.TextMatrix(fspItem.Row, 13)
   Else
      Exit Sub
   End If
   
   If Trim(strSTY) = "" Then
      Exit Sub
   End If
   
   sspSTY.Caption = strSTY
   sspPROC.Caption = strProc
   'strProc = "*"
   strArea = "*"
   strRstDiv = "*"
   strRstComp = "*"
   If strProc = "OS" Then
      strProc = "('OSP')"
      strRstDiv = "P"
      strRstComp = "OS"
   ElseIf strProc = "PH" Then
      strProc = "('PHI','PHP')"
      strRstComp = "PH"
   ElseIf strProc = "PU+SP" Then
      strProc = "('PUS','SPP')"
      strRstDiv = "P"
   ElseIf strProc = "FS" Then
      strProc = "('FSS')"
      strRstDiv = "P"
      strRstComp = "OS"
   ElseIf strProc = "UPS1" Then
      strProc = "('UPS')"
      strArea = "UPC1"
      strRstDiv = "P"
      strRstComp = "UP"
   ElseIf strProc = "UPS2" Then
      strProc = "('FGA')"
      strArea = "UPC2"
      strRstDiv = "I"
      strRstComp = "UP"
   ElseIf strProc = "FG" Then
      strProc = "('FGA')"
      strRstDiv = "T"
      strRstComp = "UP"
   End If
   
   Call sbHeadSizeDSP(Mid(sspItem.Caption, 1, 2))
      
   strYMD = vYMD
   
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
   
   'SQL = ""
   'SQL = SQL & " SELECT TO_CHAR(MAX(UPD_YMD),'YYYY/MM/DD HH24:MI:SS') FROM MP_APPLY "
   '
   'vLastUpTM = fnGetOraData(SQL)
   '
   'If Not IsArray(vLastUpTM) Then
   '   Screen.MousePointer = 1
   '   If vLastUpTM = "" Then
   '      Call sbMsgDsp("Can not find data! ", gMsgDspSec)
   '   Else
   '      Call sbMsgDsp(vLastUpTM, gMsgDspSec)
   '   End If
   '   Exit Sub
   'End If
   
      
   SQL = ""
   SQL = SQL & " SELECT  PO, SUBSTR(DIR_YMD,5,2)||'/'||SUBSTR(DIR_YMD,7,2), CS_SIZE, SUM(QTY) "
   SQL = SQL & " FROM ("
   
   SQL = SQL & " SELECT SUBSTR(B.PO_NO,5,2)||'-'||SUBSTR(B.PO_NO,7,2)||B.PO_TYPE AS PO, "
   SQL = SQL & "        A.DIR_YMD AS DIR_YMD, "
   SQL = SQL & "        B.CS_SIZE AS CS_SIZE,"
   If strProc = "('PHI','PHP')" Then
      SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP', DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
      SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS QTY"
   Else
      SQL = SQL & "    SUM(DECODE(A." & strRstDiv & "_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)) AS QTY "
   End If
   SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
   SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & strYMD & "',5) AND A.DIR_YMD <= '" & strYMD & "'"
   SQL = SQL & "   AND A.OP_CD IN " & strProc
   SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
   Select Case strPart
   Case "Bo"
      SQL = SQL & "   AND (B.ABC_ID >= '3' AND B.ABC_ID <= '8')"
   Case "FS"
      SQL = SQL & "   AND (B.ABC_ID >= '5' AND B.ABC_ID <= '8')"
   Case "UP"
      SQL = SQL & "   AND (B.ABC_ID >= '2' AND B.ABC_ID <= '8')"
   Case "FG"
      SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '8')"
   End Select
   SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   
   If strArea = "*" Then
   Else
      SQL = SQL & "   AND B.MM_AREA = '" & strArea & "' "
   End If
   
   If strRstComp = "*" Then
   Else
      SQL = SQL & "   AND B.SEMI_GOOD_CD = '" & strRstComp & "' "
   End If
   SQL = SQL & "   AND B.STYLE_CD = '" & Replace(strSTY, "-", "") & "' "
   SQL = SQL & " GROUP BY B.PO_NO, B.PO_TYPE, A.DIR_YMD, B.CS_SIZE "
   
   If strPart = "FG" Then
   Else
   
      SQL = SQL & " Union All"
      SQL = SQL & " SELECT SUBSTR(B.PO_NO,5,2)||'-'||SUBSTR(B.PO_NO,7,2)||B.PO_TYPE AS PO, "
      SQL = SQL & "        FN_MM_PREV_DAY(A.DIR_YMD,1) AS DIR_YMD, "
      SQL = SQL & "        B.CS_SIZE AS CS_SIZE,"
      If strProc = "('PHI','PHP')" Then
         SQL = SQL & "    SUM(DECODE(A.OP_CD,'PHP', DECODE(A.O_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0))"
         SQL = SQL & "  + SUM(DECODE(A.OP_CD,'PHI', DECODE(A.I_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0),0)) AS QTY"
      Else
         SQL = SQL & "    SUM(DECODE(A." & strRstDiv & "_SCN_YMD,TO_CHAR(NULL),B.PS_QTY,0)) AS QTY "
      End If
      SQL = SQL & "  FROM PS_PCARD_SEQ A, PS_PCARD B"
      
      SQL = SQL & " WHERE A.DIR_YMD >= FN_MM_PREV_DAY('" & vNextYMD(0, 0) & "',5) AND A.DIR_YMD <= '" & vNextYMD(0, 0) & "'"
      SQL = SQL & "   AND A.OP_CD IN " & strProc
      SQL = SQL & "   AND A.PCARD_ID = B.PCARD_ID"
      Select Case strPart
      Case "Bo"
         SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '2')"
      Case "FS"
         SQL = SQL & "   AND (B.ABC_ID >= '1' AND B.ABC_ID <= '4')"
      Case "UP"
         SQL = SQL & "   AND B.ABC_ID   = '1' "
      End Select
      SQL = SQL & "   AND B.RES_CD = '" & vLine & "' "
   
      If strArea = "*" Then
      Else
         SQL = SQL & "   AND B.MM_AREA = '" & strArea & "' "
      End If
   
      If strRstComp = "*" Then
      Else
         SQL = SQL & "   AND B.SEMI_GOOD_CD = '" & strRstComp & "' "
      End If
      SQL = SQL & "   AND B.STYLE_CD = '" & Replace(strSTY, "-", "") & "' "
      SQL = SQL & " GROUP BY B.PO_NO, B.PO_TYPE, A.DIR_YMD, B.CS_SIZE "
   End If
   SQL = SQL & "    )"
   SQL = SQL & " GROUP BY PO, DIR_YMD, CS_SIZE "
   SQL = SQL & " ORDER BY 1, 2, 3 "
   
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If IsArray(arrDATA) Then
      
   Else
      
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   'On Error GoTo ErrGo
   
   VCOMP = ""
   '사이즈 할당
   For i = 0 To UBound(arrDATA, 2) Step 1
      'row 설정
            
      If VCOMP <> arrDATA(0, i) & arrDATA(1, i) Then     '기준 변경시
         fspSize.Rows = fspSize.Rows + 1
         
         vrow_sz = 0
         vROW = fspSize.Rows - 1
                
         '고정 칼럼 내용
         For j = 0 To vSIZE_COL - 1
             fspSize.TextMatrix(vROW, j) = arrDATA(j, i)
         Next
         VCOMP = arrDATA(0, i) & arrDATA(1, i)
      Else
         vROW = fspSize.Rows - 1
      End If
            
      'col 설정
      vCol = 99
      For k = vSIZE_COL To fspSize.Cols - 1 Step 1
         If arrDATA(vSIZE_COL, i) = fspSize.TextMatrix(vrow_sz, k) Then
            vCol = k
            Exit For
         Else
            If UCase(fspSize.TextMatrix(vrow_sz, k)) = "X" Or fspSize.TextMatrix(vrow_sz, k) = "" Then
               fspSize.TextMatrix(vrow_sz, k) = arrDATA(vSIZE_COL, i)
               vCol = k
               Exit For
            End If
         End If
      Next k
      If vCol = 99 Then
         fspSize.Cols = fspSize.Cols + 1
         fspSize.ColWidth(fspSize.Cols - 1) = vWidth
         fspSize.TextMatrix(vrow_sz, fspSize.Cols - 1) = arrDATA(vSIZE_COL, i)
         vCol = fspSize.Cols - 1
      End If
            
      fspSize.TextMatrix(vROW, vCol) = fnNVZ(arrDATA(vSIZE_COL + 1, i))
      'fspSIZE.TextMatrix(vRow, vCol) = Int(arr(13, i)) + IIf(IsNumeric(fspSIZE.TextMatrix(vRow, vCol)), fspSIZE.TextMatrix(vRow, vCol), 0)
      
   Next i
   
   '가로 합계
   'fspSize.Cols = fspSize.Cols + 1
   'fspSize.Cell(flexcpText, 0, fspSize.Cols - 1, 0, fspSize.Cols - 1) = "Total"
   'fspSize.MergeCol(fspSize.Cols - 1) = True
   For i = 1 To fspSize.Rows - 1
      If i > (fspSize.Rows - 1) Then
         Exit For
      End If
      vsum = 0
      For j = vSIZE_COL To fspSize.Cols - 1
         vsum = vsum + fnNVZ(fspSize.TextMatrix(i, j))
      Next
      If vsum = 0 Then
         fspSize.RemoveItem i
         i = i - 1
      Else
         fspSize.TextMatrix(i, fspSize.Cols - 1) = CStr(vsum)
      End If
   Next i
       
          
   '칼럼 변경
   'fspSize.Cell(flexcpAlignment, 0, vSIZE_COL, 0, fspSize.Cols - 1) = 4
   fspSize.ColWidth(fspSize.Cols - 1) = 600
   
   '세로 합계
   fspSize.SubtotalPosition = flexSTBelow
   For j = vSIZE_COL To fspSize.Cols - 1
      'fspSize.Subtotal flexSTSum, 0, j, "####", vbYellow, vbBlack, , ""
      fspSize.Subtotal flexSTSum, -1, j, "####", vbYellow, vbBlack, , "G-Total"
   Next j
   fspSize.Cell(flexcpAlignment, 0, 0, fspSize.Rows - 1, fspSize.Cols - 1) = 4
   'fspSize.Cell(flexcpText, fspSize.Rows - 1, 1, fspSize.Rows - 1, 1) = "Total"
   'fspSize.MergeRow(fspSize.Rows - 1) = True
   
   'fspSIZE.TextMatrix(fspSIZE.Rows - 1, 1) = "Sum"
   'For i = vGEN_COUNT To fspSIZE.Rows - 2
   '   If fspSIZE.IsSubtotal(i) Then
   '      fspSIZE.TextMatrix(i, 2) = fspSIZE.TextMatrix(i - 1, 2)
   '   End If
   'Next i

   'fspSIZE.MergeCol(fspSIZE.Cols - 1) = False
    
   
   Exit Sub
        
ErrGo:
   MsgBox Err.Description
   
End Sub

'Private Sub fspBal_Click()
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
'End Sub

'Private Sub Label1_DblClick()
'   If cmdPrint.Enabled Then
'      'cndSave.DefaultExt = "*.txt"
'
'      cndSave.ShowSave
'      If cndSave.FileName = "" Then
'      Else
'         On Error GoTo err_rtn
'         fspBal.SaveGrid cndSave.FileName, flexFileTabText, True
'      End If
'   End If
'   Exit Sub
'err_rtn:
'   Call sbMsgDsp("Can not file open!", gMsgDspSec)
'End Sub

Private Sub fspItem_Click()
   If fspItem.Col >= 2 And fspItem.Col <= 4 Then
      sspItem.Caption = fspItem.TextMatrix(fspItem.Row, 5)
   ElseIf fspItem.Col = 7 Then
      sspItem.Caption = fspItem.TextMatrix(fspItem.Row, 8)
   ElseIf fspItem.Col >= 10 And fspItem.Col <= 11 Then
      sspItem.Caption = fspItem.TextMatrix(fspItem.Row, 12)
   ElseIf fspItem.Col = 14 Then
      sspItem.Caption = fspItem.TextMatrix(fspItem.Row, 15)
   Else
      Exit Sub
   End If
   
   Call sbSizeDSP
End Sub

'Private Sub sbHeadTmDSP()
'
'   Dim i As Integer
'
'   fspDay.Clear
'
'   fspDay.FontSize = 8
'   fspDay.MergeCells = flexMergeFree
'
'   'fspDay.FrozenCols = 1
'   fspDay.Cols = 15
'
'   fspDay.Cell(flexcpText, 0, 0, 0, 4) = "Bottom"
'   fspDay.Cell(flexcpText, 1, 0, 1, 0) = "Time"
'   fspDay.Cell(flexcpText, 1, 1, 1, 1) = "Plan"
'   fspDay.Cell(flexcpText, 1, 2, 1, 2) = "OS"
'   fspDay.Cell(flexcpText, 1, 3, 1, 3) = "PH"
'   fspDay.Cell(flexcpText, 1, 4, 1, 4) = "PU+SP"
'
'   fspDay.Cell(flexcpText, 0, 5, 0, 7) = "FSS"
'   fspDay.Cell(flexcpText, 1, 5, 1, 5) = "Time"
'   fspDay.Cell(flexcpText, 1, 6, 1, 6) = "Plan"
'   fspDay.Cell(flexcpText, 1, 7, 1, 7) = "FS"
'
'   fspDay.Cell(flexcpText, 0, 8, 0, 11) = "UPS"
'   fspDay.Cell(flexcpText, 1, 8, 1, 8) = "Time"
'   fspDay.Cell(flexcpText, 1, 9, 1, 9) = "Plan"
'   fspDay.Cell(flexcpText, 1, 10, 1, 10) = "UPS1"
'   fspDay.Cell(flexcpText, 1, 11, 1, 11) = "UPS2"
'
'   fspDay.Cell(flexcpText, 0, 12, 0, 14) = "FGA"
'   fspDay.Cell(flexcpText, 1, 12, 1, 12) = "Time"
'   fspDay.Cell(flexcpText, 1, 13, 1, 13) = "Plan"
'   fspDay.Cell(flexcpText, 1, 14, 1, 14) = "FG"
'
'   fspDay.MergeRow(0) = True
'
'   For i = 0 To fspDay.Cols - 1 Step 1
'      fspDay.ColWidth(i) = 780
'   Next
'   fspDay.RowHeightMax = "220"
'   fspDay.RowHeightMin = "220"
'
'   fspDay.Cell(flexcpAlignment, 0, 0, 1, fspDay.Cols - 1) = 4
'
'   fspDay.Rows = fspDay.FixedRows
'   'fspDay.Rows = 11
'End Sub


Private Sub SSCommand1_Click()
   Unload frmMO09VJ
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
