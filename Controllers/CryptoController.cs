using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CryptoController : ControllerBase
{
    [HttpGet("encrypt")]
    public ActionResult<string> Encrypt(string input)
    {
        // Lägg till din logik för kryptering här
        return "encrypted string";
    }

    [HttpGet("decrypt")]
    public ActionResult<string> Decrypt(string input)
    {
        // Lägg till din logik för avkryptering här
        return "decrypted string";
    }
}
