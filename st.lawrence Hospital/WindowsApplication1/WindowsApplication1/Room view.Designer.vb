<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room_view
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SystemDataSet = New WindowsApplication1.systemDataSet()
        Me.Rooms_allocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rooms_allocationTableAdapter = New WindowsApplication1.systemDataSetTableAdapters.Rooms_allocationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager()
        Me.RidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rooms_allocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RidDataGridViewTextBoxColumn, Me.RoomNoDataGridViewTextBoxColumn, Me.RoomTypeDataGridViewTextBoxColumn, Me.AmountdayDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Rooms_allocationBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(453, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'SystemDataSet
        '
        Me.SystemDataSet.DataSetName = "systemDataSet"
        Me.SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rooms_allocationBindingSource
        '
        Me.Rooms_allocationBindingSource.DataMember = "Rooms allocation"
        Me.Rooms_allocationBindingSource.DataSource = Me.SystemDataSet
        '
        'Rooms_allocationTableAdapter
        '
        Me.Rooms_allocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Doctor_s_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Edite__PatientTableAdapter = Nothing
        Me.TableAdapterManager.Edite_Dr_s_formTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Rooms_allocationTableAdapter = Me.Rooms_allocationTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RidDataGridViewTextBoxColumn
        '
        Me.RidDataGridViewTextBoxColumn.DataPropertyName = "R_id"
        Me.RidDataGridViewTextBoxColumn.HeaderText = "R_id"
        Me.RidDataGridViewTextBoxColumn.Name = "RidDataGridViewTextBoxColumn"
        '
        'RoomNoDataGridViewTextBoxColumn
        '
        Me.RoomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo"
        Me.RoomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo"
        Me.RoomNoDataGridViewTextBoxColumn.Name = "RoomNoDataGridViewTextBoxColumn"
        '
        'RoomTypeDataGridViewTextBoxColumn
        '
        Me.RoomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room type"
        Me.RoomTypeDataGridViewTextBoxColumn.HeaderText = "Room type"
        Me.RoomTypeDataGridViewTextBoxColumn.Name = "RoomTypeDataGridViewTextBoxColumn"
        '
        'AmountdayDataGridViewTextBoxColumn
        '
        Me.AmountdayDataGridViewTextBoxColumn.DataPropertyName = "Amount/day"
        Me.AmountdayDataGridViewTextBoxColumn.HeaderText = "Amount/day"
        Me.AmountdayDataGridViewTextBoxColumn.Name = "AmountdayDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View rooms"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Room_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Room_view"
        Me.Text = "Room_view"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rooms_allocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SystemDataSet As WindowsApplication1.systemDataSet
    Friend WithEvents Rooms_allocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rooms_allocationTableAdapter As WindowsApplication1.systemDataSetTableAdapters.Rooms_allocationTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountdayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
