Public Class FormStaff
    Private sidebar As Sidebar

    Private Sub FormStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sidebar = New Sidebar(Me, lbldashboard, lblstaff, lblpatient, lblward, lblsupplier, lblappoint, lbllogout, lblhelp)
    End Sub
    Private Sub FormStaff_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        sidebar.HighlightLabelByFormName("FormStaff")
    End Sub

End Class