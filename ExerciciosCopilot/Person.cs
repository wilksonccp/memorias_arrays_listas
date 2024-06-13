namespace ExerciciosCopilot;

public class Person
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public override string ToString()
    {
        return $"Meu nome é {Nome} eu tenho {Idade} anos";
    }
}
