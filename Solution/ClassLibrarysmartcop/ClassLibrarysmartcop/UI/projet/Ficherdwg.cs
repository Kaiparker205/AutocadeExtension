using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClassLibrarysmartcop.UI.projet
{

    public class FicherdwgCommand : ICommand
    {
        public FicherdwgCommand()
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
            Fichiers_DWG formFichiers_DWG = new Fichiers_DWG();
            formFichiers_DWG.ShowDialog();

            // Return the selected value
            return selectedValue;
        }


    }
}
