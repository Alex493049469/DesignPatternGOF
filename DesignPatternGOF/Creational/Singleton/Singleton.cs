using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternGOF.DesignPattern
{
   //Для отложенной инициализации Singleton'а в C# рекомендуется использовать конструкторы типов (статический конструктор). 
   //CLR автоматически вызывает конструктор типа при первом обращении к типу, 
   //при этом обеспечивая безопасность в отношении синхронизации потоков. 
   //Конструктор типа автоматически генерируется компилятором и в нем происходит инициализация всех полей типа (статических полей). 
   //Явно задавать конструктор типа не следует, так как в этом случае он будет вызываться непосредственно перед обращением к типу 
   //и JIT-компилятор не сможет применить оптимизацию (например, если первое обращение к Singleton'у происходит в цикле).

   // generic Singleton<T> (потокобезопасный с использованием generic-класса и с отложенной инициализацией)

    // <typeparam name="T">Singleton class</typeparam>
    public class Singleton<T> where T : class
    {
        /// Защищённый конструктор необходим для того, чтобы предотвратить создание экземпляра класса Singleton. 
        /// Он будет вызван из закрытого конструктора наследственного класса.
        protected Singleton() { }

        /// Фабрика используется для отложенной инициализации экземпляра класса
        private sealed class SingletonCreator<S> where S : class
        {
            //Используется Reflection для создания экземпляра класса без публичного конструктора
            private static readonly S instance = (S)typeof(S).GetConstructor(
                        BindingFlags.Instance | BindingFlags.NonPublic,
                        null,
                        new Type[0],
                        new ParameterModifier[0]).Invoke(null);

            public static S CreatorInstance
            {
                get { return instance; }
            }
        }

        public static T Instance
        {
            get { return SingletonCreator<T>.CreatorInstance; }
        }

    }

    /// Использование Singleton
    public class TestClass : Singleton<TestClass>
    {
        /// Вызовет защищенный конструктор класса Singleton
        private TestClass() { }

        public string TestProc()
        {
            return "Hello World";
        }
    }

    //Также можно использовать стандартный вариант потокобезопасной реализации Singleton с отложенной инициализацией
    public class Singleton1
    {
        /// Защищенный конструктор нужен, чтобы предотвратить создание экземпляра класса Singleton
        protected Singleton1() { }

        private sealed class SingletonCreator
        {
            private static readonly Singleton1 instance = new Singleton1();
            public static Singleton1 Instance { get { return instance; } }
        }

        public static Singleton1 Instance
        {
            get { return SingletonCreator.Instance; }
        }

    }

    //Если нет необходимости в каких-либо публичных статических методах или свойствах (кроме свойства Instance), то можно использовать упрощенный вариант
    public class Singleton2
    {
        private static readonly Singleton2 instance = new Singleton2();

        public static Singleton2 Instance
        {
            get { return instance; }
        }

        /// Защищенный конструктор нужен, чтобы предотвратить создание экземпляра класса Singleton
        protected Singleton2() { }
    }

    //Пример с ленивой инициализацией
    
        public class Singleton3
        {
            private static Singleton3 instance;
            public static Singleton3 Instance
            {
                get { return instance ?? (instance = new Singleton3()); }
            }
            protected Singleton3() { }
        }
    
}
