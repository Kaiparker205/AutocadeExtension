using System;
using System.Windows.Media.Imaging;
using Autodesk.Windows;
using ClassLibrarysmartcop.Helpers;
using ClassLibrarysmartcop;

namespace ClassLibrarysmartcop
{
    public static class Livrables
    {
        public static void CreateLivrablesPanel(RibbonPanelSource livrablesPanelSource, RibbonPanel livrablesPanel)
        {
            try
            {
                if (livrablesPanelSource == null)
                    throw new ArgumentNullException(nameof(livrablesPanelSource));
                if (livrablesPanel == null)
                    throw new ArgumentNullException(nameof(livrablesPanel));

                // Clear existing items
                livrablesPanelSource.Items.Clear();

                // Create buttons for each item
                RibbonButton ajustementBtn = CreateButton("Ajustement", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\ajustement.png", true);
                RibbonButton genererBtn = CreateButton("Générer", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\generer.png", true);
                RibbonButton pvBtn = CreateButton("P.V", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png");
                RibbonButton reglementBtn = CreateButton("Règlement", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png");
                RibbonButton tableauABtn = CreateButton("Tableau A", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png");
                RibbonButton calculGraphBtn = CreateButton("Calcul graphique", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png");
                RibbonButton tableauBBtn = CreateButton("Tableau B", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\word.png");
                RibbonButton messagesBtn = CreateButton("Messages: 18", @"C:\Users\hp\source\repos\ClassLibrarysmartcop\ClassLibrarysmartcop\img\!.png");

                // Build a SINGLE RibbonRowPanel with row breaks in between
                var rightNestedPanel = new RibbonRowPanel
                {
                    IsTopJustified = true
                };

                // Row 1: Ajustement, Générer
                //combinedPanel.Items.Add(ajustementBtn);
                //combinedPanel.Items.Add(genererBtn);
                //combinedPanel.Items.Add(RibbonPanelHelper.CreateRowBreak());
                // Create left nested panel that adds a row break after the provided items
                var leftNestedPanel = RibbonPanelHelper.CreateLeftNestedPanel(false, ajustementBtn, genererBtn);
                leftNestedPanel.IsTopJustified = false;
                // Row 2: P.V, Règlement
                rightNestedPanel.Items.Add(reglementBtn);
                rightNestedPanel.Items.Add(pvBtn);

                rightNestedPanel.Items.Add(RibbonPanelHelper.CreateRowBreak());

                // Row 3: Tableau A, Calcul graphique
                rightNestedPanel.Items.Add(tableauABtn);
                rightNestedPanel.Items.Add(calculGraphBtn);
                rightNestedPanel.Items.Add(RibbonPanelHelper.CreateRowBreak());

                // Row 4: Tableau B, Messages: 18
                rightNestedPanel.Items.Add(tableauBBtn);
                rightNestedPanel.Items.Add(messagesBtn);


                // Combine the left and right nested panels into one parent panel
                var combinedPanel = RibbonPanelHelper.CreateCombinedPanel(leftNestedPanel, rightNestedPanel);
                combinedPanel.Width = 450;
                livrablesPanelSource.Items.Add(combinedPanel);
                livrablesPanel.Source = livrablesPanelSource;
            }
            catch (Exception ex)
            {
                ShowError("Error in CreateLivrablesPanel", ex);
            }
        }

        /// <summary>
        /// Creates a large button with text and images.
        /// </summary>
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
                //Width = 300,
                Image = SafeLoadImage(imagePath, 12, 12),
                LargeImage = SafeLoadImage(imagePath, 16, 16),

            };
        }

        /// <summary>
        /// Helper method to show error messages.
        /// </summary>
        private static void ShowError(string context, Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(
                $"{context}: {ex.Message}\n\nStack Trace: {ex.StackTrace}",
                "Error",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
        }

        /// <summary>
        /// Loads an image from disk and resizes it safely.
        /// Implement your custom resizing logic inside ImageManager if needed.
        /// </summary>
        private static BitmapSource SafeLoadImage(string path, int width, int height)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    // Replace with your own method to load and resize the image
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