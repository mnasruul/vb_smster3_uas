Public Class FormGuru
    Dim sql As String
    Dim proses As New koneksi
    Dim guru As DataTable
    Sub data_record()
        guru = proses.executequery("select * from guru order by nuptk asc")
        dgvguru.DataSource = guru
    End Sub
    Sub bersih()
        tnuptk.Text = ""
        tnama.Text = ""
        tjurusan.Text = ""
        cbidangstudi.Text = ""
        cjabatan.Text = ""
        talamat.Text = ""
        tnohp.Text = ""

        tnuptk.Focus()

        Call data_record()
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        If tnuptk.Text = "" Or tnama.Text = "" Or tjurusan.Text = "" Or cbidangstudi.Text = "" Or cjabatan.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            guru = proses.executequery("select * from guru where nuptk='" & tnuptk.Text & "'")
            If guru.Rows.Count = 0 Then
                sql = "insert into guru values ('" & tnuptk.Text & "','" & tnuptk.Text & "','" & tjurusan.Text & "','" & cbidangstudi.Text & "','" & cjabatan.Text & "','" & talamat.Text & "','" & tnohp.Text & "')"
                proses.executenonquery(sql)
                MessageBox.Show("data telah disimpan..!!", "penyimpanan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("data sudah ada")
            End If
        End If
        Call bersih()
    End Sub
    Sub AturSimpan()
        HapusBtn.Enabled = False
        UbahBtn.Enabled = False
        SimpanBtn.Enabled = True
        tnuptk.Enabled = True
    End Sub
    Sub AturHapusEdit()
        SimpanBtn.Enabled = False
        HapusBtn.Enabled = True
        UbahBtn.Enabled = True
        tnuptk.Enabled = False
    End Sub

    Private Sub UbahBtn_Click(sender As Object, e As EventArgs) Handles UbahBtn.Click
        If MsgBox("Apakah Anda Yakin Ingin Mengedit Data guru??", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            sql = "update guru set nama_guru='" & tnama.Text & "' ,jurusan='" & tjurusan.Text & "' ,guru_bidang_studi='" & cbidangstudi.Text & "' ,jabatan='" & cjabatan.Text & "' ,alamat='" & talamat.Text & "' ,no_hp='" & tnohp.Text & "' where  nuptk='" & tnuptk.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("Data telah Diedit..!!", "Pengeditan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Silahkan Pilih Data lain..!!", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        Call bersih()
        Call AturSimpan()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        If MsgBox("Apakah Anda Yakin Ingin Mengedit Data Guru??", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            sql = "delete from guru where  nuptk='" & tnuptk.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("Data telah dihapus..!!", "Pengeditan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Silahkan Pilih Data lain..!!", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Call bersih()
        Call AturSimpan()
    End Sub

    Private Sub BersihBtn_Click(sender As Object, e As EventArgs) Handles BersihBtn.Click
        Call bersih()
        Call AturSimpan()
    End Sub

    Private Sub TutupBtn_Click(sender As Object, e As EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub tnuptk_TextChanged(sender As Object, e As EventArgs) Handles tnuptk.TextChanged

    End Sub

    Private Sub tnuptk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnuptk.KeyPress
        If e.KeyChar = Chr(13) Then
            guru = proses.executequery("select * from guru where id='" & tnuptk.Text & "'")
            If guru.Rows.Count = 0 Then
                MessageBox.Show("Data Tidak Ada Dalam Database, Silahkan Inputkan Data..!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                With guru.Rows(0)
                    tnama.Text = .Item("nama_guru")
                    tjurusan.Text = .Item("jurusan")
                    cbidangstudi.Text = .Item("guru_bidang_studi")
                    cjabatan.Text = .Item("jabatan")
                    talamat.Text = .Item("alamat")
                    tnohp.Text = .Item("no_hp")
                End With
                Call AturHapusEdit()
            End If
        End If
    End Sub
End Class