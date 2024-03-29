﻿Imports System.IO.Compression

Module ZIP
    Dim ksp As String = Steam.ksp_directory(True)
    Dim ksp_temp As String = ksp + "\_TEMP"
    Dim gamedata As String = ksp_temp + "\GameData.zip"
    Dim gamedata_temp As String = ksp_temp + "\GameData"
    Dim gamedata_dir As String = ksp + "\GameData"
    Dim backup_dir As String = ksp + "\_GameData_BAK"
    Function unzip(u As Boolean) As Integer
        My.Computer.FileSystem.CreateDirectory(gamedata_temp)
        ZipFile.ExtractToDirectory(gamedata, gamedata_temp)
        Return 1
    End Function
    Function backup(b As Boolean) As Integer
        If My.Computer.FileSystem.DirectoryExists(backup_dir) Then My.Computer.FileSystem.MoveDirectory(backup_dir, backup_dir + "1")
        My.Computer.FileSystem.MoveDirectory(gamedata_dir, backup_dir)
        Return 1
    End Function
    Function install(i As Boolean) As Integer
        If My.Computer.FileSystem.DirectoryExists(gamedata_dir) Then My.Computer.FileSystem.DeleteDirectory(gamedata_dir, FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.MoveDirectory(gamedata_temp, gamedata_dir)
        Return 1
    End Function
    Function clean(c As Boolean) As Integer
        If My.Computer.FileSystem.DirectoryExists(ksp_temp) = False Then Return 0
        My.Computer.FileSystem.DeleteDirectory(ksp_temp, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Return 1
    End Function
End Module
