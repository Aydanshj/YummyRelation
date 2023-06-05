namespace YummyTemplate.Entities
{
    public class Chef
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ChefSocialMedia ChefSocialMedia { get; set; }

        public int ProfessionId { get; set; }

        public Profession Profession { get; set; }

        public string Image { get; set; }
    }
}
