<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pharmacy_View
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
        Me.PharmacyBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital_management_systemDataSet17 = New WindowsApplication1.Hospital_management_systemDataSet17()
        Me.Pharmacy_BillTableAdapter = New WindowsApplication1.Hospital_management_systemDataSet17TableAdapters.Pharmacy_BillTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Hospital_management_systemDataSet = New WindowsApplication1.Hospital_management_systemDataSet()
        Me.Pharmacy_BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pharmacy_BillTableAdapter1 = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Pharmacy_BillTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Pharmacy_BillDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PharmacyBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital_management_systemDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pharmacy_BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pharmacy_BillDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PharmacyBillBindingSource
        '
        Me.PharmacyBillBindingSource.DataMember = "Pharmacy Bill"
        Me.PharmacyBillBindingSource.DataSource = Me.Hospital_management_systemDataSet17
        '
        'Hospital_management_systemDataSet17
        '
        Me.Hospital_management_systemDataSet17.DataSetName = "Hospital_management_systemDataSet17"
        Me.Hospital_management_systemDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pharmacy_BillTableAdapter
        '
        Me.Pharmacy_BillTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back to main"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Hospital_management_systemDataSet
        '
        Me.Hospital_management_systemDataSet.DataSetName = "Hospital_management_systemDataSet"
        Me.Hospital_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pharmacy_BillBindingSource
        '
        Me.Pharmacy_BillBindingSource.DataMember = "Pharmacy Bill"
        Me.Pharmacy_BillBindingSource.DataSource = Me.Hospital_management_systemDataSet
        '
        'Pharmacy_BillTableAdapter1
        '
        Me.Pharmacy_BillTableAdapter1.ClearBeforeFill = True
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
        Me.TableAdapterManager.OP_BillTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Pharmacy_BillTableAdapter = Me.Pharmacy_BillTableAdapter1
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.Room_allocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Pharmacy_BillDataGridView
        '
        Me.Pharmacy_BillDataGridView.AutoGenerateColumns = False
        Me.Pharmacy_BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Pharmacy_BillDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Pharmacy_BillDataGridView.DataSource = Me.Pharmacy_BillBindingSource
        Me.Pharmacy_BillDataGridView.Location = New System.Drawing.Point(12, -2)
        Me.Pharmacy_BillDataGridView.Name = "Pharmacy_BillDataGridView"
        Me.Pharmacy_BillDataGridView.Size = New System.Drawing.Size(747, 220)
        Me.Pharmacy_BillDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "P_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "P_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BillNO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BillNO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Medicine"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Medicine"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Pharmacy_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 332)
        Me.Controls.Add(Me.Pharmacy_BillDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Pharmacy_View"
        Me.Text = "Pharmacy_View"
        CType(Me.PharmacyBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital_management_systemDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pharmacy_BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pharmacy_BillDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Hospital_management_systemDataSet17 As WindowsApplication1.Hospital_management_systemDataSet17
    Friend WithEvents PharmacyBillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pharmacy_BillTableAdapter As WindowsApplication1.Hospital_management_systemDataSet17TableAdapters.Pharmacy_BillTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Hospital_management_systemDataSet As WindowsApplication1.Hospital_management_systemDataSet
    Friend WithEvents Pharmacy_BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pharmacy_BillTableAdapter1 As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.Pharmacy_BillTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hospital_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Pharmacy_BillDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
