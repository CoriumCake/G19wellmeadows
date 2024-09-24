Public Class FormPatient
    Private sidebar As Sidebar
    Private Sub FormPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sidebar = New Sidebar(Me, lbldashboard, lblstaff, lblpatient, lblward, lblsupplier, lblappoint, lbllogout, lblhelp)
    End Sub
    Private Sub FormPatient_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        sidebar.HighlightLabelByFormName("FormPatient")
    End Sub

End Class