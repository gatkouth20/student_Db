<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_form
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_form))
        Dim AccountNumberLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim OfficeAddressLabel As System.Windows.Forms.Label
        Dim HomeAddressLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim AccountTypeLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim OfficePhoneLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim AccessCodeLabel As System.Windows.Forms.Label
        Dim DateOpenedLabel As System.Windows.Forms.Label
        Dim DigitalSignLabel As System.Windows.Forms.Label
        Dim CustomerPictureLabel As System.Windows.Forms.Label
        Dim ATMCardNumberLabel As System.Windows.Forms.Label
        Dim ExpiryDateLabel As System.Windows.Forms.Label
        Me.OnlineBankingDataSet = New Home_page.OnlineBankingDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Home_page.OnlineBankingDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Home_page.OnlineBankingDataSetTableAdapters.TableAdapterManager()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.OfficeAddressTextBox = New System.Windows.Forms.TextBox()
        Me.HomeAddressTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AccountTypeTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.OfficePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.HomePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.AccessCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DateOpenedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DigitalSignTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerPictureTextBox = New System.Windows.Forms.TextBox()
        Me.ATMCardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ExpiryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        AccountNumberLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        OfficeAddressLabel = New System.Windows.Forms.Label()
        HomeAddressLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        AccountTypeLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        OfficePhoneLabel = New System.Windows.Forms.Label()
        HomePhoneLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        AccessCodeLabel = New System.Windows.Forms.Label()
        DateOpenedLabel = New System.Windows.Forms.Label()
        DigitalSignLabel = New System.Windows.Forms.Label()
        CustomerPictureLabel = New System.Windows.Forms.Label()
        ATMCardNumberLabel = New System.Windows.Forms.Label()
        ExpiryDateLabel = New System.Windows.Forms.Label()
        CType(Me.OnlineBankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'OnlineBankingDataSet
        '
        Me.OnlineBankingDataSet.DataSetName = "OnlineBankingDataSet"
        Me.OnlineBankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.OnlineBankingDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountTypeTableAdapter = Nothing
        Me.TableAdapterManager.ATM_cardTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckBookDetailsTableAdapter = Nothing
        Me.TableAdapterManager.CustomerQueryTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.Deposited_formTableAdapter = Nothing
        Me.TableAdapterManager.for_official_use_onlyTableAdapter = Nothing
        Me.TableAdapterManager.Introducer_Witness_infoTableAdapter = Nothing
        Me.TableAdapterManager.Opening_an_accountTableAdapter = Nothing
        Me.TableAdapterManager.StopPaymentTableAdapter = Nothing
        Me.TableAdapterManager.student_s_detailTableAdapter = Nothing
        Me.TableAdapterManager.TransTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Home_page.OnlineBankingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(768, 25)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AccountNumberLabel
        '
        AccountNumberLabel.AutoSize = True
        AccountNumberLabel.Location = New System.Drawing.Point(165, 92)
        AccountNumberLabel.Name = "AccountNumberLabel"
        AccountNumberLabel.Size = New System.Drawing.Size(90, 13)
        AccountNumberLabel.TabIndex = 1
        AccountNumberLabel.Text = "Account Number:"
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "AccountNumber", True))
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(266, 89)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AccountNumberTextBox.TabIndex = 2
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(165, 118)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(266, 115)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(165, 144)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(266, 141)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 6
        '
        'OfficeAddressLabel
        '
        OfficeAddressLabel.AutoSize = True
        OfficeAddressLabel.Location = New System.Drawing.Point(165, 170)
        OfficeAddressLabel.Name = "OfficeAddressLabel"
        OfficeAddressLabel.Size = New System.Drawing.Size(79, 13)
        OfficeAddressLabel.TabIndex = 7
        OfficeAddressLabel.Text = "Office Address:"
        '
        'OfficeAddressTextBox
        '
        Me.OfficeAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "OfficeAddress", True))
        Me.OfficeAddressTextBox.Location = New System.Drawing.Point(266, 167)
        Me.OfficeAddressTextBox.Name = "OfficeAddressTextBox"
        Me.OfficeAddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OfficeAddressTextBox.TabIndex = 8
        '
        'HomeAddressLabel
        '
        HomeAddressLabel.AutoSize = True
        HomeAddressLabel.Location = New System.Drawing.Point(165, 196)
        HomeAddressLabel.Name = "HomeAddressLabel"
        HomeAddressLabel.Size = New System.Drawing.Size(79, 13)
        HomeAddressLabel.TabIndex = 9
        HomeAddressLabel.Text = "Home Address:"
        '
        'HomeAddressTextBox
        '
        Me.HomeAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "HomeAddress", True))
        Me.HomeAddressTextBox.Location = New System.Drawing.Point(266, 193)
        Me.HomeAddressTextBox.Name = "HomeAddressTextBox"
        Me.HomeAddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HomeAddressTextBox.TabIndex = 10
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(165, 223)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(71, 13)
        DateOfBirthLabel.TabIndex = 11
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(266, 219)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfBirthDateTimePicker.TabIndex = 12
        '
        'AccountTypeLabel
        '
        AccountTypeLabel.AutoSize = True
        AccountTypeLabel.Location = New System.Drawing.Point(165, 248)
        AccountTypeLabel.Name = "AccountTypeLabel"
        AccountTypeLabel.Size = New System.Drawing.Size(77, 13)
        AccountTypeLabel.TabIndex = 13
        AccountTypeLabel.Text = "Account Type:"
        '
        'AccountTypeTextBox
        '
        Me.AccountTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "AccountType", True))
        Me.AccountTypeTextBox.Location = New System.Drawing.Point(266, 245)
        Me.AccountTypeTextBox.Name = "AccountTypeTextBox"
        Me.AccountTypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AccountTypeTextBox.TabIndex = 14
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(165, 274)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 15
        GenderLabel.Text = "Gender:"
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(266, 271)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 16
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(165, 300)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(266, 297)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 18
        '
        'OfficePhoneLabel
        '
        OfficePhoneLabel.AutoSize = True
        OfficePhoneLabel.Location = New System.Drawing.Point(165, 326)
        OfficePhoneLabel.Name = "OfficePhoneLabel"
        OfficePhoneLabel.Size = New System.Drawing.Size(72, 13)
        OfficePhoneLabel.TabIndex = 19
        OfficePhoneLabel.Text = "Office Phone:"
        '
        'OfficePhoneTextBox
        '
        Me.OfficePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "OfficePhone", True))
        Me.OfficePhoneTextBox.Location = New System.Drawing.Point(266, 323)
        Me.OfficePhoneTextBox.Name = "OfficePhoneTextBox"
        Me.OfficePhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OfficePhoneTextBox.TabIndex = 20
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = True
        HomePhoneLabel.Location = New System.Drawing.Point(165, 352)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(72, 13)
        HomePhoneLabel.TabIndex = 21
        HomePhoneLabel.Text = "Home Phone:"
        '
        'HomePhoneTextBox
        '
        Me.HomePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "HomePhone", True))
        Me.HomePhoneTextBox.Location = New System.Drawing.Point(266, 349)
        Me.HomePhoneTextBox.Name = "HomePhoneTextBox"
        Me.HomePhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HomePhoneTextBox.TabIndex = 22
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(165, 378)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(49, 13)
        BalanceLabel.TabIndex = 23
        BalanceLabel.Text = "Balance:"
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(266, 375)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BalanceTextBox.TabIndex = 24
        '
        'AccessCodeLabel
        '
        AccessCodeLabel.AutoSize = True
        AccessCodeLabel.Location = New System.Drawing.Point(165, 404)
        AccessCodeLabel.Name = "AccessCodeLabel"
        AccessCodeLabel.Size = New System.Drawing.Size(73, 13)
        AccessCodeLabel.TabIndex = 25
        AccessCodeLabel.Text = "Access Code:"
        '
        'AccessCodeTextBox
        '
        Me.AccessCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "AccessCode", True))
        Me.AccessCodeTextBox.Location = New System.Drawing.Point(266, 401)
        Me.AccessCodeTextBox.Name = "AccessCodeTextBox"
        Me.AccessCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AccessCodeTextBox.TabIndex = 26
        '
        'DateOpenedLabel
        '
        DateOpenedLabel.AutoSize = True
        DateOpenedLabel.Location = New System.Drawing.Point(165, 431)
        DateOpenedLabel.Name = "DateOpenedLabel"
        DateOpenedLabel.Size = New System.Drawing.Size(74, 13)
        DateOpenedLabel.TabIndex = 27
        DateOpenedLabel.Text = "Date Opened:"
        '
        'DateOpenedDateTimePicker
        '
        Me.DateOpenedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "DateOpened", True))
        Me.DateOpenedDateTimePicker.Location = New System.Drawing.Point(266, 427)
        Me.DateOpenedDateTimePicker.Name = "DateOpenedDateTimePicker"
        Me.DateOpenedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOpenedDateTimePicker.TabIndex = 28
        '
        'DigitalSignLabel
        '
        DigitalSignLabel.AutoSize = True
        DigitalSignLabel.Location = New System.Drawing.Point(165, 456)
        DigitalSignLabel.Name = "DigitalSignLabel"
        DigitalSignLabel.Size = New System.Drawing.Size(63, 13)
        DigitalSignLabel.TabIndex = 29
        DigitalSignLabel.Text = "Digital Sign:"
        '
        'DigitalSignTextBox
        '
        Me.DigitalSignTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "DigitalSign", True))
        Me.DigitalSignTextBox.Location = New System.Drawing.Point(266, 453)
        Me.DigitalSignTextBox.Name = "DigitalSignTextBox"
        Me.DigitalSignTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DigitalSignTextBox.TabIndex = 30
        '
        'CustomerPictureLabel
        '
        CustomerPictureLabel.AutoSize = True
        CustomerPictureLabel.Location = New System.Drawing.Point(165, 482)
        CustomerPictureLabel.Name = "CustomerPictureLabel"
        CustomerPictureLabel.Size = New System.Drawing.Size(90, 13)
        CustomerPictureLabel.TabIndex = 31
        CustomerPictureLabel.Text = "Customer Picture:"
        '
        'CustomerPictureTextBox
        '
        Me.CustomerPictureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerPicture", True))
        Me.CustomerPictureTextBox.Location = New System.Drawing.Point(266, 479)
        Me.CustomerPictureTextBox.Name = "CustomerPictureTextBox"
        Me.CustomerPictureTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerPictureTextBox.TabIndex = 32
        '
        'ATMCardNumberLabel
        '
        ATMCardNumberLabel.AutoSize = True
        ATMCardNumberLabel.Location = New System.Drawing.Point(165, 508)
        ATMCardNumberLabel.Name = "ATMCardNumberLabel"
        ATMCardNumberLabel.Size = New System.Drawing.Size(95, 13)
        ATMCardNumberLabel.TabIndex = 33
        ATMCardNumberLabel.Text = "ATMCard Number:"
        '
        'ATMCardNumberTextBox
        '
        Me.ATMCardNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ATMCardNumber", True))
        Me.ATMCardNumberTextBox.Location = New System.Drawing.Point(266, 505)
        Me.ATMCardNumberTextBox.Name = "ATMCardNumberTextBox"
        Me.ATMCardNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ATMCardNumberTextBox.TabIndex = 34
        '
        'ExpiryDateLabel
        '
        ExpiryDateLabel.AutoSize = True
        ExpiryDateLabel.Location = New System.Drawing.Point(165, 535)
        ExpiryDateLabel.Name = "ExpiryDateLabel"
        ExpiryDateLabel.Size = New System.Drawing.Size(64, 13)
        ExpiryDateLabel.TabIndex = 35
        ExpiryDateLabel.Text = "Expiry Date:"
        '
        'ExpiryDateDateTimePicker
        '
        Me.ExpiryDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "ExpiryDate", True))
        Me.ExpiryDateDateTimePicker.Location = New System.Drawing.Point(266, 531)
        Me.ExpiryDateDateTimePicker.Name = "ExpiryDateDateTimePicker"
        Me.ExpiryDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ExpiryDateDateTimePicker.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 26)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Welcome to Customer service "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(266, 570)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Submit to DB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(438, 570)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 570)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "View"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(519, 570)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(609, 570)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Customer_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 608)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(AccountNumberLabel)
        Me.Controls.Add(Me.AccountNumberTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(OfficeAddressLabel)
        Me.Controls.Add(Me.OfficeAddressTextBox)
        Me.Controls.Add(HomeAddressLabel)
        Me.Controls.Add(Me.HomeAddressTextBox)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(AccountTypeLabel)
        Me.Controls.Add(Me.AccountTypeTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(OfficePhoneLabel)
        Me.Controls.Add(Me.OfficePhoneTextBox)
        Me.Controls.Add(HomePhoneLabel)
        Me.Controls.Add(Me.HomePhoneTextBox)
        Me.Controls.Add(BalanceLabel)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(AccessCodeLabel)
        Me.Controls.Add(Me.AccessCodeTextBox)
        Me.Controls.Add(DateOpenedLabel)
        Me.Controls.Add(Me.DateOpenedDateTimePicker)
        Me.Controls.Add(DigitalSignLabel)
        Me.Controls.Add(Me.DigitalSignTextBox)
        Me.Controls.Add(CustomerPictureLabel)
        Me.Controls.Add(Me.CustomerPictureTextBox)
        Me.Controls.Add(ATMCardNumberLabel)
        Me.Controls.Add(Me.ATMCardNumberTextBox)
        Me.Controls.Add(ExpiryDateLabel)
        Me.Controls.Add(Me.ExpiryDateDateTimePicker)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Name = "Customer_form"
        Me.Text = "Customer_form"
        CType(Me.OnlineBankingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OnlineBankingDataSet As Home_page.OnlineBankingDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As Home_page.OnlineBankingDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Home_page.OnlineBankingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccountNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OfficeAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomeAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateOfBirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AccountTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OfficePhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomePhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccessCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateOpenedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DigitalSignTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerPictureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ATMCardNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpiryDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
