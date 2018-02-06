
Imports DevExpress.XtraGrid
Partial Class frmReportEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gcXmatch = New DevExpress.XtraEditors.GroupControl()
        Me.btnSavePrint = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorCommonData = New DevExpress.XtraEditors.SeparatorControl()
        Me.picRegister = New DevExpress.XtraEditors.PictureEdit()
        Me.lblClose = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControlPreviewAndPrintAnalysisRequest = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabDonor = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblXMatchInfo = New DevExpress.XtraEditors.LabelControl()
        Me.CheckDonorBled = New DevExpress.XtraEditors.CheckEdit()
        Me.lblLastDonationDate = New DevExpress.XtraEditors.LabelControl()
        Me.txtDDRecipientAddress = New DevExpress.XtraEditors.TextEdit()
        Me.ToggleDDRecipientSex = New DevExpress.XtraEditors.ToggleSwitch()
        Me.txtDDRecipientAge = New DevExpress.XtraEditors.TextEdit()
        Me.txtDDRecipientName = New DevExpress.XtraEditors.TextEdit()
        Me.lblDDRecipientAddress = New DevExpress.XtraEditors.LabelControl()
        Me.lblDDRecipientAge = New DevExpress.XtraEditors.LabelControl()
        Me.lblDDRecipientName = New DevExpress.XtraEditors.LabelControl()
        Me.ComboDonorComponent = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDonorAddress = New DevExpress.XtraEditors.TextEdit()
        Me.ToggleDonorSex = New DevExpress.XtraEditors.ToggleSwitch()
        Me.lblDDComponent = New DevExpress.XtraEditors.LabelControl()
        Me.txtDonorAge = New DevExpress.XtraEditors.TextEdit()
        Me.txtDonorName = New DevExpress.XtraEditors.TextEdit()
        Me.lblDonorTabDescription = New DevExpress.XtraEditors.LabelControl()
        Me.lblDAddress = New DevExpress.XtraEditors.LabelControl()
        Me.lblDAgeSex = New DevExpress.XtraEditors.LabelControl()
        Me.lblDName = New DevExpress.XtraEditors.LabelControl()
        Me.lblDateToday = New DevExpress.XtraEditors.LabelControl()
        Me.txtDonorXMatchNo = New DevExpress.XtraEditors.TextEdit()
        Me.lblDDXMatchNo = New DevExpress.XtraEditors.LabelControl()
        Me.lblXmatchNoBbk = New DevExpress.XtraEditors.LabelControl()
        Me.lblHeadingRecipient = New DevExpress.XtraEditors.LabelControl()
        Me.XmatchIcon = New DevExpress.XtraEditors.PictureEdit()
        Me.SaperatorUserEnteredvsServerloaded = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblDonorIDCardNo = New DevExpress.XtraEditors.LabelControl()
        Me.txtDonorIDCardNo = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabBloodBank = New DevExpress.XtraTab.XtraTabPage()
        Me.lblBbkTabDescription = New DevExpress.XtraEditors.LabelControl()
        Me.sBtnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.sBtnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControlBbkXmatch = New DevExpress.XtraGrid.GridControl()
        Me.GridViewBbkXmatch = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBbkUnitNo = New DevExpress.XtraEditors.TextEdit()
        Me.lblBbkUnitNo = New DevExpress.XtraEditors.LabelControl()
        Me.ComboComponentBbk = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblBbkComponent = New DevExpress.XtraEditors.LabelControl()
        Me.txtBbkXmatchNo = New DevExpress.XtraEditors.TextEdit()
        Me.lblBbkXmatchNo = New DevExpress.XtraEditors.LabelControl()
        Me.picBbk = New DevExpress.XtraEditors.PictureEdit()
        Me.lblWardBed = New DevExpress.XtraEditors.LabelControl()
        Me.lblXmatchDescription = New DevExpress.XtraEditors.LabelControl()
        Me.txtWardBedNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtDateTimeSelection = New DevExpress.XtraEditors.DateEdit()
        Me.lblSampleCollectionDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblPatientGroupRhDisplay = New DevExpress.XtraEditors.LabelControl()
        Me.txtRecipientHospitalNumber = New DevExpress.XtraEditors.TextEdit()
        Me.CheckSameGroup = New DevExpress.XtraEditors.CheckEdit()
        Me.lblPatientHospitalNumber = New DevExpress.XtraEditors.LabelControl()
        Me.lblPatientRh = New DevExpress.XtraEditors.LabelControl()
        Me.lblPatientABO = New DevExpress.XtraEditors.LabelControl()
        Me.ComboPatientRh = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboPatientABO = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.gcXmatch,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gcXmatch.SuspendLayout
        CType(Me.SeparatorCommonData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picRegister.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XtraTabControlPreviewAndPrintAnalysisRequest,System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.SuspendLayout
        Me.XtraTabDonor.SuspendLayout
        CType(Me.CheckDonorBled.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDDRecipientAddress.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ToggleDDRecipientSex.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDDRecipientAge.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDDRecipientName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboDonorComponent.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDonorAddress.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ToggleDonorSex.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDonorAge.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDonorName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDonorXMatchNo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XmatchIcon.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SaperatorUserEnteredvsServerloaded,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDonorIDCardNo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.XtraTabBloodBank.SuspendLayout
        CType(Me.GridControlBbkXmatch,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridViewBbkXmatch,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBbkUnitNo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboComponentBbk.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBbkXmatchNo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picBbk.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWardBedNo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDateTimeSelection.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDateTimeSelection.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRecipientHospitalNumber.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CheckSameGroup.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboPatientRh.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboPatientABO.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'gcXmatch
        '
        Me.gcXmatch.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gcXmatch.Appearance.Options.UseFont = true
        Me.gcXmatch.AppearanceCaption.Font = New System.Drawing.Font("Cambria", 9!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gcXmatch.AppearanceCaption.Options.UseFont = true
        Me.gcXmatch.AutoSize = true
        Me.gcXmatch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gcXmatch.Controls.Add(Me.btnSavePrint)
        Me.gcXmatch.Controls.Add(Me.SeparatorCommonData)
        Me.gcXmatch.Controls.Add(Me.picRegister)
        Me.gcXmatch.Controls.Add(Me.lblClose)
        Me.gcXmatch.Controls.Add(Me.XtraTabControlPreviewAndPrintAnalysisRequest)
        Me.gcXmatch.Controls.Add(Me.lblWardBed)
        Me.gcXmatch.Controls.Add(Me.lblXmatchDescription)
        Me.gcXmatch.Controls.Add(Me.txtWardBedNo)
        Me.gcXmatch.Controls.Add(Me.txtDateTimeSelection)
        Me.gcXmatch.Controls.Add(Me.lblSampleCollectionDate)
        Me.gcXmatch.Controls.Add(Me.lblPatientGroupRhDisplay)
        Me.gcXmatch.Controls.Add(Me.txtRecipientHospitalNumber)
        Me.gcXmatch.Controls.Add(Me.CheckSameGroup)
        Me.gcXmatch.Controls.Add(Me.lblPatientHospitalNumber)
        Me.gcXmatch.Controls.Add(Me.lblPatientRh)
        Me.gcXmatch.Controls.Add(Me.lblPatientABO)
        Me.gcXmatch.Controls.Add(Me.ComboPatientRh)
        Me.gcXmatch.Controls.Add(Me.ComboPatientABO)
        Me.gcXmatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcXmatch.Location = New System.Drawing.Point(0, 0)
        Me.gcXmatch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcXmatch.Name = "gcXmatch"
        Me.gcXmatch.Size = New System.Drawing.Size(829, 444)
        Me.gcXmatch.TabIndex = 1
        Me.gcXmatch.Text = "X-Match"
        '
        'btnSavePrint
        '
        Me.btnSavePrint.Location = New System.Drawing.Point(364, 140)
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(75, 23)
        Me.btnSavePrint.TabIndex = 28
        Me.btnSavePrint.Text = "Save | Print"
        '
        'SeparatorCommonData
        '
        Me.SeparatorCommonData.AutoSizeMode = true
        Me.SeparatorCommonData.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorCommonData.Location = New System.Drawing.Point(338, 53)
        Me.SeparatorCommonData.Name = "SeparatorCommonData"
        Me.SeparatorCommonData.Size = New System.Drawing.Size(20, 132)
        Me.SeparatorCommonData.TabIndex = 27
        Me.SeparatorCommonData.TabStop = false
        '
        'picRegister
        '
        Me.picRegister.Cursor = System.Windows.Forms.Cursors.Default
        Me.picRegister.EditValue = Global.BloodBank.My.Resources.Resources.note_edit_icon
        Me.picRegister.Location = New System.Drawing.Point(16, 24)
        Me.picRegister.Name = "picRegister"
        Me.picRegister.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picRegister.Properties.Appearance.Options.UseBackColor = true
        Me.picRegister.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picRegister.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.picRegister.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picRegister.Properties.ZoomAccelerationFactor = 1R
        Me.picRegister.Size = New System.Drawing.Size(92, 95)
        Me.picRegister.TabIndex = 21
        '
        'lblClose
        '
        Me.lblClose.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblClose.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblClose.Appearance.Options.UseBackColor = true
        Me.lblClose.Appearance.Options.UseFont = true
        Me.lblClose.Appearance.Options.UseForeColor = true
        Me.lblClose.AppearanceDisabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearanceDisabled.Options.UseFont = true
        Me.lblClose.AppearanceHovered.BackColor = System.Drawing.Color.Thistle
        Me.lblClose.AppearanceHovered.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearanceHovered.Options.UseBackColor = true
        Me.lblClose.AppearanceHovered.Options.UseFont = true
        Me.lblClose.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClose.AppearancePressed.Options.UseFont = true
        Me.lblClose.Location = New System.Drawing.Point(832, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(16, 13)
        Me.lblClose.TabIndex = 17
        Me.lblClose.Text = " X "
        '
        'XtraTabControlPreviewAndPrintAnalysisRequest
        '
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Appearance.Options.UseFont = true
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.Header.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.Header.Options.UseFont = true
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderActive.Options.UseFont = true
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderDisabled.Options.UseFont = true
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.HeaderHotTracked.Options.UseFont = true
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.PageClient.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.AppearancePage.PageClient.Options.UseFont = true
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Location = New System.Drawing.Point(2, 178)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Name = "XtraTabControlPreviewAndPrintAnalysisRequest"
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.SelectedTabPage = Me.XtraTabDonor
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.Size = New System.Drawing.Size(825, 264)
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.TabIndex = 1
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabDonor, Me.XtraTabBloodBank})
        '
        'XtraTabDonor
        '
        Me.XtraTabDonor.Controls.Add(Me.LabelControl2)
        Me.XtraTabDonor.Controls.Add(Me.LabelControl1)
        Me.XtraTabDonor.Controls.Add(Me.lblXMatchInfo)
        Me.XtraTabDonor.Controls.Add(Me.CheckDonorBled)
        Me.XtraTabDonor.Controls.Add(Me.lblLastDonationDate)
        Me.XtraTabDonor.Controls.Add(Me.txtDDRecipientAddress)
        Me.XtraTabDonor.Controls.Add(Me.ToggleDDRecipientSex)
        Me.XtraTabDonor.Controls.Add(Me.txtDDRecipientAge)
        Me.XtraTabDonor.Controls.Add(Me.txtDDRecipientName)
        Me.XtraTabDonor.Controls.Add(Me.lblDDRecipientAddress)
        Me.XtraTabDonor.Controls.Add(Me.lblDDRecipientAge)
        Me.XtraTabDonor.Controls.Add(Me.lblDDRecipientName)
        Me.XtraTabDonor.Controls.Add(Me.ComboDonorComponent)
        Me.XtraTabDonor.Controls.Add(Me.txtDonorAddress)
        Me.XtraTabDonor.Controls.Add(Me.ToggleDonorSex)
        Me.XtraTabDonor.Controls.Add(Me.lblDDComponent)
        Me.XtraTabDonor.Controls.Add(Me.txtDonorAge)
        Me.XtraTabDonor.Controls.Add(Me.txtDonorName)
        Me.XtraTabDonor.Controls.Add(Me.lblDonorTabDescription)
        Me.XtraTabDonor.Controls.Add(Me.lblDAddress)
        Me.XtraTabDonor.Controls.Add(Me.lblDAgeSex)
        Me.XtraTabDonor.Controls.Add(Me.lblDName)
        Me.XtraTabDonor.Controls.Add(Me.lblDateToday)
        Me.XtraTabDonor.Controls.Add(Me.txtDonorXMatchNo)
        Me.XtraTabDonor.Controls.Add(Me.lblDDXMatchNo)
        Me.XtraTabDonor.Controls.Add(Me.lblXmatchNoBbk)
        Me.XtraTabDonor.Controls.Add(Me.lblHeadingRecipient)
        Me.XtraTabDonor.Controls.Add(Me.XmatchIcon)
        Me.XtraTabDonor.Controls.Add(Me.SaperatorUserEnteredvsServerloaded)
        Me.XtraTabDonor.Controls.Add(Me.lblDonorIDCardNo)
        Me.XtraTabDonor.Controls.Add(Me.txtDonorIDCardNo)
        Me.XtraTabDonor.Name = "XtraTabDonor"
        Me.XtraTabDonor.Size = New System.Drawing.Size(819, 237)
        Me.XtraTabDonor.Text = "Dono&r"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl2.Appearance.Options.UseFont = true
        Me.LabelControl2.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.LabelControl2.AppearanceDisabled.Options.UseFont = true
        Me.LabelControl2.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.LabelControl2.AppearanceHovered.Options.UseFont = true
        Me.LabelControl2.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.LabelControl2.AppearancePressed.Options.UseFont = true
        Me.LabelControl2.Location = New System.Drawing.Point(709, 174)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(98, 12)
        Me.LabelControl2.TabIndex = 43
        Me.LabelControl2.Text = "DOB on manual input"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.LabelControl1.AppearanceDisabled.Options.UseFont = true
        Me.LabelControl1.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.LabelControl1.AppearanceHovered.Options.UseFont = true
        Me.LabelControl1.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.LabelControl1.AppearancePressed.Options.UseFont = true
        Me.LabelControl1.Location = New System.Drawing.Point(291, 177)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 12)
        Me.LabelControl1.TabIndex = 42
        Me.LabelControl1.Text = "DOB on manual input"
        '
        'lblXMatchInfo
        '
        Me.lblXMatchInfo.Appearance.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblXMatchInfo.Appearance.Options.UseFont = true
        Me.lblXMatchInfo.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Underline)
        Me.lblXMatchInfo.AppearanceDisabled.Options.UseFont = true
        Me.lblXMatchInfo.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Underline)
        Me.lblXMatchInfo.AppearanceHovered.Options.UseFont = true
        Me.lblXMatchInfo.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblXMatchInfo.AppearancePressed.Options.UseFont = true
        Me.lblXMatchInfo.Location = New System.Drawing.Point(436, 22)
        Me.lblXMatchInfo.Name = "lblXMatchInfo"
        Me.lblXMatchInfo.Size = New System.Drawing.Size(67, 14)
        Me.lblXMatchInfo.TabIndex = 41
        Me.lblXMatchInfo.Text = "X-Match Info"
        '
        'CheckDonorBled
        '
        Me.CheckDonorBled.Location = New System.Drawing.Point(227, 83)
        Me.CheckDonorBled.Name = "CheckDonorBled"
        Me.CheckDonorBled.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckDonorBled.Properties.Appearance.Options.UseFont = true
        Me.CheckDonorBled.Properties.Caption = "Donor Bled"
        Me.CheckDonorBled.Size = New System.Drawing.Size(102, 19)
        Me.CheckDonorBled.TabIndex = 28
        Me.CheckDonorBled.TabStop = false
        '
        'lblLastDonationDate
        '
        Me.lblLastDonationDate.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLastDonationDate.Appearance.Options.UseFont = true
        Me.lblLastDonationDate.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblLastDonationDate.AppearanceDisabled.Options.UseFont = true
        Me.lblLastDonationDate.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblLastDonationDate.AppearanceHovered.Options.UseFont = true
        Me.lblLastDonationDate.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblLastDonationDate.AppearancePressed.Options.UseFont = true
        Me.lblLastDonationDate.Location = New System.Drawing.Point(111, 104)
        Me.lblLastDonationDate.Name = "lblLastDonationDate"
        Me.lblLastDonationDate.Size = New System.Drawing.Size(93, 12)
        Me.lblLastDonationDate.TabIndex = 40
        Me.lblLastDonationDate.Text = "Last Donation Date: "
        '
        'txtDDRecipientAddress
        '
        Me.txtDDRecipientAddress.EnterMoveNextControl = true
        Me.txtDDRecipientAddress.Location = New System.Drawing.Point(493, 198)
        Me.txtDDRecipientAddress.Name = "txtDDRecipientAddress"
        Me.txtDDRecipientAddress.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtDDRecipientAddress.Properties.Appearance.Options.UseFont = true
        Me.txtDDRecipientAddress.Size = New System.Drawing.Size(314, 18)
        Me.txtDDRecipientAddress.TabIndex = 36
        Me.txtDDRecipientAddress.TabStop = false
        '
        'ToggleDDRecipientSex
        '
        Me.ToggleDDRecipientSex.Location = New System.Drawing.Point(586, 168)
        Me.ToggleDDRecipientSex.Name = "ToggleDDRecipientSex"
        Me.ToggleDDRecipientSex.Properties.OffText = "Female"
        Me.ToggleDDRecipientSex.Properties.OnText = "Male"
        Me.ToggleDDRecipientSex.Size = New System.Drawing.Size(130, 24)
        Me.ToggleDDRecipientSex.TabIndex = 35
        Me.ToggleDDRecipientSex.TabStop = false
        '
        'txtDDRecipientAge
        '
        Me.txtDDRecipientAge.EnterMoveNextControl = true
        Me.txtDDRecipientAge.Location = New System.Drawing.Point(493, 171)
        Me.txtDDRecipientAge.Name = "txtDDRecipientAge"
        Me.txtDDRecipientAge.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtDDRecipientAge.Properties.Appearance.Options.UseFont = true
        Me.txtDDRecipientAge.Size = New System.Drawing.Size(79, 18)
        Me.txtDDRecipientAge.TabIndex = 34
        Me.txtDDRecipientAge.TabStop = false
        '
        'txtDDRecipientName
        '
        Me.txtDDRecipientName.EnterMoveNextControl = true
        Me.txtDDRecipientName.Location = New System.Drawing.Point(493, 147)
        Me.txtDDRecipientName.Name = "txtDDRecipientName"
        Me.txtDDRecipientName.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtDDRecipientName.Properties.Appearance.Options.UseFont = true
        Me.txtDDRecipientName.Size = New System.Drawing.Size(314, 18)
        Me.txtDDRecipientName.TabIndex = 33
        Me.txtDDRecipientName.TabStop = false
        '
        'lblDDRecipientAddress
        '
        Me.lblDDRecipientAddress.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDDRecipientAddress.Appearance.Options.UseFont = true
        Me.lblDDRecipientAddress.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDRecipientAddress.AppearanceDisabled.Options.UseFont = true
        Me.lblDDRecipientAddress.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDRecipientAddress.AppearanceHovered.Options.UseFont = true
        Me.lblDDRecipientAddress.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDRecipientAddress.AppearancePressed.Options.UseFont = true
        Me.lblDDRecipientAddress.Location = New System.Drawing.Point(441, 201)
        Me.lblDDRecipientAddress.Name = "lblDDRecipientAddress"
        Me.lblDDRecipientAddress.Size = New System.Drawing.Size(44, 12)
        Me.lblDDRecipientAddress.TabIndex = 39
        Me.lblDDRecipientAddress.Text = "Address: "
        '
        'lblDDRecipientAge
        '
        Me.lblDDRecipientAge.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDDRecipientAge.Appearance.Options.UseFont = true
        Me.lblDDRecipientAge.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDRecipientAge.AppearanceDisabled.Options.UseFont = true
        Me.lblDDRecipientAge.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDRecipientAge.AppearanceHovered.Options.UseFont = true
        Me.lblDDRecipientAge.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDRecipientAge.AppearancePressed.Options.UseFont = true
        Me.lblDDRecipientAge.Location = New System.Drawing.Point(441, 174)
        Me.lblDDRecipientAge.Name = "lblDDRecipientAge"
        Me.lblDDRecipientAge.Size = New System.Drawing.Size(46, 12)
        Me.lblDDRecipientAge.TabIndex = 38
        Me.lblDDRecipientAge.Text = "Age / Sex: "
        '
        'lblDDRecipientName
        '
        Me.lblDDRecipientName.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDDRecipientName.Appearance.Options.UseFont = true
        Me.lblDDRecipientName.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDRecipientName.AppearanceDisabled.Options.UseFont = true
        Me.lblDDRecipientName.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDRecipientName.AppearanceHovered.Options.UseFont = true
        Me.lblDDRecipientName.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDRecipientName.AppearancePressed.Options.UseFont = true
        Me.lblDDRecipientName.Location = New System.Drawing.Point(441, 150)
        Me.lblDDRecipientName.Name = "lblDDRecipientName"
        Me.lblDDRecipientName.Size = New System.Drawing.Size(31, 12)
        Me.lblDDRecipientName.TabIndex = 37
        Me.lblDDRecipientName.Text = "Name: "
        '
        'ComboDonorComponent
        '
        Me.ComboDonorComponent.EnterMoveNextControl = true
        Me.ComboDonorComponent.Location = New System.Drawing.Point(604, 84)
        Me.ComboDonorComponent.Name = "ComboDonorComponent"
        Me.ComboDonorComponent.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ComboDonorComponent.Properties.Appearance.Options.UseFont = true
        Me.ComboDonorComponent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboDonorComponent.Properties.Items.AddRange(New Object() {"WHOLE BLOOD", "PACKED RED CELLS"})
        Me.ComboDonorComponent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboDonorComponent.Size = New System.Drawing.Size(160, 18)
        Me.ComboDonorComponent.TabIndex = 2
        '
        'txtDonorAddress
        '
        Me.txtDonorAddress.EnterMoveNextControl = true
        Me.txtDonorAddress.Location = New System.Drawing.Point(85, 198)
        Me.txtDonorAddress.Name = "txtDonorAddress"
        Me.txtDonorAddress.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtDonorAddress.Properties.Appearance.Options.UseFont = true
        Me.txtDonorAddress.Size = New System.Drawing.Size(314, 18)
        Me.txtDonorAddress.TabIndex = 12
        Me.txtDonorAddress.TabStop = false
        '
        'ToggleDonorSex
        '
        Me.ToggleDonorSex.Location = New System.Drawing.Point(173, 168)
        Me.ToggleDonorSex.Name = "ToggleDonorSex"
        Me.ToggleDonorSex.Properties.OffText = "Female"
        Me.ToggleDonorSex.Properties.OnText = "Male"
        Me.ToggleDonorSex.Size = New System.Drawing.Size(130, 24)
        Me.ToggleDonorSex.TabIndex = 11
        Me.ToggleDonorSex.TabStop = false
        '
        'lblDDComponent
        '
        Me.lblDDComponent.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDDComponent.Appearance.Options.UseFont = true
        Me.lblDDComponent.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDComponent.AppearanceDisabled.Options.UseFont = true
        Me.lblDDComponent.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDComponent.AppearanceHovered.Options.UseFont = true
        Me.lblDDComponent.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDComponent.AppearancePressed.Options.UseFont = true
        Me.lblDDComponent.Location = New System.Drawing.Point(604, 66)
        Me.lblDDComponent.Name = "lblDDComponent"
        Me.lblDDComponent.Size = New System.Drawing.Size(54, 12)
        Me.lblDDComponent.TabIndex = 13
        Me.lblDDComponent.Text = "Component"
        '
        'txtDonorAge
        '
        Me.txtDonorAge.EnterMoveNextControl = true
        Me.txtDonorAge.Location = New System.Drawing.Point(85, 171)
        Me.txtDonorAge.Name = "txtDonorAge"
        Me.txtDonorAge.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtDonorAge.Properties.Appearance.Options.UseFont = true
        Me.txtDonorAge.Size = New System.Drawing.Size(82, 18)
        Me.txtDonorAge.TabIndex = 10
        Me.txtDonorAge.TabStop = false
        '
        'txtDonorName
        '
        Me.txtDonorName.EnterMoveNextControl = true
        Me.txtDonorName.Location = New System.Drawing.Point(85, 147)
        Me.txtDonorName.Name = "txtDonorName"
        Me.txtDonorName.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtDonorName.Properties.Appearance.Options.UseFont = true
        Me.txtDonorName.Size = New System.Drawing.Size(314, 18)
        Me.txtDonorName.TabIndex = 9
        Me.txtDonorName.TabStop = false
        '
        'lblDonorTabDescription
        '
        Me.lblDonorTabDescription.Appearance.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDonorTabDescription.Appearance.Options.UseFont = true
        Me.lblDonorTabDescription.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 9!)
        Me.lblDonorTabDescription.AppearanceDisabled.Options.UseFont = true
        Me.lblDonorTabDescription.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 9!)
        Me.lblDonorTabDescription.AppearanceHovered.Options.UseFont = true
        Me.lblDonorTabDescription.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDonorTabDescription.AppearancePressed.Options.UseFont = true
        Me.lblDonorTabDescription.Location = New System.Drawing.Point(111, 21)
        Me.lblDonorTabDescription.Name = "lblDonorTabDescription"
        Me.lblDonorTabDescription.Size = New System.Drawing.Size(254, 28)
        Me.lblDonorTabDescription.TabIndex = 32
        Me.lblDonorTabDescription.Text = "Please enter the donors' ID card number to fetch "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"donor details from database"
        '
        'lblDAddress
        '
        Me.lblDAddress.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDAddress.Appearance.Options.UseFont = true
        Me.lblDAddress.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDAddress.AppearanceDisabled.Options.UseFont = true
        Me.lblDAddress.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDAddress.AppearanceHovered.Options.UseFont = true
        Me.lblDAddress.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDAddress.AppearancePressed.Options.UseFont = true
        Me.lblDAddress.Location = New System.Drawing.Point(33, 201)
        Me.lblDAddress.Name = "lblDAddress"
        Me.lblDAddress.Size = New System.Drawing.Size(44, 12)
        Me.lblDAddress.TabIndex = 30
        Me.lblDAddress.Text = "Address: "
        '
        'lblDAgeSex
        '
        Me.lblDAgeSex.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDAgeSex.Appearance.Options.UseFont = true
        Me.lblDAgeSex.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDAgeSex.AppearanceDisabled.Options.UseFont = true
        Me.lblDAgeSex.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDAgeSex.AppearanceHovered.Options.UseFont = true
        Me.lblDAgeSex.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDAgeSex.AppearancePressed.Options.UseFont = true
        Me.lblDAgeSex.Location = New System.Drawing.Point(33, 174)
        Me.lblDAgeSex.Name = "lblDAgeSex"
        Me.lblDAgeSex.Size = New System.Drawing.Size(46, 12)
        Me.lblDAgeSex.TabIndex = 29
        Me.lblDAgeSex.Text = "Age / Sex: "
        '
        'lblDName
        '
        Me.lblDName.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDName.Appearance.Options.UseFont = true
        Me.lblDName.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDName.AppearanceDisabled.Options.UseFont = true
        Me.lblDName.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDName.AppearanceHovered.Options.UseFont = true
        Me.lblDName.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDName.AppearancePressed.Options.UseFont = true
        Me.lblDName.Location = New System.Drawing.Point(37, 150)
        Me.lblDName.Name = "lblDName"
        Me.lblDName.Size = New System.Drawing.Size(31, 12)
        Me.lblDName.TabIndex = 28
        Me.lblDName.Text = "Name: "
        '
        'lblDateToday
        '
        Me.lblDateToday.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDateToday.Appearance.Options.UseFont = true
        Me.lblDateToday.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDateToday.AppearanceDisabled.Options.UseFont = true
        Me.lblDateToday.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDateToday.AppearanceHovered.Options.UseFont = true
        Me.lblDateToday.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDateToday.AppearancePressed.Options.UseFont = true
        Me.lblDateToday.Location = New System.Drawing.Point(763, 21)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(51, 12)
        Me.lblDateToday.TabIndex = 27
        Me.lblDateToday.Text = "DateToday"
        '
        'txtDonorXMatchNo
        '
        Me.txtDonorXMatchNo.EnterMoveNextControl = true
        Me.txtDonorXMatchNo.Location = New System.Drawing.Point(493, 84)
        Me.txtDonorXMatchNo.Name = "txtDonorXMatchNo"
        Me.txtDonorXMatchNo.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtDonorXMatchNo.Properties.Appearance.Options.UseFont = true
        Me.txtDonorXMatchNo.Size = New System.Drawing.Size(105, 18)
        Me.txtDonorXMatchNo.TabIndex = 1
        '
        'lblDDXMatchNo
        '
        Me.lblDDXMatchNo.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDDXMatchNo.Appearance.Options.UseFont = true
        Me.lblDDXMatchNo.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDXMatchNo.AppearanceDisabled.Options.UseFont = true
        Me.lblDDXMatchNo.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDXMatchNo.AppearanceHovered.Options.UseFont = true
        Me.lblDDXMatchNo.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDDXMatchNo.AppearancePressed.Options.UseFont = true
        Me.lblDDXMatchNo.Location = New System.Drawing.Point(493, 66)
        Me.lblDDXMatchNo.Name = "lblDDXMatchNo"
        Me.lblDDXMatchNo.Size = New System.Drawing.Size(79, 12)
        Me.lblDDXMatchNo.TabIndex = 1
        Me.lblDDXMatchNo.Text = "X-Match Number"
        '
        'lblXmatchNoBbk
        '
        Me.lblXmatchNoBbk.Appearance.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblXmatchNoBbk.Appearance.Options.UseFont = true
        Me.lblXmatchNoBbk.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Underline)
        Me.lblXmatchNoBbk.AppearanceDisabled.Options.UseFont = true
        Me.lblXmatchNoBbk.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Underline)
        Me.lblXmatchNoBbk.AppearanceHovered.Options.UseFont = true
        Me.lblXmatchNoBbk.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblXmatchNoBbk.AppearancePressed.Options.UseFont = true
        Me.lblXmatchNoBbk.Location = New System.Drawing.Point(13, 121)
        Me.lblXmatchNoBbk.Name = "lblXmatchNoBbk"
        Me.lblXmatchNoBbk.Size = New System.Drawing.Size(70, 14)
        Me.lblXmatchNoBbk.TabIndex = 21
        Me.lblXmatchNoBbk.Text = "Donor Details"
        '
        'lblHeadingRecipient
        '
        Me.lblHeadingRecipient.Appearance.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblHeadingRecipient.Appearance.Options.UseFont = true
        Me.lblHeadingRecipient.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Underline)
        Me.lblHeadingRecipient.AppearanceDisabled.Options.UseFont = true
        Me.lblHeadingRecipient.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Underline)
        Me.lblHeadingRecipient.AppearanceHovered.Options.UseFont = true
        Me.lblHeadingRecipient.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblHeadingRecipient.AppearancePressed.Options.UseFont = true
        Me.lblHeadingRecipient.Location = New System.Drawing.Point(436, 111)
        Me.lblHeadingRecipient.Name = "lblHeadingRecipient"
        Me.lblHeadingRecipient.Size = New System.Drawing.Size(86, 14)
        Me.lblHeadingRecipient.TabIndex = 20
        Me.lblHeadingRecipient.Text = "Recipient Details"
        '
        'XmatchIcon
        '
        Me.XmatchIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.XmatchIcon.EditValue = Global.BloodBank.My.Resources.Resources._1donate_icon
        Me.XmatchIcon.Location = New System.Drawing.Point(13, 21)
        Me.XmatchIcon.Name = "XmatchIcon"
        Me.XmatchIcon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.XmatchIcon.Properties.Appearance.Options.UseBackColor = true
        Me.XmatchIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XmatchIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.XmatchIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.XmatchIcon.Properties.ZoomAccelerationFactor = 1R
        Me.XmatchIcon.Size = New System.Drawing.Size(92, 95)
        Me.XmatchIcon.TabIndex = 17
        '
        'SaperatorUserEnteredvsServerloaded
        '
        Me.SaperatorUserEnteredvsServerloaded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.SaperatorUserEnteredvsServerloaded.AutoSizeMode = true
        Me.SaperatorUserEnteredvsServerloaded.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SaperatorUserEnteredvsServerloaded.Location = New System.Drawing.Point(405, 0)
        Me.SaperatorUserEnteredvsServerloaded.Name = "SaperatorUserEnteredvsServerloaded"
        Me.SaperatorUserEnteredvsServerloaded.Size = New System.Drawing.Size(20, 239)
        Me.SaperatorUserEnteredvsServerloaded.TabIndex = 16
        Me.SaperatorUserEnteredvsServerloaded.TabStop = false
        '
        'lblDonorIDCardNo
        '
        Me.lblDonorIDCardNo.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDonorIDCardNo.Appearance.Options.UseFont = true
        Me.lblDonorIDCardNo.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDonorIDCardNo.AppearanceDisabled.Options.UseFont = true
        Me.lblDonorIDCardNo.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDonorIDCardNo.AppearanceHovered.Options.UseFont = true
        Me.lblDonorIDCardNo.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblDonorIDCardNo.AppearancePressed.Options.UseFont = true
        Me.lblDonorIDCardNo.Location = New System.Drawing.Point(111, 66)
        Me.lblDonorIDCardNo.Name = "lblDonorIDCardNo"
        Me.lblDonorIDCardNo.Size = New System.Drawing.Size(82, 12)
        Me.lblDonorIDCardNo.TabIndex = 11
        Me.lblDonorIDCardNo.Text = "Donor ID Card No"
        '
        'txtDonorIDCardNo
        '
        Me.txtDonorIDCardNo.EnterMoveNextControl = true
        Me.txtDonorIDCardNo.Location = New System.Drawing.Point(111, 84)
        Me.txtDonorIDCardNo.Name = "txtDonorIDCardNo"
        Me.txtDonorIDCardNo.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtDonorIDCardNo.Properties.Appearance.Options.UseFont = true
        Me.txtDonorIDCardNo.Size = New System.Drawing.Size(107, 18)
        Me.txtDonorIDCardNo.TabIndex = 3
        '
        'XtraTabBloodBank
        '
        Me.XtraTabBloodBank.Controls.Add(Me.lblBbkTabDescription)
        Me.XtraTabBloodBank.Controls.Add(Me.sBtnRemove)
        Me.XtraTabBloodBank.Controls.Add(Me.sBtnAdd)
        Me.XtraTabBloodBank.Controls.Add(Me.GridControlBbkXmatch)
        Me.XtraTabBloodBank.Controls.Add(Me.txtBbkUnitNo)
        Me.XtraTabBloodBank.Controls.Add(Me.lblBbkUnitNo)
        Me.XtraTabBloodBank.Controls.Add(Me.ComboComponentBbk)
        Me.XtraTabBloodBank.Controls.Add(Me.lblBbkComponent)
        Me.XtraTabBloodBank.Controls.Add(Me.txtBbkXmatchNo)
        Me.XtraTabBloodBank.Controls.Add(Me.lblBbkXmatchNo)
        Me.XtraTabBloodBank.Controls.Add(Me.picBbk)
        Me.XtraTabBloodBank.Name = "XtraTabBloodBank"
        Me.XtraTabBloodBank.Size = New System.Drawing.Size(819, 237)
        Me.XtraTabBloodBank.Text = "Blood Ban&k"
        '
        'lblBbkTabDescription
        '
        Me.lblBbkTabDescription.Appearance.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBbkTabDescription.Appearance.Options.UseFont = true
        Me.lblBbkTabDescription.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 9!)
        Me.lblBbkTabDescription.AppearanceDisabled.Options.UseFont = true
        Me.lblBbkTabDescription.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 9!)
        Me.lblBbkTabDescription.AppearanceHovered.Options.UseFont = true
        Me.lblBbkTabDescription.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkTabDescription.AppearancePressed.Options.UseFont = true
        Me.lblBbkTabDescription.Location = New System.Drawing.Point(104, 25)
        Me.lblBbkTabDescription.Name = "lblBbkTabDescription"
        Me.lblBbkTabDescription.Size = New System.Drawing.Size(187, 98)
        Me.lblBbkTabDescription.TabIndex = 33
        Me.lblBbkTabDescription.Text = "Use ""Add"" and ""Remove"" buttons to"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"add and delete X-Match donor pints"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"from  the "& _ 
    "table."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Pints can be removed direclty by "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"pressing ""Delete"" on keyboard after"& _ 
    " "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"selecting the row. "
        '
        'sBtnRemove
        '
        Me.sBtnRemove.Location = New System.Drawing.Point(215, 143)
        Me.sBtnRemove.Name = "sBtnRemove"
        Me.sBtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.sBtnRemove.TabIndex = 30
        Me.sBtnRemove.Text = "Remo&ve"
        '
        'sBtnAdd
        '
        Me.sBtnAdd.Location = New System.Drawing.Point(134, 143)
        Me.sBtnAdd.Name = "sBtnAdd"
        Me.sBtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.sBtnAdd.TabIndex = 29
        Me.sBtnAdd.Text = "A&dd"
        '
        'GridControlBbkXmatch
        '
        Me.GridControlBbkXmatch.Dock = System.Windows.Forms.DockStyle.Right
        Me.GridControlBbkXmatch.Location = New System.Drawing.Point(296, 0)
        Me.GridControlBbkXmatch.MainView = Me.GridViewBbkXmatch
        Me.GridControlBbkXmatch.Name = "GridControlBbkXmatch"
        Me.GridControlBbkXmatch.Size = New System.Drawing.Size(523, 237)
        Me.GridControlBbkXmatch.TabIndex = 28
        Me.GridControlBbkXmatch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBbkXmatch})
        '
        'GridViewBbkXmatch
        '
        Me.GridViewBbkXmatch.Appearance.GroupFooter.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.GridViewBbkXmatch.Appearance.GroupFooter.Options.UseFont = true
        Me.GridViewBbkXmatch.Appearance.GroupRow.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.GridViewBbkXmatch.Appearance.GroupRow.Options.UseFont = true
        Me.GridViewBbkXmatch.Appearance.HeaderPanel.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GridViewBbkXmatch.Appearance.HeaderPanel.Options.UseFont = true
        Me.GridViewBbkXmatch.Appearance.Preview.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.GridViewBbkXmatch.Appearance.Preview.Options.UseFont = true
        Me.GridViewBbkXmatch.Appearance.Row.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.GridViewBbkXmatch.Appearance.Row.Options.UseFont = true
        Me.GridViewBbkXmatch.Appearance.TopNewRow.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.GridViewBbkXmatch.Appearance.TopNewRow.Options.UseFont = true
        Me.GridViewBbkXmatch.GridControl = Me.GridControlBbkXmatch
        Me.GridViewBbkXmatch.Name = "GridViewBbkXmatch"
        Me.GridViewBbkXmatch.OptionsView.EnableAppearanceEvenRow = true
        '
        'txtBbkUnitNo
        '
        Me.txtBbkUnitNo.EnterMoveNextControl = true
        Me.txtBbkUnitNo.Location = New System.Drawing.Point(19, 188)
        Me.txtBbkUnitNo.Name = "txtBbkUnitNo"
        Me.txtBbkUnitNo.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtBbkUnitNo.Properties.Appearance.Options.UseFont = true
        Me.txtBbkUnitNo.Size = New System.Drawing.Size(105, 18)
        Me.txtBbkUnitNo.TabIndex = 26
        '
        'lblBbkUnitNo
        '
        Me.lblBbkUnitNo.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBbkUnitNo.Appearance.Options.UseFont = true
        Me.lblBbkUnitNo.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkUnitNo.AppearanceDisabled.Options.UseFont = true
        Me.lblBbkUnitNo.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkUnitNo.AppearanceHovered.Options.UseFont = true
        Me.lblBbkUnitNo.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkUnitNo.AppearancePressed.Options.UseFont = true
        Me.lblBbkUnitNo.Location = New System.Drawing.Point(19, 170)
        Me.lblBbkUnitNo.Name = "lblBbkUnitNo"
        Me.lblBbkUnitNo.Size = New System.Drawing.Size(60, 12)
        Me.lblBbkUnitNo.TabIndex = 27
        Me.lblBbkUnitNo.Text = "Unit Number"
        '
        'ComboComponentBbk
        '
        Me.ComboComponentBbk.EnterMoveNextControl = true
        Me.ComboComponentBbk.Location = New System.Drawing.Point(130, 188)
        Me.ComboComponentBbk.Name = "ComboComponentBbk"
        Me.ComboComponentBbk.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ComboComponentBbk.Properties.Appearance.Options.UseFont = true
        Me.ComboComponentBbk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboComponentBbk.Properties.Items.AddRange(New Object() {"WHOLE BLOOD", "PACKED RED CELLS"})
        Me.ComboComponentBbk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboComponentBbk.Size = New System.Drawing.Size(160, 18)
        Me.ComboComponentBbk.TabIndex = 24
        '
        'lblBbkComponent
        '
        Me.lblBbkComponent.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBbkComponent.Appearance.Options.UseFont = true
        Me.lblBbkComponent.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkComponent.AppearanceDisabled.Options.UseFont = true
        Me.lblBbkComponent.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkComponent.AppearanceHovered.Options.UseFont = true
        Me.lblBbkComponent.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkComponent.AppearancePressed.Options.UseFont = true
        Me.lblBbkComponent.Location = New System.Drawing.Point(130, 170)
        Me.lblBbkComponent.Name = "lblBbkComponent"
        Me.lblBbkComponent.Size = New System.Drawing.Size(54, 12)
        Me.lblBbkComponent.TabIndex = 25
        Me.lblBbkComponent.Text = "Component"
        '
        'txtBbkXmatchNo
        '
        Me.txtBbkXmatchNo.EnterMoveNextControl = true
        Me.txtBbkXmatchNo.Location = New System.Drawing.Point(19, 146)
        Me.txtBbkXmatchNo.Name = "txtBbkXmatchNo"
        Me.txtBbkXmatchNo.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtBbkXmatchNo.Properties.Appearance.Options.UseFont = true
        Me.txtBbkXmatchNo.Size = New System.Drawing.Size(105, 18)
        Me.txtBbkXmatchNo.TabIndex = 22
        '
        'lblBbkXmatchNo
        '
        Me.lblBbkXmatchNo.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBbkXmatchNo.Appearance.Options.UseFont = true
        Me.lblBbkXmatchNo.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkXmatchNo.AppearanceDisabled.Options.UseFont = true
        Me.lblBbkXmatchNo.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkXmatchNo.AppearanceHovered.Options.UseFont = true
        Me.lblBbkXmatchNo.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblBbkXmatchNo.AppearancePressed.Options.UseFont = true
        Me.lblBbkXmatchNo.Location = New System.Drawing.Point(19, 128)
        Me.lblBbkXmatchNo.Name = "lblBbkXmatchNo"
        Me.lblBbkXmatchNo.Size = New System.Drawing.Size(79, 12)
        Me.lblBbkXmatchNo.TabIndex = 23
        Me.lblBbkXmatchNo.Text = "X-Match Number"
        '
        'picBbk
        '
        Me.picBbk.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBbk.EditValue = Global.BloodBank.My.Resources.Resources.Blood_Donor_Icon
        Me.picBbk.Location = New System.Drawing.Point(13, 21)
        Me.picBbk.Name = "picBbk"
        Me.picBbk.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.picBbk.Properties.Appearance.Options.UseBackColor = true
        Me.picBbk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picBbk.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.picBbk.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picBbk.Properties.ZoomAccelerationFactor = 1R
        Me.picBbk.Size = New System.Drawing.Size(85, 85)
        Me.picBbk.TabIndex = 21
        '
        'lblWardBed
        '
        Me.lblWardBed.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblWardBed.Appearance.Options.UseFont = true
        Me.lblWardBed.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblWardBed.AppearanceDisabled.Options.UseFont = true
        Me.lblWardBed.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblWardBed.AppearanceHovered.Options.UseFont = true
        Me.lblWardBed.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblWardBed.AppearancePressed.Options.UseFont = true
        Me.lblWardBed.Location = New System.Drawing.Point(225, 75)
        Me.lblWardBed.Name = "lblWardBed"
        Me.lblWardBed.Size = New System.Drawing.Size(68, 12)
        Me.lblWardBed.TabIndex = 26
        Me.lblWardBed.Text = "Ward / Bed No"
        '
        'lblXmatchDescription
        '
        Me.lblXmatchDescription.Appearance.Font = New System.Drawing.Font("Cambria", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblXmatchDescription.Appearance.Options.UseFont = true
        Me.lblXmatchDescription.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 9!)
        Me.lblXmatchDescription.AppearanceDisabled.Options.UseFont = true
        Me.lblXmatchDescription.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 9!)
        Me.lblXmatchDescription.AppearanceHovered.Options.UseFont = true
        Me.lblXmatchDescription.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblXmatchDescription.AppearancePressed.Options.UseFont = true
        Me.lblXmatchDescription.Location = New System.Drawing.Point(114, 36)
        Me.lblXmatchDescription.Name = "lblXmatchDescription"
        Me.lblXmatchDescription.Size = New System.Drawing.Size(254, 28)
        Me.lblXmatchDescription.TabIndex = 19
        Me.lblXmatchDescription.Text = "Please enter the required data, relavent data will "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"be fetched from database on "& _ 
    "the fly."
        '
        'txtWardBedNo
        '
        Me.txtWardBedNo.EnterMoveNextControl = true
        Me.txtWardBedNo.Location = New System.Drawing.Point(225, 93)
        Me.txtWardBedNo.Name = "txtWardBedNo"
        Me.txtWardBedNo.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtWardBedNo.Properties.Appearance.Options.UseFont = true
        Me.txtWardBedNo.Size = New System.Drawing.Size(107, 18)
        Me.txtWardBedNo.TabIndex = 5
        '
        'txtDateTimeSelection
        '
        Me.txtDateTimeSelection.EditValue = Nothing
        Me.txtDateTimeSelection.EnterMoveNextControl = true
        Me.txtDateTimeSelection.Location = New System.Drawing.Point(114, 145)
        Me.txtDateTimeSelection.Name = "txtDateTimeSelection"
        Me.txtDateTimeSelection.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtDateTimeSelection.Properties.Appearance.Options.UseFont = true
        Me.txtDateTimeSelection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTimeSelection.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTimeSelection.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.txtDateTimeSelection.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateTimeSelection.Properties.DisplayFormat.FormatString = ""
        Me.txtDateTimeSelection.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateTimeSelection.Properties.EditFormat.FormatString = ""
        Me.txtDateTimeSelection.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDateTimeSelection.Properties.Mask.EditMask = "dd MM yyyy HH mm"
        Me.txtDateTimeSelection.Size = New System.Drawing.Size(218, 18)
        Me.txtDateTimeSelection.TabIndex = 6
        '
        'lblSampleCollectionDate
        '
        Me.lblSampleCollectionDate.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSampleCollectionDate.Appearance.Options.UseFont = true
        Me.lblSampleCollectionDate.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblSampleCollectionDate.AppearanceDisabled.Options.UseFont = true
        Me.lblSampleCollectionDate.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblSampleCollectionDate.AppearanceHovered.Options.UseFont = true
        Me.lblSampleCollectionDate.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblSampleCollectionDate.AppearancePressed.Options.UseFont = true
        Me.lblSampleCollectionDate.Location = New System.Drawing.Point(114, 127)
        Me.lblSampleCollectionDate.Name = "lblSampleCollectionDate"
        Me.lblSampleCollectionDate.Size = New System.Drawing.Size(150, 12)
        Me.lblSampleCollectionDate.TabIndex = 7
        Me.lblSampleCollectionDate.Text = "Sample Collection Date and Time"
        '
        'lblPatientGroupRhDisplay
        '
        Me.lblPatientGroupRhDisplay.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPatientGroupRhDisplay.Appearance.Options.UseFont = true
        Me.lblPatientGroupRhDisplay.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientGroupRhDisplay.AppearanceDisabled.Options.UseFont = true
        Me.lblPatientGroupRhDisplay.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientGroupRhDisplay.AppearanceHovered.Options.UseFont = true
        Me.lblPatientGroupRhDisplay.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientGroupRhDisplay.AppearancePressed.Options.UseFont = true
        Me.lblPatientGroupRhDisplay.Location = New System.Drawing.Point(602, 108)
        Me.lblPatientGroupRhDisplay.Name = "lblPatientGroupRhDisplay"
        Me.lblPatientGroupRhDisplay.Size = New System.Drawing.Size(166, 12)
        Me.lblPatientGroupRhDisplay.TabIndex = 9
        Me.lblPatientGroupRhDisplay.Text = "Patient group is 'A' Rh(D) POSITIVE"
        '
        'txtRecipientHospitalNumber
        '
        Me.txtRecipientHospitalNumber.EnterMoveNextControl = true
        Me.txtRecipientHospitalNumber.Location = New System.Drawing.Point(114, 93)
        Me.txtRecipientHospitalNumber.Name = "txtRecipientHospitalNumber"
        Me.txtRecipientHospitalNumber.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.txtRecipientHospitalNumber.Properties.Appearance.Options.UseFont = true
        Me.txtRecipientHospitalNumber.Properties.Mask.EditMask = "[0-9]+"
        Me.txtRecipientHospitalNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtRecipientHospitalNumber.Size = New System.Drawing.Size(105, 18)
        Me.txtRecipientHospitalNumber.TabIndex = 4
        '
        'CheckSameGroup
        '
        Me.CheckSameGroup.EditValue = true
        Me.CheckSameGroup.Location = New System.Drawing.Point(584, 92)
        Me.CheckSameGroup.Name = "CheckSameGroup"
        Me.CheckSameGroup.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckSameGroup.Properties.Appearance.Options.UseFont = true
        Me.CheckSameGroup.Properties.Caption = "Same Group as Donor"
        Me.CheckSameGroup.Size = New System.Drawing.Size(138, 19)
        Me.CheckSameGroup.TabIndex = 8
        Me.CheckSameGroup.TabStop = false
        '
        'lblPatientHospitalNumber
        '
        Me.lblPatientHospitalNumber.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPatientHospitalNumber.Appearance.Options.UseFont = true
        Me.lblPatientHospitalNumber.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientHospitalNumber.AppearanceDisabled.Options.UseFont = true
        Me.lblPatientHospitalNumber.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientHospitalNumber.AppearanceHovered.Options.UseFont = true
        Me.lblPatientHospitalNumber.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientHospitalNumber.AppearancePressed.Options.UseFont = true
        Me.lblPatientHospitalNumber.Location = New System.Drawing.Point(114, 75)
        Me.lblPatientHospitalNumber.Name = "lblPatientHospitalNumber"
        Me.lblPatientHospitalNumber.Size = New System.Drawing.Size(101, 12)
        Me.lblPatientHospitalNumber.TabIndex = 15
        Me.lblPatientHospitalNumber.Text = "Recipient Hospital No"
        '
        'lblPatientRh
        '
        Me.lblPatientRh.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPatientRh.Appearance.Options.UseFont = true
        Me.lblPatientRh.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientRh.AppearanceDisabled.Options.UseFont = true
        Me.lblPatientRh.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientRh.AppearanceHovered.Options.UseFont = true
        Me.lblPatientRh.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientRh.AppearancePressed.Options.UseFont = true
        Me.lblPatientRh.Location = New System.Drawing.Point(479, 75)
        Me.lblPatientRh.Name = "lblPatientRh"
        Me.lblPatientRh.Size = New System.Drawing.Size(30, 12)
        Me.lblPatientRh.TabIndex = 5
        Me.lblPatientRh.Text = "Rh (D)"
        '
        'lblPatientABO
        '
        Me.lblPatientABO.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPatientABO.Appearance.Options.UseFont = true
        Me.lblPatientABO.AppearanceDisabled.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientABO.AppearanceDisabled.Options.UseFont = true
        Me.lblPatientABO.AppearanceHovered.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientABO.AppearanceHovered.Options.UseFont = true
        Me.lblPatientABO.AppearancePressed.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.lblPatientABO.AppearancePressed.Options.UseFont = true
        Me.lblPatientABO.Location = New System.Drawing.Point(362, 75)
        Me.lblPatientABO.Name = "lblPatientABO"
        Me.lblPatientABO.Size = New System.Drawing.Size(56, 12)
        Me.lblPatientABO.TabIndex = 3
        Me.lblPatientABO.Text = "Patient ABO"
        '
        'ComboPatientRh
        '
        Me.ComboPatientRh.EnterMoveNextControl = true
        Me.ComboPatientRh.Location = New System.Drawing.Point(473, 93)
        Me.ComboPatientRh.Name = "ComboPatientRh"
        Me.ComboPatientRh.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ComboPatientRh.Properties.Appearance.Options.UseFont = true
        Me.ComboPatientRh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboPatientRh.Properties.Items.AddRange(New Object() {"POSITIVE", "NEGATIVE"})
        Me.ComboPatientRh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboPatientRh.Size = New System.Drawing.Size(105, 18)
        Me.ComboPatientRh.TabIndex = 8
        '
        'ComboPatientABO
        '
        Me.ComboPatientABO.EnterMoveNextControl = true
        Me.ComboPatientABO.Location = New System.Drawing.Point(362, 93)
        Me.ComboPatientABO.Name = "ComboPatientABO"
        Me.ComboPatientABO.Properties.Appearance.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ComboPatientABO.Properties.Appearance.Options.UseFont = true
        Me.ComboPatientABO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboPatientABO.Properties.Items.AddRange(New Object() {"""A""", """B""", """AB""", """O"""})
        Me.ComboPatientABO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboPatientABO.Size = New System.Drawing.Size(105, 18)
        Me.ComboPatientABO.TabIndex = 7
        '
        'frmReportEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.ClientSize = New System.Drawing.Size(829, 444)
        Me.Controls.Add(Me.gcXmatch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.Name = "frmReportEntry"
        Me.Opacity = 0R
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.gcXmatch,System.ComponentModel.ISupportInitialize).EndInit
        Me.gcXmatch.ResumeLayout(false)
        Me.gcXmatch.PerformLayout
        CType(Me.SeparatorCommonData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picRegister.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XtraTabControlPreviewAndPrintAnalysisRequest,System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabControlPreviewAndPrintAnalysisRequest.ResumeLayout(false)
        Me.XtraTabDonor.ResumeLayout(false)
        Me.XtraTabDonor.PerformLayout
        CType(Me.CheckDonorBled.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDDRecipientAddress.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ToggleDDRecipientSex.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDDRecipientAge.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDDRecipientName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboDonorComponent.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDonorAddress.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ToggleDonorSex.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDonorAge.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDonorName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDonorXMatchNo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XmatchIcon.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SaperatorUserEnteredvsServerloaded,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDonorIDCardNo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.XtraTabBloodBank.ResumeLayout(false)
        Me.XtraTabBloodBank.PerformLayout
        CType(Me.GridControlBbkXmatch,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridViewBbkXmatch,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBbkUnitNo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboComponentBbk.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBbkXmatchNo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picBbk.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWardBedNo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDateTimeSelection.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDateTimeSelection.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRecipientHospitalNumber.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CheckSameGroup.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboPatientRh.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboPatientABO.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents gcXmatch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents XtraTabControlPreviewAndPrintAnalysisRequest As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents lblClose As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabDonor As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabBloodBank As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblPatientRh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboPatientRh As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblPatientABO As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDDXMatchNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDonorXMatchNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboPatientABO As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblSampleCollectionDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateTimeSelection As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckSameGroup As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblPatientGroupRhDisplay As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDonorIDCardNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDonorIDCardNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPatientHospitalNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRecipientHospitalNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDDComponent As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboDonorComponent As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SaperatorUserEnteredvsServerloaded As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents XmatchIcon As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblXmatchDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDAgeSex As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblWardBed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWardBedNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblXmatchNoBbk As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHeadingRecipient As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picBbk As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picRegister As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SeparatorCommonData As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtDonorAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToggleDonorSex As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents txtDonorAge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDonorName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDonorTabDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDDRecipientAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToggleDDRecipientSex As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents txtDDRecipientAge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDDRecipientName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDDRecipientAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDDRecipientAge As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDDRecipientName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateToday As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sBtnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sBtnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControlBbkXmatch As GridControl
    Friend WithEvents GridViewBbkXmatch As Views.Grid.GridView
    Friend WithEvents txtBbkUnitNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblBbkUnitNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboComponentBbk As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblBbkComponent As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBbkXmatchNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblBbkXmatchNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLastDonationDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBbkTabDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblXMatchInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckDonorBled As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSavePrint As DevExpress.XtraEditors.SimpleButton
End Class
