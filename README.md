
# Respostas do Slide Pato

### - Explique quais os principais ganhos desta estratégia

Essa estratégia garante que seus métodos iram obrigatoriamente ser implementados na classe que implementar a interface. A interface é mais focada no **o que** do que no **Como**, facilitando  na visualização do contexto geral de um classe.
Para um projeto muito grande o uso de interfaces tambem mostra sua utilidade na manutenção e escalamento do código garantindo por exemplo que o programador ao acrescentar uma classe nova, não esqueça de implementar um método importante que possa comprometer o funcionamento do sistema. 
Tambem conseguimos ter uma ideia do que a classe faz somente pela Interface que ela implementa.

### - Você a capaz de ver alguma desvantagem nesta estratégia?

A desvantagem está mais relacionada ao contexto da utilização. As vezes pode parecer mais viável e simples criar somente uma classe Enum com os tipos de patos que se deseja implementar, levando em consideração um caso em que os tipos de patos serão finitos e conhecidos Isso garantiria que não fossem criadas várias classes aumentando a quantidade de arquivos do nosso projeto sem necessidade.

