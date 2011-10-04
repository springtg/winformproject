VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "THREED32.OCX"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO17VJ 
   Caption         =   "MES-MO17VJ"
   ClientHeight    =   6795
   ClientLeft      =   1290
   ClientTop       =   1245
   ClientWidth     =   9480
   LinkTopic       =   "Form1"
   ScaleHeight     =   6795
   ScaleWidth      =   9480
   Begin Threed.SSPanel SSPanel1 
      Height          =   645
      Left            =   -15
      TabIndex        =   16
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
         TabIndex        =   19
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
         TabIndex        =   22
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
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand cmdSearch 
         Height          =   435
         Left            =   6180
         TabIndex        =   23
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
         TabIndex        =   26
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
         Enabled         =   0   'False
      End
      Begin VB.Label lbTitle 
         BackStyle       =   0  '투명
         Caption         =   "Etc. Prod. Result"
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
         TabIndex        =   18
         Top             =   180
         Width           =   5790
      End
      Begin VB.Label lbTitle 
         BackStyle       =   0  '투명
         Caption         =   "Etc. Prod. Result"
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
         TabIndex        =   17
         Top             =   150
         Width           =   5790
      End
      Begin VB.Image Image1 
         Height          =   585
         Left            =   0
         Picture         =   "frmMO17VJ.frx":0000
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
      TabIndex        =   15
      Top             =   570
      Width           =   11895
      Begin VB.ComboBox cboFlow 
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
         Left            =   9945
         Style           =   2  '드롭다운 목록
         TabIndex        =   32
         Top             =   270
         Width           =   1830
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
         Left            =   7785
         Style           =   2  '드롭다운 목록
         TabIndex        =   3
         Top             =   285
         Width           =   2115
      End
      Begin VB.ComboBox cboDiv 
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
         Left            =   4650
         Style           =   2  '드롭다운 목록
         TabIndex        =   2
         Top             =   285
         Width           =   1485
      End
      Begin MSComCtl2.DTPicker dtpYMD 
         Height          =   360
         Left            =   1590
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
         Format          =   23789569
         CurrentDate     =   37956
         MinDate         =   37956
      End
      Begin Threed.SSPanel sspInfo 
         Height          =   360
         Left            =   105
         TabIndex        =   13
         Top             =   285
         Width           =   1455
         _Version        =   65536
         _ExtentX        =   2566
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Prod.Date"
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
         Left            =   3165
         TabIndex        =   29
         Top             =   285
         Width           =   1455
         _Version        =   65536
         _ExtentX        =   2566
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Div"
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
         Left            =   6300
         TabIndex        =   30
         Top             =   285
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
      TabIndex        =   14
      Top             =   1290
      Width           =   11895
      Begin VB.ComboBox cboSTY 
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
         TabIndex        =   33
         Top             =   630
         Width           =   1860
      End
      Begin VB.ComboBox cboGen 
         Enabled         =   0   'False
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
         Left            =   3540
         Style           =   2  '드롭다운 목록
         TabIndex        =   7
         Top             =   630
         Width           =   1080
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
         Left            =   7785
         Style           =   2  '드롭다운 목록
         TabIndex        =   6
         Top             =   240
         Width           =   1995
      End
      Begin VB.ComboBox cboLn2 
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
         Left            =   3540
         Style           =   2  '드롭다운 목록
         TabIndex        =   5
         Top             =   255
         Visible         =   0   'False
         Width           =   1080
      End
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
         Top             =   240
         Width           =   1860
      End
      Begin Threed.SSPanel SSPanel4 
         Height          =   360
         Left            =   180
         TabIndex        =   12
         Top             =   240
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
      Begin Threed.SSPanel SSPanel6 
         Height          =   360
         Left            =   180
         TabIndex        =   0
         Top             =   615
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
         TabIndex        =   11
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
         Height          =   345
         Left            =   4605
         TabIndex        =   25
         Top             =   615
         Width           =   5145
         _Version        =   65536
         _ExtentX        =   9075
         _ExtentY        =   609
         _StockProps     =   15
         ForeColor       =   0
         BackColor       =   13160660
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.76
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin Threed.SSPanel SSPanel5 
         Height          =   360
         Left            =   6300
         TabIndex        =   31
         Top             =   240
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
   End
   Begin VB.Timer tmr1 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   9750
      Top             =   150
   End
   Begin VSFlex7LCtl.VSFlexGrid fspView 
      Height          =   3930
      Left            =   15
      TabIndex        =   21
      Top             =   3285
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
      TabIndex        =   20
      Top             =   6435
      Width           =   9480
      _ExtentX        =   16722
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
      TabIndex        =   24
      Top             =   7275
      Width           =   11895
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
         Left            =   2160
         MaxLength       =   10
         TabIndex        =   8
         Top             =   195
         Width           =   2055
      End
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
         Left            =   6720
         MaxLength       =   10
         PasswordChar    =   "@"
         TabIndex        =   9
         Top             =   195
         Width           =   2010
      End
      Begin Threed.SSPanel SSPanel7 
         Height          =   360
         Left            =   135
         TabIndex        =   27
         Top             =   180
         Width           =   2000
         _Version        =   65536
         _ExtentX        =   3528
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
         Left            =   4695
         TabIndex        =   28
         Top             =   195
         Width           =   2000
         _Version        =   65536
         _ExtentX        =   3528
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
         Height          =   435
         Left            =   9315
         TabIndex        =   10
         Top             =   150
         Width           =   2415
         _Version        =   65536
         _ExtentX        =   4260
         _ExtentY        =   767
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
End
Attribute VB_Name = "frmMO17VJ"
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
Dim VwriteDiv As String

Dim vMSG As String

Dim vDiv As String
Dim vLn As String
Dim vMini_Ln As String
Dim vPO As String
Dim vSTY As String


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

Private Sub cboDiv_Click()
   Dim varV1 As Variant
   Dim varV2 As Variant
   Dim strV As String
   Dim strRtn As String
   Dim SQL As String
   Dim i As Integer
   
   strV = fnCboValue(cboDiv)
   If Trim(strV) = "" Then
      Exit Sub
   End If
   
   varV1 = Split(strV, ".")
   vDiv = CStr(varV1(0))    'Reason
   
   '============== LINE ===============
   varV2 = varV1(2)
   
   Select Case vDiv
   Case "SS"
      SQL = "SELECT PLANT_CD||'-'||LEAD_TYPE, PLANT_DESC FROM NA_GEN_PARA ORDER BY TO_NUMBER(PLANT_CD) "
   Case "FT"
      SQL = "SELECT PLANT_CD||'-'||LEAD_TYPE, PLANT_DESC FROM NA_GEN_PARA WHERE TO_NUMBER(PLANT_CD) BETWEEN 1 AND 6 ORDER BY TO_NUMBER(PLANT_CD) "
   Case "ID"
      SQL = "SELECT PLANT_CD||'-'||LEAD_TYPE, PLANT_DESC FROM NA_GEN_PARA WHERE PLANT_CD = '" & varV2 & "' "
   Case Else
      SQL = "SELECT PLANT_CD||'-'||LEAD_TYPE, PLANT_DESC FROM NA_GEN_PARA ORDER BY TO_NUMBER(PLANT_CD) "
   End Select
   
   strRtn = fnSetCbo(cboLn, SQL)
   vLn = ""
   
   vPO = ""
   
   '=============== cboSTY ============
   SQL = "       SELECT A.STYLE_CD||'|'||MAX(A.GEN)||'|'||MAX(A.STYLE_NAME), A.STYLE_CD "
   Select Case vDiv
   Case "SS"
      SQL = SQL & "   FROM EM_OBS_HEAD B, DA_STYLE A "
      SQL = SQL & "  WHERE B.PO_ID BETWEEN SUBSTR(TO_CHAR(ADD_MONTHS(SYSDATE,-12),'YYYY'),3,2)||'0112' AND SUBSTR(TO_CHAR(ADD_MONTHS(SYSDATE,12),'YYYY'),3,2)||'0112' "
      SQL = SQL & "    AND B.PO_TYPE = 'SS' "
      SQL = SQL & "    AND B.FACTORY = '" & gFactory & "' "
      SQL = SQL & "    AND B.STYLE_CD = A.STYLE_CD"
      
   Case "FT"
      
      SQL = SQL & "   FROM PM_MPS_HEAD B, DA_STYLE A "
      SQL = SQL & "  WHERE B.PO_TYPE = 'FT' "
      SQL = SQL & "    AND B.STATUS_ORD <> 'X' "
      SQL = SQL & "    AND TO_NUMBER(B.RES_CD) BETWEEN 1 AND 6 "
      SQL = SQL & "    AND B.STYLE_CD = A.STYLE_CD"
      
   Case "ID"
      SQL = SQL & "   FROM DA_STYLE A "
      SQL = SQL & "  WHERE A.REMARK = 'ID' "
      
   Case Else
      SQL = SQL & "   FROM EM_OBS_HEAD B, DA_STYLE A "
      SQL = SQL & "  WHERE B.PO_ID BETWEEN TO_CHAR(ADD_MONTHS(SYSDATE,-6),'YYMM')||'00' AND TO_CHAR(ADD_MONTHS(SYSDATE,+6),'YYMM')||'99' "
      SQL = SQL & "    AND B.FACTORY = '" & gFactory & "' "
      SQL = SQL & "    AND B.STYLE_CD = A.STYLE_CD"
   End Select
   SQL = SQL & "  GROUP BY A.STYLE_CD "
   SQL = SQL & "  ORDER BY 1 "
   strRtn = fnSetCbo(cboSTY, SQL)
   
'   '============== PO ================
'   cboPo.Clear
'
'   If vDiv = "FT" Then
'
'      sspPO.Caption = "PO"
'      SQL = "     SELECT A.PO_NO||'-'||A.PO_TYPE, A.PO_NO||A.PO_TYPE "
'      SQL = SQL & " FROM PM_MPS_HEAD A, NA_GEN_PARA B "
'      SQL = SQL & " WHERE A.RES_CD    = B.PLANT_CD "
'      SQL = SQL & "   AND B.LEAD_TYPE = '2'"
'      SQL = SQL & "   AND A.PO_NO     BETWEEN TO_CHAR(ADD_MONTHS(SYSDATE,-3),'YYYYMMDD') AND TO_CHAR(ADD_MONTHS(SYSDATE,1), 'YYYYMMDD')"
'      SQL = SQL & "  GROUP BY A.PO_NO, A.PO_TYPE"
'      strRtn = fnSetCbo(cboDiv, SQL)
'      vPO = ""
'   Else
'
'      sspPO.Caption = "PO TYPE"
'      If Len(varV1(1)) = 2 Then
'         cboPo.AddItem varV1(1) & Space(58) & Chr$(27) & varV1(1)
'
'      Else
'         cboPo.AddItem Left(varV1(1), 2) & Space(58) & Chr$(27) & Left(varV1(1), 2)
'         cboPo.AddItem Right(varV1(1), 2) & Space(58) & Chr$(27) & Right(varV1(1), 2)
'      End If
'      cboPo.Text = cboPo.List(0)
'      vPO = Left(cboPo.Text, 2)
'   End If
      
End Sub

Private Sub sbSetCboComp(arg_Proc As String, arg_flow As String)
   Dim SQL As String
   Dim vardata As Variant
   Dim varV As Variant
   Dim i As Integer
   
   cboComp.Clear
   
   SQL = "      SELECT REMARK1, CD_NAME "
   SQL = SQL & "  FROM CM_CODE "
   SQL = SQL & " WHERE MCODE = 'MP10' "
   SQL = SQL & "    AND DCODE = '" & arg_Proc & arg_flow & "' "
   vardata = fnGetOraData(SQL)
   If IsArray(vardata) Then
      If Len(vardata(0, 0)) = 2 Then
         cboComp.AddItem vardata(0, 0) & Space(59) & Chr$(27) & vardata(0, 0)
      Else
         varV = Split(vardata(0, 0), "/")
         For i = 0 To UBound(varV) Step 1
            cboComp.AddItem varV(i) & Space(59) & Chr$(27) & varV(i)
         Next i
      End If
   End If
   cboComp.AddItem "" & Space(59) & Chr$(27) & ""
   
End Sub



Private Sub cboFlow_Click()
   If fnCboValue(cboProc) = "" Or fnCboValue(cboFlow) = "" Then
   Else
      Call sbSetCboComp(fnCboValue(cboProc), fnCboValue(cboFlow))
   End If
End Sub

Private Sub cboGen_Click()
   Call sbHeadSizeDSP(fnCboValue(cboGen))
End Sub

Private Sub cboLn_Click()
   Dim varV As Variant
   Dim strV As String
   Dim i As Integer
   
   strV = fnCboValue(cboLn)
   If Trim(strV) = "" Then
      Exit Sub
   End If
   
   varV = Split(strV, "-")
   vLn = varV(0)
   'cboLn.Tag = varV(1)
   
   cboLn2.Clear
   If CStr(varV(1)) = "3" Then
      vMini_Ln = ""
      For i = 1 To 6 Step 1
         cboLn2.AddItem i & Space(59) & Chr$(27) & i
      Next i
      cboLn2.Visible = True
   Else
      vMini_Ln = "0"
      cboLn2.AddItem "0" & Space(59) & Chr$(27) & "0"
      cboLn2.Visible = False
   End If
   cboLn2.AddItem "" & Space(59) & Chr$(27) & ""
   'Call sbSetCboSTY(vLn, vPO)
      
End Sub



'Private Sub sbSetCboSTY(arg_LN As String, arg_PO As String)
'   Dim SQL As String
'   Dim strRtn As String
'
'
'   SQL = ""
'   If Right(arg_PO, 2) = "FT" Or Right(arg_PO, 2) = "PS" Then
'      SQL = SQL & "SELECT STYLE_CD||'|'||MAX(FN_MODEL2(STYLE_CD)), SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3) "
'      SQL = SQL & "  FROM PM_MPS_HEAD "
'      SQL = SQL & " WHERE RES_CD = '" & arg_LN & "' "
'      SQL = SQL & "   AND STATUS_ORD IN ('X','R') "
'      SQL = SQL & " GROUP BY STYLE_CD "
'      SQL = SQL & " ORDER BY 1 "
'   End If
'
'   strRtn = fnSetCbo(cboSty, SQL)
'
'End Sub


Private Sub cboSec_Click()
   Dim varVAL As Variant
     
   'Call sbCheckLine
     
   'varVAL = Split(fnCboValue(cboProc), ".")
   'Call sbSetCboComp(CStr(varVAL(0)), IIf(CStr(varVAL(0)) = "UPS" Or CStr(varVAL(0)) = "PUS", "P", Mid(fnCboValue(cboSec), 1, 1)))
   '
   'If Trim(fnCboValue(cboProc)) <> "" Then
   '   Call cmdSearch_Click
   'End If
End Sub

Private Sub cboSty_Click()
   Dim varVAL As Variant
   
   varVAL = Split(fnCboValue(cboSTY), "|")
   
   If UBound(varVAL) < 0 Then
      Exit Sub
   End If
   sspStyName.Caption = CStr(varVAL(1)) & "/" & CStr(varVAL(2))
   
   Call sbLetCbo(cboGen, CStr(varVAL(1)))
      
End Sub


Private Sub cboProc_Click()
   Dim SQL As String
   Dim strRtn As String
   
   SQL = "       SELECT SUBSTR(A.DCODE,4,1), B.CD_NAME "
   SQL = SQL & "   FROM CM_CODE A, CM_CODE B"
   SQL = SQL & "  WHERE A.MCODE = 'MP10' "
   SQL = SQL & "    AND A.DCODE like '" & Mid(fnCboValue(cboProc), 1, 3) & "%' "
   SQL = SQL & "    AND A.REMARK2 = 'Y' "
   SQL = SQL & "    AND B.MCODE = 'MP01' "
   SQL = SQL & "    AND B.DCODE = SUBSTR(A.DCODE,4,1) "
   SQL = SQL & "  ORDER BY B.REMARK1 "
   strRtn = fnSetCbo(cboFlow, SQL)
      
End Sub

Private Sub sbInput_Init()

   Call sbLetCbo(cboLn, "")
   Call sbLetCbo(cboLn2, "")
   cboLn2.Visible = False
   
   Call sbLetCbo(cboComp, "")
   Call sbLetCbo(cboSTY, "")
   Call sbLetCbo(cboGen, "")
   sspStyName.Caption = ""
   
End Sub

Private Sub cmdDel_Click()
   Dim strProc As Variant
   Dim strSTY As Variant
   Dim strYMD As String
   Dim strFlow As String
   Dim varDiv As Variant
   Dim varSTY As Variant
   Dim strLN As String
   Dim strLN2 As String
   Dim strCMP As String
   
   Dim SQL As Variant
   Dim P As Integer
   Dim strRtn As String
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   varDiv = Split(fnCboValue(cboDiv), ".")
   strProc = fnCboValue(cboProc)
   strFlow = fnCboValue(cboFlow)
   
   varSTY = Split(fnCboValue(cboSTY), "|")
   strSTY = varSTY(0)
   
   If fnCboValue(cboDiv) = "" Then
      MsgBox "You have to input a data of Div."
      Exit Sub
   End If
   
   If strProc = "" Then
      MsgBox "You have to input a data of Process."
      Exit Sub
   End If
   
   If strFlow = "" Then
      MsgBox "You must input a data of Section."
      Exit Sub
   End If
   
   strLN = fnCboValue(cboLn)
   strLN = Mid(strLN, 1, InStr(1, strLN, "-") - 1)
   If strLN = "" Then
      MsgBox "You must input a data of Assy. Line."
      Exit Sub
   End If
   
   strLN2 = "0"
   If cboLn2.Visible Then
      strLN2 = fnCboValue(cboLn2)
      If strLN2 = "" Then
         MsgBox "You must input a data of Mini Line."
         Exit Sub
      End If
   End If
   
   strCMP = fnCboValue(cboComp)
   
   If strCMP = "" Then
      MsgBox "You must input a data of Component."
      Exit Sub
   End If
   
   If strSTY = "" Then
      MsgBox "You must input a data of Style."
      Exit Sub
   End If
   
   ReDim SQL(0)
      
   P = 0
   
   SQL(P) = SQL(P) & "DELETE FROM MP_PROD "
   SQL(P) = SQL(P) & "  WHERE RST_YMD   = '" & Format(dtpYMD.Value, "YYYYMMDD") & "' "
   SQL(P) = SQL(P) & "    AND WRITE_DIV = '" & VwriteDiv & "' "
   SQL(P) = SQL(P) & "    AND FACTORY   = '" & gFactory & "' "
   SQL(P) = SQL(P) & "    AND PROC      = '" & Mid(strProc, 1, 3) & "' "
   If Mid(fnCboValue(cboProc), 1, 2) = "UP" Then
      SQL(P) = SQL(P) & "    AND AREA_CD   = '" & strProc & "' "
   End If
   SQL(P) = SQL(P) & "    AND RST_DIV      = '" & strFlow & "' "
   SQL(P) = SQL(P) & "    AND PO_TYPE      = '" & varDiv(0) & "' "
   
   SQL(P) = SQL(P) & "    AND ASSY_LINE    = '" & strLN & "' "
   If cboLn2.Visible Then
      SQL(P) = SQL(P) & " AND MINI_LINE    = '" & strLN2 & "' "
   End If
   SQL(P) = SQL(P) & "    AND SEMI_GOOD_CD = '" & strCMP & "' "
   SQL(P) = SQL(P) & "    AND STYLE_CD     = '" & strSTY & "' "
      
   strRtn = fnExecOraSQL(SQL)
   If strRtn = "" Then
      Call cmdSearch_Click
      'Call sbSizeDSP
      Call sbInput_Init
   Else
      Call sbMsgDsp(strRtn, gMsgDspSec)
   End If
   
End Sub


Private Sub cmdSave_Click()
   Dim strProc As Variant
   Dim strSTY As Variant
   Dim strYMD As String
   Dim strFlow As String
   Dim varDiv As Variant
   Dim varSTY As Variant
   Dim strLN As String
   Dim strLN2 As String
   Dim strCMP As String
   
   Dim SQL As Variant
   Dim i As Integer
   Dim P As Integer
   Dim cn As Integer
   Dim strRtn As String
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   varDiv = Split(fnCboValue(cboDiv), ".")
   strProc = fnCboValue(cboProc)
   strFlow = fnCboValue(cboFlow)
   
   varSTY = Split(fnCboValue(cboSTY), "|")
   strSTY = varSTY(0)
   
   If fnCboValue(cboDiv) = "" Then
      MsgBox "You have to input a data of Div."
      Exit Sub
   End If
   
   If strProc = "" Then
      MsgBox "You have to input a data of Process."
      Exit Sub
   End If
   
   If strFlow = "" Then
      MsgBox "You must input a data of Section."
      Exit Sub
   End If
   
   strLN = fnCboValue(cboLn)
   strLN = Mid(strLN, 1, InStr(1, strLN, "-") - 1)
   
   If strLN = "" Then
      MsgBox "You must input a data of Assy. Line."
      Exit Sub
   End If
   
   strLN2 = "0"
   If cboLn2.Visible Then
      strLN2 = fnCboValue(cboLn2)
      If strLN2 = "" Then
         MsgBox "You must input a data of Mini Line."
         Exit Sub
      End If
   End If
   
   strCMP = fnCboValue(cboComp)
   
   If strCMP = "" Then
      MsgBox "You must input a data of Component."
      Exit Sub
   End If
   
   If strSTY = "" Then
      MsgBox "You must input a data of Style."
      Exit Sub
   End If
   
   '========= next proc ==========
   
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
   
   SQL(P) = SQL(P) & "DELETE FROM MP_PROD "
   SQL(P) = SQL(P) & "  WHERE RST_YMD   = '" & Format(dtpYMD.Value, "YYYYMMDD") & "' "
   SQL(P) = SQL(P) & "    AND WRITE_DIV = '" & VwriteDiv & "' "
   SQL(P) = SQL(P) & "    AND FACTORY   = '" & gFactory & "' "
   SQL(P) = SQL(P) & "    AND PROC      = '" & Mid(strProc, 1, 3) & "' "
   If Mid(fnCboValue(cboProc), 1, 2) = "UP" Then
      SQL(P) = SQL(P) & "    AND AREA_CD   = '" & strProc & "' "
   End If
   SQL(P) = SQL(P) & "    AND RST_DIV      = '" & strFlow & "' "
   SQL(P) = SQL(P) & "    AND PO_TYPE      = '" & varDiv(0) & "' "
   
   SQL(P) = SQL(P) & "    AND ASSY_LINE    = '" & strLN & "' "
   If cboLn2.Visible Then
      SQL(P) = SQL(P) & " AND MINI_LINE    = '" & strLN2 & "' "
   End If
   SQL(P) = SQL(P) & "    AND SEMI_GOOD_CD = '" & strCMP & "' "
   SQL(P) = SQL(P) & "    AND STYLE_CD     = '" & strSTY & "' "
   
   P = P + 1
   For i = 0 To fspSIZE.Cols - 2 Step 1
      If Trim(fspSIZE.TextMatrix(1, i)) = "" Then
      Else
         If IsNumeric(fspSIZE.TextMatrix(1, i)) Then
            SQL(P) = ""
            SQL(P) = SQL(P) & "INSERT INTO MP_PROD(RST_YMD, RST_DIV, WRITE_DIV, "
            SQL(P) = SQL(P) & "                    FACTORY, AREA_CD, PROD_LINE, "
            SQL(P) = SQL(P) & "                    HH, JOB_DIV, DIR_YMD, "
            SQL(P) = SQL(P) & "                    PROC, PO_NO, PO_TYPE, "
            SQL(P) = SQL(P) & "                    STYLE_CD, ASSY_LINE, DAY_SEQ, "
            SQL(P) = SQL(P) & "                    ABC_DIV, CS_SIZE, DEF_PROC, "
            SQL(P) = SQL(P) & "                    INPUT_YN, SEMI_GOOD_CD, MINI_LINE, "
            SQL(P) = SQL(P) & "                    OP_SEQ, ASSY_YMD, LINE_SEQ, "
            SQL(P) = SQL(P) & "                    DEF_SEMI_GOOD_CD, DEF_OP_SEQ, SHIFT, "
            SQL(P) = SQL(P) & "                    PRS_QTY, "
            SQL(P) = SQL(P) & "                    NEXT_AREA_CD, "
            SQL(P) = SQL(P) & "                    NEXT_PROC, "
            SQL(P) = SQL(P) & "                    LAST_SCAN_DT, PH_TYPE, UPD_YMD, "
            SQL(P) = SQL(P) & "                    UPD_USER) "
            SQL(P) = SQL(P) & " VALUES('" & strYMD & "','" & strFlow & "','" & VwriteDiv & "', "
            SQL(P) = SQL(P) & "        '" & gFactory & "', DECODE(SUBSTR('" & strProc & "',1,2),'UP','" & strProc & "',FN_AREA('" & strProc & "')),'" & strLN & "', "
            SQL(P) = SQL(P) & "        '99','1','________', "
            SQL(P) = SQL(P) & "        '" & Mid(strProc, 1, 3) & "','________','" & varDiv(0) & "', "
            SQL(P) = SQL(P) & "        '" & strSTY & "','" & strLN & "',0, "
            SQL(P) = SQL(P) & "        '_','" & Trim(fspSIZE.TextMatrix(0, i)) & "','___', "
            SQL(P) = SQL(P) & "        '_','" & strCMP & "'," & strLN2 & ", "
            SQL(P) = SQL(P) & "        0,'________',0, "
            SQL(P) = SQL(P) & "        '__',0,'A', "
            SQL(P) = SQL(P) & "        " & Trim(fspSIZE.TextMatrix(1, i)) & ", "
            SQL(P) = SQL(P) & "        FN_NEXT_AREA3('" & strSTY & "', '" & Mid(strProc, 1, 3) & "'), "
            SQL(P) = SQL(P) & "        FN_NEXT_PROC3('" & strSTY & "', '" & Mid(strProc, 1, 3) & "'), "
            SQL(P) = SQL(P) & "        '990000', FN_MM_PH_TYPE('" & strSTY & "', '" & Mid(strProc, 1, 3) & "'), SYSDATE,"
            SQL(P) = SQL(P) & "        '" & txtUser.Text & "' "
            SQL(P) = SQL(P) & "        ) "
            
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
   'If Trim(fnCboValue(cboProc)) <> "" And Trim(fnCboValue(cboSec)) <> "" Then
   '   Call cmdSearch_Click
   'End If
End Sub

Private Sub Form_Load()
   Dim SQL As String
   Dim strRtn As String
   
   'cmdSave.Enabled = False
   'cmdDel.Enabled = False
   
   VwriteDiv = "M"
   
   lbTitle(0).Caption = "Etc. Prod. Result"
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
   
   'REASON
   SQL = " SELECT DCODE||'.'||REMARK1||'.'||REMARK2, CD_NAME FROM CM_CODE WHERE MCODE = 'MP09' AND DCODE <> '0000' ORDER BY DCODE "
   strRtn = fnSetCbo(cboDiv, SQL)
         
   SQL = " SELECT DCODE, CD_NAME FROM CM_CODE WHERE MCODE = 'MP07' AND DCODE <> '0000' ORDER BY 1 "
   strRtn = fnSetCbo(cboProc, SQL)
   
   SQL = " SELECT DCODE, DCODE FROM CM_CODE WHERE MCODE = 'EM01' AND DCODE <> '0000' ORDER BY 1 "
   strRtn = fnSetCbo(cboGen, SQL)
   
   Call sbHeadSizeDSP("ME")
   Call sbHeadViewDsp
   
End Sub

'Private Sub sbSetCboLn(arg_v As String)
'   Dim varV1, varV2 As Variant
'   Dim strV As String
'
'   strV = fnCboValue(cboDiv)
'   If Trim(strV) = "" Then
'      Exit Sub
'   End If
'
'   varV1 = Split(strV, ".")
'
'   SQL = " SELECT ASSY_LINE, ASSY_LINE FROM MP_APPLY WHERE OP_CD = 'OSP' AND RST_DIV = 'P' ORDER BY 1 "
'   strRtn = fnSetCbo(cboLn, SQL)
'
'End Sub


Private Sub sbViewDsp()
   Dim SQL As String
   Dim arrDATA As Variant
   Dim varDiv As Variant
   
   varDiv = Split(fnCboValue(cboDiv), ".")
   
   Call sbHeadViewDsp
   
   Call sbHeadSizeDSP("ME")
   
   SQL = ""
   SQL = SQL & " SELECT ASSY_LINE||'-'||MINI_LINE, SEMI_GOOD_CD, SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), MAX(FN_MODEL2(STYLE_CD)), SUM(PRS_QTY) "
   SQL = SQL & "   FROM MP_PROD "
   SQL = SQL & "  WHERE RST_YMD   = '" & Format(dtpYMD.Value, "YYYYMMDD") & "' "
   SQL = SQL & "    AND WRITE_DIV = '" & VwriteDiv & "' "
   SQL = SQL & "    AND FACTORY   = '" & gFactory & "' "
   SQL = SQL & "    AND PROC      = '" & Mid(fnCboValue(cboProc), 1, 3) & "' "
   If Mid(fnCboValue(cboProc), 1, 2) = "UP" Then
      SQL = SQL & "    AND AREA_CD   = '" & fnCboValue(cboProc) & "' "
   End If
   SQL = SQL & "    AND RST_DIV      = '" & fnCboValue(cboFlow) & "' "
   SQL = SQL & "    AND PO_TYPE      = '" & varDiv(0) & "' "
   If CStr(varDiv(0)) = "FT" Then
      SQL = SQL & "    AND TO_NUMBER(ASSY_LINE) BETWEEN 1 AND 6 "
   End If
   SQL = SQL & "  GROUP BY ASSY_LINE, MINI_LINE, SEMI_GOOD_CD, STYLE_CD "
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
         Call sbMsgDsp("Can not find data! ", gMsgDspSec)
      Else
         Call sbMsgDsp(arrDATA, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   'fspview.Cell(flexcpBackColor, fspLine.Rows - 1, 3, fspLine.Rows - 1, fspLine.Cols - 1) = vbYellow
   fspView.Subtotal flexSTSum, 1, 4, "#####", vbYellow, , , ""
   fspView.Cell(flexcpAlignment, fspView.FixedRows, 0, fspView.Rows - 1, 2) = 4
   fspView.Cell(flexcpAlignment, fspView.FixedRows, 3, fspView.Rows - 1, 3) = 1
   fspView.Cell(flexcpAlignment, fspView.FixedRows, 4, fspView.Rows - 1, 4) = 7
            
End Sub

Private Sub sbHeadViewDsp()
            
   fspView.Clear
   
   fspView.FontSize = 9
   'fspVIEW.FixedCols = 0
   'fspLine.FrozenCols = 4
   fspView.Cols = 5
   fspView.MergeCells = flexMergeFree
   fspView.MergeCol(0) = True
   fspView.MergeCol(1) = True
   
   fspView.Cell(flexcpText, 0, 0) = "Line"
   fspView.Cell(flexcpText, 0, 1) = "Component"
   fspView.Cell(flexcpText, 0, 2) = "Style"
   fspView.Cell(flexcpText, 0, 3) = "Model Name"
   fspView.Cell(flexcpText, 0, 4) = "Prod. QTY"
   'fspView.Cell(flexcpText, 0, 4) = "Stock QTY"
   'fspView.Cell(flexcpText, 0, 5) = "Adjusted QTY"
   
   fspView.ColWidth(0) = 1500
   fspView.ColWidth(1) = 1500
   fspView.ColWidth(2) = 2150
   fspView.ColWidth(3) = 4400
   fspView.ColWidth(4) = 2000
   'fspView.ColWidth(4) = 1500
   'fspView.ColWidth(5) = 1500
   
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
   Dim varV As Variant
   Dim Row As Long
   Dim SQL As String
   Dim varTYPE As Variant
   
   Row = fspView.Row
   If Row = fspView.Rows - 1 Then
      Exit Sub
   End If
   
   If UCase(Mid(fspView.TextMatrix(Row, 1), 1, 1)) = "T" Then
      Exit Sub
   End If
   
   ReDim varArr(3) As String
   
   varArr(0) = fspView.TextMatrix(Row, 0)                   'Line
   varV = Split(varArr(0), "-")
   varArr(1) = fspView.TextMatrix(Row, 1)                   'Comp
   varArr(2) = Replace(fspView.TextMatrix(Row, 2), "-", "") 'STYLE_CD
   varArr(3) = Mid(fspView.TextMatrix(Row, 3), 1, 2)        'GEN
   
   SQL = "SELECT LEAD_TYPE FROM NA_GEN_PARA WHERE PLANT_CD = '" & varV(0) & "' "
   varTYPE = fnGetOraData(SQL)
   If IsArray(varTYPE) Then
      Call sbLetCbo(cboLn, varV(0) & "-" & varTYPE(0, 0))
   End If
      
   Call sbLetCbo(cboLn2, CStr(varV(1)))
   Call sbLetCbo(cboComp, CStr(varArr(1)))
   Call sbLetCbo(cboSTY, CStr(varArr(2)) & "|" & CStr(varArr(3)) & "|" & Mid(fspView.TextMatrix(Row, 3), 4, Len(fspView.TextMatrix(Row, 3)) - 3))
   Call sbLetCbo(cboGen, CStr(varArr(3)))
      
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
   Dim strLN As String
   
   
   If Trim(fnCboValue(cboDiv)) = "" Or Trim(fnCboValue(cboProc)) = "" Or Trim(fnCboValue(cboFlow)) = "" _
      Or Trim(fnCboValue(cboLn)) = "" Or Trim(fnCboValue(cboLn2)) = "" Or Trim(fnCboValue(cboComp)) = "" _
      Or Trim(fnCboValue(cboSTY)) = "" Or Trim(fnCboValue(cboGen)) = "" Then
      Exit Sub
   End If
   
   varVAL = Split(fnCboValue(cboDiv), ".")
   
   varSTY = Split(fnCboValue(cboSTY), "|")
   strLN = fnCboValue(cboLn)
   strLN = Mid(strLN, 1, InStr(1, strLN, "-") - 1)
   
   If Trim(fnCboValue(cboGen)) = "" Then
      Call sbHeadSizeDSP("ME")
      Exit Sub
   End If
   
   Call sbHeadSizeDSP(fnCboValue(cboGen))
      
   SQL = ""
   SQL = SQL & " SELECT CS_SIZE, " '
   SQL = SQL & "        PRS_QTY " '5
   SQL = SQL & "   FROM MP_PROD "
   SQL = SQL & "  WHERE RST_YMD   = '" & Format(dtpYMD.Value, "YYYYMMDD") & "' "
   SQL = SQL & "    AND WRITE_DIV = '" & VwriteDiv & "' "
   SQL = SQL & "    AND FACTORY   = '" & gFactory & "' "
   SQL = SQL & "    AND PROC      = '" & Mid(fnCboValue(cboProc), 1, 3) & "' "
   If Mid(fnCboValue(cboProc), 1, 2) = "UP" Then
      SQL = SQL & "    AND AREA_CD   = '" & fnCboValue(cboProc) & "' "
   End If
   SQL = SQL & "    AND RST_DIV      = '" & fnCboValue(cboFlow) & "' "
   SQL = SQL & "    AND PO_TYPE      = '" & varVAL(0) & "' "
   
   SQL = SQL & "    AND ASSY_LINE    = '" & strLN & "' "
   If cboLn2.Visible Then
      SQL = SQL & " AND MINI_LINE    = '" & fnCboValue(cboLn2) & "' "
   End If
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
   Unload frmMO17VJ
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
   
   'If Trim(txtUser.Text) = "sykim" Or Trim(txtUser.Text) = "hong" Or Trim(txtUser.Text) = "admin" Then
   
      strRtn = fnPass(Trim(txtUser.Text), Trim(txtPass.Text))
      If strRtn = "Y" Then
         cmdSave.Enabled = True
         cmdDel.Enabled = True
      
      Else
         cmdSave.Enabled = False
         cmdDel.Enabled = False
      End If
   'End If
End Sub

Private Sub tmr1_Timer()
   sbrStatus.Panels.Item(1).Text = ""
   tmr1.Enabled = False
End Sub



