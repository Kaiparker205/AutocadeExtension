using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.Windows;
using System.Windows.Forms;

namespace ClassLibrarysmartcop.UI.projet
{
    public class Proprietes:ICommand
    {
        
            
            public Proprietes()
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

                 //Créer une instance du formulaire "proprietes"
                 proprietes formproprietes = new proprietes();

                // Afficher le formulaire de manière bloquante (modal)
                DialogResult result = formproprietes.ShowDialog();

               

                // Return the selected value
                return selectedValue;
            }

           
        }
    
}
