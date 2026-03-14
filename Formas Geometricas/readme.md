# Calculadora de Áreas e Perímetros de Figuras Geométricas

Este programa utiliza conceitos de herança e orientação a objetos para implementar um sistema capaz de calcular área e perímetro de diferentes figuras geométricas.

O sistema também utiliza um modelo baseado em dicionários, permitindo mapear as opções do menu para os respectivos objetos responsáveis pelos cálculos.

---

## Fluxo de Execução
O funcionamento do programa segue a seguinte sequência:
1. O sistema abre um menu solicitando a escolha da forma geométrica.
2. O usuário informa o número correspondente à forma desejada.
3. O sistema abre um menu solicitando o tipo de cálculo a ser realizado.
4. O usuário informa o número correspondente ao cálculo desejado.
5. É criado um dicionário chamado formasGeometricas, que utiliza:
- chave: um valor inteiro
- valor: um objeto do tipo FormaGeometrica

6. Cada chave inteira armazena a instância de um objeto correspondente à opção escolhida.
- Além disso, o construtor desses objetos recebe o tipo de cálculo selecionado.

7. Cada objeto salva o tipo de cálculo em uma variável privada, que posteriormente é utilizada em um switch dentro do método de execução. A partir desse método de execução, são realizados todos os cálculos necessários do sistema.

---
## Estrutura de Classes
### Classe Base
#### FormaGeometrica
+ Executar()
+ CalcularArea()
+ CalcularPerimetro()

Esta classe define os métodos base que todas as figuras geométricas devem implementar.

---
### Classes Derivadas

#### Triângulo
Herda de FormaGeometrica.

##### Atributos
- baseTriangulo : double
- alturaTriangulo : double
- ladoTriangulo : double
- tipoCalculo : int
- tipoTriangulo : int
- area : double
- perimetro : int

##### Métodos
- Construtor()
- Executar()
- Cálculo de Área
- CalcularArea()
- CalcularAreaEquilatero()
- CalcularAreaIsoceles()
- CalcularAreaEscaleno()
- Cálculo de Perímetro
- CalcularPerimetro()
- CalcularPerimetroEquilatero()
- CalcularPerimetroIsoceles()
- CalcularPerimetroEscaleno()

---
#### Quadrado
Herda de FormaGeometrica.

##### Atributos
- ladoQuadrado : double
- area : double
- perimetro : int

##### Métodos
- Construtor()
- Executar()
- CalcularArea()
- CalcularPerimetro()

---
#### Retângulo
Herda de FormaGeometrica.

##### Atributos
- comprimentoRetangulo : double
- larguraRetangulo : double
- area : double
- perimetro : double

##### Métodos
- Construtor()
- Executar()
- CalcularArea()
- CalcularPerimetro()

---
#### Círculo
Herda de FormaGeometrica.

##### Atributos
- raioCirculo : double
area : double
perimetro : double

##### Métodos
- Construtor()
- Executar()
- CalcularArea()
- CalcularPerimetro()

---
#### Losango
Herda de FormaGeometrica.

##### Atributos
- diagonalMaiorLosango : double
- diagonalMenorLosango : double
- ladoLosango : double
- area : double
- perimetro : double

##### Métodos
- Construtor()
- Executar()
- CalcularArea()
- CalcularPerimetro()