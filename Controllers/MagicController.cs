//Griffin Parker
//October 27, 2022
//Mini Challenge - Magic 8 Ball - Endpoint
//Peer Review by Andrew Nilsson - Great job getting the output. In the switch statement the breaks are not needed when returning from the cases.

//https://localhost:xxxx/magic/magic8ball   <= Code to run the program. Be sure to replace the 'xxxx' with your local host information

using Microsoft.AspNetCore.Mvc;

namespace ParkerGMagic8BallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MagicController : ControllerBase
{
    [HttpGet]
    [Route("Magic8Ball")]

    public string Magic8Ball()
    {
        Random rndNum = new Random();
        int num = rndNum.Next(0, 9);
        switch (num)
        {
            case 0: return "YEP!";
            case 1: return "This is undoubtedly true."; break;
            case 2: return "Signs point to yes."; break;
            case 3: return "Absolutely not!"; break;
            case 4:return "Nope."; break;
            case 5: return "Nu-uh"; break;
            case 6: return "Try again later"; break;
            case 7: return "It remains undecided"; break;
            case 8: return "????"; break;
            case 9: return "You will die today"; break;
            default: return "this shouldn't be possible to reach..."; break;
        }
        return "Two lines?";
    }
}
