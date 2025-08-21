using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class ProjectManager
    {
        /// <summary>
        /// Имя файла с контактами
        /// </summary>
        public static readonly string FileName = "ContactsApp.notes";

        public static readonly string FolderName = "ContactsApp";
        
        /// <summary>
        /// Директория, в которой хранятся контакты
        /// </summary>
        public static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) 
                                             + @"\" + FolderName;

        /// <summary>
        /// Полный путь к файлу с контактами
        /// </summary>
        public static readonly string ProjectFullPath = Path + @"\" + FileName;

        /// <summary>
        /// Загружает проект из файла
        /// </summary>
        /// <returns>Возвращает загруженный или пустой проект</returns>
        /// <exception cref="UnauthorizedAccessException">Ошибка доступа</exception>
        /// <exception cref="JsonReaderException">Файл повреждён</exception>
        /// <exception cref="IOException">Ошибка ввода-вывода</exception>
        /// <exception cref="Exception">Неизвестная ошибка</exception>
        public Project LoadProject()
        {
            try
            {
                if (!File.Exists(ProjectFullPath))
                    CreateProject();
                
                var data = File.ReadAllText(ProjectFullPath, Encoding.UTF8);
                var project = JsonConvert.DeserializeObject<Project>(data);
                return project ?? new Project();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Сохраняет проект в файл
        /// </summary>
        /// <param name="project">Текущий файл проекта</param>
        /// <exception cref="UnauthorizedAccessException">Ошибка доступа</exception>
        /// <exception cref="IOException">Ошибка ввода-вывода</exception>
        /// <exception cref="Exception">Неизвестная ошибка</exception>
        public void SaveProject(Project project)
        {
            try
            {
                var file = new FileInfo(ProjectFullPath);
                file.Directory?.Create();
                var data = JsonConvert.SerializeObject(project);
                File.WriteAllText(ProjectFullPath, data, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Создаёт новый файл проекта
        /// </summary>
        public void CreateProject()
        {
            SaveProject(new Project());
        }

        private ProjectManager()
        {
        }

        private static readonly Lazy<ProjectManager> Singleton =
            new Lazy<ProjectManager>(() => new ProjectManager());

        public static ProjectManager Current => Singleton.Value;
    }
}