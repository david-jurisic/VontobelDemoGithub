using RAF3kAPItesting;
using RAF3kShared;
using RAF3kShared.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VontobelDemo.HelperMethods
{
    public class CommonMethods : ControlObject
    {
        public CommonMethods() : base()
        {
            sPath = "Raf3kTestProject.HelperMethods";
            sAlias = ".CommonMethods";
        }

        /// <summary>
        /// Verify folder on specific path exists / not exists
        /// </summary>
        /// <param name="sPath">Path to the folder</param>
        /// <param name="bExists">True by default, if set to false checks that folder does not exist</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Success VerifyFolderExists(string sPath, bool bExists = true)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                if (string.IsNullOrEmpty(sPath))
                {
                    throw new Exception("Folder path can not be empty.");
                }

                if (Directory.Exists(sPath) != bExists)
                {
                    if (bExists)
                    {
                        throw new Exception(String.Format("Folder {0} does not exist.", sPath));
                    }
                    else
                    {
                        throw new Exception(String.Format("Folder {0} exists but not existing folder is expected.", sPath));
                    }
                }

            }, this);
        }

        /// <summary>
        /// Verify file on specific path exists / not exists
        /// </summary>
        /// <param name="sPath">Path to the file</param>
        /// <param name="bExists">True by default, if set to false checks that file does not exist</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>        
        public Success VerifyFileExists(string sPath, bool bExists = true)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                if (string.IsNullOrEmpty(sPath))
                {
                    throw new Exception("File path can not be empty.");
                }

                if (File.Exists(sPath) != bExists)
                {
                    if (bExists)
                    {
                        throw new Exception(String.Format("File {0} does not exist.", sPath));
                    }
                    else
                    {
                        throw new Exception(String.Format("File {0} exists but not existing path is expected.", sPath));
                    }
                }

            }, this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iSeconds">enter miliseconds</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Success Wait(int iSeconds)
        {
            return APIReferences.Eval.Evaluate(() =>
            {

                Thread.Sleep(iSeconds * 1000);

            }, this);
        }

        /// <summary>
        /// Method logs exception in log file.
        /// </summary>
        /// <param name="sMessage">Exception message to be logged.</param>
        /// <returns>Success</returns>
        /// <exception cref="Exception"></exception>
        public Success LogException(string sMessage)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                throw new Exception(sMessage);

            }, this);
        }

        /// <summary>
        /// Method verifies text is equal.
        /// </summary>
        /// <param name="sExpectedText"></param>
        /// <param name="sActualText"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Success VerifyText(string sExpectedText, string sActualText)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                if (!sExpectedText.Equals(sActualText))
                    throw new Exception(String.Format("Text is not verified. Expected text: {0} , actual text {1}.", sExpectedText, sActualText));

            }, this);
        }

        /// <summary>
        /// Method verifies that actual text contains expected text.
        /// </summary>
        /// <param name="sExpectedText"></param>
        /// <param name="sActualText"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Success VerifyTextContains(string sExpectedText, string sActualText, bool bContains = true)
        {
            return APIReferences.Eval.Evaluate(() =>
            {
                if (!sActualText.Contains(sExpectedText) && bContains)
                    throw new Exception(String.Format("Actual text: {0} does not contain expected text: {1}.", sActualText, sExpectedText));

                else if (sActualText.Contains(sExpectedText) && !bContains)
                    throw new Exception(String.Format("Actual text: {0} contains expected text: {1}.", sActualText, sExpectedText));
            }, this);
        }
    }
}
