using System.Globalization;

namespace ValidatedTextBox {
    public sealed class PositiveFloatingPointNumberTextBox : RegexedTextBox<double> {
        public PositiveFloatingPointNumberTextBox()
            : base(@"^(\d+\" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + @")?\d*$") { }
    }
}