<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicine_view
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
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.Medicine_UpdateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medicine_UpdateTableAdapter = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Medicine_UpdateTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.MidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiredDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medicine_UpdateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MidDataGridViewTextBoxColumn, Me.MedicineNameDataGridViewTextBoxColumn, Me.MedtypeDataGridViewTextBoxColumn, Me.AmountunitDataGridViewTextBoxColumn, Me.ExpiredDateDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Medicine_UpdateBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(647, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Hospital_management_systemDataSet
        '
        Me.Hospital_management_systemDataSet.DataSetName = "Hospital_management_systemDataSet"
        Me.Hospital_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Medicine_UpdateBindingSource
        '
        Me.Medicine_UpdateBindingSource.DataMember = "Medicine Update"
        Me.Medicine_UpdateBindingSource.DataSource = Me.Hospital_management_systemDataSet
        '
        'Medicine_UpdateTableAdapter
        '
        Me.Medicine_UpdateTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Medicine_UpdateTableAdapter = Me.Medicine_UpdateTableAdapter
        Me.TableAdapterManager.OP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Pharmacy_BillTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Room_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MidDataGridViewTextBoxColumn
        '
        Me.MidDataGridViewTextBoxColumn.DataPropertyName = "M_id"
        Me.MidDataGridViewTextBoxColumn.HeaderText = "M_id"
        Me.MidDataGridViewTextBoxColumn.Name = "MidDataGridViewTextBoxColumn"
        '
        'MedicineNameDataGridViewTextBoxColumn
        '
        Me.MedicineNameDataGridViewTextBoxColumn.DataPropertyName = "Medicine name"
        Me.MedicineNameDataGridViewTextBoxColumn.HeaderText = "Medicine name"
        Me.MedicineNameDataGridViewTextBoxColumn.Name = "MedicineNameDataGridViewTextBoxColumn"
        '
        'MedtypeDataGridViewTextBoxColumn
        '
        Me.MedtypeDataGridViewTextBoxColumn.DataPropertyName = "Med_type"
        Me.MedtypeDataGridViewTextBoxColumn.HeaderText = "Med_type"
        Me.MedtypeDataGridViewTextBoxColumn.Name = "MedtypeDataGridViewTextBoxColumn"
        '
        'AmountunitDataGridViewTextBoxColumn
        '
        Me.AmountunitDataGridViewTextBoxColumn.DataPropertyName = "Amount/unit"
        Me.AmountunitDataGridViewTextBoxColumn.HeaderText = "Amount/unit"
        Me.AmountunitDataGridViewTextBoxColumn.Name = "AmountunitDataGridViewTextBoxColumn"
        '
        'ExpiredDateDataGridViewTextBoxColumn
        '
        Me.ExpiredDateDataGridViewTextBoxColumn.DataPropertyName = "Expired date"
        Me.ExpiredDateDataGridViewTextBoxColumn.HeaderText = "Expired date"
        Me.ExpiredDateDataGridViewTextBoxColumn.Name = "ExpiredDateDataGridViewTextBoxColumn"
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Medicine_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Medicine_view"
        Me.Text = "Medicine_view"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medicine_UpdateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Hospital_management_systemDataSet As WindowsApplication1.Hospital_management_systemDataSet
    Friend WithEvents Medicine_UpdateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Medicine_UpdateTableAdapter As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Medicine_UpdateTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicineNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountunitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpiredDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
