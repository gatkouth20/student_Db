<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ATM_Form
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
        Dim ATM_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim OthernameLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim POBLabel As System.Windows.Forms.Label
        Dim CountyLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim ID_passportNoLabel As System.Windows.Forms.Label
        Dim Issue_atLabel As System.Windows.Forms.Label
        Dim Residing_atLabel As System.Windows.Forms.Label
        Dim P_O_BoxLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim BranchnameLabel As System.Windows.Forms.Label
        Dim A_c_TitleLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Security_codeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ATM_Form))
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.ATM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATM_CardTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.ATM_CardTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.ATM_CardBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ATM_CardBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ATM_IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.OthernameTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.POBTextBox = New System.Windows.Forms.TextBox()
        Me.CountyTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.ID_passportNoTextBox = New System.Windows.Forms.TextBox()
        Me.Issue_atTextBox = New System.Windows.Forms.TextBox()
        Me.Residing_atTextBox = New System.Windows.Forms.TextBox()
        Me.P_O_BoxTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.BranchnameTextBox = New System.Windows.Forms.TextBox()
        Me.A_c_TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Security_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ATM_CardDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ATM_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        OthernameLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        POBLabel = New System.Windows.Forms.Label()
        CountyLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        ID_passportNoLabel = New System.Windows.Forms.Label()
        Issue_atLabel = New System.Windows.Forms.Label()
        Residing_atLabel = New System.Windows.Forms.Label()
        P_O_BoxLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        BranchnameLabel = New System.Windows.Forms.Label()
        A_c_TitleLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Security_codeLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATM_CardBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ATM_CardBindingNavigator.SuspendLayout()
        CType(Me.ATM_CardDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ATM_IDLabel
        '
        ATM_IDLabel.AutoSize = True
        ATM_IDLabel.Location = New System.Drawing.Point(32, 55)
        ATM_IDLabel.Name = "ATM_IDLabel"
        ATM_IDLabel.Size = New System.Drawing.Size(47, 13)
        ATM_IDLabel.TabIndex = 1
        ATM_IDLabel.Text = "ATM ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(32, 81)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'OthernameLabel
        '
        OthernameLabel.AutoSize = True
        OthernameLabel.Location = New System.Drawing.Point(32, 107)
        OthernameLabel.Name = "OthernameLabel"
        OthernameLabel.Size = New System.Drawing.Size(62, 13)
        OthernameLabel.TabIndex = 5
        OthernameLabel.Text = "Othername:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(32, 134)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 7
        DOBLabel.Text = "DOB:"
        '
        'POBLabel
        '
        POBLabel.AutoSize = True
        POBLabel.Location = New System.Drawing.Point(32, 159)
        POBLabel.Name = "POBLabel"
        POBLabel.Size = New System.Drawing.Size(32, 13)
        POBLabel.TabIndex = 9
        POBLabel.Text = "POB:"
        '
        'CountyLabel
        '
        CountyLabel.AutoSize = True
        CountyLabel.Location = New System.Drawing.Point(32, 185)
        CountyLabel.Name = "CountyLabel"
        CountyLabel.Size = New System.Drawing.Size(43, 13)
        CountyLabel.TabIndex = 11
        CountyLabel.Text = "County:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(32, 211)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 13
        CountryLabel.Text = "Country:"
        '
        'ID_passportNoLabel
        '
        ID_passportNoLabel.AutoSize = True
        ID_passportNoLabel.Location = New System.Drawing.Point(32, 237)
        ID_passportNoLabel.Name = "ID_passportNoLabel"
        ID_passportNoLabel.Size = New System.Drawing.Size(83, 13)
        ID_passportNoLabel.TabIndex = 15
        ID_passportNoLabel.Text = "ID/passport No:"
        '
        'Issue_atLabel
        '
        Issue_atLabel.AutoSize = True
        Issue_atLabel.Location = New System.Drawing.Point(32, 263)
        Issue_atLabel.Name = "Issue_atLabel"
        Issue_atLabel.Size = New System.Drawing.Size(47, 13)
        Issue_atLabel.TabIndex = 17
        Issue_atLabel.Text = "Issue at:"
        '
        'Residing_atLabel
        '
        Residing_atLabel.AutoSize = True
        Residing_atLabel.Location = New System.Drawing.Point(32, 289)
        Residing_atLabel.Name = "Residing_atLabel"
        Residing_atLabel.Size = New System.Drawing.Size(63, 13)
        Residing_atLabel.TabIndex = 19
        Residing_atLabel.Text = "Residing at:"
        '
        'P_O_BoxLabel
        '
        P_O_BoxLabel.AutoSize = True
        P_O_BoxLabel.Location = New System.Drawing.Point(32, 315)
        P_O_BoxLabel.Name = "P_O_BoxLabel"
        P_O_BoxLabel.Size = New System.Drawing.Size(49, 13)
        P_O_BoxLabel.TabIndex = 21
        P_O_BoxLabel.Text = "P O Box:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(32, 341)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 23
        TelephoneLabel.Text = "Telephone:"
        '
        'BranchnameLabel
        '
        BranchnameLabel.AutoSize = True
        BranchnameLabel.Location = New System.Drawing.Point(32, 367)
        BranchnameLabel.Name = "BranchnameLabel"
        BranchnameLabel.Size = New System.Drawing.Size(70, 13)
        BranchnameLabel.TabIndex = 25
        BranchnameLabel.Text = "Branchname:"
        '
        'A_c_TitleLabel
        '
        A_c_TitleLabel.AutoSize = True
        A_c_TitleLabel.Location = New System.Drawing.Point(32, 393)
        A_c_TitleLabel.Name = "A_c_TitleLabel"
        A_c_TitleLabel.Size = New System.Drawing.Size(51, 13)
        A_c_TitleLabel.TabIndex = 27
        A_c_TitleLabel.Text = "A/c Title:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(32, 420)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(31, 13)
        DateLabel.TabIndex = 29
        DateLabel.Text = "date:"
        '
        'Security_codeLabel
        '
        Security_codeLabel.AutoSize = True
        Security_codeLabel.Location = New System.Drawing.Point(32, 445)
        Security_codeLabel.Name = "Security_codeLabel"
        Security_codeLabel.Size = New System.Drawing.Size(75, 13)
        Security_codeLabel.TabIndex = 31
        Security_codeLabel.Text = "Security code:"
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ATM_CardBindingSource
        '
        Me.ATM_CardBindingSource.DataMember = "ATM Card"
        Me.ATM_CardBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'ATM_CardTableAdapter
        '
        Me.ATM_CardTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Account_closing_formTableAdapter = Nothing
        Me.TableAdapterManager.ATM_CardTableAdapter = Me.ATM_CardTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_Book_detailTableAdapter = Nothing
        Me.TableAdapterManager.Deposite_informationTableAdapter = Nothing
        Me.TableAdapterManager.Loan_informationTableAdapter = Nothing
        Me.TableAdapterManager.Official_Use_onlyTableAdapter = Nothing
        Me.TableAdapterManager.Opening_accountTableAdapter = Nothing
        Me.TableAdapterManager.student_accountTableAdapter = Nothing
        Me.TableAdapterManager.Transaction_infoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Withdrawal_formTableAdapter = Nothing
        Me.TableAdapterManager.Witness_informationTableAdapter = Nothing
        '
        'ATM_CardBindingNavigator
        '
        Me.ATM_CardBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ATM_CardBindingNavigator.BindingSource = Me.ATM_CardBindingSource
        Me.ATM_CardBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ATM_CardBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ATM_CardBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ATM_CardBindingNavigatorSaveItem})
        Me.ATM_CardBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ATM_CardBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ATM_CardBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ATM_CardBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ATM_CardBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ATM_CardBindingNavigator.Name = "ATM_CardBindingNavigator"
        Me.ATM_CardBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ATM_CardBindingNavigator.Size = New System.Drawing.Size(1209, 25)
        Me.ATM_CardBindingNavigator.TabIndex = 0
        Me.ATM_CardBindingNavigator.Text = "BindingNavigator1"
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
        'ATM_CardBindingNavigatorSaveItem
        '
        Me.ATM_CardBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ATM_CardBindingNavigatorSaveItem.Image = CType(resources.GetObject("ATM_CardBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ATM_CardBindingNavigatorSaveItem.Name = "ATM_CardBindingNavigatorSaveItem"
        Me.ATM_CardBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ATM_CardBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ATM_IDTextBox
        '
        Me.ATM_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "ATM_ID", True))
        Me.ATM_IDTextBox.Location = New System.Drawing.Point(121, 52)
        Me.ATM_IDTextBox.Name = "ATM_IDTextBox"
        Me.ATM_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ATM_IDTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(121, 78)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'OthernameTextBox
        '
        Me.OthernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "Othername", True))
        Me.OthernameTextBox.Location = New System.Drawing.Point(121, 104)
        Me.OthernameTextBox.Name = "OthernameTextBox"
        Me.OthernameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OthernameTextBox.TabIndex = 6
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ATM_CardBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(121, 130)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 8
        '
        'POBTextBox
        '
        Me.POBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "POB", True))
        Me.POBTextBox.Location = New System.Drawing.Point(121, 156)
        Me.POBTextBox.Name = "POBTextBox"
        Me.POBTextBox.Size = New System.Drawing.Size(200, 20)
        Me.POBTextBox.TabIndex = 10
        '
        'CountyTextBox
        '
        Me.CountyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "County", True))
        Me.CountyTextBox.Location = New System.Drawing.Point(121, 182)
        Me.CountyTextBox.Name = "CountyTextBox"
        Me.CountyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CountyTextBox.TabIndex = 12
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(121, 208)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CountryTextBox.TabIndex = 14
        '
        'ID_passportNoTextBox
        '
        Me.ID_passportNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "ID/passportNo", True))
        Me.ID_passportNoTextBox.Location = New System.Drawing.Point(121, 234)
        Me.ID_passportNoTextBox.Name = "ID_passportNoTextBox"
        Me.ID_passportNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_passportNoTextBox.TabIndex = 16
        '
        'Issue_atTextBox
        '
        Me.Issue_atTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "Issue at", True))
        Me.Issue_atTextBox.Location = New System.Drawing.Point(121, 260)
        Me.Issue_atTextBox.Name = "Issue_atTextBox"
        Me.Issue_atTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Issue_atTextBox.TabIndex = 18
        '
        'Residing_atTextBox
        '
        Me.Residing_atTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "Residing at", True))
        Me.Residing_atTextBox.Location = New System.Drawing.Point(121, 286)
        Me.Residing_atTextBox.Name = "Residing_atTextBox"
        Me.Residing_atTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Residing_atTextBox.TabIndex = 20
        '
        'P_O_BoxTextBox
        '
        Me.P_O_BoxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "P O Box", True))
        Me.P_O_BoxTextBox.Location = New System.Drawing.Point(121, 312)
        Me.P_O_BoxTextBox.Name = "P_O_BoxTextBox"
        Me.P_O_BoxTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_O_BoxTextBox.TabIndex = 22
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(121, 338)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelephoneTextBox.TabIndex = 24
        '
        'BranchnameTextBox
        '
        Me.BranchnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "Branchname", True))
        Me.BranchnameTextBox.Location = New System.Drawing.Point(121, 364)
        Me.BranchnameTextBox.Name = "BranchnameTextBox"
        Me.BranchnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BranchnameTextBox.TabIndex = 26
        '
        'A_c_TitleTextBox
        '
        Me.A_c_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "A/c Title", True))
        Me.A_c_TitleTextBox.Location = New System.Drawing.Point(121, 390)
        Me.A_c_TitleTextBox.Name = "A_c_TitleTextBox"
        Me.A_c_TitleTextBox.Size = New System.Drawing.Size(200, 20)
        Me.A_c_TitleTextBox.TabIndex = 28
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ATM_CardBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(121, 416)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 30
        '
        'Security_codeTextBox
        '
        Me.Security_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ATM_CardBindingSource, "Security code", True))
        Me.Security_codeTextBox.Location = New System.Drawing.Point(121, 442)
        Me.Security_codeTextBox.Name = "Security_codeTextBox"
        Me.Security_codeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Security_codeTextBox.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(246, 490)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(162, 490)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "View Item"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(327, 490)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(408, 490)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ATM_CardBindingSource
        Me.ComboBox1.DisplayMember = "ATM_ID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(725, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(933, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Searching"
        '
        'ATM_CardDataGridView
        '
        Me.ATM_CardDataGridView.AutoGenerateColumns = False
        Me.ATM_CardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ATM_CardDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.ATM_CardDataGridView.DataSource = Me.ATM_CardBindingSource
        Me.ATM_CardDataGridView.Location = New System.Drawing.Point(327, 52)
        Me.ATM_CardDataGridView.Name = "ATM_CardDataGridView"
        Me.ATM_CardDataGridView.Size = New System.Drawing.Size(882, 220)
        Me.ATM_CardDataGridView.TabIndex = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ATM_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ATM_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Othername"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Othername"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "POB"
        Me.DataGridViewTextBoxColumn5.HeaderText = "POB"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "County"
        Me.DataGridViewTextBoxColumn6.HeaderText = "County"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID/passportNo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID/passportNo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Issue at"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Issue at"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Residing at"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Residing at"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "P O Box"
        Me.DataGridViewTextBoxColumn11.HeaderText = "P O Box"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Branchname"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Branchname"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "A/c Title"
        Me.DataGridViewTextBoxColumn14.HeaderText = "A/c Title"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn15.HeaderText = "date"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Security code"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Security code"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'ATM_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 533)
        Me.Controls.Add(Me.ATM_CardDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ATM_IDLabel)
        Me.Controls.Add(Me.ATM_IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(OthernameLabel)
        Me.Controls.Add(Me.OthernameTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(POBLabel)
        Me.Controls.Add(Me.POBTextBox)
        Me.Controls.Add(CountyLabel)
        Me.Controls.Add(Me.CountyTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(ID_passportNoLabel)
        Me.Controls.Add(Me.ID_passportNoTextBox)
        Me.Controls.Add(Issue_atLabel)
        Me.Controls.Add(Me.Issue_atTextBox)
        Me.Controls.Add(Residing_atLabel)
        Me.Controls.Add(Me.Residing_atTextBox)
        Me.Controls.Add(P_O_BoxLabel)
        Me.Controls.Add(Me.P_O_BoxTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(BranchnameLabel)
        Me.Controls.Add(Me.BranchnameTextBox)
        Me.Controls.Add(A_c_TitleLabel)
        Me.Controls.Add(Me.A_c_TitleTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Security_codeLabel)
        Me.Controls.Add(Me.Security_codeTextBox)
        Me.Controls.Add(Me.ATM_CardBindingNavigator)
        Me.Name = "ATM_Form"
        Me.Text = "ATM_Form"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATM_CardBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ATM_CardBindingNavigator.ResumeLayout(False)
        Me.ATM_CardBindingNavigator.PerformLayout()
        CType(Me.ATM_CardDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents ATM_CardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ATM_CardTableAdapter As My_system.Banking_managmentDataSetTableAdapters.ATM_CardTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ATM_CardBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ATM_CardBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ATM_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OthernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents POBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_passportNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Issue_atTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Residing_atTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P_O_BoxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_c_TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Security_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ATM_CardDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
