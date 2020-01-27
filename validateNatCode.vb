 Function IsValidNationalCode(ByVal nationalCode As String) As Boolean
 If nationalCode = String.Empty Then Return True --Or Flase if need

        Dim regex = New System.Text.RegularExpressions.Regex("\d{10}")

        If Not regex.IsMatch(nationalCode) Then Return False
        Dim allDigitEqual() As String = {"0000000000", "1111111111", "2222222222", "3333333333", "4444444444", "5555555555", "6666666666", "7777777777", "8888888888", "9999999999"}

        If allDigitEqual(0) = (nationalCode) Then Return False
        If allDigitEqual(1) = (nationalCode) Then Return False
        If allDigitEqual(2) = (nationalCode) Then Return False
        If allDigitEqual(3) = (nationalCode) Then Return False
        If allDigitEqual(4) = (nationalCode) Then Return False
        If allDigitEqual(5) = (nationalCode) Then Return False
        If allDigitEqual(6) = (nationalCode) Then Return False
        If allDigitEqual(7) = (nationalCode) Then Return False
        If allDigitEqual(8) = (nationalCode) Then Return False
        If allDigitEqual(9) = (nationalCode) Then Return False

        Dim chArray = nationalCode.ToCharArray()
        Dim num0 = Convert.ToInt32(chArray(0).ToString()) * 10
        Dim num2 = Convert.ToInt32(chArray(1).ToString()) * 9
        Dim num3 = Convert.ToInt32(chArray(2).ToString()) * 8
        Dim num4 = Convert.ToInt32(chArray(3).ToString()) * 7
        Dim num5 = Convert.ToInt32(chArray(4).ToString()) * 6
        Dim num6 = Convert.ToInt32(chArray(5).ToString()) * 5
        Dim num7 = Convert.ToInt32(chArray(6).ToString()) * 4
        Dim num8 = Convert.ToInt32(chArray(7).ToString()) * 3
        Dim num9 = Convert.ToInt32(chArray(8).ToString()) * 2
        Dim a = Convert.ToInt32(chArray(9).ToString())
        Dim b = (((((((num0 + num2) + num3) + num4) + num5) + num6) + num7) + num8) + num9
        Dim c = b Mod 11

        Return (((c < 2) AndAlso (a = c)) OrElse ((c >= 2) AndAlso ((11 - c) = a)))
    End Function
