Imports SistemaAguaRioLimpio.Entities
Imports System.Data.SqlClient
Public Class ArticuloDAL
        Inherits BaseDAL

        'METODOS CRUD 
        Public Shared Sub Create(articulo As ArticuloEntity)
        'CREAMOS LA CONEXION A LA BD
        Using Conex As New SqlConnection(m_CadenaConexion)
            Conex.Open()

            'CREAMOS LA SENTENCIA SQL PARA AGREGAR UN REGISTRO
            Dim sql As String = "INSERT INTO Articulo (IdCategoria, Nombre, Descripcion, PrecioCompra, PrecioVenta, Stock)
                               Values(@idCategoria, @nombre, @descripcion, @precioCompra, @precioVenta, @stock" &
                                   "SELECT SCOPE_IDENTITY()"

            Dim cmd As New SqlCommand(sql, Conex)

            'AGREGAMOS EL PARAMETRO
            cmd.Parameters.AddWithValue("@nombre", articulo.Nombre)
            cmd.Parameters.AddWithValue("@descrpcion", articulo.Descripcion)
            cmd.Parameters.AddWithValue("@precioCompra", articulo.PrecioCompra)
            cmd.Parameters.AddWithValue("@precioVenta", articulo.PrecioVenta)
            cmd.Parameters.AddWithValue("@idCategoria", articulo.IdCategoria)
            articulo.ID = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
    End Sub

        Public Shared Function GetByID(Id As Integer) As ArticuloEntity
            Dim articulo As ArticuloEntity = Nothing

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            Dim sql As String = "SELECT * FROM Articulo Where ID=@IdArticulo"
            Dim cmd As New SqlCommand(sql, conex)
            cmd.Parameters.AddWithValue("IdArticulo", Id)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                articulo = ConvertToObjet(reader)

            End If

        End Using

        Return articulo
        End Function

        Public Shared Function GetByValor(Valor As String) As List(Of ArticuloEntity)
            Dim list As New List(Of ArticuloEntity)

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            Dim sql As String = "SELECT*FOM Articulo" &
                                    "WHERE Nombre Like '%' + @valor '&' or Descripcion Like '&' + @valor + '&' ORDER BY Nombre"

            Dim cmd As New SqlCommand(sql, conex)
            cmd.Parameters.AddWithValue("@valor", Valor)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                list.Add(ConvertToObjet(reader))
            End While
        End Using
        Return list

        End Function

        Public Shared Function GetAll() As List(Of ArticuloEntity)
            Dim list As New List(Of ArticuloEntity)

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            Dim sql As String = "SELECT*FOM Articulo ORDER BY Nombre"
            Dim cmd As New SqlCommand(sql, conex)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                list.Add(ConvertToObjet(reader))
            End While
        End Using
        Return list

        End Function

        Private Shared Function ConvertToObjet(reader As SqlDataReader) As ArticuloEntity
            Throw New NotImplementedException()
        End Function

        Public Shared Sub Update(articulo As ArticuloEntity)
        'CREAMOS LA CONEXION A LA BD
        Using Conex As New SqlConnection(m_CadenaConexion)
            Conex.Open()

            'CREAMOS LA SENTENCIA SQL PARA AGREGAR UN REGISTRO
            Dim sql As String = "UPDATE Articulo Set IdCategoria=@idCategoria,Nombre=@nombre,Descripcion=@descripcion,PrecioCompra=@precioCompra,
                                                     PrecioVenta=@precioVenta,
                                                     Stock=@stock WHERE ID=idArticulo"


            Dim cmd As New SqlCommand(sql, Conex)

            'AGREGAMOS EL PARAMETRO
            cmd.Parameters.AddWithValue("@nombre", articulo.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", articulo.Descripcion)
            cmd.Parameters.AddWithValue("@precioCompra", articulo.PrecioCompra)
            cmd.Parameters.AddWithValue("@precioVenta", articulo.PrecioVenta)
            cmd.Parameters.AddWithValue("@stock", articulo.Stock)
            cmd.Parameters.AddWithValue("@idArticulo", articulo.ID)
            cmd.Parameters.AddWithValue("@idCategoria", articulo.IdCategoria)

            cmd.ExecuteNonQuery()  'Ejecutar Comando

        End Using
    End Sub

        Public Shared Function Delete(Id As String) As Boolean
            Dim SeElimino As Boolean

        Using conex As New SqlConnection(m_CadenaConexion)
            conex.Open()

            Dim sql As String = "DELETE FROM Articulo WHERE ID=@IdArticulo"
            Dim cmd As New SqlCommand(sql, conex)
            cmd.Parameters.AddWithValue("IdArticulo", Id)

            SeElimino = cmd.ExecuteNonQuery() > 0

        End Using

        Return SeElimino

        End Function

    End Class
