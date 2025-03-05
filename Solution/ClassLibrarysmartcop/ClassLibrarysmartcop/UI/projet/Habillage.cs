using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ClassLibrarysmartcop.UI.projet
{
    
    public class HabillageCommand : ICommand
    {
        public HabillageCommand()
        {
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
        

            string selectedOption = ShowSelectionForm();

        }

        private string ShowSelectionForm()
        {
            string selectedValue = null;

            //Créer une instance du formulaire "Habillage"
            Habillage formhabillage = new Habillage();
            formhabillage.ShowDialog();

            // Return the selected value
            return selectedValue;
        }


    }
}
