Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
' ...

Namespace docITypedList

	Public Class Supplier
		Private Shared nextID As Integer = 0
		Private id As Integer
		Private name As String

		Private products_Renamed As New List(Of Product)()

		Public ReadOnly Property Products() As IList(Of Product)
			Get
				Return products_Renamed
			End Get
		End Property
		Public ReadOnly Property SupplierID() As Integer
			Get
				Return id
			End Get
		End Property
		Public ReadOnly Property CompanyName() As String
			Get
				Return name
			End Get
		End Property

		Public Sub New(ByVal name As String)
			Me.name = name

			Me.id = nextID
			nextID += 1
		End Sub
		Public Sub Add(ByVal product As Product)
			products_Renamed.Add(product)
		End Sub
	End Class

	Public Class Product
		Private Shared nextID As Integer = 0

		Private orderDetails_Renamed As New List(Of OrderDetail)()
		Private suppID As Integer
		Private prodID As Integer
		Private name As String

		Public ReadOnly Property SupplierID() As Integer
			Get
				Return suppID
			End Get
		End Property
		Public ReadOnly Property ProductID() As Integer
			Get
				Return prodID
			End Get
		End Property
		Public ReadOnly Property ProductName() As String
			Get
				Return name
			End Get
		End Property

		Public ReadOnly Property OrderDetails() As IList(Of OrderDetail)
			Get
				Return orderDetails_Renamed
			End Get
		End Property

		Public Sub New(ByVal suppID As Integer, ByVal name As String)
			Me.suppID = suppID
			Me.name = name

			Me.prodID = nextID
			nextID += 1
		End Sub

		Friend Sub AddRange(ByVal orderDetailArray() As OrderDetail)
			orderDetails_Renamed.AddRange(orderDetailArray)
		End Sub
	End Class

	Public Class OrderDetail
		Private prodID As Integer
		Private quantity_Renamed As Short
		Public ReadOnly Property ProductID() As Integer
			Get
				Return prodID
			End Get
		End Property
		Public ReadOnly Property Quantity() As Short
			Get
				Return quantity_Renamed
			End Get
		End Property

		Public Sub New(ByVal prodID As Integer, ByVal quantity As Integer)
			Me.prodID = prodID
			Me.quantity_Renamed = Convert.ToInt16(quantity)
		End Sub
	End Class

End Namespace
