﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="lightbox")>  _
Partial Public Class DataClassesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertAlbum(instance As Album)
    End Sub
  Partial Private Sub UpdateAlbum(instance As Album)
    End Sub
  Partial Private Sub DeleteAlbum(instance As Album)
    End Sub
  Partial Private Sub InsertPhoto(instance As Photo)
    End Sub
  Partial Private Sub UpdatePhoto(instance As Photo)
    End Sub
  Partial Private Sub DeletePhoto(instance As Photo)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Albums() As System.Data.Linq.Table(Of Album)
		Get
			Return Me.GetTable(Of Album)
		End Get
	End Property
	
	Public ReadOnly Property Photos() As System.Data.Linq.Table(Of Photo)
		Get
			Return Me.GetTable(Of Photo)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Albums")>  _
Partial Public Class Album
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _Album_Name As String
	
	Private _Photos As String
	
	Private _Photos1 As EntitySet(Of Photo)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnAlbum_NameChanging(value As String)
    End Sub
    Partial Private Sub OnAlbum_NameChanged()
    End Sub
    Partial Private Sub OnPhotosChanging(value As String)
    End Sub
    Partial Private Sub OnPhotosChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Photos1 = New EntitySet(Of Photo)(AddressOf Me.attach_Photos1, AddressOf Me.detach_Photos1)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Album_Name", DbType:="NVarChar(MAX)")>  _
	Public Property Album_Name() As String
		Get
			Return Me._Album_Name
		End Get
		Set
			If (String.Equals(Me._Album_Name, value) = false) Then
				Me.OnAlbum_NameChanging(value)
				Me.SendPropertyChanging
				Me._Album_Name = value
				Me.SendPropertyChanged("Album_Name")
				Me.OnAlbum_NameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Photos", DbType:="NVarChar(MAX)")>  _
	Public Property Photos() As String
		Get
			Return Me._Photos
		End Get
		Set
			If (String.Equals(Me._Photos, value) = false) Then
				Me.OnPhotosChanging(value)
				Me.SendPropertyChanging
				Me._Photos = value
				Me.SendPropertyChanged("Photos")
				Me.OnPhotosChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Album_Photo", Storage:="_Photos1", ThisKey:="ID", OtherKey:="ID_Album")>  _
	Public Property Photos1() As EntitySet(Of Photo)
		Get
			Return Me._Photos1
		End Get
		Set
			Me._Photos1.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Photos1(ByVal entity As Photo)
		Me.SendPropertyChanging
		entity.Album = Me
	End Sub
	
	Private Sub detach_Photos1(ByVal entity As Photo)
		Me.SendPropertyChanging
		entity.Album = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Photos")>  _
Partial Public Class Photo
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID_Photo As Integer
	
	Private _Photo_Name As String
	
	Private _Photo_discreption As String
	
	Private _ID_Album As Integer
	
	Private _Album As EntityRef(Of Album)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnID_PhotoChanging(value As Integer)
    End Sub
    Partial Private Sub OnID_PhotoChanged()
    End Sub
    Partial Private Sub OnPhoto_NameChanging(value As String)
    End Sub
    Partial Private Sub OnPhoto_NameChanged()
    End Sub
    Partial Private Sub OnPhoto_discreptionChanging(value As String)
    End Sub
    Partial Private Sub OnPhoto_discreptionChanged()
    End Sub
    Partial Private Sub OnID_AlbumChanging(value As Integer)
    End Sub
    Partial Private Sub OnID_AlbumChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Album = CType(Nothing, EntityRef(Of Album))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_Photo", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID_Photo() As Integer
		Get
			Return Me._ID_Photo
		End Get
		Set
			If ((Me._ID_Photo = value)  _
						= false) Then
				Me.OnID_PhotoChanging(value)
				Me.SendPropertyChanging
				Me._ID_Photo = value
				Me.SendPropertyChanged("ID_Photo")
				Me.OnID_PhotoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Photo_Name", DbType:="NVarChar(MAX)")>  _
	Public Property Photo_Name() As String
		Get
			Return Me._Photo_Name
		End Get
		Set
			If (String.Equals(Me._Photo_Name, value) = false) Then
				Me.OnPhoto_NameChanging(value)
				Me.SendPropertyChanging
				Me._Photo_Name = value
				Me.SendPropertyChanged("Photo_Name")
				Me.OnPhoto_NameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Photo_discreption", DbType:="NVarChar(MAX)")>  _
	Public Property Photo_discreption() As String
		Get
			Return Me._Photo_discreption
		End Get
		Set
			If (String.Equals(Me._Photo_discreption, value) = false) Then
				Me.OnPhoto_discreptionChanging(value)
				Me.SendPropertyChanging
				Me._Photo_discreption = value
				Me.SendPropertyChanged("Photo_discreption")
				Me.OnPhoto_discreptionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_Album", DbType:="Int NOT NULL")>  _
	Public Property ID_Album() As Integer
		Get
			Return Me._ID_Album
		End Get
		Set
			If ((Me._ID_Album = value)  _
						= false) Then
				If Me._Album.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnID_AlbumChanging(value)
				Me.SendPropertyChanging
				Me._ID_Album = value
				Me.SendPropertyChanged("ID_Album")
				Me.OnID_AlbumChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Album_Photo", Storage:="_Album", ThisKey:="ID_Album", OtherKey:="ID", IsForeignKey:=true)>  _
	Public Property Album() As Album
		Get
			Return Me._Album.Entity
		End Get
		Set
			Dim previousValue As Album = Me._Album.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Album.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Album.Entity = Nothing
					previousValue.Photos1.Remove(Me)
				End If
				Me._Album.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Photos1.Add(Me)
					Me._ID_Album = value.ID
				Else
					Me._ID_Album = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Album")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
