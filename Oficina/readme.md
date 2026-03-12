# Modelagem de Sistema Oficina Mecânica

Este modelo representa um sistema simples de gerenciamento de serviços de uma oficina mecânica.  
Ele inclui as entidades **Carro**, **Cliente**, **Funcionário** e **Serviço**, bem como seus atributos e comportamentos principais.

---

## Carro

### Atributos
- `ID: int`
- `Marca: string`
- `Modelo: string`
- `Ano: int`

### Métodos
- `Construtor`
- `ExibirDetalhes()`

---

## Cliente

### Atributos
- `ID: int`
- `Nome: string`
- `ListaCarros: List<Carro>`
- `ListaServicos: List<Servico>`

### Métodos
- `Construtor`
- `ToString()`
- `AdicionarServico()`
- `AdicionarCarros()`
- `ExibirDetalhes()`

---

## Funcionario

### Atributos
- `ID: int`
- `Nome: string`
- `Salario: decimal`
- `Cargo: string`
- `ListaServicos: List<Servico>`

### Métodos
- `Construtor`
- `ToString()`
- `AdicionarServico()`
- `ExibirDetalhes()`

---

## Servico

### Atributos
- `ID: int`
- `Tipo: string`
- `Cliente: Cliente`
- `Carro: Carro`
- `Funcionario: Funcionario`
- `DataServico: DateTime`

### Métodos
- `Construtor`
- `ExibirDetalhes()`

---

## Relações do Modelo

- Um **Cliente** pode possuir vários **Carros**.
- Um **Cliente** pode possuir vários **Serviços**.
- Um **Funcionário** pode realizar vários **Serviços**.
- Cada **Serviço** está associado a:
  - um **Cliente**
  - um **Carro**
  - um **Funcionário**

---

## Objetivo

Este modelo foi criado como exercício de **modelagem orientada a objetos em C#**, com foco em:

- Estruturação de classes
- Relacionamentos entre entidades
- Organização de responsabilidades
- Prática de design orientado a objetos