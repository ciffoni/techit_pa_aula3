using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    public class aviao: veiculo
    {
        public aviao()
        {

        }
        public override void locomover()
        {
            MessageBox.Show("Voar");
        }
    }
}
