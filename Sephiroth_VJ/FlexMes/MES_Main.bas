Attribute VB_Name = "MES_MAIN"
Public Sub Main()
'*******************************************************************************************************
' 1.Description : MES
' 2.ACCESS      : PUBLIC
' 3.PARAMETER   :
' 4.작성자명    : 강성화
' 5.작성일자    : 2003.06.23
' 6.변경이력    :
'*******************************************************************************************************
    '중복실행 방지
    If App.PrevInstance Then
        AppActivate App.Title
        End
    End If
    
    LoginSucceeded = False
    frmMO01VJ.Show
End Sub
