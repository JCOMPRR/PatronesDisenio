using Adapter;

IPago pago = new PagoTransferencia();
Ventas venta = new Ventas(pago);
venta.ProcesarPago();

IPago pago1 = new PagoEfectivo();
Ventas venta1 = new Ventas(pago1);
venta1.ProcesarPago();

IPago pagoTC = new PagoTarjetaCredito("7643");
Ventas ventaTC = new Ventas(pagoTC);
ventaTC.ProcesarPago();

IPago pagoTB = new PagoVacas();
Ventas ventaTB = new Ventas(pagoTB);
ventaTB.ProcesarPago();

IPago pagoBtc = new PagoBitcoin("9023");
Ventas ventaBtc = new Ventas(pagoBtc);
ventaBtc.ProcesarPago();

IPago pagoP = new PagoPrepago("82");
Ventas ventaP = new Ventas(pagoP);
ventaP.ProcesarPago();

IPago pagoCh = new PagoCheques("9812");
Ventas ventaCh = new Ventas(pagoCh);
ventaCh.ProcesarPago();

IPago pagoPp = new PagoPaypal();
Ventas ventaPp = new Ventas(pagoPp);
ventaPp.ProcesarPago();
