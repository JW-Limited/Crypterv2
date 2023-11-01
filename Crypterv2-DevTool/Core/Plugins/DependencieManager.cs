using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypterv2.DevTool.Core.Plugins
{
    public unsafe class DependencyManager
    {
        //public static IEnumerable<string> DetectDependencies(string dllPath)
        //{

        //    PEHeader peHeader = DllExports.GetPEHeader(dllPath);


        //    IMAGE_SECTION_HEADER importSectionHeader = GetImportSectionHeader(peHeader);

        //    if (importSectionHeader.Equals(null))
        //    {
        //        yield return string.Empty;
        //    }

        //    // Get the import table of the DLL library.
        //    var importTablePtr = GetImportTable(importSectionHeader);

        //    // Iterate over the import table to get the names of the DLL libraries that the DLL library imports from.
        //    foreach (IMAGE_IMPORT_DESCRIPTOR importEntry in importTablePtr)
        //    {
        //        string dependencyName = DllExports.GetImportDllName(importEntry);

        //        // Add the dependency name to the list of dependencies.
        //        yield return dependencyName;
        //    }
        //}


        //public static unsafe IMAGE_IMPORT_DESCRIPTOR* GetImportTable(IMAGE_SECTION_HEADER importSectionHeader)
        //{
        //    // Get the pointer to the import table.
        //    IntPtr importTablePtr = (nint)importSectionHeader.VirtualAddress;

        //    // Return the pointer to the import table.
        //    return (IMAGE_IMPORT_DESCRIPTOR*)importTablePtr.ToPointer();
        //}


        //public static IMAGE_SECTION_HEADER GetImportSectionHeader(PEHeader peHeader)
        //{
        //    // Iterate over the section headers of the DLL library.
        //    foreach (IMAGE_SECTION_HEADER sectionHeader in peHeader.CorHeaderTableDirectory)
        //    {
        //        // If the section name is ".idata", then this is the import section.
        //        if (sectionHeader.Name.Equals(".idata"))
        //        {
        //            return sectionHeader;
        //        }
        //    }

        //    // If we reach here, then the DLL library does not have an import section.
        //    return new IMAGE_SECTION_HEADER();
        //}


    }

}
