/*
ARELY MARTINEZ 
OCT 25, 2022 8:25 PM
ODD OR EVEN END POINT 
THIS PROGRAM WILL MAKE IT SO THAT THE USER 
CAN ENTER A NUMBER. ON POSTMAN IT WILL REPSOND 
WITH A SENTENCE STATING WETHER THE INPUT IS 
ODD OR EVEN.
PEER REVIEW: ANDREW NILSSON -- ALL INPUTS WORK IN POSTMAN AND RETURNS THE PROPER STRING ACCORDING TO THE INPUT BEING ODD OR EVEN.
*/

using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("OddOrEven")]
    public string Math()
    {

        return "ENTER IN A NUMBER AND ILL TELL YOU IF ITS ODD OR EVEN"; 
    }

    [HttpGet]
    [Route("OddOrEven/{number1}")]
    public string Math(string number1)
    {
        int convertNum1 = Convert.ToInt32(number1);

        return convertNum1 % 2 == 0 ? $"You're number of {convertNum1} is even" : $"You're number of {convertNum1} is odd"; 
    }
    
    //return$"This would be my return {var} "
}