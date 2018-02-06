Public Class DonorUnits
    'THIS CLASS WILL BE USED TO STORE DONOR UNITS INFO FOR DONOR XMATCHES. THIS WILL ALSO BE USED AS A DATASOURCE 
    'FOR TABLE GridViewBbkXmatch DISPLAYING USER ENTERED DETAILS ABOUT DONOR UNITS X-MATCHED FOR THE RECEIPIENTS.

    'THIS DATA MIGHT BE SAVED TO LOCAL ATTACHED SQL SERVER DATABASE TO STORE XMATCH INFORMATION.

    'AUTHOR: IBRAHIM HUSSAIN
    'SWAT INC. 

    'Initialising log4net logger for this class and getting class name from reflection
    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    Public Sub New(ByVal XMatchNo as String, ByVal UnitNo as String, ByVal UnitABO as String,ByVal UnitRh as String, ByVal UnitCompatible as String, ByVal Compononet As String, Optional Volume as Decimal = Nothing)
       log.Info("Donor Unit.New()")

        X_MATCH_NO = XMatchNo
        UNIT_NO = UnitNo
        UNIT_ABO = UnitABO
        UNIT_Rh = UnitRh
        COMPATABILITY = UnitCompatible
        COMPONENT = Compononet
        VOLUME = Volume

        log.Info(String.Format("Generic List, New Record: {0}|{1}|{2}|{3}|{4}|{5}|{6}", X_MATCH_NO, UNIT_NO, UNIT_ABO, UNIT_Rh, COMPATABILITY, COMPONENT, VOLUME))

    End Sub

    Public Property X_MATCH_NO() As String
    Public Property UNIT_NO() As String
    Public Property UNIT_ABO() As String
    Public Property UNIT_Rh() As String
    Public Property COMPATABILITY() As String
    Public Property COMPONENT() As String
    Public Property VOLUME() As Decimal

End Class