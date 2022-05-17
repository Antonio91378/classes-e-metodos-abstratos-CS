using System;

// abstract quer dizer que a classe é como um esboço, feito para ser utilizado por classes derivadas. a classe abstract nao pode sr chamada, apenas usada como classe base.
//se a classe fosse 'SEALED' eu nao poderia gerar classes derivadas.
abstract class Veiculo
{
    protected int velMaxima;

    protected int velAtual;

    protected bool ligado;

    public Veiculo()
    {
        ligado = false;
        velAtual = 0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }

    public int getVelAtual()
    {
        return velAtual;
    }

    //como este é um método abstract eu não tenho a obrigação de definilo aqui, mas tenho a obrigação de definilo nas classes derivadas.
    public abstract void aceleracao(int mult);
}

class Carro : Veiculo
{
    public Carro()
    {
        velMaxima = 120;
    }

    public override void aceleracao(int mult)
    {
        velAtual += 10 * mult;
    }
}

class principal
{
    static void Main()
    {
        Carro carro1 = new Carro();
        carro1.aceleracao(2);
        Console.WriteLine(carro1.getVelAtual());
    }
}
