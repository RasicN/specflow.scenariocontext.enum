using System;
using System.Globalization;

namespace Specflow.ScenarioContext.Enum
{
    public static class ScenarioContextExtensionsEnum
    {
        public static T Get<T>(this TechTalk.SpecFlow.ScenarioContext context, IConvertible key)
        {
            return context.Get<T>(key.ToString(CultureInfo.InvariantCulture));
        }

        public static void Set(this TechTalk.SpecFlow.ScenarioContext context, object data, IConvertible key)
        {
            context.Set(data, key.ToString(CultureInfo.InvariantCulture));
        }

        public static bool TryGetValue<T>(this TechTalk.SpecFlow.ScenarioContext context, IConvertible key, out T value)
        {
            value = default;
            if (context.TryGetValue<T>(key.ToString(CultureInfo.InvariantCulture), out var x) == false)
            {
                return false;
            }

            value = x;
            return true;
        }

        public static bool ContainsKey(this TechTalk.SpecFlow.ScenarioContext context, IConvertible key)
        {
            return context.ContainsKey(key.ToString(CultureInfo.InvariantCulture));
        }
    }
}
