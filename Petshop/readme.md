# Modelagem de Sistema — Clínica Veterinária

Este modelo representa um sistema simples de gerenciamento de **consultas veterinárias**.
Ele inclui as entidades **Pet**, **Dono**, **Consulta** e **Médico**, bem como seus atributos e operações principais.

---

## Pet

### Atributos

* `ID: int`
* `Nome: string`
* `Raça: string`
* `ListaConsultas: List<Consulta>`

### Métodos

* `override ToString()`
* `Construtor`
* `ExibeDetalhes()`
* `AdicionarConsulta()`

---

## Dono

### Atributos

* `Nome: string`
* `Descrição: string`

---

## Consulta

### Atributos

* `ID: int`
* `Medico: Medico`
* `Pet: Pet`

### Métodos

* `override ToString()`
* `Construtor`
* `ExibeDetalhes()`

---

## Médico

### Atributos

* `ID: int`
* `Nome: string`
* `Salário: decimal`
* `ListaConsultas: List<Consulta>`

### Métodos

* `override ToString()`
* `Construtor`
* `ExibeDetalhes()`
* `AdicionarConsulta()`

---

## Relações do Modelo

* Um **Pet** pode possuir várias **Consultas**.
* Um **Médico** pode realizar várias **Consultas**.
* Cada **Consulta** está associada a:

  * um **Pet**
  * um **Médico**

---

## Objetivo

Este modelo foi desenvolvido como exercício de **modelagem orientada a objetos**, com foco em:

* Estruturação de entidades
* Relacionamentos entre classes
* Organização de responsabilidades
* Prática de design orientado a objetos
