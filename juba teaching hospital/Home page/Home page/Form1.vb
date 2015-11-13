Public Class Form1

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub OpenAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub OpenAnAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Open_account_form.Show()
        Me.Hide()


    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Hall.Show()
        Me.Hide()


    End Sub

    Private Sub JointUsNowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DepositedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Deposit_form.Show()
        Me.Hide()


    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Customer_form.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CheckBook.Show()
        Me.Hide()


    End Sub

    Private Sub DepositToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositToolStripMenuItem.Click
        Deposit_form.Show()
        Me.Hide()


    End Sub
End Class
