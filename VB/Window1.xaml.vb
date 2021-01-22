Imports System
Imports System.Collections.ObjectModel
Imports System.Windows
Namespace SideBySideBar2DChart
	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class ChartViewModel
		Private privateData As ObservableCollection(Of DataSeries)
		Public Property Data() As ObservableCollection(Of DataSeries)
			Get
				Return privateData
			End Get
			Private Set(ByVal value As ObservableCollection(Of DataSeries))
				privateData = value
			End Set
		End Property

		Public Sub New()
			Data = New ObservableCollection(Of DataSeries) _
				From {
					New DataSeries With {
						.Name = "DevAV North",
						.Values = New ObservableCollection(Of DataPoint) From {
							New DataPoint(New DateTime(2013,12,31), 362.5),
							New DataPoint(New DateTime(2014,12,31), 348.4),
							New DataPoint(New DateTime(2015,12,31), 279.0),
							New DataPoint(New DateTime(2016,12,31), 230.9),
							New DataPoint(New DateTime(2017,12,31), 203.5),
							New DataPoint(New DateTime(2018,12,31), 197.1)
						}
					},
					New DataSeries With {
						.Name = "DevAV South",
						.Values = New ObservableCollection(Of DataPoint) From {
							New DataPoint(New DateTime(2013,12,31), 277.0),
							New DataPoint(New DateTime(2014,12,31), 328.5),
							New DataPoint(New DateTime(2015,12,31), 297.0),
							New DataPoint(New DateTime(2016,12,31), 255.3),
							New DataPoint(New DateTime(2017,12,31), 173.5),
							New DataPoint(New DateTime(2018,12,31), 131.8)
						}
					}
				}
		End Sub
		Public Class DataSeries
			Public Property Name() As String
			Public Property Values() As ObservableCollection(Of DataPoint)
		End Class
		Public Class DataPoint
			Public Property Argument() As DateTime
			Public Property Value() As Double
			Public Sub New(ByVal argument As DateTime, ByVal value As Double)
				Me.Argument = argument
				Me.Value = value
			End Sub
		End Class
	End Class
End Namespace
