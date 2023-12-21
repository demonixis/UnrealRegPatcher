using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace UnrealRegPatcher
{
    public partial class Form1 : Form
    {
        private const string DefaultUnrealTargetName = "5.x_Vendor";
        private string UnrealTargetPath;

        public string GetTargetName()
        {
            if (string.IsNullOrEmpty(txTargetName.Text))
                return DefaultUnrealTargetName;

            return txTargetName.Text;
        }

        public Form1()
        {
            InitializeComponent();
            txTargetName.Text = DefaultUnrealTargetName;
        }

        private void OnButtonInstallClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UnrealTargetPath))
            {
                LogError("The Unreal Path is NOT valid. Abording");
                return;
            }

            var subKey = Registry.CurrentUser.CreateSubKey(@"Software\Epic Games\Unreal Engine\Builds", true);
            if (subKey != null)
            {
                subKey.SetValue(GetTargetName(), UnrealTargetPath);
                subKey.Close();
                LogSuccess("Unreal custom installation completed!");
            }
            else
            {
                LogError("Was not able to install the custom version");
            }
        }

        private void OnButtonUninstallClicked(object sender, EventArgs e)
        {
            var subKey = Registry.CurrentUser.OpenSubKey(@"Software\Epic Games\Unreal Engine\Builds", true);
            if (subKey != null)
            {
                subKey.DeleteValue(GetTargetName());
                subKey.Close();
                LogSuccess("Unreal custom installation was uninstalled!");
            }
            else
            {
                LogError("Was not able to uninstall the custom version. Probably because it wasn't installed.");
            }
        }

        private void OnChooseClicked(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    UnrealTargetPath = fbd.SelectedPath;
                    UEPathText.Text = fbd.SelectedPath;
                }
                else
                    LogError("The path is not valid");
            }
        }

        private static void LogSuccess(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void LogError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
