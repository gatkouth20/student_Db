Public Class OP_View

    Private Sub OP_BillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OP_BillBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OP_BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_management_systemDataSet)

    End Sub

    Private Sub OP_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.OP_Bill' table. You can move, or remove it, as needed.
        Me.OP_BillTableAdapter.Fill(Me.Hospital_management_systemDataSet.OP_Bill)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OP_Bill.Show()
        Me.Hide()


    End Sub
End Class