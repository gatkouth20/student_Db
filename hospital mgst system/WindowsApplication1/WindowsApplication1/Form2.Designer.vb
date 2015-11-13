<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim P_IDLabel As System.Windows.Forms.Label
        Dim P_nameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Me.Hospital_systemDataSet = New WindowsApplication1.hospital_systemDataSet()
        Me.Patient_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_listTableAdapter = New WindowsApplication1.hospital_systemDataSetTableAdapters.Patient_listTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.hospital_systemDataSetTableAdapters.TableAdapterManager()
        Me.Patient_listBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Patient_listBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.P_IDTextBox = New System.Windows.Forms.TextBox()
        Me.P_nameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        P_IDLabel = New System.Windows.Forms.Label()
        P_nameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_listBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Patient_listBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Hospital_systemDataSet
        '
        Me.Hospital_systemDataSet.DataSetName = "hospital_systemDataSet"
        Me.Hospital_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Patient_listBindingSource
        '
        Me.Patient_listBindingSource.DataMember = "Patient list"
        Me.Patient_listBindingSource.DataSource = Me.Hospital_systemDataSet
        '
        'Patient_listTableAdapter
        '
        Me.Patient_listTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Doctor_listTableAdapter = Nothing
        Me.TableAdapterManager.Patient_listTableAdapter = Me.Patient_listTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.hospital_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Patient_listBindingNavigator
        '
        Me.Patient_listBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Patient_listBindingNavigator.BindingSource = Me.Patient_listBindingSource
        Me.Patient_listBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Patient_listBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Patient_listBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Patient_listBindingNavigatorSaveItem})
        Me.Patient_listBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Patient_listBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Patient_listBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Patient_listBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Patient_listBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Patient_listBindingNavigator.Name = "Patient_listBindingNavigator"
        Me.Patient_listBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Patient_listBindingNavigator.Size = New System.Drawing.Size(522, 25)
        Me.Patient_listBindingNavigator.TabIndex = 0
        Me.Patient_listBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
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
        'Patient_listBindingNavigatorSaveItem
        '
        Me.Patient_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Patient_listBindingNavigatorSaveItem.Image = CType(resources.GetObject("Patient_listBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Patient_listBindingNavigatorSaveItem.Name = "Patient_listBindingNavigatorSaveItem"
        Me.Patient_listBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Patient_listBindingNavigatorSaveItem.Text = "Save Data"
        '
        'P_IDLabel
        '
        P_IDLabel.AutoSize = True
        P_IDLabel.Location = New System.Drawing.Point(166, 111)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(31, 13)
        P_IDLabel.TabIndex = 1
        P_IDLabel.Text = "P ID:"
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_listBindingSource, "P_ID", True))
        Me.P_IDTextBox.Location = New System.Drawing.Point(219, 108)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(80, 20)
        Me.P_IDTextBox.TabIndex = 2
        '
        'P_nameLabel
        '
        P_nameLabel.AutoSize = True
        P_nameLabel.Location = New System.Drawing.Point(166, 137)
        P_nameLabel.Name = "P_nameLabel"
        P_nameLabel.Size = New System.Drawing.Size(46, 13)
        P_nameLabel.TabIndex = 3
        P_nameLabel.Text = "P name:"
        '
        'P_nameTextBox
        '
        Me.P_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_listBindingSource, "P_name", True))
        Me.P_nameTextBox.Location = New System.Drawing.Point(219, 134)
        Me.P_nameTextBox.Name = "P_nameTextBox"
        Me.P_nameTextBox.Size = New System.Drawing.Size(146, 20)
        Me.P_nameTextBox.TabIndex = 4
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(166, 163)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 5
        GenderLabel.Text = "Gender:"
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_listBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(219, 160)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(146, 20)
        Me.GenderTextBox.TabIndex = 6
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(166, 189)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(47, 13)
        AddressLabel.TabIndex = 7
        AddressLabel.Text = "address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_listBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(219, 186)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(146, 20)
        Me.AddressTextBox.TabIndex = 8
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(160, 226)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 9
        Me.Submit.Text = "main page"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 261)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(P_IDLabel)
        Me.Controls.Add(Me.P_IDTextBox)
        Me.Controls.Add(P_nameLabel)
        Me.Controls.Add(Me.P_nameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Patient_listBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Patient's list"
        CType(Me.Hospital_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_listBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Patient_listBindingNavigator.ResumeLayout(False)
        Me.Patient_listBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hospital_systemDataSet As WindowsApplication1.hospital_systemDataSet
    Friend WithEvents Patient_listBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Patient_listTableAdapter As WindowsApplication1.hospital_systemDataSetTableAdapters.Patient_listTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.hospital_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Patient_listBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Patient_listBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents P_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Submit As System.Windows.Forms.Button
End Class
