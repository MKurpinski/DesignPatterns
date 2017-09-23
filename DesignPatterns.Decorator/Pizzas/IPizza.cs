using System.Collections.Generic;

namespace DesignPatterns.Decorator.Pizzas
{
    public interface IPizza
    {
        decimal Cost { get; set; }
        IList<string> Ingredients { get; set; }
    }
}