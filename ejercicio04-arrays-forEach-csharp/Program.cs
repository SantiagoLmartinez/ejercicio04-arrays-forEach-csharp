/*
Supongamos que trabajamos en el departamento antifraude de una empresa que relaciona a vendedores en línea con anunciantes 
que trabajan a comisión. Nuestros anunciantes nos han informado de un aumento reciente de las anulaciones de transacciones
en tarjetas de crédito. Estas anulaciones se producen unos meses más tarde de que se hayan pagado las comisiones,
mucho después de que los ladrones hayan desaparecido. Nos han pedido que revisemos varios pedidos con el fin de identificar
los marcadores de fraude. Es posible que nuestra empresa pueda usar esos marcadores en el futuro para identificar posibles
compras fraudulentas.

Paso 1: declarar una matriz nueva.
 */
Console.WriteLine($" 1 ------------------- ");

string[] posiblesFraudesId = new string[3];
posiblesFraudesId[0] = "a1b2c3";
posiblesFraudesId[1] = "b2b2c3";
posiblesFraudesId[2] = "c3b2c3";

Console.WriteLine($" 1ro - {posiblesFraudesId[0]}");
Console.WriteLine($" 2do - {posiblesFraudesId[1]}");
Console.WriteLine($" 3ro - {posiblesFraudesId[2]}");

Console.WriteLine($" ------------------- ");

// le reasginamos valor al [0]
posiblesFraudesId[0] = "alerta-FRAUDE-a1b2c3";
Console.WriteLine($" Reasignado por ALERTA - {posiblesFraudesId[0]}");

//al crear el array le asignamos valor 
string[] posiblesFraudesId2 = {"a1", "b2", "c3" };
Console.WriteLine($" 1ro - {posiblesFraudesId2[0]}");
Console.WriteLine($" 2do - {posiblesFraudesId2[1]}");
Console.WriteLine($" 3ro - {posiblesFraudesId2[2]}");

/*
 Paso 1: crear e inicializar una matriz de números enteros (int).
 Paso 2: agregar una instrucción “foreach” para recorrer en iteración la matriz.
 Paso 3: agregar una variable para sumar el valor de cada elemento de la matriz.

Paso 4: crear una variable que contenga el número del contenedor actual y que muestre la suma acumulativa
Para cumplir el requisito final, es necesario crear una variable que contenga la iteración actual de la instrucción
foreach para que podamos mostrar el contenedor y el número de elementos terminados en ese contenedor, junto con la suma
acumulativa de todos los elementos de los contenedores que se han contabilizado hasta el momento.

Encima de la instrucción foreach, declare e inicialice una nueva variable de tipo int para almacenar el número 
actual del contenedor cuyo inventario se está procesando.
 */
Console.WriteLine($" 2 ------------------- ");

int[] inventario = { 200, 450, 700, 175, 250 };
int sumaItemsInventario = 0;
int stockDeProducto = 0;

foreach(var item in inventario)
{
    sumaItemsInventario += item;
    stockDeProducto++;
    Console.WriteLine($"Producto {stockDeProducto}: {item}.");

}
Console.WriteLine($" Total de items en inventario : {sumaItemsInventario}.");

Console.WriteLine($" 3 ------------------- ");

/*
Estos son los datos de los identificadores de pedido falsos que debe usar para inicializar la matriz.
    B123 C234 A345 C15 B177 G3003 C235 B179

Paso 1: recorrer en iteración cada elemento de la matriz.
Paso 2: si el identificador de pedido falso comienza por la letra “B”, imprimir el identificador de pedido en la salida.

 */

string[] IdDePedidos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach(var item in IdDePedidos)
{
    string UPPER = item.ToUpper();
    
    if (UPPER.StartsWith("B"))
    {
        Console.WriteLine(UPPER);
    }
}