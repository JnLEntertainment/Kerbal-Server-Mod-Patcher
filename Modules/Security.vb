Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Module Security

    Function md5_hash(ByVal file_name As String)

        Return security_hash_code("md5", file_name)

    End Function

    Function sha1_hash(ByVal file_name As String)

        Return security_hash_code("sha1", file_name)

    End Function

    Function sha256_hash(ByVal file_name As String)

        Return security_hash_code("sha256", file_name)

    End Function

    Function security_hash_code(ByVal code_type As String, ByVal file_name As String)

        Dim hash
        If code_type.ToLower = "md5" Then
            hash = MD5.Create
        ElseIf code_type.ToLower = "sha1" Then
            hash = SHA1.Create
        ElseIf code_type.ToLower = "sha256" Then
            hash = SHA256.Create
        Else
            MsgBox("HASH 타입이 올바르지 않습니다 : " & code_type, MsgBoxStyle.Critical)
            Return False
        End If

        Dim hash_value() As Byte
        Dim file_stream As FileStream = File.OpenRead(file_name)

        file_stream.Position = 0
        hash_value = hash.ComputeHash(file_stream)

        Dim hash_hex = PrintByteArray(hash_value)

        file_stream.Close()

        Return hash_hex
    End Function
    Public Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""
        Dim i As Integer

        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i

        Return hex_value.ToLower
    End Function
End Module

'   Reference

'       ////////////////////////////////////////////////////////////////////////////////////////////////////
'       Function security_hash_code
'       Function PrintByteArray
'       Function md5_hash / sha1_hash / sha256_hash
'       http://us.informatiweb.net/tutorials/programing/1-vb-net/36--generate-hashes-md5-sha-1-and-sha-256-of-a-file.html
'       ////////////////////////////////////////////////////////////////////////////////////////////////////