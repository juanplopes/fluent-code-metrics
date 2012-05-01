#language: pt-BR

Funcionalidade: Calcular Acoplamento Eferente (Ce)
	
	Acomplamento Eferente é uma métrica que indica a quantidade
	de referências de um tipo para outros.
	
	Entram na contagem: classe base, interfaces implementadas, 
	tipos dos variáveis locais, atributos e das propriedades, 
	tipos dos parâmetros em métodos e construtores, exceptions.

	Como o objetivo é identificar a "complexidade" de um tipo,
	considero também as referências "herdadas".

	Esquema do Cenário: Calcular Acoplamento Eferente para um tipo
		Dado que tenho um <tipo>
		Quando inspeciono seu acoplamento eferente
		Então obtenho <ce>
		# todos os tipos tem object, boolean, string, int32, type no mínimo

		Exemplos: 
			| tipo                              | ce |
			| Samples.EmptyClass                | 5  |
			| Samples.SingleArgCtor             | 6  |
			| Samples.SingleArgVoidMethod       | 6  |
			| Samples.FeeMethod                 | 6  |
			| Samples.DateTimeArgDateTimeMethod | 6  |
			| Samples.SingleProperty            | 6  |
			| Samples.SingleField               | 6  |
			| Samples.OneException              | 6  |
			| Samples.SingleNonAutoProperty     | 6  |



