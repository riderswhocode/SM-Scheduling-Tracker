Imports MySql.Data.MySqlClient
Module Module1

    Dim host = My.Settings.DBServer
    Dim port = My.Settings.Port
    Dim dbname = My.Settings.DBName
    Dim dbuser = My.Settings.DBUser
    Dim dbpassword = My.Settings.DBPassword


    Public conString As String = "host='" + host + "';user='" + dbuser + "';password='" + dbpassword + "';port='" + port + "';Database='" + dbname + "';"

    'Public sqlcon As New MySqlConnection("host='" + host + "';user='" + dbuser + "';password='" + dbpassword + "';port='" + port + "';Database='" + dbname + "';")


End Module
