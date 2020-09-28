using System;

class MainClass {
  public static void Main () {
    Empresa MinhaEmpresa = new Empresa();

		Console.Write("Digite a Razão Social da sua empresa: ");
		MinhaEmpresa.SetRazaoSocial(Console.ReadLine());
		Console.Write("Digite o CNPJ da sua empresa: ");
		MinhaEmpresa.SetCnpj(Console.ReadLine());
		Console.Write("Digite dados pessoais dos clientes serão utilizados pela sua empresa (de uma só vez, separados por vírgula): ");
		MinhaEmpresa.SetDados(Console.ReadLine());
		Console.Write("Digite os serviços em que esses dados serão utilizados (de uma só vez, separados por vírgula): ");
		MinhaEmpresa.SetServicos(Console.ReadLine());

		Termo MeuTermo = new Termo();
		MeuTermo.SetTexto(MinhaEmpresa.GetDados(), MinhaEmpresa.GetServicos(), MinhaEmpresa.GetRazaoSocial(), MinhaEmpresa.GetCnpj());
		Console.WriteLine("\n\n**COPIE E COLE O TERMO PARA UTILIZAÇÃO:**\n\n---------------------------------------------");
		Console.WriteLine(MeuTermo.GetTexto());
		Console.WriteLine("---------------------------------------------\n\n**COPIE E COLE O TERMO PARA UTILIZAÇÃO:**\n\n");
  }
}