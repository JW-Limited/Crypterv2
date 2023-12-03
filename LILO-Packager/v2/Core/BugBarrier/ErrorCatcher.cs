using LILO_Packager.v2.Core.BugBarrier.Dump;
using LILO_Packager.v2.Core.BugBarrier.Types;
using LILO_Packager.v2.Shared;
using System.Diagnostics;

namespace LILO_Packager.v2.Core.BugBarrier
{
    public static partial class BugBarrier
    {
        public static List<ICustomError> errorList = new List<ICustomError>();
        private static ErrorRank GetErrorRank(Exception ex)
        {
            string[] highImpactKeywords = { "critical", "dangerous", "severe" };
            bool hasHighImpactKeywords = highImpactKeywords.Any(keyword => ex.Message.Contains(keyword, StringComparison.OrdinalIgnoreCase));

            if (hasHighImpactKeywords)
            {
                return ErrorRank.High;
            }
            if (IsHighImpactExceptionType(ex.GetType()))
            {
                return ErrorRank.High;
            }

            if (ex.InnerException != null)
            {
                return ErrorRank.Medium;
            }

            return ErrorRank.Low;
        }

        public static void Initialize()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            HandleException(ex);
        }

        private static bool IsHighImpactExceptionType(Type exceptionType)
        {
            Type[] highImpactExceptionTypes = { typeof(StackOverflowException), typeof(OutOfMemoryException) };
            return highImpactExceptionTypes.Contains(exceptionType);
        }
        public static async void HandleException(Exception ex)
        {
            LogException(ex);


            // Unstabel in the Moment - default [FALSE]

            if (FeatureManager.IsFeatureEnabled(FeatureFlags.BugBarrierMiniDumpService))
            {
                try
                {
                    _ = Task.Run(() =>
                    {
                        try
                        {

                            var dumpFileName = $"CrashDump-{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}.dmp";
                            var dumpFilePath = Path.Combine(new FileInfo(Application.ExecutablePath).Directory.ToString() + "\\crash_dumps\\", dumpFileName);
                            Directory.CreateDirectory(new FileInfo(Application.ExecutablePath).Directory.ToString() + "\\crash_dumps");

                            ConsoleManager.Instance().WriteLineWithColor(dumpFilePath);

                            MiniDump.WriteDump(Process.GetCurrentProcess().Id, dumpFilePath, MiniDumpType.Normal);
                        }
                        catch (Exception ex1)
                        {
                            ConsoleManager.Instance().WriteLineWithColor(ex1.Message);
                        }
                    });
                }
                catch (Exception ex1)
                {
                    ConsoleManager.Instance().WriteLineWithColor(ex1.Message);
                    MessageBox.Show(ex1.Message, "Dumping Error");
                }
            }

            

            ErrorRank rank = GetErrorRank(ex);
            CustomError customError = new CustomError(rank, ex, DateTime.Now, "An error occurred.");
            errorList.Add(customError);

            MainHost.Instance().OpenInApp(new Forms.uiErrorHandle(customError));

        }


        private static void LogException(Exception ex)
        {
            ConsoleManager.Instance().WriteLineWithColor("[BUG BARRIER (SHELL)] Unhandled Exception:\n\n" + ex.ToString(), ConsoleColor.DarkRed);
        }
    }
}
