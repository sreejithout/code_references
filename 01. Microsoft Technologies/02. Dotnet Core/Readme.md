# Fundamentals
- Startup
- Dependency Injection
- Middleware
- Host
- Configuration
- Options
- Environments
- Logging and monitoring
- HttpContext
- Routing
- Handle Errors
- Make HTTP Requests
- Static Files

# APIs
- Overview
  - ControllerBase class
  - Attributes
  - ApiController Attribute
  - Attribute routing requirement
  - Automatice Http 400 responses
  - Binding source parameter inference
  - Multipart/form-data request inference
  - problem details for error status codes
  - Define supported request content types with [Consumes] attribute
- Swagger/ OpenAPI
  - Swagger Middleware
- Action return Types
- Handle JSON Patch requests
- Format response data
- Custom formatters
- Analyzers
- Conventions
- Handle errors

# Web Apps

# Realtime Apps

# Data Access
- Entity Framework 6 with ASP.NET Core
- Azure SQL Database with Azure App Service
- Azure Storage
  - Blob
  - Queue
  - Table

# Security and Identity
- Authentication
- Authorization
- Data Protection
- Secrets Management
- Enforce HTTPS
- Docker compose with HTTPS
- Prevent Cross-Site Request Forgery (XSRF/CSRF) attacks
- Prevent open redirect attacks
- Prevent Cross-Site Scripting(XSS)
- Enable Cross Origin Requests (CORS)
- Share cookies among apps
- Samesite cookies
- IP safelist
- Application security - OWASP

# Host and Deploy

# Performance
- Caching
  - In-memory caching
  - Distributed caching
  - Response caching
- Scaling apps on Azure
- Response compression

# Best Practices
- Cache Aggressively
- Understand Hot code paths
- Avoid blocking calls
- Return large collections across multiple smaller pages
- Return IEnumerable<T> or IAsyncEnumerable<T>
- Minimize large object allocations
- Optimize data access and I/O
  - DbContext pooling
  - Explicitly compiled queries
- Pool Http connections with HttpClientFactory
- Keep common code paths fast
- Complete long running tasks outside of Http requests
- Minify client assets
- Compress responses
- Use the latest ASP.NET Core release
- Minimize exceptions
  - Do not use throwing or catching exceptions as a means of normal program flow, especially in hot code paths.
  - Do include logic in the app to detect and handle conditions that would cause an exception.
  - Do throw or catch exceptions for unusual or unexpected conditions.
- Avoid synchronous read or write on HttpRequest/HttpResponse body
- Prefer ReadFormAsync over Request.form
- Avoid reading large request bodies or response bodies into memory
- Working with a synchronous data processing API
  - ASP.NET Core 3.0 uses System.Text.Json by default for JSON serialization. System.Text.Json:
    - Reads and writes JSON asynchronously.
    - Is optimized for UTF-8 text.
    - Typically is higher performance than Newtonsoft.Json.
- Do not store IHttpContextAccessor.HttpContext in a field
- Do not access HttpContext form multiple threads
- Do not use HttpContext after the request is completed
- Do not capture the HttpContext in background threads
- Do not capture services injected into controllers on background threads
- Do not modify the status code or headers after the response body has started
- Do not call next() if you have already started writing to the response body
- Use In-process hosting with IIS
- Don't assume that HttpRequest.ContentLength is not null
- Reliable Web app patterns
  
# Advanced
- Model Binding
  - Custom model binding
- Model Validation
- Compatibility version
- Write Middleware
- Request and Response operations
- URL rewriting
- file providers
- Request-feature interfaces
- Access HttpContext
- Change Tokens
- Open Web Interface for .NET(OWIN)
- Background tasks with hosted services
- Hosting startup assemblies
- ASP.NET Core in class assemblies
- Metapackages
  - Microsoft.AspNetCore.App
  - Microsoft.AspNetCore.All
- High performance logging
- Use a file watcher
- Factory-based middleware
- Factory-based middleware with third-party container
