using System;

namespace DataClassGenerator
{
    public interface ITemplate
    {
         string TransformText() => throw new NotImplementedException();
    }
}