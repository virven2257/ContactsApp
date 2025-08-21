using System;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private Project _project;
        
        // Путь до файла контактов
        private static readonly string ProjectFile = ProjectManager.ProjectFullPath;
        
        [SetUp]
        public void Init()
        {
            // Бэкап уже существующего файла контактов
            Backup();
            
            _project = new Project();
            
            Contact con1 = new Contact()
            {
                LastName = "Prower",
                FirstName = "Miles",
                DateOfBirth = new DateTime(1992,6,6),
                Email = "tails@e.tusur.ru",
                VkId = "tails",
                PhoneNumber = new PhoneNumber()
            };
            
            Contact con2 = new Contact()
            {
                LastName = "Rebel",
                FirstName = "Jack",
                DateOfBirth = new DateTime(1991, 1, 17),
                Email = "rebel.jack.tv@gmail.com",
                VkId = "rebel_jack",
                PhoneNumber = new PhoneNumber()
            };

            _project.Contacts.Add(con1);
            _project.Contacts.Add(con2);
        }

        [TearDown]
        public void TearDown()
        {
            DeleteTrash();
            Restore();
        }
        
        /// <summary>
        /// Удаление мусора после тестов
        /// </summary>
        private void DeleteTrash()
        {
            if (File.Exists(ProjectFile))
                File.Delete(ProjectFile);
        }

        /// <summary>
        /// Бэкап уже существующего файла контактов
        /// </summary>
        private void Backup()
        {
            if (File.Exists(ProjectFile))
                File.Move(ProjectFile, ProjectFile + ".bak");
        }

        /// <summary>
        /// Восстановление файла контактов после тестов
        /// </summary>
        private void Restore()
        {
            if (File.Exists(ProjectFile + ".bak"))
                File.Move(ProjectFile + ".bak", ProjectFile);
        }
        
        
        [Test(Description = "Попытка загрузить некорректный файл")]
        public void ProjectManagerTest_ReadCorruptedFile()
        {
            Assert.Throws<Exception>(
                () =>
            {
                var text = "Неправильный текст";
                var data = new FileInfo(ProjectFile);
                data.Directory?.Create();
                File.WriteAllText(ProjectFile, text, Encoding.UTF8);
                ProjectManager.Current.LoadProject();
            });
        }

        /// <summary>
        /// Позитивный тест записи и чтения проекта
        /// </summary>
        /// <returns></returns>
        [Test(Description = "Сохранение и загрузка проекта")]
        public void ProjectManagerTest_SaveAndLoad()
        {
            ProjectManager.Current.SaveProject(_project);
            var actual = ProjectManager.Current.LoadProject();
            bool equals = actual.Equals(_project);
            Assert.IsTrue(equals, "Проект отличается от ожидаемого");
        }

        /// <summary>
        /// Позитивный тест записи проекта
        /// </summary>
        /// <returns></returns>
        [Test(Description = "Saving project test")]
        public void ProjectManagerTest_Save()
        {
            ProjectManager.Current.SaveProject(_project);
            var file = File.ReadAllText(ProjectFile);
            var actual = JsonConvert.DeserializeObject<Project>(file);
            Assert.AreEqual(_project, actual, "Данные в файле отличаются от проекта");
        }
        
        /// <summary>
        /// Позитивный тест создания пустого проекта
        /// </summary>
        /// <returns></returns>
        [Test(Description = "Позитивный тест создания пустого проекта")]
        public void ProjectManagerTest_CreateBlankProject()
        {
            ProjectManager.Current.CreateProject();
            var actual = ProjectManager.Current.LoadProject();
            Assert.IsTrue(!actual.Contacts.Any(), "Созданный проект не пуст");
        }
    }    
}
