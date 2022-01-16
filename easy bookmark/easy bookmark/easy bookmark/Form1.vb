Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dark-/Lightmode
        If (My.Settings.Einstellungen_DarkLightmode = "Lightmode") Then
            Me.BackColor = Color.FromArgb(224, 224, 224)
            MenuStrip1.BackColor = Color.FromArgb(224, 224, 224)
            DarkmodeToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224)
            AktivierenToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224)
            DeaktivierenToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224)

            ButtonsBearbeiten.BackColor = Color.White
        ElseIf (My.Settings.Einstellungen_DarkLightmode = "Darkmode") Then
            Me.BackColor = Color.Gray
            MenuStrip1.BackColor = Color.Gray
            DarkmodeToolStripMenuItem.BackColor = Color.Gray
            AktivierenToolStripMenuItem.BackColor = Color.Gray
            DeaktivierenToolStripMenuItem.BackColor = Color.Gray

            ButtonsBearbeiten.BackColor = Color.Silver
        Else
            Me.BackColor = Color.FromArgb(224, 224, 224)
            MenuStrip1.BackColor = Color.FromArgb(224, 224, 224)
            DarkmodeToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224)
            AktivierenToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224)
            DeaktivierenToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224)

            ButtonsBearbeiten.BackColor = Color.White
        End If

        'Hintergrundfarbe
        If (My.Settings.Button1_Hintergrundfarbe = "grün") Then
            Button1.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button1_Hintergrundfarbe = "rot") Then
            Button1.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button1_Hintergrundfarbe = "schwarz") Then
            Button1.BackColor = Color.Black
        ElseIf (My.Settings.Button1_Hintergrundfarbe = "lila") Then
            Button1.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button1_Hintergrundfarbe = "blau") Then
            Button1.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button1_Hintergrundfarbe = "weiß") Then
            Button1.BackColor = Color.White
        End If

        If (My.Settings.Button2_Hintergrundfarbe = "grün") Then
            Button2.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button2_Hintergrundfarbe = "rot") Then
            Button2.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button2_Hintergrundfarbe = "schwarz") Then
            Button2.BackColor = Color.Black
        ElseIf (My.Settings.Button2_Hintergrundfarbe = "lila") Then
            Button2.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button2_Hintergrundfarbe = "blau") Then
            Button2.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button2_Hintergrundfarbe = "weiß") Then
            Button2.BackColor = Color.White
        End If

        If (My.Settings.Button3_Hintergrundfarbe = "grün") Then
            Button3.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button3_Hintergrundfarbe = "rot") Then
            Button3.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button3_Hintergrundfarbe = "schwarz") Then
            Button3.BackColor = Color.Black
        ElseIf (My.Settings.Button3_Hintergrundfarbe = "lila") Then
            Button3.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button3_Hintergrundfarbe = "blau") Then
            Button3.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button3_Hintergrundfarbe = "weiß") Then
            Button3.BackColor = Color.White
        End If

        If (My.Settings.Button4_Hintergrundfarbe = "grün") Then
            Button4.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button4_Hintergrundfarbe = "rot") Then
            Button4.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button4_Hintergrundfarbe = "schwarz") Then
            Button4.BackColor = Color.Black
        ElseIf (My.Settings.Button4_Hintergrundfarbe = "lila") Then
            Button4.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button4_Hintergrundfarbe = "blau") Then
            Button4.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button4_Hintergrundfarbe = "weiß") Then
            Button4.BackColor = Color.White
        End If

        If (My.Settings.Button5_Hintergrundfarbe = "grün") Then
            Button5.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button5_Hintergrundfarbe = "rot") Then
            Button5.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button5_Hintergrundfarbe = "schwarz") Then
            Button5.BackColor = Color.Black
        ElseIf (My.Settings.Button5_Hintergrundfarbe = "lila") Then
            Button5.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button5_Hintergrundfarbe = "blau") Then
            Button5.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button5_Hintergrundfarbe = "weiß") Then
            Button5.BackColor = Color.White
        End If

        If (My.Settings.Button6_Hintergrundfarbe = "grün") Then
            Button6.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button6_Hintergrundfarbe = "rot") Then
            Button6.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button6_Hintergrundfarbe = "schwarz") Then
            Button6.BackColor = Color.Black
        ElseIf (My.Settings.Button6_Hintergrundfarbe = "lila") Then
            Button6.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button6_Hintergrundfarbe = "blau") Then
            Button6.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button6_Hintergrundfarbe = "weiß") Then
            Button6.BackColor = Color.White
        End If

        If (My.Settings.Button7_Hintergrundfarbe = "grün") Then
            Button7.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button7_Hintergrundfarbe = "rot") Then
            Button7.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button7_Hintergrundfarbe = "schwarz") Then
            Button7.BackColor = Color.Black
        ElseIf (My.Settings.Button7_Hintergrundfarbe = "lila") Then
            Button7.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button7_Hintergrundfarbe = "blau") Then
            Button7.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button7_Hintergrundfarbe = "weiß") Then
            Button7.BackColor = Color.White
        End If

        If (My.Settings.Button8_Hintergrundfarbe = "grün") Then
            Button8.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button8_Hintergrundfarbe = "rot") Then
            Button8.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button8_Hintergrundfarbe = "schwarz") Then
            Button8.BackColor = Color.Black
        ElseIf (My.Settings.Button8_Hintergrundfarbe = "lila") Then
            Button8.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button8_Hintergrundfarbe = "blau") Then
            Button8.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button8_Hintergrundfarbe = "weiß") Then
            Button8.BackColor = Color.White
        End If

        If (My.Settings.Button9_Hintergrundfarbe = "grün") Then
            Button9.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button9_Hintergrundfarbe = "rot") Then
            Button9.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button9_Hintergrundfarbe = "schwarz") Then
            Button9.BackColor = Color.Black
        ElseIf (My.Settings.Button9_Hintergrundfarbe = "lila") Then
            Button9.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button9_Hintergrundfarbe = "blau") Then
            Button9.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button9_Hintergrundfarbe = "weiß") Then
            Button9.BackColor = Color.White
        End If

        If (My.Settings.Button10_Hintergrundfarbe = "grün") Then
            Button10.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button10_Hintergrundfarbe = "rot") Then
            Button10.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button10_Hintergrundfarbe = "schwarz") Then
            Button10.BackColor = Color.Black
        ElseIf (My.Settings.Button10_Hintergrundfarbe = "lila") Then
            Button10.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button10_Hintergrundfarbe = "blau") Then
            Button10.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button10_Hintergrundfarbe = "weiß") Then
            Button10.BackColor = Color.White
        End If

        If (My.Settings.Button11_Hintergrundfarbe = "grün") Then
            Button11.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button11_Hintergrundfarbe = "rot") Then
            Button11.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button11_Hintergrundfarbe = "schwarz") Then
            Button11.BackColor = Color.Black
        ElseIf (My.Settings.Button11_Hintergrundfarbe = "lila") Then
            Button11.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button11_Hintergrundfarbe = "blau") Then
            Button11.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button11_Hintergrundfarbe = "weiß") Then
            Button11.BackColor = Color.White
        End If

        If (My.Settings.Button12_Hintergrundfarbe = "grün") Then
            Button12.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button12_Hintergrundfarbe = "rot") Then
            Button12.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button12_Hintergrundfarbe = "schwarz") Then
            Button12.BackColor = Color.Black
        ElseIf (My.Settings.Button12_Hintergrundfarbe = "lila") Then
            Button12.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button12_Hintergrundfarbe = "blau") Then
            Button12.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button12_Hintergrundfarbe = "weiß") Then
            Button12.BackColor = Color.White
        End If

        If (My.Settings.Button13_Hintergrundfarbe = "grün") Then
            Button13.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button13_Hintergrundfarbe = "rot") Then
            Button13.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button13_Hintergrundfarbe = "schwarz") Then
            Button13.BackColor = Color.Black
        ElseIf (My.Settings.Button13_Hintergrundfarbe = "lila") Then
            Button13.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button13_Hintergrundfarbe = "blau") Then
            Button13.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button13_Hintergrundfarbe = "weiß") Then
            Button13.BackColor = Color.White
        End If

        If (My.Settings.Button14_Hintergrundfarbe = "grün") Then
            Button14.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button14_Hintergrundfarbe = "rot") Then
            Button14.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button14_Hintergrundfarbe = "schwarz") Then
            Button14.BackColor = Color.Black
        ElseIf (My.Settings.Button14_Hintergrundfarbe = "lila") Then
            Button14.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button14_Hintergrundfarbe = "blau") Then
            Button14.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button14_Hintergrundfarbe = "weiß") Then
            Button14.BackColor = Color.White
        End If

        If (My.Settings.Button15_Hintergrundfarbe = "grün") Then
            Button15.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button15_Hintergrundfarbe = "rot") Then
            Button15.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button15_Hintergrundfarbe = "schwarz") Then
            Button15.BackColor = Color.Black
        ElseIf (My.Settings.Button15_Hintergrundfarbe = "lila") Then
            Button15.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button15_Hintergrundfarbe = "blau") Then
            Button15.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button15_Hintergrundfarbe = "weiß") Then
            Button15.BackColor = Color.White
        End If

        If (My.Settings.Button16_Hintergrundfarbe = "grün") Then
            Button16.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button16_Hintergrundfarbe = "rot") Then
            Button16.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button16_Hintergrundfarbe = "schwarz") Then
            Button16.BackColor = Color.Black
        ElseIf (My.Settings.Button16_Hintergrundfarbe = "lila") Then
            Button16.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button16_Hintergrundfarbe = "blau") Then
            Button16.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button16_Hintergrundfarbe = "weiß") Then
            Button16.BackColor = Color.White
        End If

        If (My.Settings.Button17_Hintergrundfarbe = "grün") Then
            Button17.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button17_Hintergrundfarbe = "rot") Then
            Button17.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button17_Hintergrundfarbe = "schwarz") Then
            Button17.BackColor = Color.Black
        ElseIf (My.Settings.Button17_Hintergrundfarbe = "lila") Then
            Button17.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button17_Hintergrundfarbe = "blau") Then
            Button17.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button17_Hintergrundfarbe = "weiß") Then
            Button17.BackColor = Color.White
        End If

        If (My.Settings.Button18_Hintergrundfarbe = "grün") Then
            Button18.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button18_Hintergrundfarbe = "rot") Then
            Button18.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button18_Hintergrundfarbe = "schwarz") Then
            Button18.BackColor = Color.Black
        ElseIf (My.Settings.Button18_Hintergrundfarbe = "lila") Then
            Button18.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button18_Hintergrundfarbe = "blau") Then
            Button18.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button18_Hintergrundfarbe = "weiß") Then
            Button18.BackColor = Color.White
        End If

        If (My.Settings.Button19_Hintergrundfarbe = "grün") Then
            Button19.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button19_Hintergrundfarbe = "rot") Then
            Button19.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button19_Hintergrundfarbe = "schwarz") Then
            Button19.BackColor = Color.Black
        ElseIf (My.Settings.Button19_Hintergrundfarbe = "lila") Then
            Button19.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button19_Hintergrundfarbe = "blau") Then
            Button19.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button19_Hintergrundfarbe = "weiß") Then
            Button19.BackColor = Color.White
        End If

        If (My.Settings.Button20_Hintergrundfarbe = "grün") Then
            Button20.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button20_Hintergrundfarbe = "rot") Then
            Button20.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button20_Hintergrundfarbe = "schwarz") Then
            Button20.BackColor = Color.Black
        ElseIf (My.Settings.Button20_Hintergrundfarbe = "lila") Then
            Button20.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button20_Hintergrundfarbe = "blau") Then
            Button20.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button20_Hintergrundfarbe = "weiß") Then
            Button20.BackColor = Color.White
        End If

        If (My.Settings.Button21_Hintergrundfarbe = "grün") Then
            Button21.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button21_Hintergrundfarbe = "rot") Then
            Button21.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button21_Hintergrundfarbe = "schwarz") Then
            Button21.BackColor = Color.Black
        ElseIf (My.Settings.Button21_Hintergrundfarbe = "lila") Then
            Button21.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button21_Hintergrundfarbe = "blau") Then
            Button21.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button21_Hintergrundfarbe = "weiß") Then
            Button21.BackColor = Color.White
        End If

        If (My.Settings.Button22_Hintergrundfarbe = "grün") Then
            Button22.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button22_Hintergrundfarbe = "rot") Then
            Button22.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button22_Hintergrundfarbe = "schwarz") Then
            Button22.BackColor = Color.Black
        ElseIf (My.Settings.Button22_Hintergrundfarbe = "lila") Then
            Button22.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button22_Hintergrundfarbe = "blau") Then
            Button22.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button22_Hintergrundfarbe = "weiß") Then
            Button22.BackColor = Color.White
        End If

        If (My.Settings.Button23_Hintergrundfarbe = "grün") Then
            Button23.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button23_Hintergrundfarbe = "rot") Then
            Button23.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button23_Hintergrundfarbe = "schwarz") Then
            Button23.BackColor = Color.Black
        ElseIf (My.Settings.Button23_Hintergrundfarbe = "lila") Then
            Button23.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button23_Hintergrundfarbe = "blau") Then
            Button23.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button23_Hintergrundfarbe = "weiß") Then
            Button23.BackColor = Color.White
        End If

        If (My.Settings.Button24_Hintergrundfarbe = "grün") Then
            Button24.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button24_Hintergrundfarbe = "rot") Then
            Button24.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button24_Hintergrundfarbe = "schwarz") Then
            Button24.BackColor = Color.Black
        ElseIf (My.Settings.Button24_Hintergrundfarbe = "lila") Then
            Button24.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button24_Hintergrundfarbe = "blau") Then
            Button24.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button24_Hintergrundfarbe = "weiß") Then
            Button24.BackColor = Color.White
        End If

        If (My.Settings.Button25_Hintergrundfarbe = "grün") Then
            Button25.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button25_Hintergrundfarbe = "rot") Then
            Button25.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button25_Hintergrundfarbe = "schwarz") Then
            Button25.BackColor = Color.Black
        ElseIf (My.Settings.Button25_Hintergrundfarbe = "lila") Then
            Button25.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button25_Hintergrundfarbe = "blau") Then
            Button25.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button25_Hintergrundfarbe = "weiß") Then
            Button25.BackColor = Color.White
        End If

        If (My.Settings.Button26_Hintergrundfarbe = "grün") Then
            Button26.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button26_Hintergrundfarbe = "rot") Then
            Button26.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button26_Hintergrundfarbe = "schwarz") Then
            Button26.BackColor = Color.Black
        ElseIf (My.Settings.Button26_Hintergrundfarbe = "lila") Then
            Button26.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button26_Hintergrundfarbe = "blau") Then
            Button26.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button26_Hintergrundfarbe = "weiß") Then
            Button26.BackColor = Color.White
        End If

        If (My.Settings.Button27_Hintergrundfarbe = "grün") Then
            Button27.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button27_Hintergrundfarbe = "rot") Then
            Button27.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button27_Hintergrundfarbe = "schwarz") Then
            Button27.BackColor = Color.Black
        ElseIf (My.Settings.Button27_Hintergrundfarbe = "lila") Then
            Button27.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button27_Hintergrundfarbe = "blau") Then
            Button27.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button27_Hintergrundfarbe = "weiß") Then
            Button27.BackColor = Color.White
        End If

        If (My.Settings.Button28_Hintergrundfarbe = "grün") Then
            Button28.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button28_Hintergrundfarbe = "rot") Then
            Button28.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button28_Hintergrundfarbe = "schwarz") Then
            Button28.BackColor = Color.Black
        ElseIf (My.Settings.Button28_Hintergrundfarbe = "lila") Then
            Button28.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button28_Hintergrundfarbe = "blau") Then
            Button28.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button28_Hintergrundfarbe = "weiß") Then
            Button28.BackColor = Color.White
        End If

        If (My.Settings.Button29_Hintergrundfarbe = "grün") Then
            Button29.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button29_Hintergrundfarbe = "rot") Then
            Button29.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button29_Hintergrundfarbe = "schwarz") Then
            Button29.BackColor = Color.Black
        ElseIf (My.Settings.Button29_Hintergrundfarbe = "lila") Then
            Button29.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button29_Hintergrundfarbe = "blau") Then
            Button29.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button29_Hintergrundfarbe = "weiß") Then
            Button29.BackColor = Color.White
        End If

        If (My.Settings.Button30_Hintergrundfarbe = "grün") Then
            Button30.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button30_Hintergrundfarbe = "rot") Then
            Button30.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button30_Hintergrundfarbe = "schwarz") Then
            Button30.BackColor = Color.Black
        ElseIf (My.Settings.Button30_Hintergrundfarbe = "lila") Then
            Button30.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button30_Hintergrundfarbe = "blau") Then
            Button30.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button30_Hintergrundfarbe = "weiß") Then
            Button30.BackColor = Color.White
        End If

        If (My.Settings.Button31_Hintergrundfarbe = "grün") Then
            Button31.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button31_Hintergrundfarbe = "rot") Then
            Button31.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button31_Hintergrundfarbe = "schwarz") Then
            Button31.BackColor = Color.Black
        ElseIf (My.Settings.Button31_Hintergrundfarbe = "lila") Then
            Button31.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button31_Hintergrundfarbe = "blau") Then
            Button31.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button31_Hintergrundfarbe = "weiß") Then
            Button31.BackColor = Color.White
        End If

        If (My.Settings.Button32_Hintergrundfarbe = "grün") Then
            Button32.BackColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button32_Hintergrundfarbe = "rot") Then
            Button32.BackColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button32_Hintergrundfarbe = "schwarz") Then
            Button32.BackColor = Color.Black
        ElseIf (My.Settings.Button32_Hintergrundfarbe = "lila") Then
            Button32.BackColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button32_Hintergrundfarbe = "blau") Then
            Button32.BackColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button32_Hintergrundfarbe = "weiß") Then
            Button32.BackColor = Color.White
        End If

        'Vordergrundfarbe
        If (My.Settings.Button1_Vordergrundfarbe = "grün") Then
            Button1.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button1_Vordergrundfarbe = "rot") Then
            Button1.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button1_Vordergrundfarbe = "schwarz") Then
            Button1.ForeColor = Color.Black
        ElseIf (My.Settings.Button1_Vordergrundfarbe = "lila") Then
            Button1.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button1_Vordergrundfarbe = "blau") Then
            Button1.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button1_Vordergrundfarbe = "weiß") Then
            Button1.ForeColor = Color.White
        End If

        If (My.Settings.Button2_Vordergrundfarbe = "grün") Then
            Button2.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button2_Vordergrundfarbe = "rot") Then
            Button2.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button2_Vordergrundfarbe = "schwarz") Then
            Button2.ForeColor = Color.Black
        ElseIf (My.Settings.Button2_Vordergrundfarbe = "lila") Then
            Button2.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button2_Vordergrundfarbe = "blau") Then
            Button2.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button2_Vordergrundfarbe = "weiß") Then
            Button2.ForeColor = Color.White
        End If

        If (My.Settings.Button3_Vordergrundfarbe = "grün") Then
            Button3.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button3_Vordergrundfarbe = "rot") Then
            Button3.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button3_Vordergrundfarbe = "schwarz") Then
            Button3.ForeColor = Color.Black
        ElseIf (My.Settings.Button3_Vordergrundfarbe = "lila") Then
            Button3.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button3_Vordergrundfarbe = "blau") Then
            Button3.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button3_Vordergrundfarbe = "weiß") Then
            Button3.ForeColor = Color.White
        End If

        If (My.Settings.Button4_Vordergrundfarbe = "grün") Then
            Button4.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button4_Vordergrundfarbe = "rot") Then
            Button4.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button4_Vordergrundfarbe = "schwarz") Then
            Button4.ForeColor = Color.Black
        ElseIf (My.Settings.Button4_Vordergrundfarbe = "lila") Then
            Button4.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button4_Vordergrundfarbe = "blau") Then
            Button4.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button4_Vordergrundfarbe = "weiß") Then
            Button4.ForeColor = Color.White
        End If

        If (My.Settings.Button5_Vordergrundfarbe = "grün") Then
            Button5.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button5_Vordergrundfarbe = "rot") Then
            Button5.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button5_Vordergrundfarbe = "schwarz") Then
            Button5.ForeColor = Color.Black
        ElseIf (My.Settings.Button5_Vordergrundfarbe = "lila") Then
            Button5.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button5_Vordergrundfarbe = "blau") Then
            Button5.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button5_Vordergrundfarbe = "weiß") Then
            Button5.ForeColor = Color.White
        End If

        If (My.Settings.Button6_Vordergrundfarbe = "grün") Then
            Button6.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button6_Vordergrundfarbe = "rot") Then
            Button6.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button6_Vordergrundfarbe = "schwarz") Then
            Button6.ForeColor = Color.Black
        ElseIf (My.Settings.Button6_Vordergrundfarbe = "lila") Then
            Button6.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button6_Vordergrundfarbe = "blau") Then
            Button6.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button6_Vordergrundfarbe = "weiß") Then
            Button6.ForeColor = Color.White
        End If

        If (My.Settings.Button7_Vordergrundfarbe = "grün") Then
            Button7.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button7_Vordergrundfarbe = "rot") Then
            Button7.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button7_Vordergrundfarbe = "schwarz") Then
            Button7.ForeColor = Color.Black
        ElseIf (My.Settings.Button7_Vordergrundfarbe = "lila") Then
            Button7.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button7_Vordergrundfarbe = "blau") Then
            Button7.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button7_Vordergrundfarbe = "weiß") Then
            Button7.ForeColor = Color.White
        End If

        If (My.Settings.Button8_Vordergrundfarbe = "grün") Then
            Button8.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button8_Vordergrundfarbe = "rot") Then
            Button8.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button8_Vordergrundfarbe = "schwarz") Then
            Button8.ForeColor = Color.Black
        ElseIf (My.Settings.Button8_Vordergrundfarbe = "lila") Then
            Button8.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button8_Vordergrundfarbe = "blau") Then
            Button8.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button8_Vordergrundfarbe = "weiß") Then
            Button8.ForeColor = Color.White
        End If

        If (My.Settings.Button9_Vordergrundfarbe = "grün") Then
            Button9.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button9_Vordergrundfarbe = "rot") Then
            Button9.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button9_Vordergrundfarbe = "schwarz") Then
            Button9.ForeColor = Color.Black
        ElseIf (My.Settings.Button9_Vordergrundfarbe = "lila") Then
            Button9.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button9_Vordergrundfarbe = "blau") Then
            Button9.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button9_Vordergrundfarbe = "weiß") Then
            Button9.ForeColor = Color.White
        End If

        If (My.Settings.Button10_Vordergrundfarbe = "grün") Then
            Button10.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button10_Vordergrundfarbe = "rot") Then
            Button10.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button10_Vordergrundfarbe = "schwarz") Then
            Button10.ForeColor = Color.Black
        ElseIf (My.Settings.Button10_Vordergrundfarbe = "lila") Then
            Button10.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button10_Vordergrundfarbe = "blau") Then
            Button10.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button10_Vordergrundfarbe = "weiß") Then
            Button10.ForeColor = Color.White
        End If

        If (My.Settings.Button11_Vordergrundfarbe = "grün") Then
            Button11.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button11_Vordergrundfarbe = "rot") Then
            Button11.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button11_Vordergrundfarbe = "schwarz") Then
            Button11.ForeColor = Color.Black
        ElseIf (My.Settings.Button11_Vordergrundfarbe = "lila") Then
            Button11.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button11_Vordergrundfarbe = "blau") Then
            Button11.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button11_Vordergrundfarbe = "weiß") Then
            Button11.ForeColor = Color.White
        End If

        If (My.Settings.Button12_Vordergrundfarbe = "grün") Then
            Button12.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button12_Vordergrundfarbe = "rot") Then
            Button12.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button12_Vordergrundfarbe = "schwarz") Then
            Button12.ForeColor = Color.Black
        ElseIf (My.Settings.Button12_Vordergrundfarbe = "lila") Then
            Button12.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button12_Vordergrundfarbe = "blau") Then
            Button12.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button12_Vordergrundfarbe = "weiß") Then
            Button12.ForeColor = Color.White
        End If

        If (My.Settings.Button13_Vordergrundfarbe = "grün") Then
            Button13.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button13_Vordergrundfarbe = "rot") Then
            Button13.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button13_Vordergrundfarbe = "schwarz") Then
            Button13.ForeColor = Color.Black
        ElseIf (My.Settings.Button13_Vordergrundfarbe = "lila") Then
            Button13.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button13_Vordergrundfarbe = "blau") Then
            Button13.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button13_Vordergrundfarbe = "weiß") Then
            Button13.ForeColor = Color.White
        End If

        If (My.Settings.Button14_Vordergrundfarbe = "grün") Then
            Button14.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button14_Vordergrundfarbe = "rot") Then
            Button14.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button14_Vordergrundfarbe = "schwarz") Then
            Button14.ForeColor = Color.Black
        ElseIf (My.Settings.Button14_Vordergrundfarbe = "lila") Then
            Button14.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button14_Vordergrundfarbe = "blau") Then
            Button14.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button14_Vordergrundfarbe = "weiß") Then
            Button14.ForeColor = Color.White
        End If

        If (My.Settings.Button15_Vordergrundfarbe = "grün") Then
            Button15.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button15_Vordergrundfarbe = "rot") Then
            Button15.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button15_Vordergrundfarbe = "schwarz") Then
            Button15.ForeColor = Color.Black
        ElseIf (My.Settings.Button15_Vordergrundfarbe = "lila") Then
            Button15.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button15_Vordergrundfarbe = "blau") Then
            Button15.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button15_Vordergrundfarbe = "weiß") Then
            Button15.ForeColor = Color.White
        End If

        If (My.Settings.Button16_Vordergrundfarbe = "grün") Then
            Button16.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button16_Vordergrundfarbe = "rot") Then
            Button16.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button16_Vordergrundfarbe = "schwarz") Then
            Button16.ForeColor = Color.Black
        ElseIf (My.Settings.Button16_Vordergrundfarbe = "lila") Then
            Button16.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button16_Vordergrundfarbe = "blau") Then
            Button16.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button16_Vordergrundfarbe = "weiß") Then
            Button16.ForeColor = Color.White
        End If

        If (My.Settings.Button17_Vordergrundfarbe = "grün") Then
            Button17.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button17_Vordergrundfarbe = "rot") Then
            Button17.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button17_Vordergrundfarbe = "schwarz") Then
            Button17.ForeColor = Color.Black
        ElseIf (My.Settings.Button17_Vordergrundfarbe = "lila") Then
            Button17.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button17_Vordergrundfarbe = "blau") Then
            Button17.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button17_Vordergrundfarbe = "weiß") Then
            Button17.ForeColor = Color.White
        End If

        If (My.Settings.Button18_Vordergrundfarbe = "grün") Then
            Button18.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button18_Vordergrundfarbe = "rot") Then
            Button18.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button18_Vordergrundfarbe = "schwarz") Then
            Button18.ForeColor = Color.Black
        ElseIf (My.Settings.Button18_Vordergrundfarbe = "lila") Then
            Button18.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button18_Vordergrundfarbe = "blau") Then
            Button18.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button18_Vordergrundfarbe = "weiß") Then
            Button18.ForeColor = Color.White
        End If

        If (My.Settings.Button19_Vordergrundfarbe = "grün") Then
            Button19.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button19_Vordergrundfarbe = "rot") Then
            Button19.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button19_Vordergrundfarbe = "schwarz") Then
            Button19.ForeColor = Color.Black
        ElseIf (My.Settings.Button19_Vordergrundfarbe = "lila") Then
            Button19.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button19_Vordergrundfarbe = "blau") Then
            Button19.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button19_Vordergrundfarbe = "weiß") Then
            Button19.ForeColor = Color.White
        End If

        If (My.Settings.Button20_Vordergrundfarbe = "grün") Then
            Button20.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button20_Vordergrundfarbe = "rot") Then
            Button20.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button20_Vordergrundfarbe = "schwarz") Then
            Button20.ForeColor = Color.Black
        ElseIf (My.Settings.Button20_Vordergrundfarbe = "lila") Then
            Button20.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button20_Vordergrundfarbe = "blau") Then
            Button20.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button20_Vordergrundfarbe = "weiß") Then
            Button20.ForeColor = Color.White
        End If

        If (My.Settings.Button21_Vordergrundfarbe = "grün") Then
            Button21.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button21_Vordergrundfarbe = "rot") Then
            Button21.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button21_Vordergrundfarbe = "schwarz") Then
            Button21.ForeColor = Color.Black
        ElseIf (My.Settings.Button21_Vordergrundfarbe = "lila") Then
            Button21.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button21_Vordergrundfarbe = "blau") Then
            Button21.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button21_Vordergrundfarbe = "weiß") Then
            Button21.ForeColor = Color.White
        End If

        If (My.Settings.Button22_Vordergrundfarbe = "grün") Then
            Button22.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button22_Vordergrundfarbe = "rot") Then
            Button22.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button22_Vordergrundfarbe = "schwarz") Then
            Button22.ForeColor = Color.Black
        ElseIf (My.Settings.Button22_Vordergrundfarbe = "lila") Then
            Button22.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button22_Vordergrundfarbe = "blau") Then
            Button22.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button22_Vordergrundfarbe = "weiß") Then
            Button22.ForeColor = Color.White
        End If

        If (My.Settings.Button23_Vordergrundfarbe = "grün") Then
            Button23.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button23_Vordergrundfarbe = "rot") Then
            Button23.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button23_Vordergrundfarbe = "schwarz") Then
            Button23.ForeColor = Color.Black
        ElseIf (My.Settings.Button23_Vordergrundfarbe = "lila") Then
            Button23.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button23_Vordergrundfarbe = "blau") Then
            Button23.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button23_Vordergrundfarbe = "weiß") Then
            Button23.ForeColor = Color.White
        End If

        If (My.Settings.Button24_Vordergrundfarbe = "grün") Then
            Button24.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button24_Vordergrundfarbe = "rot") Then
            Button24.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button24_Vordergrundfarbe = "schwarz") Then
            Button24.ForeColor = Color.Black
        ElseIf (My.Settings.Button24_Vordergrundfarbe = "lila") Then
            Button24.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button24_Vordergrundfarbe = "blau") Then
            Button24.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button24_Vordergrundfarbe = "weiß") Then
            Button24.ForeColor = Color.White
        End If

        If (My.Settings.Button25_Vordergrundfarbe = "grün") Then
            Button25.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button25_Vordergrundfarbe = "rot") Then
            Button25.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button25_Vordergrundfarbe = "schwarz") Then
            Button25.ForeColor = Color.Black
        ElseIf (My.Settings.Button25_Vordergrundfarbe = "lila") Then
            Button25.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button25_Vordergrundfarbe = "blau") Then
            Button25.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button25_Vordergrundfarbe = "weiß") Then
            Button25.ForeColor = Color.White
        End If

        If (My.Settings.Button26_Vordergrundfarbe = "grün") Then
            Button26.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button26_Vordergrundfarbe = "rot") Then
            Button26.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button26_Vordergrundfarbe = "schwarz") Then
            Button26.ForeColor = Color.Black
        ElseIf (My.Settings.Button26_Vordergrundfarbe = "lila") Then
            Button26.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button26_Vordergrundfarbe = "blau") Then
            Button26.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button26_Vordergrundfarbe = "weiß") Then
            Button26.ForeColor = Color.White
        End If

        If (My.Settings.Button27_Vordergrundfarbe = "grün") Then
            Button27.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button27_Vordergrundfarbe = "rot") Then
            Button27.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button27_Vordergrundfarbe = "schwarz") Then
            Button27.ForeColor = Color.Black
        ElseIf (My.Settings.Button27_Vordergrundfarbe = "lila") Then
            Button27.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button27_Vordergrundfarbe = "blau") Then
            Button27.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button27_Vordergrundfarbe = "weiß") Then
            Button27.ForeColor = Color.White
        End If

        If (My.Settings.Button28_Vordergrundfarbe = "grün") Then
            Button28.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button28_Vordergrundfarbe = "rot") Then
            Button28.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button28_Vordergrundfarbe = "schwarz") Then
            Button28.ForeColor = Color.Black
        ElseIf (My.Settings.Button28_Vordergrundfarbe = "lila") Then
            Button28.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button28_Vordergrundfarbe = "blau") Then
            Button28.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button28_Vordergrundfarbe = "weiß") Then
            Button28.ForeColor = Color.White
        End If

        If (My.Settings.Button29_Vordergrundfarbe = "grün") Then
            Button29.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button29_Vordergrundfarbe = "rot") Then
            Button29.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button29_Vordergrundfarbe = "schwarz") Then
            Button29.ForeColor = Color.Black
        ElseIf (My.Settings.Button29_Vordergrundfarbe = "lila") Then
            Button29.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button29_Vordergrundfarbe = "blau") Then
            Button29.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button29_Vordergrundfarbe = "weiß") Then
            Button29.ForeColor = Color.White
        End If

        If (My.Settings.Button30_Vordergrundfarbe = "grün") Then
            Button30.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button30_Vordergrundfarbe = "rot") Then
            Button30.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button30_Vordergrundfarbe = "schwarz") Then
            Button30.ForeColor = Color.Black
        ElseIf (My.Settings.Button30_Vordergrundfarbe = "lila") Then
            Button30.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button30_Vordergrundfarbe = "blau") Then
            Button30.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button30_Vordergrundfarbe = "weiß") Then
            Button30.ForeColor = Color.White
        End If

        If (My.Settings.Button31_Vordergrundfarbe = "grün") Then
            Button31.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button31_Vordergrundfarbe = "rot") Then
            Button31.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button31_Vordergrundfarbe = "schwarz") Then
            Button31.ForeColor = Color.Black
        ElseIf (My.Settings.Button31_Vordergrundfarbe = "lila") Then
            Button31.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button31_Vordergrundfarbe = "blau") Then
            Button31.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button31_Vordergrundfarbe = "weiß") Then
            Button31.ForeColor = Color.White
        End If

        If (My.Settings.Button32_Vordergrundfarbe = "grün") Then
            Button32.ForeColor = Color.FromArgb(0, 192, 0)
        ElseIf (My.Settings.Button32_Vordergrundfarbe = "rot") Then
            Button32.ForeColor = Color.FromArgb(192, 0, 0)
        ElseIf (My.Settings.Button32_Vordergrundfarbe = "schwarz") Then
            Button32.ForeColor = Color.Black
        ElseIf (My.Settings.Button32_Vordergrundfarbe = "lila") Then
            Button32.ForeColor = Color.FromArgb(192, 0, 192)
        ElseIf (My.Settings.Button32_Vordergrundfarbe = "blau") Then
            Button32.ForeColor = Color.FromArgb(0, 0, 192)
        ElseIf (My.Settings.Button32_Vordergrundfarbe = "weiß") Then
            Button32.ForeColor = Color.White
        End If

        'Text
        Button1.Text = My.Settings.Button1_Text
        Button2.Text = My.Settings.Button2_Text
        Button3.Text = My.Settings.Button3_Text
        Button4.Text = My.Settings.Button4_Text
        Button5.Text = My.Settings.Button5_Text
        Button6.Text = My.Settings.Button6_Text
        Button7.Text = My.Settings.Button7_Text
        Button8.Text = My.Settings.Button8_Text
        Button9.Text = My.Settings.Button9_Text
        Button10.Text = My.Settings.Button10_Text
        Button11.Text = My.Settings.Button11_Text
        Button12.Text = My.Settings.Button12_Text
        Button13.Text = My.Settings.Button13_Text
        Button14.Text = My.Settings.Button14_Text
        Button15.Text = My.Settings.Button15_Text
        Button16.Text = My.Settings.Button16_Text
        Button17.Text = My.Settings.Button17_Text
        Button18.Text = My.Settings.Button18_Text
        Button19.Text = My.Settings.Button19_Text
        Button20.Text = My.Settings.Button20_Text
        Button21.Text = My.Settings.Button21_Text
        Button22.Text = My.Settings.Button22_Text
        Button23.Text = My.Settings.Button23_Text
        Button24.Text = My.Settings.Button24_Text
        Button25.Text = My.Settings.Button25_Text
        Button26.Text = My.Settings.Button26_Text
        Button27.Text = My.Settings.Button27_Text
        Button28.Text = My.Settings.Button28_Text
        Button29.Text = My.Settings.Button29_Text
        Button30.Text = My.Settings.Button30_Text
        Button31.Text = My.Settings.Button31_Text
        Button32.Text = My.Settings.Button32_Text
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
    Private Sub Bearbeiten1_Click(sender As Object, e As EventArgs) Handles Bearbeiten1.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 1"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten2_Click(sender As Object, e As EventArgs) Handles Bearbeiten2.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 2"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten3_Click(sender As Object, e As EventArgs) Handles Bearbeiten3.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 3"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten4_Click(sender As Object, e As EventArgs) Handles Bearbeiten4.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 4"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten5_Click(sender As Object, e As EventArgs) Handles Bearbeiten5.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 5"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten6_Click(sender As Object, e As EventArgs) Handles Bearbeiten6.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 6"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten7_Click(sender As Object, e As EventArgs) Handles Bearbeiten7.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 7"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten8_Click(sender As Object, e As EventArgs) Handles Bearbeiten8.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 8"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten9_Click(sender As Object, e As EventArgs) Handles Bearbeiten9.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 9"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten10_Click(sender As Object, e As EventArgs) Handles Bearbeiten10.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 10"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten11_Click(sender As Object, e As EventArgs) Handles Bearbeiten11.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 11"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten12_Click(sender As Object, e As EventArgs) Handles Bearbeiten12.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 12"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten13_Click(sender As Object, e As EventArgs) Handles Bearbeiten13.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 13"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten14_Click(sender As Object, e As EventArgs) Handles Bearbeiten14.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 14"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten15_Click(sender As Object, e As EventArgs) Handles Bearbeiten15.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 15"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten16_Click(sender As Object, e As EventArgs) Handles Bearbeiten16.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 16"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten17_Click(sender As Object, e As EventArgs) Handles Bearbeiten17.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 17"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten18_Click(sender As Object, e As EventArgs) Handles Bearbeiten18.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 18"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten19_Click(sender As Object, e As EventArgs) Handles Bearbeiten19.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 19"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten20_Click(sender As Object, e As EventArgs) Handles Bearbeiten20.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 20"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten21_Click(sender As Object, e As EventArgs) Handles Bearbeiten21.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 21"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten22_Click(sender As Object, e As EventArgs) Handles Bearbeiten22.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 22"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten23_Click(sender As Object, e As EventArgs) Handles Bearbeiten23.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 23"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten24_Click(sender As Object, e As EventArgs) Handles Bearbeiten24.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 24"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten25_Click(sender As Object, e As EventArgs) Handles Bearbeiten25.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 25"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten26_Click(sender As Object, e As EventArgs) Handles Bearbeiten26.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 26"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten27_Click(sender As Object, e As EventArgs) Handles Bearbeiten27.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 27"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten28_Click(sender As Object, e As EventArgs) Handles Bearbeiten28.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 28"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten29_Click(sender As Object, e As EventArgs) Handles Bearbeiten29.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 29"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten30_Click(sender As Object, e As EventArgs) Handles Bearbeiten30.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 30"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten31_Click(sender As Object, e As EventArgs) Handles Bearbeiten31.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 31"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Bearbeiten32_Click(sender As Object, e As EventArgs) Handles Bearbeiten32.Click
        ButtonsBearbeiten.AusgewählterButton_lbl.Text = "Button 32"
        ButtonsBearbeiten.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (My.Settings.Button1_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button1_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (My.Settings.Button2_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button2_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (My.Settings.Button3_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button3_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (My.Settings.Button4_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button4_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (My.Settings.Button5_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button5_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (My.Settings.Button6_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button6_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (My.Settings.Button7_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button7_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (My.Settings.Button8_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button8_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (My.Settings.Button9_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button9_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (My.Settings.Button10_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button10_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (My.Settings.Button11_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button11_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If (My.Settings.Button12_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button12_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (My.Settings.Button13_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button13_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (My.Settings.Button14_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button14_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (My.Settings.Button15_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button15_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (My.Settings.Button16_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button16_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (My.Settings.Button17_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button17_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If (My.Settings.Button18_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button18_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If (My.Settings.Button19_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button19_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If (My.Settings.Button20_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button20_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If (My.Settings.Button21_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button21_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If (My.Settings.Button22_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button22_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If (My.Settings.Button23_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button23_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If (My.Settings.Button24_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button24_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If (My.Settings.Button25_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button25_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If (My.Settings.Button26_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button26_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If (My.Settings.Button27_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button27_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If (My.Settings.Button28_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button28_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If (My.Settings.Button29_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button29_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If (My.Settings.Button30_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button30_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If (My.Settings.Button31_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button31_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If (My.Settings.Button32_Link = "") Then
            MsgBox("Es ist kein Link für diesen Button angegeben!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(My.Settings.Button32_Link)
            Catch ex As Exception
                MsgBox("Der angegebene Link konnte nicht ausgeführt werden!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub AktivierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AktivierenToolStripMenuItem.Click
        'Darkmode aktivieren
        DarkmodeAktivieren()
    End Sub

    Private Sub DeaktivierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeaktivierenToolStripMenuItem.Click
        'Darkmode deaktivieren
        DarkmodeDeaktivieren()
    End Sub

    Public Sub DarkmodeAktivieren()
        Me.BackColor = Color.Gray
        MenuStrip1.BackColor = Color.Gray
        DarkmodeToolStripMenuItem.BackColor = Color.Gray
        AktivierenToolStripMenuItem.BackColor = Color.Gray
        DeaktivierenToolStripMenuItem.BackColor = Color.Gray

        ButtonsBearbeiten.BackColor = Color.Silver

        My.Settings.Einstellungen_DarkLightmode = "Darkmode"
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Public Sub DarkmodeDeaktivieren()
        Me.BackColor = Color.FromArgb(224, 224, 224)
        MenuStrip1.BackColor = Color.FromArgb(224, 224, 224)
        DarkmodeToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224)
        AktivierenToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224)
        DeaktivierenToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224)

        ButtonsBearbeiten.BackColor = Color.White

        My.Settings.Einstellungen_DarkLightmode = "Lightmode"
        My.Settings.Save()
        My.Settings.Reload()
    End Sub
End Class
