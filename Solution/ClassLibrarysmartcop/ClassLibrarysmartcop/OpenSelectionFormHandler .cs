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
            using (Form selectionForm = new Form())
            {
                selectionForm.Text = "Choisissez un type de projet";
                selectionForm.Width = 400;
                selectionForm.Height = 250;
                selectionForm.StartPosition = FormStartPosition.CenterScreen;

                FlowLayoutPanel panel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    AutoSize = true
                };

                Button immeubleButton = new Button { Text = "Immeuble", Width = 300, Height = 50 };
                Button residenceButton = new Button { Text = "Résidence", Width = 300, Height = 50 };
                Button ensembleButton = new Button { Text = "Ensemble d'Immeubles", Width = 300, Height = 50 };

                immeubleButton.Click += (sender, e) => { selectedValue = "Immeuble"; selectionForm.Close(); };
                residenceButton.Click += (sender, e) => { selectedValue = "Résidence"; selectionForm.Close(); };
                ensembleButton.Click += (sender, e) => { selectedValue = "Ensemble d'Immeubles"; selectionForm.Close(); };

                panel.Controls.Add(immeubleButton);
                panel.Controls.Add(residenceButton);
                panel.Controls.Add(ensembleButton);
                selectionForm.Controls.Add(panel);

                selectionForm.ShowDialog();
            }
            return selectedValue;
        }

        public static void EnableProprietesButton(RibbonPanelSource projetPanelSource)
        {
            foreach (var item in projetPanelSource.Items)
            {
                if (item is RibbonButton button && button.Text == "Propriétés")
                {
                    button.IsEnabled = true;
                    break;
                }
            }

        }
    }
}