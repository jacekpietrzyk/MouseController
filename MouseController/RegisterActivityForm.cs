using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseController
{
    public partial class RegisterActivityForm : Form
    {
        List<WaitAction> actions = new List<WaitAction>();

        public RegisterActivityForm()
        {
            InitializeComponent();
            
            actions.Add(new WaitAction { DelayTime = 1000, Name = "Jeden" });
            actions.Add(new WaitAction { DelayTime = 2000, Name = "dwa" });
            
            
        }
       
        
    }
}
