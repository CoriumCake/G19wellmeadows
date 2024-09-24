Public Class FormAppointment
    Private sidebar As Sidebar

    Private Sub FormAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sidebar = New Sidebar(Me, lbldashboard, lblstaff, lblpatient, lblward, lblsupplier, lblappoint, lbllogout, lblhelp)
    End Sub
    Private Sub FormAppointment_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        sidebar.HighlightLabelByFormName("FormAppointment")
    End Sub
End Class