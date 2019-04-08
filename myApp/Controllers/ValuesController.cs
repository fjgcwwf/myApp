using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace myApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// 这是一个api方法的注释
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 这是一个带参数的get请求
        /// </summary>
        /// <remarks>
        /// 例子:
        /// Get api/Values/1
        /// </remarks>
        /// <param name="id">主键</param>
        /// <returns>测试字符串</returns> 
        /// <response code="201">返回value字符串</response>
        /// <response code="400">如果id为空</response>  
        // GET api/values/2
        [HttpGet("{id}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<object> Get(int id)
        {
            
            return $"你请求的 id 是 {id}";
        }

        // POST api/values
        [HttpPost]
        [AllowAnonymous]
        public object Post([FromBody] BlogArticle blogArticle)
        {
            return Ok(new { success = true, data = blogArticle });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
