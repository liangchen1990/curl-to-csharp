using CurlToCSharp.Extensions;

namespace CurlToCSharp.Models.Parsing;

public class CookieParameterEvaluator : ParameterEvaluator
{
    public CookieParameterEvaluator()
    {
        Keys = new HashSet<string> { "-b", "--cookie" };
    }

    protected override HashSet<string> Keys { get; }

    protected override void EvaluateInner(ref Span<char> commandLine, ConvertResult<CurlOptions> convertResult)
    {
        convertResult.Data.CookieValue = commandLine.ReadValue()
            .ToString();
    }
}
