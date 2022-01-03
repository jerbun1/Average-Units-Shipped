Option Strict On
'Name: Jermaine Henry
'Date: June 21, 2019
'Program: This program will take the user input units for 7 days and display the average for 3 employees
'then display the total average for the 3 employees.

Public Class Form1
    Dim currentEmployee As Integer = 1
    Dim employeeUnits As Integer = 1
    Dim currentUnits(2, 6) As Integer
    Private Const minUnits As Integer = 0
    Private Const maxUnits As Integer = 1000
    Private Const maxEmployees As Integer = 3
    Private maxDays As Integer = 7
    Private Const maxEmployeeUnits As Integer = 7
    Private currentDay As Integer = 1


    Dim boldFont As New Font("Sans Serif", 9, FontStyle.Bold)
    Dim regularFont As New Font("Sans Serif", 9, FontStyle.Regular)


    Private employeeAverageUnits1 As Double
    Private employeeAverageUnits2 As Double
    Private employeeAverageUnits3 As Double
    Private totalEmployeeAverage As Double


    Function validateInput(ByVal inputData As String) As Boolean
        Dim userInputValidate As Boolean = False
        Dim inputAsNumber As Integer

        If (Integer.TryParse(inputData, inputAsNumber)) Then
            If (inputAsNumber >= minUnits AndAlso inputAsNumber <= maxUnits) Then
                userInputValidate = True

            End If
            Return userInputValidate
        End If
    End Function




    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userInput As Double = CInt(txtInput.Text)

        If (validateInput(CType(userInput, String))) Then
            If CDbl(userInput.ToString) = userInput Then


                userInput = CInt(txtInput.Text)

                currentUnits(currentEmployee - 1, employeeUnits - 1) = CInt(userInput)


                If currentEmployee = 1 Then
                    lblEmployee1.Font = boldFont
                    txtEmployee1.Text += currentUnits(0, employeeUnits - 1).ToString + vbCrLf
                    txtInput.Text = ""
                    txtInput.Focus()
                ElseIf currentEmployee = 2 Then
                    lblEmployee1.Font = regularFont
                    lblEmployee2.Font = boldFont
                    txtEmployee2.Text += currentUnits(1, employeeUnits - 1).ToString + vbCrLf
                    txtInput.Text = ""
                    txtInput.Focus()
                Else
                    lblEmployee2.Font = regularFont
                    lblEmployee3.Font = boldFont
                    txtEmployee3.Text += currentUnits(2, employeeUnits - 1).ToString + vbCrLf
                    txtInput.Text = ""
                    txtInput.Focus()
                End If





                If employeeUnits = 7 Then
                    employeeUnits = 1
                    currentEmployee += 1
                Else
                    employeeUnits += 1
                End If

                If currentEmployee > 3 Then
                    btnEnter.Enabled = False
                    txtInput.Enabled = False

                Else
                    lblDay.Text = "Day: " + currentDay.ToString
                End If

                If currentDay = 7 Then
                    currentDay = 1
                    'MsgBox(currentEmployee.ToString + " " + employeeUnits.ToString)
                    If currentEmployee = 2 And employeeUnits = 1 Then

                        For averageCounter As Double = 0 To (maxEmployeeUnits - 1)
                            employeeAverageUnits1 += currentUnits(0, CInt(averageCounter))
                        Next
                        employeeAverageUnits1 = employeeAverageUnits1 / maxEmployeeUnits
                        lblAverageEmployee1.Text = "Average: " + Math.Round(employeeAverageUnits1, 2).ToString



                    ElseIf currentEmployee = 3 And employeeUnits = 1 Then
                        For averageCounter As Double = 0 To (maxEmployeeUnits - 1)
                            employeeAverageUnits2 += currentUnits(1, CInt(averageCounter))
                        Next
                        employeeAverageUnits2 = employeeAverageUnits2 / maxEmployeeUnits
                        lblAverageEmployee2.Text = "Average: " + Math.Round(employeeAverageUnits2, 2).ToString


                    ElseIf currentEmployee = 4 And employeeUnits = 1 Then
                        For averageCounter As Double = 0 To (maxEmployeeUnits - 1)
                            employeeAverageUnits3 += currentUnits(2, CInt(averageCounter))
                        Next
                        employeeAverageUnits3 = employeeAverageUnits3 / maxEmployeeUnits
                        lblAverageEmployee3.Text = "Average: " + Math.Round(employeeAverageUnits3, 2).ToString



                    End If

                    If currentEmployee = 4 And employeeUnits = 1 Then
                        lblEmployee3.Font = regularFont
                        totalEmployeeAverage = employeeAverageUnits1 + employeeAverageUnits2 + employeeAverageUnits3
                        totalEmployeeAverage = totalEmployeeAverage / 3
                        lblAveragePerDay.Text = "Average per day: " + Math.Round(totalEmployeeAverage, 2).ToString

                        lblDay.Text = "Done:"
                        txtInput.Text = ""
                        txtInput.Focus()
                        lblEmployee3.Font = regularFont
                        lblEmployee1.Font = boldFont

                    End If



                Else
                    currentDay += 1


                End If



            Else
                MessageBox.Show("Please enter a whole number")
                txtInput.Text = ""
                txtInput.Focus()


            End If
        Else


            MessageBox.Show("Please units must be between " + minUnits.ToString + " and " + maxUnits.ToString)
            txtInput.Text = ""
            txtInput.Focus()





        End If




    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtInput.Text = ""
        txtEmployee1.Text = ""
        txtEmployee2.Text = ""
        txtEmployee3.Text = ""
        lblAverageEmployee1.Text = ""
        lblAverageEmployee2.Text = ""
        lblAverageEmployee3.Text = ""
        lblAveragePerDay.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
