using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.DAO;
using Biblioteca.Model;

namespace Configurador
{
    /// <summary>
    /// Tela principal do Configurador.
    /// </summary>
    public partial class MainForm : Form
    {
        private Configuration lastConfiguration;
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento do botão Salvar configuração. Realiza a validação dos dados de entrada antes de salvar no banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida os campos do formulário para prosseguir
                if (formIsValid())
                {
                    //Valida as regra de distância entre vãos
                    if (float.Parse(txbMinTotalDistance.Text) < 2.0)
                    {
                        MessageBox.Show("A distância máxima entre vãos deve ser de pelo menos 2 metros.");
                        return;
                    }

                    Configuration configuration = new Configuration();
                    configuration.maxSpansDistance = float.Parse(txbMaxSpansDistance.Text);
                    configuration.minTotalDistance = float.Parse(txbMinTotalDistance.Text);
                    configuration.maxDistanceReinforcedBase = float.Parse(txbMaxDistanceReinforcedBase.Text);
                    ConfigurationDAO cd = new ConfigurationDAO();
                    cd.insert(configuration);
                    clearForm();
                    loadData(); 
                    MessageBox.Show("Configuração salva!.");
                }
                else
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Para cada tecla pressionada avalia se ela é permitida para compor um número decimal válido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbMParam_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = KeyFloatOnlyComma(e.KeyChar, (sender as TextBox).Text);
        }

        /// <summary>
        /// Função para validar os dados de entrada do formulário.
        /// </summary>
        /// <returns>True se as entradas estivem corretas e False caso contrário.</returns>
        private Boolean formIsValid()
        {

            if (txbMaxSpansDistance.Text == string.Empty)
            {
                txbMaxSpansDistance.Focus();
                return false;
            }
            if (txbMinTotalDistance.Text == string.Empty)
            {
                txbMinTotalDistance.Focus();
                return false;
            }
            if (txbMaxDistanceReinforcedBase.Text == string.Empty)
            {
                txbMaxDistanceReinforcedBase.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Limpa os campos do formulário.
        /// </summary>
        private void clearForm()
        {
            txbMaxSpansDistance.Text = String.Empty;
            txbMinTotalDistance.Text = String.Empty;
            txbMaxDistanceReinforcedBase.Text = String.Empty;
        }


        /// <summary>
        /// Efetua a validação para da tecla para os campos decimais permitindo a diditação de números, a vírgula e o tecla de voltar
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private Boolean KeyFloatOnlyComma(char key, string text)
        {
            //permite numeros, virgula e backspace
            if (text.Length == 0 && key.Equals(','))
            {
                //Não permite iniciar o número com a vírgula
                return true;
            }
            else if (text.Contains(key) && key.Equals(','))
            {
                //Não permite duas virgulas no número
                return true;
            }
            else
            {
                switch (key)
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                    case ',':
                    case (char)8: return false;
                    //Outra tecla cancela
                    default: return true;
                }
            }
        }

        /// <summary>
        /// Evento para inserir um novo processamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProcessing_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida os campos do formulário para prosseguir
                if (txbTotalDistance.Text == string.Empty)
                {
                    MessageBox.Show("O campo de Distância mínima deve estar preenchido.");
                    txbTotalDistance.Focus();
                    return;
                }
                else
                {

                    //Valida as regra de distância mínima
                    if (float.Parse(txbTotalDistance.Text) < lastConfiguration.minTotalDistance)
                    {
                        MessageBox.Show("A distância mínima total para configuração atual deve ser de pelo menos ." + lastConfiguration.minTotalDistance.ToString("0.00"));
                        return;
                    }

                    //Insere o novo processamento
                    Processing processing = new Processing();
                    processing.totalDistance = float.Parse(txbTotalDistance.Text);
                    processing.processed = false;
                    processing.configurationId = lastConfiguration.id;
                    ProcessingDAO processingDAO = new ProcessingDAO();
                    processingDAO.insert(processing);
                    loadData();
                    MessageBox.Show("Processamento adicionado!.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Ao abrir a tela faz o carregamento dos dados para preenchimento dos campos necessários
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }




        /// <summary>
        /// Carrega dados do banco para o formulário
        /// </summary>
        private void loadData()
        {

            //Valida a existencia do banco de dados.
            string databasePath = System.Configuration.ConfigurationManager.AppSettings["SQLitePath"];
            if (!File.Exists(databasePath))
            {
                MessageBox.Show("O banco de dados não foi encontrado.\n Ajuste o caminho para arquivo nas configurações da programa.");
                return;
            }


            try
            {
                //Busca a configuração vigente e atualiza os dados da tela
                ConfigurationDAO configurationDAO = new ConfigurationDAO();
                lastConfiguration = configurationDAO.getLast();
                if (lastConfiguration != null)
                {
                    lblCurValueMaxSpansDistance.Text = lastConfiguration.maxSpansDistance.ToString("0.00");
                    lblCurValueMinTotalDistance.Text = lastConfiguration.minTotalDistance.ToString("0.00");
                    lblCurValueMaxDistanceReinforcedBase.Text = lastConfiguration.maxDistanceReinforcedBase.ToString("0.00");
                }

                //Carrega a lista de processamentos não realizados
                ProcessingDAO processingDAO = new ProcessingDAO();
                dgvProcessing.DataSource = processingDAO.getPending();

                //Carrega os resultados não vizualizados
                ResultDAO resultDAO = new ResultDAO();
                List<Result> listResultUnviewed = resultDAO.getUnviewedList(checkBoxViewAll.Checked);

                //Limpa os resultados
                richTextBoxResults.Clear();
                //configura uma fonte maior para o RichTextBox
                Font fontCopy = richTextBoxResults.Font;
                richTextBoxResults.Font = new Font(fontCopy.FontFamily.Name, 9.5F, FontStyle.Regular);

                //Cria um array de cores para destacar cada mudança na Configuração dos processamentos
                Color[] colors = new Color[4] { Color.DarkRed, Color.DarkGreen, Color.DarkOrange, Color.DarkBlue, };
                int color_index = 0;
                Color color = colors[color_index];
                if (listResultUnviewed.Count > 0)
                {
                    richTextBoxResults.AppendText(String.Format("Existem {0} resultados marcados como não visualizados.\n", listResultUnviewed.Count));

                    int configurationId = 0;
                    foreach (Result result in listResultUnviewed)
                    {
                        Processing processing = processingDAO.get(result.processingId);
                        
                        if (configurationId != processing.configurationId)
                        {
                            //Os processamentos são carregados em ordem. Para cada mudança de cofiguração cria-se um cabeçalho com os parâmetros utilizados nos cálculos
                            color = colors[color_index];
                            Configuration configuration = configurationDAO.get(processing.configurationId);
                            AppendText("\nConfiguração utilizada para os próximos processamentos:\n", color);
                            AppendText(String.Format("Distância máxima entre vãos (m)*: {0}\n", configuration.maxSpansDistance), color);
                            AppendText(String.Format("Distância mínima total (m)*: {0}\n", configuration.minTotalDistance), color);
                            AppendText(String.Format("Distância máxima base reforçada (m)*: {0}\n", configuration.maxDistanceReinforcedBase), color);
                            color_index = (color_index >= colors.Length - 1) ? 0 : color_index + 1;
                        }
                        // Imprime a informação do processamento e os resultados obtidos 
                        AppendText(String.Format("\nProcessamento: {0}\n", result.processingId), color);
                        AppendText(String.Format("Distância total (m): {0}\n", processing.totalDistance), color);
                        AppendText(String.Format("Quantidade de pilares a serem incluídos: {0}\n", result.numberPillars), color);
                        AppendText(String.Format("Distância entre vãos (m): {0}\n", result.spansDistance), color);
                        AppendText(String.Format("Quantidade de bases reforçadas a serem incluídas: {0}\n", result.numberReinforcedBases), color);
                        AppendText(String.Format("Pilares que receberão a base reforçada: {0}\n", string.Join(", ", result.reinforcedPillars.Select(n => n.number.ToString()).ToArray())), color);

                        configurationId = processing.configurationId;
                    }
                }
                else
                {
                    richTextBoxResults.ForeColor = Color.Red;
                    richTextBoxResults.AppendText("Não foram encontrados resultados pendentes.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("Ocorreu um erro no carregamento: {0}", ex.Message));
            }
        }

        /// <summary>
        /// Permite incluir no RichTextBox textos com diferente do restante do documento
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public void AppendText(string text, Color color)
        {
            richTextBoxResults.SelectionStart = richTextBoxResults.TextLength;
            richTextBoxResults.SelectionLength = 0;
            richTextBoxResults.SelectionColor = color;
            
            richTextBoxResults.AppendText(text);
            richTextBoxResults.SelectionColor = richTextBoxResults.ForeColor;
        }

        /// <summary>
        /// Se uma linha estiver selecionada habilita o botão de excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProcessing_SelectionChanged(object sender, EventArgs e)
        {
            btnDeleteProcessing.Enabled = true;
        }

        /// <summary>
        /// Exclui um processamento que estiver selecionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteProcessing_Click(object sender, EventArgs e)
        {
            try
            {
                //Recupera o identificador do precessamento
                int linha = dgvProcessing.CurrentRow.Index;
                int processing_id = Convert.ToInt32(dgvProcessing[0, linha].Value);

                //Solicita uma confirmação antes de excluir
                DialogResult response = MessageBox.Show("Deseja excluir este processamento?", "Excluir processamento",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (response == DialogResult.Yes)
                {
                    ProcessingDAO processingDAO = new ProcessingDAO();
                    if (processingDAO.delete(processing_id))
                    {
                        //A exclusão foi realizada e recarrega a lista
                        loadData();
                        MessageBox.Show("Prossamento excluído!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o processamento.");
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Encerra a execução do programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Indica se deve recarregar todos os resultados incluindo os marcados como visualizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxViewAll_Click(object sender, EventArgs e)
        {
            loadData();
        }

        /// <summary>
        /// Altera os resultados não visualizados para visualizdos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            //Carrega os resultados não vizualizados
            ResultDAO resultDAO = new ResultDAO();
            List<Result> listResultUnviewed = resultDAO.getUnviewedList(false);
            foreach(Result result in listResultUnviewed)
            {
                result.viewed = true;
                resultDAO.update(result);
            }

            loadData();
        }
    }
}
