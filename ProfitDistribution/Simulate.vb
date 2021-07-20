Module Simulate
    Function GetuniformRandom(ByVal min As Integer, ByVal max As Integer) As Integer

        Dim uniform As Integer = CInt((Rnd() * (max - min + 1)) + min)
        Return uniform
    End Function
    Function GetnormalRandom(ByVal mean As Single, ByVal stddev As Single) As Single
        Dim r As Single = Rnd()
        Dim phi As Single = Rnd()
        Dim z As Single = CSng((Math.Cos(2 * Math.PI * r)) * (Math.Sqrt(-2 * Math.Log(phi))))
        Dim x As Single = z * stddev + mean
        Return x

    End Function

    Function GetBinIndex(ByVal mini As Single, ByVal maxi As Single, ByVal numBins As Integer, ByVal valuetobin As Single) As Integer
        Dim binIndex As Integer = CInt(Math.Ceiling((valuetobin - mini) * (numBins / (maxi - mini))))
        Return binIndex
    End Function
End Module

