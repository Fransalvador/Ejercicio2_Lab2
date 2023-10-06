Imports System.Data.SqlTypes

Module Module1

    Sub Main()
        'Declaracion de Variables
        Dim opc As String = "Y"
        Dim venta, descuento, monto, total As Double
        venta = 0
        descuento = 0
        monto = 0

        Dim i As Integer = 0
        Do 'Ciclo de ingreso de totales de compra
            Console.WriteLine("ingrese el monto de la venta: $ ")
            monto = Console.ReadLine()
            While monto <= 0 'se repetira ciclo si el dato ingresado es negativo o cero
                Console.WriteLine("El monto debe ser mayor a 0, Intentelo denuevo!")
                monto = Console.ReadLine()
            End While
            venta = venta + monto
            i += 1
            Console.WriteLine("¿Ingresara otra compra?")
            Console.WriteLine("(S) para si, (N) para no")
            opc = Console.ReadLine.ToUpper()
            While opc <> "S" AndAlso opc <> "N" 'se repetira el ciclo hasta que se ingrese una letra valida
                Console.WriteLine("Debe ingresar (S) para si o (N) para no, intentelo denuevo")
                opc = Console.ReadLine.ToUpper()
            End While

        Loop While opc = "S" 'El ciclo se repetira hasta que se ingrese la opcion N
        'Calculo del descuento a aplicar
        If venta > 500 Then
            descuento = venta * 0.05
        ElseIf venta > 1000 Then
            descuento = venta * 0.1
        Else

        End If
        total = venta - descuento
        'Salida de datos obtenidos
        Console.WriteLine("El ventas en su compra fue: " & i)
        Console.WriteLine("El subtotal de su compra fue: $" & venta)
        Console.WriteLine("El descuento aplicado fue: $" & descuento)
        Console.WriteLine("El total a cancelar es: $" & total)
        Console.ReadLine()
        Console.Clear()
        'Elaborado por
        Console.WriteLine("integrantes:")
        Console.WriteLine("1-Francisco Salvador Moreno Garcia")
        Console.WriteLine("1-Hugo Nelson Ramirez Perez")


    End Sub

End Module
