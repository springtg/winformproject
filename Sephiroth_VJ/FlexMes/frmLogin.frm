VERSION 5.00
Begin VB.Form frmLogin 
   BorderStyle     =   3  'ũ�� ���� ��ȭ ����
   Caption         =   "�α���"
   ClientHeight    =   1215
   ClientLeft      =   5415
   ClientTop       =   3465
   ClientWidth     =   4335
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   717.862
   ScaleMode       =   0  '�����
   ScaleWidth      =   4070.33
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton cmdOK 
      Caption         =   "Ȯ��"
      Default         =   -1  'True
      Height          =   390
      Left            =   720
      TabIndex        =   2
      Top             =   690
      Width           =   1140
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "���"
      Height          =   390
      Left            =   2340
      TabIndex        =   3
      Top             =   690
      Width           =   1140
   End
   Begin VB.TextBox txtPassword 
      Height          =   345
      IMEMode         =   3  '��� ����
      Left            =   1529
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   165
      Width           =   2610
   End
   Begin VB.Label lblLabels 
      Alignment       =   2  '��� ����
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
    '���� ������ False�� �����Ͽ�
    '������ �ε����� ǥ���մϴ�.
    LoginSucceeded = False
    Me.Hide
End Sub

Private Sub cmdOK_Click()
    '��Ȯ�� ��ȣ�� Ȯ���մϴ�.
    If txtPassword = "administrator" Then
        '�ڵ带 ���⿡ �ٿ� �־�
        '���� ������ ȣ�� Sub�� �����մϴ�.
        '���� ������ �����ϴ� ���� ���� �����ϴ�.
        LoginSucceeded = True
        Me.Hide
    Else
        LoginSucceeded = False
        MsgBox "��ȣ�� �߸��Ǿ����ϴ�. �ٽ� �õ��Ͻʽÿ�", , "�α���"
        txtPassword.SetFocus
        SendKeys "{Home}+{End}"
    End If
End Sub

Private Sub Form_Load()
   LoginSucceeded = False
End Sub
