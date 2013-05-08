Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Cod2013 北海道会場 #1"

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your app description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
