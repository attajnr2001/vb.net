Public Class formParent
    Private Sub formParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim addNewForm As New sell()
        addNewForm.MdiParent = Me
        For Each childForm As Form In Me.MdiChildren
            childForm.Hide()
        Next
        addNewForm.Show()
    End Sub

    Private Sub formParent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Public Sub SetAdminPermissions(isAdmin As Boolean)
        ADDNEWToolStripMenuItem.Enabled = isAdmin
        STOCKToolStripMenuItem.Enabled = isAdmin
        COMPANYToolStripMenuItem.Enabled = isAdmin
        STAFFToolStripMenuItem.Enabled = isAdmin
    End Sub

    Private Sub ADDNEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWToolStripMenuItem.Click
        Dim addNewForm As New addnew()
        addNewForm.MdiParent = Me
        For Each childForm As Form In Me.MdiChildren
            childForm.Hide()
        Next
        addNewForm.Show()
    End Sub

    Private Sub SELLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELLToolStripMenuItem.Click
        Dim addNewForm As New sell()
        addNewForm.MdiParent = Me
        For Each childForm As Form In Me.MdiChildren
            childForm.Hide()
        Next
        addNewForm.Show()
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        Dim addNewForm As New update()
        addNewForm.MdiParent = Me
        For Each childForm As Form In Me.MdiChildren
            childForm.Hide()
        Next
        addNewForm.Show()
    End Sub

    Private Sub VIEWSOLDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWSOLDToolStripMenuItem.Click
        Dim addNewForm As New viewsold()
        addNewForm.MdiParent = Me
        For Each childForm As Form In Me.MdiChildren
            childForm.Hide()
        Next
        addNewForm.Show()
    End Sub

    Private Sub VIEWSTOCKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWSTOCKToolStripMenuItem.Click
        Dim addNewForm As New viewstock()
        addNewForm.MdiParent = Me
        For Each childForm As Form In Me.MdiChildren
            childForm.Hide()
        Next
        addNewForm.Show()
    End Sub

    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        Dim addNewForm As New addcompany()
        addNewForm.MdiParent = Me
        For Each childForm As Form In Me.MdiChildren
            childForm.Hide()
        Next
        addNewForm.Show()
    End Sub

    Private Sub ADDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem1.Click
        Dim addNewForm As New addcompany()
        addNewForm.MdiParent = Me
        For Each childForm As Form In Me.MdiChildren
            childForm.Hide()
        Next
        addNewForm.Show()
    End Sub

    Private Sub EDITtttttttttttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITtttttttttttToolStripMenuItem.Click
        Dim addNewForm As New editStaff()
        addNewForm.MdiParent = Me
        For Each childForm As Form In Me.MdiChildren
            childForm.Hide()
        Next
        addNewForm.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
End Class
