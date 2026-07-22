namespace SeztionParser.Tests.Reader;

[TestClass]
public class SingleLineSectionTests
{
    [TestMethod]
    public void GetFirstLineDecimal_WhenConversionIsValid_ShouldReturnDecimal()
    {
        // Arrange
        var data =
        """
         [section1]
         12.456
        """;
        var sections = new SectionsParser().Parse(data);
        decimal expected = 12.456M;

        // Act
        decimal actual = sections.GetFirstLineDecimal("section1");

        // Assert
        actual.Should().Be(expected);
    }

    [TestMethod]
    public void GetFirstLineDouble_WhenConversionIsValid_ShouldReturnDouble()
    {
        // Arrange
        var data =
        """
         [section1]
         12.456
        """;
        var sections = new SectionsParser().Parse(data);
        double expected = 12.456;

        // Act
        double actual = sections.GetFirstLineDouble("section1");

        // Assert
        actual.Should().Be(expected);
    }

    [TestMethod]
    public void GetFirstLineFloat_WhenConversionIsValid_ShouldReturnFloat()
    {
        // Arrange
        var data =
        """
         [section1]
         12.456
        """;
        var sections = new SectionsParser().Parse(data);
        float expected = 12.456f;

        // Act
        float actual = sections.GetFirstLineFloat("section1");

        // Assert
        actual.Should().Be(expected);
    }

    [TestMethod]
    public void GetFirstLineInt_WhenConversionIsValid_ShouldReturnInt()
    {
        // Arrange
        var data =
        """
         [section1]
         12
        """;
        var sections = new SectionsParser().Parse(data);
        int expected = 12;

        // Act
        int actual = sections.GetFirstLineInt("section1");

        // Assert
        actual.Should().Be(expected);
    }

    [TestMethod]
    public void GetFirstLineLong_WhenConversionIsValid_ShouldReturnLong()
    {
        // Arrange
        var data =
        """
          [section1]
          12
        """;
        var sections = new SectionsParser().Parse(data);
        long expected = 12;

        // Act
        long actual = sections.GetFirstLineLong("section1");

        // Assert
        actual.Should().Be(expected);
    }

    [TestMethod]
    public void GetFirstLineEnum_WhenConversionIsValid_ShouldReturnEnum()
    {
        // Arrange
        var data =
        """
        [section1]
        Alpha
        """;
        var sections = new SectionsParser().Parse(data);
        TestEnum expected = TestEnum.Alpha;

        // Act
        TestEnum actual = sections.GetFirstLineEnum<TestEnum>("section1");

        // Assert
        actual.Should().Be(expected);
    }

    [TestMethod]
    public void GetFirstLineEnum_WhenIgnoreCaseIsTrue_ShouldReturnEnum()
    {
        // Arrange
        var data =
        """
        [section1]
        alpha
        """;
        var sections = new SectionsParser().Parse(data);
        TestEnum expected = TestEnum.Alpha;

        // Act
        TestEnum actual = sections.GetFirstLineEnum<TestEnum>("section1", ignoreCase: true);

        // Assert
        actual.Should().Be(expected);
    }

    [TestMethod]
    public void GetFirstLineEnum_WhenValueIsInvalid_ShouldThrowArgumentException()
    {
        // Arrange
        var data =
        """
        [section1]
        Invalid
        """;
        var sections = new SectionsParser().Parse(data);

        // Act
        Action action = () => sections.GetFirstLineEnum<TestEnum>("section1");

        // Assert
        action.Should().Throw<ArgumentException>();
    }

    private enum TestEnum
    {
        Alpha,
        Beta
    }
}
