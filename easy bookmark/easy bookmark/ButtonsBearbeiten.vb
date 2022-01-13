Imports System.ComponentModel

Public Class ButtonsBearbeiten
    Private Sub ButtonsBearbeiten_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            link_txt.Text = My.Settings.Button1_Link
            text_txt.Text = My.Settings.Button1_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            link_txt.Text = My.Settings.Button2_Link
            text_txt.Text = My.Settings.Button2_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            link_txt.Text = My.Settings.Button3_Link
            text_txt.Text = My.Settings.Button3_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            link_txt.Text = My.Settings.Button4_Link
            text_txt.Text = My.Settings.Button4_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            link_txt.Text = My.Settings.Button5_Link
            text_txt.Text = My.Settings.Button5_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            link_txt.Text = My.Settings.Button6_Link
            text_txt.Text = My.Settings.Button6_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            link_txt.Text = My.Settings.Button7_Link
            text_txt.Text = My.Settings.Button7_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            link_txt.Text = My.Settings.Button8_Link
            text_txt.Text = My.Settings.Button8_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            link_txt.Text = My.Settings.Button9_Link
            text_txt.Text = My.Settings.Button9_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            link_txt.Text = My.Settings.Button10_Link
            text_txt.Text = My.Settings.Button10_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            link_txt.Text = My.Settings.Button11_Link
            text_txt.Text = My.Settings.Button11_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            link_txt.Text = My.Settings.Button12_Link
            text_txt.Text = My.Settings.Button12_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            link_txt.Text = My.Settings.Button13_Link
            text_txt.Text = My.Settings.Button13_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            link_txt.Text = My.Settings.Button14_Link
            text_txt.Text = My.Settings.Button14_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            link_txt.Text = My.Settings.Button15_Link
            text_txt.Text = My.Settings.Button15_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            link_txt.Text = My.Settings.Button16_Link
            text_txt.Text = My.Settings.Button16_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            link_txt.Text = My.Settings.Button17_Link
            text_txt.Text = My.Settings.Button17_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            link_txt.Text = My.Settings.Button18_Link
            text_txt.Text = My.Settings.Button18_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            link_txt.Text = My.Settings.Button19_Link
            text_txt.Text = My.Settings.Button19_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            link_txt.Text = My.Settings.Button20_Link
            text_txt.Text = My.Settings.Button20_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            link_txt.Text = My.Settings.Button21_Link
            text_txt.Text = My.Settings.Button21_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            link_txt.Text = My.Settings.Button22_Link
            text_txt.Text = My.Settings.Button22_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            link_txt.Text = My.Settings.Button23_Link
            text_txt.Text = My.Settings.Button23_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            link_txt.Text = My.Settings.Button24_Link
            text_txt.Text = My.Settings.Button24_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            link_txt.Text = My.Settings.Button25_Link
            text_txt.Text = My.Settings.Button25_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            link_txt.Text = My.Settings.Button26_Link
            text_txt.Text = My.Settings.Button26_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            link_txt.Text = My.Settings.Button27_Link
            text_txt.Text = My.Settings.Button27_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            link_txt.Text = My.Settings.Button28_Link
            text_txt.Text = My.Settings.Button28_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            link_txt.Text = My.Settings.Button29_Link
            text_txt.Text = My.Settings.Button29_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            link_txt.Text = My.Settings.Button30_Link
            text_txt.Text = My.Settings.Button30_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            link_txt.Text = My.Settings.Button31_Link
            text_txt.Text = My.Settings.Button31_Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            link_txt.Text = My.Settings.Button32_Link
            text_txt.Text = My.Settings.Button32_Text
        End If
    End Sub

    Private Sub ButtonsBearbeiten_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub speichern_btn_Click(sender As Object, e As EventArgs) Handles speichern_btn.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Link = link_txt.Text
            My.Settings.Button1_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Link = link_txt.Text
            My.Settings.Button2_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Link = link_txt.Text
            My.Settings.Button3_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Link = link_txt.Text
            My.Settings.Button4_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Link = link_txt.Text
            My.Settings.Button5_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Link = link_txt.Text
            My.Settings.Button6_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Link = link_txt.Text
            My.Settings.Button7_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Link = link_txt.Text
            My.Settings.Button8_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Link = link_txt.Text
            My.Settings.Button9_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Link = link_txt.Text
            My.Settings.Button10_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Link = link_txt.Text
            My.Settings.Button11_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Link = link_txt.Text
            My.Settings.Button12_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Link = link_txt.Text
            My.Settings.Button13_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Link = link_txt.Text
            My.Settings.Button14_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Link = link_txt.Text
            My.Settings.Button15_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Link = link_txt.Text
            My.Settings.Button16_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Link = link_txt.Text
            My.Settings.Button17_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Link = link_txt.Text
            My.Settings.Button18_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Link = link_txt.Text
            My.Settings.Button19_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Link = link_txt.Text
            My.Settings.Button20_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Link = link_txt.Text
            My.Settings.Button21_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Link = link_txt.Text
            My.Settings.Button22_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Link = link_txt.Text
            My.Settings.Button23_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Link = link_txt.Text
            My.Settings.Button24_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Link = link_txt.Text
            My.Settings.Button25_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Link = link_txt.Text
            My.Settings.Button26_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Link = link_txt.Text
            My.Settings.Button27_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Link = link_txt.Text
            My.Settings.Button28_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Link = link_txt.Text
            My.Settings.Button29_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Link = link_txt.Text
            My.Settings.Button30_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Link = link_txt.Text
            My.Settings.Button31_Text = text_txt.Text
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Link = link_txt.Text
            My.Settings.Button32_Text = text_txt.Text
        End If

        My.Settings.Save()
        My.Settings.Reload()
        Application.Restart()
    End Sub

    Private Sub hintergrund_grün_Click(sender As Object, e As EventArgs) Handles hintergrund_grün.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Hintergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Hintergrundfarbe = "grün"
        End If
    End Sub

    Private Sub hintergrund_rot_Click(sender As Object, e As EventArgs) Handles hintergrund_rot.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Hintergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Hintergrundfarbe = "rot"
        End If
    End Sub

    Private Sub hintergrund_schwarz_Click(sender As Object, e As EventArgs) Handles hintergrund_schwarz.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Hintergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Hintergrundfarbe = "schwarz"
        End If
    End Sub

    Private Sub hintergrund_lila_Click(sender As Object, e As EventArgs) Handles hintergrund_lila.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Hintergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Hintergrundfarbe = "lila"
        End If
    End Sub

    Private Sub hintergrund_blau_Click(sender As Object, e As EventArgs) Handles hintergrund_blau.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Hintergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Hintergrundfarbe = "blau"
        End If
    End Sub

    Private Sub hintergrund_weiß_Click(sender As Object, e As EventArgs) Handles hintergrund_weiß.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Hintergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Hintergrundfarbe = "weiß"
        End If
    End Sub

    Private Sub vordergrund_grün_Click(sender As Object, e As EventArgs) Handles vordergrund_grün.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Vordergrundfarbe = "grün"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Vordergrundfarbe = "grün"
        End If
    End Sub

    Private Sub vordergrund_rot_Click(sender As Object, e As EventArgs) Handles vordergrund_rot.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Vordergrundfarbe = "rot"
        End If
        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Vordergrundfarbe = "rot"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Vordergrundfarbe = "rot"
        End If
    End Sub

    Private Sub vordergrund_schwarz_Click(sender As Object, e As EventArgs) Handles vordergrund_schwarz.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Vordergrundfarbe = "schwarz"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Vordergrundfarbe = "schwarz"
        End If
    End Sub

    Private Sub vordergrund_lila_Click(sender As Object, e As EventArgs) Handles vordergrund_lila.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Vordergrundfarbe = "lila"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Vordergrundfarbe = "lila"
        End If
    End Sub

    Private Sub vordergrund_blau_Click(sender As Object, e As EventArgs) Handles vordergrund_blau.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Vordergrundfarbe = "blau"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Vordergrundfarbe = "blau"
        End If
    End Sub

    Private Sub vordergrund_weiß_Click(sender As Object, e As EventArgs) Handles vordergrund_weiß.Click
        If (AusgewählterButton_lbl.Text = "Button 1") Then
            My.Settings.Button1_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 2") Then
            My.Settings.Button2_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 3") Then
            My.Settings.Button3_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 4") Then
            My.Settings.Button4_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 5") Then
            My.Settings.Button5_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 6") Then
            My.Settings.Button6_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 7") Then
            My.Settings.Button7_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 8") Then
            My.Settings.Button8_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 9") Then
            My.Settings.Button9_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 10") Then
            My.Settings.Button10_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 11") Then
            My.Settings.Button11_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 12") Then
            My.Settings.Button12_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 13") Then
            My.Settings.Button13_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 14") Then
            My.Settings.Button14_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 15") Then
            My.Settings.Button15_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 16") Then
            My.Settings.Button16_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 17") Then
            My.Settings.Button17_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 18") Then
            My.Settings.Button18_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 19") Then
            My.Settings.Button19_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 20") Then
            My.Settings.Button20_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 21") Then
            My.Settings.Button21_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 22") Then
            My.Settings.Button22_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 23") Then
            My.Settings.Button23_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 24") Then
            My.Settings.Button24_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 25") Then
            My.Settings.Button25_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 26") Then
            My.Settings.Button26_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 27") Then
            My.Settings.Button27_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 28") Then
            My.Settings.Button28_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 29") Then
            My.Settings.Button29_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 30") Then
            My.Settings.Button30_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 31") Then
            My.Settings.Button31_Vordergrundfarbe = "weiß"
        End If

        If (AusgewählterButton_lbl.Text = "Button 32") Then
            My.Settings.Button32_Vordergrundfarbe = "weiß"
        End If
    End Sub
End Class