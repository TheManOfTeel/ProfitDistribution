Public Class Form1
    Dim PvMin As Integer
    Dim PvMax As Integer
    Dim mean As Single
    Dim stddev As Single
    Dim PtMax As Integer
    Dim PtMin As Integer
    Dim NMax As Integer
    Dim NMin As Integer
    Dim numBins As Integer
    Dim ProfitTotal As Double
    Dim counter As Integer
    Dim IndividualProfit As Single
    Dim averageprofit As Single
    Dim PvNormalMin As Integer
    Dim PvNormalMax As Integer
    Dim Nmean As Single
    Dim Nstddev As Single

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click


        If radNormalPv.Checked Then
            If radUniformN.Checked Then
                mean = CSng(txtMeanPv.Text)
                stddev = CSng(txtStndDevPv.Text)



                PvMin = CInt(mean - (3 * stddev))
                PvMax = CInt(mean + (3 * stddev))
                'MessageBox.Show(PvMin.ToString & PvMax.ToString)
                NMin = CInt(txtMinN.Text)
                NMax = CInt(txtMaxN.Text)
                PtMin = CInt(PvMin * NMin)
                PtMax = CInt(PvMax * NMax)
                numBins = CInt(txtNumBins.Text)
                Dim BinMin As Integer = PvMin * NMin
                Dim BinMax As Integer = PvMax * NMax
                Dim BinIncrement As Integer = CInt((BinMax - BinMin) / numBins)
                'MessageBox.Show(PtMin.ToString & " " & PtMax.ToString)

                Dim Bins(numBins) As Integer
                counter = CInt(txtIterations.Text) - 1
                Dim Ni As Integer
                Dim Pvi As Single
                ProfitTotal = 0
                'Dim BinPlacememt As Integer = 0
                Dim IndPorfit(counter) As Integer

                For i As Integer = 0 To counter

                    ' For j As Integer = 0 To counter
                    Ni = GetuniformRandom(NMin, NMax)
                    Pvi = GetnormalRandom(mean, stddev)
                    IndividualProfit = Ni * Pvi
                    IndPorfit(i) = CInt(IndividualProfit)
                    'If IndividualProfit <= BinMin And >= BinMin + BinIncrement Then
                    '    Bins(0) = Bins(0) + 1
                    'ElseIf IndividualProfit < BinMin + (BinIncrement) And =

                    For j As Integer = 1 To numBins + 1
                        If IndividualProfit > BinMin + (BinIncrement * (j - 1)) And (IndividualProfit <= BinMin + (BinIncrement * j)) Then
                            Bins(j - 1) = Bins(j - 1) + 1
                            'Else

                            'Bins(j - 1) = Bins(j - 1)
                        End If
                    Next
                    'For m As Integer = 1 To numBins
                    '    Bins(m) = Bins(m) - Bins(m - 1)
                    'Next



                    'Next

                    'For j = 1 To numBins

                    'Next



                    'Next


                    ProfitTotal = ProfitTotal + IndividualProfit
                Next
                'MessageBox.Show(Bins(1).ToString)
                'MessageBox.Show(Bins(2).ToString)
                'MessageBox.Show(Bins(9).ToString)

                'MessagteBox.Show(ProfitTotal.ToString & vbCrLf & Ni.ToString & vbCrLf & Pvi.ToString)

                averageprofit = CSng(ProfitTotal / CSng(txtIterations.Text))

                lblOutputAvg.Text = averageprofit.ToString("c")
                For m As Integer = 0 To numBins
                    chrtData.Series(0).Points.AddXY(m, Bins(m))
                    chrtData.Series(0).Points(m).AxisLabel = "Bin " & m
                Next
                'MessageBox.Show(IndPorfit(counter).ToString)
            End If
        End If
        If radUniformPv.Checked Then
            If radUniformN.Checked Then
                PvNormalMin = CInt(txtMinPv.Text)
                PvNormalMax = CInt(txtMaxPV.Text)
                NMin = CInt(txtMinN.Text)
                NMax = CInt(txtMaxN.Text)
                PvMin = PvNormalMin
                PvMax = PvNormalMax
                numBins = CInt(txtNumBins.Text)
                Dim BinMin As Integer = PvMin * NMin
                Dim BinMax As Integer = PvMax * NMax
                Dim BinIncrement As Integer = CInt((BinMax - BinMin) / numBins)
                'MessageBox.Show(PtMin.ToString & " " & PtMax.ToString)

                Dim Bins(numBins) As Integer
                counter = CInt(txtIterations.Text) - 1
                Dim Ni As Integer
                Dim Pvi As Single
                ProfitTotal = 0
                'Dim BinPlacememt As Integer = 0
                Dim IndPorfit(counter) As Integer

                For i As Integer = 0 To counter

                    ' For j As Integer = 0 To counter
                    Ni = GetuniformRandom(NMin, NMax)
                    Pvi = GetuniformRandom(PvMin, PvMax)
                    IndividualProfit = Ni * Pvi
                    IndPorfit(i) = CInt(IndividualProfit)
                    'If IndividualProfit <= BinMin And >= BinMin + BinIncrement Then
                    '    Bins(0) = Bins(0) + 1
                    'ElseIf IndividualProfit < BinMin + (BinIncrement) And =

                    For j As Integer = 1 To numBins + 1
                        If IndividualProfit > BinMin + (BinIncrement * (j - 1)) And (IndividualProfit <= BinMin + (BinIncrement * j)) Then
                            Bins(j - 1) = Bins(j - 1) + 1
                            'Else

                            'Bins(j - 1) = Bins(j - 1)
                        End If
                    Next
                    'For m As Integer = 1 To numBins
                    '    Bins(m) = Bins(m) - Bins(m - 1)
                    'Next



                    'Next

                    'For j = 1 To numBins

                    'Next



                    'Next


                    ProfitTotal = ProfitTotal + IndividualProfit
                Next
                'MessageBox.Show(Bins(1).ToString)
                'MessageBox.Show(Bins(2).ToString)
                'MessageBox.Show(Bins(9).ToString)

                'MessagteBox.Show(ProfitTotal.ToString & vbCrLf & Ni.ToString & vbCrLf & Pvi.ToString)

                averageprofit = CSng(ProfitTotal / CSng(txtIterations.Text))

                lblOutputAvg.Text = averageprofit.ToString("c")
                For m As Integer = 0 To numBins
                    chrtData.Series(0).Points.AddXY(m, Bins(m))
                    chrtData.Series(0).Points(m).AxisLabel = "Bin " & m
                Next



            End If
        End If
        If radNormalPv.Checked Then
            If radNormalN.Checked Then
                mean = CSng(txtMeanPv.Text)
                stddev = CSng(txtStndDevPv.Text)
                PvMin = CInt(mean - (3 * stddev))
                PvMax = CInt(mean + (3 * stddev))
                Nmean = CSng(txtMeanN.Text)
                Nstddev = CSng(txtStndDevN.Text)
                NMin = CInt(Nmean - (3 * Nstddev))
                NMax = CInt(Nmean + (3 * Nstddev))
                numBins = CInt(txtNumBins.Text)
                Dim BinMin As Integer = PvMin * NMin
                Dim BinMax As Integer = PvMax * NMax
                Dim BinIncrement As Integer = CInt((BinMax - BinMin) / numBins)
                'MessageBox.Show(PtMin.ToString & " " & PtMax.ToString)

                Dim Bins(numBins) As Integer
                counter = CInt(txtIterations.Text) - 1
                Dim Ni As Integer
                Dim Pvi As Single
                ProfitTotal = 0
                'Dim BinPlacememt As Integer = 0
                Dim IndPorfit(counter) As Integer

                For i As Integer = 0 To counter

                    ' For j As Integer = 0 To counter
                    Ni = CInt(GetnormalRandom(Nmean, Nstddev))
                    Pvi = GetnormalRandom(mean, stddev)
                    IndividualProfit = Ni * Pvi
                    IndPorfit(i) = CInt(IndividualProfit)
                    'If IndividualProfit <= BinMin And >= BinMin + BinIncrement Then
                    '    Bins(0) = Bins(0) + 1
                    'ElseIf IndividualProfit < BinMin + (BinIncrement) And =

                    For j As Integer = 1 To numBins + 1
                        If IndividualProfit > BinMin + (BinIncrement * (j - 1)) And (IndividualProfit <= BinMin + (BinIncrement * j)) Then
                            Bins(j - 1) = Bins(j - 1) + 1
                            'Else

                            'Bins(j - 1) = Bins(j - 1)
                        End If
                    Next
                    'For m As Integer = 1 To numBins
                    '    Bins(m) = Bins(m) - Bins(m - 1)
                    'Next



                    'Next

                    'For j = 1 To numBins

                    'Next



                    'Next


                    ProfitTotal = ProfitTotal + IndividualProfit
                Next
                'MessageBox.Show(Bins(1).ToString)
                'MessageBox.Show(Bins(2).ToString)
                'MessageBox.Show(Bins(9).ToString)

                'MessagteBox.Show(ProfitTotal.ToString & vbCrLf & Ni.ToString & vbCrLf & Pvi.ToString)

                averageprofit = CSng(ProfitTotal / CSng(txtIterations.Text))

                lblOutputAvg.Text = averageprofit.ToString("c")
                For m As Integer = 0 To numBins
                    chrtData.Series(0).Points.AddXY(m, Bins(m))
                    chrtData.Series(0).Points(m).AxisLabel = "Bin " & m
                Next

            End If
        End If
        If radUniformPv.Checked Then
            If radNormalN.Checked Then
                PvMin = CInt(txtMinPv.Text)
                PvMax = CInt(txtMaxPV.Text)
                NMin = CInt(Nmean - (3 * Nstddev))
                NMax = CInt(Nmean + (3 * Nstddev))
                numBins = CInt(txtNumBins.Text)
                Dim BinMin As Integer = PvMin * NMin
                Dim BinMax As Integer = PvMax * NMax
                Dim BinIncrement As Integer = CInt((BinMax - BinMin) / numBins)
                'MessageBox.Show(PtMin.ToString & " " & PtMax.ToString)

                Dim Bins(numBins) As Integer
                counter = CInt(txtIterations.Text) - 1
                Dim Ni As Integer
                Dim Pvi As Single
                ProfitTotal = 0
                'Dim BinPlacememt As Integer = 0
                Dim IndPorfit(counter) As Integer

                For i As Integer = 0 To counter

                    ' For j As Integer = 0 To counter
                    Ni = CInt(GetnormalRandom(Nmean, Nstddev))
                    Pvi = GetuniformRandom(PvMin, PvMax)
                    IndividualProfit = Ni * Pvi
                    IndPorfit(i) = CInt(IndividualProfit)
                    'If IndividualProfit <= BinMin And >= BinMin + BinIncrement Then
                    '    Bins(0) = Bins(0) + 1
                    'ElseIf IndividualProfit < BinMin + (BinIncrement) And =

                    For j As Integer = 1 To numBins + 1
                        If IndividualProfit > BinMin + (BinIncrement * (j - 1)) And (IndividualProfit <= BinMin + (BinIncrement * j)) Then
                            Bins(j - 1) = Bins(j - 1) + 1
                            'Else

                            'Bins(j - 1) = Bins(j - 1)
                        End If
                    Next
                    'For m As Integer = 1 To numBins
                    '    Bins(m) = Bins(m) - Bins(m - 1)
                    'Next



                    'Next

                    'For j = 1 To numBins

                    'Next



                    'Next


                    ProfitTotal = ProfitTotal + IndividualProfit
                Next
                'MessageBox.Show(Bins(1).ToString)
                'MessageBox.Show(Bins(2).ToString)
                'MessageBox.Show(Bins(9).ToString)

                'MessagteBox.Show(ProfitTotal.ToString & vbCrLf & Ni.ToString & vbCrLf & Pvi.ToString)

                averageprofit = CSng(ProfitTotal / CSng(txtIterations.Text))

                lblOutputAvg.Text = averageprofit.ToString("c")
                For m As Integer = 0 To numBins
                    chrtData.Series(0).Points.AddXY(m, Bins(m))
                    chrtData.Series(0).Points(m).AxisLabel = "Bin " & m
                Next

            End If
        End If



    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BinArray(numBins - 1) As Integer

    End Sub

    Private Sub chrtData_Click(sender As Object, e As EventArgs) Handles chrtData.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub radUnoformPv_CheckedChanged(sender As Object, e As EventArgs) Handles radUniformPv.CheckedChanged
        If radUniformPv.Checked Then
            grpBoxUniformPv.Visible = True
            grpBoxNormalPV.Visible = False
        End If

    End Sub

    Private Sub radNormalPv_CheckedChanged(sender As Object, e As EventArgs) Handles radNormalPv.CheckedChanged
        If radNormalPv.Checked Then
            grpBoxUniformPv.Visible = False
            grpBoxNormalPV.Visible = True




        End If
    End Sub

    Private Sub radUniformN_CheckedChanged(sender As Object, e As EventArgs) Handles radUniformN.CheckedChanged
        If radUniformN.Checked Then
            grpBoxNormalN.Visible = False
            grpBoxUniformN.Visible = True

        End If
    End Sub

    Private Sub radNormalN_CheckedChanged(sender As Object, e As EventArgs) Handles radNormalN.CheckedChanged
        If radNormalN.Checked Then
            grpBoxNormalN.Visible = True
            grpBoxUniformN.Visible = False
        End If
    End Sub
End Class
