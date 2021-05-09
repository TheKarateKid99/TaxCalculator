using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Domain.Constants
{
    public static class ProgressiveTaxLevelConstants
    {
        public const double Level1Limits = 8350;
        public const double Level2Limits = 33950;
        public const double Level3Limits = 82250;
        public const double Level4Limits = 171550;
        public const double Level5Limits = 372950;

    }

    public static class ProgressiveTaxLevelPercentage
    {
        public const double Level1 = 0.1;
        public const double Level2 = 0.15;
        public const double Level3 = 0.25;
        public const double Level4 = 0.28;
        public const double Level5 = 0.33;
        public const double Level6 = 0.35;
    }

}
