using CodingChallenge2;
using CodingChallenge2.Exceptions;
using CodingChallenge2.Model;
using CodingChallenge2.Repository;
using CodingChallenge2.Service;
ICareerHubService userService = new CareerHubService();

string menu = "\n Press1:: Insert \n Press2::Get Information ";
Console.WriteLine(" Welcome To Our Car Rental System choose from the Below options To continue");
Console.WriteLine(menu);
Console.WriteLine("Enter your choice");
int choice = int.Parse(Console.ReadLine());
Console.Clear();
switch (choice)
{
    case 1:
        string menu1 = "\n Press1:: InsertJobListing \n Press2::InsertJobApplication \n Press3::InsertApplicant \n Press4::InsertCompany";
        Console.WriteLine(menu1);
        Console.WriteLine("Enter your choice");
        int choice1 = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (choice1)
        {
            case 1:
                userService.InsertJobListing();
                break;
            case 2:
                userService.InsertJobApplication();
                break;
            case 3:
                userService.InsertApplicant();
                break;
            case 4:
                userService.InsertCompany();
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
        break;
    case 2:
        string menu2 = "\n Press1:: GetAllJobListing \n Press2::GetAllAppicant \n Press3::GetAllJobApplication \n Press4::GetAllCompany";
        Console.WriteLine(menu2);
        Console.WriteLine("Enter your choice");
        int choice2 = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (choice2)
        {
            case 1:
                userService.GetAllJobListing();
                break;
            case 2:
                userService.GetAllAppicant();
                break;
            case 3:
                userService.GetAllJobApplication();
                break;
            case 4:
                userService.GetAllCompany();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;

}