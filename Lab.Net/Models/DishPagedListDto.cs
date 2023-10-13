namespace Lab.Net.Models
{
        public class PageInfoModule
        {
            public int size { get; set; }
            public int count { get; set; }
            public int current { get; set; }

        }

        public class DishPagedListDto
        {
            public PageInfoModule pagination { get; set; }
            public List<DishDto> dishes { get; set; }

        }
    
}
