namespace StringInterpolationTemplate.Services;

public class MainService : IMainService
{
    private readonly IStringInterpolationService _stringInterpolationService;

    public MainService(IStringInterpolationService stringInterpolationService)
    {
        _stringInterpolationService = stringInterpolationService;
    }

    public void Invoke()
    {
        _stringInterpolationService.Number01();
        _stringInterpolationService.Number02();
        _stringInterpolationService.Number03();
        _stringInterpolationService.Number04();
        _stringInterpolationService.Number05();
        _stringInterpolationService.Number06();
        _stringInterpolationService.Number07();
        _stringInterpolationService.Number08();
        _stringInterpolationService.Number09();
        _stringInterpolationService.Number10();
        _stringInterpolationService.Number11();
    }
}
