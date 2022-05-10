using AdapteTirgull;

//Implementaion Dollar Payment class
IDollarPaycs dollarsPay = new DollarPaycs();
dollarsPay.Payment(12);
//Implementaion Euro Payment class
InEuroPay euroPay = new EuroPay();
euroPay.Payment(13.5);
//Implementaion Adapte Payment class
InEuroPay euroConvertToDollar = new AdaptClass();
euroConvertToDollar.Payment(15.2);

