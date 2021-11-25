Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.DisplayMember = "Text"
        ComboBox1.ValueMember = "Value"
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))
        tb.Rows.Add("kg", 101)
        tb.Rows.Add("lbs", 109)
        tb.Rows.Add("ounces", 106)
        ComboBox1.DataSource = tb

        ComboBox2.DisplayMember = "Text"
        ComboBox2.ValueMember = "Value"
        Dim tb1 As New DataTable
        tb1.Columns.Add("Text", GetType(String))
        tb1.Columns.Add("Value", GetType(Integer))
        tb1.Rows.Add("kg", 101)
        tb1.Rows.Add("lbs", 109)
        tb1.Rows.Add("grams", 106)
        ComboBox2.DataSource = tb1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'CONVERSIONS FROM KG

        If ComboBox1.Text = "kg" And ComboBox2.Text = "kg" Then
            TextBox2.Text = TextBox1.Text
        End If

        If ComboBox1.Text = "kg" And ComboBox2.Text = "lbs" Then
            TextBox2.Text = TextBox1.Text * 2.20462
        End If

        If ComboBox1.Text = "kg" And ComboBox2.Text = "grams" Then
            TextBox2.Text = TextBox1.Text * 1000
        End If

        'CONVERSIONS FROM LBS

        If ComboBox1.Text = "lbs" And ComboBox2.Text = "lbs" Then
            TextBox2.Text = TextBox1.Text
        End If

        If ComboBox1.Text = "lbs" And ComboBox2.Text = "kg" Then
            TextBox2.Text = TextBox1.Text * 0.4536
        End If

        If ComboBox1.Text = "lbs" And ComboBox2.Text = "grams" Then
            TextBox2.Text = TextBox1.Text * 453.592
        End If

        'CONVERSIONS FROM OUNCES

        If ComboBox1.Text = "ounces" And ComboBox2.Text = "kg" Then
            TextBox2.Text = TextBox1.Text * 0.0283495
        End If

        If ComboBox1.Text = "ounces" And ComboBox2.Text = "lbs" Then
            TextBox2.Text = TextBox1.Text * 0.0625
        End If

        If ComboBox1.Text = "ounces" And ComboBox2.Text = "grams" Then
            TextBox2.Text = TextBox1.Text * 28.3495
        End If

    End Sub
End Class
