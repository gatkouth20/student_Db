<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IP_Bill
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
        Dim IPLabel As System.Windows.Forms.Label
        Dim Bill_NoLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DoctorLabel As System.Windows.Forms.Label
        Dim Reg_dateLabel As System.Windows.Forms.Label
        Dim Room_NoLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IP_Bill))
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.IP_BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IP_BillTableAdapter = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.IP_BillTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.IP_BillBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IP_BillDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        CType(Me.IP_BillDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IPLabel
        '
        IPLabel.AutoSize = True
        IPLabel.Location = New System.Drawing.Point(185, 103)
        IPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IPLabel.Name = "IPLabel"
        IPLabel.Size = New System.Drawing.Size(24, 15)
        IPLabel.TabIndex = 1
        IPLabel.Text = "IP:"
        '
        'Bill_NoLabel
        '
        Bill_NoLabel.AutoSize = True
        Bill_NoLabel.Location = New System.Drawing.Point(155, 133)
        Bill_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Bill_NoLabel.Name = "Bill_NoLabel"
        Bill_NoLabel.Size = New System.Drawing.Size(54, 15)
        Bill_NoLabel.TabIndex = 3
        Bill_NoLabel.Text = "Bill No:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(135, 166)
        PatientIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(74, 15)
        PatientIDLabel.TabIndex = 5
        PatientIDLabel.Text = "Patient ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(111, 193)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(98, 15)
        NameLabel.TabIndex = 7
        NameLabel.Text = "Patient Name:"
        '
        'DoctorLabel
        '
        DoctorLabel.AutoSize = True
        DoctorLabel.Location = New System.Drawing.Point(141, 223)
        DoctorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DoctorLabel.Name = "DoctorLabel"
        DoctorLabel.Size = New System.Drawing.Size(68, 15)
        DoctorLabel.TabIndex = 9
        DoctorLabel.Text = "Dr Name:"
        '
        'Reg_dateLabel
        '
        Reg_dateLabel.AutoSize = True
        Reg_dateLabel.Location = New System.Drawing.Point(140, 253)
        Reg_dateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Reg_dateLabel.Name = "Reg_dateLabel"
        Reg_dateLabel.Size = New System.Drawing.Size(69, 15)
        Reg_dateLabel.TabIndex = 11
        Reg_dateLabel.Text = "Reg date:"
        '
        'Room_NoLabel
        '
        Room_NoLabel.AutoSize = True
        Room_NoLabel.Location = New System.Drawing.Point(140, 283)
        Room_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Room_NoLabel.Name = "Room_NoLabel"
        Room_NoLabel.Size = New System.Drawing.Size(71, 15)
        Room_NoLabel.TabIndex = 13
        Room_NoLabel.Text = "Room No:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(152, 313)
        AmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(59, 15)
        AmountLabel.TabIndex = 15
        AmountLabel.Text = "Amount:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(168, 342)
        TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(43, 15)
        TotalLabel.TabIndex = 17
        TotalLabel.Text = "Total:"
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
        Me.IP_BillBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.IP_BillBindingNavigator.TabIndex = 0
        Me.IP_BillBindingNavigator.Text = "BindingNavigator1"
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
        'IP_BillBindingNavigatorSaveItem
        '
        Me.IP_BillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IP_BillBindingNavigatorSaveItem.Image = CType(resources.GetObject("IP_BillBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IP_BillBindingNavigatorSaveItem.Name = "IP_BillBindingNavigatorSaveItem"
        Me.IP_BillBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.IP_BillBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IPTextBox
        '
        Me.IPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "IP", True))
        Me.IPTextBox.Location = New System.Drawing.Point(219, 103)
        Me.IPTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.Size = New System.Drawing.Size(265, 21)
        Me.IPTextBox.TabIndex = 2
        '
        'Bill_NoTextBox
        '
        Me.Bill_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Bill_No", True))
        Me.Bill_NoTextBox.Location = New System.Drawing.Point(219, 133)
        Me.Bill_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Bill_NoTextBox.Name = "Bill_NoTextBox"
        Me.Bill_NoTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Bill_NoTextBox.TabIndex = 4
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(219, 163)
        Me.PatientIDTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(265, 21)
        Me.PatientIDTextBox.TabIndex = 6
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(219, 193)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(265, 21)
        Me.NameTextBox.TabIndex = 8
        '
        'DoctorTextBox
        '
        Me.DoctorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Doctor", True))
        Me.DoctorTextBox.Location = New System.Drawing.Point(219, 223)
        Me.DoctorTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DoctorTextBox.Name = "DoctorTextBox"
        Me.DoctorTextBox.Size = New System.Drawing.Size(265, 21)
        Me.DoctorTextBox.TabIndex = 10
        '
        'Reg_dateDateTimePicker
        '
        Me.Reg_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IP_BillBindingSource, "Reg date", True))
        Me.Reg_dateDateTimePicker.Location = New System.Drawing.Point(219, 253)
        Me.Reg_dateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Reg_dateDateTimePicker.Name = "Reg_dateDateTimePicker"
        Me.Reg_dateDateTimePicker.Size = New System.Drawing.Size(265, 21)
        Me.Reg_dateDateTimePicker.TabIndex = 12
        '
        'Room_NoTextBox
        '
        Me.Room_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Room_No", True))
        Me.Room_NoTextBox.Location = New System.Drawing.Point(219, 283)
        Me.Room_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Room_NoTextBox.Name = "Room_NoTextBox"
        Me.Room_NoTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Room_NoTextBox.TabIndex = 14
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(219, 313)
        Me.AmountTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(265, 21)
        Me.AmountTextBox.TabIndex = 16
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IP_BillBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(219, 343)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(265, 21)
        Me.TotalTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(219, 392)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 27)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(340, 392)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 27)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Back to Main"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Welcome to IP Bill"
        '
        'IP_BillDataGridView
        '
        Me.IP_BillDataGridView.AutoGenerateColumns = False
        Me.IP_BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IP_BillDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.IP_BillDataGridView.DataSource = Me.IP_BillBindingSource
        Me.IP_BillDataGridView.Location = New System.Drawing.Point(493, 103)
        Me.IP_BillDataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.IP_BillDataGridView.Name = "IP_BillDataGridView"
        Me.IP_BillDataGridView.Size = New System.Drawing.Size(1256, 254)
        Me.IP_BillDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IP"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IP"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bill_No"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bill_No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Doctor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Doctor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Reg date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Reg date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Room_No"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Room_No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn8.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.IP_BillBindingSource
        Me.ComboBox1.DisplayMember = "Bill_No"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(493, 53)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(221, 23)
        Me.ComboBox1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(724, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Searching"
        '
        'IP_Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1362, 448)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.IP_BillDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "IP_Bill"
        Me.Text = "IP_Bill"
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IP_BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IP_BillBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IP_BillBindingNavigator.ResumeLayout(False)
        Me.IP_BillBindingNavigator.PerformLayout()
        CType(Me.IP_BillDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IP_BillDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
