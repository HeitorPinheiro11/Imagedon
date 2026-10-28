using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace projeto_4bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // O unico botao chama a primitiva responsavel pelo processamento completo.
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            ProcessarImagens();
        }

        private void ProcessarImagens()
        {
            Bitmap colorida = new Bitmap(@"C:\Imagens\Im.jpg");
            Bitmap balao = new Bitmap(@"C:\Imagens\Balao.jpg");
            Bitmap homem = new Bitmap(@"C:\Imagens\homem.jpg");
            Bitmap aviao = new Bitmap(@"C:\Imagens\Aviao2.jpg");

            // B: fundo azul; C: fundo marrom; D: fundo azul.
            // Os intervalos levam em conta as pequenas variacoes do JPEG.
            JuntarImagens(colorida, balao, 500, 0, 40, 115, 110, 170, 170, 230);
            JuntarImagens(colorida, homem, 500, 505, 146, 186, 124, 164, 87, 127);
            JuntarImagens(colorida, aviao, 190, 0, 40, 85, 125, 170, 190, 235);
            balao.Dispose();
            homem.Dispose();
            aviao.Dispose();

            // Brilho e cinza partem da composicao colorida.
            // A binarizacao parte da imagem em cinza, com T = 126.
            Bitmap brilho = AumentarBrilho(colorida, 85);
            Bitmap cinza = GerarCinza(colorida);
            Bitmap binaria = GerarBinaria(cinza, 126);
            Bitmap rotacao = Rotacionar(cinza);

            SalvarImagem(colorida, @"C:\Imagens\01_Colorida.jpg");
            SalvarImagem(brilho, @"C:\Imagens\02_Brilho85.jpg");
            SalvarImagem(cinza, @"C:\Imagens\03_Cinza.jpg");
            SalvarImagem(binaria, @"C:\Imagens\04_Binaria.jpg");
            SalvarImagem(rotacao, @"C:\Imagens\05_Rotacao.jpg");

            MostrarImagem(picColorida, colorida);
            MostrarImagem(picBrilho, brilho);
            MostrarImagem(picCinza, cinza);
            MostrarImagem(picBinaria, binaria);
            MostrarImagem(picRotacao, rotacao);
            lblStatus.Text = @"Concluído! As 5 imagens foram salvas em C:\Imagens.";
        }

        // Save foi apresentado nos slides 6 e 7.
        // O formato JPEG explicito foi autorizado para atender ao enunciado.
        private void SalvarImagem(Bitmap imagem, string caminho)
        {
            imagem.Save(caminho, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void MostrarImagem(PictureBox quadro, Bitmap imagem)
        {
            // Libera a imagem anterior ao clicar novamente no mesmo botao.
            if (quadro.Image != null)
                quadro.Image.Dispose();
            quadro.Image = imagem;
        }

        private void LiberarImagens()
        {
            if (picColorida.Image != null)
                picColorida.Image.Dispose();
            if (picBrilho.Image != null)
                picBrilho.Image.Dispose();
            if (picCinza.Image != null)
                picCinza.Image.Dispose();
            if (picBinaria.Image != null)
                picBinaria.Image.Dispose();
            if (picRotacao.Image != null)
                picRotacao.Image.Dispose();
        }

        // Primitivas preservadas do projeto anterior fornecido pelo aluno.
        public Color cores(int r, int g, int b)
        {
            Color cor = new Color();
            cor = Color.FromArgb(r, g, b);
            return cor;
        }

        public Pen caneta(int r, int g, int b)
        {
            Pen caneta = new Pen(cores(r, g, b));
            return caneta;
        }

        public Pen caneta(int r, int g, int b, int esp)
        {
            Pen caneta = new Pen(cores(r, g, b), esp);
            return caneta;
        }

        public Pen caneta(int r, int g, int b, int esp, float[] v)
        {
            Pen caneta = new Pen(cores(r, g, b), esp);
            caneta.DashPattern = v;
            return caneta;
        }

        public void pintaPonto(PaintEventArgs e, Pen caneta, int x, int y)
        {
            e.Graphics.DrawLine(caneta, x, y, x + 1, y);
        }

        public void pintaLinha(PaintEventArgs e, Pen caneta, int x, int y, int x1, int y1)
        {
            e.Graphics.DrawLine(caneta, x, y, x1, y1);
        }

        public void pintaRetangulo(PaintEventArgs e, Pen caneta, int x, int y, int x1, int y1)
        {
            e.Graphics.DrawRectangle(caneta, x, y, x1, y1);
        }

        public void desenhaPoligono(PaintEventArgs e, Pen caneta, Point[] pontos)
        {
            e.Graphics.DrawPolygon(caneta, pontos);
        }

        public void PreenchePoligono(PaintEventArgs e, SolidBrush fundo, Point[] pontos)
        {
            e.Graphics.FillPolygon(fundo, pontos);
        }

        public void PreenchePoligono(PaintEventArgs e, HatchBrush fundo, Point[] pontos)
        {
            e.Graphics.FillPolygon(fundo, pontos);
        }

        public void PreenchePoligono(PaintEventArgs e, TextureBrush fundo, Point[] pontos)
        {
            e.Graphics.FillPolygon(fundo, pontos);
        }

        public SolidBrush preen_Area(Color cor)
        {
            SolidBrush pincel = new SolidBrush(cor);
            return pincel;
        }

        public HatchBrush preen_Area(HatchStyle hachura, Color corL, Color corF)
        {
            HatchBrush pincel = new HatchBrush(hachura, corL, corF);
            return pincel;
        }

        public TextureBrush preen_Area(string imagem)
        {
            Bitmap bmp = new Bitmap(imagem);
            TextureBrush pincel = new TextureBrush(bmp);
            return pincel;
        }

        public Point[] poligono(int[] x, int[] y)
        {
            int tamanho_x_y = x.Length;
            Point[] pontos = new Point[tamanho_x_y];

            for (int i = 0; i < tamanho_x_y; i++)
            {
                Point point1 = new Point(x[i], y[i]);
                pontos[i] = point1;
            }

            return pontos;
        }

        public Color clareiaCor(int r, int g, int b)
        {
            int rc = (r + 255 * 4) / 5;
            int gc = (g + 255 * 4) / 5;
            int bc = (b + 255 * 4) / 5;
            return cores(rc, gc, bc);
        }

        public Color acinzentaCor(int r, int g, int b)
        {
            int rc = (r * 85 + 128 * 15) / 100;
            int gc = (g * 85 + 128 * 15) / 100;
            int bc = (b * 85 + 128 * 15) / 100;
            return cores(rc, gc, bc);
        }


        // Slides 7, paginas 14 a 18: leitura e escrita pixel a pixel.
        // O fundo e identificado por intervalos de intensidade RGB.
        private bool FiltrarFundo(Color cor, int rMin, int rMax,
            int gMin, int gMax, int bMin, int bMax)
        {
            return cor.R >= rMin && cor.R <= rMax
                && cor.G >= gMin && cor.G <= gMax
                && cor.B >= bMin && cor.B <= bMax;
        }

        // Uma unica primitiva de juncao, usada para B, C e D.
        // As coordenadas aplicam a translacao apresentada nos slides 6.
        private void JuntarImagens(Bitmap destino, Bitmap origem, int coluna, int linha,
            int rMin, int rMax, int gMin, int gMax, int bMin, int bMax)
        {
            for (int y = 0; y < origem.Height; y++)
            {
                for (int x = 0; x < origem.Width; x++)
                {
                    Color cor = origem.GetPixel(x, y);
                    if (!FiltrarFundo(cor, rMin, rMax, gMin, gMax, bMin, bMax))
                    {
                        int novoX = x + coluna;
                        int novoY = y + linha;
                        if (novoX >= 0 && novoX < destino.Width
                            && novoY >= 0 && novoY < destino.Height)
                        {
                            destino.SetPixel(novoX, novoY, cor);
                        }
                    }
                }
            }
        }

        // Slides 7, paginas 27 e 29: min(max(I + brilho, 0), 255).
        private int LimitarIntensidade(int intensidade)
        {
            if (intensidade < 0)
                return 0;
            if (intensidade > 255)
                return 255;
            return intensidade;
        }

        private Bitmap AumentarBrilho(Bitmap imagem, int brilho)
        {
            Bitmap nova = new Bitmap(imagem.Width, imagem.Height);
            for (int y = 0; y < imagem.Height; y++)
            {
                for (int x = 0; x < imagem.Width; x++)
                {
                    Color cor = imagem.GetPixel(x, y);
                    int r = LimitarIntensidade(cor.R + brilho);
                    int g = LimitarIntensidade(cor.G + brilho);
                    int b = LimitarIntensidade(cor.B + brilho);
                    nova.SetPixel(x, y, cores(r, g, b));
                }
            }
            return nova;
        }

        // Slides 7, pagina 21: Gray = 0.30 R + 0.59 G + 0.11 B.
        private Bitmap GerarCinza(Bitmap imagem)
        {
            Bitmap nova = new Bitmap(imagem.Width, imagem.Height);
            for (int y = 0; y < imagem.Height; y++)
            {
                for (int x = 0; x < imagem.Width; x++)
                {
                    Color cor = imagem.GetPixel(x, y);
                    int cinza = (int)(cor.R * 0.30 + cor.G * 0.59 + cor.B * 0.11);
                    nova.SetPixel(x, y, cores(cinza, cinza, cinza));
                }
            }
            return nova;
        }

        // Slides 7, pagina 23: I <= T vira 0; I > T vira 255.
        // Esta funcao recebe a imagem ja convertida para cinza.
        private Bitmap GerarBinaria(Bitmap imagemCinza, int limiar)
        {
            Bitmap nova = new Bitmap(imagemCinza.Width, imagemCinza.Height);
            for (int y = 0; y < imagemCinza.Height; y++)
            {
                for (int x = 0; x < imagemCinza.Width; x++)
                {
                    int intensidade = imagemCinza.GetPixel(x, y).R;
                    int valor;
                    if (intensidade <= limiar)
                        valor = 0;
                    else
                        valor = 255;
                    nova.SetPixel(x, y, cores(valor, valor, valor));
                }
            }
            return nova;
        }

        // Slides 6, pagina 20: I(x,y) -> I(y,x), por transposicao.
        private Bitmap Rotacionar(Bitmap imagem)
        {
            Bitmap nova = new Bitmap(imagem.Height, imagem.Width);
            for (int y = 0; y < imagem.Height; y++)
            {
                for (int x = 0; x < imagem.Width; x++)
                {
                    nova.SetPixel(y, x, imagem.GetPixel(x, y));
                }
            }
            return nova;
        }
    }
}
