using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone

        // Criando instância de Nokia e testando os métodos
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111111111111111", memoria: 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine();

        // Criando instância de iPhone e testando os métodos
        Smartphone iphone = new Iphone(numero: "654321", modelo: "iPhone 12", imei: "222222222222222", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
