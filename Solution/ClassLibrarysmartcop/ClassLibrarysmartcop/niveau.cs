using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Windows;

namespace ClassLibrarysmartcop
{
    static class niveau
    {
        public static void CreateInitialPanels(RibbonPanelSource projetPanelSource, RibbonPanel projetPanel)
        {
            Dictionary<string, string[]> sections = new Dictionary<string, string[]>
            {
                { "Niveau/Parties", new string[] { "Fichier DWG", "Niveaux", "Privatives/Communes" } }
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

                    string imagePath = "Fichier DWG" == buttonText
                        ? @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\generer.png"
                        : "Niveaux" == buttonText? @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\niveaux.png"
                        : @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Privqtives Communes.png";

                    nouveauButton.Image = ImageManager.LoadAndResizeImage(imagePath, 32, 32);
                    nouveauButton.LargeImage = ImageManager.LoadAndResizeImage(imagePath, 32, 32);

                    projetPanelSource.Items.Add(nouveauButton);
                }

                projetPanel.Source = projetPanelSource;
            }
        }
    }
}
