<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_new_Room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_new_Room))
        Dim R_idLabel As System.Windows.Forms.Label
        Dim Room_NoLabel As System.Windows.Forms.Label
        Dim Room_typeLabel As System.Windows.Forms.Label
        Dim Amount_dayLabel As System.Windows.Forms.Label
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.Add_new_RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Add_new_RoomTableAdapter = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Add_new_RoomTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Add_new_RoomBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Add_new_RoomBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.R_idTextBox = New System.Windows.Forms.TextBox()
        Me.Room_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Room_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_dayTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        R_idLabel = New System.Windows.Forms.Label()
        Room_NoLabel = New System.Windows.Forms.Label()
        Room_typeLabel = New System.Windows.Forms.Label()
        Amount_dayLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_new_RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_new_RoomBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Add_new_RoomBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Hospital_management_systemDataSet
        '
        Me.Hospital_management_systemDataSet.DataSetName = "Hospital_management_systemDataSet"
        Me.Hospital_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Add_new_RoomBindingSource
        '
        Me.Add_new_RoomBindingSource.DataMember = "Add new Room"
        Me.Add_new_RoomBindingSource.DataSource = Me.Hospital_management_systemDataSet
        '
        'Add_new_RoomTableAdapter
        '
        Me.Add_new_RoomTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Add_new_departmentTableAdapter = Nothing
        Me.TableAdapterManager.Add_new_RoomTableAdapter = Me.Add_new_RoomTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Blood_Bank_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Discharge_SheetTableAdapter = Nothing
        Me.TableAdapterManager.Doctor_s_registrationTableAdapter = Nothing
        Me.TableAdapterManager.Doctor_UpdateTableAdapter = Nothing
        Me.TableAdapterManager.IP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Lab_BillTableAdapter = Nothing
        Me.TableAdapterManager.Medicine_UpdateTableAdapter = Nothing
        Me.TableAdapterManager.OP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Pharmacy_BillTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Room_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Add_new_RoomBindingNavigator
        '
        Me.Add_new_RoomBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Add_new_RoomBindingNavigator.BindingSource = Me.Add_new_RoomBindingSource
        Me.Add_new_RoomBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Add_new_RoomBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Add_new_RoomBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Add_new_RoomBindingNavigatorSaveItem})
        Me.Add_new_RoomBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Add_new_RoomBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Add_new_RoomBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Add_new_RoomBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Add_new_RoomBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Add_new_RoomBindingNavigator.Name = "Add_new_RoomBindingNavigator"
        Me.Add_new_RoomBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Add_new_RoomBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Add_new_RoomBindingNavigator.TabIndex = 0
        Me.Add_new_RoomBindingNavigator.Text = "BindingNavigator1"
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
        'Add_new_RoomBindingNavigatorSaveItem
        '
        Me.Add_new_RoomBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Add_new_RoomBindingNavigatorSaveItem.Image = CType(resources.GetObject("Add_new_RoomBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Add_new_RoomBindingNavigatorSaveItem.Name = "Add_new_RoomBindingNavigatorSaveItem"
        Me.Add_new_RoomBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Add_new_RoomBindingNavigatorSaveItem.Text = "Save Data"
        '
        'R_idLabel
        '
        R_idLabel.AutoSize = True
        R_idLabel.Location = New System.Drawing.Point(49, 55)
        R_idLabel.Name = "R_idLabel"
        R_idLabel.Size = New System.Drawing.Size(29, 13)
        R_idLabel.TabIndex = 1
        R_idLabel.Text = "R id:"
        '
        'R_idTextBox
        '
        Me.R_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_new_RoomBindingSource, "R_id", True))
        Me.R_idTextBox.Location = New System.Drawing.Point(122, 52)
        Me.R_idTextBox.Name = "R_idTextBox"
        Me.R_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.R_idTextBox.TabIndex = 2
        '
        'Room_NoLabel
        '
        Room_NoLabel.AutoSize = True
        Room_NoLabel.Location = New System.Drawing.Point(49, 81)
        Room_NoLabel.Name = "Room_NoLabel"
        Room_NoLabel.Size = New System.Drawing.Size(55, 13)
        Room_NoLabel.TabIndex = 3
        Room_NoLabel.Text = "Room No:"
        '
        'Room_NoTextBox
        '
        Me.Room_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_new_RoomBindingSource, "Room_No", True))
        Me.Room_NoTextBox.Location = New System.Drawing.Point(122, 78)
        Me.Room_NoTextBox.Name = "Room_NoTextBox"
        Me.Room_NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Room_NoTextBox.TabIndex = 4
        '
        'Room_typeLabel
        '
        Room_typeLabel.AutoSize = True
        Room_typeLabel.Location = New System.Drawing.Point(49, 107)
        Room_typeLabel.Name = "Room_typeLabel"
        Room_typeLabel.Size = New System.Drawing.Size(61, 13)
        Room_typeLabel.TabIndex = 5
        Room_typeLabel.Text = "Room type:"
        '
        'Room_typeTextBox
        '
        Me.Room_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_new_RoomBindingSource, "Room type", True))
        Me.Room_typeTextBox.Location = New System.Drawing.Point(122, 104)
        Me.Room_typeTextBox.Name = "Room_typeTextBox"
        Me.Room_typeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Room_typeTextBox.TabIndex = 6
        '
        'Amount_dayLabel
        '
        Amount_dayLabel.AutoSize = True
        Amount_dayLabel.Location = New System.Drawing.Point(49, 133)
        Amount_dayLabel.Name = "Amount_dayLabel"
        Amount_dayLabel.Size = New System.Drawing.Size(67, 13)
        Amount_dayLabel.TabIndex = 7
        Amount_dayLabel.Text = "amount/day:"
        '
        'Amount_dayTextBox
        '
        Me.Amount_dayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_new_RoomBindingSource, "amount/day", True))
        Me.Amount_dayTextBox.Location = New System.Drawing.Point(122, 130)
        Me.Amount_dayTextBox.Name = "Amount_dayTextBox"
        Me.Amount_dayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Amount_dayTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Added"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Add_new_Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(R_idLabel)
        Me.Controls.Add(Me.R_idTextBox)
        Me.Controls.Add(Room_NoLabel)
        Me.Controls.Add(Me.Room_NoTextBox)
        Me.Controls.Add(Room_typeLabel)
        Me.Controls.Add(Me.Room_typeTextBox)
        Me.Controls.Add(Amount_dayLabel)
        Me.Controls.Add(Me.Amount_dayTextBox)
        Me.Controls.Add(Me.Add_new_RoomBindingNavigator)
        Me.Name = "Add_new_Room"
        Me.Text = "Add_new_Room"
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_new_RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_new_RoomBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Add_new_RoomBindingNavigator.ResumeLayout(False)
        Me.Add_new_RoomBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hospital_management_systemDataSet As WindowsApplication1.Hospital_management_systemDataSet
    Friend WithEvents Add_new_RoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Add_new_RoomTableAdapter As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Add_new_RoomTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Add_new_RoomBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Add_new_RoomBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents R_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_typeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_dayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
