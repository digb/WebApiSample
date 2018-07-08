Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
'Imports R_Web.Api.Filters

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services
        'config.Filters.Add(New BasicAuthenticationAttribute())

        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
            name:="ActionApi",
            routeTemplate:="api/{controller}/{action}"
        )
    End Sub
End Module
