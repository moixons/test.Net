﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class TestingEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=TestingEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property REGISTER() As DbSet(Of REGISTER)
    Public Overridable Property USERS() As DbSet(Of USERS)
    Public Overridable Property USERS_REGISTER() As DbSet(Of USERS_REGISTER)

End Class