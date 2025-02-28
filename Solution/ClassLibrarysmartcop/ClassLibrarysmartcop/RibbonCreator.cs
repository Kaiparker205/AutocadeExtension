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
using ClassLibrarysmartcop;
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

            //Create "Nouveau and Pr" RibbonButton.
            CreateInitialPanels(projetPanelSource, projetPanel);

            //this**********  SmartCopTab.Panels.Add(projetPanel);
            #endregion


            #region Niveau/Parties
            // Create Projet Panel 
            RibbonPanelSource nvPanelSource = new RibbonPanelSource
            {
                Title = "Niveaux/Parties"
            };
            RibbonPanel nvPanel = new RibbonPanel
            {
                Source = nvPanelSource
            };

            // Create "Niveau" Button
            RibbonButton niveauxButton = new RibbonButton
            {
                Text = "Niveaux",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            niveauxButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\niveaux.png", 16, 16);
            niveauxButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\niveaux.png", 32, 32);



            RibbonButton pcButton = new RibbonButton
            {
                Text = "Privatives/Communes",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,

            };
            pcButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Privqtives Communes.png", 16, 16);
            pcButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Privqtives Communes.png", 64, 64);

            nvPanelSource.Items.Add(niveauxButton);
            nvPanelSource.Items.Add(pcButton);

            SmartCopTab.Panels.Add(nvPanel);
            #endregion

            #region Dessin
            // Create Projet Panel 
            RibbonPanelSource dessinPanelSource = new RibbonPanelSource
            {
                Title = "Dessin"
            };
            RibbonPanel dessinPanel = new RibbonPanel
            {
                Source = dessinPanelSource
            };

            RibbonButton orientationButton = new RibbonButton
            {
                Text = "Orientation du dessin",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            orientationButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\vérification.png", 16, 16);
            orientationButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\vérification.png", 16, 16);


            //  Bouton "Mise à jour du dessin"
            RibbonButton miseAJourButton = new RibbonButton
            {
                Text = "Mise à jour du dessin",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            miseAJourButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\actualiser.png", 16, 16);
            miseAJourButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\actualiser.png", 13, 13);


            // Label "Échelle"
            RibbonLabel echelleLabel = new RibbonLabel
            {
                Text = "Échelle",
                ShowText = true,
                Size = RibbonItemSize.Large,            
            };
           


            // ComboBox "Échelle"
            RibbonSplitButton echelleSplitButton = new RibbonSplitButton
            {
                Text = "Échelle",
                ShowText = true
            }
            ;
            echelleSplitButton.Items.Add(new Autodesk.Windows.RibbonButton { Text = "1/50" });
            echelleSplitButton.Items.Add(new Autodesk.Windows.RibbonButton { Text = "1/100" });
            echelleSplitButton.Items.Add(new Autodesk.Windows.RibbonButton { Text = "1/200" });

        



            //// Create "Nouveau" Button
            RibbonButton HabillageButton = new RibbonButton
            {
                Text = "Habillage",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,

            };
            HabillageButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Habillage.png", 16, 16);
            HabillageButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Habillage.png", 32, 32);


            //Add Button to Projet Panel

            RibbonButton tableauButton = new RibbonButton
            {
                Text = "Tableau des contenances",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            tableauButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\tableau.png", 16, 16);
            tableauButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\tableau.png", 32, 32);


            RibbonButton calquesButton = new RibbonButton
            {
                Text = "Calques",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            calquesButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Calques.png", 16, 16);
            calquesButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Calques.png", 32, 32);

            dessinPanelSource.Items.Add(orientationButton);
            dessinPanelSource.Items.Add(miseAJourButton);
            dessinPanelSource.Items.Add(echelleLabel);
            dessinPanelSource.Items.Add(echelleSplitButton);


            dessinPanelSource.Items.Add(HabillageButton);
            dessinPanelSource.Items.Add(tableauButton);
            dessinPanelSource.Items.Add(calquesButton);
            

            SmartCopTab.Panels.Add(dessinPanel);
            #endregion

            #region Livrable
            //// Create Projet Panel 
            RibbonPanelSource LivrablePanelSource = new RibbonPanelSource
            {
                Title = "Livrable"
            };
            RibbonPanel LivrablePanel = new RibbonPanel
            {
                Source = LivrablePanelSource
            };

            RibbonButton AjustementButton = new RibbonButton
            {
                Text = "Ajustement",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,

            };
            AjustementButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\ajustement.png", 16, 16);
            AjustementButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\ajustement.png", 32, 32);

            RibbonButton genererButton = new RibbonButton
            {
                Text = "Générer",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,

            };
            genererButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\generer.png", 16, 16);
            genererButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\generer.png", 32, 32);
            


            // Bouton "P.V"
            RibbonButton pvButton = new RibbonButton
            {
                Text = "P.V",
                ShowText = true,
                Size = RibbonItemSize.Standard,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            pvButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 16, 16);
            pvButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 32, 32);




            // Bouton "Règlement"
            RibbonButton reglementButton = new RibbonButton
            {
                Text = "Règlement",
                ShowText = true,
                Size = RibbonItemSize.Standard,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            reglementButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 16, 16);
            reglementButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 32, 32);




            // Bouton "Tableau A"
            RibbonButton tableauAButton = new RibbonButton
            {
                Text = "Tableau A",
                ShowText = true,
                Size = RibbonItemSize.Standard,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            tableauAButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 16, 16);
            tableauAButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 32, 32);




            // Bouton "Calcul graphique"
            RibbonButton calculGraphiqueButton = new RibbonButton
            {
                Text = "Calcul graphique",
                ShowText = true,
                Size = RibbonItemSize.Standard,
              Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            calculGraphiqueButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 16, 16);
            calculGraphiqueButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 32, 32);




            // Bouton "Tableau B"
            RibbonButton tableauBButton = new RibbonButton
            {
                Text = "Tableau B",
                ShowText = true,
                Size = RibbonItemSize.Standard,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            pvButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 16, 16);
            pvButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png", 32, 32);




            // Bouton "Messages: 18"
            RibbonButton messagesButton = new RibbonButton
            {
                Text = "Messages: 18",
                ShowText = true,
                Size = RibbonItemSize.Standard,
                Orientation = System.Windows.Controls.Orientation.Vertical,
            };
            messagesButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\!.png", 16, 16);
            messagesButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\!.png", 32, 32);



            LivrablePanelSource.Items.Add(AjustementButton);
            LivrablePanelSource.Items.Add(genererButton);
            LivrablePanelSource.Items.Add(pvButton);
            LivrablePanelSource.Items.Add(tableauAButton);
            LivrablePanelSource.Items.Add(tableauBButton);
            LivrablePanelSource.Items.Add(reglementButton);
            LivrablePanelSource.Items.Add(calculGraphiqueButton);
            LivrablePanelSource.Items.Add(messagesButton);
            SmartCopTab.Panels.Add(LivrablePanel);
            #endregion


            #region SmartCop
            // Create Projet Panel 
            RibbonPanelSource SmartCopPanelSource = new RibbonPanelSource
            {
                Title = "SmartCop"
            };
            RibbonPanel SmartCopPanel = new RibbonPanel
            {
                Source = SmartCopPanelSource
            };

            ////// Create "Nouveau" Button
            RibbonButton PréférencesButton = new RibbonButton
            {
                Text = "Préférences",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,

            };

            RibbonButton proposButton = new RibbonButton
            {
                Text = "A propos",
                ShowText = true,
                Size = RibbonItemSize.Large,
                Orientation = System.Windows.Controls.Orientation.Vertical,

            };
            proposButton.Image = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\a-propos-de.png", 16, 16);
            proposButton.LargeImage = ImageManager.LoadAndResizeImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\a-propos-de.png", 32, 32);

            SmartCopPanelSource.Items.Add(PréférencesButton);
            SmartCopPanelSource.Items.Add(proposButton);
            SmartCopTab.Panels.Add(SmartCopPanel);
            #endregion


            ComponentManager.Ribbon.UpdateLayout();

        }

        private static void CreateInitialPanels(RibbonPanelSource projetPanelSource, RibbonPanel projetPanel)
        {
            //// Initialize the hiddenPanels collection if it doesn't exist
            //if (hiddenPanels == null)
            //    hiddenPanels = new List<RibbonPanel>();

            // Sections and buttons
             Dictionary<string, string[]> sections = new Dictionary<string, string[]>
             {
              { 
                "Project", new string[] { "Nouveau", "Propriétés" }
               
              }
             };
            projetPanelSourceRef = projetPanelSource;
            // Create buttons for each section
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


                    // Set the button's images using the ImageManager helper class
                    string imagePath = buttonText != "Propriétés" ? @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\nouveaux.png" : @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\propriete.png";
                    nouveauButton.Image = ImageManager.LoadAndResizeImage(imagePath, 32, 32);
                    nouveauButton.LargeImage = ImageManager.LoadAndResizeImage(imagePath, 32, 32);

                    // Add the button to the panel
                    projetPanelSource.Items.Add(nouveauButton);
                }
            }

            SmartCopTab.Panels.Add(projetPanel);
        }


        //private static void CreateHiddenPanels()
        //{
        //    // Initialize the hiddenPanels collection if it doesn't exist
        //    //if (hiddenPanels == null)
        //    //    hiddenPanels = new List<RibbonPanel>();

        //    // Sections and buttons
        //    Dictionary<string, string[]> sections = new Dictionary<string, string[]>
        //      {

        //        { "Niveau/Parties", new string[] { "Fichiers DWG", "Niveaux", "Privatives/Communes" } },
        //        { "Dessin", new string[] { "Habillage", "Tableau des contenances", "Calques" } },
        //        { "Livrables", new string[] { "Ajustement", "Générer" } },
        //        { "SmartCop", new string[] { "Préférences", "À Propos" } }
        //      };
        //    //EnableProprietesButton(projetPanelSourceRef);
        //    // Clear existing panels if necessary
        //    //hiddenPanels.Clear();

        //    foreach (var section in sections)
        //    {
        //        RibbonPanelSource panelSource = new RibbonPanelSource
        //        {
        //            Title = section.Key
        //        };

        //        RibbonPanel panel = new RibbonPanel
        //        {
        //            Source = panelSource
        //        };

        //        RibbonRowPanel rowPanel = new RibbonRowPanel();

        //        foreach (var buttonText in section.Value)
        //        {
        //            RibbonButton sectionButton = new RibbonButton
        //            {
        //                Text = buttonText,
        //                ShowText = true,
        //                Size = RibbonItemSize.Large
        //            };

        //            // Add event handlers if needed
        //            // sectionButton.Click += SectionButton_Click;

        //            rowPanel.Items.Add(sectionButton);
        //        }

        //        panelSource.Items.Add(rowPanel);
        //        hiddenPanels.Add(panel);
        //    }
        //}


        
    }
}