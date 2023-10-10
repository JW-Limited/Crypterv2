using System;

namespace LILO_Packager.v2.Plugins.ThirdParty.Types.Exceptions
{
    /// <summary>
    /// An exception that is thrown when an invalid package is encountered.
    /// </summary>
    public class InvalidPackageException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPackageException"/> class.
        /// </summary>
        public InvalidPackageException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPackageException"/> class with the specified package file.
        /// </summary>
        /// <param name="packageFile">The package file that is invalid.</param>
        public InvalidPackageException(string packageFile)
            : base(GenerateErrorMessage(packageFile))
        {
            PackageFile = packageFile;
        }

        /// <summary>
        /// Gets the package file that is invalid.
        /// </summary>
        public string PackageFile { get; }

        private static string GenerateErrorMessage(string packageFile)
        {
            if (packageFile == null)
            {
                return "Invalid package. " + INSTALLER_CODES.INVALID_PACKAGE;
            }

            return $"\"{packageFile}\"\n\nThis package is invalid, corrupted, or not a LILO Crypterv2 Plugin. 0x{INSTALLER_CODES.INVALID_PACKAGE.ToString("X")}";
        }
    }

    /// <summary>
    /// An exception that is thrown when a required file is missing in the package.
    /// </summary>
    public class MissingFileException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingFileException"/> class.
        /// </summary>
        public MissingFileException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingFileException"/> class with the specified file name.
        /// </summary>
        /// <param name="fileName">The name of the missing file.</param>
        public MissingFileException(string fileName)
            : base($"The required file \"{fileName}\" is missing in the package.")
        {
            FileName = fileName;
        }

        /// <summary>
        /// Gets the name of the missing file.
        /// </summary>
        public string FileName { get; }
    }

    /// <summary>
    /// An exception that is thrown when an XML file is not valid.
    /// </summary>
    public class InvalidXmlException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidXmlException"/> class.
        /// </summary>
        public InvalidXmlException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidXmlException"/> class with the specified message.
        /// </summary>
        /// <param name="message">The error message.</param>
        public InvalidXmlException(string message)
            : base($"Invalid XML format: {message}")
        {
        }
    }
}

