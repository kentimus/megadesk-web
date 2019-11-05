using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskWebWeek8.Models
{
    public class DeskQuote
    {
        private const int MINWIDTH = 24;
        private const int MAXWIDTH = 96;
        private const int MINDEPTH = 12;
        private const int MAXDEPTH = 48;

        public int ID { get; set; }

        [Required]
        [Range(MINWIDTH, MAXWIDTH)]
        public int Width { get; set; }

        [Required]
        [Range(MINDEPTH, MAXDEPTH)]
        public int Depth { get; set; }

        [Display(Name = "Number of Drawers")]
        [Required]
        [Range(0, 7)]
        public int NumDrawers { get; set; }

        [Display(Name = "Surface Material")]
        [Required]
        public string SurfaceMaterial { get; set; }

        [Display(Name = "Customer Name")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string CustomerName { get; set; }

        [Display(Name = "Shipping")]
        [Required]
        public int rushDays { get; set; }

        [Display(Name = "Price")]
        public int price { get; set; }

        [Display(Name = "Order Date")]
        public string orderDate { get; set; }

        



        public int GetPrice()
        {
            int BasePrice = 200;
            int Area = Width * Depth;
            int SurfaceAreaPrice = GetSurfaceAreaPrice(Area);
            int DrawerPrice = GetDrawerPrice(NumDrawers);
            int MaterialPrice = GetMaterialPrice(SurfaceMaterial);
            int RushPrice = GetRushPrice(rushDays, Area);

            return BasePrice + SurfaceAreaPrice + DrawerPrice + MaterialPrice + RushPrice;
        }

        private int GetSurfaceAreaPrice(int surfaceArea)
        {
            if (surfaceArea > 1000)
            {
                return surfaceArea - 1000;
            }
            else
            {
                return 0;
            }
        }

        private int GetDrawerPrice(int numDrawers)
        {
            return numDrawers * 50;
        }

        private int GetMaterialPrice(string material)
        {
            switch (material)
            {
                case "Oak":
                    return 200;
                case "Laminate":
                    return 100;
                case "Pine":
                    return 50;
                case "Rosewood":
                    return 300;
                case "Veneer":
                    return 125;
                default:
                    return 50;
            }
        }

        private int GetRushPrice(int days, int surfaceArea)
        {
            switch (days)
            {
                case 3:
                    if (surfaceArea < 1000) { return 60; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000) { return 70; }
                    else { return 80; } // surfaceArea > 2000
                case 5:
                    if (surfaceArea < 1000) { return 40; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000) { return 50; }
                    else { return 60; }
                case 7:
                    if (surfaceArea < 1000) { return 30; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000) { return 35; }
                    else { return 40; }
                default:
                    return 0;
            }
        }
    }
}
