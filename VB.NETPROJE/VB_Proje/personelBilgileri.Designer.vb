<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class personelBilgileri
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cb_personel = New System.Windows.Forms.ComboBox()
        Me.lbl_personel = New System.Windows.Forms.Label()
        Me.gb_gorevBilgileri = New System.Windows.Forms.GroupBox()
        Me.lbl_aktifGorev = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbl_bitenGorevSayisi = New System.Windows.Forms.Label()
        Me.lbl_bitenGorev = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.gb_gorevBilgileri.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_personel
        '
        Me.cb_personel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_personel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cb_personel.FormattingEnabled = True
        Me.cb_personel.Location = New System.Drawing.Point(117, 25)
        Me.cb_personel.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_personel.Name = "cb_personel"
        Me.cb_personel.Size = New System.Drawing.Size(160, 28)
        Me.cb_personel.TabIndex = 1
        '
        'lbl_personel
        '
        Me.lbl_personel.AutoSize = True
        Me.lbl_personel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_personel.Location = New System.Drawing.Point(20, 28)
        Me.lbl_personel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_personel.Name = "lbl_personel"
        Me.lbl_personel.Size = New System.Drawing.Size(85, 20)
        Me.lbl_personel.TabIndex = 1
        Me.lbl_personel.Text = "Personel :"
        '
        'gb_gorevBilgileri
        '
        Me.gb_gorevBilgileri.Controls.Add(Me.lbl_aktifGorev)
        Me.gb_gorevBilgileri.Controls.Add(Me.ListBox1)
        Me.gb_gorevBilgileri.Controls.Add(Me.lbl_bitenGorevSayisi)
        Me.gb_gorevBilgileri.Controls.Add(Me.lbl_bitenGorev)
        Me.gb_gorevBilgileri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gb_gorevBilgileri.Location = New System.Drawing.Point(24, 159)
        Me.gb_gorevBilgileri.Margin = New System.Windows.Forms.Padding(4)
        Me.gb_gorevBilgileri.Name = "gb_gorevBilgileri"
        Me.gb_gorevBilgileri.Padding = New System.Windows.Forms.Padding(4)
        Me.gb_gorevBilgileri.Size = New System.Drawing.Size(452, 373)
        Me.gb_gorevBilgileri.TabIndex = 0
        Me.gb_gorevBilgileri.TabStop = False
        Me.gb_gorevBilgileri.Text = "Görev Bilgileri"
        '
        'lbl_aktifGorev
        '
        Me.lbl_aktifGorev.AutoSize = True
        Me.lbl_aktifGorev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_aktifGorev.Location = New System.Drawing.Point(8, 78)
        Me.lbl_aktifGorev.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_aktifGorev.Name = "lbl_aktifGorev"
        Me.lbl_aktifGorev.Size = New System.Drawing.Size(111, 20)
        Me.lbl_aktifGorev.TabIndex = 0
        Me.lbl_aktifGorev.Text = "Aktif Görevler"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Aktif Görev Adı - Bitiş Tarihi", "Aktif Görev Adı - Bitiş Tarihi", "Aktif Görev Adı - Bitiş Tarihi", "Aktif Görev Adı - Bitiş Tarihi"})
        Me.ListBox1.Location = New System.Drawing.Point(8, 102)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(432, 244)
        Me.ListBox1.TabIndex = 0
        '
        'lbl_bitenGorevSayisi
        '
        Me.lbl_bitenGorevSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_bitenGorevSayisi.Location = New System.Drawing.Point(197, 36)
        Me.lbl_bitenGorevSayisi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_bitenGorevSayisi.Name = "lbl_bitenGorevSayisi"
        Me.lbl_bitenGorevSayisi.Size = New System.Drawing.Size(57, 20)
        Me.lbl_bitenGorevSayisi.TabIndex = 0
        Me.lbl_bitenGorevSayisi.Text = "100"
        '
        'lbl_bitenGorev
        '
        Me.lbl_bitenGorev.AutoSize = True
        Me.lbl_bitenGorev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_bitenGorev.Location = New System.Drawing.Point(7, 36)
        Me.lbl_bitenGorev.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_bitenGorev.Name = "lbl_bitenGorev"
        Me.lbl_bitenGorev.Size = New System.Drawing.Size(176, 20)
        Me.lbl_bitenGorev.TabIndex = 0
        Me.lbl_bitenGorev.Text = "Bitirilen Görev Sayısı :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(327, 540)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Rapor Oluştur"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tarih"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(407, 30)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(57, 21)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Gün"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(407, 63)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(64, 21)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Hafta"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(407, 90)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(46, 21)
        Me.CheckBox3.TabIndex = 8
        Me.CheckBox3.Text = "Ay"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'personelBilgileri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(503, 604)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gb_gorevBilgileri)
        Me.Controls.Add(Me.lbl_personel)
        Me.Controls.Add(Me.cb_personel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "personelBilgileri"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personel Bilgileri"
        Me.gb_gorevBilgileri.ResumeLayout(False)
        Me.gb_gorevBilgileri.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_personel As ComboBox
    Friend WithEvents lbl_personel As Label
    Friend WithEvents gb_gorevBilgileri As GroupBox
    Friend WithEvents lbl_bitenGorevSayisi As Label
    Friend WithEvents lbl_bitenGorev As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_aktifGorev As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
End Class
