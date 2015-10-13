Public Class Form1

	'Create private constant variables that cannot be manipulated
	Private ReadOnly Rate_Pension As Double = 0.05
	Private ReadOnly Rate_401k As Double = 0.1
	Private ReadOnly Rate_TravelBonus As Double = 0.15

	Private Sub btnCalculate_Click() Handles btnCalculate.Click
		'Create payRate, hrsWorked & deductions and declare them as double
		Dim payRate As Double
		Dim hrsWorked As Double
		Dim deductions As Double = 0

		'payRate and hrsWorked will get their values based on the corresponding text boxes from client
		payRate = CDbl(txtHrPR.Text)
		hrsWorked = CDbl(txtHrWrkd.Text)

		'Calculate the value of grossPay
		Dim grossPay As Double = hrsWorked * payRate

		' Start of Retirement Plan section 
		If radPension.Checked Then
			deductions = (Rate_Pension * grossPay)
			lblStatus.Text = "You chose the Pension retirement plan."

		ElseIf rad401K.Checked Then
			deductions = (Rate_401k * grossPay)
			lblStatus.Text = "You chose the 401k retirement plan."

		Else
			lblStatus.Text = "Please choose a retirement plan."
			Return
		End If

		'Calculate the Net Pay
		Dim netPay As Double = grossPay - deductions

		' Display Gross Pay, Deductions and Net Pay
		lblGrossPay.Text = grossPay.ToString("n") ' ("n") used for 2 decimal places and no $
		lblDeductions.Text = deductions.ToString("n")
		lblNetPay.Text = netPay.ToString("c") ' ("c") argument used for currency format

		'Travel Bonus section
		If chkTravelBonus.Checked Then

			Dim travelBonus As Double = Rate_TravelBonus * grossPay
			lblStatus.Text = "Travel Bonus: " & travelBonus.ToString("c")
		End If

	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		'Close the current window when the button is clicked
		Me.Close()

	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

		txtHrPR.Clear()
		txtHrWrkd.Clear()

		radPension.Checked = False
		rad401K.Checked = False
		chkTravelBonus.Checked = False

		lblGrossPay.Text = String.Empty
		lblDeductions.Text = String.Empty
		lblNetPay.Text = String.Empty
		lblStatus.Text = String.Empty

	End Sub
End Class
