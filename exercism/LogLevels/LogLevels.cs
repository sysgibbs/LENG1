static class LogLine
{
    public static string Message(string logLine)
    {

        int posicion = logLine.IndexOf(":");
        return logLine.Substring(posicion + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int inicio = logLine.IndexOf("[");
        int final = logLine.IndexOf("]");

        int cantidad = final - inicio;
        string palabraExtraida = logLine.Substring(inicio, cantidad).ToLower();
        return palabraExtraida;
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} {LogLevel(logLine)}";
    }
}
