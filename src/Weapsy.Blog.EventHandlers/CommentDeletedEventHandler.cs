using System;
using System.Threading.Tasks;
using Weapsy.Blog.Domain;
using Weapsy.Blog.Domain.Comment.Events;

namespace Weapsy.Blog.EventHandlers
{
	public class CommentDeletedEventHandler : IEventHandler<CommentDeletedEvent>
	{
		public Task Execute(CommentDeletedEvent @event)
		{
			throw new NotImplementedException();
		}
	}
}