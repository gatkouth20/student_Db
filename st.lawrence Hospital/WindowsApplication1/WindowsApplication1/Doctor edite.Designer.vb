<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_edite
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Doctor_s_nameLabel As System.Windows.Forms.Label
        Dim TimeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim Emergency_callLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor_edite))
        Me.SystemDataSet = New WindowsApplication1.systemDataSet()
        Me.Edite_Dr_s_formBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Edite_Dr_s_formTableAdapter = New WindowsApplication1.systemDataSetTableAdapters.Edite_Dr_s_formTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager()
        Me.Edite_Dr_s_formBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Edite_Dr_s_formBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_s_nameTextBox = New System.Windows.Forms.TextBox()
        Me.TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_callTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Doctor_s_nameLabel = New System.Windows.Forms.Label()
        TimeLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        Emergency_callLabel = New System.Windows.Forms.Label()
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edite_Dr_s_formBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edite_Dr_s_formBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Edite_Dr_s_formBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(98, 83)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'Doctor_s_nameLabel
        '
        Doctor_s_nameLabel.AutoSize = True
        Doctor_s_nameLabel.Location = New System.Drawing.Point(98, 109)
        Doctor_s_nameLabel.Name = "Doctor_s_nameLabel"
        Doctor_s_nameLabel.Size = New System.Drawing.Size(76, 13)
        Doctor_s_nameLabel.TabIndex = 3
        Doctor_s_nameLabel.Text = "doctor's name:"
        '
        'TimeLabel
        '
        TimeLabel.AutoSize = True
        TimeLabel.Location = New System.Drawing.Point(98, 136)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New System.Drawing.Size(33, 13)
        TimeLabel.TabIndex = 5
        TimeLabel.Text = "Time:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(98, 161)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 7
        AddressLabel.Text = "Address:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(98, 187)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(47, 13)
        ContactLabel.TabIndex = 9
        ContactLabel.Text = "Contact:"
        '
        'Emergency_callLabel
        '
        Emergency_callLabel.AutoSize = True
        Emergency_callLabel.Location = New System.Drawing.Point(98, 213)
        Emergency_callLabel.Name = "Emergency_callLabel"
        Emergency_callLabel.Size = New System.Drawing.Size(82, 13)
        Emergency_callLabel.TabIndex = 11
        Emergency_callLabel.Text = "Emergency call:"
        '
        'SystemDataSet
        '
        Me.SystemDataSet.DataSetName = "systemDataSet"
        Me.SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Edite_Dr_s_formBindingSource
        '
        Me.Edite_Dr_s_formBindingSource.DataMember = "Edite Dr's form"
        Me.Edite_Dr_s_formBindingSource.DataSource = Me.SystemDataSet
        '
        'Edite_Dr_s_formTableAdapter
        '
        Me.Edite_Dr_s_formTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Doctor_s_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Edite__PatientTableAdapter = Nothing
        Me.TableAdapterManager.Edite_Dr_s_formTableAdapter = Me.Edite_Dr_s_formTableAdapter
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Rooms_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Edite_Dr_s_formBindingNavigator
        '
        Me.Edite_Dr_s_formBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Edite_Dr_s_formBindingNavigator.BindingSource = Me.Edite_Dr_s_formBindingSource
        Me.Edite_Dr_s_formBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Edite_Dr_s_formBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Edite_Dr_s_formBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Edite_Dr_s_formBindingNavigatorSaveItem})
        Me.Edite_Dr_s_formBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Edite_Dr_s_formBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Edite_Dr_s_formBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Edite_Dr_s_formBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Edite_Dr_s_formBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Edite_Dr_s_formBindingNavigator.Name = "Edite_Dr_s_formBindingNavigator"
        Me.Edite_Dr_s_formBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Edite_Dr_s_formBindingNavigator.Size = New System.Drawing.Size(682, 25)
        Me.Edite_Dr_s_formBindingNavigator.TabIndex = 0
        Me.Edite_Dr_s_formBindingNavigator.Text = "BindingNavigator1"
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
        'Edite_Dr_s_formBindingNavigatorSaveItem
        '
        Me.Edite_Dr_s_formBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Edite_Dr_s_formBindingNavigatorSaveItem.Image = CType(resources.GetObject("Edite_Dr_s_formBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Edite_Dr_s_formBindingNavigatorSaveItem.Name = "Edite_Dr_s_formBindingNavigatorSaveItem"
        Me.Edite_Dr_s_formBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Edite_Dr_s_formBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Edite_Dr_s_formBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(186, 80)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'Doctor_s_nameTextBox
        '
        Me.Doctor_s_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Edite_Dr_s_formBindingSource, "doctor's name", True))
        Me.Doctor_s_nameTextBox.Location = New System.Drawing.Point(186, 106)
        Me.Doctor_s_nameTextBox.Name = "Doctor_s_nameTextBox"
        Me.Doctor_s_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Doctor_s_nameTextBox.TabIndex = 4
        '
        'TimeDateTimePicker
        '
        Me.TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Edite_Dr_s_formBindingSource, "Time", True))
        Me.TimeDateTimePicker.Location = New System.Drawing.Point(186, 132)
        Me.TimeDateTimePicker.Name = "TimeDateTimePicker"
        Me.TimeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TimeDateTimePicker.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Edite_Dr_s_formBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(186, 158)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 8
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Edite_Dr_s_formBindingSource, "Contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(186, 184)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ContactTextBox.TabIndex = 10
        '
        'Emergency_callTextBox
        '
        Me.Emergency_callTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Edite_Dr_s_formBindingSource, "Emergency call", True))
        Me.Emergency_callTextBox.Location = New System.Drawing.Point(186, 210)
        Me.Emergency_callTextBox.Name = "Emergency_callTextBox"
        Me.Emergency_callTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Emergency_callTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.Location = New System.Drawing.Point(186, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Doctor_edite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(682, 284)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Doctor_s_nameLabel)
        Me.Controls.Add(Me.Doctor_s_nameTextBox)
        Me.Controls.Add(TimeLabel)
        Me.Controls.Add(Me.TimeDateTimePicker)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(ContactLabel)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Emergency_callLabel)
        Me.Controls.Add(Me.Emergency_callTextBox)
        Me.Controls.Add(Me.Edite_Dr_s_formBindingNavigator)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Doctor_edite"
        Me.Text = "Doctor_edite"
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edite_Dr_s_formBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edite_Dr_s_formBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Edite_Dr_s_formBindingNavigator.ResumeLayout(False)
        Me.Edite_Dr_s_formBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SystemDataSet As WindowsApplication1.systemDataSet
    Friend WithEvents Edite_Dr_s_formBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Edite_Dr_s_formTableAdapter As WindowsApplication1.systemDataSetTableAdapters.Edite_Dr_s_formTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Edite_Dr_s_formBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Edite_Dr_s_formBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_s_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emergency_callTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
