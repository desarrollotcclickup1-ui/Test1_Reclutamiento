# Test1_Reclutamiento
Prueba de programación para el equipo de Tempo Control

## Información inicial
Esta es una Aplicación de consola en .Net 9, trabajarlo con Visual Studio Code, el proyecto ya cuenta con los modelos a utilizar, y las clases de servicios en donde vas a trabajar.
  Restricciones generales
    Trabajar solo en memoria
    Codigo estructurado en clases
    Manero de errores

## Parte 1 - Procesamiento de transacciones
Se tiene una lista de transacciones con la siguiente estructura:

 - Id (int)
 - Usuario (string)
 - Monto (decimal)
 - Fecha (DateTime)

  ### Objetivo
  
    Implementar una funcionalidad que:
    
    1. Filtre transacciones con monto mayor a 500  
    
    2. Ignore montos negativos
    
    3. Agrupe las transacciones por usuario
    
    4. Calcule el total de monto por usuario
    
    5. Ordene los resultados de mayor a menor
    
    6. Muestre el usuario con mayor gasto

## Parte 2 - Sistema Inventario
  Se requiere implementar un sistema que permita:
  
    1. Agregar productos
    
    2. Vender productos (disminuir stock)
    
    3. Reabastecer productos (aumentar stock)
    
    4. Listar productos
  
  ### Reglas
  
    No permitir IDs duplicados
    
    No permitir stock negativo
    
    Validar existencia del producto
    
    Manejar errores

## Parte 3 - Compresión de string
  Dado un string, comprimirlo contando caracteres consecutivos.

    ### Ejemplo
    
      Entrada: aabbbccccdd
      Salida: a2b3c4d2
    
    ### Casos a considerar
    
      "abc" → a1b1c1
      
      "" → ""
      
      "a" → a1
