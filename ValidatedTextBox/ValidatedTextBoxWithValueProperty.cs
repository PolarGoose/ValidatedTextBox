using System;

namespace ValidatedTextBox {
    public abstract class ValidatedTextBoxWithValueProperty<T> : ValidatedTextBox where T : IConvertible {
        public T Value => (T) Convert.ChangeType(Text, typeof(T));
    }
}