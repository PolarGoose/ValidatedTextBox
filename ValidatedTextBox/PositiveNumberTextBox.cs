namespace ValidatedTextBox {
    public sealed class PositiveNumberTextBox : RegexedTextBox<ulong> {
        public PositiveNumberTextBox() : base(@"^\d*$") { }
    }
}