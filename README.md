# Projeto do 4º Bimestre — Processamento de Imagens

Aplicação Windows Forms desenvolvida para a disciplina de Introdução à Computação Gráfica. O programa combina quatro imagens JPG oficiais e aplica operações básicas de processamento de pixels.

## Requisitos

- Visual Studio com suporte a Windows Forms e .NET Framework 4.7.2.
- As quatro imagens oficiais na pasta `C:\Imagens`:
  - `Im.jpg` (imagem A)
  - `Balao.jpg` (imagem B)
  - `homem.jpg` (imagem C)
  - `Aviao2.jpg` (imagem D)

## Como executar

1. Abra `projeto 4bimestre.slnx` no Visual Studio.
2. Compile e execute com **F5** ou **Ctrl+F5**.
3. Clique em **Processar imagens**.

O programa usa caminhos fixos em `C:\Imagens`, conforme os requisitos do projeto. As imagens de entrada estão na pasta `Imagens` do pacote; copie-as para `C:\Imagens` antes de executar em outro computador.

## Processamento

Um único botão gera e exibe os seguintes resultados:

| Arquivo de saída | Operação |
| --- | --- |
| `01_Colorida.jpg` | Composição da imagem A com B, C e D, removendo os fundos por faixas de intensidade RGB. |
| `02_Brilho85.jpg` | Aumento de 85 no brilho dos canais vermelho, verde e azul, limitando os valores ao intervalo de 0 a 255. |
| `03_Cinza.jpg` | Conversão GrayLevel pela fórmula `0,30 × R + 0,59 × G + 0,11 × B`. |
| `04_Binaria.jpg` | Limiarização da imagem em cinza com `T = 126`: intensidade até 126 vira preto; acima de 126 vira branco. |
| `05_Rotacao.jpg` | Transposição da imagem em cinza, conforme a técnica mostrada nos slides. A largura e a altura são invertidas. |

As saídas são gravadas em `C:\Imagens`. Um novo clique gera os resultados novamente a partir das entradas originais.

> A imagem binária contém somente preto e branco durante o processamento. Como o enunciado pede arquivos JPG, a compressão JPEG pode criar tons intermediários nas bordas ao reabrir o arquivo.

## Organização do código

- `Form1.cs`: evento do botão, composição, filtros, conversão de cores, binarização, transposição e primitivas gráficas reaproveitadas do projeto anterior.
- `Form1.Designer.cs`: formulário, botão único e áreas de exibição dos resultados.
- `Imagens/`: cópias das quatro imagens oficiais para instalação em `C:\Imagens`.

As funções de processamento usam laços, `Bitmap`, `GetPixel` e `SetPixel`, conforme o conteúdo dos slides fornecidos.
