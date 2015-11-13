<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(new_form))
        Dim IPLabel As System.Windows.Forms.Label
        Dim Bill_NoLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DoctorLabel As System.Windows.Forms.Label
        Dim Reg_dateLabel As System.Windows.Forms.Label
        Dim Room_NoLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.IP_BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IP_BillTableAdapter = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.IP_BillTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.IP_BillBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.IP_BillBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IPTextBox = New System.Windows.Forms.TextBox()
        Me.Bill_NoTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorTextBox = New System.Windows.Forms.TextBox()
        Me.Reg_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Room_NoTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        IPLabel = New System.Windows.Forms.Label()
        Bill_NoLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DoctorLabel = New System.Windows.Forms.Label()
        Reg_dateLabel = New System.Windows.Forms.Label()
        Room_NoLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IP_BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IP_BillBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IP_BillBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(209, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Hospital_management_systemDataSet
        '
        Me.Hospital_management_systemDataSet.DataSetName = "Hospital_management_systemDataSet"
        Me.Hospital_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IP_BillBindingSource
        '
        Me.IP_BillBindingSource.DataMember = "IP Bill"
        Me.IP_BillBindingSource.DataSource = Me.Hospital_management_systemDataSet
        '
        'IP_BillTableAdapter
        '
        Me.IP_BillTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Add_new_departmentTableAdapter = Nothing
        Me.TableAdapterManager.Add_new_RoomTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Blood_Bank_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Discharge_SheetTableAdapter = Nothing
        Me.TableAdapterManager.Doctor_s_registrationTableAdapter = Nothing
        Me.TableAdapterManager.Doctor_UpdateTableAdapter = Nothing
        Me.TableAdapterManager.IP_BillTableAdapter = Me.IP_BillTableAdapter
        Me.TableAdapterManager.Lab_BillTableAdapter = Nothing
        Me.TableAdapterManager.Medicine_UpdateTableAdapter = Nothing
        Me.TableAdapterManager.OP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Pharmacy_BillTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Room_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IP_BillBindingNavigator
        '
        Me.IP_BillBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IP_BillBindingNavigator.BindingSource = Me.IP_BillBindingSource
        Me.IP_BillBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IP_BillBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IP_BillBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IP_BillBindingNavigatorSaveItem})
        Me.IP_BillBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.IP_BillBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IP_BillBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IP_BillBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IP_BillBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IP_BillBindingNavigator.Name = "IP_BillBindingNavigator"
        Me.IP_BillBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IP_BillBindingNavigator.Size = New System.Drawing.Size(582, 25)
        Me.IP_BillBindingNavigator.TabIndex = 1
        Me.IP_BillBindingNavigator.Text = "BindingNavigator1"
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
        'IP_BillBindingNavigatorSaveItem
        '
        Me.IP_BillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IP_BillBindingNavigatorSaveItem.Image = CType(resources.GetObject("IP_BillBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IP_BillBindingNavigatorSaveItem.Name = "IP_BillBindingNavigatorSaveItem"
        Me.IP_BillBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.IP_BillBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IPLabel
        '
        IPLabel.AutoSize = True
        IPLabel.Location = New System.Drawing.Point(137, 87)
        IPLabel.Name = "IPLabel"
        IPLabel.Size = New System.Drawing.Size(20, 13)
        IPLabel.TabIndex = 2
        IPLabel.Text = "IP:"
        '
        'IPTextBox
        '
        Me.IPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "IP", True))
        Me.IPTextBox.Location = New System.Drawing.Point(200, 84)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IPTextBox.TabIndex = 3
        '
        'Bill_NoLabel
        '
        Bill_NoLabel.AutoSize = True
        Bill_NoLabel.Location = New System.Drawing.Point(137, 113)
        Bill_NoLabel.Name = "Bill_NoLabel"
        Bill_NoLabel.Size = New System.Drawing.Size(40, 13)
        Bill_NoLabel.TabIndex = 4
        Bill_NoLabel.Text = "Bill No:"
        '
        'Bill_NoTextBox
        '
        Me.Bill_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Bill_No", True))
        Me.Bill_NoTextBox.Location = New System.Drawing.Point(200, 110)
        Me.Bill_NoTextBox.Name = "Bill_NoTextBox"
        Me.Bill_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Bill_NoTextBox.TabIndex = 5
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(137, 139)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(57, 13)
        PatientIDLabel.TabIndex = 6
        PatientIDLabel.Text = "Patient ID:"
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(200, 136)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PatientIDTextBox.TabIndex = 7
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(137, 165)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 8
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(200, 162)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 9
        '
        'DoctorLabel
        '
        DoctorLabel.AutoSize = True
        DoctorLabel.Location = New System.Drawing.Point(137, 191)
        DoctorLabel.Name = "DoctorLabel"
        DoctorLabel.Size = New System.Drawing.Size(42, 13)
        DoctorLabel.TabIndex = 10
        DoctorLabel.Text = "Doctor:"
        '
        'DoctorTextBox
        '
        Me.DoctorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Doctor", True))
        Me.DoctorTextBox.Location = New System.Drawing.Point(200, 188)
        Me.DoctorTextBox.Name = "DoctorTextBox"
        Me.DoctorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DoctorTextBox.TabIndex = 11
        '
        'Reg_dateLabel
        '
        Reg_dateLabel.AutoSize = True
        Reg_dateLabel.Location = New System.Drawing.Point(137, 218)
        Reg_dateLabel.Name = "Reg_dateLabel"
        Reg_dateLabel.Size = New System.Drawing.Size(54, 13)
        Reg_dateLabel.TabIndex = 12
        Reg_dateLabel.Text = "Reg date:"
        '
        'Reg_dateDateTimePicker
        '
        Me.Reg_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IP_BillBindingSource, "Reg date", True))
        Me.Reg_dateDateTimePicker.Location = New System.Drawing.Point(200, 214)
        Me.Reg_dateDateTimePicker.Name = "Reg_dateDateTimePicker"
        Me.Reg_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Reg_dateDateTimePicker.TabIndex = 13
        '
        'Room_NoLabel
        '
        Room_NoLabel.AutoSize = True
        Room_NoLabel.Location = New System.Drawing.Point(137, 243)
        Room_NoLabel.Name = "Room_NoLabel"
        Room_NoLabel.Size = New System.Drawing.Size(55, 13)
        Room_NoLabel.TabIndex = 14
        Room_NoLabel.Text = "Room No:"
        '
        'Room_NoTextBox
        '
        Me.Room_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Room_No", True))
        Me.Room_NoTextBox.Location = New System.Drawing.Point(200, 240)
        Me.Room_NoTextBox.Name = "Room_NoTextBox"
        Me.Room_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Room_NoTextBox.TabIndex = 15
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(137, 269)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(45, 13)
        AmountLabel.TabIndex = 16
        AmountLabel.Text = "amount:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(200, 266)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmountTextBox.TabIndex = 17
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(137, 295)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 18
        TotalLabel.Text = "Total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(200, 292)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalTextBox.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(390, 318)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'new_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 365)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(IPLabel)
        Me.Controls.Add(Me.IPTextBox)
        Me.Controls.Add(Bill_NoLabel)
        Me.Controls.Add(Me.Bill_NoTextBox)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(DoctorLabel)
        Me.Controls.Add(Me.DoctorTextBox)
        Me.Controls.Add(Reg_dateLabel)
        Me.Controls.Add(Me.Reg_dateDateTimePicker)
        Me.Controls.Add(Room_NoLabel)
        Me.Controls.Add(Me.Room_NoTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.IP_BillBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "new_form"
        Me.Text = "new_form"
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IP_BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IP_BillBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IP_BillBindingNavigator.ResumeLayout(False)
        Me.IP_BillBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Hospital_management_systemDataSet As WindowsApplication1.Hospital_management_systemDataSet
    Friend WithEvents IP_BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IP_BillTableAdapter As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.IP_BillTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IP_BillBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents IP_BillBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bill_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DoctorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Reg_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Room_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
