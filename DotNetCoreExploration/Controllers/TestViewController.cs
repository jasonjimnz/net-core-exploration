using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

/**
*   It seems like that every controller should have a class
*   that has inheritance from ControllerBase and I don't have
*   to register in other files
*/
namespace DotNetCoreExploration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestViewController : ControllerBase
    {
        /**
        *   A Reference for a String array, it seems easy but
        *   let's see if serializing objects to JSON objects
        *   will be easy as String array is
        */
        private static readonly string[] TestArray = new[]
        {
            "Hello", "World", "Test array"
        };

        /**
        *   It seems that the logger is neccesary, so I won't 
        *   remove it, for a while xD
        */
        private readonly ILogger<TestViewController> _logger;

        /**
        *   This constructors are really boring when you come from
        *   Python or JavaScript, Low level programming languages ... xD
        */
        public TestViewController(ILogger<TestViewController> logger)
        {
            _logger = logger;
        }

        // GET api/TestView
        [HttpGet]
        public ActionResult<IEnumerable<String>> Get()
        {
            /**
            *   HERE COMES THE ACTION, so if I call to /api/testView
            *   it will return the TestArray variable that I have declared
            *   before.
            */
            return TestArray;
        }
    }
}