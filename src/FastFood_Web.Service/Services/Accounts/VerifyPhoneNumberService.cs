using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Service.Dto.AccountDto;
using FastFood_Web.Service.Interfaces.Accounts;
using FastFood_Web.Service.Interfaces.Common;
using Microsoft.Extensions.Caching.Memory;

namespace FastFood_Web.Service.Services.Accounts
{
    public class VerifyPhoneNumberService : IVerifyPhoneNumberService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IAuthManager _authManager;
        private readonly IUnitOfWork _unitOfWork;

        public VerifyPhoneNumberService(IMemoryCache memoryCache, IAuthManager authManager, IUnitOfWork unitOfWork)
        {
            _memoryCache = memoryCache;
            _authManager = authManager;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> SendCodeAsync(SendToPhoneNumberDto sendDto)
        {
            //var user = await _unitOfWork.Users.FirstOrDefaultAsync(x => x.PhoneNumber == sendDto.PhoneNumber);

            //if (user is null)
            //{ 
            //    throw new StatusCode
            //}
            return false;
        }


        //        var user = await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumber == sendToPhoneNumberDto.PhoneNumber);
        //            if (user is null) { throw new StatusCodeException(HttpStatusCode.NotFound, "User not found");
        //    }
        //    Random r = new Random();
        //    int code = r.Next(1000, 9999);

        //    _cache.Set(sendToPhoneNumberDto.PhoneNumber, code, TimeSpan.FromMinutes(2));

        //            var client = new RestClient("https://sms.sysdc.ru/index.php");
        //    client.Timeout = -1;
        //            var request = new RestRequest(Method.POST);
        //    request.AlwaysMultipartFormData = true;
        //            request.AddParameter("mobile_phone", sendToPhoneNumberDto.PhoneNumber);
        //            request.AddParameter("message", $"TwistFood Tadiqlash kodi: {code}");
        //            request.AddHeader("Authorization", "Bearer oILdj1OUmUqDZWXanwPIR3vFYVh7kDiDb6fFzIHh2OsBMeCM8eIbsadZCtn1ZgON");
        //            IRestResponse response = client.Execute(request);
        //            if (response.Content.ToString().Substring(11, 5) == "error")
        //            {
        //                throw new StatusCodeException(HttpStatusCode.Forbidden, "We are unable to send messages to this company at this time");
        //}
        //return true;

        public Task<string> VerifyPasswordNumberAsync(VerifyPhoneNumberDto verifyPhoneNumberDto)
        {
            throw new NotImplementedException();
        }
    }
}
