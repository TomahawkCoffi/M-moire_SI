using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mémoire_SI
{
    public partial class Chargement : Form
    {
        public Chargement()
        {
            InitializeComponent();

            Task.Run(Work);
        }

        private void Work()
        {
            do
            {
                Thread.Sleep(100);
                guna2CircleProgressBar1.Value++;
                //guna2CircleProgressBar1.Update();

            } while (guna2CircleProgressBar1.Value < guna2CircleProgressBar1.Maximum);

            new Userlogin().Show();
            this.Hide();

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, System.EventArgs e)
        {

        }
    }
}
