using System.Reflection.Emit;

namespace FluentIL
{
    public static class ILGeneratorExtensions
    {
        public static IFluentILGenerator Fluent(this ILGenerator generator, IILLogger logger = null)
        {
            return new FluentILGenerator(generator, logger);
        }
    }
}
