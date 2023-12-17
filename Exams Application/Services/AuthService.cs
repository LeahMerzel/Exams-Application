using Exams_Application.Interfaces;

public class AuthService<T>
{
    private readonly IGenericRepository<T> userRepository;
    private readonly IHttpContextAccessor httpContextAccessor;

    public AuthService(IGenericRepository<T> userRepository, IHttpContextAccessor httpContextAccessor)
    {
        this.userRepository = userRepository;
        this.httpContextAccessor = httpContextAccessor;
    }

    public bool Login(string username, string password)
    {
        // Replace this with your actual authentication logic
        T user = userRepository.Find(u => /* Your authentication conditions here */);

        if (user != null)
        {
            // Set authentication-related information in the HttpContext
            // Example: httpContextAccessor.HttpContext.SignInAsync(...)

            return true; // Authentication successful
        }

        return false; // Authentication failed
    }

    public void Logout()
    {
        // Clear authentication-related information
        // Example: httpContextAccessor.HttpContext.SignOutAsync(...)

        // Additional cleanup or logout logic

        // Example: httpContextAccessor.HttpContext.Session.Clear();
    }
}
