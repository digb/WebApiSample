Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
'Imports R_Web.Api.Filters

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services

        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
            name:="ActionApi",
            routeTemplate:="api/{controller}/{action}"
        )

        'config.Filters.Add(New BasicAuthenticationAttribute())
    End Sub
End Module
