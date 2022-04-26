using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            ICommand openCommand = new OpenCommand(document);
            ICommand saveCommand = new SaveCommand(document);
            ICommand closeCommand = new CloseCommand(document);

            MenuOpetions menu = new MenuOpetions(openCommand, saveCommand, closeCommand);

            menu.ClickOpen();
            menu.ClickSave();
            menu.ClickSave();
        }
    }
}
