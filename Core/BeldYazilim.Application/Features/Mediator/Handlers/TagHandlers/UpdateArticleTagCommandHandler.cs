using BeldYazilim.Application.Features.Mediator.Commands.TagCommands;
using BeldYazilim.Application.Interfaces.TagInterfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Features.Mediator.Handlers.TagHandlers
{
    public class UpdateArticleTagCommandHandler : IRequestHandler<UpdateArticleTagCommand>
    {
        private readonly ITagRepository _tagRepository;

        public UpdateArticleTagCommandHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task Handle(UpdateArticleTagCommand request, CancellationToken cancellationToken)
        {
            await _tagRepository.UpdateArticleTags(request.NewArticleId);
        }
    }
}
