// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        Post post1 = new Post();
        post1.title = "Nhiệm vụ đặc biệt 100 ngày' của Binh đoàn Trường Sơn";
        post1.image = "hinh1.png";
        post1.content = "Cuộc gọi giao nhiệm vụ phụ trách xây dựng cho thượng tá Vũ Đình Dũng lúc 0h30 ngày 16/9, chỉ vài tiếng sau khi Lào Cai chốt vị trí tái thiết Làng Nủ.";
        // Console.WriteLine($"bài viết 1: {baiviet1.hinhAnh}, {baiviet1.noiDung}, {baiviet1.tieuDe}");
        post1.displayInfo();
        
        Console.WriteLine("=======================================");
        Post post2 = new Post();
        post2.title = "Chủ tịch nước gặp lãnh đạo Trung Quốc, Mỹ khi dự hội nghị APEC";
        post2.image = "hinh2.png";
        post2.content = "Chủ tịch nước Lương Cường gặp Chủ tịch Trung Quốc, Tổng thống Mỹ cùng lãnh đạo các nền kinh tế bên lề Hội nghị Cấp cao APEC.";
        post2.displayInfo();

        Post post3;
        post3 = post1;
        Console.WriteLine($"kiểm tra: {post3 == post1}");
        post3.image = "hinh3.png";
        Console.WriteLine(post1.image);

        Post post4 = new Post(); // vùng nhớ mới: x234
        post4.image = post1.image;
        post4.content = post1.content;
        post4.title = post1.title;
        Console.WriteLine($"kiểm tra: {post4 == post1}");

        Post post5 = new Post();
        Console.WriteLine($"Giá trị mặc định của thuộc tính noiDung là: {post5.content}");
        // default value của các biến có kiểu dữ liệu là string là null
        // của integer là số 0
        // của boolean là số 0 (0 và 1)
        var studentA = new Student();
        studentA.importInfo();
        studentA.exportInfo();

        Product product = new Product();
        product.readInfo();
        product.displayInfo();
        // E1: create new product oop: product id, product name, price, stock
        // import and export info

        // E2: create new rectangle oop: 
    }
}