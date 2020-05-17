using SYS = System;

namespace CalculatorDemo
{
  /// <summary>
  /// This class provides a subset of capabilities
  /// expected for a calculator to perform.
  /// </summary>
  [SYS.Serializable]
  public static class Calculator
  {
    #region Main method

    /// <summary>
    /// Starter method for the application.
    /// </summary>
    /// <param name="args">The parameter is not used.</param>
    static void Main( string[] args )
    {     
      // No implementation necessary.  The purpose of this application
      // is to just get some basic experience with the concept
      // of data driven unit testing on a calculator class.  The
      // calculator class will be exercised from a unit testing project.
    }

    #endregion
    
    #region Public static methods

    /// <summary>
    /// This method computes and returns the sum of the two provided numbers.
    /// </summary>
    /// <param name="number1">The first number in addition operation.</param>
    /// <param name="number2">The second number in the addition operation.</param>
    /// <returns>See method summary.</returns>
    public static double Add( double number1, double number2 ) => number1 + number2;

    /// <summary>
    /// This method subtracts the second number from the first number and returns the difference.
    /// </summary>
    /// <param name="number1">The first number in the subtraction operation.</param>
    /// <param name="number2">The second number in the subtraction operation.</param>
    /// <returns>See method summary.</returns>
    public static double Subtract( double number1, double number2 ) => number1 - number2;

    /// <summary>
    /// This method multiples the first and second number provided and returns the product.
    /// </summary>
    /// <param name="number1">The first number in the multiplication operation.</param>
    /// <param name="number2">The second number in the multiplication operation.</param>
    /// <returns>See method summary.</returns>
    public static double Multiply( double number1, double number2 ) => number1 * number2;

    /// <summary>
    /// This method divides the second number from the first and returns the result.
    /// </summary>
    /// <param name="number1">The first number in the division operation.</param>
    /// <param name="number2">The second number in the division operation.</param>
    /// <returns>See method summary.</returns>
    /// <exception cref="SYS.ArgumentException">Thrown if the second number is 0.</exception>
    public static double Divide( double number1, double number2 )
    {
      if ( number2.Equals( 0.0 ) )
      {
        throw new SYS.ArgumentException( "The second number in the division cannot be zero." );
      }
      return number1 / number2;
    }

    #endregion
  }
}
