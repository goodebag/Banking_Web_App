using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanking.Rest.Data;
using WebBanking.Rest.Models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;  

namespace WebBanking.Rest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProcessController:ControllerBase
    {
        private readonly IUsersRepo _usersRepo;

        public ProcessController(IUsersRepo usersRepo)
        {
            this._usersRepo = usersRepo;
        }
       
 
        
        [HttpPost]
        public async Task<ActionResult<AcctHolder>> AddUserAsync(AcctHolder user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }
                var returned = await _usersRepo.SaveUsers(user);
                return CreatedAtAction(nameof(GetUserAsync), new { AccountNo = returned.AccountNumber },returned);
            }
            catch (Exception e)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")("+e.InnerException+")");

            }

        }
        [HttpPost]
        public async Task<ActionResult<AirtimeTopUp>> AddAirtimeAsync(AirtimeTopUp Airtime)
        {
            try
            {
                if (Airtime == null)
                {
                    return BadRequest();
                }
                var returned = await _usersRepo.SaveAirtimeTopUps(Airtime);
                return CreatedAtAction(nameof(GetAirtimeTopUp), new { Id = returned.Id }, returned);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")(" + e.InnerException + ")");

            }

        }
        [HttpPost]
        public async Task<ActionResult<CableRecharge>> AddCableRechargeAsync(CableRecharge cableTime)
        {
            try
            {
                if (cableTime == null)
                {
                    return BadRequest();
                }
                var returned = await _usersRepo.SaveCableRecharges(cableTime);
                return CreatedAtAction(nameof(GetCableRecharge), new { Id = returned.Id }, returned);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")(" + e.InnerException + ")");

            }

        }

        [HttpPost]
        public async Task<ActionResult<CashWithdrawal>> AddCashWithdrawalAsync(CashWithdrawal Withdrawal)
        {
            try
            {
                if (Withdrawal == null)
                {
                    return BadRequest();
                }
                var returned = await _usersRepo.SaveCashWithdrawals(Withdrawal);
                return CreatedAtAction(nameof(GetCashWithdrawal), new { Id = returned.Id }, returned);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")(" + e.InnerException + ")");

            }

        }
        [HttpPost]
        public async Task<ActionResult<Transfer>> AddTransferAsync(Transfer Transfer)
        {
            try
            {
                if (Transfer == null)
                {
                    return BadRequest();
                }
                var returned = await _usersRepo.SaveTransfers(Transfer);
                return CreatedAtAction(nameof(GetTransfer), new { Id = returned.Id }, returned);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")(" + e.InnerException + ")");

            }

        }
        [HttpPost]
        public async Task<ActionResult<Transactions>> AddTransactionAsync(Transactions Transaction)
        {
            try
            {
                if (Transaction == null)
                {
                    return BadRequest();
                }
                var returned = await _usersRepo.SaveTransactions(Transaction);
                return CreatedAtAction(nameof(GetTransaction), new { Id = returned.Id }, returned);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")(" + e.InnerException + ")");

            }

        }


        [HttpGet("{AccountNo:int}")]
        public async Task<ActionResult<AcctHolder>> GetUserAsync(Guid IdentityId)
        {
            try
            {
                var result = await _usersRepo.GetAccount(IdentityId);
                if (result == null)
                {
                    return NotFound();
                }
                result.Transactions = (IList<Transactions>)await _usersRepo.GetTransactions(result.AccountNumber);
                return result;
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        public async Task<ActionResult<AcctHolder>> DeleteUserAsync(int Id)
        {
            try
            {
                var result = await _usersRepo.DeleteUsers(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }

        [HttpGet("{AcctNo:int}/{pin:int}")]
        public async Task<bool> ComfirmTransaction(ComfirmationToken token)
        {

            var TrueOrFalse = await _usersRepo.ConfirmTransaction(token.AcctNo, token.pin);
            return TrueOrFalse;
        }
        [HttpGet("{Id:int}")]
        public async Task<ActionResult<AirtimeTopUp>> GetAirtimeTopUp(int Id)
        {
            try
            {
                var result = await _usersRepo.GetAirtimeTopUp(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        [HttpGet("{AcctNo:int}")]
        public async Task<ActionResult <IEnumerable<AirtimeTopUp>>> GetAirtimeTopUpMatch(int AcctNo)
        {
            try
            {
                var result = await _usersRepo.GetAirtimeTopUps(AcctNo);
                if ((result.Equals(null))||(result.Count().Equals(0)))
                {
                    return NotFound();
                }
                return Ok( result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        [HttpGet("{Id:int}")]
        public async Task<ActionResult<CableRecharge>> GetCableRecharge(int Id)
        {
            try
            {
                var result = await _usersRepo.GetCableRecharge(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        [HttpGet("{AcctNo:int}")]
        public async Task<ActionResult<IEnumerable<CableRecharge>>> GetCableRechargeMatch(int AcctNo)
        {
            try
            {
                var result = await _usersRepo.GetCableRecharges(AcctNo);
                if ((result.Equals(null)) || (result.Count().Equals(0)))
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        [HttpGet("{Id:int}")]
        public async Task<ActionResult<CashWithdrawal>> GetCashWithdrawal(int Id)
        {
            try
            {
                var result = await _usersRepo.GetCashWithdrawal(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        [HttpGet("{AcctNo:int}")]
        public async Task<ActionResult<IEnumerable<CashWithdrawal>>> GetCashWithdrawalMatch(int AcctNo)
        {
            try
            {
                var result = await _usersRepo.GetCashWithdrawals(AcctNo);
                if ((result.Equals(null)) || (result.Count().Equals(0)))
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Transactions>> GetTransaction(int Id)
        {
            try
            {
                var result = await _usersRepo.GetTransaction(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        [HttpGet("{AcctNo:int}")]
        public async Task<ActionResult<IEnumerable<Transactions>>> GetTransactionMatch(int AcctNo)
        {
            try
            {
                var result = await _usersRepo.GetTransactions(AcctNo);
                if ((result.Equals(null)) || (result.Count().Equals(0)))
                {
                    return NotFound(result);
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Transfer>> GetTransfer(int Id)
        {
            try
            {
                var result = await _usersRepo.GetTransfer(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
        [HttpGet("{AcctNo:int}")]
        public async Task<ActionResult<IEnumerable<Transfer>>> GetTransferMatch(int AcctNo)
        {
            try
            {
                var result = await _usersRepo.GetTransfers(AcctNo);
                if ((result.Equals(null)) || (result.Count().Equals(0)))
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from our Database  (" + e.Message + ")");

            }
        }
    }

}
