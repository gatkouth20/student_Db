<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BtnPreview
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Dr_s_nameLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim Consultation_dayLabel As System.Windows.Forms.Label
        Dim Consultation_time_FromLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Contact_numberLabel As System.Windows.Forms.Label
        Dim Emergency_numberLabel As System.Windows.Forms.Label
        Dim ConsultationLabel As System.Windows.Forms.Label
        Dim Total_patientLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BtnPreview))
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.Doctor_s_registrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Doctor_s_registrationTableAdapter = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Doctor_s_registrationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Dr_s_nameTextBox = New System.Windows.Forms.TextBox()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Consultation_dayTextBox = New System.Windows.Forms.TextBox()
        Me.Consultation_time_FromTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_numberTextBox = New System.Windows.Forms.TextBox()
        Me.ConsultationTextBox = New System.Windows.Forms.TextBox()
        Me.Total_patientTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Doctor_s_registrationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Doctor_s_registrationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        Dr_s_nameLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        Consultation_dayLabel = New System.Windows.Forms.Label()
        Consultation_time_FromLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Contact_numberLabel = New System.Windows.Forms.Label()
        Emergency_numberLabel = New System.Windows.Forms.Label()
        ConsultationLabel = New System.Windows.Forms.Label()
        Total_patientLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_s_registrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_s_registrationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Doctor_s_registrationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(218, 96)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 15)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'Dr_s_nameLabel
        '
        Dr_s_nameLabel.AutoSize = True
        Dr_s_nameLabel.Location = New System.Drawing.Point(169, 128)
        Dr_s_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Dr_s_nameLabel.Name = "Dr_s_nameLabel"
        Dr_s_nameLabel.Size = New System.Drawing.Size(77, 15)
        Dr_s_nameLabel.TabIndex = 3
        Dr_s_nameLabel.Text = "Dr's name:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(208, 156)
        SexLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(35, 15)
        SexLabel.TabIndex = 5
        SexLabel.Text = "Sex:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(160, 191)
        DepartmentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(86, 15)
        DepartmentLabel.TabIndex = 7
        DepartmentLabel.Text = "Department:"
        '
        'Consultation_dayLabel
        '
        Consultation_dayLabel.AutoSize = True
        Consultation_dayLabel.Location = New System.Drawing.Point(129, 218)
        Consultation_dayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Consultation_dayLabel.Name = "Consultation_dayLabel"
        Consultation_dayLabel.Size = New System.Drawing.Size(117, 15)
        Consultation_dayLabel.TabIndex = 9
        Consultation_dayLabel.Text = "Consultation day:"
        '
        'Consultation_time_FromLabel
        '
        Consultation_time_FromLabel.AutoSize = True
        Consultation_time_FromLabel.Location = New System.Drawing.Point(93, 249)
        Consultation_time_FromLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Consultation_time_FromLabel.Name = "Consultation_time_FromLabel"
        Consultation_time_FromLabel.Size = New System.Drawing.Size(158, 15)
        Consultation_time_FromLabel.TabIndex = 11
        Consultation_time_FromLabel.Text = "consultation time From:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(180, 279)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 15)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "Address:"
        '
        'Contact_numberLabel
        '
        Contact_numberLabel.AutoSize = True
        Contact_numberLabel.Location = New System.Drawing.Point(136, 350)
        Contact_numberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Contact_numberLabel.Name = "Contact_numberLabel"
        Contact_numberLabel.Size = New System.Drawing.Size(112, 15)
        Contact_numberLabel.TabIndex = 15
        Contact_numberLabel.Text = "Contact number:"
        '
        'Emergency_numberLabel
        '
        Emergency_numberLabel.AutoSize = True
        Emergency_numberLabel.Location = New System.Drawing.Point(113, 380)
        Emergency_numberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Emergency_numberLabel.Name = "Emergency_numberLabel"
        Emergency_numberLabel.Size = New System.Drawing.Size(135, 15)
        Emergency_numberLabel.TabIndex = 17
        Emergency_numberLabel.Text = "Emergency number:"
        '
        'ConsultationLabel
        '
        ConsultationLabel.AutoSize = True
        ConsultationLabel.Location = New System.Drawing.Point(136, 410)
        ConsultationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ConsultationLabel.Name = "ConsultationLabel"
        ConsultationLabel.Size = New System.Drawing.Size(111, 15)
        ConsultationLabel.TabIndex = 19
        ConsultationLabel.Text = "Consultation fee"
        '
        'Total_patientLabel
        '
        Total_patientLabel.AutoSize = True
        Total_patientLabel.Location = New System.Drawing.Point(154, 445)
        Total_patientLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_patientLabel.Name = "Total_patientLabel"
        Total_patientLabel.Size = New System.Drawing.Size(91, 15)
        Total_patientLabel.TabIndex = 21
        Total_patientLabel.Text = "Total patient:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(204, 470)
        DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(39, 15)
        DateLabel.TabIndex = 23
        DateLabel.Text = "date:"
        '
        'Hospital_management_systemDataSet
        '
        Me.Hospital_management_systemDataSet.DataSetName = "Hospital_management_systemDataSet"
        Me.Hospital_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Doctor_s_registrationBindingSource
        '
        Me.Doctor_s_registrationBindingSource.DataMember = "Doctor's registration"
        Me.Doctor_s_registrationBindingSource.DataSource = Me.Hospital_management_systemDataSet
        '
        'Doctor_s_registrationTableAdapter
        '
        Me.Doctor_s_registrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Add_new_departmentTableAdapter = Nothing
        Me.TableAdapterManager.Add_new_RoomTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Blood_Bank_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Discharge_SheetTableAdapter = Nothing
        Me.TableAdapterManager.Doctor_s_registrationTableAdapter = Me.Doctor_s_registrationTableAdapter
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
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(254, 96)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(98, 21)
        Me.IDTextBox.TabIndex = 2
        '
        'Dr_s_nameTextBox
        '
        Me.Dr_s_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "Dr's name", True))
        Me.Dr_s_nameTextBox.Location = New System.Drawing.Point(254, 126)
        Me.Dr_s_nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Dr_s_nameTextBox.Name = "Dr_s_nameTextBox"
        Me.Dr_s_nameTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Dr_s_nameTextBox.TabIndex = 4
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(254, 156)
        Me.SexTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(98, 21)
        Me.SexTextBox.TabIndex = 6
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(254, 186)
        Me.DepartmentTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(265, 21)
        Me.DepartmentTextBox.TabIndex = 8
        '
        'Consultation_dayTextBox
        '
        Me.Consultation_dayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "Consultation day", True))
        Me.Consultation_dayTextBox.Location = New System.Drawing.Point(254, 216)
        Me.Consultation_dayTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Consultation_dayTextBox.Name = "Consultation_dayTextBox"
        Me.Consultation_dayTextBox.Size = New System.Drawing.Size(98, 21)
        Me.Consultation_dayTextBox.TabIndex = 10
        '
        'Consultation_time_FromTextBox
        '
        Me.Consultation_time_FromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "consultation time From", True))
        Me.Consultation_time_FromTextBox.Location = New System.Drawing.Point(254, 246)
        Me.Consultation_time_FromTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Consultation_time_FromTextBox.Name = "Consultation_time_FromTextBox"
        Me.Consultation_time_FromTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Consultation_time_FromTextBox.TabIndex = 12
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(254, 279)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(265, 63)
        Me.AddressTextBox.TabIndex = 14
        '
        'Contact_numberTextBox
        '
        Me.Contact_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "Contact number", True))
        Me.Contact_numberTextBox.Location = New System.Drawing.Point(254, 350)
        Me.Contact_numberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Contact_numberTextBox.Name = "Contact_numberTextBox"
        Me.Contact_numberTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Contact_numberTextBox.TabIndex = 16
        '
        'Emergency_numberTextBox
        '
        Me.Emergency_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "Emergency number", True))
        Me.Emergency_numberTextBox.Location = New System.Drawing.Point(254, 380)
        Me.Emergency_numberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Emergency_numberTextBox.Name = "Emergency_numberTextBox"
        Me.Emergency_numberTextBox.Size = New System.Drawing.Size(98, 21)
        Me.Emergency_numberTextBox.TabIndex = 18
        '
        'ConsultationTextBox
        '
        Me.ConsultationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "Consultation", True))
        Me.ConsultationTextBox.Location = New System.Drawing.Point(254, 410)
        Me.ConsultationTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsultationTextBox.Name = "ConsultationTextBox"
        Me.ConsultationTextBox.Size = New System.Drawing.Size(265, 21)
        Me.ConsultationTextBox.TabIndex = 20
        '
        'Total_patientTextBox
        '
        Me.Total_patientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_registrationBindingSource, "Total patient", True))
        Me.Total_patientTextBox.Location = New System.Drawing.Point(254, 440)
        Me.Total_patientTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Total_patientTextBox.Name = "Total_patientTextBox"
        Me.Total_patientTextBox.Size = New System.Drawing.Size(98, 21)
        Me.Total_patientTextBox.TabIndex = 22
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Doctor_s_registrationBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(254, 470)
        Me.DateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(265, 21)
        Me.DateDateTimePicker.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(128, 516)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 26)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Add new"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(254, 516)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 26)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 23)
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
        'Doctor_s_registrationBindingNavigatorSaveItem
        '
        Me.Doctor_s_registrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Doctor_s_registrationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Doctor_s_registrationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Doctor_s_registrationBindingNavigatorSaveItem.Name = "Doctor_s_registrationBindingNavigatorSaveItem"
        Me.Doctor_s_registrationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Doctor_s_registrationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Doctor_s_registrationBindingNavigator
        '
        Me.Doctor_s_registrationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Doctor_s_registrationBindingNavigator.BindingSource = Me.Doctor_s_registrationBindingSource
        Me.Doctor_s_registrationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Doctor_s_registrationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Doctor_s_registrationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Doctor_s_registrationBindingNavigatorSaveItem})
        Me.Doctor_s_registrationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Doctor_s_registrationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Doctor_s_registrationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Doctor_s_registrationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Doctor_s_registrationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Doctor_s_registrationBindingNavigator.Name = "Doctor_s_registrationBindingNavigator"
        Me.Doctor_s_registrationBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Doctor_s_registrationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Doctor_s_registrationBindingNavigator.Size = New System.Drawing.Size(939, 25)
        Me.Doctor_s_registrationBindingNavigator.TabIndex = 0
        Me.Doctor_s_registrationBindingNavigator.Text = "BindingNavigator1"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Doctor_s_registrationBindingSource
        Me.ComboBox1.DisplayMember = "Dr's name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(724, 95)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 23)
        Me.ComboBox1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(638, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Look up"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(363, 516)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 26)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = " view"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Welcome to doctor's registration form"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(470, 517)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtnPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(939, 556)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Dr_s_nameLabel)
        Me.Controls.Add(Me.Dr_s_nameTextBox)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.SexTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Consultation_dayLabel)
        Me.Controls.Add(Me.Consultation_dayTextBox)
        Me.Controls.Add(Consultation_time_FromLabel)
        Me.Controls.Add(Me.Consultation_time_FromTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Contact_numberLabel)
        Me.Controls.Add(Me.Contact_numberTextBox)
        Me.Controls.Add(Emergency_numberLabel)
        Me.Controls.Add(Me.Emergency_numberTextBox)
        Me.Controls.Add(ConsultationLabel)
        Me.Controls.Add(Me.ConsultationTextBox)
        Me.Controls.Add(Total_patientLabel)
        Me.Controls.Add(Me.Total_patientTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.Doctor_s_registrationBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BtnPreview"
        Me.Text = "Doctor_form"
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_s_registrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_s_registrationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Doctor_s_registrationBindingNavigator.ResumeLayout(False)
        Me.Doctor_s_registrationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hospital_management_systemDataSet As WindowsApplication1.Hospital_management_systemDataSet
    Friend WithEvents Doctor_s_registrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Doctor_s_registrationTableAdapter As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Doctor_s_registrationTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dr_s_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Consultation_dayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Consultation_time_FromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Contact_numberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emergency_numberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConsultationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_patientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Doctor_s_registrationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Doctor_s_registrationBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
