using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Mail.Services;
using Thread_.NET.Common.DTO.Dislike;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly PostService _postService;
        private readonly LikeService _likeService;
        private readonly EmailService _emailService;

        public PostsController(PostService postService, LikeService likeService, EmailService emailService)
        {
            _postService = postService;
            _likeService = likeService;
            _emailService = emailService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<PostDTO>>> Get()
        {
            return Ok(await _postService.GetAllPosts());
        }

        [HttpPost]
        public async Task<ActionResult<PostDTO>> CreatePost([FromBody] PostCreateDTO dto)
        {
            dto.AuthorId = this.GetUserIdFromToken();

            return Ok(await _postService.CreatePost(dto));
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePost([FromBody] PostDTO dto)
        {
            try
            {
                var result = await _postService.UpdatePost(dto);
                if (result > 0)
                    return NoContent();
                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }           
        }
        
        [HttpDelete("{postId:int}")]
        public async Task<ActionResult> DeletePost(int postId)
        {
            var succeed = await _postService.DeletePost(postId);
            if (!succeed) return NotFound();
            return NoContent();
        }

        [HttpPost("like")]
        public async Task<IActionResult> LikePost(NewReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            var succed = await _likeService.LikePost(reaction);

            if (succed)
                await _emailService.SendLikeMessageToEmail(reaction.EntityId, reaction.UserId);

            return Ok();
        }

        [HttpPost("dislike")]
        public async Task<IActionResult> DislikePost(NewNegativeReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _likeService.DislikePost(reaction);
            return Ok();
        }

        [HttpPost("share-post-by-email")]
        public IActionResult SendPostByEmail(SharePostByEmailDTO sharePost)
        {
            this._emailService.SendPostByEmail(sharePost);
            return Ok();
        }
    }
}