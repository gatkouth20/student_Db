<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposit_form
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
        Dim ID1Label As System.Windows.Forms.Label
        Dim Acc_NOLabel As System.Windows.Forms.Label
        Dim Deposited_nameLabel As System.Windows.Forms.Label
        Dim Branch_nameLabel As System.Windows.Forms.Label
        Dim TellLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim Amount_in_wordLabel As System.Windows.Forms.Label
        Dim Teller_NOLabel As System.Windows.Forms.Label
        Dim Date_of_depositeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deposit_form))
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.Deposite_informationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deposite_informationTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.Deposite_informationTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.Deposite_informationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Deposite_informationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID1TextBox = New System.Windows.Forms.TextBox()
        Me.Acc_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Deposited_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Branch_nameTextBox = New System.Windows.Forms.TextBox()
        Me.TellTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_in_wordTextBox = New System.Windows.Forms.TextBox()
        Me.Teller_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_depositeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        ID1Label = New System.Windows.Forms.Label()
        Acc_NOLabel = New System.Windows.Forms.Label()
        Deposited_nameLabel = New System.Windows.Forms.Label()
        Branch_nameLabel = New System.Windows.Forms.Label()
        TellLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        Amount_in_wordLabel = New System.Windows.Forms.Label()
        Teller_NOLabel = New System.Windows.Forms.Label()
        Date_of_depositeLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deposite_informationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deposite_informationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Deposite_informationBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID1Label
        '
        ID1Label.AutoSize = True
        ID1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID1Label.Location = New System.Drawing.Point(108, 85)
        ID1Label.Name = "ID1Label"
        ID1Label.Size = New System.Drawing.Size(31, 16)
        ID1Label.TabIndex = 1
        ID1Label.Text = "ID1:"
        '
        'Acc_NOLabel
        '
        Acc_NOLabel.AutoSize = True
        Acc_NOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Acc_NOLabel.Location = New System.Drawing.Point(82, 127)
        Acc_NOLabel.Name = "Acc_NOLabel"
        Acc_NOLabel.Size = New System.Drawing.Size(58, 16)
        Acc_NOLabel.TabIndex = 5
        Acc_NOLabel.Text = "Acc/NO:"
        '
        'Deposited_nameLabel
        '
        Deposited_nameLabel.AutoSize = True
        Deposited_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deposited_nameLabel.Location = New System.Drawing.Point(20, 153)
        Deposited_nameLabel.Name = "Deposited_nameLabel"
        Deposited_nameLabel.Size = New System.Drawing.Size(111, 16)
        Deposited_nameLabel.TabIndex = 7
        Deposited_nameLabel.Text = "Deposited name:"
        '
        'Branch_nameLabel
        '
        Branch_nameLabel.AutoSize = True
        Branch_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Branch_nameLabel.Location = New System.Drawing.Point(38, 183)
        Branch_nameLabel.Name = "Branch_nameLabel"
        Branch_nameLabel.Size = New System.Drawing.Size(90, 16)
        Branch_nameLabel.TabIndex = 9
        Branch_nameLabel.Text = "Branch name:"
        '
        'TellLabel
        '
        TellLabel.AutoSize = True
        TellLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TellLabel.Location = New System.Drawing.Point(108, 213)
        TellLabel.Name = "TellLabel"
        TellLabel.Size = New System.Drawing.Size(34, 16)
        TellLabel.TabIndex = 11
        TellLabel.Text = "Tell:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(76, 245)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 16)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "Address:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(91, 275)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 16)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.Location = New System.Drawing.Point(78, 303)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(56, 16)
        AmountLabel.TabIndex = 17
        AmountLabel.Text = "Amount:"
        '
        'Amount_in_wordLabel
        '
        Amount_in_wordLabel.AutoSize = True
        Amount_in_wordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_in_wordLabel.Location = New System.Drawing.Point(26, 333)
        Amount_in_wordLabel.Name = "Amount_in_wordLabel"
        Amount_in_wordLabel.Size = New System.Drawing.Size(101, 16)
        Amount_in_wordLabel.TabIndex = 19
        Amount_in_wordLabel.Text = "Amount in word:"
        '
        'Teller_NOLabel
        '
        Teller_NOLabel.AutoSize = True
        Teller_NOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Teller_NOLabel.Location = New System.Drawing.Point(63, 363)
        Teller_NOLabel.Name = "Teller_NOLabel"
        Teller_NOLabel.Size = New System.Drawing.Size(69, 16)
        Teller_NOLabel.TabIndex = 21
        Teller_NOLabel.Text = "Teller NO:"
        '
        'Date_of_depositeLabel
        '
        Date_of_depositeLabel.AutoSize = True
        Date_of_depositeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_depositeLabel.Location = New System.Drawing.Point(19, 393)
        Date_of_depositeLabel.Name = "Date_of_depositeLabel"
        Date_of_depositeLabel.Size = New System.Drawing.Size(108, 16)
        Date_of_depositeLabel.TabIndex = 23
        Date_of_depositeLabel.Text = "date of deposite:"
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Deposite_informationBindingSource
        '
        Me.Deposite_informationBindingSource.DataMember = "Deposite information"
        Me.Deposite_informationBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'Deposite_informationTableAdapter
        '
        Me.Deposite_informationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Account_closing_formTableAdapter = Nothing
        Me.TableAdapterManager.ATM_CardTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_Book_detailTableAdapter = Nothing
        Me.TableAdapterManager.Deposite_informationTableAdapter = Me.Deposite_informationTableAdapter
        Me.TableAdapterManager.Loan_informationTableAdapter = Nothing
        Me.TableAdapterManager.Official_Use_onlyTableAdapter = Nothing
        Me.TableAdapterManager.Opening_accountTableAdapter = Nothing
        Me.TableAdapterManager.student_accountTableAdapter = Nothing
        Me.TableAdapterManager.Transaction_infoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Withdrawal_formTableAdapter = Nothing
        Me.TableAdapterManager.Witness_informationTableAdapter = Nothing
        '
        'Deposite_informationBindingNavigator
        '
        Me.Deposite_informationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Deposite_informationBindingNavigator.BindingSource = Me.Deposite_informationBindingSource
        Me.Deposite_informationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Deposite_informationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Deposite_informationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Deposite_informationBindingNavigatorSaveItem})
        Me.Deposite_informationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Deposite_informationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Deposite_informationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Deposite_informationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Deposite_informationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Deposite_informationBindingNavigator.Name = "Deposite_informationBindingNavigator"
        Me.Deposite_informationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Deposite_informationBindingNavigator.Size = New System.Drawing.Size(1098, 25)
        Me.Deposite_informationBindingNavigator.TabIndex = 0
        Me.Deposite_informationBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
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
        'Deposite_informationBindingNavigatorSaveItem
        '
        Me.Deposite_informationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Deposite_informationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Deposite_informationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Deposite_informationBindingNavigatorSaveItem.Name = "Deposite_informationBindingNavigatorSaveItem"
        Me.Deposite_informationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Deposite_informationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID1TextBox
        '
        Me.ID1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "ID1", True))
        Me.ID1TextBox.Location = New System.Drawing.Point(154, 82)
        Me.ID1TextBox.Name = "ID1TextBox"
        Me.ID1TextBox.Size = New System.Drawing.Size(107, 21)
        Me.ID1TextBox.TabIndex = 2
        '
        'Acc_NOTextBox
        '
        Me.Acc_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "Acc/NO", True))
        Me.Acc_NOTextBox.Location = New System.Drawing.Point(154, 123)
        Me.Acc_NOTextBox.Name = "Acc_NOTextBox"
        Me.Acc_NOTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Acc_NOTextBox.TabIndex = 6
        '
        'Deposited_nameTextBox
        '
        Me.Deposited_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "Deposited name", True))
        Me.Deposited_nameTextBox.Location = New System.Drawing.Point(154, 153)
        Me.Deposited_nameTextBox.Name = "Deposited_nameTextBox"
        Me.Deposited_nameTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Deposited_nameTextBox.TabIndex = 8
        '
        'Branch_nameTextBox
        '
        Me.Branch_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "Branch name", True))
        Me.Branch_nameTextBox.Location = New System.Drawing.Point(154, 183)
        Me.Branch_nameTextBox.Name = "Branch_nameTextBox"
        Me.Branch_nameTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Branch_nameTextBox.TabIndex = 10
        '
        'TellTextBox
        '
        Me.TellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "Tell", True))
        Me.TellTextBox.Location = New System.Drawing.Point(154, 213)
        Me.TellTextBox.Name = "TellTextBox"
        Me.TellTextBox.Size = New System.Drawing.Size(233, 21)
        Me.TellTextBox.TabIndex = 12
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(154, 243)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(233, 21)
        Me.AddressTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(154, 273)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(233, 21)
        Me.EmailTextBox.TabIndex = 16
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(154, 303)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(233, 21)
        Me.AmountTextBox.TabIndex = 18
        '
        'Amount_in_wordTextBox
        '
        Me.Amount_in_wordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "Amount in word", True))
        Me.Amount_in_wordTextBox.Location = New System.Drawing.Point(154, 333)
        Me.Amount_in_wordTextBox.Name = "Amount_in_wordTextBox"
        Me.Amount_in_wordTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Amount_in_wordTextBox.TabIndex = 20
        '
        'Teller_NOTextBox
        '
        Me.Teller_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposite_informationBindingSource, "Teller NO", True))
        Me.Teller_NOTextBox.Location = New System.Drawing.Point(154, 363)
        Me.Teller_NOTextBox.Name = "Teller_NOTextBox"
        Me.Teller_NOTextBox.Size = New System.Drawing.Size(233, 21)
        Me.Teller_NOTextBox.TabIndex = 22
        '
        'Date_of_depositeDateTimePicker
        '
        Me.Date_of_depositeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Deposite_informationBindingSource, "date of deposite", True))
        Me.Date_of_depositeDateTimePicker.Location = New System.Drawing.Point(154, 393)
        Me.Date_of_depositeDateTimePicker.Name = "Date_of_depositeDateTimePicker"
        Me.Date_of_depositeDateTimePicker.Size = New System.Drawing.Size(233, 21)
        Me.Date_of_depositeDateTimePicker.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(153, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 27)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(247, 457)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(342, 457)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 27)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Display"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(436, 457)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 27)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(531, 457)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 27)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(408, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(675, 332)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Deposite_informationBindingSource
        Me.ComboBox1.DisplayMember = "Acc/NO"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(470, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 23)
        Me.ComboBox1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(712, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Searching"
        '
        'Deposit_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1098, 510)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ID1Label)
        Me.Controls.Add(Me.ID1TextBox)
        Me.Controls.Add(Acc_NOLabel)
        Me.Controls.Add(Me.Acc_NOTextBox)
        Me.Controls.Add(Deposited_nameLabel)
        Me.Controls.Add(Me.Deposited_nameTextBox)
        Me.Controls.Add(Branch_nameLabel)
        Me.Controls.Add(Me.Branch_nameTextBox)
        Me.Controls.Add(TellLabel)
        Me.Controls.Add(Me.TellTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Amount_in_wordLabel)
        Me.Controls.Add(Me.Amount_in_wordTextBox)
        Me.Controls.Add(Teller_NOLabel)
        Me.Controls.Add(Me.Teller_NOTextBox)
        Me.Controls.Add(Date_of_depositeLabel)
        Me.Controls.Add(Me.Date_of_depositeDateTimePicker)
        Me.Controls.Add(Me.Deposite_informationBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Deposit_form"
        Me.Text = "Deposit_form"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deposite_informationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deposite_informationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Deposite_informationBindingNavigator.ResumeLayout(False)
        Me.Deposite_informationBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents Deposite_informationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Deposite_informationTableAdapter As My_system.Banking_managmentDataSetTableAdapters.Deposite_informationTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Deposite_informationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Deposite_informationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Acc_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Deposited_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Branch_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TellTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_in_wordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Teller_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_depositeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
