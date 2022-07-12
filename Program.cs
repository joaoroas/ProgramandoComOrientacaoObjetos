using ProgramandoComOrientacaoObjetos.Helper;
using ProgramandoComOrientacaoObjetos.Interfaces;
using ProgramandoComOrientacaoObjetos.Models;

//ClasseObject();
//ClasseAbstrata();
//Calcular();
//HerancaPessoaProfessor();
//HerancaPessoaAluno();
//LerDirectorios();
//LerArquivos();
//CriaDiretorio();
//ApagaDiretorio();
//CriaArquivoTexto();
//CriaArquivoTextoStream();
//AdicionaTexto();
//LerArquivosStream();
//MoveArquivo();
//CopiaArquivo();
//DeletaArquivo();


static void DeletaArquivo()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";
    var caminhoArquivo = Path.Combine
   (caminho, "Teste3", "SubPastaTeste3", "arquivo copiado.txt");

    FileHelper helper = new FileHelper();
    helper.DeletarArquivo(caminhoArquivo);
}


static void CopiaArquivo()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";
    var caminhoArquivo = Path.Combine
    (caminho, "arquivo-texte.txt");

    var novoCaminho = Path.Combine
    (caminho, "arquivo copiado.txt");


    FileHelper helper = new FileHelper();
    helper.CopiarArquivo(caminhoArquivo, novoCaminho, false);
}



static void MoveArquivo()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";
    var caminhoArquivo = Path.Combine
    (caminho, "arquivo-texte-stream.txt");

    var novoCaminho = Path.Combine
    (caminho, "Teste3", "SubPastaTeste3", "arquivo-movido-stream.txt");


    FileHelper helper = new FileHelper();
    helper.MoverArquivo(caminhoArquivo, novoCaminho);
}



static void LerArquivosStream()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";
    var caminhoArquivo = Path.Combine
    (caminho, "arquivo-texte-stream.txt");

    FileHelper helper = new FileHelper();
    helper.LerArquivoStream(caminhoArquivo);

}


static void AdicionaTexto()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";
    var caminhoArquivo = Path.Combine
    (caminho, "arquivo-texte-stream.txt");

    var listaString = new List<string>
    {"linha 1", "linha 2", "linha 3"};

    var novaListaString = new List<string>
    {"linha 4", "linha 5", "linha 6"};

    FileHelper helper = new FileHelper();
    helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
    helper.AdicionarTextoStream(caminhoArquivo, novaListaString);

}


static void CriaArquivoTextoStream()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";
    var caminhoArquivo = Path.Combine
    (caminho, "arquivo-texte-stream.txt");

    var listaString = new List<string>
    {"linha 1", "linha 2", "linha 3"};

    FileHelper helper = new FileHelper();
    helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
}


static void CriaArquivoTexto()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";
    var caminhoArquivo = Path.Combine
    (caminho, "arquivo-texte.txt");

    FileHelper helper = new FileHelper();
    helper.CriarArquivoTexto
    (caminhoArquivo, "Teste escrita de arquivo");
}




static void ApagaDiretorio()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";
    var caminhoPathCombine = Path.Combine
    (caminho, "Teste1");

    FileHelper helper = new FileHelper();
    helper.ApagarDiretorio(caminhoPathCombine, true);
}


static void CriaDiretorio()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";
    var caminhoPathCombine = Path.Combine
    (caminho, "Teste3", "SubPastaTeste3");

    FileHelper helper = new FileHelper();
    helper.CriarDiretorio(Path.Combine
    (caminhoPathCombine));
}


static void LerArquivos()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";

    FileHelper helper = new FileHelper();
    helper.ListarArquivos(caminho);
}



static void LerDirectorios()
{
    var caminho = "C:\\Users\\joaor\\OneDrive\\Área de Trabalho\\PROJETOS\\ProgramandoComOrientacaoObjetos\\Arquivos";

    FileHelper helper = new FileHelper();
    helper.ListarDiretorios(caminho);
}




static void ImplementaInterface()
{
    ICalculadora calc = new Caulculadora();
    System.Console.WriteLine(calc.Somar(10, 20));
    Console.ReadLine();
}


static void ClasseObject()
{
    Computador comp = new Computador();
    System.Console.WriteLine(comp.ToString());
    Console.ReadLine();
}

static void ClasseAbstrata()
{
    Corrente c = new Corrente();
    c.Creditar(100);
    c.ExibirSaldo();
}

static void Calcular()
{
    //Polimorfismo em tempo de execução
    Caulculadora calc = new Caulculadora();
    System.Console.WriteLine($"Resultado da primeira soma: {calc.Somar(10, 10)}");
    System.Console.WriteLine($"Resultado da segunda soma: {calc.Somar(10, 10, 10)}");
    Console.ReadLine();

}


static void HerancaPessoaProfessor()
{
    Professor p1 = new Professor();
    p1.Nome = "bob";
    p1.Idade = 20;
    p1.Salario = 1200;
    p1.Apresentar();

}



static void HerancaPessoaAluno()
{
    Aluno p1 = new Aluno();
    p1.Nome = "bob";
    p1.Idade = 20;
    p1.Nota = 5.5;
    p1.Apresentar();

}



static void AbstrairPessoa()
{
    Pessoa p1 = new Pessoa();
    p1.Nome = "João";
    p1.Idade = 30;

    p1.Apresentar();
    Console.ReadLine();

}

//Encapsulamento
static void ValoresValidosRetangulo()
{
    Retangulo r = new Retangulo();
    r.DefinirMedidas(30, 20);
    Console.WriteLine($"Área: {r.ObterArea()}");
    Console.ReadLine();

}
static void ValoresInvalidosRetangulo()
{
    Retangulo r2 = new Retangulo();
    r2.DefinirMedidas(0, 2);
    System.Console.WriteLine($"Àrea: {r2.ObterArea()}");
    Console.ReadLine();
}
