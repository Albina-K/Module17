using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeExample.Components;

namespace CompositeExample
{
    /// <summary>
    /// клиeнтский код
    /// </summary>
    class Client
    {
        public static void Main()
        {
            //создание корневой папки
            Component rootFolder = new Folder("Root");

            //создание файла компонента низшего уровня
            Component myFile = new Components.File("MyFile.txt");

            //создание папки с документами
            Folder documentsFolder = new Folder("MyDocuments");

            //добавляем файл в корневую папки
            rootFolder.Add(myFile);

            //добавляем подпапку для документов в корневую папку
            rootFolder.Add(documentsFolder);

            //показываем контент корневой папки
            rootFolder.Display();
        }
    }
}
