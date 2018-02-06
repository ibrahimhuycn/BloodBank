Imports DevExpress.XtraEditors.Controls
Imports BloodBank.frmBloodBank
Imports System.ComponentModel
Imports SwatInc.SwatInc
Imports SwatInc.SwatInc.Data.ServerCommunications
Imports SwatInc.SwatInc.ValidationHandler
Imports DevExpress.XtraReports.UI
Imports SwatIncNotifications

Public Class frmReportEntry

    'Initialising log4net logger for this class and getting class name from reflection
    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    'Variables to move the form by grabbing GroupControl "gcAnalysisRequest"
    Dim DRAG_ANALYSIS_REQUEST As Boolean
    Dim MOUSE_POSITION_X As Integer
    Dim MOUSE_POSITION_Y As Integer

    'VAR CHECKING FOR DATA ENTRY IF ANY, & THAT THEY ARE DATA IS SAVED.
    'FORMS DATA ENTRY IS CHECKED BY THE BOOLEAN "IS_FORM_EMPTY", WHEN LOST_FOCUS EVENTS ARE RAISED
    'THIS VAR WILL BE UPDATED BY THE SUB "IsFormEmpty"
    Dim IS_FORM_EMPTY As Boolean
    Dim IS_REPORT_ENTRY_SAVED As Boolean

    'VAR HOLDING PATIENT ABO INCASE OF A MISMATCH TO ALLOW FOR DONOR ABO TO BE ENTERED IN THE SAME
    'CONTROLS
    Dim PATIENT_ABO As Integer
    Dim PATIENT_Rh As Integer

    Dim BY_PASS As Integer = Nothing
    Dim CHECK_STATE_ROLLBACK_POINT As Byte

    'INITIALISING TEMP DONOR UNITS LIST USED AS A DATASOURCE FOR GridViewBbkXmatch
    ReadOnly xMatchedDonorUnits As New List(Of DonorUnits)
    Enum PintType
        'Used when to pass PintType to functions, subs, etc...
        Donor
        BloodBank
    End Enum
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        log.Info("Initialising frmReportEntry")
        'INITIALISING VARIABLES
        log.Info("PATIENT_ABO and PATIENT_Rh set to Nothing")
        PATIENT_ABO = Nothing
        PATIENT_Rh = Nothing

        'ASSIGNING GENERIC LIST DonorUnits AS THE DATASOURCE FOR TABLE GridControlBbkXmatch
        log.Info("ASSIGNING GENERIC LIST DonorUnits AS THE DATASOURCE FOR TABLE GridControlBbkXmatch")
        GridControlBbkXmatch.DataSource = xMatchedDonorUnits

    End Sub
    Private Sub gcAnalysisRequest_MouseDown(sender As Object, e As MouseEventArgs) Handles gcXmatch.MouseDown

        'DRAG_ANALYSIS_REQUEST handles an IF CONDITION at mouse move event. If DRAG_ANALYSIS_REQUEST is true, 
        ' and if mouse button.left is down, form is moved with cursor
        log.Info("gcAnalysisRequest_MouseDown: DRAG_ANALYSIS_REQUEST handles an IF CONDITION at mouse move event. If DRAG_ANALYSIS_REQUEST is true, and if mouse button.left is down, form is moved with cursor")
        log.Info("Mouse Button pressed: " & e.Button.ToString)
        If e.Button = MouseButtons.Left Then
            DRAG_ANALYSIS_REQUEST = True
            MOUSE_POSITION_X = Cursor.Position.X - Me.Left
            MOUSE_POSITION_Y = Cursor.Position.Y - Me.Top

            log.Info("DRAG_ANALYSIS_REQUEST Boolean Value: " & DRAG_ANALYSIS_REQUEST.ToString)
            log.Info(String.Format("Mouse position X-Axis: {0}, Y-Axis: {1}", MOUSE_POSITION_X, MOUSE_POSITION_Y))
        End If



    End Sub

    Private Sub gcAnalysisRequest_DoubleClick(sender As Object, e As EventArgs) Handles gcXmatch.DoubleClick
        log.Info("gcAnalysisRequest_DoubleClick: Handles maxmize & minimize")
        log.Info(String.Format("frmReportEntry WindowState: {0}. lblClose Visibility: {1}", WindowState, lblClose.Visible))
        If WindowState = FormWindowState.Normal Then
            WindowState = 2 'Maximaized
            lblClose.Visible = False
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = 0
            lblClose.Visible = True
        End If
        log.Info(String.Format("frmReportEntry WindowState: {0}. lblClose Visibility: {1}", WindowState, lblClose.Visible))
    End Sub

    Private Sub gcAnalysisRequest_MouseMove(sender As Object, e As MouseEventArgs) Handles gcXmatch.MouseMove

        'Moves the form if the form is clicked on to.
        If DRAG_ANALYSIS_REQUEST = True Then
            log.Debug(String.Format("gcAnalysisRequest_MouseMove: DRAG_ANALYSIS_REQUEST Boolean Value: {0}. Determines Whether to move the form drawn location.", DRAG_ANALYSIS_REQUEST))
            Top = Cursor.Position.Y - MOUSE_POSITION_Y
            Left = Cursor.Position.X - MOUSE_POSITION_X
            log.Debug(String.Format("Cursor Location (Top, Left): {0}, {1}", Top, Left))
        End If

    End Sub

    Private Sub gcAnalysisRequest_MouseUp(sender As Object, e As MouseEventArgs) Handles gcXmatch.MouseUp
        'Setting Drag Analysis Request as false on MouseUp event prevents the form being moved when the user is not
        'holding the mouse down.
        DRAG_ANALYSIS_REQUEST = False
        log.Info("Setting Drag Analysis Request as false on MouseUp event prevents the form being moved when the user is not holding the mouse down.")
        log.Info("DRAG_ANALYSIS_REQUEST Boolean Value: " & DRAG_ANALYSIS_REQUEST.ToString)
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        log.Info("User Click: lblClose_Click")
        Close()
    End Sub

    Private Sub CheckSameGroup_MisMatch(sender As Object, e As EventArgs) Handles CheckSameGroup.CheckedChanged
        log.Info("sub CheckSameGroup_MisMatch: CheckSameGroup.CheckedChanged")

        'IF THE CHECK BOX IS UNCEHCKED, PROMPT A MESSAGE FOR VERIFICATION. IF VERIFIED MISMATCH THEN
        'ASSIGN THE PATIENT GROUP VARIABLES AND EMPTY THE COMBOs FOR DONOR GROUP ENTRY, & 
        'RENAME THEIR LABELS TO "Donor ABO" and "Rh(D)"....
        'TODO: . MAKE THE TEXT COLOUR RED AND BOLD.

        'CHANGING THE CHECKED STATE IN CODE FIRES THIS EVENT AGAIN. THIS IS TROUBLESOME AND NEEDS TO BE 
        'BYPASSED. 

        'NOTE: BYPASS SHOULD BE SET TO ONE EVERYTIME CheckSameGroup.CheckState IS TWEAKED IN CODE. 
        If BY_PASS = 1 Then
            BY_PASS = Nothing
            log.Info("ByPass Processing code present in CheckSameGroup_MisMatch.")
            GoTo ByPassProcessing :
        End If

        'CHEKING WHETHER PATIENT GROUP WAS ENTERED
        If not ComboPatientABO.SelectedIndex = -1 and Not ComboPatientRh.SelectedIndex = -1 And lblPatientABO.Text = "Patient ABO" Then
            log.Info(String.Format("Entered patient Group & Rh: {0} {1}", ComboPatientABO.text, ComboPatientRh.Text))

            'CHECKING THE STATE OF THE CHECK BOX AND PROCESSING USER RESPONSE TO GROUP MISMATCH QUERY
            If CheckSameGroup.CheckState = CheckState.Unchecked Then

                'VERIFYING GROUP MISMATCH

                log.Info("MessageBox: Is there a mismatch between donor and patient groups?")
                Dim UserResponseIsMismatch As Integer = MsgBox("Is there a mismatch between donor and patient groups?", vbYesNo + vbExclamation, "Verification")


                IF UserResponseIsMismatch = MsgBoxResult.Yes Then
                    log.Info("User Response: MsgBoxResult.Yes.")
                    'ASSIGN PATIENT GROUP AND Rh TO VARIABLES
                    'THEREBY EMPTYING THEM UP FOR DONOR GROUP ENTRY
                    log.Info(String.Format("ASSIGN PATIENT GROUP AND Rh TO VARIABLES;  PATIENT_ABO: {0}  PATIENT_Rh: {1}", PATIENT_ABO, PATIENT_Rh))  
                    PATIENT_ABO = ComboPatientABO.SelectedIndex
                    PATIENT_Rh = ComboPatientRh.SelectedIndex

                    'CLEAR THE COMBO BOXES
                    log.Info ("Clearing Group & Rh combo boxes.")
                    ComboPatientABO.SelectedIndex = -1
                    ComboPatientRh.SelectedIndex = -1

                    'RENAMING THE LABLES FOR DONOR GROUP ENTRY
                    lblPatientABO.Text = "Donor ABO"
                    log.Info("Changing lblPatientABO.Text to 'Donor ABO'.")
                    'DISPLAYING PATIENT_Rh AND PATIENT_ABO FOR USER CONVINIENCE
                    lblPatientGroupRhDisplay.Text = "Patient Group and Rh: " & ParseABORh(PATIENT_ABO, PATIENT_Rh)
                    log.Info("DISPLAYED PATIENT_Rh AND PATIENT_ABO FOR USER CONVINIENCE: " & ParseABORh(PATIENT_ABO, PATIENT_Rh))
                ElseIf UserResponseIsMismatch = MsgBoxResult.No then

                    log.Info("User Response: MsgBoxResult.Yes.")
                    'IF RESPONSE IS NO; THAT THE GROUPS DOES MATCH THEN MAKE THE CHECKBOX CHECKED AGAIN
                    BY_PASS = 1
                    CheckSameGroup.CheckState = CHECK_STATE_ROLLBACK_POINT
                    log.Info(String.Format("BY_PASS Changed to: {0}. CheckSameGroup.CheckState set to  CHECK_STATE_ROLLBACK_POINT({1})", BY_PASS, CHECK_STATE_ROLLBACK_POINT))
                End If

            End If

        ElseIf lblPatientABO.Text = "Donor ABO" Then
            log.Info(String.Format("Existing DonorABO(Group does not match with recipients ABO): {0} {1}", ComboPatientABO.Text, ComboPatientRh.Text))
            'IF USER WANTS TO CHANGE THE GROUP BACK TO THE OPTION OF DONOR HAVING THE SAME GROUP AS RECIPIENT.
            'THIS CODE GET EXECUTED. 
            Dim UserResponseIsMatch As Integer = MsgBox("Is the blood group of the donor and recipient same?", vbYesNo, vbExclamation)
            log.Info("Message Displayed: Is the blood group of the donor and recipient same?")
            If UserResponseIsMatch = MsgBoxResult.Yes Then
                log.Info("User response: " & "MsgBoxResult.Yes")
                'GETTING PATIENT_Rh AND PATIENT_ABO STORED PREVIOUSLY
                ComboPatientABO.SelectedIndex = PATIENT_ABO
                ComboPatientRh.SelectedIndex = PATIENT_Rh
                'RENAMING THE LABEL
                lblPatientABO.Text = "Patient ABO"
                'REMOVING THE PATIENT BLOOD GROUP AND Rh FROM  lblPatientGroupRhDisplay.Text
                lblPatientGroupRhDisplay.Text = ""

            Else
                log.Info("User response: " & "MsgBoxResult.No")
                BY_PASS = 1
                CheckSameGroup.CheckState = CHECK_STATE_ROLLBACK_POINT
                log.Info(String.Format("BY_PASS Changed to: {0}. CheckSameGroup.CheckState set to  CHECK_STATE_ROLLBACK_POINT({1})", BY_PASS, CHECK_STATE_ROLLBACK_POINT))

            End If

        Else

            BY_PASS = 1
            CheckSameGroup.CheckState = CHECK_STATE_ROLLBACK_POINT
            log.Info(String.Format("Either PatientABO/Patient Rh or both is not entered. PatientABO: {0} Patient Rh: {1}", ComboPatientABO.Text, ComboPatientRh.Text))
            log.Info(String.Format("BY_PASS Changed to: {0}. CheckSameGroup.CheckState set to  CHECK_STATE_ROLLBACK_POINT({1})", BY_PASS, CHECK_STATE_ROLLBACK_POINT))

            MsgBox("Please enter the Group and Rh of the recipient to proceed.")

            log.Info("Please enter the Group and Rh of the recipient to proceed.")
        End If

        ' MsgBox(ComboPatientABO.SelectedIndex & vbCrLf & ComboPatientRh.SelectedIndex)

ByPassProcessing:

    End Sub

    Private Sub IsFormEmpty()
        'TODO: CHECK WHETHER ALL OF THE DATA ENTRY BOXES ARE FIILLED, IF FILLED SET THE BOOLEAN NAMED "IS_FORM_EMPTY" AS FALSE

        log.Info("Sub called: IsFormEmpty()")
        'CHEKING TO SEE WHETHER THE ABO AND Rh FIELDS ARE FILLED TO ENABLE THE CHECK BOX.
        If Not ComboPatientABO.SelectedIndex = -1 And Not ComboPatientRh.SelectedIndex = -1
            'CheckSameGroup.Enabled = True
        Else
            'CheckSameGroup.Enabled = False
        End If
    End Sub


    Private Sub ComboPatientABO_LostFocus(sender As Object, e As EventArgs) Handles ComboPatientABO.LostFocus
        'ASKS THE SUB IsFormEmpty() TO CHECK WHETHER ALL/ANY FILEDS ARE FILLED.
        log.Info("Sub: ComboPatientABO_LostFocus")
        log.Info("Calling sub: IsFormEmpty()")
        IsFormEmpty()
    End Sub
    Function ParseABORh(byval ABOIndexCombo as Integer, ByVal RhIndexCombo As Integer)
        log.Info(String.Format("Sub Called: ParseABORh. Parameters ABOIndexCombo: {0}, RhIndexCombo: {1}", ABOIndexCombo, RhIndexCombo))
        'TODO: WRITE TESTS FOR THIS
        'TODO: REFACTORIZE: THIS SUB COULD BE SIMPLIFIED TO AN ENUM.
        Dim GroupAndRh as string = Nothing
        'A=0,  B=1,   AB=2,    O=3
        'POSITIVE =0, NEGATIVE = 1

        Select Case ABOIndexCombo
            Case 0
                GroupAndRh = "'A'"
            Case 1
                GroupAndRh = "'B'"
            Case 2
                GroupAndRh = "'AB'"
            Case 3
                GroupAndRh = "'O'"
        End Select

        Select Case RhIndexCombo
            Case 0
                GroupAndRh = GroupAndRh & " Rh(D) POSITIVE"
            Case 1
                GroupAndRh = GroupAndRh & " Rh(D) NEGATIVE"
        End Select
        Return GroupAndRh
        log.Info("Returning Parsed Blood Group & Rh: " & GroupAndRh)
    End Function

    Private Sub CheckSameGroup_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles CheckSameGroup.EditValueChanging
        log.Info("CheckSameGroup_EditValueChanging, THIS EVENT FIRES BEFORE CheckSameGroup.CheckState IS CHANGED.")
        'THIS EVENT FIRES BEFORE CheckSameGroup.CheckState IS CHANGED.
        log.Info("If BY_PASS is NOT EQUAL to 1, it would indicate that user checked/unchecked the checkbox CheckSameGroup. If so checkstate needs to be noted as a rollback point.")
        If Not BY_PASS = 1 Then
            CHECK_STATE_ROLLBACK_POINT = CheckSameGroup.CheckState
            log.Info(String.Format("BY_PASS = {0} AND CHECK_STATE_ROLLBACK_POINT{1}", BY_PASS, CHECK_STATE_ROLLBACK_POINT))
            ' MsgBox(CHECK_STATE_ROLLBACK_POINT)   THIS MESSAGE BOX IS FOR DEBUGGING PURPOSE
            Else
            log.Info(String.Format("BY_PASS = {0},  CheckSameGroup.EditValue changed in code. The code in Event: CheckSameGroup_MisMatch(...) Handles CheckSameGroup.CheckedChanged Needs to be skipped.", BY_PASS))
        End If
    End Sub

    Private Sub frmReportEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        log.Info("frmReportEntry_Load")

        lblPatientGroupRhDisplay.Text = ""
        txtDateTimeSelection.Text = Date.Today
        log.Info("Setting lblPatientGroupRhDisplay.Text as null and Selecting todays date for txtDateTimeSelection.Text")
        'CheckSameGroup.Enabled = False

        'AUTOMATIC "VALIDATING" EVENT IS RAISED ON LOST FOCUS EVENT OF A CONTROL. THIS FIELD REQUIRES VALIDATION ON "EDIT VALUE CHANGED" EVENT
        'SO, "CAUSE VALIDATION" IS DISABLED. VALIDATING EVENT IS RAISED MANUALLY BY CALLING txtDonorIDCardNoDoValidate()
        txtDonorIDCardNo.CausesValidation = False
        log.Info("Disabling automatic validating for ID card number with txtDonorIDCardNo.CausesValidation = False")

    End Sub

    Private Sub txtXMatchNo_LostFocus(sender As Object, e As EventArgs) Handles txtDonorXMatchNo.LostFocus

        'CANNOT SET A FORM NAME AS NULL, SO RULING OUT A POSSBILITY OF TRYING TO ASSIGN A NULL VALUE TO FORMS NAME PROPERTY.
        log.Info("CANNOT SET A FORM NAME AS NULL, SO RULING OUT A POSSBILITY OF TRYING TO ASSIGN A NULL VALUE TO FORMS NAME PROPERTY.")
        If Not txtDonorXMatchNo Is Nothing Then

            txtDonorXMatchNo.Text = txtDonorXMatchNo.Text.ToUpper
            log.Info("Upper casing ")
            If Not txtDonorXMatchNo.Text = "" Then
                gcXmatch.Text = "X-Match Record:  " & txtDonorXMatchNo.Text
                Me.Name = gcXmatch.Text
                log.Info(String.Format("Changing form name with respect to Xmatch Number. Form Name: {0}. Xmatch-Number: {1}.", Me.Name, txtDonorXMatchNo.Text))
            Else
                gcXmatch.Text = "X-Match"
            End If

            'THIS IS A SHARED BOOLEAN IN frmBloodBank. IF THIS IS TRUE THE TIMER TICK EVENT ON frmBloodBank WILL INVOKE THE SUB 
            'UpdateDockPanel_OpenRecords() WHICH WILL CHECK FOR OPEN CHILD FORMS AND UPDATE THE DISPLAY LIST OF OPEN RECORDS TO 
            'ENABLE USER TO BRING OPEN FORMS TO TOP IMMEDIATELY.
            log.Info("Setting InitDeltaChildren = True to so that the timer event will pick up the change in name of the child form and update it to dockpanel")
            InitDeltaChildren = True

        End If
    End Sub

    Private Sub txtDateTimeSelection_GotFocus(sender As Object, e As EventArgs) Handles txtDateTimeSelection.GotFocus
        log.Info("txtDateTimeSelection_GotFocus: Setting the edit mask to dd MM yyyy HH mm")
        txtDateTimeSelection.Properties.EditMask = "dd MM yyyy HH mm"
    End Sub

    Private Sub txtDateTimeSelection_LostFocus(sender As Object, e As EventArgs) Handles txtDateTimeSelection.LostFocus
        txtDateTimeSelection.Properties.mask.EditMask = "dd/MM/yyyy HH:mm"
        txtDateTimeSelection.Properties.mask.UseMaskAsDisplayFormat = True
        log.Info("txtDateTimeSelection_LostFocus: New edit mask: dd/MM/yyyy HH:mm, Use Display mask set to TRUE")
    End Sub

    Private Sub frmReportEntry_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'NEEDS TO UPDATE THE DISPLAYED LIST OF OPEN RECORDS.

        'THIS IS A SHARED BOOLEAN IN frmBloodBank. IF THIS IS TRUE THE TIMER TICK EVENT ON frmBloodBank WILL INVOKE THE SUB 
        'UpdateDockPanel_OpenRecords() WHICH WILL CHECK FOR OPEN CHILD FORMS AND UPDATE THE DISPLAY LIST OF OPEN RECORDS TO 
        'ENABLE USER TO BRING OPEN FORMS TO TOP IMMEDIATELY.
        log.Info("frmReportEntry_FormClosed: Settinng InitDeltaChildren = True to update the dock panel.")
        InitDeltaChildren = True
    End Sub

    Private Sub txtDonorIDCardNo_LostFocus(sender As Object, e As EventArgs) Handles txtDonorIDCardNo.LostFocus
        log.Info("txtDonorIDCardNo_LostFocus: Maually validating ID Card Number.")
        If Not txtDonorIDCardNo.Text = "" Then
            'National ID may be entered with a lower case "a". Eg: a309254 while it should be like "A309254"
            log.Info("txtDonorIDCardNo_LostFocus: Trimming the ID Card Number and making it Upper case.")
            txtDonorIDCardNo.Text = Trim(txtDonorIDCardNo.Text)
            txtDonorIDCardNo.Text = txtDonorIDCardNo.Text.ToUpper

            'VALIDATE National ID Card Number
            log.Info("Calling DoCalidate for ID Card Number.")
            txtDonorIDCardNo.DoValidate()

        End If
    End Sub

    Private Sub txtDonorIDCardNo_Validating(sender As Object, e As CancelEventArgs) Handles txtDonorIDCardNo.Validating
        'THIS EVENT IS RAISED WHEN  txtDonorIDCardNo.DoValidate() IS CALLED FROM CODE.


        Dim IsNIdValid As Boolean   'TO GET THE RETURN FROM FUNCTION VALIDATING NATIONAL ID CARD NUMBER.
        Dim ValidateID As New Validations 'INITIALISING VALIDATIONS CLASS
        log.Info("Initialised variables and Validations class for ID card Validation")
        IsNIdValid = ValidateID.ValidateNId(txtDonorIDCardNo.Text)    'PASSING ENTERED ID TO THE FUNCTION HANDLING NID VALIDATIONS.
        log.Info("Called ValidateID.ValidateNId to Validate ID Card Number and the method Returned: " & IsNIdValid)

        'USER FEEDBACK FOR INVALID IDCARD NUMBER ENTRIES IS GIVEN BY DISPLAYING A RED CROSS ICON WITH TOOLTIP 
        If IsNidValid = True Then
             txtDonorIDCardNo.ShowToolTips = False
            log.Info("Disabled helping tooltips for entering valid ID Card Number.")
        
        Else
             e.Cancel = True
             txtDonorIDCardNo.ShowToolTips = True                          'SETTING UP A TOOLTIP.
             txtDonorIDCardNo.ToolTipTitle = "Invalid ID Card Number"
             txtDonorIDCardNo.ToolTip = "Format: A012345 or BO01012345"
             txtDonorIDCardNo.Focus

            log.Info("Enabled helping tooltips for Valid ID Number. Tooltip: " & txtDonorIDCardNo.ToolTip)
        End If

    End Sub

    Private Sub txtDonorIDCardNo_Validated(sender As Object, e As EventArgs) Handles txtDonorIDCardNo.Validated
        'LOAD DONOR DETAILS ON ID CARD NUMBER VALIDATED EVENT.
        log.Info("txtDonorIDCardNo_Validated: Fetching donor details from validated ID CARD Number: " & txtDonorIDCardNo.Text)
        Dim DonorDetails(5) As String
        log.Info("Donor Details Array Initialised. Array length: " & DonorDetails.Length)

        Try
            'INSTANTIATING THE CLASS NEEDED FOR SERVER COMMUNICATONS AND 
            'FETCHING DETAILS BY PASSING ID CARD NUMBER TO QUERY THE SERVER WITH.

            Dim Coms As New Data.ServerCommunications
            log.Info("INSTANTIATED THE CLASS NEEDED FOR SERVER COMMUNICATONS AS Coms")
            DonorDetails = Coms.FetchRecord(eTasks.MsAccessFetchDonorRecord, txtDonorIDCardNo.Text, eVariousTypes.IdCardNo)
            log.Info(String.Format("Fetched Donor Details Record: |{0}|{1}|{2}|{3}|{4}|{5} ^^^1 = MALE  2 = FEMALE|", DonorDetails(0), DonorDetails(1), DonorDetails(2), DonorDetails(3), DonorDetails(4), DonorDetails(5)))
            'DISPLAYING QUERY RESULTS ON UI
            
            'NAME
            txtDonorName.Text = DonorDetails(2)
            log.Info("Displayed Donor Name: " & txtDonorName.Text)

            'AVOID PASSING A NULL STRING TO A DATE CALCUALTION INCASE DATABASE DOES NOT RETURN A RECORD.
            log.Info("AVOID PASSING A NULL STRING TO A DATE CALCUALTION INCASE DATABASE DOES NOT RETURN A RECORD.")
            If Not DonorDetails(4) = Nothing Then 
                'AGE : NEEDS TO BE CALCULATED FROM DOB
                log.Info("AGE : NEEDS TO BE CALCULATED FROM DOB: " & DonorDetails(4))
                Dim CalcAge As New Mathematics.PreSetCalculations
                txtDonorAge.Text = CalcAge.CalculateAge(DonorDetails(4))
                log.Info("Initialised class Mathematics.PreSetCalculations, Passed DOB. Calculated Age: " & txtDonorAge.Text)
                Else
                'TODO: MAKE SOME WAY TO COMPENSATE FOR DATA NOT BEING ON SERVER
                txtDonorAge.Text = DonorDetails(4)

            End If

            
            'GENDER
            log.Info("Setting ToggleDonorSex.IsOn as TRUE/FALSE depending on patient SEX")
            if DonorDetails(5) = 1 Then   '1 = MALE  2 = FEMALE
                ToggleDonorSex.IsOn = True
            ElseIf DonorDetails(5) = 2 then
                ToggleDonorSex.IsOn = False
            End If

            'ADDRESS
            txtDonorAddress.Text = DonorDetails(3)
            log.Info("Displayed donor Address: " & txtDonorAddress.Text)

            'TODO: FOR THIS TO WORK PROPERLY, DATAREADER ?HAS_ROWS PROPERTY HAS TO BE IMPLEMENTED IN SERVER COMMUNICATIONS CLASS.
            'AFTER THAT IF DONOR DATA FETCH WAS SUCCESSFUL THEN HOSPITAL NUMBER FIELD HAS TO BE FOCUSED. 
            txtRecipientHospitalNumber.Focus()
            log.Info("Setting focus for txtRecipientHospitalNumber")
        Catch ex As Exception
            log.Error(ex.Message, ex)
            MsgBox (ex.Message)
        End Try

    End Sub
    Private Sub txtRecipientHospitalNumber_Validated(sender As Object, e As EventArgs) Handles txtRecipientHospitalNumber.Validated
        log.Info("Sub: txtRecipientHospitalNumber_Validated")
        'LOAD RECIPIENT DETAILS ON HOSPITAL NUMBER VALIDATED EVENT.
        'CHECKING THAT USER ENTERED A VALUE FOR HOSPITAL NUMBER. I.E.., NOT LEFT BLANK
        log.Info("Hospital Number: " & txtRecipientHospitalNumber.Text)
        If Not txtRecipientHospitalNumber.Text = "" Then
            Dim RecipientDetails(5) As String
            log.Debug("Declared variable string array: RecipientDetails(5)")
            Try
                'INSTANTIATING THE CLASS NEEDED FOR SERVER COMMUNICATONS AND 
                'FETCHING DETAILS BY PASSING HOSPITAL NUMBER TO QUERY THE SERVER WITH.

                Dim Coms As New Data.ServerCommunications
                log.Info("Initialised Class: Data.ServerCommunications")
                RecipientDetails = Coms.FetchRecord(eTasks.MsAccessFetchRecipientRecord, txtRecipientHospitalNumber.Text, eVariousTypes.PatientNo)
                log.Info(String.Format("Fetched Recipient Details Record: |{0}|{1}|{2}|{3}|{4}|{5} ^^^1 = MALE  2 = FEMALE|", RecipientDetails(0), RecipientDetails(1), RecipientDetails(2), RecipientDetails(3), RecipientDetails(4), RecipientDetails(5)))
                'DISPLAYING QUERY RESULTS ON UI

                'NAME
                txtDDRecipientName.Text = RecipientDetails(2)
                log.Info("Displayed Recipien Name: " & RecipientDetails(2))

                'AVOID PASSING A NULL STRING TO A DATE CALCUALTION INCASE DATABASE DOES NOT RETURN A RECORD.
                If Not RecipientDetails(4) = Nothing Then
                    'AGE : NEEDS TO BE CALCULATED FROM DOB
                    log.Debug("DOB Field is not NULL")
                    Dim CalcAge As New Mathematics.PreSetCalculations
                    log.Info("Initialised Class: Mathematics.PreSetCalculations")
                    txtDDRecipientAge.Text = CalcAge.CalculateAge(RecipientDetails(4))
                    log.Info(String.Format("DOB Passed: {0}. Age Returned: {1}", RecipientDetails(4), txtDDRecipientAge.Text))
                Else
                    'TODO: MAKE SOME WAY TO COMPENSATE FOR DATA NOT BEING ON SERVER
                    txtDonorAge.Text = RecipientDetails(4)

                End If


                'GENDER
                log.Info("Setting ToggleDonorSex.IsOn as TRUE/FALSE depending on patient SEX")
                if RecipientDetails(5) = 1 Then   '1 = MALE  2 = FEMALE
                    ToggleDDRecipientSex.IsOn = True
                ElseIf RecipientDetails(5) = 2 then
                    ToggleDDRecipientSex.IsOn = False
                End If

                'ADDRESS
                txtDDRecipientAddress.Text = RecipientDetails(3)
                log.Info("Displayed Recipient Address: " & RecipientDetails(3))

            Catch ex As Exception
                log.Error(ex.Message, ex)
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub txtDonorName_LostFocus(sender As Object, e As EventArgs) Handles txtDonorName.LostFocus

        'MAKING USER INPUT CAPS.
        If Not txtDonorName.Text = Nothing Then
            txtDonorName.Text.ToUpper
            log.Info("Sub: txtDonorName_LostFocus. Donor name changed to upper case.")
        End If
    End Sub

    Private Sub txtDonorAddress_LostFocus(sender As Object, e As EventArgs) Handles txtDonorAddress.LostFocus
        'MAKING USER INPUT CAPS.
        If Not txtDonorAddress.Text = Nothing Then
            txtDonorAddress.Text.ToUpper
            log.Info("Sub: txtDonorAddress_LostFocus. Donor Address changed to upper case.")
        End If
    End Sub

    Private Sub txtDDRecipientName_LostFocus(sender As Object, e As EventArgs) Handles txtDDRecipientName.LostFocus
        'MAKING USER INPUT CASPS.
        If Not txtDDRecipientName.Text = Nothing Then
            txtDDRecipientName.Text.ToUpper
            log.Info("Sub: txtDDRecipientName_LostFocus. Recipient name changed to upper case.")
        End If
    End Sub

    Private Sub txtDDRecipientAddress_LostFocus(sender As Object, e As EventArgs) Handles txtDDRecipientAddress.LostFocus
        'MAKING USER INPUT CASPS.
        If Not txtDDRecipientAddress.Text = Nothing Then
            txtDDRecipientAddress.Text.ToUpper
            log.Info("Sub: txtDDRecipientAddress_LostFocus. Recipient Address changed to upper case.")
        End If
    End Sub

    Private Sub ComboPatientRh_LostFocus(sender As Object, e As EventArgs) Handles ComboPatientRh.LostFocus
        'ASKS THE SUB IsFormEmpty() TO CHECK WHETHER ALL/ANY FILEDS ARE FILLED.
        log.Info("Sub: ComboPatientRh_LostFocus. Calling SUB IsFormEmpty() TO CHECK WHETHER ALL/ANY FILEDS ARE FILLED.")
        IsFormEmpty()
    End Sub

    Private Sub sBtnAdd_Click(sender As Object, e As EventArgs) Handles sBtnAdd.Click
        'STEP 1: GET DATA
        'STEP 2: ADDING RECORDS TO THE GENERIC LIST xMatchedDonorUnits
        'STEP 3: REFRESHING GridViewBbkXmatch TO REFLECT THE CHANGES BROUGHT TO GENERIC LIST.
        log.Info("Sub: sBtnAdd_Click. Initialising variables.")
        'INITIALISING STEP 1: GET REQUIRED DATA
        Dim UnitGroup As String = Nothing
        Dim UnitRh As String = Nothing
        
        Dim UnitCompatibility As String = "COMPATIBLE" 
        'TODO: MAINTAIN \ BUILD UP A DATABASE OF UNITS IN BLOOD BANK. GET THE UNIT GROUP FROM THE DATABASE WHEN UNIT NUMBER ENTERED IS VALIDATED.
        'VERIFYIING DONOR GROUP.

        If CheckSameGroup.CheckState=CheckState.Checked
            log.Info("CheckSameGroup.CheckState changed to CheckState.Checked")
            log.Info("ASSIGNING RECIPIENT GROUP AS UNIT GROUP AS THEY ARE THE SAME.")
            'ASSIGNING RECIPIENT GROUP AS UNIT GROUP AS THEY ARE THE SAME.
            UnitGroup = ComboPatientABO.Text
            UnitRh = ComboPatientRh.Text

            log.Info(String.Format("Unit Group: {0}. Unit Rh: {1}", UnitGroup, UnitRh))
        ElseIf CheckSameGroup.CheckState=CheckState.Unchecked
            log.Info("CheckSameGroup.CheckState changed to CheckState.Unchecked.")
            'STILL THE SAME SINCE DONOR GROUP/UNIT GROUP WILL BE ON THE SAME FIELDS EVEN IF THE GROUPS DOES NOT MATCH.
            UnitGroup = ComboPatientABO.Text
            UnitRh = ComboPatientRh.Text

            log.Info(String.Format("Unit Group: {0}. Unit Rh: {1}", UnitGroup, UnitRh))
        End If

        'STEP 2: POPULATE GENERIC LIST
        log.Info("POPULATING GENERIC LIST")
        xMatchedDonorUnits.Add(New DonorUnits(txtBbkXmatchNo.Text,txtBbkUnitNo.Text,UnitGroup,UnitRh,UnitCompatibility,ComboComponentBbk.Text))
        log.Info(String.Format("BBK Unit/Donor Bled Unit Record: |{0}|{1}|{2}|{3}|{4}|{5}", txtBbkXmatchNo.Text, txtBbkUnitNo.Text, UnitGroup, UnitRh, UnitCompatibility, ComboComponentBbk.Text))
        'STEP 3: REFRESH GRID CONTROL
        log.Info("UPDATING CHANGES TO USER: REFRESHING GRID CONTROL")
        GridControlBbkXmatch.DataSource = Nothing
        GridControlBbkXmatch.DataSource = xMatchedDonorUnits
        
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        log.Info("Sub: btnSavePrint_Click")

        'Todo: Check whether all required fields are filled.
        'Determine PintType based on the SelectedTabPageIndex
        If XtraTabControlPreviewAndPrintAnalysisRequest.SelectedTabPage.Name = "XtraTabDonor" Then

            Select CheckDonorBled.Checked
                Case True
                    'Report will be as a BBK pint since donor is already bled.
                    SavePrintCompatabilityReport(PintType.BloodBank)
                    'MsgBox("True")
                Case False
                    'This is a donor Pint
                    SavePrintCompatabilityReport(PintType.Donor)
                    'MsgBox ("False")
            End Select


        ElseIf XtraTabControlPreviewAndPrintAnalysisRequest.SelectedTabPage.Name = "XtraTabBloodBank" then
            'This is a BloodBank Pint
            SavePrintCompatabilityReport(PintType.BloodBank)

        End If

    End Sub

    Private Sub SavePrintCompatabilityReport(ReportType As PintType)
        'STEPS TO GO: 
        '   SAVE THE REPORT TO DISK
        '   SAVE THE REPORT AS PDF
        '   LOAD DETAILS FROM DISK :: OPTIONAL
        '   PRINT THE REPORT

        'MsgBox (ReportType.ToString)
        Select Case ReportType
            Case PintType.BloodBank
                'Instantating and initialising Report
            Case PintType.Donor
                'Determine Sex of Donor and Receipient
                Dim DonorGender As String = ""
                Dim RecipientGender As String = ""

                If ToggleDDRecipientSex.IsOn = True Then
                    RecipientGender = "Male"
                Elseif ToggleDDRecipientSex.IsOn = False then
                    RecipientGender = "Female"
                End If

                If ToggleDonorSex.IsOn = True Then
                    DonorGender = "Male"
                ElseIf ToggleDonorSex.IsOn = False then
                    DonorGender = "Female"
                End If

                'Instantating and initialising Report
                Dim DonorReport As ReportDonor = New ReportDonor()
                With DonorReport
                    '                    .Parameters("PatientData").Value = PATIENT_DATA
                    .Parameters("ABOPatient").Value = ComboPatientABO.Text
                    .Parameters("Rh").Value = ComboPatientRh.Text
                    .Parameters("AddressDonor").Value = txtDonorAddress.Text
                    .Parameters("AddressPatient").Value = txtDDRecipientAddress.Text
                    .Parameters("AgeGenderDonor").Value = String.Format("{0} / {1}", txtDonorAge.Text, DonorGender)
                    .Parameters("AgeGenderPatient").Value = String.Format("{0} / {1}", txtDDRecipientAge.Text, RecipientGender)
                    .Parameters("Component").Value = ComboDonorComponent.Text
                    'TODO: Report maybe printed on a later date. This would introduce errors in that case. Correct this.
                    .Parameters("DateXmatch").value = DateTime.Today().ToString("dd/MM/yyyy").ToString
                    .Parameters("HospitalNumber").Value = txtRecipientHospitalNumber.Text
                    .Parameters("NameDonor").Value = txtDonorName.Text
                    .Parameters("NidCardNumber").Value = txtDonorIDCardNo.Text
                    .Parameters("PatientName").Value = txtDDRecipientName.Text

                    'TODO: This will be recorded on report save time with all the fields completed.
                    .Parameters("ReportedDate").Value = DateTime.Now().ToString("dd/MM/yyyy HH:mm:ss").ToString
                    .Parameters("SampleCollectedAt").Value = txtDateTimeSelection.Text
                    .Parameters("WardBedNo").Value = txtWardBedNo.Text
                    .Parameters("XMatchNumber").Value = txtDonorXMatchNo.Text

                End With


                'Disabling manual feedng of parameters
                DonorReport.RequestParameters = False
                'Naming the exported report.

                'SPECIFYING A NON EXISTANT DIR/PRINTER IN CONFIG WILL THROW AN ERROR
                Try
                    DonorReport.ExportToPdf(String.Format("{0}{1} {2} P{3}.PDF", My.Settings.ReportExportBasePath, txtDonorXMatchNo.Text, txtDDRecipientName.Text, txtRecipientHospitalNumber.Text))

                    'Instantitating SwatIncNotifications.frmNotification
                    Dim NotifyUser As New frmNotification
                    NotifyUser.ShowNotification("Report exported as PDF", "Save Successful!", "LanTech", "Blood Bank")
                    'Print report
                    Dim AutoPrint As New ReportPrintTool(DonorReport)
                    'TODO: Set up print options. Detecting printers and all.
                    AutoPrint.Print(My.Settings.ReportPrinterName)

                    'Instantitating SwatIncNotifications.frmNotification
                    Dim NotifyUser1 As New frmNotification  'CONFIG FILE CANNOT HANDLE READ WRITE A THE SPEED TO DISPLAY TO MESSAGES CONSEQUENTLY
                    NotifyUser1.ShowNotification(String.Format("The Report has been sent to the printer{0}Printer: {1}", vbCrLf, My.Settings.ReportPrinterName), "Report Print!", "LanTech", "Blood Bank")

                Catch ex As Exception
                    'Instantitating SwatIncNotifications.frmNotification
                    Dim NotifyUser As New frmNotification
                    NotifyUser.ShowNotification(ex.Message, "Error", "LanTech", "Blood Bank")

                End Try

        End Select

    End Sub
End Class