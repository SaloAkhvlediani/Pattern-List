using Patern.Adapter;
using Patern.Adapter.DataProccessor;
using Patern.Adapter.Network;
using Patern.ChainResponsibility;
using Patern.Facade;
using Patern.Factory.NetworkFactory;
using Patern.Factory.NetworkUtility;
using Patern.Proxy;
using Patern.Singelton;
using Patern.Strategy;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();
Console.WriteLine("---------- Pattern ----------");
//// პირველი ნაწილი Singelton
//Singleton object1 = Singleton.Instance();
//Singleton object2 = Singleton.Instance();
//if (object1 == object2)
//{
//    Console.WriteLine("these object are the same");
//}
////მეორე ნაწილი Factory
//int val = 0;
//Ping ping12 = new Ping();
//INetwork ping1 = new Ping();
////მესამე ნაწილი Factory
//NetworkFactory factory = new NetworkFactory();
//var ping = factory.GetNetworkInstance("ping");
//var dns = factory.GetNetworkInstance("dns");
//var arp = factory.GetNetworkInstance("arp");
//ping.SendRequest("78.97", 2);
//dns.SendRequest("74.12", 3);
//arp.SendRequest("77.12", 5);
////მეოთხე ნაწილი Facade
//NetworkFacade facade = new NetworkFacade("8.8.8.8", "UDP", "s");
//facade.BuildNetworkLayer();
//facade.SendPacketOverNetwork();
////მესამე ნაწილი Adapter 
//INetworkClient network = new NetworkClient();
//network.SendRequest("1.2.3.4");
//IDataProcessor dataProcessor= new DataProcessor();
//dataProcessor.SendNetworkRequsest("1.2.3.4","");
// NetworkAdapter adapter= new NetworkAdapter(dataProcessor);
//adapter.SendRequest("87");
//მეოთხე მაწილი Proxy
//ISuperSecretDatabase database= new SuperSecretDatabaseProxy("testdb", "password");
//database.DisplayDatabaseName();
//მეხუთე ნაწილი Chain responsibility

//IChain obj1 = new SendSSh();
//IChain obj2 = new SendPing();
//IChain obj3= new SendARP();

//obj1.SetNext(obj2);
//obj2.SetNext(obj3);

//NetworkModel request1 = new NetworkModel("2.3.4.1",false);
//obj1.SendRequest(request1);
//NetworkModel request2 = new NetworkModel("2.3.4.1", true);
//obj2.SendRequest(request2);
//NetworkModel request3 = new NetworkModel("2.3.4.1", false);
//obj3.SendRequest(request3);
//მეექვსე ნაწილი Strategy


 var contextARPS = new Contex(new ARPS());
var contextPing = new Contex(new PingS());
var contextDNS= new Contex(new DNSS());
contextARPS.ExecuteStrategy();
contextPing.ExecuteStrategy();
contextDNS.ExecuteStrategy();