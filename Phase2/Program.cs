IPayment UpiPayment = new UpiPayment();

PaymentService paymentService = new PaymentService(UpiPayment);


paymentService.ProcessPayment(100.00m);