using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LILO_Packager.v2.Shared.FileOperations.FileDialogFilter;

namespace LILO_Packager.v2.Shared;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public partial class FileOperations
{
    public string GetFileFromDialog()
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.CheckFileExists = true;
        ofd.AutoUpgradeEnabled = true;
        ofd.ShowHiddenFiles = true;
        ofd.CheckPathExists = true;
        ofd.SupportMultiDottedExtensions = true;
        ofd.Multiselect = false;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            return ofd.FileName;
        }

        else { return null; }
    }

    public string[] GetFilesFromDialog()
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.CheckFileExists = true;
        ofd.AutoUpgradeEnabled = true;
        ofd.ShowHiddenFiles = true;
        ofd.CheckPathExists = true;
        ofd.SupportMultiDottedExtensions = true;
        ofd.Multiselect = true;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            return ofd.FileNames;
        }

        else { return null; }
    }

    public string[] GetFilesFromDialogFilter(FilterType type)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.CheckFileExists = true;
        ofd.AutoUpgradeEnabled = true;
        ofd.ShowHiddenFiles = true;
        ofd.CheckPathExists = true;
        ofd.Filter = FileDialogFilter.GetFilter(type);
        ofd.SupportMultiDottedExtensions = true;
        ofd.Multiselect = true;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            return ofd.FileNames;
        }

        else { return null; }
    }

    public string GetDebuggerDisplay()
    {
        return ToString();
    }
}
