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
    public partial class frmCadastroCompra : GUI.frmModeloDeFormularioDeCadastro
    {
        public Double totalCompra = 0;
        public frmCadastroCompra()
        {
            InitializeComponent();
        }

        private void LimpaTela() {
            txt_cod.Clear();
            txt_codfor.Clear();
            txt_nfiscal.Clear();
            txt_codpro.Clear();
            txt_qtd.Clear();
            txt_valunitario.Clear();
            lb_fornecedor.Text = "Informe o código do fornecedor ou clique em localizar";
            lb_produto.Text = "Informe o código do produto ou clique em localizar";
            txt_total.Clear();
            dgv_itenscompra.Rows.Clear();           
        }

        private void frmCadastroCompra_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            cb_nparcelas.SelectedIndex = 0;       
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir"; 
            this.AlteraBotoes(2);
            this.totalCompra = 0;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cb_tpa.DataSource = bll.Localizar("");
            cb_tpa.DisplayMember = "tpa_nome";
            cb_tpa.ValueMember = "tpa_cod";
        }

        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txt_cod.Text = modelo.ComCod.ToString();              
                txt_nfiscal.Text = modelo.ComNotafiscal.ToString();
                dtp_datacompra.Value = modelo.ComData;
                txt_codfor.Text = modelo.ForCod.ToString();
                txt_codfor_Leave(sender, e);

                cb_nparcelas.SelectedValue = modelo.ComNparcelas;               

                BLLTipoPagamento blltp = new BLLTipoPagamento(cx);
                cb_tpa.DataSource = blltp.Localizar("");
                cb_tpa.DisplayMember = "tpa_nome";
                cb_tpa.ValueMember = "tpa_cod";
                cb_tpa.SelectedValue = modelo.TpaCod;

                txt_total.Text = modelo.ComTotal.ToString("N2");             
                //itens da compra
                BLLItensCompra bllitens = new BLLItensCompra(cx);
                DataTable tabela = bllitens.LocalizarPorCompra(modelo.ComCod);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {            
                    Double totalLocal = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itc_valor"]);
                    this.totalCompra += totalLocal;
                    string cod, nome, qtde, valor;
                    cod = tabela.Rows[i]["pro_cod"].ToString();
                    nome = tabela.Rows[i]["pro_nome"].ToString();
                    qtde = tabela.Rows[i]["itc_qtde"].ToString();
                    valor = tabela.Rows[i]["itc_valor"].ToString();
                    String[] g = new String[] { cod, nome, qtde, valor, totalLocal.ToString() };
                    lb_totalcompra.Text = this.totalCompra.ToString("N2");
                    this.dgv_itenscompra.Rows.Add(g);
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
            BLLParcelasCompra bllparcelas = new BLLParcelasCompra(cx);
   
            //verificar se possui parcelas pagas                    
            int pagou = bllparcelas.LocalizarParcelasPagas(Convert.ToInt32(txt_cod.Text));                
            if (pagou == 0)
            {
                this.operacao = "alterar";
                this.AlteraBotoes(2);
            }
            else {
                MessageBox.Show("Não é possível alterar compras com parcelas pagas.");
                this.LimpaTela();
                this.AlteraBotoes(1);
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
                    BLLParcelasCompra bllparcelas = new BLLParcelasCompra(cx);
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
                            BLLItensCompra bllitens = new BLLItensCompra(cx);
                            bllitens.ExcluirTodos(Convert.ToInt32(txt_cod.Text));
                            //excluir quantidade de produtos
                            //trigger
                            BLLCompra bll = new BLLCompra(cx);
                            bll.Cancelar(Convert.ToInt32(txt_cod.Text));
                            MessageBox.Show("Compra inativada com sucesso!");

                            this.LimpaTela();
                            this.AlteraBotoes(1);
                            cx.FinalizarTransacao();
                            cx.Desconectar();
                        }
                        catch(Exception error)
                        {
                            MessageBox.Show(error.Message);
                            cx.CancelarTransacao();
                            cx.Desconectar();
                        }
                    }
                    else {
                        MessageBox.Show("Compra com parcelas pagas não podem ser canceladas.");
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
            Double totalLocal = this.totalCompra;
            Double valparc = totalLocal / parcelas;        
            valparc = Math.Round(valparc,2);
            DateTime dt = new DateTime();
            dt = dtp_datainipag.Value;
            lb_totalcompra.Text = totalLocal.ToString("N2");

            for (int i = 1; i <= parcelas; i++)
            {
                String [] j = new String[] { i.ToString(), valparc.ToString(), dt.Date.ToString() };
                this.dgv_parcelas.Rows.Add(j);
                        
                if (dt.Month != 12)
                {                
                    dt = new DateTime(dt.Year, dt.Month+1, dt.Day);
                }
                else
                {
                    dt = new DateTime(dt.Year+1, 1, dt.Day);
                }      
            }
            pn_pagamento.Visible = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
        }

        private void btn_localizafor_Click(object sender, EventArgs e)
        {
             frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txt_codfor.Text = f.codigo.ToString();
                txt_codfor_Leave(sender, e);
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
            if ((txt_codpro.Text != "") && (txt_qtd.Text != "" ) && (txt_valunitario.Text != ""))
            {
                Double totalLocal = Convert.ToDouble(txt_qtd.Text) * Convert.ToDouble(txt_valunitario.Text);
                this.totalCompra += totalLocal;
                String[] i = new String[] { txt_codpro.Text, lb_produto.Text, txt_qtd.Text, txt_valunitario.Text, totalLocal.ToString() };
                this.dgv_itenscompra.Rows.Add(i);
                txt_total.Text = this.totalCompra.ToString("N2");

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

        private void txt_codfor_Leave(object sender, EventArgs e)
        {         
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txt_codfor.Text));
                
                if (modelo.ForNome == "")
                {
                    txt_codfor.Clear();
                    lb_fornecedor.Text = "Informe o código do cliente ou clique em localizar";
                }
                else
                {
                    lb_fornecedor.Text = modelo.ForNome;
                }
            }
            catch {
                txt_codfor.Clear();
                lb_fornecedor.Text = "Informe o código do fornecedor ou clique em localizar";
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
                    txt_valunitario.Text = modelo.ProValorpago.ToString();
                }
                else
                {
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

        private void dgv_itenscompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {        
            if (e.RowIndex >= 0) {
                txt_codpro.Text = dgv_itenscompra.Rows[e.RowIndex].Cells[0].Value.ToString();
                lb_produto.Text = dgv_itenscompra.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_qtd.Text = dgv_itenscompra.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_valunitario.Text = dgv_itenscompra.Rows[e.RowIndex].Cells[3].Value.ToString();

                Double valor = Convert.ToDouble(txt_qtd.Text) * Convert.ToDouble(txt_valunitario.Text);
                this.totalCompra -= valor;
                dgv_itenscompra.Rows.RemoveAt(e.RowIndex);
                txt_total.Text = this.totalCompra.ToString("N2");              
            }
        }

        private void btn_cancelaFinalizaCompra_Click(object sender, EventArgs e)
        {
            pn_pagamento.Visible = false;
        }

        private void btn_salvaFinalizaCompra_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //leitura de dados
                ModeloCompra modelo = new ModeloCompra();                          
                modelo.ComData = Convert.ToDateTime(dtp_datacompra.Value);
                modelo.ComNotafiscal = Convert.ToInt32(txt_nfiscal.Text);
                modelo.ComTotal = Convert.ToDouble(txt_total.Text);
                modelo.ComNparcelas = Convert.ToInt32(cb_nparcelas.Text);
                modelo.ComStatus = "Ativa"; //poderia estar como pedido, comprado, ativo, efetuado
                modelo.ForCod = Convert.ToInt32(txt_codfor.Text);
                modelo.TpaCod = Convert.ToInt32(cb_tpa.SelectedValue);              
                //obj para gravar os dados no banco
              
                BLLCompra bll = new BLLCompra(cx);
                ModeloItensCompra modeloItens = new ModeloItensCompra();
                BLLItensCompra bllitem = new BLLItensCompra(cx);

                ModeloParcelasCompra modeloParc = new ModeloParcelasCompra();
                BLLParcelasCompra bllparc = new BLLParcelasCompra(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar compra
                    bll.Incluir(modelo);
                    //cadastrar itens da compra
                    for (int i = 0; i < dgv_itenscompra.RowCount; i++)
                    {
                        modeloItens.ItcCod = i + 1;
                        modeloItens.ComCod = modelo.ComCod;
                        modeloItens.ProCod = Convert.ToInt32(dgv_itenscompra.Rows[i].Cells[0].Value);                  
                        modeloItens.ItcQtde = Convert.ToDouble(dgv_itenscompra.Rows[i].Cells[2].Value);
                        modeloItens.ItcValor = Convert.ToDouble(dgv_itenscompra.Rows[i].Cells[3].Value);
                        bllitem.Incluir(modeloItens);
                        //alterar a quantidade de produtos comprados na tabela produtos 
                        //usando trigger

                    }

                    //cadastrar as parcelas da compra
                    for (int i = 0; i < dgv_parcelas.RowCount; i++)
                    {
                        modeloParc.ComCod = modelo.ComCod;
                        modeloParc.PcoCod = Convert.ToInt32(dgv_parcelas.Rows[i].Cells[0].Value);
                        modeloParc.PcoValor = Convert.ToDouble(dgv_parcelas.Rows[i].Cells[1].Value);
                        modeloParc.PcoDataVecto = Convert.ToDateTime(dgv_parcelas.Rows[i].Cells[2].Value);
                        bllparc.Incluir(modeloParc);
                    }
                    MessageBox.Show("Compra realizada - Código " + modelo.ComCod.ToString());
                }
                else
                {
                        modelo.ComCod = Convert.ToInt32(txt_cod.Text);            
                        //alterar compras
                        bll.Alterar(modelo);
                        //exclui e add itens 
                        bllitem.ExcluirTodos(modelo.ComCod);
                        for (int i = 0; i < dgv_itenscompra.RowCount; i++)
                        {
                            modeloItens.ItcCod = i + 1;
                            modeloItens.ComCod = modelo.ComCod;
                            modeloItens.ProCod = Convert.ToInt32(dgv_itenscompra.Rows[i].Cells[0].Value);
                            modeloItens.ItcQtde = Convert.ToDouble(dgv_itenscompra.Rows[i].Cells[2].Value);
                            modeloItens.ItcValor = Convert.ToDouble(dgv_itenscompra.Rows[i].Cells[3].Value);
                            bllitem.Incluir(modeloItens);
                            //add quantidade de produto
                            //usando trigger
                        }

                        //exclui e add parcelas
                        bllparc.ExcluirTodasAsParcelas(modelo.ComCod);
                        for (int i = 0; i < dgv_parcelas.RowCount; i++)
                        {
                            modeloParc.ComCod = modelo.ComCod;
                            modeloParc.PcoCod = Convert.ToInt32(dgv_parcelas.Rows[i].Cells[0].Value);
                            modeloParc.PcoValor = Convert.ToDouble(dgv_parcelas.Rows[i].Cells[1].Value);
                            modeloParc.PcoDataVecto = Convert.ToDateTime(dgv_parcelas.Rows[i].Cells[2].Value);
                            bllparc.Incluir(modeloParc);
                        }
                        MessageBox.Show("Compra alterada.");
                    }                           
                           
                this.LimpaTela();
                this.pn_pagamento.Visible = false;
                this.AlteraBotoes(1);
                cx.FinalizarTransacao();
                cx.Desconectar();
                //contador de qtde de parcelas a serem pagas da compra

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
        }
    }
}
