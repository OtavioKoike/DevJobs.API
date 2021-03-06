namespace DevJobs.API.Entities
{
    public class JobApplication
    {
        // Atalho: ctrl + . e gerar contrutor com atributos selecionados
        public JobApplication(int idApplicant, int idJobVacancy)
        {
            IdApplicant = idApplicant;
            IdJobVacancy = idJobVacancy;
        }

        // Atalho: propg
        public int Id { get; private set; }
        public int IdApplicant { get; private set; }
        public int IdJobVacancy { get; private set; }
        
    }
}