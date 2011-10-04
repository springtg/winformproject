VERSION 5.00
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Begin VB.Form frmMO01VJ 
   Caption         =   "Manufacturing Execute System"
   ClientHeight    =   8790
   ClientLeft      =   90
   ClientTop       =   330
   ClientWidth     =   14010
   LinkTopic       =   "Form1"
   ScaleHeight     =   8790
   ScaleWidth      =   14010
   Begin Threed.SSPanel SSPanel14 
      Height          =   600
      Left            =   1980
      TabIndex        =   57
      Top             =   3495
      Width           =   30
      _Version        =   65536
      _ExtentX        =   53
      _ExtentY        =   1058
      _StockProps     =   15
      BackColor       =   13160660
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±¼¸²"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BorderWidth     =   1
      BevelOuter      =   1
   End
   Begin VB.PictureBox Picture16 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00008080&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   240
      Picture         =   "frmMO01VJ.frx":0000
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   48
      Top             =   5760
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture24 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00808080&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   8865
      Picture         =   "frmMO01VJ.frx":08CA
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   56
      Top             =   3990
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture23 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00808080&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   7920
      Picture         =   "frmMO01VJ.frx":1194
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   55
      Top             =   3990
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture22 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00808080&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   6510
      Picture         =   "frmMO01VJ.frx":1A5E
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   54
      Top             =   3960
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture21 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00008080&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   4095
      Picture         =   "frmMO01VJ.frx":2328
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   53
      Top             =   5370
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture20 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00008000&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   4110
      Picture         =   "frmMO01VJ.frx":2BF2
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   52
      Top             =   4260
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture19 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H0000FF00&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   4095
      Picture         =   "frmMO01VJ.frx":34BC
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   51
      Top             =   3615
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture18 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00FF00FF&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   4095
      Picture         =   "frmMO01VJ.frx":3D86
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   50
      Top             =   2760
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture17 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00008080&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   3330
      Picture         =   "frmMO01VJ.frx":4650
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   49
      Top             =   5760
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture15 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00008080&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   3330
      Picture         =   "frmMO01VJ.frx":4F1A
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   47
      Top             =   5130
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture14 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00008000&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   2400
      Picture         =   "frmMO01VJ.frx":57E4
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   46
      Top             =   4275
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture13 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00008000&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   945
      Picture         =   "frmMO01VJ.frx":60AE
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   33
      Top             =   4275
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture12 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H0000FF00&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   2400
      Picture         =   "frmMO01VJ.frx":6978
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   32
      Top             =   3630
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture11 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H0000FF00&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   930
      Picture         =   "frmMO01VJ.frx":7242
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   31
      Top             =   3645
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture10 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00FF00FF&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   2460
      Picture         =   "frmMO01VJ.frx":7B0C
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   30
      Top             =   2805
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture9 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00FF00FF&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   1245
      Picture         =   "frmMO01VJ.frx":83D6
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   29
      Top             =   2790
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture8 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00808000&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   11715
      Picture         =   "frmMO01VJ.frx":8CA0
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   28
      Top             =   5325
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture7 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H0000FFFF&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   6240
      Picture         =   "frmMO01VJ.frx":956A
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   27
      Top             =   1605
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture6 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00808000&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   10305
      Picture         =   "frmMO01VJ.frx":9E34
      ScaleHeight     =   420
      ScaleWidth      =   420
      TabIndex        =   26
      Top             =   1935
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.PictureBox Picture5 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H0000FFFF&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   8880
      Picture         =   "frmMO01VJ.frx":A6FE
      ScaleHeight     =   420
      ScaleWidth      =   420
      TabIndex        =   25
      Top             =   780
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.PictureBox picArrow 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H0000FFFF&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   3570
      Picture         =   "frmMO01VJ.frx":AFC8
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   22
      Top             =   675
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture4 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H00808000&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   11715
      Picture         =   "frmMO01VJ.frx":B892
      ScaleHeight     =   420
      ScaleWidth      =   435
      TabIndex        =   24
      Top             =   1545
      Visible         =   0   'False
      Width           =   435
   End
   Begin VB.PictureBox Picture3 
      Appearance      =   0  'Æò¸é
      BackColor       =   &H0000FFFF&
      BorderStyle     =   0  '¾øÀ½
      ForeColor       =   &H80000008&
      Height          =   420
      Left            =   7920
      Picture         =   "frmMO01VJ.frx":C15C
      ScaleHeight     =   420
      ScaleWidth      =   420
      TabIndex        =   23
      Top             =   765
      Visible         =   0   'False
      Width           =   420
   End
   Begin Threed.SSFrame ssfFGW 
      Height          =   6345
      Left            =   11565
      TabIndex        =   4
      Top             =   30
      Width           =   2415
      _Version        =   65536
      _ExtentX        =   4260
      _ExtentY        =   11192
      _StockProps     =   14
      Caption         =   "FGW"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±¼¸²"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspFGW 
         Height          =   3150
         Index           =   0
         Left            =   105
         TabIndex        =   5
         Top             =   195
         Width           =   2175
         _Version        =   65536
         _ExtentX        =   3836
         _ExtentY        =   5556
         _StockProps     =   15
         BackColor       =   8421376
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFGW 
         Height          =   765
         Index           =   1
         Left            =   105
         TabIndex        =   6
         Top             =   3345
         Width           =   2175
         _Version        =   65536
         _ExtentX        =   3836
         _ExtentY        =   1349
         _StockProps     =   15
         BackColor       =   8421376
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFGW 
         Height          =   1305
         Index           =   3
         Left            =   105
         TabIndex        =   7
         Top             =   4890
         Width           =   2175
         _Version        =   65536
         _ExtentX        =   3836
         _ExtentY        =   2302
         _StockProps     =   15
         BackColor       =   8421376
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFGW 
         Height          =   765
         Index           =   2
         Left            =   105
         TabIndex        =   8
         Top             =   4110
         Width           =   2175
         _Version        =   65536
         _ExtentX        =   3836
         _ExtentY        =   1349
         _StockProps     =   15
         BackColor       =   8421376
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
   End
   Begin Threed.SSFrame ssfFGA 
      Height          =   6345
      Left            =   7755
      TabIndex        =   0
      Top             =   30
      Width           =   3840
      _Version        =   65536
      _ExtentX        =   6773
      _ExtentY        =   11192
      _StockProps     =   14
      Caption         =   "FGA"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±¼¸²"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspFGA 
         Height          =   1890
         Index           =   0
         Left            =   120
         TabIndex        =   1
         Top             =   180
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   3334
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   1890
         Index           =   1
         Left            =   1320
         TabIndex        =   2
         Top             =   180
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   3334
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   6015
         Index           =   4
         Left            =   2505
         TabIndex        =   3
         Top             =   180
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   10610
         _StockProps     =   15
         BackColor       =   8421376
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   3945
         Index           =   2
         Left            =   120
         TabIndex        =   14
         Top             =   2250
         Width           =   1185
         _Version        =   65536
         _ExtentX        =   2090
         _ExtentY        =   6959
         _StockProps     =   15
         BackColor       =   8421504
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   3945
         Index           =   3
         Left            =   1305
         TabIndex        =   15
         Top             =   2250
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   6959
         _StockProps     =   15
         BackColor       =   8421504
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
   End
   Begin Threed.SSFrame ssfFSS 
      Height          =   4275
      Left            =   3930
      TabIndex        =   9
      Top             =   2100
      Width           =   3855
      _Version        =   65536
      _ExtentX        =   6800
      _ExtentY        =   7541
      _StockProps     =   14
      Caption         =   "FSS"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±¼¸²"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspFSS 
         Height          =   960
         Index           =   0
         Left            =   120
         TabIndex        =   10
         Top             =   195
         Width           =   2400
         _Version        =   65536
         _ExtentX        =   4233
         _ExtentY        =   1693
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   3930
         Index           =   4
         Left            =   2520
         TabIndex        =   11
         Top             =   195
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   6932
         _StockProps     =   15
         BackColor       =   8421504
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   615
         Index           =   1
         Left            =   120
         TabIndex        =   12
         Top             =   1365
         Width           =   2400
         _Version        =   65536
         _ExtentX        =   4233
         _ExtentY        =   1085
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   645
         Index           =   2
         Left            =   135
         TabIndex        =   13
         Top             =   1995
         Width           =   2400
         _Version        =   65536
         _ExtentX        =   4233
         _ExtentY        =   1138
         _StockProps     =   15
         BackColor       =   32768
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9.01
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   1275
         Index           =   3
         Left            =   120
         TabIndex        =   16
         Top             =   2850
         Width           =   2385
         _Version        =   65536
         _ExtentX        =   4207
         _ExtentY        =   2249
         _StockProps     =   15
         BackColor       =   32896
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
   End
   Begin Threed.SSFrame ssfPH 
      Height          =   1620
      Left            =   45
      TabIndex        =   39
      Top             =   4755
      Width           =   3915
      _Version        =   65536
      _ExtentX        =   6906
      _ExtentY        =   2857
      _StockProps     =   14
      Caption         =   "Phylon"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±¼¸²"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel SSPanel11 
         Height          =   255
         Left            =   525
         TabIndex        =   58
         Top             =   915
         Width           =   495
         _Version        =   65536
         _ExtentX        =   873
         _ExtentY        =   450
         _StockProps     =   15
         Caption         =   "PHI"
         ForeColor       =   4194304
         BackColor       =   32896
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   9.01
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel SSPanel10 
         Height          =   255
         Left            =   450
         TabIndex        =   59
         Top             =   270
         Width           =   735
         _Version        =   65536
         _ExtentX        =   1296
         _ExtentY        =   450
         _StockProps     =   15
         Caption         =   "PHP"
         ForeColor       =   4194304
         BackColor       =   32896
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   9.01
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel sspPH 
         Height          =   630
         Index           =   0
         Left            =   150
         TabIndex        =   40
         Top             =   210
         Width           =   3600
         _Version        =   65536
         _ExtentX        =   6350
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   32896
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspPH 
         Height          =   630
         Index           =   1
         Left            =   150
         TabIndex        =   41
         Top             =   855
         Width           =   3600
         _Version        =   65536
         _ExtentX        =   6350
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   32896
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
   End
   Begin Threed.SSFrame ssfPU 
      Height          =   1560
      Left            =   45
      TabIndex        =   34
      Top             =   3285
      Width           =   3915
      _Version        =   65536
      _ExtentX        =   6906
      _ExtentY        =   2752
      _StockProps     =   14
      Caption         =   "PU"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±¼¸²"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel SSPanel15 
         Height          =   210
         Left            =   1980
         TabIndex        =   66
         Top             =   240
         Width           =   405
         _Version        =   65536
         _ExtentX        =   714
         _ExtentY        =   370
         _StockProps     =   15
         Caption         =   "PUS"
         ForeColor       =   4194304
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   8.99
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel SSPanel7 
         Height          =   210
         Left            =   1380
         TabIndex        =   65
         Top             =   240
         Width           =   405
         _Version        =   65536
         _ExtentX        =   714
         _ExtentY        =   370
         _StockProps     =   15
         Caption         =   "PUP"
         ForeColor       =   4194304
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   8.99
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel SSPanel8 
         Height          =   195
         Left            =   375
         TabIndex        =   64
         Top             =   270
         Width           =   735
         _Version        =   65536
         _ExtentX        =   1296
         _ExtentY        =   344
         _StockProps     =   15
         Caption         =   "PUA"
         ForeColor       =   4194304
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   0
         Left            =   165
         TabIndex        =   35
         Top             =   195
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   1
         Left            =   1365
         TabIndex        =   36
         Top             =   195
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   2
         Left            =   2565
         TabIndex        =   37
         Top             =   180
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   65280
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   5
         Left            =   2565
         TabIndex        =   38
         Top             =   825
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   32768
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel SSPanel4 
         Height          =   255
         Left            =   540
         TabIndex        =   60
         Top             =   915
         Width           =   495
         _Version        =   65536
         _ExtentX        =   873
         _ExtentY        =   450
         _StockProps     =   15
         Caption         =   "SPA"
         ForeColor       =   4194304
         BackColor       =   32768
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   9.01
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   3
         Left            =   165
         TabIndex        =   61
         Top             =   825
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   32768
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel SSPanel13 
         Height          =   255
         Left            =   1590
         TabIndex        =   62
         Top             =   900
         Width           =   495
         _Version        =   65536
         _ExtentX        =   873
         _ExtentY        =   450
         _StockProps     =   15
         Caption         =   "SPP"
         ForeColor       =   4194304
         BackColor       =   32768
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   9.01
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   4
         Left            =   1365
         TabIndex        =   63
         Top             =   825
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   32768
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
   End
   Begin Threed.SSFrame ssfOS 
      Height          =   1275
      Left            =   45
      TabIndex        =   42
      Top             =   2100
      Width           =   3915
      _Version        =   65536
      _ExtentX        =   6906
      _ExtentY        =   2249
      _StockProps     =   14
      Caption         =   "OutSole"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±¼¸²"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel SSPanel5 
         Height          =   195
         Left            =   360
         TabIndex        =   67
         Top             =   315
         Width           =   735
         _Version        =   65536
         _ExtentX        =   1296
         _ExtentY        =   344
         _StockProps     =   15
         Caption         =   "OSP"
         ForeColor       =   4194304
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel sspOS 
         Height          =   960
         Index           =   0
         Left            =   180
         TabIndex        =   43
         Top             =   195
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1693
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspOS 
         Height          =   960
         Index           =   1
         Left            =   1380
         TabIndex        =   44
         Top             =   195
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1693
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspOS 
         Height          =   960
         Index           =   2
         Left            =   2580
         TabIndex        =   45
         Top             =   195
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1693
         _StockProps     =   15
         BackColor       =   16711935
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
   End
   Begin Threed.SSFrame ssfUP 
      Height          =   2175
      Left            =   60
      TabIndex        =   17
      Top             =   30
      Width           =   7725
      _Version        =   65536
      _ExtentX        =   13626
      _ExtentY        =   3836
      _StockProps     =   14
      Caption         =   "UPPER"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±¼¸²"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel SSPanel3 
         Height          =   375
         Left            =   4080
         TabIndex        =   70
         Top             =   1155
         Width           =   735
         _Version        =   65536
         _ExtentX        =   1296
         _ExtentY        =   661
         _StockProps     =   15
         Caption         =   "UPS1"
         ForeColor       =   4194304
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel SSPanel2 
         Height          =   375
         Left            =   4080
         TabIndex        =   69
         Top             =   210
         Width           =   735
         _Version        =   65536
         _ExtentX        =   1296
         _ExtentY        =   661
         _StockProps     =   15
         Caption         =   "UPS2"
         ForeColor       =   4194304
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   2
         BevelOuter      =   0
         Font3D          =   1
      End
      Begin Threed.SSPanel sspUP 
         Height          =   945
         Index           =   1
         Left            =   4020
         TabIndex        =   18
         Top             =   165
         Width           =   3585
         _Version        =   65536
         _ExtentX        =   6324
         _ExtentY        =   1667
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspUP 
         Height          =   960
         Index           =   2
         Left            =   4020
         TabIndex        =   19
         Top             =   1110
         Width           =   2385
         _Version        =   65536
         _ExtentX        =   4207
         _ExtentY        =   1693
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspUP 
         Height          =   960
         Index           =   3
         Left            =   6405
         TabIndex        =   20
         Top             =   1110
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1693
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
      Begin Threed.SSPanel sspUP 
         Height          =   945
         Index           =   0
         Left            =   2805
         TabIndex        =   21
         Top             =   165
         Width           =   1200
         _Version        =   65536
         _ExtentX        =   2117
         _ExtentY        =   1667
         _StockProps     =   15
         BackColor       =   65535
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±¼¸²"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
      End
   End
   Begin Threed.SSFrame SSFrame3 
      Height          =   2430
      Left            =   30
      TabIndex        =   68
      Top             =   6375
      Width           =   13950
      _Version        =   65536
      _ExtentX        =   24606
      _ExtentY        =   4286
      _StockProps     =   14
      Caption         =   "Results By Line"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±¼¸²"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
End
Attribute VB_Name = "frmMO01VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub sbCtlDept(ByRef obj As Object, ByRef obj2 As Object)
Dim i As Integer

   If obj(0).BevelOuter = 2 Then
      For i = 0 To obj.UBound Step 1
         obj(i).BevelOuter = 1 'Inner
      Next i
      obj2.Font3D = 2
   Else
      For i = 0 To obj.UBound Step 1
         obj(i).BevelOuter = 2 'Outer
      Next i
      obj2.Font3D = 0
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
    
End Sub

Private Sub sspUP_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspUP, ssfUP)
End Sub

Private Sub sspOS_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspOS, ssfOS)
End Sub

Private Sub sspPU_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspPU, ssfPU)
End Sub

Private Sub sspPH_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspPH, ssfPH)
End Sub

Private Sub sspFSS_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFSS, ssfFSS)
End Sub

Private Sub sspFGA_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGA, ssfFGA)
End Sub

Private Sub sspFGW_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGW, ssfFGW)
End Sub

