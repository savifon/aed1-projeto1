using System;

class Termo {
	private string Texto;

	public void SetTexto(string dados, string servicos) {
		if (String.IsNullOrEmpty(dados)) || (String.IsNullOrEmpty(servicos))
			Console.WriteLine("Os dados e/ou serviços informados são vazios ou nulos.")
		else
			Termo = "Termo de consentimento para armazenamento e tratamento de dados pessoais em conformidade com a LGPD\n\nEste documento visa registrar a manifestação livre, informada e inequívoca pela qual o titular concorda com o tratamento de seus dados pessoais para finalidade específica, em conformidade com a Lei nº 13.709 – Lei Geral de Proteção de Dados Pessoais (LGPD).\n\nInformamos que coletamos seus dados pessoais ({0}) para {1}. Os seus dados pessoais serão armazenados e preservados por um período indeterminado; os dados dos clientes são registrados no sistema e podem ser anonimizados a qualquer momento, desde que o cliente solicite.\n\nVocê poderá, a qualquer momento:\n\nTer acesso às informações sobre a forma e a duração de tratamento dos seus dados na nossa plataforma;\nSolicitar a atualização ou correção dos seus dados;\nSolicitar a eliminação dos seus dados pessoais tratados e revogação do consentimento, nos termos da Lei.\n\nAs solicitações e questionamentos acerca do tratamento e eliminação de seus dados deverão ser realizadas através do [informe seu e-mail ou telefone].\n\nCaso ACEITE que seus Dados Pessoais sejam coletados, por favor, concorde com este aviso.\n\nA – CONCORDO / B – NÃO CONCORDO";
	}

	public string GetTexto() {
		return Texto;
	}

}