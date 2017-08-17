/*
●	получение объема памяти;
●	копирование данных (файлов/папок) на устройство,
●	получение информации о свободном объеме памяти на устройстве;
●	получение общей/полной информации об устройстве.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
  public abstract class Storage
    {
        private string nameOfCarrier;
        private string model;
        private double memory;
        private double fileOrDirectory;
        private DateTime timeOfCopy;
        public double Memory
        {
            get{ return memory; }
            set{ memory = value; } 
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        abstract public void CopyToDVD();
        abstract public void CopyToHDD();
        abstract public void CopyToFlesh();
        abstract public void FreeSpace();
        abstract public void infOfDevice();
    }
}
