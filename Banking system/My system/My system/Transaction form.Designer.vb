<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_form
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
        Dim TransactionIdLabel As System.Windows.Forms.Label
        Dim TransactionDateLabel As System.Windows.Forms.Label
        Dim TransactionTypeLabel As System.Windows.Forms.Label
        Dim TransactionModeLabel As System.Windows.Forms.Label
        Dim From_A_c_NoLabel As System.Windows.Forms.Label
        Dim To_A_c_NoLabel As System.Windows.Forms.Label
        Dim CheckNumberLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_form))
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.Transaction_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Transaction_infoTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.Transaction_infoTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.Transaction_infoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Transaction_infoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TransactionIdTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TransactionTypeTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionModeTextBox = New System.Windows.Forms.TextBox()
        Me.From_A_c_NoTextBox = New System.Windows.Forms.TextBox()
        Me.To_A_c_NoTextBox = New System.Windows.Forms.TextBox()
        Me.CheckNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        TransactionIdLabel = New System.Windows.Forms.Label()
        TransactionDateLabel = New System.Windows.Forms.Label()
        TransactionTypeLabel = New System.Windows.Forms.Label()
        TransactionModeLabel = New System.Windows.Forms.Label()
        From_A_c_NoLabel = New System.Windows.Forms.Label()
        To_A_c_NoLabel = New System.Windows.Forms.Label()
        CheckNumberLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_infoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Transaction_infoBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransactionIdLabel
        '
        TransactionIdLabel.AutoSize = True
        TransactionIdLabel.Location = New System.Drawing.Point(53, 60)
        TransactionIdLabel.Name = "TransactionIdLabel"
        TransactionIdLabel.Size = New System.Drawing.Size(78, 13)
        TransactionIdLabel.TabIndex = 1
        TransactionIdLabel.Text = "Transaction Id:"
        '
        'TransactionDateLabel
        '
        TransactionDateLabel.AutoSize = True
        TransactionDateLabel.Location = New System.Drawing.Point(39, 90)
        TransactionDateLabel.Name = "TransactionDateLabel"
        TransactionDateLabel.Size = New System.Drawing.Size(92, 13)
        TransactionDateLabel.TabIndex = 3
        TransactionDateLabel.Text = "Transaction Date:"
        '
        'TransactionTypeLabel
        '
        TransactionTypeLabel.AutoSize = True
        TransactionTypeLabel.Location = New System.Drawing.Point(39, 115)
        TransactionTypeLabel.Name = "TransactionTypeLabel"
        TransactionTypeLabel.Size = New System.Drawing.Size(93, 13)
        TransactionTypeLabel.TabIndex = 5
        TransactionTypeLabel.Text = "Transaction Type:"
        '
        'TransactionModeLabel
        '
        TransactionModeLabel.AutoSize = True
        TransactionModeLabel.Location = New System.Drawing.Point(39, 141)
        TransactionModeLabel.Name = "TransactionModeLabel"
        TransactionModeLabel.Size = New System.Drawing.Size(96, 13)
        TransactionModeLabel.TabIndex = 7
        TransactionModeLabel.Text = "Transaction Mode:"
        '
        'From_A_c_NoLabel
        '
        From_A_c_NoLabel.AutoSize = True
        From_A_c_NoLabel.Location = New System.Drawing.Point(60, 171)
        From_A_c_NoLabel.Name = "From_A_c_NoLabel"
        From_A_c_NoLabel.Size = New System.Drawing.Size(71, 13)
        From_A_c_NoLabel.TabIndex = 9
        From_A_c_NoLabel.Text = "From A/c No:"
        '
        'To_A_c_NoLabel
        '
        To_A_c_NoLabel.AutoSize = True
        To_A_c_NoLabel.Location = New System.Drawing.Point(70, 190)
        To_A_c_NoLabel.Name = "To_A_c_NoLabel"
        To_A_c_NoLabel.Size = New System.Drawing.Size(61, 13)
        To_A_c_NoLabel.TabIndex = 11
        To_A_c_NoLabel.Text = "To A/c No:"
        '
        'CheckNumberLabel
        '
        CheckNumberLabel.AutoSize = True
        CheckNumberLabel.Location = New System.Drawing.Point(50, 216)
        CheckNumberLabel.Name = "CheckNumberLabel"
        CheckNumberLabel.Size = New System.Drawing.Size(81, 13)
        CheckNumberLabel.TabIndex = 13
        CheckNumberLabel.Text = "Check Number:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(85, 242)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 15
        AmountLabel.Text = "Amount:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(91, 268)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 17
        StatusLabel.Text = "Status:"
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Transaction_infoBindingSource
        '
        Me.Transaction_infoBindingSource.DataMember = "Transaction info"
        Me.Transaction_infoBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'Transaction_infoTableAdapter
        '
        Me.Transaction_infoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Transaction_infoTableAdapter = Me.Transaction_infoTableAdapter
        Me.TableAdapterManager.UpdateOrder = My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Withdrawal_formTableAdapter = Nothing
        Me.TableAdapterManager.Witness_informationTableAdapter = Nothing
        '
        'Transaction_infoBindingNavigator
        '
        Me.Transaction_infoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Transaction_infoBindingNavigator.BindingSource = Me.Transaction_infoBindingSource
        Me.Transaction_infoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Transaction_infoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Transaction_infoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Transaction_infoBindingNavigatorSaveItem})
        Me.Transaction_infoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Transaction_infoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Transaction_infoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Transaction_infoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Transaction_infoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Transaction_infoBindingNavigator.Name = "Transaction_infoBindingNavigator"
        Me.Transaction_infoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Transaction_infoBindingNavigator.Size = New System.Drawing.Size(844, 25)
        Me.Transaction_infoBindingNavigator.TabIndex = 0
        Me.Transaction_infoBindingNavigator.Text = "BindingNavigator1"
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
        'Transaction_infoBindingNavigatorSaveItem
        '
        Me.Transaction_infoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Transaction_infoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Transaction_infoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Transaction_infoBindingNavigatorSaveItem.Name = "Transaction_infoBindingNavigatorSaveItem"
        Me.Transaction_infoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Transaction_infoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TransactionIdTextBox
        '
        Me.TransactionIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transaction_infoBindingSource, "TransactionId", True))
        Me.TransactionIdTextBox.Location = New System.Drawing.Point(141, 60)
        Me.TransactionIdTextBox.Name = "TransactionIdTextBox"
        Me.TransactionIdTextBox.Size = New System.Drawing.Size(97, 20)
        Me.TransactionIdTextBox.TabIndex = 2
        '
        'TransactionDateDateTimePicker
        '
        Me.TransactionDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Transaction_infoBindingSource, "TransactionDate", True))
        Me.TransactionDateDateTimePicker.Location = New System.Drawing.Point(141, 86)
        Me.TransactionDateDateTimePicker.Name = "TransactionDateDateTimePicker"
        Me.TransactionDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TransactionDateDateTimePicker.TabIndex = 4
        '
        'TransactionTypeTextBox
        '
        Me.TransactionTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transaction_infoBindingSource, "TransactionType", True))
        Me.TransactionTypeTextBox.Location = New System.Drawing.Point(141, 112)
        Me.TransactionTypeTextBox.Name = "TransactionTypeTextBox"
        Me.TransactionTypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionTypeTextBox.TabIndex = 6
        '
        'TransactionModeTextBox
        '
        Me.TransactionModeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transaction_infoBindingSource, "TransactionMode", True))
        Me.TransactionModeTextBox.Location = New System.Drawing.Point(141, 138)
        Me.TransactionModeTextBox.Name = "TransactionModeTextBox"
        Me.TransactionModeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionModeTextBox.TabIndex = 8
        '
        'From_A_c_NoTextBox
        '
        Me.From_A_c_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transaction_infoBindingSource, "From A/c No", True))
        Me.From_A_c_NoTextBox.Location = New System.Drawing.Point(141, 164)
        Me.From_A_c_NoTextBox.Name = "From_A_c_NoTextBox"
        Me.From_A_c_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.From_A_c_NoTextBox.TabIndex = 10
        '
        'To_A_c_NoTextBox
        '
        Me.To_A_c_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transaction_infoBindingSource, "To A/c No", True))
        Me.To_A_c_NoTextBox.Location = New System.Drawing.Point(141, 190)
        Me.To_A_c_NoTextBox.Name = "To_A_c_NoTextBox"
        Me.To_A_c_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.To_A_c_NoTextBox.TabIndex = 12
        '
        'CheckNumberTextBox
        '
        Me.CheckNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transaction_infoBindingSource, "CheckNumber", True))
        Me.CheckNumberTextBox.Location = New System.Drawing.Point(141, 216)
        Me.CheckNumberTextBox.Name = "CheckNumberTextBox"
        Me.CheckNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CheckNumberTextBox.TabIndex = 14
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transaction_infoBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(141, 242)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmountTextBox.TabIndex = 16
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transaction_infoBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(141, 268)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(234, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(315, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(396, 307)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(477, 307)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(347, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(497, 260)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Transaction_infoBindingSource
        Me.ComboBox1.DisplayMember = "TransactionId"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(556, 1)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(706, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Searching"
        '
        'Transaction_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(844, 380)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(TransactionIdLabel)
        Me.Controls.Add(Me.TransactionIdTextBox)
        Me.Controls.Add(TransactionDateLabel)
        Me.Controls.Add(Me.TransactionDateDateTimePicker)
        Me.Controls.Add(TransactionTypeLabel)
        Me.Controls.Add(Me.TransactionTypeTextBox)
        Me.Controls.Add(TransactionModeLabel)
        Me.Controls.Add(Me.TransactionModeTextBox)
        Me.Controls.Add(From_A_c_NoLabel)
        Me.Controls.Add(Me.From_A_c_NoTextBox)
        Me.Controls.Add(To_A_c_NoLabel)
        Me.Controls.Add(Me.To_A_c_NoTextBox)
        Me.Controls.Add(CheckNumberLabel)
        Me.Controls.Add(Me.CheckNumberTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.Transaction_infoBindingNavigator)
        Me.Name = "Transaction_form"
        Me.Text = "Transaction_form"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_infoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Transaction_infoBindingNavigator.ResumeLayout(False)
        Me.Transaction_infoBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents Transaction_infoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Transaction_infoTableAdapter As My_system.Banking_managmentDataSetTableAdapters.Transaction_infoTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Transaction_infoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Transaction_infoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransactionIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransactionDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransactionTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransactionModeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents From_A_c_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents To_A_c_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
