<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBook_form
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
        Dim CheckBookNoLabel As System.Windows.Forms.Label
        Dim A_c_NoLabel As System.Windows.Forms.Label
        Dim Date_of_IssuedLabel As System.Windows.Forms.Label
        Dim StartNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckBook_form))
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.Check_Book_detailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Check_Book_detailTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.Check_Book_detailTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.Check_Book_detailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Check_Book_detailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CheckBookNoTextBox = New System.Windows.Forms.TextBox()
        Me.A_c_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_IssuedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBookNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfIssuedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CheckBookNoLabel = New System.Windows.Forms.Label()
        A_c_NoLabel = New System.Windows.Forms.Label()
        Date_of_IssuedLabel = New System.Windows.Forms.Label()
        StartNumberLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Check_Book_detailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Check_Book_detailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Check_Book_detailBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBookNoLabel
        '
        CheckBookNoLabel.AutoSize = True
        CheckBookNoLabel.Location = New System.Drawing.Point(28, 60)
        CheckBookNoLabel.Name = "CheckBookNoLabel"
        CheckBookNoLabel.Size = New System.Drawing.Size(86, 13)
        CheckBookNoLabel.TabIndex = 1
        CheckBookNoLabel.Text = "Check Book No:"
        '
        'A_c_NoLabel
        '
        A_c_NoLabel.AutoSize = True
        A_c_NoLabel.Location = New System.Drawing.Point(28, 86)
        A_c_NoLabel.Name = "A_c_NoLabel"
        A_c_NoLabel.Size = New System.Drawing.Size(45, 13)
        A_c_NoLabel.TabIndex = 3
        A_c_NoLabel.Text = "A/c No:"
        '
        'Date_of_IssuedLabel
        '
        Date_of_IssuedLabel.AutoSize = True
        Date_of_IssuedLabel.Location = New System.Drawing.Point(28, 113)
        Date_of_IssuedLabel.Name = "Date_of_IssuedLabel"
        Date_of_IssuedLabel.Size = New System.Drawing.Size(79, 13)
        Date_of_IssuedLabel.TabIndex = 5
        Date_of_IssuedLabel.Text = "Date of Issued:"
        '
        'StartNumberLabel
        '
        StartNumberLabel.AutoSize = True
        StartNumberLabel.Location = New System.Drawing.Point(28, 138)
        StartNumberLabel.Name = "StartNumberLabel"
        StartNumberLabel.Size = New System.Drawing.Size(72, 13)
        StartNumberLabel.TabIndex = 7
        StartNumberLabel.Text = "Start Number:"
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Check_Book_detailBindingSource
        '
        Me.Check_Book_detailBindingSource.DataMember = "Check Book detail"
        Me.Check_Book_detailBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'Check_Book_detailTableAdapter
        '
        Me.Check_Book_detailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Account_closing_formTableAdapter = Nothing
        Me.TableAdapterManager.ATM_CardTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_Book_detailTableAdapter = Me.Check_Book_detailTableAdapter
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
        'Check_Book_detailBindingNavigator
        '
        Me.Check_Book_detailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Check_Book_detailBindingNavigator.BindingSource = Me.Check_Book_detailBindingSource
        Me.Check_Book_detailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Check_Book_detailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Check_Book_detailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Check_Book_detailBindingNavigatorSaveItem})
        Me.Check_Book_detailBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Check_Book_detailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Check_Book_detailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Check_Book_detailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Check_Book_detailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Check_Book_detailBindingNavigator.Name = "Check_Book_detailBindingNavigator"
        Me.Check_Book_detailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Check_Book_detailBindingNavigator.Size = New System.Drawing.Size(840, 25)
        Me.Check_Book_detailBindingNavigator.TabIndex = 0
        Me.Check_Book_detailBindingNavigator.Text = "BindingNavigator1"
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
        'Check_Book_detailBindingNavigatorSaveItem
        '
        Me.Check_Book_detailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Check_Book_detailBindingNavigatorSaveItem.Image = CType(resources.GetObject("Check_Book_detailBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Check_Book_detailBindingNavigatorSaveItem.Name = "Check_Book_detailBindingNavigatorSaveItem"
        Me.Check_Book_detailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Check_Book_detailBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CheckBookNoTextBox
        '
        Me.CheckBookNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Check_Book_detailBindingSource, "CheckBookNo", True))
        Me.CheckBookNoTextBox.Location = New System.Drawing.Point(120, 57)
        Me.CheckBookNoTextBox.Name = "CheckBookNoTextBox"
        Me.CheckBookNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CheckBookNoTextBox.TabIndex = 2
        '
        'A_c_NoTextBox
        '
        Me.A_c_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Check_Book_detailBindingSource, "A/c No", True))
        Me.A_c_NoTextBox.Location = New System.Drawing.Point(120, 83)
        Me.A_c_NoTextBox.Name = "A_c_NoTextBox"
        Me.A_c_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.A_c_NoTextBox.TabIndex = 4
        '
        'Date_of_IssuedDateTimePicker
        '
        Me.Date_of_IssuedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Check_Book_detailBindingSource, "Date of Issued", True))
        Me.Date_of_IssuedDateTimePicker.Location = New System.Drawing.Point(120, 109)
        Me.Date_of_IssuedDateTimePicker.Name = "Date_of_IssuedDateTimePicker"
        Me.Date_of_IssuedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_of_IssuedDateTimePicker.TabIndex = 6
        '
        'StartNumberTextBox
        '
        Me.StartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Check_Book_detailBindingSource, "StartNumber", True))
        Me.StartNumberTextBox.Location = New System.Drawing.Point(120, 135)
        Me.StartNumberTextBox.Name = "StartNumberTextBox"
        Me.StartNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StartNumberTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(198, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(279, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(360, 183)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBookNoDataGridViewTextBoxColumn, Me.AcNoDataGridViewTextBoxColumn, Me.DateOfIssuedDataGridViewTextBoxColumn, Me.StartNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Check_Book_detailBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(341, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'CheckBookNoDataGridViewTextBoxColumn
        '
        Me.CheckBookNoDataGridViewTextBoxColumn.DataPropertyName = "CheckBookNo"
        Me.CheckBookNoDataGridViewTextBoxColumn.HeaderText = "CheckBookNo"
        Me.CheckBookNoDataGridViewTextBoxColumn.Name = "CheckBookNoDataGridViewTextBoxColumn"
        '
        'AcNoDataGridViewTextBoxColumn
        '
        Me.AcNoDataGridViewTextBoxColumn.DataPropertyName = "A/c No"
        Me.AcNoDataGridViewTextBoxColumn.HeaderText = "A/c No"
        Me.AcNoDataGridViewTextBoxColumn.Name = "AcNoDataGridViewTextBoxColumn"
        '
        'DateOfIssuedDataGridViewTextBoxColumn
        '
        Me.DateOfIssuedDataGridViewTextBoxColumn.DataPropertyName = "Date of Issued"
        Me.DateOfIssuedDataGridViewTextBoxColumn.HeaderText = "Date of Issued"
        Me.DateOfIssuedDataGridViewTextBoxColumn.Name = "DateOfIssuedDataGridViewTextBoxColumn"
        '
        'StartNumberDataGridViewTextBoxColumn
        '
        Me.StartNumberDataGridViewTextBoxColumn.DataPropertyName = "StartNumber"
        Me.StartNumberDataGridViewTextBoxColumn.HeaderText = "StartNumber"
        Me.StartNumberDataGridViewTextBoxColumn.Name = "StartNumberDataGridViewTextBoxColumn"
        '
        'CheckBook_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 210)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CheckBookNoLabel)
        Me.Controls.Add(Me.CheckBookNoTextBox)
        Me.Controls.Add(A_c_NoLabel)
        Me.Controls.Add(Me.A_c_NoTextBox)
        Me.Controls.Add(Date_of_IssuedLabel)
        Me.Controls.Add(Me.Date_of_IssuedDateTimePicker)
        Me.Controls.Add(StartNumberLabel)
        Me.Controls.Add(Me.StartNumberTextBox)
        Me.Controls.Add(Me.Check_Book_detailBindingNavigator)
        Me.Name = "CheckBook_form"
        Me.Text = "CheckBook_form"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Check_Book_detailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Check_Book_detailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Check_Book_detailBindingNavigator.ResumeLayout(False)
        Me.Check_Book_detailBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents Check_Book_detailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Check_Book_detailTableAdapter As My_system.Banking_managmentDataSetTableAdapters.Check_Book_detailTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Check_Book_detailBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Check_Book_detailBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CheckBookNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_c_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_IssuedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBookNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfIssuedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
