VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO14VJ 
   Caption         =   "MES-MO14VJ"
   ClientHeight    =   8295
   ClientLeft      =   1290
   ClientTop       =   390
   ClientWidth     =   11910
   BeginProperty Font 
      Name            =   "Microsoft Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   8295
   ScaleWidth      =   11910
   Begin Threed.SSPanel SSPanel1 
      Height          =   645
      Left            =   -15
      TabIndex        =   17
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
      Begin Threed.SSCommand cmdClose 
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
         TabIndex        =   23
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
      Begin VB.Label lbTitle 
         BackStyle       =   0  '투명
         Caption         =   "F/N Goods Manual In/Out"
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
         Caption         =   "F/N Goods Manual In/Out"
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
         TabIndex        =   24
         Top             =   150
         Width           =   5790
      End
      Begin VB.Image Image1 
         Height          =   585
         Left            =   30
         Picture         =   "frmMO14VJ.frx":0000
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
      Height          =   780
      Left            =   15
      TabIndex        =   16
      Top             =   570
      Width           =   11895
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
         Left            =   5355
         Style           =   2  '드롭다운 목록
         TabIndex        =   2
         Top             =   255
         Width           =   1485
      End
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
         Left            =   8625
         Style           =   2  '드롭다운 목록
         TabIndex        =   3
         Top             =   255
         Width           =   3135
      End
      Begin MSComCtl2.DTPicker dtpYMD 
         Height          =   360
         Left            =   1470
         TabIndex        =   1
         Top             =   255
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
         Format          =   75563009
         CurrentDate     =   37956
         MinDate         =   37956
      End
      Begin Threed.SSPanel sspInfo 
         Height          =   360
         Left            =   180
         TabIndex        =   14
         Top             =   255
         Width           =   1275
         _Version        =   65536
         _ExtentX        =   2249
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Date"
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
         Left            =   7320
         TabIndex        =   13
         Top             =   255
         Width           =   1275
         _Version        =   65536
         _ExtentX        =   2249
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Flow"
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
         Left            =   4065
         TabIndex        =   25
         Top             =   255
         Width           =   1275
         _Version        =   65536
         _ExtentX        =   2249
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Goods"
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
      Height          =   2250
      Left            =   15
      TabIndex        =   15
      Top             =   1230
      Width           =   11895
      Begin VB.ComboBox cboSEQ 
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
         Left            =   2820
         Style           =   2  '드롭다운 목록
         TabIndex        =   7
         Top             =   630
         Width           =   2835
      End
      Begin VB.TextBox txtRemark 
         Alignment       =   2  '가운데 맞춤
         Height          =   360
         Left            =   1440
         MaxLength       =   50
         TabIndex        =   8
         Top             =   990
         Width           =   10275
      End
      Begin VB.TextBox txtPOID 
         Alignment       =   2  '가운데 맞춤
         Height          =   360
         Left            =   1470
         MaxLength       =   8
         TabIndex        =   4
         Top             =   240
         Width           =   1395
      End
      Begin VB.ComboBox cboDest 
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
         Left            =   1470
         Style           =   2  '드롭다운 목록
         TabIndex        =   6
         Top             =   630
         Width           =   1380
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
         Left            =   5340
         Style           =   2  '드롭다운 목록
         TabIndex        =   5
         Top             =   240
         Width           =   1995
      End
      Begin Threed.SSPanel SSPanel4 
         Height          =   360
         Left            =   180
         TabIndex        =   12
         Top             =   240
         Width           =   1275
         _Version        =   65536
         _ExtentX        =   2249
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "PO ID"
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
         Left            =   180
         TabIndex        =   11
         Top             =   615
         Width           =   1275
         _Version        =   65536
         _ExtentX        =   2249
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Destination"
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
         Left            =   4065
         TabIndex        =   0
         Top             =   240
         Width           =   1275
         _Version        =   65536
         _ExtentX        =   2249
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
         TabIndex        =   9
         Top             =   1380
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
      Begin Threed.SSPanel sspSty 
         Height          =   360
         Left            =   7335
         TabIndex        =   27
         Top             =   225
         Width           =   4410
         _Version        =   65536
         _ExtentX        =   7779
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
      Begin Threed.SSPanel SSPanel7 
         Height          =   360
         Left            =   165
         TabIndex        =   26
         Top             =   990
         Width           =   1275
         _Version        =   65536
         _ExtentX        =   2249
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "Remark"
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
      Height          =   4395
      Left            =   30
      TabIndex        =   10
      Top             =   3495
      Width           =   11865
      _cx             =   20929
      _cy             =   7752
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
      Begin VB.Frame fmePass 
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   1.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   870
         Left            =   3600
         TabIndex        =   28
         Top             =   345
         Width           =   3960
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
            Left            =   1320
            MaxLength       =   10
            TabIndex        =   30
            Top             =   90
            Width           =   1590
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
            Left            =   1320
            MaxLength       =   10
            PasswordChar    =   "@"
            TabIndex        =   29
            Top             =   465
            Width           =   1590
         End
         Begin Threed.SSPanel SSPanel8 
            Height          =   360
            Left            =   45
            TabIndex        =   31
            Top             =   90
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
            Left            =   45
            TabIndex        =   32
            Top             =   465
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
            Height          =   375
            Left            =   2925
            TabIndex        =   33
            Top             =   60
            Width           =   960
            _Version        =   65536
            _ExtentX        =   1693
            _ExtentY        =   661
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
         Begin Threed.SSCommand SSCommand3 
            Height          =   375
            Left            =   2925
            TabIndex        =   34
            Top             =   420
            Width           =   960
            _Version        =   65536
            _ExtentX        =   1693
            _ExtentY        =   661
            _StockProps     =   78
            Caption         =   "Cancel"
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
   Begin MSComctlLib.StatusBar sbrStatus 
      Align           =   2  '아래 맞춤
      Height          =   360
      Left            =   0
      TabIndex        =   20
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
End
Attribute VB_Name = "frmMO14VJ"
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

Sub StySet(arg_POID As String)
   Dim SQL As String
   Dim strRtn As String
   
   If IsNumeric(Mid(arg_POID, 1, 1)) Then
      SQL = "       SELECT STYLE_CD||'@'||NVL(FN_MODEL2(STYLE_CD),'NONE'), SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3) AS NM "
      SQL = SQL & "   FROM EM_OBS_HEAD "
      SQL = SQL & "  WHERE PO_ID   = '" & Mid(arg_POID, 1, 6) & "' "
      SQL = SQL & "    AND PO_TYPE = '" & Mid(arg_POID, 7, 2) & "' "
      SQL = SQL & " GROUP BY STYLE_CD "
      SQL = SQL & "ORDER BY 1 "
      
   Else
      SQL = "       SELECT STYLE_CD||'@'||NVL(FN_MODEL2(STYLE_CD),'NONE'), SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3) AS NM "
      SQL = SQL & "   FROM EM_OBS_HEAD "
      SQL = SQL & "  WHERE (PO_ID = TO_CHAR(ADD_MONTHS(SYSDATE,-3),'YYMM')||'00' AND PO_TYPE = 'FT') "
      SQL = SQL & "     OR (PO_ID >= TO_CHAR(ADD_MONTHS(SYSDATE,-3),'YY')||'0000' AND PO_TYPE <> 'FT') "
      SQL = SQL & " GROUP BY STYLE_CD "
      SQL = SQL & "ORDER BY 1 "
      
   End If
   
   strRtn = fnSetCbo(cboSty, SQL)

End Sub

Sub DestSet(arg_POID As String, arg_STY As String)
   Dim SQL As String
   Dim strRtn As String
   
   'po_nu , itm_seq_nu
   If IsNumeric(Mid(arg_POID, 1, 1)) Then
      SQL = "       SELECT DEST, DEST AS NM "
      SQL = SQL & "   FROM EM_OBS_HEAD "
      SQL = SQL & "  WHERE PO_ID    = '" & Mid(arg_POID, 1, 6) & "' "
      SQL = SQL & "    AND PO_TYPE  = '" & Mid(arg_POID, 7, 2) & "' "
      SQL = SQL & "    AND STYLE_CD = '" & arg_STY & "' "
      SQL = SQL & "   GROUP BY DEST "
      SQL = SQL & " UNION ALL "
      SQL = SQL & " SELECT '_____' AS DEST, '_____' AS NM FROM DUAL "
   Else
      SQL = SQL & " SELECT '_____' AS DEST, '_____' AS NM FROM DUAL "
   End If
   
   strRtn = fnSetCbo(cboDest, SQL)

End Sub

Sub SeqSet(arg_POID As String, arg_STY As String, arg_DEST)
   Dim SQL As String
   Dim strRtn As String
   
   'po_nu , itm_seq_nu
   If IsNumeric(Mid(arg_POID, 1, 1)) Then
      SQL = "       SELECT LTRIM(TO_CHAR(CD)), NM "
      SQL = SQL & "   FROM (SELECT OBS_SEQ AS CD, LTRIM(TO_CHAR(OBS_SEQ))||':'||PO_NU||'-'||ITM_SEQ_NU AS NM "
      SQL = SQL & "           FROM EM_OBS_HEAD "
      SQL = SQL & "          WHERE PO_ID    = '" & Mid(arg_POID, 1, 6) & "' "
      SQL = SQL & "            AND PO_TYPE  = '" & Mid(arg_POID, 7, 2) & "' "
      SQL = SQL & "            AND STYLE_CD = '" & arg_STY & "' "
      SQL = SQL & "            AND DEST     = '" & arg_DEST & "' "
      SQL = SQL & "          UNION ALL "
      SQL = SQL & "         SELECT 0 AS CD, 'NONE' AS NM FROM DUAL) "
      SQL = SQL & "  ORDER BY CD "
   Else
      SQL = SQL & "SELECT '0' AS CD, 'NONE' AS NM FROM DUAL "
   End If
   
   strRtn = fnSetCbo(cboSEQ, SQL)

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

Private Sub cboDest_Click()
   If txtPOID.Text <> "" And fnCboValue(cboSty) <> "" And fnCboValue(cboDest) <> "" Then
      Dim varSTY As Variant
      varSTY = Split(fnCboValue(cboSty), "@", 2)
      Call SeqSet(txtPOID.Text, CStr(varSTY(0)), fnCboValue(cboDest))
   End If
End Sub

Private Sub cboGrade_Click()
  Call DestSet("_", "_")
  If fnCboValue(cboGrade) = "A" Then
     txtPOID.Text = ""
     txtPOID.Enabled = True
  Else
     txtPOID.Text = "________"
     txtPOID.Enabled = False
     Call txtPOID_Change
     Call sbLetCbo(cboDest, "_____")
     Call sbLetCbo(cboSEQ, "0")
  End If
    
  If Trim(fnCboValue(cboGrade)) <> "" And Trim(fnCboValue(cboFlow)) <> "" Then
     Call sbViewDsp
  End If
  
End Sub

Private Sub cboFlow_Click()
   If Trim(fnCboValue(cboGrade)) <> "" And Trim(fnCboValue(cboFlow)) <> "" Then
      Call sbViewDsp
   End If
End Sub


Private Sub cboSEQ_Click()
   If txtPOID.Text <> "" And fnCboValue(cboSty) <> "" And fnCboValue(cboDest) <> "" And fnCboValue(cboSEQ) <> "" Then
      Call sbSizeDSP
   End If
End Sub

Private Sub cboSty_Click()
   Dim varVAL As Variant
   
   If fnCboValue(cboSty) = "" Or fnCboValue(cboGrade) <> "A" Then
   
   Else
      Dim varSTY As Variant
      varSTY = Split(fnCboValue(cboSty), "@", 2)
      sspSTY.Caption = CStr(varSTY(1))
      If txtPOID.Text <> "" Then
         Call DestSet(txtPOID.Text, CStr(varSTY(0)))
      End If
      Call sbHeadSizeDSP(Mid(sspSTY.Caption, 1, 2))
   End If
   
End Sub

Private Sub cmdDel_Click()
   Dim strYMD As String
   Dim SQL As Variant
   Dim strRtn As String
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   If fnCboValue(cboGrade) = "" Then
      MsgBox "You must input a data of Goods."
      Exit Sub
   End If
   
   If fnCboValue(cboFlow) = "" Then
      MsgBox "You must input a data of Flow."
      Exit Sub
   End If
   
   If txtPOID.Text = "" Then
      MsgBox "You must input a data of PO ID."
      Exit Sub
   End If
   
   If fnCboValue(cboSty) = "" Then
      MsgBox "You must input a data of Style."
      Exit Sub
   End If
   
   Dim varSTY As Variant
   varSTY = Split(fnCboValue(cboSty), "@", 2)
   
   If fnCboValue(cboDest) = "" Or fnCboValue(cboSEQ) = "" Then
      MsgBox "You must input a data of Destination."
      Exit Sub
   End If
      
   ReDim SQL(0)
   'ymd, inout_div, grade, work_div, po_id, style_cd, obs_seq
   SQL(0) = ""
   SQL(0) = SQL(0) & " DELETE FROM MG_IO "
   SQL(0) = SQL(0) & "  WHERE YMD          = '" & strYMD & "' "
   SQL(0) = SQL(0) & "    AND INOUT_DIV    = '" & fnCboValue(cboFlow) & "' "
   SQL(0) = SQL(0) & "    AND GRADE        = '" & fnCboValue(cboGrade) & "' "
   SQL(0) = SQL(0) & "    AND WORK_DIV      = 'M' "
   SQL(0) = SQL(0) & "    AND PO_ID        = '" & Mid(txtPOID.Text, 1, 6) & "' "
   SQL(0) = SQL(0) & "    AND PO_TYPE      = '" & Mid(txtPOID.Text, 7, 2) & "' "
   SQL(0) = SQL(0) & "    AND STYLE_CD     = '" & varSTY(0) & "' "
   SQL(0) = SQL(0) & "    AND OBS_SEQ      = '" & fnCboValue(cboSEQ) & "' "
   
   strRtn = fnExecOraSQL(SQL)
   If strRtn = "" Then
      Call cmdSearch_Click
      Call sbSizeDSP
   Else
      Call sbMsgDsp(strRtn, gMsgDspSec)
   End If
   
End Sub

Private Sub cmdSave_Click()
   Dim strYMD As String
   Dim SQL As Variant
   Dim i As Integer
   Dim P As Integer
   Dim cn As Integer
   Dim strRtn As String
   
   strYMD = Format(dtpYMD.Value, "YYYYMMDD")
   
   If fnCboValue(cboGrade) = "" Then
      MsgBox "You must input a data of Goods."
      Exit Sub
   End If
   
   If fnCboValue(cboFlow) = "" Then
      MsgBox "You must input a data of Flow."
      Exit Sub
   End If
   
   If Len(txtPOID.Text) <> 8 Then
      MsgBox "You must input a data of PO ID."
      Exit Sub
   End If
   
   If fnCboValue(cboSty) = "" Then
      MsgBox "You must input a data of Style."
      Exit Sub
   End If
   
   Dim varSTY As Variant
   varSTY = Split(fnCboValue(cboSty), "@", 2)
   
   If fnCboValue(cboSEQ) = "" Or fnCboValue(cboDest) = "" Then
      MsgBox "You must input a data of Destination."
      Exit Sub
   End If
   
   Dim varV As Variant
   Dim varSEQ As Variant
   
   If fnCboValue(cboSEQ) = "0" Then
      ReDim varSEQ(1)
      varSEQ(0) = "NONE"
      varSEQ(1) = "0"
   Else
      varV = Split(fnCboDesc(cboSEQ), ":", 2)
      varSEQ = Split(varV(1), "-", 2)
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
   'ymd, inout_div, grade, work_div, po_id, style_cd, obs_seq, cs_size, dest, prs_qty, remark, po_nu, itm_seq_nu, upd_ymd, upd_user
   SQL(P) = SQL(P) & " DELETE FROM MG_IO "
   SQL(P) = SQL(P) & "  WHERE YMD          = '" & strYMD & "' "
   SQL(P) = SQL(P) & "    AND INOUT_DIV    = '" & fnCboValue(cboFlow) & "' "
   SQL(P) = SQL(P) & "    AND GRADE        = '" & fnCboValue(cboGrade) & "' "
   SQL(P) = SQL(P) & "    AND WORK_DIV     = 'M' "
   SQL(P) = SQL(P) & "    AND PO_ID        = '" & Mid(txtPOID.Text, 1, 6) & "' "
   SQL(P) = SQL(P) & "    AND PO_TYPE      = '" & Mid(txtPOID.Text, 7, 2) & "' "
   SQL(P) = SQL(P) & "    AND STYLE_CD     = '" & varSTY(0) & "' "
   SQL(P) = SQL(P) & "    AND OBS_SEQ      = '" & fnCboValue(cboSEQ) & "' "
   
   P = P + 1
   For i = 0 To fspSIZE.Cols - 2 Step 1
      If Trim(fspSIZE.TextMatrix(1, i)) = "" Then
      Else
         If IsNumeric(fspSIZE.TextMatrix(1, i)) Then
            SQL(P) = ""
            SQL(P) = SQL(P) & "INSERT INTO MG_IO(ymd, inout_div, grade, work_div, po_id, po_type, style_cd, obs_seq, cs_size, dest, prs_qty, remark, po_nu, itm_seq_nu, upd_ymd, upd_user) "
            SQL(P) = SQL(P) & " VALUES('" & strYMD & "',"
            SQL(P) = SQL(P) & "        '" & fnCboValue(cboFlow) & "',"
            SQL(P) = SQL(P) & "        '" & fnCboValue(cboGrade) & "',"
            SQL(P) = SQL(P) & "        'M',"
            
            SQL(P) = SQL(P) & "        '" & Mid(txtPOID.Text, 1, 6) & "',"
            SQL(P) = SQL(P) & "        '" & Mid(txtPOID.Text, 7, 2) & "',"
            
            SQL(P) = SQL(P) & "        '" & varSTY(0) & "',"
            SQL(P) = SQL(P) & "        '" & fnCboValue(cboSEQ) & "',"
            SQL(P) = SQL(P) & "        '" & Trim(fspSIZE.TextMatrix(0, i)) & "',"
            SQL(P) = SQL(P) & "        '" & fnCboValue(cboDest) & "',"
            SQL(P) = SQL(P) & "        " & Trim(fspSIZE.TextMatrix(1, i)) & ", "
            SQL(P) = SQL(P) & "        '" & txtRemark.Text & "',"
            SQL(P) = SQL(P) & "        '" & varSEQ(0) & "', "
            SQL(P) = SQL(P) & "        '" & varSEQ(1) & "', "
            SQL(P) = SQL(P) & "        SYSDATE,"
            SQL(P) = SQL(P) & "        'FGW'"
            SQL(P) = SQL(P) & ") "
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
   If Trim(fnCboValue(cboGrade)) <> "" And Trim(fnCboValue(cboFlow)) <> "" Then
      Call sbViewDsp
   End If
End Sub



Private Sub Form_Load()
   Dim SQL As String
   Dim strRtn As String
   
   lbTitle(0).Caption = "F/N Goods Manual In/Out"
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
         
   '--------Initializing ComboBox--------
   'GRADE
   SQL = " SELECT DCODE AS CD, CD_NAME AS NM FROM CM_CODE WHERE MCODE = 'MG01' AND DCODE <> '0000' "
   strRtn = fnSetCbo(cboGrade, SQL)
   
   'cboFlow
   SQL = " SELECT DCODE AS CD, CD_NAME AS NM FROM CM_CODE WHERE MCODE = 'MG02' AND DCODE <> '0000' "
   strRtn = fnSetCbo(cboFlow, SQL)
   
   'cboSTY
   Call StySet("_")
   
   'cboDest
   Call DestSet("_", "_")
   
   'cboSEQ
   Call SeqSet("_", "_", "_")
   
   Call sbHeadSizeDSP("ME")
   Call sbHeadViewDsp
   
   cmdSearch.Enabled = False
   cmdSave.Enabled = False
   cmdDel.Enabled = False
   cmdClose.Enabled = False
   
   fmePass.Visible = True
   
End Sub


Private Sub sbViewDsp()
   Dim SQL As String
   Dim arrDATA As Variant
   
   Call sbHeadViewDsp
   
   Call sbHeadSizeDSP("ME")
   'ymd, inout_div, grade, work_div, po_id, style_cd, obs_seq, cs_size, dest, prs_qty, remark, po_nu, itm_seq_nu, upd_ymd, upd_user
   SQL = ""
   SQL = SQL & " SELECT PO_ID||PO_TYPE, SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3), "
   SQL = SQL & "        MAX(FN_MODEL2(STYLE_CD)), MAX(DEST), OBS_SEQ, MAX(PO_NU||'-'||ITM_SEQ_NU), SUM(PRS_QTY), MAX(REMARK) "
   SQL = SQL & "   FROM MG_IO "
   SQL = SQL & "  WHERE YMD          = '" & Format(dtpYMD.Value, "YYYYMMDD") & "' "
   SQL = SQL & "    AND INOUT_DIV    = '" & fnCboValue(cboFlow) & "' "
   SQL = SQL & "    AND GRADE        = '" & fnCboValue(cboGrade) & "' "
   SQL = SQL & "    AND WORK_DIV      = 'M' "
   SQL = SQL & "  GROUP BY PO_ID, PO_TYPE, STYLE_CD, OBS_SEQ "
   SQL = SQL & "  ORDER BY PO_ID, PO_TYPE, STYLE_CD, OBS_SEQ "
   
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
   'fspView.Subtotal flexSTSum, 1, 4, "#####", vbYellow, , , ""
   
   fspView.Cell(flexcpAlignment, fspView.FixedRows, 0, fspView.Rows - 1, fspView.Cols - 1) = 4
   fspView.Cell(flexcpAlignment, fspView.FixedRows, 2, fspView.Rows - 1, 2) = 1
   fspView.Cell(flexcpAlignment, fspView.FixedRows, 6, fspView.Rows - 1, 6) = 7
   
End Sub

Private Sub sbHeadViewDsp()
            
   fspView.Clear
   
   fspView.FontSize = 9
   'fspVIEW.FixedCols = 0
   'fspLine.FrozenCols = 4
   fspView.Cols = 8
   fspView.MergeCells = flexMergeFree
   fspView.MergeCol(0) = True
   fspView.MergeCol(1) = True
   fspView.MergeCol(2) = True
   
   fspView.Cell(flexcpText, 0, 0) = "PO ID"
   fspView.Cell(flexcpText, 0, 1) = "Style"
   fspView.Cell(flexcpText, 0, 2) = "Model Name"
   fspView.Cell(flexcpText, 0, 3) = "Dest"
   fspView.Cell(flexcpText, 0, 4) = "SEQ"
   fspView.Cell(flexcpText, 0, 5) = "PO_NO-ITM"
   fspView.Cell(flexcpText, 0, 6) = "QTY"
   fspView.Cell(flexcpText, 0, 7) = "REMARK"
      
   fspView.ColWidth(0) = 1000
   fspView.ColWidth(1) = 1300
   fspView.ColWidth(2) = 2500
   fspView.ColWidth(3) = 800
   fspView.ColWidth(4) = 500
   fspView.ColWidth(5) = 2000
   fspView.ColWidth(6) = 1000
   fspView.ColWidth(7) = 2500
      
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
   Dim Row As Long
   
   Row = fspView.Row
   If Row < fspView.FixedRows Then
      Exit Sub
   End If
   
   If UCase(Mid(fspView.TextMatrix(Row, 1), 1, 1)) = "T" Then
      Exit Sub
   End If
   
   txtPOID.Text = fspView.TextMatrix(Row, 0)
   Call sbLetCbo2(cboSty, Replace(fspView.TextMatrix(Row, 1), "-", ""), 9)
   sspSTY.Caption = fspView.TextMatrix(Row, 2)
   Call sbLetCbo(cboDest, fspView.TextMatrix(Row, 3))
   Call sbLetCbo(cboSEQ, fspView.TextMatrix(Row, 4))
   txtRemark.Text = fspView.TextMatrix(Row, 7)
   
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
   
   
   If Trim(fnCboValue(cboGrade)) = "" Or Trim(fnCboValue(cboFlow)) = "" Or txtPOID.Text = "" _
      Or Trim(fnCboValue(cboSty)) = "" Or Trim(fnCboValue(cboDest)) = "" Then
      Exit Sub
   End If
   
   Call sbHeadSizeDSP(Mid(sspSTY.Caption, 1, 2))
   
   Dim varSTY As Variant
   varSTY = Split(fnCboValue(cboSty), "@", 2)
   'ymd, inout_div, grade, work_div, po_id, style_cd, obs_seq, cs_size, dest, prs_qty, remark, po_nu, itm_seq_nu, upd_ymd, upd_user
   SQL = ""
   SQL = SQL & " SELECT CS_SIZE, " '
   SQL = SQL & "        PRS_QTY " '5
   SQL = SQL & "   FROM MG_IO "
   SQL = SQL & "  WHERE YMD          = '" & Format(dtpYMD.Value, "YYYYMMDD") & "' "
   SQL = SQL & "    AND INOUT_DIV    = '" & fnCboValue(cboFlow) & "' "
   SQL = SQL & "    AND GRADE        = '" & fnCboValue(cboGrade) & "' "
   SQL = SQL & "    AND WORK_DIV     = 'M' "
   SQL = SQL & "    AND PO_ID        = '" & Mid(txtPOID.Text, 1, 6) & "' "
   SQL = SQL & "    AND PO_TYPE      = '" & Mid(txtPOID.Text, 7, 2) & "' "
   SQL = SQL & "    AND STYLE_CD     = '" & varSTY(0) & "' "
   SQL = SQL & "    AND OBS_SEQ      = " & fnCboValue(cboSEQ) & " "
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
   Unload frmMO14VJ
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
   
   If Trim(txtUser.Text) = "fgw" Or Trim(txtUser.Text) = "admin" Then
   
      strRtn = fnPass(Trim(txtUser.Text), Trim(txtPass.Text))
      If strRtn = "Y" Then
         cmdSearch.Enabled = True
         cmdSave.Enabled = True
         cmdDel.Enabled = True
         cmdClose.Enabled = True
   
         fmePass.Visible = False
      Else
         MsgBox "User id or Password is wrong."
         
      End If
   End If

   
End Sub

Private Sub SSCommand3_Click()
    Unload Me
End Sub

Private Sub tmr1_Timer()
   sbrStatus.Panels.Item(1).Text = ""
   tmr1.Enabled = False
End Sub


Private Sub txtPOID_Change()
   If Len(txtPOID.Text) = 8 Then
      Call StySet(txtPOID.Text)
   End If
End Sub

Private Sub txtPOID_KeyPress(KeyAscii As Integer)
   If (KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = Asc("_") Then
   ElseIf KeyAscii <= 31 Then
   ElseIf KeyAscii = Asc("f") Or KeyAscii = Asc("t") Or KeyAscii = Asc("p") Or KeyAscii = Asc("s") Then
      KeyAscii = KeyAscii - 32
   ElseIf KeyAscii = Asc("F") Or KeyAscii = Asc("T") Or KeyAscii = Asc("P") Or KeyAscii = Asc("S") Then
   
   Else
      KeyAscii = 0
   End If
End Sub

