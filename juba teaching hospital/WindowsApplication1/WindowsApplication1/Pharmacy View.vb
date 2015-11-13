Public Class Pharmacy_View

    Private Sub Pharmacy_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.Pharmacy_Bill' table. You can move, or remove it, as needed.
        Me.Pharmacy_BillTableAdapter1.Fill(Me.Hospital_management_systemDataSet.Pharmacy_Bill)
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet17.Pharmacy_Bill' table. You can move, or remove it, as needed.
        Me.Pharmacy_BillTableAdapter.Fill(Me.Hospital_management_systemDataSet17.Pharmacy_Bill)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Pharmacy_Bill.Show()
        Me.Hide()


    End Sub
End Class