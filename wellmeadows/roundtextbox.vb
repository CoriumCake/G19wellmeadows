Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedTextBox
    Inherits TextBox

    ' Property to adjust corner radius
    Private _cornerRadius As Integer = 15
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Me.Invalidate() ' Redraw the control when the value changes
        End Set
    End Property

    ' Constructor to disable TextBox border
    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.UserPaint, True) ' We will handle the painting
    End Sub

    ' Create a method to draw a rounded rectangle
    Private Function GetRoundedRectanglePath(bounds As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        ' Limit the diameter to avoid overstretching
        Dim diameter As Integer = Math.Min(bounds.Height, radius * 2)

        ' Add arcs and lines to create the rounded rectangle
        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90)
        path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90)
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        Return path
    End Function

    ' Override the OnPaint method to create the custom drawing
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Set up the graphics object for anti-aliasing
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Define the bounds for the rounded rectangle
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        ' Create a path for the rounded rectangle
        Dim path As GraphicsPath = GetRoundedRectanglePath(rect, _cornerRadius)

        ' Fill the background
        Using brush As New SolidBrush(Me.BackColor)
            e.Graphics.FillPath(brush, path)
        End Using

        ' Draw the border
        Using pen As New Pen(Color.Gray, 2) ' Adjust pen width as needed
            e.Graphics.DrawPath(pen, path)
        End Using

        ' Draw the text inside the TextBox manually
        Using format As New StringFormat()
            format.LineAlignment = StringAlignment.Center
            format.Alignment = StringAlignment.Near
            Dim textRect As New Rectangle(5, 0, Me.Width - 10, Me.Height) ' Adjust the text padding here
            e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), textRect, format)
        End Using
    End Sub

    ' Override the OnResize event to force the control to be redrawn when resized
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate() ' Force redrawing on resizing
    End Sub
End Class
