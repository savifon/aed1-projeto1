using System;

class Empresa {
	private string RazaoSocial;
	private string Cnpj;
	private string Servicos;
	private string Dados;

	public void SetRazaoSocial(string rs) {
		if (String.IsNullOrEmpty(rs))
			Console.WriteLine("A Razão Social informada é nula ou vazia.");
		else
			RazaoSocial = rs;
	}

	public string GetRazaoSocial() {
		return RazaoSocial;
	}

	public void SetCnpj(string n) {
		if (String.IsNullOrEmpty(n))
			Console.WriteLine("O CNPJ informado é nulo ou vazio.");
		else
			Cnpj = n;
	}

	public string GetCnpj() {
		return Cnpj;
	}

	public void SetServicos(string s) {
		if (String.IsNullOrEmpty(s))
			Console.WriteLine("Os serviços informados são nulos ou vazios.");
		else
			Servicos = s;
	}

	public string GetServicos() {
		return Servicos;
	}

	public void SetDados(string d) {
		if (String.IsNullOrEmpty(d))
			Console.WriteLine("Os dados informados são nulos ou vazios.");
		else
			Dados = d;
	}

	public string GetDados() {
		return Dados;
	}

}