using FluentValidation;
using HomeApi.Contracts.Models.Devices;

namespace HomeApi.Contracts.Validation
{
    public class DeleteDeviceRequestValidator : AbstractValidator<DeleteDeviceRequest>
    {
        public DeleteDeviceRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("Идентификатор устройства должен быть указан.");
        }
    }
}
