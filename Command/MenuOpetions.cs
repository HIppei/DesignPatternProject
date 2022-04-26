using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class MenuOpetions
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;


        public MenuOpetions(ICommand open, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.saveCommand = save;
            this.closeCommand = close;
        }

        public void ClickOpen()
        {
            openCommand.Execute();
        }

        public void ClickSave()
        {
            saveCommand.Execute();
        }

        public void ClickClose()
        {
            closeCommand.Execute();
        }
    }
}
