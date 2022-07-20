using ola_mundo;
using Xunit;
using FluentAssertions;
using System.IO;
using System;

namespace ola_mundo.Test;

public class OlaMundoTest
{
   [Theory(DisplayName = "Deve exibir Olá, Mundo!")]
   [InlineData("Olá, Mundo!")]
  public void TestOlaMundo(string Expected)
  {
    {

     

      string result =  Hello.OlaMundo();

      result.Should().Be(Expected);
    }
  }
}