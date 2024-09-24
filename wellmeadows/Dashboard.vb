Public Class Dashboard


    Private sidebar As sidebar

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sidebar = New Sidebar(Me, lbldashboard, lblstaff, lblpatient, lblward, lblsupplier, lblappoint, lbllogout, lblhelp)
    End Sub
    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Assuming you have a reference to the Sidebar instance
        sidebar.HighlightLabelByFormName("Dashboard")
    End Sub

End Class