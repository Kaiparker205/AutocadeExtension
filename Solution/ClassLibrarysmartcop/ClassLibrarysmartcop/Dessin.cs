using Autodesk.Windows;
using ClassLibrarysmartcop.Helpers;
using ClassLibrarysmartcop;
using System;
using System.Windows.Media.Imaging;
using Autodesk.AutoCAD.GraphicsInterface;

namespace ClassLibrarysmartcop
{
    static class Dessin
    {
        public static void CreateInitialPanels(RibbonPanelSource projetPanelSource, RibbonPanel projetPanel)
        {
            try
            {
                if (projetPanelSource == null)
                    throw new ArgumentNullException(nameof(projetPanelSource));
                if (projetPanel == null)
                    throw new ArgumentNullException(nameof(projetPanel));

                projetPanelSource.Items.Clear();

                // --- Left Nested Panel: "Orientation du dessin" and "Mise à jour" ---
                RibbonButton orientationBtn = new RibbonButton
                {
                    Text = "Orientation du dessin",
                    ShowText = true,
                    Size = RibbonItemSize.Large,
                    Image = SafeLoadImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\vérification.png", 10, 10),
                    LargeImage = SafeLoadImage(@"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\vérification.png", 14, 14)
                };

                RibbonButton majBtn = CreateButton("Mise à jour du dessin", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\actualiser.png");

                // Create left nested panel that adds a row break after the provided items
                var leftNestedPanel = RibbonPanelHelper.CreateLeftNestedPanel(true, orientationBtn, majBtn);
                leftNestedPanel.IsTopJustified = false;

                RibbonLabel echelleLabel = new RibbonLabel { Text = "Échelle", ShowText = true };
                RibbonSplitButton echelleDropdown = CreateScaleDropdown(new[] { "1/50                           ", "1/100                           ", "1/200                           ", "1/500                           ", "1/1000                           " });
                //projetPanelSource.Items.Add(RibbonPanelHelper.CreateRowPanel(echelleLabel, echelleDropdown));
                leftNestedPanel.Items.Add(echelleLabel);
                leftNestedPanel.Items.Add(echelleDropdown);
                

                // --- Right Nested Panel: Multiple buttons ---
                RibbonButton habillageBtn = CreateButton("Habillage", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Habillage.png",true);
                RibbonButton tableauBtn = CreateButton("Tableau des contenances", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\tableau.png", true);
                RibbonButton calquesBtn = CreateButton("Calques", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\Calques.png", true);

                // Create right nested panel without adding a row break
                var rightNestedPanel = RibbonPanelHelper.CreateRightNestedPanel(false, habillageBtn, tableauBtn, calquesBtn);
                rightNestedPanel.IsTopJustified = false;

                // Combine the left and right nested panels into one parent panel
                var combinedPanel = RibbonPanelHelper.CreateCombinedPanel(leftNestedPanel, rightNestedPanel);
                combinedPanel.IsTopJustified = false;
                projetPanelSource.Items.Add(combinedPanel);
                projetPanelSource.Items.Add(RibbonPanelHelper.CreateRowBreak());


                // --- Additional Panel: Scale dropdown ---
               

                projetPanel.Source = projetPanelSource;
            }
            catch (Exception ex)
            {
                ShowError("Error in CreateInitialPanels", ex);
            }
        }

        // Example helper method to create a button
        private static RibbonButton CreateButton(string text, string imagePath, bool vertical = false)
        {
            if (vertical)
            {
                return new RibbonButton
                {
                    Text = text,
                    ShowText = true,
                    Orientation = System.Windows.Controls.Orientation.Vertical,
                    Width = 80,
                    Size = RibbonItemSize.Large,
                    Image = SafeLoadImage(imagePath, 16, 16),
                    LargeImage = SafeLoadImage(imagePath, 32, 32)
                };
            }
            return new RibbonButton
            {
                Text = text,
                ShowText = true,
                Size = RibbonItemSize.Large,
                Image = SafeLoadImage(imagePath, 12, 12),
                LargeImage = SafeLoadImage(imagePath, 16, 16),
            };
            }

        // Example helper method to create a scale dropdown
        private static RibbonSplitButton CreateScaleDropdown(string[] scales)
        {
            RibbonSplitButton dropdown = new RibbonSplitButton
            {
                Text = "1/100",
                ShowText = true,
                Size = RibbonItemSize.Standard
            };

            foreach (var scale in scales)
            {
                dropdown.Items.Add(new RibbonButton { Text = scale });
            }

            return dropdown;
        }

        // Display error messages
        private static void ShowError(string context, Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(
                $"{context}: {ex.Message}\n\nStack Trace: {ex.StackTrace}",
                "Error",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
        }

        // Helper method to safely load images with null checks
        private static BitmapSource SafeLoadImage(string path, int width, int height)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    // Implement your image loading and resizing logic here
                    return ImageManager.LoadAndResizeImage(path, width, height);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show($"Image not found: {path}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error loading image: {ex.Message}");
                return null;
            }
        }
    }
}