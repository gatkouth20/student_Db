<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opening_Account_form
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim OthernameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Martial_statusLabel As System.Windows.Forms.Label
        Dim Account_typeLabel As System.Windows.Forms.Label
        Dim Business_typeLabel As System.Windows.Forms.Label
        Dim Profession_statusLabel As System.Windows.Forms.Label
        Dim NationalityLabel As System.Windows.Forms.Label
        Dim Country_of_residentLabel As System.Windows.Forms.Label
        Dim Postal_codeLabel As System.Windows.Forms.Label
        Dim TellLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Street_buildingLabel As System.Windows.Forms.Label
        Dim House_NumberLabel As System.Windows.Forms.Label
        Dim Type_NationalLabel As System.Windows.Forms.Label
        Dim ID_NOLabel As System.Windows.Forms.Label
        Dim Issuing__authorityLabel As System.Windows.Forms.Label
        Dim Place_of_issueLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opening_Account_form))
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.Opening_accountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Opening_accountTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.Opening_accountTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.Opening_accountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Opening_accountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.OthernameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Martial_statusTextBox = New System.Windows.Forms.TextBox()
        Me.Account_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Business_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Profession_statusTextBox = New System.Windows.Forms.TextBox()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.Country_of_residentTextBox = New System.Windows.Forms.TextBox()
        Me.Postal_codeTextBox = New System.Windows.Forms.TextBox()
        Me.TellTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Street_buildingTextBox = New System.Windows.Forms.TextBox()
        Me.House_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Type_NationalTextBox = New System.Windows.Forms.TextBox()
        Me.ID_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Issuing__authorityTextBox = New System.Windows.Forms.TextBox()
        Me.Place_of_issueTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        OthernameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Martial_statusLabel = New System.Windows.Forms.Label()
        Account_typeLabel = New System.Windows.Forms.Label()
        Business_typeLabel = New System.Windows.Forms.Label()
        Profession_statusLabel = New System.Windows.Forms.Label()
        NationalityLabel = New System.Windows.Forms.Label()
        Country_of_residentLabel = New System.Windows.Forms.Label()
        Postal_codeLabel = New System.Windows.Forms.Label()
        TellLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Street_buildingLabel = New System.Windows.Forms.Label()
        House_NumberLabel = New System.Windows.Forms.Label()
        Type_NationalLabel = New System.Windows.Forms.Label()
        ID_NOLabel = New System.Windows.Forms.Label()
        Issuing__authorityLabel = New System.Windows.Forms.Label()
        Place_of_issueLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Opening_accountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Opening_accountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Opening_accountBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(123, 44)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(21, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.Location = New System.Drawing.Point(85, 70)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(60, 13)
        SurnameLabel.TabIndex = 3
        SurnameLabel.Text = "Surname:"
        '
        'OthernameLabel
        '
        OthernameLabel.AutoSize = True
        OthernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OthernameLabel.Location = New System.Drawing.Point(73, 96)
        OthernameLabel.Name = "OthernameLabel"
        OthernameLabel.Size = New System.Drawing.Size(72, 13)
        OthernameLabel.TabIndex = 5
        OthernameLabel.Text = "Othername:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(92, 122)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(52, 13)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'Martial_statusLabel
        '
        Martial_statusLabel.AutoSize = True
        Martial_statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Martial_statusLabel.Location = New System.Drawing.Point(58, 151)
        Martial_statusLabel.Name = "Martial_statusLabel"
        Martial_statusLabel.Size = New System.Drawing.Size(87, 13)
        Martial_statusLabel.TabIndex = 9
        Martial_statusLabel.Text = "Martial status:"
        '
        'Account_typeLabel
        '
        Account_typeLabel.AutoSize = True
        Account_typeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Account_typeLabel.Location = New System.Drawing.Point(58, 174)
        Account_typeLabel.Name = "Account_typeLabel"
        Account_typeLabel.Size = New System.Drawing.Size(86, 13)
        Account_typeLabel.TabIndex = 11
        Account_typeLabel.Text = "Account type:"
        '
        'Business_typeLabel
        '
        Business_typeLabel.AutoSize = True
        Business_typeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Business_typeLabel.Location = New System.Drawing.Point(56, 200)
        Business_typeLabel.Name = "Business_typeLabel"
        Business_typeLabel.Size = New System.Drawing.Size(89, 13)
        Business_typeLabel.TabIndex = 13
        Business_typeLabel.Text = "Business type:"
        '
        'Profession_statusLabel
        '
        Profession_statusLabel.AutoSize = True
        Profession_statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Profession_statusLabel.Location = New System.Drawing.Point(31, 229)
        Profession_statusLabel.Name = "Profession_statusLabel"
        Profession_statusLabel.Size = New System.Drawing.Size(110, 13)
        Profession_statusLabel.TabIndex = 15
        Profession_statusLabel.Text = "Profession/status:"
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NationalityLabel.Location = New System.Drawing.Point(70, 252)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(71, 13)
        NationalityLabel.TabIndex = 17
        NationalityLabel.Text = "Nationality:"
        '
        'Country_of_residentLabel
        '
        Country_of_residentLabel.AutoSize = True
        Country_of_residentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Country_of_residentLabel.Location = New System.Drawing.Point(23, 278)
        Country_of_residentLabel.Name = "Country_of_residentLabel"
        Country_of_residentLabel.Size = New System.Drawing.Size(118, 13)
        Country_of_residentLabel.TabIndex = 19
        Country_of_residentLabel.Text = "Country of resident:"
        '
        'Postal_codeLabel
        '
        Postal_codeLabel.AutoSize = True
        Postal_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Postal_codeLabel.Location = New System.Drawing.Point(58, 304)
        Postal_codeLabel.Name = "Postal_codeLabel"
        Postal_codeLabel.Size = New System.Drawing.Size(77, 13)
        Postal_codeLabel.TabIndex = 21
        Postal_codeLabel.Text = "postal code:"
        '
        'TellLabel
        '
        TellLabel.AutoSize = True
        TellLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TellLabel.Location = New System.Drawing.Point(103, 330)
        TellLabel.Name = "TellLabel"
        TellLabel.Size = New System.Drawing.Size(32, 13)
        TellLabel.TabIndex = 23
        TellLabel.Text = "Tell:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(81, 356)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(60, 13)
        LocationLabel.TabIndex = 25
        LocationLabel.Text = "Location:"
        '
        'Street_buildingLabel
        '
        Street_buildingLabel.AutoSize = True
        Street_buildingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Street_buildingLabel.Location = New System.Drawing.Point(51, 385)
        Street_buildingLabel.Name = "Street_buildingLabel"
        Street_buildingLabel.Size = New System.Drawing.Size(93, 13)
        Street_buildingLabel.TabIndex = 27
        Street_buildingLabel.Text = "street/building:"
        '
        'House_NumberLabel
        '
        House_NumberLabel.AutoSize = True
        House_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_NumberLabel.Location = New System.Drawing.Point(51, 411)
        House_NumberLabel.Name = "House_NumberLabel"
        House_NumberLabel.Size = New System.Drawing.Size(94, 13)
        House_NumberLabel.TabIndex = 29
        House_NumberLabel.Text = "House Number:"
        '
        'Type_NationalLabel
        '
        Type_NationalLabel.AutoSize = True
        Type_NationalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Type_NationalLabel.Location = New System.Drawing.Point(51, 437)
        Type_NationalLabel.Name = "Type_NationalLabel"
        Type_NationalLabel.Size = New System.Drawing.Size(90, 13)
        Type_NationalLabel.TabIndex = 31
        Type_NationalLabel.Text = "Type National:"
        '
        'ID_NOLabel
        '
        ID_NOLabel.AutoSize = True
        ID_NOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_NOLabel.Location = New System.Drawing.Point(95, 460)
        ID_NOLabel.Name = "ID_NOLabel"
        ID_NOLabel.Size = New System.Drawing.Size(46, 13)
        ID_NOLabel.TabIndex = 33
        ID_NOLabel.Text = "ID NO:"
        '
        'Issuing__authorityLabel
        '
        Issuing__authorityLabel.AutoSize = True
        Issuing__authorityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Issuing__authorityLabel.Location = New System.Drawing.Point(36, 486)
        Issuing__authorityLabel.Name = "Issuing__authorityLabel"
        Issuing__authorityLabel.Size = New System.Drawing.Size(108, 13)
        Issuing__authorityLabel.TabIndex = 35
        Issuing__authorityLabel.Text = "Issuing  authority:"
        '
        'Place_of_issueLabel
        '
        Place_of_issueLabel.AutoSize = True
        Place_of_issueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Place_of_issueLabel.Location = New System.Drawing.Point(51, 515)
        Place_of_issueLabel.Name = "Place_of_issueLabel"
        Place_of_issueLabel.Size = New System.Drawing.Size(91, 13)
        Place_of_issueLabel.TabIndex = 37
        Place_of_issueLabel.Text = "Place of issue:"
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Opening_accountBindingSource
        '
        Me.Opening_accountBindingSource.DataMember = "Opening account"
        Me.Opening_accountBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'Opening_accountTableAdapter
        '
        Me.Opening_accountTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Account_closing_formTableAdapter = Nothing
        Me.TableAdapterManager.ATM_CardTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_Book_detailTableAdapter = Nothing
        Me.TableAdapterManager.Deposite_informationTableAdapter = Nothing
        Me.TableAdapterManager.Loan_informationTableAdapter = Nothing
        Me.TableAdapterManager.Official_Use_onlyTableAdapter = Nothing
        Me.TableAdapterManager.Opening_accountTableAdapter = Me.Opening_accountTableAdapter
        Me.TableAdapterManager.student_accountTableAdapter = Nothing
        Me.TableAdapterManager.Transaction_infoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Withdrawal_formTableAdapter = Nothing
        Me.TableAdapterManager.Witness_informationTableAdapter = Nothing
        '
        'Opening_accountBindingNavigator
        '
        Me.Opening_accountBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Opening_accountBindingNavigator.BindingSource = Me.Opening_accountBindingSource
        Me.Opening_accountBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Opening_accountBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Opening_accountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Opening_accountBindingNavigatorSaveItem})
        Me.Opening_accountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Opening_accountBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Opening_accountBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Opening_accountBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Opening_accountBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Opening_accountBindingNavigator.Name = "Opening_accountBindingNavigator"
        Me.Opening_accountBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Opening_accountBindingNavigator.Size = New System.Drawing.Size(986, 25)
        Me.Opening_accountBindingNavigator.TabIndex = 0
        Me.Opening_accountBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Opening_accountBindingNavigatorSaveItem
        '
        Me.Opening_accountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Opening_accountBindingNavigatorSaveItem.Image = CType(resources.GetObject("Opening_accountBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Opening_accountBindingNavigatorSaveItem.Name = "Opening_accountBindingNavigatorSaveItem"
        Me.Opening_accountBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Opening_accountBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(155, 44)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(155, 70)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTextBox.TabIndex = 4
        '
        'OthernameTextBox
        '
        Me.OthernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Othername", True))
        Me.OthernameTextBox.Location = New System.Drawing.Point(155, 96)
        Me.OthernameTextBox.Name = "OthernameTextBox"
        Me.OthernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OthernameTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(155, 122)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 8
        '
        'Martial_statusTextBox
        '
        Me.Martial_statusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Martial status", True))
        Me.Martial_statusTextBox.Location = New System.Drawing.Point(155, 148)
        Me.Martial_statusTextBox.Name = "Martial_statusTextBox"
        Me.Martial_statusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Martial_statusTextBox.TabIndex = 10
        '
        'Account_typeTextBox
        '
        Me.Account_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Account type", True))
        Me.Account_typeTextBox.Location = New System.Drawing.Point(155, 174)
        Me.Account_typeTextBox.Name = "Account_typeTextBox"
        Me.Account_typeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Account_typeTextBox.TabIndex = 12
        '
        'Business_typeTextBox
        '
        Me.Business_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Business type", True))
        Me.Business_typeTextBox.Location = New System.Drawing.Point(155, 200)
        Me.Business_typeTextBox.Name = "Business_typeTextBox"
        Me.Business_typeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Business_typeTextBox.TabIndex = 14
        '
        'Profession_statusTextBox
        '
        Me.Profession_statusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Profession/status", True))
        Me.Profession_statusTextBox.Location = New System.Drawing.Point(155, 226)
        Me.Profession_statusTextBox.Name = "Profession_statusTextBox"
        Me.Profession_statusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Profession_statusTextBox.TabIndex = 16
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Nationality", True))
        Me.NationalityTextBox.Location = New System.Drawing.Point(155, 252)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NationalityTextBox.TabIndex = 18
        '
        'Country_of_residentTextBox
        '
        Me.Country_of_residentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Country of resident", True))
        Me.Country_of_residentTextBox.Location = New System.Drawing.Point(155, 278)
        Me.Country_of_residentTextBox.Name = "Country_of_residentTextBox"
        Me.Country_of_residentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Country_of_residentTextBox.TabIndex = 20
        '
        'Postal_codeTextBox
        '
        Me.Postal_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "postal code", True))
        Me.Postal_codeTextBox.Location = New System.Drawing.Point(155, 304)
        Me.Postal_codeTextBox.Name = "Postal_codeTextBox"
        Me.Postal_codeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Postal_codeTextBox.TabIndex = 22
        '
        'TellTextBox
        '
        Me.TellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Tell", True))
        Me.TellTextBox.Location = New System.Drawing.Point(155, 330)
        Me.TellTextBox.Name = "TellTextBox"
        Me.TellTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TellTextBox.TabIndex = 24
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(155, 356)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocationTextBox.TabIndex = 26
        '
        'Street_buildingTextBox
        '
        Me.Street_buildingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "street/building", True))
        Me.Street_buildingTextBox.Location = New System.Drawing.Point(155, 382)
        Me.Street_buildingTextBox.Name = "Street_buildingTextBox"
        Me.Street_buildingTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Street_buildingTextBox.TabIndex = 28
        '
        'House_NumberTextBox
        '
        Me.House_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "House Number", True))
        Me.House_NumberTextBox.Location = New System.Drawing.Point(155, 408)
        Me.House_NumberTextBox.Name = "House_NumberTextBox"
        Me.House_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.House_NumberTextBox.TabIndex = 30
        '
        'Type_NationalTextBox
        '
        Me.Type_NationalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Type National", True))
        Me.Type_NationalTextBox.Location = New System.Drawing.Point(155, 434)
        Me.Type_NationalTextBox.Name = "Type_NationalTextBox"
        Me.Type_NationalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Type_NationalTextBox.TabIndex = 32
        '
        'ID_NOTextBox
        '
        Me.ID_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "ID NO", True))
        Me.ID_NOTextBox.Location = New System.Drawing.Point(155, 460)
        Me.ID_NOTextBox.Name = "ID_NOTextBox"
        Me.ID_NOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_NOTextBox.TabIndex = 34
        '
        'Issuing__authorityTextBox
        '
        Me.Issuing__authorityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Issuing  authority", True))
        Me.Issuing__authorityTextBox.Location = New System.Drawing.Point(155, 486)
        Me.Issuing__authorityTextBox.Name = "Issuing__authorityTextBox"
        Me.Issuing__authorityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Issuing__authorityTextBox.TabIndex = 36
        '
        'Place_of_issueTextBox
        '
        Me.Place_of_issueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Opening_accountBindingSource, "Place of issue", True))
        Me.Place_of_issueTextBox.Location = New System.Drawing.Point(155, 512)
        Me.Place_of_issueTextBox.Name = "Place_of_issueTextBox"
        Me.Place_of_issueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Place_of_issueTextBox.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 548)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(236, 548)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(317, 548)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(398, 548)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(479, 548)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(261, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(713, 458)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Opening_accountBindingSource
        Me.ComboBox1.DisplayMember = "Surname"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(587, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox1.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(780, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Searching"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(560, 548)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 47
        Me.Button6.Text = "Officer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Opening_Account_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 590)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(OthernameLabel)
        Me.Controls.Add(Me.OthernameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Martial_statusLabel)
        Me.Controls.Add(Me.Martial_statusTextBox)
        Me.Controls.Add(Account_typeLabel)
        Me.Controls.Add(Me.Account_typeTextBox)
        Me.Controls.Add(Business_typeLabel)
        Me.Controls.Add(Me.Business_typeTextBox)
        Me.Controls.Add(Profession_statusLabel)
        Me.Controls.Add(Me.Profession_statusTextBox)
        Me.Controls.Add(NationalityLabel)
        Me.Controls.Add(Me.NationalityTextBox)
        Me.Controls.Add(Country_of_residentLabel)
        Me.Controls.Add(Me.Country_of_residentTextBox)
        Me.Controls.Add(Postal_codeLabel)
        Me.Controls.Add(Me.Postal_codeTextBox)
        Me.Controls.Add(TellLabel)
        Me.Controls.Add(Me.TellTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Street_buildingLabel)
        Me.Controls.Add(Me.Street_buildingTextBox)
        Me.Controls.Add(House_NumberLabel)
        Me.Controls.Add(Me.House_NumberTextBox)
        Me.Controls.Add(Type_NationalLabel)
        Me.Controls.Add(Me.Type_NationalTextBox)
        Me.Controls.Add(ID_NOLabel)
        Me.Controls.Add(Me.ID_NOTextBox)
        Me.Controls.Add(Issuing__authorityLabel)
        Me.Controls.Add(Me.Issuing__authorityTextBox)
        Me.Controls.Add(Place_of_issueLabel)
        Me.Controls.Add(Me.Place_of_issueTextBox)
        Me.Controls.Add(Me.Opening_accountBindingNavigator)
        Me.Name = "Opening_Account_form"
        Me.Text = "Opening_Account_form"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Opening_accountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Opening_accountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Opening_accountBindingNavigator.ResumeLayout(False)
        Me.Opening_accountBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents Opening_accountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Opening_accountTableAdapter As My_system.Banking_managmentDataSetTableAdapters.Opening_accountTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Opening_accountBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Opening_accountBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OthernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Martial_statusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Account_typeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Business_typeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Profession_statusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NationalityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Country_of_residentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Postal_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TellTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Street_buildingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents House_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Type_NationalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Issuing__authorityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Place_of_issueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
