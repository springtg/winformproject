VERSION 5.00
Begin VB.Form frmLogin 
   BorderStyle     =   3  '크기 고정 대화 상자
   Caption         =   "로그인"
   ClientHeight    =   1215
   ClientLeft      =   5415
   ClientTop       =   3465
   ClientWidth     =   4335
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   717.862
   ScaleMode       =   0  '사용자
   ScaleWidth      =   4070.33
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton cmdOK 
      Caption         =   "확인"
      Default         =   -1  'True
      Height          =   390
      Left            =   720
      TabIndex        =   2
      Top             =   690
      Width           =   1140
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "취소"
      Height          =   390
      Left            =   2340
      TabIndex        =   3
      Top             =   690
      Width           =   1140
   End
   Begin VB.TextBox txtPassword 
      Height          =   345
      IMEMode         =   3  '사용 못함
      Left            =   1529
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   165
      Width           =   2610
   End
   Begin VB.Label lblLabels 
      Alignment       =   2  '가운데 맞춤
      Caption         =   "Pasword(&P):"
      Height          =   270
      Index           =   1
      Left            =   0
      TabIndex        =   0
      Top             =   240
      Width           =   1440
   End
End
Attribute VB_Name = "frmLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public LoginSucceeded As Boolean

Private Sub cmdCancel_Click()
    '전역 변수를 False로 설정하여
    '실패한 로드인을 표시합니다.
    LoginSucceeded = False
    Me.Hide
End Sub

Private Sub cmdOK_Click()
    '정확한 암호를 확인합니다.
    If txtPassword = "administrator" Then
        '코드를 여기에 붙여 넣어
        '성공 사항을 호출 Sub로 전달합니다.
        '전역 변수를 설정하는 것이 가장 쉽습니다.
        LoginSucceeded = True
        Me.Hide
    Else
        LoginSucceeded = False
        MsgBox "암호가 잘못되었습니다. 다시 시도하십시오", , "로그인"
        txtPassword.SetFocus
        SendKeys "{Home}+{End}"
    End If
End Sub

Private Sub Form_Load()
   LoginSucceeded = False
End Sub
