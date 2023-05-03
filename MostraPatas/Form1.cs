namespace MostraPatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //limpa os itens adicionados no ComboBox
            cboAnimais.Items.Clear();

            cboAnimais.Items.Add("Cachorro");
            cboAnimais.Items.Add("Cavalo");
            cboAnimais.Items.Add("Gato");
            cboAnimais.Items.Add("Centopeia");
            cboAnimais.Items.Add("Cobra");
            cboAnimais.Items.Add("P�ssaro");
        }

        private void btnMostraPatas_Click(object sender, EventArgs e)
        {
            //Declara Vari�vel
            string strAnimal;

            //Vari�vel recebe o texto do item do ComboBox selecionado
            strAnimal = cboAnimais.Text;

            int count = cboAnimais.Items.Count;

            //Se o ComboBox tiver pelo menos um item, selecione um aleat�rio
            if (count > 0)
            {
                //Gera um n�mero aleat�rio
                Random random = new Random();

                //Seleciona um n�mero aleat�rio para �ndice e atribui � propriedade Indice Selecionado
                int randomIndice = random.Next(0, count);

                cboAnimais.SelectedIndex = randomIndice;
            }

            //Instru��o de Sele��o
            switch (strAnimal)
            {
                case "Cavalo":
                    //Carregar o arquivo que est� na pasta Debug
                    pctAnimais.Load("animais/Cavalo.png");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK);
                    break;

                case "Gato":
                    pctAnimais.Load("animais/Gato.jpg");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK);
                    break;


                case "Cachorro":
                    pctAnimais.Load("animais/Cachorro.jpg");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK);
                    break;

                case "Centopeia":
                    pctAnimais.Load("animais/Centopeia.jpg");
                    MessageBox.Show("Este animal tem 100 patas", "Animais", MessageBoxButtons.OK);
                    break;

                case "Cobra":
                    pctAnimais.Load("animais/Cobra.jpg");
                    MessageBox.Show("Hoje este animal n�o tem patas, j� teve", "Animais", MessageBoxButtons.OK);
                    break;

                case "P�ssaro":
                    pctAnimais.Load("animais/Passaro.png");
                    MessageBox.Show("Este animal tem 2 patas", "Animais", MessageBoxButtons.OK);
                    break;

                default:
                    MessageBox.Show("Selecione um Animal", "Animais", MessageBoxButtons.OK);
                    break;
            }
        }

        private void cboAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                //Declara Vari�vel
                string strAnimal;

                //Vari�vel recebe o texto do item do ComboBox selecionado
                strAnimal = cboAnimais.Text;

                //Instru��o de Sele��o
                switch (strAnimal)
                {
                    case "Cavalo":
                        //Carregar o arquivo que est� na pasta Debug
                        pctAnimais.Load("animais/Cavalo.png");
                        break;

                    case "Gato":
                        pctAnimais.Load("animais/Gato.jpg");
                        break;


                    case "Cachorro":
                        pctAnimais.Load("animais/Cachorro.jpg");
                        break;

                    case "Centopeia":
                        pctAnimais.Load("animais/Centopeia.jpg");
                        break;

                    case "Cobra":
                        pctAnimais.Load("animais/Cobra.jpg");
                        break;

                    case "P�ssaro":
                        pctAnimais.Load("animais/Passaro.png");
                        break;

                    default:
                        MessageBox.Show("Selecione um Animal", "Animais", MessageBoxButtons.OK);
                        break;
                }
            }
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            //Declara Vari�vel
            var strAnimal = string.Empty;

            int count = cboAnimais.Items.Count;

            //Se o ComboBox tiver pelo menos um item, selecione um aleat�rio
            if (count > 0)
            {
                //Gera um n�mero aleat�rio
                Random random = new Random();

                //Seleciona um n�mero aleat�rio para �ndice e atribui � propriedade Indice Selecionado
                int randomIndice = random.Next(0, count);

                cboAnimais.SelectedIndex = randomIndice;

                //Vari�vel recebe o texto do item do ComboBox selecionado
                strAnimal = cboAnimais.Text;
            }

            //Instru��o de Sele��o
            switch (strAnimal)
            {
                case "Cavalo":
                    //Carregar o arquivo que est� na pasta Debug
                    pctAnimais.Load("animais/Cavalo.png");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK);
                    break;

                case "Gato":
                    pctAnimais.Load("animais/Gato.jpg");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK);
                    break;


                case "Cachorro":
                    pctAnimais.Load("animais/Cachorro.jpg");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK);
                    break;

                case "Centopeia":
                    pctAnimais.Load("animais/Centopeia.jpg");
                    MessageBox.Show("Este animal tem 100 patas", "Animais", MessageBoxButtons.OK);
                    break;

                case "Cobra":
                    pctAnimais.Load("animais/Cobra.jpg");
                    MessageBox.Show("Hoje este animal n�o tem patas, j� teve", "Animais", MessageBoxButtons.OK);
                    break;

                case "P�ssaro":
                    pctAnimais.Load("animais/Passaro.png");
                    MessageBox.Show("Este animal tem 2 patas", "Animais", MessageBoxButtons.OK);
                    break;

                default:
                    MessageBox.Show("Selecione um Animal", "Animais", MessageBoxButtons.OK);
                    break;
            }
        }
    }
}