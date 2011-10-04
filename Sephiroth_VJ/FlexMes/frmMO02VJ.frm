VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO02VJ 
   Caption         =   "MES-MO02VJ"
   ClientHeight    =   8295
   ClientLeft      =   1080
   ClientTop       =   1245
   ClientWidth     =   11910
   LinkTopic       =   "Form1"
   ScaleHeight     =   8295
   ScaleWidth      =   11910
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   9750
      Top             =   150
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
      Height          =   3195
      Index           =   0
      Left            =   30
      TabIndex        =   6
      Top             =   660
      Width           =   2550
      Begin Threed.SSPanel sspInfo 
         Height          =   390
         Left            =   180
         TabIndex        =   16
         Top             =   675
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
         TabIndex        =   12
         Top             =   1065
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
         Caption         =   "Incoming"
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
         Top             =   1065
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
         Format          =   77201409
         CurrentDate     =   37956
         MinDate         =   37956
      End
      Begin Threed.SSPanel sspTOT 
         Height          =   405
         Index           =   1
         Left            =   1470
         TabIndex        =   9
         Top             =   1470
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
         Top             =   1875
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
         TabIndex        =   11
         Top             =   2685
         Visible         =   0   'False
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
         TabIndex        =   13
         Top             =   1470
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
         Caption         =   "Insp Pass"
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
         TabIndex        =   14
         Top             =   1875
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
         Caption         =   "Shipped"
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
         TabIndex        =   15
         Top             =   2685
         Visible         =   0   'False
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
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
         Index           =   3
         Left            =   1470
         TabIndex        =   21
         Top             =   2280
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
         Index           =   3
         Left            =   165
         TabIndex        =   22
         Top             =   2280
         Width           =   1305
         _Version        =   65536
         _ExtentX        =   2302
         _ExtentY        =   714
         _StockProps     =   78
         Caption         =   "Etc Outgoing"
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
   Begin VSFlex7LCtl.VSFlexGrid fspRst 
      Height          =   2760
      Left            =   2625
      TabIndex        =   4
      Top             =   1095
      Width           =   9270
      _cx             =   16351
      _cy             =   4868
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
      FormatString    =   $"frmMO02VJ.frx":0000
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
         Picture         =   "frmMO02VJ.frx":00E6
         Top             =   30
         Width           =   4950
      End
   End
   Begin VSFlex7LCtl.VSFlexGrid fspSIZE 
      Height          =   3135
      Left            =   30
      TabIndex        =   5
      Top             =   4785
      Width           =   11865
      _cx             =   20929
      _cy             =   5530
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
      FormatString    =   $"frmMO02VJ.frx":0DBB
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
   Begin MSComctlLib.StatusBar sbrStatus 
      Align           =   2  '아래 맞춤
      Height          =   360
      Left            =   0
      TabIndex        =   17
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
   Begin Threed.SSFrame SSFrame1 
      Height          =   510
      Left            =   2640
      TabIndex        =   18
      Top             =   615
      Width           =   9255
      _Version        =   65536
      _ExtentX        =   16325
      _ExtentY        =   900
      _StockProps     =   14
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Serif"
         Size            =   6.01
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin VB.Label lbBgrade 
         Alignment       =   2  '가운데 맞춤
         BackStyle       =   0  '투명
         Caption         =   "XXX"
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
         Left            =   5625
         TabIndex        =   25
         Top             =   165
         Width           =   825
      End
      Begin VB.Label Label4 
         Caption         =   "B-Grade PRS:"
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
         Left            =   4110
         TabIndex        =   24
         Top             =   165
         Width           =   1485
      End
      Begin VB.Label lbTotCtn 
         Alignment       =   2  '가운데 맞춤
         BackStyle       =   0  '투명
         Caption         =   "XXX"
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
         Left            =   1875
         TabIndex        =   20
         Top             =   165
         Width           =   945
      End
      Begin VB.Label Label1 
         Caption         =   "TOTAL PRS :"
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
         Left            =   435
         TabIndex        =   19
         Top             =   165
         Width           =   1530
      End
   End
   Begin VSFlex7LCtl.VSFlexGrid fspSIZE2 
      Height          =   885
      Left            =   30
      TabIndex        =   23
      Top             =   3870
      Width           =   11865
      _cx             =   20929
      _cy             =   1561
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
      FormatString    =   $"frmMO02VJ.frx":0E93
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
End
Attribute VB_Name = "frmMO02VJ"
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

Dim vPARAM As Variant '0:ymd, 1:inout_div, 2:loc_div, 3:work_div
Dim vMSG As String
Dim vINX As Integer
Dim vKIND As Variant
Dim vOLDROW As Long

Private Sub cmdDIV_Click(Index As Integer)
   vINX = Index
   vPARAM(0) = Format(dtpYMD.Value, "YYYYMMDD")
   
   vPARAM(1) = vKIND(Index, 0)
   vPARAM(2) = vKIND(Index, 1)
   vPARAM(3) = vKIND(Index, 2)
   
   'sspInfo.Caption = cmdDIV(Index).Caption
   Call sbRstDsp
   If Index = 0 Then
      Call sbBgradeDsp
   End If
End Sub

Private Sub dtpYMD_Change()
   Call sbTotDSP
   Call cmdDIV_Click(vINX)
End Sub

Private Sub Form_Load()
      
   ReDim vPARAM(3)
   
   lbTitle(0).Caption = "F/N Goods W/H Results"
   lbTitle(1).Caption = lbTitle(0).Caption
   
   Me.Left = 0
   Me.Top = 0
   
   dtpYMD.Value = frmMO01VJ.dtpYMD.Value
   vPARAM(0) = Format(dtpYMD.Value, "YYYYMMDD")
   
   Lv_SIZE = 4
   vGEN_COUNT = 3
   vSIZE_COUNT = 31
     
   ReDim vCol_Arr(1 To Lv_SIZE)
   vCol_Arr(1) = 1000
   vCol_Arr(2) = 1200
   vCol_Arr(3) = 400
   vWidth = 410
   
   ReDim vKIND(3, 2) As String '(Total Index, Param Index)
   
   vKIND(0, 0) = " ('I')"
   vKIND(0, 1) = "X"
   vKIND(0, 2) = " ('M','A')"
   
   vKIND(1, 0) = " ('X')"
   vKIND(1, 1) = "X"
   vKIND(1, 2) = " ('I')"
   
   vKIND(2, 0) = " ('S')"
   vKIND(2, 1) = "X"
   vKIND(2, 2) = " ('M','A')"
   
   vKIND(3, 0) = " ('G','C')"
   vKIND(3, 1) = "X"
   vKIND(3, 2) = " ('M')"
      
   Call sbTotDSP
   Call cmdDIV_Click(0)
   
   vOLDROW = 0
   
End Sub


Private Sub sbRstDsp()
   Dim SQL As String
   Dim arrDATA As Variant
   Dim vFixedCols As Integer
   
   sspInfo.Caption = cmdDIV(vINX).Caption
   
   Call sbHeadRstDsp
   
   Call sbHeadSizeDSP("ME")
   
   If CStr(vPARAM(0)) < "20041101" Then
      'vPARAM: 0:ymd, 1:inout_div, 2:loc_div, 3:work_div
      SQL = ""
      SQL = SQL & " SELECT GRADE, PO_ID||PO_TYPE, SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), MAX(FN_MODEL2(STYLE_CD)), DEST, "
      SQL = SQL & "        SUM(PRS_QTY), MAX(REMARK) "
      SQL = SQL & "   FROM MG_IO "
      SQL = SQL & "  WHERE YMD = '" & vPARAM(0) & "' "
      SQL = SQL & "    AND INOUT_DIV IN " & vPARAM(1) & " "
      'SQL = SQL & "    AND FACTORY = '" & gFactory & "' "
      'SQL = SQL & "    AND LOC_DIV = '" & vPARAM(2) & "' "
      SQL = SQL & "    AND GRADE = 'A' "
      SQL = SQL & "    AND WORK_DIV IN " & vPARAM(3) & " "
      SQL = SQL & "  GROUP BY GRADE, PO_ID, PO_TYPE, STYLE_CD, DEST "
      SQL = SQL & "  ORDER BY 1,2,3,5 "
   Else
      'vPARAM: 0:ymd, 1:inout_div, 2:loc_div, 3:work_div
      
      SQL = ""
      SQL = SQL & " SELECT GRADE, PO_ID||PO_TYPE, SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), MAX(FN_MODEL2(STYLE_CD)), DEST, "
      SQL = SQL & "        SUM(PRS_QTY), MAX(REMARK) "
      SQL = SQL & "   FROM NM_GHEAD "
      SQL = SQL & "  WHERE YMD = '" & vPARAM(0) & "' "
      SQL = SQL & "    AND INOUT_DIV IN " & Replace(vPARAM(1), "S", "O") & " "
      SQL = SQL & "    AND FACTORY  = '" & gFactory & "' "
      SQL = SQL & "    AND PLANT_CD = '" & gFactory & "' "
      SQL = SQL & "    AND LOC_DIV = 'IR' "
      SQL = SQL & "    AND GRADE = 'A' "
      SQL = SQL & "    AND WORK_DIV IN " & vPARAM(3) & " "
      SQL = SQL & "  GROUP BY GRADE, PO_ID, PO_TYPE, STYLE_CD, DEST "
      SQL = SQL & "  ORDER BY 1,2,3,5 "
   End If
   arrDATA = fnGetOraData(SQL)
   If IsArray(arrDATA) Then
      vFixedCols = fspRst.FixedCols
      fspRst.FixedCols = 0
      fspRst.LoadArray arrDATA
      
   Else
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find carton data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      lbTotCtn.Caption = "0"
      sspTOT(vINX).Caption = "0"
      Exit Sub
   End If
   
   'fspRst.Cell(flexcpBackColor, fspLine.Rows - 1, 3, fspLine.Rows - 1, fspLine.Cols - 1) = vbYellow
   fspRst.Subtotal flexSTSum, -1, 5, "#####", vbYellow, , , "Total"
   'fspRst.Subtotal flexSTSum, -1, 6, "#####", vbYellow, , , "Total"
   fspRst.Cell(flexcpAlignment, fspRst.FixedRows, 0, fspRst.Rows - 1, 2) = 4
   fspRst.Cell(flexcpAlignment, fspRst.FixedRows, 3, fspRst.Rows - 1, 3) = 1
   fspRst.Cell(flexcpAlignment, fspRst.FixedRows, 4, fspRst.Rows - 1, 4) = 4
   fspRst.Cell(flexcpAlignment, fspRst.FixedRows, 5, fspRst.Rows - 1, 5) = 7
   
   lbTotCtn.Caption = fspRst.TextMatrix(fspRst.Rows - 1, 5)
   sspTOT(vINX).Caption = fspRst.TextMatrix(fspRst.Rows - 1, 5)
         
End Sub

Private Sub sbTotDSP()
   Dim SQL As String
   Dim varTOT As Variant
   Dim i As Integer
   Dim j As Integer
      
   'RESULTS TOTAL
   SQL = ""
   
   For i = 0 To UBound(vKIND, 1) Step 1
      If CStr(vPARAM(0)) < "20041101" Then
         SQL = SQL & " SELECT " & CStr(i) & ", SUM(PRS_QTY) "
         SQL = SQL & "   FROM MG_IO "
         SQL = SQL & "  WHERE YMD = '" & vPARAM(0) & "' "
         SQL = SQL & "    AND INOUT_DIV IN " & vKIND(i, 0) & " "
         'SQL = SQL & "    AND FACTORY = '" & gFactory & "' "
         'SQL = SQL & "    AND LOC_DIV = '" & vKIND(i, 1) & "' "
         SQL = SQL & "    AND GRADE = 'A' "
         SQL = SQL & "    AND WORK_DIV IN " & vKIND(i, 2) & " "
         SQL = SQL & " UNION ALL "
      Else
         SQL = SQL & " SELECT " & CStr(i) & ", SUM(PRS_QTY) "
         SQL = SQL & "   FROM NM_GHEAD"
         SQL = SQL & "  WHERE YMD = '" & vPARAM(0) & "' "
         SQL = SQL & "    AND INOUT_DIV IN " & Replace(vKIND(i, 0), "S", "O") & " "
         SQL = SQL & "    AND FACTORY = '" & gFactory & "' "
         SQL = SQL & "    AND PLANT_CD = '" & gFactory & "' "
         SQL = SQL & "    AND LOC_DIV = 'IR' "
         SQL = SQL & "    AND GRADE = 'A' "
         SQL = SQL & "    AND WORK_DIV IN " & vKIND(i, 2) & " "
         SQL = SQL & " UNION ALL "
      End If
   Next i
   SQL = Mid(SQL, 1, Len(SQL) - 11)
   
   varTOT = fnGetOraData(SQL)
   If Not IsArray(varTOT) Then
      If varTOT = "" Then
         Call sbMsgDsp("Can not find F/N Goods W/H TOTAL Data!", gMsgDspSec)
      Else
         Call sbMsgDsp(varTOT, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   For i = 0 To UBound(vKIND, 1) Step 1
      sspTOT(i).Caption = "0"
      For j = 0 To UBound(varTOT, 2) Step 1
         If i = CInt(varTOT(0, j)) Then
            sspTOT(i).Caption = fnNVZ(varTOT(1, j))
            Exit For
         End If
      Next j
   Next i
   
End Sub

Private Sub sbHeadRstDsp()
            
   fspRst.Clear
   
   fspRst.FontSize = 9
   'fspRst.FixedCols = 0
   'fspLine.FrozenCols = 4
   fspRst.Cols = 7
   
   fspRst.Cell(flexcpText, 0, 0) = "Grade"
   fspRst.Cell(flexcpText, 0, 1) = "PO ID"
   fspRst.Cell(flexcpText, 0, 2) = "Style"
   fspRst.Cell(flexcpText, 0, 3) = "Model Name"
   fspRst.Cell(flexcpText, 0, 4) = "DEST"
   'fspRst.Cell(flexcpText, 0, 5) = "CTN QTY"
   fspRst.Cell(flexcpText, 0, 5) = "PRS QTY"
   fspRst.Cell(flexcpText, 0, 6) = "REMARK"
   
   fspRst.ColWidth(0) = 600
   fspRst.ColWidth(1) = 1100
   fspRst.ColWidth(2) = 1100
   fspRst.ColWidth(3) = 3200
   fspRst.ColWidth(4) = 900
   fspRst.ColWidth(5) = 1000
   fspRst.ColWidth(6) = 1000
   
   fspRst.RowHeightMax = "250"
   fspRst.RowHeightMin = "250"
   
   fspRst.Cell(flexcpAlignment, 0, 0, 0, fspRst.Cols - 1) = 4
   
   fspRst.Rows = 1
   
End Sub

Private Sub sbHeadBgradeDsp()
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
   
   fspSIZE.MergeRow(0) = True
   fspSIZE.MergeRow(1) = True
   fspSIZE.MergeRow(2) = True
   
   fspSIZE.Cell(flexcpText, 0, 1, 0, 3) = "B-Grade Incoming"
   fspSIZE.Cell(flexcpText, 1, 1, 2, 1) = "Style"
   fspSIZE.Cell(flexcpText, 1, 2, 2, 2) = "Model Name"
   fspSIZE.Cell(flexcpText, 0, 3, 0) = "ME"
   fspSIZE.Cell(flexcpText, 1, 3, 1) = "WO"
   fspSIZE.Cell(flexcpText, 2, 3, 2) = "GS"
   
   fspSIZE.ColWidth(1) = vCol_Arr(1)
   fspSIZE.ColWidth(2) = vCol_Arr(2)
   fspSIZE.ColWidth(3) = vCol_Arr(3)
      
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

Private Sub sbBgradeDsp()

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
   
   Call sbHeadBgradeDsp
   
   If CStr(vPARAM(0)) < "20041101" Then
      SQL = ""
      SQL = SQL & " SELECT 0, " '0
      SQL = SQL & "        SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), " '1
      SQL = SQL & "        MAX(FN_MM_STYNAME(STYLE_CD)), " '2
      SQL = SQL & "        MAX(FN_GEN(STYLE_CD)), " '3
      SQL = SQL & "        CS_SIZE, " '4
      SQL = SQL & "        SUM(PRS_QTY) " '5
      SQL = SQL & "   FROM MG_IO "
      SQL = SQL & "  WHERE YMD = '" & vPARAM(0) & "' "
      SQL = SQL & "    AND INOUT_DIV = 'I' "
      'SQL = SQL & "    AND FACTORY = 'VJ' "
      'SQL = SQL & "    AND LOC_DIV = 'IR' "
      SQL = SQL & "    AND GRADE = 'B' "
      SQL = SQL & "    AND WORK_DIV IN ('A','M') "
      SQL = SQL & "  GROUP BY STYLE_CD, CS_SIZE "
      SQL = SQL & "  ORDER BY 2, 5 "
   Else
      SQL = ""
      SQL = SQL & " SELECT 0, " '0
      SQL = SQL & "        SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), " '1
      SQL = SQL & "        MAX(FN_MM_STYNAME(STYLE_CD)), " '2
      SQL = SQL & "        MAX(FN_GEN(STYLE_CD)), " '3
      SQL = SQL & "        CS_SIZE, " '4
      SQL = SQL & "        SUM(PRS_QTY) " '5
      SQL = SQL & "   FROM NM_GTAIL "
      SQL = SQL & "  WHERE YMD = '" & vPARAM(0) & "' "
      SQL = SQL & "    AND INOUT_DIV = 'I' "
      SQL = SQL & "    AND FACTORY = '" & gFactory & "' "
      SQL = SQL & "    AND PLANT_CD = '" & gFactory & "' "
      SQL = SQL & "    AND LOC_DIV = 'IR' "
      SQL = SQL & "    AND GRADE = 'B' "
      SQL = SQL & "    AND WORK_DIV IN ('A','M') "
      SQL = SQL & "  GROUP BY STYLE_CD, CS_SIZE "
      SQL = SQL & "  ORDER BY 2, 5 "
   End If
   arrDATA = fnGetOraData(SQL)
   If Not IsArray(arrDATA) Then
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find B-Grade data by size! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      lbBgrade.Caption = "0"
      Exit Sub
   End If
      
On Error GoTo ErrGo

   VCOMP = ""
   fspSIZE.Rows = 3
   '사이즈 할당
   For i = 0 To UBound(arrDATA, 2) Step 1
      'row 설정
      If VCOMP <> arrDATA(1, i) Then     '기준 변경시
         fspSIZE.Rows = fspSIZE.Rows + 1
         
         vrow_sz = fnGenRow(CStr(arrDATA(Lv_SIZE - 1, i)))
         vROW = fspSIZE.Rows - 1
                
         '고정 칼럼 내용
         For j = 0 To Lv_SIZE - 1
             fspSIZE.TextMatrix(vROW, j) = arrDATA(j, i)
         Next
         VCOMP = arrDATA(1, i)
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
   
   'fspSIZE.TextMatrix(fspSIZE.Rows - 1, 1) = "Sum"
   'For i = vGEN_COUNT To fspSIZE.Rows - 2
   '   If fspSIZE.IsSubtotal(i) Then
   '      fspSIZE.TextMatrix(i, 2) = fspSIZE.TextMatrix(i - 1, 2)
   '   End If
   'Next i

   'fspSIZE.MergeCol(fspSIZE.Cols - 1) = False
    
   lbBgrade.Caption = fspSIZE.TextMatrix(fspRst.Rows - 1, fspSIZE.Cols - 1)
   
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

Private Sub fspRst_Click()
   Dim varArr As Variant
   Dim Row As Long
   
   Row = fspRst.Row
   If Row = fspRst.Rows - 1 Then
      Exit Sub
   End If
   
   ReDim varArr(5) As String
   
   varArr(0) = fspRst.TextMatrix(Row, 0)                   'GRADE
   varArr(1) = Mid(fspRst.TextMatrix(Row, 1), 1, 6)        'PO_ID
   varArr(2) = Mid(fspRst.TextMatrix(Row, 1), 7, 2)        'PO_TYPE
   varArr(3) = Replace(fspRst.TextMatrix(Row, 2), "-", "") 'STYLE_CD
   varArr(4) = Mid(fspRst.TextMatrix(Row, 3), 1, 2)        'GEN
   varArr(5) = fspRst.TextMatrix(Row, 4)                   'DEST
   
   Call sbSizeDSP(varArr)
End Sub

Private Sub sbSizeDSP(arg_arr As Variant)
   Dim SQL As String
   Dim arrDATA As Variant
   Dim i As Integer
   Dim j As Integer
   Dim vCol As Integer
   Dim vsum As Long
   
   Call sbHeadSizeDSP(CStr(arg_arr(4)))
   
   If CStr(vPARAM(0)) < "20041101" Then
      SQL = ""
      SQL = SQL & " SELECT CS_SIZE, " '
      SQL = SQL & "        SUM(PRS_QTY) " '5
      SQL = SQL & "   FROM MG_IO "
      SQL = SQL & "  WHERE YMD = '" & vPARAM(0) & "' "
      SQL = SQL & "    AND INOUT_DIV IN " & vPARAM(1) & " "
      'SQL = SQL & "    AND FACTORY = '" & gFactory & "' "
      'SQL = SQL & "    AND LOC_DIV = '" & vPARAM(2) & "' "
      SQL = SQL & "    AND GRADE = '" & arg_arr(0) & "' "
      SQL = SQL & "    AND WORK_DIV IN " & vPARAM(3) & " "
      SQL = SQL & "    AND PO_ID = '" & arg_arr(1) & "' "
      SQL = SQL & "    AND PO_TYPE = '" & arg_arr(2) & "' "
      SQL = SQL & "    AND STYLE_CD = '" & arg_arr(3) & "' "
      SQL = SQL & "    AND DEST = '" & arg_arr(5) & "' "
      SQL = SQL & "  GROUP BY CS_SIZE "
      SQL = SQL & "  ORDER BY 1 "
   Else
      
      SQL = ""
      SQL = SQL & " SELECT CS_SIZE, " '
      SQL = SQL & "        SUM(PRS_QTY) " '5
      SQL = SQL & "   FROM NM_GTAIL "
      SQL = SQL & "  WHERE YMD = '" & vPARAM(0) & "' "
      SQL = SQL & "    AND INOUT_DIV IN " & Replace(vPARAM(1), "S", "O") & " "
      SQL = SQL & "    AND FACTORY = '" & gFactory & "' "
      SQL = SQL & "    AND PLANT_CD = '" & gFactory & "' "
      SQL = SQL & "    AND LOC_DIV = 'IR' "
      SQL = SQL & "    AND GRADE = '" & arg_arr(0) & "' "
      SQL = SQL & "    AND WORK_DIV IN " & vPARAM(3) & " "
      SQL = SQL & "    AND PO_ID = '" & arg_arr(1) & "' "
      SQL = SQL & "    AND PO_TYPE = '" & arg_arr(2) & "' "
      SQL = SQL & "    AND STYLE_CD = '" & arg_arr(3) & "' "
      SQL = SQL & "    AND DEST = '" & arg_arr(5) & "' "
      SQL = SQL & "  GROUP BY CS_SIZE "
      SQL = SQL & "  ORDER BY 1 "
   End If
   
   arrDATA = fnGetOraData(SQL)
   If Not IsArray(arrDATA) Then
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find data by size! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   fspSIZE2.Rows = 2
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
      fspSIZE2.TextMatrix(1, vCol) = arrDATA(1, i)
   Next i
   
   'Total
   vsum = 0
   For j = 1 To fspSIZE2.Cols - 1 Step 1
      vsum = vsum + CLng(fnNVZ(fspSIZE2.TextMatrix(1, j)))
   Next j
   
   fspSIZE2.Cols = fspSIZE2.Cols + 1
   fspSIZE2.ColWidth(fspSIZE2.Cols - 1) = vWidth + 100
   fspSIZE2.TextMatrix(0, fspSIZE2.Cols - 1) = "Total"
   fspSIZE2.TextMatrix(1, fspSIZE2.Cols - 1) = vsum
   
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
   fspSIZE2.Rows = 1
   fspSIZE2.Cols = vSIZE_COL + vSIZE_COUNT
   
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


Private Sub fspRst_RowColChange()
  Dim newrow As Long
  
  newrow = fspRst.Row
  If vOLDROW = newrow Then
  Else
     Call fspRst_Click
     vOLDROW = newrow
  End If
  
End Sub

'Private Sub Option1_Click()
'frmMO01VJ.sspFGW(0).BevelOuter = 1
'End Sub

Private Sub SSCommand1_Click()
   Unload frmMO02VJ
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
