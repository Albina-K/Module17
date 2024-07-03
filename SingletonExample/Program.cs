using System;

namespace SingletonExample
{ //Вот пример классической реализации Синглтона: 
    class Singleton
    {
        // статистическая переменная - ссылка на конкретный экземпляр объекта
        private static Singleton Instance;

        // приватный конструктор
        private Singleton() 
        {
        
        }

        // здесь конструктор вызыввется для создания объекта, если он отсутствует или равен null
        public static Singleton GetInstance()
        { 
            if (Instance == null)
                Instance = new Singleton();
            return Instance; 
        }
    }
}
