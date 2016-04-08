Public Class Form1
    'Scale
    Dim C8 As Double = 4186.01
    Dim B7 As Double = 3951.07
    Dim AS7 As Double = 3729.31
    Dim A7 As Double = 3520.0
    Dim GS7 As Double = 3322.44
    Dim G7 As Double = 3135.96
    Dim FS7 As Double = 2959.96
    Dim F7 As Double = 2793.83
    Dim E7 As Double = 2637.02
    Dim DS7 As Double = 2489.02
    Dim D7 As Double = 2349.32
    Dim CS7 As Double = 2217.46
    Dim C7 As Double = 2093.0
    Dim B6 As Double = 1975.53
    Dim AS6 As Double = 1864.66
    Dim A6 As Double = 1760.0
    Dim GS6 As Double = 1661.22
    Dim G6 As Double = 1567.98
    Dim FS6 As Double = 1479.98
    Dim F6 As Double = 1396.91
    Dim E6 As Double = 1318.51
    Dim DS6 As Double = 1244.51
    Dim D6 As Double = 1174.66
    Dim CS6 As Double = 1108.73
    Dim C6 As Double = 1046.5
    Dim B5 As Double = 987.767
    Dim AS5 As Double = 932.328
    Dim A5 As Double = 880.0
    Dim GS5 As Double = 830.609
    Dim G5 As Double = 783.991
    Dim FS5 As Double = 739.989
    Dim F5 As Double = 698.456
    Dim E5 As Double = 659.255
    Dim DS5 As Double = 622.254
    Dim D5 As Double = 587.33
    Dim CS5 As Double = 554.365
    Dim C5 As Double = 523.251
    Dim B4 As Double = 493.883
    Dim AS4 As Double = 466.164
    Dim A4 As Double = 440.0
    Dim GS4 As Double = 415.305
    Dim G4 As Double = 391.995
    Dim FS4 As Double = 369.994
    Dim F4 As Double = 349.228
    Dim E4 As Double = 329.628
    Dim DS4 As Double = 311.127
    Dim D4 As Double = 293.665
    Dim CS4 As Double = 277.183
    Dim C4 As Double = 261.626
    Dim B3 As Double = 246.942
    Dim AS3 As Double = 233.082
    Dim A3 As Double = 220.0
    Dim GS3 As Double = 207.652
    Dim G3 As Double = 195.998
    Dim FS3 As Double = 184.997
    Dim F3 As Double = 174.614
    Dim E3 As Double = 164.814
    Dim DS3 As Double = 155.563
    Dim D3 As Double = 146.832
    Dim CS3 As Double = 138.591
    Dim C3 As Double = 130.813
    Dim B2 As Double = 123.471
    Dim AS2 As Double = 116.541
    Dim A2 As Double = 110.0
    Dim GS2 As Double = 103.826
    Dim G2 As Double = 97.9989
    Dim FS2 As Double = 92.4986
    Dim F2 As Double = 87.3071
    Dim E2 As Double = 82.4069
    Dim DS2 As Double = 77.7817
    Dim D2 As Double = 73.4162
    Dim CS2 As Double = 69.2957
    Dim C2 As Double = 65.4064
    Dim B1 As Double = 61.7354
    Dim AS1 As Double = 58.2705
    Dim A1 As Double = 55.0
    Dim GS1 As Double = 51.9131
    Dim G1 As Double = 48.9994
    Dim FS1 As Double = 46.2493
    Dim F1 As Double = 43.6535
    Dim E1 As Double = 41.2034
    Dim DS1 As Double = 38.8909
    Dim D1 As Double = 36.7081
    Dim CS1 As Double = 34.6478
    Dim C1 As Double = 32.7032
    Dim B0 As Double = 30.8677
    Dim AS0 As Double = 29.1352
    Dim A0 As Double = 27.5
    Dim Octave As Integer = 4


    Public Sub P(ByVal note As Double, ByVal duration As Double)
        System.Console.Beep(note, duration)
    End Sub
    Private Sub btnScale_Click(sender As Object, ea As EventArgs) Handles btnScale.Click
        P(C4, 500)
        P(CS4, 500)
        P(D4, 500)
        P(DS4, 500)
        P(E4, 500)
        P(F4, 500)
        P(FS4, 500)
        P(G4, 500)
        P(GS4, 500)
        P(A4, 500)
        P(AS4, 500)
        P(B4, 500)
        P(C5, 500)
    End Sub

    Private Sub btnMario_Click(sender As Object, e As EventArgs) Handles btnMario.Click
        P(E5, 125)
        P(E5, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(167)
        P(C5, 125)
        P(E5, 125)
        System.Threading.Thread.Sleep(125)
        P(G5, 125)
        System.Threading.Thread.Sleep(375)
        P(G4, 125)
        System.Threading.Thread.Sleep(375)
        P(C5, 125)
        System.Threading.Thread.Sleep(250)
        P(G4, 125)
        System.Threading.Thread.Sleep(250)
        P(E4, 125)
        System.Threading.Thread.Sleep(250)
        P(A4, 125)
        System.Threading.Thread.Sleep(125)
        P(B4, 125)
        System.Threading.Thread.Sleep(125)
        P(AS4, 125)
        System.Threading.Thread.Sleep(42)
        P(A4, 125)
        System.Threading.Thread.Sleep(125)
        P(G4, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(125)
        P(G5, 125)
        System.Threading.Thread.Sleep(125)
        P(A5, 125)
        System.Threading.Thread.Sleep(125)
        P(F5, 125)
        P(G5, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(125)
        P(C5, 125)
        System.Threading.Thread.Sleep(125)
        P(D5, 125)
        P(B4, 125)
        System.Threading.Thread.Sleep(125)
        P(C5, 125)
        System.Threading.Thread.Sleep(250)
        P(G4, 125)
        System.Threading.Thread.Sleep(250)
        P(E4, 125)
        System.Threading.Thread.Sleep(250)
        P(A4, 125)
        System.Threading.Thread.Sleep(125)
        P(B4, 125)
        System.Threading.Thread.Sleep(125)
        P(AS4, 125)
        System.Threading.Thread.Sleep(42)
        P(A4, 125)
        System.Threading.Thread.Sleep(125)
        P(G4, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(125)
        P(G5, 125)
        System.Threading.Thread.Sleep(125)
        P(A5, 125)
        System.Threading.Thread.Sleep(125)
        P(F5, 125)
        P(G5, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(125)
        P(C5, 125)
        System.Threading.Thread.Sleep(125)
        P(D5, 125)
        P(B4, 125)
        System.Threading.Thread.Sleep(375)
        P(G5, 125)
        P(FS5, 125)
        P(F5, 125)
        System.Threading.Thread.Sleep(42)
        P(DS5, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(167)
        P(GS4, 125)
        P(A4, 125)
        P(C5, 125)
        System.Threading.Thread.Sleep(125)
        P(A4, 125)
        P(C5, 125)
        P(D5, 125)
        System.Threading.Thread.Sleep(250)
        P(G5, 125)
        P(FS5, 125)
        P(F5, 125)
        System.Threading.Thread.Sleep(42)
        P(DS5, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(167)
        P(F5, 125)
        System.Threading.Thread.Sleep(125)
        P(F5, 125)
        P(F5, 125)
        System.Threading.Thread.Sleep(625)
        P(G5, 125)
        P(FS5, 125)
        P(F5, 125)
        System.Threading.Thread.Sleep(42)
        P(DS5, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(167)
        P(GS4, 125)
        P(A4, 125)
        P(C5, 125)
        System.Threading.Thread.Sleep(125)
        P(A4, 125)
        P(C5, 125)
        P(D5, 125)
        System.Threading.Thread.Sleep(250)
        P(DS5, 125)
        System.Threading.Thread.Sleep(250)
        P(D5, 125)
        System.Threading.Thread.Sleep(250)
        P(C5, 125)
        System.Threading.Thread.Sleep(1125)
        P(G5, 125)
        P(FS5, 125)
        P(F5, 125)
        System.Threading.Thread.Sleep(42)
        P(DS5, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(167)
        P(GS4, 125)
        P(A4, 125)
        P(C5, 125)
        System.Threading.Thread.Sleep(125)
        P(A4, 125)
        P(C5, 125)
        P(D5, 125)
        System.Threading.Thread.Sleep(250)
        P(G5, 125)
        P(FS5, 125)
        P(F5, 125)
        System.Threading.Thread.Sleep(42)
        P(DS5, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(167)
        P(F5, 125)
        System.Threading.Thread.Sleep(125)
        P(F5, 125)
        P(F5, 125)
        System.Threading.Thread.Sleep(625)
        P(G5, 125)
        P(FS5, 125)
        P(F5, 125)
        System.Threading.Thread.Sleep(42)
        P(DS5, 125)
        System.Threading.Thread.Sleep(125)
        P(E5, 125)
        System.Threading.Thread.Sleep(167)
        P(GS4, 125)
        P(A4, 125)
        P(C5, 125)
        System.Threading.Thread.Sleep(125)
        P(A4, 125)
        P(C5, 125)
        P(D5, 125)
        System.Threading.Thread.Sleep(250)
        P(DS5, 125)
        System.Threading.Thread.Sleep(250)
        P(D5, 125)
        System.Threading.Thread.Sleep(250)
        P(C5, 125)
        System.Threading.Thread.Sleep(625)
    End Sub

    Private Sub btnTetris_Click(sender As Object, e As EventArgs) Handles btnTetris.Click
        P(658, 125)
        P(1320, 500)
        P(990, 250)
        P(1056, 250)
        P(1188, 250)
        P(1320, 125)
        P(1188, 125)
        P(1056, 250)
        P(990, 250)
        P(880, 500)
        P(880, 250)
        P(1056, 250)
        P(1320, 500)
        P(1188, 250)
        P(1056, 250)
        P(990, 750)
        P(1056, 250)
        P(1188, 500)
        P(1320, 500)
        P(1056, 500)
        P(880, 500)
        P(880, 500)
        System.Threading.Thread.Sleep(250)
        P(1188, 500)
        P(1408, 250)
        P(1760, 500)
        P(1584, 250)
        P(1408, 250)
        P(1320, 750)
        P(1056, 250)
        P(1320, 500)
        P(1188, 250)
        P(1056, 250)
        P(990, 500)
        P(990, 250)
        P(1056, 250)
        P(1188, 500)
        P(1320, 500)
        P(1056, 500)
        P(880, 500)
        P(880, 500)
        System.Threading.Thread.Sleep(500)
        P(1320, 500)
        P(990, 250)
        P(1056, 250)
        P(1188, 250)
        P(1320, 125)
        P(1188, 125)
        P(1056, 250)
        P(990, 250)
        P(880, 500)
        P(880, 250)
        P(1056, 250)
        P(1320, 500)
        P(1188, 250)
        P(1056, 250)
        P(990, 750)
        P(1056, 250)
        P(1188, 500)
        P(1320, 500)
        P(1056, 500)
        P(880, 500)
        P(880, 500)
        System.Threading.Thread.Sleep(250)
        P(1188, 500)
        P(1408, 250)
        P(1760, 500)
        P(1584, 250)
        P(1408, 250)
        P(1320, 750)
        P(1056, 250)
        P(1320, 500)
        P(1188, 250)
        P(1056, 250)
        P(990, 500)
        P(990, 250)
        P(1056, 250)
        P(1188, 500)
        P(1320, 500)
        P(1056, 500)
        P(880, 500)
        P(880, 500)
        System.Threading.Thread.Sleep(500)
        P(660, 1000)
        P(528, 1000)
        P(594, 1000)
        P(495, 1000)
        P(528, 1000)
        P(440, 1000)
        P(419, 1000)
        P(495, 1000)
        P(660, 1000)
        P(528, 1000)
        P(594, 1000)
        P(495, 1000)
        P(528, 500)
        P(660, 500)
        P(880, 1000)
        P(838, 2000)
        P(660, 1000)
        P(528, 1000)
        P(594, 1000)
        P(495, 1000)
        P(528, 1000)
        P(440, 1000)
        P(419, 1000)
        P(495, 1000)
        P(660, 1000)
        P(528, 1000)
        P(594, 1000)
        P(495, 1000)
        P(528, 500)
        P(660, 500)
        P(880, 1000)
        P(838, 2000)
    End Sub
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        FormConver.Show()
    End Sub

    Private Sub btnGS_Click(sender As Object, e As EventArgs) Handles btnGS.Click
        P(Convert.ToDouble("GS" + Octave), 250)
    End Sub



    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Select Case Octave
            Case 1
                P(B1, 250)
            Case 2
                P(B2, 250)
            Case 3
                P(B3, 250)
            Case 4
                P(B4, 250)
            Case 5
                P(B5, 250)
            Case 6
                P(B6, 250)
            Case 7
                P(B7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnAS_Click(sender As Object, e As EventArgs) Handles btnAS.Click
        Select Case Octave
            Case 1
                P(AS1, 250)
            Case 2
                P(AS2, 250)
            Case 3
                P(AS3, 250)
            Case 4
                P(AS4, 250)
            Case 5
                P(AS5, 250)
            Case 6
                P(AS6, 250)
            Case 7
                P(AS7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Select Case Octave
            Case 1
                P(A1, 250)
            Case 2
                P(A2, 250)
            Case 3
                P(A3, 250)
            Case 4
                P(A4, 250)
            Case 5
                P(A5, 250)
            Case 6
                P(A6, 250)
            Case 7
                P(A7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnHighC_Click(sender As Object, e As EventArgs) Handles btnHighC.Click
        Select Case Octave
            Case 1
                P(C2, 250)
            Case 2
                P(C3, 250)
            Case 3
                P(C4, 250)
            Case 4
                P(C5, 250)
            Case 5
                P(C6, 250)
            Case 6
                P(C7, 250)
            Case 7
                P(C8, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        Select Case Octave
            Case 1
                P(G1, 250)
            Case 2
                P(G2, 250)
            Case 3
                P(G3, 250)
            Case 4
                P(G4, 250)
            Case 5
                P(G5, 250)
            Case 6
                P(G6, 250)
            Case 7
                P(G7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnFS_Click(sender As Object, e As EventArgs) Handles btnFS.Click
        Select Case Octave
            Case 1
                P(FS1, 250)
            Case 2
                P(FS2, 250)
            Case 3
                P(FS3, 250)
            Case 4
                P(FS4, 250)
            Case 5
                P(FS5, 250)
            Case 6
                P(FS6, 250)
            Case 7
                P(FS7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        Select Case Octave
            Case 1
                P(F1, 250)
            Case 2
                P(F2, 250)
            Case 3
                P(F3, 250)
            Case 4
                P(F4, 250)
            Case 5
                P(F5, 250)
            Case 6
                P(F6, 250)
            Case 7
                P(F7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Select Case Octave
            Case 1
                P(E1, 250)
            Case 2
                P(E2, 250)
            Case 3
                P(E3, 250)
            Case 4
                P(E4, 250)
            Case 5
                P(E5, 250)
            Case 6
                P(E6, 250)
            Case 7
                P(E7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnDS_Click(sender As Object, e As EventArgs) Handles btnDS.Click
        Select Case Octave
            Case 1
                P(DS1, 250)
            Case 2
                P(DS2, 250)
            Case 3
                P(DS3, 250)
            Case 4
                P(DS4, 250)
            Case 5
                P(DS5, 250)
            Case 6
                P(DS6, 250)
            Case 7
                P(DS7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Select Case Octave
            Case 1
                P(D1, 250)
            Case 2
                P(D2, 250)
            Case 3
                P(D3, 250)
            Case 4
                P(D4, 250)
            Case 5
                P(D5, 250)
            Case 6
                P(D6, 250)
            Case 7
                P(D7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnCS_Click(sender As Object, e As EventArgs) Handles btnCS.Click
        Select Case Octave
            Case 1
                P(CS1, 250)
            Case 2
                P(CS2, 250)
            Case 3
                P(CS3, 250)
            Case 4
                P(CS4, 250)
            Case 5
                P(CS5, 250)
            Case 6
                P(CS6, 250)
            Case 7
                P(CS7, 250)
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Select Case Octave
            Case 1
                P(C1, 250)
            Case 2
                P(C2, 250)
            Case 3
                P(C3, 250)
            Case 4
                P(C4, 250)
            Case 5
                P(C5, 250)
            Case 6
                P(C6, 250)
            Case 7
                P(C7, 250)
            Case Else
                MsgBox("Error")
        End Select


    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Octave = NumericUpDown1.Value
    End Sub
End Class
