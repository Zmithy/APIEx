using APIEx.API.Controls;
using Microsoft.AspNetCore.Mvc;

namespace APIEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiddlerController : ControllerBase
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Riddler Values
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        // GET: api/Riddler
        /// <summary>
        /// Solves 538's Riddler for finding the Riddler Value, the largest number less than its spelled out value if:
        ///  a = 1
        ///  b = 2
        ///  ...
        ///  z = 
        /// </summary>
        /// <returns>Solution (Riddler Value) to 538's Riddler Problem from [I cant find the date :( ]</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { RiddlerControls.RiddlerExpress().ToString() };
        }

        // GET api/Riddler/calculateInt/5
        /// <summary>
        /// Sums the value of a word where letters are assigned values based on their alphabetical position.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Int</returns>
        [HttpGet]
        [Route("calculateInt/{number}")]
        public int CalculateInt(int number)
        {
            return RiddlerControls.NumberToValue(number);
        }

        // GET api/Riddler/calculateString/five
        /// <summary>
        /// Sums the value of a word where letters are assigned values based on their alphabetical position.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Int</returns>
        [HttpGet]
        [Route("calculateString/{number}")]
        public int CalculateString(string number)
        {
            return RiddlerControls.WordValueCalculate(number);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Other Functions
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        // GET api/Riddler/spell/5
        /// <summary>
        /// Sums the value of a word where letters are assigned values based on their alphabetical position.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>String: number spelled out.</returns>
        [HttpGet]
        [Route("spell/{number}")]
        public string spellNumber(int number)
        {
            return RiddlerControls.NumberToWord((int)number).ToString();    
        }





    }
}
