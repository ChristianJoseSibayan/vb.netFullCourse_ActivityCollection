Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstFormOccupation.Items.Add("Programmer")
        lstFormOccupation.Items.Add("Front-end Engineer")
        lstFormOccupation.Items.Add("Back-end Engineer")
        'lblExercise1.Text = "Output each item in a separate" & vbCrLf & "message box one after another."

    End Sub

    Private Sub button_Start_Click(sender As Object, e As EventArgs) Handles button_Start.Click

        MsgBox("You clicked the button once!")
        MsgBox("You clicked the button twice!")

    End Sub

    Private Sub button_Variables_Click(sender As Object, e As EventArgs) Handles button_Variables.Click
        MsgBox("Output and Variables")
        MessageBox.Show("v2 Output and Variables")

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Christian Jose"
        stLastName = "Sibayan"

        MessageBox.Show(stFirstName & " " & stLastName)

        stFirstName = "v2 Christian Jose"
        stLastName = "v2 Sibayan"

        MessageBox.Show(stFirstName & " " & stLastName)

    End Sub

    Private Sub btnVariableDataTypes_Click(sender As Object, e As EventArgs) Handles btnVariableDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColour = "Red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.999
        dtDateRegistered = #07/08/2023#

        MessageBox.Show("Car Information:" & vbNewLine & "Manufacturer - " & stMake & vbNewLine &
                        "Model - " & stModel & vbNewLine & "# of Doors - " & iDoors & vbNewLine & "Colour - " & stColour &
                        vbNewLine & "Taxed - " & bTaxed & vbNewLine & "Engine Size - " & iEngineSize & vbNewLine &
                        "Price - " & decPrice & vbNewLine & "Date Regestered - " & dtDateRegistered)

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim stFullName As String

        stFullName = InputBox("Enter Your Name: ")

        MessageBox.Show("Congratulations " & stFullName & ", You successfully entered your name!")

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim stFormFirstName As String
        Dim stFormLastName As String
        Dim stFormGender As String
        Dim stFormOccupation As String

        stFormFirstName = txtFirstName.Text
        stFormLastName = txtLastName.Text
        stFormGender = txtGender.Text
        stFormOccupation = lstFormOccupation.SelectedItem


        MessageBox.Show("You successfully submitted this following informations:" & vbNewLine &
                        "Firt Name: " & stFormFirstName & vbNewLine & "Last Name: " & stFormLastName &
                        vbNewLine & "Gender: " & stFormGender & vbNewLine & "Occupation: " & stFormOccupation)

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim iFirstNumber As Integer
        Dim iSecondNumber As Integer

        Dim iResult As Integer

        iFirstNumber = txtFirstNumber.Text
        iSecondNumber = txtSecondNumber.Text

        iResult = iFirstNumber + iSecondNumber

        MessageBox.Show("Sum: " & iResult)

    End Sub

    Private Sub btnCalculateSalaryOffer_Click(sender As Object, e As EventArgs) Handles btnCalculateSalaryOffer.Click
        Dim decSalaryOffer As Decimal
        Dim decSalaryOfferPerDay As Decimal

        decSalaryOffer = txtSalaryOffer.Text
        decSalaryOfferPerDay = decSalaryOffer / 26

        MsgBox("Your salary per day is ₱" & decSalaryOfferPerDay & ".")
    End Sub

    Private Sub btnIfGreetings_Click(sender As Object, e As EventArgs) Handles btnIfGreetings.Click
        Dim stIfCountry As String
        stIfCountry = txtIfCountry.Text

        MsgBox("You are from " & stIfCountry & "!")

        If stIfCountry.ToUpper = "PHILIPPINES" Then
            MsgBox("Magandang araw!")
        ElseIf stIfCountry.ToUpper = "SPAIN" Then
            MsgBox("Buen día!")
        Else
            MsgBox("Good day!")
        End If

    End Sub

    Private Sub btnClassifyScore_Click(sender As Object, e As EventArgs) Handles btnClassifyScore.Click
        Dim iScore As Integer

        If IsNumeric(txtFormScore.Text) = True Then
            iScore = CInt(txtFormScore.Text)
        Else
            MsgBox("You must enter a number.")
            Exit Sub
        End If

        If Not (iScore >= 0 And iScore <= 100) Then
            'If iScore < 0 Or iScore > 100 Then
            MsgBox("That is not a valid score. Enter a number between 0 and 100.")
        ElseIf iScore <= 20 Then
            MsgBox("Better luck next time!")
            MsgBox("You failed the exam with an F Grade.")
        ElseIf iScore > 20 And iScore <= 30 Then
            MsgBox("Better luck next time!")
            MsgBox("You failed the exam with an E Grade.")
            'MsgBox("Better luck next time!")
            'MsgBox("You failed the exam.")
        ElseIf iScore > 30 And iScore <= 40 Then
            MsgBox("Better luck next time!")
            MsgBox("You failed the exam with an D Grade.")
        ElseIf iScore > 40 And iScore <= 50 Then
            MsgBox("Better luck next time!")
            MsgBox("You failed the exam with an C Grade.")
        ElseIf iScore > 50 And iScore <= 70 Then
            MsgBox("Congratulations!")
            MsgBox("You passed the exam with an B Grade.")
        ElseIf iScore > 70 And iScore <= 100 Then
            MsgBox("Congratulations!")
            MsgBox("You passed the exam with an A Grade.")
        End If

    End Sub

    Private Sub btnCheckTemperature_Click(sender As Object, e As EventArgs) Handles btnCheckTemperature.Click
        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)

        Dim iWindSpeed As Integer
        iWindSpeed = 30

        Select Case iTemperature
            Case Is < 0
                MsgBox("Sub zero")
                If iWindSpeed > 20 Then
                    MsgBox("The wind speed is " & iWindSpeed & ", this would feel really cold!")
                End If
            Case Is = 0
                MsgBox("Freezing")
            Case 1 To 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        Dim iCounter As Integer
        Dim stOutput As String

        stOutput = ""

        'For iCounter = 0 To 100 Step 10
        For iCounter = 100 To 0 Step -10
            stOutput = $"{stOutput}{iCounter}{vbNewLine}"
            'MsgBox(iCounter)
            'Beep()
            'Threading.Thread.Sleep(3000)
        Next

        MsgBox(stOutput)
    End Sub

    Private Sub btnCountUp_Click(sender As Object, e As EventArgs) Handles btnCountUp.Click
        Dim iMax As Integer
        Dim stOddOrEven As String
        Dim iCounter As Integer

        iMax = InputBox("What number do you want to count up to?")
        stOddOrEven = InputBox("Do you want odd numbers or even numbers?")

        If stOddOrEven.ToUpper = "EVEN" Then
            For iCounter = 2 To iMax Step 2
                MsgBox(iCounter)
            Next
        ElseIf stOddOrEven.ToUpper = "ODD" Then
            For iCounter = 1 To iMax Step 2
                MsgBox(iCounter)
            Next
        End If
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        Dim iCounter As Integer

        iCounter = 0
        Do While iCounter < 5
            iCounter = iCounter + 1
            MsgBox("Loop " & iCounter)
        Loop

        iCounter = 0
        Do
            iCounter = iCounter + 1
            MsgBox("Loop " & iCounter)
        Loop While iCounter < 5

        iCounter = 0
        Do Until iCounter = 5
            iCounter = iCounter + 1
            MsgBox("Loop " & iCounter)
        Loop

        iCounter = 0
        Do
            iCounter = iCounter + 1
            MsgBox("Loop " & iCounter)
        Loop Until iCounter = 5

        MessageBox.Show("Condition has been fulfilled!")

    End Sub

    Private Sub btnConditionControlledLoops_Click(sender As Object, e As EventArgs) Handles btnConditionControlledLoops.Click
        Dim stConditionName As String

        stConditionName = ""

        Do While stConditionName.ToUpper <> "CHRISTIAN JOSE"
            stConditionName = InputBox("Please enter your first name: ")
            If stConditionName.ToUpper = "CHRISTIAN JOSE" Then
                Exit Do
            End If
        Loop

        MessageBox.Show(stConditionName & ", condition has been fulfilled!")

    End Sub

    Private Sub btnv2ConditionControlledLoops_Click(sender As Object, e As EventArgs) Handles btnv2ConditionControlledLoops.Click
        'This code will as for the user to input their age to calculate their birth year.
        Dim stAge As String
        Dim iAge As Integer
        Dim currentYear As Integer = DateTime.Now.Year

        Do While IsNumeric(stAge) = False
            stAge = InputBox("Enter your age.")
        Loop

        iAge = CInt(stAge)

        MsgBox("Birth Year: " & currentYear - iAge)

    End Sub

    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click
        Dim aiData(4) As String

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For iCounter = 0 To 4
            MessageBox.Show(aiData(iCounter))
        Next

    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click
        Dim aiData(4) As String
        Dim stArrayList As String

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For iCounter = 0 To 4
            stArrayList = $"{stArrayList}{aiData(iCounter)}{vbNewLine}"
        Next

        MsgBox(stArrayList)
    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click
        Dim aiData(4) As String
        Dim iSum As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For iCounter = 0 To 4
            iSum = iSum + aiData(iCounter)
        Next

        MsgBox(iSum)
    End Sub

    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click
        Dim stSearch As String
        Dim astFruit() As String = {"Apple", "Mango", "Strawberry", "Banana"}
        Dim bFound As Boolean

        stSearch = InputBox("Search for fruit inventory.")

        For iCounter = 0 To astFruit.Length
            If astFruit(iCounter).ToUpper = stSearch.ToUpper Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            MsgBox(StrConv(stSearch, VbStrConv.ProperCase) & " is in stock.")
        Else
            MsgBox(StrConv(stSearch, VbStrConv.ProperCase) & " is out of stock.")
        End If

    End Sub

    Private Sub btnRowWise_Click(sender As Object, e As EventArgs) Handles btnRowWise.Click
        Dim astData(,) As String
        Dim iRowCounter As Integer
        Dim iColumnCounter As Integer

        astData = {
            {"Barack", "Obama", "Male", "American", "President"},
            {"Jacinda", "Ardern", "Female", "New Zealand", "Prime Minister"},
            {"Christian Jose", "Sibayan", "Male", "Filipino", "Software Engineer"}
        }

        MsgBox("Row: " & astData.GetLength(0) - 1 & vbNewLine & "Column: " & astData.GetLength(1) - 1)

        For iRowCounter = 0 To astData.GetLength(0) - 1
            For iColumnCounter = 0 To astData.GetLength(1) - 1
                MsgBox(astData(iRowCounter, iColumnCounter))
            Next
            iColumnCounter = 0
        Next
    End Sub

    Private Sub btnColumnWise_Click(sender As Object, e As EventArgs) Handles btnColumnWise.Click
        Dim astData(,) As String
        Dim iRowCounter As Integer
        Dim iColumnCounter As Integer

        astData = {
            {"Barack", "Obama", "Male", "American", "President"},
            {"Jacinda", "Ardern", "Female", "New Zealand", "Prime Minister"},
            {"Christian Jose", "Sibayan", "Male", "Filipino", "Software Engineer"}
        }

        MsgBox("Row: " & astData.GetLength(0) - 1 & vbNewLine & "Column: " & astData.GetLength(1) - 1)

        For iColumnCounter = 0 To astData.GetLength(1) - 1
            For iRowCounter = 0 To astData.GetLength(0) - 1
                MsgBox(astData(iRowCounter, iColumnCounter))
            Next
            iRowCounter = 0
        Next
    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
        Dim astData(,) As String
        Dim iRowCounter As Integer
        Dim iColumnCounter As Integer
        Dim stDisplayAll As String

        astData = {
            {"Barack", "Obama", "Male", "American", "President"},
            {"Jacinda", "Ardern", "Female", "New Zealand", "Prime Minister"},
            {"Christian Jose", "Sibayan", "Male", "Filipino", "Software Engineer"}
        }

        MsgBox("Row: " & astData.GetLength(0) - 1 & vbNewLine & "Column: " & astData.GetLength(1) - 1)

        For iRowCounter = 0 To astData.GetLength(0) - 1
            stDisplayAll = $"{stDisplayAll}{vbNewLine}"
            For iColumnCounter = 0 To astData.GetLength(1) - 1
                If astData(iRowCounter, iColumnCounter) <> astData(iRowCounter, astData.GetLength(1) - 1) Then
                    stDisplayAll = stDisplayAll & astData(iRowCounter, iColumnCounter) & ", "
                Else
                    stDisplayAll = stDisplayAll & astData(iRowCounter, iColumnCounter)
                End If
            Next
            iColumnCounter = 0
        Next

        MsgBox(stDisplayAll)
    End Sub

    Private Sub btnSearchPerson_Click(sender As Object, e As EventArgs) Handles btnSearchPerson.Click
        Dim astData(,) As String
        Dim iRowCounter As Integer
        Dim iColumnCounter As Integer
        Dim stSearch As String
        Dim bFound As Boolean
        Dim stPersonInfo As String

        astData = {
            {"Barack", "Obama", "Male", "American", "President"},
            {"Jacinda", "Ardern", "Female", "New Zealand", "Prime Minister"},
            {"Christian Jose", "Sibayan", "Male", "Filipino", "Software Engineer"}
        }

        MsgBox("Row: " & astData.GetLength(0) - 1 & vbNewLine & "Column: " & astData.GetLength(1) - 1)

        stSearch = InputBox("Search for a person by surname:")
        If stSearch.Length = 0 Then
            stSearch = InputBox("Search for a person by surname:")
        Else
            For iRowCounter = 0 To astData.GetLength(0) - 1
                If astData(iRowCounter, 1).ToUpper = stSearch.ToUpper Then
                    bFound = True

                    ' Build the person's information string
                    For iColumnCounter = 0 To astData.GetLength(1) - 1
                        If astData(iRowCounter, iColumnCounter) <> astData(iRowCounter, astData.GetLength(1) - 1) Then
                            stPersonInfo &= astData(iRowCounter, iColumnCounter) & ", "
                        Else
                            stPersonInfo &= astData(iRowCounter, iColumnCounter)
                        End If
                    Next

                    Exit For
                End If
            Next

            If bFound = True Then
                MsgBox(stPersonInfo)
            Else
                MsgBox("Person not found.")
            End If
        End If
    End Sub
End Class