﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BLL
{
    class Filehandler
    {
        #region Paramators
        private string filepath;
        private FileStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public Filehandler(string filepathP = " Problem.txt")
        {
            this.filepath = filepathP;
        }
        #endregion

        #region WriteMethods

        public void writeToText(List<string> datalist)
        {

        }


        #endregion

        #region ReadMethod
public List<string> ReadFromText()
{

}
        #endregion


    }
}
