<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim P_idLabel As System.Windows.Forms.Label
        Dim Patient_s_nameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Room_NoLabel As System.Windows.Forms.Label
        Dim Dr_preferredLabel As System.Windows.Forms.Label
        Dim Reg_feeLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SystemDataSet = New WindowsApplication1.systemDataSet()
        Me.Patient_RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_RegistrationTableAdapter = New WindowsApplication1.systemDataSetTableAdapters.Patient_RegistrationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager()
        Me.Patient_RegistrationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Patient_RegistrationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.P_idTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_s_nameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Room_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Dr_preferredTextBox = New System.Windows.Forms.TextBox()
        Me.Reg_feeTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        P_idLabel = New System.Windows.Forms.Label()
        Patient_s_nameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Room_NoLabel = New System.Windows.Forms.Label()
        Dr_preferredLabel = New System.Windows.Forms.Label()
        Reg_feeLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_RegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Patient_RegistrationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_idLabel
        '
        P_idLabel.AutoSize = True
        P_idLabel.Location = New System.Drawing.Point(126, 81)
        P_idLabel.Name = "P_idLabel"
        P_idLabel.Size = New System.Drawing.Size(28, 13)
        P_idLabel.TabIndex = 1
        P_idLabel.Text = "P id:"
        '
        'Patient_s_nameLabel
        '
        Patient_s_nameLabel.AutoSize = True
        Patient_s_nameLabel.Location = New System.Drawing.Point(126, 107)
        Patient_s_nameLabel.Name = "Patient_s_nameLabel"
        Patient_s_nameLabel.Size = New System.Drawing.Size(79, 13)
        Patient_s_nameLabel.TabIndex = 3
        Patient_s_nameLabel.Text = "Patient's name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(126, 133)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 5
        AgeLabel.Text = "Age:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(126, 159)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(28, 13)
        SexLabel.TabIndex = 7
        SexLabel.Text = "Sex:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(126, 185)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'Room_NoLabel
        '
        Room_NoLabel.AutoSize = True
        Room_NoLabel.Location = New System.Drawing.Point(126, 211)
        Room_NoLabel.Name = "Room_NoLabel"
        Room_NoLabel.Size = New System.Drawing.Size(55, 13)
        Room_NoLabel.TabIndex = 11
        Room_NoLabel.Text = "Room No:"
        '
        'Dr_preferredLabel
        '
        Dr_preferredLabel.AutoSize = True
        Dr_preferredLabel.Location = New System.Drawing.Point(126, 237)
        Dr_preferredLabel.Name = "Dr_preferredLabel"
        Dr_preferredLabel.Size = New System.Drawing.Size(66, 13)
        Dr_preferredLabel.TabIndex = 13
        Dr_preferredLabel.Text = "Dr preferred:"
        '
        'Reg_feeLabel
        '
        Reg_feeLabel.AutoSize = True
        Reg_feeLabel.Location = New System.Drawing.Point(126, 263)
        Reg_feeLabel.Name = "Reg_feeLabel"
        Reg_feeLabel.Size = New System.Drawing.Size(48, 13)
        Reg_feeLabel.TabIndex = 15
        Reg_feeLabel.Text = "Reg fee:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(126, 290)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 17
        DateLabel.Text = "Date:"
        '
        'SystemDataSet
        '
        Me.SystemDataSet.DataSetName = "systemDataSet"
        Me.SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Patient_RegistrationBindingSource
        '
        Me.Patient_RegistrationBindingSource.DataMember = "Patient Registration"
        Me.Patient_RegistrationBindingSource.DataSource = Me.SystemDataSet
        '
        'Patient_RegistrationTableAdapter
        '
        Me.Patient_RegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Doctor_s_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Edite__PatientTableAdapter = Nothing
        Me.TableAdapterManager.Edite_Dr_s_formTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Me.Patient_RegistrationTableAdapter
        Me.TableAdapterManager.Rooms_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Patient_RegistrationBindingNavigator
        '
        Me.Patient_RegistrationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Patient_RegistrationBindingNavigator.BindingSource = Me.Patient_RegistrationBindingSource
        Me.Patient_RegistrationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Patient_RegistrationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Patient_RegistrationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Patient_RegistrationBindingNavigatorSaveItem})
        Me.Patient_RegistrationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Patient_RegistrationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Patient_RegistrationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Patient_RegistrationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Patient_RegistrationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Patient_RegistrationBindingNavigator.Name = "Patient_RegistrationBindingNavigator"
        Me.Patient_RegistrationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Patient_RegistrationBindingNavigator.Size = New System.Drawing.Size(638, 25)
        Me.Patient_RegistrationBindingNavigator.TabIndex = 0
        Me.Patient_RegistrationBindingNavigator.Text = "BindingNavigator1"
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
        'Patient_RegistrationBindingNavigatorSaveItem
        '
        Me.Patient_RegistrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Patient_RegistrationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Patient_RegistrationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Patient_RegistrationBindingNavigatorSaveItem.Name = "Patient_RegistrationBindingNavigatorSaveItem"
        Me.Patient_RegistrationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Patient_RegistrationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'P_idTextBox
        '
        Me.P_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RegistrationBindingSource, "P_id", True))
        Me.P_idTextBox.Location = New System.Drawing.Point(211, 78)
        Me.P_idTextBox.Name = "P_idTextBox"
        Me.P_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_idTextBox.TabIndex = 2
        '
        'Patient_s_nameTextBox
        '
        Me.Patient_s_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RegistrationBindingSource, "Patient's name", True))
        Me.Patient_s_nameTextBox.Location = New System.Drawing.Point(211, 104)
        Me.Patient_s_nameTextBox.Name = "Patient_s_nameTextBox"
        Me.Patient_s_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Patient_s_nameTextBox.TabIndex = 4
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RegistrationBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(211, 130)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgeTextBox.TabIndex = 6
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RegistrationBindingSource, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(211, 156)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SexTextBox.TabIndex = 8
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RegistrationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(211, 182)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 10
        '
        'Room_NoTextBox
        '
        Me.Room_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RegistrationBindingSource, "Room_No", True))
        Me.Room_NoTextBox.Location = New System.Drawing.Point(211, 208)
        Me.Room_NoTextBox.Name = "Room_NoTextBox"
        Me.Room_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Room_NoTextBox.TabIndex = 12
        '
        'Dr_preferredTextBox
        '
        Me.Dr_preferredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RegistrationBindingSource, "Dr_preferred", True))
        Me.Dr_preferredTextBox.Location = New System.Drawing.Point(211, 234)
        Me.Dr_preferredTextBox.Name = "Dr_preferredTextBox"
        Me.Dr_preferredTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Dr_preferredTextBox.TabIndex = 14
        '
        'Reg_feeTextBox
        '
        Me.Reg_feeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RegistrationBindingSource, "Reg_fee", True))
        Me.Reg_feeTextBox.Location = New System.Drawing.Point(211, 260)
        Me.Reg_feeTextBox.Name = "Reg_feeTextBox"
        Me.Reg_feeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Reg_feeTextBox.TabIndex = 16
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Patient_RegistrationBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(211, 286)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(240, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "View patient"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 374)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(P_idLabel)
        Me.Controls.Add(Me.P_idTextBox)
        Me.Controls.Add(Patient_s_nameLabel)
        Me.Controls.Add(Me.Patient_s_nameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.SexTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Room_NoLabel)
        Me.Controls.Add(Me.Room_NoTextBox)
        Me.Controls.Add(Dr_preferredLabel)
        Me.Controls.Add(Me.Dr_preferredTextBox)
        Me.Controls.Add(Reg_feeLabel)
        Me.Controls.Add(Me.Reg_feeTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.Patient_RegistrationBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_RegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Patient_RegistrationBindingNavigator.ResumeLayout(False)
        Me.Patient_RegistrationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SystemDataSet As WindowsApplication1.systemDataSet
    Friend WithEvents Patient_RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Patient_RegistrationTableAdapter As WindowsApplication1.systemDataSetTableAdapters.Patient_RegistrationTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Patient_RegistrationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Patient_RegistrationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents P_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_s_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dr_preferredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Reg_feeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
