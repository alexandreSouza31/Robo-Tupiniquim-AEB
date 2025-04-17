﻿﻿# Robo-Tupiniquim 🤖 

Esta aplicação simula a movimentação de robôs dentro de um grid 10x10, com base em instruções como virar à esquerda, virar à direita e mover-se para frente.

## Sumário

- [Visão geral](#visão-geral)
  - [Mídia](#mídia-)
  - [Funcionalidades](#funcionalidades)
  - [Desenvolvido com](#desenvolvido-com-)
  - [Estrutura do projeto](#estrutura-do-projeto-)
- [Como rodar o código?](#como-rodar-o-código-)
  - [Passo a passo - Clone ou baixe o projeto](#passo-a-passo---clone-ou-baixe-o-projeto--)
  - [Uso](#uso-)
- [Autor](#autor-)

## Visão geral

### Mídia 📷
##### GIF da aplicação - Clique no GIF para dar Play/Pause
![Image](https://i.imgur.com/eXA5gNN.gif)

### Funcionalidades✅ 
- Cria múltiplas instâncias de robôs com controle individual.
- Executa comandos em sequência: virar e mover.
- Exibe a localização final do robô após os movimentos.
- Impede que o robô ultrapasse os limites do grid (0 a 10).
- Informa o usuário se o movimento foi inválido.


### Desenvolvido com 🚀

[![My Skills](https://skillicons.dev/icons?i=cs,dotnet,git&theme=light)](https://skillicons.dev)


### Estrutura do projeto 📁
```
├── Robo-Tupiniquim
│   └── Program.cs
│   └── Robo.cs
├── .gitignore
├── Robo-Tupiniquim.ConsoleApp.sln
└── README.md
```


### Como rodar o código? 🤖

#### ❗❗Obs: Há a necessidade de ter o .NET SDK instalado em sua máquina previamente!

#### Passo a passo - Clone ou baixe o projeto  👞👞

1. Abra o terminal do seu editor de código;
2. Navegue até a pasta onde deseja instalar o projeto;
3. Clone o projeto 
ex:``` git clone git@github.com:alexandreSouza31/Robo-Tupiniquim-AEB.git```
 ou se preferir, baixe clicando no botão verde chamado "Code" no repositório desse projeto, e depois "Download zip.


#### Uso 💻
1. Inicie o App:
Certifique-se de estar na pasta do projeto, e navegue pelo terminal até o caminho do arquivo Program.cs
```
Robo-Tupiniquim\Robo-Tupiniquim.ConsoleApp>
```
2. Compile e execute o programa: ```dotnet run```

    ou, com o arquivo Program.cs aberto clique no botão verde(Current Document(Program.cs)) para iniciar

3. Instruções: 
- `M` → Move o robô 1 unidade para frente (de acordo com a direção atual)
- `E` → Vira o robô 90º à esquerda
- `D` → Vira o robô 90º à direita
- Exemplo de instrução: `MMMMEDMM`


## Autor 😏 

<main>
<div style="display: flex; align-items: center; gap: 20px;padding-bottom: 2em">
  <img src="https://github.com/user-attachments/assets/74c712a4-9e48-4ae3-839c-46089b850a27" width="80" />
  <h3 style="margin: 0;"><i>Alexandre Mariano</i></h4>
</div>

  <p>
    <a href="https://www.linkedin.com/in/alexandresouza31/">
      <img src="https://skillicons.dev/icons?i=linkedin&theme=dark" width="50"/>
      LinkedIn
    </a> &nbsp;  |  &nbsp;
    <a href="https://github.com/alexandreSouza31">
      <img src="https://skillicons.dev/icons?i=github&theme=dark" width="50"/>
      GitHub
    </a>
  </p>
</main>


<a href="#Robo-Tupiniquim" 
   style="position: fixed; right: 10px; bottom: 20px; background-color:rgba(99, 102, 99, 0.32); color: white; padding: 1px 5px 5px; text-decoration: none; border-radius: 5px; font-size: 16px;">
   🔝Voltar ao topo🔝
</a>