﻿using FluentAssertions;
using System;

namespace CSharpFunctionalExtensions.Tests.ResultTests.Extensions
{
    public class BindTryTestsBase : BindTestsBase
    {       

        protected static Result Throwing() => throw new Exception(ErrorMessage);
        protected static Result<T> Throwing_T() => throw new Exception(ErrorMessage);
        protected static UnitResult<E> Throwing_E() => throw new Exception(ErrorMessage);
        protected static Result<T, E> Throwing_T_E() => throw new Exception(ErrorMessage);
        protected static Result<K> Throwing_K() => throw new Exception(ErrorMessage);
        protected static Result<T, K> Throwing_T_K() => throw new Exception(ErrorMessage);
        protected static Result<K, E> Throwing_K_E() => throw new Exception(ErrorMessage);


        protected void AssertFailure(Result result, string message)
        {
            result.IsFailure.Should().BeTrue();
            result.Error.Should().Be(message);
            FuncExecuted.Should().BeFalse();
        }
        protected void AssertFailure(UnitResult<E> result, E errorValue)
        {
            result.IsFailure.Should().BeTrue();
            result.Error.Should().Be(errorValue);
            FuncExecuted.Should().BeFalse();
        }
    }
}
