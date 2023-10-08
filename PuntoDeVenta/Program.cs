using PuntoDeVenta;

//Adapter
IPagoPV pago = new PagoEfectivoAdapter();
VentasAdapter venta = new VentasAdapter(pago);
venta.ProcesarPago();


//Strategy
ProductoPV producto = new ProductoPV(new DescuentoEfectivoStrategy());
producto.Nombre = "Kfreeze";
producto.Precio = 80m;

Console.WriteLine($"El descuento que se aplico es del: {producto.Descuento / producto.Precio}%");

//Decorator

List<string> productos = new List<string>()
{
    "Nieve, ", "Canela y ", "Oreo"
};

ICargoExtraDecorator cargoExtraDecorator = new CargoExtraDecorator(new VentaExtra(productos), producto.Precio + 80);
Console.WriteLine($"Si desea agregar {string.Join("", productos)} serian:{cargoExtraDecorator}");
Console.WriteLine($"Total del {producto.Nombre}: {producto.Descuento}");

