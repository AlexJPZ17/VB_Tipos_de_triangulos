Module Module1
    Private lado1, lado2, lado3, repetir As Integer
    Public Class TiposTriangulos
        'Método que muestra los mensajes y obtiene los datos ingresados
        Public Sub Inicializar()
            Console.WriteLine("Introduzca los lados del triangulo")
            Console.WriteLine("Medida del lado 1")
            lado1 = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Medida del lado 2")
            lado2 = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Medida del lado 3")
            lado3 = Convert.ToInt32(Console.ReadLine())

        End Sub
        'Método que busca el lado mayor de los tres lados del triangulo
        Public Sub LadoMayor()
            'Condiciones que buscan el lado mayor
            If lado1 > lado2 And lado1 > lado3 Then
                Console.WriteLine("El lado mayor es: " & lado1)
            Else
                If lado2 > lado3 Then
                    Console.WriteLine("El lado mayor es: " & lado2)
                Else
                    Console.WriteLine("El lado mayor es: " & lado3)
                End If

            End If

        End Sub
        'Método que busca los tipos de triángulos de acuerdo a los tipos de medidas ingresados
        Public Sub Trinagulos()
            'Condiciones que evalúan el tipo de triangulo de acuerdo a los lados ingresados
            If lado1 = lado2 And lado1 = lado3 Then
                Console.WriteLine("El triángulo es equilátero")
            End If
            If lado1 = lado2 And lado1 <> lado3 Or lado2 = lado3 And lado2 <> lado1 Or lado3 = lado1 And lado3 <> lado2 Then
                Console.WriteLine("El triángulo es isósceles")
            End If
            If lado1 <> lado2 And lado1 <> lado3 And lado2 <> lado3 Then
                Console.WriteLine("El triángulo es escaleno")
            End If

        End Sub
    End Class
    Sub Main()
        'Instruccion do while
        Do
            'Mandamos a llamar a la clase TiposTriangulos
            Dim triangulo As New TiposTriangulos
            triangulo.Inicializar()
            triangulo.LadoMayor()
            triangulo.Trinagulos()
            Console.WriteLine("Desea repitir el prosedimiento coloque 1 = si o 2 = no")
            repetir = Convert.ToInt32(Console.ReadLine())
        Loop While repetir = 1
    End Sub

End Module
