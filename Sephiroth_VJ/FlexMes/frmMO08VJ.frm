VERSION 5.00
Object = "{0BA686C6-F7D3-101A-993E-0000C0EF6F5E}#1.0#0"; "threed32.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmMO08VJ 
   Caption         =   "MES-MO08VJ"
   ClientHeight    =   2265
   ClientLeft      =   2625
   ClientTop       =   3195
   ClientWidth     =   6795
   LinkTopic       =   "Form1"
   ScaleHeight     =   2265
   ScaleWidth      =   6795
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
      Left            =   2235
      Style           =   2  '드롭다운 목록
      TabIndex        =   12
      Top             =   1515
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
      Left            =   2235
      Style           =   2  '드롭다운 목록
      TabIndex        =   13
      Top             =   1875
      Width           =   3015
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
      Left            =   1305
      MaxLength       =   10
      TabIndex        =   8
      Top             =   690
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
      Left            =   4155
      MaxLength       =   10
      PasswordChar    =   "@"
      TabIndex        =   9
      Top             =   705
      Width           =   1590
   End
   Begin Threed.SSPanel SSPanel1 
      Height          =   645
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   6795
      _Version        =   65536
      _ExtentX        =   11986
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
         Left            =   5310
         TabIndex        =   15
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
      Begin Threed.SSCommand cmdApply 
         Height          =   435
         Left            =   3645
         TabIndex        =   14
         Top             =   105
         Width           =   1680
         _Version        =   65536
         _ExtentX        =   2963
         _ExtentY        =   767
         _StockProps     =   78
         Caption         =   "Closing Stock"
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
         Caption         =   "Closing Stock"
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
         TabIndex        =   1
         Top             =   180
         Width           =   2985
      End
      Begin VB.Label lbTitle 
         BackStyle       =   0  '투명
         Caption         =   "Closing Stock"
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
         TabIndex        =   2
         Top             =   150
         Width           =   3135
      End
      Begin VB.Image Image1 
         Height          =   585
         Left            =   30
         Picture         =   "frmMO08VJ.frx":0000
         Top             =   30
         Width           =   4950
      End
   End
   Begin Threed.SSPanel SSPanel7 
      Height          =   360
      Left            =   30
      TabIndex        =   3
      Top             =   690
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
      Left            =   2880
      TabIndex        =   4
      Top             =   705
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
      Left            =   5775
      TabIndex        =   10
      Top             =   675
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
   Begin MSComCtl2.DTPicker dtpYMD 
      Height          =   360
      Left            =   2235
      TabIndex        =   11
      Top             =   1155
      Width           =   1275
      _ExtentX        =   2249
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
      CustomFormat    =   "yyyy/MM"
      Format          =   23855107
      CurrentDate     =   37987
      MinDate         =   37987
   End
   Begin Threed.SSPanel sspInfo 
      Height          =   360
      Left            =   45
      TabIndex        =   5
      Top             =   1155
      Width           =   2160
      _Version        =   65536
      _ExtentX        =   3810
      _ExtentY        =   635
      _StockProps     =   15
      Caption         =   "Closing Year/Month"
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
      Left            =   45
      TabIndex        =   6
      Top             =   1515
      Width           =   2160
      _Version        =   65536
      _ExtentX        =   3810
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
      Left            =   45
      TabIndex        =   7
      Top             =   1875
      Width           =   2160
      _Version        =   65536
      _ExtentX        =   3810
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
Attribute VB_Name = "frmMO08VJ"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

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

Private Sub cmdApply_Click()
   Dim strRtn As String
   Dim strYMD As String
   Dim vPROC  As Variant
   Dim strSECTION  As String
   Dim strUSER As String
   Dim SQL As String
      
   strYMD = Format(dtpYMD.Value, "YYYYMM")
   vPROC = Split(fnCboValue(cboProc), ".")
   strSECTION = fnCboValue(cboSec)
   strUSER = txtUser.Text
   
   If strYMD = "" Or CStr(vPROC(0)) = "" Or strSECTION = "" Or strUSER = "" Then
      MsgBox "You must input datas of Exam.Date, Process, Section."
      Exit Sub
   End If
   SQL = "BEGIN SP_MM_APPLY_CLOSE('" & strYMD & "','" & CStr(vPROC(0)) & "','" & strSECTION & "','" & strUSER & "'); END;"
   Screen.MousePointer = 11
   strRtn = fnExecOraSQL2(SQL)
   Screen.MousePointer = 1
   If strRtn = "" Then
      MsgBox "Closing Stock is success."
   Else
      MsgBox strRtn
   End If

End Sub

Private Sub Form_Load()
   Dim SQL As String
   Dim strRtn As String
   
   lbTitle(0).Caption = "Closing Stock"
   lbTitle(1).Caption = lbTitle(0).Caption
   
   dtpYMD.Value = frmMO01VJ.dtpYMD.Value
   
   'Getting Process
   SQL = " SELECT DCODE||'.'||REMARK1, CD_NAME FROM CM_CODE WHERE MCODE = 'MP07' AND DCODE <> '0000' ORDER BY DCODE "
   strRtn = fnSetCbo(cboProc, SQL)
   
End Sub

Private Sub SSCommand1_Click()
   Unload frmMO08VJ
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
