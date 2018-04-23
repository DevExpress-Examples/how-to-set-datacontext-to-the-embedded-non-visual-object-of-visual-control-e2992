Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace DataContextSLSample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim connection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=True"
			Dim sourceData As New DataStoreModel(connection)
			Dim sourceDataModel As New DataStoreViewModel(sourceData)

			Me.MyVisualControl.DataContext = sourceDataModel
		End Sub
	End Class
End Namespace
