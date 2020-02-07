# ProjetoArt3mis
Jogo desenvolvido na disciplina de Projeto IV no 8 semestre do curso de Engenharia da Computação (2019).

**Autores:**

[Mayara - Desenvolvedora/Design]

[Leonardo - Desenvolvedor/Design](https://github.com/LZagatto)

[Lucas - Planejamento/Documentação](https://github.com/ldonizete)

**Agradecimento**

[Rodrigo - Design do personagem principal](https://github.com/RodrigoDisselli)

O objetivo do projeto foi aproveitar da oportunidade e adquirir novas hablidades na engine Unity por meio de atividades jamais desenvolvidas pelos participantes como: 

- Quests
- Inventário
- Craft
- Design

## História

O jogo consiste em uma missão apelidada de “Art3mis” onde a tripulação de astronautas em uma nave que sai do planeta Terra, fugindo da poluição e indo em busca de recursos e novos planetas semelhantes ao seu redor, já que a escassez de alimento, e a poluição que o ser humano proporcionou ao planeta, levaram a qualidade de vida na Terra a níveis críticos.
Durante a exploração eles passam por uma tempestade cósmica que danifica a nave, perdendo total controle sobre ela e ficando à mercê do fluxo do universo.
Depois de algum tempo, eles se vêem indo em direção á um buraco negro no qual após entrarem percebem que estão novamente no espaço porém com planetas muito diferentes dos que já conheciam. Ainda sem saber o que tinha acontecido, percebem que estão sendo puxados pela gravidade de um planeta duas vezes maior que o planeta Terra. Durante a passagem pela atmosfera alguns equipamentos são danificados, mas no fim conseguem pousar no solo em segurança.

![Nave](https://github.com/MayaraFreitas/ProjetoArt3mis/blob/master/ProjetoArt3mis/Img/Nave.PNG)

## Objetivo

Completar as 2 quests existentes no jogo utilizando o sistema de coleta, inventário e craft.

## Funcionalidades

### Quests + NPCs

Com a inserção das Quests no jogo, foi necessário uma interação visual entre o jogador e os componentes inseridos no mapa, para que seja de fácil entendimento o objetivo que terá que ser cumprido. 
Caixas de diálogos foram criadas e são ativadas ao interagir com os desafios ou com NPCs espalhados pelos mapas por meio de um sistema de gerenciamento de diálogo dentro da Unity que interligado aos componentes das Quests e do Player acabam gerando o resultado esperado conforme imagem abaixo.  

![Missao](https://github.com/MayaraFreitas/ProjetoArt3mis/blob/master/ProjetoArt3mis/Img/Missão.PNG)

### Inventário + Craft

Durante o jogo o player poderá coletar itens encontrado no mapa, cada item recebe um nome, descrição e observação e o mesmo unido com outro item é capaz de dar origem a um novo item. Caso o player entre em contanto com algum item ele será encaminhado para seu inventário (exceto quando o inventário está cheio). O inventário é constituído por 25 caixas que armazenam os itens coletados, uma área de construção, que recebe no máximo dois itens para a construção de um novo e uma área de descarte. 

![Inventario](https://github.com/MayaraFreitas/ProjetoArt3mis/blob/master/ProjetoArt3mis/Img/Inventário.png)

O que determina quais itens juntos ou individualmente podem ser transformados em outros, é um script que se comporta como uma “receita”, determinando a entrada e saída.

![Craft](https://github.com/MayaraFreitas/ProjetoArt3mis/blob/master/ProjetoArt3mis/Img/Craft.png)

Um mini mapa acompanha o Player enquanto de movimenta, sendo possível ter uma maior visão do mapa e obstáculos.

![MiniMap](https://github.com/MayaraFreitas/ProjetoArt3mis/blob/master/ProjetoArt3mis/Img/MiniMap.PNG)


## Arte

Sprites foram confeccionados com cerca de 36 pixels utilizando a ferramenta web PiskelApp para a construção dos objetos, personagens, e o mapa. Os sprites possuem a coloração principalmente azul contrastando com as secundárias vermelha e verde, para causar estranheza ao usuário ao ver cenários e objetos semelhantes aos presentes na terra. Por sua vez, a personagem principal recebeu cores mais agradáveis, seu cabelo colorido representa a modernidade e o futurismo não deixando claro o sexo, para que o jogador possa a enxergar como quiser.

**A personagem principal foi a única não desenvolvida pelo grupo que não possui muitas habilidades com design, então pedimos ajuda de um terceiro.**


![Sprites](https://github.com/MayaraFreitas/ProjetoArt3mis/blob/master/ProjetoArt3mis/Img/Sprites.PNG)

