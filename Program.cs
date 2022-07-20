// See https://aka.ms/new-console-template for more information


var qwerty = new Tree<int>(1);
var qwert = new Tree<int>(2);
var qwer = new Tree<int>(3);
var qwe = new Tree<int>(4);
var qw = new Tree<int>(5);


qwert.AddChild(qwer);
qwe.AddChild(qw);
qwerty.AddChild(qwert);
qwerty.AddChild(qwe);

foreach (var item in Recorridos.PreOrden(qwerty))
{
    System.Console.WriteLine(item.Value);
}
System.Console.WriteLine("////////////////");


foreach (var item in Recorridos.PosOrden(qwerty))
{
    System.Console.WriteLine(item.Value);
}


System.Console.WriteLine("***************");

var uno = new BinarianTree<int>(1);
var dos = new BinarianTree<int>(2);
var tres = new BinarianTree<int>(3);
var cuatro = new BinarianTree<int>(4);
var cinco = new BinarianTree<int>(5);
var seis = new BinarianTree<int>(6);
var siete = new BinarianTree<int>(7);
var ocho = new BinarianTree<int>(8);
var nueve = new BinarianTree<int>(9);
var diez = new BinarianTree<int>(10);


cuatro.AddChild(nueve, true);
cuatro.AddChild(ocho, false);

cinco.AddChild(diez, false);

dos.AddChild(cuatro, false);
dos.AddChild(cinco, true);

tres.AddChild(seis, false);
tres.AddChild(siete, true);

uno.AddChild(dos, false);
uno.AddChild(tres, true);

foreach (var item in Recorridos.InOrden(uno))
{
    System.Console.WriteLine(item.Value);
}




