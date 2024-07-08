using System.Data.Common;

namespace AdapterExample
{
    //наш код, где необходимо использование класса-источника
    class Client
    {
        public void Request(DataSource dataSource)
        {
            dataSource.GetData();
        }

        ///<summary>
        ///класс - источник ресурса, к которому нужно подключиться
        /// </summary>
        class DataSource
        {
            public virtual void GetData()
            {

            }
        }
        
        ///<summary>
        ///класс потребитель ресурса
        /// </summary>
        class DataConsumer
        {
            public void GetSpecificData()
            {

            }
        }

        ///<summary>
        ///адаптер для подлючения
        /// </summary>
        class Adapter : DataSource
        {
            private DataConsumer _dataConsumer = new DataConsumer();

            //метод для подключения ресурса
            public override void GetData()
            {
                _dataConsumer.GetSpecificData();
            }
        }
    }
}
