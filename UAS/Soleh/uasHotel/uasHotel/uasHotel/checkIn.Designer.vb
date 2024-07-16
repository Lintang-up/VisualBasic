<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkIn
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbTipeMember = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.textIdTransaksi = New System.Windows.Forms.Label()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.btCheckIn = New System.Windows.Forms.Button()
        Me.btPlus2 = New System.Windows.Forms.Button()
        Me.btMin2 = New System.Windows.Forms.Button()
        Me.btPlus1 = New System.Windows.Forms.Button()
        Me.btMin1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teksUangMuka = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbJumlahAnak = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbJumlahDewasa = New System.Windows.Forms.TextBox()
        Me.tbJumlahHari = New System.Windows.Forms.TextBox()
        Me.tbUangMuka = New System.Windows.Forms.TextBox()
        Me.tbTotalKurang = New System.Windows.Forms.TextBox()
        Me.tbDiskonMember = New System.Windows.Forms.TextBox()
        Me.tbSubTotal = New System.Windows.Forms.TextBox()
        Me.tbDiskonInap = New System.Windows.Forms.TextBox()
        Me.tbTarifKamar = New System.Windows.Forms.TextBox()
        Me.tbTipeRuangan = New System.Windows.Forms.TextBox()
        Me.tbNoRuangan = New System.Windows.Forms.TextBox()
        Me.tbNamaTamu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvCheckIn = New System.Windows.Forms.DataGridView()
        Me.dgvIdTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNamaTamu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNomorRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTipeRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTarifRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTanggalCheckIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTanggalCheckOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvJumlahHari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvJumlahDewasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvJumlahAnak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDiskonInap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTipeMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDiskonMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvUangMuka = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTotalKurang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvCheckIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1159, 504)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbTipeMember)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.textIdTransaksi)
        Me.TabPage1.Controls.Add(Me.btClear)
        Me.TabPage1.Controls.Add(Me.btBatal)
        Me.TabPage1.Controls.Add(Me.btCheckIn)
        Me.TabPage1.Controls.Add(Me.btPlus2)
        Me.TabPage1.Controls.Add(Me.btMin2)
        Me.TabPage1.Controls.Add(Me.btPlus1)
        Me.TabPage1.Controls.Add(Me.btMin1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btLogin)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.teksUangMuka)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.tbJumlahAnak)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.tbJumlahDewasa)
        Me.TabPage1.Controls.Add(Me.tbJumlahHari)
        Me.TabPage1.Controls.Add(Me.tbUangMuka)
        Me.TabPage1.Controls.Add(Me.tbTotalKurang)
        Me.TabPage1.Controls.Add(Me.tbDiskonMember)
        Me.TabPage1.Controls.Add(Me.tbSubTotal)
        Me.TabPage1.Controls.Add(Me.tbDiskonInap)
        Me.TabPage1.Controls.Add(Me.tbTarifKamar)
        Me.TabPage1.Controls.Add(Me.tbTipeRuangan)
        Me.TabPage1.Controls.Add(Me.tbNoRuangan)
        Me.TabPage1.Controls.Add(Me.tbNamaTamu)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1151, 475)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Check In"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbTipeMember
        '
        Me.cbTipeMember.Enabled = False
        Me.cbTipeMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipeMember.FormattingEnabled = True
        Me.cbTipeMember.Items.AddRange(New Object() {"Tidak Ada", "Premium", "VIP"})
        Me.cbTipeMember.Location = New System.Drawing.Point(836, 182)
        Me.cbTipeMember.Name = "cbTipeMember"
        Me.cbTipeMember.Size = New System.Drawing.Size(233, 28)
        Me.cbTipeMember.TabIndex = 54
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(864, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 17)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "ID Transaksi :"
        '
        'textIdTransaksi
        '
        Me.textIdTransaksi.AutoSize = True
        Me.textIdTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textIdTransaksi.ForeColor = System.Drawing.Color.Red
        Me.textIdTransaksi.Location = New System.Drawing.Point(979, 42)
        Me.textIdTransaksi.Name = "textIdTransaksi"
        Me.textIdTransaksi.Size = New System.Drawing.Size(95, 17)
        Me.textIdTransaksi.TabIndex = 52
        Me.textIdTransaksi.Text = "TransID-0001"
        '
        'btClear
        '
        Me.btClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClear.Location = New System.Drawing.Point(534, 407)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(110, 33)
        Me.btClear.TabIndex = 50
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBatal.Location = New System.Drawing.Point(418, 407)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(110, 33)
        Me.btBatal.TabIndex = 50
        Me.btBatal.Text = "Batal"
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'btCheckIn
        '
        Me.btCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCheckIn.Location = New System.Drawing.Point(650, 407)
        Me.btCheckIn.Name = "btCheckIn"
        Me.btCheckIn.Size = New System.Drawing.Size(110, 33)
        Me.btCheckIn.TabIndex = 51
        Me.btCheckIn.Text = "Check In"
        Me.btCheckIn.UseVisualStyleBackColor = True
        '
        'btPlus2
        '
        Me.btPlus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPlus2.Location = New System.Drawing.Point(997, 116)
        Me.btPlus2.Name = "btPlus2"
        Me.btPlus2.Size = New System.Drawing.Size(72, 27)
        Me.btPlus2.TabIndex = 48
        Me.btPlus2.Text = "+"
        Me.btPlus2.UseVisualStyleBackColor = True
        '
        'btMin2
        '
        Me.btMin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMin2.Location = New System.Drawing.Point(836, 116)
        Me.btMin2.Name = "btMin2"
        Me.btMin2.Size = New System.Drawing.Size(72, 27)
        Me.btMin2.TabIndex = 46
        Me.btMin2.Text = "-"
        Me.btMin2.UseVisualStyleBackColor = True
        '
        'btPlus1
        '
        Me.btPlus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPlus1.Location = New System.Drawing.Point(997, 83)
        Me.btPlus1.Name = "btPlus1"
        Me.btPlus1.Size = New System.Drawing.Size(72, 27)
        Me.btPlus1.TabIndex = 49
        Me.btPlus1.Text = "+"
        Me.btPlus1.UseVisualStyleBackColor = True
        '
        'btMin1
        '
        Me.btMin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMin1.Location = New System.Drawing.Point(836, 83)
        Me.btMin1.Name = "btMin1"
        Me.btMin1.Size = New System.Drawing.Size(72, 27)
        Me.btMin1.TabIndex = 47
        Me.btMin1.Text = "-"
        Me.btMin1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(486, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 27)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btLogin
        '
        Me.btLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogin.Location = New System.Drawing.Point(486, 83)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(72, 27)
        Me.btLogin.TabIndex = 45
        Me.btLogin.Text = "Cari"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dddd, dd MMM yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(231, 248)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(233, 24)
        Me.DateTimePicker2.TabIndex = 43
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dddd, dd MMM yyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(231, 215)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 24)
        Me.DateTimePicker1.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tgl Check Out"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(663, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 20)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Jumlah Anak"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(663, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Jumlah Dewasa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Jumlah Hari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Tgl Check In"
        '
        'teksUangMuka
        '
        Me.teksUangMuka.AutoSize = True
        Me.teksUangMuka.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teksUangMuka.ForeColor = System.Drawing.Color.Red
        Me.teksUangMuka.Location = New System.Drawing.Point(833, 312)
        Me.teksUangMuka.Name = "teksUangMuka"
        Me.teksUangMuka.Size = New System.Drawing.Size(205, 17)
        Me.teksUangMuka.TabIndex = 41
        Me.teksUangMuka.Text = "Uang Muka minimal Rp. 50.000"
        Me.teksUangMuka.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(663, 284)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 20)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Uang Muka"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(399, 377)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 20)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Total Kurang"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(663, 218)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(140, 20)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Diskon Member"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(663, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Sub Total"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(663, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 20)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Tipe Member"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(663, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 20)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Diskon Inap"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Tarif Kamar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Tipe Ruangan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nomor Ruangan"
        '
        'tbJumlahAnak
        '
        Me.tbJumlahAnak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJumlahAnak.Location = New System.Drawing.Point(914, 116)
        Me.tbJumlahAnak.Name = "tbJumlahAnak"
        Me.tbJumlahAnak.Size = New System.Drawing.Size(77, 27)
        Me.tbJumlahAnak.TabIndex = 20
        Me.tbJumlahAnak.Text = "0"
        Me.tbJumlahAnak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Nama Tamu"
        '
        'tbJumlahDewasa
        '
        Me.tbJumlahDewasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJumlahDewasa.Location = New System.Drawing.Point(914, 83)
        Me.tbJumlahDewasa.Name = "tbJumlahDewasa"
        Me.tbJumlahDewasa.Size = New System.Drawing.Size(77, 27)
        Me.tbJumlahDewasa.TabIndex = 21
        Me.tbJumlahDewasa.Text = "0"
        Me.tbJumlahDewasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbJumlahHari
        '
        Me.tbJumlahHari.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJumlahHari.Location = New System.Drawing.Point(231, 281)
        Me.tbJumlahHari.Name = "tbJumlahHari"
        Me.tbJumlahHari.Size = New System.Drawing.Size(233, 27)
        Me.tbJumlahHari.TabIndex = 19
        '
        'tbUangMuka
        '
        Me.tbUangMuka.BackColor = System.Drawing.Color.White
        Me.tbUangMuka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUangMuka.Location = New System.Drawing.Point(836, 282)
        Me.tbUangMuka.Name = "tbUangMuka"
        Me.tbUangMuka.ReadOnly = True
        Me.tbUangMuka.Size = New System.Drawing.Size(233, 27)
        Me.tbUangMuka.TabIndex = 17
        '
        'tbTotalKurang
        '
        Me.tbTotalKurang.BackColor = System.Drawing.Color.White
        Me.tbTotalKurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalKurang.ForeColor = System.Drawing.Color.Red
        Me.tbTotalKurang.Location = New System.Drawing.Point(548, 374)
        Me.tbTotalKurang.Name = "tbTotalKurang"
        Me.tbTotalKurang.ReadOnly = True
        Me.tbTotalKurang.Size = New System.Drawing.Size(233, 27)
        Me.tbTotalKurang.TabIndex = 18
        '
        'tbDiskonMember
        '
        Me.tbDiskonMember.BackColor = System.Drawing.Color.White
        Me.tbDiskonMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDiskonMember.Location = New System.Drawing.Point(836, 216)
        Me.tbDiskonMember.Name = "tbDiskonMember"
        Me.tbDiskonMember.ReadOnly = True
        Me.tbDiskonMember.Size = New System.Drawing.Size(233, 27)
        Me.tbDiskonMember.TabIndex = 22
        '
        'tbSubTotal
        '
        Me.tbSubTotal.BackColor = System.Drawing.Color.White
        Me.tbSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubTotal.Location = New System.Drawing.Point(836, 249)
        Me.tbSubTotal.Name = "tbSubTotal"
        Me.tbSubTotal.ReadOnly = True
        Me.tbSubTotal.Size = New System.Drawing.Size(233, 27)
        Me.tbSubTotal.TabIndex = 22
        '
        'tbDiskonInap
        '
        Me.tbDiskonInap.BackColor = System.Drawing.Color.White
        Me.tbDiskonInap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDiskonInap.Location = New System.Drawing.Point(836, 149)
        Me.tbDiskonInap.Name = "tbDiskonInap"
        Me.tbDiskonInap.ReadOnly = True
        Me.tbDiskonInap.Size = New System.Drawing.Size(233, 27)
        Me.tbDiskonInap.TabIndex = 26
        '
        'tbTarifKamar
        '
        Me.tbTarifKamar.BackColor = System.Drawing.Color.White
        Me.tbTarifKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTarifKamar.Location = New System.Drawing.Point(231, 182)
        Me.tbTarifKamar.Name = "tbTarifKamar"
        Me.tbTarifKamar.ReadOnly = True
        Me.tbTarifKamar.Size = New System.Drawing.Size(233, 27)
        Me.tbTarifKamar.TabIndex = 27
        '
        'tbTipeRuangan
        '
        Me.tbTipeRuangan.BackColor = System.Drawing.Color.White
        Me.tbTipeRuangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTipeRuangan.Location = New System.Drawing.Point(231, 149)
        Me.tbTipeRuangan.Name = "tbTipeRuangan"
        Me.tbTipeRuangan.ReadOnly = True
        Me.tbTipeRuangan.Size = New System.Drawing.Size(233, 27)
        Me.tbTipeRuangan.TabIndex = 25
        '
        'tbNoRuangan
        '
        Me.tbNoRuangan.BackColor = System.Drawing.Color.White
        Me.tbNoRuangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoRuangan.Location = New System.Drawing.Point(231, 116)
        Me.tbNoRuangan.Name = "tbNoRuangan"
        Me.tbNoRuangan.ReadOnly = True
        Me.tbNoRuangan.Size = New System.Drawing.Size(233, 27)
        Me.tbNoRuangan.TabIndex = 23
        '
        'tbNamaTamu
        '
        Me.tbNamaTamu.BackColor = System.Drawing.Color.White
        Me.tbNamaTamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaTamu.Location = New System.Drawing.Point(231, 83)
        Me.tbNamaTamu.Name = "tbNamaTamu"
        Me.tbNamaTamu.ReadOnly = True
        Me.tbNamaTamu.Size = New System.Drawing.Size(233, 27)
        Me.tbNamaTamu.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(518, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tamu Check In"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvCheckIn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1151, 475)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Check In List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvCheckIn
        '
        Me.dgvCheckIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheckIn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvIdTransaksi, Me.dgvNamaTamu, Me.dgvNomorRuangan, Me.dgvTipeRuangan, Me.dgvTarifRuangan, Me.dgvTanggalCheckIn, Me.dgvTanggalCheckOut, Me.dgvJumlahHari, Me.dgvJumlahDewasa, Me.dgvJumlahAnak, Me.dgvDiskonInap, Me.dgvTipeMember, Me.dgvDiskonMember, Me.dgvSubTotal, Me.dgvUangMuka, Me.dgvTotalKurang})
        Me.dgvCheckIn.Location = New System.Drawing.Point(6, 6)
        Me.dgvCheckIn.Name = "dgvCheckIn"
        Me.dgvCheckIn.RowHeadersVisible = False
        Me.dgvCheckIn.RowTemplate.Height = 24
        Me.dgvCheckIn.Size = New System.Drawing.Size(1139, 463)
        Me.dgvCheckIn.TabIndex = 0
        '
        'dgvIdTransaksi
        '
        Me.dgvIdTransaksi.HeaderText = "ID Transaksi"
        Me.dgvIdTransaksi.Name = "dgvIdTransaksi"
        Me.dgvIdTransaksi.Width = 103
        '
        'dgvNamaTamu
        '
        Me.dgvNamaTamu.HeaderText = "Nama Tamu"
        Me.dgvNamaTamu.Name = "dgvNamaTamu"
        Me.dgvNamaTamu.Width = 101
        '
        'dgvNomorRuangan
        '
        Me.dgvNomorRuangan.HeaderText = "Nomor Ruangan"
        Me.dgvNomorRuangan.Name = "dgvNomorRuangan"
        Me.dgvNomorRuangan.Width = 125
        '
        'dgvTipeRuangan
        '
        Me.dgvTipeRuangan.HeaderText = "Tipe Ruangan"
        Me.dgvTipeRuangan.Name = "dgvTipeRuangan"
        Me.dgvTipeRuangan.Width = 113
        '
        'dgvTarifRuangan
        '
        Me.dgvTarifRuangan.HeaderText = "Tarif Ruangan"
        Me.dgvTarifRuangan.Name = "dgvTarifRuangan"
        Me.dgvTarifRuangan.Width = 114
        '
        'dgvTanggalCheckIn
        '
        Me.dgvTanggalCheckIn.HeaderText = "Tanggal Check In"
        Me.dgvTanggalCheckIn.Name = "dgvTanggalCheckIn"
        Me.dgvTanggalCheckIn.Width = 117
        '
        'dgvTanggalCheckOut
        '
        Me.dgvTanggalCheckOut.HeaderText = "Tanggal Check Out"
        Me.dgvTanggalCheckOut.Name = "dgvTanggalCheckOut"
        Me.dgvTanggalCheckOut.Width = 91
        '
        'dgvJumlahHari
        '
        Me.dgvJumlahHari.HeaderText = "Jumlah Hari"
        Me.dgvJumlahHari.Name = "dgvJumlahHari"
        Me.dgvJumlahHari.Width = 99
        '
        'dgvJumlahDewasa
        '
        Me.dgvJumlahDewasa.HeaderText = "Jumlah Dewasa"
        Me.dgvJumlahDewasa.Name = "dgvJumlahDewasa"
        Me.dgvJumlahDewasa.Width = 121
        '
        'dgvJumlahAnak
        '
        Me.dgvJumlahAnak.HeaderText = "Jumlah Anak"
        Me.dgvJumlahAnak.Name = "dgvJumlahAnak"
        Me.dgvJumlahAnak.Width = 105
        '
        'dgvDiskonInap
        '
        Me.dgvDiskonInap.HeaderText = "Diskon Inap"
        Me.dgvDiskonInap.Name = "dgvDiskonInap"
        Me.dgvDiskonInap.Width = 98
        '
        'dgvTipeMember
        '
        Me.dgvTipeMember.HeaderText = "Tipe Member"
        Me.dgvTipeMember.Name = "dgvTipeMember"
        Me.dgvTipeMember.Width = 106
        '
        'dgvDiskonMember
        '
        Me.dgvDiskonMember.HeaderText = "Diskon Member"
        Me.dgvDiskonMember.Name = "dgvDiskonMember"
        Me.dgvDiskonMember.Width = 120
        '
        'dgvSubTotal
        '
        Me.dgvSubTotal.HeaderText = "Sub Total"
        Me.dgvSubTotal.Name = "dgvSubTotal"
        Me.dgvSubTotal.Width = 87
        '
        'dgvUangMuka
        '
        Me.dgvUangMuka.HeaderText = "Uang Muka"
        Me.dgvUangMuka.Name = "dgvUangMuka"
        Me.dgvUangMuka.Width = 96
        '
        'dgvTotalKurang
        '
        Me.dgvTotalKurang.HeaderText = "Total Kurang"
        Me.dgvTotalKurang.Name = "dgvTotalKurang"
        Me.dgvTotalKurang.Width = 105
        '
        'checkIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 528)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "checkIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "checkIn"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvCheckIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btBatal As System.Windows.Forms.Button
    Friend WithEvents btPlus2 As System.Windows.Forms.Button
    Friend WithEvents btMin2 As System.Windows.Forms.Button
    Friend WithEvents btPlus1 As System.Windows.Forms.Button
    Friend WithEvents btMin1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btLogin As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents teksUangMuka As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbJumlahAnak As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbJumlahDewasa As System.Windows.Forms.TextBox
    Friend WithEvents tbJumlahHari As System.Windows.Forms.TextBox
    Friend WithEvents tbUangMuka As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalKurang As System.Windows.Forms.TextBox
    Friend WithEvents tbSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbDiskonInap As System.Windows.Forms.TextBox
    Friend WithEvents tbTarifKamar As System.Windows.Forms.TextBox
    Friend WithEvents tbTipeRuangan As System.Windows.Forms.TextBox
    Friend WithEvents tbNoRuangan As System.Windows.Forms.TextBox
    Friend WithEvents tbNamaTamu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvCheckIn As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents textIdTransaksi As System.Windows.Forms.Label
    Friend WithEvents btCheckIn As System.Windows.Forms.Button
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbTipeMember As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbDiskonMember As System.Windows.Forms.TextBox
    Friend WithEvents dgvIdTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvNamaTamu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvNomorRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTipeRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTarifRuangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTanggalCheckIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTanggalCheckOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvJumlahHari As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvJumlahDewasa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvJumlahAnak As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDiskonInap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTipeMember As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDiskonMember As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvUangMuka As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTotalKurang As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
