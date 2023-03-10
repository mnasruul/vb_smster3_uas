<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGuru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvguru = New System.Windows.Forms.DataGridView()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BersihBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbidangstudi = New System.Windows.Forms.ComboBox()
        Me.cjabatan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tnohp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.talamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tjurusan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tnuptk = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvguru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvguru
        '
        Me.dgvguru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvguru.Location = New System.Drawing.Point(8, 330)
        Me.dgvguru.Name = "dgvguru"
        Me.dgvguru.Size = New System.Drawing.Size(516, 162)
        Me.dgvguru.TabIndex = 25
        '
        'TutupBtn
        '
        Me.TutupBtn.Location = New System.Drawing.Point(424, 19)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(75, 23)
        Me.TutupBtn.TabIndex = 14
        Me.TutupBtn.Text = "TUTUP"
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'BersihBtn
        '
        Me.BersihBtn.Location = New System.Drawing.Point(316, 19)
        Me.BersihBtn.Name = "BersihBtn"
        Me.BersihBtn.Size = New System.Drawing.Size(75, 23)
        Me.BersihBtn.TabIndex = 12
        Me.BersihBtn.Text = "BERSIH"
        Me.BersihBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(214, 19)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.HapusBtn.TabIndex = 10
        Me.HapusBtn.Text = "HAPUS"
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TutupBtn)
        Me.GroupBox2.Controls.Add(Me.BersihBtn)
        Me.GroupBox2.Controls.Add(Me.HapusBtn)
        Me.GroupBox2.Controls.Add(Me.UbahBtn)
        Me.GroupBox2.Controls.Add(Me.SimpanBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 270)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 54)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'UbahBtn
        '
        Me.UbahBtn.Location = New System.Drawing.Point(106, 19)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(75, 23)
        Me.UbahBtn.TabIndex = 9
        Me.UbahBtn.Text = "UBAH"
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Location = New System.Drawing.Point(6, 19)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(75, 23)
        Me.SimpanBtn.TabIndex = 8
        Me.SimpanBtn.Text = "SIMPAN"
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbidangstudi)
        Me.GroupBox1.Controls.Add(Me.cjabatan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tnohp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.talamat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tjurusan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tnama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tnuptk)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 265)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'cbidangstudi
        '
        Me.cbidangstudi.FormattingEnabled = True
        Me.cbidangstudi.Location = New System.Drawing.Point(199, 124)
        Me.cbidangstudi.Name = "cbidangstudi"
        Me.cbidangstudi.Size = New System.Drawing.Size(192, 21)
        Me.cbidangstudi.TabIndex = 3
        '
        'cjabatan
        '
        Me.cjabatan.FormattingEnabled = True
        Me.cjabatan.Location = New System.Drawing.Point(199, 161)
        Me.cjabatan.Name = "cjabatan"
        Me.cjabatan.Size = New System.Drawing.Size(192, 21)
        Me.cjabatan.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUPTK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA GURU"
        '
        'tnohp
        '
        Me.tnohp.Location = New System.Drawing.Point(199, 224)
        Me.tnohp.Name = "tnohp"
        Me.tnohp.Size = New System.Drawing.Size(192, 20)
        Me.tnohp.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JURUSAN"
        '
        'talamat
        '
        Me.talamat.Location = New System.Drawing.Point(199, 190)
        Me.talamat.Name = "talamat"
        Me.talamat.Size = New System.Drawing.Size(192, 20)
        Me.talamat.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "GURU BIDANG STUDI"
        '
        'tjurusan
        '
        Me.tjurusan.Location = New System.Drawing.Point(199, 86)
        Me.tjurusan.Name = "tjurusan"
        Me.tjurusan.Size = New System.Drawing.Size(192, 20)
        Me.tjurusan.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "JABATAN"
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(199, 48)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(192, 20)
        Me.tnama.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ALAMAT"
        '
        'tnuptk
        '
        Me.tnuptk.Location = New System.Drawing.Point(199, 19)
        Me.tnuptk.Name = "tnuptk"
        Me.tnuptk.Size = New System.Drawing.Size(192, 20)
        Me.tnuptk.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "NO HP"
        '
        'FormGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 491)
        Me.Controls.Add(Me.dgvguru)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormGuru"
        Me.Text = "FormGuru"
        CType(Me.dgvguru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvguru As DataGridView
    Friend WithEvents TutupBtn As Button
    Friend WithEvents BersihBtn As Button
    Friend WithEvents HapusBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents UbahBtn As Button
    Friend WithEvents SimpanBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbidangstudi As ComboBox
    Friend WithEvents cjabatan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tnohp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents talamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tjurusan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tnama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tnuptk As TextBox
    Friend WithEvents Label7 As Label
End Class
