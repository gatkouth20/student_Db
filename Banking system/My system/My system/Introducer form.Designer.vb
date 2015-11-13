<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Introducer_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Introducer_form))
        Dim W_IDLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim OthernameLabel As System.Windows.Forms.Label
        Dim A_C_NoLabel As System.Windows.Forms.Label
        Dim Branch_nameLabel As System.Windows.Forms.Label
        Dim Place_of_workLabel As System.Windows.Forms.Label
        Dim Name_of_employerLabel As System.Windows.Forms.Label
        Dim Date_of_employedLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim StationLabel As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim Staff_NoLabel As System.Windows.Forms.Label
        Dim Building_nameLabel As System.Windows.Forms.Label
        Dim Block_NOLabel As System.Windows.Forms.Label
        Dim Office_TellLabel As System.Windows.Forms.Label
        Dim Email_addressLabel As System.Windows.Forms.Label
        Dim Estimated_income_levelLabel As System.Windows.Forms.Label
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.Witness_informationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Witness_informationTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.Witness_informationTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.Witness_informationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Witness_informationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.W_IDTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.OthernameTextBox = New System.Windows.Forms.TextBox()
        Me.A_C_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Branch_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Place_of_workTextBox = New System.Windows.Forms.TextBox()
        Me.Name_of_employerTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_employedTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.StationTextBox = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Building_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Block_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Office_TellTextBox = New System.Windows.Forms.TextBox()
        Me.Email_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Estimated_income_levelTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        W_IDLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        OthernameLabel = New System.Windows.Forms.Label()
        A_C_NoLabel = New System.Windows.Forms.Label()
        Branch_nameLabel = New System.Windows.Forms.Label()
        Place_of_workLabel = New System.Windows.Forms.Label()
        Name_of_employerLabel = New System.Windows.Forms.Label()
        Date_of_employedLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        StationLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        Staff_NoLabel = New System.Windows.Forms.Label()
        Building_nameLabel = New System.Windows.Forms.Label()
        Block_NOLabel = New System.Windows.Forms.Label()
        Office_TellLabel = New System.Windows.Forms.Label()
        Email_addressLabel = New System.Windows.Forms.Label()
        Estimated_income_levelLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Witness_informationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Witness_informationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Witness_informationBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Witness_informationBindingSource
        '
        Me.Witness_informationBindingSource.DataMember = "Witness information"
        Me.Witness_informationBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'Witness_informationTableAdapter
        '
        Me.Witness_informationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Opening_accountTableAdapter = Nothing
        Me.TableAdapterManager.student_accountTableAdapter = Nothing
        Me.TableAdapterManager.Transaction_infoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Withdrawal_formTableAdapter = Nothing
        Me.TableAdapterManager.Witness_informationTableAdapter = Me.Witness_informationTableAdapter
        '
        'Witness_informationBindingNavigator
        '
        Me.Witness_informationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Witness_informationBindingNavigator.BindingSource = Me.Witness_informationBindingSource
        Me.Witness_informationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Witness_informationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Witness_informationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Witness_informationBindingNavigatorSaveItem})
        Me.Witness_informationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Witness_informationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Witness_informationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Witness_informationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Witness_informationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Witness_informationBindingNavigator.Name = "Witness_informationBindingNavigator"
        Me.Witness_informationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Witness_informationBindingNavigator.Size = New System.Drawing.Size(978, 25)
        Me.Witness_informationBindingNavigator.TabIndex = 0
        Me.Witness_informationBindingNavigator.Text = "BindingNavigator1"
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
        'Witness_informationBindingNavigatorSaveItem
        '
        Me.Witness_informationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Witness_informationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Witness_informationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Witness_informationBindingNavigatorSaveItem.Name = "Witness_informationBindingNavigatorSaveItem"
        Me.Witness_informationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Witness_informationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'W_IDLabel
        '
        W_IDLabel.AutoSize = True
        W_IDLabel.Location = New System.Drawing.Point(111, 43)
        W_IDLabel.Name = "W_IDLabel"
        W_IDLabel.Size = New System.Drawing.Size(35, 13)
        W_IDLabel.TabIndex = 1
        W_IDLabel.Text = "W ID:"
        '
        'W_IDTextBox
        '
        Me.W_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "W_ID", True))
        Me.W_IDTextBox.Location = New System.Drawing.Point(160, 43)
        Me.W_IDTextBox.Name = "W_IDTextBox"
        Me.W_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.W_IDTextBox.TabIndex = 2
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(94, 69)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 3
        SurnameLabel.Text = "Surname:"
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(160, 69)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTextBox.TabIndex = 4
        '
        'OthernameLabel
        '
        OthernameLabel.AutoSize = True
        OthernameLabel.Location = New System.Drawing.Point(90, 95)
        OthernameLabel.Name = "OthernameLabel"
        OthernameLabel.Size = New System.Drawing.Size(62, 13)
        OthernameLabel.TabIndex = 5
        OthernameLabel.Text = "Othername:"
        '
        'OthernameTextBox
        '
        Me.OthernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Othername", True))
        Me.OthernameTextBox.Location = New System.Drawing.Point(160, 95)
        Me.OthernameTextBox.Name = "OthernameTextBox"
        Me.OthernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OthernameTextBox.TabIndex = 6
        '
        'A_C_NoLabel
        '
        A_C_NoLabel.AutoSize = True
        A_C_NoLabel.Location = New System.Drawing.Point(100, 124)
        A_C_NoLabel.Name = "A_C_NoLabel"
        A_C_NoLabel.Size = New System.Drawing.Size(46, 13)
        A_C_NoLabel.TabIndex = 7
        A_C_NoLabel.Text = "A/C No:"
        '
        'A_C_NoTextBox
        '
        Me.A_C_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "A/C No", True))
        Me.A_C_NoTextBox.Location = New System.Drawing.Point(160, 121)
        Me.A_C_NoTextBox.Name = "A_C_NoTextBox"
        Me.A_C_NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.A_C_NoTextBox.TabIndex = 8
        '
        'Branch_nameLabel
        '
        Branch_nameLabel.AutoSize = True
        Branch_nameLabel.Location = New System.Drawing.Point(73, 150)
        Branch_nameLabel.Name = "Branch_nameLabel"
        Branch_nameLabel.Size = New System.Drawing.Size(73, 13)
        Branch_nameLabel.TabIndex = 9
        Branch_nameLabel.Text = "Branch name:"
        '
        'Branch_nameTextBox
        '
        Me.Branch_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Branch name", True))
        Me.Branch_nameTextBox.Location = New System.Drawing.Point(160, 147)
        Me.Branch_nameTextBox.Name = "Branch_nameTextBox"
        Me.Branch_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Branch_nameTextBox.TabIndex = 10
        '
        'Place_of_workLabel
        '
        Place_of_workLabel.AutoSize = True
        Place_of_workLabel.Location = New System.Drawing.Point(71, 173)
        Place_of_workLabel.Name = "Place_of_workLabel"
        Place_of_workLabel.Size = New System.Drawing.Size(75, 13)
        Place_of_workLabel.TabIndex = 11
        Place_of_workLabel.Text = "Place of work:"
        '
        'Place_of_workTextBox
        '
        Me.Place_of_workTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Place of work", True))
        Me.Place_of_workTextBox.Location = New System.Drawing.Point(160, 173)
        Me.Place_of_workTextBox.Name = "Place_of_workTextBox"
        Me.Place_of_workTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Place_of_workTextBox.TabIndex = 12
        '
        'Name_of_employerLabel
        '
        Name_of_employerLabel.AutoSize = True
        Name_of_employerLabel.Location = New System.Drawing.Point(57, 199)
        Name_of_employerLabel.Name = "Name_of_employerLabel"
        Name_of_employerLabel.Size = New System.Drawing.Size(95, 13)
        Name_of_employerLabel.TabIndex = 13
        Name_of_employerLabel.Text = "Name of employer:"
        '
        'Name_of_employerTextBox
        '
        Me.Name_of_employerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Name of employer", True))
        Me.Name_of_employerTextBox.Location = New System.Drawing.Point(160, 199)
        Me.Name_of_employerTextBox.Name = "Name_of_employerTextBox"
        Me.Name_of_employerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Name_of_employerTextBox.TabIndex = 14
        '
        'Date_of_employedLabel
        '
        Date_of_employedLabel.AutoSize = True
        Date_of_employedLabel.Location = New System.Drawing.Point(57, 225)
        Date_of_employedLabel.Name = "Date_of_employedLabel"
        Date_of_employedLabel.Size = New System.Drawing.Size(93, 13)
        Date_of_employedLabel.TabIndex = 15
        Date_of_employedLabel.Text = "Date of employed:"
        '
        'Date_of_employedTextBox
        '
        Me.Date_of_employedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Date of employed", True))
        Me.Date_of_employedTextBox.Location = New System.Drawing.Point(160, 225)
        Me.Date_of_employedTextBox.Name = "Date_of_employedTextBox"
        Me.Date_of_employedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Date_of_employedTextBox.TabIndex = 16
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(85, 251)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 17
        DepartmentLabel.Text = "Department:"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(160, 251)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DepartmentTextBox.TabIndex = 18
        '
        'StationLabel
        '
        StationLabel.AutoSize = True
        StationLabel.Location = New System.Drawing.Point(105, 284)
        StationLabel.Name = "StationLabel"
        StationLabel.Size = New System.Drawing.Size(41, 13)
        StationLabel.TabIndex = 19
        StationLabel.Text = "station:"
        '
        'StationTextBox
        '
        Me.StationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "station", True))
        Me.StationTextBox.Location = New System.Drawing.Point(160, 277)
        Me.StationTextBox.Name = "StationTextBox"
        Me.StationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StationTextBox.TabIndex = 20
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Location = New System.Drawing.Point(86, 310)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(66, 13)
        DesignationLabel.TabIndex = 21
        DesignationLabel.Text = "Designation:"
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Designation", True))
        Me.DesignationTextBox.Location = New System.Drawing.Point(160, 303)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DesignationTextBox.TabIndex = 22
        '
        'Staff_NoLabel
        '
        Staff_NoLabel.AutoSize = True
        Staff_NoLabel.Location = New System.Drawing.Point(105, 336)
        Staff_NoLabel.Name = "Staff_NoLabel"
        Staff_NoLabel.Size = New System.Drawing.Size(47, 13)
        Staff_NoLabel.TabIndex = 23
        Staff_NoLabel.Text = "staff No:"
        '
        'Staff_NoTextBox
        '
        Me.Staff_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "staff_No", True))
        Me.Staff_NoTextBox.Location = New System.Drawing.Point(160, 329)
        Me.Staff_NoTextBox.Name = "Staff_NoTextBox"
        Me.Staff_NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Staff_NoTextBox.TabIndex = 24
        '
        'Building_nameLabel
        '
        Building_nameLabel.AutoSize = True
        Building_nameLabel.Location = New System.Drawing.Point(76, 362)
        Building_nameLabel.Name = "Building_nameLabel"
        Building_nameLabel.Size = New System.Drawing.Size(76, 13)
        Building_nameLabel.TabIndex = 25
        Building_nameLabel.Text = "Building name:"
        '
        'Building_nameTextBox
        '
        Me.Building_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Building name", True))
        Me.Building_nameTextBox.Location = New System.Drawing.Point(160, 355)
        Me.Building_nameTextBox.Name = "Building_nameTextBox"
        Me.Building_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Building_nameTextBox.TabIndex = 26
        '
        'Block_NOLabel
        '
        Block_NOLabel.AutoSize = True
        Block_NOLabel.Location = New System.Drawing.Point(96, 384)
        Block_NOLabel.Name = "Block_NOLabel"
        Block_NOLabel.Size = New System.Drawing.Size(56, 13)
        Block_NOLabel.TabIndex = 27
        Block_NOLabel.Text = "Block NO:"
        '
        'Block_NOTextBox
        '
        Me.Block_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Block_NO", True))
        Me.Block_NOTextBox.Location = New System.Drawing.Point(160, 381)
        Me.Block_NOTextBox.Name = "Block_NOTextBox"
        Me.Block_NOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Block_NOTextBox.TabIndex = 28
        '
        'Office_TellLabel
        '
        Office_TellLabel.AutoSize = True
        Office_TellLabel.Location = New System.Drawing.Point(96, 410)
        Office_TellLabel.Name = "Office_TellLabel"
        Office_TellLabel.Size = New System.Drawing.Size(58, 13)
        Office_TellLabel.TabIndex = 29
        Office_TellLabel.Text = "Office Tell:"
        '
        'Office_TellTextBox
        '
        Me.Office_TellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Office Tell", True))
        Me.Office_TellTextBox.Location = New System.Drawing.Point(160, 407)
        Me.Office_TellTextBox.Name = "Office_TellTextBox"
        Me.Office_TellTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Office_TellTextBox.TabIndex = 30
        '
        'Email_addressLabel
        '
        Email_addressLabel.AutoSize = True
        Email_addressLabel.Location = New System.Drawing.Point(79, 436)
        Email_addressLabel.Name = "Email_addressLabel"
        Email_addressLabel.Size = New System.Drawing.Size(75, 13)
        Email_addressLabel.TabIndex = 31
        Email_addressLabel.Text = "Email address:"
        '
        'Email_addressTextBox
        '
        Me.Email_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Email address", True))
        Me.Email_addressTextBox.Location = New System.Drawing.Point(160, 433)
        Me.Email_addressTextBox.Name = "Email_addressTextBox"
        Me.Email_addressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Email_addressTextBox.TabIndex = 32
        '
        'Estimated_income_levelLabel
        '
        Estimated_income_levelLabel.AutoSize = True
        Estimated_income_levelLabel.Location = New System.Drawing.Point(36, 462)
        Estimated_income_levelLabel.Name = "Estimated_income_levelLabel"
        Estimated_income_levelLabel.Size = New System.Drawing.Size(118, 13)
        Estimated_income_levelLabel.TabIndex = 33
        Estimated_income_levelLabel.Text = "Estimated income level:"
        '
        'Estimated_income_levelTextBox
        '
        Me.Estimated_income_levelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Witness_informationBindingSource, "Estimated income level", True))
        Me.Estimated_income_levelTextBox.Location = New System.Drawing.Point(160, 459)
        Me.Estimated_income_levelTextBox.Name = "Estimated_income_levelTextBox"
        Me.Estimated_income_levelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Estimated_income_levelTextBox.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(149, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(230, 498)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "View Db"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(311, 498)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(392, 498)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(473, 498)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(266, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(712, 432)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(506, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(205, 21)
        Me.ComboBox1.TabIndex = 41
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(720, 18)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Searching"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Introducer_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 527)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(W_IDLabel)
        Me.Controls.Add(Me.W_IDTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(OthernameLabel)
        Me.Controls.Add(Me.OthernameTextBox)
        Me.Controls.Add(A_C_NoLabel)
        Me.Controls.Add(Me.A_C_NoTextBox)
        Me.Controls.Add(Branch_nameLabel)
        Me.Controls.Add(Me.Branch_nameTextBox)
        Me.Controls.Add(Place_of_workLabel)
        Me.Controls.Add(Me.Place_of_workTextBox)
        Me.Controls.Add(Name_of_employerLabel)
        Me.Controls.Add(Me.Name_of_employerTextBox)
        Me.Controls.Add(Date_of_employedLabel)
        Me.Controls.Add(Me.Date_of_employedTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(StationLabel)
        Me.Controls.Add(Me.StationTextBox)
        Me.Controls.Add(DesignationLabel)
        Me.Controls.Add(Me.DesignationTextBox)
        Me.Controls.Add(Staff_NoLabel)
        Me.Controls.Add(Me.Staff_NoTextBox)
        Me.Controls.Add(Building_nameLabel)
        Me.Controls.Add(Me.Building_nameTextBox)
        Me.Controls.Add(Block_NOLabel)
        Me.Controls.Add(Me.Block_NOTextBox)
        Me.Controls.Add(Office_TellLabel)
        Me.Controls.Add(Me.Office_TellTextBox)
        Me.Controls.Add(Email_addressLabel)
        Me.Controls.Add(Me.Email_addressTextBox)
        Me.Controls.Add(Estimated_income_levelLabel)
        Me.Controls.Add(Me.Estimated_income_levelTextBox)
        Me.Controls.Add(Me.Witness_informationBindingNavigator)
        Me.Name = "Introducer_form"
        Me.Text = "Introducer_form"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Witness_informationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Witness_informationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Witness_informationBindingNavigator.ResumeLayout(False)
        Me.Witness_informationBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents Witness_informationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Witness_informationTableAdapter As My_system.Banking_managmentDataSetTableAdapters.Witness_informationTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Witness_informationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Witness_informationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents W_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OthernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_C_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Branch_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Place_of_workTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_of_employerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_employedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesignationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Staff_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Building_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Block_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Office_TellTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Estimated_income_levelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
