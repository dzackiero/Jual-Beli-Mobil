Imports System.Reflection.PortableExecutable

Public Class EditPembeli

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextBox_editnik.Text = Pembeli.dataPembeli.GSnik
        TextBox_editnama.Text = Pembeli.dataPembeli.GSnama
        RichTextBox_editalamat.Text = Pembeli.dataPembeli.GSalamat
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        Try
            Pembeli.dataPembeli.GSnik = TextBox_editnik.Text
            Pembeli.dataPembeli.GSnama = TextBox_editnama.Text
            Pembeli.dataPembeli.GSalamat = RichTextBox_editalamat.Text

            Pembeli.dataPembeli.EditDataPembeliByIDDatabase(
                                                    Pembeli.dataPembeli.GSnik,
                                                    Pembeli.dataPembeli.GSnama,
                                                    Pembeli.dataPembeli.GSalamat
                                                    )

            MessageBox.Show("Berhsil Mengedit Pembeli")
            Close()

        Catch ex As Exception
            MessageBox.Show("Masukan data dengan sesuai.Error: " + ex.Message)
        End Try
    End Sub

    Private Sub OnlyNumberTextBox(sender As Object, e As KeyPressEventArgs) Handles TextBox_editnik.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            'Messagebox.Show("Hanya Menerima Angka")
        End If
    End Sub
End Class