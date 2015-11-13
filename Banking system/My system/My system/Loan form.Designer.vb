<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan_form
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
        Dim LOANIDLabel As System.Windows.Forms.Label
        Dim FullnameLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Contact_addressLabel As System.Windows.Forms.Label
        Dim Martial_statusLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim Monthly_incomeLabel As System.Windows.Forms.Label
        Dim Loan_durationLabel As System.Windows.Forms.Label
        Dim Purpose_of_loanLabel As System.Windows.Forms.Label
        Dim Loan_amountLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Tell_MobileNoLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim SignatureLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loan_form))
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.Loan_informationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Loan_informationTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.Loan_informationTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.Loan_informationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Loan_informationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LOANIDTextBox = New System.Windows.Forms.TextBox()
        Me.FullnameTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Contact_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Martial_statusTextBox = New System.Windows.Forms.TextBox()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.Monthly_incomeTextBox = New System.Windows.Forms.TextBox()
        Me.Loan_durationTextBox = New System.Windows.Forms.TextBox()
        Me.Purpose_of_loanTextBox = New System.Windows.Forms.TextBox()
        Me.Loan_amountTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Tell_MobileNoTextBox = New System.Windows.Forms.TextBox()
        Me.ReligionTextBox = New System.Windows.Forms.TextBox()
        Me.SignatureTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        LOANIDLabel = New System.Windows.Forms.Label()
        FullnameLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Contact_addressLabel = New System.Windows.Forms.Label()
        Martial_statusLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        Monthly_incomeLabel = New System.Windows.Forms.Label()
        Loan_durationLabel = New System.Windows.Forms.Label()
        Purpose_of_loanLabel = New System.Windows.Forms.Label()
        Loan_amountLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Tell_MobileNoLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        SignatureLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loan_informationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loan_informationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Loan_informationBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LOANIDLabel
        '
        LOANIDLabel.AutoSize = True
        LOANIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LOANIDLabel.Location = New System.Drawing.Point(96, 69)
        LOANIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LOANIDLabel.Name = "LOANIDLabel"
        LOANIDLabel.Size = New System.Drawing.Size(60, 16)
        LOANIDLabel.TabIndex = 1
        LOANIDLabel.Text = "LOANID:"
        '
        'FullnameLabel
        '
        FullnameLabel.AutoSize = True
        FullnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FullnameLabel.Location = New System.Drawing.Point(96, 101)
        FullnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FullnameLabel.Name = "FullnameLabel"
        FullnameLabel.Size = New System.Drawing.Size(66, 16)
        FullnameLabel.TabIndex = 3
        FullnameLabel.Text = "Fullname:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(96, 134)
        DOBLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(40, 16)
        DOBLabel.TabIndex = 5
        DOBLabel.Text = "DOB:"
        '
        'Contact_addressLabel
        '
        Contact_addressLabel.AutoSize = True
        Contact_addressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_addressLabel.Location = New System.Drawing.Point(96, 165)
        Contact_addressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Contact_addressLabel.Name = "Contact_addressLabel"
        Contact_addressLabel.Size = New System.Drawing.Size(109, 16)
        Contact_addressLabel.TabIndex = 7
        Contact_addressLabel.Text = "Contact address:"
        '
        'Martial_statusLabel
        '
        Martial_statusLabel.AutoSize = True
        Martial_statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Martial_statusLabel.Location = New System.Drawing.Point(96, 197)
        Martial_statusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Martial_statusLabel.Name = "Martial_statusLabel"
        Martial_statusLabel.Size = New System.Drawing.Size(89, 16)
        Martial_statusLabel.TabIndex = 9
        Martial_statusLabel.Text = "Martial status:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OccupationLabel.Location = New System.Drawing.Point(96, 229)
        OccupationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(79, 16)
        OccupationLabel.TabIndex = 11
        OccupationLabel.Text = "Occupation:"
        '
        'Monthly_incomeLabel
        '
        Monthly_incomeLabel.AutoSize = True
        Monthly_incomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Monthly_incomeLabel.Location = New System.Drawing.Point(96, 261)
        Monthly_incomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Monthly_incomeLabel.Name = "Monthly_incomeLabel"
        Monthly_incomeLabel.Size = New System.Drawing.Size(104, 16)
        Monthly_incomeLabel.TabIndex = 13
        Monthly_incomeLabel.Text = "Monthly income:"
        '
        'Loan_durationLabel
        '
        Loan_durationLabel.AutoSize = True
        Loan_durationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Loan_durationLabel.Location = New System.Drawing.Point(96, 293)
        Loan_durationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Loan_durationLabel.Name = "Loan_durationLabel"
        Loan_durationLabel.Size = New System.Drawing.Size(92, 16)
        Loan_durationLabel.TabIndex = 15
        Loan_durationLabel.Text = "Loan duration:"
        '
        'Purpose_of_loanLabel
        '
        Purpose_of_loanLabel.AutoSize = True
        Purpose_of_loanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Purpose_of_loanLabel.Location = New System.Drawing.Point(96, 325)
        Purpose_of_loanLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Purpose_of_loanLabel.Name = "Purpose_of_loanLabel"
        Purpose_of_loanLabel.Size = New System.Drawing.Size(105, 16)
        Purpose_of_loanLabel.TabIndex = 17
        Purpose_of_loanLabel.Text = "Purpose of loan:"
        '
        'Loan_amountLabel
        '
        Loan_amountLabel.AutoSize = True
        Loan_amountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Loan_amountLabel.Location = New System.Drawing.Point(96, 357)
        Loan_amountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Loan_amountLabel.Name = "Loan_amountLabel"
        Loan_amountLabel.Size = New System.Drawing.Size(88, 16)
        Loan_amountLabel.TabIndex = 19
        Loan_amountLabel.Text = "Loan amount:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(96, 389)
        GenderLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(56, 16)
        GenderLabel.TabIndex = 21
        GenderLabel.Text = "Gender:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(96, 421)
        CountryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(56, 16)
        CountryLabel.TabIndex = 23
        CountryLabel.Text = "Country:"
        '
        'Tell_MobileNoLabel
        '
        Tell_MobileNoLabel.AutoSize = True
        Tell_MobileNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tell_MobileNoLabel.Location = New System.Drawing.Point(96, 453)
        Tell_MobileNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tell_MobileNoLabel.Name = "Tell_MobileNoLabel"
        Tell_MobileNoLabel.Size = New System.Drawing.Size(100, 16)
        Tell_MobileNoLabel.TabIndex = 25
        Tell_MobileNoLabel.Text = "Tell/Mobile No:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReligionLabel.Location = New System.Drawing.Point(96, 485)
        ReligionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(61, 16)
        ReligionLabel.TabIndex = 27
        ReligionLabel.Text = "Religion:"
        '
        'SignatureLabel
        '
        SignatureLabel.AutoSize = True
        SignatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SignatureLabel.Location = New System.Drawing.Point(96, 517)
        SignatureLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SignatureLabel.Name = "SignatureLabel"
        SignatureLabel.Size = New System.Drawing.Size(68, 16)
        SignatureLabel.TabIndex = 29
        SignatureLabel.Text = "Signature:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(96, 550)
        DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(40, 16)
        DateLabel.TabIndex = 31
        DateLabel.Text = "Date:"
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Loan_informationBindingSource
        '
        Me.Loan_informationBindingSource.DataMember = "Loan information"
        Me.Loan_informationBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'Loan_informationTableAdapter
        '
        Me.Loan_informationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Account_closing_formTableAdapter = Nothing
        Me.TableAdapterManager.ATM_CardTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_Book_detailTableAdapter = Nothing
        Me.TableAdapterManager.Deposite_informationTableAdapter = Nothing
        Me.TableAdapterManager.Loan_informationTableAdapter = Me.Loan_informationTableAdapter
        Me.TableAdapterManager.Official_Use_onlyTableAdapter = Nothing
        Me.TableAdapterManager.Opening_accountTableAdapter = Nothing
        Me.TableAdapterManager.student_accountTableAdapter = Nothing
        Me.TableAdapterManager.Transaction_infoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Withdrawal_formTableAdapter = Nothing
        Me.TableAdapterManager.Witness_informationTableAdapter = Nothing
        '
        'Loan_informationBindingNavigator
        '
        Me.Loan_informationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Loan_informationBindingNavigator.BindingSource = Me.Loan_informationBindingSource
        Me.Loan_informationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Loan_informationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Loan_informationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Loan_informationBindingNavigatorSaveItem})
        Me.Loan_informationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Loan_informationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Loan_informationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Loan_informationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Loan_informationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Loan_informationBindingNavigator.Name = "Loan_informationBindingNavigator"
        Me.Loan_informationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Loan_informationBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.Loan_informationBindingNavigator.TabIndex = 0
        Me.Loan_informationBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
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
        'Loan_informationBindingNavigatorSaveItem
        '
        Me.Loan_informationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Loan_informationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Loan_informationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Loan_informationBindingNavigatorSaveItem.Name = "Loan_informationBindingNavigatorSaveItem"
        Me.Loan_informationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Loan_informationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LOANIDTextBox
        '
        Me.LOANIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "LOANID", True))
        Me.LOANIDTextBox.Location = New System.Drawing.Point(220, 65)
        Me.LOANIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LOANIDTextBox.Name = "LOANIDTextBox"
        Me.LOANIDTextBox.Size = New System.Drawing.Size(119, 22)
        Me.LOANIDTextBox.TabIndex = 2
        '
        'FullnameTextBox
        '
        Me.FullnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Fullname", True))
        Me.FullnameTextBox.Location = New System.Drawing.Point(220, 97)
        Me.FullnameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FullnameTextBox.Name = "FullnameTextBox"
        Me.FullnameTextBox.Size = New System.Drawing.Size(231, 22)
        Me.FullnameTextBox.TabIndex = 4
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Loan_informationBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(220, 129)
        Me.DOBDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(244, 22)
        Me.DOBDateTimePicker.TabIndex = 6
        '
        'Contact_addressTextBox
        '
        Me.Contact_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Contact address", True))
        Me.Contact_addressTextBox.Location = New System.Drawing.Point(220, 161)
        Me.Contact_addressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Contact_addressTextBox.Name = "Contact_addressTextBox"
        Me.Contact_addressTextBox.Size = New System.Drawing.Size(231, 22)
        Me.Contact_addressTextBox.TabIndex = 8
        '
        'Martial_statusTextBox
        '
        Me.Martial_statusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Martial status", True))
        Me.Martial_statusTextBox.Location = New System.Drawing.Point(220, 193)
        Me.Martial_statusTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Martial_statusTextBox.Name = "Martial_statusTextBox"
        Me.Martial_statusTextBox.Size = New System.Drawing.Size(231, 22)
        Me.Martial_statusTextBox.TabIndex = 10
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Occupation", True))
        Me.OccupationTextBox.Location = New System.Drawing.Point(220, 225)
        Me.OccupationTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.Size = New System.Drawing.Size(231, 22)
        Me.OccupationTextBox.TabIndex = 12
        '
        'Monthly_incomeTextBox
        '
        Me.Monthly_incomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Monthly income", True))
        Me.Monthly_incomeTextBox.Location = New System.Drawing.Point(220, 257)
        Me.Monthly_incomeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Monthly_incomeTextBox.Name = "Monthly_incomeTextBox"
        Me.Monthly_incomeTextBox.Size = New System.Drawing.Size(231, 22)
        Me.Monthly_incomeTextBox.TabIndex = 14
        '
        'Loan_durationTextBox
        '
        Me.Loan_durationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Loan duration", True))
        Me.Loan_durationTextBox.Location = New System.Drawing.Point(220, 289)
        Me.Loan_durationTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Loan_durationTextBox.Name = "Loan_durationTextBox"
        Me.Loan_durationTextBox.Size = New System.Drawing.Size(231, 22)
        Me.Loan_durationTextBox.TabIndex = 16
        '
        'Purpose_of_loanTextBox
        '
        Me.Purpose_of_loanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Purpose of loan", True))
        Me.Purpose_of_loanTextBox.Location = New System.Drawing.Point(220, 321)
        Me.Purpose_of_loanTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Purpose_of_loanTextBox.Name = "Purpose_of_loanTextBox"
        Me.Purpose_of_loanTextBox.Size = New System.Drawing.Size(231, 22)
        Me.Purpose_of_loanTextBox.TabIndex = 18
        '
        'Loan_amountTextBox
        '
        Me.Loan_amountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Loan amount", True))
        Me.Loan_amountTextBox.Location = New System.Drawing.Point(220, 353)
        Me.Loan_amountTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Loan_amountTextBox.Name = "Loan_amountTextBox"
        Me.Loan_amountTextBox.Size = New System.Drawing.Size(119, 22)
        Me.Loan_amountTextBox.TabIndex = 20
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(220, 385)
        Me.GenderTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(119, 22)
        Me.GenderTextBox.TabIndex = 22
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(220, 417)
        Me.CountryTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(231, 22)
        Me.CountryTextBox.TabIndex = 24
        '
        'Tell_MobileNoTextBox
        '
        Me.Tell_MobileNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Tell/MobileNo", True))
        Me.Tell_MobileNoTextBox.Location = New System.Drawing.Point(220, 449)
        Me.Tell_MobileNoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Tell_MobileNoTextBox.Name = "Tell_MobileNoTextBox"
        Me.Tell_MobileNoTextBox.Size = New System.Drawing.Size(231, 22)
        Me.Tell_MobileNoTextBox.TabIndex = 26
        '
        'ReligionTextBox
        '
        Me.ReligionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Religion", True))
        Me.ReligionTextBox.Location = New System.Drawing.Point(220, 481)
        Me.ReligionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ReligionTextBox.Name = "ReligionTextBox"
        Me.ReligionTextBox.Size = New System.Drawing.Size(231, 22)
        Me.ReligionTextBox.TabIndex = 28
        '
        'SignatureTextBox
        '
        Me.SignatureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loan_informationBindingSource, "Signature", True))
        Me.SignatureTextBox.Location = New System.Drawing.Point(220, 513)
        Me.SignatureTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SignatureTextBox.Name = "SignatureTextBox"
        Me.SignatureTextBox.Size = New System.Drawing.Size(231, 22)
        Me.SignatureTextBox.TabIndex = 30
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Loan_informationBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(220, 545)
        Me.DateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(244, 22)
        Me.DateDateTimePicker.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 598)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(351, 598)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "View Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(459, 598)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(567, 598)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(675, 598)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 28)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(459, 97)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(905, 469)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Loan_informationBindingSource
        Me.ComboBox1.DisplayMember = "Fullname"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(626, 65)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(246, 24)
        Me.ComboBox1.TabIndex = 39
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(881, 63)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 28)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Searching"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Loan_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1362, 641)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(LOANIDLabel)
        Me.Controls.Add(Me.LOANIDTextBox)
        Me.Controls.Add(FullnameLabel)
        Me.Controls.Add(Me.FullnameTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(Contact_addressLabel)
        Me.Controls.Add(Me.Contact_addressTextBox)
        Me.Controls.Add(Martial_statusLabel)
        Me.Controls.Add(Me.Martial_statusTextBox)
        Me.Controls.Add(OccupationLabel)
        Me.Controls.Add(Me.OccupationTextBox)
        Me.Controls.Add(Monthly_incomeLabel)
        Me.Controls.Add(Me.Monthly_incomeTextBox)
        Me.Controls.Add(Loan_durationLabel)
        Me.Controls.Add(Me.Loan_durationTextBox)
        Me.Controls.Add(Purpose_of_loanLabel)
        Me.Controls.Add(Me.Purpose_of_loanTextBox)
        Me.Controls.Add(Loan_amountLabel)
        Me.Controls.Add(Me.Loan_amountTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Tell_MobileNoLabel)
        Me.Controls.Add(Me.Tell_MobileNoTextBox)
        Me.Controls.Add(ReligionLabel)
        Me.Controls.Add(Me.ReligionTextBox)
        Me.Controls.Add(SignatureLabel)
        Me.Controls.Add(Me.SignatureTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.Loan_informationBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Loan_form"
        Me.Text = "Loan_form"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loan_informationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loan_informationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Loan_informationBindingNavigator.ResumeLayout(False)
        Me.Loan_informationBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents Loan_informationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Loan_informationTableAdapter As My_system.Banking_managmentDataSetTableAdapters.Loan_informationTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Loan_informationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Loan_informationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LOANIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FullnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Contact_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Martial_statusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OccupationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Monthly_incomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Loan_durationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Purpose_of_loanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Loan_amountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tell_MobileNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReligionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignatureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
