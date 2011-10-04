VERSION 5.00
Begin VB.Form frmDown 
   Caption         =   "Download..."
   ClientHeight    =   1065
   ClientLeft      =   5250
   ClientTop       =   6690
   ClientWidth     =   5985
   Icon            =   "frmDown.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   1065
   ScaleWidth      =   5985
   Begin VB.Label lblstatus 
      BackColor       =   &H0080FFFF&
      BorderStyle     =   1  '단일 고정
      Caption         =   "Connecting to server....."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   225
      TabIndex        =   1
      Top             =   525
      Width           =   5490
   End
   Begin VB.Label Label1 
      Caption         =   "[Status]"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   315
      Left            =   225
      TabIndex        =   0
      Top             =   150
      Width           =   1065
   End
End
Attribute VB_Name = "frmDown"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub sbdown()
Dim fso, f_s, f_l, f_fld, f_prts, f_prt
Dim s_path, l_path
Dim comp_s, comp_l
On Error Resume Next
   DoEvents
   'server path
   s_path = "\\211.54.128.5\neomics\mm\bl\mes\MES.exe"
   'local path
   l_path = App.Path & "\MES.exe"
   
   Set fso = CreateObject("Scripting.FileSystemObject")
   'server
   Set f_s = fso.GetFile(s_path)
   comp_s = f_s.DateLastModified
   
   'local
   Set f_l = fso.GetFile(l_path)
   If IsEmpty(f_l) Then
      lblstatus.Caption = "Downloading Files....."
      fso.CopyFile s_path, App.Path & "\"
      
      s_path = "\\211.54.128.5\neomics\mm\bl\mes\prt\"
      Set f_fld = fso.GetFolder(s_path)
      Set f_prts = f_fld.Files
      For Each f_prt In f_prts
         If LCase(Right(f_prt.Name, 3)) = "mrd" Then
           fso.CopyFile s_path & "\" & f_prt.Name, App.Path & "\prt\"
         End If
      Next
      
   Else
      comp_l = f_l.DateLastModified
   
      If comp_l <> comp_s Then
           lblstatus.Caption = "Downloading Files....."
           fso.CopyFile s_path, App.Path & "\"
      Else
           lblstatus.Caption = "Files does not change....."
      End If
   
      s_path = "\\211.54.128.5\neomics\mm\bl\mes\prt\"
      Set f_fld = fso.GetFolder(s_path)
      Set f_prts = f_fld.Files
      For Each f_prt In f_prts
         If LCase(Right(f_prt.Name, 3)) = "mrd" Then
           fso.CopyFile s_path & "\" & f_prt.Name, App.Path & "\prt\"
         End If
      Next
      
   End If
   Exit Sub
ErrGo:
   MsgBox "Downloading Error -" & Err.Description
End Sub

Private Sub Form_Activate()
    DoEvents
    Call sbdown
    Shell App.Path & "\MES.exe", vbNormalFocus
    Unload Me
End Sub

