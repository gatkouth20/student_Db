Public Class Pharmacy_Bill

    Private Sub Pharmacy_BillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pharmacy_BillBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Pharmacy_BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_management_systemDataSet)

    End Sub

    Private Sub Pharmacy_Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.Pharmacy_Bill' table. You can move, or remove it, as needed.
        Me.Pharmacy_BillTableAdapter.Fill(Me.Hospital_management_systemDataSet.Pharmacy_Bill)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("one new Item is added")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Home__Page.Show()
        Me.Hide()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Pharmacy_View.Show()
        Me.Hide()


    End Sub
End Class