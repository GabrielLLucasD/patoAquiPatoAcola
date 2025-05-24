using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patos2
{
    public partial class FormPatos : Form
    {
        private List<Duck> listaDePatos = new List<Duck>();
        private int indexAtual = 0;

        public FormPatos()
        {
            InitializeComponent();
            listaDePatos.Add(new MallardDuck());
            listaDePatos.Add(new RubberDuck());
            listaDePatos.Add(new RedHeadDuck());
            listaDePatos.Add(new PatoChef());
            listaDePatos.Add(new PatoLaser());
            listaDePatos.Add(new PatoMestre());

            MostrarPatoAtual();
        }

        private void pictureBoxPato_Click(object sender, EventArgs e)
        {

        }

        private Image ObterImagemDoPato(Duck pato)
        {
            if (pato == null)
                return null;

            string nomeClasse = pato.GetType().Name;
            string caminho = Path.Combine(Application.StartupPath, "imagens", nomeClasse + ".jpg");

            if (File.Exists(caminho))
            {
                return Image.FromFile(caminho);
            }

            return null;
        }

        private void MostrarPatoAtual()
        {
            if (listaDePatos.Count == 0)
            {
                return;
            }

            Duck patoAtual = listaDePatos[indexAtual];
            pictureBoxPato.Image = ObterImagemDoPato(patoAtual);
            string nome = patoAtual.GetType().Name.Replace("Duck", "");
            lblNome.Text = nome;
            AtualizarPoderes();
        }

        private void AtualizarPoderes()
        {
            Duck patoAtual = listaDePatos[indexAtual];
            List<string> poderes = new List<string>();

            if (patoAtual is IFlyable)
                poderes.Add("Voar");
            if (patoAtual is IQuackable)
                poderes.Add("Quack");
            if (patoAtual is IEspecial)
                poderes.Add("Especial");

            if (poderes.Count == 0)
                lblPoderes.Text = "Sem poderes.";
            else
                lblPoderes.Text = "Poderes: " + string.Join(", ", poderes);
        }

        private void FormPatos_Load(object sender, EventArgs e)
        {
            MostrarPatoAtual();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (listaDePatos.Count == 0)
            {
                return;
            }

            indexAtual++;
            if (indexAtual >= listaDePatos.Count)
            {
                indexAtual = 0;
            }

            MostrarPatoAtual();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (listaDePatos.Count == 0)
            {
                return;
            }

            indexAtual--;
            if (indexAtual < 0)
            {
                indexAtual = listaDePatos.Count - 1;
            }

            MostrarPatoAtual();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            GerarBotoesDePoder();
            panelPoderes.Visible = true;
            btnAnterior.Visible = false;
            btnProximo.Visible = false;
            btnEscolher.Visible = false;
        }

        private void GerarBotoesDePoder()
        {
            panelPoderes.Controls.Clear();

            Duck patoAtual = listaDePatos[indexAtual];

            int espacamento = 10;
            int larguraBotao = 100;
            int alturaBotao = 40;
            int posX = 0;

            void AdicionarBotao(string texto, Func<string> acaoComRetorno)
            {
                Button botao = new Button();
                botao.Text = texto;
                botao.Size = new Size(larguraBotao, alturaBotao);
                botao.Location = new Point(posX, 0);
                botao.Click += (s, e) => {
                    string resultado = acaoComRetorno();
                    lblPoderes.Text = resultado;
                };

                panelPoderes.Controls.Add(botao);
                posX += larguraBotao + espacamento;
            }

            if (patoAtual is IFlyable flyable)
            {
                AdicionarBotao("Voar", () => flyable.Fly());
            }

            if (patoAtual is IQuackable quackable)
            {
                AdicionarBotao("Quack", () => quackable.Quack());
            }

            if (patoAtual is IEspecial especial)
            {
                AdicionarBotao("Especial", () => especial.ExecutarEspecial());
            }

            Button botaoVoltar = new Button();
            botaoVoltar.Text = "Voltar";
            botaoVoltar.Size = new Size(larguraBotao, alturaBotao);
            botaoVoltar.Location = new Point(posX, 0);
            botaoVoltar.Click += (s, e) => {
                panelPoderes.Visible = false;

                btnAnterior.Visible = true;
                btnProximo.Visible = true;
                btnEscolher.Visible = true;

                lblPoderes.Visible = true;

                MostrarPatoAtual();
            };
            panelPoderes.Controls.Add(botaoVoltar);
        }
    }
}
