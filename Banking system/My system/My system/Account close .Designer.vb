<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opening_Account
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
        Dim CLOSE_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim A_C_NoLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZIP_CodeLabel As System.Windows.Forms.Label
        Dim SignLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opening_Account))
        Me.Banking_managmentDataSet = New My_system.Banking_managmentDataSet()
        Me.Account_closing_formBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Account_closing_formTableAdapter = New My_system.Banking_managmentDataSetTableAdapters.Account_closing_formTableAdapter()
        Me.TableAdapterManager = New My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager()
        Me.Account_closing_formBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Account_closing_formBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CLOSE_IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.A_C_NoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZIP_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.SignTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CLOSE_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        A_C_NoLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZIP_CodeLabel = New System.Windows.Forms.Label()
        SignLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Account_closing_formBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Account_closing_formBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Account_closing_formBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLOSE_IDLabel
        '
        CLOSE_IDLabel.AutoSize = True
        CLOSE_IDLabel.Location = New System.Drawing.Point(34, 62)
        CLOSE_IDLabel.Name = "CLOSE_IDLabel"
        CLOSE_IDLabel.Size = New System.Drawing.Size(59, 13)
        CLOSE_IDLabel.TabIndex = 1
        CLOSE_IDLabel.Text = "CLOSE ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(34, 88)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'A_C_NoLabel
        '
        A_C_NoLabel.AutoSize = True
        A_C_NoLabel.Location = New System.Drawing.Point(34, 114)
        A_C_NoLabel.Name = "A_C_NoLabel"
        A_C_NoLabel.Size = New System.Drawing.Size(46, 13)
        A_C_NoLabel.TabIndex = 5
        A_C_NoLabel.Text = "A/C No:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(34, 140)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 7
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(34, 166)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 9
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(34, 192)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 11
        StateLabel.Text = "State:"
        '
        'ZIP_CodeLabel
        '
        ZIP_CodeLabel.AutoSize = True
        ZIP_CodeLabel.Location = New System.Drawing.Point(34, 218)
        ZIP_CodeLabel.Name = "ZIP_CodeLabel"
        ZIP_CodeLabel.Size = New System.Drawing.Size(55, 13)
        ZIP_CodeLabel.TabIndex = 13
        ZIP_CodeLabel.Text = "ZIP Code:"
        '
        'SignLabel
        '
        SignLabel.AutoSize = True
        SignLabel.Location = New System.Drawing.Point(34, 244)
        SignLabel.Name = "SignLabel"
        SignLabel.Size = New System.Drawing.Size(31, 13)
        SignLabel.TabIndex = 15
        SignLabel.Text = "Sign:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(34, 271)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 17
        DateLabel.Text = "Date:"
        '
        'Banking_managmentDataSet
        '
        Me.Banking_managmentDataSet.DataSetName = "Banking_managmentDataSet"
        Me.Banking_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Account_closing_formBindingSource
        '
        Me.Account_closing_formBindingSource.DataMember = "Account closing form"
        Me.Account_closing_formBindingSource.DataSource = Me.Banking_managmentDataSet
        '
        'Account_closing_formTableAdapter
        '
        Me.Account_closing_formTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Account_closing_formTableAdapter = Me.Account_closing_formTableAdapter
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
        Me.TableAdapterManager.Witness_informationTableAdapter = Nothing
        '
        'Account_closing_formBindingNavigator
        '
        Me.Account_closing_formBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Account_closing_formBindingNavigator.BindingSource = Me.Account_closing_formBindingSource
        Me.Account_closing_formBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Account_closing_formBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Account_closing_formBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Account_closing_formBindingNavigatorSaveItem})
        Me.Account_closing_formBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Account_closing_formBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Account_closing_formBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Account_closing_formBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Account_closing_formBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Account_closing_formBindingNavigator.Name = "Account_closing_formBindingNavigator"
        Me.Account_closing_formBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Account_closing_formBindingNavigator.Size = New System.Drawing.Size(849, 25)
        Me.Account_closing_formBindingNavigator.TabIndex = 0
        Me.Account_closing_formBindingNavigator.Text = "BindingNavigator1"
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
        'Account_closing_formBindingNavigatorSaveItem
        '
        Me.Account_closing_formBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Account_closing_formBindingNavigatorSaveItem.Image = CType(resources.GetObject("Account_closing_formBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Account_closing_formBindingNavigatorSaveItem.Name = "Account_closing_formBindingNavigatorSaveItem"
        Me.Account_closing_formBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Account_closing_formBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CLOSE_IDTextBox
        '
        Me.CLOSE_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Account_closing_formBindingSource, "CLOSE_ID", True))
        Me.CLOSE_IDTextBox.Location = New System.Drawing.Point(99, 59)
        Me.CLOSE_IDTextBox.Name = "CLOSE_IDTextBox"
        Me.CLOSE_IDTextBox.Size = New System.Drawing.Size(77, 20)
        Me.CLOSE_IDTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Account_closing_formBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(99, 85)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'A_C_NoTextBox
        '
        Me.A_C_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Account_closing_formBindingSource, "A/C No", True))
        Me.A_C_NoTextBox.Location = New System.Drawing.Point(99, 111)
        Me.A_C_NoTextBox.Name = "A_C_NoTextBox"
        Me.A_C_NoTextBox.Size = New System.Drawing.Size(77, 20)
        Me.A_C_NoTextBox.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Account_closing_formBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(99, 137)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 8
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Account_closing_formBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(99, 163)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CityTextBox.TabIndex = 10
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Account_closing_formBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(99, 189)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StateTextBox.TabIndex = 12
        '
        'ZIP_CodeTextBox
        '
        Me.ZIP_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Account_closing_formBindingSource, "ZIP Code", True))
        Me.ZIP_CodeTextBox.Location = New System.Drawing.Point(99, 215)
        Me.ZIP_CodeTextBox.Name = "ZIP_CodeTextBox"
        Me.ZIP_CodeTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ZIP_CodeTextBox.TabIndex = 14
        '
        'SignTextBox
        '
        Me.SignTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Account_closing_formBindingSource, "Sign", True))
        Me.SignTextBox.Location = New System.Drawing.Point(99, 241)
        Me.SignTextBox.Name = "SignTextBox"
        Me.SignTextBox.Size = New System.Drawing.Size(77, 20)
        Me.SignTextBox.TabIndex = 16
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Account_closing_formBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(99, 267)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(317, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(532, 259)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(289, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "View Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(370, 315)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(451, 315)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Opening_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(849, 355)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(CLOSE_IDLabel)
        Me.Controls.Add(Me.CLOSE_IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(A_C_NoLabel)
        Me.Controls.Add(Me.A_C_NoTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(ZIP_CodeLabel)
        Me.Controls.Add(Me.ZIP_CodeTextBox)
        Me.Controls.Add(SignLabel)
        Me.Controls.Add(Me.SignTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.Account_closing_formBindingNavigator)
        Me.Name = "Opening_Account"
        Me.Text = "Opening_Account"
        CType(Me.Banking_managmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Account_closing_formBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Account_closing_formBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Account_closing_formBindingNavigator.ResumeLayout(False)
        Me.Account_closing_formBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banking_managmentDataSet As My_system.Banking_managmentDataSet
    Friend WithEvents Account_closing_formBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Account_closing_formTableAdapter As My_system.Banking_managmentDataSetTableAdapters.Account_closing_formTableAdapter
    Friend WithEvents TableAdapterManager As My_system.Banking_managmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Account_closing_formBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Account_closing_formBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CLOSE_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_C_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZIP_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
