using System.Reflection.Emit;

namespace FluentIL
{
    public static class ILGeneratorExtensions
    {
        public static IFluentILGenerator Fluent(this ILGenerator generator)
        {
            return new FluentILGenerator(generator);
        }
    }
}
