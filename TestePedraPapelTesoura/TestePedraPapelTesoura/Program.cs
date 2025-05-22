// See https://aka.ms/new-console-template for more information

using TestePedraPapelTesoura;

var user1 = EnumPedraPapelTesoura.Papel;
var user2 = EnumPedraPapelTesoura.Tesoura;

var ganhador = Validador.VerificaGanhador(user1, user2);

Console.WriteLine("O ganhador é: " + ganhador);

public static class Validador
{
    private static readonly Dictionary<EnumPedraPapelTesoura, List<EnumPedraPapelTesoura>> comparacoes =
        new()
        {
            { EnumPedraPapelTesoura.Pedra, new List<EnumPedraPapelTesoura> { EnumPedraPapelTesoura.Tesoura } },
            { EnumPedraPapelTesoura.Papel, new List<EnumPedraPapelTesoura> { EnumPedraPapelTesoura.Pedra } },
            { EnumPedraPapelTesoura.Tesoura, new List<EnumPedraPapelTesoura> { EnumPedraPapelTesoura.Papel } },
        };
    
    public static string VerificaGanhador(EnumPedraPapelTesoura user1, EnumPedraPapelTesoura user2)
    {
        if (user1 == user2)
            return "Empate";

        if (comparacoes[user1].Contains(user2))
            return "User1 Ganhador";

        if (comparacoes[user2].Contains(user1))
            return "User2 Ganhador";

        return "Erro na comparação";
    }
}