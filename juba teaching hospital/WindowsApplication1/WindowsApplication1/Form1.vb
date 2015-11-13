Public Class Form1

    Private Sub Add_new_departmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_new_departmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Add_new_departmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_management_systemDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.Add_new_department' table. You can move, or remove it, as needed.
        Me.Add_new_departmentTableAdapter.Fill(Me.Hospital_management_systemDataSet.Add_new_department)

    End Sub
End Class
