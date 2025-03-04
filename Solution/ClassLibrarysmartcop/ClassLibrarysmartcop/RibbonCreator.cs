using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.GraphicsInterface;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Windows;
using static System.Net.Mime.MediaTypeNames;

[assembly: CommandClass(typeof(ClassLibrarysmartcop.RibbonCreator))]

namespace ClassLibrarysmartcop
{
    public class RibbonCreator
    {
        private static List<RibbonPanel> hiddenPanels = new List<RibbonPanel>();
        private static RibbonTab SmartCopTab;
        private static RibbonPanelSource projetPanelSourceRef;

        [CommandMethod("SmartCop")]
        public static void LoadSmartCopRibbon()
        {
            try
            {
            
            Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            ed.WriteMessage("\n[DEBUG] Running SmartCop Ribbon setup...");

            // Get the AutoCAD Ribbon
            RibbonControl ribbonControl = ComponentManager.Ribbon;
            if (ribbonControl == null)
            {
                ed.WriteMessage("\n[ERROR] Unable to access the Ribbon Control.");
                return;
            }

            // Check if the tab already exists
            SmartCopTab = null;
            foreach (RibbonTab existingTab in ribbonControl.Tabs)
            {
                if (existingTab.Title == "SmartCop")
                {
                    SmartCopTab = existingTab;
                    break;
                }
            }

            // Create the tab if it doesn't exist
            if (SmartCopTab == null)
            {
                SmartCopTab = new RibbonTab
                {
                    Title = "SmartCop",
                    Id = "SmartCop_TAB"
                };
                ribbonControl.Tabs.Add(SmartCopTab);
                ed.WriteMessage("\n[DEBUG] SmartCop Ribbon has been added.");
            }

            #region Projet
            // Create Projet Panel (Initial View)
            RibbonPanelSource projetPanelSource = new RibbonPanelSource
            {
                Title = "Projet"
            };
            RibbonPanel projetPanel = new RibbonPanel
            {
                Source = projetPanelSource
            };

            // Create "Nouveau and Propriétés" RibbonButton.
            CreateInitialPanels(projetPanelSource, projetPanel);

            // Add the panel to the tab
           //this***** SmartCopTab.Panels.Add(projetPanel);
            #endregion

            CreateHiddenPanels();
            ComponentManager.Ribbon.UpdateLayout();
        }
            catch (System.Exception ex)
            {
                Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
                ed.WriteMessage("\n[ERROR] Exception in LoadSmartCopRibbon: " + ex.Message);
            }
        }

        private static void CreateHiddenPanels()
        {
            // Create the "Niveau/Parties" panel using the Niveau/Parties class
            RibbonPanelSource niveauPanelSource = new RibbonPanelSource
            {
                Title = "Niveau/Parties"
            };

            RibbonPanel niveausPanel = new RibbonPanel
            {
                Source = niveauPanelSource
            };
            niveau.CreateInitialPanels(niveauPanelSource, niveausPanel);
            hiddenPanels.Add(niveausPanel);


            // Create the "Dessin" panel using the Dessin class
            RibbonPanelSource dessinPanelSource = new RibbonPanelSource
            {
                Title = "Dessin"
            };

            RibbonPanel dessinPanel = new RibbonPanel
            {
                Source = dessinPanelSource
            };

            // Use the Dessin class to create the panel contents
            Dessin.CreateInitialPanels(dessinPanelSource, dessinPanel);
            hiddenPanels.Add(dessinPanel);


            // Create the "livrables" panel using the livrables class
            RibbonPanelSource livrablesPanelSource = new RibbonPanelSource
            {
                Title = "livrables"
            };

            RibbonPanel livrablesPanel = new RibbonPanel
            {
                Source = livrablesPanelSource
            };

            // Use the livrables class to create the panel contents
           
            Livrables.CreateLivrablesPanel(livrablesPanelSource, livrablesPanel);
            hiddenPanels.Add(livrablesPanel);


            // Create the "livrables" panel using the livrables class
            RibbonPanelSource SmartCopPanelSource = new RibbonPanelSource
            {
                Title = "SmartCop"
            };

            RibbonPanel SmartCopPanel = new RibbonPanel
            {
                Source = SmartCopPanelSource
            };

            // Use the livrables class to create the panel contents

            SmartCop.CreateInitialPanels(SmartCopPanelSource, SmartCopPanel);
            hiddenPanels.Add(SmartCopPanel);




            // Dictionary mapping sections to buttons and their corresponding icon paths
            Dictionary<string, Dictionary<string, string>> sections = new Dictionary<string, Dictionary<string, string>>
            {
                //{ "Niveau/Parties", new Dictionary<string, string>
                //    {
                //        { "Fichiers DWG", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\niveaux.png" },
                //        { "Niveaux", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\niveaux.png" },
                //        { "Privatives/Communes", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Privqtives Communes.png" }
                //    }
                //},
                //{ "Dessin", new Dictionary<string, string>
                //    {
                //        { "Orientation du dessin", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\vérification.png" },
                //        { "Mise à jour du dessin", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\actualiser.png" },
                //    { "Échelle", "" },

                //        { "Habillage", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Habillage.png" },
                //        { "Tableau des contenances", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\tableau.png" },
                //        { "Calques", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Calques.png" }
                //    }
                //},

    // { "Livrables", new Dictionary<string, string>
    //{
    //        { "Ajustement", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\ajustement.png" },
    //        { "Générer", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\generer.png" },
    //        { "P.V", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png" },
    //        { "Tableau A", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png" },
    //        { "Tableau B", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png" },

    //        { "Règlement", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png" },
    //        { "Calcul graphique", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png" },
    //        { "Messages: 18", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\!.png" },
    //    }
    //},


    //{ "SmartCop", new Dictionary<string, string>
    //    {
    //        { "Préférences", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\a-propos-de.png" },
    //        { "À Propos", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\a-propos-de.png" }

    //    }
    //}
};

            foreach (var section in sections)
            {
                RibbonPanelSource panelSource = new RibbonPanelSource { Title = section.Key };
                RibbonPanel panel = new RibbonPanel { Source = panelSource };
                RibbonRowPanel rowPanel = new RibbonRowPanel();

                foreach (var buttonData in section.Value)
                {
                    string buttonText = buttonData.Key;
                    string imagePath = buttonData.Value;

                    if (buttonText == "Échelle")
                    {
                        // Ajouter un label "Échelle" avant le menu déroulant
                        RibbonLabel echelleLabel = new RibbonLabel
                        {
                            Text = "Échelle",
                            ShowText = true
                        };
                        rowPanel.Items.Add(echelleLabel);

                        // Créer le bouton déroulant avec "1/100" comme valeur par défaut
                        RibbonSplitButton echelleDropdown = new RibbonSplitButton
                        {
                            Text = "1/100",  // Texte affiché sur le bouton
                            ShowText = true,
                            Size = RibbonItemSize.Standard
                        };

                        // Ajouter les différentes options d'échelle
                        string[] scales = { "1/50", "1/100", "1/200", "1/500", "1/1000" };
                        foreach (string scale in scales)
                        {
                            RibbonButton option = new RibbonButton
                            {
                                Text = scale,
                                ShowText = true
                            };
                            echelleDropdown.Items.Add(option);
                        }

                        rowPanel.Items.Add(echelleDropdown);
                    }
                    else
                    {
                        RibbonButton sectionButton = new RibbonButton
                        {
                            Text = buttonText,
                            ShowText = true,
                            Size = RibbonItemSize.Large,
                            Orientation = System.Windows.Controls.Orientation.Vertical,
                            Image = !string.IsNullOrEmpty(imagePath) ? ImageManager.LoadAndResizeImage(imagePath, 16, 16) : null,
                            LargeImage = !string.IsNullOrEmpty(imagePath) ? ImageManager.LoadAndResizeImage(imagePath, 32, 32) : null,
                        };

                        rowPanel.Items.Add(sectionButton);
                    }
                }

                panelSource.Items.Add(rowPanel);
                hiddenPanels.Add(panel);  // Stocker les panneaux pour les ajouter plus tard
            }

        }

        private static void CreateInitialPanels(RibbonPanelSource projetPanelSource, RibbonPanel projetPanel)
        {
            Dictionary<string, string[]> sections = new Dictionary<string, string[]>
            {
                { "Project", new string[] { "Nouveau", "Propriétés" } }
            };

            projetPanelSourceRef = projetPanelSource;

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
                        CommandHandler = buttonText != "Propriétés" ? new OpenSelectionFormHandler(hiddenPanels, SmartCopTab, projetPanelSourceRef) : null,
                        IsEnabled = buttonText != "Propriétés"
                    };

                    string imagePath = buttonText != "Propriétés"
                        ? @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\nouveaux.png"
                        : @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\propriete.png";

                    nouveauButton.Image = ImageManager.LoadAndResizeImage(imagePath, 32, 32);
                    nouveauButton.LargeImage = ImageManager.LoadAndResizeImage(imagePath, 32, 32);

                    projetPanelSource.Items.Add(nouveauButton);
                }

               SmartCopTab.Panels.Add(projetPanel);
            }
        }
    }
}