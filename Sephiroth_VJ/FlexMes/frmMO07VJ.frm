VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO07VJ 
   Caption         =   "MES-MO07VJ"
   ClientHeight    =   8295
   ClientLeft      =   1290
   ClientTop       =   390
   ClientWidth     =   11910
   LinkTopic       =   "Form1"
   ScaleHeight     =   8295
   ScaleWidth      =   11910
   Begin Threed.SSPanel SSPanel1 
      Height          =   645
      Left            =   -15
      TabIndex        =   15
      Top             =   0
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
         TabIndex        =   18
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
      Begin Threed.SSCommand cmdSave 
         Height          =   435
         Left            =   7560
         TabIndex        =   21
         Top             =   105
         Width           =   1395
         _Version        =   65536
         _ExtentX        =   2461
         _ExtentY        =   767
         _StockProps     =   78
         Caption         =   "Save"
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
         Left            =   6180
         TabIndex        =   22
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
      Begin Threed.SSCommand cmdDel 
         Height          =   435
         Left            =   8925
         TabIndex        =   28
         Top             =   105
         Width           =   1395
         _Version        =   65536
         _ExtentX        =   2461
         _ExtentY        =   767
         _StockProps     =   78
         Caption         =   "Delete"
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
      Begin Threed.SSCommand cmdFormReport 
         Height          =   435
         Left            =   4815
         TabIndex        =   34
         Top             =   105
         Width           =   1395
         _Version        =   65536
         _ExtentX        =   2461
         _ExtentY        =   767
         _StockProps     =   78
         Caption         =   "Exam. Form"
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
         Caption         =   "Stock Examination"
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
         TabIndex        =   17
         Top             =   180
         Width           =   5790
      End
      Begin VB.Label lbTitle 
         BackStyle       =   0  '투명
         Caption         =   "Stock Examination"
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
         TabIndex        =   16
         Top             =   150
         Width           =   5790
      End
      Begin VB.Image Image1 
         Height          =   585
         Left            =   30
         Picture         =   "frmMO07VJ.frx":0000
         Top             =   30
         Width           =   4950
      End
   End
   Begin VB.Frame Frame1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   840
      Left            =   15
      TabIndex        =   14
      Top             =   570
      Width           =   11895
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
         Left            =   8475
         Style           =   2  '드롭다운 목록
         TabIndex        =   3
         Top             =   285
         Width           =   3195
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
         Left            =   4815
         Style           =   2  '드롭다운 목록
         TabIndex        =   2
         Top             =   300
         Width           =   1995
      End
      Begin MSComCtl2.DTPicker dtpYMD 
         Height          =   360
         Left            =   1665
         TabIndex        =   1
         Top             =   285
         Width           =   1455
         _ExtentX        =   2566
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
         Format          =   76611585
         CurrentDate     =   37956
         MinDate         =   37956
      End
      Begin Threed.SSPanel sspInfo 
         Height          =   360
         Left            =   180
         TabIndex        =   12
         Top             =   285
         Width           =   1455
         _Version        =   65536
         _ExtentX        =   2566
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Exam.Date"
         ForeColor       =   0
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
      Begin Threed.SSPanel SSPanel2 
         Height          =   360
         Left            =   3330
         TabIndex        =   11
         Top             =   300
         Width           =   1455
         _Version        =   65536
         _ExtentX        =   2566
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Process"
         ForeColor       =   0
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
      Begin Threed.SSPanel SSPanel3 
         Height          =   360
         Left            =   6990
         TabIndex        =   10
         Top             =   285
         Width           =   1455
         _Version        =   65536
         _ExtentX        =   2566
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Section"
         ForeColor       =   0
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
   Begin VB.Frame Frame2 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1995
      Left            =   15
      TabIndex        =   13
      Top             =   1290
      Width           =   11895
      Begin VB.ComboBox cboLn 
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
         Left            =   1665
         Style           =   2  '드롭다운 목록
         TabIndex        =   4
         Top             =   255
         Width           =   1455
      End
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
         Left            =   4815
         Style           =   2  '드롭다운 목록
         TabIndex        =   5
         Top             =   255
         Width           =   1995
      End
      Begin VB.ComboBox cboSty 
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
         Left            =   8460
         Style           =   2  '드롭다운 목록
         TabIndex        =   6
         Top             =   255
         Width           =   1995
      End
      Begin Threed.SSPanel SSPanel4 
         Height          =   360
         Left            =   180
         TabIndex        =   9
         Top             =   255
         Width           =   1455
         _Version        =   65536
         _ExtentX        =   2566
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Assy. Line"
         ForeColor       =   0
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
      Begin Threed.SSPanel SSPanel5 
         Height          =   360
         Left            =   3330
         TabIndex        =   8
         Top             =   255
         Width           =   1455
         _Version        =   65536
         _ExtentX        =   2566
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Component"
         ForeColor       =   0
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
      Begin Threed.SSPanel SSPanel6 
         Height          =   360
         Left            =   6975
         TabIndex        =   0
         Top             =   255
         Width           =   1455
         _Version        =   65536
         _ExtentX        =   2566
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Style"
         ForeColor       =   0
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
      Begin VSFlex7LCtl.VSFlexGrid fspSIZE 
         Height          =   780
         Left            =   180
         TabIndex        =   7
         Top             =   1035
         Width           =   11595
         _cx             =   20452
         _cy             =   1376
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
         FocusRect       =   3
         HighLight       =   0
         AllowSelection  =   -1  'True
         AllowBigSelection=   0   'False
         AllowUserResizing=   0
         SelectionMode   =   0
         GridLines       =   1
         GridLinesFixed  =   2
         GridLineWidth   =   1
         Rows            =   2
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
         AutoResize      =   0   'False
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
         Editable        =   2
         ShowComboButton =   0   'False
         WordWrap        =   0   'False
         TextStyle       =   0
         TextStyleFixed  =   0
         OleDragMode     =   0
         OleDropMode     =   0
         ComboSearch     =   0
         AutoSizeMouse   =   -1  'True
         FrozenRows      =   0
         FrozenCols      =   0
         AllowUserFreezing=   0
         BackColorFrozen =   0
         ForeColorFrozen =   0
         WallPaperAlignment=   9
      End
      Begin Threed.SSPanel sspStyName 
         Height          =   360
         Left            =   6975
         TabIndex        =   27
         Top             =   615
         Width           =   4740
         _Version        =   65536
         _ExtentX        =   8361
         _ExtentY        =   635
         _StockProps     =   15
         ForeColor       =   0
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
      Begin MSComDlg.CommonDialog cndSave 
         Left            =   0
         Top             =   0
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
         DefaultExt      =   "text (*.txt)"
      End
   End
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   9750
      Top             =   150
   End
   Begin VSFlex7LCtl.VSFlexGrid fspView 
      Height          =   3930
      Left            =   30
      TabIndex        =   20
      Top             =   3360
      Width           =   11865
      _cx             =   20929
      _cy             =   6932
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
   Begin MSComctlLib.StatusBar sbrStatus 
      Align           =   2  '아래 맞춤
      Height          =   360
      Left            =   0
      TabIndex        =   19
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
   Begin VB.Frame Frame3 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   660
      Left            =   0
      TabIndex        =   23
      Top             =   7275
      Width           =   11895
      Begin VB.TextBox txtPass 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         IMEMode         =   3  '사용 못함
         Left            =   4260
         MaxLength       =   10
         PasswordChar    =   "@"
         TabIndex        =   32
         Top             =   195
         Width           =   1590
      End
      Begin VB.TextBox txtUser 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   1410
         MaxLength       =   10
         TabIndex        =   30
         Top             =   180
         Width           =   1590
      End
      Begin VB.ComboBox cboApplyLn 
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
         Left            =   8505
         Style           =   2  '드롭다운 목록
         TabIndex        =   24
         Top             =   195
         Width           =   1320
      End
      Begin Threed.SSPanel SSPanel8 
         Height          =   360
         Left            =   7185
         TabIndex        =   25
         Top             =   195
         Width           =   1290
         _Version        =   65536
         _ExtentX        =   2275
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Apply Line"
         ForeColor       =   0
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
      Begin Threed.SSCommand cmdApply 
         Height          =   450
         Left            =   9885
         TabIndex        =   26
         Top             =   150
         Width           =   1920
         _Version        =   65536
         _ExtentX        =   3387
         _ExtentY        =   794
         _StockProps     =   78
         Caption         =   "Applying Stock"
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
      Begin Threed.SSPanel SSPanel7 
         Height          =   360
         Left            =   135
         TabIndex        =   29
         Top             =   180
         Width           =   1260
         _Version        =   65536
         _ExtentX        =   2222
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "User"
         ForeColor       =   0
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
      Begin Threed.SSPanel SSPanel9 
         Height          =   360
         Left            =   2985
         TabIndex        =   31
         Top             =   195
         Width           =   1260
         _Version        =   65536
         _ExtentX        =   2222
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Password"
         ForeColor       =   0
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
      Begin Threed.SSCommand SSCommand2 
         Height          =   420
         Left            =   5850
         TabIndex        =   33
         Top             =   165
         Width           =   960
         _Version        =   65536
         _ExtentX        =   1693
         _ExtentY        =   741
         _StockProps     =   78
         Caption         =   "Login"
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
   Begin VSFlex7LCtl.VSFlexGrid fspForm 
      Height          =   3930
      Left            =   960
      TabIndex        =   35
      Top             =   2505
      Visible         =   0   'False
      Width           =   11865
      _cx             =   20929
      _cy             =   6932
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
End
Attribute VB_Name = "frmMO07VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim vSIZE_COUNT As Variant
Dim vWidth As Variant

Dim Lv_SIZE As Integer  '스프레드의 사이즈 시작 칼럼(0부터 시작)
Dim vGEN_COUNT As Variant
'Dim vCol_Arr As Variant
Dim vWidthLINE As Variant

Dim vMSG As String

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

Private Sub sbHeadExamFromDSP()
   fspForm.Clear
   fspForm.Rows = vGEN_COUNT
   fspForm.FontSize = 8
   fspForm.MergeCells = flexMergeFixedOnly
   fspForm.FixedCols = Lv_SIZE
   'fspSIZE.FrozenCols = Lv_SIZE
   'head
        
   fspForm.MergeCol(0) = True
   fspForm.MergeCol(1) = True
   fspForm.MergeCol(2) = True
   
   fspForm.MergeRow(0) = True
   fspForm.MergeRow(1) = True
   fspForm.MergeRow(2) = True
   
   'fspForm.Cell(flexcpText, 0, 1, 0, 3) = "Examin. WIP Sheet"
   fspForm.Cell(flexcpText, 0, 0, 2, 0) = "LN"
   fspForm.Cell(flexcpText, 0, 1, 2, 1) = "Style"
   fspForm.Cell(flexcpText, 0, 2, 0) = "ME"
   fspForm.Cell(flexcpText, 1, 2, 1) = "WO"
   fspForm.Cell(flexcpText, 2, 2, 2) = "GS"
   
   fspForm.ColWidth(0) = 350
   fspForm.ColWidth(1) = 1200
   fspForm.ColWidth(2) = 400
      
   Call init_sizerun(fspForm)
   
   fspForm.Cell(flexcpAlignment, 0, 0, 2, fspForm.Cols - 1) = 3
   
End Sub

Private Sub sbExamFromDSP()

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
   
   Call sbHeadExamFromDSP
      
   'SQL = ""
   'SQL = SQL & " SELECT ASSY_LINE, SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), "
   'SQL = SQL & "        MAX(FN_GEN(STYLE_CD)), "
   'SQL = SQL & " FROM PM_MPS_HEAD "
   'SQL = SQL & " WHERE USR = '" & PCname & "' "
   'SQL = SQL & " AND PROC = '" & varVAL(0) & "' "
   'SQL = SQL & " AND IVTR_DIV = '" & strSEC & "' "
   'SQL = SQL & " AND SEMI_GOOD_CD = '" & sCOMP & "'"
   'SQL = SQL & " GROUP BY ASSY_LINE, STYLE_CD"
   'SQL = SQL & "  ORDER BY 1, 3 '"
   
   SQL = ""
   SQL = SQL & "SELECT A.ASSY_LINE, SUBSTR(A.STYLE_CD,1,6)||'-'||SUBSTR(A.STYLE_CD,7,3), "
   SQL = SQL & "       FN_GEN(A.STYLE_CD) "
   SQL = SQL & "  FROM ("
   SQL = SQL & "  SELECT ASSY_LINE, STYLE_CD "
   SQL = SQL & "    FROM MP_DAY_IVTR "
   SQL = SQL & "   WHERE YMD  = FN_MM_PDAY('" & strYMD & "') "
   SQL = SQL & "     AND PROC = '" & varVAL(0) & "'"
   SQL = SQL & "     AND IVTR_DIV = '" & strSEC & "' "
   SQL = SQL & "     AND SEMI_GOOD_CD = '" & sCOMP & "'"
   SQL = SQL & "   GROUP BY ASSY_LINE, STYLE_CD"
   SQL = SQL & "  UNION ALL "
      
   SQL = SQL & "  SELECT ASSY_LINE, STYLE_CD "
   SQL = SQL & "    From MP_PROD"
   SQL = SQL & "   Where RST_YMD LIKE '" & Mid(strYMD, 1, 6) & "%' "
   SQL = SQL & "     AND WRITE_DIV    LIKE '%'"
   SQL = SQL & "     AND FACTORY      = 'VJ'"
   SQL = SQL & "     AND PROC         = '" & Mid(varVAL(0), 1, 3) & "' "
   If Mid(varVAL(0), 1, 3) = "UPS" Then
      SQL = SQL & "     AND AREA_CD = '" & varVAL(0) & "'"
      SQL = SQL & "     AND RST_DIV = 'P' "
   Else
      SQL = SQL & "     AND RST_DIV = '" & Mid(strSEC, 1, 1) & "' "
   End If
   SQL = SQL & "     AND ASSY_LINE IN ('1','2','3','4','5','6') "
   SQL = SQL & "     AND SEMI_GOOD_CD = '" & sCOMP & "'"
   SQL = SQL & "   GROUP BY ASSY_LINE, STYLE_CD "
      
   If varVAL(0) = "UPS2" Or varVAL(0) = "UPC2" Then
   Else
      SQL = SQL & "  Union All"
      SQL = SQL & "  SELECT ASSY_LINE, STYLE_CD "
      SQL = SQL & "    From MP_PROD "
      SQL = SQL & "   Where RST_YMD LIKE '" & Mid(strYMD, 1, 6) & "%' "
      SQL = SQL & "     AND WRITE_DIV    LIKE '%'"
      SQL = SQL & "     AND FACTORY      = 'VJ'"
      SQL = SQL & "     AND PROC         = 'FGA'"
      SQL = SQL & "     AND RST_DIV      = 'P'"
      SQL = SQL & "     AND ASSY_LINE IN ('9','10','11','12','13','14','15','16','99') "
      SQL = SQL & "   GROUP BY ASSY_LINE, STYLE_CD "
      SQL = SQL & "  Union All"
   
      SQL = SQL & "  SELECT ASSY_LINE, STYLE_CD "
      SQL = SQL & "    From MP_PROD"
      SQL = SQL & "   Where RST_YMD LIKE '" & Mid(strYMD, 1, 6) & "%' "
      SQL = SQL & "     AND WRITE_DIV    LIKE '%'"
      SQL = SQL & "     AND FACTORY       = 'VJ'"
      If Mid(varVAL(0), 1, 2) = "OS" Or _
         Mid(varVAL(0), 1, 2) = "PH" Or _
         Mid(varVAL(0), 1, 2) = "PU" Or _
         Mid(varVAL(0), 1, 2) = "SP" Then
         SQL = SQL & "     AND PROC    = '" & Mid(varVAL(0), 1, 3) & "' "
         SQL = SQL & "     AND RST_DIV = '" & Mid(strSEC, 1, 1) & "' "
      Else
         SQL = SQL & "     AND PROC    = 'FGA' "
         SQL = SQL & "     AND RST_DIV = 'P' "
      End If
      SQL = SQL & "     AND ASSY_LINE IN ('7','8')"
      SQL = SQL & "   GROUP BY ASSY_LINE, STYLE_CD "
   End If
'   SQL = SQL & "  SELECT ASSY_LINE, STYLE_CD "
'   SQL = SQL & "    FROM MP_PROD "
'   SQL = SQL & "   WHERE RST_YMD  = '" & strYMD & "'"
'   SQL = SQL & "     AND PROC = '" & Mid(varVAL(0), 1, 3) & "'"
'   If Mid(varVAL(0), 1, 3) = "UPS" Then
'      SQL = SQL & "     AND AREA_CD = '" & varVAL(0) & "'"
'      SQL = SQL & "     AND RST_DIV = 'P' "
'   Else
'      SQL = SQL & "     AND RST_DIV = '" & Mid(strSEC, 1, 1) & "' "
'   End If
'   SQL = SQL & "     AND SEMI_GOOD_CD = '" & sCOMP & "'"
'   SQL = SQL & "   GROUP BY ASSY_LINE, STYLE_CD "

   SQL = SQL & "       ) A, "
   SQL = SQL & "( SELECT STYLE_CD "
   SQL = SQL & "   FROM PB_STYLE_ROUT "
   If Mid(varVAL(0), 1, 3) = "PHI" Then
      SQL = SQL & "  WHERE OP_CD = '" & Mid(varVAL(0), 1, 3) & "' "
   Else
      SQL = SQL & "  WHERE SEMI_GOOD_CD = '" & sCOMP & "' "
   End If
   SQL = SQL & "  GROUP BY STYLE_CD"
   SQL = SQL & "       ) B "
   SQL = SQL & "  Where A.STYLE_CD = B.STYLE_CD "
   SQL = SQL & " GROUP BY A.ASSY_LINE, A.STYLE_CD "
   SQL = SQL & " ORDER BY TO_NUMBER(A.ASSY_LINE), A.STYLE_CD "
   
'---------------FGW---------------
   If varVAL(0) = "FGW" Then
   
      SQL = ""
      SQL = SQL & "SELECT PLANT_CD, SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), "
      SQL = SQL & "       MAX(FN_GEN(STYLE_CD)) "
      SQL = SQL & "  FROM "
      SQL = SQL & "("
      SQL = SQL & "SELECT DECODE(PLANT_CD,'VJ','1',PLANT_CD) AS PLANT_CD, STYLE_CD "
      SQL = SQL & "  FROM NM_GMONSTK_HEAD "
      SQL = SQL & " WHERE YYMM = '" & Mid(strYMD, 1, 6) & "' "
      SQL = SQL & " GROUP BY PLANT_CD, STYLE_CD "
      SQL = SQL & "UNION ALL "
      SQL = SQL & "SELECT DECODE(PLANT_CD,'VJ','1',PLANT_CD) AS PLANT_CD, STYLE_CD "
      SQL = SQL & "  FROM NM_GHEAD "
      SQL = SQL & " WHERE YMD LIKE '" & Mid(strYMD, 1, 6) & "%' "
      SQL = SQL & " GROUP BY PLANT_CD, STYLE_CD "
      SQL = SQL & ")"
      SQL = SQL & "GROUP BY PLANT_CD, STYLE_CD "
      SQL = SQL & "ORDER BY TO_NUMBER(PLANT_CD), STYLE_CD "
      
   End If
'---------------------------------
   
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If IsArray(arrDATA) Then
      
      fspForm.Rows = fspForm.FixedRows + UBound(arrDATA, 2) + 1
      For i = 0 To UBound(arrDATA, 2) Step 1
         fspForm.Row = i + fspForm.FixedRows
         fspForm.Col = 0
         fspForm.Text = arrDATA(0, i)
         
         fspForm.Col = 1
         fspForm.Text = arrDATA(1, i)
         
         fspForm.Col = 2
         fspForm.Text = arrDATA(2, i)
      Next i
      fspForm.Cell(flexcpAlignment, 0, 0, fspForm.Rows - 1, 2) = 4
      
   Else
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
  
   
   Call sbExamFormPrint
End Sub

Private Sub sbExamFormPrint()
   Dim vOldWidth1 As Integer
   Dim vOldWidth2 As Integer
   Dim vOldWidth3 As Integer
   Dim i As Integer
   
   Dim strYMD As String
   Dim lngRTN As Long
   Dim buffer As String
   Dim varVAL As Variant
   Dim strSEC As String
   Dim sCOMP As String
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   If Trim(fnCboValue(cboProc)) = "" Then
      Exit Sub
   End If
   varVAL = Split(fnCboValue(cboProc), ".")
   
   strSEC = fnCboDesc(cboSec)
   If Trim(strSEC) = "" Then
      Exit Sub
   End If
   
   sCOMP = fnCboValue(cboComp)
   If Trim(sCOMP) = "" Then
      Exit Sub
   End If
   
   fspForm.AddItem "" & vbTab & "", 0
   
   fspForm.Cell(flexcpText, 0, 0, 0, 2) = "Examin. WIP"
   fspForm.Cell(flexcpFontSize, 0, 0, 0, 2) = 12
   fspForm.Cell(flexcpFontBold, 0, 0, 0, 2) = True
   'fspForm.Cell(flexcpFontUnderline, 0, 0, 0, 2) = True
   fspForm.Cell(flexcpText, 0, 3, 0, fspForm.Cols - 1) = "Date: " & Format(dtpYMD.Value, "YYYY/MM/DD") & Space(4) & _
                                                       "Process: " & varVAL(0) & Space(4) & _
                                                       "Section: " & strSEC & Space(4) & _
                                                       "Component: " & sCOMP & Space(4) & _
                                                       "Print Date: " & Format(Now, "YYYY/MM/DD HH:MM:SS")
   fspForm.Cell(flexcpAlignment, 0, 3, 0, fspForm.Cols - 1) = 8
   fspForm.Cell(flexcpBackColor, 0, 0, 0, fspForm.Cols - 1) = vbWhite
   
   fspForm.MergeRow(0) = True
   fspForm.RowHeightMax = 900
   fspForm.RowHeightMax = 300
   fspForm.RowHeight(0) = 1000
   
   
   For i = 4 To fspForm.Cols - 1 Step 1
      fspForm.ColWidth(i) = 500
   Next i
   
   'fspForm.ColWidth(1) = 1000
   'fspForm.ColWidth(2) = 100
   
   fspForm.FixedRows = 4
   
   
   If fspSIZE.TextMatrix(1, 0) = "-7" Then
      Call SbSAVEFILE
   Else
      fspForm.PrintGrid "", True, 2, 100, 250
   End If
   
   
   fspForm.RemoveItem 0
   
   fspForm.FixedRows = 3
End Sub

Sub SbSAVEFILE()
   
   If fspSIZE.TextMatrix(1, 0) = "-7" Then
      'cndSave.DefaultExt = "*.txt"
      
      cndSave.ShowSave
      If cndSave.FileName = "" Then
      Else
         On Error GoTo err_rtn
         fspForm.SaveGrid cndSave.FileName, flexFileTabText, True
      End If
   End If
   Exit Sub
err_rtn:
   Call sbMsgDsp("Can not file open!", gMsgDspSec)
   
End Sub


Private Function fnChkFGAPO() As Boolean
   Dim varVAL As Variant
   
   If fnCboValue(cboProc) = "" Then
      fnChkFGAPO = False
      Exit Function
   End If
   
   varVAL = Split(fnCboValue(cboProc), ".")
   If varVAL(0) = "FGW" Then
      fnChkFGAPO = True
   ElseIf varVAL(0) = "FGA" And fnCboValue(cboSec) = "PO" Then
      fnChkFGAPO = True
   Else
      fnChkFGAPO = False
   End If
End Function

Private Sub sbCheckLine()
   
   If fnChkFGAPO Then
      cboLn.Enabled = False
      Call sbLetCbo(cboLn, "1")
   Else
      cboLn.Enabled = True
   End If
   
End Sub


Private Sub cboComp_Click()
   Call sbSizeDSP
End Sub

Private Sub cboLn_Click()
   Call sbSetCboSTY(fnCboValue(cboLn))
End Sub

Private Sub cboProc_Click()
  Dim varVAL As Variant
  Dim varSec As Variant
  Dim SQL As String
  Dim i As Integer
  Dim strIN As String
  Dim strRtn As String
  
  Call sbCheckLine
  
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
   
   If Mid(arg_OPCD, 1, 3) & arg_RstDiv = "FGAP" Or Mid(arg_OPCD, 1, 3) = "FGW" Then
      cboComp.Clear
      cboComp.AddItem "F/N Goods" + Space(51) & Chr$(27) & "FG"
      cboComp.AddItem Space(60) & Chr$(27) & ""
   Else
      SQL = ""
      SQL = SQL & "SELECT SEMI_GOOD_CD, MAX(FN_MM_CDNAME('PA01',SEMI_GOOD_CD)) "
      SQL = SQL & "  FROM MP_APPLY "
      SQL = SQL & " WHERE OP_CD LIKE '" & Mid(arg_OPCD, 1, 3) & "%' "
      SQL = SQL & "   AND RST_DIV LIKE '" & arg_RstDiv & "%' "
      SQL = SQL & " GROUP BY SEMI_GOOD_CD "
      SQL = SQL & " ORDER BY 1 "
      
      strRtn = fnSetCbo(cboComp, SQL)
   End If

End Sub


Private Sub sbSetCboSTY(arg_LN As String)
   Dim SQL As String
   Dim strRtn As String
   
   SQL = ""
   SQL = SQL & "SELECT STYLE_CD||'|'||MAX(FN_MODEL2(STYLE_CD)), SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3) "
   SQL = SQL & "  FROM PM_MPS_HEAD "
   If cboLn.Enabled Then
      SQL = SQL & " WHERE RES_CD = '" & arg_LN & "' "
      SQL = SQL & "   AND STATUS_ORD IN ('X','R') "
   Else
      SQL = SQL & " WHERE STATUS_ORD IN ('X','R') "
   End If
   SQL = SQL & " GROUP BY STYLE_CD "
   SQL = SQL & " ORDER BY 1 "
   
   strRtn = fnSetCbo(cboSty, SQL)

End Sub


Private Sub cboSec_Click()
   Dim varVAL As Variant
     
   Call sbCheckLine
     
   varVAL = Split(fnCboValue(cboProc), ".")
   Call sbSetCboComp(CStr(varVAL(0)), IIf(CStr(varVAL(0)) = "UPS" Or CStr(varVAL(0)) = "PUS", "P", Mid(fnCboValue(cboSec), 1, 1)))
  
   If Trim(fnCboValue(cboProc)) <> "" Then
      Call cmdSearch_Click
   End If
End Sub

Private Sub cboSty_Click()
   Dim varVAL As Variant
   
   varVAL = Split(fnCboValue(cboSty), "|")
   
   If UBound(varVAL) < 0 Then
      Exit Sub
   End If
   sspStyName.Caption = CStr(varVAL(1))
   
   Call sbSizeDSP
   
End Sub

Private Sub cmdApply_Click()
   Dim strRtn As String
   Dim strYMD As String
   Dim vPROC  As Variant
   Dim strSECTION  As String
   Dim strLine As String
   Dim strUSER As String
   Dim SQL As String
   
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   vPROC = Split(fnCboValue(cboProc), ".")
   strSECTION = fnCboValue(cboSec)
   strLine = fnCboValue(cboApplyLn)
   strUSER = txtUser.Text
   
   If strYMD = "" Or CStr(vPROC(0)) = "" Or strSECTION = "" Or strLine = "" Or strUSER = "" Then
      MsgBox "You must input datas of Exam.Date, Process, Section, Apply Line"
      Exit Sub
   End If
   SQL = "BEGIN SP_MM_APPLY_EXAM('" & strYMD & "','" & CStr(vPROC(0)) & "','" & strSECTION & "','" & strLine & "','" & strUSER & "'); END;"
   Screen.MousePointer = 11
   strRtn = fnExecOraSQL2(SQL)
   Screen.MousePointer = 1
   If strRtn = "" Then
   Else
      MsgBox strRtn
   End If
   
   Call sbViewDsp
End Sub

Private Sub cmdDel_Click()
   Dim varProc As Variant
   Dim varSTY As Variant
   Dim strYMD As String
   Dim SQL As Variant
   Dim strRtn As String
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   varProc = Split(fnCboValue(cboProc), ".")
   varSTY = Split(fnCboValue(cboSty), "|")
   
   If fnCboValue(cboProc) = "" Then
      MsgBox "You must input a data of Process."
      Exit Sub
   End If
   
   If fnCboValue(cboSec) = "" Then
      MsgBox "You must input a data of Section."
      Exit Sub
   End If
   
   ReDim SQL(0)
            
   SQL(0) = ""
   SQL(0) = SQL(0) & "DELETE FROM MP_EXAMSTK "
   SQL(0) = SQL(0) & " WHERE YMD          = '" & strYMD & "' "
   SQL(0) = SQL(0) & "   AND PROC         = '" & varProc(0) & "' "
   SQL(0) = SQL(0) & "   AND IVTR_DIV     = '" & fnCboValue(cboSec) & "' "
   SQL(0) = SQL(0) & "   AND ASSY_LINE    = '" & fnCboValue(cboLn) & "' "
   SQL(0) = SQL(0) & "   AND SEMI_GOOD_CD = '" & fnCboValue(cboComp) & "' "
   SQL(0) = SQL(0) & "   AND STYLE_CD     = '" & varSTY(0) & "' "
   
   strRtn = fnExecOraSQL(SQL)
   If strRtn = "" Then
      Call cmdSearch_Click
      Call sbSizeDSP
   Else
      Call sbMsgDsp(strRtn, gMsgDspSec)
   End If
   
End Sub


Private Sub cmdFormReport_Click()
   Call sbExamFromDSP
   
   
End Sub

Private Sub cmdSave_Click()
   Dim varProc As Variant
   Dim varSTY As Variant
   Dim strYMD As String
   Dim SQL As Variant
   Dim i As Integer
   Dim P As Integer
   Dim cn As Integer
   Dim strRtn As String
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   varProc = Split(fnCboValue(cboProc), ".")
   varSTY = Split(fnCboValue(cboSty), "|")
   
   If fnCboValue(cboProc) = "" Then
      MsgBox "You must input a data of Process."
      Exit Sub
   End If
   
   If fnCboValue(cboSec) = "" Then
      MsgBox "You must input a data of Section."
      Exit Sub
   End If
   
   If fnCboValue(cboLn) = "" Then
      MsgBox "You must input a data of Assy. Line."
      Exit Sub
   End If
   
   If fnCboValue(cboComp) = "" Then
      MsgBox "You must input a data of Component."
      Exit Sub
   End If
   
   If fnCboValue(cboSty) = "" Then
      MsgBox "You must input a data of Style."
      Exit Sub
   End If
   
   cn = 0
   For i = 0 To fspSIZE.Cols - 2 Step 1
      If Trim(fspSIZE.TextMatrix(1, i)) = "" Then
      Else
         If IsNumeric(fspSIZE.TextMatrix(1, i)) Then
            cn = cn + 1
         End If
      End If
   Next i
   If cn < 1 Then
      MsgBox "Input the size QTY!"
      Exit Sub
   End If
   ReDim SQL(cn)
      
   P = 0
   
   SQL(P) = SQL(P) & "DELETE FROM MP_EXAMSTK "
   SQL(P) = SQL(P) & " WHERE YMD          = '" & strYMD & "' "
   SQL(P) = SQL(P) & "   AND PROC         = '" & varProc(0) & "' "
   SQL(P) = SQL(P) & "   AND IVTR_DIV     = '" & fnCboValue(cboSec) & "' "
   SQL(P) = SQL(P) & "   AND ASSY_LINE    = '" & fnCboValue(cboLn) & "' "
   SQL(P) = SQL(P) & "   AND SEMI_GOOD_CD = '" & fnCboValue(cboComp) & "' "
   SQL(P) = SQL(P) & "   AND STYLE_CD     = '" & varSTY(0) & "' "
   
   P = P + 1
   For i = 0 To fspSIZE.Cols - 2 Step 1
      If Trim(fspSIZE.TextMatrix(1, i)) = "" Then
      Else
         If IsNumeric(fspSIZE.TextMatrix(1, i)) Then
            SQL(P) = ""
            SQL(P) = SQL(P) & "INSERT INTO MP_EXAMSTK(YMD, PROC, IVTR_DIV, ASSY_LINE, SEMI_GOOD_CD, STYLE_CD, CS_SIZE, PRS_QTY) "
            SQL(P) = SQL(P) & " VALUES('" & strYMD & "',"
            SQL(P) = SQL(P) & "        '" & varProc(0) & "',"
            SQL(P) = SQL(P) & "        '" & fnCboValue(cboSec) & "',"
            SQL(P) = SQL(P) & "        '" & fnCboValue(cboLn) & "',"
            SQL(P) = SQL(P) & "        '" & fnCboValue(cboComp) & "',"
            SQL(P) = SQL(P) & "        '" & varSTY(0) & "',"
            SQL(P) = SQL(P) & "        '" & Trim(fspSIZE.TextMatrix(0, i)) & "',"
            SQL(P) = SQL(P) & "        " & Trim(fspSIZE.TextMatrix(1, i)) & ") "
            P = P + 1
         End If
      End If
   Next i
   
   strRtn = fnExecOraSQL(SQL)
   If strRtn = "" Then
      Call cmdSearch_Click
      Call sbSizeDSP
   Else
      Call sbMsgDsp(strRtn, gMsgDspSec)
   End If
   
End Sub

Private Sub cmdSearch_Click()
   Call sbViewDsp
End Sub

Private Sub dtpYMD_Change()
   If Trim(fnCboValue(cboProc)) <> "" And Trim(fnCboValue(cboSec)) <> "" Then
      Call cmdSearch_Click
   End If
End Sub

Private Sub Form_Load()
   Dim SQL As String
   Dim strRtn As String
   
   lbTitle(0).Caption = "Stock Examination"
   lbTitle(1).Caption = lbTitle(0).Caption
   
   Me.Left = 0
   Me.Top = 0
   
   dtpYMD.Value = frmMO01VJ.dtpYMD.Value
   
   vSIZE_COUNT = 27
     
   vWidth = 500
      
   '======== Form Report ============
   Lv_SIZE = 3
   vGEN_COUNT = 3
      
   ReDim vCol_Arr(1 To Lv_SIZE)
   
   vWidthLINE = 450
   '=================================
         
   'Getting Process
   SQL = " SELECT DCODE||'.'||REMARK1, CD_NAME FROM CM_CODE WHERE MCODE = 'MP07' AND DCODE <> '0000' ORDER BY DCODE "
   strRtn = fnSetCbo(cboProc, SQL)
   
   SQL = " SELECT ASSY_LINE, ASSY_LINE FROM MP_APPLY WHERE OP_CD = 'OSP' AND RST_DIV = 'P' ORDER BY 1 "
   strRtn = fnSetCbo(cboLn, SQL)
   
   SQL = " SELECT 'ALL', 'ALL' FROM DUAL UNION ALL SELECT ASSY_LINE, ASSY_LINE FROM MP_APPLY WHERE OP_CD = 'OSP' AND RST_DIV = 'P' ORDER BY 1 "
   strRtn = fnSetCbo(cboApplyLn, SQL)
   
   Call sbHeadSizeDSP("ME")
   Call sbHeadViewDsp
   
End Sub


Private Sub sbViewDsp()
   Dim SQL As String
   Dim arrDATA As Variant
   Dim varVAL As Variant
   
   varVAL = Split(fnCboValue(cboProc), ".")
   
   Call sbHeadViewDsp
   
   Call sbHeadSizeDSP("ME")
   
   'vPARAM: 0:ymd, 1:inout_div, 2:loc_div, 3:work_div
   SQL = ""
   SQL = SQL & " SELECT ASSY_LINE, SEMI_GOOD_CD, SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), MAX(FN_MODEL2(STYLE_CD)), SUM(PRS_QTY), SUM(STK_QTY), SUM(ADJ_QTY) "
   SQL = SQL & "   FROM MP_EXAMSTK "
   SQL = SQL & "  WHERE YMD      = '" & Format(dtpYMD.Value, "YYYYMMDD") & "' "
   SQL = SQL & "    AND PROC     = '" & varVAL(0) & "' "
   SQL = SQL & "    AND IVTR_DIV = '" & fnCboValue(cboSec) & "' "
   SQL = SQL & "  GROUP BY ASSY_LINE, SEMI_GOOD_CD, STYLE_CD "
   SQL = SQL & "  ORDER BY 1,2,3 "
   
   Screen.MousePointer = 11
   arrDATA = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If IsArray(arrDATA) Then
      'vFixedCols = fspview.FixedCols
      'fspview.FixedCols = 0
      fspView.LoadArray arrDATA
      
   Else
      If arrDATA = "" Then
         Call sbMsgDsp("Can not find carton data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   'fspview.Cell(flexcpBackColor, fspLine.Rows - 1, 3, fspLine.Rows - 1, fspLine.Cols - 1) = vbYellow
   fspView.Subtotal flexSTSum, 1, 4, "#####", vbYellow, , , ""
   fspView.Subtotal flexSTSum, 1, 5, "#####", vbYellow, , , ""
   fspView.Subtotal flexSTSum, 1, 6, "#####", vbYellow, , , ""
   fspView.Cell(flexcpAlignment, fspView.FixedRows, 0, fspView.Rows - 1, 2) = 4
   fspView.Cell(flexcpAlignment, fspView.FixedRows, 3, fspView.Rows - 1, 3) = 1
   fspView.Cell(flexcpAlignment, fspView.FixedRows, 4, fspView.Rows - 1, 6) = 7
            
End Sub

Private Sub sbHeadViewDsp()
            
   fspView.Clear
   
   fspView.FontSize = 9
   'fspVIEW.FixedCols = 0
   'fspLine.FrozenCols = 4
   fspView.Cols = 7
   fspView.MergeCells = flexMergeFree
   fspView.MergeCol(0) = True
   fspView.MergeCol(2) = True
   
   fspView.Cell(flexcpText, 0, 0) = "Line"
   fspView.Cell(flexcpText, 0, 1) = "Component"
   fspView.Cell(flexcpText, 0, 2) = "Style"
   fspView.Cell(flexcpText, 0, 3) = "Model Name"
   fspView.Cell(flexcpText, 0, 4) = "Examin QTY"
   fspView.Cell(flexcpText, 0, 5) = "Stock QTY"
   fspView.Cell(flexcpText, 0, 6) = "Adjusted QTY"
   
   fspView.ColWidth(0) = 1100
   fspView.ColWidth(1) = 1100
   fspView.ColWidth(2) = 1500
   fspView.ColWidth(3) = 3350
   fspView.ColWidth(4) = 1500
   fspView.ColWidth(5) = 1500
   fspView.ColWidth(6) = 1500
   
   fspView.RowHeightMax = "250"
   fspView.RowHeightMin = "250"
   
   fspView.Cell(flexcpAlignment, 0, 0, 0, fspView.Cols - 1) = 4
   
   fspView.Rows = 1
   
End Sub


'Private Sub Form_Unload(Cancel As Integer)
'   Call frmMO01VJ.sbDspData(Format(frmMO01VJ.dtpYMD.Value, "YYYYMMDD"), "ALL")
'   If frmMO01VJ.chkAutoScan.Value = 1 Then
'      frmMO01VJ.tmrScan.Enabled = True
'   End If
'End Sub


Private Sub fspSIZE_AfterEdit(ByVal Row As Long, ByVal Col As Long)
   Dim i As Integer
   
   If IsNumeric(fspSIZE.TextMatrix(1, i)) Then
      fspSIZE.TextMatrix(1, fspSIZE.Cols - 1) = CLng(IIf(Trim(fspSIZE.TextMatrix(1, fspSIZE.Cols - 1)) = "", "0", fspSIZE.TextMatrix(1, fspSIZE.Cols - 1))) + CLng(fspSIZE.TextMatrix(1, i))
   End If
   
End Sub

Private Sub fspView_Click()
   Dim varArr As Variant
   Dim Row As Long
   
   Row = fspView.Row
   If Row = fspView.Rows - 1 Then
      Exit Sub
   End If
   
   If UCase(Mid(fspView.TextMatrix(Row, 1), 1, 1)) = "T" Then
      Exit Sub
   End If
   
   ReDim varArr(3) As String
   
   varArr(0) = fspView.TextMatrix(Row, 0)                   'Line
   varArr(1) = fspView.TextMatrix(Row, 1)                   'Comp
   varArr(2) = Replace(fspView.TextMatrix(Row, 2), "-", "") 'STYLE_CD
   varArr(3) = Mid(fspView.TextMatrix(Row, 3), 1, 2)        'GEN
   
   Call sbLetCbo(cboLn, CStr(varArr(0)))
   Call sbLetCbo(cboComp, CStr(varArr(1)))
   Call sbLetCbo(cboSty, CStr(varArr(2)) & "|" & fspView.TextMatrix(Row, 3))
   sspStyName.Caption = fspView.TextMatrix(Row, 3)
   
   Call sbSizeDSP
   
End Sub

Private Sub sbSizeDSP()
   Dim SQL As String
   Dim arrDATA As Variant
   Dim varVAL As Variant
   Dim i As Integer
   Dim j As Integer
   Dim vCol As Integer
   Dim vsum As Long
   Dim varSTY As Variant
   
   If Trim(fnCboValue(cboProc)) = "" Or Trim(fnCboValue(cboSec)) = "" Or Trim(fnCboValue(cboComp)) = "" _
      Or Trim(fnCboValue(cboLn)) = "" Or Trim(fnCboValue(cboSty)) = "" Then
      Exit Sub
   End If
   
   varVAL = Split(fnCboValue(cboProc), ".")
   varSTY = Split(fnCboValue(cboSty), "|")
   
   Call sbHeadSizeDSP(Mid(CStr(varSTY(1)), 1, 2))
      
   SQL = ""
   SQL = SQL & " SELECT CS_SIZE, " '
   SQL = SQL & "        PRS_QTY " '5
   SQL = SQL & "   FROM MP_EXAMSTK "
   SQL = SQL & "  WHERE YMD          = '" & Format(dtpYMD.Value, "YYYYMMDD") & "' "
   SQL = SQL & "    AND PROC         = '" & varVAL(0) & "' "
   SQL = SQL & "    AND IVTR_DIV     = '" & fnCboValue(cboSec) & "' "
   SQL = SQL & "    AND ASSY_LINE    = '" & fnCboValue(cboLn) & "' "
   SQL = SQL & "    AND SEMI_GOOD_CD = '" & fnCboValue(cboComp) & "' "
   SQL = SQL & "    AND STYLE_CD     = '" & varSTY(0) & "' "
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
   
   fspSIZE.Rows = 2
   For i = 0 To UBound(arrDATA, 2) Step 1
      vCol = 99
      For j = 0 To fspSIZE.Cols - 2 Step 1
         If CStr(arrDATA(0, i)) = fspSIZE.TextMatrix(0, j) Then
            vCol = j
            Exit For
         End If
      Next j
      If vCol = 99 Then
         For j = 0 To fspSIZE.Cols - 2 Step 1
            If UCase(fspSIZE.TextMatrix(0, j)) = "X" Then
               vCol = j
               Exit For
            End If
         Next j
         If vCol = 99 Then
            fspSIZE.Cols = fspSIZE.Cols + 1
            fspSIZE.ColWidth(fspSIZE.Cols - 2) = vWidth
            fspSIZE.TextMatrix(0, fspSIZE.Cols - 2) = arrDATA(0, i)
            vCol = fspSIZE.Cols - 2
            
            fspSIZE.ColWidth(fspSIZE.Cols - 1) = vWidth + 100
            fspSIZE.TextMatrix(0, fspSIZE.Cols - 1) = "Total"
         End If
      End If
      fspSIZE.TextMatrix(1, vCol) = IIf(IsNull(arrDATA(1, i)), "", arrDATA(1, i))
   Next i
   
   'Total
   vsum = 0
   For j = 0 To fspSIZE.Cols - 2 Step 1
      vsum = vsum + CLng(fnNVZ(fspSIZE.TextMatrix(1, j)))
   Next j
   
   fspSIZE.TextMatrix(1, fspSIZE.Cols - 1) = vsum
      
   
End Sub


Private Sub sbHeadSizeDSP(arg_Gen As String)
   Dim vsize_arr As Variant
   Dim vSIZE_COL As Integer
   Dim i As Single
   Dim j As Integer
   Dim k As Integer

On Error GoTo ErrGo
   
   vSIZE_COL = 0
   
   fspSIZE.Clear
   fspSIZE.FontSize = 8
   fspSIZE.Rows = 2
   fspSIZE.Cols = vSIZE_COL + vSIZE_COUNT
   
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
   
      For i = 1 To 7.5 Step 0.5
         If i = CInt(i) Then
            vsize_arr(k) = CStr(i)
         Else
            vsize_arr(k) = CStr(i - 0.5) & "T"
         End If
         k = k + 1
      Next
   End Select
   
   For j = 0 To vSIZE_COUNT - 1 Step 1
      fspSIZE.TextMatrix(0, j + vSIZE_COL) = vsize_arr(j)
   Next
   
   fspSIZE.Cols = vSIZE_COUNT + 1
   fspSIZE.TextMatrix(0, vSIZE_COUNT) = "Total"
   For i = vSIZE_COL To fspSIZE.Cols - 2 Step 1
      fspSIZE.ColWidth(i) = vWidth
   Next
   fspSIZE.ColWidth(i) = vWidth + 100
   fspSIZE.Cell(flexcpAlignment, 0, vSIZE_COL, fspSIZE.Rows - 1, fspSIZE.Cols - 1) = 4
   
   For i = 0 To fspSIZE.Cols - 1 Step 1
      fspSIZE.ColDataType(i) = flexDTLong
   Next
   
   'fspsize.Cell(flexcpAlignment, 0, 1, fspsize.Rows - 1, fspsize.Cols - 1) = 4
   
   Exit Sub
ErrGo:
   Call sbMsgDsp("Size Run Head Error!", gMsgDspSec)
   
End Sub

Private Sub SSCommand1_Click()
   Unload frmMO07VJ
End Sub


Private Sub sbMsgDsp(arg_TXT As Variant, arg_ITVL As Integer)
   tmr1.Enabled = False
   sbrStatus.Panels.Item(1).Text = ""
   sbrStatus.Panels.Item(1).Text = arg_TXT
   tmr1.Interval = arg_ITVL * 1000
   tmr1.Enabled = True
End Sub

Private Sub SSCommand2_Click()
   Dim strRtn As String
   
   If Trim(txtUser.Text) = "" Or Trim(txtPass.Text) = "" Then
      Exit Sub
   End If
   
   If Trim(txtUser.Text) = "sykim" Or Trim(txtUser.Text) = "hong" Or Trim(txtUser.Text) = "admin" Then
   
      strRtn = fnPass(Trim(txtUser.Text), Trim(txtPass.Text))
      If strRtn = "Y" Then
         cmdApply.Enabled = True
      Else
         cmdApply.Enabled = False
      End If
   End If
End Sub

Private Sub tmr1_Timer()
   sbrStatus.Panels.Item(1).Text = ""
   tmr1.Enabled = False
End Sub


