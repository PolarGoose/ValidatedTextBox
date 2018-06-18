using System;
using System.Text.RegularExpressions;

namespace ValidatedTextBox {
    public abstract class RegexedTextBox<T> : ValidatedTextBoxWithValueProperty<T> where T : IConvertible {
        private readonly Regex m_regex;

        protected RegexedTextBox(string regExpString) {
            m_regex = new Regex(regExpString);
        }

        protected override bool IsValid(string text) {
            return m_regex.IsMatch(Text);
        }
    }
}