using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrintErro
{
    public partial class frm_print : Form
    {
        public frm_print()
        {
            InitializeComponent();
            this.Text = "Print de Tela";
        }


        private void btPrint_Click(object sender, EventArgs e)
        {
            PrintScreen();
        }


        private void PrintScreen()
        {
            string caminho = "";
            string nomeimagem = "";

            if (tbObsv.Text == "")
            {
                MessageBox.Show("Campo Obsv não pode ficar em branco!", "Print Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                this.Hide();
                //System.Threading.Thread.Sleep(2000);
                //SendKeys.Send("{PRTSC}");
                
                //Image img = Clipboard.GetImage();

                Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

                Graphics graphics = Graphics.FromImage(printscreen as Image);

                graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);


                caminho = @"\\srvfiles\Departamentos\Supervisao\Print_Erros\";


                string Data = //DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +"_" +
                    DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

                nomeimagem = "Erro_" + Data + "_"+ tbObsv.Text  +"_"+ Environment.MachineName + ".jpg";

                printscreen.Save(caminho + nomeimagem);

                this.Show();

                MessageBox.Show("Imagem salva com sucesso!", "Print Screen", MessageBoxButtons.OK ,MessageBoxIcon.Information);

                Application.Exit();

            }
            catch (Exception e)
            {
                MessageBox.Show("Verifique o nome digitado ele contem caractares invalidos!. Imagem não foi salva"
                                + Environment.NewLine + e.Message, "Imagem não foi salva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }


        private void tbObsv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }  
        }


        private void lbObs_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(@"\\srvfiles\Departamentos\Supervisao\Print_Erros\", "Print gravado na pasta ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void frm_print_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

    }
}
