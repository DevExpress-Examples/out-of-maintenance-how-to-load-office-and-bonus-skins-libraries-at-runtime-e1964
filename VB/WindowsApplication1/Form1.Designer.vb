Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 12)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(190, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Load office skins"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Location = New System.Drawing.Point(271, 12)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(257, 395)
			Me.listBoxControl1.TabIndex = 2
'			Me.listBoxControl1.SelectedValueChanged += New System.EventHandler(Me.listBoxControl1_SelectedValueChanged);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(12, 69)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(190, 23)
			Me.simpleButton2.TabIndex = 3
			Me.simpleButton2.Text = "Load bonus skins"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(540, 441)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

