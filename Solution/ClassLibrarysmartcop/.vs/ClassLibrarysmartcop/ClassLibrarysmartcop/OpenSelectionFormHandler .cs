using Autodesk.AutoCAD.EditorInput;
using Autodesk.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using ClassLibrarysmartcop;
using ClassLibrarysmartcop.UI.projet;

namespace ClassLibrarysmartcop
{
    public class OpenSelectionFormHandler : ICommand
    {
        private List<RibbonPanel> hiddenPanels;
        private RibbonTab smartCopTab;
        private RibbonPanelSource projetPanelSourceRef;
        public OpenSelectionFormHandler(List<RibbonPanel> hiddenPanels, RibbonTab smartCopTab, RibbonPanelSource projetPanelSourceRef)
        {
            this.hiddenPanels = hiddenPanels;
            this.smartCopTab = smartCopTab;
            this.projetPanelSourceRef = projetPanelSourceRef;


        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            ed.WriteMessage("\n[DEBUG] Opening Selection Form...");

            string selectedOption = ShowSelectionForm();

            if (selectedOption != null)
            {
                // Reveal additional sections
                if (smartCopTab != null && hiddenPanels.Count > 0)
                {
                    foreach (var panel in hiddenPanels)
                    {
                        smartCopTab.Panels.Add(panel);
                    }
                    hiddenPanels.Clear();
                }
                EnableProprietesButton(projetPanelSourceRef);


                ComponentManager.Ribbon.UpdateLayout();
            }
        }

        private string ShowSelectionForm()
        {
            string selectedValue = null;

            //Créer une instance du formulaire "nouveaux"
            nouveaux formNouveau = new nouveaux();

            // Afficher le formulaire de manière bloquante (modal)
            DialogResult result = formNouveau.ShowDialog();
            
            if (result == DialogResult.OK)
            {               
                selectedValue = "Immeuble";  
            }

            // Return the selected value
            return selectedValue;
        }

        public static void EnableProprietesButton(RibbonPanelSource projetPanelSource)
        {
            foreach (var item in projetPanelSource.Items)
            {
                if (item is RibbonButton button && button.Text == "Propriétés")
                {
                    button.IsEnabled = true;
                    button.CommandHandler = new Proprietes();
                    break;
                }
            }

        }

        
    }
}