<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_form
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
        Dim D_IDLabel As System.Windows.Forms.Label
        Dim Dr_nameLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim Consultation_dayLabel As System.Windows.Forms.Label
        Dim Consultation_timeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim Emergency_callLabel As System.Windows.Forms.Label
        Dim Consultation_feeLabel As System.Windows.Forms.Label
        Dim Total_patientLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor_form))
        Me.SystemDataSet = New WindowsApplication1.systemDataSet()
        Me.Doctor_s_RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Doctor_s_RegistrationTableAdapter = New WindowsApplication1.systemDataSetTableAdapters.Doctor_s_RegistrationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager()
        Me.Doctor_s_RegistrationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Doctor_s_RegistrationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.D_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Dr_nameTextBox = New System.Windows.Forms.TextBox()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Consultation_dayTextBox = New System.Windows.Forms.TextBox()
        Me.Consultation_timeTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_callTextBox = New System.Windows.Forms.TextBox()
        Me.Consultation_feeTextBox = New System.Windows.Forms.TextBox()
        Me.Total_patientTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        D_IDLabel = New System.Windows.Forms.Label()
        Dr_nameLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        Consultation_dayLabel = New System.Windows.Forms.Label()
        Consultation_timeLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        Emergency_callLabel = New System.Windows.Forms.Label()
        Consultation_feeLabel = New System.Windows.Forms.Label()
        Total_patientLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_s_RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_s_RegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Doctor_s_RegistrationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'D_IDLabel
        '
        D_IDLabel.AutoSize = True
        D_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        D_IDLabel.Location = New System.Drawing.Point(105, 60)
        D_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        D_IDLabel.Name = "D_IDLabel"
        D_IDLabel.Size = New System.Drawing.Size(39, 15)
        D_IDLabel.TabIndex = 1
        D_IDLabel.Text = "D ID:"
        '
        'Dr_nameLabel
        '
        Dr_nameLabel.AutoSize = True
        Dr_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dr_nameLabel.Location = New System.Drawing.Point(105, 90)
        Dr_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Dr_nameLabel.Name = "Dr_nameLabel"
        Dr_nameLabel.Size = New System.Drawing.Size(66, 15)
        Dr_nameLabel.TabIndex = 3
        Dr_nameLabel.Text = "Dr name:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexLabel.Location = New System.Drawing.Point(105, 120)
        SexLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(35, 15)
        SexLabel.TabIndex = 5
        SexLabel.Text = "Sex:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(105, 150)
        DepartmentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(86, 15)
        DepartmentLabel.TabIndex = 7
        DepartmentLabel.Text = "Department:"
        '
        'Consultation_dayLabel
        '
        Consultation_dayLabel.AutoSize = True
        Consultation_dayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Consultation_dayLabel.Location = New System.Drawing.Point(105, 180)
        Consultation_dayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Consultation_dayLabel.Name = "Consultation_dayLabel"
        Consultation_dayLabel.Size = New System.Drawing.Size(117, 15)
        Consultation_dayLabel.TabIndex = 9
        Consultation_dayLabel.Text = "Consultation day:"
        '
        'Consultation_timeLabel
        '
        Consultation_timeLabel.AutoSize = True
        Consultation_timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Consultation_timeLabel.Location = New System.Drawing.Point(105, 210)
        Consultation_timeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Consultation_timeLabel.Name = "Consultation_timeLabel"
        Consultation_timeLabel.Size = New System.Drawing.Size(123, 15)
        Consultation_timeLabel.TabIndex = 11
        Consultation_timeLabel.Text = "Consultation time:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(105, 240)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 15)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "Address:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(105, 270)
        ContactLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(59, 15)
        ContactLabel.TabIndex = 15
        ContactLabel.Text = "Contact:"
        '
        'Emergency_callLabel
        '
        Emergency_callLabel.AutoSize = True
        Emergency_callLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Emergency_callLabel.Location = New System.Drawing.Point(105, 300)
        Emergency_callLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Emergency_callLabel.Name = "Emergency_callLabel"
        Emergency_callLabel.Size = New System.Drawing.Size(109, 15)
        Emergency_callLabel.TabIndex = 17
        Emergency_callLabel.Text = "Emergency call:"
        '
        'Consultation_feeLabel
        '
        Consultation_feeLabel.AutoSize = True
        Consultation_feeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Consultation_feeLabel.Location = New System.Drawing.Point(105, 330)
        Consultation_feeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Consultation_feeLabel.Name = "Consultation_feeLabel"
        Consultation_feeLabel.Size = New System.Drawing.Size(115, 15)
        Consultation_feeLabel.TabIndex = 19
        Consultation_feeLabel.Text = "Consultation fee:"
        '
        'Total_patientLabel
        '
        Total_patientLabel.AutoSize = True
        Total_patientLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_patientLabel.Location = New System.Drawing.Point(105, 360)
        Total_patientLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_patientLabel.Name = "Total_patientLabel"
        Total_patientLabel.Size = New System.Drawing.Size(91, 15)
        Total_patientLabel.TabIndex = 21
        Total_patientLabel.Text = "Total patient:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(105, 391)
        DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(41, 15)
        DateLabel.TabIndex = 23
        DateLabel.Text = "Date:"
        '
        'SystemDataSet
        '
        Me.SystemDataSet.DataSetName = "systemDataSet"
        Me.SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Doctor_s_RegistrationBindingSource
        '
        Me.Doctor_s_RegistrationBindingSource.DataMember = "Doctor's Registration"
        Me.Doctor_s_RegistrationBindingSource.DataSource = Me.SystemDataSet
        '
        'Doctor_s_RegistrationTableAdapter
        '
        Me.Doctor_s_RegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Doctor_s_RegistrationTableAdapter = Me.Doctor_s_RegistrationTableAdapter
        Me.TableAdapterManager.Edite__PatientTableAdapter = Nothing
        Me.TableAdapterManager.Edite_Dr_s_formTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Rooms_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Doctor_s_RegistrationBindingNavigator
        '
        Me.Doctor_s_RegistrationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Doctor_s_RegistrationBindingNavigator.BindingSource = Me.Doctor_s_RegistrationBindingSource
        Me.Doctor_s_RegistrationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Doctor_s_RegistrationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Doctor_s_RegistrationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Doctor_s_RegistrationBindingNavigatorSaveItem})
        Me.Doctor_s_RegistrationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Doctor_s_RegistrationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Doctor_s_RegistrationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Doctor_s_RegistrationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Doctor_s_RegistrationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Doctor_s_RegistrationBindingNavigator.Name = "Doctor_s_RegistrationBindingNavigator"
        Me.Doctor_s_RegistrationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Doctor_s_RegistrationBindingNavigator.Size = New System.Drawing.Size(944, 25)
        Me.Doctor_s_RegistrationBindingNavigator.TabIndex = 0
        Me.Doctor_s_RegistrationBindingNavigator.Text = "BindingNavigator1"
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
        'Doctor_s_RegistrationBindingNavigatorSaveItem
        '
        Me.Doctor_s_RegistrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Doctor_s_RegistrationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Doctor_s_RegistrationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Doctor_s_RegistrationBindingNavigatorSaveItem.Name = "Doctor_s_RegistrationBindingNavigatorSaveItem"
        Me.Doctor_s_RegistrationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Doctor_s_RegistrationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'D_IDTextBox
        '
        Me.D_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "D_ID", True))
        Me.D_IDTextBox.Location = New System.Drawing.Point(233, 57)
        Me.D_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.D_IDTextBox.Name = "D_IDTextBox"
        Me.D_IDTextBox.Size = New System.Drawing.Size(265, 21)
        Me.D_IDTextBox.TabIndex = 2
        '
        'Dr_nameTextBox
        '
        Me.Dr_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Dr_name", True))
        Me.Dr_nameTextBox.Location = New System.Drawing.Point(233, 87)
        Me.Dr_nameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Dr_nameTextBox.Name = "Dr_nameTextBox"
        Me.Dr_nameTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Dr_nameTextBox.TabIndex = 4
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(233, 117)
        Me.SexTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(265, 21)
        Me.SexTextBox.TabIndex = 6
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(233, 147)
        Me.DepartmentTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(265, 21)
        Me.DepartmentTextBox.TabIndex = 8
        '
        'Consultation_dayTextBox
        '
        Me.Consultation_dayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Consultation day", True))
        Me.Consultation_dayTextBox.Location = New System.Drawing.Point(233, 177)
        Me.Consultation_dayTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Consultation_dayTextBox.Name = "Consultation_dayTextBox"
        Me.Consultation_dayTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Consultation_dayTextBox.TabIndex = 10
        '
        'Consultation_timeTextBox
        '
        Me.Consultation_timeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Consultation time", True))
        Me.Consultation_timeTextBox.Location = New System.Drawing.Point(233, 207)
        Me.Consultation_timeTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Consultation_timeTextBox.Name = "Consultation_timeTextBox"
        Me.Consultation_timeTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Consultation_timeTextBox.TabIndex = 12
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(233, 237)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(265, 21)
        Me.AddressTextBox.TabIndex = 14
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(233, 267)
        Me.ContactTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(265, 21)
        Me.ContactTextBox.TabIndex = 16
        '
        'Emergency_callTextBox
        '
        Me.Emergency_callTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Emergency call", True))
        Me.Emergency_callTextBox.Location = New System.Drawing.Point(233, 297)
        Me.Emergency_callTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Emergency_callTextBox.Name = "Emergency_callTextBox"
        Me.Emergency_callTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Emergency_callTextBox.TabIndex = 18
        '
        'Consultation_feeTextBox
        '
        Me.Consultation_feeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Consultation fee", True))
        Me.Consultation_feeTextBox.Location = New System.Drawing.Point(233, 327)
        Me.Consultation_feeTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Consultation_feeTextBox.Name = "Consultation_feeTextBox"
        Me.Consultation_feeTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Consultation_feeTextBox.TabIndex = 20
        '
        'Total_patientTextBox
        '
        Me.Total_patientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_s_RegistrationBindingSource, "Total patient", True))
        Me.Total_patientTextBox.Location = New System.Drawing.Point(233, 357)
        Me.Total_patientTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Total_patientTextBox.Name = "Total_patientTextBox"
        Me.Total_patientTextBox.Size = New System.Drawing.Size(265, 21)
        Me.Total_patientTextBox.TabIndex = 22
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Doctor_s_RegistrationBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(233, 387)
        Me.DateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(265, 21)
        Me.DateDateTimePicker.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(233, 429)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 27)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Back to main"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(411, 429)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Display"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(765, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Searching"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Doctor_s_RegistrationBindingSource
        Me.ComboBox1.DisplayMember = "Dr_name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(638, 87)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 28
        '
        'Doctor_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(944, 470)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(D_IDLabel)
        Me.Controls.Add(Me.D_IDTextBox)
        Me.Controls.Add(Dr_nameLabel)
        Me.Controls.Add(Me.Dr_nameTextBox)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.SexTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Consultation_dayLabel)
        Me.Controls.Add(Me.Consultation_dayTextBox)
        Me.Controls.Add(Consultation_timeLabel)
        Me.Controls.Add(Me.Consultation_timeTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(ContactLabel)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Emergency_callLabel)
        Me.Controls.Add(Me.Emergency_callTextBox)
        Me.Controls.Add(Consultation_feeLabel)
        Me.Controls.Add(Me.Consultation_feeTextBox)
        Me.Controls.Add(Total_patientLabel)
        Me.Controls.Add(Me.Total_patientTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.Doctor_s_RegistrationBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Doctor_form"
        Me.Text = "Doctor_form"
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_s_RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_s_RegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Doctor_s_RegistrationBindingNavigator.ResumeLayout(False)
        Me.Doctor_s_RegistrationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SystemDataSet As WindowsApplication1.systemDataSet
    Friend WithEvents Doctor_s_RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Doctor_s_RegistrationTableAdapter As WindowsApplication1.systemDataSetTableAdapters.Doctor_s_RegistrationTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Doctor_s_RegistrationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Doctor_s_RegistrationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents D_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dr_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Consultation_dayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Consultation_timeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emergency_callTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Consultation_feeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_patientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
