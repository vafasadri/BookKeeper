using System;

namespace BookKeeper
{
    public enum Major
    {
        Bio,
        Math,
        Commerce
    }

    public enum Grade
    {
        Tenth,
        Eleventh,
        Twelveth
    }
    public interface IDataModel
    {
        int Id { get; set; }
    }
    public struct User : IDataModel
    {
        public int Id { get; set; }
        public Major Major { get; set; }
        public Grade Grade { get; set; }
        public string Fullname { get; set; }
        public string FatherName { get; set; }
        public string NationalId { get; set; }
        public string PhoneNumber { get; set; }
        public Hash PFPHash { get; set; }
    }
    public struct Loan : IDataModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
    public struct Delivery
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string UserName { get; set; }
        public string BookName { get; set; }
    }
    public struct Book : IDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public Hash CoverHash { get; set; }
    }
}
