using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Windows;

namespace ClassLibrarysmartcop.Helpers
{
    public static class RibbonPanelHelper
    {
        /// <summary>
        /// Creates a nested panel with specified items and optionally inserts a row break at the end.
        /// </summary>
        /// <param name="addRowBreak">If set to true, a row break will be added to the panel.</param>
        /// <param name="items">The RibbonItems to add to the panel.</param>
        /// <returns>A configured RibbonRowPanel.</returns>
        public static RibbonRowPanel CreateNestedPanel(bool addRowBreak, params RibbonItem[] items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            RibbonRowPanel panel = new RibbonRowPanel
            {
                IsTopJustified = true,

            };

            foreach (var item in items)
            {
                if (item != null)
                {
                    panel.Items.Add(item);
                    if (addRowBreak)
                    {
                        panel.Items.Add(CreateRowBreak());
                    }
                }
            }

            return panel;
        }

        /// <summary>
        /// Creates a left nested panel with a row break.
        /// </summary>
        /// <param name="items">The RibbonItems for the left group.</param>
        /// <returns>A RibbonRowPanel configured for the left group.</returns>
        public static RibbonRowPanel CreateLeftNestedPanel(bool isBreak = false, params RibbonItem[] items)
        {
            return CreateNestedPanel(isBreak, items);
        }

        /// <summary>
        /// Creates a right nested panel without an additional row break.
        /// </summary>
        /// <param name="items">The RibbonItems for the right group.</param>
        /// <returns>A RibbonRowPanel configured for the right group.</returns>
        public static RibbonRowPanel CreateRightNestedPanel(bool isBreak = false, params RibbonItem[] items)
        {
            return CreateNestedPanel(isBreak, items);
        }

        /// <summary>
        /// (Optional) Combines a left and right nested panel into one parent panel.
        /// </summary>
        /// <param name="leftPanel">The left nested panel.</param>
        /// <param name="rightPanel">The right nested panel.</param>
        /// <returns>A combined RibbonRowPanel containing both nested panels.</returns>
        public static RibbonRowPanel CreateCombinedPanel(RibbonRowPanel leftPanel, RibbonRowPanel rightPanel)
        {
            if (leftPanel == null)
                throw new ArgumentNullException(nameof(leftPanel));
            if (rightPanel == null)
                throw new ArgumentNullException(nameof(rightPanel));

            RibbonRowPanel combinedPanel = new RibbonRowPanel
            {
                IsTopJustified = true
            };

            combinedPanel.Items.Add(leftPanel);
            combinedPanel.Items.Add(rightPanel);

            return combinedPanel;
        }

        /// <summary>
        /// Creates a RibbonRowPanel with specified items.
        /// </summary>
        /// <param name="items">The items to add to the panel.</param>
        /// <returns>A configured RibbonRowPanel.</returns>
        public static RibbonRowPanel CreateRowPanel(params RibbonItem[] items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            RibbonRowPanel panel = new RibbonRowPanel
            {
                IsTopJustified = true
            };

            foreach (var item in items)
            {
                if (item != null)
                    panel.Items.Add(item);
            }

            return panel;
        }

        /// <summary>
        /// Creates a RibbonRowBreak to separate rows in a panel.
        /// </summary>
        /// <returns>A new RibbonRowBreak instance.</returns>
        public static RibbonRowBreak CreateRowBreak()
        {
            return new RibbonRowBreak();
        }
    }
}

