using System;
using System.Windows.Forms;

namespace Example {
    public partial class ExampleForm : Form {
        public ExampleForm() {
            InitializeComponent();
        }

        private void readPositiveNumberButton_Click(object sender, System.EventArgs e) {
            ShowMessageBox(() => positiveNumberTextBox.Value);
        }

        private void readPositiveFloatingNumberButton_Click(object sender, EventArgs e) {
            ShowMessageBox(() => positiveFloatingPointNumberTextBox.Value);
        }

        private static void ShowMessageBox<T>(Func<T> getValue) where T : IConvertible {
            try {
                MessageBox.Show(
                    $@"Value = {getValue()}",
                    @"Read is successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            } catch (Exception ex) {
                MessageBox.Show(
                    $@"Exception of type '{ex.GetType()}' is thrown; message: '{ex.Message}'",
                    @"Read was unsuccessful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}