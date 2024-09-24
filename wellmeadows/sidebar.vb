Public Class Sidebar
    ' The form that contains the sidebar (e.g., MainForm)
    Private mainForm As Form

    ' List of labels for sidebar items
    Private labels As List(Of Label)

    ' Track the currently active label
    Private activeLabel As Label = Nothing

    ' Constructor to initialize the sidebar with labels and the main form
    Public Sub New(mainForm As Form, ParamArray labels() As Label)
        Me.mainForm = mainForm
        Me.labels = labels.ToList()

        ' Set up the sidebar functionality
        SetupSidebar()
    End Sub

    ' Method to set up the sidebar functionality
    Private Sub SetupSidebar()
        ' Set up click events and hover effects for each label
        For Each lbl As Label In labels
            AddHandler lbl.Click, AddressOf lblSidebar_Click
            AddHandler lbl.MouseEnter, AddressOf lblSidebar_MouseEnter
            AddHandler lbl.MouseLeave, AddressOf lblSidebar_MouseLeave
        Next
    End Sub

    ' Event handler for label clicks (handles all labels)
    Private Sub lblSidebar_Click(sender As Object, e As EventArgs)
        Dim clickedLabel As Label = CType(sender, Label)

        ' Perform navigation based on clicked label
        Select Case clickedLabel.Name
            Case "lbldashboard"
                NavigateToDashboard()
            Case "lblstaff"
                NavigateToStaff()
            Case "lblpatient"
                NavigateToPatient()
            Case "lblward"
                NavigateToWard()
            Case "lblsupplier"
                NavigateToSupplier()
            Case "lblappoint"
                NavigateToAppointment()
            Case "lblhelp"
                ShowHelp()
            Case "lbllogout"
                LogoutToLogin() ' Handle the logout event
        End Select

        ' Highlight the clicked label (keep it highlighted)
        HighlightLabel(clickedLabel)
    End Sub

    ' Navigation functions for each page
    Private Sub NavigateToDashboard()
        Dim dashboardForm As New Dashboard()
        ShowNewForm(dashboardForm)
    End Sub

    Private Sub NavigateToStaff()
        Dim staffForm As New FormStaff()
        ShowNewForm(staffForm)
    End Sub

    Private Sub NavigateToPatient()
        Dim patientForm As New FormPatient()
        ShowNewForm(patientForm)
    End Sub

    Private Sub NavigateToWard()
        Dim wardForm As New FormWard()
        ShowNewForm(wardForm)
    End Sub

    Private Sub NavigateToSupplier()
        Dim supplierForm As New Formsupplier()
        ShowNewForm(supplierForm)
    End Sub

    Private Sub NavigateToAppointment()
        Dim appointmentForm As New FormAppointment()
        ShowNewForm(appointmentForm)
    End Sub

    Private Sub ShowHelp()
        ' Display a message box with contact information
        MessageBox.Show("For assistance, contact: G19@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Method to handle logout and navigate to the login form
    Private Sub LogoutToLogin()
        Dim loginForm As New Form1() ' Assuming you have a LoginForm or LoginPage
        loginForm.StartPosition = FormStartPosition.CenterScreen
        loginForm.Show()
        mainForm.Close() ' Close the current form and return to login page
    End Sub

    ' Method to handle form transition (show the new form and hide the current one)
    ' Variable to store the last known location of the form
    Private lastFormLocation As Point = New Point(100, 100) ' Default position if no movement

    Private Sub ShowNewForm(newForm As Form)
        ' Store the current form's location
        lastFormLocation = mainForm.Location

        ' Hide the current form (mainForm)
        mainForm.Hide()

        ' Set the new form's location to the stored location (lastFormLocation)
        newForm.StartPosition = FormStartPosition.Manual ' Use manual positioning
        newForm.Location = lastFormLocation ' Apply the last known location to the new form

        ' Show the new form
        newForm.Show()
    End Sub


    ' Method to highlight the clicked label (active state)
    Private Sub HighlightLabel(clickedLabel As Label)
        ' Reset all labels to default colors except for the clicked (active) label
        ResetLabels()

        ' Set the new active label
        activeLabel = clickedLabel

        ' Highlight the clicked label (set it to the active state)
        clickedLabel.BackColor = Color.Black
        clickedLabel.ForeColor = Color.Orange ' Gold/Orange text color for active
    End Sub

    ' Method to reset all label colors
    Private Sub ResetLabels()
        For Each lbl As Label In labels
            If lbl IsNot activeLabel Then ' Keep the active label highlighted
                lbl.BackColor = Color.Black
                lbl.ForeColor = Color.White ' White text for non-active labels
            End If
        Next
    End Sub

    ' Method to highlight a label based on the form name
    Public Sub HighlightLabelByFormName(formName As String)
        ' Map form names to labels and highlight the correct label
        Select Case formName
            Case "Dashboard"
                HighlightLabel(labels.Find(Function(lbl) lbl.Name = "lbldashboard"))
            Case "FormStaff"
                HighlightLabel(labels.Find(Function(lbl) lbl.Name = "lblstaff"))
            Case "FormPatient"
                HighlightLabel(labels.Find(Function(lbl) lbl.Name = "lblpatient"))
            Case "FormWard"
                HighlightLabel(labels.Find(Function(lbl) lbl.Name = "lblward"))
            Case "FormSupplier"
                HighlightLabel(labels.Find(Function(lbl) lbl.Name = "lblsupplier"))
            Case "FormAppointment"
                HighlightLabel(labels.Find(Function(lbl) lbl.Name = "lblappoint"))
                ' Add more cases if needed
        End Select
    End Sub

    ' Event handler for label hover effects (MouseEnter)
    Private Sub lblSidebar_MouseEnter(sender As Object, e As EventArgs)
        Dim hoveredLabel As Label = CType(sender, Label)
        ' Only change the color to orange if it's not the active label
        If hoveredLabel IsNot activeLabel Then
            hoveredLabel.ForeColor = Color.Orange
        End If
    End Sub

    ' Event handler for label hover effects (MouseLeave)
    Private Sub lblSidebar_MouseLeave(sender As Object, e As EventArgs)
        Dim hoveredLabel As Label = CType(sender, Label)
        ' Only reset to white if it's not the active label
        If hoveredLabel IsNot activeLabel Then
            hoveredLabel.ForeColor = Color.White
        End If
    End Sub
End Class
