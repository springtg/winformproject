Attribute VB_Name = "MES_MAIN"
Public Sub Main()
'*******************************************************************************************************
' 1.Description : MES
' 2.ACCESS      : PUBLIC
' 3.PARAMETER   :
' 4.�ۼ��ڸ�    : ����ȭ
' 5.�ۼ�����    : 2003.06.23
' 6.�����̷�    :
'*******************************************************************************************************
    '�ߺ����� ����
    If App.PrevInstance Then
        AppActivate App.Title
        End
    End If
    
    LoginSucceeded = False
    frmMO01VJ.Show
End Sub
