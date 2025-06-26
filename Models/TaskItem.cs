using System;

namespace SmartTask.Models
{
    public class TaskItem
    {
        public int Id { get; set; }                 // ID unic
        public string Title { get; set; }           // Titlu sarcină
        public string Description { get; set; }     // Descriere detaliată
        public DateTime DueDate { get; set; }       // Data scadentă
        public bool IsCompleted { get; set; }       // Stare sarcină

        // Legătura cu utilizatorul (opțional)
        public int UserId { get; set; }
    }
}
