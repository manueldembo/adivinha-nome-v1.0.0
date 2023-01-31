using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace adivinha_nome
{
    public partial class frmJogo : Form
    {
        int pontuacao = 0;
        int oportunidades = 3;
        int pos = 0;
        int[] pontuacoes;
        ArrayList respostas = new ArrayList();
        ArrayList imagens = new ArrayList();
        clOperacoes ope = new clOperacoes();
        public frmJogo()
        {
            InitializeComponent();
            pontuacoes = ope.LerPontuacoes();
            respostas.AddRange(vars.respostasPersonagens);
            imagens.AddRange(vars.imagensPersonagens);
        }

        private void picResponder_Click(object sender, EventArgs e)
        {
            if (respostas[pos].ToString().Contains(" "))
            {
                string[] resposta = respostas[pos].ToString().Split(' ');

                if (txtResposta.Text.Contains(resposta[0]) && txtResposta.Text.Contains(resposta[1]))
                    RespostaCerta();
                else
                {
                    oportunidades--;
                    lblOportunidades.Text = $"Oportunidades: {oportunidades}";
                }
            }
            else
            {
                if (txtResposta.Text == respostas[pos].ToString())
                    RespostaCerta();
                else
                {
                    oportunidades--;
                    lblOportunidades.Text = $"Oportunidades: {oportunidades}";
                }
            }

            if (oportunidades == 0)
            {
                ope.GravarPontuacoes(pontuacao, pontuacoes);
                this.Close();
            }
        }

        private void picResponder_MouseEnter(object sender, EventArgs e)
        {
            picResponder.Image = Image.FromFile(vars.responderLuz);
        }

        private void picResponder_MouseLeave(object sender, EventArgs e)
        {
            picResponder.Image = Image.FromFile(vars.responder);
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            GerarPergunta();
        }
        private void GerarPergunta() {
            txtResposta.Text = "";
            Random rd = new Random();
            int pos = rd.Next(0, respostas.Count);
            picImagem.Image = Image.FromFile(vars.pastaPersonagens + imagens[pos]);
            txtResposta.MaxLength = respostas[pos].ToString().Length;
            this.pos = pos;
        }

        private void RespostaCerta() {
            oportunidades = 3;
            lblOportunidades.Text = $"Oportunidades: {oportunidades}";
            pontuacao++;
            lblRespostas.Text = $"Respostas: {pontuacao}";
            respostas.RemoveAt(pos);
            imagens.RemoveAt(pos);
            
            if (pontuacao == vars.respostasPersonagens.Length)
            {
                MessageBox.Show("Parabéns você ganhou");
                this.Close();
                ope.GravarPontuacoes(pontuacao, pontuacoes);
            }
            else
                GerarPergunta();
        }
    }
}
