<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdrawal_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Withdrawal_form))
        Dim IDLabel As System.Windows.Forms.Label
        Dim A_C_NoLabel As System.Windows.Forms.Label
        Dim A_C_nameLabel As System.Windows.Forms.Label
        Dim Branch_nameLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim Date_of_WithdrawalLabel As System.Windows.Forms.Label
        Dim SignatureLabel As System.Windows.Forms.Label
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.Withdrawal_formBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Withdrawal_formTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.Withdrawal_formTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.Withdrawal_formBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Withdrawal_formBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.A_C_NoTextBox = New System.Windows.Forms.TextBox()
        Me.A_C_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Branch_nameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_WithdrawalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SignatureTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        IDLabel = New System.Windows.Forms.Label()
        A_C_NoLabel = New System.Windows.Forms.Label()
        A_C_nameLabel = New System.Windows.Forms.Label()
        Branch_nameLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        Date_of_WithdrawalLabel = New System.Windows.Forms.Label()
        SignatureLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Withdrawal_formBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Withdrawal_formBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Withdrawal_formBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Withdrawal_formBindingSource
        '
        Me.Withdrawal_formBindingSource.DataMember = "Withdrawal form"
        Me.Withdrawal_formBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'Withdrawal_formTableAdapter
        '
        Me.Withdrawal_formTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Withdrawal_formTableAdapter = Me.Withdrawal_formTableAdapter
        Me.TableAdapterManager.Witness_informationTableAdapter = Nothing
        '
        'Withdrawal_formBindingNavigator
        '
        Me.Withdrawal_formBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Withdrawal_formBindingNavigator.BindingSource = Me.Withdrawal_formBindingSource
        Me.Withdrawal_formBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Withdrawal_formBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Withdrawal_formBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Withdrawal_formBindingNavigatorSaveItem})
        Me.Withdrawal_formBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Withdrawal_formBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Withdrawal_formBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Withdrawal_formBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Withdrawal_formBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Withdrawal_formBindingNavigator.Name = "Withdrawal_formBindingNavigator"
        Me.Withdrawal_formBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Withdrawal_formBindingNavigator.Size = New System.Drawing.Size(1209, 25)
        Me.Withdrawal_formBindingNavigator.TabIndex = 0
        Me.Withdrawal_formBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Withdrawal_formBindingNavigatorSaveItem
        '
        Me.Withdrawal_formBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Withdrawal_formBindingNavigatorSaveItem.Image = CType(resources.GetObject("Withdrawal_formBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Withdrawal_formBindingNavigatorSaveItem.Name = "Withdrawal_formBindingNavigatorSaveItem"
        Me.Withdrawal_formBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Withdrawal_formBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        IDLabel.Location = New System.Drawing.Point(169, 82)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(27, 17)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Withdrawal_formBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(220, 82)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(136, 21)
        Me.IDTextBox.TabIndex = 2
        '
        'A_C_NoLabel
        '
        A_C_NoLabel.AutoSize = True
        A_C_NoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        A_C_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_C_NoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        A_C_NoLabel.Location = New System.Drawing.Point(136, 112)
        A_C_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        A_C_NoLabel.Name = "A_C_NoLabel"
        A_C_NoLabel.Size = New System.Drawing.Size(56, 17)
        A_C_NoLabel.TabIndex = 3
        A_C_NoLabel.Text = "A/C No:"
        '
        'A_C_NoTextBox
        '
        Me.A_C_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Withdrawal_formBindingSource, "A/C No", True))
        Me.A_C_NoTextBox.Location = New System.Drawing.Point(220, 112)
        Me.A_C_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.A_C_NoTextBox.Name = "A_C_NoTextBox"
        Me.A_C_NoTextBox.Size = New System.Drawing.Size(265, 21)
        Me.A_C_NoTextBox.TabIndex = 4
        '
        'A_C_nameLabel
        '
        A_C_nameLabel.AutoSize = True
        A_C_nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        A_C_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        A_C_nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        A_C_nameLabel.Location = New System.Drawing.Point(120, 142)
        A_C_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        A_C_nameLabel.Name = "A_C_nameLabel"
        A_C_nameLabel.Size = New System.Drawing.Size(74, 17)
        A_C_nameLabel.TabIndex = 5
        A_C_nameLabel.Text = "A/C name:"
        '
        'A_C_nameTextBox
        '
        Me.A_C_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Withdrawal_formBindingSource, "A/C name", True))
        Me.A_C_nameTextBox.Location = New System.Drawing.Point(220, 142)
        Me.A_C_nameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.A_C_nameTextBox.Name = "A_C_nameTextBox"
        Me.A_C_nameTextBox.Size = New System.Drawing.Size(265, 21)
        Me.A_C_nameTextBox.TabIndex = 6
        '
        'Branch_nameLabel
        '
        Branch_nameLabel.AutoSize = True
        Branch_nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Branch_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Branch_nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Branch_nameLabel.Location = New System.Drawing.Point(100, 175)
        Branch_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Branch_nameLabel.Name = "Branch_nameLabel"
        Branch_nameLabel.Size = New System.Drawing.Size(98, 17)
        Branch_nameLabel.TabIndex = 7
        Branch_nameLabel.Text = "Branch name:"
        '
        'Branch_nameTextBox
        '
        Me.Branch_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Withdrawal_formBindingSource, "Branch name", True))
        Me.Branch_nameTextBox.Location = New System.Drawing.Point(220, 172)
        Me.Branch_nameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Branch_nameTextBox.Name = "Branch_nameTextBox"
        Me.Branch_nameTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Branch_nameTextBox.TabIndex = 8
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        ContactLabel.Location = New System.Drawing.Point(135, 205)
        ContactLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(61, 17)
        ContactLabel.TabIndex = 9
        ContactLabel.Text = "Contact:"
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Withdrawal_formBindingSource, "Contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(220, 202)
        Me.ContactTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(265, 21)
        Me.ContactTextBox.TabIndex = 10
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        AddressLabel.Location = New System.Drawing.Point(133, 232)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Withdrawal_formBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(220, 232)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(265, 21)
        Me.AddressTextBox.TabIndex = 12
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        AmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        AmountLabel.Location = New System.Drawing.Point(136, 262)
        AmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(61, 17)
        AmountLabel.TabIndex = 13
        AmountLabel.Text = "Amount:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Withdrawal_formBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(220, 262)
        Me.AmountTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(136, 21)
        Me.AmountTextBox.TabIndex = 14
        '
        'Date_of_WithdrawalLabel
        '
        Date_of_WithdrawalLabel.AutoSize = True
        Date_of_WithdrawalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Date_of_WithdrawalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_WithdrawalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Date_of_WithdrawalLabel.Location = New System.Drawing.Point(63, 299)
        Date_of_WithdrawalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Date_of_WithdrawalLabel.Name = "Date_of_WithdrawalLabel"
        Date_of_WithdrawalLabel.Size = New System.Drawing.Size(134, 17)
        Date_of_WithdrawalLabel.TabIndex = 15
        Date_of_WithdrawalLabel.Text = "Date of Withdrawal:"
        '
        'Date_of_WithdrawalDateTimePicker
        '
        Me.Date_of_WithdrawalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Withdrawal_formBindingSource, "Date of Withdrawal", True))
        Me.Date_of_WithdrawalDateTimePicker.Location = New System.Drawing.Point(220, 292)
        Me.Date_of_WithdrawalDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Date_of_WithdrawalDateTimePicker.Name = "Date_of_WithdrawalDateTimePicker"
        Me.Date_of_WithdrawalDateTimePicker.Size = New System.Drawing.Size(265, 21)
        Me.Date_of_WithdrawalDateTimePicker.TabIndex = 16
        '
        'SignatureLabel
        '
        SignatureLabel.AutoSize = True
        SignatureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        SignatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SignatureLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        SignatureLabel.Location = New System.Drawing.Point(124, 322)
        SignatureLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SignatureLabel.Name = "SignatureLabel"
        SignatureLabel.Size = New System.Drawing.Size(75, 17)
        SignatureLabel.TabIndex = 17
        SignatureLabel.Text = "Signature:"
        '
        'SignatureTextBox
        '
        Me.SignatureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Withdrawal_formBindingSource, "Signature", True))
        Me.SignatureTextBox.Location = New System.Drawing.Point(220, 322)
        Me.SignatureTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SignatureTextBox.Name = "SignatureTextBox"
        Me.SignatureTextBox.Size = New System.Drawing.Size(265, 21)
        Me.SignatureTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 366)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add to Db"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(328, 366)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "view"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(436, 366)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 27)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(544, 366)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 27)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(652, 366)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 27)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Withdrawal_formBindingSource
        Me.ComboBox1.DisplayMember = "A/C No"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(644, 33)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(264, 23)
        Me.ComboBox1.TabIndex = 24
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(917, 32)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 27)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "finding"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(495, 65)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(714, 275)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Withdrawal_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1209, 417)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(A_C_NoLabel)
        Me.Controls.Add(Me.A_C_NoTextBox)
        Me.Controls.Add(A_C_nameLabel)
        Me.Controls.Add(Me.A_C_nameTextBox)
        Me.Controls.Add(Branch_nameLabel)
        Me.Controls.Add(Me.Branch_nameTextBox)
        Me.Controls.Add(ContactLabel)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Date_of_WithdrawalLabel)
        Me.Controls.Add(Me.Date_of_WithdrawalDateTimePicker)
        Me.Controls.Add(SignatureLabel)
        Me.Controls.Add(Me.SignatureTextBox)
        Me.Controls.Add(Me.Withdrawal_formBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Withdrawal_form"
        Me.Text = "Withdrawal_form"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Withdrawal_formBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Withdrawal_formBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Withdrawal_formBindingNavigator.ResumeLayout(False)
        Me.Withdrawal_formBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents Withdrawal_formBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Withdrawal_formTableAdapter As My_system.Banking_managmentDataSetTableAdapters.Withdrawal_formTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Withdrawal_formBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Withdrawal_formBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_C_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_C_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Branch_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_WithdrawalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SignatureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
