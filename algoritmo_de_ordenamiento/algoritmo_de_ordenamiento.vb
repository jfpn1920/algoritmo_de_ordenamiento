Imports System
Module algoritmo_de_ordenamiento
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim numeros(9) As Double
        Dim algoritmos(9) As String
        Dim ordenes(9) As String
        Dim resultados(9) As String
        Dim niveles(9) As String
        Dim fechas(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '----------------------------------------------'
        '--|menu_principal_algoritmo_de_ordenamiento|--'
        '----------------------------------------------'
        Do
            Console.WriteLine("menu principal algoritmo de ordenamiento")
            Console.WriteLine("1) Registrar numero")
            Console.WriteLine("2) Editar numero")
            Console.WriteLine("3) Listar numeros")
            Console.WriteLine("4) Buscar numero")
            Console.WriteLine("5) Eliminar numero")
            Console.WriteLine("6) Ordenar numeros")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '----------------------'
                '--|registrar_numero|--'
                '----------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas numeros.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Numero: ")
                        numeros(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Algoritmo: ")
                        algoritmos(cantidad) = Console.ReadLine()
                        Console.Write("Orden (Ascendente/Descendente): ")
                        ordenes(cantidad) = Console.ReadLine()
                        Console.Write("Resultado: ")
                        resultados(cantidad) = Console.ReadLine()
                        Console.Write("Nivel: ")
                        niveles(cantidad) = Console.ReadLine()
                        Console.Write("Fecha: ")
                        fechas(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Numero registrado correctamente.")
                    End If
                '-------------------'
                '--|editar_numero|--'
                '-------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen numeros registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Numero: " & numeros(i) & " | Algoritmo: " & algoritmos(i) & " | Orden: " & ordenes(i) & " | Resultado: " & resultados(i) & " | Nivel: " & niveles(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del numero a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo numero: ")
                            numeros(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nuevo algoritmo: ")
                            algoritmos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo orden: ")
                            ordenes(posicion) = Console.ReadLine()
                            Console.Write("Nuevo resultado: ")
                            resultados(posicion) = Console.ReadLine()
                            Console.Write("Nuevo nivel: ")
                            niveles(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha: ")
                            fechas(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Numero actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------'
                '--|listar_numeros|--'
                '--------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen numeros registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Numero: " & numeros(i) & " | Algoritmo: " & algoritmos(i) & " | Orden: " & ordenes(i) & " | Resultado: " & resultados(i) & " | Nivel: " & niveles(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '-------------------'
                '--|buscar_numero|--'
                '-------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen numeros registrados.")
                    Else
                        Console.Write("Ingrese el ID del numero a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Numero: " & numeros(posicion) & " | Algoritmo: " & algoritmos(posicion) & " | Orden: " & ordenes(posicion) & " | Resultado: " & resultados(posicion) & " | Nivel: " & niveles(posicion) & " | Fecha: " & fechas(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|eliminar_numero|--'
                '---------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen numeros registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Numero: " & numeros(i) & " | Algoritmo: " & algoritmos(i) & " | Orden: " & ordenes(i) & " | Resultado: " & resultados(i) & " | Nivel: " & niveles(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del numero a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                numeros(i) = numeros(i + 1)
                                algoritmos(i) = algoritmos(i + 1)
                                ordenes(i) = ordenes(i + 1)
                                resultados(i) = resultados(i + 1)
                                niveles(i) = niveles(i + 1)
                                fechas(i) = fechas(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Numero eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|ordenar_numeros|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen numeros registrados.")
                    Else
                        Console.WriteLine("1) Ordenamiento burbuja")
                        Console.WriteLine("2) Ordenamiento seleccion")
                        Console.WriteLine("3) Ordenamiento insercion")
                        Console.Write("Seleccione el algoritmo: ")
                        Dim tipoAlgoritmo As Integer = Convert.ToInt32(Console.ReadLine())
                        Console.WriteLine("1) Ascendente")
                        Console.WriteLine("2) Descendente")
                        Console.Write("Seleccione el orden: ")
                        Dim tipoOrden As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoAlgoritmo = 1 Then
                            For i As Integer = 0 To cantidad - 2
                                For j As Integer = 0 To cantidad - 2 - i
                                    If tipoOrden = 1 Then
                                        If numeros(j) > numeros(j + 1) Then
                                            Dim temporal As Double = numeros(j)
                                            numeros(j) = numeros(j + 1)
                                            numeros(j + 1) = temporal
                                        End If
                                    ElseIf tipoOrden = 2 Then
                                        If numeros(j) < numeros(j + 1) Then
                                            Dim temporal As Double = numeros(j)
                                            numeros(j) = numeros(j + 1)
                                            numeros(j + 1) = temporal
                                        End If
                                    End If
                                Next
                            Next
                            Console.WriteLine("Numeros ordenados mediante Burbuja.")
                        ElseIf tipoAlgoritmo = 2 Then
                            For i As Integer = 0 To cantidad - 2
                                Dim posicion As Integer = i
                                For j As Integer = i + 1 To cantidad - 1
                                    If tipoOrden = 1 Then
                                        If numeros(j) < numeros(posicion) Then
                                            posicion = j
                                        End If
                                    ElseIf tipoOrden = 2 Then
                                        If numeros(j) > numeros(posicion) Then
                                            posicion = j
                                        End If
                                    End If
                                Next
                                Dim temporal As Double = numeros(i)
                                numeros(i) = numeros(posicion)
                                numeros(posicion) = temporal
                            Next
                            Console.WriteLine("Numeros ordenados mediante Seleccion.")
                        ElseIf tipoAlgoritmo = 3 Then
                            For i As Integer = 1 To cantidad - 1
                                Dim actual As Double = numeros(i)
                                Dim j As Integer = i - 1
                                If tipoOrden = 1 Then
                                    While j >= 0 AndAlso numeros(j) > actual
                                        numeros(j + 1) = numeros(j)
                                        j -= 1
                                    End While
                                ElseIf tipoOrden = 2 Then
                                    While j >= 0 AndAlso numeros(j) < actual
                                        numeros(j + 1) = numeros(j)
                                        j -= 1
                                    End While
                                End If
                                numeros(j + 1) = actual
                            Next
                            Console.WriteLine("Numeros ordenados mediante Insercion.")
                        Else
                            Console.WriteLine("Algoritmo no valido.")
                        End If
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Numero: " & numeros(i) & " | Algoritmo: " & algoritmos(i) & " | Orden: " & ordenes(i) & " | Resultado: " & resultados(i) & " | Nivel: " & niveles(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Algoritmo de Ordenamiento.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module