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