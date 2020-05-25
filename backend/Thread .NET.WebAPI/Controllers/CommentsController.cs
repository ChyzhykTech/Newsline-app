using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.Common.DTO.Dislike;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly CommentService _commentService;
        private readonly LikeService _likeService;

        public CommentsController(CommentService commentService,
            LikeService likeService)
        {
            _commentService = commentService;
            _likeService = likeService;
        }

        [HttpPost]
        public async Task<ActionResult<CommentDTO>> CreateComment([FromBody] NewCommentDTO comment)
        {
            comment.AuthorId = this.GetUserIdFromToken();
            return Ok(await _commentService.CreateComment(comment));
        }

        [HttpPatch("{commentId:int}")]
        public async Task<ActionResult<CommentDTO>> UpdateComment([FromBody] EditCommentDTO comment)
        {
            return Ok(await _commentService.UpdateComment(comment));
        }

        [HttpDelete("{commentId:int}")]
        public async Task<ActionResult> DeleteComment(int commentId)
        {
            var succeed = await _commentService.DeleteComment(commentId);
            if (!succeed) return NotFound();
            return NoContent();
        }

        [HttpPost("like")]
        public async Task<IActionResult> LikeComment(NewReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _likeService.LikeComment(reaction);
            return Ok();
        }

        [HttpPost("dislike")]
        public async Task<IActionResult> DislikeComment(NewNegativeReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _likeService.DislikeComment(reaction);
            return Ok();
        }
    }
}