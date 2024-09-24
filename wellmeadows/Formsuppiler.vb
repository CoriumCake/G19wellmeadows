Public Class Formsupplier
    Private sidebar As Sidebar

    Private Sub Formsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sidebar = New Sidebar(Me, lbldashboard, lblstaff, lblpatient, lblward, lblsupplier, lblappoint, lbllogout, lblhelp)
    End Sub
    Private Sub Formsupplier_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        sidebar.HighlightLabelByFormName("FormSupplier")
    End Sub
End Class