<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.OwnerTextBox = New System.Windows.Forms.TextBox()
		Me.ModelTextBox = New System.Windows.Forms.TextBox()
		Me.vehicleNameTextBox = New System.Windows.Forms.TextBox()
		Me.vehicleIDTextBox = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SaveButton = New System.Windows.Forms.Button()
		Me.ClearButton = New System.Windows.Forms.Button()
		Me.DeleteButton = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.vehicleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.vehicleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.owner = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.OwnerTextBox)
		Me.GroupBox1.Controls.Add(Me.ModelTextBox)
		Me.GroupBox1.Controls.Add(Me.vehicleNameTextBox)
		Me.GroupBox1.Controls.Add(Me.vehicleIDTextBox)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(36, 51)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(446, 386)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "vehicle details"
		'
		'OwnerTextBox
		'
		Me.OwnerTextBox.Location = New System.Drawing.Point(204, 311)
		Me.OwnerTextBox.Name = "OwnerTextBox"
		Me.OwnerTextBox.Size = New System.Drawing.Size(100, 22)
		Me.OwnerTextBox.TabIndex = 8
		'
		'ModelTextBox
		'
		Me.ModelTextBox.AcceptsReturn = True
		Me.ModelTextBox.Location = New System.Drawing.Point(214, 221)
		Me.ModelTextBox.Name = "ModelTextBox"
		Me.ModelTextBox.Size = New System.Drawing.Size(100, 22)
		Me.ModelTextBox.TabIndex = 7
		'
		'vehicleNameTextBox
		'
		Me.vehicleNameTextBox.Location = New System.Drawing.Point(214, 134)
		Me.vehicleNameTextBox.Name = "vehicleNameTextBox"
		Me.vehicleNameTextBox.Size = New System.Drawing.Size(100, 22)
		Me.vehicleNameTextBox.TabIndex = 6
		'
		'vehicleIDTextBox
		'
		Me.vehicleIDTextBox.Location = New System.Drawing.Point(214, 53)
		Me.vehicleIDTextBox.Name = "vehicleIDTextBox"
		Me.vehicleIDTextBox.Size = New System.Drawing.Size(100, 22)
		Me.vehicleIDTextBox.TabIndex = 5
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(73, 314)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(50, 16)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Owner"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(73, 227)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(50, 16)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Model"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(73, 52)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(76, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "vehicle ID"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(73, 150)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(104, 16)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Vehicle Name"
		'
		'SaveButton
		'
		Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SaveButton.Location = New System.Drawing.Point(226, 480)
		Me.SaveButton.Name = "SaveButton"
		Me.SaveButton.Size = New System.Drawing.Size(159, 75)
		Me.SaveButton.TabIndex = 1
		Me.SaveButton.Text = "Save"
		Me.SaveButton.UseVisualStyleBackColor = False
		'
		'ClearButton
		'
		Me.ClearButton.BackColor = System.Drawing.Color.Cyan
		Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ClearButton.Location = New System.Drawing.Point(499, 483)
		Me.ClearButton.Name = "ClearButton"
		Me.ClearButton.Size = New System.Drawing.Size(173, 72)
		Me.ClearButton.TabIndex = 2
		Me.ClearButton.Text = "Clear"
		Me.ClearButton.UseVisualStyleBackColor = False
		'
		'DeleteButton
		'
		Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DeleteButton.Location = New System.Drawing.Point(816, 480)
		Me.DeleteButton.Name = "DeleteButton"
		Me.DeleteButton.Size = New System.Drawing.Size(188, 75)
		Me.DeleteButton.TabIndex = 3
		Me.DeleteButton.Text = "Delete"
		Me.DeleteButton.UseVisualStyleBackColor = False
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vehicleID, Me.vehicleName, Me.Model, Me.owner})
		Me.DataGridView1.Location = New System.Drawing.Point(537, 51)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersWidth = 51
		Me.DataGridView1.RowTemplate.Height = 24
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(564, 367)
		Me.DataGridView1.TabIndex = 4
		'
		'vehicleID
		'
		Me.vehicleID.HeaderText = "vehicleID"
		Me.vehicleID.MinimumWidth = 6
		Me.vehicleID.Name = "vehicleID"
		Me.vehicleID.ReadOnly = True
		Me.vehicleID.Width = 125
		'
		'vehicleName
		'
		Me.vehicleName.HeaderText = "vehicleName"
		Me.vehicleName.MinimumWidth = 6
		Me.vehicleName.Name = "vehicleName"
		Me.vehicleName.ReadOnly = True
		Me.vehicleName.Width = 125
		'
		'Model
		'
		Me.Model.HeaderText = "Model"
		Me.Model.MinimumWidth = 6
		Me.Model.Name = "Model"
		Me.Model.ReadOnly = True
		Me.Model.Width = 125
		'
		'owner
		'
		Me.owner.HeaderText = "owner"
		Me.owner.MinimumWidth = 6
		Me.owner.Name = "owner"
		Me.owner.ReadOnly = True
		Me.owner.Width = 125
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1288, 584)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.DeleteButton)
		Me.Controls.Add(Me.ClearButton)
		Me.Controls.Add(Me.SaveButton)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "Form1"
		Me.Text = "vehicle management"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents OwnerTextBox As TextBox
	Friend WithEvents ModelTextBox As TextBox
	Friend WithEvents vehicleNameTextBox As TextBox
	Friend WithEvents vehicleIDTextBox As TextBox
	Friend WithEvents SaveButton As Button
	Friend WithEvents ClearButton As Button
	Friend WithEvents DeleteButton As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents vehicleID As DataGridViewTextBoxColumn
	Friend WithEvents vehicleName As DataGridViewTextBoxColumn
	Friend WithEvents Model As DataGridViewTextBoxColumn
	Friend WithEvents owner As DataGridViewTextBoxColumn
End Class
