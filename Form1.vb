Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables for course grades and credits
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '

        ' Parse input from textboxes and assign to variables

        Double.TryParse(txtGradeEnglish.Text, gradeEnglish)
        Double.TryParse(txtCreditsEnglish.Text, creditsEnglish)
        Double.TryParse(txtGradeMath.Text, gradeMath)
        Double.TryParse(txtCreditsMath.Text, creditsMath)
        Double.TryParse(txtGradeHistory.Text, gradeHistory)
        Double.TryParse(txtCreditsHistory.Text, creditsHistory)

        ' Calculate total grade points and total credits
        ' Grade Calculation (gradeEnglish * creditsEnglish) + (gradeMath * creditsMath) + (gradeHistory * creditsHistory)
        ' Credits Calculation creditsEnglish + creditsMath + creditsHistory



        ' Calculate GPA with appropriate precision
        ' GPA Calculation totalGradePoints / totalCredits

        'Display the calculated GPA

    End Sub

End Class
