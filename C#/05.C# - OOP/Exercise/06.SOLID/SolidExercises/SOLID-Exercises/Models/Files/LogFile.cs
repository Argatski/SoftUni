using SOLID_Exercises.Models.Contracts;
using SOLID_Exercises.Models.IOManagment;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace SOLID_Exercises.Models.Files
{
    public class LogFile : IFile
    {
        private const string DataFormat = "M/dd/yyyy h:mm:ss tt";

        private const string CurrentDirectory = "\\logs\\";
        private const string CurrentFile = "log.txt";

        private readonly string currentPath;
        private readonly IIOManager IOManager;

        public LogFile()
        {
            this.IOManager = new IOManager(CurrentDirectory, CurrentFile);
            this.currentPath = this.IOManager.GetCurrentPath();
            this.IOManager.EnsureDirectoryAndFileExist();
            this.Path = this.currentPath + CurrentDirectory + CurrentFile;

        }

        public string Path { get; }

        public ulong Size => this.GetFileSize();

        private ulong GetFileSize()
        {
            var text = File.ReadAllText(this.Path);

            var size = (ulong)text
                .ToCharArray()
                .Where(c => char.IsLetter(c))
                .Sum(c => c);

            return size;
        }

        public string Write(ILayout layout, IError error)
        {
            var format = layout.Format;

            var dateTime = error.DateTime;
            var messsage = error.Message;
            var level = error.Level;

            return string.Format(format, dateTime.ToString(DataFormat, CultureInfo.InvariantCulture), level.ToString(), messsage);
        }

        
    }
}
