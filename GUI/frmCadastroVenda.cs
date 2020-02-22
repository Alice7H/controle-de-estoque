using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroVenda : GUI.frmModeloDeFormularioDeCadastro
    {
        public Double totalVenda = 0;
        public frmCadastroVenda()
        {
            InitializeComponent();
        }
        private void LimpaTela()
        {
            txt_cod.Clear();
            txt_codcli.Clear();
            txt_nfiscal.Clear();
            txt_codpro.Clear();
            txt_qtd.Clear();
            txt_valunitario.Clear();
            lb_cliente.Text = "Informe o código do cliente ou clique em localizar";
            lb_produto.Text = "Informe o código do produto ou clique em localizar";
            txt_total.Clear();
            dgv_itensvenda.Rows.Clear();
            ckb_vista.Checked = false;
        }

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            cb_nparcelas.SelectedIndex = 0;
        }
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
            this.totalVenda = 0;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cb_tpa.DataSource = bll.Localizar("");
            cb_tpa.DisplayMember = "tpa_nome";
            cb_tpa.ValueMember = "tpa_cod";
        }
        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                txt_cod.Text = modelo.VenCod.ToString();
                txt_nfiscal.Text = modelo.VenNfiscal.ToString();
                dtp_datavenda.Value = modelo.VenData;
                txt_codcli.Text = modelo.CliCod.ToString();
                txt_codcli_Leave(sender, e);

                cb_nparcelas.SelectedValue = modelo.VenNparcelas;

                BLLTipoPagamento blltp = new BLLTipoPagamento(cx);
                cb_tpa.DataSource = blltp.Localizar("");
                cb_tpa.DisplayMember = "tpa_nome";
                cb_tpa.ValueMember = "tpa_cod";
                cb_tpa.SelectedValue = modelo.TpaCod;

                txt_total.Text = modelo.VenTotal.ToString("N2");
                //itens da venda
                BLLItensVenda bllitens = new BLLItensVenda(cx);
                DataTable tabela = bllitens.LocalizarPorVenda(modelo.VenCod);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    Double totalLocal = Convert.ToDouble(tabela.Rows[i]["itv_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itv_valor"]);
                    this.totalVenda += totalLocal;
                    string cod, nome, qtde, valor;
                    cod = tabela.Rows[i]["pro_cod"].ToString();
                    nome = tabela.Rows[i]["pro_nome"].ToString();
                    qtde = tabela.Rows[i]["itv_qtde"].ToString();
                    valor = tabela.Rows[i]["itv_valor"].ToString();                  
                    String[] g = new String[] { cod, nome, qtde, valor, totalLocal.ToString() };
                    lb_totalvenda.Text = this.totalVenda.ToString("N2");
                    this.dgv_itensvenda.Rows.Add(g);
                }
                this.AlteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
    }
    f.Dispose();
        }
        private void btn_Alterar_Click(object sender, EventArgs e)
        {

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLParcelasVenda bllparcelas = new BLLParcelasVenda(cx);

            //verificar se possui parcelas pagas                    
            int pagou = bllparcelas.LocalizarParcelasPagas(Convert.ToInt32(txt_cod.Text));
            if (pagou == 0)
            {
                this.operacao = "alterar";
                this.AlteraBotoes(2);
            }
            else
            {
                MessageBox.Show("Não é possível alterar vendas as parcelas pagas.");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja cancelar o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLParcelasVenda bllparcelas = new BLLParcelasVenda(cx);
                    //verificar se possui parcelas pagas                                       
                    int pagou = bllparcelas.LocalizarParcelasPagas(Convert.ToInt32(txt_cod.Text));
                    if (pagou == 0)
                    {

                        cx.Conectar();
                        cx.IniciarTransacao();
                        try
                        {
                            //excluir as parcelas da compra
                            bllparcelas.ExcluirTodasAsParcelas(Convert.ToInt32(txt_cod.Text));
                            //excluir itens da compra
                            BLLItensVenda bllitens = new BLLItensVenda(cx);
                            bllitens.ExcluirTodos(Convert.ToInt32(txt_cod.Text));
                            //excluir quantidade de produtos
                            //trigger
                            BLLVenda bll = new BLLVenda(cx);
                            bll.Cancelar(Convert.ToInt32(txt_cod.Text));
                            MessageBox.Show("Venda inativada com sucesso!");

                            this.LimpaTela();
                            this.AlteraBotoes(1);
                            cx.FinalizarTransacao();
                            cx.Desconectar();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                            cx.CancelarTransacao();
                            cx.Desconectar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Venda com parcelas pagas não podem ser canceladas.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Impossível cancelar o registro.");
                this.AlteraBotoes(3);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            dgv_parcelas.Rows.Clear();
            int parcelas = Convert.ToInt32(cb_nparcelas.Text);
            Double totalLocal = this.totalVenda;
            Double valparc = totalLocal / parcelas;
            valparc = Math.Round(valparc, 2);
            DateTime dt = new DateTime();
            dt = dtp_datainirec.Value;
            lb_totalvenda.Text = totalLocal.ToString("N2");

            for (int i = 1; i <= parcelas; i++)
            {
                String[] j = new String[] { i.ToString(), valparc.ToString(), dt.Date.ToString() };
                this.dgv_parcelas.Rows.Add(j);

                if (dt.Month != 12)
                {
                    dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                }
                else
                {
                    dt = new DateTime(dt.Year + 1, 1, dt.Day);
                }
            }
            pn_pagamento.Visible = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
        }

        private void btn_localizacli_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txt_codcli.Text = f.codigo.ToString();
                txt_codcli_Leave(sender, e);
            }
        }

        private void btn_localizaprod_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txt_codpro.Text = f.codigo.ToString();
                txt_codpro_Leave(sender, e);
            }
        }

        private void btn_addprod_Click(object sender, EventArgs e)
        {
            if ((txt_codpro.Text != "") && (txt_qtd.Text != "") && (txt_valunitario.Text != ""))
            {
                Double totalLocal = Convert.ToDouble(txt_qtd.Text) * Convert.ToDouble(txt_valunitario.Text);
                this.totalVenda += totalLocal;
                String[] i = new String[] { txt_codpro.Text, lb_produto.Text, txt_qtd.Text, txt_valunitario.Text, totalLocal.ToString() };
                this.dgv_itensvenda.Rows.Add(i);
                txt_total.Text = this.totalVenda.ToString("N2");

                //limpa campos relacionado aos produtos
                this.LimpaProduto();
            }
        }

        private void LimpaProduto()
        {
            txt_codpro.Clear();
            lb_produto.Text = "Informe o código do produto ou clique em localizar.";
            txt_qtd.Clear();
            txt_valunitario.Clear();
        }

        private void txt_codcli_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txt_codcli.Text));
                if (modelo.CliNome == "")
                {
                    txt_codcli.Clear();
                    lb_cliente.Text = "Informe o código do cliente ou clique em localizar";
                }
                else
                {
                    lb_cliente.Text = modelo.CliNome;
                }
            }
            catch
            {
                txt_codcli.Clear();
                lb_cliente.Text = "Informe o código do cliente ou clique em localizar";
            }
        }

        private void txt_codpro_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txt_codpro.Text));
                if (modelo.ProNome != "")
                {
                    lb_produto.Text = modelo.ProNome;
                    txt_qtd.Text = "1";
                    txt_valunitario.Text = modelo.ProValorvenda.ToString("N2");
                }
                else {
                    txt_codpro.Clear();
                    lb_produto.Text = "Informe o código do produto ou clique em localizar";
                }
            }
            catch
            {
                txt_codpro.Clear();
                lb_produto.Text = "Informe o código do produto ou clique em localizar";
            }
        }

        private void dgv_itensvenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_codpro.Text = dgv_itensvenda.Rows[e.RowIndex].Cells[0].Value.ToString();
                lb_produto.Text = dgv_itensvenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_qtd.Text = dgv_itensvenda.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_valunitario.Text = dgv_itensvenda.Rows[e.RowIndex].Cells[3].Value.ToString();

                Double valor = Convert.ToDouble(txt_qtd.Text) * Convert.ToDouble(txt_valunitario.Text);
                this.totalVenda -= valor;
                dgv_itensvenda.Rows.RemoveAt(e.RowIndex);
                txt_total.Text = this.totalVenda.ToString("N2");
            }
        }

        private void btn_cancelaFinalizaVenda_Click(object sender, EventArgs e)
        {
            pn_pagamento.Visible = false;
        }

        private void btn_salvaFinalizaVenda_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //leitura de dados
                ModeloVenda modelo = new ModeloVenda();                
                modelo.VenData = Convert.ToDateTime(dtp_datavenda.Value);
                modelo.VenNfiscal = Convert.ToInt32(txt_nfiscal.Text);
                modelo.VenTotal = Convert.ToDouble(txt_total.Text);
                modelo.VenNparcelas = Convert.ToInt32(cb_nparcelas.Text);
                modelo.VenStatus = "EFETUADA"; //poderia estar como pedido, comprado, ativo, efetuado
                modelo.CliCod = Convert.ToInt32(txt_codcli.Text);
                modelo.TpaCod = Convert.ToInt32(cb_tpa.SelectedValue);

                if (ckb_vista.Checked == true || modelo.VenNparcelas == 1)
                {
                    modelo.VenAvista = 1;                
                }
                else
                {
                    modelo.VenAvista = 0;
                }
                //obj para gravar os dados no banco

                BLLVenda bll = new BLLVenda(cx);
                ModeloItensVenda modeloItens = new ModeloItensVenda();
                BLLItensVenda bllitem = new BLLItensVenda(cx);

                ModeloParcelasVenda modeloParc = new ModeloParcelasVenda();
                BLLParcelasVenda bllparc = new BLLParcelasVenda(cx);

                if (this.operacao == "inserir")
                {                   
                    //cadastrar venda
                    bll.Incluir(modelo);
                    //cadastrar itens da venda
                    for (int i = 0; i < dgv_itensvenda.RowCount; i++)
                    {
                        modeloItens.ItvCod = i + 1;
                        modeloItens.VenCod = modelo.VenCod;
                        modeloItens.ProCod = Convert.ToInt32(dgv_itensvenda.Rows[i].Cells[0].Value);
                        modeloItens.ItvQtde = Convert.ToDouble(dgv_itensvenda.Rows[i].Cells[2].Value);
                        modeloItens.ItvValor = Convert.ToDouble(dgv_itensvenda.Rows[i].Cells[3].Value);
                        bllitem.Incluir(modeloItens);
                        //alterar a quantidade de produtos vendidos na tabela produtos 
                        //usando trigger

                    }

                    //cadastrar as parcelas da venda
                    for (int i = 0; i < dgv_parcelas.RowCount; i++)
                    {
                        modeloParc.VenCod = modelo.VenCod;
                        modeloParc.PveCod = Convert.ToInt32(dgv_parcelas.Rows[i].Cells[0].Value);
                        modeloParc.PveValor = Convert.ToDouble(dgv_parcelas.Rows[i].Cells[1].Value);
                        modeloParc.PveDataVecto = Convert.ToDateTime(dgv_parcelas.Rows[i].Cells[2].Value);                    
                        bllparc.Incluir(modeloParc);
                    }
                    MessageBox.Show("Venda realizada - Código " + modelo.VenCod.ToString());
                }
                else
                {
                    //alterar venda
                    modelo.VenCod = Convert.ToInt32(txt_cod.Text);
                    bll.Alterar(modelo);
                    //exclui e add itens 
                    bllitem.ExcluirTodos(modelo.VenCod);
                    for (int i = 0; i < dgv_itensvenda.RowCount; i++)
                    {
                        modeloItens.ItvCod = i + 1;
                        modeloItens.VenCod = modelo.VenCod;
                        modeloItens.ProCod = Convert.ToInt32(dgv_itensvenda.Rows[i].Cells[0].Value);
                        modeloItens.ItvQtde = Convert.ToDouble(dgv_itensvenda.Rows[i].Cells[2].Value);
                        modeloItens.ItvValor = Convert.ToDouble(dgv_itensvenda.Rows[i].Cells[3].Value);
                        bllitem.Incluir(modeloItens);
                        //remove quantidade de produto
                        //usando trigger
                    }

                    //exclui e add parcelas
                    bllparc.ExcluirTodasAsParcelas(modelo.VenCod);
                    for (int i = 0; i < dgv_parcelas.RowCount; i++)
                    {
                        modeloParc.VenCod = modelo.VenCod;
                        modeloParc.PveCod = Convert.ToInt32(dgv_parcelas.Rows[i].Cells[0].Value);
                        modeloParc.PveValor = Convert.ToDouble(dgv_parcelas.Rows[i].Cells[1].Value);
                        modeloParc.PveDataVecto = Convert.ToDateTime(dgv_parcelas.Rows[i].Cells[2].Value);
                        bllparc.Incluir(modeloParc);
                    }
                    MessageBox.Show("Venda alterada.");
                }

                this.LimpaTela();
                this.pn_pagamento.Visible = false;
                this.AlteraBotoes(1);
                cx.FinalizarTransacao();
                cx.Desconectar();
                //contador de qtde de parcelas a serem recebidas da venda

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
        }

        private void ckb_vista_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_vista.Checked == true)
            {              
                cb_nparcelas.SelectedIndex = 0;
                cb_nparcelas.Enabled = false;
                //dtp_datainirec.Enabled = false;
            }
            else
            {
                cb_nparcelas.Enabled = true;
            }
        }
    }
}
