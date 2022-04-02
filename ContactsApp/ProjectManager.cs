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
        
        /// <summary>
        /// Директория, в которой хранятся контакты
        /// </summary>
        public static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        /// <summary>
        /// Полный путь к файлу с контактами
        /// </summary>
        public static readonly string ContactsData = Path + @"\" + FileName;

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
                if (!File.Exists(ContactsData))
                    CreateProject();
                
                var data = File.ReadAllText(ContactsData, Encoding.UTF8);
                var project = JsonConvert.DeserializeObject<Project>(data);
                return project;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException("Ошибка доступа");
            }
            catch (JsonReaderException ex)
            {
                throw new JsonReaderException("Файл повреждён");
            }
            catch (IOException ex)
            {
                throw new IOException("Ошибка ввода-вывода");
            }
            catch (Exception ex)
            {
                throw new Exception("Неизвестная ошибка");
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
                var data = JsonConvert.SerializeObject(project);
                File.WriteAllText(ContactsData, data, Encoding.UTF8);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException("Ошибка доступа");
            }
            catch (IOException ex)
            {
                throw new IOException("Ошибка ввода-вывода");
            }
            catch (Exception ex)
            {
                throw new Exception("Неизвестная ошибка");
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