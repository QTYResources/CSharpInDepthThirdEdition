string[] values = { "x", "y", "z" };
var actions = new List<Action>();

foreach (string value in values)
{
    actions.Add(() => Console.WriteLine(value));
}

foreach (Action action in actions)
{
    action();
}