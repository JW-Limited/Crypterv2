using LILO_Packager.v2.Core.BugBarrier.Types;
using LILO_Packager.v2.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.BugBarrier
{
    public static partial class ErrorCatcher
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
        private static void HandleException(Exception ex)
        {
            LogException(ex);
            ErrorRank rank = GetErrorRank(ex);
            CustomError customError = new CustomError(rank, ex, DateTime.Now, "An error occurred.");
            errorList.Add(customError);
            MainHost.Instance().OpenInApp(new Forms.uiErrorHandle(customError));
        }

        private static void LogException(Exception ex)
        {
            ConsoleManager.Instance().WriteLineWithColor("Unhandled Exception:\n\n" + ex.ToString(), ConsoleColor.DarkRed);
        }
    }
}
