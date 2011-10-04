VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO01VJ 
   AutoRedraw      =   -1  'True
   Caption         =   "Manufacturing Execute System"
   ClientHeight    =   10725
   ClientLeft      =   75
   ClientTop       =   360
   ClientWidth     =   15240
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   10725
   ScaleWidth      =   15240
   WindowState     =   2  '최대화
   Begin Threed.SSPanel sspWIP 
      Height          =   810
      Left            =   7410
      TabIndex        =   231
      Top             =   4710
      Visible         =   0   'False
      Width           =   3255
      _Version        =   65536
      _ExtentX        =   5741
      _ExtentY        =   1429
      _StockProps     =   15
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BevelInner      =   1
      Begin Threed.SSPanel SSPanel1 
         Height          =   360
         Left            =   60
         TabIndex        =   232
         Top             =   75
         Width           =   2805
         _Version        =   65536
         _ExtentX        =   4948
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "WIP"
         ForeColor       =   16777215
         BackColor       =   16711680
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
         Left            =   2850
         TabIndex        =   233
         Top             =   60
         Width           =   330
         _Version        =   65536
         _ExtentX        =   582
         _ExtentY        =   661
         _StockProps     =   78
         Caption         =   "X"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Font3D          =   3
      End
      Begin VB.Label lbw 
         BackColor       =   &H00FFFFFF&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   75
         TabIndex        =   234
         Top             =   465
         Width           =   3090
      End
   End
   Begin VSFlex7LCtl.VSFlexGrid fspINFO 
      Height          =   2235
      Left            =   2325
      TabIndex        =   91
      Top             =   8550
      Visible         =   0   'False
      Width           =   4140
      _cx             =   7302
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
      FocusRect       =   0
      HighLight       =   0
      AllowSelection  =   0   'False
      AllowBigSelection=   0   'False
      AllowUserResizing=   0
      SelectionMode   =   0
      GridLines       =   1
      GridLinesFixed  =   2
      GridLineWidth   =   1
      Rows            =   9
      Cols            =   2
      FixedRows       =   0
      FixedCols       =   1
      RowHeightMin    =   240
      RowHeightMax    =   240
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
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   46
      Left            =   10020
      TabIndex        =   170
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Prod"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   26
      Left            =   9030
      TabIndex        =   168
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP3"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   29
      Left            =   7755
      TabIndex        =   146
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Input"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   28
      Left            =   4785
      TabIndex        =   145
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP2"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   24
      Left            =   5775
      TabIndex        =   166
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Prod"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   41
      Left            =   6765
      TabIndex        =   149
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP1"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSFrame ssfFSS2 
      Height          =   1485
      Left            =   4560
      TabIndex        =   160
      Top             =   6195
      Width           =   4365
      _Version        =   65536
      _ExtentX        =   7699
      _ExtentY        =   2619
      _StockProps     =   14
      Caption         =   "FSS"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspFSS2 
         Height          =   1185
         Index           =   0
         Left            =   195
         TabIndex        =   161
         Top             =   225
         Width           =   1995
         _Version        =   65536
         _ExtentX        =   3519
         _ExtentY        =   2090
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   14
            Left            =   1140
            TabIndex        =   185
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   13
            Left            =   165
            TabIndex        =   184
            Top             =   30
            Width           =   810
         End
      End
      Begin Threed.SSPanel sspFSS2 
         Height          =   240
         Index           =   1
         Left            =   2205
         TabIndex        =   162
         Top             =   225
         Width           =   1995
         _Version        =   65536
         _ExtentX        =   3519
         _ExtentY        =   423
         _StockProps     =   15
         BackColor       =   16776960
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   16
            Left            =   1095
            TabIndex        =   187
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   15
            Left            =   120
            TabIndex        =   186
            Top             =   30
            Width           =   810
         End
      End
      Begin Threed.SSPanel sspFSS2 
         Height          =   240
         Index           =   2
         Left            =   2205
         TabIndex        =   163
         Top             =   690
         Width           =   1995
         _Version        =   65536
         _ExtentX        =   3519
         _ExtentY        =   423
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   18
            Left            =   1095
            TabIndex        =   189
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   17
            Left            =   120
            TabIndex        =   188
            Top             =   30
            Width           =   810
         End
      End
      Begin Threed.SSPanel sspFSS2 
         Height          =   240
         Index           =   3
         Left            =   2205
         TabIndex        =   164
         Top             =   1170
         Width           =   1995
         _Version        =   65536
         _ExtentX        =   3519
         _ExtentY        =   423
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   20
            Left            =   1125
            TabIndex        =   191
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   19
            Left            =   120
            TabIndex        =   190
            Top             =   30
            Width           =   810
         End
      End
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   40
      Left            =   13980
      TabIndex        =   148
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Incom"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   30
      Left            =   12990
      TabIndex        =   147
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP1"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   25
      Left            =   11010
      TabIndex        =   167
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP2"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   27
      Left            =   12000
      TabIndex        =   169
      Top             =   5985
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Input"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   20
      Left            =   7755
      TabIndex        =   141
      Top             =   4905
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP2"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   21
      Left            =   4785
      TabIndex        =   142
      Top             =   4905
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Input"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   22
      Left            =   5775
      TabIndex        =   143
      Top             =   4905
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP1"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   23
      Left            =   6765
      TabIndex        =   144
      Top             =   4905
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Prod"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   17
      Left            =   9105
      TabIndex        =   138
      Top             =   4905
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Incom"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   18
      Left            =   11085
      TabIndex        =   139
      Top             =   4905
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Outgo"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   19
      Left            =   10095
      TabIndex        =   140
      Top             =   4905
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Stock"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   42
      Left            =   225
      TabIndex        =   150
      Top             =   4905
      Width           =   1095
      _Version        =   65536
      _ExtentX        =   1931
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Input"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   43
      Left            =   1320
      TabIndex        =   151
      Top             =   4905
      Width           =   1005
      _Version        =   65536
      _ExtentX        =   1773
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP1"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   44
      Left            =   2310
      TabIndex        =   152
      Top             =   4905
      Width           =   1095
      _Version        =   65536
      _ExtentX        =   1931
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Prod"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   45
      Left            =   3405
      TabIndex        =   153
      Top             =   4905
      Width           =   990
      _Version        =   65536
      _ExtentX        =   1746
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP2"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSFrame ssfFGW2 
      Height          =   825
      Left            =   8895
      TabIndex        =   127
      Top             =   5115
      Width           =   3345
      _Version        =   65536
      _ExtentX        =   5900
      _ExtentY        =   1455
      _StockProps     =   14
      Caption         =   "FGW"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspFGW2 
         Height          =   495
         Index           =   0
         Left            =   195
         TabIndex        =   128
         Top             =   255
         Width           =   2985
         _Version        =   65536
         _ExtentX        =   5265
         _ExtentY        =   873
         _StockProps     =   15
         BackColor       =   16744576
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   12
            Left            =   2100
            TabIndex        =   183
            Top             =   15
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   11
            Left            =   1140
            TabIndex        =   182
            Top             =   15
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   10
            Left            =   150
            TabIndex        =   181
            Top             =   15
            Width           =   810
         End
      End
   End
   Begin Threed.SSFrame ssfFGA2 
      Height          =   825
      Left            =   4560
      TabIndex        =   129
      Top             =   5115
      Width           =   4365
      _Version        =   65536
      _ExtentX        =   7699
      _ExtentY        =   1455
      _StockProps     =   14
      Caption         =   "FGA"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspFGA2 
         Height          =   255
         Index           =   0
         Left            =   195
         TabIndex        =   130
         Top             =   240
         Width           =   1995
         _Version        =   65536
         _ExtentX        =   3519
         _ExtentY        =   450
         _StockProps     =   15
         BackColor       =   255
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   5
            Left            =   1125
            TabIndex        =   176
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   4
            Left            =   150
            TabIndex        =   175
            Top             =   30
            Width           =   810
         End
      End
      Begin Threed.SSPanel sspFGA2 
         Height          =   255
         Index           =   1
         Left            =   195
         TabIndex        =   131
         Top             =   495
         Width           =   1995
         _Version        =   65536
         _ExtentX        =   3519
         _ExtentY        =   450
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   7
            Left            =   1125
            TabIndex        =   178
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   6
            Left            =   135
            TabIndex        =   177
            Top             =   30
            Width           =   810
         End
      End
      Begin Threed.SSPanel sspFGA2 
         Height          =   510
         Index           =   2
         Left            =   2190
         TabIndex        =   171
         Top             =   240
         Width           =   1995
         _Version        =   65536
         _ExtentX        =   3519
         _ExtentY        =   900
         _StockProps     =   15
         BackColor       =   16744576
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   9
            Left            =   1110
            TabIndex        =   180
            Top             =   15
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   8
            Left            =   150
            TabIndex        =   179
            Top             =   15
            Width           =   810
         End
      End
   End
   Begin Threed.SSFrame ssfUP2 
      Height          =   825
      Left            =   15
      TabIndex        =   132
      Top             =   5115
      Width           =   4575
      _Version        =   65536
      _ExtentX        =   8070
      _ExtentY        =   1455
      _StockProps     =   14
      Caption         =   "UPPER"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspUP2 
         Height          =   255
         Index           =   0
         Left            =   180
         TabIndex        =   133
         Top             =   225
         Width           =   4215
         _Version        =   65536
         _ExtentX        =   7435
         _ExtentY        =   450
         _StockProps     =   15
         BackColor       =   255
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   3
            Left            =   3345
            TabIndex        =   174
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   2
            Left            =   2370
            TabIndex        =   173
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   1
            Left            =   1275
            TabIndex        =   172
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   0
            Left            =   270
            TabIndex        =   134
            Top             =   30
            Width           =   810
         End
      End
   End
   Begin Threed.SSFrame ssfOS2 
      Height          =   510
      Left            =   8895
      TabIndex        =   135
      Top             =   6195
      Width           =   6270
      _Version        =   65536
      _ExtentX        =   11060
      _ExtentY        =   900
      _StockProps     =   14
      Caption         =   "Outsole"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspOS2 
         Height          =   240
         Index           =   0
         Left            =   195
         TabIndex        =   136
         Top             =   225
         Width           =   3900
         _Version        =   65536
         _ExtentX        =   6879
         _ExtentY        =   423
         _StockProps     =   15
         BackColor       =   16776960
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   24
            Left            =   3000
            TabIndex        =   195
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   23
            Left            =   2040
            TabIndex        =   194
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   22
            Left            =   1050
            TabIndex        =   193
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   21
            Left            =   60
            TabIndex        =   192
            Top             =   30
            Width           =   810
         End
      End
      Begin Threed.SSPanel sspOS2 
         Height          =   240
         Index           =   1
         Left            =   4095
         TabIndex        =   137
         Top             =   225
         Width           =   1980
         _Version        =   65536
         _ExtentX        =   3492
         _ExtentY        =   423
         _StockProps     =   15
         BackColor       =   16776960
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   26
            Left            =   1065
            TabIndex        =   197
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   25
            Left            =   120
            TabIndex        =   196
            Top             =   30
            Width           =   810
         End
      End
   End
   Begin Threed.SSFrame ssfPU2 
      Height          =   510
      Left            =   8895
      TabIndex        =   154
      Top             =   6675
      Width           =   6270
      _Version        =   65536
      _ExtentX        =   11060
      _ExtentY        =   900
      _StockProps     =   14
      Caption         =   "PU"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspPU2 
         Height          =   240
         Index           =   0
         Left            =   195
         TabIndex        =   155
         Top             =   210
         Width           =   3900
         _Version        =   65536
         _ExtentX        =   6879
         _ExtentY        =   423
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   30
            Left            =   3000
            TabIndex        =   201
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   29
            Left            =   2040
            TabIndex        =   200
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   28
            Left            =   1035
            TabIndex        =   199
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   27
            Left            =   60
            TabIndex        =   198
            Top             =   30
            Width           =   810
         End
      End
      Begin Threed.SSPanel sspPU2 
         Height          =   240
         Index           =   1
         Left            =   4080
         TabIndex        =   156
         Top             =   210
         Width           =   1980
         _Version        =   65536
         _ExtentX        =   3492
         _ExtentY        =   423
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   32
            Left            =   1080
            TabIndex        =   203
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   31
            Left            =   135
            TabIndex        =   202
            Top             =   30
            Width           =   810
         End
      End
   End
   Begin Threed.SSFrame ssfPH2 
      Height          =   510
      Left            =   8895
      TabIndex        =   157
      Top             =   7170
      Width           =   6270
      _Version        =   65536
      _ExtentX        =   11060
      _ExtentY        =   900
      _StockProps     =   14
      Caption         =   "Phylon"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspPH2 
         Height          =   240
         Index           =   0
         Left            =   195
         TabIndex        =   158
         Top             =   225
         Width           =   3900
         _Version        =   65536
         _ExtentX        =   6879
         _ExtentY        =   423
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   36
            Left            =   3000
            TabIndex        =   207
            Top             =   15
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   35
            Left            =   2040
            TabIndex        =   206
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   34
            Left            =   1035
            TabIndex        =   205
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   33
            Left            =   60
            TabIndex        =   204
            Top             =   30
            Width           =   810
         End
      End
      Begin Threed.SSPanel sspPH2 
         Height          =   240
         Index           =   1
         Left            =   4095
         TabIndex        =   159
         Top             =   225
         Width           =   1980
         _Version        =   65536
         _ExtentX        =   3492
         _ExtentY        =   423
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   38
            Left            =   1065
            TabIndex        =   209
            Top             =   30
            Width           =   810
         End
         Begin VB.Label lbrst2 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   37
            Left            =   120
            TabIndex        =   208
            Top             =   30
            Width           =   810
         End
      End
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   16
      Left            =   150
      TabIndex        =   120
      Top             =   1755
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Prod"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   9
      Left            =   780
      TabIndex        =   113
      Top             =   1755
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Incom"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   10
      Left            =   1410
      TabIndex        =   114
      Top             =   1755
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP1"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   11
      Left            =   1935
      TabIndex        =   115
      Top             =   1755
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Input"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   12
      Left            =   2565
      TabIndex        =   116
      Top             =   1755
      Width           =   540
      _Version        =   65536
      _ExtentX        =   952
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP2"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   13
      Left            =   3105
      TabIndex        =   117
      Top             =   1755
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Prod"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   14
      Left            =   4260
      TabIndex        =   118
      Top             =   1755
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Outgo"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   15
      Left            =   3735
      TabIndex        =   119
      Top             =   1755
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP3"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   33
      Left            =   5070
      TabIndex        =   106
      Top             =   30
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Incom"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   34
      Left            =   5700
      TabIndex        =   107
      Top             =   30
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP1"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   35
      Left            =   6225
      TabIndex        =   108
      Top             =   30
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Input"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   36
      Left            =   6855
      TabIndex        =   109
      Top             =   30
      Width           =   540
      _Version        =   65536
      _ExtentX        =   952
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP2"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   37
      Left            =   7395
      TabIndex        =   110
      Top             =   30
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Prod"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   38
      Left            =   8550
      TabIndex        =   111
      Top             =   30
      Width           =   540
      _Version        =   65536
      _ExtentX        =   952
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Outgo"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   39
      Left            =   8025
      TabIndex        =   112
      Top             =   30
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP3"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   32
      Left            =   12270
      TabIndex        =   105
      Top             =   45
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP3"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   0
      Left            =   9315
      TabIndex        =   99
      Top             =   45
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Incom"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   1
      Left            =   9945
      TabIndex        =   100
      Top             =   45
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP1"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   2
      Left            =   10470
      TabIndex        =   101
      Top             =   45
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Input"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   3
      Left            =   11100
      TabIndex        =   102
      Top             =   45
      Width           =   540
      _Version        =   65536
      _ExtentX        =   952
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "WIP2"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   4
      Left            =   11640
      TabIndex        =   103
      Top             =   45
      Width           =   630
      _Version        =   65536
      _ExtentX        =   1111
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Prod"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   5
      Left            =   12795
      TabIndex        =   104
      Top             =   45
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Outgo"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   6
      Left            =   13515
      TabIndex        =   96
      Top             =   45
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Incom"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   7
      Left            =   14565
      TabIndex        =   97
      Top             =   45
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Outgo"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSPanel ssptest 
      Height          =   255
      Index           =   8
      Left            =   14040
      TabIndex        =   98
      Top             =   45
      Width           =   525
      _Version        =   65536
      _ExtentX        =   926
      _ExtentY        =   450
      _StockProps     =   15
      Caption         =   "Stock"
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Threed.SSFrame ssfMenu 
      Height          =   2955
      Left            =   9075
      TabIndex        =   50
      Top             =   7950
      Visible         =   0   'False
      Width           =   3810
      _Version        =   65536
      _ExtentX        =   6720
      _ExtentY        =   5212
      _StockProps     =   14
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Gothic"
         Size            =   1.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSCommand SSCommand3 
         Height          =   345
         Left            =   3420
         TabIndex        =   93
         Top             =   30
         Width           =   330
         _Version        =   65536
         _ExtentX        =   582
         _ExtentY        =   609
         _StockProps     =   78
         Caption         =   "X"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Font3D          =   3
      End
      Begin Threed.SSCommand cmdSetBal 
         Height          =   510
         Left            =   60
         TabIndex        =   51
         Top             =   1395
         Width           =   1845
         _Version        =   65536
         _ExtentX        =   3254
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "Set Balance"
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
      Begin Threed.SSCommand cmdSeqBal 
         Height          =   510
         Left            =   60
         TabIndex        =   52
         Top             =   1890
         Width           =   1845
         _Version        =   65536
         _ExtentX        =   3254
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "Sequence Bal."
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
      Begin Threed.SSCommand smdPassMark 
         Height          =   510
         Left            =   60
         TabIndex        =   53
         Top             =   900
         Width           =   1845
         _Version        =   65536
         _ExtentX        =   3254
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "Passcard Marking"
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
      Begin Threed.SSCommand cmdHistory 
         Height          =   510
         Left            =   60
         TabIndex        =   54
         Top             =   2385
         Width           =   1845
         _Version        =   65536
         _ExtentX        =   3254
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "Execute History"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand cmdExit 
         Height          =   510
         Left            =   1890
         TabIndex        =   55
         Top             =   2385
         Width           =   1860
         _Version        =   65536
         _ExtentX        =   3281
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "MES Exit"
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
      Begin Threed.SSCommand cmdEtcInOut 
         Height          =   510
         Left            =   1890
         TabIndex        =   56
         Top             =   900
         Width           =   1860
         _Version        =   65536
         _ExtentX        =   3281
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "ETC. In/Out"
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
      Begin Threed.SSCommand cmdExam 
         Height          =   510
         Left            =   1890
         TabIndex        =   57
         Top             =   1395
         Width           =   1860
         _Version        =   65536
         _ExtentX        =   3281
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "Stock Examination"
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
      Begin Threed.SSCommand cmdHide 
         Height          =   510
         Left            =   1890
         TabIndex        =   58
         Top             =   1890
         Width           =   1860
         _Version        =   65536
         _ExtentX        =   3281
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "Menu Hide"
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
      Begin Threed.SSCommand cmdStockRpt 
         Height          =   510
         Left            =   1890
         TabIndex        =   59
         Top             =   405
         Width           =   1860
         _Version        =   65536
         _ExtentX        =   3281
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "Inventory"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand SSCommand1 
         Height          =   510
         Left            =   60
         TabIndex        =   87
         Top             =   405
         Width           =   1845
         _Version        =   65536
         _ExtentX        =   3254
         _ExtentY        =   900
         _StockProps     =   78
         Caption         =   "Results"
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
      Begin Threed.SSPanel sspMTitle 
         Height          =   360
         Left            =   45
         TabIndex        =   94
         Top             =   30
         Width           =   3375
         _Version        =   65536
         _ExtentX        =   5953
         _ExtentY        =   635
         _StockProps     =   15
         Caption         =   "MENU"
         ForeColor       =   16777215
         BackColor       =   16711680
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
   Begin VB.VScrollBar vsc1 
      Height          =   450
      Left            =   14910
      Max             =   1
      TabIndex        =   0
      Top             =   -45
      Width           =   285
   End
   Begin Threed.SSPanel sspMsg 
      Height          =   1035
      Left            =   1035
      TabIndex        =   88
      Top             =   8400
      Visible         =   0   'False
      Width           =   6585
      _Version        =   65536
      _ExtentX        =   11615
      _ExtentY        =   1826
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
      BevelWidth      =   2
      BorderWidth     =   5
      BevelInner      =   1
      Font3D          =   2
   End
   Begin VB.Timer tmrBLK 
      Interval        =   1000
      Left            =   1455
      Top             =   -45
   End
   Begin VB.Timer tmrNow 
      Interval        =   30000
      Left            =   15000
      Top             =   3810
   End
   Begin VB.Timer tmrMSG 
      Enabled         =   0   'False
      Interval        =   3000
      Left            =   13905
      Top             =   5040
   End
   Begin VB.Timer tmrScan 
      Interval        =   60000
      Left            =   7125
      Top             =   8055
   End
   Begin Threed.SSFrame ssfFGW 
      Height          =   4455
      Left            =   13395
      TabIndex        =   5
      Top             =   270
      Width           =   1815
      _Version        =   65536
      _ExtentX        =   3201
      _ExtentY        =   7858
      _StockProps     =   14
      Caption         =   "FGW"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspFGW 
         Height          =   1875
         Index           =   0
         Left            =   135
         TabIndex        =   6
         Top             =   225
         Width           =   1590
         _Version        =   65536
         _ExtentX        =   2805
         _ExtentY        =   3307
         _StockProps     =   15
         BackColor       =   16744576
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   22
            Left            =   0
            TabIndex        =   82
            Top             =   15
            Width           =   600
         End
         Begin VB.Label lbFGW 
            BackStyle       =   0  '투명
            Caption         =   "A-GRADE"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   0
            Left            =   90
            TabIndex        =   47
            Top             =   1635
            Width           =   1005
         End
      End
      Begin Threed.SSPanel sspFGW 
         Height          =   735
         Index           =   1
         Left            =   135
         TabIndex        =   7
         Top             =   2100
         Width           =   1590
         _Version        =   65536
         _ExtentX        =   2805
         _ExtentY        =   1296
         _StockProps     =   15
         BackColor       =   16744576
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbFGW 
            BackStyle       =   0  '투명
            Caption         =   "OverRun"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   1
            Left            =   45
            TabIndex        =   48
            Top             =   480
            Width           =   1005
         End
      End
      Begin Threed.SSPanel sspFGW 
         Height          =   750
         Index           =   3
         Left            =   135
         TabIndex        =   8
         Top             =   3555
         Width           =   1590
         _Version        =   65536
         _ExtentX        =   2805
         _ExtentY        =   1323
         _StockProps     =   15
         BackColor       =   16744576
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   23
            Left            =   -15
            TabIndex        =   83
            Top             =   30
            Width           =   660
         End
         Begin VB.Label lbFGW 
            BackStyle       =   0  '투명
            Caption         =   "B-GRADE"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   3
            Left            =   60
            TabIndex        =   49
            Top             =   510
            Width           =   1005
         End
      End
      Begin Threed.SSPanel sspFGW 
         Height          =   720
         Index           =   2
         Left            =   135
         TabIndex        =   9
         Top             =   2835
         Width           =   1590
         _Version        =   65536
         _ExtentX        =   2805
         _ExtentY        =   1270
         _StockProps     =   15
         BackColor       =   16744576
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbFGW 
            BackStyle       =   0  '투명
            Caption         =   "Not Sales Shoes"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   2
            Left            =   90
            TabIndex        =   89
            Top             =   480
            Width           =   1440
         End
      End
   End
   Begin Threed.SSFrame ssfFGA 
      Height          =   4455
      Left            =   9165
      TabIndex        =   1
      Top             =   270
      Width           =   4260
      _Version        =   65536
      _ExtentX        =   7514
      _ExtentY        =   7858
      _StockProps     =   14
      Caption         =   "FGA"
      ForeColor       =   0
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspFGA 
         Height          =   1020
         Index           =   0
         Left            =   135
         TabIndex        =   2
         Top             =   225
         Width           =   1155
         _Version        =   65536
         _ExtentX        =   2037
         _ExtentY        =   1799
         _StockProps     =   15
         BackColor       =   255
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   15
            Left            =   540
            TabIndex        =   226
            Top             =   360
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   3
            Left            =   30
            TabIndex        =   63
            Top             =   30
            Width           =   555
         End
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   1020
         Index           =   1
         Left            =   1290
         TabIndex        =   3
         Top             =   225
         Width           =   1170
         _Version        =   65536
         _ExtentX        =   2064
         _ExtentY        =   1799
         _StockProps     =   15
         BackColor       =   255
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   16
            Left            =   570
            TabIndex        =   227
            Top             =   360
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   4
            Left            =   30
            TabIndex        =   64
            Top             =   30
            Width           =   555
         End
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   4095
         Index           =   4
         Left            =   2460
         TabIndex        =   4
         Top             =   225
         Width           =   1680
         _Version        =   65536
         _ExtentX        =   2963
         _ExtentY        =   7223
         _StockProps     =   15
         BackColor       =   16744576
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   19
            Left            =   690
            TabIndex        =   230
            Top             =   1860
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   21
            Left            =   0
            TabIndex        =   81
            Top             =   15
            Width           =   600
         End
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   2385
         Index           =   2
         Left            =   120
         TabIndex        =   15
         Top             =   1920
         Width           =   1170
         _Version        =   65536
         _ExtentX        =   2064
         _ExtentY        =   4207
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   17
            Left            =   585
            TabIndex        =   228
            Top             =   1065
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   19
            Left            =   30
            TabIndex        =   79
            Top             =   60
            Width           =   615
         End
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   2385
         Index           =   3
         Left            =   1290
         TabIndex        =   16
         Top             =   1920
         Width           =   1155
         _Version        =   65536
         _ExtentX        =   2037
         _ExtentY        =   4207
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   18
            Left            =   570
            TabIndex        =   229
            Top             =   1065
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   20
            Left            =   -45
            TabIndex        =   80
            Top             =   60
            Width           =   615
         End
      End
   End
   Begin Threed.SSFrame ssfFSS 
      Height          =   2760
      Left            =   4920
      TabIndex        =   10
      Top             =   1965
      Width           =   4275
      _Version        =   65536
      _ExtentX        =   7541
      _ExtentY        =   4868
      _StockProps     =   14
      Caption         =   "FSS"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspFSS 
         Height          =   315
         Index           =   0
         Left            =   135
         TabIndex        =   11
         Top             =   240
         Width           =   2325
         _Version        =   65536
         _ExtentX        =   4101
         _ExtentY        =   556
         _StockProps     =   15
         BackColor       =   16777088
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   10
            Left            =   1725
            TabIndex        =   221
            Top             =   45
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   7
            Left            =   -75
            TabIndex        =   67
            Top             =   15
            Width           =   615
         End
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   2385
         Index           =   4
         Left            =   2475
         TabIndex        =   12
         Top             =   240
         Width           =   1665
         _Version        =   65536
         _ExtentX        =   2937
         _ExtentY        =   4207
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   14
            Left            =   690
            TabIndex        =   225
            Top             =   1050
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   18
            Left            =   15
            TabIndex        =   78
            Top             =   45
            Width           =   615
         End
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   330
         Index           =   1
         Left            =   135
         TabIndex        =   13
         Top             =   915
         Width           =   2325
         _Version        =   65536
         _ExtentX        =   4101
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   11
            Left            =   1725
            TabIndex        =   222
            Top             =   45
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   10
            Left            =   -30
            TabIndex        =   70
            Top             =   0
            Width           =   615
         End
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   330
         Index           =   2
         Left            =   135
         TabIndex        =   14
         Top             =   1245
         Width           =   2325
         _Version        =   65536
         _ExtentX        =   4101
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   12
            Left            =   1725
            TabIndex        =   223
            Top             =   45
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   13
            Left            =   -30
            TabIndex        =   73
            Top             =   0
            Width           =   615
         End
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   660
         Index           =   3
         Left            =   135
         TabIndex        =   17
         Top             =   1965
         Width           =   2325
         _Version        =   65536
         _ExtentX        =   4101
         _ExtentY        =   1164
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   13
            Left            =   1725
            TabIndex        =   224
            Top             =   60
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   17
            Left            =   -60
            TabIndex        =   77
            Top             =   15
            Width           =   615
         End
      End
   End
   Begin Threed.SSFrame ssfPH 
      Height          =   1035
      Left            =   15
      TabIndex        =   28
      Top             =   3690
      Width           =   4950
      _Version        =   65536
      _ExtentX        =   8731
      _ExtentY        =   1826
      _StockProps     =   14
      Caption         =   "Phylon"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspPH 
         Height          =   330
         Index           =   2
         Left            =   120
         TabIndex        =   122
         Top             =   240
         Width           =   615
         _Version        =   65536
         _ExtentX        =   1085
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
      End
      Begin Threed.SSPanel sspPH 
         Height          =   330
         Index           =   0
         Left            =   735
         TabIndex        =   29
         Top             =   240
         Width           =   4065
         _Version        =   65536
         _ExtentX        =   7170
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   8
            Left            =   1830
            TabIndex        =   219
            Top             =   45
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   24
            Left            =   -60
            TabIndex        =   92
            Top             =   0
            Width           =   615
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   14
            Left            =   3390
            TabIndex        =   74
            Top             =   0
            Width           =   615
         End
         Begin VB.Label lbPH 
            BackStyle       =   0  '투명
            Caption         =   "PHP"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   0
            Left            =   1305
            TabIndex        =   45
            Top             =   105
            Width           =   375
         End
      End
      Begin Threed.SSPanel sspPH 
         Height          =   330
         Index           =   1
         Left            =   735
         TabIndex        =   30
         Top             =   570
         Width           =   4065
         _Version        =   65536
         _ExtentX        =   7170
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   9
            Left            =   1830
            TabIndex        =   220
            Top             =   45
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   16
            Left            =   3390
            TabIndex        =   76
            Top             =   0
            Width           =   615
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   15
            Left            =   30
            TabIndex        =   75
            Top             =   0
            Width           =   525
         End
         Begin VB.Label lbPH 
            BackStyle       =   0  '투명
            Caption         =   "PHI"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   1
            Left            =   1320
            TabIndex        =   46
            Top             =   105
            Width           =   345
         End
      End
      Begin Threed.SSPanel sspPH 
         Height          =   330
         Index           =   3
         Left            =   120
         TabIndex        =   123
         Top             =   570
         Width           =   615
         _Version        =   65536
         _ExtentX        =   1085
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
      End
   End
   Begin Threed.SSFrame ssfPU 
      Height          =   1035
      Left            =   15
      TabIndex        =   23
      Top             =   2655
      Width           =   4950
      _Version        =   65536
      _ExtentX        =   8731
      _ExtentY        =   1826
      _StockProps     =   14
      Caption         =   "PU"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspPU 
         Height          =   330
         Index           =   0
         Left            =   105
         TabIndex        =   24
         Top             =   240
         Width           =   645
         _Version        =   65536
         _ExtentX        =   1138
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   8
            Left            =   -30
            TabIndex        =   68
            Top             =   0
            Width           =   615
         End
         Begin VB.Label lbPU 
            BackStyle       =   0  '투명
            Caption         =   "PUA"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   0
            Left            =   150
            TabIndex        =   40
            Top             =   150
            Width           =   465
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   330
         Index           =   1
         Left            =   750
         TabIndex        =   25
         Top             =   240
         Width           =   2970
         _Version        =   65536
         _ExtentX        =   5239
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   4
            Left            =   1815
            TabIndex        =   215
            Top             =   60
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   9
            Left            =   2415
            TabIndex        =   69
            Top             =   0
            Width           =   510
         End
         Begin VB.Label lbPU 
            BackStyle       =   0  '투명
            Caption         =   "PUS"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   2
            Left            =   1305
            TabIndex        =   42
            Top             =   120
            Width           =   465
         End
         Begin VB.Label lbPU 
            BackStyle       =   0  '투명
            Caption         =   "PUP"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   1
            Left            =   795
            TabIndex        =   41
            Top             =   120
            Width           =   465
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   330
         Index           =   4
         Left            =   3720
         TabIndex        =   26
         Top             =   240
         Width           =   1080
         _Version        =   65536
         _ExtentX        =   1905
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   5
            Left            =   30
            TabIndex        =   216
            Top             =   30
            Width           =   540
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   330
         Index           =   5
         Left            =   3735
         TabIndex        =   27
         Top             =   570
         Width           =   1080
         _Version        =   65536
         _ExtentX        =   1905
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   7
            Left            =   30
            TabIndex        =   218
            Top             =   45
            Width           =   540
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   330
         Index           =   2
         Left            =   105
         TabIndex        =   35
         Top             =   570
         Width           =   645
         _Version        =   65536
         _ExtentX        =   1138
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbPU 
            BackStyle       =   0  '투명
            Caption         =   "SPA"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   3
            Left            =   150
            TabIndex        =   43
            Top             =   150
            Width           =   465
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   11
            Left            =   -30
            TabIndex        =   71
            Top             =   0
            Width           =   615
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   330
         Index           =   3
         Left            =   750
         TabIndex        =   36
         Top             =   570
         Width           =   2970
         _Version        =   65536
         _ExtentX        =   5239
         _ExtentY        =   582
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   6
            Left            =   1815
            TabIndex        =   217
            Top             =   60
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   12
            Left            =   2310
            TabIndex        =   72
            Top             =   0
            Width           =   615
         End
         Begin VB.Label lbPU 
            BackStyle       =   0  '투명
            Caption         =   "SPP"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   4
            Left            =   1260
            TabIndex        =   44
            Top             =   120
            Width           =   465
         End
      End
   End
   Begin Threed.SSFrame ssfOS 
      Height          =   690
      Left            =   15
      TabIndex        =   31
      Top             =   1965
      Width           =   4950
      _Version        =   65536
      _ExtentX        =   8731
      _ExtentY        =   1217
      _StockProps     =   14
      Caption         =   "Outsole"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspOS 
         Height          =   315
         Index           =   0
         Left            =   750
         TabIndex        =   32
         Top             =   240
         Width           =   1785
         _Version        =   65536
         _ExtentX        =   3149
         _ExtentY        =   556
         _StockProps     =   15
         BackColor       =   16777088
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   5
            Left            =   1125
            TabIndex        =   65
            Top             =   15
            Width           =   630
         End
      End
      Begin Threed.SSPanel sspOS 
         Height          =   315
         Index           =   1
         Left            =   2535
         TabIndex        =   33
         Top             =   240
         Width           =   1170
         _Version        =   65536
         _ExtentX        =   2064
         _ExtentY        =   556
         _StockProps     =   15
         BackColor       =   16777088
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   2
            Left            =   45
            TabIndex        =   213
            Top             =   30
            Width           =   540
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   6
            Left            =   510
            TabIndex        =   66
            Top             =   15
            Width           =   615
         End
      End
      Begin Threed.SSPanel sspOS 
         Height          =   315
         Index           =   2
         Left            =   3705
         TabIndex        =   34
         Top             =   240
         Width           =   1080
         _Version        =   65536
         _ExtentX        =   1905
         _ExtentY        =   556
         _StockProps     =   15
         BackColor       =   16777088
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   3
            Left            =   30
            TabIndex        =   214
            Top             =   30
            Width           =   540
         End
      End
      Begin Threed.SSPanel sspOS 
         Height          =   315
         Index           =   3
         Left            =   105
         TabIndex        =   121
         Top             =   240
         Width           =   645
         _Version        =   65536
         _ExtentX        =   1138
         _ExtentY        =   556
         _StockProps     =   15
         BackColor       =   16777088
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
      End
   End
   Begin Threed.SSFrame ssfUP 
      Height          =   1440
      Left            =   4920
      TabIndex        =   18
      Top             =   270
      Width           =   4275
      _Version        =   65536
      _ExtentX        =   7541
      _ExtentY        =   2540
      _StockProps     =   14
      Caption         =   "UPPER"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin Threed.SSPanel sspUP 
         Height          =   525
         Index           =   1
         Left            =   780
         TabIndex        =   19
         Top             =   225
         Width           =   3375
         _Version        =   65536
         _ExtentX        =   5953
         _ExtentY        =   926
         _StockProps     =   15
         BackColor       =   255
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   1
            Left            =   2370
            TabIndex        =   212
            Top             =   150
            Width           =   585
         End
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   2
            Left            =   2700
            TabIndex        =   84
            Top             =   30
            Width           =   615
         End
         Begin VB.Label lbUP 
            BackStyle       =   0  '투명
            Caption         =   "UPS2"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   1
            Left            =   1125
            TabIndex        =   38
            Top             =   315
            Width           =   585
         End
      End
      Begin Threed.SSPanel sspUP 
         Height          =   525
         Index           =   2
         Left            =   765
         TabIndex        =   20
         Top             =   750
         Width           =   2355
         _Version        =   65536
         _ExtentX        =   4154
         _ExtentY        =   926
         _StockProps     =   15
         BackColor       =   255
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H00000000&
            Height          =   180
            Index           =   1
            Left            =   1560
            TabIndex        =   62
            Top             =   15
            Width           =   720
         End
         Begin VB.Label lbUP 
            BackStyle       =   0  '투명
            Caption         =   "UPS1"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   2
            Left            =   1155
            TabIndex        =   39
            Top             =   315
            Width           =   570
         End
      End
      Begin Threed.SSPanel sspUP 
         Height          =   525
         Index           =   3
         Left            =   3120
         TabIndex        =   21
         Top             =   750
         Width           =   1035
         _Version        =   65536
         _ExtentX        =   1826
         _ExtentY        =   926
         _StockProps     =   15
         BackColor       =   255
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbWIP 
            Alignment       =   1  '오른쪽 맞춤
            BackColor       =   &H00FFFFFF&
            Caption         =   "0"
            ForeColor       =   &H00FF0000&
            Height          =   225
            Index           =   0
            Left            =   45
            TabIndex        =   211
            Top             =   150
            Width           =   585
         End
      End
      Begin Threed.SSPanel sspUP 
         Height          =   525
         Index           =   0
         Left            =   150
         TabIndex        =   22
         Top             =   225
         Width           =   630
         _Version        =   65536
         _ExtentX        =   1111
         _ExtentY        =   926
         _StockProps     =   15
         BackColor       =   255
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "굴림"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderWidth     =   2
         BevelOuter      =   1
         Begin VB.Label lbrst 
            Alignment       =   1  '오른쪽 맞춤
            Appearance      =   0  '평면
            BackColor       =   &H80000005&
            BackStyle       =   0  '투명
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   210
            Index           =   0
            Left            =   15
            TabIndex        =   61
            Top             =   30
            Width           =   540
         End
      End
   End
   Begin Threed.SSFrame ssfLine 
      Height          =   2970
      Left            =   15
      TabIndex        =   37
      Top             =   7740
      Width           =   15150
      _Version        =   65536
      _ExtentX        =   26723
      _ExtentY        =   5239
      _StockProps     =   14
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Gothic"
         Size            =   1.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin VSFlex7LCtl.VSFlexGrid fspLine 
         Height          =   2745
         Left            =   165
         TabIndex        =   95
         Top             =   135
         Width           =   14835
         _cx             =   26167
         _cy             =   4842
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
         HighLight       =   1
         AllowSelection  =   -1  'True
         AllowBigSelection=   0   'False
         AllowUserResizing=   0
         SelectionMode   =   1
         GridLines       =   1
         GridLinesFixed  =   2
         GridLineWidth   =   1
         Rows            =   11
         Cols            =   16
         FixedRows       =   1
         FixedCols       =   1
         RowHeightMin    =   240
         RowHeightMax    =   240
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
   Begin Threed.SSFrame SSFrame1 
      Height          =   1680
      Left            =   3075
      TabIndex        =   124
      Top             =   30
      Width           =   1755
      _Version        =   65536
      _ExtentX        =   3096
      _ExtentY        =   2963
      _StockProps     =   14
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Gothic"
         Size            =   1.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin VB.CheckBox chkAutoScan 
         BackColor       =   &H80000000&
         Caption         =   "Auto Scan"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   195
         TabIndex        =   165
         Top             =   750
         Width           =   1395
      End
      Begin Threed.SSOption ssoMD 
         Height          =   255
         Index           =   0
         Left            =   180
         TabIndex        =   125
         Top             =   1080
         Width           =   810
         _Version        =   65536
         _ExtentX        =   1429
         _ExtentY        =   450
         _StockProps     =   78
         Caption         =   "Daily"
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Value           =   -1  'True
      End
      Begin Threed.SSOption ssoMD 
         Height          =   255
         Index           =   1
         Left            =   180
         TabIndex        =   126
         Top             =   1320
         Width           =   1095
         _Version        =   65536
         _ExtentX        =   1931
         _ExtentY        =   450
         _StockProps     =   78
         Caption         =   "Monthly"
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
   Begin Threed.SSFrame ssfDate 
      Height          =   1680
      Left            =   30
      TabIndex        =   60
      Top             =   30
      Width           =   3075
      _Version        =   65536
      _ExtentX        =   5424
      _ExtentY        =   2963
      _StockProps     =   14
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Gothic"
         Size            =   1.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ShadowStyle     =   1
      Begin VB.CommandButton cmdScan 
         Caption         =   "ALL-Line"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   435
         Left            =   390
         TabIndex        =   86
         Top             =   1095
         Width           =   2265
      End
      Begin MSComCtl2.DTPicker dtpYMD 
         Height          =   390
         Left            =   390
         TabIndex        =   85
         Top             =   330
         Width           =   2265
         _ExtentX        =   3995
         _ExtentY        =   688
         _Version        =   393216
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   12
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
      Begin Threed.SSPanel sspTime 
         Height          =   345
         Left            =   390
         TabIndex        =   90
         Top             =   735
         Width           =   2265
         _Version        =   65536
         _ExtentX        =   3995
         _ExtentY        =   609
         _StockProps     =   15
         Caption         =   "00:00:00"
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
         BevelOuter      =   1
         Font3D          =   2
      End
   End
   Begin Threed.SSPanel ssptest 
      Height          =   1620
      Index           =   31
      Left            =   90
      TabIndex        =   210
      Top             =   6000
      Width           =   4395
      _Version        =   65536
      _ExtentX        =   7752
      _ExtentY        =   2857
      _StockProps     =   15
      Caption         =   "NOS-LINE"
      ForeColor       =   16777215
      BackColor       =   8421376
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Font3D          =   2
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00E0E0E0&
      Index           =   1
      X1              =   0
      X2              =   15150
      Y1              =   4830
      Y2              =   4830
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00808080&
      Index           =   0
      X1              =   0
      X2              =   15150
      Y1              =   4800
      Y2              =   4800
   End
End
Attribute VB_Name = "frmMO01VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private varRST As Variant
Private varPLN As Variant
Private varPOS As Variant
Private varOP As Variant
Private varWIP As Variant
Private vLnPOS As Variant
Private vOPCD As Variant
Private varGWH As Variant
Private varCOMP As Variant

Private varSCN As Variant
Private vFlag As Boolean
Private vDownFlag As Boolean

Private vKIND As Variant
Private vHeadCol As Variant

Private mm_Count As Integer
Private vBlnk As Boolean
Private oldX As Single
Private oldY As Single
Private offsetX As Single
Private offsetY As Single
Public IsToday As Boolean


Private Function fnFssCOMP(arg_COMP As String, arg_LINE As String) As Long
   Dim i As Long
   Dim TOT As Long
   
   If arg_LINE = "ALL" Then
      TOT = 0
      For i = 0 To UBound(varCOMP, 2) Step 1
         If CStr(varCOMP(0, i)) = arg_COMP Then
            TOT = TOT + CLng(varCOMP(2, i))
'            If i < UBound(varCOMP, 2) Then
'               If varCOMP(0, i) <> varCOMP(0, i + 1) Then
'                  Exit For
'               End If
'            End If
         End If
      Next i
      fnFssCOMP = TOT
   Else
      For i = 0 To UBound(varCOMP, 2) Step 1
         If CStr(varCOMP(0, i)) = arg_COMP And CStr(varCOMP(1, i)) = arg_LINE Then
            fnFssCOMP = CLng(varCOMP(2, i))
            Exit Function
         End If
      Next i
      fnFssCOMP = 0
   End If
End Function

'========================================
' arg_pos :
'          4:RST
'          5:Late
'          6.Exactly
'          7:Early
'========================================
Private Sub sbDspData3(ByVal arg_pos As Integer)
   Dim varTOT As Variant
   Dim varTOT2 As Variant
   Dim oldval As String
   Dim i As Long
   Dim j As Long
   Dim lSPA As Long
   Dim lSPP As Long
   Dim lSPPT As Long
   Dim lFSSSPT As Long
   Dim lPHP1 As Long
   Dim lPHP2 As Long
   
   i = 0
   ReDim varTOT(i) As Long
   ReDim varTOT2(i) As Long
   ReDim varPOS(i) As Long
   ReDim varOP(i) As String
   
   oldval = ""
   Screen.MousePointer = 11
   For j = 0 To UBound(varRST, 2) Step 1
      If oldval <> varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j) Then
      'If CStr(varRST(3, j)) = "1" Then
         ReDim Preserve varOP(i)
         ReDim Preserve varPOS(i)
         ReDim Preserve varTOT(i)
         ReDim Preserve varTOT2(i)
         
         varTOT(i) = 0
         oldval = varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j)
         varOP(i) = oldval
         varPOS(i) = j
         varTOT(i) = 0
         varTOT2(i) = 0
         i = i + 1
      End If
      If CInt(varRST(3, j)) <= 6 Then
         If gLine = "ALL" Then
            varTOT(i - 1) = varTOT(i - 1) + CLng(varRST(arg_pos, j))
         Else
            If gLine = CStr(varRST(3, j)) Then
               varTOT(i - 1) = varTOT(i - 1) + CLng(varRST(arg_pos, j))
            End If
         End If
      Else
         If gLine = "ALL" Then
            varTOT2(i - 1) = varTOT2(i - 1) + CLng(varRST(arg_pos, j))
         Else
            If gLine = CStr(varRST(3, j)) Then
               varTOT2(i - 1) = varTOT2(i - 1) + CLng(varRST(arg_pos, j))
            End If
         End If
      End If
      
   Next j
   
   
   For j = 0 To i - 1 Step 1
      Select Case varOP(j)
      Case "UPC1.T.UP"
         lbrst2(0).Caption = varTOT2(j)
      Case "UPC2.O.UP"
         lbrst(0).Caption = varTOT(j)
      Case "UPS1.P.UP"
         lbrst(1).Caption = varTOT(j)
         lbrst2(2).Caption = varTOT2(j)
      Case "UPS2.P.UP"
         lbrst(2).Caption = varTOT(j)
         
      Case "FGA.I.UP"
         lbrst(3).Caption = varTOT(j)
         
      Case "FGA.T.UP"
         lbrst(4).Caption = varTOT(j)
         lbrst2(4).Caption = varTOT2(j)
      Case "OSP.T.OS"
         lbrst(5).Caption = varTOT(j)
         lbrst2(24).Caption = varTOT2(j)
      Case "OSP.P.OS"
         lbrst(6).Caption = varTOT(j)
         lbrst2(22).Caption = varTOT2(j)
      Case "FSS.I.OS"
         lbrst(7).Caption = varTOT(j)
         
      Case "PUA.P.PU"
         lbrst(8).Caption = varTOT(j)
         lbrst2(32).Caption = varTOT2(j) 'PU Airbag을 입고로 처리
      Case "PUS.T.PU"
         lbrst2(30).Caption = varTOT2(j)
      Case "PUS.P.PU"
         lbrst(9).Caption = varTOT(j)
         lbrst2(28).Caption = varTOT2(j)
         
      Case "FSS.I.PU"
         lbrst(10).Caption = varTOT(j)
      Case "FSS.T.PU"
         lbrst2(18).Caption = varTOT2(j)
      Case "FSS.T.SP"
         lFSSSPT = varTOT2(j)
      Case "FSS.T.OS"
         lbrst2(16).Caption = varTOT2(j)
      Case "FSS.T.PH"
         lbrst2(20).Caption = varTOT2(j)
         
      Case "SPA.P.SP"
         lbrst(11).Caption = varTOT(j)
         lSPA = varTOT2(j)
      Case "SPP.T.SP"
         lSPPT = varTOT2(j)
      Case "SPP.P.SP"
         lbrst(12).Caption = varTOT(j)
         lSPP = varTOT2(j)
      Case "FSS.I.SP"
         lbrst(13).Caption = varTOT(j)
         
      Case "PHP.I.PH"
         lbrst(24).Caption = varTOT(j)
         lPHP1 = varTOT2(j)
         
      Case "PHP.O.PH"
         lbrst(14).Caption = varTOT(j)
         lPHP2 = varTOT2(j)
         
      Case "PHI.I.PH"
         lbrst(15).Caption = varTOT(j)
         lbrst2(38).Caption = varTOT2(j)
         
      Case "PHI.O.PH"
         lbrst(16).Caption = varTOT(j)
         lbrst2(34).Caption = varTOT2(j)
         
      Case "FSS.I.PH"
         lbrst(17).Caption = varTOT(j)
      
      Case "FSS.P.FS"
         lbrst(18).Caption = varTOT(j)
         lbrst2(14).Caption = varTOT2(j)
      Case "FGA.I.FS"
         lbrst(19).Caption = varTOT(j)
         
      Case "FGA.T.FS"
         lbrst(20).Caption = varTOT(j)
         lbrst2(6).Caption = varTOT2(j)
      Case "FGA.P.FG"
         lbrst(21).Caption = varTOT(j)
         lbrst2(8).Caption = varTOT2(j)
      Case Else
      
      End Select
   Next j
   
   
   
   'NOS Line Adjusting Data
   lbrst2(18).Caption = CStr(CLng(lbrst2(18).Caption) + lFSSSPT) 'FSS PU + SP Input
   lbrst2(32).Caption = CStr(CLng(lbrst2(32).Caption) + lSPA)    'PUA + SPA Production
   lbrst2(28).Caption = CStr(CLng(lbrst2(28).Caption) + lSPP)    'PUS + SPP Production
   lbrst2(30).Caption = CStr(CLng(lbrst2(30).Caption) + lSPPT)   'PUS + SPP Input
   lbrst2(38).Caption = CStr(CLng(lbrst2(38).Caption) + lPHP1)   'PHI + PHP Incoming
   lbrst2(34).Caption = CStr(CLng(lbrst2(34).Caption) + lPHP2)   'PHI + PHP Production
   
   
   'Displaying WIP
   'Upper
   lbWIP(0).Caption = fnOldWIP("UPS1.PO.UP", gLine) + CLng(lbrst(1).Caption) + CLng(lbrst(2).Caption) - CLng(lbrst(3).Caption)
   lbWIP(1).Caption = fnOldWIP("UPS2.IP.UP", gLine) + CLng(lbrst(0).Caption) - CLng(lbrst(2).Caption)
   
   'OS
   lbWIP(2).Caption = fnOldWIP("OSP.TP.OS", gLine) + CLng(lbrst(5).Caption) - CLng(lbrst(6).Caption)
   lbWIP(3).Caption = fnOldWIP("OSP.PO.OS", gLine) + CLng(lbrst(6).Caption) - CLng(lbrst(7).Caption)
   
   'PU
   lbWIP(4).Caption = fnOldWIP("PUS.TP.PU", gLine) + CLng(lbrst(8).Caption) - CLng(lbrst(9).Caption)
   lbWIP(5).Caption = fnOldWIP("PUS.PO.PU", gLine) + CLng(lbrst(9).Caption) - CLng(lbrst(10).Caption)
   
   lbWIP(6).Caption = fnOldWIP("SPP.TP.SP", gLine) + CLng(lbrst(11).Caption) - CLng(lbrst(12).Caption)
   lbWIP(7).Caption = fnOldWIP("SPP.PO.SP", gLine) + CLng(lbrst(12).Caption) - CLng(lbrst(13).Caption)
   
   'PH
   lbWIP(8).Caption = fnOldWIP("PHP.IO.PH", gLine) + CLng(lbrst(24).Caption) - CLng(lbrst(14).Caption)
   lbWIP(9).Caption = fnOldWIP("PHI.IO.PH", gLine) + CLng(lbrst(15).Caption) - CLng(lbrst(16).Caption)
   
   'FS
   lbWIP(10).Caption = fnOldWIP("FSS.IP.OS", gLine) + CLng(lbrst(7).Caption) - fnFssCOMP("OS", gLine)
   lbWIP(11).Caption = fnOldWIP("FSS.IP.PU", gLine) + CLng(lbrst(10).Caption) - fnFssCOMP("PU", gLine)
   lbWIP(12).Caption = fnOldWIP("FSS.IP.SP", gLine) + CLng(lbrst(13).Caption) - fnFssCOMP("SP", gLine)
   lbWIP(13).Caption = fnOldWIP("FSS.IP.PH", gLine) + CLng(lbrst(17).Caption) - fnFssCOMP("PH", gLine)
   
   lbWIP(14).Caption = fnOldWIP("FSS.PO.FS", gLine) + CLng(lbrst(18).Caption) - CLng(lbrst(19).Caption)
   
   'FG
   lbWIP(15).Caption = fnOldWIP("FGA.IT.UP", gLine) + CLng(lbrst(3).Caption) - CLng(lbrst(4).Caption)
   lbWIP(16).Caption = fnOldWIP("FGA.TP.UP", gLine) + CLng(lbrst(4).Caption) - CLng(lbrst(21).Caption)
   
   lbWIP(17).Caption = fnOldWIP("FGA.IT.FS", gLine) + CLng(lbrst(19).Caption) - CLng(lbrst(20).Caption)
   lbWIP(18).Caption = fnOldWIP("FGA.TP.FS", gLine) + CLng(lbrst(20).Caption) - CLng(lbrst(21).Caption)
   
   lbWIP(19).Caption = fnOldWIP("FGA.PO.FG", gLine) + CLng(lbrst(21).Caption) - CLng(lbrst(22).Caption)
   
   Screen.MousePointer = 1
   
End Sub

Private Function fnOldWIP(arg_key As String, arg_LINE As String)
   Dim i As Long
   Dim TOT As Long
   
   If IsArray(varWIP) Then
   Else
      Call sbMsgDsp("Not found WIP of Before Day!", 3)
      fnOldWIP = 0
      Exit Function
   End If
   
   If arg_LINE = "ALL" Then
      TOT = 0
      For i = 0 To UBound(varWIP, 2) Step 1
         If CStr(varWIP(0, i)) = arg_key Then
            TOT = TOT + CLng(varWIP(2, i))
            If i < UBound(varWIP, 2) Then
               If varWIP(0, i) <> varWIP(0, i + 1) Then
                  Exit For
               End If
            End If
         End If
      Next i
      fnOldWIP = TOT
   Else
      For i = 0 To UBound(varWIP, 2) Step 1
         If CStr(varWIP(0, i)) = arg_key And CStr(varWIP(1, i)) = arg_LINE Then
            fnOldWIP = CLng(varWIP(2, i))
            Exit Function
         End If
      Next i
      fnOldWIP = 0
   End If
End Function

Private Function fnMVZ(VAL As Long) As Long
   fnMVZ = VAL
   If VAL < 0 Then
      fnMVZ = 0
   End If
End Function

Private Sub sbSetLinePos()
   Dim i As Integer
   Dim j As Integer
   
   ReDim vOPCD(5) As String
   ReDim vLnPOS(5, 9) As String
   
   vOPCD(0) = "UP"
   vOPCD(1) = "OS"
   vOPCD(2) = "PU"
   vOPCD(3) = "PH"
   vOPCD(4) = "FS"
   vOPCD(5) = "FG"
   
   For i = 0 To UBound(vLnPOS, 1) Step 1
      For j = 0 To UBound(vLnPOS, 2) Step 1
         vLnPOS(i, j) = ""
      Next j
   Next i
   
   vLnPOS(0, 0) = "UPS1Inc"
   vLnPOS(0, 1) = "UPS1.IP.UP" 'WIP2
   vLnPOS(0, 2) = "UPS1Pro"
   vLnPOS(0, 3) = "UPS1.PO.UP" 'WIP3
   vLnPOS(0, 4) = ""
   vLnPOS(0, 5) = "UPS2Inc"
   vLnPOS(0, 6) = "UPS2.IP.UP" 'WIP2
   vLnPOS(0, 7) = "UPS2Pro"
   vLnPOS(0, 8) = "UPS2.PO.UP" 'WIP3
   
   vLnPOS(1, 0) = "OSP Inp"
   vLnPOS(1, 1) = "OSP.TP.OS"
   vLnPOS(1, 2) = "OSP Pro"
   vLnPOS(1, 3) = "OSP.PO.OS"
   
   vLnPOS(2, 0) = "PUA Pro"
   vLnPOS(2, 1) = "PUS.TP.PU"  'WIP
   vLnPOS(2, 2) = "PUS Pro"
   vLnPOS(2, 3) = "PUS.PO.PU"
   vLnPOS(2, 4) = ""
   vLnPOS(2, 5) = "SPA Pro"
   vLnPOS(2, 6) = "SPP.TP.SP"
   vLnPOS(2, 7) = "SPP Pro"
   vLnPOS(2, 8) = "SPP.PO.SP"
   
   vLnPOS(3, 0) = "PHP Inc"
   vLnPOS(3, 1) = "PHP.IO.PH"
   vLnPOS(3, 2) = "PHP Out"
   vLnPOS(3, 3) = ""
   vLnPOS(3, 4) = "PHI Inc"
   vLnPOS(3, 5) = "PHI.IO.PH"
   vLnPOS(3, 6) = "PHI Out"
   
   vLnPOS(4, 0) = "OS Inco"
   vLnPOS(4, 1) = "PU Inco"
   vLnPOS(4, 2) = "SP Inco"
   vLnPOS(4, 3) = "PH Inco"
   vLnPOS(4, 4) = "FSS.IP.OS"
   vLnPOS(4, 5) = "FSS.IP.PU"
   vLnPOS(4, 6) = "FSS.IP.SP"
   vLnPOS(4, 7) = "FSS.IP.PH"
   vLnPOS(4, 8) = "FSS Pro"
   vLnPOS(4, 9) = "FSS.PO.FS"
   
   vLnPOS(5, 0) = "UP Inco"
   vLnPOS(5, 1) = "FS Inco"
   vLnPOS(5, 2) = "FGA.IT.UP"
   vLnPOS(5, 3) = "FGA.IT.FS"
   vLnPOS(5, 4) = "UP Inpu"
   vLnPOS(5, 5) = "FS Inpu"
   vLnPOS(5, 6) = "FGA.TP.UP"
   vLnPOS(5, 7) = "FGA.TP.FS"
   vLnPOS(5, 8) = "FGA Pro"
   vLnPOS(5, 9) = "FGA.PO.FG"
      
End Sub

Private Sub sbDspHeadLine()
   Dim i As Integer
   
   fspLine.ColWidth(0) = 600
   For i = 1 To fspLine.Cols - 1 Step 1
      fspLine.ColWidth(i) = 950
   Next
   fspLine.Cell(flexcpAlignment, 0, 0, 0, fspLine.Cols - 1) = 4
   fspLine.Cell(flexcpAlignment, 0, 2, 0, 11) = 1
   fspLine.Cell(flexcpAlignment, 1, 1, fspLine.Rows - 1, fspLine.Cols - 1) = 7
   For i = 1 To fspLine.Cols - 1 Step 1
      fspLine.ColFormat(i) = "###,###,###"
   Next
   fspLine.Cell(flexcpBackColor, 1, fspLine.Cols - 4, fspLine.Rows - 2, fspLine.Cols - 4) = vbYellow
   
   fspLine.Cell(flexcpForeColor, 1, fspLine.Cols - 3, fspLine.Rows - 2, fspLine.Cols - 3) = vbRed
   fspLine.Cell(flexcpForeColor, 1, fspLine.Cols - 2, fspLine.Rows - 2, fspLine.Cols - 2) = vbBlue
   fspLine.Cell(flexcpForeColor, 1, fspLine.Cols - 1, fspLine.Rows - 2, fspLine.Cols - 1) = vbMagenta
   fspLine.Cell(flexcpFontBold, 1, fspLine.Cols - 4, fspLine.Rows - 1, fspLine.Cols - 1) = True
   
End Sub
Private Sub sbBlkStop()
   Dim i As Integer
   
   For i = 0 To lbrst.UBound Step 1
       lbrst(i).Tag = ""
   Next i
   
End Sub
Private Sub subPopDsp(arg_Proc As String, arg_RstDiv As String, arg_COMP As String, arg_UpperDiv As String)
   Dim i As Integer
   Dim Row As Integer
   
   If Not IsArray(varSCN) Then
      Exit Sub
   End If
   
   fspINFO.Cell(flexcpText, 0, 1, fspINFO.Rows - 1, 1) = ""
   If vDownFlag Then
      fspINFO.TextMatrix(0, 1) = "Wait a minute! ...."
      Exit Sub
   End If
   For i = 0 To UBound(varSCN, 2) Step 1
      If CStr(varSCN(0, i)) = arg_Proc And CStr(varSCN(1, i)) = arg_RstDiv And CStr(varSCN(2, i)) = arg_COMP _
         And IIf(arg_Proc = "FGA" And arg_UpperDiv = "2" Or arg_Proc = "UPC", CStr(varSCN(4, i)), "1") = arg_UpperDiv Then
         Row = CInt(varSCN(3, i)) - 1
         If Row < 0 Then
            Row = 0
         End If
         If Mid(varSCN(6, i), 1, 8) = Format(DateAdd("h", 2, Now), "YYYYMMDD") Then
            fspINFO.TextMatrix(Row, 1) = varSCN(5, i)
         Else
            fspINFO.TextMatrix(Row, 1) = "Today Nothing"
         End If
         If CInt(varSCN(3, i)) >= 9 Then
            Exit Sub
         End If
      End If
   Next i
End Sub

Private Sub sbSetKind()
   Dim i As Integer
   Dim j As Integer
   Dim k As Integer
   Dim ttl As String
   
   ReDim vKIND(0)
   ReDim vHeadCol(0)
   
   k = 0
   For i = 0 To UBound(gArrRstGroup, 2) Step 1
      If gDept = Mid(gArrRstGroup(6, i), 1, 2) Then
         If gDept = "UP" Then
            For j = 0 To 3 Step 1
               If gArrRstGroup(2 + j, i) = "Y" Then
                  ReDim Preserve vKIND(k)
                  ReDim Preserve vHeadCol(k)
                  
                  If UCase(Mid(gArrRstDiv(j), 3, 1)) = "P" Then
                     ttl = Mid(gArrRstDiv(j), 3, 4)
                  ElseIf UCase(Mid(gArrRstDiv(j), 3, 1)) = "I" Then
                     ttl = Mid(gArrRstDiv(j), 3, 2)
                  Else
                     ttl = Mid(gArrRstDiv(j), 3, 3)
                  End If
                  vHeadCol(k) = gArrRstGroup(0, i) & "1" & ttl
                  If Mid(vHeadCol(k), 1, 5) = "UPC1O" Then
                     vHeadCol(k) = "UPS1Incom"
                  End If
                  
                  vKIND(k) = gArrRstGroup(0, i) & "1." & Mid(gArrRstDiv(j), 1, 1) & ".UP"
                  
                  k = k + 1
                  
                  ReDim Preserve vKIND(k)
                  ReDim Preserve vHeadCol(k)
                  
                  vHeadCol(k) = gArrRstGroup(0, i) & "2" & ttl
                  If Mid(vHeadCol(k), 1, 5) = "UPC2O" Then
                     vHeadCol(k) = "UPS2Incom"
                  End If
                  vKIND(k) = gArrRstGroup(0, i) & "2." & Mid(gArrRstDiv(j), 1, 1) & ".UP"
                  
                  k = k + 1
               End If
            Next j
         Else
            For j = 0 To 3 Step 1
               If gArrRstGroup(2 + j, i) = "Y" Then
                  If Mid(gArrRstDiv(j), 1, 1) = "I" Or Mid(gArrRstDiv(j), 1, 1) = "T" Then
                     If gDept = "FG" Then
                        ReDim Preserve vKIND(k)
                        ReDim Preserve vHeadCol(k)
                        vHeadCol(k) = "UP " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".UP"
                        k = k + 1
                        
                        ReDim Preserve vKIND(k)
                        ReDim Preserve vHeadCol(k)
                        vHeadCol(k) = "FS " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".FS"
                        k = k + 1
                     ElseIf gDept = "FS" Then
                        ReDim Preserve vKIND(k)
                        ReDim Preserve vHeadCol(k)
                        vHeadCol(k) = "OS " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".OS"
                        k = k + 1
                        
                        ReDim Preserve vKIND(k)
                        ReDim Preserve vHeadCol(k)
                        vHeadCol(k) = "PU " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".PU"
                        k = k + 1
                        
                        ReDim Preserve vKIND(k)
                        ReDim Preserve vHeadCol(k)
                        vHeadCol(k) = "SP " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".SP"
                        k = k + 1
                        
                        ReDim Preserve vKIND(k)
                        ReDim Preserve vHeadCol(k)
                        vHeadCol(k) = "PH " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & ".PH"
                        k = k + 1
                     Else
                        ReDim Preserve vKIND(k)
                        ReDim Preserve vHeadCol(k)
                        vHeadCol(k) = Mid(gArrRstGroup(0, i), 1, 3) & " " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                        vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & "." & Mid(gArrRstGroup(0, i), 1, 2)
                        k = k + 1
                     End If
                  Else
                     ReDim Preserve vKIND(k)
                     ReDim Preserve vHeadCol(k)
                     vHeadCol(k) = Mid(gArrRstGroup(0, i), 1, 3) & " " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                     vKIND(k) = gArrRstGroup(0, i) & "." & Mid(gArrRstDiv(j), 1, 1) & "." & Mid(gArrRstGroup(0, i), 1, 2)
                     k = k + 1
                  End If
               End If
            Next j
         End If
         
         'Exit For
      End If
   Next i
   
End Sub


Private Sub chkAutoScan_Click()
   If chkAutoScan.Value = 1 And IsToday Then
      mm_Count = 0
      tmrScan.Enabled = True
   Else
      Call sbBlkStop
      mm_Count = 0
      tmrScan.Enabled = False
   End If
End Sub

Private Sub chkAutoScan_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   fspINFO.Visible = False
End Sub

Private Sub cmdEtcInOut_Click()
   frmMO10VJ.Show 1
End Sub

Private Sub cmdExam_Click()
   frmMO07VJ.Show 1
End Sub

Private Sub cmdHide_Click()
   Call SSCommand3_Click
End Sub

Private Sub cmdMenu_Click()
   ssfMenu.Visible = True
   cmdMenu.Visible = False
End Sub

Private Sub cmdScan_Click()
   cmdScan.Caption = "ALL-Line"
   gLine = "ALL"
   Call sbDspData(Format(dtpYMD.Value, "YYYYMMDD"), "ALL")
End Sub

Private Sub cmdSeqBal_Click()
   frmMO06VJ.Show 1
End Sub

Private Sub cmdSetBal_Click()
   frmMO05VJ.Show 1
End Sub

Private Sub dtpYMD_Change()
   Dim i As Integer
   
   If Format(DateAdd("h", 2, Now), "YYYYMMDD") = Format(dtpYMD.Value, "YYYYMMDD") Then
      IsToday = True
   Else
      IsToday = False
   End If
   
   For i = 0 To lbrst.UBound Step 1
      lbrst(i).Visible = True
      lbrst(i).Tag = ""
   Next i
   
   For i = 0 To lbrst2.UBound Step 1
      lbrst2(i).Visible = True
      lbrst2(i).Tag = ""
   Next i
   
   cmdScan.Caption = "ALL-Line"
   gLine = "ALL"
   
   Call sbOldWipScan
   
   'chkAutoScan.Value = 0
   Call chkAutoScan_Click
   Call sbDspData(Format(dtpYMD.Value, "YYYYMMDD"), "ALL")
End Sub

Private Sub Form_Load()
   Dim strYMD As String
   Dim lngWidth As Long
   Dim lngHeight As Long
   Dim WSIZE As Long
   
   'sspMsg.Visible = True
         
   IsToday = True
   vDownFlag = False
   vBlnk = False
   
   Call sbSetLinePos
   
   'imgMoveFGA(1).Height = imgMoveFGA(2).Height \ 2 - 50
   'imgMoveFGA(3).Height = imgMoveFGA(3).Height \ 2 - 50
   sspMsg.Left = Me.Width / 2 - sspMsg.Width / 2
   sspMsg.Top = Me.Height / 2 - sspMsg.Height / 2
   
   Me.Left = 0
   Me.Top = 0
   
   'vsc1.Height = Me.Height
   vsc1.Left = Me.Width - vsc1.Width
   'vsc1.Top = 20
   
   Call GetInitParam
   Call fnConnOraDB
   Call sbGetBase
   
   'Reset System Time
   If gFactory = "VJ" Then
      Call sbSetSysDate(7)
   ElseIf gFactory = "QD" Then
      Call sbSetSysDate(8)
   ElseIf gFactory = "DS" Then
      Call sbSetSysDate(9)
   Else
      'Call sbMsgDsp("Check 'FACTORY' Key into NEOMICS.INI file!", 3)
      MsgBox "Check 'FACTORY' Key into NEOMICS.INI file!"
      End
   End If
   
   gDept = "FG"
   
   strYMD = Format(DateAdd("h", 2, Now), "YYYYMMDD")
   dtpYMD.Value = DateAdd("h", 2, Now)
   
   Call sbOldWipScan
   
   Call sbDspHeadLine
   
   Call sbDspData(strYMD, "ALL")
   
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGA, ssfFGA)
   
   mm_Count = 0
   
   fspINFO.FontSize = 8
   
   lngWidth = Screen.Width
   lngHeight = Screen.Height
   
   WSIZE = lngWidth / Screen.TwipsPerPixelX
   
   If WSIZE >= 1024 Then
      vsc1.Visible = False
      vsc1.Enabled = False
      lngHeight = 11100
   Else
      ssfDate.Tag = CStr(ssfDate.Top)
      ssfUP.Tag = CStr(ssfUP.Top)
      ssfFGA.Tag = CStr(ssfFGA.Top)
      ssfFGW.Tag = CStr(ssfFGW.Top)
      ssfOS.Tag = CStr(ssfOS.Top)
      ssfPH.Tag = CStr(ssfPH.Top)
      ssfPU.Tag = CStr(ssfPU.Top)
      ssfFSS.Tag = CStr(ssfFSS.Top)
      ssfLine.Tag = CStr(ssfLine.Top)
      ssfMenu.Tag = CStr(ssfMenu.Top)
      lngHeight = 8580
      vsc1.Visible = True
      vsc1.Enabled = True
   End If
   frmMO01VJ.WindowState = 0
   frmMO01VJ.Height = lngHeight
   frmMO01VJ.Width = lngWidth
   
   oldX = lngWidth \ 2 - (ssfMenu.Width \ 2)
   oldY = lngHeight \ 2 - (ssfMenu.Height \ 2)
   ssfMenu.Left = oldX
   ssfMenu.Top = oldY
   
End Sub

Private Sub Form_Unload(Cancel As Integer)

   tmrScan.Enabled = False
   Call sbDisconnOra
   
End Sub
Private Sub sbOldWipScan()
   Dim SQL As String
   
   vDownFlag = True
   If ssoMD(0).Value Then
      SQL = ""
      SQL = SQL & " SELECT PROC||'.'||IVTR_DIV||'.'||SEMI_GOOD_CD, "
      SQL = SQL & "        ASSY_LINE, "     '3
      SQL = SQL & "        SUM(PRS_QTY) "
      SQL = SQL & "   FROM MP_DAY_IVTR "
      If IsToday Then
         SQL = SQL & "  WHERE YMD = FN_MM_PDAY(TO_CHAR(SYSDATE + 1/12,'YYYYMMDD')) "
      Else
         SQL = SQL & "  WHERE YMD = FN_MM_PDAY('" & Format(dtpYMD.Value, "YYYYMMDD") & "') "
      End If
      
      SQL = SQL & "  GROUP BY PROC, IVTR_DIV, SEMI_GOOD_CD, ASSY_LINE "
      SQL = SQL & "  ORDER BY PROC, IVTR_DIV, SEMI_GOOD_CD, ASSY_LINE "
   Else
      SQL = ""
      SQL = SQL & " SELECT PROC||'.'||IVTR_DIV||'.'||SEMI_GOOD_CD, "
      SQL = SQL & "        ASSY_LINE, "     '3
      SQL = SQL & "        SUM(PRS_QTY) "
      SQL = SQL & "   FROM MP_DAY_IVTR "
      SQL = SQL & "  WHERE YMD = FN_MM_PDAY('" & Format(dtpYMD.Value, "YYYYMM") & "01') "
      
      SQL = SQL & "  GROUP BY PROC, IVTR_DIV, SEMI_GOOD_CD, ASSY_LINE "
      SQL = SQL & "  ORDER BY PROC, IVTR_DIV, SEMI_GOOD_CD, ASSY_LINE "
   End If
   
   Set varWIP = Nothing
   varWIP = fnGetOraData(SQL)
   
   If Not IsArray(varWIP) Then
      tmrScan.Enabled = False
      chkAutoScan.Value = 0
      If varWIP = "" Then
         Call sbMsgDsp("Can not find Applyed Date!", gMsgDspSec)
      Else
         Call sbMsgDsp(varWIP, gMsgDspSec)
      End If
      
      SQL = ""
      SQL = SQL & " SELECT PROC||'.'||IVTR_DIV||'.'||SEMI_GOOD_CD, "
      SQL = SQL & "        ASSY_LINE, "     '3
      SQL = SQL & "        0 "
      SQL = SQL & "   FROM MP_DAY_IVTR "
      SQL = SQL & "  WHERE YMD = '20040329' "
      SQL = SQL & "  GROUP BY PROC, IVTR_DIV, SEMI_GOOD_CD, ASSY_LINE "
      SQL = SQL & "  ORDER BY PROC, IVTR_DIV, SEMI_GOOD_CD, ASSY_LINE "
      
      varWIP = fnGetOraData(SQL)
      
      vDownFlag = False
      Exit Sub
   End If
   
   vDownFlag = False

End Sub
Private Sub sbBarScan()
   Dim SQL As String
   
   vDownFlag = True
   
   SQL = ""
   SQL = SQL & " SELECT OP_CD, "         '0
   SQL = SQL & "        RST_DIV, "       '1
   SQL = SQL & "        SEMI_GOOD_CD, "  '2
   SQL = SQL & "        ASSY_LINE, "     '3
   SQL = SQL & "        UPPER_DIV, "     '4
   SQL = SQL & "        ASSY_LINE||'-'||TO_CHAR(TO_DATE(ASSY_YMD,'YYYYMMDD'),'MON-DD')||'-'||ABC_ID||'H-'||LTRIM(TO_CHAR(PCARD_SEQ,'00'))||' / '||SUBSTR(STYLE_CD,1,6)||'-'||SUBSTR(STYLE_CD,7,3)||' / '||SUBSTR(SCN_TMS,9,2)||':'||SUBSTR(SCN_TMS,11,2)||':'||SUBSTR(SCN_TMS,13,2)||' / '||DECODE(DIV,'1','NOR','DEF'), "
   SQL = SQL & "        SCN_TMS "
   SQL = SQL & "   FROM PS_PCARD_MON "
   SQL = SQL & "  ORDER BY OP_CD, RST_DIV, SEMI_GOOD_CD, ASSY_LINE "
   
   Set varSCN = Nothing
   varSCN = fnGetOraData(SQL)
   If Not IsArray(varSCN) Then
      tmrScan.Enabled = False
      chkAutoScan.Value = 0
      If varSCN = "" Then
         Call sbMsgDsp("Can not find Applyed Date!", gMsgDspSec)
      Else
         Call sbMsgDsp(varSCN, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   vDownFlag = False
End Sub

Public Sub sbDspData(ByVal arg_ymd As String, ByVal arg_LINE As String)
   Dim varTM As Variant
   Dim SQL As String
   Dim i As Long
   Dim j As Long
   Dim k As Long
      
   vFlag = False
   gLine = arg_LINE
   
   For i = 0 To lbrst.UBound Step 1
      lbrst(i).Caption = "0"
   Next
   
   For i = 0 To lbrst2.UBound Step 1
      lbrst2(i).Caption = "0"
   Next
   
   'Set varPLN = Nothing
   'Set varRST = Nothing
   
   'strYMD = Format(DateAdd("h", 2, Now), "YYYYMMDD")
   'strYMD = "20031210"
   
   'Initializing results label
   cmdScan.Caption = arg_LINE & "-Line"
   For i = 0 To lbrst.UBound Step 1
      lbrst(i).Caption = "0"
   Next i
   
   
   '=======================
   
   SQL = ""
   SQL = SQL & " SELECT NVL(MAX(TO_CHAR(UPD_YMD,'YYYYMMDDHH24:MI:SS')),'*'), "
   SQL = SQL & "        MAX(TO_CHAR(DECODE(SUBSTR(OP_CD,1,2),'UP',UPD_YMD,TO_DATE(NULL)),'YYYYMMDDHH24:MI:SS')), "
   SQL = SQL & "        MAX(TO_CHAR(DECODE(OP_CD,'FGA',UPD_YMD,TO_DATE(NULL)),'YYYYMMDDHH24:MI:SS')), "
   SQL = SQL & "        MAX(TO_CHAR(DECODE(OP_CD,'OSP',UPD_YMD,TO_DATE(NULL)),'YYYYMMDDHH24:MI:SS')), "
   SQL = SQL & "        MAX(TO_CHAR(DECODE(SUBSTR(OP_CD,1,2),'PU',UPD_YMD,'SP',UPD_YMD,TO_DATE(NULL)),'YYYYMMDDHH24:MI:SS')), "
   SQL = SQL & "        MAX(TO_CHAR(DECODE(SUBSTR(OP_CD,1,2),'PH',UPD_YMD,TO_DATE(NULL)),'YYYYMMDDHH24:MI:SS')), "
   SQL = SQL & "        MAX(TO_CHAR(DECODE(OP_CD,'FSS',UPD_YMD,TO_DATE(NULL)),'YYYYMMDDHH24:MI:SS')) "
   SQL = SQL & "   FROM MP_APPLY "
   
   Screen.MousePointer = 11
   Set varTM = Nothing
   varTM = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If Not IsArray(varTM) Then
      tmrScan.Enabled = False
      chkAutoScan.Value = 0
      If varTM = "" Then
         Call sbMsgDsp("Can not find Applyed Date!", gMsgDspSec)
      Else
         Call sbMsgDsp(varTM, gMsgDspSec)
      End If
      Exit Sub
   End If
   sspTime.Caption = Mid(varTM(0, 0), 9, 8)
   ssfUP.Caption = "Upper(" & Mid(varTM(1, 0), 9, 8) & ")"
   ssfFGA.Caption = "FGA(" & Mid(varTM(2, 0), 9, 8) & ")"
   ssfOS.Caption = "OutSole(" & Mid(varTM(3, 0), 9, 8) & ")"
   ssfPU.Caption = "PU(" & Mid(varTM(4, 0), 9, 8) & ")"
   ssfPH.Caption = "Phylon(" & Mid(varTM(5, 0), 9, 8) & ")"
   ssfFSS.Caption = "FSS(" & Mid(varTM(6, 0), 9, 8) & ")"
   
   Call sbBarScan
   
   '=======================
   
   
   'Initializing Spread
   For i = 0 To fspLine.Rows - 1 Step 1
      For j = 1 To fspLine.Cols - 1 Step 1
         fspLine.TextMatrix(i, j) = ""
      Next j
   Next
   
   'PLAN BY LINE
   SQL = ""
   SQL = SQL & " SELECT OP_CD, LINE, SUM(QTY) "
   SQL = SQL & "   FROM V_PS_LINE_TOT "
   If ssoMD(0).Value Then
      SQL = SQL & "  WHERE YMD = '" & arg_ymd & "' "
   Else
      SQL = SQL & "  WHERE YMD >= '" & Mid(arg_ymd, 1, 6) & "01' AND YMD <= '" & arg_ymd & "' "
   End If
   
   SQL = SQL & "  GROUP BY OP_CD, LINE "
   SQL = SQL & "  ORDER BY 1, 2 "
   
   Screen.MousePointer = 11
   Set VATPLN = Nothing
   varPLN = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If Not IsArray(varPLN) Then
      tmrScan.Enabled = False
      chkAutoScan.Value = 0
      If varPLN = "" Then
         Call sbMsgDsp("Can not find PLAN Data!", gMsgDspSec)
      Else
         Call sbMsgDsp(varPLN, gMsgDspSec)
      End If
      'Exit Sub
   End If
   
   
   'RESULTS BY LINE
   SQL = ""
   SQL = SQL & " SELECT DECODE(SEMI_GOOD_CD||RST_DIV,'UPP',AREA_CD, 'UPO', AREA_CD, OP_CD), RST_DIV, SEMI_GOOD_CD, LINE, SUM(QTY), "
   SQL = SQL & "        SUM(DECODE(LEAST(DIR_YMD,YMD), YMD, 0, QTY)), "
   SQL = SQL & "        SUM(DECODE(DIR_YMD,YMD, QTY, 0)),"
   SQL = SQL & "        SUM(DECODE(GREATEST(DIR_YMD,YMD), YMD, 0, QTY)) "
   SQL = SQL & "   FROM V_MM_LINE_TOT "
   If ssoMD(0).Value Then
      SQL = SQL & "  WHERE YMD = '" & arg_ymd & "' "
   Else
      SQL = SQL & "  WHERE YMD >= '" & Mid(arg_ymd, 1, 6) & "01' AND YMD <= '" & arg_ymd & "' "
   End If
   SQL = SQL & "  GROUP BY DECODE(SEMI_GOOD_CD||RST_DIV,'UPP',AREA_CD, 'UPO', AREA_CD, OP_CD), RST_DIV, SEMI_GOOD_CD, LINE "
   SQL = SQL & "  ORDER BY 1, 2, 3 "
   
   Screen.MousePointer = 11
   Set varRST = Nothing
   varRST = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If Not IsArray(varRST) Then
      tmrScan.Enabled = False
      chkAutoScan.Value = 0
      If varRST = "" Then
         Call sbMsgDsp("Can not find Production Results Data!", gMsgDspSec)
      Else
         Call sbMsgDsp(varRST, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   SQL = ""
   SQL = SQL & " SELECT B.SEMI_GOOD_CD, A.ASSY_LINE, SUM(A.PRS_QTY) "
   SQL = SQL & "   FROM MP_PROD A,"
   SQL = SQL & "        PB_STYLE_ROUT B"
   
   If ssoMD(0).Value Then
      SQL = SQL & "  WHERE A.RST_YMD = '" & arg_ymd & "' "
   Else
      SQL = SQL & "  WHERE A.RST_YMD >= '" & Mid(arg_ymd, 1, 6) & "01' AND A.RST_YMD <= '" & arg_ymd & "' "
   End If
   
   SQL = SQL & "    AND A.PROC     = 'FSS'"
   SQL = SQL & "    AND A.RST_DIV  = 'P'"
   SQL = SQL & "    AND A.STYLE_CD = B.STYLE_CD"
   SQL = SQL & "    AND B.OP_PARENT = 'FSS'"
   SQL = SQL & "    AND A.ASSY_LINE IN ('1','2','3','4','5','6') "
   SQL = SQL & "  GROUP BY B.SEMI_GOOD_CD, A.ASSY_LINE "
   
   Screen.MousePointer = 11
   Set varCOMP = Nothing
   varCOMP = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If Not IsArray(varCOMP) Then
      tmrScan.Enabled = False
      chkAutoScan.Value = 0
      If varCOMP = "" Then
         Call sbMsgDsp("Can not find Components Production Results Data!", gMsgDspSec)
      Else
         Call sbMsgDsp(varCOMP, gMsgDspSec)
      End If
      Exit Sub
   End If
      
   'F/N Goods W/H Incoming
   SQL = ""
   SQL = SQL & " SELECT GRADE, SUM(PRS_QTY) "
   SQL = SQL & "   FROM MG_HEAD "
   
   If ssoMD(0).Value Then
      SQL = SQL & "  WHERE YMD = '" & arg_ymd & "' "
   Else
      SQL = SQL & "  WHERE YMD >= '" & Mid(arg_ymd, 1, 6) & "01' AND YMD <= '" & arg_ymd & "' "
   End If
   
   SQL = SQL & "    AND INOUT_DIV = 'I' "
   SQL = SQL & "    AND LOC_DIV = 'IR' "
   SQL = SQL & "  GROUP BY GRADE "
   SQL = SQL & "  ORDER BY 1"
   
   Screen.MousePointer = 11
   
   Set varGWH = Nothing
   varGWH = fnGetOraData(SQL)
   Screen.MousePointer = 1
   If Not IsArray(varGWH) Then
      tmrScan.Enabled = False
      chkAutoScan.Value = 0
      If varGWH = "" Then
         Call sbMsgDsp("Can not find Data of F/N Goods W/H Incoming!", gMsgDspSec)
      Else
         Call sbMsgDsp(varGWH, gMsgDspSec)
      End If
      Exit Sub
   End If
   
   For i = 0 To UBound(varGWH, 2) Step 1
      If varGWH(0, 0) = "A" Then
         lbrst(22).Caption = fnNVZ(varGWH(1, i))
      ElseIf varGWH(0, 0) = "B" Then
         lbrst(23).Caption = fnNVZ(varGWH(1, i))
      End If
   Next i
   
   Call sbDspData3(4)
   
   Call sbLineRst(gDept)
   
End Sub

Private Sub sbDspData2(ByVal arg_LINE As String)
   Dim varTOT As Variant
   Dim varTOT2 As Variant
   Dim i As Long
   Dim j As Long
   Dim k As Long
   Dim oldval As String
   Dim lSPA As Long
   Dim lSPP As Long
   Dim lSPPT As Long
   Dim lFSSSPT As Long
   Dim lPHP1 As Long
   Dim lPHP2 As Long
   Dim arg_pos As Integer
   
   arg_pos = 4
   
   cmdScan.Caption = arg_LINE & "-Line"
   'Initializing results label
   For i = 0 To lbrst.UBound - 2 Step 1
      lbrst(i).Caption = "0"
   Next i
   
   i = 0
   ReDim varTOT(i) As Long
   ReDim varTOT2(i) As Long
      
   oldval = ""
   Screen.MousePointer = 11
   For j = 0 To UBound(varRST, 2) Step 1
      If oldval <> varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j) Then
         ReDim Preserve varTOT(i)
         ReDim Preserve varTOT2(i)
         
         oldval = varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j)
         varTOT(i) = 0
         varTOT2(i) = 0
         i = i + 1
      End If
      
      If CInt(varRST(3, j)) <= 6 Then
         If gLine = "ALL" Then
            varTOT(i - 1) = varTOT(i - 1) + CLng(varRST(arg_pos, j))
         Else
            If gLine = CStr(varRST(3, j)) Then
               varTOT(i - 1) = varTOT(i - 1) + CLng(varRST(arg_pos, j))
            End If
         End If
      Else
         If gLine = "ALL" Then
            varTOT2(i - 1) = varTOT2(i - 1) + CLng(varRST(arg_pos, j))
         Else
            If gLine = CStr(varRST(3, j)) Then
               varTOT2(i - 1) = varTOT2(i - 1) + CLng(varRST(arg_pos, j))
            End If
         End If
      End If
   Next j
   
   For j = 0 To i - 1 Step 1
      Select Case varOP(j)
      Case "UPC1.T.UP"
         lbrst2(0).Caption = varTOT2(j)
      Case "UPC2.O.UP"
         lbrst(0).Caption = varTOT(j)
      Case "UPS1.P.UP"
         lbrst(1).Caption = varTOT(j)
         lbrst2(2).Caption = varTOT2(j)
      Case "UPS2.P.UP"
         lbrst(2).Caption = varTOT(j)
         
      Case "FGA.I.UP"
         lbrst(3).Caption = varTOT(j)
         
      Case "FGA.T.UP"
         lbrst(4).Caption = varTOT(j)
         lbrst2(4).Caption = varTOT2(j)
      Case "OSP.T.OS"
         lbrst(5).Caption = varTOT(j)
         lbrst2(24).Caption = varTOT2(j)
      Case "OSP.P.OS"
         lbrst(6).Caption = varTOT(j)
         lbrst2(22).Caption = varTOT2(j)
      Case "FSS.I.OS"
         lbrst(7).Caption = varTOT(j)
         
      Case "PUA.P.PU"
         lbrst(8).Caption = varTOT(j)
         lbrst2(32).Caption = varTOT2(j) 'PU Airbag을 입고로 처리
      Case "PUS.T.PU"
         lbrst2(30).Caption = varTOT2(j)
      Case "PUS.P.PU"
         lbrst(9).Caption = varTOT(j)
         lbrst2(28).Caption = varTOT2(j)
         
      Case "FSS.I.PU"
         lbrst(10).Caption = varTOT(j)
      Case "FSS.T.PU"
         lbrst2(18).Caption = varTOT2(j)
      Case "FSS.T.SP"
         lFSSSPT = varTOT2(j)
      Case "FSS.T.OS"
         lbrst2(16).Caption = varTOT2(j)
      Case "FSS.T.PH"
         lbrst2(20).Caption = varTOT2(j)
         
      Case "SPA.P.SP"
         lbrst(11).Caption = varTOT(j)
         lSPA = varTOT2(j)
      Case "SPP.T.SP"
         lSPPT = varTOT2(j)
      Case "SPP.P.SP"
         lbrst(12).Caption = varTOT(j)
         lSPP = varTOT2(j)
      Case "FSS.I.SP"
         lbrst(13).Caption = varTOT(j)
         
      Case "PHP.I.PH"
         lbrst(24).Caption = varTOT(j)
         lPHP1 = varTOT2(j)
         
      Case "PHP.O.PH"
         lbrst(14).Caption = varTOT(j)
         lPHP2 = varTOT2(j)
         
      Case "PHI.I.PH"
         lbrst(15).Caption = varTOT(j)
         lbrst2(38).Caption = varTOT2(j)
         
      Case "PHI.O.PH"
         lbrst(16).Caption = varTOT(j)
         lbrst2(34).Caption = varTOT2(j)
         
      Case "FSS.I.PH"
         lbrst(17).Caption = varTOT(j)
      
      Case "FSS.P.FS"
         lbrst(18).Caption = varTOT(j)
         lbrst2(14).Caption = varTOT2(j)
      Case "FGA.I.FS"
         lbrst(19).Caption = varTOT(j)
         
      Case "FGA.T.FS"
         lbrst(20).Caption = varTOT(j)
         lbrst2(6).Caption = varTOT2(j)
      Case "FGA.P.FG"
         lbrst(21).Caption = varTOT(j)
         lbrst2(8).Caption = varTOT2(j)
      Case Else
      
      End Select
   Next j
   
   'NOS Line Adjusting Data
   lbrst2(18).Caption = CStr(CLng(lbrst2(18).Caption) + lFSSSPT) 'FSS PU + SP Input
   lbrst2(32).Caption = CStr(CLng(lbrst2(32).Caption) + lSPA)    'PUA + SPA Production
   lbrst2(28).Caption = CStr(CLng(lbrst2(28).Caption) + lSPP)    'PUS + SPP Production
   lbrst2(30).Caption = CStr(CLng(lbrst2(30).Caption) + lSPPT)   'PUS + SPP Input
   lbrst2(38).Caption = CStr(CLng(lbrst2(38).Caption) + lPHP1)   'PHI + PHP Incoming
   lbrst2(34).Caption = CStr(CLng(lbrst2(34).Caption) + lPHP2)   'PHI + PHP Production
   
   'Displaying WIP
   'Upper
   lbWIP(0).Caption = fnOldWIP("UPS1.PO.UP", gLine) + CLng(lbrst(1).Caption) + CLng(lbrst(2).Caption) - CLng(lbrst(3).Caption)
   lbWIP(1).Caption = fnOldWIP("UPS2.IP.UP", gLine) + CLng(lbrst(0).Caption) - CLng(lbrst(2).Caption)
   
   'OS
   lbWIP(2).Caption = fnOldWIP("OSP.TP.OS", gLine) + CLng(lbrst(5).Caption) - CLng(lbrst(6).Caption)
   lbWIP(3).Caption = fnOldWIP("OSP.PO.OS", gLine) + CLng(lbrst(6).Caption) - CLng(lbrst(7).Caption)
   
   'PU
   lbWIP(4).Caption = fnOldWIP("PUS.TP.PU", gLine) + CLng(lbrst(8).Caption) - CLng(lbrst(9).Caption)
   lbWIP(5).Caption = fnOldWIP("PUS.PO.PU", gLine) + CLng(lbrst(9).Caption) - CLng(lbrst(10).Caption)
   
   lbWIP(6).Caption = fnOldWIP("SPP.TP.SP", gLine) + CLng(lbrst(11).Caption) - CLng(lbrst(12).Caption)
   lbWIP(7).Caption = fnOldWIP("SPP.PO.SP", gLine) + CLng(lbrst(12).Caption) - CLng(lbrst(13).Caption)
   
   'PH
   lbWIP(8).Caption = fnOldWIP("PHP.IO.PH", gLine) + CLng(lbrst(24).Caption) - CLng(lbrst(14).Caption)
   lbWIP(9).Caption = fnOldWIP("PHI.IO.PH", gLine) + CLng(lbrst(15).Caption) - CLng(lbrst(16).Caption)
   
   'FS
   lbWIP(10).Caption = fnOldWIP("FSS.IP.OS", gLine) + CLng(lbrst(7).Caption) - fnFssCOMP("OS", gLine)
   lbWIP(11).Caption = fnOldWIP("FSS.IP.PU", gLine) + CLng(lbrst(10).Caption) - fnFssCOMP("PU", gLine)
   lbWIP(12).Caption = fnOldWIP("FSS.IP.SP", gLine) + CLng(lbrst(13).Caption) - fnFssCOMP("SP", gLine)
   lbWIP(13).Caption = fnOldWIP("FSS.IP.PH", gLine) + CLng(lbrst(17).Caption) - fnFssCOMP("PH", gLine)
   
   lbWIP(14).Caption = fnOldWIP("FSS.PO.FS", gLine) + CLng(lbrst(18).Caption) - CLng(lbrst(19).Caption)
   
   'FG
   lbWIP(15).Caption = fnOldWIP("FGA.IT.UP", gLine) + CLng(lbrst(3).Caption) - CLng(lbrst(4).Caption)
   lbWIP(16).Caption = fnOldWIP("FGA.TP.UP", gLine) + CLng(lbrst(4).Caption) - CLng(lbrst(21).Caption)
   
   lbWIP(17).Caption = fnOldWIP("FGA.IT.FS", gLine) + CLng(lbrst(19).Caption) - CLng(lbrst(20).Caption)
   lbWIP(18).Caption = fnOldWIP("FGA.TP.FS", gLine) + CLng(lbrst(20).Caption) - CLng(lbrst(21).Caption)
   
   
   lbWIP(19).Caption = fnOldWIP("FGA.PO.FG", gLine) + CLng(lbrst(21).Caption) - CLng(lbrst(22).Caption)
   
   
   Screen.MousePointer = 1
End Sub


Private Sub sbLine_SUB(arg_OPCD As String, arg_RstDiv As String, arg_COMP As String, arg_HeadName As String, arg_Col As Long)
   Dim i As Long
   Dim j As Long
   Dim strV1 As String
   Dim strV2 As String
   
   strV1 = arg_OPCD & "." & arg_RstDiv & "." & arg_COMP
   
   fspLine.TextMatrix(0, arg_Col) = arg_HeadName
   i = fnFindArrData(varOP, arg_OPCD & "." & arg_RstDiv & "." & arg_COMP)
   If i >= 0 Then
      fg = False
      For j = varPOS(i) To UBound(varRST, 2) Step 1
         strV2 = varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j)
         If fg And strV1 <> strV2 Then
            Exit For
         End If
         If strV1 = strV2 Then
            fg = True
            fspLine.TextMatrix(CInt(varRST(3, j)), arg_Col) = fnNVZ(varRST(4, j))
         End If
      Next j
   End If
End Sub

Private Function fnLineRST(arg_val, arg_LINE As String) As Long
   Dim i As Long
   Dim j As Long
   Dim strV1 As String
   Dim strV2 As String
   Dim TOT As Long
   
   strV1 = arg_val
   
   
   i = fnFindArrData(varOP, arg_val)
   If i >= 0 Then
      If arg_LINE = "ALL" Then
         TOT = 0
         For j = varPOS(i) To UBound(varRST, 2) Step 1
            strV2 = varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j)
            If strV1 = strV2 Then
               TOT = TOT + CLng(fnNVZ(varRST(4, j)))
               If j < UBound(varRST, 2) Then
                  If varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j) <> varRST(0, j + 1) & "." & varRST(1, j + 1) & "." & varRST(2, j + 1) Then
                     Exit For
                  End If
               End If
            End If
         Next j
         fnLineRST = TOT
      Else
         For j = varPOS(i) To UBound(varRST, 2) Step 1
            strV2 = varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j)
            If strV1 = strV2 And CStr(varRST(3, j)) = arg_LINE Then
            
               fnLineRST = CLng(fnNVZ(varRST(4, j)))
               Exit Function
            End If
         Next j
         fnLineRST = 0
      End If
   Else
      fnLineRST = 0
   End If
   
End Function


Private Sub sbLine_DD(arg_OPCD As String, arg_RstDiv As String, arg_COMP As String)
   Dim i As Long
   Dim j As Long
   Dim strV1 As String
   Dim strV2 As String
   
   strV1 = arg_OPCD & "." & arg_RstDiv & "." & arg_COMP
   
   fspLine.TextMatrix(0, fspLine.Cols - 3) = "Late"
   fspLine.TextMatrix(0, fspLine.Cols - 2) = "Exact"
   fspLine.TextMatrix(0, fspLine.Cols - 1) = "Early"
   
   i = fnFindArrData(varOP, arg_OPCD & "." & arg_RstDiv & "." & arg_COMP)
   If i >= 0 Then
      fg = False
      For j = varPOS(i) To UBound(varRST, 2) Step 1
         strV2 = varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j)
         If fg And strV1 <> strV2 Then
            Exit For
         End If
         If strV1 = strV2 Then
            fg = True
            fspLine.TextMatrix(CInt(varRST(3, j)), fspLine.Cols - 3) = CStr(CLng(fnNVZ(fspLine.TextMatrix(CInt(varRST(3, j)), fspLine.Cols - 3))) + CLng(fnNVZ(varRST(5, j))))
            fspLine.TextMatrix(CInt(varRST(3, j)), fspLine.Cols - 2) = CStr(CLng(fnNVZ(fspLine.TextMatrix(CInt(varRST(3, j)), fspLine.Cols - 2))) + CLng(fnNVZ(varRST(6, j))))
            fspLine.TextMatrix(CInt(varRST(3, j)), fspLine.Cols - 1) = CStr(CLng(fnNVZ(fspLine.TextMatrix(CInt(varRST(3, j)), fspLine.Cols - 1))) + CLng(fnNVZ(varRST(7, j))))
         End If
      Next j
   End If
End Sub

Private Sub sbRate(arg_RstPos1 As Integer, arg_RstPos2 As Integer)
   Dim i As Integer
   Dim j As Integer
   Dim totval As Long
   Dim prodsum As Long
   Dim strVal As String
   Dim RateCol As Integer
   
   If arg_RstPos1 = -1 Then
      Exit Sub
   End If
   
   RateCol = fspLine.Cols - 4
   
   'Column Total
   For i = 1 To fspLine.Cols - 1 Step 1
      If i = RateCol Then
      Else
         totval = 0
         For j = 1 To fspLine.Rows - 2 Step 1
            totval = totval + CLng(IIf(fspLine.TextMatrix(j, i) = "", "0", fspLine.TextMatrix(j, i)))
         Next j
         fspLine.TextMatrix(fspLine.Rows - 1, i) = CStr(totval)
         fspLine.Cell(flexcpBackColor, fspLine.Rows - 1, 1, fspLine.Rows - 1, fspLine.Cols - 1) = vbYellow
      End If
   Next i
   
   fspLine.TextMatrix(0, RateCol) = "Rate(%)"
   For i = 1 To fspLine.Rows - 1 Step 1
      prodsum = CLng(IIf(fspLine.TextMatrix(i, arg_RstPos1) = "", "0", fspLine.TextMatrix(i, arg_RstPos1)))
      If arg_RstPos2 <> -1 Then
         prodsum = prodsum + CLng(IIf(fspLine.TextMatrix(i, arg_RstPos2) = "", "0", fspLine.TextMatrix(i, arg_RstPos2)))
      End If
      If fspLine.TextMatrix(i, 1) = "" Or fspLine.TextMatrix(i, 1) = "0" Then
         fspLine.TextMatrix(i, RateCol) = ""
      Else
         strVal = fnNVL(fspLine.TextMatrix(i, 1))
         If strVal = "0" Then
            fspLine.TextMatrix(i, RateCol) = ""
         Else
            fspLine.TextMatrix(i, RateCol) = CStr(Round(prodsum / CLng(strVal) * 100))
         End If
      End If
   Next i
   
End Sub


Private Sub sbLineRst(ByVal arg_dept As String)
   Dim i As Long
   Dim j As Long
   Dim k As Integer
   Dim q As Integer
   Dim fg As Boolean
   Dim strDept1 As String
   Dim strDept2 As String
   Dim varVAL As Variant
   Dim II As Integer
   Dim JJ As Long
   Dim CP As Variant
   Dim varKEY As Variant
   Dim InKEY As String
   Dim OutKEY As String
   Dim inGW As Long
   
   
   Dim IVTR As Long
   Dim INQTY As Long
   Dim OUTQTY As Long
   
   gDept = arg_dept
   
   If Not IsArray(varPLN) Then
      Call sbMsgDsp("Can not find PLAN Data!", gMsgDspSec)
      Exit Sub
   End If
   
   If Not IsArray(varRST) Then
      Call sbMsgDsp("Can not find Results Data!", gMsgDspSec)
      Exit Sub
   End If
   
   fspLine.Redraw = 0
   
   fspLine.Cell(flexcpAlignment, 0, 0, 0, fspLine.Cols - 1) = 4
   fspLine.Cell(flexcpAlignment, 0, 2, 0, 11) = 1
   fspLine.Cell(flexcpAlignment, 1, 1, fspLine.Rows - 1, fspLine.Cols - 1) = 7
   
   fspLine.Cell(flexcpForeColor, 0, 0, fspLine.Rows - 1, fspLine.Cols - 1) = vbBlack
   fspLine.Cell(flexcpBackColor, 1, fspLine.Cols - 4, fspLine.Rows - 2, fspLine.Cols - 4) = vbYellow
   fspLine.Cell(flexcpForeColor, 1, fspLine.Cols - 3, fspLine.Rows - 2, fspLine.Cols - 3) = vbRed
   fspLine.Cell(flexcpForeColor, 1, fspLine.Cols - 2, fspLine.Rows - 2, fspLine.Cols - 2) = vbBlue
   fspLine.Cell(flexcpForeColor, 1, fspLine.Cols - 1, fspLine.Rows - 2, fspLine.Cols - 1) = vbMagenta
   fspLine.Cell(flexcpFontBold, 1, fspLine.Cols - 4, fspLine.Rows - 1, fspLine.Cols - 1) = True
   
   'Initializing Spread
   For i = 0 To fspLine.Rows - 1 Step 1
      For j = 1 To fspLine.Cols - 1 Step 1
         fspLine.TextMatrix(i, j) = ""
      Next j
   Next
   
  'Setting Plan Data
   If gDept = "WH" Then
      fspLine.Redraw = 1
      Exit Sub
   End If
   
   fspLine.TextMatrix(0, 1) = "PLAN"
   
   strDept1 = "*"
   strDept2 = "*"
   
   Select Case arg_dept
   Case "UP"
      strDept1 = "UPS"
   Case "OS"
      strDept1 = "OSP"
   Case "PU"
      strDept1 = "PUS"
      strDept2 = "SPP"
   Case "PH"
      strDept1 = "PHP"
      strDept2 = "PHI"
   Case "FS"
      strDept1 = "FSS"
   Case "FG"
      strDept1 = "FGA"
   Case Else
      strDept1 = arg_dept
   End Select
   
   fg = False
   For i = 0 To UBound(varPLN, 2) Step 1
      If fg And varPLN(0, i) <> strDept1 Then
         Exit For
      End If
      If varPLN(0, i) = strDept1 Then
         fg = True
         fspLine.TextMatrix(CInt(varPLN(1, i)), 1) = fnNVZ(varPLN(2, i))
      End If
   Next i
   
   If strDept2 <> "*" Then
      fg = False
      For i = 0 To UBound(varPLN, 2) Step 1
         If fg And varPLN(0, i) <> strDept2 Then
            Exit For
         End If
         If varPLN(0, i) = strDept2 Then
            fg = True
            fspLine.TextMatrix(CInt(varPLN(1, i)), 1) = CStr(CLng(IIf(fspLine.TextMatrix(CInt(varPLN(1, i)), 1) = "", "0", fspLine.TextMatrix(CInt(varPLN(1, i)), 1))) + CLng(fnNVZ(varPLN(2, i))))
         End If
      Next i
   End If
   
   k = -1
   q = -1
   Call sbSetKind
   
   
   For i = 0 To UBound(vKIND) Step 1
      varVAL = Split(vKIND(i), ".", 3)
      
      CP = Mid(varVAL(0), 1, 2)
      If CP = "SP" Then
         CP = "PU"
      End If
      
      II = fnFindArrData(vOPCD, CP)
      For JJ = 0 To UBound(vLnPOS, 2) Step 1
         If Mid(CStr(vHeadCol(i)), 1, 7) = CStr(vLnPOS(II, JJ)) Then
            Call sbLine_SUB(CStr(varVAL(0)), CStr(varVAL(1)), CStr(varVAL(2)), CStr(vHeadCol(i)), JJ + 2)
            Exit For
         End If
      Next JJ
      
   Next i
      
   'varWIP
   II = fnFindArrData(vOPCD, arg_dept)
   For JJ = 0 To UBound(vLnPOS, 2) Step 1
      If Len(vLnPOS(II, JJ)) >= 9 Then
         fspLine.Cell(flexcpText, 0, JJ + 2, 0, JJ + 2) = "WIP." & Right(vLnPOS(II, JJ), 2)
         fspLine.Cell(flexcpAlignment, 0, JJ + 2, 0, JJ + 2) = 4
         fspLine.Cell(flexcpForeColor, 0, JJ + 2, fspLine.Rows - 1, JJ + 2) = vbBlue
         
         For i = 0 To UBound(varWIP, 2) Step 1
            If vLnPOS(II, JJ) = varWIP(0, i) Then
               varKEY = Split(varWIP(0, i), ".", 3)
               InKEY = varKEY(0) & "." & Mid(varKEY(1), 1, 1) & "." & varKEY(2)
               If InKEY = "UPS1.I.UP" Then
                     InKEY = "UPC1.O.UP"
               ElseIf InKEY = "UPS2.I.UP" Then
                  InKEY = "UPC2.O.UP"
               ElseIf InKEY = "PUS.T.PU" Then
                  InKEY = "PUA.P.PU"
               ElseIf InKEY = "SPP.T.SP" Then
                  InKEY = "SPA.P.SP"
               End If
               
               OutKEY = varKEY(0) & "." & Mid(varKEY(1), 2, 1) & "." & varKEY(2)
               If OutKEY = "UPS1.O.UP" Then
                  OutKEY = "FGA.I.UP"
               ElseIf OutKEY = "OSP.O.OS" Then
                  OutKEY = "FSS.I.OS"
               ElseIf OutKEY = "PUS.O.PU" Then
                  OutKEY = "FSS.I.PU"
               ElseIf OutKEY = "SPP.O.SP" Then
                  OutKEY = "FSS.I.SP"
               ElseIf OutKEY = "FSS.O.FS" Then
                  OutKEY = "FGA.I.FS"
               ElseIf OutKEY = "FGA.P.UP" Or OutKEY = "FGA.P.FS" Then
                  OutKEY = "FGA.P.FG"
               ElseIf OutKEY = "FGA.O.FG" Then
                  OutKEY = "FGW.I.FG"
               End If
               
               If CStr(varWIP(0, i)) = "UPS1.PO.UP" Then
                  fspLine.TextMatrix(CInt(varWIP(1, i)), JJ + 2) = CStr(CLng(varWIP(2, i)) + fnLineRST(InKEY, CStr(varWIP(1, i))) - fnLineRST(OutKEY, CStr(varWIP(1, i))) + fnLineRST("UPS2.P.UP", CStr(varWIP(1, i))))
                  
               ElseIf CStr(varWIP(0, i)) = "FSS.IP.OS" Then
                  fspLine.TextMatrix(CInt(varWIP(1, i)), JJ + 2) = CStr(CLng(varWIP(2, i)) + fnLineRST(InKEY, CStr(varWIP(1, i))) - fnFssCOMP("OS", CStr(varWIP(1, i))))
               ElseIf CStr(varWIP(0, i)) = "FSS.IP.PU" Then
                  fspLine.TextMatrix(CInt(varWIP(1, i)), JJ + 2) = CStr(CLng(varWIP(2, i)) + fnLineRST(InKEY, CStr(varWIP(1, i))) - fnFssCOMP("PU", CStr(varWIP(1, i))))
               ElseIf CStr(varWIP(0, i)) = "FSS.IP.SP" Then
                  fspLine.TextMatrix(CInt(varWIP(1, i)), JJ + 2) = CStr(CLng(varWIP(2, i)) + fnLineRST(InKEY, CStr(varWIP(1, i))) - fnFssCOMP("SP", CStr(varWIP(1, i))))
               ElseIf CStr(varWIP(0, i)) = "FSS.IP.PH" Then
                  fspLine.TextMatrix(CInt(varWIP(1, i)), JJ + 2) = CStr(CLng(varWIP(2, i)) + fnLineRST(InKEY, CStr(varWIP(1, i))) - fnFssCOMP("PH", CStr(varWIP(1, i))))
               
               ElseIf CStr(varWIP(0, i)) = "FGA.PO.FG" Then
               
                  If CLng(varWIP(1, i)) = 1 Then
                     If IsArray(varGWH) Then
                        inGW = CLng(varGWH(1, 0))
                     Else
                        inGW = 0
                     End If
                     IVTR = CLng(varWIP(2, i))
                     INQTY = fnLineRST(InKEY, "ALL")
                     OUTQTY = inGW
                     fspLine.TextMatrix(CInt(varWIP(1, i)), JJ + 2) = CStr(CLng(varWIP(2, i)) + INQTY - OUTQTY)
                  End If
               Else
                  IVTR = CLng(varWIP(2, i))
                  INQTY = fnLineRST(InKEY, CStr(varWIP(1, i)))
                  OUTQTY = fnLineRST(OutKEY, CStr(varWIP(1, i)))
                  fspLine.TextMatrix(CInt(varWIP(1, i)), JJ + 2) = CStr(IVTR + INQTY - OUTQTY)
               End If
               If i < UBound(varWIP, 2) Then
                  If varWIP(0, i) <> varWIP(0, i + 1) Then
                     Exit For
                  End If
               End If
            End If
         Next i
         
      End If
   Next JJ
   
   k = -1
   q = -1
   
   'Setting Results Data
   Select Case arg_dept
   Case "UP"
      k = 4
      q = 8
      Call sbLine_DD("UPS1", "P", "UP")
      Call sbLine_DD("UPS2", "P", "UP")
   Case "OS"
      k = 4
      Call sbLine_DD("OSP", "P", "OS")
   Case "PU"
      k = 4
      q = 8
      Call sbLine_DD("PUS", "P", "PU")
      Call sbLine_DD("SPP", "P", "SP")
   Case "PH"
      k = 4
      q = 7
      Call sbLine_DD("PHI", "O", "PH")
      Call sbLine_DD("PHP", "O", "PH")
   Case "FS"
      k = 10
      Call sbLine_DD("FSS", "P", "FS")
   Case "FG"
      k = 6
      Call sbLine_DD("FGA", "T", "UP")
   End Select
   
   Call sbRate(k, q)
   fspLine.Redraw = 1
   
End Sub

Private Sub sbCtlDept(ByRef obj As Object, ByRef obj2 As Object)
Dim i As Integer

   If obj(0).BevelOuter = 2 Then
      For i = 0 To obj.UBound Step 1
         obj(i).BevelOuter = 1 'Inner
      Next i
      obj2.Font3D = 2
      obj2.ForeColor = &HFF&
   Else
      For i = 0 To obj.UBound Step 1
         obj(i).BevelOuter = 2 'Outer
      Next i
      obj2.Font3D = 0
      obj2.ForeColor = 0
   End If
End Sub

Private Sub sbCtlDeptAllOut()

    If sspUP(0).BevelOuter = 1 Then
       Call sbCtlDept(sspUP, ssfUP)
    End If
    
    If sspOS(0).BevelOuter = 1 Then
       Call sbCtlDept(sspOS, ssfOS)
    End If
    
    If sspPU(0).BevelOuter = 1 Then
       Call sbCtlDept(sspPU, ssfPU)
    End If
    
    If sspPH(0).BevelOuter = 1 Then
       Call sbCtlDept(sspPH, ssfPH)
    End If
    
    If sspFSS(0).BevelOuter = 1 Then
       Call sbCtlDept(sspFSS, ssfFSS)
    End If
    
    If sspFGA(0).BevelOuter = 1 Then
       Call sbCtlDept(sspFGA, ssfFGA)
    End If
    
    If sspFGW(0).BevelOuter = 1 Then
       Call sbCtlDept(sspFGW, ssfFGW)
    End If
    
    '------ NOS ------
    If sspUP2(0).BevelOuter = 1 Then
       Call sbCtlDept(sspUP2, ssfUP2)
    End If
    If sspFGA2(0).BevelOuter = 1 Then
       Call sbCtlDept(sspFGA2, ssfFGA2)
    End If
    If sspFGW2(0).BevelOuter = 1 Then
       Call sbCtlDept(sspFGW2, ssfFGW2)
    End If
    If sspFSS2(0).BevelOuter = 1 Then
       Call sbCtlDept(sspFSS2, ssfFSS2)
    End If
    If sspOS2(0).BevelOuter = 1 Then
       Call sbCtlDept(sspOS2, ssfOS2)
    End If
    If sspPU2(0).BevelOuter = 1 Then
       Call sbCtlDept(sspPU2, ssfPU2)
    End If
    If sspPH2(0).BevelOuter = 1 Then
       Call sbCtlDept(sspPH2, ssfPH2)
    End If
    
End Sub

Private Sub cmdExit_Click()
   Unload Me
End Sub


Private Sub fspINFO_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   fspINFO.Visible = False
End Sub

Private Sub fspLine_DblClick()
   Dim vcolname As String
   
   gLine = fspLine.TextMatrix(fspLine.Row, 0)
   If Not IsNumeric(gLine) Then
      gLine = "ALL"
   End If
   cmdScan.Caption = gLine & "-Line"
   vcolname = fspLine.TextMatrix(0, fspLine.Col)
   If vcolname = "Late" Then
      Call sbDspData3(5)
   ElseIf vcolname = "Exact" Then
      Call sbDspData3(6)
   ElseIf vcolname = "Early" Then
      Call sbDspData3(7)
   Else
      Call sbDspData2(gLine)
   End If
   
   If gLine = "ALL" Then
      lbWIP(19).Visible = True
   Else
      lbWIP(19).Visible = False
   End If
End Sub


Private Sub lbrst_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   Dim ssfTOP As Long
   Dim ssfLEFT As Long

   If Not IsToday Then
      Exit Sub
   End If
   'If Index = 4 Then
   '   Exit Sub
   'End If
   
   ssfTOP = 0
   ssfLEFT = 0
   If Not vFlag Then
      Select Case Index
      
      Case 0
         Call subPopDsp("UPC", "O", "UP", "2")
         ssfTOP = ssfUP.Top + sspUP(0).Top + 50
         ssfLEFT = ssfUP.Left + sspUP(0).Left + 50
      Case 1
         Call subPopDsp("UPS", "P", "UP", "1")
         ssfTOP = ssfUP.Top + sspUP(2).Top + 50
         ssfLEFT = ssfUP.Left + sspUP(2).Left + 50
      Case 2
         Call subPopDsp("FGA", "I", "UP", "2")
         ssfTOP = ssfUP.Top + sspUP(1).Top + 50
         ssfLEFT = ssfUP.Left + sspUP(1).Left + 50
            
      Case 3
         Call subPopDsp("FGA", "I", "UP", "1")
         ssfTOP = ssfFGA.Top + sspFGA(0).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(0).Left + 50
      Case 4
         Call subPopDsp("FGA", "T", "UP", "1")
         ssfTOP = ssfFGA.Top + sspFGA(1).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(1).Left - 800
      Case 19
         Call subPopDsp("FGA", "I", "FS", "1")
         ssfTOP = ssfFGA.Top + sspFGA(2).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(2).Left
      Case 20
         Call subPopDsp("FGA", "T", "FS", "1")
         ssfTOP = ssfFGA.Top + sspFGA(3).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(3).Left - 800
      Case 21
         Call subPopDsp("FGA", "P", "FG", "1")
         ssfTOP = ssfFGA.Top + sspFGA(4).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(4).Left - 200
      
      Case 22
         Call subPopDsp("FGW", "I", "FG", "1")
         ssfTOP = ssfFGW.Top + sspFGW(0).Top + 50
         ssfLEFT = ssfFGW.Left + sspFGW(0).Left - 3150
      Case 23
         Call subPopDsp("FGW", "I", "FG", "2")
         ssfTOP = ssfFGW.Top + sspFGW(3).Top + 50
         ssfLEFT = ssfFGW.Left + sspFGW(3).Left - 3150
         
      Case 7
         Call subPopDsp("FSS", "I", "OS", "1")
         ssfTOP = ssfFSS.Top + sspFSS(0).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(0).Left + 50
      Case 10
         Call subPopDsp("FSS", "I", "PU", "1")
         ssfTOP = ssfFSS.Top + sspFSS(1).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(1).Left + 50
      Case 13
         Call subPopDsp("FSS", "I", "SP", "1")
         ssfTOP = ssfFSS.Top + sspFSS(2).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(2).Left + 50
      Case 17
         Call subPopDsp("FSS", "I", "PH", "1")
         ssfTOP = ssfFSS.Top + sspFSS(3).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(3).Left + 50
      Case 18
         Call subPopDsp("FSS", "P", "FS", "1")
         ssfTOP = ssfFSS.Top + sspFSS(4).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(4).Left + 50
         
      Case 5
         Call subPopDsp("OSP", "T", "OS", "1")
         ssfTOP = ssfOS.Top + sspOS(0).Top + 50
         ssfLEFT = ssfOS.Left + sspOS(0).Left + 50
      Case 6
         Call subPopDsp("OSP", "P", "OS", "1")
         ssfTOP = ssfOS.Top + sspOS(1).Top + 50
         ssfLEFT = ssfOS.Left + sspOS(1).Left + 50
      
      Case 8
         Call subPopDsp("PUA", "P", "PU", "1")
         ssfTOP = ssfPU.Top + sspPU(0).Top + 50
         ssfLEFT = ssfPU.Left + sspPU(0).Left + 50
      Case 9
         Call subPopDsp("PUS", "P", "PU", "1")
         ssfTOP = ssfPU.Top + sspPU(1).Top + 50
         ssfLEFT = ssfPU.Left + sspPU(1).Left + 50
      Case 11
         Call subPopDsp("SPA", "P", "SP", "1")
         ssfTOP = ssfPU.Top + sspPU(2).Top + 50
         ssfLEFT = ssfPU.Left + sspPU(2).Left + 50
      Case 12
         Call subPopDsp("SPP", "P", "SP", "1")
         ssfTOP = ssfPU.Top + sspPU(3).Top + 50
         ssfLEFT = ssfPU.Left + sspPU(3).Left + 50
      
      Case 24
         Call subPopDsp("PHP", "I", "PH", "1")
         ssfTOP = ssfPH.Top + sspPH(0).Top + 50
         ssfLEFT = ssfPH.Left + sspPH(0).Left + 50
      Case 14
         Call subPopDsp("PHP", "O", "PH", "1")
         ssfTOP = ssfPH.Top + sspPH(0).Top + 50
         ssfLEFT = ssfPH.Left + sspPH(0).Left + 50
      Case 15
         Call subPopDsp("PHI", "I", "PH", "1")
         ssfTOP = ssfPH.Top + sspPH(1).Top + 50
         ssfLEFT = ssfPH.Left + sspPH(1).Left + 50
      Case 16
         Call subPopDsp("PHI", "O", "PH", "1")
         ssfTOP = ssfPH.Top + sspPH(1).Top + 50
         ssfLEFT = ssfPH.Left + sspPH(1).Left + 50
      End Select
      
      vFlag = True
      fspINFO.Top = ssfTOP + lbrst(Index).Top + lbrst(Index).Height
      fspINFO.Left = ssfLEFT + lbrst(Index).Left
   
   End If
   
   
   fspINFO.Visible = True
End Sub

Private Sub lbrst2_Click(Index As Integer)
   Select Case Index
   Case 0 To 3
      Call sspUP2_Click(0)
   Case 21 To 26
      Call sspOS2_Click(0)
   Case 27 To 32
      Call sspPU2_Click(0)
   Case 33 To 38
      Call sspPH2_Click(0)
   Case 13 To 20
      Call sspFSS2_Click(0)
   Case 4 To 9
      Call sspFGA2_Click(0)
   Case 10 To 12
      Call sspFGW2_Click(0)
   End Select
End Sub



Private Sub lbWIP_Click(Index As Integer)
   Select Case Index
   Case 0, 1
      Call sspUP_Click(0)
   Case 2, 3
      Call sspOS_Click(0)
   Case 4, 5, 6, 7
      Call sspPU_Click(0)
   Case 8, 9
      Call sspPH_Click(0)
   Case 10, 11, 12, 13, 14
      Call sspFSS_Click(0)
   Case 15, 16, 17, 18, 19
      Call sspFGA_Click(0)
   End Select
End Sub

Private Sub lbWIP_DblClick(Index As Integer)
   Dim ssfTOP As Long
   Dim ssfLEFT As Long

   
   ssfTOP = 0
   ssfLEFT = 0
   If Not vFlag Then
      Select Case Index
      
      Case 0
         lbw.Caption = CStr(fnOldWIP("UPS1.PO.UP", gLine)) & " + " & lbrst(1).Caption & " - (" & lbrst(3).Caption & " - " & lbrst(2).Caption & ") = " & lbWIP(Index).Caption
         ssfTOP = ssfUP.Top + sspUP(2).Top + 50
         ssfLEFT = ssfUP.Left + sspUP(2).Left
      Case 1
         lbw.Caption = CStr(fnOldWIP("UPS2.IP.UP", gLine)) & " + " & lbrst(0).Caption & " - " & lbrst(2).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfUP.Top + sspUP(0).Top + 50
         ssfLEFT = ssfUP.Left + sspUP(0).Left
      Case 2
         lbw.Caption = CStr(fnOldWIP("OSP.TP.OS", gLine)) & " + " & lbrst(5).Caption & " - " & lbrst(6).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfOS.Top + sspOS(1).Top + 50
         ssfLEFT = ssfOS.Left + sspOS(1).Left
      Case 3
         lbw.Caption = CStr(fnOldWIP("OSP.PO.OS", gLine)) & " + " & lbrst(6).Caption & " - " & lbrst(7).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfOS.Top + sspOS(2).Top + 50
         ssfLEFT = ssfOS.Left + sspOS(2).Left
      Case 4
         lbw.Caption = CStr(fnOldWIP("PUS.TP.PU", gLine)) & " + " & lbrst(8).Caption & " - " & lbrst(9).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfPU.Top + sspPU(1).Top + 50
         ssfLEFT = ssfPU.Left + sspPU(1).Left
      Case 5
         lbw.Caption = CStr(fnOldWIP("PUS.PO.PU", gLine)) & " + " & lbrst(9).Caption & " - " & lbrst(10).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfPU.Top + sspPU(4).Top + 50
         ssfLEFT = ssfPU.Left + sspPU(4).Left
      Case 6
         lbw.Caption = CStr(fnOldWIP("SPP.TP.SP", gLine)) & " + " & lbrst(11).Caption & " - " & lbrst(12).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfPU.Top + sspPU(3).Top + 50
         ssfLEFT = ssfPU.Left + sspPU(3).Left
      Case 7
         lbw.Caption = CStr(fnOldWIP("SPP.PO.SP", gLine)) & " + " & lbrst(12).Caption & " - " & lbrst(13).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfPU.Top + sspPU(5).Top + 50
         ssfLEFT = ssfPU.Left + sspPU(5).Left
      Case 8
         lbw.Caption = CStr(fnOldWIP("PHP.IO.PH", gLine)) & " + " & lbrst(24).Caption & " - " & lbrst(14).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfPH.Top + sspPH(0).Top + 50
         ssfLEFT = ssfPH.Left + sspPH(0).Left
      Case 9
         lbw.Caption = CStr(fnOldWIP("PHI.IO.PH", gLine)) & " + " & lbrst(15).Caption & " - " & lbrst(16).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfPH.Top + sspPH(1).Top + 50
         ssfLEFT = ssfPH.Left + sspPH(1).Left
      Case 10
         lbw.Caption = CStr(fnOldWIP("FSS.IP.OS", gLine)) & " + " & lbrst(7).Caption & " - " & CStr(fnFssCOMP("OS", gLine)) & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFSS.Top + sspFSS(0).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(0).Left
      Case 11
         lbw.Caption = CStr(fnOldWIP("FSS.IP.PU", gLine)) & " + " & lbrst(10).Caption & " - " & CStr(fnFssCOMP("PU", gLine)) & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFSS.Top + sspFSS(1).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(1).Left
      Case 12
         lbw.Caption = CStr(fnOldWIP("FSS.IP.SP", gLine)) & " + " & lbrst(13).Caption & " - " & CStr(fnFssCOMP("SP", gLine)) & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFSS.Top + sspFSS(2).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(2).Left
      Case 13
         lbw.Caption = CStr(fnOldWIP("FSS.IP.PH", gLine)) & " + " & lbrst(17).Caption & " - " & CStr(fnFssCOMP("PH", gLine)) & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFSS.Top + sspFSS(3).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(3).Left
      Case 14
         lbw.Caption = CStr(fnOldWIP("FSS.PO.FS", gLine)) & " + " & lbrst(18).Caption & " - " & lbrst(19).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFSS.Top + sspFSS(4).Top + 50
         ssfLEFT = ssfFSS.Left + sspFSS(4).Left
      Case 15
         lbw.Caption = CStr(fnOldWIP("FGA.IT.UP", gLine)) & " + " & lbrst(3).Caption & " - " & lbrst(4).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFGA.Top + sspFGA(0).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(0).Left
      Case 16
         lbw.Caption = CStr(fnOldWIP("FGA.TP.UP", gLine)) & " + " & lbrst(4).Caption & " - " & lbrst(21).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFGA.Top + sspFGA(1).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(1).Left
      Case 17
         lbw.Caption = CStr(fnOldWIP("FGA.IT.FS", gLine)) & " + " & lbrst(19).Caption & " - " & lbrst(20).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFGA.Top + sspFGA(2).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(2).Left
      
      Case 18
         lbw.Caption = CStr(fnOldWIP("FGA.TP.FS", gLine)) & " + " & lbrst(20).Caption & " - " & lbrst(21).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFGA.Top + sspFGA(3).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(3).Left
      Case 19
         lbw.Caption = CStr(fnOldWIP("FGA.PO.FG", gLine)) & " + " & lbrst(21).Caption & " - " & lbrst(20).Caption & " = " & lbWIP(Index).Caption
         ssfTOP = ssfFGA.Top + sspFGA(4).Top + 50
         ssfLEFT = ssfFGA.Left + sspFGA(4).Left
      End Select
   
      sspWIP.Visible = True
      vFlag = True
      sspWIP.Top = ssfTOP + lbWIP(Index).Top + lbWIP(Index).Height
      sspWIP.Left = ssfLEFT + lbWIP(Index).Left
      
   End If
End Sub

Private Sub SSCommand2_Click()
   sspWIP.Visible = False
End Sub

Private Sub SSCommand3_Click()
   ssfMenu.Visible = False
   cmdMenu.Visible = True
   
End Sub

Private Sub ssfFGA_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
   
End Sub

Private Sub ssfFGW_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub ssfFSS_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub ssfOS_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub ssfPH_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub ssfPU_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub ssfUP_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   fspINFO.Visible = False
   vFlag = False
End Sub


Private Sub ssoMD_Click(Index As Integer, Value As Integer)
   If ssoMD(0) Then
      chkAutoScan.Visible = True
      If Format(dtpYMD.Value, "YYYYMMDD") = Format(DateAdd("h", 2, Now), "YYYYMMDD") Then
         IsToday = True
      Else
         IsToday = False
      End If
   Else
      chkAutoScan.Value = 0
      chkAutoScan.Visible = False
      IsToday = False
   End If
   
   Call sbOldWipScan
   
   Call cmdScan_Click
End Sub

Private Sub SSPanel1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
   If Button = vbLeftButton Then
      offsetX = X
      offsetY = Y
   End If
End Sub

Private Sub SSPanel1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   If Button = vbLeftButton Then
      sspWIP.Left = oldX + SSPanel1.Left - offsetX + X
      sspWIP.Top = oldY + SSPanel1.Top - offsetY + Y
      oldX = sspWIP.Left
      oldY = sspWIP.Top
   End If
End Sub


Private Sub sspMTitle_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
   If Button = vbLeftButton Then
      offsetX = X
      offsetY = Y
   End If
End Sub

Private Sub sspMTitle_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
   If Button = vbLeftButton Then
      ssfMenu.Left = oldX + sspMTitle.Left - offsetX + X
      ssfMenu.Top = oldY + sspMTitle.Top - offsetY + Y
      oldX = ssfMenu.Left
      oldY = ssfMenu.Top
   End If
End Sub

Private Sub sspFGA_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub sspFGW_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub sspFSS_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub




Private Sub sspOS_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub sspPH_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub sspPU_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   vFlag = False
   fspINFO.Visible = False
End Sub

Private Sub sspUP_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspUP, ssfUP)
   Call sbLineRst("UP")
End Sub

Private Sub sspOS_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspOS, ssfOS)
   Call sbLineRst("OS")
End Sub

Private Sub sspPU_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspPU, ssfPU)
   Call sbLineRst("PU")
End Sub

Private Sub sspPH_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspPH, ssfPH)
   Call sbLineRst("PH")
End Sub

Private Sub sspFSS_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFSS, ssfFSS)
   Call sbLineRst("FS")
End Sub

Private Sub sspFGA_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGA, ssfFGA)
   Call sbLineRst("FG")
End Sub

Private Sub sspFGW_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGW, ssfFGW)
   Call sbLineRst("WH")
   
End Sub



Private Sub sspUP2_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspUP2, ssfUP2)
   Call sbLineRst("UP")
End Sub

Private Sub sspFGA2_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGA2, ssfFGA2)
   Call sbLineRst("FG")
End Sub

Private Sub sspFGW2_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGW2, ssfFGW2)
   Call sbLineRst("WH")
End Sub

Private Sub sspOS2_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspOS2, ssfOS2)
   Call sbLineRst("OS")
End Sub

Private Sub sspPU2_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspPU2, ssfPU2)
   Call sbLineRst("PU")
End Sub

Private Sub sspPH2_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspPH2, ssfPH2)
   Call sbLineRst("PH")
End Sub

Private Sub sspFSS2_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFSS2, ssfFSS2)
   Call sbLineRst("FS")
End Sub

Private Sub lbrst_Click(Index As Integer)
   Select Case Index
   Case 0, 1, 2
      Call sspUP_Click(0)
   Case 5, 6
      Call sspOS_Click(0)
   Case 8, 9, 11, 12
      Call sspPU_Click(0)
   Case 14, 15, 16
      Call sspPH_Click(0)
   Case 7, 10, 13, 17, 18
      Call sspFSS_Click(0)
   Case 3, 4, 19, 20, 21
      Call sspFGA_Click(0)
   Case 22, 23
      Call sspFGW_Click(0)
   End Select
End Sub



Private Sub lbUP_Click(Index As Integer)
   Call sspUP_Click(0)
  
End Sub

Private Sub lbOS_Click(Index As Integer)
   Call sspOS_Click(0)
End Sub

Private Sub lbPU_Click(Index As Integer)
   Call sspPU_Click(0)
End Sub

Private Sub lbPH_Click(Index As Integer)
   Call sspPH_Click(0)
End Sub

Private Sub lbFGW_Click(Index As Integer)
   Call sspFGW_Click(0)
End Sub

Private Sub smdPassMark_Click()
   frmMO04VJ.Show 1
End Sub

Private Sub SSCommand1_Click()
   tmrScan.Enabled = False
   If gDept = "WH" Then
      frmMO02VJ.Show 1 ' F/N Goods W/H
   Else
      frmMO03VJ.Show 1 ' Production Results
   End If
End Sub


Private Sub sspMsg_Click()
   sspMsg.Visible = False
   sspMsg.Caption = ""
End Sub

Private Sub sspUP_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
   fspINFO.Visible = False
   vFlag = False
End Sub

Private Sub tmrBLK_Timer()
   Dim i As Integer
   
   If Not IsToday Then
      Exit Sub
   End If
   
   If vBlnk Then
      vBlnk = False
   Else
      vBlnk = True
   End If
   
   For i = 0 To lbrst.UBound Step 1
      If lbrst(i).Tag = "Y" Then
         If vBlnk Then
            lbrst(i).Visible = False
         Else
            lbrst(i).Visible = True
         End If
      Else
         lbrst(i).Visible = True
      End If
   Next i
   
End Sub

Private Sub tmrMSG_Timer()
   sspMsg.Visible = False
   sspMsg.Caption = ""
   tmrMSG.Enabled = False
End Sub

Private Sub tmrNow_Timer()
   Dim i As Integer
   Dim OldKey As String
   
   If vDownFlag Then
      Exit Sub
   End If
   
   For i = 0 To lbrst.UBound Step 1
       lbrst(i).Tag = ""
   Next i
   
   If chkAutoScan.Value <> 1 Or (Not IsToday) Then
      Exit Sub
   End If
   
   OldKey = ""
   For i = 0 To UBound(varSCN, 2) Step 1
      If CStr(varSCN(6, i)) >= Format(DateAdd("n", -2, Now), "YYYYMMDDHHMMSS") Then
         If OldKey <> CStr(varSCN(0, i)) & CStr(varSCN(1, i)) & CStr(varSCN(2, i)) & CStr(varSCN(4, i)) Then
            OldKey = CStr(varSCN(0, i)) & CStr(varSCN(1, i)) & CStr(varSCN(2, i)) & CStr(varSCN(4, i))
            'OP_CD, RST_DIV, SEMI_GOOD_CD, UPPER_DIV
            Select Case OldKey
            Case "UPCOUP2"
               lbrst(0).Tag = "Y"
            Case "FGAIUP2"
               lbrst(1).Tag = "Y"
               lbrst(3).Tag = "Y"
            Case "UPSPUP1"
               lbrst(2).Tag = "Y"
            Case "OSPTOS1"
               lbrst(5).Tag = "Y"
            Case "OSPPOS1"
               lbrst(6).Tag = "Y"
            Case "PUAPPU1"
               lbrst(8).Tag = "Y"
            Case "PUSPPU1"
               lbrst(9).Tag = "Y"
            Case "SPAPSP1"
               lbrst(11).Tag = "Y"
            Case "SPPPSP1"
               lbrst(12).Tag = "Y"
            Case "PHPIPH1"
               lbrst(24).Tag = "Y"
            Case "PHPOPH1"
               lbrst(14).Tag = "Y"
            Case "PHIIPH1"
               lbrst(15).Tag = "Y"
            Case "PHIOPH1"
               lbrst(16).Tag = "Y"
            Case "FSSIOS1"
               lbrst(7).Tag = "Y"
            Case "FSSIPU1"
               lbrst(10).Tag = "Y"
            Case "FSSISP1"
               lbrst(13).Tag = "Y"
            Case "FSSIPH1"
               lbrst(17).Tag = "Y"
            Case "FSSPFS1"
               lbrst(18).Tag = "Y"
            Case "FGAIUP1"
               lbrst(3).Tag = "Y"
            Case "FGATUP1"
               lbrst(4).Tag = "Y"
            Case "FGAIFS1"
               lbrst(19).Tag = "Y"
            Case "FGATFS1"
               lbrst(20).Tag = "Y"
            Case "FGAPFG1"
               lbrst(21).Tag = "Y"
            Case "FGWIFG1"
               lbrst(22).Tag = "Y"
            Case "FGWIFG2"
               lbrst(23).Tag = "Y"
            End Select
            
         End If
      End If
   Next i
   
End Sub

Private Sub tmrScan_Timer()
   If chkAutoScan.Value = 0 Or (Not IsToday) Then
      tmrScan.Enabled = False
      Exit Sub
   End If
   
   dtpYMD.Value = Now
   mm_Count = mm_Count + 1
   If mm_Count = gINTERVAL Then
      Call sbDspData(Format(dtpYMD.Value, "YYYYMMDD"), "ALL")
      mm_Count = 0
   End If
   
End Sub

Private Sub sbMsgDsp(arg_MSG As Variant, arg_INTVL As Integer)
   sspMsg.Caption = arg_MSG
   sspMsg.Visible = True
   tmrMSG.Interval = arg_INTVL * 1000
   tmrMSG.Enabled = True
End Sub

Private Sub vsc1_Change()
   Dim Y As Long
   'ssfDate
   '11115 = 100 * 11.115
   If 10000 < Me.Height Then
      Exit Sub
   End If
   Y = 2080
   'cmdStockClose.Caption = CStr(vsc1.Value)
   
   If vsc1.Value = 1 Then
      IsToday = False
      ssfDate.Top = CLng(ssfDate.Tag) - Y
      ssfUP.Top = CLng(ssfUP.Tag) - Y
      ssfFGA.Top = CLng(ssfFGA.Tag) - Y
      ssfFGW.Top = CLng(ssfFGW.Tag) - Y
      ssfOS.Top = CLng(ssfOS.Tag) - Y
      ssfPH.Top = CLng(ssfPH.Tag) - Y
      ssfPU.Top = CLng(ssfPU.Tag) - Y
      ssfFSS.Top = CLng(ssfFSS.Tag) - Y
      ssfLine.Top = CLng(ssfLine.Tag) - Y
      ssfMenu.Top = CLng(ssfMenu.Tag) - Y
      
      ssfDate.Left = 45 - Y
      ssfUP.Left = 3165 - Y
      ssfFGA.Left = 8400 - Y
      ssfFGW.Left = 12600 - Y
      ssfOS.Left = 45 - Y
      ssfPH.Left = 45 - Y
      ssfPU.Left = 45 - Y
      ssfFSS.Left = 4485 - Y
      ssfLine.Left = 45
      ssfMenu.Left = 8400 - Y
   Else
      If Format(dtpYMD.Value, "YYYYMMDD") = Format(DateAdd("h", 2, Now), "YYYYMMDD") Then
         IsToday = True
      Else
         IsToday = False
      End If
      ssfDate.Top = CLng(ssfDate.Tag)
      ssfUP.Top = CLng(ssfUP.Tag)
      ssfFGA.Top = CLng(ssfFGA.Tag)
      ssfFGW.Top = CLng(ssfFGW.Tag)
      ssfOS.Top = CLng(ssfOS.Tag)
      ssfPH.Top = CLng(ssfPH.Tag)
      ssfPU.Top = CLng(ssfPU.Tag)
      ssfFSS.Top = CLng(ssfFSS.Tag)
      ssfLine.Top = CLng(ssfLine.Tag)
      ssfMenu.Top = CLng(ssfMenu.Tag)
      ssfDate.Left = 45
      ssfUP.Left = 3165
      ssfFGA.Left = 8400
      ssfFGW.Left = 12600
      ssfOS.Left = 45
      ssfPH.Left = 45
      ssfPU.Left = 45
      ssfFSS.Left = 4485
      ssfLine.Left = 45
      ssfMenu.Left = 8400
      
   End If
   ssfFGA.Font.Size = 8
End Sub
