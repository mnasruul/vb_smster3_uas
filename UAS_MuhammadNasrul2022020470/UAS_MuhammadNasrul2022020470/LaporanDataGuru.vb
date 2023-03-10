Public Class LaporanDataGuru
    Private Sub LaporanDataGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filter As String = ""
        Laporan.Text = "Laporan"
        Laporan.CrystalReportViewer1.ReportSource = Nothing
        Laporan.CrystalReportViewer1.RefreshReport()
        Laporan.CrystalReportViewer1.SelectionFormula = "{guru.guru_bidang_studi}='" & cbidangstudi.Text & "'"
        Laporan.CrystalReportViewer1.ReportSource = "D:\KULIAH\SEMESTER 3\VB\UAS\UAS_MuhammadNasrul2022020470\UAS_MuhammadNasrul2022020470\laporanDataguruBidang.rpt"
        Laporan.WindowState = FormWindowState.Maximized
        Laporan.Show()
    End Sub
End Class