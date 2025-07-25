﻿namespace BlazorViewer_CustomStore.Data;

/// <summary>
/// Provides static data resources.
/// </summary>
public static partial class Data
{
	public static string AcmeStore =
		@"region(String),city(String),year(Integer),order_price(Integer),product_item(String),product_category(String),customer_age(Integer),purchase_method(String),payment_method(String)
NA,Las Vegas,2016,135,Aute,Electronics,64,Online,Check
NA,Las Vegas,2016,59,Dolore,Transport,31,Phone,Card
NA,Las Vegas,2016,88,Eiusmod,Food,47,In-store,Check
NA,Las Vegas,2016,39,Exercitation,Food,33,In-store,Check
NA,Las Vegas,2016,26,Ex,Food,15,In-store,Card
NA,Las Vegas,2016,77,Sit,Sport,64,Phone,Check
NA,Las Vegas,2016,86,Do,Tools,35,Online,Check
NA,Las Vegas,2016,14,Nostrud,Food,32,Phone,Check
NA,Las Vegas,2016,70,Consequat,Jewelry,54,Phone,Check
NA,Las Vegas,2016,113,Lorem,Transport,40,In-store,Check
NA,Las Vegas,2016,17,Occaecat,Sport,50,Phone,Card
NA,Las Vegas,2017,70,Aute,Transport,47,In-store,Cash
NA,Las Vegas,2017,14,Commodo,Fashion,24,Phone,Card
NA,Las Vegas,2017,108,Non,Tools,55,Online,Check
NA,Las Vegas,2017,83,Esse,Transport,25,Phone,Check
NA,Las Vegas,2017,91,Excepteur,Transport,31,Online,Card
NA,Las Vegas,2017,88,Cillum,Sport,23,Online,Card
NA,Las Vegas,2017,9,Cupidatat,Toys,43,In-store,Check
NA,Las Vegas,2018,40,Dolore,Sport,55,Online,Check
NA,Las Vegas,2018,5,Pariatur,Food,66,Online,Card
NA,Las Vegas,2018,108,Enim,Sport,35,In-store,Cash
NA,Las Vegas,2018,76,Commodo,Electronics,51,Online,Check
NA,Las Vegas,2018,87,Consequat,Jewelry,17,In-store,Card
NA,Las Vegas,2018,66,Ullamco,Tools,29,In-store,Card
NA,Las Vegas,2018,67,Sunt,Sport,41,Phone,Card
NA,Las Vegas,2018,49,Labore,Toys,27,In-store,Check
NA,Las Vegas,2018,84,Incididunt,Transport,38,Online,Check
NA,Las Vegas,2018,86,Elit,Food,24,In-store,Check
NA,Las Vegas,2019,127,Enim,Fashion,25,In-store,Check
NA,Las Vegas,2019,93,Adipisicing,Transport,46,Online,Card
NA,Las Vegas,2019,75,Deserunt,Fashion,57,Online,Check
NA,Las Vegas,2019,72,Tempor,Sport,49,Phone,Check
NA,Las Vegas,2019,96,Enim,Fashion,15,Phone,Card
NA,Las Vegas,2019,91,Quis,Sport,24,In-store,Check
NA,Las Vegas,2019,69,Elit,Toys,53,Online,Card
NA,Las Vegas,2019,131,Proident,Tools,44,In-store,Cash
NA,Las Vegas,2019,72,Adipisicing,Jewelry,44,Phone,Check
NA,Las Vegas,2019,54,Ipsum,Food,28,Phone,Check
NA,Miami,2016,30,Ipsum,Healthcare,38,In-store,Cash
NA,Miami,2016,134,Culpa,Toys,58,Online,Card
NA,Miami,2016,42,Fugiat,Food,37,In-store,Cash
NA,Miami,2016,118,Proident,Tools,50,In-store,Check
NA,Miami,2016,44,Duis,Sport,62,Online,Card
NA,Miami,2016,113,Eu,Fashion,24,Phone,Check
NA,Miami,2016,34,Minim,Services,55,Online,Check
NA,Miami,2016,86,Aliqua,Food,67,Phone,Card
NA,Miami,2016,99,Deserunt,Food,59,In-store,Check
NA,Miami,2017,113,Irure,Sport,59,Online,Check
NA,Miami,2017,115,Aliquip,Toys,35,Phone,Card
NA,Miami,2017,89,Minim,Fashion,28,Online,Check
NA,Miami,2017,119,Ex,Healthcare,26,Phone,Card
NA,Miami,2017,68,Incididunt,Tools,26,Phone,Check
NA,Miami,2017,52,Enim,Food,21,Phone,Card
NA,Miami,2017,61,Exercitation,Healthcare,59,Phone,Card
NA,Miami,2017,132,Ad,Food,25,Phone,Check
NA,Miami,2017,138,Dolore,Jewelry,27,In-store,Card
NA,Miami,2017,73,Aliqua,Toys,37,Online,Card
NA,Miami,2018,43,Excepteur,Food,58,Phone,Check
NA,Miami,2018,96,Aliqua,Food,26,Online,Card
NA,Miami,2018,66,Anim,Sport,61,Phone,Card
NA,Miami,2018,76,Sit,Services,65,In-store,Card
NA,Miami,2018,139,Qui,Services,21,In-store,Cash
NA,Miami,2018,12,Mollit,Food,48,In-store,Cash
NA,Miami,2018,136,Tempor,Fashion,15,Phone,Check
NA,Miami,2018,129,Adipisicing,Transport,41,Online,Check
NA,Miami,2018,125,Aute,Fashion,43,Phone,Card
NA,Miami,2019,39,Incididunt,Fashion,35,In-store,Card
NA,Miami,2019,133,Adipisicing,Food,56,Phone,Card
NA,Miami,2019,41,Exercitation,Healthcare,20,Online,Card
NA,Miami,2019,111,Pariatur,Tools,17,Online,Check
NA,Miami,2019,138,Exercitation,Tools,45,Online,Check
NA,Miami,2019,103,Veniam,Healthcare,40,Phone,Check
NA,Miami,2019,38,Exercitation,Toys,31,Phone,Card
NA,Miami,2019,89,Nisi,Sport,19,In-store,Card
NA,Miami,2019,36,Tempor,Transport,16,In-store,Cash
NA,Chicago,2016,30,Adipisicing,Jewelry,39,In-store,Card
NA,Chicago,2016,63,Reprehenderit,Fashion,36,Phone,Card
NA,Chicago,2016,77,Officia,Healthcare,54,In-store,Card
NA,Chicago,2016,17,Nulla,Services,22,Online,Check
NA,Chicago,2016,135,Aliquip,Jewelry,55,Phone,Card
NA,Chicago,2016,37,Occaecat,Electronics,70,Online,Check
NA,Chicago,2016,125,Id,Electronics,52,Phone,Check
NA,Chicago,2017,133,Cupidatat,Sport,69,In-store,Cash
NA,Chicago,2017,58,Labore,Healthcare,43,In-store,Card
NA,Chicago,2017,19,Ea,Tools,40,Online,Check
NA,Chicago,2017,27,Amet,Electronics,67,In-store,Cash
NA,Chicago,2017,58,Occaecat,Fashion,16,Phone,Check
NA,Chicago,2017,64,Consectetur,Sport,50,Phone,Check
NA,Chicago,2017,46,Culpa,Electronics,65,Phone,Check
NA,Chicago,2018,60,Ut,Jewelry,23,Online,Card
NA,Chicago,2018,25,Exercitation,Healthcare,28,Phone,Check
NA,Chicago,2018,128,Est,Transport,64,In-store,Card
NA,Chicago,2018,124,Ex,Sport,50,In-store,Card
NA,Chicago,2018,69,Incididunt,Tools,69,Online,Card
NA,Chicago,2018,114,Ipsum,Transport,19,In-store,Cash
NA,Chicago,2018,125,Ut,Tools,43,Online,Card
NA,Chicago,2018,147,Adipisicing,Transport,32,In-store,Cash
NA,Chicago,2018,59,Lorem,Fashion,31,In-store,Card
NA,Chicago,2019,134,Non,Toys,49,Online,Check
NA,Chicago,2019,134,Lorem,Sport,65,Online,Card
NA,Chicago,2019,149,Commodo,Electronics,31,Phone,Check
NA,Chicago,2019,132,Veniam,Services,22,Online,Check
NA,Chicago,2019,10,Qui,Toys,42,Online,Check
NA,Chicago,2019,123,Consectetur,Transport,18,In-store,Card
NA,Chicago,2019,59,Est,Toys,38,Online,Card
NA,Seattle,2016,130,Ut,Sport,70,Phone,Check
NA,Seattle,2016,132,Cillum,Sport,31,Online,Check
NA,Seattle,2016,85,Nostrud,Sport,27,Phone,Check
NA,Seattle,2016,39,Eu,Toys,32,In-store,Cash
NA,Seattle,2016,13,Id,Healthcare,49,In-store,Cash
NA,Seattle,2016,14,Sunt,Services,53,Phone,Check
NA,Seattle,2016,108,Est,Tools,25,Online,Card
NA,Seattle,2016,73,Nulla,Healthcare,38,Online,Check
NA,Seattle,2016,125,Nisi,Transport,45,Phone,Card
NA,Seattle,2016,119,Amet,Services,65,Online,Check
NA,Seattle,2017,110,Sint,Toys,58,Phone,Card
NA,Seattle,2017,131,Voluptate,Services,35,In-store,Card
NA,Seattle,2017,106,Aliqua,Electronics,61,Phone,Card
NA,Seattle,2017,91,Lorem,Fashion,16,Phone,Check
NA,Seattle,2017,121,Labore,Transport,38,Online,Card
NA,Seattle,2017,61,Mollit,Toys,66,Phone,Card
NA,Seattle,2017,123,Do,Tools,66,In-store,Card
NA,Seattle,2017,147,Nostrud,Electronics,30,Online,Card
NA,Seattle,2017,145,Elit,Food,28,Phone,Card
NA,Seattle,2017,51,Deserunt,Services,54,Phone,Card
NA,Seattle,2017,134,Qui,Transport,50,Phone,Check
NA,Seattle,2017,97,Sint,Sport,65,Phone,Check
NA,Seattle,2017,149,Voluptate,Jewelry,17,Online,Check
NA,Seattle,2018,62,Elit,Tools,16,In-store,Card
NA,Seattle,2018,40,Nisi,Jewelry,34,In-store,Cash
NA,Seattle,2018,67,Reprehenderit,Transport,25,Online,Card
NA,Seattle,2018,108,Aliquip,Healthcare,59,In-store,Card
NA,Seattle,2018,103,Labore,Healthcare,56,In-store,Cash
NA,Seattle,2018,47,Et,Sport,58,In-store,Card
NA,Seattle,2018,132,Eiusmod,Healthcare,27,Online,Check
NA,Seattle,2019,37,Veniam,Healthcare,34,Online,Card
NA,Seattle,2019,13,Esse,Jewelry,28,Phone,Check
NA,Seattle,2019,83,Officia,Services,25,In-store,Card
NA,Seattle,2019,23,Officia,Electronics,58,Online,Check
NA,Seattle,2019,13,Dolore,Services,53,In-store,Cash
NA,Seattle,2019,4,Cillum,Services,66,In-store,Cash
NA,Seattle,2019,111,Enim,Transport,15,Online,Card
NA,Seattle,2019,57,Lorem,Food,31,Phone,Card
LA,Panama,2016,84,Magna,Tools,60,Phone,Check
LA,Panama,2016,5,Ea,Healthcare,30,Phone,Check
LA,Panama,2016,69,Nisi,Services,26,Online,Check
LA,Panama,2016,46,Culpa,Transport,66,Online,Card
LA,Panama,2016,81,Et,Electronics,24,Online,Card
LA,Panama,2016,105,Amet,Jewelry,68,Online,Card
LA,Panama,2016,117,Ad,Healthcare,18,In-store,Cash
LA,Panama,2016,66,Duis,Healthcare,42,Online,Check
LA,Panama,2017,82,Lorem,Electronics,63,Online,Check
LA,Panama,2017,146,Est,Fashion,24,Online,Card
LA,Panama,2017,41,Incididunt,Food,19,In-store,Cash
LA,Panama,2017,45,Eu,Transport,31,Phone,Check
LA,Panama,2017,79,Elit,Tools,58,Online,Check
LA,Panama,2017,111,Cupidatat,Healthcare,46,Online,Card
LA,Panama,2017,34,Tempor,Healthcare,29,In-store,Cash
LA,Panama,2017,97,Esse,Transport,15,In-store,Cash
LA,Panama,2018,148,Eu,Food,60,Online,Card
LA,Panama,2018,76,Eu,Services,30,Online,Check
LA,Panama,2018,65,Laborum,Healthcare,58,In-store,Check
LA,Panama,2018,8,Duis,Electronics,16,In-store,Card
LA,Panama,2018,86,Esse,Transport,67,Phone,Card
LA,Panama,2018,90,Sunt,Transport,36,Online,Card
LA,Panama,2018,16,Velit,Sport,37,In-store,Card
LA,Panama,2018,25,Pariatur,Transport,60,Online,Check
LA,Panama,2018,114,Pariatur,Food,31,Phone,Card
LA,Panama,2018,79,Culpa,Fashion,41,Online,Card
LA,Panama,2018,102,Culpa,Healthcare,43,Online,Check
LA,Panama,2019,36,Duis,Toys,22,Online,Card
LA,Panama,2019,25,Excepteur,Toys,65,Phone,Check
LA,Panama,2019,117,Magna,Tools,23,In-store,Check
LA,Panama,2019,144,Tempor,Services,55,Phone,Check
LA,Panama,2019,100,Consequat,Services,62,Online,Check
LA,Panama,2019,59,Velit,Food,59,Phone,Check
LA,Panama,2019,29,Sunt,Transport,17,Online,Card
LA,Cali,2016,100,Sunt,Toys,61,In-store,Card
LA,Cali,2016,111,Tempor,Healthcare,50,Online,Card
LA,Cali,2016,118,Excepteur,Fashion,30,Online,Check
LA,Cali,2016,50,Nulla,Toys,43,Online,Check
LA,Cali,2016,83,Et,Electronics,36,In-store,Card
LA,Cali,2016,124,Cillum,Fashion,29,In-store,Card
LA,Cali,2016,139,Reprehenderit,Fashion,24,Phone,Check
LA,Cali,2016,66,Laborum,Sport,23,Online,Check
LA,Cali,2016,35,Ullamco,Fashion,28,Online,Check
LA,Cali,2016,117,Occaecat,Tools,38,In-store,Cash
LA,Cali,2017,75,Officia,Jewelry,50,In-store,Cash
LA,Cali,2017,91,Est,Jewelry,70,Online,Card
LA,Cali,2017,94,Adipisicing,Fashion,19,In-store,Card
LA,Cali,2017,118,Ea,Sport,30,Phone,Check
LA,Cali,2017,13,Nulla,Electronics,50,In-store,Card
LA,Cali,2017,51,Do,Electronics,46,In-store,Cash
LA,Cali,2017,124,Tempor,Healthcare,24,Online,Check
LA,Cali,2017,66,Aute,Sport,58,Phone,Check
LA,Cali,2018,76,Mollit,Sport,64,Online,Card
LA,Cali,2018,84,Proident,Healthcare,28,Phone,Card
LA,Cali,2018,131,Aute,Services,45,Phone,Card
LA,Cali,2018,13,Duis,Electronics,41,In-store,Check
LA,Cali,2018,51,In,Food,31,Online,Check
LA,Cali,2018,63,Deserunt,Jewelry,50,In-store,Cash
LA,Cali,2018,147,Sunt,Transport,41,Online,Card
LA,Cali,2018,9,Lorem,Healthcare,53,Online,Card
LA,Cali,2018,147,Aliqua,Toys,44,In-store,Check
LA,Cali,2018,10,Magna,Jewelry,45,In-store,Check
LA,Cali,2019,24,Mollit,Tools,30,In-store,Check
LA,Cali,2019,82,Tempor,Healthcare,33,Online,Check
LA,Cali,2019,30,Mollit,Jewelry,34,In-store,Check
LA,Cali,2019,97,Officia,Fashion,29,In-store,Cash
LA,Cali,2019,74,Velit,Toys,58,Phone,Card
LA,Cali,2019,82,Cillum,Toys,55,Online,Check
LA,Cali,2019,116,Mollit,Fashion,26,Phone,Card
LA,Cali,2019,50,In,Tools,59,Online,Card
LA,Cali,2019,20,Pariatur,Transport,27,In-store,Check
LA,Mexico,2016,65,Adipisicing,Transport,23,Online,Check
LA,Mexico,2016,72,Officia,Tools,53,In-store,Cash
LA,Mexico,2016,47,Reprehenderit,Fashion,22,Phone,Card
LA,Mexico,2016,41,Exercitation,Jewelry,53,Phone,Check
LA,Mexico,2016,11,Velit,Tools,49,In-store,Card
LA,Mexico,2016,67,Ad,Electronics,30,Online,Check
LA,Mexico,2016,103,Fugiat,Food,28,Online,Card
LA,Mexico,2016,15,Nulla,Sport,39,In-store,Cash
LA,Mexico,2016,149,Dolore,Food,69,Phone,Card
LA,Mexico,2016,46,Qui,Services,45,In-store,Check
LA,Mexico,2016,145,Dolore,Electronics,69,Online,Check
LA,Mexico,2017,4,Minim,Sport,15,Online,Check
LA,Mexico,2017,136,Aute,Tools,58,Phone,Card
LA,Mexico,2017,45,Aliquip,Jewelry,45,Online,Card
LA,Mexico,2017,57,Eu,Electronics,20,Phone,Check
LA,Mexico,2017,62,Et,Transport,58,Phone,Card
LA,Mexico,2017,137,Fugiat,Toys,33,Online,Check
LA,Mexico,2017,118,Sunt,Fashion,39,Phone,Card
LA,Mexico,2017,87,Aute,Food,43,Phone,Card
LA,Mexico,2017,30,Eiusmod,Toys,61,In-store,Cash
LA,Mexico,2017,78,Nostrud,Healthcare,50,Phone,Check
LA,Mexico,2018,22,Dolore,Fashion,16,Online,Card
LA,Mexico,2018,59,Sit,Transport,65,Online,Check
LA,Mexico,2018,79,Nisi,Healthcare,67,Phone,Check
LA,Mexico,2018,116,Do,Sport,41,Online,Card
LA,Mexico,2018,106,Fugiat,Toys,34,Online,Check
LA,Mexico,2018,42,Mollit,Tools,20,Online,Card
LA,Mexico,2018,27,Amet,Fashion,68,In-store,Cash
LA,Mexico,2018,25,Do,Toys,29,In-store,Check
LA,Mexico,2018,48,Ullamco,Sport,46,Online,Card
LA,Mexico,2018,145,Et,Services,34,Phone,Card
LA,Mexico,2018,79,Mollit,Electronics,25,In-store,Cash
LA,Mexico,2018,12,Culpa,Tools,33,In-store,Cash
LA,Mexico,2019,82,Cupidatat,Jewelry,66,In-store,Cash
LA,Mexico,2019,70,Sit,Services,61,Online,Card
LA,Mexico,2019,49,Dolore,Healthcare,62,Phone,Check
LA,Mexico,2019,69,Reprehenderit,Jewelry,39,Online,Card
LA,Mexico,2019,84,Anim,Fashion,40,In-store,Check
LA,Mexico,2019,145,Pariatur,Services,28,In-store,Card
LA,Mexico,2019,28,Commodo,Food,54,Phone,Check
LA,Mexico,2019,45,Exercitation,Toys,59,Phone,Check
LA,Mexico,2019,148,Minim,Healthcare,34,In-store,Check
LA,Buenos Aires,2016,106,Officia,Fashion,35,Phone,Check
LA,Buenos Aires,2016,121,Labore,Jewelry,49,In-store,Card
LA,Buenos Aires,2016,10,Ad,Tools,46,In-store,Card
LA,Buenos Aires,2016,120,Ea,Tools,35,Online,Card
LA,Buenos Aires,2016,91,Ea,Food,37,Online,Check
LA,Buenos Aires,2016,113,Ad,Tools,63,Phone,Card
LA,Buenos Aires,2016,81,Fugiat,Sport,20,In-store,Cash
LA,Buenos Aires,2016,70,Duis,Jewelry,29,Online,Check
LA,Buenos Aires,2016,8,Ad,Transport,15,Online,Card
LA,Buenos Aires,2016,128,Ea,Healthcare,35,Phone,Check
LA,Buenos Aires,2016,85,Ipsum,Healthcare,61,In-store,Check
LA,Buenos Aires,2016,89,Labore,Jewelry,22,Online,Check
LA,Buenos Aires,2016,143,Quis,Fashion,49,Phone,Card
LA,Buenos Aires,2017,29,Amet,Electronics,65,Phone,Card
LA,Buenos Aires,2017,85,Dolore,Electronics,40,Phone,Card
LA,Buenos Aires,2017,78,Nisi,Fashion,34,In-store,Card
LA,Buenos Aires,2017,131,Ipsum,Jewelry,62,Online,Check
LA,Buenos Aires,2017,81,Duis,Toys,67,Phone,Card
LA,Buenos Aires,2017,103,Eu,Transport,69,Online,Check
LA,Buenos Aires,2017,106,Eu,Healthcare,34,Online,Card
LA,Buenos Aires,2018,40,Reprehenderit,Fashion,28,Online,Card
LA,Buenos Aires,2018,104,Ullamco,Fashion,55,Online,Card
LA,Buenos Aires,2018,61,Elit,Electronics,53,In-store,Check
LA,Buenos Aires,2018,116,Consectetur,Sport,26,Phone,Card
LA,Buenos Aires,2018,108,Officia,Healthcare,70,Phone,Check
LA,Buenos Aires,2018,55,Tempor,Fashion,25,Online,Card
LA,Buenos Aires,2018,91,Est,Sport,61,Online,Check
LA,Buenos Aires,2018,38,Eiusmod,Jewelry,18,Online,Check
LA,Buenos Aires,2018,15,Magna,Electronics,27,In-store,Card
LA,Buenos Aires,2018,69,Laborum,Toys,34,Phone,Card
LA,Buenos Aires,2018,90,Ut,Sport,61,Online,Check
LA,Buenos Aires,2018,29,Dolore,Electronics,39,In-store,Card
LA,Buenos Aires,2018,49,Et,Electronics,29,Phone,Card
LA,Buenos Aires,2019,89,Sit,Jewelry,57,Phone,Check
LA,Buenos Aires,2019,75,Cupidatat,Tools,31,Phone,Card
LA,Buenos Aires,2019,113,Aute,Jewelry,29,Online,Card
LA,Buenos Aires,2019,12,Adipisicing,Healthcare,35,Phone,Card
LA,Buenos Aires,2019,50,Nisi,Transport,31,Online,Card
LA,Buenos Aires,2019,12,Ad,Services,65,In-store,Card
LA,Buenos Aires,2019,33,Exercitation,Tools,37,Phone,Card
LA,Buenos Aires,2019,76,Veniam,Jewelry,23,Phone,Card
LA,Buenos Aires,2019,136,Deserunt,Jewelry,27,Phone,Card
LA,Buenos Aires,2019,61,Sint,Transport,24,Online,Check
EMEA,Amsterdam,2016,50,Laboris,Jewelry,52,Online,Card
EMEA,Amsterdam,2016,81,Duis,Food,65,Phone,Card
EMEA,Amsterdam,2016,48,Deserunt,Jewelry,49,In-store,Cash
EMEA,Amsterdam,2016,39,In,Fashion,70,Phone,Check
EMEA,Amsterdam,2016,69,Minim,Fashion,52,Phone,Card
EMEA,Amsterdam,2016,94,Aute,Electronics,15,In-store,Card
EMEA,Amsterdam,2016,35,Et,Electronics,20,In-store,Cash
EMEA,Amsterdam,2016,82,Ullamco,Food,35,Online,Card
EMEA,Amsterdam,2016,76,Elit,Transport,33,Online,Card
EMEA,Amsterdam,2016,149,Labore,Healthcare,36,Phone,Card
EMEA,Amsterdam,2016,30,Cillum,Toys,53,Phone,Card
EMEA,Amsterdam,2017,5,Adipisicing,Jewelry,28,Phone,Card
EMEA,Amsterdam,2017,32,Proident,Jewelry,62,In-store,Check
EMEA,Amsterdam,2017,19,Eiusmod,Electronics,27,Online,Card
EMEA,Amsterdam,2017,114,Magna,Jewelry,66,In-store,Cash
EMEA,Amsterdam,2017,23,Commodo,Tools,16,In-store,Cash
EMEA,Amsterdam,2017,78,Ex,Tools,46,In-store,Card
EMEA,Amsterdam,2017,41,Consequat,Food,46,Phone,Card
EMEA,Amsterdam,2017,128,Esse,Jewelry,57,Online,Card
EMEA,Amsterdam,2018,142,Fugiat,Food,62,Online,Card
EMEA,Amsterdam,2018,50,Est,Jewelry,25,In-store,Card
EMEA,Amsterdam,2018,49,Duis,Fashion,33,Phone,Card
EMEA,Amsterdam,2018,100,Labore,Electronics,70,Online,Check
EMEA,Amsterdam,2018,88,Non,Services,49,Online,Check
EMEA,Amsterdam,2018,16,Occaecat,Food,45,Online,Card
EMEA,Amsterdam,2018,67,Voluptate,Food,19,In-store,Check
EMEA,Amsterdam,2018,14,Duis,Food,42,Online,Card
EMEA,Amsterdam,2018,92,Deserunt,Jewelry,25,In-store,Card
EMEA,Amsterdam,2018,141,Consectetur,Healthcare,49,In-store,Cash
EMEA,Amsterdam,2018,62,Ullamco,Sport,32,In-store,Cash
EMEA,Amsterdam,2018,93,Duis,Jewelry,30,Online,Check
EMEA,Amsterdam,2018,19,Dolore,Services,40,In-store,Check
EMEA,Amsterdam,2019,30,Cillum,Electronics,30,Online,Check
EMEA,Amsterdam,2019,43,Do,Fashion,59,Online,Card
EMEA,Amsterdam,2019,102,Ea,Transport,47,Online,Card
EMEA,Amsterdam,2019,136,Velit,Tools,41,Online,Check
EMEA,Amsterdam,2019,84,Irure,Electronics,70,Phone,Check
EMEA,Amsterdam,2019,9,Nulla,Jewelry,32,Phone,Card
EMEA,Amsterdam,2019,123,Velit,Food,67,Online,Check
EMEA,Amsterdam,2019,104,Culpa,Electronics,35,In-store,Card
EMEA,Amsterdam,2019,147,Excepteur,Services,66,Phone,Check
EMEA,Amsterdam,2019,39,Lorem,Services,56,Online,Check
EMEA,Amsterdam,2019,71,Dolor,Toys,40,Phone,Check
EMEA,Amsterdam,2019,15,Nulla,Transport,22,Online,Check
EMEA,Riga,2016,95,Ea,Fashion,43,Phone,Card
EMEA,Riga,2016,65,Cupidatat,Services,26,Online,Card
EMEA,Riga,2016,24,Do,Fashion,44,Phone,Check
EMEA,Riga,2016,68,Proident,Healthcare,30,Online,Check
EMEA,Riga,2016,136,Amet,Tools,33,Phone,Check
EMEA,Riga,2016,68,Dolore,Services,39,In-store,Cash
EMEA,Riga,2016,134,Cillum,Toys,35,Phone,Check
EMEA,Riga,2016,91,Ex,Tools,25,Phone,Card
EMEA,Riga,2017,128,Id,Jewelry,69,In-store,Check
EMEA,Riga,2017,149,Lorem,Sport,39,Online,Card
EMEA,Riga,2017,126,Consectetur,Toys,63,Phone,Card
EMEA,Riga,2017,127,Qui,Electronics,53,In-store,Cash
EMEA,Riga,2017,11,Proident,Sport,34,Phone,Card
EMEA,Riga,2017,82,Ut,Electronics,52,Phone,Card
EMEA,Riga,2017,71,Ea,Healthcare,25,In-store,Check
EMEA,Riga,2017,8,Aute,Food,51,Phone,Check
EMEA,Riga,2017,58,Anim,Sport,45,Online,Card
EMEA,Riga,2018,35,Aliquip,Food,17,In-store,Card
EMEA,Riga,2018,33,Magna,Electronics,40,Online,Check
EMEA,Riga,2018,45,Eiusmod,Electronics,16,In-store,Cash
EMEA,Riga,2018,123,Nulla,Healthcare,51,In-store,Card
EMEA,Riga,2018,48,Consequat,Electronics,29,Online,Check
EMEA,Riga,2018,125,Enim,Healthcare,36,In-store,Check
EMEA,Riga,2018,25,Commodo,Healthcare,20,Phone,Check
EMEA,Riga,2018,128,Voluptate,Fashion,24,Phone,Card
EMEA,Riga,2018,56,Quis,Food,36,Online,Card
EMEA,Riga,2019,137,Aliqua,Sport,54,In-store,Cash
EMEA,Riga,2019,99,Velit,Services,39,Online,Card
EMEA,Riga,2019,149,In,Transport,52,Online,Card
EMEA,Riga,2019,91,Aliquip,Electronics,59,Online,Check
EMEA,Riga,2019,46,Officia,Sport,32,Phone,Check
EMEA,Riga,2019,70,Aute,Healthcare,52,Phone,Check
EMEA,Riga,2019,138,Adipisicing,Toys,69,In-store,Check
EMEA,Riga,2019,26,Reprehenderit,Services,66,Phone,Card
EMEA,Istanbul,2016,90,Exercitation,Jewelry,26,Phone,Card
EMEA,Istanbul,2016,54,Occaecat,Healthcare,58,In-store,Card
EMEA,Istanbul,2016,51,Duis,Fashion,43,Online,Check
EMEA,Istanbul,2016,119,Enim,Sport,19,Online,Check
EMEA,Istanbul,2016,11,Nisi,Toys,51,Phone,Check
EMEA,Istanbul,2016,65,Eu,Services,48,Phone,Card
EMEA,Istanbul,2016,21,Laboris,Transport,57,Phone,Check
EMEA,Istanbul,2016,142,Cupidatat,Jewelry,20,In-store,Cash
EMEA,Istanbul,2016,97,Non,Food,28,Online,Card
EMEA,Istanbul,2016,133,Quis,Tools,42,Online,Check
EMEA,Istanbul,2017,9,Excepteur,Electronics,23,In-store,Card
EMEA,Istanbul,2017,45,Sunt,Food,26,Online,Card
EMEA,Istanbul,2017,135,Irure,Healthcare,37,Online,Check
EMEA,Istanbul,2017,88,Amet,Transport,51,Phone,Check
EMEA,Istanbul,2017,85,Tempor,Services,61,In-store,Card
EMEA,Istanbul,2017,35,Sit,Tools,27,Online,Check
EMEA,Istanbul,2017,145,Velit,Fashion,15,Online,Check
EMEA,Istanbul,2017,4,Adipisicing,Transport,61,In-store,Check
EMEA,Istanbul,2017,107,Id,Food,19,In-store,Cash
EMEA,Istanbul,2018,90,Dolor,Healthcare,35,Phone,Check
EMEA,Istanbul,2018,133,Consequat,Healthcare,64,Online,Check
EMEA,Istanbul,2018,30,Consequat,Sport,58,In-store,Card
EMEA,Istanbul,2018,31,Quis,Services,36,Online,Card
EMEA,Istanbul,2018,92,Qui,Electronics,22,Online,Card
EMEA,Istanbul,2018,133,Pariatur,Healthcare,31,Online,Card
EMEA,Istanbul,2018,71,In,Services,43,Online,Check
EMEA,Istanbul,2018,63,Et,Food,21,Phone,Check
EMEA,Istanbul,2018,132,Fugiat,Food,18,Online,Card
EMEA,Istanbul,2019,95,Minim,Transport,30,In-store,Cash
EMEA,Istanbul,2019,18,Consequat,Jewelry,22,Online,Card
EMEA,Istanbul,2019,87,Qui,Food,56,Online,Check
EMEA,Istanbul,2019,45,Aliqua,Fashion,22,In-store,Check
EMEA,Istanbul,2019,95,Eiusmod,Food,35,Online,Card
EMEA,Istanbul,2019,145,Esse,Sport,63,Phone,Check
EMEA,Istanbul,2019,99,Dolor,Food,35,Online,Check
EMEA,Istanbul,2019,80,Sint,Sport,61,In-store,Cash
EMEA,Lagos,2016,6,Irure,Tools,45,In-store,Card
EMEA,Lagos,2016,145,Esse,Toys,15,Phone,Card
EMEA,Lagos,2016,122,Do,Electronics,68,Online,Card
EMEA,Lagos,2016,33,Ex,Toys,38,In-store,Check
EMEA,Lagos,2016,74,Incididunt,Food,33,In-store,Check
EMEA,Lagos,2016,96,Aute,Food,33,Online,Check
EMEA,Lagos,2016,39,Amet,Food,21,In-store,Cash
EMEA,Lagos,2016,123,Id,Services,43,In-store,Check
EMEA,Lagos,2017,14,Nisi,Electronics,61,Online,Card
EMEA,Lagos,2017,109,Est,Services,43,In-store,Check
EMEA,Lagos,2017,139,Exercitation,Electronics,67,Online,Card
EMEA,Lagos,2017,121,Nisi,Sport,54,Phone,Card
EMEA,Lagos,2017,69,Minim,Healthcare,61,In-store,Card
EMEA,Lagos,2017,112,Esse,Toys,34,In-store,Cash
EMEA,Lagos,2017,39,Velit,Tools,60,In-store,Check
EMEA,Lagos,2018,35,Magna,Healthcare,43,Online,Check
EMEA,Lagos,2018,82,Laborum,Fashion,50,Phone,Card
EMEA,Lagos,2018,16,Pariatur,Services,64,In-store,Cash
EMEA,Lagos,2018,15,Fugiat,Food,17,Phone,Card
EMEA,Lagos,2018,16,Aliquip,Toys,53,In-store,Cash
EMEA,Lagos,2018,109,Mollit,Services,26,Phone,Card
EMEA,Lagos,2018,126,Officia,Jewelry,37,Phone,Check
EMEA,Lagos,2018,85,Reprehenderit,Sport,42,Online,Check
EMEA,Lagos,2018,51,Aliqua,Fashion,62,Online,Check
EMEA,Lagos,2018,145,Fugiat,Food,68,Phone,Card
EMEA,Lagos,2018,31,Mollit,Food,38,Phone,Check
EMEA,Lagos,2018,115,Exercitation,Fashion,65,Phone,Card
EMEA,Lagos,2019,24,Deserunt,Services,15,In-store,Check
EMEA,Lagos,2019,128,Do,Jewelry,33,Online,Check
EMEA,Lagos,2019,7,Incididunt,Tools,49,Phone,Card
EMEA,Lagos,2019,127,Ex,Electronics,59,In-store,Check
EMEA,Lagos,2019,48,Esse,Jewelry,68,In-store,Check
EMEA,Lagos,2019,6,Eu,Healthcare,27,In-store,Cash
EMEA,Lagos,2019,72,Fugiat,Sport,68,Phone,Check
AP,Sydney,2016,104,Est,Tools,70,In-store,Cash
AP,Sydney,2016,144,Labore,Tools,66,Phone,Check
AP,Sydney,2016,132,Ut,Services,20,In-store,Card
AP,Sydney,2016,99,Sunt,Tools,24,Online,Card
AP,Sydney,2016,8,Eiusmod,Jewelry,31,In-store,Check
AP,Sydney,2016,68,Nostrud,Food,59,In-store,Check
AP,Sydney,2016,19,Enim,Sport,23,Online,Card
AP,Sydney,2016,32,Aute,Transport,69,In-store,Cash
AP,Sydney,2016,144,Tempor,Fashion,19,In-store,Card
AP,Sydney,2016,46,Veniam,Toys,62,Phone,Check
AP,Sydney,2016,80,Do,Fashion,38,Online,Check
AP,Sydney,2017,23,Incididunt,Transport,27,Online,Check
AP,Sydney,2017,94,Laboris,Electronics,58,Online,Check
AP,Sydney,2017,41,Elit,Toys,33,Online,Check
AP,Sydney,2017,81,Quis,Food,15,Phone,Check
AP,Sydney,2017,115,Ex,Fashion,38,Online,Card
AP,Sydney,2017,46,Mollit,Fashion,50,Phone,Check
AP,Sydney,2017,7,Irure,Jewelry,45,Phone,Card
AP,Sydney,2017,90,Sit,Food,38,Phone,Check
AP,Sydney,2017,113,Magna,Toys,38,In-store,Card
AP,Sydney,2017,29,Cillum,Food,30,Online,Check
AP,Sydney,2017,71,Occaecat,Food,42,In-store,Check
AP,Sydney,2018,36,Aliqua,Electronics,38,Phone,Check
AP,Sydney,2018,147,Commodo,Services,56,In-store,Check
AP,Sydney,2018,35,Eiusmod,Services,32,Online,Card
AP,Sydney,2018,132,Aliquip,Tools,17,Phone,Card
AP,Sydney,2018,141,Adipisicing,Services,58,Phone,Card
AP,Sydney,2018,97,Officia,Sport,39,In-store,Cash
AP,Sydney,2018,66,Laboris,Transport,58,Phone,Check
AP,Sydney,2019,126,Pariatur,Tools,20,Online,Check
AP,Sydney,2019,128,Aute,Food,56,Online,Card
AP,Sydney,2019,83,Do,Jewelry,45,Phone,Check
AP,Sydney,2019,145,Consectetur,Tools,40,Phone,Card
AP,Sydney,2019,4,Tempor,Healthcare,70,Phone,Card
AP,Sydney,2019,146,Deserunt,Jewelry,45,Online,Check
AP,Sydney,2019,110,Ea,Transport,53,In-store,Card
AP,Osaka,2016,57,Aliqua,Tools,37,Online,Check
AP,Osaka,2016,58,Pariatur,Transport,26,Online,Check
AP,Osaka,2016,115,Aute,Food,34,Phone,Check
AP,Osaka,2016,112,Eiusmod,Electronics,33,Online,Card
AP,Osaka,2016,6,Ullamco,Food,39,In-store,Card
AP,Osaka,2016,125,Aliquip,Transport,57,Phone,Card
AP,Osaka,2016,140,Lorem,Healthcare,55,Online,Card
AP,Osaka,2016,6,Culpa,Toys,34,Phone,Card
AP,Osaka,2016,12,Sint,Toys,51,In-store,Check
AP,Osaka,2016,146,Deserunt,Transport,26,Phone,Card
AP,Osaka,2016,22,Reprehenderit,Fashion,17,In-store,Cash
AP,Osaka,2016,90,Nisi,Services,64,Online,Check
AP,Osaka,2016,51,Commodo,Food,47,Phone,Check
AP,Osaka,2017,7,Eiusmod,Jewelry,34,Online,Check
AP,Osaka,2017,30,Et,Fashion,40,In-store,Cash
AP,Osaka,2017,33,Aliqua,Sport,33,In-store,Card
AP,Osaka,2017,65,Sint,Sport,43,Phone,Check
AP,Osaka,2017,34,Officia,Electronics,47,Phone,Check
AP,Osaka,2017,143,Et,Healthcare,41,Phone,Card
AP,Osaka,2017,50,Minim,Food,56,Phone,Check
AP,Osaka,2017,143,Aliqua,Jewelry,17,In-store,Card
AP,Osaka,2017,51,Aliquip,Transport,25,Phone,Check
AP,Osaka,2017,115,Occaecat,Fashion,25,Phone,Check
AP,Osaka,2017,44,Magna,Toys,39,In-store,Card
AP,Osaka,2017,26,Eiusmod,Tools,39,Online,Card
AP,Osaka,2018,29,Veniam,Healthcare,51,Online,Card
AP,Osaka,2018,130,Quis,Tools,50,In-store,Check
AP,Osaka,2018,90,Ea,Toys,62,In-store,Card
AP,Osaka,2018,137,Nisi,Tools,31,Online,Check
AP,Osaka,2018,5,Nostrud,Fashion,18,Online,Card
AP,Osaka,2018,109,Fugiat,Services,31,Online,Card
AP,Osaka,2018,99,Magna,Electronics,56,In-store,Card
AP,Osaka,2019,71,Irure,Jewelry,56,Phone,Card
AP,Osaka,2019,38,Elit,Tools,65,Online,Check
AP,Osaka,2019,108,Ullamco,Transport,69,Phone,Card
AP,Osaka,2019,59,Consequat,Transport,61,Online,Check
AP,Osaka,2019,59,Cupidatat,Services,69,Phone,Check
AP,Osaka,2019,11,Consequat,Fashion,37,In-store,Cash
AP,Osaka,2019,138,Velit,Transport,43,Phone,Card
AP,Osaka,2019,43,Sit,Transport,15,Phone,Check
AP,Osaka,2019,12,Ex,Healthcare,62,In-store,Card
AP,Osaka,2019,107,Anim,Transport,30,Online,Card
AP,Osaka,2019,54,Velit,Toys,42,Online,Check
AP,Osaka,2019,44,Ut,Jewelry,23,In-store,Card
AP,Osaka,2019,73,Deserunt,Tools,48,Phone,Card
AP,Tokyo,2016,69,Commodo,Electronics,16,In-store,Card
AP,Tokyo,2016,131,In,Fashion,17,Phone,Card
AP,Tokyo,2016,132,Duis,Food,46,Online,Check
AP,Tokyo,2016,113,Id,Jewelry,38,In-store,Check
AP,Tokyo,2016,20,Velit,Food,42,In-store,Check
AP,Tokyo,2016,34,Aliqua,Electronics,64,In-store,Check
AP,Tokyo,2016,39,Lorem,Healthcare,31,In-store,Check
AP,Tokyo,2016,56,Id,Tools,43,Online,Card
AP,Tokyo,2016,9,Tempor,Tools,53,Online,Check
AP,Tokyo,2016,124,Eiusmod,Food,68,Phone,Check
AP,Tokyo,2016,117,Proident,Tools,38,Online,Check
AP,Tokyo,2016,127,Ut,Fashion,53,Online,Check
AP,Tokyo,2016,137,Qui,Healthcare,54,Phone,Check
AP,Tokyo,2017,9,Voluptate,Sport,28,Online,Card
AP,Tokyo,2017,131,Officia,Food,48,Online,Card
AP,Tokyo,2017,26,Ad,Toys,54,In-store,Card
AP,Tokyo,2017,14,Minim,Fashion,66,Phone,Check
AP,Tokyo,2017,74,Ad,Sport,44,Phone,Check
AP,Tokyo,2017,28,Laborum,Sport,51,Phone,Card
AP,Tokyo,2017,93,Mollit,Transport,52,Phone,Check
AP,Tokyo,2018,12,Et,Fashion,59,In-store,Card
AP,Tokyo,2018,45,Culpa,Services,36,Phone,Check
AP,Tokyo,2018,8,Consectetur,Services,27,Online,Card
AP,Tokyo,2018,118,Qui,Jewelry,48,Phone,Card
AP,Tokyo,2018,78,Eiusmod,Services,48,Phone,Check
AP,Tokyo,2018,127,Ut,Electronics,16,Phone,Check
AP,Tokyo,2018,126,Ad,Electronics,60,Phone,Card
AP,Tokyo,2018,43,Velit,Food,61,Phone,Check
AP,Tokyo,2018,60,Magna,Tools,16,In-store,Cash
AP,Tokyo,2018,10,Aliqua,Toys,54,In-store,Check
AP,Tokyo,2018,141,Veniam,Transport,23,Phone,Card
AP,Tokyo,2018,121,In,Services,25,Phone,Card
AP,Tokyo,2019,85,Ipsum,Toys,66,In-store,Cash
AP,Tokyo,2019,108,Ullamco,Healthcare,33,In-store,Card
AP,Tokyo,2019,126,Sint,Toys,38,In-store,Card
AP,Tokyo,2019,135,Ipsum,Electronics,50,In-store,Check
AP,Tokyo,2019,60,Laboris,Electronics,52,In-store,Cash
AP,Tokyo,2019,9,Exercitation,Food,64,Phone,Check
AP,Tokyo,2019,137,Enim,Electronics,36,In-store,Check
AP,Seoul,2016,69,Cillum,Tools,33,Online,Check
AP,Seoul,2016,144,Ullamco,Electronics,52,In-store,Cash
AP,Seoul,2016,30,Proident,Sport,58,Online,Check
AP,Seoul,2016,87,Qui,Jewelry,49,Phone,Card
AP,Seoul,2016,91,Lorem,Sport,62,In-store,Card
AP,Seoul,2016,121,Non,Toys,29,In-store,Card
AP,Seoul,2016,139,Nulla,Food,45,Phone,Card
AP,Seoul,2016,36,Est,Fashion,29,In-store,Check
AP,Seoul,2016,115,Esse,Tools,45,Phone,Card
AP,Seoul,2016,149,Ipsum,Toys,21,Online,Card
AP,Seoul,2016,7,Nisi,Toys,27,In-store,Check
AP,Seoul,2016,30,Occaecat,Tools,36,Phone,Card
AP,Seoul,2016,59,Nulla,Services,31,Online,Check
AP,Seoul,2017,95,Aliquip,Jewelry,50,In-store,Card
AP,Seoul,2017,108,Lorem,Food,66,Online,Check
AP,Seoul,2017,24,Magna,Services,26,Phone,Check
AP,Seoul,2017,110,Aliquip,Services,43,Online,Check
AP,Seoul,2017,70,Minim,Tools,50,Phone,Card
AP,Seoul,2017,19,Anim,Sport,55,Phone,Check
AP,Seoul,2017,40,Aute,Sport,53,Phone,Card
AP,Seoul,2017,57,Adipisicing,Tools,54,Phone,Check
AP,Seoul,2018,135,Voluptate,Jewelry,39,Phone,Card
AP,Seoul,2018,77,Sint,Electronics,52,Online,Check
AP,Seoul,2018,72,Do,Jewelry,49,Online,Card
AP,Seoul,2018,96,Laborum,Jewelry,51,Online,Card
AP,Seoul,2018,70,Laborum,Jewelry,25,Phone,Check
AP,Seoul,2018,61,Deserunt,Services,61,Online,Card
AP,Seoul,2018,101,Consectetur,Food,53,Online,Card
AP,Seoul,2018,112,Ipsum,Electronics,68,Phone,Card
AP,Seoul,2019,50,Ut,Services,48,Phone,Check
AP,Seoul,2019,118,Duis,Services,22,Phone,Check
AP,Seoul,2019,142,Voluptate,Electronics,29,Phone,Card
AP,Seoul,2019,112,Incididunt,Transport,44,Phone,Check
AP,Seoul,2019,33,Ad,Jewelry,48,Online,Check
AP,Seoul,2019,98,In,Electronics,47,In-store,Cash
AP,Seoul,2019,99,Aliquip,Tools,52,In-store,Check
AP,Seoul,2019,19,Ex,Food,40,Online,Card
AP,Seoul,2019,142,Officia,Services,19,Phone,Check
AP,Seoul,2019,9,Occaecat,Transport,55,Phone,Card
AP,Seoul,2019,20,Nostrud,Healthcare,61,In-store,Card
AP,Seoul,2019,50,Dolore,Food,34,In-store,Check
AP,Seoul,2019,72,Reprehenderit,Services,50,Phone,Card";
}