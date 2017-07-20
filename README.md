# desligaPC
Desligar o PC no horário específico desenvolvido em C#
</br>
O objetivo deste programa, além de estudos com a linguagem C#, é suprir uma necessidade que eu tenho, pois utilizo o computador por várias horas do dia e costumo dormir com ele ligado, então desligar em um determinado tempo é uma necessidade que tenho na minha rotina.</br>
Fiz uma série de mudanças no código, se comparado com a versão anterior, incluindo a possibilidade de hibernar o pc com tempo específico. Agora para que o programa funcione corretamente, é necessário o manter aberto, existe uma contagem de tempo regressiva que só vai ativar os comandos quando esta chegar a "zero".

A quantidade de linhas aumentou consideravelmente, pois resolvi separar algumas partes do código em funções, assim evitando multipla edição de algumas partes, além de facilitar manutenção e futuras implementações.

Como alguns anto vírus começaram a reconhecer o programa como um possível vírus, resolvi tirar qualquer execução sobre o prompt comando, passando a utilizar uma classe especial que encontrei no stackoverflow "sim o programador amigo, hehehe", por fim, esta nova versão incluí também no menu "Ação" a opção "Desligar Agora".
</br>

![Alt text](/img/Desliga.jpg?raw=true "Desliga o PC")
</br>

