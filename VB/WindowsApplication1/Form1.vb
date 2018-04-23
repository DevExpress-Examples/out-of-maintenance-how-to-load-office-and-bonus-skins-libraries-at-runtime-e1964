Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Reflection
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.Skins

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits XtraForm


		Private Shared Function GetLibraryName(ByVal type As DynamicSkinType) As String
			Return String.Format("DevExpress.{0}Skins{1}.dll", type, AssemblyInfo.VSuffix)
		End Function

		Private Overloads Function ShowDialog(ByVal type As DynamicSkinType) As String
			Dim dialog As New OpenFileDialog()
			dialog.FileName = GetLibraryName(type)
			dialog.ShowDialog()
			Return dialog.FileName
		End Function

		Private Sub LoadDynamicSkin(ByVal type As DynamicSkinType)
			Dim fileName As String = ShowDialog(type)
			If File.Exists(fileName) Then
				Dim SampleAssembly As System.Reflection.Assembly = System.Reflection.Assembly.LoadFile(fileName)
				DevExpress.Skins.SkinManager.Default.RegisterAssembly(SampleAssembly)
				PopulateListBox()
			Else
				MessageBox.Show(String.Format("File not found ({0})", fileName))
			End If
		End Sub

		Private Sub PopulateListBox()
			listBoxControl1.Items.Clear()
			For Each skin As SkinContainer In SkinManager.Default.Skins
				listBoxControl1.Items.Add(skin.SkinName)
			Next skin
		End Sub

		Public Sub New()
			InitializeComponent()
			PopulateListBox()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			LoadDynamicSkin(DynamicSkinType.Office)
		End Sub

		Private Sub listBoxControl1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.SelectedValueChanged
			If listBoxControl1.SelectedValue IsNot Nothing Then
				defaultLookAndFeel1.LookAndFeel.SkinName = listBoxControl1.SelectedValue.ToString()
			End If
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			LoadDynamicSkin(DynamicSkinType.Bonus)
		End Sub
	End Class

	Friend Enum DynamicSkinType
		Office
		Bonus
	End Enum
End Namespace