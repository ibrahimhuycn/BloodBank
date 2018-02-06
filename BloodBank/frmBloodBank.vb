Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins

'Watch the app.config for changes in log4Net configuration. So that logging behaviour uptodate
<Assembly: log4net.Config.XmlConfigurator(Watch:=True)>

Public Class frmBloodBank
    'Initialising log4net logger for this class and getting class name from reflection
    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    Public Shared InitDeltaChildren As Boolean = False

    Public AlreadyActiveNotificationsMonitor As Integer = 0 'VARIABLE FOR DETERMING NUMBER OF ACTIVE NOFIFICATION WINDOWS ON
    'SCREEN. THIS IS TO ADJUST VERTICAL POSITION OF THE NOTIFICATIONS SO THAT ALL CAN BE SEEN ON SCREEN.
    Public IsRelocateNofitication As Boolean = False 'DETERMINES WHETHER NOTIFICATION NEEDS TO BE RELOCATED FROM DEFAULT POSITION.

    Sub New()

        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
        log.Info("Sub New: Initialising")

    End Sub
    Sub InitSkins()
        SkinManager.EnableFormSkins()
        BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
        log.Info("Sub: Initialising skins")

    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
        log.Info("Sub: Initialising ribbon gallery")
    End Sub

    Public Sub iNew_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iNew.ItemClick
        log.Info("User Click: iNew_ItemClick")

        'OPENING FRMREPORTENTRY AS A CHILD FORM OF FRMBLOODBANK.
        Dim bbkreportentry As New frmReportEntry() With {.MdiParent = Me, .Name = "X-Match"}
        log.Info("frmReportEntry instantiated as bbkreportentry")

        bbkreportentry.Show()
        log.Info("bbkreportentry displayed to user")

        bbkreportentry.txtDonorXMatchNo.Focus()
        log.Info("txtDonorXMatchNo is focused")

        'UPDATE TREEVIEW TO ALLOW TO ENABLE NAVIGATION.
        log.Info("Calling: UpdateDockPanel_OpenRecords to update tree view in dock panel names of open forms.")
        UpdateDockPanel_OpenRecords()

    End Sub

    Protected Overrides Sub Finalize()
        log.Info("Finalising Class before ?dispose. MyBase.Finalize")
        MyBase.Finalize()
    End Sub

    Public Sub UpdateDockPanel_OpenRecords()
        'THIS SUB UPDATES THE TREEVIEW WITH THE NAMES OF OPEN CHILD FORMS TO ENABLE EASY NAVIGATION BETWEEN FORMS.

        'STEP 1: CLEAR ALL NODES IN TREE VIEW.
        TreeViewXMatchRecords.Nodes.Clear()
        log.Info("UpdateDockPanel_OpenRecords: Cleared all nodes in tree view")
        'STEP 2: LOOP THROUGH ALL OPEN CHILD FORMS AND ADD THEIR NAMES TO TREE VIEW AS NAMES.
        For Each frm As Form In Me.MdiChildren

            TreeViewXMatchRecords.Nodes.Add(frm.Name.ToString)
            log.Info(String.Format("UpdateDockPanel_OpenRecords: Looping to get open child form names. Child Form Name: {0}", frm.Name))
        Next
    End Sub

    Private Sub MonitorOpenRecords_Tick(sender As Object, e As EventArgs) Handles MonitorOpenRecords.Tick
        'UPDATES TREE VIEW WITH NAMES OF OPEN CHILD FORMS.
        'THE BOOLEAN SHARED PUBLIC VARIABLE InitDeltaChildren MUST BE SET TO TRUE EACH TIME A NEW CHILD IS CREATED OR CLOSED.

        If InitDeltaChildren = True Then
            log.Info("MonitorOpenRecords_Tick: UPDATES TREE VIEW WITH NAMES OF OPEN CHILD FORMS. THE BOOLEAN SHARED PUBLIC VARIABLE InitDeltaChildren MUST BE SET TO TRUE EACH TIME A NEW CHILD IS CREATED OR CLOSED.")
            log.Info(String.Format("InitDeltaChildren boolean value: {0}. Calling UpdateDockPanel_OpenRecords()", InitDeltaChildren.ToString))
            UpdateDockPanel_OpenRecords()
            InitDeltaChildren = False
            log.Info("InitDeltaChildren Set to False")

        Else
            log.Debug(String.Format("MonitorOpenRecords_Tick: InitDeltaChildren Value: {0}. MonitorOpenRecords Timer Interval: {1}.", InitDeltaChildren, MonitorOpenRecords.Interval))

        End If
    End Sub
    Private Sub TreeViewXMatchRecords_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeViewXMatchRecords.NodeMouseClick

        'THIS SUB BRINGS CHILD FORMS TO THE FRONT WHEN USER CLICKS THE CHILD FORM NAMES ON THE TREE VIEW LIST
        log.Info("TreeViewXMatchRecords_NodeMouseClick: THIS SUB BRINGS CHILD FORMS TO THE FRONT WHEN USER CLICKS THE CHILD FORM NAMES ON THE TREE VIEW LIST")
        Dim RequiredTopMost As String = e.Node.Text
        log.Info("User Clicked Node text: " & e.Node.Text)
        For Each frm As Form In Me.MdiChildren
            If frm.Name = RequiredTopMost Then
                frm.BringToFront()
                log.Info(String.Format("Form brought to front: {0}. Exiting for Loop.", frm.Name))
                Exit For
            End If
        Next
    End Sub

    Private Sub iExit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iExit.ItemClick
        log.Info("User Clicked Exit Button")
        Application.Exit
        Environment.Exit(0)
        
    End Sub
End Class
