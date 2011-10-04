Attribute VB_Name = "MesBase"
Public LoginSucceeded As Boolean
Public gFactory As String
Public gDept As String
Public gLine As String
Public gDelayFlag As Boolean
Public gINTERVAL As Integer
Public gASSY_LINE_NUM As Integer

Public gArrDept As Variant
Public gArrRstGroup As Variant
Public gArrRstDiv As Variant
Public gMsgDspSec As Integer

Public adoConnLocal As ADODB.Connection '' ADODB의 Connection오브젝트
Public adoConnOra As ADODB.Connection '' ADODB의 Connection오브젝트

Public Const GRID_HEAD_BACKCOLOR As Long = 15198183
Public Const GRID_BACKCOLOR As Long = 15198183
Public Const GRID_ROWHEIGHT As Long = 17
Public Const GRID_GRIDCOLOR As Long = 6579300
Public Const GRID_TOTCOLOR As Long = 0
'System Time Type
Private Type SYSTEMTIME
    wYear As Integer
    wMonth As Integer
    wDayOfWeek As Integer
    wDay As Integer
    wHour As Integer
    wMinute As Integer
    wSecond As Integer
    wMilliseconds As Integer
End Type

'------------------------------------------------------------------------------------------
'  INI File의 Key정보를 가져오기 API함수
'------------------------------------------------------------------------------------------
Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long

'------------------------------------------------------------------------------------------
'  System Time 설정 API함수
'------------------------------------------------------------------------------------------
Private Declare Function SetSystemTime Lib "kernel32" (lpSystemTime As SYSTEMTIME) As Long

'------------------------------------------------------------------------------------------
' 연결정보가 있는 파일을 실행하는 API함수
'------------------------------------------------------------------------------------------
Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
            (ByVal hWnd As Long, _
             ByVal lpOperation As String, _
             ByVal lpFile As String, _
             ByVal lpParameters As String, _
             ByVal lpDirectory As String, _
             ByVal nShowCmd As Long) As Long

' ShellExecute실행시 창모양
Public Const SW_SHOWDEFAULT = 10     ' 기본값
Public Const SW_SHOWMAXIMIZED = 3    ' 최대화면
Public Const SW_SHOWMINIMIZED = 2    ' 아이콘
Public Const SW_SHOWNORMAL = 1       ' 보통창

' ShellExecute 실행후 리턴되는 값중에서 에러상수
Public Const ERROR_FILE_NOT_FOUND = 2&  ' 화일이 없음
Public Const ERROR_PATH_NOT_FOUND = 3&  ' 경로가 없음
Public Const ERROR_BAD_FORMAT = 11&     ' 형식이 맞지않음
Public Const ERROR_GEN_FAILURE = 31&    ' 일반적인 에러

'------------------------------------------------------------------------------------------
' 파일을 실행하는 프로시져
'  lHwnd: 윈도우 핸들
'  sOperation: 실행구분  예) "OPEN"
'  sFile: 실행할 파일 명
'  iShowCmd: 창속성
'         SW_SHOWDEFAULT   ; 기본값
'         SW_SHOWMAXIMIZED ; 최대화면
'         SW_SHOWMINIMIZED ; 아이콘
'         SW_SHOWNORMAL    ; 보통창
'------------------------------------------------------------------------------------------
Public Sub OpenShell(lHwnd As Long, _
                     sOperation As String, _
                     sFile As String, _
                     iShowCmd As Integer)
Dim lRet As Long

  lRet = ShellExecute(lHwnd, _
                      sOperation, _
                      sFile, _
                      vbNullString, _
                      vbNullString, _
                      iShowCmd)

  ' 에러를 처리할 부분
  Select Case lRet
         Case ERROR_FILE_NOT_FOUND
              MsgBox "File Not Found!"
         Case ERROR_PATH_NOT_FOUND
              MsgBox "Path Not Found!"
         Case ERROR_BAD_FORMAT
              MsgBox "Bad File Format!"
         Case ERROR_GEN_FAILURE
              MsgBox "Open Failure"
  End Select

End Sub

Public Sub sbSpdVLine(ByRef fsp1 As Object, Col As Long, Row As Long)
   fsp1.ColWidth(Col) = 25
   fsp1.Cell(6, Row, Col, fsp1.Rows - 1, Col) = RGB(1, 1, 1)
End Sub

Public Sub sbSpdHLine(ByRef fsp1 As Object, Row As Long, Col1 As Long, Col2 As Long)
   fsp1.ColWidth(Col) = 25
   fsp1.Cell(6, Row, Col1, Row, Col2) = RGB(1, 1, 1)
End Sub


'------------------------------------------------------------------------------------------
' 로그 파일에 메세지를 기록한다. (strType:메세지구분, strLog:메세지)
'------------------------------------------------------------------------------------------
Public Sub sbLogWrite(ByVal strType As String, ByVal strLog As String)
    Dim strData As String '시간(yyyymmddhhmmss) + type(REV,SND) + data
    Dim SP As String
    Dim strFileName As String
    
    SP = "¿"   '구분자
    strFileName = App.Path & "\LOG\log_" & Format(Now, "yyyyMMdd") & ".txt"

On Error Resume Next
    strData = Format(Now, "yyyyMMddhhmmss") & SP & strType & SP & strLog
    Open strFileName For Append As #1
        Print #1, strData
    Close #1
End Sub


Public Function fnFindArrData(arg_arr As Variant, arg_key As Variant) As Integer
   Dim i As Integer
   Dim varVAL As Variant
      
   On Error GoTo err_rtn
   
   For i = 0 To UBound(arg_arr)
      If arg_arr(i) = arg_key Then
         fnFindArrData = i
         Exit Function
      End If
   Next i
   
err_rtn:
   
   fnFindArrData = -1
   
End Function

'------------------------------------------------------------------------------------------
'  Variant Array의 찾는 KeyValue가 들어 있는 인덱스를 리턴하는 함수
'  만약, 찾지 못하면 -1을 리턴한다.
'  Array Value : KeyValue + Chr(27) + KeyName
'------------------------------------------------------------------------------------------
Public Function fnFindArr(arg_arr As Variant, arg_key As Variant) As Integer
   Dim i As Integer
   Dim varVAL As Variant
      
   On Error GoTo err_rtn
   
   For i = 0 To UBound(arg_arr)
      varVAL = Split(arg_arr(i), Chr$(27))
      If varVAL(0) = arg_key Then
         fnFindArr = i
         Exit Function
      End If
   Next i
   
err_rtn:
   
   fnFindArr = -1
   
End Function

'------------------------------------------------------------------------------------------
'  Variant Array의 찾는 KeyValue가 들어 있는 인덱스를 찾아서 KeyName을 리턴하는 함수
'  만약, 찾지 못하면 ""를 리턴한다.
'  Array Value : KeyValue + Chr(27) + KeyName
'------------------------------------------------------------------------------------------
Public Function fnFindName(arg_arr, arg_key As Variant) As String
    Dim varRet As Variant
    Dim i As Integer
    
    i = fnFindArr(arg_arr, arg_key)
    If i = -1 Then
        fnFindName = ""
    Else
       varRet = Split(arg_arr(i), Chr$(27), 2)
       fnFindName = varRet(1)
    End If
End Function

'------------------------------------------------------------------------------------------
' 인자값이 Null이면 ""를 리턴하고, 아니면 인자값의 String값을 리턴하는 함수
'------------------------------------------------------------------------------------------
Public Function fnNVL(arg_val As Variant) As String
   If IsNull(arg_val) Then
      fnNVL = ""
   Else
      fnNVL = CStr(arg_val)
   End If
End Function

'------------------------------------------------------------------------------------------
' 인자값이 Null이거나 숫자가 아니면 "0"를 리턴하고, 아니면 인자값의 String값을 리턴하는 함수
'------------------------------------------------------------------------------------------
Public Function fnNVZ(arg_val As Variant) As String
   If IsNull(arg_val) Then
      fnNVZ = "0"
   Else
      If Not IsNumeric(arg_val) Then
         fnNVZ = "0"
      Else
         If Trim(arg_val) = "" Then
            fnNVZ = "0"
         Else
            fnNVZ = CStr(arg_val)
         End If
      End If
   End If
End Function

'------------------------------------------------------------------------------------------
' ComboBox의 KeyValue를 리턴하는 함수
' ComboBox.Text = KeyName + Chr(27) + KeyValue
'------------------------------------------------------------------------------------------
Public Function fnCboValue(ByRef arg_cbo As Object) As String
    Dim varRet As Variant
    
    If Trim(arg_cbo.Text) = "" Then
        fnCboValue = ""
    Else
        varRet = Split(arg_cbo.Text, Chr$(27))
        fnCboValue = varRet(1)
    End If
End Function

Public Function fnCboDesc(ByRef arg_cbo As Object) As String
    Dim varRet As Variant
    
    If Trim(arg_cbo.Text) = "" Then
        fnCboDesc = ""
    Else
        varRet = Split(arg_cbo.Text, Chr$(27))
        fnCboDesc = Trim(varRet(0))
    End If
End Function

'------------------------------------------------------------------------------------------
' ComboBox에 Local DB로 부터 Item을 가져오는 함수 (arg_sql 쿼리 사용)
' 정상이면 ""값을 리턴하고, 비정상이면 에러메세지를 리턴한다.
'------------------------------------------------------------------------------------------
Public Function fnSetCbo(ByRef arg_cbo As Object, arg_sql As String) As String
   Dim varDATA As Variant
   Dim i As Long
   
   'varData = fnGetData(arg_sql)
   varDATA = fnGetOraData(arg_sql)
   
   If IsArray(varDATA) Then
      arg_cbo.Clear
      For i = 0 To UBound(varDATA, 2) Step 1
         arg_cbo.AddItem varDATA(1, i) & Space(60 - Len(varDATA(1, i))) & Chr$(27) & varDATA(0, i)
      Next i
      arg_cbo.AddItem Space(60) & Chr$(27) & ""
      fnSetCbo = ""
   Else
      fnSetCbo = "The base data not found!"
   End If
End Function

'------------------------------------------------------------------------------------------
' 일정 시간 만큼 프로세스를 멈추게하는 프로시져
'------------------------------------------------------------------------------------------
Public Sub sbDelay(arg_LoopNum As Long)
   For lngRow = 0 To arg_LoopNum Step 1
      If Not gDelayFlag Then
         Exit For
      End If
      DoEvents
      DoEvents
   Next
End Sub

'------------------------------------------------------------------------------------------
' 기준정보를 Local DB에서 가져와서 글로발 Array변수에 넣는 프로시져
' gArrProdTP : 양산구분 배열
'------------------------------------------------------------------------------------------
Public Sub sbGetBase()
   Dim strSQL As String
   
   'Dept Info.:TC_CF_DEPART
   strSQL = "  SELECT DEPT_CODE, "  '0
   strSQL = strSQL & "FTR_CODE, "   '1
   strSQL = strSQL & "START_LINE, " '2
   strSQL = strSQL & "LINE_QTY, "   '3
   strSQL = strSQL & "SHIFT_A_STR, SHIFT_A_FROM, SHIFT_A_TO, " '4,5,6
   strSQL = strSQL & "SHIFT_B_STR, SHIFT_B_FROM, SHIFT_B_TO, " '7,8,9
   strSQL = strSQL & "SHIFT_C_STR, SHIFT_C_FROM, SHIFT_C_TO, " '10,11,12
   strSQL = strSQL & "DEPART_NAME " '13
   strSQL = strSQL & "FROM MICS.FM_DEPT_TIME "
   strSQL = strSQL & "ORDER BY 1,2 "
   
   gArrDept = fnGetOraData(strSQL)
   If IsArray(gArrDept) Then
   Else
      If gArrDept = "" Then
         MsgBox "Dept Info Not Found!", vbExclamation
      Else
         MsgBox gArrDept
      End If
   End If
   
   'Results Group : PB_OPCD
   strSQL = "  SELECT OP_CD, "           '0
   strSQL = strSQL & "OP_NAME, "         '1
   strSQL = strSQL & "I_SCN_RESULT_YN, " '2
   strSQL = strSQL & "T_SCN_RESULT_YN, " '3
   strSQL = strSQL & "P_SCN_RESULT_YN, " '4
   strSQL = strSQL & "O_SCN_RESULT_YN, " '5
   strSQL = strSQL & "RST_GROUP "        '6
   strSQL = strSQL & "FROM PB_OPCD "
   strSQL = strSQL & "WHERE RST_GROUP IS NOT NULL "
   strSQL = strSQL & "ORDER BY RST_GROUP "
   
   gArrRstGroup = fnGetOraData(strSQL)
   If IsArray(gArrRstGroup) Then
   Else
      If gArrRstGroup = "" Then
         MsgBox "OP_CD Not Found!", vbExclamation
      Else
         MsgBox gArrRstGroup
      End If
   End If
   
   ReDim gArrRstDiv(3) As String
   gArrRstDiv(0) = "I-Incom."
   gArrRstDiv(1) = "T-Input"
   gArrRstDiv(2) = "P-Prod."
   gArrRstDiv(3) = "O-Outgo."
End Sub

Public Function fnPass(arg_user As String, arg_pass As String) As String
   Dim SQL As String
   Dim vRTN As Variant
   
   SQL = ""
   SQL = SQL & " SELECT COUNT(A.USER_ID) "
   SQL = SQL & "   FROM CM_USER A, PB_PARAM B "
   SQL = SQL & "  WHERE A.FACTORY =  B.FACTORY "
   SQL = SQL & "    AND USER_ID   = '" & arg_user & "' "
   SQL = SQL & "    AND PASSWD    = '" & arg_pass & "' "
   vRTN = fnGetOraData(SQL)
   If IsArray(vRTN) Then
      If CInt(vRTN(0, 0)) = 0 Then
         fnPass = "N"
      Else
         fnPass = "Y"
      End If
   Else
      If vRTN = "" Then
         fnPass = "Can not find data!"
      Else
         fnPass = vRTN
      End If
   End If
End Function

'------------------------------------------------------------------------------------------
' KeyValue로 ComboBox의 값을 셋팅하는 프로시져
'------------------------------------------------------------------------------------------
Public Sub sbLetCbo(ByRef arg_cbo As ComboBox, arg_key As String)
   Dim i As Long
   Dim varVAL As Variant
   
   For i = 0 To arg_cbo.ListCount - 1 Step 1
      varVAL = Split(arg_cbo.List(i), Chr$(27), 2)
      If varVAL(1) = arg_key Then
         arg_cbo.Text = arg_cbo.List(i)
         Exit Sub
      End If
   Next i
   
   On Error GoTo err_rtn
   arg_cbo.Text = Space(60) & Chr$(27) & ""
   Exit Sub
err_rtn:
   'arg_cbo.Text = ""
End Sub

Public Sub sbLetCbo2(ByRef arg_cbo As ComboBox, arg_key As String, arg_keylength As Integer)
   Dim i As Long
   Dim varVAL As Variant
   
   For i = 0 To arg_cbo.ListCount - 1 Step 1
      varVAL = Split(arg_cbo.List(i), Chr$(27), 2)
      If Mid(varVAL(1), 1, arg_keylength) = arg_key Then
         arg_cbo.Text = arg_cbo.List(i)
         Exit Sub
      End If
   Next i
   
   On Error GoTo err_rtn
   arg_cbo.Text = Space(50) & Chr$(27) & ""
   Exit Sub
err_rtn:
   'arg_cbo.Text = ""
End Sub

'------------------------------------------------------------------------------------------
' KeyName으로 ComboBox의 값을 셋팅하는 프로시져
'------------------------------------------------------------------------------------------
Public Sub sbLetCboByName(ByRef arg_cbo As ComboBox, arg_name As String)
   Dim i As Long
   Dim varVAL As Variant
   
   For i = 0 To arg_cbo.ListCount - 1 Step 1
      varVAL = Split(arg_cbo.List(i), Chr$(27), 2)
      If Trim(varVAL(0)) = Trim(arg_name) Then
         arg_cbo.Text = arg_cbo.List(i)
         Exit Sub
      End If
   Next i
   On Error GoTo err_rtn
   arg_cbo.Text = Space(60) & Chr$(27) & ""
   Exit Sub
err_rtn:
   'arg_cbo.Text = ""
End Sub

'-----------------------------------------------------------------------------
' Oracle 데이타베이스 연결 함수
' 성공하면 ""를 리턴하고, 실패하면 에러메세지를 리턴한다.
'-----------------------------------------------------------------------------
Public Function fnConnOraDB() As String
   Dim strDBConn As String
   Dim strPath As String
   Dim lngRet As Long
   Dim strBuffer As String
   Dim strServer As String
   Dim strUsr As String
   Dim strPsw As String
   
   strPath = App.Path & "\NEOMICS.INI"
   strBuffer = Space(20)
   lngRet = GetPrivateProfileString("DB", "DB_NAME", "", strBuffer, Len(strBuffer), strPath)
   strServer = fnRemoveNUL(strBuffer)
   lngRet = GetPrivateProfileString("DB", "USR", "", strBuffer, Len(strBuffer), strPath)
   strUsr = fnRemoveNUL(strBuffer)
   lngRet = GetPrivateProfileString("DB", "PSW", "", strBuffer, Len(strBuffer), strPath)
   strPsw = fnRemoveNUL(strBuffer)
   
   On Error GoTo errorHandler
    
   strDBConn = "Provider=MSDAORA.1;" _
             & "Data Source=" & strServer & ";" _
             & "User ID=" & strUsr & ";" _
             & "Password=" & strPsw
             
   Set adoConnOra = New ADODB.Connection
   With adoConnOra
      .Provider = "MSDAORA.1"
      .ConnectionString = strDBConn
      .CommandTimeout = 60
      .CursorLocation = adUseClient
      .Open
   End With
   
   fnConnOraDB = ""
   
   Exit Function
errorHandler:
   fnConnOraDB = Err.Description
   Err.Clear
   Set adoConnOra = Nothing
End Function

'***************************************************************************
' 인수로 받은 SELECT문을 쿼리하여 레코드셋에 넘겨줌
'***************************************************************************
Public Function Get_Recordset(ByRef DBConn As ADODB.Connection, _
                              ByRef RS As ADODB.Recordset, _
                              ByVal strSQL As String, _
                              Optional bReadOnly As Boolean = True) As Boolean
   
    Set RS = Nothing
    Set RS = New ADODB.Recordset
    
    On Error GoTo ErrHandle
    
    If bReadOnly Then
        RS.Open strSQL, DBConn, adOpenDynamic, adLockReadOnly
    Else
        RS.Open strSQL, DBConn, adOpenKeyset, adLockOptimistic
    End If
    
    If RS Is Nothing Then
        Get_Recordset = False
    Else
        Get_Recordset = True
    End If
    
    Exit Function
    
ErrHandle:
    Get_Recordset = False
End Function

'------------------------------------------------------------------------------------------
' DB Server에 SQL 쿼리를 실행하는 함수
' 정상이면 ""를 리턴하고, 비정상이면 에러메세지를 리턴한다.
' (주의) arg_sql은 1차원 배열이어야 함
'------------------------------------------------------------------------------------------
Public Function fnExecOraSQL(arg_sql As Variant) As String
   
   On Error GoTo errorHandler
   
   Dim intCount  As Integer        ' Loop Count
   Dim execsql As String
   Dim intLBound
   Dim intUBound As Integer
   
   intLBound = LBound(arg_sql)
   intUBound = UBound(arg_sql)
   adoConnOra.BeginTrans
   For intCount = intLBound To intUBound
      If arg_sql(intCount) <> "" Then
        execsql = arg_sql(intCount)
        adoConnOra.Execute execsql
      End If
   Next intCount
   adoConnOra.CommitTrans
   fnExecOraSQL = ""
   
   Exit Function
   
errorHandler:
   
   fnExecOraSQL = Err.Description
   Err.Clear
   adoConnOra.RollbackTrans
End Function

Public Function fnExecOraSQL2(arg_sql As String) As String
   
   On Error GoTo errorHandler
   
   adoConnOra.BeginTrans
   adoConnOra.Execute arg_sql
   adoConnOra.CommitTrans
   fnExecOraSQL2 = ""
   
   Exit Function
   
errorHandler:
   
   fnExecOraSQL2 = Err.Description
   Err.Clear
   adoConnOra.RollbackTrans
End Function


'------------------------------------------------------------------------------------------
' DB Server에 SQL 쿼리를 보내고 쿼리결과를 Array로 받는 함수
' 정상이면 쿼리결과를 배열로 리턴하고, 비정상이면 에러메세지를 리턴한다.
'------------------------------------------------------------------------------------------
Public Function fnGetOraData(arg_sql As String) As Variant
   On Error GoTo errorHandler
   
   Dim adoRSOra   As ADODB.Recordset
   
   Set adoRSOra = New ADODB.Recordset
   adoRSOra.Open arg_sql, adoConnOra, adOpenForwardOnly, adLockReadOnly
   
   If adoRSOra.EOF Then
      fnGetOraData = ""
   Else
      fnGetOraData = adoRSOra.GetRows
   End If
   
   adoRSOra.Close
   Set adoRSOra = Nothing
   
   Exit Function
errorHandler:
   
   fnGetOraData = Err.Description
   Err.Clear
   
   If adoRSOra.State = 1 Then
      adoRSOra.Close
   End If
   Set adoRSOra = Nothing

End Function

'------------------------------------------------------------------------------------------
' Oracle 접속을 해제하는 프로시져
'------------------------------------------------------------------------------------------
Public Sub sbDisconnOra()
   On Error Resume Next
   
   adoConnOra.Close
   
   Set adoConnOra = Nothing
End Sub

'------------------------------------------------------------------------------------------
' 로칼 데이타베이스 연결 함수
' 성공하면 ""를 리턴하고, 실패하면 에러메세지를 리턴한다.
'------------------------------------------------------------------------------------------
Public Function fnConnLocalDB() As String
   On Error GoTo errorHandler
   
   'Local DB connection
   Set adoConnLocal = New ADODB.Connection
   adoConnLocal.Provider = "Microsoft.Jet.OLEDB.4.0"
   adoConnLocal.ConnectionString = "Data Source=" & App.Path & "\DATA\NEOMICS_PROD.mdb;Mode=ReadWrite"
   adoConnLocal.CommandTimeout = 10
   adoConnLocal.Open
   
   fnConnLocalDB = ""
   
   Exit Function
errorHandler:
   fnConnLocalDB = Err.Description
   Err.Clear
   Set adoConnLocal = Nothing
End Function

'------------------------------------------------------------------------------------------
' 로칼 데이타베이스에 SQL 쿼리를 실행하는 함수
' 정상이면 ""를 리턴하고, 비정상이면 에러메세지를 리턴한다.
' (주의) arg_sql은 1차원 배열이어야 함
'------------------------------------------------------------------------------------------
Public Function fnExecSQL(arg_sql As Variant) As String
    
   On Error GoTo errorHandler
   
   Dim intCount  As Integer        ' Loop Count
   Dim execsql As String
   Dim intLBound
   Dim intUBound As Integer
   
   intLBound = LBound(arg_sql)
   intUBound = UBound(arg_sql)
   adoConnLocal.BeginTrans
   For intCount = intLBound To intUBound
      If arg_sql(intCount) <> "" Then
        execsql = arg_sql(intCount)
        adoConnLocal.Execute execsql
      End If
   Next intCount
   adoConnLocal.CommitTrans
   fnExecSQL = ""
   
   Exit Function

errorHandler:
   
   fnExecSQL = Err.Description
   Err.Clear
   adoConnLocal.RollbackTrans
End Function

'------------------------------------------------------------------------------------------
' 로칼 데이타베이스에 SQL 쿼리를 보내고 쿼리결과를 Array로 받는 함수
' 정상이면 쿼리결과를 배열로 리턴하고, 비정상이면 에러메세지를 리턴한다.
'------------------------------------------------------------------------------------------
Public Function fnGetData(arg_sql As String) As Variant
   On Error GoTo errorHandler
   
   Dim adoRSLocal   As ADODB.Recordset
   
   Set adoRSLocal = New ADODB.Recordset
   adoRSLocal.Open arg_sql, adoConnLocal, adOpenForwardOnly, adLockReadOnly
   
   If adoRSLocal.EOF Then
      fnGetData = ""
   Else
      fnGetData = adoRSLocal.GetRows
   End If
   
   adoRSLocal.Close
   Set adoRSLocal = Nothing
   
   Exit Function
errorHandler:
   
   fnGetData = Err.Description
   Err.Clear
   
   If adoRSLocal.State = 1 Then
      adoRSLocal.Close
   End If
   Set adoRSLocal = Nothing

End Function

'------------------------------------------------------------------------------------------
' Null값을 제거한 String을 리턴하는 함수
'------------------------------------------------------------------------------------------
Public Function fnRemoveNUL(ByVal arg_str As String) As String
   Dim i As Integer
   Dim strTmp As String
   Dim strBuffer As String
   
   strTmp = Trim(arg_str)
   strBuffer = ""
   For i = 1 To Len(strTmp) Step 1
      If Asc(Mid(strTmp, i, 1)) = 0 Then
         fnRemoveNUL = strBuffer
         Exit Function
      Else
         strBuffer = strBuffer & Mid(strTmp, i, 1)
      End If
   Next i
   fnRemoveNUL = strBuffer
End Function

'------------------------------------------------------------------------------------------
' PRPCmn.INI 파일을 읽어서 글로벌 변수를 초기화하는 프로시져
'------------------------------------------------------------------------------------------
Public Sub GetInitParam()
   Dim strPath As String
   Dim lngRet As Long
   Dim strBuffer As String

   strPath = App.Path & "\NEOMICS.INI"
         
   strBuffer = Space(20)
   
   lngRet = GetPrivateProfileString("Common", "FACTORY", "", strBuffer, Len(strBuffer), strPath)
   gFactory = fnRemoveNUL(strBuffer)
   
   lngRet = GetPrivateProfileString("Common", "INTERVAL", "5", strBuffer, Len(strBuffer), strPath)
   gINTERVAL = CInt(fnRemoveNUL(strBuffer))
   
   lngRet = GetPrivateProfileString("Common", "ASSY_LINE_NUM", "9", strBuffer, Len(strBuffer), strPath)
   gASSY_LINE_NUM = CInt(fnRemoveNUL(strBuffer))
   
   lngRet = GetPrivateProfileString("Common", "MSG_DSP_SEC", "3", strBuffer, Len(strBuffer), strPath)
   gMsgDspSec = CInt(fnRemoveNUL(strBuffer))
End Sub

'------------------------------------------------------------------------------------------
' System Time을 서버의 SystemTime으로 초기화하는 함수
' 성공하면 ""를 리턴하고, 실패하면 에러메세지를 리턴한다.
'------------------------------------------------------------------------------------------
Public Sub sbSetSysDate(ByVal timezone As Integer)
    '클라이언트 날짜/시간 세팅
    Dim strSQL As String
    Dim dtSysdate As Date
    Dim lpSystemTime As SYSTEMTIME
    Dim varDATA As Variant
    Dim strRet As String
    
On Error GoTo err_rtn
    
    'strRet = fnConnOraDB()
    'If strRet = "" Then
    'Else
    '   fnSetSysDate = "DB Connection Failed!"
    '   Exit Function
    'End If
    
    strSQL = "SELECT SYSDATE FROM DUAL "
    varDATA = fnGetOraData(strSQL)
    dtSysdate = varDATA(0, 0)
    
    'Call sbDisconnOra
    
    '----------------------------------------------
    dtSysdate = DateAdd("h", -1 * timezone, dtSysdate)

    lpSystemTime.wYear = Year(dtSysdate)
    lpSystemTime.wMonth = Month(dtSysdate)
    lpSystemTime.wDayOfWeek = Weekday(dtSysdate) - 1
    lpSystemTime.wDay = Day(dtSysdate)
    lpSystemTime.wHour = Hour(dtSysdate)
    lpSystemTime.wMinute = Minute(dtSysdate)
    lpSystemTime.wSecond = Second(dtSysdate)
    lpSystemTime.wMilliseconds = 0
    SetSystemTime lpSystemTime
    
    fnSetSysDate = ""
    
    Exit Sub
err_rtn:
    fnSetSysDate = Err.Description
    Exit Sub
End Sub

'------------------------------------------------------------------------------------------
' Local DB를 압축하고 Old DB를 복사하는 프로시져
'------------------------------------------------------------------------------------------
Sub sbCompactLocalDB(arg_Mdb As String)
   Dim varRet As Variant
   Dim strTmp As String
   Dim i As Integer
   Dim intFlag As Integer
   
   varRet = Split(arg_Mdb, ".")
   strTmp = ""
   For i = 0 To UBound(varRet) - 1 Step 1
      strTmp = strTmp + varRet(i)
   Next
   
   'Database Compact
   If Trim(Dir(strTmp & "_tmp.mdb")) = "" Then
   Else
      Kill (strTmp & "_tmp.mdb")
   End If
      
   intFlag = 0
   
   On Error Resume Next
   intFlag = adoConnLocal.State
      
   If intFlag = 1 Then
      adoConnLocal.Close
      Set adoConnLocal = Nothing
   End If
   
   CompactDatabase arg_Mdb, strTmp & "_tmp.mdb"
   
   FileCopy arg_Mdb, strTmp & "_old.mdb"
   
   FileCopy strTmp & "_tmp.mdb", arg_Mdb
   
   If intFlag = 1 Then
      strTmp = fnConnLocalDB()
      If strTmp = "" Then
      Else
         MsgBox strTmp, vbExclamation
      End If
   End If
End Sub

