Public Class FormWard
    Private sidebar As Sidebar
    Private Sub FormWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sidebar = New Sidebar(Me, lbldashboard, lblstaff, lblpatient, lblward, lblsupplier, lblappoint, lbllogout, lblhelp)
    End Sub
    Private Sub FormWard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        sidebar.HighlightLabelByFormName("FormWard")
    End Sub
End Class