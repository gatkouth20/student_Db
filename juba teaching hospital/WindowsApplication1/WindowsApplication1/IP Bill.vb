Public Class IP_Bill

    Private Sub IP_BillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IP_BillBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IP_BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_management_systemDataSet)

    End Sub

    Private Sub IP_Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.IP_Bill' table. You can move, or remove it, as needed.
        Me.IP_BillTableAdapter.Fill(Me.Hospital_management_systemDataSet.IP_Bill)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("data has been added")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Home__Page.Show()
        Me.Hide()


    End Sub
End Class