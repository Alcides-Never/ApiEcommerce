using APIEcommerce.Context;

namespace APIEcommerce;

public class testeComunicacao
{
    public static void TesteComunicacao()
    {
        try
        {
            using var context = new ECommerceContext();
            var conected = context.Database.CanConnect();
            Console.WriteLine(conected ? "Conectado" : "Desconectado");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
    }
}