using System;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using StringInterpolationTemplate.Services;
using StringInterpolationTemplate.Utils;
using Xunit;

namespace StringInterpolationTemplate.Tests;

public class StringInterpolationServiceTests
{
    private readonly StringInterpolationService _service;

    public StringInterpolationServiceTests()
    {
        Mock<ISystemDate> mockDate = new();
        DateTime testDate = new(2019, 01, 22, 23, 01, 27);

        mockDate.Setup(x => x.Now).Returns(testDate);
        _service = new StringInterpolationService(mockDate.Object, NullLogger<IStringInterpolationService>.Instance);
    }

    [Fact]
    public void StringInterpolationService_Number01_Success()
    {
        var response = _service.Number01();

        Assert.Equal("                        January 22, 2019", response);
    }

    [Fact]
    public void StringInterpolationService_Number02_Success()
    {
        var response = _service.Number02();

        Assert.Equal("2019.01.22", response);
    }

    [Fact]
    public void StringInterpolationService_Number03_Success()
    {
        var response = _service.Number03();

        Assert.Equal("Day 22 of January, 2019", response);
    }

    [Fact]
    public void StringInterpolationService_Number04_Success()
    {
        var response = _service.Number04();

        Assert.Equal("Year: 2019, Month: 01, Day: 22", response);
    }

    [Fact]
    public void StringInterpolationService_Number05_Success()
    {
        var response = _service.Number05();

        Assert.Equal("   Tuesday", response);
    }

    [Fact]
    public void StringInterpolationService_Number06_Success()
    {
        var response = _service.Number06();

        Assert.Equal("  11:01 PM   Tuesday", response);
    }

    [Fact]
    public void StringInterpolationService_Number07_Success()
    {
        var response = _service.Number07();

        Assert.Equal("h:11, m:01, s:27", response);
    }

    [Fact]
    public void StringInterpolationService_Number08_Success()
    {
        var response = _service.Number08();

        Assert.Equal("2019.01.22.11.01.27", response);
    }

    [Fact]
    public void StringInterpolationService_Number09_Success()
    {
        var response = _service.Number09();

        Assert.Equal("$3.14", response);
    }

    [Fact]
    public void StringInterpolationService_Number10_Success()
    {
        var response = _service.Number10();

        Assert.Equal("     3.142", response);
    }

    [Fact]
    public void StringInterpolationService_Number11_Success()
    {
        var response = _service.Number11();

        Assert.Equal("7E7", response);
    }
}
