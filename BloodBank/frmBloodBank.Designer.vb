Imports DevExpress.XtraBars.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBloodBank
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBloodBank))
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.iNew = New DevExpress.XtraBars.BarButtonItem()
        Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
        Me.iSave = New DevExpress.XtraBars.BarButtonItem()
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.iClose = New DevExpress.XtraBars.BarButtonItem()
        Me.iFind = New DevExpress.XtraBars.BarButtonItem()
        Me.iHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.siStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.siInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.alignButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iBoldFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iItalicFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iUnderlinedFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.fontStyleButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iLeftTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iCenterTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iRightTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.homeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.fileRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.exitRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.helpRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.helpRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BloodBankDocker = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockPanelOpenRecords = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.TreeViewXMatchRecords = New System.Windows.Forms.TreeView()
        Me.MonitorOpenRecords = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ribbonControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.appMenu,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ribbonImageCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ribbonImageCollectionLarge,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BloodBankDocker,System.ComponentModel.ISupportInitialize).BeginInit
        Me.hideContainerLeft.SuspendLayout
        Me.DockPanelOpenRecords.SuspendLayout
        Me.DockPanel2_Container.SuspendLayout
        Me.SuspendLayout
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ApplicationIcon = CType(resources.GetObject("ribbonControl.ApplicationIcon"),System.Drawing.Bitmap)
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.iNew, Me.iOpen, Me.iClose, Me.iFind, Me.iSave, Me.iExit, Me.iHelp, Me.iAbout, Me.siStatus, Me.siInfo, Me.alignButtonGroup, Me.iBoldFontStyle, Me.iItalicFontStyle, Me.iUnderlinedFontStyle, Me.fontStyleButtonGroup, Me.iLeftTextAlign, Me.iCenterTextAlign, Me.iRightTextAlign, Me.rgbiSkins})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 1
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.iAbout)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.homeRibbonPage, Me.helpRibbonPage})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.ribbonControl.Size = New System.Drawing.Size(1208, 143)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        '
        'appMenu
        '
        Me.appMenu.ItemLinks.Add(Me.iNew)
        Me.appMenu.ItemLinks.Add(Me.iOpen)
        Me.appMenu.ItemLinks.Add(Me.iSave)
        Me.appMenu.ItemLinks.Add(Me.iExit)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.ShowRightPane = true
        '
        'iNew
        '
        Me.iNew.Caption = "&New"
        Me.iNew.Description = "Creates a new, blank file."
        Me.iNew.Hint = "Creates a new, blank file"
        Me.iNew.Id = 1
        Me.iNew.ImageIndex = 0
        Me.iNew.LargeImageIndex = 0
        Me.iNew.Name = "iNew"
        '
        'iOpen
        '
        Me.iOpen.Caption = "&Open"
        Me.iOpen.Description = "Opens a file."
        Me.iOpen.Hint = "Opens a file"
        Me.iOpen.Id = 2
        Me.iOpen.ImageIndex = 1
        Me.iOpen.LargeImageIndex = 1
        Me.iOpen.Name = "iOpen"
        Me.iOpen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'iSave
        '
        Me.iSave.Caption = "&Save"
        Me.iSave.Description = "Saves the active document."
        Me.iSave.Hint = "Saves the active document"
        Me.iSave.Id = 16
        Me.iSave.ImageIndex = 4
        Me.iSave.LargeImageIndex = 4
        Me.iSave.Name = "iSave"
        '
        'iExit
        '
        Me.iExit.Caption = "Exit"
        Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
        Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
        Me.iExit.Id = 20
        Me.iExit.ImageIndex = 6
        Me.iExit.LargeImageIndex = 6
        Me.iExit.Name = "iExit"
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"),DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        '
        'iClose
        '
        Me.iClose.Caption = "&Close"
        Me.iClose.Description = "Closes the active document."
        Me.iClose.Hint = "Closes the active document"
        Me.iClose.Id = 3
        Me.iClose.ImageIndex = 2
        Me.iClose.LargeImageIndex = 2
        Me.iClose.Name = "iClose"
        Me.iClose.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText),DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'iFind
        '
        Me.iFind.Caption = "Find"
        Me.iFind.Description = "Searches for the specified info."
        Me.iFind.Hint = "Searches for the specified info"
        Me.iFind.Id = 15
        Me.iFind.ImageIndex = 3
        Me.iFind.LargeImageIndex = 3
        Me.iFind.Name = "iFind"
        Me.iFind.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText),DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'iHelp
        '
        Me.iHelp.Caption = "Help"
        Me.iHelp.Description = "Start the program help system."
        Me.iHelp.Hint = "Start the program help system"
        Me.iHelp.Id = 22
        Me.iHelp.ImageIndex = 7
        Me.iHelp.LargeImageIndex = 7
        Me.iHelp.Name = "iHelp"
        '
        'iAbout
        '
        Me.iAbout.Caption = "About"
        Me.iAbout.Description = "Displays general program information."
        Me.iAbout.Hint = "Displays general program information"
        Me.iAbout.Id = 24
        Me.iAbout.ImageIndex = 8
        Me.iAbout.LargeImageIndex = 8
        Me.iAbout.Name = "iAbout"
        '
        'siStatus
        '
        Me.siStatus.Caption = "Some Status Info"
        Me.siStatus.Id = 31
        Me.siStatus.Name = "siStatus"
        Me.siStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'siInfo
        '
        Me.siInfo.Caption = "Some Info"
        Me.siInfo.Id = 32
        Me.siInfo.Name = "siInfo"
        Me.siInfo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'alignButtonGroup
        '
        Me.alignButtonGroup.Caption = "Align Commands"
        Me.alignButtonGroup.Id = 52
        Me.alignButtonGroup.ItemLinks.Add(Me.iBoldFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iItalicFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iUnderlinedFontStyle)
        Me.alignButtonGroup.Name = "alignButtonGroup"
        '
        'iBoldFontStyle
        '
        Me.iBoldFontStyle.Caption = "Bold"
        Me.iBoldFontStyle.Id = 53
        Me.iBoldFontStyle.ImageIndex = 9
        Me.iBoldFontStyle.Name = "iBoldFontStyle"
        '
        'iItalicFontStyle
        '
        Me.iItalicFontStyle.Caption = "Italic"
        Me.iItalicFontStyle.Id = 54
        Me.iItalicFontStyle.ImageIndex = 10
        Me.iItalicFontStyle.Name = "iItalicFontStyle"
        '
        'iUnderlinedFontStyle
        '
        Me.iUnderlinedFontStyle.Caption = "Underlined"
        Me.iUnderlinedFontStyle.Id = 55
        Me.iUnderlinedFontStyle.ImageIndex = 11
        Me.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle"
        '
        'fontStyleButtonGroup
        '
        Me.fontStyleButtonGroup.Caption = "Font Style"
        Me.fontStyleButtonGroup.Id = 56
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iLeftTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iCenterTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iRightTextAlign)
        Me.fontStyleButtonGroup.Name = "fontStyleButtonGroup"
        '
        'iLeftTextAlign
        '
        Me.iLeftTextAlign.Caption = "Left"
        Me.iLeftTextAlign.Id = 57
        Me.iLeftTextAlign.ImageIndex = 12
        Me.iLeftTextAlign.Name = "iLeftTextAlign"
        '
        'iCenterTextAlign
        '
        Me.iCenterTextAlign.Caption = "Center"
        Me.iCenterTextAlign.Id = 58
        Me.iCenterTextAlign.ImageIndex = 13
        Me.iCenterTextAlign.Name = "iCenterTextAlign"
        '
        'iRightTextAlign
        '
        Me.iRightTextAlign.Caption = "Right"
        Me.iRightTextAlign.Id = 59
        Me.iRightTextAlign.ImageIndex = 14
        Me.iRightTextAlign.Name = "iRightTextAlign"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        '
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = true
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = false
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 60
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"),DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        '
        'homeRibbonPage
        '
        Me.homeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.fileRibbonPageGroup, Me.skinsRibbonPageGroup, Me.exitRibbonPageGroup})
        Me.homeRibbonPage.Name = "homeRibbonPage"
        Me.homeRibbonPage.Text = "Home"
        '
        'fileRibbonPageGroup
        '
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iNew)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iOpen)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iSave)
        Me.fileRibbonPageGroup.Name = "fileRibbonPageGroup"
        Me.fileRibbonPageGroup.Text = "File"
        '
        'skinsRibbonPageGroup
        '
        Me.skinsRibbonPageGroup.ItemLinks.Add(Me.rgbiSkins)
        Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
        Me.skinsRibbonPageGroup.ShowCaptionButton = false
        Me.skinsRibbonPageGroup.Text = "Skins"
        '
        'exitRibbonPageGroup
        '
        Me.exitRibbonPageGroup.ItemLinks.Add(Me.iExit)
        Me.exitRibbonPageGroup.Name = "exitRibbonPageGroup"
        Me.exitRibbonPageGroup.Text = "Exit"
        '
        'helpRibbonPage
        '
        Me.helpRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.helpRibbonPageGroup})
        Me.helpRibbonPage.Name = "helpRibbonPage"
        Me.helpRibbonPage.Text = "Help"
        '
        'helpRibbonPageGroup
        '
        Me.helpRibbonPageGroup.ItemLinks.Add(Me.iHelp)
        Me.helpRibbonPageGroup.ItemLinks.Add(Me.iAbout)
        Me.helpRibbonPageGroup.Name = "helpRibbonPageGroup"
        Me.helpRibbonPageGroup.Text = "Help"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.siStatus)
        Me.ribbonStatusBar.ItemLinks.Add(Me.siInfo)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 569)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1208, 31)
        '
        'BloodBankDocker
        '
        Me.BloodBankDocker.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
        Me.BloodBankDocker.Form = Me
        Me.BloodBankDocker.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'hideContainerLeft
        '
        Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(235,Byte),Integer), CType(CType(236,Byte),Integer), CType(CType(239,Byte),Integer))
        Me.hideContainerLeft.Controls.Add(Me.DockPanelOpenRecords)
        Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.hideContainerLeft.Location = New System.Drawing.Point(0, 143)
        Me.hideContainerLeft.Name = "hideContainerLeft"
        Me.hideContainerLeft.Size = New System.Drawing.Size(19, 426)
        '
        'DockPanelOpenRecords
        '
        Me.DockPanelOpenRecords.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanelOpenRecords.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanelOpenRecords.ID = New System.Guid("b3dc3f98-a74c-449d-9b37-9de088a33a33")
        Me.DockPanelOpenRecords.Location = New System.Drawing.Point(0, 0)
        Me.DockPanelOpenRecords.Name = "DockPanelOpenRecords"
        Me.DockPanelOpenRecords.Options.ShowCloseButton = false
        Me.DockPanelOpenRecords.Options.ShowMaximizeButton = false
        Me.DockPanelOpenRecords.OriginalSize = New System.Drawing.Size(176, 200)
        Me.DockPanelOpenRecords.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanelOpenRecords.SavedIndex = 0
        Me.DockPanelOpenRecords.Size = New System.Drawing.Size(176, 426)
        Me.DockPanelOpenRecords.TabStop = false
        Me.DockPanelOpenRecords.Text = "Open Records"
        Me.DockPanelOpenRecords.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.TreeViewXMatchRecords)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(167, 399)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'TreeViewXMatchRecords
        '
        Me.TreeViewXMatchRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewXMatchRecords.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewXMatchRecords.Name = "TreeViewXMatchRecords"
        Me.TreeViewXMatchRecords.Size = New System.Drawing.Size(167, 399)
        Me.TreeViewXMatchRecords.TabIndex = 0
        '
        'MonitorOpenRecords
        '
        Me.MonitorOpenRecords.Enabled = true
        '
        'frmBloodBank
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.BloodBank.My.Resources.Resources.bkgd_pattern
        Me.ClientSize = New System.Drawing.Size(1208, 600)
        Me.Controls.Add(Me.hideContainerLeft)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.Name = "frmBloodBank"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Blood Bank"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.appMenu,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ribbonImageCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ribbonImageCollectionLarge,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BloodBankDocker,System.ComponentModel.ISupportInitialize).EndInit
        Me.hideContainerLeft.ResumeLayout(false)
        Me.DockPanelOpenRecords.ResumeLayout(false)
        Me.DockPanel2_Container.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents iNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iOpen As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iFind As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iSave As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iHelp As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private WithEvents siStatus As DevExpress.XtraBars.BarStaticItem
    Private WithEvents siInfo As DevExpress.XtraBars.BarStaticItem
    Private WithEvents alignButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iBoldFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iItalicFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iUnderlinedFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents fontStyleButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iLeftTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iCenterTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iRightTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents homeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents fileRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents exitRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents helpRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents helpRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Friend WithEvents BloodBankDocker As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanelOpenRecords As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents TreeViewXMatchRecords As TreeView
    Friend WithEvents MonitorOpenRecords As Timer
    Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
End Class
