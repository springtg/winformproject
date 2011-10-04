VERSION 5.00
Object = "{C0A63B80-4B21-11D3-BD95-D426EF2C7949}#1.0#0"; "Vsflex7L.ocx"
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO01VJ 
   Caption         =   "Manufacturing Execute System"
   ClientHeight    =   8310
   ClientLeft      =   1200
   ClientTop       =   1485
   ClientWidth     =   11940
   Icon            =   "frmMO01VJ.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   8310
   ScaleWidth      =   11940
   Begin VB.Timer tmrMSG 
      Enabled         =   0   'False
      Interval        =   3000
      Left            =   11580
      Top             =   5655
   End
   Begin Threed.SSPanel sspMsg 
      Height          =   1035
      Left            =   2265
      TabIndex        =   92
      Top             =   3030
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
   Begin VB.Timer tmrScan 
      Interval        =   60000
      Left            =   7125
      Top             =   8070
   End
   Begin Threed.SSFrame ssfFGW 
      Height          =   5400
      Left            =   10035
      TabIndex        =   4
      Top             =   0
      Width           =   1845
      _Version        =   65536
      _ExtentX        =   3254
      _ExtentY        =   9525
      _StockProps     =   14
      Caption         =   "FGW"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspFGW 
         Height          =   2445
         Index           =   0
         Left            =   105
         TabIndex        =   5
         Top             =   210
         Width           =   1590
         _Version        =   65536
         _ExtentX        =   2805
         _ExtentY        =   4313
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   22
            Left            =   -45
            TabIndex        =   85
            Top             =   1590
            Width           =   615
         End
         Begin VB.Image imgMoveFGW 
            Height          =   480
            Index           =   0
            Left            =   -45
            Picture         =   "frmMO01VJ.frx":08CA
            Top             =   1710
            Width           =   480
         End
         Begin VB.Label lbFGW 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "A-GRADE"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   0
            Left            =   60
            TabIndex        =   48
            Top             =   75
            Width           =   1005
         End
         Begin VB.Image imgFGW 
            Height          =   2355
            Index           =   0
            Left            =   60
            Picture         =   "frmMO01VJ.frx":1194
            Stretch         =   -1  'True
            Top             =   45
            Width           =   1470
         End
      End
      Begin Threed.SSPanel sspFGW 
         Height          =   840
         Index           =   1
         Left            =   105
         TabIndex        =   6
         Top             =   2655
         Width           =   1590
         _Version        =   65536
         _ExtentX        =   2805
         _ExtentY        =   1482
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbFGW 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "OverRun"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   1
            Left            =   45
            TabIndex        =   49
            Top             =   75
            Width           =   1005
         End
         Begin VB.Image imgFGW 
            Height          =   750
            Index           =   1
            Left            =   45
            Picture         =   "frmMO01VJ.frx":2C66
            Stretch         =   -1  'True
            Top             =   45
            Width           =   1485
         End
      End
      Begin Threed.SSPanel sspFGW 
         Height          =   1035
         Index           =   3
         Left            =   105
         TabIndex        =   7
         Top             =   4215
         Width           =   1590
         _Version        =   65536
         _ExtentX        =   2805
         _ExtentY        =   1826
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   23
            Left            =   -60
            TabIndex        =   86
            Top             =   450
            Width           =   615
         End
         Begin VB.Image imgMoveFGW 
            Height          =   480
            Index           =   1
            Left            =   -45
            Picture         =   "frmMO01VJ.frx":4738
            Top             =   555
            Width           =   480
         End
         Begin VB.Label lbFGW 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "B-GRADE"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   3
            Left            =   45
            TabIndex        =   51
            Top             =   60
            Width           =   1005
         End
         Begin VB.Image imgFGW 
            Height          =   945
            Index           =   3
            Left            =   60
            Picture         =   "frmMO01VJ.frx":5002
            Stretch         =   -1  'True
            Top             =   45
            Width           =   1485
         End
      End
      Begin Threed.SSPanel sspFGW 
         Height          =   720
         Index           =   2
         Left            =   105
         TabIndex        =   8
         Top             =   3495
         Width           =   1590
         _Version        =   65536
         _ExtentX        =   2805
         _ExtentY        =   1270
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbFGW 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "Not Sales Shoes"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   435
            Index           =   2
            Left            =   45
            TabIndex        =   50
            Top             =   60
            Width           =   1335
         End
         Begin VB.Image imgFGW 
            Height          =   630
            Index           =   2
            Left            =   45
            Picture         =   "frmMO01VJ.frx":6AD4
            Stretch         =   -1  'True
            Top             =   45
            Width           =   1470
         End
      End
   End
   Begin Threed.SSFrame ssfFGA 
      Height          =   5400
      Left            =   6675
      TabIndex        =   0
      Top             =   0
      Width           =   3405
      _Version        =   65536
      _ExtentX        =   6006
      _ExtentY        =   9525
      _StockProps     =   14
      Caption         =   "FGA"
      ForeColor       =   0
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspFGA 
         Height          =   1230
         Index           =   0
         Left            =   135
         TabIndex        =   1
         Top             =   210
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   2170
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   3
            Left            =   -45
            TabIndex        =   66
            Top             =   570
            Width           =   555
         End
         Begin VB.Image imgMoveFGA 
            Height          =   480
            Index           =   0
            Left            =   -30
            Picture         =   "frmMO01VJ.frx":85A6
            Top             =   690
            Width           =   480
         End
         Begin VB.Image imgFGA 
            Height          =   1140
            Index           =   0
            Left            =   45
            Picture         =   "frmMO01VJ.frx":8E70
            Stretch         =   -1  'True
            Top             =   45
            Width           =   960
         End
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   1245
         Index           =   1
         Left            =   1185
         TabIndex        =   2
         Top             =   195
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   2196
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   4
            Left            =   -45
            TabIndex        =   67
            Top             =   585
            Width           =   555
         End
         Begin VB.Image imgMoveFGA 
            Height          =   480
            Index           =   1
            Left            =   -45
            Picture         =   "frmMO01VJ.frx":A942
            Top             =   690
            Width           =   480
         End
         Begin VB.Image imgFGA 
            Height          =   1155
            Index           =   1
            Left            =   75
            Picture         =   "frmMO01VJ.frx":B20C
            Stretch         =   -1  'True
            Top             =   45
            Width           =   915
         End
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   5055
         Index           =   4
         Left            =   2235
         TabIndex        =   3
         Top             =   195
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   8916
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   21
            Left            =   -75
            TabIndex        =   84
            Top             =   1605
            Width           =   615
         End
         Begin VB.Image imgMoveFGA 
            Height          =   480
            Index           =   4
            Left            =   0
            Picture         =   "frmMO01VJ.frx":CCDE
            Top             =   1725
            Width           =   480
         End
         Begin VB.Image imgFGA 
            Height          =   4950
            Index           =   4
            Left            =   60
            Picture         =   "frmMO01VJ.frx":D5A8
            Stretch         =   -1  'True
            Top             =   60
            Width           =   930
         End
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   3630
         Index           =   2
         Left            =   135
         TabIndex        =   14
         Top             =   1620
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   6403
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   19
            Left            =   -60
            TabIndex        =   82
            Top             =   1560
            Width           =   615
         End
         Begin VB.Image imgMoveFGA 
            Height          =   480
            Index           =   2
            Left            =   -45
            Picture         =   "frmMO01VJ.frx":F07A
            Top             =   1710
            Width           =   480
         End
         Begin VB.Image imgFGA 
            Height          =   3540
            Index           =   2
            Left            =   30
            Picture         =   "frmMO01VJ.frx":F944
            Stretch         =   -1  'True
            Top             =   45
            Width           =   975
         End
      End
      Begin Threed.SSPanel sspFGA 
         Height          =   3630
         Index           =   3
         Left            =   1185
         TabIndex        =   15
         Top             =   1620
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   6403
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   20
            Left            =   -105
            TabIndex        =   83
            Top             =   1560
            Width           =   615
         End
         Begin VB.Image imgMoveFGA 
            Height          =   480
            Index           =   3
            Left            =   -45
            Picture         =   "frmMO01VJ.frx":11416
            Top             =   1710
            Width           =   480
         End
         Begin VB.Image imgFGA 
            Height          =   3540
            Index           =   3
            Left            =   45
            Picture         =   "frmMO01VJ.frx":11CE0
            Stretch         =   -1  'True
            Top             =   45
            Width           =   960
         End
      End
   End
   Begin Threed.SSFrame ssfFSS 
      Height          =   3960
      Left            =   3345
      TabIndex        =   9
      Top             =   1440
      Width           =   3360
      _Version        =   65536
      _ExtentX        =   5927
      _ExtentY        =   6985
      _StockProps     =   14
      Caption         =   "FSS"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspFSS 
         Height          =   630
         Index           =   0
         Left            =   120
         TabIndex        =   10
         Top             =   195
         Width           =   2100
         _Version        =   65536
         _ExtentX        =   3704
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   7
            Left            =   -60
            TabIndex        =   70
            Top             =   90
            Width           =   615
         End
         Begin VB.Image imgMoveFSS 
            Height          =   480
            Index           =   0
            Left            =   -45
            Picture         =   "frmMO01VJ.frx":137B2
            Top             =   180
            Width           =   480
         End
         Begin VB.Image imgFSS 
            Height          =   540
            Index           =   0
            Left            =   45
            Picture         =   "frmMO01VJ.frx":1407C
            Stretch         =   -1  'True
            Top             =   45
            Width           =   2010
         End
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   3630
         Index           =   4
         Left            =   2220
         TabIndex        =   11
         Top             =   195
         Width           =   1035
         _Version        =   65536
         _ExtentX        =   1826
         _ExtentY        =   6403
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   18
            Left            =   -75
            TabIndex        =   81
            Top             =   1545
            Width           =   615
         End
         Begin VB.Image imgMoveFSS 
            Height          =   480
            Index           =   4
            Left            =   -30
            Picture         =   "frmMO01VJ.frx":15B4E
            Top             =   1665
            Width           =   480
         End
         Begin VB.Image imgFSS 
            Height          =   3540
            Index           =   4
            Left            =   60
            Picture         =   "frmMO01VJ.frx":16418
            Stretch         =   -1  'True
            Top             =   45
            Width           =   930
         End
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   630
         Index           =   1
         Left            =   120
         TabIndex        =   12
         Top             =   1050
         Width           =   2100
         _Version        =   65536
         _ExtentX        =   3704
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   10
            Left            =   -60
            TabIndex        =   73
            Top             =   60
            Width           =   615
         End
         Begin VB.Image imgMoveFSS 
            Height          =   480
            Index           =   1
            Left            =   -30
            Picture         =   "frmMO01VJ.frx":17EEA
            Top             =   165
            Width           =   480
         End
         Begin VB.Image imgFSS 
            Height          =   540
            Index           =   1
            Left            =   45
            Picture         =   "frmMO01VJ.frx":187B4
            Stretch         =   -1  'True
            Top             =   45
            Width           =   2010
         End
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   630
         Index           =   2
         Left            =   120
         TabIndex        =   13
         Top             =   1680
         Width           =   2100
         _Version        =   65536
         _ExtentX        =   3704
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   13
            Left            =   -75
            TabIndex        =   76
            Top             =   75
            Width           =   615
         End
         Begin VB.Image imgMoveFSS 
            Height          =   480
            Index           =   2
            Left            =   -45
            Picture         =   "frmMO01VJ.frx":1A286
            Top             =   195
            Width           =   480
         End
         Begin VB.Image imgFSS 
            Height          =   540
            Index           =   2
            Left            =   45
            Picture         =   "frmMO01VJ.frx":1AB50
            Stretch         =   -1  'True
            Top             =   45
            Width           =   2010
         End
      End
      Begin Threed.SSPanel sspFSS 
         Height          =   1275
         Index           =   3
         Left            =   120
         TabIndex        =   16
         Top             =   2550
         Width           =   2100
         _Version        =   65536
         _ExtentX        =   3704
         _ExtentY        =   2249
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   17
            Left            =   -60
            TabIndex        =   80
            Top             =   255
            Width           =   615
         End
         Begin VB.Image imgMoveFSS 
            Height          =   480
            Index           =   3
            Left            =   -45
            Picture         =   "frmMO01VJ.frx":1C622
            Top             =   375
            Visible         =   0   'False
            Width           =   480
         End
         Begin VB.Image imgFSS 
            Height          =   1185
            Index           =   3
            Left            =   45
            Picture         =   "frmMO01VJ.frx":1CEEC
            Stretch         =   -1  'True
            Top             =   45
            Width           =   2010
         End
      End
   End
   Begin Threed.SSFrame ssfPH 
      Height          =   1620
      Left            =   0
      TabIndex        =   27
      Top             =   3780
      Width           =   3390
      _Version        =   65536
      _ExtentX        =   5980
      _ExtentY        =   2857
      _StockProps     =   14
      Caption         =   "Phylon"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspPH 
         Height          =   630
         Index           =   0
         Left            =   105
         TabIndex        =   28
         Top             =   210
         Width           =   3150
         _Version        =   65536
         _ExtentX        =   5556
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Image imgMovePH 
            Height          =   480
            Index           =   3
            Left            =   2670
            Picture         =   "frmMO01VJ.frx":1E9BE
            Top             =   165
            Width           =   480
         End
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   14
            Left            =   2475
            TabIndex        =   77
            Top             =   45
            Width           =   615
         End
         Begin VB.Image imgMovePH 
            Height          =   480
            Index           =   0
            Left            =   3180
            Picture         =   "frmMO01VJ.frx":1F288
            Top             =   150
            Width           =   480
         End
         Begin VB.Label lbPH 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "PHP"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   0
            Left            =   45
            TabIndex        =   46
            Top             =   60
            Width           =   465
         End
         Begin VB.Image imgPH 
            Height          =   540
            Index           =   0
            Left            =   45
            Picture         =   "frmMO01VJ.frx":1FB52
            Stretch         =   -1  'True
            Top             =   45
            Width           =   3060
         End
      End
      Begin Threed.SSPanel sspPH 
         Height          =   630
         Index           =   1
         Left            =   105
         TabIndex        =   29
         Top             =   855
         Width           =   3150
         _Version        =   65536
         _ExtentX        =   5556
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   16
            Left            =   2475
            TabIndex        =   79
            Top             =   45
            Width           =   615
         End
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   15
            Left            =   240
            TabIndex        =   78
            Top             =   195
            Width           =   615
         End
         Begin VB.Image imgMovePH 
            Height          =   480
            Index           =   2
            Left            =   2670
            Picture         =   "frmMO01VJ.frx":21624
            Top             =   165
            Width           =   480
         End
         Begin VB.Image imgMovePH 
            Height          =   480
            Index           =   1
            Left            =   0
            Picture         =   "frmMO01VJ.frx":21EEE
            Top             =   165
            Width           =   480
         End
         Begin VB.Label lbPH 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "PHI"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   1
            Left            =   45
            TabIndex        =   47
            Top             =   45
            Width           =   465
         End
         Begin VB.Image imgPH 
            Height          =   540
            Index           =   1
            Left            =   45
            Picture         =   "frmMO01VJ.frx":227B8
            Stretch         =   -1  'True
            Top             =   30
            Width           =   3060
         End
      End
   End
   Begin Threed.SSFrame ssfPU 
      Height          =   1560
      Left            =   0
      TabIndex        =   22
      Top             =   2310
      Width           =   3390
      _Version        =   65536
      _ExtentX        =   5980
      _ExtentY        =   2752
      _StockProps     =   14
      Caption         =   "PU"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   0
         Left            =   105
         TabIndex        =   23
         Top             =   195
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   8
            Left            =   360
            TabIndex        =   71
            Top             =   60
            Width           =   615
         End
         Begin VB.Image imgMovePU 
            Height          =   480
            Index           =   0
            Left            =   585
            Picture         =   "frmMO01VJ.frx":2428A
            Top             =   165
            Width           =   480
         End
         Begin VB.Label lbPU 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "PUA"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   0
            Left            =   75
            TabIndex        =   41
            Top             =   75
            Width           =   465
         End
         Begin VB.Image imgPU 
            Height          =   540
            Index           =   0
            Left            =   60
            Picture         =   "frmMO01VJ.frx":24B54
            Stretch         =   -1  'True
            Top             =   45
            Width           =   945
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   1
         Left            =   1155
         TabIndex        =   24
         Top             =   195
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   9
            Left            =   120
            TabIndex        =   72
            Top             =   225
            Width           =   510
         End
         Begin VB.Image imgMovePU 
            Height          =   480
            Index           =   1
            Left            =   630
            Picture         =   "frmMO01VJ.frx":26626
            Top             =   165
            Width           =   480
         End
         Begin VB.Label lbPU 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "PUS"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   2
            Left            =   615
            TabIndex        =   43
            Top             =   60
            Width           =   465
         End
         Begin VB.Label lbPU 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "PUP"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   1
            Left            =   45
            TabIndex        =   42
            Top             =   60
            Width           =   465
         End
         Begin VB.Image imgPU 
            Height          =   540
            Index           =   1
            Left            =   45
            Picture         =   "frmMO01VJ.frx":26EF0
            Stretch         =   -1  'True
            Top             =   45
            Width           =   960
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   2
         Left            =   2205
         TabIndex        =   25
         Top             =   195
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Image imgPU 
            Height          =   540
            Index           =   2
            Left            =   45
            Picture         =   "frmMO01VJ.frx":289C2
            Stretch         =   -1  'True
            Top             =   45
            Width           =   960
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   5
         Left            =   2205
         TabIndex        =   26
         Top             =   825
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Image imgPU 
            Height          =   540
            Index           =   5
            Left            =   45
            Picture         =   "frmMO01VJ.frx":2A494
            Stretch         =   -1  'True
            Top             =   45
            Width           =   945
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   3
         Left            =   105
         TabIndex        =   34
         Top             =   825
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   11
            Left            =   375
            TabIndex        =   74
            Top             =   60
            Width           =   615
         End
         Begin VB.Image imgMovePU 
            Height          =   480
            Index           =   2
            Left            =   615
            Picture         =   "frmMO01VJ.frx":2BF66
            Top             =   180
            Width           =   480
         End
         Begin VB.Label lbPU 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "SPA"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   3
            Left            =   45
            TabIndex        =   44
            Top             =   60
            Width           =   465
         End
         Begin VB.Image imgPU 
            Height          =   540
            Index           =   3
            Left            =   45
            Picture         =   "frmMO01VJ.frx":2C830
            Stretch         =   -1  'True
            Top             =   45
            Width           =   960
         End
      End
      Begin Threed.SSPanel sspPU 
         Height          =   630
         Index           =   4
         Left            =   1155
         TabIndex        =   35
         Top             =   825
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   12
            Left            =   375
            TabIndex        =   75
            Top             =   60
            Width           =   615
         End
         Begin VB.Image imgMovePU 
            Height          =   480
            Index           =   3
            Left            =   630
            Picture         =   "frmMO01VJ.frx":2E302
            Top             =   180
            Width           =   480
         End
         Begin VB.Label lbPU 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "SPP"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   180
            Index           =   4
            Left            =   30
            TabIndex        =   45
            Top             =   45
            Width           =   465
         End
         Begin VB.Image imgPU 
            Height          =   540
            Index           =   4
            Left            =   45
            Picture         =   "frmMO01VJ.frx":2EBCC
            Stretch         =   -1  'True
            Top             =   45
            Width           =   960
         End
      End
   End
   Begin Threed.SSFrame ssfOS 
      Height          =   975
      Left            =   0
      TabIndex        =   30
      Top             =   1440
      Width           =   3390
      _Version        =   65536
      _ExtentX        =   5980
      _ExtentY        =   1720
      _StockProps     =   14
      Caption         =   "OutSole"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspOS 
         Height          =   630
         Index           =   0
         Left            =   105
         TabIndex        =   31
         Top             =   210
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   5
            Left            =   465
            TabIndex        =   68
            Top             =   60
            Width           =   510
         End
         Begin VB.Image imgMoveOS 
            Height          =   480
            Index           =   0
            Left            =   615
            Picture         =   "frmMO01VJ.frx":3069E
            Top             =   180
            Width           =   480
         End
         Begin VB.Image imgOS 
            Height          =   540
            Index           =   0
            Left            =   60
            Picture         =   "frmMO01VJ.frx":30F68
            Stretch         =   -1  'True
            Top             =   45
            Width           =   945
         End
      End
      Begin Threed.SSPanel sspOS 
         Height          =   630
         Index           =   1
         Left            =   1155
         TabIndex        =   32
         Top             =   210
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   6
            Left            =   375
            TabIndex        =   69
            Top             =   60
            Width           =   615
         End
         Begin VB.Image imgMoveOS 
            Height          =   480
            Index           =   1
            Left            =   615
            Picture         =   "frmMO01VJ.frx":32A3A
            Top             =   180
            Width           =   480
         End
         Begin VB.Label lbOS 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "OSP"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   0
            Left            =   75
            TabIndex        =   40
            Top             =   90
            Width           =   465
         End
         Begin VB.Image imgOS 
            Height          =   540
            Index           =   1
            Left            =   60
            Picture         =   "frmMO01VJ.frx":33304
            Stretch         =   -1  'True
            Top             =   45
            Width           =   945
         End
      End
      Begin Threed.SSPanel sspOS 
         Height          =   630
         Index           =   2
         Left            =   2205
         TabIndex        =   33
         Top             =   210
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1111
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Image imgOS 
            Height          =   540
            Index           =   2
            Left            =   45
            Picture         =   "frmMO01VJ.frx":34DD6
            Stretch         =   -1  'True
            Top             =   45
            Width           =   960
         End
      End
   End
   Begin Threed.SSFrame ssfUP 
      Height          =   1575
      Left            =   2265
      TabIndex        =   17
      Top             =   0
      Width           =   4440
      _Version        =   65536
      _ExtentX        =   7832
      _ExtentY        =   2778
      _StockProps     =   14
      Caption         =   "UPPER"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   9.75
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSPanel sspUP 
         Height          =   615
         Index           =   1
         Left            =   1155
         TabIndex        =   18
         Top             =   210
         Width           =   3150
         _Version        =   65536
         _ExtentX        =   5556
         _ExtentY        =   1085
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   2
            Left            =   2445
            TabIndex        =   87
            Top             =   75
            Width           =   615
         End
         Begin VB.Image imgMoveUP 
            Height          =   480
            Index           =   2
            Left            =   2715
            Picture         =   "frmMO01VJ.frx":368A8
            Top             =   195
            Width           =   480
         End
         Begin VB.Label lbUP 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "UPS2"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   1
            Left            =   75
            TabIndex        =   38
            Top             =   75
            Width           =   585
         End
         Begin VB.Image imgUP 
            Height          =   525
            Index           =   1
            Left            =   45
            Picture         =   "frmMO01VJ.frx":37172
            Stretch         =   -1  'True
            Top             =   45
            Width           =   3045
         End
      End
      Begin Threed.SSPanel sspUP 
         Height          =   615
         Index           =   2
         Left            =   1155
         TabIndex        =   19
         Top             =   825
         Width           =   2100
         _Version        =   65536
         _ExtentX        =   3704
         _ExtentY        =   1085
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   1
            Left            =   1410
            TabIndex        =   65
            Top             =   60
            Width           =   615
         End
         Begin VB.Image imgMoveUP 
            Height          =   480
            Index           =   1
            Left            =   1680
            Picture         =   "frmMO01VJ.frx":38C44
            Top             =   195
            Width           =   480
         End
         Begin VB.Label lbUP 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "UPS1"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   2
            Left            =   75
            TabIndex        =   39
            Top             =   75
            Width           =   570
         End
         Begin VB.Image imgUP 
            Height          =   525
            Index           =   2
            Left            =   60
            Picture         =   "frmMO01VJ.frx":3950E
            Stretch         =   -1  'True
            Top             =   45
            Width           =   1980
         End
      End
      Begin Threed.SSPanel sspUP 
         Height          =   615
         Index           =   3
         Left            =   3255
         TabIndex        =   20
         Top             =   825
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1085
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Image imgUP 
            Height          =   525
            Index           =   3
            Left            =   45
            Picture         =   "frmMO01VJ.frx":3AFE0
            Stretch         =   -1  'True
            Top             =   45
            Width           =   945
         End
      End
      Begin Threed.SSPanel sspUP 
         Height          =   615
         Index           =   0
         Left            =   105
         TabIndex        =   21
         Top             =   210
         Width           =   1050
         _Version        =   65536
         _ExtentX        =   1852
         _ExtentY        =   1085
         _StockProps     =   15
         BackColor       =   12632256
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
            Size            =   9
            Charset         =   129
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BevelWidth      =   3
         BorderWidth     =   2
         Begin VB.Label lbrst 
            Alignment       =   1  'ø¿∏•¬  ∏¬√„
            Appearance      =   0  '∆Ú∏È
            BackColor       =   &H80000005&
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "0"
            ForeColor       =   &H80000008&
            Height          =   180
            Index           =   0
            Left            =   375
            TabIndex        =   64
            Top             =   90
            Width           =   615
         End
         Begin VB.Image imgMoveUP 
            Height          =   480
            Index           =   0
            Left            =   585
            Picture         =   "frmMO01VJ.frx":3CAB2
            Top             =   195
            Width           =   480
         End
         Begin VB.Label lbUP 
            BackStyle       =   0  '≈ı∏Ì
            Caption         =   "UPC2"
            BeginProperty Font 
               Name            =   "±º∏≤"
               Size            =   9
               Charset         =   129
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Index           =   0
            Left            =   75
            TabIndex        =   37
            Top             =   75
            Width           =   585
         End
         Begin VB.Image imgUP 
            Height          =   525
            Index           =   0
            Left            =   45
            Picture         =   "frmMO01VJ.frx":3D37C
            Stretch         =   -1  'True
            Top             =   45
            Width           =   960
         End
      End
   End
   Begin Threed.SSFrame SSFrame3 
      Height          =   3000
      Left            =   0
      TabIndex        =   36
      Top             =   5295
      Width           =   8085
      _Version        =   65536
      _ExtentX        =   14261
      _ExtentY        =   5292
      _StockProps     =   14
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin VSFlex7LCtl.VSFlexGrid fspLine 
         Height          =   2745
         Left            =   105
         TabIndex        =   52
         Top             =   165
         Width           =   7875
         _cx             =   13891
         _cy             =   4842
         _ConvInfo       =   1
         Appearance      =   1
         BorderStyle     =   1
         Enabled         =   -1  'True
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "±º∏≤"
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
         Cols            =   8
         FixedRows       =   1
         FixedCols       =   1
         RowHeightMin    =   240
         RowHeightMax    =   240
         ColWidthMin     =   0
         ColWidthMax     =   0
         ExtendLastCol   =   0   'False
         FormatString    =   $"frmMO01VJ.frx":3EE4E
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
      Height          =   3015
      Left            =   8055
      TabIndex        =   53
      Top             =   5280
      Width           =   3825
      _Version        =   65536
      _ExtentX        =   6747
      _ExtentY        =   5318
      _StockProps     =   14
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   9
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin Threed.SSCommand cmdSetBal 
         Height          =   555
         Left            =   180
         TabIndex        =   54
         Top             =   1290
         Width           =   1740
         _Version        =   65536
         _ExtentX        =   3069
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "Set Balance"
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand cmdSeqBal 
         Height          =   555
         Left            =   180
         TabIndex        =   55
         Top             =   1830
         Width           =   1740
         _Version        =   65536
         _ExtentX        =   3069
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "Sequence Balance"
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand smdPassMark 
         Height          =   555
         Left            =   180
         TabIndex        =   56
         Top             =   750
         Width           =   1725
         _Version        =   65536
         _ExtentX        =   3043
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "Passcard Marking"
      End
      Begin Threed.SSCommand cmdHistory 
         Height          =   555
         Left            =   180
         TabIndex        =   57
         Top             =   2370
         Width           =   1740
         _Version        =   65536
         _ExtentX        =   3069
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "Execute History"
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand cmdExit 
         Height          =   555
         Left            =   1905
         TabIndex        =   58
         Top             =   2370
         Width           =   1725
         _Version        =   65536
         _ExtentX        =   3043
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "Exit"
      End
      Begin Threed.SSCommand cmdEtcInOut 
         Height          =   555
         Left            =   1890
         TabIndex        =   59
         Top             =   750
         Width           =   1740
         _Version        =   65536
         _ExtentX        =   3069
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "ETC. In/Out"
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand cmdExam 
         Height          =   555
         Left            =   1890
         TabIndex        =   60
         Top             =   1290
         Width           =   1740
         _Version        =   65536
         _ExtentX        =   3069
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "Stock Examination"
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand cmdStockClose 
         Height          =   555
         Left            =   1890
         TabIndex        =   61
         Top             =   1830
         Width           =   1740
         _Version        =   65536
         _ExtentX        =   3069
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "Closeing Stock"
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand cmdStockRpt 
         Height          =   555
         Left            =   1890
         TabIndex        =   62
         Top             =   210
         Width           =   1740
         _Version        =   65536
         _ExtentX        =   3069
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "Inventory"
         Enabled         =   0   'False
      End
      Begin Threed.SSCommand SSCommand1 
         Height          =   555
         Left            =   180
         TabIndex        =   91
         Top             =   210
         Width           =   1725
         _Version        =   65536
         _ExtentX        =   3043
         _ExtentY        =   979
         _StockProps     =   78
         Caption         =   "Results"
      End
   End
   Begin Threed.SSFrame SSFrame4 
      Height          =   1530
      Left            =   0
      TabIndex        =   63
      Top             =   75
      Width           =   2295
      _Version        =   65536
      _ExtentX        =   4048
      _ExtentY        =   2699
      _StockProps     =   14
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "±º∏≤"
         Size            =   1.5
         Charset         =   129
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin VB.CommandButton cmdScan 
         Caption         =   "ALL-Line"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   11.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   435
         Left            =   195
         TabIndex        =   90
         Top             =   600
         Width           =   1920
      End
      Begin VB.CheckBox chkAutoScan 
         BackColor       =   &H80000000&
         Caption         =   "Auto Scan Data"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   210
         TabIndex        =   88
         Top             =   1065
         Width           =   2295
      End
      Begin MSComCtl2.DTPicker dtpYMD 
         Height          =   390
         Left            =   195
         TabIndex        =   89
         Top             =   165
         Width           =   1920
         _ExtentX        =   3387
         _ExtentY        =   688
         _Version        =   393216
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Microsoft Sans Serif"
            Size            =   11.25
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
   End
   Begin VB.Line Line1 
      X1              =   -900
      X2              =   1425
      Y1              =   8070
      Y2              =   8070
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

Private vKIND As Variant
Private vHeadCol As Variant

Private mm_Count As Integer

Private Sub sbSetKind()
   Dim i As Integer
   Dim j As Integer
   Dim k As Integer
   
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
                  
                  vHeadCol(k) = gArrRstGroup(0, i) & "1 " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
                  vKIND(k) = gArrRstGroup(0, i) & "1." & Mid(gArrRstDiv(j), 1, 1) & ".UP"
                  k = k + 1
                  
                  ReDim Preserve vKIND(k)
                  ReDim Preserve vHeadCol(k)
                  vHeadCol(k) = gArrRstGroup(0, i) & "2 " & Mid(gArrRstDiv(j), 3, Len(gArrRstDiv(j)) - 2)
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
   If chkAutoScan.Value = 1 Then
      mm_Count = 0
      tmrScan.Enabled = True
   Else
      mm_Count = 0
      tmrScan.Enabled = False
   End If
End Sub

Private Sub cmdScan_Click()
   cmdScan.Caption = "ALL-Line"
   gLine = "ALL"
   Call sbDspData(Format(dtpYMD.Value, "YYYYMMDD"), "ALL")
End Sub

Private Sub dtpYMD_Change()
   cmdScan.Caption = "ALL-Line"
   gLine = "ALL"
   Call sbDspData(Format(dtpYMD.Value, "YYYYMMDD"), "ALL")
End Sub

Private Sub Form_Load()
   Dim strYMD As String
   
   'sspMsg.Visible = True
   sspMsg.Left = Me.Width / 2 - sspMsg.Width / 2
   sspMsg.Top = Me.Height / 2 - sspMsg.Height / 2
   
   Me.Left = 0
   Me.Top = 0
   
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
   strYMD = Format(Now, "YYYYMMDD")
   dtpYMD.Value = Now
   
   Call sbDspData(strYMD, "ALL")
   
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGA, ssfFGA)
   
   mm_Count = 0
      
End Sub

Private Sub Form_Unload(Cancel As Integer)

   tmrScan.Enabled = False
   Call sbDisconnOra
   
End Sub

Public Sub sbDspData(ByVal arg_ymd As String, ByVal arg_line As String)
   Dim varTOT As Variant
   Dim varGWH As Variant
   Dim SQL As String
   Dim i As Long
   Dim j As Long
   Dim k As Long
   Dim oldval As String
   
   'Set varPLN = Nothing
   'Set varRST = Nothing
   
   'strYMD = Format(Now, "YYYYMMDD")
   'strYMD = "20031210"
   
   'Initializing results label
   cmdScan.Caption = arg_line & "-Line"
   For i = 0 To lbrst.UBound Step 1
      lbrst(i).Caption = "0"
   Next i
   
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
   SQL = SQL & "  WHERE YMD = '" & arg_ymd & "' "
   SQL = SQL & "  GROUP BY OP_CD, LINE "
   SQL = SQL & "  ORDER BY 1, 2 "
   
   varPLN = fnGetOraData(SQL)
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
   SQL = SQL & " SELECT DECODE(SEMI_GOOD_CD||RST_DIV,'UPP',AREA_CD, OP_CD), RST_DIV, SEMI_GOOD_CD, LINE, QTY "
   SQL = SQL & "   FROM V_MM_LINE_TOT "
   SQL = SQL & "  WHERE YMD = '" & arg_ymd & "' "
   SQL = SQL & "  ORDER BY 1, 2, 3 "
   
   varRST = fnGetOraData(SQL)
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
   
   i = 0
   ReDim varTOT(i) As Long
   ReDim varPOS(i) As Long
   ReDim varOP(i) As String
   
   oldval = ""
   For j = 0 To UBound(varRST, 2) Step 1
      If oldval <> varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j) Then
      'If CStr(varRST(3, j)) = "1" Then
         ReDim Preserve varOP(i)
         ReDim Preserve varPOS(i)
         ReDim Preserve varTOT(i)
         
         oldval = varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j)
         varOP(i) = oldval
         varPOS(i) = j
         varTOT(i) = 0
         i = i + 1
      End If
      If arg_line = "ALL" Then
         varTOT(i - 1) = varTOT(i - 1) + CLng(varRST(4, j))
      Else
         If arg_line = CStr(varRST(3, j)) Then
            varTOT(i - 1) = varTOT(i - 1) + CLng(varRST(4, j))
         End If
      End If
   Next j
   
   For j = 0 To i - 1 Step 1
      Select Case varOP(j)
      Case "UPC2.O.UP"
         lbrst(0).Caption = varTOT(j)
      Case "UPS1.P.UP"
         lbrst(1).Caption = varTOT(j)
      Case "UPS2.P.UP"
         lbrst(2).Caption = varTOT(j)
         
      Case "FGA.I.UP"
         lbrst(3).Caption = varTOT(j)
      Case "FGA.T.UP"
         lbrst(4).Caption = varTOT(j)
      
      Case "OSP.T.OS"
         lbrst(5).Caption = varTOT(j)
      Case "OSP.P.OS"
         lbrst(6).Caption = varTOT(j)
      Case "FSS.I.OS"
         lbrst(7).Caption = varTOT(j)
         
      Case "PUA.P.PU"
         lbrst(8).Caption = varTOT(j)
      Case "PUS.P.PU"
         lbrst(9).Caption = varTOT(j)
      Case "FSS.I.PU"
         lbrst(10).Caption = varTOT(j)
                  
      Case "SPA.P.SP"
         lbrst(11).Caption = varTOT(j)
      Case "SPP.P.SP"
         lbrst(12).Caption = varTOT(j)
      Case "FSS.I.SP"
         lbrst(13).Caption = varTOT(j)
         
      Case "PHP.O.PH"
         lbrst(14).Caption = varTOT(j)
      Case "PHI.I.PH"
         lbrst(15).Caption = varTOT(j)
      Case "PHI.O.PH"
         lbrst(16).Caption = varTOT(j)
      Case "FSS.I.PH"
         lbrst(17).Caption = varTOT(j)
         
      Case "FSS.P.FS"
         lbrst(18).Caption = varTOT(j)
      
      Case "FGA.I.FS"
         lbrst(19).Caption = varTOT(j)
      Case "FGA.T.FS"
         lbrst(20).Caption = varTOT(j)
      Case "FGA.P.FG"
         lbrst(21).Caption = varTOT(j)
      Case Else
      
      End Select
   Next j
   
   Call sbLineRst(gDept)
   
   'F/N Goods W/H Incoming
   SQL = ""
   SQL = SQL & " SELECT GRADE, SUM(PRS_QTY) "
   SQL = SQL & "   FROM MG_HEAD "
   SQL = SQL & "  WHERE YMD = '" & arg_ymd & "' "
   SQL = SQL & "    AND INOUT_DIV = 'I' "
   SQL = SQL & "    AND LOC_DIV = 'IR' "
   SQL = SQL & "  GROUP BY GRADE "
   SQL = SQL & "  ORDER BY 1"
   
   varGWH = fnGetOraData(SQL)
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
End Sub

Private Sub sbDspData2(ByVal arg_line As String)
   Dim varTOT As Variant
   Dim i As Long
   Dim j As Long
   Dim k As Long
   Dim oldval As String
   
   
   cmdScan.Caption = arg_line & "-Line"
   'Initializing results label
   For i = 0 To lbrst.UBound - 2 Step 1
      lbrst(i).Caption = "0"
   Next i
   
   i = 0
   ReDim varTOT(i) As Long
      
   oldval = ""
   For j = 0 To UBound(varRST, 2) Step 1
      If oldval <> varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j) Then
         ReDim Preserve varTOT(i)
         oldval = varRST(0, j) & "." & varRST(1, j) & "." & varRST(2, j)
         varTOT(i) = 0
         i = i + 1
      End If
      
      If arg_line = "ALL" Then
         varTOT(i - 1) = varTOT(i - 1) + CLng(varRST(4, j))
      Else
         If arg_line = CStr(varRST(3, j)) Then
            varTOT(i - 1) = varTOT(i - 1) + CLng(varRST(4, j))
         End If
      End If
   Next j
   
   For j = 0 To i - 1 Step 1
      Select Case varOP(j)
      Case "UPC2.P.UP"
         lbrst(0).Caption = varTOT(j)
      Case "UPS1.P.UP"
         lbrst(1).Caption = varTOT(j)
      Case "UPS2.P.UP"
         lbrst(2).Caption = varTOT(j)
         
      Case "FGA.I.UP"
         lbrst(3).Caption = varTOT(j)
      Case "FGA.T.UP"
         lbrst(4).Caption = varTOT(j)
      
      Case "OSP.T.OS"
         lbrst(5).Caption = varTOT(j)
      Case "OSP.P.OS"
         lbrst(6).Caption = varTOT(j)
      Case "FSS.I.OS"
         lbrst(7).Caption = varTOT(j)
         
      Case "PUA.P.PU"
         lbrst(8).Caption = varTOT(j)
      Case "PUS.P.PU"
         lbrst(9).Caption = varTOT(j)
      Case "FSS.I.PU"
         lbrst(10).Caption = varTOT(j)
         
         
      Case "SPA.P.SP"
         lbrst(11).Caption = varTOT(j)
      Case "SPP.P.SP"
         lbrst(12).Caption = varTOT(j)
      Case "FSS.I.SP"
         lbrst(13).Caption = varTOT(j)
         
      Case "PHP.O.PH"
         lbrst(14).Caption = varTOT(j)
      Case "PHI.I.PH"
         lbrst(15).Caption = varTOT(j)
      Case "PHI.O.PH"
         lbrst(16).Caption = varTOT(j)
      Case "FSS.I.PH"
         lbrst(17).Caption = varTOT(j)
         
      Case "FSS.P.FS"
         lbrst(18).Caption = varTOT(j)
      
      Case "FGA.I.FS"
         lbrst(19).Caption = varTOT(j)
      Case "FGA.T.FS"
         lbrst(20).Caption = varTOT(j)
      Case "FGA.P.FG"
         lbrst(21).Caption = varTOT(j)
      Case Else
      
      End Select
   Next j
   
End Sub


Private Sub sbLine_SUB(arg_OPCD As String, arg_RstDiv As String, arg_comp As String, arg_HeadName As String, arg_Col As Long)
   Dim i As Long
   Dim j As Long
   Dim strV1 As String
   Dim strV2 As String
   
   strV1 = arg_OPCD & "." & arg_RstDiv & "." & arg_comp
   
   fspLine.TextMatrix(0, arg_Col) = arg_HeadName
   i = fnFindArrData(varOP, arg_OPCD & "." & arg_RstDiv & "." & arg_comp)
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
Private Sub sbRate(arg_RstPos1 As Integer, arg_RstPos2 As Integer)
   Dim i As Integer
   Dim j As Integer
   Dim totval As Long
   Dim prodsum As Long
   Dim strVal As String
   
   If arg_RstPos1 = -1 Then
      Exit Sub
   End If
   
   For i = 1 To fspLine.Cols - 2 Step 1
      totval = 0
      For j = 1 To fspLine.Rows - 2 Step 1
         totval = totval + CLng(IIf(fspLine.TextMatrix(j, i) = "", "0", fspLine.TextMatrix(j, i)))
      Next j
      fspLine.TextMatrix(fspLine.Rows - 1, i) = CStr(totval)
   Next i
   
   fspLine.TextMatrix(0, fspLine.Cols - 1) = "Rate(%)"
   For i = 1 To fspLine.Rows - 1 Step 1
      prodsum = CLng(IIf(fspLine.TextMatrix(i, arg_RstPos1) = "", "0", fspLine.TextMatrix(i, arg_RstPos1)))
      If arg_RstPos2 <> -1 Then
         prodsum = prodsum + CLng(IIf(fspLine.TextMatrix(i, arg_RstPos2) = "", "0", fspLine.TextMatrix(i, arg_RstPos2)))
      End If
      If fspLine.TextMatrix(i, 1) = "" Or fspLine.TextMatrix(i, 1) = "0" Then
         fspLine.TextMatrix(i, fspLine.Cols - 1) = ""
      Else
         strVal = fnNVL(fspLine.TextMatrix(i, 1))
         If strVal = "0" Then
            fspLine.TextMatrix(i, fspLine.Cols - 1) = ""
         Else
            fspLine.TextMatrix(i, fspLine.Cols - 1) = CStr(Round(prodsum / CLng(strVal) * 100))
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
   Dim varVal As Variant
   
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
      varVal = Split(vKIND(i), ".", 3)
      Call sbLine_SUB(CStr(varVal(0)), CStr(varVal(1)), CStr(varVal(2)), CStr(vHeadCol(i)), 2 + i)
   Next i
   
   k = -1
   q = -1
   'Setting Results Data
   Select Case arg_dept
   Case "UP"
      k = 4
      q = 5
   Case "OS"
      k = 3
      
   Case "PU"
      k = 3
      q = 5
   Case "PH"
      k = 3
      q = 5
   Case "FS"
      k = 6
   Case "FG"
      k = 6
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
    
End Sub

Private Sub cmdExit_Click()
   Unload Me
End Sub


Private Sub fspLine_DblClick()
   
   gLine = fspLine.TextMatrix(fspLine.Row, 0)
   If Not IsNumeric(gLine) Then
      gLine = "ALL"
   End If
   cmdScan.Caption = gLine & "-Line"
   Call sbDspData2(gLine)
   
End Sub

Private Sub imgUP_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspUP, ssfUP)
   Call sbLineRst("UP")
End Sub

Private Sub imgOS_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspOS, ssfOS)
   Call sbLineRst("OS")
End Sub

Private Sub imgPU_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspPU, ssfPU)
   Call sbLineRst("PU")
End Sub

Private Sub imgPH_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspPH, ssfPH)
   Call sbLineRst("PH")
End Sub

Private Sub imgFSS_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFSS, ssfFSS)
   Call sbLineRst("FS")
End Sub

Private Sub imgFGA_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGA, ssfFGA)
   Call sbLineRst("FG")
End Sub

Private Sub imgFGW_Click(Index As Integer)
   Call sbCtlDeptAllOut
   Call sbCtlDept(sspFGW, ssfFGW)
   Call sbLineRst("WH")
   
End Sub

Private Sub lbrst_Click(Index As Integer)
   Select Case Index
   Case 0, 1, 2
      Call imgUP_Click(0)
   Case 5, 6
      Call imgOS_Click(0)
   Case 8, 9, 11, 12
      Call imgPU_Click(0)
   Case 14, 15, 16
      Call imgPH_Click(0)
   Case 7, 10, 13, 17, 18
      Call imgFSS_Click(0)
   Case 3, 4, 19, 20, 21
      Call imgFGA_Click(0)
   Case 22, 23
      Call imgFGW_Click(0)
   End Select
End Sub

Private Sub lbUP_Click(Index As Integer)
   Call imgUP_Click(0)
  
End Sub

Private Sub lbOS_Click(Index As Integer)
   Call imgOS_Click(0)
End Sub

Private Sub lbPU_Click(Index As Integer)
   Call imgPU_Click(0)
End Sub

Private Sub lbPH_Click(Index As Integer)
   Call imgPH_Click(0)
End Sub

Private Sub lbFGW_Click(Index As Integer)
   Call imgFGW_Click(0)
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

Private Sub tmrMSG_Timer()
   sspMsg.Visible = False
   sspMsg.Caption = ""
   tmrMSG.Enabled = False
End Sub

Private Sub tmrScan_Timer()
   If chkAutoScan.Value = 0 Then
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
