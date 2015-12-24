using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplicationClient
{
    internal class HideOnStartupApplicationContext : ApplicationContext
    {
        private base_form mainFormInternal;

        // 构造函数，主窗体被存储在mainFormInternal
        public HideOnStartupApplicationContext(base_form mainForm)
        {
            this.mainFormInternal = mainForm;

            this.mainFormInternal.Closed += new EventHandler(mainFormInternal_Closed);
        }
        void mainFormInternal_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
