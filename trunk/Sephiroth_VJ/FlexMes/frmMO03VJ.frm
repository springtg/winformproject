VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO03VJ 
   Caption         =   "MES-MO03VJ"
   ClientHeight    =   8295
   ClientLeft      =   1080
   ClientTop       =   1245
   ClientWidth     =   11940
   LinkTopic       =   "Form1"
   ScaleHeight     =   8295
   ScaleWidth      =   11940
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   5640
      Top             =   660
   End
   Begin VB.Frame Frame1 
      BeginProperty Font 
         Name            =   "Microsoft Sans Serif"
         Size            =   1.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3360
      Index           =   0
      Left            =   30
      TabIndex        =   6
      Top             =   660
      Width           =   2550
      Begin Threed.SSPanel sspInfo 
         Height          =   390
         Left            =   180
         TabIndex        =   21
         Top             =   750
         Width           =   2190
         _Version        =   65536
         _ExtentX        =   3863
         _ExtentY        =   688
         _StockProps     =   15
         Caption         =   "XXX"
         ForeColor       =   12582912
         BackColor       =   13160660
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Font3D          =   1
      End
      Begin Threed.SSCommand cmdDIV 
         Height          =   405
         Index           =   0
         Left            =   165
         TabIndex        =   13
         Top             =   1140
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
         Caption         =   "UP Incoming"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin Threed.SSPanel sspTOT 
         Height          =   405
         Index           =   0
         Left            =   1470
         TabIndex        =   8
         Top             =   1140
         Width           =   900
         _Version        =   65536
         _ExtentX        =   1587
         _ExtentY        =   714
         _StockProps     =   15
         Caption         =   "0"
         BackColor       =   13160660
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.74
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Font3D          =   1
      End
      Begin MSComCtl2.DTPicker dtpYMD 
         Height          =   390
         Left            =   330
         TabIndex        =   7
         Top             =   105
         Width           =   1920
         _ExtentX        =   3387
         _ExtentY        =   688
         _Version        =   393216
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Microsoft Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Format          =   78643201
         CurrentDate     =   37956
         MinDate         =   37956
      End
      Begin Threed.SSPanel sspTOT 
         Height          =   405
         Index           =   1
         Left            =   1470
         TabIndex        =   9
         Top             =   1545
         Width           =   900
         _Version        =   65536
         _ExtentX        =   1587
         _ExtentY        =   714
         _StockProps     =   15
         Caption         =   "0"
         BackColor       =   13160660
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.74
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Font3D          =   1
      End
      Begin Threed.SSPanel sspTOT 
         Height          =   405
         Index           =   2
         Left            =   1470
         TabIndex        =   10
         Top             =   1950
         Width           =   900
         _Version        =   65536
         _ExtentX        =   1587
         _ExtentY        =   714
         _StockProps     =   15
         Caption         =   "0"
         BackColor       =   13160660
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.74
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Font3D          =   1
      End
      Begin Threed.SSPanel sspTOT 
         Height          =   405
         Index           =   3
         Left            =   1470
         TabIndex        =   11
         Top             =   2355
         Width           =   900
         _Version        =   65536
         _ExtentX        =   1587
         _ExtentY        =   714
         _StockProps     =   15
         Caption         =   "0"
         BackColor       =   13160660
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.74
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Font3D          =   1
      End
      Begin Threed.SSPanel sspTOT 
         Height          =   405
         Index           =   4
         Left            =   1470
         TabIndex        =   12
         Top             =   2760
         Width           =   900
         _Version        =   65536
         _ExtentX        =   1587
         _ExtentY        =   714
         _StockProps     =   15
         Caption         =   "0"
         BackColor       =   13160660
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.74
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Font3D          =   1
      End
      Begin Threed.SSCommand cmdDIV 
         Height          =   405
         Index           =   1
         Left            =   165
         TabIndex        =   14
         Top             =   1545
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
         Caption         =   "FS Incoming"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin Threed.SSCommand cmdDIV 
         Height          =   405
         Index           =   2
         Left            =   165
         TabIndex        =   15
         Top             =   1950
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
         Caption         =   "UP Intput"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin Threed.SSCommand cmdDIV 
         Height          =   405
         Index           =   3
         Left            =   165
         TabIndex        =   16
         Top             =   2355
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
         Caption         =   "FS Input"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin Threed.SSCommand cmdDIV 
         Height          =   405
         Index           =   4
         Left            =   165
         TabIndex        =   17
         Top             =   2760
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
         Caption         =   "FG Prod"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin VB.Line Line1 
         BorderColor     =   &H00FFFFFF&
         Index           =   1
         X1              =   0
         X2              =   2520
         Y1              =   570
         Y2              =   570
      End
      Begin VB.Line Line1 
         BorderColor     =   &H00808080&
         Index           =   0
         X1              =   15
         X2              =   2535
         Y1              =   555
         Y2              =   555
      End
   End
   Begin VSFlex7LCtl.VSFlexGrid fspLine 
      Height          =   2925
      Left            =   2625
      TabIndex        =   4
      Top             =   1095
      Width           =   9270
      _cx             =   16351
      _cy             =   5159
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
      FormatString    =   $"frmMO03VJ.frx":0000
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
         TabIndex        =   23
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
      Begin VB.Label lbTitle 
         BackStyle       =   0  '투명
         Caption         =   "Productoin Results"
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
         Caption         =   "Productoin Results"
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
         Picture         =   "frmMO03VJ.frx":00D5
         Top             =   30
         Width           =   4950
      End
   End
   Begin VSFlex7LCtl.VSFlexGrid fspSIZE 
      Height          =   3915
      Left            =   30
      TabIndex        =   5
      Top             =   4020
      Width           =   11865
      _cx             =   20929
      _cy             =   6906
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
      FixedRows       =   3
      FixedCols       =   0
      RowHeightMin    =   0
      RowHeightMax    =   0
      ColWidthMin     =   0
      ColWidthMax     =   0
      ExtendLastCol   =   0   'False
      FormatString    =   $"frmMO03VJ.frx":0DAA
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
   Begin Threed.SSFrame SSFrame1 
      Height          =   465
      Left            =   2625
      TabIndex        =   18
      Top             =   615
      Width           =   2925
      _Version        =   65536
      _ExtentX        =   5159
      _ExtentY        =   820
      _StockProps     =   14
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Serif"
         Size            =   6
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSOption ssoLine 
         Height          =   255
         Index           =   0
         Left            =   180
         TabIndex        =   19
         Top             =   150
         Width           =   1170
         _Version        =   65536
         _ExtentX        =   2064
         _ExtentY        =   450
         _StockProps     =   78
         Caption         =   " Assy Line"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Value           =   -1  'True
      End
      Begin Threed.SSOption ssoLine 
         Height          =   255
         Index           =   1
         Left            =   1650
         TabIndex        =   20
         Top             =   150
         Width           =   1110
         _Version        =   65536
         _ExtentX        =   1958
         _ExtentY        =   450
         _StockProps     =   78
         Caption         =   "Prod Line"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
   End
   Begin MSComctlLib.StatusBar sbrStatus 
      Align           =   2  '아래 맞춤
      Height          =   360
      Left            =   0
      TabIndex        =   22
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
      Left            =   6210
      Top             =   615
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DefaultExt      =   "text (*.txt)"
   End
End
Attribute VB_Name = "frmMO03VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Lv_SIZE As Integer  '스프레드의 사이즈 시작 칼럼(0부터 시작)
Dim vGEN_COUNT As Variant
Dim vSIZE_COUNT As Variant
Dim vCol_Arr As Variant
Dim vWidth As Variant
Dim vWidthLINE As Variant
Dim vDept As String

Dim vPARAM As Variant ' 0:RST_YMD, 1:kind, 2:Line_div, 3:Line
Dim vKIND As Variant  ' kind:OP_CD||SBUSTR(AREA_CD,4,1)||'.'||RST_DIV||'.'||SEMI_GOOD_CD
Dim vLineDiv As String
Dim vINX As Integer
Dim vMSG As String


Private Sub cmdDIV_Click(Index As Integer)
   vINX = Index
   vPARAM(0) = Format(dtpYMD.Value, "YYYYMMDD")
   vPARAM(1) = vKIND(Index)
   vPARAM(2) = vLineDiv
   vPARAM(3) = "ALL"
   Call sbLineDsp(Index)
   Call sbSizeDSP(vPARAM)

End Sub

Private Sub Command1_Click()
   fspSIZE.PrintGrid "Print Test", True, 2, 60, 60
End Sub

Private Sub cmdPrint_Click()
      
   fspSIZE.AddItem "" & vbTab & "", 0
   
   fspSIZE.Cell(flexcpText, 0, 0, 0, fspSIZE.FixedCols - 1) = vDept
   fspSIZE.Cell(flexcpFontSize, 0, 0, 0, fspSIZE.FixedCols - 1) = 12
   fspSIZE.Cell(flexcpFontBold, 0, 0, 0, fspSIZE.FixedCols - 1) = True
   
   'fspsize.Cell(flexcpFontUnderline, 0, 0, 0, 2) = True
   fspSIZE.Cell(flexcpText, 0, fspSIZE.FixedCols, 0, fspSIZE.Cols - 1) = "Kind Of Flow: " & sspInfo.Caption & "    Date: " & Format(dtpYMD.Value, "YYYY/MM/DD")
   fspSIZE.Cell(flexcpAlignment, 0, 3, 0, fspSIZE.Cols - 1) = 8
   fspSIZE.Cell(flexcpBackColor, 0, 0, 0, fspSIZE.Cols - 1) = vbWhite
   
   fspSIZE.MergeRow(0) = True
   fspSIZE.RowHeightMax = 900
   fspSIZE.RowHeightMax = 300
   fspSIZE.RowHeight(0) = 900
   fspSIZE.FixedRows = 4
   
   fspSIZE.PrintGrid "", True, 2, 60, 200
   fspSIZE.RemoveItem 0
   
   fspSIZE.FixedRows = 3
End Sub

Private Sub dtpYMD_Change()
   Call sbTotDSP
   Call cmdDIV_Click(vINX)
End Sub

Private Sub Form_Load()
      
   ReDim vPARAM(5)
   
   Select Case gDept
   Case "UP"
      lbTitle(0).Caption = "Production Results Of Upper"
      lbTitle(1).Caption = lbTitle(0).Caption
      vDept = "Upper"
   Case "OS"
      lbTitle(0).Caption = "Production Results Of Outsole"
      lbTitle(1).Caption = lbTitle(0).Caption
      vDept = "Outsole"
   Case "PH"
      lbTitle(0).Caption = "Production Results Of Phylon"
      lbTitle(1).Caption = lbTitle(0).Caption
      vDept = "Phylon"
   Case "FS"
      lbTitle(0).Caption = "Production Results Of Stockfit"
      lbTitle(1).Caption = lbTitle(0).Caption
      vDept = "Stockfit"
   Case "FG"
      lbTitle(0).Caption = "Production Results Of Assembly"
      lbTitle(1).Caption = lbTitle(0).Caption
      vDept = "Assembly"
   Case Else
      lbTitle(0).Caption = "Production Results Of " & gDept
      lbTitle(1).Caption = lbTitle(0).Caption
      vDept = gDept
   End Select
   
   Me.Left = 0
   Me.Top = 0
   dtpYMD.Value = frmMO01VJ.dtpYMD.Value
   
   vLineDiv = "ASSY_LINE"
   Lv_SIZE = 6
   vGEN_COUNT = 3
   vSIZE_COUNT = 27
   
   ReDim vCol_Arr(1 To Lv_SIZE)
   
   vCol_Arr(1) = 300
   vCol_Arr(2) = 700
   vCol_Arr(3) = 1050
   vCol_Arr(4) = 1200
   vCol_Arr(5) = 400
   
   vWidth = 410
   vWidthLINE = 450
   
   Call sbAutoDsp
          
End Sub

Private Sub sbLineDsp(inx As Integer)
   Dim SQL As String
   Dim varPLN As Variant
   Dim varRST As Variant
   Dim strYMD As String
   Dim varVAL As Variant
   Dim i As Integer
   Dim j As Integer
   Dim k As Integer
   Dim LinePOS As Integer
   Dim HourPOS As Integer
   Dim vsum As Long
   Dim strVal As String
   
   sspInfo.Caption = cmdDIV(inx).Caption
   
   Call sbHeadLineDsp(inx)
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   varVAL = Split(vKIND(inx), ".", 3) '0:RSTPROC, 1:RST_DIV, 2:SEMI_GOOD_CD
   
   'PLAN BY LINE
   If vLineDiv = "ASSY_LINE" Then
      SQL = ""
      SQL = SQL & " SELECT to_number(LINE), SUM(QTY) "
      SQL = SQL & "   FROM V_PS_LINE_TOT "
      SQL = SQL & "  WHERE YMD = '" & strYMD & "' "
      If gDept = "UP" Then
         SQL = SQL & "    AND AREA_CD = '" & varVAL(0) & "' "
      Else
         SQL = SQL & "    AND OP_CD = '" & varVAL(0) & "' "
      End If
      SQL = SQL & "  GROUP BY LINE "
      SQL = SQL & "  ORDER BY 1 "
   Else
      SQL = ""
      SQL = SQL & " SELECT to_number(LINENO), SUM(TQTY) "
      SQL = SQL & "   FROM TC_TARGET_RMK "
      SQL = SQL & "  WHERE WORK_D = '" & strYMD & "' "
      SQL = SQL & "    AND DEPT_CODE||FTR_CODE = '" & varVAL(0) & "' "
      SQL = SQL & "  GROUP BY LINENO "
      SQL = SQL & "  ORDER BY 1 "
   End If
   
   Screen.MousePointer = 11
   varPLN = fnGetOraData(SQL)
   Screen.MousePointer = 1
   'fspLine.Rows = UBound(varPLN, 2) + 2
   If IsArray(varPLN) Then
      vsum = 0
      For i = 0 To UBound(varPLN, 2) Step 1
         For j = 1 To fspLine.Rows - 2 Step 1
            If fspLine.TextMatrix(j, 0) = CStr(varPLN(0, i)) Then
               fspLine.TextMatrix(j, 1) = varPLN(1, i)
               vsum = vsum + CLng(varPLN(1, i))
               Exit For
            End If
         Next j
      Next i
      fspLine.TextMatrix(fspLine.Rows - 1, 1) = vsum
   Else
      If varPLN = "" Then
         vMSG = "Can not find Plan Data! "
      Else
         vMSG = varPLN + " "
      End If
      'Exit Sub
   End If
   
   
   'Results BY LINE
   SQL = ""
   SQL = SQL & " SELECT " & vLineDiv & ", HH, SUM(PRS_QTY) "
   SQL = SQL & "   FROM MP_PROD "
   SQL = SQL & "  WHERE RST_YMD = '" & strYMD & "' "
   SQL = SQL & "    AND RST_DIV = '" & varVAL(1) & "' "
   If gDept = "UP" Then
      SQL = SQL & "    AND AREA_CD = '" & varVAL(0) & "' "
   Else
      SQL = SQL & "    AND PROC = '" & varVAL(0) & "' "
   End If
   SQL = SQL & "    AND SEMI_GOOD_CD = '" & varVAL(2) & "' "
   SQL = SQL & "  GROUP BY " & vLineDiv & ", HH "
   SQL = SQL & "  ORDER BY 1, 2 "
   
   Screen.MousePointer = 11
   varRST = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If IsArray(varRST) Then
      vsum = 0
      
      For i = 0 To UBound(varRST, 2) Step 1
         LinePOS = -1
         For j = 1 To fspLine.Rows - 2 Step 1 'Getting Line position
            If fspLine.TextMatrix(j, 0) = fnNVL(varRST(0, i)) Then
               LinePOS = j
               Exit For
            End If
         Next j
         If LinePOS = -1 Then
            LinePOS = fspLine.Rows - 1
            fspLine.AddItem CStr(varRST(0, i)) & vbTab & "", LinePOS
         End If
         HourPOS = -1
         For k = 4 To fspLine.Cols - 1 Step 1
            If fspLine.TextMatrix(0, k) = fnNVL(varRST(1, i)) Then
               HourPOS = k
               Exit For
            End If
         Next k
         If HourPOS = -1 Then
            fspLine.Cols = fspLine.Cols + 1
            HourPOS = fspLine.Cols - 1
            fspLine.TextMatrix(0, HourPOS) = varRST(1, i)
            fspLine.ColWidth(HourPOS) = vWidthLINE
         End If
         fspLine.TextMatrix(LinePOS, HourPOS) = fnNVL(varRST(2, i))
      Next i
   Else
      If varRST = "" Then
         vMSG = vMSG & "Can not find Results Data! "
         
      Else
         vMSG = vMSG & varRST
      End If
   End If
   
   If vMSG <> "" Then
      Call sbMsgDsp(vMSG, gMsgDspSec)
      vMSG = ""
   End If
   
   'sum of row
   For i = 1 To fspLine.Rows - 2 Step 1
      vsum = 0
      For j = 4 To fspLine.Cols - 1 Step 1
         vsum = vsum + CLng(fnNVZ(fspLine.TextMatrix(i, j)))
      Next j
      fspLine.TextMatrix(i, 2) = CStr(vsum)
      strVal = fnNVZ(fspLine.TextMatrix(i, 1))
      If strVal = "0" Then
         fspLine.TextMatrix(i, 3) = ""
      Else
         fspLine.TextMatrix(i, 3) = CStr(Round(vsum / CLng(strVal) * 100))
      End If
   Next i
   
   'sum of col
   For j = 1 To fspLine.Cols - 1 Step 1
      If j = 3 Then
         strVal = fnNVZ(fspLine.TextMatrix(fspLine.Rows - 1, 1))
         If strVal = "0" Then
            fspLine.TextMatrix(fspLine.Rows - 1, j) = ""
         Else
            fspLine.TextMatrix(fspLine.Rows - 1, j) = CStr(Round(CLng(fspLine.TextMatrix(fspLine.Rows - 1, 2)) / CLng(strVal) * 100))
         End If
      Else
         vsum = 0
         For i = 1 To fspLine.Rows - 2 Step 1
            vsum = vsum + CLng(fnNVZ(fspLine.TextMatrix(i, j)))
         Next i
         fspLine.TextMatrix(fspLine.Rows - 1, j) = CStr(vsum)
      End If
   Next j
   fspLine.Cell(flexcpFontSize, 0, 0, fspLine.Rows - 1, 3) = 9
   fspLine.Cell(flexcpBackColor, fspLine.Rows - 1, 4, fspLine.Rows - 1, fspLine.Cols - 1) = vbYellow
   sspTOT(inx).Caption = fspLine.TextMatrix(fspLine.Rows - 1, 2)
   
End Sub

Private Sub sbAutoDsp()
   Dim i As Integer
   Dim j As Integer
   Dim k As Integer
   
   ReDim vKIND(0)
   
   k = 0
   For i = 0 To UBound(gArrRstGroup, 2) Step 1
      If gDept = Mid(gArrRstGroup(6, i), 1, 2) Then
         If gDept = "UP" Then
            For j = 0 To 3 Step 1
               If gArrRstGroup(2 + j, i) = "Y" Then
                  cmdDIV(k).Visible = True
                  If gArrRstGroup(0, i) & Mid(gArrRstDiv(j), 3, 1) = "UPCO" Then
                     cmdDIV(k).Caption = "UPS1 Incom."
                  Else
                     cmdDIV(k).Caption = gArrRstGroup(0, i) & "1 " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                  End If
                  sspTOT(k).Visible = True
                  ReDim Preserve vKIND(k)
                  vKIND(k) = gArrRstGroup(0, i) & "1." & Mid(gArrRstDiv(j), 1, 1) & ".UP"
                  k = k + 1
                  
                  cmdDIV(k).Visible = True
                  If gArrRstGroup(0, i) & Mid(gArrRstDiv(j), 3, 1) = "UPCO" Then
                     cmdDIV(k).Caption = "UPS2 Incom."
                  Else
                     cmdDIV(k).Caption = gArrRstGroup(0, i) & "2 " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                  End If
                  sspTOT(k).Visible = True
                  ReDim Preserve vKIND(k)
                  vKIND(k) = gArrRstGroup(0, i) & "2." & Mid(gArrRstDiv(j), 1, 1) & ".UP"
                  k = k + 1
               End If
            Next j
         Else
            For j = 0 To 3 Step 1
               If gArrRstGroup(2 + j, i) = "Y" Then
                  If Mid(gArrRstDiv(j), 1, 1) = "I" Or Mid(gArrRstDiv(j), 1, 1) = "T" Then
                     If gDept = "FG" Then
                        cmdDIV(k).Visible = True
                        cmdDIV(k).Caption = "UP " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        sspTOT(k).Visible = True
                        ReDim Preserve vKIND(k)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".UP"
                        k = k + 1
                        
                        cmdDIV(k).Visible = True
                        cmdDIV(k).Caption = "FS " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        sspTOT(k).Visible = True
                        ReDim Preserve vKIND(k)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".FS"
                        k = k + 1
                     ElseIf gDept = "FS" Then
                        cmdDIV(k).Visible = True
                        cmdDIV(k).Caption = "OS " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        sspTOT(k).Visible = True
                        ReDim Preserve vKIND(k)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".OS"
                        k = k + 1
                        
                        cmdDIV(k).Visible = True
                        cmdDIV(k).Caption = "PU " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        sspTOT(k).Visible = True
                        ReDim Preserve vKIND(k)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".PU"
                        k = k + 1
                        
                        cmdDIV(k).Visible = True
                        cmdDIV(k).Caption = "SP " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        sspTOT(k).Visible = True
                        ReDim Preserve vKIND(k)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".SP"
                        k = k + 1
                        
                        cmdDIV(k).Visible = True
                        cmdDIV(k).Caption = "PH " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        sspTOT(k).Visible = True
                        ReDim Preserve vKIND(k)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".PH"
                        k = k + 1
                     Else
                        cmdDIV(k).Visible = True
                        cmdDIV(k).Caption = Mid(gArrRstGroup(0, i), 1, 3) & " " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        sspTOT(k).Visible = True
                        ReDim Preserve vKIND(k)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & "." & Mid(gArrRstGroup(0, i), 1, 2)
                        k = k + 1
                     End If
                  Else
                     cmdDIV(k).Visible = True
                     cmdDIV(k).Caption = Mid(gArrRstGroup(0, i), 1, 3) & " " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                     sspTOT(k).Visible = True
                     ReDim Preserve vKIND(k)
                     vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & "." & Mid(gArrRstGroup(0, i), 1, 2)
                     k = k + 1
                  End If
               End If
            Next j
         End If
         
         'Exit For
      End If
   Next i
      
   For i = k To 4 Step 1
      cmdDIV(i).Visible = False
      sspTOT(i).Visible = False
      cmdDIV(i).Caption = ""
   Next i
   
   Call sbTotDSP
   
   Call cmdDIV_Click(UBound(vKIND))
End Sub

Private Sub sbTotDSP()
   Dim SQL As String
   Dim varTOT As Variant
   Dim i As Integer
   Dim j As Integer
   
   'RESULTS TOTAL
   SQL = ""
   SQL = SQL & " SELECT OP_CD||SUBSTR(AREA_CD,4,1)||'.'||RST_DIV||'.'||SEMI_GOOD_CD, SUM(QTY) "
   SQL = SQL & "   FROM V_MM_LINE_TOT "
   SQL = SQL & "  WHERE YMD = '" & Format(dtpYMD.Value, "YYYYMMDD") & "' "
   SQL = SQL & "  GROUP BY OP_CD, AREA_CD, RST_DIV, SEMI_GOOD_CD "
   SQL = SQL & "  ORDER BY 1 "
   
   varTOT = fnGetOraData(SQL)
   If Not IsArray(varTOT) Then
      If varTOT = "" Then
         Call sbMsgDsp("Can not find Production Results TOTAL!", gMsgDspSec)
      Else
         Call sbMsgDsp(varTOT, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   For i = 0 To UBound(vKIND) Step 1
      sspTOT(i).Caption = "0"
      For j = 0 To UBound(varTOT, 2) Step 1
         If vKIND(i) = varTOT(0, j) Then
            sspTOT(i).Caption = fnNVZ(varTOT(1, j))
            Exit For
         End If
      Next j
   Next i
   
End Sub

Private Sub sbHeadLineDsp(inx As Integer)
   Dim i As Integer
   Dim k As Integer
   Dim start_HH As Integer
   Dim end_HH As Integer
   Dim delta_HH As Integer
   Dim start_Line As Integer
   Dim end_line As Integer
      
   fspLine.Clear
   
   fspLine.FontSize = 8
   fspLine.FixedCols = 4
   'fspLine.FrozenCols = 4
   
   fspLine.Cell(flexcpText, 0, 0) = "Line"
   fspLine.Cell(flexcpText, 0, 1) = "Plan"
   fspLine.Cell(flexcpText, 0, 2) = "Sum"
   fspLine.Cell(flexcpText, 0, 3) = "%"
   fspLine.ColWidth(0) = 450
   fspLine.ColWidth(1) = 520
   fspLine.ColWidth(2) = 520
   fspLine.ColWidth(3) = 350
   
   'Top Head Dsp
   For i = 0 To UBound(gArrDept, 2) Step 1
      If (gDept = "UP" And gArrDept(0, i) & gArrDept(1, i) = Mid(vKIND(inx), 1, 4)) _
      Or (gDept <> "UP" And gArrDept(0, i) = Mid(vKIND(inx), 1, 3)) Then
         If fnNVL(gArrDept(4, i)) <> "" Then
            If IsNumeric(Mid(gArrDept(5, i), 1, 2)) Then
               start_HH = CInt(Mid(gArrDept(5, i), 1, 2))
            Else
               If fnNVL(gArrDept(10, i)) <> "" Then
                  start_HH = 22
               Else
                  start_HH = 6
               End If
            End If
            
         Else
            'MsgBox "A Shift isn't in TC_CF_DEPART and then Start hour of Sole Dept is 22. "
            If gDept = "OS" Or gDept = "PU" Or gDept = "PH" Then
               start_HH = 22
            End If
         End If
         
         If fnNVL(gArrDept(10, i)) <> "" Then
            If IsNumeric(Mid(gArrDept(12, i), 1, 2)) Then
               end_HH = CInt(Mid(gArrDept(12, i), 1, 2))
            Else
               end_HH = 21
            End If
         Else
            If fnNVL(gArrDept(7, i)) <> "" Then
               If IsNumeric(Mid(gArrDept(9, i), 1, 2)) Then
                  end_HH = CInt(Mid(gArrDept(9, i), 1, 2))
               Else
                  end_HH = 14
               End If
            
            Else
               If IsNumeric(Mid(gArrDept(6, i), 1, 2)) Then
                  end_HH = CInt(Mid(gArrDept(6, i), 1, 2))
               Else
                  end_HH = 23
               End If
            End If
         End If
      End If
   Next i
   
   If start_HH >= end_HH Then
      end_HH = end_HH + 24
   End If
   delta_HH = end_HH - start_HH + 1
   'If arg_shift = 3 Then
   '   start_HH = 24
   '   delta_HH = 24
   'Else
   '   start_HH = 6
   '   delta_HH = 17
   'End If
   
   If start_HH = ((start_HH + delta_HH - 1) Mod 24) Then
      delta_HH = delta_HH - 1
   End If
   
   fspLine.Cols = 4 + delta_HH
   
   For i = start_HH To start_HH + delta_HH - 1 Step 1
      fspLine.Cell(flexcpText, 0, fspLine.FixedCols + i - start_HH) = Mid(CStr((i Mod 24) + 100), 2, 2)
      fspLine.ColWidth(fspLine.FixedCols + i - start_HH) = vWidthLINE
   Next i
   
   fspLine.Cell(flexcpAlignment, 0, 0, 0, fspLine.Cols - 1) = 4
   
   'Left Heap Dsp
   start_Line = 0
   If vLineDiv = "PROD_LINE" Then
      For i = 0 To UBound(gArrDept, 2) Step 1
         If (gDept = "UP" And gArrDept(0, i) & gArrDept(1, i) = Mid(vKIND(inx), 1, 4)) _
         Or (gDept <> "UP" And gArrDept(0, i) = Mid(vKIND(inx), 1, 3)) Then
            start_Line = CInt(gArrDept(2, i))
            end_line = start_Line + CInt(gArrDept(3, i)) - 1
         End If
      Next i
      If start_Line = 0 Then
         start_Line = 1
         end_line = 24
      End If
   Else
      start_Line = 1
      end_line = gASSY_LINE_NUM
   End If
   
   k = 1
   fspLine.Rows = end_line + 2
   For i = start_Line To end_line Step 1
   
       fspLine.TextMatrix(k, 0) = CStr(i)
       k = k + 1
   Next i
   'fspLine.Rows = k
   fspLine.TextMatrix(fspLine.Rows - 1, 0) = "Total"
   fspLine.Cell(flexcpAlignment, 1, 1, fspLine.Rows - 1, fspLine.Cols - 1) = 7
   
End Sub

Private Sub sbHeadSizeDSP()
   fspSIZE.Clear
   fspSIZE.Rows = vGEN_COUNT
   fspSIZE.FontSize = 8
   fspSIZE.MergeCells = flexMergeFixedOnly
   fspSIZE.FixedCols = Lv_SIZE
   'fspSIZE.FrozenCols = Lv_SIZE
   'head
        
   fspSIZE.MergeCol(1) = True
   fspSIZE.MergeCol(2) = True
   fspSIZE.MergeCol(3) = True
   fspSIZE.MergeCol(4) = True
   fspSIZE.MergeCol(5) = True
   
   fspSIZE.MergeRow(0) = True
   fspSIZE.MergeRow(1) = True
   fspSIZE.MergeRow(2) = True
   
   fspSIZE.Cell(flexcpText, 0, 1, 0, 4) = "Production Results"
   fspSIZE.Cell(flexcpText, 1, 1, 2, 1) = "LN"
   
   fspSIZE.Cell(flexcpText, 1, 2, 2, 2) = "PO"
   fspSIZE.Cell(flexcpText, 1, 3, 2, 3) = "Style"
   fspSIZE.Cell(flexcpText, 1, 4, 2, 4) = "Model Name"
   fspSIZE.Cell(flexcpText, 0, 5, 0) = "ME"
   fspSIZE.Cell(flexcpText, 1, 5, 1) = "WO"
   fspSIZE.Cell(flexcpText, 2, 5, 2) = "GS"
   
   fspSIZE.ColWidth(1) = vCol_Arr(1)
   fspSIZE.ColWidth(2) = vCol_Arr(2)
   fspSIZE.ColWidth(3) = vCol_Arr(3)
   fspSIZE.ColWidth(4) = vCol_Arr(4)
   fspSIZE.ColWidth(5) = vCol_Arr(5)
   
   Call init_sizerun(fspSIZE)
   
   fspSIZE.Cell(flexcpAlignment, 0, 0, 2, fspSIZE.Cols - 1) = 4
   
End Sub

Sub init_sizerun(ByRef fsp As Object)
Dim vsize_arr As Variant
Dim vSIZE_COL As Integer
Dim i As Single
Dim j As Integer
Dim k As Integer

On Error GoTo ErrGo

   ReDim vsize_arr(vGEN_COUNT - 1, vSIZE_COUNT - 1)
   vSIZE_COL = Lv_SIZE
   fsp.Cols = vSIZE_COL + vSIZE_COUNT
   
   For j = 0 To vGEN_COUNT - 1 Step 1
      For k = 0 To vSIZE_COUNT - 1 Step 1
         vsize_arr(j, k) = "x"
      Next k
   Next j
      
   'M Size Map
   k = 0
   For i = 3.5 To 12.5 Step 0.5
      If i = CInt(i) Then
         vsize_arr(0, k) = CStr(i)
      Else
         vsize_arr(0, k) = CStr(i - 0.5) & "T"
      End If
      k = k + 1
   Next
   
   For i = 13 To 18 Step 1
      vsize_arr(0, k) = CStr(i)
      k = k + 1
   Next
   
   'W Size Map
   k = 0
   For i = 2 To 15 Step 0.5
      If i = CInt(i) Then
         vsize_arr(1, k) = CStr(i)
      Else
         vsize_arr(1, k) = CStr(i - 0.5) & "T"
      End If
      k = k + 1
   Next
      
   'G Size Map
   k = 0
   For i = 8 To 13.5 Step 0.5
      If i = CInt(i) Then
         vsize_arr(2, k) = CStr(i)
      Else
         vsize_arr(2, k) = CStr(i - 0.5) & "T"
      End If
      k = k + 1
   Next
   
   For i = 1 To 7 Step 0.5
      If i = CInt(i) Then
         vsize_arr(2, k) = CStr(i)
      Else
         vsize_arr(2, k) = CStr(i - 0.5) & "T"
      End If
      k = k + 1
   Next
       
   For i = 0 To vGEN_COUNT - 1 Step 1
      For j = 0 To vSIZE_COUNT - 1 Step 1
         fsp.TextMatrix(i, j + vSIZE_COL) = vsize_arr(i, j)
      Next
   Next
   
   For i = Lv_SIZE To fsp.Cols - 1 Step 1
      fsp.ColWidth(i) = vWidth
   Next i
   
   Exit Sub
ErrGo:
   Call sbMsgDsp("Size Run Head Error!", gMsgDspSec)
   
End Sub

Private Function fnGenRow(arg_v As String) As Integer
   Dim i As Integer
   For i = 0 To vGEN_COUNT - 2 Step 1
      If arg_v = fspSIZE.TextMatrix(i, Lv_SIZE - 1) Then
         fnGenRow = i
         Exit Function
      End If
   Next i
   fnGenRow = i
End Function

'------------------------------------------------------------------------
'  arg_arr: 0:RST_YMD, 1:kind, 2:Line_div, 3:Line
'------------------------------------------------------------------------
Private Sub sbSizeDSP(arg_arr As Variant)

   Dim SQL As String
   Dim arrDATA As Variant
   Dim vCol, vROW As Integer
   Dim VCOMP As String
   Dim vsum As Long
   Dim strYMD As String
   Dim varVAL As Variant
   Dim vrow_sz As Integer
   
   Dim i As Long
   Dim j As Long
   Dim k As Long
   
   Call sbHeadSizeDSP
   
   varVAL = Split(arg_arr(1), ".", 3) '0:OPCD, 1:RST_DIV, 2:SEMI_GOOD_CD
   
   'PLAN BY LINE
   SQL = ""
   SQL = SQL & " SELECT 0, " '0
   SQL = SQL & "        MINI_LINE, " '1
   SQL = SQL & "        SUBSTR(PO_NO,5,2)||SUBSTR(PO_NO,7,2)||PO_TYPE, " '2
   SQL = SQL & "        SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), " '3
   SQL = SQL & "        MAX(FN_MM_STYNAME(STYLE_CD)), " '4
   SQL = SQL & "        MAX(FN_GEN(STYLE_CD)), " '5
   SQL = SQL & "        CS_SIZE, " '6
   SQL = SQL & "        SUM(PRS_QTY) " '7
   SQL = SQL & "   FROM MP_PROD "
   SQL = SQL & "  WHERE RST_YMD = '" & arg_arr(0) & "' "
   SQL = SQL & "    AND RST_DIV = '" & varVAL(1) & "' "
   If Mid(varVAL(0), 1, 2) = "UP" Then
      SQL = SQL & " AND AREA_CD = '" & varVAL(0) & "' "
   Else
      SQL = SQL & " AND PROC = '" & varVAL(0) & "' "
   End If
   If Not arg_arr(3) = "ALL" Then
      SQL = SQL & " AND " & arg_arr(2) & " = '" & arg_arr(3) & "' "
   End If
   SQL = SQL & "    AND SEMI_GOOD_CD = '" & varVAL(2) & "' "
   SQL = SQL & "  GROUP BY MINI_LINE, PO_NO, PO_TYPE, STYLE_CD, CS_SIZE "
   SQL = SQL & "  ORDER BY 2, 3, 4, 7 "
   
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   
   If Not IsArray(arrDATA) Then
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find results data by size! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   
On Error GoTo ErrGo

   VCOMP = ""
   fspSIZE.Rows = 3
   '사이즈 할당
   For i = 0 To UBound(arrDATA, 2) Step 1
      'row 설정
      If VCOMP <> arrDATA(1, i) & arrDATA(2, i) & arrDATA(3, i) Then     '기준 변경시
         fspSIZE.Rows = fspSIZE.Rows + 1
         
         vrow_sz = fnGenRow(CStr(arrDATA(Lv_SIZE - 1, i)))
         vROW = fspSIZE.Rows - 1
                
         '고정 칼럼 내용
         For j = 0 To Lv_SIZE - 1
             fspSIZE.TextMatrix(vROW, j) = arrDATA(j, i)
         Next
         VCOMP = arrDATA(1, i) & arrDATA(2, i) & arrDATA(3, i)
      Else
         vROW = fspSIZE.Rows - 1
      End If
            
      'col 설정
      vCol = 99
      For k = Lv_SIZE To fspSIZE.Cols - 1 Step 1
         If arrDATA(Lv_SIZE, i) = fspSIZE.TextMatrix(vrow_sz, k) Then
            vCol = k
            Exit For
         Else
            If UCase(fspSIZE.TextMatrix(vrow_sz, k)) = "X" Or fspSIZE.TextMatrix(vrow_sz, k) = "" Then
               fspSIZE.TextMatrix(vrow_sz, k) = arrDATA(Lv_SIZE, i)
               vCol = k
               Exit For
            End If
         End If
      Next k
      If vCol = 99 Then
         fspSIZE.Cols = fspSIZE.Cols + 1
         fspSIZE.ColWidth(fspSIZE.Cols - 1) = vWidth
         fspSIZE.TextMatrix(vrow_sz, fspSIZE.Cols - 1) = arrDATA(Lv_SIZE, i)
         vCol = fspSIZE.Cols - 1
      End If
            
      fspSIZE.TextMatrix(vROW, vCol) = fnNVZ(arrDATA(Lv_SIZE + 1, i))
      'fspSIZE.TextMatrix(vRow, vCol) = Int(arr(13, i)) + IIf(IsNumeric(fspSIZE.TextMatrix(vRow, vCol)), fspSIZE.TextMatrix(vRow, vCol), 0)
      
   Next i
   
   '가로 합계
   fspSIZE.Cols = fspSIZE.Cols + 1
   fspSIZE.Cell(flexcpText, 0, fspSIZE.Cols - 1, 2) = "Total"
   fspSIZE.MergeCol(fspSIZE.Cols - 1) = True
   For i = vGEN_COUNT To fspSIZE.Rows - 1
      vsum = 0
      For j = Lv_SIZE To fspSIZE.Cols - 1
         vsum = vsum + fnNVZ(fspSIZE.TextMatrix(i, j))
      Next
      fspSIZE.TextMatrix(i, fspSIZE.Cols - 1) = CStr(vsum)
   Next i
        
   '칼럼 변경
   fspSIZE.Cell(flexcpAlignment, 0, Lv_SIZE, 2, fspSIZE.Cols - 1) = 4
   fspSIZE.ColWidth(fspSIZE.Cols - 1) = 600
   
   '세로 합계
   fspSIZE.SubtotalPosition = flexSTBelow
   For j = Lv_SIZE To fspSIZE.Cols - 1
      'fspSIZE.Subtotal flexSTSum, 2, j, "####", RGB(220, 220, 220)
      fspSIZE.Subtotal flexSTSum, -1, j, "####", vbYellow, vbBlack, , "Total"
   Next j
   fspSIZE.Cell(flexcpAlignment, fspSIZE.Rows - 1, 1, fspSIZE.Rows - 1, 4) = 4
   fspSIZE.Cell(flexcpText, fspSIZE.Rows - 1, 1, fspSIZE.Rows - 1, 4) = "Total"
   fspSIZE.MergeRow(fspSIZE.Rows - 1) = True
   
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

Private Sub Form_Unload(Cancel As Integer)
   Call frmMO01VJ.sbDspData(Format(frmMO01VJ.dtpYMD.Value, "YYYYMMDD"), "ALL")
   If frmMO01VJ.chkAutoScan.Value = 1 Then
      frmMO01VJ.tmrScan.Enabled = True
   End If
End Sub

Private Sub fspLine_Click()
   vPARAM(0) = Format(dtpYMD.Value, "YYYYMMDD")
   vPARAM(1) = vKIND(vINX)
   vPARAM(2) = vLineDiv
   
   If IsNumeric(fspLine.TextMatrix(fspLine.Row, 0)) Then
      vPARAM(3) = fspLine.TextMatrix(fspLine.Row, 0)
   Else
      vPARAM(3) = "ALL"
   End If
   Call sbSizeDSP(vPARAM)
End Sub

Private Sub SSCommand1_Click()
   Unload frmMO03VJ
End Sub

Private Sub ssoLine_Click(Index As Integer, Value As Integer)
   If ssoLine(0).Value Then
      vLineDiv = "ASSY_LINE"
   Else
      vLineDiv = "PROD_LINE"
   End If
   Call cmdDIV_Click(vINX)
End Sub

Private Sub sbMsgDsp(arg_TXT As Variant, arg_ITVL As Integer)
   tmr1.Enabled = False
   sbrStatus.Panels.Item(1).Text = ""
   sbrStatus.Panels.Item(1).Text = arg_TXT
   tmr1.Interval = arg_ITVL * 1000
   tmr1.Enabled = True
End Sub

Private Sub sspInfo_DblClick()
   If cmdPrint.Enabled Then
      'cndSave.DefaultExt = "*.txt"
      
      cndSave.ShowSave
      If cndSave.FileName = "" Then
      Else
         On Error GoTo err_rtn
         fspSIZE.SaveGrid cndSave.FileName, flexFileTabText, True
      End If
   End If
   Exit Sub
err_rtn:
   Call sbMsgDsp("Can not file open!", gMsgDspSec)
End Sub

Private Sub tmr1_Timer()
   sbrStatus.Panels.Item(1).Text = ""
   tmr1.Enabled = False
End Sub
