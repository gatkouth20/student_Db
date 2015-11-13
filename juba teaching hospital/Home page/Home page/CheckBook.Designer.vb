<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckBook))
        Dim CheckBookNumberLabel As System.Windows.Forms.Label
        Dim AccountNumberLabel As System.Windows.Forms.Label
        Dim DateIssuedLabel As System.Windows.Forms.Label
        Dim StartNumberLabel As System.Windows.Forms.Label
        Me.OnlineBankingDataSet = New Home_page.OnlineBankingDataSet()
        Me.CheckBookDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBookDetailsTableAdapter = New Home_page.OnlineBankingDataSetTableAdapters.CheckBookDetailsTableAdapter()
        Me.TableAdapterManager = New Home_page.OnlineBankingDataSetTableAdapters.TableAdapterManager()
        Me.CheckBookDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CheckBookDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CheckBookNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DateIssuedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CheckBookNumberLabel = New System.Windows.Forms.Label()
        AccountNumberLabel = New System.Windows.Forms.Label()
        DateIssuedLabel = New System.Windows.Forms.Label()
        StartNumberLabel = New System.Windows.Forms.Label()
        CType(Me.OnlineBankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBookDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBookDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CheckBookDetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'OnlineBankingDataSet
        '
        Me.OnlineBankingDataSet.DataSetName = "OnlineBankingDataSet"
        Me.OnlineBankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBookDetailsBindingSource
        '
        Me.CheckBookDetailsBindingSource.DataMember = "CheckBookDetails"
        Me.CheckBookDetailsBindingSource.DataSource = Me.OnlineBankingDataSet
        '
        'CheckBookDetailsTableAdapter
        '
        Me.CheckBookDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountTypeTableAdapter = Nothing
        Me.TableAdapterManager.ATM_cardTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckBookDetailsTableAdapter = Me.CheckBookDetailsTableAdapter
        Me.TableAdapterManager.CustomerQueryTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
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
        'CheckBookDetailsBindingNavigator
        '
        Me.CheckBookDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CheckBookDetailsBindingNavigator.BindingSource = Me.CheckBookDetailsBindingSource
        Me.CheckBookDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CheckBookDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CheckBookDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CheckBookDetailsBindingNavigatorSaveItem})
        Me.CheckBookDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CheckBookDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CheckBookDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CheckBookDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CheckBookDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CheckBookDetailsBindingNavigator.Name = "CheckBookDetailsBindingNavigator"
        Me.CheckBookDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CheckBookDetailsBindingNavigator.Size = New System.Drawing.Size(600, 25)
        Me.CheckBookDetailsBindingNavigator.TabIndex = 0
        Me.CheckBookDetailsBindingNavigator.Text = "BindingNavigator1"
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
        'CheckBookDetailsBindingNavigatorSaveItem
        '
        Me.CheckBookDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CheckBookDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CheckBookDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CheckBookDetailsBindingNavigatorSaveItem.Name = "CheckBookDetailsBindingNavigatorSaveItem"
        Me.CheckBookDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CheckBookDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CheckBookNumberLabel
        '
        CheckBookNumberLabel.AutoSize = True
        CheckBookNumberLabel.Location = New System.Drawing.Point(56, 72)
        CheckBookNumberLabel.Name = "CheckBookNumberLabel"
        CheckBookNumberLabel.Size = New System.Drawing.Size(109, 13)
        CheckBookNumberLabel.TabIndex = 1
        CheckBookNumberLabel.Text = "Check Book Number:"
        '
        'CheckBookNumberTextBox
        '
        Me.CheckBookNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckBookDetailsBindingSource, "CheckBookNumber", True))
        Me.CheckBookNumberTextBox.Location = New System.Drawing.Point(171, 69)
        Me.CheckBookNumberTextBox.Name = "CheckBookNumberTextBox"
        Me.CheckBookNumberTextBox.Size = New System.Drawing.Size(65, 20)
        Me.CheckBookNumberTextBox.TabIndex = 2
        '
        'AccountNumberLabel
        '
        AccountNumberLabel.AutoSize = True
        AccountNumberLabel.Location = New System.Drawing.Point(56, 98)
        AccountNumberLabel.Name = "AccountNumberLabel"
        AccountNumberLabel.Size = New System.Drawing.Size(90, 13)
        AccountNumberLabel.TabIndex = 3
        AccountNumberLabel.Text = "Account Number:"
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckBookDetailsBindingSource, "AccountNumber", True))
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(171, 95)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AccountNumberTextBox.TabIndex = 4
        '
        'DateIssuedLabel
        '
        DateIssuedLabel.AutoSize = True
        DateIssuedLabel.Location = New System.Drawing.Point(56, 125)
        DateIssuedLabel.Name = "DateIssuedLabel"
        DateIssuedLabel.Size = New System.Drawing.Size(67, 13)
        DateIssuedLabel.TabIndex = 5
        DateIssuedLabel.Text = "Date Issued:"
        '
        'DateIssuedDateTimePicker
        '
        Me.DateIssuedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CheckBookDetailsBindingSource, "DateIssued", True))
        Me.DateIssuedDateTimePicker.Location = New System.Drawing.Point(171, 121)
        Me.DateIssuedDateTimePicker.Name = "DateIssuedDateTimePicker"
        Me.DateIssuedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateIssuedDateTimePicker.TabIndex = 6
        '
        'StartNumberLabel
        '
        StartNumberLabel.AutoSize = True
        StartNumberLabel.Location = New System.Drawing.Point(56, 150)
        StartNumberLabel.Name = "StartNumberLabel"
        StartNumberLabel.Size = New System.Drawing.Size(72, 13)
        StartNumberLabel.TabIndex = 7
        StartNumberLabel.Text = "Start Number:"
        '
        'StartNumberTextBox
        '
        Me.StartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckBookDetailsBindingSource, "StartNumber", True))
        Me.StartNumberTextBox.Location = New System.Drawing.Point(171, 147)
        Me.StartNumberTextBox.Name = "StartNumberTextBox"
        Me.StartNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StartNumberTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(286, 195)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(367, 195)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CheckBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(600, 221)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CheckBookNumberLabel)
        Me.Controls.Add(Me.CheckBookNumberTextBox)
        Me.Controls.Add(AccountNumberLabel)
        Me.Controls.Add(Me.AccountNumberTextBox)
        Me.Controls.Add(DateIssuedLabel)
        Me.Controls.Add(Me.DateIssuedDateTimePicker)
        Me.Controls.Add(StartNumberLabel)
        Me.Controls.Add(Me.StartNumberTextBox)
        Me.Controls.Add(Me.CheckBookDetailsBindingNavigator)
        Me.Name = "CheckBook"
        Me.Text = "CheckBook"
        CType(Me.OnlineBankingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBookDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBookDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CheckBookDetailsBindingNavigator.ResumeLayout(False)
        Me.CheckBookDetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OnlineBankingDataSet As Home_page.OnlineBankingDataSet
    Friend WithEvents CheckBookDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckBookDetailsTableAdapter As Home_page.OnlineBankingDataSetTableAdapters.CheckBookDetailsTableAdapter
    Friend WithEvents TableAdapterManager As Home_page.OnlineBankingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CheckBookDetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CheckBookDetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CheckBookNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateIssuedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
