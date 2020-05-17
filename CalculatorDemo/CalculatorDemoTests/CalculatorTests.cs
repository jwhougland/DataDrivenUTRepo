using MVST = Microsoft.VisualStudio.TestTools.UnitTesting;
using CD = CalculatorDemo;
using SYS = System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorDemo.Tests
{
  /// <summary>
  /// This class contains the tests for the
  /// <see cref="CD.Calculator"/> class.
  /// </summary>
  [MVST.TestClass()]
  [SYS.Serializable]
  public class CalculatorTests
  {
    #region Private member objects

    private MVST.TestContext m_testContext;

    #endregion

    #region Public properties

    /// <summary>
    /// Gets and sets the test context that provides information to the unit tests.
    /// </summary>
    public MVST.TestContext TestContext
    {
      get
      {
        return m_testContext;
      }
      set
      {
        m_testContext = value;
      }
    }

    #endregion 

    #region Public test methods

    /// <summary>
    /// This data driven test accepts various sets of input data to ensure
    /// we get the expected sum.
    /// </summary>
    /// <param name="number1">The first number in an addition operation.</param>
    /// <param name="number2">The second number in an addition operation.</param>
    /// <param name="expectedSum">The expected sum.</param>
    [MVST.DataTestMethod]
    [DataRow( 10, 20, 30 )]
    [DataRow( -5, -15, -20 )]
    [DataRow( -8, 15, 7 )]
    public void AdditionTest( double number1, double number2, double expectedSum ) =>    
      MVST.Assert.AreEqual( CD.Calculator.Add( number1, number2 ), expectedSum );

    /// <summary>
    /// This data driven test accepts various sets of input data to ensure
    /// we get the expected difference.
    /// </summary>
    /// <param name="number1">The first number in the subtraction operation.</param>
    /// <param name="number2">The second number in the subtraction operation.</param>
    /// <param name="expectedDifference">The expected difference.</param>
    [MVST.DataTestMethod]
    [DataRow( 30, 20, 10 )]
    [DataRow( -5, -15, 10 )]
    [DataRow( -8, 15, -23 )]
    public void SubtractionTest( double number1, double number2, double expectedDifference ) =>
      MVST.Assert.AreEqual( CD.Calculator.Subtract( number1, number2 ), expectedDifference );

    /// <summary>
    /// This data driven test accepts various sets of input data to ensure
    /// we get the expected product.
    /// </summary>
    /// <param name="number1">The first number in the multiplication operation.</param>
    /// <param name="number2">The second number in the multiplication operation.</param>
    /// <param name="expectedProduct">The expected product.</param>
    [MVST.DataTestMethod]
    [DataRow( 10, 20, 200 )]
    [DataRow( -5, -15, 75 )]
    [DataRow( -8, 15, -120 )]
    public void MultiplicationTest( double number1, double number2, double expectedProduct ) =>
      MVST.Assert.AreEqual( CD.Calculator.Multiply( number1, number2 ), expectedProduct );

    /// <summary>
    /// This data driven test accepts various sets of input data to ensure
    /// we get the expected quotient.
    /// </summary>
    /// <param name="number1">The first number in the division operation.</param>
    /// <param name="number2">The second number in the division operation.</param>
    /// <param name="expectedQuotient">The expected quotient.</param>
    [MVST.DataTestMethod]
    [DataRow( 10.0, 20.0, 0.5 )]
    [DataRow( 20, 10, 2 )]
    [DataRow( -5.0, -15.0, (1.0/3.0) )]
    [DataRow( -40, -10, 4 )]
    [DataRow( 0, 1, 0 )]
    public void DivisionTestHappyPath( double number1, double number2, double expectedQuotient ) =>
      MVST.Assert.AreEqual( CD.Calculator.Divide( number1, number2 ), expectedQuotient );

    /// <summary>
    /// This test verifies that if we attempt to divide by zero that an exception
    /// will be thrown by the Divide method in the <see cref="CD.Calculator"/> class.
    /// </summary>
    /// <param name="number1">Tee first number in the division operation.</param>    
    [MVST.TestMethod()]
    [DataRow( 1 )]
    [DataRow( -1 )]
    public void DivideByZeroCase( double number1 ) =>
      MVST.Assert.ThrowsException<SYS.ArgumentException>( () => CD.Calculator.Divide( number1, 0 ) );    

    #endregion
  }
}