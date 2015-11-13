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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deposit_form))
        Dim DIDLabel As System.Windows.Forms.Label
        Dim Acc_NOLabel As System.Windows.Forms.Label
        Dim Deposited_nameLabel As System.Windows.Forms.Label
        Dim Branch_nameLabel As System.Windows.Forms.Label
        Dim TellLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim Amount_in_wordLabel As System.Windows.Forms.Label
        Dim Teller_NOLabel As System.Windows.Forms.Label
        Dim Dep_dateLabel As System.Windows.Forms.Label
        Me.OnlineBankingDataSet = New Home_page.OnlineBankingDataSet()
        Me.Deposited_formBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deposited_formTableAdapter = New Home_page.OnlineBankingDataSetTableAdapters.Deposited_formTableAdapter()
        Me.TableAdapterManager = New Home_page.OnlineBankingDataSetTableAdapters.TableAdapterManager()
        Me.Deposited_formBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Deposited_formBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DIDTextBox = New System.Windows.Forms.TextBox()
        Me.Acc_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Deposited_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Branch_nameTextBox = New System.Windows.Forms.TextBox()
        Me.TellTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_in_wordTextBox = New System.Windows.Forms.TextBox()
        Me.Teller_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Dep_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        DIDLabel = New System.Windows.Forms.Label()
        Acc_NOLabel = New System.Windows.Forms.Label()
        Deposited_nameLabel = New System.Windows.Forms.Label()
        Branch_nameLabel = New System.Windows.Forms.Label()
        TellLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        Amount_in_wordLabel = New System.Windows.Forms.Label()
        Teller_NOLabel = New System.Windows.Forms.Label()
        Dep_dateLabel = New System.Windows.Forms.Label()
        CType(Me.OnlineBankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deposited_formBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deposited_formBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Deposited_formBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'OnlineBankingDataSet
        '
        Me.OnlineBankingDataSet.DataSetName = "OnlineBankingDataSet"
        Me.OnlineBankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Deposited_formBindingSource
        '
        Me.Deposited_formBindingSource.DataMember = "Deposited form"
        Me.Deposited_formBindingSource.DataSource = Me.OnlineBankingDataSet
        '
        'Deposited_formTableAdapter
        '
        Me.Deposited_formTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountTypeTableAdapter = Nothing
        Me.TableAdapterManager.ATM_cardTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckBookDetailsTableAdapter = Nothing
        Me.TableAdapterManager.CustomerQueryTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.Deposited_formTableAdapter = Me.Deposited_formTableAdapter
        Me.TableAdapterManager.for_official_use_onlyTableAdapter = Nothing
        Me.TableAdapterManager.Introducer_Witness_infoTableAdapter = Nothing
        Me.TableAdapterManager.Opening_an_accountTableAdapter = Nothing
        Me.TableAdapterManager.StopPaymentTableAdapter = Nothing
        Me.TableAdapterManager.student_s_detailTableAdapter = Nothing
        Me.TableAdapterManager.TransTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Home_page.OnlineBankingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Deposited_formBindingNavigator
        '
        Me.Deposited_formBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Deposited_formBindingNavigator.BindingSource = Me.Deposited_formBindingSource
        Me.Deposited_formBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Deposited_formBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Deposited_formBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Deposited_formBindingNavigatorSaveItem})
        Me.Deposited_formBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Deposited_formBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Deposited_formBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Deposited_formBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Deposited_formBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Deposited_formBindingNavigator.Name = "Deposited_formBindingNavigator"
        Me.Deposited_formBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Deposited_formBindingNavigator.Size = New System.Drawing.Size(633, 25)
        Me.Deposited_formBindingNavigator.TabIndex = 0
        Me.Deposited_formBindingNavigator.Text = "BindingNavigator1"
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
        'Deposited_formBindingNavigatorSaveItem
        '
        Me.Deposited_formBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Deposited_formBindingNavigatorSaveItem.Image = CType(resources.GetObject("Deposited_formBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Deposited_formBindingNavigatorSaveItem.Name = "Deposited_formBindingNavigatorSaveItem"
        Me.Deposited_formBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Deposited_formBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DIDLabel
        '
        DIDLabel.AutoSize = True
        DIDLabel.Location = New System.Drawing.Point(29, 64)
        DIDLabel.Name = "DIDLabel"
        DIDLabel.Size = New System.Drawing.Size(29, 13)
        DIDLabel.TabIndex = 1
        DIDLabel.Text = "DID:"
        '
        'DIDTextBox
        '
        Me.DIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "DID", True))
        Me.DIDTextBox.Location = New System.Drawing.Point(122, 61)
        Me.DIDTextBox.Name = "DIDTextBox"
        Me.DIDTextBox.Size = New System.Drawing.Size(68, 20)
        Me.DIDTextBox.TabIndex = 2
        '
        'Acc_NOLabel
        '
        Acc_NOLabel.AutoSize = True
        Acc_NOLabel.Location = New System.Drawing.Point(29, 90)
        Acc_NOLabel.Name = "Acc_NOLabel"
        Acc_NOLabel.Size = New System.Drawing.Size(50, 13)
        Acc_NOLabel.TabIndex = 3
        Acc_NOLabel.Text = "Acc/NO:"
        '
        'Acc_NOTextBox
        '
        Me.Acc_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "Acc/NO", True))
        Me.Acc_NOTextBox.Location = New System.Drawing.Point(122, 87)
        Me.Acc_NOTextBox.Name = "Acc_NOTextBox"
        Me.Acc_NOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Acc_NOTextBox.TabIndex = 4
        '
        'Deposited_nameLabel
        '
        Deposited_nameLabel.AutoSize = True
        Deposited_nameLabel.Location = New System.Drawing.Point(29, 116)
        Deposited_nameLabel.Name = "Deposited_nameLabel"
        Deposited_nameLabel.Size = New System.Drawing.Size(87, 13)
        Deposited_nameLabel.TabIndex = 5
        Deposited_nameLabel.Text = "Deposited name:"
        '
        'Deposited_nameTextBox
        '
        Me.Deposited_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "Deposited name", True))
        Me.Deposited_nameTextBox.Location = New System.Drawing.Point(122, 113)
        Me.Deposited_nameTextBox.Name = "Deposited_nameTextBox"
        Me.Deposited_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Deposited_nameTextBox.TabIndex = 6
        '
        'Branch_nameLabel
        '
        Branch_nameLabel.AutoSize = True
        Branch_nameLabel.Location = New System.Drawing.Point(29, 142)
        Branch_nameLabel.Name = "Branch_nameLabel"
        Branch_nameLabel.Size = New System.Drawing.Size(73, 13)
        Branch_nameLabel.TabIndex = 7
        Branch_nameLabel.Text = "Branch name:"
        '
        'Branch_nameTextBox
        '
        Me.Branch_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "Branch name", True))
        Me.Branch_nameTextBox.Location = New System.Drawing.Point(122, 139)
        Me.Branch_nameTextBox.Name = "Branch_nameTextBox"
        Me.Branch_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Branch_nameTextBox.TabIndex = 8
        '
        'TellLabel
        '
        TellLabel.AutoSize = True
        TellLabel.Location = New System.Drawing.Point(29, 168)
        TellLabel.Name = "TellLabel"
        TellLabel.Size = New System.Drawing.Size(27, 13)
        TellLabel.TabIndex = 9
        TellLabel.Text = "Tell:"
        '
        'TellTextBox
        '
        Me.TellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "Tell", True))
        Me.TellTextBox.Location = New System.Drawing.Point(122, 165)
        Me.TellTextBox.Name = "TellTextBox"
        Me.TellTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TellTextBox.TabIndex = 10
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(29, 194)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(47, 13)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(122, 191)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 49)
        Me.AddressTextBox.TabIndex = 12
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(29, 259)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(122, 256)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 14
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(29, 285)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 15
        AmountLabel.Text = "Amount:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(122, 282)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmountTextBox.TabIndex = 16
        '
        'Amount_in_wordLabel
        '
        Amount_in_wordLabel.AutoSize = True
        Amount_in_wordLabel.Location = New System.Drawing.Point(29, 311)
        Amount_in_wordLabel.Name = "Amount_in_wordLabel"
        Amount_in_wordLabel.Size = New System.Drawing.Size(83, 13)
        Amount_in_wordLabel.TabIndex = 17
        Amount_in_wordLabel.Text = "Amount in word:"
        '
        'Amount_in_wordTextBox
        '
        Me.Amount_in_wordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "Amount in word", True))
        Me.Amount_in_wordTextBox.Location = New System.Drawing.Point(122, 308)
        Me.Amount_in_wordTextBox.Name = "Amount_in_wordTextBox"
        Me.Amount_in_wordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Amount_in_wordTextBox.TabIndex = 18
        '
        'Teller_NOLabel
        '
        Teller_NOLabel.AutoSize = True
        Teller_NOLabel.Location = New System.Drawing.Point(29, 337)
        Teller_NOLabel.Name = "Teller_NOLabel"
        Teller_NOLabel.Size = New System.Drawing.Size(55, 13)
        Teller_NOLabel.TabIndex = 19
        Teller_NOLabel.Text = "Teller NO:"
        '
        'Teller_NOTextBox
        '
        Me.Teller_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deposited_formBindingSource, "Teller NO", True))
        Me.Teller_NOTextBox.Location = New System.Drawing.Point(122, 334)
        Me.Teller_NOTextBox.Name = "Teller_NOTextBox"
        Me.Teller_NOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Teller_NOTextBox.TabIndex = 20
        '
        'Dep_dateLabel
        '
        Dep_dateLabel.AutoSize = True
        Dep_dateLabel.Location = New System.Drawing.Point(29, 364)
        Dep_dateLabel.Name = "Dep_dateLabel"
        Dep_dateLabel.Size = New System.Drawing.Size(54, 13)
        Dep_dateLabel.TabIndex = 21
        Dep_dateLabel.Text = "Dep date:"
        '
        'Dep_dateDateTimePicker
        '
        Me.Dep_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Deposited_formBindingSource, "Dep_date", True))
        Me.Dep_dateDateTimePicker.Location = New System.Drawing.Point(122, 360)
        Me.Dep_dateDateTimePicker.Name = "Dep_dateDateTimePicker"
        Me.Dep_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Dep_dateDateTimePicker.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(298, 406)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(379, 406)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Deposit_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 464)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DIDLabel)
        Me.Controls.Add(Me.DIDTextBox)
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
        Me.Controls.Add(Dep_dateLabel)
        Me.Controls.Add(Me.Dep_dateDateTimePicker)
        Me.Controls.Add(Me.Deposited_formBindingNavigator)
        Me.Name = "Deposit_form"
        Me.Text = "Deposit_form"
        CType(Me.OnlineBankingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deposited_formBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deposited_formBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Deposited_formBindingNavigator.ResumeLayout(False)
        Me.Deposited_formBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OnlineBankingDataSet As Home_page.OnlineBankingDataSet
    Friend WithEvents Deposited_formBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Deposited_formTableAdapter As Home_page.OnlineBankingDataSetTableAdapters.Deposited_formTableAdapter
    Friend WithEvents TableAdapterManager As Home_page.OnlineBankingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Deposited_formBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Deposited_formBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Acc_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Deposited_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Branch_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TellTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_in_wordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Teller_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dep_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
