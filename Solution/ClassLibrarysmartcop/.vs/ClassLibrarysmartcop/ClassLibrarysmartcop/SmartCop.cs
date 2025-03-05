using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Autodesk.Windows;
using ClassLibrarysmartcop.UI.projet;

namespace ClassLibrarysmartcop
{
    static class SmartCop
    {
        public static void CreateInitialPanels(RibbonPanelSource projetPanelSource, RibbonPanel projetPanel)
        {
            Dictionary<string, string[]> sections = new Dictionary<string, string[]>
            {
                { "SmartCop", new string[] { "Préférences", "A propos" } }
            };

            foreach (var section in sections)
            {
                foreach (var buttonText in section.Value)
                {
                    RibbonButton nouveauButton = new RibbonButton
                    {
                        Text = buttonText,
                        Orientation = System.Windows.Controls.Orientation.Vertical,
                        ShowText = true,
                        Size = RibbonItemSize.Large,

                    };

                    string imagePath = buttonText != "Préférences"
                        ? @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\a-propos-de.png"
                        : @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\a-propos-de.png";

                    ICommand cmd = null;
                    switch (buttonText)
                    {
                        case "Préférences":
                            cmd = new PréférencesCommand();
                            break;
                        
                        default:
                            cmd = new ProposCommand();
                            break;

                    }
                    nouveauButton.CommandHandler = cmd;
                    nouveauButton.Image = ImageManager.LoadAndResizeImage(imagePath, 32, 32);
                    nouveauButton.LargeImage = ImageManager.LoadAndResizeImage(imagePath, 32, 32);

                    projetPanelSource.Items.Add(nouveauButton);
                }

                projetPanel.Source = projetPanelSource;
            }
        }
    }
}
