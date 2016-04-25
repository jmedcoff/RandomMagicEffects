using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomMagicEffects.Business_Logic;

namespace RandomMagicEffects
{
    public partial class Form1 : Form
    {

        private IListReader lr;
        private IMagicEffects me;
            
        public Form1()
        {
            InitializeComponent();
            lr = new ListReader();
            me = new MagicEffects(lr.getMagicList());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = me.getRandMagicEffect();
        }
    }
}
