<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OP_Bill
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
        Dim Op_idLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DoctorLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim PharmacyLabel As System.Windows.Forms.Label
        Dim Lab_testLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OP_Bill))
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.OP_BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OP_BillTableAdapter = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.OP_BillTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.OP_BillBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OP_BillBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Op_idTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.PharmacyTextBox = New System.Windows.Forms.TextBox()
        Me.Lab_testTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Op_idLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DoctorLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        PharmacyLabel = New System.Windows.Forms.Label()
        Lab_testLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OP_BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OP_BillBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OP_BillBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Op_idLabel
        '
        Op_idLabel.AutoSize = True
        Op_idLabel.Location = New System.Drawing.Point(16, 75)
        Op_idLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Op_idLabel.Name = "Op_idLabel"
        Op_idLabel.Size = New System.Drawing.Size(43, 15)
        Op_idLabel.TabIndex = 1
        Op_idLabel.Text = "op id:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(16, 105)
        PatientIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(74, 15)
        PatientIDLabel.TabIndex = 3
        PatientIDLabel.Text = "Patient ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(16, 135)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 15)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name:"
        '
        'DoctorLabel
        '
        DoctorLabel.AutoSize = True
        DoctorLabel.Location = New System.Drawing.Point(16, 165)
        DoctorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DoctorLabel.Name = "DoctorLabel"
        DoctorLabel.Size = New System.Drawing.Size(53, 15)
        DoctorLabel.TabIndex = 7
        DoctorLabel.Text = "Doctor:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(16, 196)
        DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(41, 15)
        DateLabel.TabIndex = 9
        DateLabel.Text = "Date:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(16, 225)
        AmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(59, 15)
        AmountLabel.TabIndex = 11
        AmountLabel.Text = "Amount:"
        '
        'PharmacyLabel
        '
        PharmacyLabel.AutoSize = True
        PharmacyLabel.Location = New System.Drawing.Point(16, 255)
        PharmacyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PharmacyLabel.Name = "PharmacyLabel"
        PharmacyLabel.Size = New System.Drawing.Size(74, 15)
        PharmacyLabel.TabIndex = 13
        PharmacyLabel.Text = "Pharmacy:"
        '
        'Lab_testLabel
        '
        Lab_testLabel.AutoSize = True
        Lab_testLabel.Location = New System.Drawing.Point(16, 285)
        Lab_testLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Lab_testLabel.Name = "Lab_testLabel"
        Lab_testLabel.Size = New System.Drawing.Size(62, 15)
        Lab_testLabel.TabIndex = 15
        Lab_testLabel.Text = "Lab test:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(16, 315)
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
        'OP_BillBindingSource
        '
        Me.OP_BillBindingSource.DataMember = "OP Bill"
        Me.OP_BillBindingSource.DataSource = Me.Hospital_management_systemDataSet
        '
        'OP_BillTableAdapter
        '
        Me.OP_BillTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.IP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Lab_BillTableAdapter = Nothing
        Me.TableAdapterManager.Medicine_UpdateTableAdapter = Nothing
        Me.TableAdapterManager.OP_BillTableAdapter = Me.OP_BillTableAdapter
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Pharmacy_BillTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Room_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OP_BillBindingNavigator
        '
        Me.OP_BillBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OP_BillBindingNavigator.BindingSource = Me.OP_BillBindingSource
        Me.OP_BillBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OP_BillBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OP_BillBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OP_BillBindingNavigatorSaveItem})
        Me.OP_BillBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OP_BillBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OP_BillBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OP_BillBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OP_BillBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OP_BillBindingNavigator.Name = "OP_BillBindingNavigator"
        Me.OP_BillBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.OP_BillBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OP_BillBindingNavigator.Size = New System.Drawing.Size(883, 25)
        Me.OP_BillBindingNavigator.TabIndex = 0
        Me.OP_BillBindingNavigator.Text = "BindingNavigator1"
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
        'OP_BillBindingNavigatorSaveItem
        '
        Me.OP_BillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OP_BillBindingNavigatorSaveItem.Image = CType(resources.GetObject("OP_BillBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OP_BillBindingNavigatorSaveItem.Name = "OP_BillBindingNavigatorSaveItem"
        Me.OP_BillBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OP_BillBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Op_idTextBox
        '
        Me.Op_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OP_BillBindingSource, "op_id", True))
        Me.Op_idTextBox.Location = New System.Drawing.Point(100, 71)
        Me.Op_idTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Op_idTextBox.Name = "Op_idTextBox"
        Me.Op_idTextBox.Size = New System.Drawing.Size(81, 21)
        Me.Op_idTextBox.TabIndex = 2
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OP_BillBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(100, 101)
        Me.PatientIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(81, 21)
        Me.PatientIDTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OP_BillBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(100, 131)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(265, 21)
        Me.NameTextBox.TabIndex = 6
        '
        'DoctorTextBox
        '
        Me.DoctorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OP_BillBindingSource, "Doctor", True))
        Me.DoctorTextBox.Location = New System.Drawing.Point(100, 161)
        Me.DoctorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DoctorTextBox.Name = "DoctorTextBox"
        Me.DoctorTextBox.Size = New System.Drawing.Size(265, 21)
        Me.DoctorTextBox.TabIndex = 8
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OP_BillBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(100, 191)
        Me.DateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(265, 21)
        Me.DateDateTimePicker.TabIndex = 10
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OP_BillBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(100, 221)
        Me.AmountTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(81, 21)
        Me.AmountTextBox.TabIndex = 12
        '
        'PharmacyTextBox
        '
        Me.PharmacyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OP_BillBindingSource, "Pharmacy", True))
        Me.PharmacyTextBox.Location = New System.Drawing.Point(100, 251)
        Me.PharmacyTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PharmacyTextBox.Name = "PharmacyTextBox"
        Me.PharmacyTextBox.Size = New System.Drawing.Size(81, 21)
        Me.PharmacyTextBox.TabIndex = 14
        '
        'Lab_testTextBox
        '
        Me.Lab_testTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OP_BillBindingSource, "Lab test", True))
        Me.Lab_testTextBox.Location = New System.Drawing.Point(100, 281)
        Me.Lab_testTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Lab_testTextBox.Name = "Lab_testTextBox"
        Me.Lab_testTextBox.Size = New System.Drawing.Size(81, 21)
        Me.Lab_testTextBox.TabIndex = 16
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OP_BillBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(100, 311)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(81, 21)
        Me.TotalTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(100, 354)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 26)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(208, 354)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 26)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(316, 354)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 26)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(424, 354)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 26)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(799, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Searching"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.OP_BillBindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(601, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 23)
        Me.ComboBox1.TabIndex = 24
        '
        'OP_Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(883, 395)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Op_idLabel)
        Me.Controls.Add(Me.Op_idTextBox)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(DoctorLabel)
        Me.Controls.Add(Me.DoctorTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(PharmacyLabel)
        Me.Controls.Add(Me.PharmacyTextBox)
        Me.Controls.Add(Lab_testLabel)
        Me.Controls.Add(Me.Lab_testTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.OP_BillBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OP_Bill"
        Me.Text = "OP_Bill"
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OP_BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OP_BillBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OP_BillBindingNavigator.ResumeLayout(False)
        Me.OP_BillBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hospital_management_systemDataSet As WindowsApplication1.Hospital_management_systemDataSet
    Friend WithEvents OP_BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OP_BillTableAdapter As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.OP_BillTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OP_BillBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OP_BillBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Op_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DoctorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PharmacyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lab_testTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
