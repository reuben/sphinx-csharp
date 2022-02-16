namespace OtherNamespace
{
    public class NullableClass
    {
        /// <summary>
        /// Constructor of the class.
        /// </summary>
        public ExampleClass()
        {
        }

        /// <summary>
        /// A nullable bool value.
        /// </summary>
        public bool? BNullableBool { get; set; }

        /// <summary>
        /// A nullable type value.
        /// </summary>
        public Bar? NNullableInt { get; set; }

        /// <summary>
        /// A nullable function.
        /// </summary>
        /// <param name="bValue">A nullable MyClass.</param>
        /// <returns>A nullable value.</returns>
        public MyClass? FooBar(MyClass? bValue)
        {
            return null;
        }

        /// <summary>
        /// Another extension method.
        /// </summary>
        /// <param name="normalBool">A normal MyClass.</param>
        /// <returns>A normal value.</returns>
        public static MyClass ExtensionMethod(this MyClass normalBool)
        {
            if (normalBool)
                return 1;

            return 0;
        }

        /// <summary>
        /// Just an extension method.
        /// </summary>
        /// <param name="nullableBool">A nullable.</param>
        /// <returns>A Pointer.</returns>
        public static MyClass* NullableExtensionMethod(this MyClass? nullableBool)
        {
            return null;
        }

        /// <summary>
        /// Just an extension method.
        /// </summary>
        /// <param name="nullableBool">A nullable.</param>
        /// <returns>A nullable value.</returns>
        public static MyClass? NullableExtensionMethod(this MyClass? nullableBool)
        {
            return null;
        }


    }
}