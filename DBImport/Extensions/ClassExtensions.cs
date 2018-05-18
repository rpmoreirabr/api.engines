using System;

namespace Api.Engines.Venda.Extensions
{
    public static class ClassExtensions
    {
        public static int Idade(this DateTime desde, DateTime? ate = null)
        {
            if (!ate.HasValue)
                ate = DateTime.UtcNow;

            ate = ate.Value.ToUniversalTime();
            desde = desde.ToUniversalTime();

            var age = ate.Value.Year - desde.Year;

            return desde > ate.Value.AddYears(-age) ? age - 1 : age;
        }
    }
}
