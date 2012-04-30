#language: pt-BR

Funcionalidade: Calcular Acoplamento Eferente (Ce)
	
	Acomplamento Eferente é uma métrica que indica a quantidade
	de referências de um tipo para outros.
	Entram na contagem: classe base, interfaces implementadas, 
	tipos dos variáveis locais, atributos e das propriedades, 
	tipos dos parâmetros em métodos e construtores, exceptions.

	Esquema do Cenário: Calcular Acoplamento Eferente para um tipo
		Dado que tenho um <tipo>
		Quando inspeciono seu acoplamento eferente
		Então obtenho <ce>

		Exemplos: 
			| tipo                       | ce |
			| Samples.EmptyClass         | 1  |
			| Samples.OneArgCtor         | 2  |
			| Samples.OneArgVoidMethod   | 2  |
			| Samples.IntMethod          | 2  |
			| Samples.StringArgIntMethod | 3  |
			| Samples.OneProperty        | 2  |
			| Samples.OneAttribute       | 2  |
			| Samples.OneException       | 2  |



