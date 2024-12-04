class Post
{
    public string title;
    public string content;
    public string image;

    // default when creating a Post in C# then constructor with default properties
    // public <class name>(){}
    public Post()
    {
        Console.WriteLine("This is constructor of a Post");
    } // constructor

    public Post2(string title, string content, string image)
    {
        this.title = title;
        this.content = content;
        this.image = image;   
    }

    public Post3(Post other)
    {
        this.title = other.title;
        this.content = other.content;
        this.image = other.image;
    }

    public void printInfo()
    {
        Console.WriteLine("Post info:");
        Console.WriteLine($"title: {title}");
        Console.WriteLine($"content: {content}");
        Console.WriteLine($"image: {image}");
    }
}